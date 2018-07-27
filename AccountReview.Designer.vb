<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountReview
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnRenew = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LblWelcome = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnView = New System.Windows.Forms.Button()
        Me.tmrText = New System.Windows.Forms.Timer(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.CheckID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BookTitle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Alast = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CheckDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ReturnDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DueDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ResID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRenew
        '
        Me.btnRenew.BackColor = System.Drawing.Color.SteelBlue
        Me.btnRenew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRenew.ForeColor = System.Drawing.Color.White
        Me.btnRenew.Location = New System.Drawing.Point(665, 139)
        Me.btnRenew.Name = "btnRenew"
        Me.btnRenew.Size = New System.Drawing.Size(206, 34)
        Me.btnRenew.TabIndex = 28
        Me.btnRenew.Text = "Renew Resource"
        Me.btnRenew.UseVisualStyleBackColor = False
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.SteelBlue
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.Color.White
        Me.btnReturn.Location = New System.Drawing.Point(396, 139)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(197, 34)
        Me.btnReturn.TabIndex = 27
        Me.btnReturn.Text = "Return Resource"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox2.Controls.Add(Me.LblWelcome)
        Me.GroupBox2.Controls.Add(Me.btnLogout)
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(-15, -11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(998, 108)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        '
        'LblWelcome
        '
        Me.LblWelcome.AutoSize = True
        Me.LblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LblWelcome.Location = New System.Drawing.Point(37, 35)
        Me.LblWelcome.Name = "LblWelcome"
        Me.LblWelcome.Size = New System.Drawing.Size(174, 15)
        Me.LblWelcome.TabIndex = 31
        Me.LblWelcome.Text = "Welcom Username to E-library"
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
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnSearch.Location = New System.Drawing.Point(680, 50)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(97, 29)
        Me.btnSearch.TabIndex = 25
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(34, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 31)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "View My Account"
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.SteelBlue
        Me.btnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.Color.White
        Me.btnView.Location = New System.Drawing.Point(123, 139)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(197, 34)
        Me.btnView.TabIndex = 34
        Me.btnView.Text = "View Checked Out"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'tmrText
        '
        Me.tmrText.Enabled = True
        '
        'ListView1
        '
        Me.ListView1.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CheckID, Me.BookTitle, Me.Alast, Me.CheckDate, Me.ReturnDate, Me.DueDate, Me.ResID})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(37, 205)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(904, 291)
        Me.ListView1.TabIndex = 35
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'CheckID
        '
        Me.CheckID.Text = "CheckoutID"
        Me.CheckID.Width = 120
        '
        'BookTitle
        '
        Me.BookTitle.Text = "Title"
        Me.BookTitle.Width = 300
        '
        'Alast
        '
        Me.Alast.Text = "Author Last"
        Me.Alast.Width = 120
        '
        'CheckDate
        '
        Me.CheckDate.Text = "Checkout Date"
        Me.CheckDate.Width = 120
        '
        'ReturnDate
        '
        Me.ReturnDate.Text = "Return Date"
        Me.ReturnDate.Width = 120
        '
        'DueDate
        '
        Me.DueDate.Text = "Due Date"
        Me.DueDate.Width = 120
        '
        'AccountReview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 530)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnRenew)
        Me.Controls.Add(Me.btnReturn)
        Me.Name = "AccountReview"
        Me.Text = "AccountReview"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnRenew As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LblWelcome As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnView As Button
    Friend WithEvents tmrText As Timer
    Friend WithEvents ListView1 As ListView
    Friend WithEvents CheckID As ColumnHeader
    Friend WithEvents BookTitle As ColumnHeader
    Friend WithEvents Alast As ColumnHeader
    Friend WithEvents CheckDate As ColumnHeader
    Friend WithEvents ReturnDate As ColumnHeader
    Friend WithEvents DueDate As ColumnHeader
    Friend WithEvents ResID As ColumnHeader
End Class
