Imports System.Data.SQLite

Public Class AccountReview
    Dim connectionString As String = "Data Source = ELibrary.db"
    Dim conn As New SQLiteConnection(connectionString)

    Dim localMemberID As String = Login.memberID

    Private Sub tmrText_Tick(sender As Object, e As EventArgs) Handles tmrText.Tick
        LblWelcome.Text = "Welcom " & Login.MemberName & " To E-library"

        'makes it blink by maing it visble or invisible
        'LblWelcome.Visible = Not (LblWelcome.Visible)

        ' makes it move left to right
        LblWelcome.Left += 10
        If LblWelcome.Left > 1000 Then
            LblWelcome.Left = -100
        End If

        'make it change color
        'Randomize()
        'LblWelcome.ForeColor = Color.FromArgb(Int(Rnd() * 256), Int(Rnd() * 256), Int(Rnd() * 256))

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ListView1.Items.Clear()
        Me.Hide()
        SearchForm.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ListView1.Items.Clear()
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim txtIDR As String
        Dim txtTitle As String
        Dim txtLast As String
        Dim txtCheck As String
        Dim txtReturn As String
        Dim txtPeriod As Integer
        Dim txtDate As Date
        Dim txtDue As String
        Dim LocalMemID As String = Login.memberID

        'clear the list of any data before searching database 
        ListView1.Items.Clear()

        'search database by title and return any data with title, resourceid, last
        Dim FindAccount As String = "SELECT Checkout.CheckoutID, Checkout.CheckOutDate, Checkout.ReturnDate, Resources.Title, Resources.AuthorLast, Resources.CheckOutPeriod FROM Checkout INNER JOIN Resources WHERE Resources.ResourceID=Checkout.ResourceID AND MemberID='" & LocalMemID & "'"

        'open the connection to database 
        conn.Open()
        'declare new sqlite command with the current query and connection
        Dim SQLcmd As New SQLiteCommand(FindAccount, conn)
        'declare sqlite data reader 
        Dim SQLreader As SQLiteDataReader = SQLcmd.ExecuteReader(CommandBehavior.Default)


        'note user that he/she does not have any checked out items
        If SQLreader.Read = False Then
            MessageBox.Show("You don't have any items currently checked out.")
            SQLreader.Close()
            conn.Close()
        Else

            'Declare column
            Dim i As ListViewItem
            'looping sqlreader through all matching records
            Do While SQLreader.Read()
                'convert whatever the reader finds from search into string
                txtIDR = SQLreader("CheckoutID").ToString()
                txtTitle = SQLreader("Title").ToString()
                txtLast = SQLreader("AuthorLast").ToString()
                txtCheck = SQLreader("CheckOutDate").ToString()
                txtReturn = SQLreader("ReturnDate").ToString()
                txtPeriod = CInt(SQLreader("CheckOutPeriod"))
                txtDate = CDate(SQLreader("CheckOutDate"))
                txtDue = (txtDate.AddDays(txtPeriod)).ToString("d")

                'display data from converted strings on listview 
                i = ListView1.Items.Add(txtIDR)
                i.SubItems.Add(txtTitle)
                i.SubItems.Add(txtLast)
                i.SubItems.Add(txtCheck)
                i.SubItems.Add(txtReturn)
                i.SubItems.Add(txtDue)

            Loop
        End If
        SQLreader.Close()
        conn.Close()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click

        If ListView1.Items.Count = 0 Then
            MessageBox.Show("You do not have any books for return.")

        Else
            Dim RToday As String = CStr(Today.Date.ToString("d"))
            If ListView1.SelectedItems.Count = 0 Then
                'input validation
                MessageBox.Show("Please select a book.")
            ElseIf ListView1.SelectedItems(0).SubItems(4).Text = ""
                Dim CheckoutID As String = ListView1.SelectedItems(0).Text
                conn.Open()
                Dim sqlreturn As New SQLiteCommand("UPDATE Checkout SET ReturnDate='" & RToday & "' WHERE CheckoutID='" & CheckoutID & "'", conn)
                sqlreturn.ExecuteNonQuery()
                sqlreturn.Dispose()
                MessageBox.Show("Book returned successfully.")
                ListView1.SelectedItems(0).SubItems(4).Text = Today.Date.ToString("d")
                conn.Close()
            Else MessageBox.Show("You have returned this book.")
            End If
        End If
        ListView1.SelectedItems.Clear()
    End Sub

    Private Sub btnRenew_Click(sender As Object, e As EventArgs) Handles btnRenew.Click

        If ListView1.Items.Count = 0 Then
            MessageBox.Show("You do not have any books for renew.")

        Else
            Dim RToday As String = CStr(Today.Date.ToString("d"))
            If ListView1.SelectedItems.Count = 0 Then
                'input validation
                MessageBox.Show("Please Select a book.")
            Else
                Dim CheckoutID As String = ListView1.SelectedItems(0).Text
                conn.Open()
                Dim sqlCheck As New SQLiteCommand("UPDATE Checkout Set CheckOutDate='" & RToday & "' WHERE CheckoutID='" & CheckoutID & "'", conn)
                sqlCheck.ExecuteNonQuery()
                sqlCheck.Dispose()
                ListView1.SelectedItems(0).SubItems(3).Text = Today.Date.ToString("d")

                'Update renewed Return Date
                Dim sqlreturn As New SQLiteCommand("UPDATE Checkout Set ReturnDate='' WHERE CheckoutID='" & CheckoutID & "'", conn)
                sqlreturn.ExecuteNonQuery()
                sqlreturn.Dispose()
                ListView1.SelectedItems(0).SubItems(4).Text = ""

                MessageBox.Show("Book renewed successfully.")

                'Update renewed Due Date
                Dim txtPeriod As Integer
                Dim txtDate As Date = Today.Date
                Dim txtDue As String


                'declare new sqlite command with query and connection
                Dim SQLcmd As New SQLiteCommand("SELECT Resources.CheckOutPeriod FROM Resources INNER JOIN Checkout WHERE Resources.ResourceID=Checkout.ResourceID AND CheckoutID='" & CheckoutID & "'", conn)
                'declare sqlite data reader 
                Dim SQLreader As SQLiteDataReader = SQLcmd.ExecuteReader(CommandBehavior.Default)

                SQLreader.Read()
                txtPeriod = CInt(SQLreader("CheckOutPeriod"))
                txtDue = (txtDate.AddDays(txtPeriod)).ToString("d")

                ListView1.SelectedItems(0).SubItems(5).Text = txtDue

                SQLreader.Close()
                conn.Close()
            End If
        End If
        ListView1.SelectedItems.Clear()
    End Sub
End Class