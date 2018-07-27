Imports System.Data.SQLite

Public Class SearchForm
    Dim connectionString As String = "Data Source = ELibrary.db"
    Dim conn As New SQLiteConnection(connectionString)

    Dim localMemberID As String = Login.memberID

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        Dim txtIDR As String
        Dim txtTitle As String
        Dim txtLast As String
        Dim txtPeriod As String
        Dim txtStatus As String

        'clear the list of any data before searching database 
        ListView1.Items.Clear()

        'search database by title and return any data with title, resourceid, last
        If RbtTitle.Checked = True Then
            Dim FindBookQuery As String = "SELECT ResourceID, Title, AuthorLast, CheckOutPeriod FROM Resources WHERE Title LIKE'%" & SearchTxt.Text & "%'"

            'open the connection to database 
            conn.Open()
            'declare new sqlite command with the current query and connection
            Dim SQLcmd As New SQLiteCommand(FindBookQuery, conn)
            'declare sqlite data reader 
            Dim SQLreader As SQLiteDataReader = SQLcmd.ExecuteReader(CommandBehavior.Default)


            'Data validation
            If SearchTxt.Text = "" Then
                MessageBox.Show("Search empyty, please type In what you want To search")
                SQLreader.Close()
                conn.Close()
            Else

                'Declare column
                Dim i As ListViewItem
                'looping sqlreader through all matching records
                Do While SQLreader.Read()
                    'convert whatever the reader finds from search into string
                    txtIDR = SQLreader("ResourceID").ToString()


                    'Find out if the searched book is still available
                    Dim Status As New SQLiteCommand("Select ReturnDate FROM Checkout WHERE (ResourceID = '" & txtIDR & "' and ReturnDate IS NULL)", conn)
                    Dim Statusreader As SQLiteDataReader = Status.ExecuteReader()
                    If Statusreader.Read() = True Then
                        txtStatus = "Unavailable"
                    Else
                        txtStatus = "Available"
                    End If
                    Statusreader.Close()



                    txtTitle = SQLreader("Title").ToString()
                    txtLast = SQLreader("AuthorLast").ToString()
                    txtPeriod = SQLreader("CheckOutPeriod").ToString()


                    'display data from converted strings on listview 
                    i = ListView1.Items.Add(txtIDR)
                    i.SubItems.Add(txtTitle)
                    i.SubItems.Add(txtLast)
                    i.SubItems.Add(txtPeriod)
                    i.SubItems.Add(txtStatus)

                Loop
                'note user when search a not-existing resource
                If ListView1.Items.Count = 0 Then
                    MessageBox.Show("There are no resources matching your search. Please Try another.")
                End If
            End If
            SQLreader.Close()
            conn.Close()
        ElseIf RbtLastName.Checked = True Then
            Dim FindBookQuery As String = "Select ResourceID, Title, AuthorLast, CheckOutPeriod FROM Resources WHERE AuthorLast LIKE'%" & SearchTxt.Text & "%'"
            'open the connection to database 
            conn.Open()
            'declare new sqlite command with the current query and connection
            Dim SQLcmd As New SQLiteCommand(FindBookQuery, conn)
            'declare sqlite data reader 
            Dim SQLreader As SQLiteDataReader = SQLcmd.ExecuteReader(CommandBehavior.Default)

            'Data validation
            If SearchTxt.Text = "" Then
                MessageBox.Show("Search empyty, please type in what you want to search")
                SQLreader.Close()
                conn.Close()
            Else

                'Declare column
                Dim i As ListViewItem
                'looping sqlreader through all matching records
                Do While SQLreader.Read()
                    'convert whatever the reader finds from search into string
                    txtIDR = SQLreader("ResourceID").ToString()


                    'Find out if the searched book is still available
                    Dim Status As New SQLiteCommand("Select ReturnDate FROM Checkout WHERE (ResourceID = '" & txtIDR & "' and ReturnDate IS NULL)", conn)
                    Dim Statusreader As SQLiteDataReader = Status.ExecuteReader()
                    If Statusreader.Read() = True Then
                        txtStatus = "Unavailable"
                    Else
                        txtStatus = "Available"
                    End If
                    Statusreader.Close()



                    txtTitle = SQLreader("Title").ToString()
                    txtLast = SQLreader("AuthorLast").ToString()
                    txtPeriod = SQLreader("CheckOutPeriod").ToString()


                    'display data from converted strings on listview 
                    i = ListView1.Items.Add(txtIDR)
                    i.SubItems.Add(txtTitle)
                    i.SubItems.Add(txtLast)
                    i.SubItems.Add(txtPeriod)
                    i.SubItems.Add(txtStatus)
                Loop
                'note user when search a not-existing resource
                If ListView1.Items.Count = 0 Then
                    MessageBox.Show("There are no resources matching your search. Please Try another.")
                End If
            End If
            SQLreader.Close()
            conn.Close()
        ElseIf RbtTitle.Checked = False Or RbtLastName.Checked = False Then
            MessageBox.Show("Please Select a search catagory")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        SearchTxt.Clear()
        ListView1.Items.Clear()
        RbtLastName.Checked = False
        RbtTitle.Checked = False
    End Sub

    Private Sub tmrText_Tick(sender As Object, e As EventArgs) Handles tmrText.Tick

        LblWelcome.Text = "Welcom " & Login.MemberName & " To E-library"

        'makes it blink by maing it visble or invisible
        'LblWelcome.Visible = Not (LblWelcome.Visible)

        ' makes it move left to right
        LblWelcome.Left += 10
        If LblWelcome.Left > 650 Then
            LblWelcome.Left = -100
        End If

        'make it change color
        'Randomize()
        'LblWelcome.ForeColor = Color.FromArgb(Int(Rnd() * 256), Int(Rnd() * 256), Int(Rnd() * 256))

    End Sub

    Private Sub SearchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblWelcome.Text = "Welcom " & Login.MemberName & " To E-library"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles CheckoutBtn.Click
        'declare variables        
        Dim resourceID As String
        'declare a local variable to hold the Public memberID declared on the Login Form
        Dim LocalMemID As String = Login.memberID

        '‘Create a random checkoutID and make sure it’s unique
        conn.Open()
        Dim rand As New Random
        Dim checkoutID As String
        Dim counter As Integer = 1
        Do While counter = 1
            checkoutID = CStr(rand.Next(0, 9999))
            Dim UniqueID As New SQLiteCommand("Select * FROM Checkout WHERE (CheckoutID = '" & checkoutID & "')", conn)
            Dim sqlreader As SQLiteDataReader = UniqueID.ExecuteReader()
            If sqlreader.Read() = False Then
                counter = 0
                UniqueID.Dispose()
                'MessageBox.Show("random number is unique. Your random number is: " & checkoutID)
            End If
            sqlreader.Close()
        Loop
        conn.Close()

        'checkoutdate is the current date, converted to a string         
        Dim checkoutdate As String = CStr(Today.Date.ToString("d"))

        If ListView1.SelectedItems.Count = 0 Then
            'input validation
            MessageBox.Show("Please select a book.")

        ElseIf ListView1.SelectedItems.Count > 0 And ListView1.SelectedItems(0).SubItems(4).Text = "Available" Then
            'save the selected row’s (the selected book’s) resourceID into our declared variable
            resourceID = ListView1.SelectedItems(0).Text

            'open our connection to the database and also declare our SQL command
            conn.Open()
            Dim sqlcmd As New SQLiteCommand("INSERT INTO Checkout (CheckoutID, ResourceID, MemberID, CheckOutDate, ReturnDate) VALUES('" & checkoutID & "','" & resourceID & "','" & LocalMemID & "','" & checkoutdate & "',NULL)", conn)
            sqlcmd.ExecuteNonQuery()
            sqlcmd.Dispose()
            MessageBox.Show("Book checked out successfully.")
            ListView1.SelectedItems(0).SubItems(4).Text = "Unavailable"
            conn.Close()

        ElseIf ListView1.SelectedItems(0).SubItems(4).Text = "Unavailable" Then
            MessageBox.Show("This book is Unavailable. Please select another book.")

        Else
        End If
        ListView1.SelectedItems.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        Me.Hide()
        AccountReview.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Login.Show()
    End Sub
End Class