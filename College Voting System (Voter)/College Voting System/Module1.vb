Imports System.Data.SqlClient

Module Module1
    Public openform As New Form
    Public con As SqlConnection
    Public cmd As SqlCommand
    Public adapter As New SqlDataAdapter
    Public sqlconn As String = "(local)"
    Public sqldb As String = "evm"
    Public numericexpression As String = "^[0-9]*$" 'Regular Expression Validation Variable

    'This function creates a theme for the header, close button, etc.
    Public Sub createtheme(ByVal formname As Form, ByVal formtitle As String)
        Dim formtheme As New FormSkin 'Background skin of the form
        Dim formstatusbar As New StatusStrip 'Status bar to display the last update
        openform = formname
        formtheme.Text = formtitle
        With formname
            .Controls.Add(formtheme)
            .Controls.Add(formstatusbar)
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
            .RowHeadersDefaultCellStyle.SelectionBackColor = Color.LightGray
            .MultiSelect = False 'Multiple selection of rows is disabled
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeRows = False 'Disables resizing of rows
            .readonly = True 'Disallows users to edit
            .currentcell = Nothing
        End With
    End Sub
End Module
