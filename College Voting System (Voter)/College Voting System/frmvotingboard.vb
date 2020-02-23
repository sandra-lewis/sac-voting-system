Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class frmvotingboard

    Dim valid As String = "true"

    Public Sub validateform()

        valid = "true"
        ErrorProvider1.Clear()

        If Not Regex.Match(txtrno.Text, numericexpression).Success Then
            ErrorProvider1.SetError(txtrno, "Register Number can only contain digits")
            valid = "false"
        End If

        If txtrno.Text = "" Then
            ErrorProvider1.SetError(txtrno, "Please enter your Register Number")
            valid = "false"
        End If

        If Not Regex.Match(pwdb.Text, numericexpression).Success Then
            ErrorProvider1.SetError(pwdb, "Password must be a numeric value")
            valid = "false"
        End If

        If pwdb.Text.Length < 4 Then
            ErrorProvider1.SetError(pwdb, "Minimum password length must be 4 digits")
            valid = "false"
        End If

        If pwdb.Text = "" Then
            ErrorProvider1.SetError(pwdb, "Please enter your password")
            valid = "false"
        End If

        If valid = "false" Then
            valid = "false"
        Else
            valid = "true"
        End If

    End Sub

    Public Sub reset()        
        If FlatTabControl1.TabPages.Contains(TabPage1) = True Then
            FlatTabControl1.SelectedTab = TabPage1
            loaddgvpresident()
        End If
        If FlatTabControl1.TabPages.Contains(TabPage2) = True Then
            loaddgvvicepresident()
        End If
        FlatTabControl1.Enabled = False
        txtrno.Text = ""
        pwdb.Text = ""
        FlatGroupBox1.Enabled = True
        btnfinish.Visible = False
    End Sub

    Private Sub frmvotingboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim qry As String
        Dim dr As SqlDataReader
        btnfinish.Visible = False
        With btnfinish
            .Top = 70
            .Size = New Size(300, 40)
            .Left = Me.Width - 340
        End With
        With btnclose
            .Top = 15
            .Size = New Size(30, 30)
            .Left = Me.Width - 50
        End With
        With FlatGroupBox1
            .Top = 140
            .Size = New Size(300, 650)
            .Left = Me.Width - 340
        End With
        FlatGroupBox1.Enabled = True
        FlatTabControl1.Enabled = False
        FlatTabControl1.Width = Me.Width - 385
        FlatTabControl1.Height = Me.Height - 85
        FlatTabControl1.TabPages.Remove(TabPage1)
        FlatTabControl1.TabPages.Remove(TabPage2)
        createcon()
        qry = "SELECT DISTINCT(candidate.postid), post.postname FROM candidate INNER JOIN post ON candidate.postid=post.postid"
        cmd = New SqlCommand(qry, con)
        dr = cmd.ExecuteReader
        While dr.Read = True
            If dr(1) = "President" Then
                FlatTabControl1.TabPages.Add(TabPage1)
                loaddgvpresident()
            End If
            If dr(1) = "Vice President" Then
                FlatTabControl1.TabPages.Add(TabPage2)
                loaddgvvicepresident()
            End If
        End While
        closecon()
    End Sub

    Public Sub loaddgvpresident()
        dgvpresident.Width = Me.Width - 450
        dgvpresident.Height = Me.Height - 200
        datagridviewwork(dgvpresident)
        dgvpresident.Enabled = True
        Dim qry As String
        Dim i As Integer
        Dim dr As SqlDataReader
        createcon()
        qry = "SELECT candidate.candidateid, post.postid, voter.votername, course.coursename FROM candidate INNER JOIN post ON candidate.postid = post.postid INNER JOIN voter ON candidate.voterid = voter.voterid INNER JOIN course ON voter.courseid = course.courseid WHERE post.postname = 'President'"
        cmd = New SqlCommand(qry, con)
        dr = cmd.ExecuteReader
        dgvpresident.Rows.Clear()
        i = 0
        While dr.Read = True
            dgvpresident.Rows.Add()
            dgvpresident.Rows(i).Height = 100
            dgvpresident.Item(0, i).Value = dr(0)
            dgvpresident.Item(1, i).Value = dr(1)
            dgvpresident.Item(2, i).Value = dr(2).ToString.ToUpper
            dgvpresident.Item(3, i).Value = dr(3)
            dgvpresident.Item(4, i).Value = "Click Here To Vote"
            i = i + 1
        End While
        closecon()
    End Sub

    Public Sub loaddgvvicepresident()
        dgvvicepresident.Width = Me.Width - 450
        dgvvicepresident.Height = Me.Height - 200
        datagridviewwork(dgvvicepresident)
        dgvvicepresident.Enabled = True
        Dim qry As String
        Dim i As Integer
        Dim dr As SqlDataReader
        createcon()
        qry = "SELECT candidate.candidateid, post.postid, voter.votername, course.coursename FROM candidate INNER JOIN post ON candidate.postid = post.postid INNER JOIN voter ON candidate.voterid = voter.voterid INNER JOIN course ON voter.courseid = course.courseid WHERE post.postname = 'Vice President'"
        cmd = New SqlCommand(qry, con)
        dr = cmd.ExecuteReader
        dgvvicepresident.Rows.Clear()
        i = 0
        While dr.Read = True
            dgvvicepresident.Rows.Add()
            dgvvicepresident.Rows(i).Height = 100
            dgvvicepresident.Item(0, i).Value = dr(0)
            dgvvicepresident.Item(1, i).Value = dr(1)
            dgvvicepresident.Item(2, i).Value = dr(2).ToString.ToUpper
            dgvvicepresident.Item(3, i).Value = dr(3)
            dgvvicepresident.Item(4, i).Value = "Click Here To Vote"
            i = i + 1
        End While
        closecon()
    End Sub

    Private Sub dgvpresident_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvpresident.CellClick
        Dim query As String
        If e.ColumnIndex = 4 Then
                createcon()
                query = "INSERT INTO votingresult(candidateid,postid,totalvotes,status) VALUES('" & dgvpresident.CurrentRow.Cells(0).Value & "','" & dgvpresident.CurrentRow.Cells(1).Value & "',1,'Open')"
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                closecon()
            dgvpresident.Enabled = False
            If FlatTabControl1.TabPages.Contains(TabPage2) = False Then
                btnfinish.Visible = True
            End If
        End If
    End Sub

    Private Sub dgvvicepresident_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvvicepresident.CellClick
        Dim query As String
        If e.ColumnIndex = 4 Then
                createcon()
                query = "INSERT INTO votingresult(candidateid,postid,totalvotes,status) VALUES('" & dgvvicepresident.CurrentRow.Cells(0).Value & "','" & dgvvicepresident.CurrentRow.Cells(1).Value & "',1,'Open')"
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                closecon()
            dgvvicepresident.Enabled = False
            btnfinish.Visible = True
        End If
    End Sub

    Private Sub btnfinish_Click(sender As Object, e As EventArgs) Handles btnfinish.Click
        Dim query As String
        createcon()
        query = "UPDATE voter SET status='Inactive' WHERE regno='" & txtrno.Text & "' AND password='" & pwdb.Text & "'"
        cmd = New SqlCommand(query, con)
        cmd.ExecuteNonQuery()
        closecon()
        reset()
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        validateform()
        If valid = "true" Then
            Dim qry As String
            Dim dr As SqlDataReader
            createcon()
            qry = "SELECT * FROM voter WHERE regno='" & txtrno.Text & "' AND password='" & pwdb.Text & "' AND status='Active'"
            cmd = New SqlCommand(qry, con)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                FlatGroupBox1.Enabled = False
                FlatTabControl1.Enabled = True
            Else
                MessageBox.Show("You cannot vote..", "Failed to Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtrno.Text = ""
                pwdb.Text = ""
            End If
            closecon()
        End If
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Dim query As String
        If txtrno.Text <> "" And pwdb.Text <> "" Then
            createcon()
            query = "UPDATE voter SET status='Inactive' WHERE regno='" & txtrno.Text & "' AND password='" & pwdb.Text & "'"
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            closecon()
        End If
        Me.Close()
    End Sub
End Class