Imports System.Data.SqlClient

Module Module1
    Public openform As New Form
    Public con As SqlConnection
    Public cmd As SqlCommand
    Public adapter As New SqlDataAdapter
    Public sqlconn As String = "(local)"
    Public sqldb As String = "evm"
    Public mainclosebutton As New myCloseButton
    Public updid As Integer = 0

    '#### Regular Expression Validation Variable starts here --- 
    Public numericexpression As String = "^[0-9]*$"
    Public alphaexpression As String = "^[a-zA-Z]*$"
    Public alphaspaceexpression As String = "^[a-zA-Z\s]*$"
    Public alphanumericexpression As String = "^[0-9a-zA-Z]*$"
    '#### Regular Expression Validation Variable ends here --- 

    'This function creates a theme for the header, close button, etc.
    Public Sub createtheme(ByVal formname As Form, ByVal formtitle As String)
        Dim formtheme As New FormSkin 'Background skin of the form
        Dim formclose As New FlatClose
        Dim formclosebutton As New myCloseButton 'Close button to close the form
        Dim formminimise As New FlatMini
        Dim formstatusbar As New StatusStrip 'Status bar to display the last update
        openform = formname
        formclosebutton.BaseColor = System.Drawing.Color.FromArgb(192, 0, 0) 'Changing the font colour of the button
        formclosebutton.Size = New Size(43, 31)
        formtheme.Text = formtitle
        With formname
            .Controls.Add(formtheme)
            If .Name <> "frmmain" Then
                .Controls.Add(formclose)
            End If
            .Controls.Add(formstatusbar)
            With formclose
                .Text = "X"
                .Top = 15
                .Size = New Size(25, 25)
                .Left = formname.Width - 45
                formtheme.SendToBack()
                .BaseColor = System.Drawing.Color.FromArgb(192, 0, 0)
                .BringToFront()
            End With
            .ShowInTaskbar = True
            .ShowDialog()
            .Close()
        End With
    End Sub

    Public Sub createcon()
        Dim sqlcon = "Data Source=(local);Initial Catalog=evm;Integrated Security=True"
        con = New SqlConnection(sqlcon)
        Try
            con.Open()
        Catch
            MessageBox.Show("Failed to open the connection")
        End Try
    End Sub

    Public Sub closecon()
        Try
            con.Close()
        Catch ex As Exception
            MsgBox("Failed to close the connection")
        End Try
    End Sub

    Public Sub datagridviewwork(ByVal valdatagridview)
        valdatagridview.Rows.Clear()
        With valdatagridview
            .BorderStyle = BorderStyle.Fixed3D 'Changes the border style
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect 'Selects the row
            .RowHeadersVisible = True 'Sets the visibility of the row header to true
            .RowsDefaultCellStyle.SelectionBackColor = Color.CadetBlue 'Changes the backcolor of the cell to blue
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
            .MultiSelect = False 'Multiple selection of rows is disabled
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeRows = False 'Disables resizing of rows
            .readonly = True 'Disallows users to edit
            .currentcell = Nothing
        End With
    End Sub

    Public Sub chkcourse(ByVal courses)
        Dim dscourse As New DataSet
        Dim sql As String = ""
        createcon()
        sql = "SELECT courseid, coursename FROM course"
        cmd = New SqlCommand(sql, con)
        adapter.SelectCommand = cmd
        adapter.Fill(dscourse)
        With courses
            .datasource = dscourse.Tables(0)
            .valuemember = "courseid"
            .displaymember = "coursename"
            .selectedvalue = -1
        End With
        closecon()
    End Sub

    Public Sub clearcourse(ByVal cmb)
        Dim dscourse As New DataSet
        Dim sql As String = ""
        createcon()
        sql = "SELECT courseid, coursename FROM course WHERE coursename='AAA'"
        cmd = New SqlCommand(sql, con)
        adapter.SelectCommand = cmd
        adapter.Fill(dscourse)
        With cmb
            .datasource = dscourse.Tables(0)
            .valuemember = "courseid"
            .displaymember = "coursename"
            .selectedvalue = -1
        End With
        closecon()
    End Sub

    Public Sub cmbpost(ByVal cmb)
        Dim dspost As New DataSet
        Dim sql As String = ""
        createcon()
        sql = "SELECT (SELECT MIN(postid) FROM post WHERE post.coursegroup=h.coursegroup) AS postid, h.coursegroup + ' - ' + (SELECT TOP 1 postname FROM post WHERE post.coursegroup=h.coursegroup) AS coursegroupcode FROM post AS h GROUP BY h.coursegroup"
        cmd = New SqlCommand(sql, con)
        adapter.SelectCommand = cmd
        adapter.Fill(dspost)
        With cmb
            .datasource = dspost.Tables(0)
            .valuemember = "postid"
            .displaymember = "coursegroupcode"
            .selectedvalue = -1
        End With
        closecon()
    End Sub
End Module


