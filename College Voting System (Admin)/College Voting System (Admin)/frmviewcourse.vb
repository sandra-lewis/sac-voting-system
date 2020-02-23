Imports System.Data.SqlClient

Public Class frmviewcourse

    Private Sub btnaddcourse_Click(sender As Object, e As EventArgs) Handles btnaddcourse.Click
        updid = 0
        createtheme(frmcourse, "Course")
    End Sub

    Private Sub frmviewcourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddgvcourse()
    End Sub

    Public Sub loaddgvcourse()
        datagridviewwork(dgvcourse)
        Dim qry As String
        Dim i As Integer
        Dim dr As SqlDataReader
        createcon()
        qry = "SELECT * FROM course"
        cmd = New SqlCommand(qry, con)
        dr = cmd.ExecuteReader
        dgvcourse.Rows.Clear()
        i = 0
        While dr.Read = True
            dgvcourse.Rows.Add()
            dgvcourse.Item(0, i).Value = dr(0)
            dgvcourse.Item(1, i).Value = dr(1)
            dgvcourse.Item(2, i).Value = "Edit"
            dgvcourse.Item(3, i).Value = "Delete"
            i = i + 1
        End While
        closecon()
    End Sub

    Private Sub dgvcourse_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcourse.CellContentClick
        If e.ColumnIndex = 2 Then
            updid = dgvcourse.CurrentRow.Cells(0).Value
            createtheme(frmcourse, "Edit Course Record")
        End If

        If e.ColumnIndex = 3 Then
            If MessageBox.Show("Are you sure you want to delete this record?", "Confirm to Delete..", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                createcon()
                Dim query As String
                query = "DELETE FROM course WHERE courseid=" & dgvcourse.CurrentRow.Cells(0).Value
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Course deleted successfully...")
                closecon()
                loaddgvcourse()
            End If
        End If
    End Sub
End Class