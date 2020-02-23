<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmviewadmin
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
        Me.dgvadmin = New System.Windows.Forms.DataGridView()
        Me.btnaddadmin = New College_Voting_System__Admin_.FlatButton()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dgvadmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvadmin
        '
        Me.dgvadmin.AllowUserToAddRows = False
        Me.dgvadmin.AllowUserToDeleteRows = False
        Me.dgvadmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvadmin.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column6, Me.Column7})
        Me.dgvadmin.Location = New System.Drawing.Point(30, 100)
        Me.dgvadmin.Name = "dgvadmin"
        Me.dgvadmin.ReadOnly = True
        Me.dgvadmin.RowTemplate.Height = 24
        Me.dgvadmin.Size = New System.Drawing.Size(799, 413)
        Me.dgvadmin.TabIndex = 0
        '
        'btnaddadmin
        '
        Me.btnaddadmin.BackColor = System.Drawing.Color.Transparent
        Me.btnaddadmin.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnaddadmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnaddadmin.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnaddadmin.Location = New System.Drawing.Point(30, 534)
        Me.btnaddadmin.Name = "btnaddadmin"
        Me.btnaddadmin.Rounded = False
        Me.btnaddadmin.Size = New System.Drawing.Size(126, 36)
        Me.btnaddadmin.TabIndex = 1
        Me.btnaddadmin.Text = "Add"
        Me.btnaddadmin.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Column1
        '
        Me.Column1.HeaderText = "Admin ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "Admin Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 130
        '
        'Column3
        '
        Me.Column3.HeaderText = "Login ID"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Password"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Edit"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Delete"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'frmviewadmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 646)
        Me.Controls.Add(Me.btnaddadmin)
        Me.Controls.Add(Me.dgvadmin)
        Me.Name = "frmviewadmin"
        Me.Text = "frmviewadmin"
        CType(Me.dgvadmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvadmin As System.Windows.Forms.DataGridView
    Friend WithEvents btnaddadmin As College_Voting_System__Admin_.FlatButton
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewButtonColumn
End Class
