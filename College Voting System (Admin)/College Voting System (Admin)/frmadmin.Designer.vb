<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmadmin
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
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.FlatGroupBox1 = New College_Voting_System__Admin_.FlatGroupBox()
        Me.btnsubmit = New College_Voting_System__Admin_.FlatButton()
        Me.pwdbconfirm = New College_Voting_System__Admin_.PasswordBox()
        Me.pwdb = New College_Voting_System__Admin_.PasswordBox()
        Me.txtloginid = New College_Voting_System__Admin_.FlatTextBox()
        Me.txtadminname = New College_Voting_System__Admin_.FlatTextBox()
        Me.FlatLabel4 = New College_Voting_System__Admin_.FlatLabel()
        Me.FlatLabel3 = New College_Voting_System__Admin_.FlatLabel()
        Me.FlatLabel2 = New College_Voting_System__Admin_.FlatLabel()
        Me.FlatLabel1 = New College_Voting_System__Admin_.FlatLabel()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlatGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FlatGroupBox1
        '
        Me.FlatGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatGroupBox1.Controls.Add(Me.btnsubmit)
        Me.FlatGroupBox1.Controls.Add(Me.pwdbconfirm)
        Me.FlatGroupBox1.Controls.Add(Me.pwdb)
        Me.FlatGroupBox1.Controls.Add(Me.txtloginid)
        Me.FlatGroupBox1.Controls.Add(Me.txtadminname)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel4)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel3)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel2)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel1)
        Me.FlatGroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox1.Location = New System.Drawing.Point(35, 72)
        Me.FlatGroupBox1.Name = "FlatGroupBox1"
        Me.FlatGroupBox1.ShowText = True
        Me.FlatGroupBox1.Size = New System.Drawing.Size(676, 509)
        Me.FlatGroupBox1.TabIndex = 0
        '
        'btnsubmit
        '
        Me.btnsubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnsubmit.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnsubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsubmit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnsubmit.Location = New System.Drawing.Point(324, 388)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Rounded = False
        Me.btnsubmit.Size = New System.Drawing.Size(143, 40)
        Me.btnsubmit.TabIndex = 1
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'pwdbconfirm
        '
        Me.pwdbconfirm.BackColor = System.Drawing.Color.Transparent
        Me.pwdbconfirm.Location = New System.Drawing.Point(324, 302)
        Me.pwdbconfirm.MaxLength = 32767
        Me.pwdbconfirm.Multiline = False
        Me.pwdbconfirm.Name = "pwdbconfirm"
        Me.pwdbconfirm.ReadOnly = False
        Me.pwdbconfirm.Size = New System.Drawing.Size(210, 34)
        Me.pwdbconfirm.TabIndex = 8
        Me.pwdbconfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.pwdbconfirm.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pwdbconfirm.UseSystemPasswordChar = False
        '
        'pwdb
        '
        Me.pwdb.BackColor = System.Drawing.Color.Transparent
        Me.pwdb.Location = New System.Drawing.Point(324, 236)
        Me.pwdb.MaxLength = 32767
        Me.pwdb.Multiline = False
        Me.pwdb.Name = "pwdb"
        Me.pwdb.ReadOnly = False
        Me.pwdb.Size = New System.Drawing.Size(210, 34)
        Me.pwdb.TabIndex = 7
        Me.pwdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.pwdb.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pwdb.UseSystemPasswordChar = False
        '
        'txtloginid
        '
        Me.txtloginid.BackColor = System.Drawing.Color.Transparent
        Me.txtloginid.Location = New System.Drawing.Point(324, 167)
        Me.txtloginid.MaxLength = 32767
        Me.txtloginid.Multiline = False
        Me.txtloginid.Name = "txtloginid"
        Me.txtloginid.ReadOnly = False
        Me.txtloginid.Size = New System.Drawing.Size(210, 34)
        Me.txtloginid.TabIndex = 6
        Me.txtloginid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtloginid.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtloginid.UseSystemPasswordChar = False
        '
        'txtadminname
        '
        Me.txtadminname.BackColor = System.Drawing.Color.Transparent
        Me.txtadminname.Location = New System.Drawing.Point(324, 100)
        Me.txtadminname.MaxLength = 32767
        Me.txtadminname.Multiline = False
        Me.txtadminname.Name = "txtadminname"
        Me.txtadminname.ReadOnly = False
        Me.txtadminname.Size = New System.Drawing.Size(210, 34)
        Me.txtadminname.TabIndex = 5
        Me.txtadminname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtadminname.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtadminname.UseSystemPasswordChar = False
        '
        'FlatLabel4
        '
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel4.ForeColor = System.Drawing.Color.White
        Me.FlatLabel4.Location = New System.Drawing.Point(137, 313)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New System.Drawing.Size(146, 23)
        Me.FlatLabel4.TabIndex = 3
        Me.FlatLabel4.Text = "Confirm Password"
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel3.ForeColor = System.Drawing.Color.White
        Me.FlatLabel3.Location = New System.Drawing.Point(137, 247)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(80, 23)
        Me.FlatLabel3.TabIndex = 2
        Me.FlatLabel3.Text = "Password"
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel2.ForeColor = System.Drawing.Color.White
        Me.FlatLabel2.Location = New System.Drawing.Point(137, 178)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(74, 23)
        Me.FlatLabel2.TabIndex = 1
        Me.FlatLabel2.Text = "Login ID"
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(137, 111)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(111, 23)
        Me.FlatLabel1.TabIndex = 0
        Me.FlatLabel1.Text = "Admin Name"
        '
        'frmadmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 627)
        Me.Controls.Add(Me.FlatGroupBox1)
        Me.Name = "frmadmin"
        Me.Text = "frmadmin"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlatGroupBox1.ResumeLayout(False)
        Me.FlatGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlatGroupBox1 As College_Voting_System__Admin_.FlatGroupBox
    Friend WithEvents FlatLabel4 As College_Voting_System__Admin_.FlatLabel
    Friend WithEvents FlatLabel3 As College_Voting_System__Admin_.FlatLabel
    Friend WithEvents FlatLabel2 As College_Voting_System__Admin_.FlatLabel
    Friend WithEvents FlatLabel1 As College_Voting_System__Admin_.FlatLabel
    Friend WithEvents txtloginid As College_Voting_System__Admin_.FlatTextBox
    Friend WithEvents txtadminname As College_Voting_System__Admin_.FlatTextBox
    Friend WithEvents pwdbconfirm As College_Voting_System__Admin_.PasswordBox
    Friend WithEvents pwdb As College_Voting_System__Admin_.PasswordBox
    Friend WithEvents btnsubmit As College_Voting_System__Admin_.FlatButton
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
