<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpost
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
        Me.dgvpost = New System.Windows.Forms.DataGridView()
        Me.btnsubmit = New College_Voting_System__Admin_.FlatButton()
        Me.txtpostname = New College_Voting_System__Admin_.FlatTextBox()
        Me.chkcourselist = New System.Windows.Forms.CheckedListBox()
        Me.FlatLabel2 = New College_Voting_System__Admin_.FlatLabel()
        Me.FlatLabel1 = New College_Voting_System__Admin_.FlatLabel()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlatGroupBox1.SuspendLayout()
        CType(Me.dgvpost, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.FlatGroupBox1.Controls.Add(Me.dgvpost)
        Me.FlatGroupBox1.Controls.Add(Me.btnsubmit)
        Me.FlatGroupBox1.Controls.Add(Me.txtpostname)
        Me.FlatGroupBox1.Controls.Add(Me.chkcourselist)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel2)
        Me.FlatGroupBox1.Controls.Add(Me.FlatLabel1)
        Me.FlatGroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox1.Location = New System.Drawing.Point(38, 78)
        Me.FlatGroupBox1.Name = "FlatGroupBox1"
        Me.FlatGroupBox1.ShowText = True
        Me.FlatGroupBox1.Size = New System.Drawing.Size(749, 630)
        Me.FlatGroupBox1.TabIndex = 0
        '
        'dgvpost
        '
        Me.dgvpost.AllowUserToAddRows = False
        Me.dgvpost.AllowUserToDeleteRows = False
        Me.dgvpost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvpost.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvpost.Location = New System.Drawing.Point(91, 315)
        Me.dgvpost.Name = "dgvpost"
        Me.dgvpost.ReadOnly = True
        Me.dgvpost.RowTemplate.Height = 24
        Me.dgvpost.Size = New System.Drawing.Size(580, 272)
        Me.dgvpost.TabIndex = 6
        '
        'btnsubmit
        '
        Me.btnsubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnsubmit.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnsubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsubmit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnsubmit.Location = New System.Drawing.Point(311, 256)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Rounded = False
        Me.btnsubmit.Size = New System.Drawing.Size(140, 40)
        Me.btnsubmit.TabIndex = 5
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'txtpostname
        '
        Me.txtpostname.BackColor = System.Drawing.Color.Transparent
        Me.txtpostname.Location = New System.Drawing.Point(311, 59)
        Me.txtpostname.MaxLength = 32767
        Me.txtpostname.Multiline = False
        Me.txtpostname.Name = "txtpostname"
        Me.txtpostname.ReadOnly = False
        Me.txtpostname.Size = New System.Drawing.Size(229, 34)
        Me.txtpostname.TabIndex = 4
        Me.txtpostname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtpostname.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtpostname.UseSystemPasswordChar = False
        '
        'chkcourselist
        '
        Me.chkcourselist.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkcourselist.ForeColor = System.Drawing.Color.White
        Me.chkcourselist.FormattingEnabled = True
        Me.chkcourselist.Location = New System.Drawing.Point(311, 108)
        Me.chkcourselist.Name = "chkcourselist"
        Me.chkcourselist.Size = New System.Drawing.Size(229, 129)
        Me.chkcourselist.TabIndex = 3
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel2.ForeColor = System.Drawing.Color.White
        Me.FlatLabel2.Location = New System.Drawing.Point(205, 108)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(63, 23)
        Me.FlatLabel2.TabIndex = 2
        Me.FlatLabel2.Text = "Course"
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(205, 59)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(42, 23)
        Me.FlatLabel1.TabIndex = 1
        Me.FlatLabel1.Text = "Post"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Post ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column3
        '
        Me.Column3.HeaderText = "Post"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Courses"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 160
        '
        'Column5
        '
        Me.Column5.HeaderText = "Delete"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'frmpost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 745)
        Me.Controls.Add(Me.FlatGroupBox1)
        Me.Name = "frmpost"
        Me.Text = "frmpost"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlatGroupBox1.ResumeLayout(False)
        Me.FlatGroupBox1.PerformLayout()
        CType(Me.dgvpost, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlatGroupBox1 As College_Voting_System__Admin_.FlatGroupBox
    Friend WithEvents dgvpost As System.Windows.Forms.DataGridView
    Friend WithEvents btnsubmit As College_Voting_System__Admin_.FlatButton
    Friend WithEvents txtpostname As College_Voting_System__Admin_.FlatTextBox
    Friend WithEvents chkcourselist As System.Windows.Forms.CheckedListBox
    Friend WithEvents FlatLabel2 As College_Voting_System__Admin_.FlatLabel
    Friend WithEvents FlatLabel1 As College_Voting_System__Admin_.FlatLabel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewButtonColumn
End Class
