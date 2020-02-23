<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcandidate
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
        Me.cmbcandpost = New College_Voting_System__Admin_.FlatComboBox()
        Me.txtcandcourse = New College_Voting_System__Admin_.FlatTextBox()
        Me.txtcandname = New College_Voting_System__Admin_.FlatTextBox()
        Me.txtcandrno = New College_Voting_System__Admin_.FlatTextBox()
        Me.FlatLabel4 = New College_Voting_System__Admin_.FlatLabel()
        Me.btnsubmit = New College_Voting_System__Admin_.FlatButton()
        Me.FlatLabel1 = New College_Voting_System__Admin_.FlatLabel()
        Me.FlatLabel2 = New College_Voting_System__Admin_.FlatLabel()
        Me.FlatLabel3 = New College_Voting_System__Admin_.FlatLabel()
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
        Me.FlatGroupBox1.Controls.Add(Me.cmbcandpost)
        Me.FlatGroupBox1.Controls.Add(Me.txtcandcourse)
        Me.FlatGroupBox1.Controls.Add(Me.txtcandname)
        Me.FlatGroupBox1.Controls.Add(Me.txtcandrno)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel4)
        Me.FlatGroupBox1.Controls.Add(Me.btnsubmit)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel1)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel2)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel3)
        Me.FlatGroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox1.Location = New System.Drawing.Point(38, 78)
        Me.FlatGroupBox1.Name = "FlatGroupBox1"
        Me.FlatGroupBox1.ShowText = True
        Me.FlatGroupBox1.Size = New System.Drawing.Size(714, 492)
        Me.FlatGroupBox1.TabIndex = 0
        '
        'cmbcandpost
        '
        Me.cmbcandpost.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.cmbcandpost.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbcandpost.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbcandpost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcandpost.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.cmbcandpost.ForeColor = System.Drawing.Color.White
        Me.cmbcandpost.FormattingEnabled = True
        Me.cmbcandpost.HoverColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cmbcandpost.ItemHeight = 18
        Me.cmbcandpost.Location = New System.Drawing.Point(271, 295)
        Me.cmbcandpost.Name = "cmbcandpost"
        Me.cmbcandpost.Size = New System.Drawing.Size(317, 24)
        Me.cmbcandpost.TabIndex = 9
        '
        'txtcandcourse
        '
        Me.txtcandcourse.BackColor = System.Drawing.Color.Transparent
        Me.txtcandcourse.Location = New System.Drawing.Point(271, 228)
        Me.txtcandcourse.MaxLength = 32767
        Me.txtcandcourse.Multiline = False
        Me.txtcandcourse.Name = "txtcandcourse"
        Me.txtcandcourse.ReadOnly = True
        Me.txtcandcourse.Size = New System.Drawing.Size(317, 34)
        Me.txtcandcourse.TabIndex = 8
        Me.txtcandcourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtcandcourse.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtcandcourse.UseSystemPasswordChar = False
        '
        'txtcandname
        '
        Me.txtcandname.BackColor = System.Drawing.Color.Transparent
        Me.txtcandname.Location = New System.Drawing.Point(271, 159)
        Me.txtcandname.MaxLength = 32767
        Me.txtcandname.Multiline = False
        Me.txtcandname.Name = "txtcandname"
        Me.txtcandname.ReadOnly = True
        Me.txtcandname.Size = New System.Drawing.Size(317, 34)
        Me.txtcandname.TabIndex = 7
        Me.txtcandname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtcandname.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtcandname.UseSystemPasswordChar = False
        '
        'txtcandrno
        '
        Me.txtcandrno.BackColor = System.Drawing.Color.Transparent
        Me.txtcandrno.Location = New System.Drawing.Point(271, 91)
        Me.txtcandrno.MaxLength = 32767
        Me.txtcandrno.Multiline = False
        Me.txtcandrno.Name = "txtcandrno"
        Me.txtcandrno.ReadOnly = False
        Me.txtcandrno.Size = New System.Drawing.Size(317, 34)
        Me.txtcandrno.TabIndex = 6
        Me.txtcandrno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtcandrno.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtcandrno.UseSystemPasswordChar = False
        '
        'FlatLabel4
        '
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel4.ForeColor = System.Drawing.Color.White
        Me.FlatLabel4.Location = New System.Drawing.Point(105, 296)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New System.Drawing.Size(42, 23)
        Me.FlatLabel4.TabIndex = 5
        Me.FlatLabel4.Text = "Post"
        '
        'btnsubmit
        '
        Me.btnsubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnsubmit.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnsubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsubmit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnsubmit.Location = New System.Drawing.Point(271, 366)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Rounded = False
        Me.btnsubmit.Size = New System.Drawing.Size(196, 47)
        Me.btnsubmit.TabIndex = 4
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(105, 102)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(139, 23)
        Me.FlatLabel1.TabIndex = 1
        Me.FlatLabel1.Text = "Register Number"
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel2.ForeColor = System.Drawing.Color.White
        Me.FlatLabel2.Location = New System.Drawing.Point(105, 170)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(56, 23)
        Me.FlatLabel2.TabIndex = 2
        Me.FlatLabel2.Text = "Name"
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel3.ForeColor = System.Drawing.Color.White
        Me.FlatLabel3.Location = New System.Drawing.Point(105, 228)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(63, 23)
        Me.FlatLabel3.TabIndex = 3
        Me.FlatLabel3.Text = "Course"
        '
        'frmcandidate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 630)
        Me.Controls.Add(Me.FlatGroupBox1)
        Me.Name = "frmcandidate"
        Me.Text = "frmcandidate"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlatGroupBox1.ResumeLayout(False)
        Me.FlatGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlatGroupBox1 As College_Voting_System__Admin_.FlatGroupBox
    Friend WithEvents cmbcandpost As College_Voting_System__Admin_.FlatComboBox
    Friend WithEvents txtcandcourse As College_Voting_System__Admin_.FlatTextBox
    Friend WithEvents txtcandname As College_Voting_System__Admin_.FlatTextBox
    Friend WithEvents txtcandrno As College_Voting_System__Admin_.FlatTextBox
    Friend WithEvents FlatLabel4 As College_Voting_System__Admin_.FlatLabel
    Friend WithEvents btnsubmit As College_Voting_System__Admin_.FlatButton
    Friend WithEvents FlatLabel1 As College_Voting_System__Admin_.FlatLabel
    Friend WithEvents FlatLabel2 As College_Voting_System__Admin_.FlatLabel
    Friend WithEvents FlatLabel3 As College_Voting_System__Admin_.FlatLabel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
