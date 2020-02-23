Imports System.Data.SqlClient

Public Class frmviewadmin

    Private Sub frmviewadmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddgvadmin()
    End Sub

    Public Sub loaddgvadmin()
        datagridviewwork(dgvadmin)
        Dim qry As String
        Dim i As Integer
        Dim dr As SqlDataReader
        createcon()
        qry = "SELECT * FROM admin"
        cmd = New SqlCommand(qry, con)
        dr = cmd.ExecuteReader
        dgvadmin.Rows.Clear()
        i = 0
        While dr.Read = True
            dgvadmin.Rows.Add()
            dgvadmin.Item(0, i).Value = dr(0)
            dgvadmin.Item(1, i).Value = dr(1)
            dgvadmin.Item(2, i).Value = dr(2)
            dgvadmin.Item(3, i).Value = dr(3)
            dgvadmin.Item(4, i).Value = "Edit"
            dgvadmin.Item(5, i).Value = "Delete"
            i = i + 1
        End While
        closecon()
    End Sub

    Private Sub dgvadmin_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvadmin.CellContentClick
        ' ###  Update statemet : Step 1 - Send update ID to form page starts here
        If e.ColumnIndex = 4 Then
            updid = dgvadmin.CurrentRow.Cells(0).Value
            createtheme(frmadmin, "Edit Admin Record")
        End If
        ' ###  Update statemet : Step 1 - Send update ID to form page ends here

        If e.ColumnIndex = 5 Then
            If MessageBox.Show("Are you sure you want to delete this record?", "Confirm to Delete..", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                createcon()
                Dim query As String
                query = "DELETE FROM admin WHERE adminid=" & dgvadmin.CurrentRow.Cells(0).Value
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Admin record deleted successfully...")
                closecon()
                loaddgvadmin()
            End If
        End If
    End Sub

    Private Sub btnaddadmin_Click(sender As Object, e As EventArgs) Handles btnaddadmin.Click
        updid = 0
        createtheme(frmadmin, "Admin")
    End Sub
End Class