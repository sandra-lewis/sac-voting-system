<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmaddvoter
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
        Me.cmbcourse = New College_Voting_System__Admin_.FlatComboBox()
        Me.txtvotername = New College_Voting_System__Admin_.FlatTextBox()
        Me.txtvoterrno = New College_Voting_System__Admin_.FlatTextBox()
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
        Me.FlatGroupBox1.Controls.Add(Me.btnsubmit)
        Me.FlatGroupBox1.Controls.Add(Me.cmbcourse)
        Me.FlatGroupBox1.Controls.Add(Me.txtvotername)
        Me.FlatGroupBox1.Controls.Add(Me.txtvoterrno)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel1)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel2)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel3)
        Me.FlatGroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox1.Location = New System.Drawing.Point(35, 89)
        Me.FlatGroupBox1.Name = "FlatGroupBox1"
        Me.FlatGroupBox1.ShowText = True
        Me.FlatGroupBox1.Size = New System.Drawing.Size(675, 482)
        Me.FlatGroupBox1.TabIndex = 0
        '
        'btnsubmit
        '
        Me.btnsubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnsubmit.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnsubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsubmit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnsubmit.Location = New System.Drawing.Point(309, 361)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Rounded = False
        Me.btnsubmit.Size = New System.Drawing.Size(124, 42)
        Me.btnsubmit.TabIndex = 9
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cmbcourse
        '
        Me.cmbcourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.cmbcourse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbcourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbcourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcourse.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.cmbcourse.ForeColor = System.Drawing.Color.White
        Me.cmbcourse.FormattingEnabled = True
        Me.cmbcourse.HoverColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cmbcourse.ItemHeight = 18
        Me.cmbcourse.Location = New System.Drawing.Point(309, 267)
        Me.cmbcourse.Name = "cmbcourse"
        Me.cmbcourse.Size = New System.Drawing.Size(214, 24)
        Me.cmbcourse.TabIndex = 8
        '
        'txtvotername
        '
        Me.txtvotername.BackColor = System.Drawing.Color.Transparent
        Me.txtvotername.Location = New System.Drawing.Point(309, 171)
        Me.txtvotername.MaxLength = 32767
        Me.txtvotername.Multiline = False
        Me.txtvotername.Name = "txtvotername"
        Me.txtvotername.ReadOnly = False
        Me.txtvotername.Size = New System.Drawing.Size(214, 34)
        Me.txtvotername.TabIndex = 6
        Me.txtvotername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtvotername.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtvotername.UseSystemPasswordChar = False
        '
        'txtvoterrno
        '
        Me.txtvoterrno.BackColor = System.Drawing.Color.Transparent
        Me.txtvoterrno.Location = New System.Drawing.Point(309, 87)
        Me.txtvoterrno.MaxLength = 32767
        Me.txtvoterrno.Multiline = False
        Me.txtvoterrno.Name = "txtvoterrno"
        Me.txtvoterrno.ReadOnly = False
        Me.txtvoterrno.Size = New System.Drawing.Size(214, 34)
        Me.txtvoterrno.TabIndex = 5
        Me.txtvoterrno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtvoterrno.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtvoterrno.UseSystemPasswordChar = False
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(148, 98)
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
        Me.FlatLabel2.Location = New System.Drawing.Point(148, 182)
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
        Me.FlatLabel3.Location = New System.Drawing.Point(148, 266)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(63, 23)
        Me.FlatLabel3.TabIndex = 3
        Me.FlatLabel3.Text = "Course"
        '
        'frmaddvoter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 640)
        Me.Controls.Add(Me.FlatGroupBox1)
        Me.Name = "frmaddvoter"
        Me.Text = "frmaddvoter"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlatGroupBox1.ResumeLayout(False)
        Me.FlatGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlatGroupBox1 As College_Voting_System__Admin_.FlatGroupBox
    Friend WithEvents btnsubmit As College_Voting_System__Admin_.FlatButton
    Friend WithEvents cmbcourse As College_Voting_System__Admin_.FlatComboBox
    Friend WithEvents txtvotername As College_Voting_System__Admin_.FlatTextBox
    Friend WithEvents txtvoterrno As College_Voting_System__Admin_.FlatTextBox
    Friend WithEvents FlatLabel1 As College_Voting_System__Admin_.FlatLabel
    Friend WithEvents FlatLabel2 As College_Voting_System__Admin_.FlatLabel
    Friend WithEvents FlatLabel3 As College_Voting_System__Admin_.FlatLabel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
