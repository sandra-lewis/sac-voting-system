<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmimportvoters
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnimportdata = New System.Windows.Forms.Button()
        Me.btnselectfile = New College_Voting_System__Admin_.FlatButton()
        Me.btnexcelformat = New College_Voting_System__Admin_.FlatButton()
        Me.btnupload = New College_Voting_System__Admin_.FlatButton()
        Me.txtimportfile = New System.Windows.Forms.TextBox()
        Me.txtimportfilename = New System.Windows.Forms.TextBox()
        Me.lblcountimport = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(24, 179)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1266, 499)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'btnimportdata
        '
        Me.btnimportdata.Location = New System.Drawing.Point(568, 360)
        Me.btnimportdata.Name = "btnimportdata"
        Me.btnimportdata.Size = New System.Drawing.Size(274, 83)
        Me.btnimportdata.TabIndex = 1
        Me.btnimportdata.Text = "Import Data"
        Me.btnimportdata.UseVisualStyleBackColor = True
        Me.btnimportdata.Visible = False
        '
        'btnselectfile
        '
        Me.btnselectfile.BackColor = System.Drawing.Color.Transparent
        Me.btnselectfile.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnselectfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnselectfile.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnselectfile.Location = New System.Drawing.Point(269, 111)
        Me.btnselectfile.Name = "btnselectfile"
        Me.btnselectfile.Rounded = False
        Me.btnselectfile.Size = New System.Drawing.Size(239, 51)
        Me.btnselectfile.TabIndex = 2
        Me.btnselectfile.Text = "Select Excel File"
        Me.btnselectfile.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnexcelformat
        '
        Me.btnexcelformat.BackColor = System.Drawing.Color.Transparent
        Me.btnexcelformat.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnexcelformat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexcelformat.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnexcelformat.Location = New System.Drawing.Point(24, 111)
        Me.btnexcelformat.Name = "btnexcelformat"
        Me.btnexcelformat.Rounded = False
        Me.btnexcelformat.Size = New System.Drawing.Size(239, 51)
        Me.btnexcelformat.TabIndex = 3
        Me.btnexcelformat.Text = "Excel File Format"
        Me.btnexcelformat.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnupload
        '
        Me.btnupload.BackColor = System.Drawing.Color.Transparent
        Me.btnupload.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnupload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnupload.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnupload.Location = New System.Drawing.Point(1051, 111)
        Me.btnupload.Name = "btnupload"
        Me.btnupload.Rounded = False
        Me.btnupload.Size = New System.Drawing.Size(239, 51)
        Me.btnupload.TabIndex = 4
        Me.btnupload.Text = "Upload File"
        Me.btnupload.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'txtimportfile
        '
        Me.txtimportfile.Location = New System.Drawing.Point(542, 111)
        Me.txtimportfile.Multiline = True
        Me.txtimportfile.Name = "txtimportfile"
        Me.txtimportfile.Size = New System.Drawing.Size(476, 51)
        Me.txtimportfile.TabIndex = 5
        '
        'txtimportfilename
        '
        Me.txtimportfilename.Location = New System.Drawing.Point(156, 35)
        Me.txtimportfilename.Name = "txtimportfilename"
        Me.txtimportfilename.Size = New System.Drawing.Size(171, 22)
        Me.txtimportfilename.TabIndex = 6
        Me.txtimportfilename.Visible = False
        '
        'lblcountimport
        '
        Me.lblcountimport.AutoSize = True
        Me.lblcountimport.Location = New System.Drawing.Point(796, 131)
        Me.lblcountimport.Name = "lblcountimport"
        Me.lblcountimport.Size = New System.Drawing.Size(58, 17)
        Me.lblcountimport.TabIndex = 8
        Me.lblcountimport.Text = "Counter"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmimportvoters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1448, 720)
        Me.Controls.Add(Me.txtimportfilename)
        Me.Controls.Add(Me.txtimportfile)
        Me.Controls.Add(Me.btnupload)
        Me.Controls.Add(Me.btnexcelformat)
        Me.Controls.Add(Me.btnselectfile)
        Me.Controls.Add(Me.btnimportdata)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.lblcountimport)
        Me.Name = "frmimportvoters"
        Me.Text = "frmimportvoters"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents btnimportdata As System.Windows.Forms.Button
    Friend WithEvents btnselectfile As College_Voting_System__Admin_.FlatButton
    Friend WithEvents btnexcelformat As College_Voting_System__Admin_.FlatButton
    Friend WithEvents btnupload As College_Voting_System__Admin_.FlatButton
    Friend WithEvents txtimportfile As System.Windows.Forms.TextBox
    Friend WithEvents txtimportfilename As System.Windows.Forms.TextBox
    Friend WithEvents lblcountimport As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
