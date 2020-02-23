Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports Excela = Microsoft.Office.Interop.Excel
Imports System.String
Imports System.Net
Imports System.Text.RegularExpressions

Public Class frmimportvoters

    Private Sub KillExcelProcess()
        Try
            Dim Xcel() As Process = Process.GetProcessesByName("EXCEL")
            For Each Process As Process In Xcel
                Process.Kill()
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub getXlFile()
        Dim xlApp As Excel.Application
        Dim xlWorkbook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim xlRange As Excel.Range
        Dim xlCol As Integer
        Dim xlRow As Integer
        Dim strDestination As String
        Dim Data(0 To 100) As String
        With OpenFileDialog1
            .Filter = "Excel Office|*.xls;*.xlsx;*.csv"
            .FileName = ""
            .ShowDialog()
            strDestination = .FileName
            txtimportfile.Text = .FileName
            txtimportfilename.Text = Path.GetFileNameWithoutExtension(txtimportfile.Text)
        End With
        With ListView1
            .View = View.Details
            .HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
            .FullRowSelect = True
            .GridLines = True
            .Columns.Clear()
            .Items.Clear()
            If strDestination <> "" And txtimportfilename.Text <> "" Then
                xlApp = New Excel.Application
                xlWorkbook = xlApp.Workbooks.Open(strDestination)
                xlWorkSheet = xlWorkbook.Worksheets("Sheet1")
                xlRange = xlWorkSheet.UsedRange
                If xlRange.Columns.Count > 0 Then
                    If xlRange.Rows.Count > 0 Then
                        lblcountimport.Visible = True
                        'Header
                        For xlCol = 1 To xlRange.Columns.Count
                            .Columns.Add("Column" & xlCol)
                        Next
                        'Detail
                        For xlRow = 1 To xlRange.Rows.Count
                            For xlCol = 1 To xlRange.Columns.Count
                                Data(xlCol) = xlRange.Cells(xlRow, xlCol).text
                                If xlCol = 1 Then
                                    .Items.Add(Data(xlCol).ToString)
                                Else
                                    .Items(xlRow - 1).SubItems.Add(Data(xlCol).ToString)
                                End If
                            Next
                            lblcountimport.Text = ListView1.Items.Count - 1 & " / " & xlRange.Rows.Count - 1
                        Next
                        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
                        btnupload.Visible = True
                        xlWorkbook.Close()
                        xlApp.Quit()
                        KillExcelProcess()
                    End If
                End If
            End If
        End With
        lblcountimport.Visible = False
        If ListView1.Items.Count <> 0 Then
            btnupload.Text = "Import " & ListView1.Items.Count - 1 & " Records"
        End If
    End Sub

    Private Sub btnupload_Click(sender As Object, e As EventArgs) Handles btnupload.Click
        Dim adapter, adaptera As New SqlDataAdapter
        Dim ds, ds1, ds2, dsarea As New DataSet
        Dim reader As SqlDataReader
        Dim countins As Integer = 0
        Dim sql As String
        Dim execute As Boolean = True
        btnimportdata.Text = "Uploading..."
        btnimportdata.Visible = True
        Dim countimportgrid As Integer = ListView1.Items.Count - 1
        Me.Cursor = Windows.Forms.Cursors.WaitCursor
        Dim recset, cstid, cstcount As Integer
        Dim regDate As Date = Date.Now()
        Dim insid As Integer
        For j = 1 To ListView1.Items.Count - 1
            btnimportdata.Refresh()
            cstcount = 0
            recset = 0
            insid = 0
            createcon()
            sql = "SELECT courseid FROM course WHERE coursename='" & ListView1.Items(j).SubItems(2).Text & "'"
            cmd = New SqlCommand(sql, con)
            reader = cmd.ExecuteReader()
            If reader.Read = True Then
                cstid = reader(0)
            End If
            closecon()
            createcon()
            Dim query As String
            Dim pwd As Integer
            Dim index As Integer = 0           
            For index = 0 To frmmain.dgvvoters.Rows.Count - 1
                If frmmain.dgvvoters.Item(1, index).Value = ListView1.Items(j).SubItems(0).Text Then
                    execute = False
                    Exit For
                End If
            Next
            If execute = True Then
                pwd = Int((5000 * Rnd()) + 1000)
                query = "INSERT INTO voter(regno,votername,courseid,password,status) VALUES('" & ListView1.Items(j).SubItems(0).Text & "', '" & ListView1.Items(j).SubItems(1).Text & "','" & cstid & "','" & pwd & "','Active')"
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                closecon()
                countins = countins + 1
                btnimportdata.Text = countins & " / " & countimportgrid & " Received"
            End If
        Next
        txtimportfile.Clear()
        btnupload.Text = "Upload File"
        Me.Cursor = Windows.Forms.Cursors.Default
        If execute = True Then
            MsgBox("Voters data imported successfully...", MsgBoxStyle.Information)
        Else
            MessageBox.Show("Voters already exist")
            Me.Close()
        End If
    End Sub

    Private Sub btnselectfile_Click(sender As Object, e As EventArgs) Handles btnselectfile.Click
        btnimportdata.Visible = False
        getXlFile()
    End Sub

    Private Sub btnexcelformat_Click(sender As Object, e As EventArgs) Handles btnexcelformat.Click
        Dim appPath As String = Application.StartupPath()
        Process.Start(appPath & "/docs/")
    End Sub

End Class