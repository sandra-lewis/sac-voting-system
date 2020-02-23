Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.OleDb

Public Class frmmain

    Dim rptpostid, rptcourseid As Integer
    Dim valid As String = "true"

    Public Sub validateform()

        valid = "true"
        ErrorProvider1.Clear()

        If cmbpostresults.Text = "" Then
            ErrorProvider1.SetError(cmbpostresults, "Please select the post")
            valid = "false"
        End If

        If valid = "false" Then
            valid = "false"
        Else
            valid = "true"
        End If

    End Sub

    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Controls.Add(mainclosebutton)
        With mainclosebutton
            .Text = "X"
            .Top = 15
            .Size = New Size(25, 25)
            .Left = Me.Width - 45
            .BaseColor = System.Drawing.Color.FromArgb(192, 0, 0)
            .BringToFront()
        End With
        With btnclosesession
            .Left = Me.Width - 250
        End With
        FlatTabControl1.Width = Me.Width - 15
        FlatTabControl1.Height = Me.Height - 75
        loaddgvvoter()
        loaddgvcandidate()
        cmbpost(cmbpostresults)
        GroupBox2.Width = Me.Width - 100
        dgvresults.Width = Me.Width - 100
        dgvresults.Height = Me.Height - 330

        Dim qry As String
        Dim dr As SqlDataReader
        createcon()
        qry = "SELECT TOP 1 status FROM votingresult"
        cmd = New SqlCommand(qry, con)
        dr = cmd.ExecuteReader
        While dr.Read = True
            If dr(0).ToString = "Open" Then
                btnclosesession.Visible = True
                lblnoteresults.Visible = True
            End If
            If dr(0).ToString = "Closed" Then
                GroupBox2.Enabled = True
            End If
        End While
        closecon()  
    End Sub

    Private Sub btnadmin_Click(sender As Object, e As EventArgs) Handles btnadmin.Click
        updid = 0
        createtheme(frmviewadmin, "Admin")
    End Sub

    Private Sub btncourse_Click(sender As Object, e As EventArgs) Handles btncourse.Click
        updid = 0
        createtheme(frmviewcourse, "Course")
    End Sub

    Private Sub btnpost_Click(sender As Object, e As EventArgs) Handles btnpost.Click
        updid = 0
        createtheme(frmpost, "Post")
    End Sub

    Private Sub btnimportvoters_Click(sender As Object, e As EventArgs) Handles btnimportvoters.Click
        createtheme(frmimportvoters, "Import Voters list")
    End Sub

    Private Sub btnaddvoter_Click(sender As Object, e As EventArgs) Handles btnaddvoter.Click
        updid = 0
        createtheme(frmaddvoter, "Add Voter")
    End Sub

    Public Sub loaddgvvoter()
        GroupBox1.Width = Me.Width - 50
        dgvvoters.Width = Me.Width - 50
        dgvvoters.Height = Me.Height - 280
        datagridviewwork(dgvvoters)
        Dim qry As String
        Dim i As Integer
        Dim dr As SqlDataReader
        createcon()
        qry = "SELECT voter.*, course.coursename FROM voter LEFT JOIN course ON voter.courseid=course.courseid"
        If txtrno.Text <> "" Then
            qry = qry & " WHERE voter.regno='" & txtrno.Text & "'"
        End If
        If cmbvotercourse.Text <> "" Then
            qry = qry & " WHERE voter.courseid=" & cmbvotercourse.SelectedValue
            rptcourseid = cmbvotercourse.SelectedValue
            btnvoterdetails.Visible = True
        Else
            rptcourseid = 0
            btnvoterdetails.Visible = False
        End If
        If txtname.Text <> "" Then
            qry = qry & " WHERE voter.votername='" & txtname.Text & "'"
        End If
        cmd = New SqlCommand(qry, con)
        dr = cmd.ExecuteReader
        dgvvoters.Rows.Clear()
        i = 0
        While dr.Read = True
            dgvvoters.Rows.Add()
            dgvvoters.Item(0, i).Value = dr("voterid")
            dgvvoters.Item(1, i).Value = dr("regno").ToString
            dgvvoters.Item(2, i).Value = dr("votername")
            dgvvoters.Item(3, i).Value = dr("coursename")
            dgvvoters.Item(4, i).Value = dr("password")
            dgvvoters.Item(5, i).Value = dr("status")
            dgvvoters.Item(6, i).Value = "Edit"
            dgvvoters.Item(7, i).Value = "Delete"
            i = i + 1
        End While
        closecon()
    End Sub

    Private Sub btndisplay_Click(sender As Object, e As EventArgs) Handles btndisplay.Click
        txtrno.Text = ""
        txtname.Text = ""
        cmbvotercourse.SelectedIndex = -1
        loaddgvvoter()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        loaddgvvoter()
    End Sub

    Private Sub cmbvotercourse_Click(sender As Object, e As EventArgs) Handles cmbvotercourse.Click
        chkcourse(cmbvotercourse)
    End Sub

    Private Sub dgvvoters_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvvoters.CellClick
        If e.ColumnIndex = 6 Then
            updid = dgvvoters.CurrentRow.Cells(0).Value
            createtheme(frmaddvoter, "Update Voter Profile")
        End If
        If e.ColumnIndex = 7 Then
            If MessageBox.Show("Are you sure you want to delete this record?", "Confirm to Delete..", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                createcon()
                Dim query As String
                query = "DELETE FROM voter WHERE voterid=" & dgvvoters.CurrentRow.Cells(0).Value
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Voter Profile deleted successfully...")
                closecon()
                loaddgvvoter()
            End If
        End If
    End Sub

    Private Sub btnaddcand_Click(sender As Object, e As EventArgs) Handles btnaddcand.Click
        createtheme(frmcandidate, "Add Candidate")
    End Sub

    Public Sub loaddgvcandidate()
        dgvcandidates.Width = Me.Width - 90
        dgvcandidates.Height = Me.Height - 250
        datagridviewwork(dgvcandidates)
        Dim qry As String
        Dim i As Integer
        Dim dr As SqlDataReader
        createcon()
        qry = "SELECT candidate.candidateid, voter.regno, voter.votername, course.coursename FROM candidate LEFT JOIN voter ON candidate.voterid=voter.voterid LEFT JOIN course ON voter.courseid=course.courseid"
        cmd = New SqlCommand(qry, con)
        dr = cmd.ExecuteReader
        dgvcandidates.Rows.Clear()
        i = 0
        While dr.Read = True
            dgvcandidates.Rows.Add()
            dgvcandidates.Item(0, i).Value = dr(0)
            dgvcandidates.Item(1, i).Value = dr(1).ToString
            dgvcandidates.Item(2, i).Value = dr(2)
            dgvcandidates.Item(3, i).Value = dr(3)
            dgvcandidates.Item(5, i).Value = "Delete"
            i = i + 1
        End While
        closecon()

        Dim index As Integer = 0
        For index = 0 To dgvcandidates.Rows.Count - 1
            createcon()
            qry = "SELECT post.postname + ' - ' + post.coursegroup AS posttype FROM post INNER JOIN candidate ON post.postid=candidate.postid WHERE candidateid='" & dgvcandidates.Item(0, index).Value & "'"
            cmd = New SqlCommand(qry, con)
            dr = cmd.ExecuteReader
            While dr.Read = True
                dgvcandidates.Item(4, index).Value = dr("posttype")
            End While
            closecon()
        Next
    End Sub

    Private Sub dgvcandidates_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcandidates.CellClick
        If e.ColumnIndex = 5 Then
            If MessageBox.Show("Are you sure you want to delete this record?", "Confirm to Delete..", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                createcon()
                Dim query As String
                query = "DELETE FROM candidate WHERE candidateid=" & dgvcandidates.CurrentRow.Cells(0).Value
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Candidate details deleted successfully...")
                closecon()
                loaddgvcandidate()
            End If
        End If
    End Sub

    Private Sub btnclosesession_Click(sender As Object, e As EventArgs) Handles btnclosesession.Click
        Dim query As String
        If MessageBox.Show("Do you want to close the voting session?", "Close Voting Session", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            createcon()
            query = "UPDATE voter SET status='Inactive'"
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            closecon()

            createcon()
            query = "UPDATE votingresult SET status='Closed'"
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("The voting session was closed successfully...", "Voting System")
            closecon()

            GroupBox2.Enabled = True
            btnclosesession.Visible = False
            lblnoteresults.Visible = False
        End If
    End Sub

    Private Sub btndisplayresults_Click(sender As Object, e As EventArgs) Handles btndisplayresults.Click
        validateform()
        If valid = "true" Then
            loaddgvresults()
        End If
    End Sub

    Public Sub loaddgvresults()
        datagridviewwork(dgvresults)
        Dim qry As String
        Dim i As Integer
        Dim dr As SqlDataReader
        createcon()
        qry = "SELECT candidate.candidateid, voter.votername, course.coursename, (SELECT COUNT(totalvotes) AS votes FROM votingresult WHERE (status = 'Closed') AND (candidateid = candidate.candidateid)) AS total, candidate.postid AS postid FROM candidate INNER JOIN post ON candidate.postid = post.postid INNER JOIN voter ON candidate.voterid = voter.voterid INNER JOIN course ON voter.courseid = course.courseid WHERE (post.postid = '" & cmbpostresults.SelectedValue & "') AND (voter.status = 'Inactive') ORDER BY total DESC"
        cmd = New SqlCommand(qry, con)
        dr = cmd.ExecuteReader
        dgvresults.Rows.Clear()
        i = 0
        While dr.Read = True
            dgvresults.Rows.Add()
            dgvresults.Rows(i).Height = 60
            dgvresults.Item(0, i).Value = dr(0)
            dgvresults.Item(1, i).Value = dr(1).ToString.ToUpper
            dgvresults.Item(2, i).Value = dr(2)
            dgvresults.Item(3, i).Value = dr("total")
            rptpostid = dr("postid")
            i = i + 1
        End While
        closecon()

    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnreport.Click
        Dim rpt1 As New rptresults
        rpt1.DataSourceConnections.Item(0).SetConnection(sqlconn, sqldb, True)
        rpt1.SetParameterValue("postid", rptpostid)
        frmreport.CrystalReportViewer1.Refresh()
        frmreport.CrystalReportViewer1.ReportSource = rpt1
        frmreport.Show()
    End Sub

    Private Sub btnvoterdetails_Click(sender As Object, e As EventArgs) Handles btnvoterdetails.Click
        Dim rpt2 As New rptvoters
        rpt2.DataSourceConnections.Item(0).SetConnection(sqlconn, sqldb, True)
        rpt2.SetParameterValue("courseid", rptcourseid)
        frmvoters.CrystalReportViewer2.Refresh()
        frmvoters.CrystalReportViewer2.ReportSource = rpt2
        frmvoters.Show()
    End Sub
End Class
