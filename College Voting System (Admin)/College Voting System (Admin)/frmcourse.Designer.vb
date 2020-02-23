<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcourse
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
        Me.FlatGroupBox1 = New College_Voting_System__Admin_.FlatGroupBox()
        Me.FlatLabel1 = New College_Voting_System__Admin_.FlatLabel()
        Me.txtcourse = New College_Voting_System__Admin_.FlatTextBox()
        Me.btnsubmit = New College_Voting_System__Admin_.FlatButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.FlatGroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlatGroupBox1
        '
        Me.FlatGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel1)
        Me.FlatGroupBox1.Controls.Add(Me.txtcourse)
        Me.FlatGroupBox1.Controls.Add(Me.btnsubmit)
        Me.FlatGroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox1.Location = New System.Drawing.Point(38, 83)
        Me.FlatGroupBox1.Name = "FlatGroupBox1"
        Me.FlatGroupBox1.ShowText = True
        Me.FlatGroupBox1.Size = New System.Drawing.Size(619, 324)
        Me.FlatGroupBox1.TabIndex = 0
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(147, 122)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(63, 23)
        Me.FlatLabel1.TabIndex = 1
        Me.FlatLabel1.Text = "Course"
        '
        'txtcourse
        '
        Me.txtcourse.BackColor = System.Drawing.Color.Transparent
        Me.txtcourse.Location = New System.Drawing.Point(243, 111)
        Me.txtcourse.MaxLength = 32767
        Me.txtcourse.Multiline = False
        Me.txtcourse.Name = "txtcourse"
        Me.txtcourse.ReadOnly = False
        Me.txtcourse.Size = New System.Drawing.Size(278, 34)
        Me.txtcourse.TabIndex = 2
        Me.txtcourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtcourse.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtcourse.UseSystemPasswordChar = False
        '
        'btnsubmit
        '
        Me.btnsubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnsubmit.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnsubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsubmit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnsubmit.Location = New System.Drawing.Point(243, 181)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Rounded = False
        Me.btnsubmit.Size = New System.Drawing.Size(152, 39)
        Me.btnsubmit.TabIndex = 3
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmcourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 456)
        Me.Controls.Add(Me.FlatGroupBox1)
        Me.Name = "frmcourse"
        Me.Text = "frmcourse"
        Me.FlatGroupBox1.ResumeLayout(False)
        Me.FlatGroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlatGroupBox1 As College_Voting_System__Admin_.FlatGroupBox
    Friend WithEvents FlatLabel1 As College_Voting_System__Admin_.FlatLabel
    Friend WithEvents txtcourse As College_Voting_System__Admin_.FlatTextBox
    Friend WithEvents btnsubmit As College_Voting_System__Admin_.FlatButton
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
