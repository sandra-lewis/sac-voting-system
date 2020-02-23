Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class frmpost

    Dim valid As String = "true"

    Public Sub validateform()

        valid = "true"
        ErrorProvider1.Clear()

        If Not Regex.Match(txtpostname.Text, alphaspaceexpression).Success Then
            ErrorProvider1.SetError(txtpostname, "Post name cannot contain digits and special characters")
            valid = "false"
        End If

        If txtpostname.Text = "" Then
            ErrorProvider1.SetError(txtpostname, "Please enter the post")
            valid = "false"
        End If

        If chkcourselist.Text = "" Then
            ErrorProvider1.SetError(chkcourselist, "Please select the course")
            valid = "false"
        End If

        If valid = "false" Then
            valid = "false"
        Else
            valid = "true"
        End If

    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Dim query As String
        Dim coursegroups As String = ""
        validateform()
        If valid = "true" Then
            For ctr = 0 To chkcourselist.Items.Count - 1
                If chkcourselist.GetItemChecked(ctr) Then
                    coursegroups = coursegroups & " " & chkcourselist.Items.Item(ctr)(1).ToString
                End If
            Next
            For ctr = 0 To chkcourselist.Items.Count - 1
                If chkcourselist.GetItemChecked(ctr) Then
                    createcon()
                    query = "INSERT INTO post(courseid,postname,coursegroup) VALUES('" & chkcourselist.Items.Item(ctr)(0).ToString & "', '" & txtpostname.Text & "','" & coursegroups & "')"
                    cmd = New SqlCommand(query, con)
                    cmd.ExecuteNonQuery()
                    closecon()
                End If
            Next
            MessageBox.Show("Course Group created successfully...")
            loaddgvpost()
        End If
        clearcourse(chkcourselist)
        txtpostname.Text = ""
        chkcourse(chkcourselist)
    End Sub

    Private Sub frmpost_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkcourse(chkcourselist)
        loaddgvpost()
    End Sub

    Public Sub loaddgvpost()
        datagridviewwork(dgvpost)
        Dim qry As String
        Dim i As Integer
        Dim dr As SqlDataReader
        createcon()
        qry = "SELECT DISTINCT(coursegroup) FROM post"
        cmd = New SqlCommand(qry, con)
        dr = cmd.ExecuteReader
        dgvpost.Rows.Clear()
        i = 0
        While dr.Read = True
            dgvpost.Rows.Add()
            dgvpost.Item(2, i).Value = dr(0)
            dgvpost.Item(3, i).Value = "Delete"
            i = i + 1
        End While
        closecon()

        Dim index As Integer = 0
        For index = 0 To dgvpost.Rows.Count - 1
            createcon()
            qry = "SELECT postid,postname FROM post WHERE coursegroup='" & dgvpost.Item(2, index).Value & "'"
            cmd = New SqlCommand(qry, con)
            dr = cmd.ExecuteReader
            While dr.Read = True
                dgvpost.Item(0, index).Value = dr(0)
                dgvpost.Item(1, index).Value = dr(1)
            End While
            closecon()
        Next
    End Sub

    Private Sub dgvpost_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvpost.CellClick
        Dim query As String
        If e.ColumnIndex = 3 Then
            If MessageBox.Show("Are you sure you want to delete this record?", "Confirm to Delete..", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                createcon()
                query = "DELETE FROM post WHERE coursegroup='" & dgvpost.CurrentRow.Cells(2).Value & "'"
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Post record deleted successfully...")
                closecon()
                loaddgvpost()
            End If
        End If
    End Sub
End Class