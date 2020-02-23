<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmain
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.FlatTabControl1 = New College_Voting_System__Admin_.FlatTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvvoters = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnvoterdetails = New College_Voting_System__Admin_.FlatButton()
        Me.btnaddvoter = New College_Voting_System__Admin_.FlatButton()
        Me.btnimportvoters = New College_Voting_System__Admin_.FlatButton()
        Me.btndisplay = New College_Voting_System__Admin_.FlatButton()
        Me.btnsearch = New College_Voting_System__Admin_.FlatButton()
        Me.cmbvotercourse = New College_Voting_System__Admin_.FlatComboBox()
        Me.txtname = New College_Voting_System__Admin_.FlatTextBox()
        Me.txtrno = New College_Voting_System__Admin_.FlatTextBox()
        Me.FlatLabel1 = New College_Voting_System__Admin_.FlatLabel()
        Me.FlatLabel3 = New College_Voting_System__Admin_.FlatLabel()
        Me.FlatLabel2 = New College_Voting_System__Admin_.FlatLabel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnaddcand = New College_Voting_System__Admin_.FlatButton()
        Me.dgvcandidates = New System.Windows.Forms.DataGridView()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lblnoteresults = New College_Voting_System__Admin_.FlatLabel()
        Me.btnclosesession = New College_Voting_System__Admin_.FlatButton()
        Me.dgvresults = New System.Windows.Forms.DataGridView()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnreport = New College_Voting_System__Admin_.FlatButton()
        Me.btndisplayresults = New College_Voting_System__Admin_.FlatButton()
        Me.cmbpostresults = New College_Voting_System__Admin_.FlatComboBox()
        Me.FlatLabel4 = New College_Voting_System__Admin_.FlatLabel()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btnpost = New College_Voting_System__Admin_.FlatButton()
        Me.btncourse = New College_Voting_System__Admin_.FlatButton()
        Me.btnadmin = New College_Voting_System__Admin_.FlatButton()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlatTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvvoters, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvcandidates, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvresults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FlatTabControl1
        '
        Me.FlatTabControl1.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatTabControl1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatTabControl1.Controls.Add(Me.TabPage1)
        Me.FlatTabControl1.Controls.Add(Me.TabPage2)
        Me.FlatTabControl1.Controls.Add(Me.TabPage3)
        Me.FlatTabControl1.Controls.Add(Me.TabPage4)
        Me.FlatTabControl1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatTabControl1.ItemSize = New System.Drawing.Size(180, 50)
        Me.FlatTabControl1.Location = New System.Drawing.Point(12, 65)
        Me.FlatTabControl1.Name = "FlatTabControl1"
        Me.FlatTabControl1.SelectedIndex = 0
        Me.FlatTabControl1.Size = New System.Drawing.Size(1496, 650)
        Me.FlatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FlatTabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.dgvvoters)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 54)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1488, 592)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Voters"
        '
        'dgvvoters
        '
        Me.dgvvoters.AllowUserToAddRows = False
        Me.dgvvoters.AllowUserToDeleteRows = False
        Me.dgvvoters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvvoters.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.dgvvoters.Location = New System.Drawing.Point(21, 173)
        Me.dgvvoters.Name = "dgvvoters"
        Me.dgvvoters.ReadOnly = True
        Me.dgvvoters.RowTemplate.Height = 28
        Me.dgvvoters.Size = New System.Drawing.Size(1444, 401)
        Me.dgvvoters.TabIndex = 11
        '
        'Column1
        '
        Me.Column1.HeaderText = "Voter ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "Register Number"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 300
        '
        'Column4
        '
        Me.Column4.HeaderText = "Course"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 150
        '
        'Column5
        '
        Me.Column5.HeaderText = "Password"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 150
        '
        'Column6
        '
        Me.Column6.HeaderText = "Status"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Edit"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Delete"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnvoterdetails)
        Me.GroupBox1.Controls.Add(Me.btnaddvoter)
        Me.GroupBox1.Controls.Add(Me.btnimportvoters)
        Me.GroupBox1.Controls.Add(Me.btndisplay)
        Me.GroupBox1.Controls.Add(Me.btnsearch)
        Me.GroupBox1.Controls.Add(Me.cmbvotercourse)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.txtrno)
        Me.GroupBox1.Controls.Add(Me.FlatLabel1)
        Me.GroupBox1.Controls.Add(Me.FlatLabel3)
        Me.GroupBox1.Controls.Add(Me.FlatLabel2)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 16)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1444, 128)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'btnvoterdetails
        '
        Me.btnvoterdetails.BackColor = System.Drawing.Color.Transparent
        Me.btnvoterdetails.BaseColor = System.Drawing.Color.LightSeaGreen
        Me.btnvoterdetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnvoterdetails.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnvoterdetails.Location = New System.Drawing.Point(1387, 24)
        Me.btnvoterdetails.Name = "btnvoterdetails"
        Me.btnvoterdetails.Rounded = False
        Me.btnvoterdetails.Size = New System.Drawing.Size(120, 92)
        Me.btnvoterdetails.TabIndex = 12
        Me.btnvoterdetails.Text = "Voters Details"
        Me.btnvoterdetails.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnvoterdetails.Visible = False
        '
        'btnaddvoter
        '
        Me.btnaddvoter.BackColor = System.Drawing.Color.Transparent
        Me.btnaddvoter.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnaddvoter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnaddvoter.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnaddvoter.Location = New System.Drawing.Point(1167, 24)
        Me.btnaddvoter.Name = "btnaddvoter"
        Me.btnaddvoter.Rounded = False
        Me.btnaddvoter.Size = New System.Drawing.Size(191, 43)
        Me.btnaddvoter.TabIndex = 3
        Me.btnaddvoter.Text = "Add Voter"
        Me.btnaddvoter.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnimportvoters
        '
        Me.btnimportvoters.BackColor = System.Drawing.Color.Transparent
        Me.btnimportvoters.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnimportvoters.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnimportvoters.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnimportvoters.Location = New System.Drawing.Point(1167, 71)
        Me.btnimportvoters.Name = "btnimportvoters"
        Me.btnimportvoters.Rounded = False
        Me.btnimportvoters.Size = New System.Drawing.Size(191, 45)
        Me.btnimportvoters.TabIndex = 4
        Me.btnimportvoters.Text = "Import Voters"
        Me.btnimportvoters.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btndisplay
        '
        Me.btndisplay.BackColor = System.Drawing.Color.Transparent
        Me.btndisplay.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btndisplay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndisplay.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btndisplay.Location = New System.Drawing.Point(945, 73)
        Me.btndisplay.Name = "btndisplay"
        Me.btndisplay.Rounded = False
        Me.btndisplay.Size = New System.Drawing.Size(191, 43)
        Me.btndisplay.TabIndex = 10
        Me.btndisplay.Text = "Display All"
        Me.btndisplay.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.Transparent
        Me.btnsearch.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsearch.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnsearch.Location = New System.Drawing.Point(945, 24)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Rounded = False
        Me.btnsearch.Size = New System.Drawing.Size(191, 43)
        Me.btnsearch.TabIndex = 9
        Me.btnsearch.Text = "Search"
        Me.btnsearch.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cmbvotercourse
        '
        Me.cmbvotercourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.cmbvotercourse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbvotercourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbvotercourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbvotercourse.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.cmbvotercourse.ForeColor = System.Drawing.Color.White
        Me.cmbvotercourse.FormattingEnabled = True
        Me.cmbvotercourse.HoverColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cmbvotercourse.ItemHeight = 18
        Me.cmbvotercourse.Location = New System.Drawing.Point(621, 34)
        Me.cmbvotercourse.Name = "cmbvotercourse"
        Me.cmbvotercourse.Size = New System.Drawing.Size(251, 24)
        Me.cmbvotercourse.TabIndex = 8
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.Transparent
        Me.txtname.Location = New System.Drawing.Point(221, 82)
        Me.txtname.MaxLength = 32767
        Me.txtname.Multiline = False
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = False
        Me.txtname.Size = New System.Drawing.Size(264, 34)
        Me.txtname.TabIndex = 7
        Me.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtname.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtname.UseSystemPasswordChar = False
        '
        'txtrno
        '
        Me.txtrno.BackColor = System.Drawing.Color.Transparent
        Me.txtrno.Location = New System.Drawing.Point(221, 31)
        Me.txtrno.MaxLength = 32767
        Me.txtrno.Multiline = False
        Me.txtrno.Name = "txtrno"
        Me.txtrno.ReadOnly = False
        Me.txtrno.Size = New System.Drawing.Size(264, 34)
        Me.txtrno.TabIndex = 6
        Me.txtrno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtrno.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtrno.UseSystemPasswordChar = False
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(59, 31)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(139, 23)
        Me.FlatLabel1.TabIndex = 3
        Me.FlatLabel1.Text = "Register Number"
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel3.ForeColor = System.Drawing.Color.White
        Me.FlatLabel3.Location = New System.Drawing.Point(539, 34)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(63, 23)
        Me.FlatLabel3.TabIndex = 5
        Me.FlatLabel3.Text = "Course"
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel2.ForeColor = System.Drawing.Color.White
        Me.FlatLabel2.Location = New System.Drawing.Point(59, 82)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(56, 23)
        Me.FlatLabel2.TabIndex = 4
        Me.FlatLabel2.Text = "Name"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.btnaddcand)
        Me.TabPage2.Controls.Add(Me.dgvcandidates)
        Me.TabPage2.Location = New System.Drawing.Point(4, 54)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1488, 592)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Candidates"
        '
        'btnaddcand
        '
        Me.btnaddcand.BackColor = System.Drawing.Color.Transparent
        Me.btnaddcand.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnaddcand.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnaddcand.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnaddcand.Location = New System.Drawing.Point(42, 32)
        Me.btnaddcand.Name = "btnaddcand"
        Me.btnaddcand.Rounded = False
        Me.btnaddcand.Size = New System.Drawing.Size(202, 64)
        Me.btnaddcand.TabIndex = 1
        Me.btnaddcand.Text = "Add Candidates"
        Me.btnaddcand.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'dgvcandidates
        '
        Me.dgvcandidates.AllowUserToAddRows = False
        Me.dgvcandidates.AllowUserToDeleteRows = False
        Me.dgvcandidates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcandidates.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column9, Me.Column13, Me.Column10, Me.Column11, Me.Column12, Me.Column15})
        Me.dgvcandidates.Location = New System.Drawing.Point(42, 113)
        Me.dgvcandidates.Name = "dgvcandidates"
        Me.dgvcandidates.ReadOnly = True
        Me.dgvcandidates.RowTemplate.Height = 28
        Me.dgvcandidates.Size = New System.Drawing.Size(1406, 458)
        Me.dgvcandidates.TabIndex = 0
        '
        'Column9
        '
        Me.Column9.HeaderText = "Candidate ID"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Visible = False
        '
        'Column13
        '
        Me.Column13.HeaderText = "Register Number"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Visible = False
        '
        'Column10
        '
        Me.Column10.HeaderText = "Name"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 300
        '
        'Column11
        '
        Me.Column11.HeaderText = "Course"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 150
        '
        'Column12
        '
        Me.Column12.HeaderText = "Post"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 300
        '
        'Column15
        '
        Me.Column15.HeaderText = "Delete"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.lblnoteresults)
        Me.TabPage3.Controls.Add(Me.btnclosesession)
        Me.TabPage3.Controls.Add(Me.dgvresults)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 54)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1488, 592)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Results"
        '
        'lblnoteresults
        '
        Me.lblnoteresults.AutoSize = True
        Me.lblnoteresults.BackColor = System.Drawing.Color.Transparent
        Me.lblnoteresults.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnoteresults.ForeColor = System.Drawing.Color.Turquoise
        Me.lblnoteresults.Location = New System.Drawing.Point(30, 32)
        Me.lblnoteresults.Name = "lblnoteresults"
        Me.lblnoteresults.Size = New System.Drawing.Size(683, 28)
        Me.lblnoteresults.TabIndex = 7
        Me.lblnoteresults.Text = "Note: The results can be viewed only once the voting session is closed."
        Me.lblnoteresults.Visible = False
        '
        'btnclosesession
        '
        Me.btnclosesession.BackColor = System.Drawing.Color.Transparent
        Me.btnclosesession.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnclosesession.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclosesession.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnclosesession.Location = New System.Drawing.Point(1220, 17)
        Me.btnclosesession.Name = "btnclosesession"
        Me.btnclosesession.Rounded = False
        Me.btnclosesession.Size = New System.Drawing.Size(233, 53)
        Me.btnclosesession.TabIndex = 6
        Me.btnclosesession.Text = "Close Voting Session"
        Me.btnclosesession.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnclosesession.Visible = False
        '
        'dgvresults
        '
        Me.dgvresults.AllowUserToAddRows = False
        Me.dgvresults.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvresults.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvresults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvresults.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column19, Me.Column16, Me.Column18, Me.Column14})
        Me.dgvresults.Location = New System.Drawing.Point(35, 221)
        Me.dgvresults.Name = "dgvresults"
        Me.dgvresults.ReadOnly = True
        Me.dgvresults.RowTemplate.Height = 28
        Me.dgvresults.Size = New System.Drawing.Size(1418, 341)
        Me.dgvresults.TabIndex = 5
        '
        'Column19
        '
        Me.Column19.HeaderText = "Candidate ID"
        Me.Column19.Name = "Column19"
        Me.Column19.ReadOnly = True
        Me.Column19.Visible = False
        '
        'Column16
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column16.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column16.HeaderText = "Candidate Name"
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        Me.Column16.Width = 400
        '
        'Column18
        '
        Me.Column18.HeaderText = "Course"
        Me.Column18.Name = "Column18"
        Me.Column18.ReadOnly = True
        Me.Column18.Visible = False
        '
        'Column14
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column14.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column14.HeaderText = "Total Votes"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Width = 300
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnreport)
        Me.GroupBox2.Controls.Add(Me.btndisplayresults)
        Me.GroupBox2.Controls.Add(Me.cmbpostresults)
        Me.GroupBox2.Controls.Add(Me.FlatLabel4)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(35, 77)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1418, 121)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'btnreport
        '
        Me.btnreport.BackColor = System.Drawing.Color.Transparent
        Me.btnreport.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnreport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnreport.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnreport.Location = New System.Drawing.Point(699, 50)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Rounded = False
        Me.btnreport.Size = New System.Drawing.Size(144, 41)
        Me.btnreport.TabIndex = 8
        Me.btnreport.Text = "Report"
        Me.btnreport.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btndisplayresults
        '
        Me.btndisplayresults.BackColor = System.Drawing.Color.Transparent
        Me.btndisplayresults.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btndisplayresults.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndisplayresults.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btndisplayresults.Location = New System.Drawing.Point(534, 50)
        Me.btndisplayresults.Name = "btndisplayresults"
        Me.btndisplayresults.Rounded = False
        Me.btndisplayresults.Size = New System.Drawing.Size(144, 41)
        Me.btndisplayresults.TabIndex = 5
        Me.btndisplayresults.Text = "Display"
        Me.btndisplayresults.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cmbpostresults
        '
        Me.cmbpostresults.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.cmbpostresults.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbpostresults.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbpostresults.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbpostresults.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbpostresults.ForeColor = System.Drawing.Color.White
        Me.cmbpostresults.FormattingEnabled = True
        Me.cmbpostresults.HoverColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cmbpostresults.ItemHeight = 25
        Me.cmbpostresults.Location = New System.Drawing.Point(102, 50)
        Me.cmbpostresults.Name = "cmbpostresults"
        Me.cmbpostresults.Size = New System.Drawing.Size(383, 31)
        Me.cmbpostresults.TabIndex = 5
        '
        'FlatLabel4
        '
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel4.ForeColor = System.Drawing.Color.White
        Me.FlatLabel4.Location = New System.Drawing.Point(31, 50)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New System.Drawing.Size(49, 28)
        Me.FlatLabel4.TabIndex = 5
        Me.FlatLabel4.Text = "Post"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.btnpost)
        Me.TabPage4.Controls.Add(Me.btncourse)
        Me.TabPage4.Controls.Add(Me.btnadmin)
        Me.TabPage4.Location = New System.Drawing.Point(4, 54)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1488, 592)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Settings"
        '
        'btnpost
        '
        Me.btnpost.BackColor = System.Drawing.Color.Transparent
        Me.btnpost.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnpost.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnpost.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpost.Location = New System.Drawing.Point(59, 358)
        Me.btnpost.Name = "btnpost"
        Me.btnpost.Rounded = False
        Me.btnpost.Size = New System.Drawing.Size(315, 128)
        Me.btnpost.TabIndex = 2
        Me.btnpost.Text = "Post"
        Me.btnpost.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btncourse
        '
        Me.btncourse.BackColor = System.Drawing.Color.Transparent
        Me.btncourse.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btncourse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncourse.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncourse.Location = New System.Drawing.Point(59, 202)
        Me.btncourse.Name = "btncourse"
        Me.btncourse.Rounded = False
        Me.btncourse.Size = New System.Drawing.Size(315, 128)
        Me.btncourse.TabIndex = 1
        Me.btncourse.Text = "Course"
        Me.btncourse.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnadmin
        '
        Me.btnadmin.BackColor = System.Drawing.Color.Transparent
        Me.btnadmin.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnadmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnadmin.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadmin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnadmin.Location = New System.Drawing.Point(59, 47)
        Me.btnadmin.Name = "btnadmin"
        Me.btnadmin.Rounded = False
        Me.btnadmin.Size = New System.Drawing.Size(315, 128)
        Me.btnadmin.TabIndex = 0
        Me.btnadmin.Text = "Admin"
        Me.btnadmin.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1520, 751)
        Me.Controls.Add(Me.FlatTabControl1)
        Me.Name = "frmmain"
        Me.Text = "frmmain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlatTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvvoters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvcandidates, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dgvresults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlatTabControl1 As College_Voting_System__Admin_.FlatTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents btnpost As College_Voting_System__Admin_.FlatButton
    Friend WithEvents btncourse As College_Voting_System__Admin_.FlatButton
    Friend WithEvents btnadmin As College_Voting_System__Admin_.FlatButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents FlatLabel1 As College_Voting_System__Admin_.FlatLabel
    Friend WithEvents FlatLabel2 As College_Voting_System__Admin_.FlatLabel
    Friend WithEvents FlatLabel3 As College_Voting_System__Admin_.FlatLabel
    Friend WithEvents txtname As College_Voting_System__Admin_.FlatTextBox
    Friend WithEvents txtrno As College_Voting_System__Admin_.FlatTextBox
    Friend WithEvents cmbvotercourse As College_Voting_System__Admin_.FlatComboBox
    Friend WithEvents btnaddvoter As College_Voting_System__Admin_.FlatButton
    Friend WithEvents btnimportvoters As College_Voting_System__Admin_.FlatButton
    Friend WithEvents btndisplay As College_Voting_System__Admin_.FlatButton
    Friend WithEvents btnsearch As College_Voting_System__Admin_.FlatButton
    Friend WithEvents dgvvoters As System.Windows.Forms.DataGridView
    Friend WithEvents dgvcandidates As System.Windows.Forms.DataGridView
    Friend WithEvents btnaddcand As College_Voting_System__Admin_.FlatButton
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column15 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btndisplayresults As College_Voting_System__Admin_.FlatButton
    Friend WithEvents cmbpostresults As College_Voting_System__Admin_.FlatComboBox
    Friend WithEvents FlatLabel4 As College_Voting_System__Admin_.FlatLabel
    Friend WithEvents dgvresults As System.Windows.Forms.DataGridView
    Friend WithEvents btnclosesession As College_Voting_System__Admin_.FlatButton
    Friend WithEvents lblnoteresults As College_Voting_System__Admin_.FlatLabel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnreport As College_Voting_System__Admin_.FlatButton
    Friend WithEvents Column19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnvoterdetails As College_Voting_System__Admin_.FlatButton
End Class
