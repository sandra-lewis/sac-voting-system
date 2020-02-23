<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlogin
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
        Me.FormSkin1 = New College_Voting_System__Admin_.FormSkin()
        Me.FlatLabel4 = New College_Voting_System__Admin_.FlatLabel()
        Me.FlatClose1 = New College_Voting_System__Admin_.FlatClose()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.FlatGroupBox1 = New College_Voting_System__Admin_.FlatGroupBox()
        Me.pwdblogin = New College_Voting_System__Admin_.PasswordBox()
        Me.txtloginid = New College_Voting_System__Admin_.FlatTextBox()
        Me.btnlogin = New College_Voting_System__Admin_.FlatButton()
        Me.FlatLabel3 = New College_Voting_System__Admin_.FlatLabel()
        Me.FlatLabel2 = New College_Voting_System__Admin_.FlatLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormSkin1.SuspendLayout()
        Me.FlatGroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.Teal
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.FlatLabel4)
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Controls.Add(Me.StatusStrip1)
        Me.FormSkin1.Controls.Add(Me.FlatGroupBox1)
        Me.FormSkin1.Controls.Add(Me.PictureBox1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(738, 640)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "ADMIN LOGIN PANEL"
        '
        'FlatLabel4
        '
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Rockwell", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel4.ForeColor = System.Drawing.Color.White
        Me.FlatLabel4.Location = New System.Drawing.Point(118, 238)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New System.Drawing.Size(517, 82)
        Me.FlatLabel4.TabIndex = 6
        Me.FlatLabel4.Text = "St. Agnes College (Autonomous)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Voting System"
        Me.FlatLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlatClose1
        '
        Me.FlatClose1.BackColor = System.Drawing.Color.Transparent
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FlatClose1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatClose1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatClose1.Location = New System.Drawing.Point(673, 12)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Rounded = False
        Me.FlatClose1.Size = New System.Drawing.Size(43, 31)
        Me.FlatClose1.TabIndex = 5
        Me.FlatClose1.Text = "X"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 618)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(738, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'FlatGroupBox1
        '
        Me.FlatGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatGroupBox1.Controls.Add(Me.pwdblogin)
        Me.FlatGroupBox1.Controls.Add(Me.txtloginid)
        Me.FlatGroupBox1.Controls.Add(Me.btnlogin)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel3)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel2)
        Me.FlatGroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox1.Location = New System.Drawing.Point(99, 335)
        Me.FlatGroupBox1.Name = "FlatGroupBox1"
        Me.FlatGroupBox1.ShowText = True
        Me.FlatGroupBox1.Size = New System.Drawing.Size(540, 259)
        Me.FlatGroupBox1.TabIndex = 3
        '
        'pwdblogin
        '
        Me.pwdblogin.BackColor = System.Drawing.Color.Transparent
        Me.pwdblogin.Location = New System.Drawing.Point(236, 119)
        Me.pwdblogin.MaxLength = 32767
        Me.pwdblogin.Multiline = False
        Me.pwdblogin.Name = "pwdblogin"
        Me.pwdblogin.ReadOnly = False
        Me.pwdblogin.Size = New System.Drawing.Size(187, 34)
        Me.pwdblogin.TabIndex = 4
        Me.pwdblogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.pwdblogin.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pwdblogin.UseSystemPasswordChar = False
        '
        'txtloginid
        '
        Me.txtloginid.BackColor = System.Drawing.Color.Transparent
        Me.txtloginid.Location = New System.Drawing.Point(236, 65)
        Me.txtloginid.MaxLength = 32767
        Me.txtloginid.Multiline = False
        Me.txtloginid.Name = "txtloginid"
        Me.txtloginid.ReadOnly = False
        Me.txtloginid.Size = New System.Drawing.Size(187, 34)
        Me.txtloginid.TabIndex = 3
        Me.txtloginid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtloginid.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtloginid.UseSystemPasswordChar = False
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.Transparent
        Me.btnlogin.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogin.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnlogin.Location = New System.Drawing.Point(236, 182)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Rounded = False
        Me.btnlogin.Size = New System.Drawing.Size(135, 40)
        Me.btnlogin.TabIndex = 2
        Me.btnlogin.Text = "Login"
        Me.btnlogin.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel3.ForeColor = System.Drawing.Color.White
        Me.FlatLabel3.Location = New System.Drawing.Point(120, 119)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(93, 28)
        Me.FlatLabel3.TabIndex = 1
        Me.FlatLabel3.Text = "Password"
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel2.ForeColor = System.Drawing.Color.White
        Me.FlatLabel2.Location = New System.Drawing.Point(120, 65)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(85, 28)
        Me.FlatLabel2.TabIndex = 0
        Me.FlatLabel2.Text = "Login ID"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.College_Voting_System__Admin_.My.Resources.Resources.St_Agnes_College_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(307, 87)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(127, 133)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 640)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.FlatGroupBox1.ResumeLayout(False)
        Me.FlatGroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As College_Voting_System__Admin_.FormSkin
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents FlatGroupBox1 As College_Voting_System__Admin_.FlatGroupBox
    Friend WithEvents txtloginid As College_Voting_System__Admin_.FlatTextBox
    Friend WithEvents btnlogin As College_Voting_System__Admin_.FlatButton
    Friend WithEvents FlatLabel3 As College_Voting_System__Admin_.FlatLabel
    Friend WithEvents FlatLabel2 As College_Voting_System__Admin_.FlatLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pwdblogin As College_Voting_System__Admin_.PasswordBox
    Friend WithEvents FlatClose1 As College_Voting_System__Admin_.FlatClose
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents FlatLabel4 As College_Voting_System__Admin_.FlatLabel

End Class
