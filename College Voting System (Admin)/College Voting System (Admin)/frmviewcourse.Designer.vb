<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmviewcourse
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
        Me.dgvcourse = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnaddcourse = New College_Voting_System__Admin_.FlatButton()
        CType(Me.dgvcourse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvcourse
        '
        Me.dgvcourse.AllowUserToAddRows = False
        Me.dgvcourse.AllowUserToDeleteRows = False
        Me.dgvcourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcourse.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgvcourse.Location = New System.Drawing.Point(39, 90)
        Me.dgvcourse.Name = "dgvcourse"
        Me.dgvcourse.ReadOnly = True
        Me.dgvcourse.RowTemplate.Height = 24
        Me.dgvcourse.Size = New System.Drawing.Size(492, 316)
        Me.dgvcourse.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Course ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "Course"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Edit"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Delete"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'btnaddcourse
        '
        Me.btnaddcourse.BackColor = System.Drawing.Color.Transparent
        Me.btnaddcourse.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnaddcourse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnaddcourse.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnaddcourse.Location = New System.Drawing.Point(39, 426)
        Me.btnaddcourse.Name = "btnaddcourse"
        Me.btnaddcourse.Rounded = False
        Me.btnaddcourse.Size = New System.Drawing.Size(125, 42)
        Me.btnaddcourse.TabIndex = 1
        Me.btnaddcourse.Text = "Add"
        Me.btnaddcourse.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'frmviewcourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 515)
        Me.Controls.Add(Me.btnaddcourse)
        Me.Controls.Add(Me.dgvcourse)
        Me.Name = "frmviewcourse"
        Me.Text = "frmviewcourse"
        CType(Me.dgvcourse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvcourse As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents btnaddcourse As College_Voting_System__Admin_.FlatButton
End Class
