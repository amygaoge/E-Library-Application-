<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SearchForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.CheckoutBtn = New System.Windows.Forms.Button()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnAccount = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbtTitle = New System.Windows.Forms.RadioButton()
        Me.RbtLastName = New System.Windows.Forms.RadioButton()
        Me.SearchTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblWelcome = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ResID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BookTitle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Alast = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tmrText = New System.Windows.Forms.Timer(Me.components)
        Me.CheckPeriod = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ResStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckoutBtn
        '
        Me.CheckoutBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.CheckoutBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckoutBtn.ForeColor = System.Drawing.Color.White
        Me.CheckoutBtn.Location = New System.Drawing.Point(817, 200)
        Me.CheckoutBtn.Name = "CheckoutBtn"
        Me.CheckoutBtn.Size = New System.Drawing.Size(96, 37)
        Me.CheckoutBtn.TabIndex = 29
        Me.CheckoutBtn.Text = "Checkout"
        Me.CheckoutBtn.UseVisualStyleBackColor = False
        '
        'ClearBtn
        '
        Me.ClearBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.ClearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearBtn.ForeColor = System.Drawing.Color.White
        Me.ClearBtn.Location = New System.Drawing.Point(817, 157)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(94, 37)
        Me.ClearBtn.TabIndex = 28
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnLogout.Location = New System.Drawing.Point(789, 50)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(97, 29)
        Me.btnLogout.TabIndex = 26
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnAccount
        '
        Me.btnAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccount.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnAccount.Location = New System.Drawing.Point(680, 50)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(97, 29)
        Me.btnAccount.TabIndex = 25
        Me.btnAccount.Text = "My Account"
        Me.btnAccount.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(352, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 16)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Key word search OK only for TItile"
        '
        'SearchBtn
        '
        Me.SearchBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.SearchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBtn.ForeColor = System.Drawing.Color.White
        Me.SearchBtn.Location = New System.Drawing.Point(817, 115)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(96, 36)
        Me.SearchBtn.TabIndex = 23
        Me.SearchBtn.Text = "Search"
        Me.SearchBtn.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbtTitle)
        Me.GroupBox1.Controls.Add(Me.RbtLastName)
        Me.GroupBox1.Location = New System.Drawing.Point(57, 144)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(227, 80)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a search catagory"
        '
        'RbtTitle
        '
        Me.RbtTitle.AutoSize = True
        Me.RbtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtTitle.Location = New System.Drawing.Point(29, 28)
        Me.RbtTitle.Name = "RbtTitle"
        Me.RbtTitle.Size = New System.Drawing.Size(116, 20)
        Me.RbtTitle.TabIndex = 3
        Me.RbtTitle.Text = "Search by Title"
        Me.RbtTitle.UseVisualStyleBackColor = True
        '
        'RbtLastName
        '
        Me.RbtLastName.AutoSize = True
        Me.RbtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtLastName.Location = New System.Drawing.Point(29, 54)
        Me.RbtLastName.Name = "RbtLastName"
        Me.RbtLastName.Size = New System.Drawing.Size(196, 20)
        Me.RbtLastName.TabIndex = 4
        Me.RbtLastName.Text = "Search by Author Last Name"
        Me.RbtLastName.UseVisualStyleBackColor = True
        '
        'SearchTxt
        '
        Me.SearchTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTxt.ForeColor = System.Drawing.Color.Black
        Me.SearchTxt.Location = New System.Drawing.Point(300, 165)
        Me.SearchTxt.Name = "SearchTxt"
        Me.SearchTxt.Size = New System.Drawing.Size(340, 29)
        Me.SearchTxt.TabIndex = 21
        Me.SearchTxt.Text = "Please type in what you want to search"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(34, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 31)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Search Page"
        '
        'LblWelcome
        '
        Me.LblWelcome.AutoSize = True
        Me.LblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LblWelcome.Location = New System.Drawing.Point(37, 27)
        Me.LblWelcome.Name = "LblWelcome"
        Me.LblWelcome.Size = New System.Drawing.Size(174, 15)
        Me.LblWelcome.TabIndex = 31
        Me.LblWelcome.Text = "Welcom Username to E-library"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox2.Controls.Add(Me.LblWelcome)
        Me.GroupBox2.Controls.Add(Me.btnLogout)
        Me.GroupBox2.Controls.Add(Me.btnAccount)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(-15, -11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(998, 108)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        '
        'ListView1
        '
        Me.ListView1.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ResID, Me.BookTitle, Me.Alast, Me.CheckPeriod, Me.ResStatus})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(58, 265)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(855, 232)
        Me.ListView1.TabIndex = 33
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ResID
        '
        Me.ResID.Text = "ResourceID"
        Me.ResID.Width = 150
        '
        'BookTitle
        '
        Me.BookTitle.Text = "Title"
        Me.BookTitle.Width = 300
        '
        'Alast
        '
        Me.Alast.Text = "Author Last Name"
        Me.Alast.Width = 150
        '
        'tmrText
        '
        Me.tmrText.Enabled = True
        '
        'CheckPeriod
        '
        Me.CheckPeriod.Text = "CheckOut Period"
        Me.CheckPeriod.Width = 150
        '
        'ResStatus
        '
        Me.ResStatus.Text = "Status"
        Me.ResStatus.Width = 100
        '
        'SearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 530)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.CheckoutBtn)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SearchBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SearchTxt)
        Me.Name = "SearchForm"
        Me.Text = "SearchForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckoutBtn As Button
    Friend WithEvents ClearBtn As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnAccount As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents SearchBtn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RbtTitle As RadioButton
    Friend WithEvents RbtLastName As RadioButton
    Friend WithEvents SearchTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblWelcome As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ResID As ColumnHeader
    Friend WithEvents BookTitle As ColumnHeader
    Friend WithEvents Alast As ColumnHeader
    Friend WithEvents tmrText As Timer
    Friend WithEvents CheckPeriod As ColumnHeader
    Friend WithEvents ResStatus As ColumnHeader
End Class
