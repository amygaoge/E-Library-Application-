'Import SQLite Library
Imports System.Data.SQLite

Public Class Login
    'Create connection to SQLite database
    Public sqlconn As New SQLiteConnection("Data Source = elibrary.db")

    'Declare variables
    Public memberID As String
    Public MemberName As String
    Dim memberPassword As String

    'Open and Close the data connection
    Public Function Hasconnection() As Boolean
        Try
            sqlconn.Open()
            sqlconn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        'Test if the data connection is OK
        'If Hasconnection() = True Then
        '    MessageBox.Show("Successful connection")
        'Else
        '    MessageBox.Show("Unsuccessful")
        'End If

        'declare new sqlite command with the current query and connection
        Dim sqlcmd1 As New SQLiteCommand("SELECT Email, Password, MemberID, FirstName FROM Member WHERE (Email = '" & EmailTxt.Text & "')", sqlconn)

        'Open connection and SQLiteDataReader
        sqlconn.Open()
        Dim sqlreader As SQLiteDataReader = sqlcmd1.ExecuteReader()

        'Getting values
        If sqlreader.Read() = True Then
            memberID = sqlreader("MemberID").ToString()
            MemberName = sqlreader("FirstName").ToString()
            memberPassword = sqlreader("Password").ToString()
            'MessageBox.Show("Select successful" & "  " & memberID & "  " & MemberName & "  " & memberPassword)

            'Password Check
            If memberPassword = PasswordTxt.Text Then
                MessageBox.Show("Login successful.")
                sqlreader.Close()
                sqlconn.Close()
                PasswordTxt.Clear()
                'Hide Login Form
                Me.Hide()
                'Show Search Form
                SearchForm.Show()
            Else
                MessageBox.Show("Login unsuccessful -Password incorrect.")
            End If

        Else

            'Input validation
            If PasswordTxt.Text = "" Or EmailTxt.Text = "" Then
                MessageBox.Show("Email or Password empyty, please type in Email or Password.")
            Else
                MessageBox.Show("Login unsuccessful - Email incorrect.")
            End If
        End If
        sqlreader.Close()
        sqlconn.Close()

    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        'Clear all the input
        EmailTxt.Clear()
        PasswordTxt.Clear()
    End Sub
End Class
