Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class frmaddvoter

    Dim valid As String = "true"

    Public Sub validateform()

        valid = "true"
        ErrorProvider1.Clear()

        If Not Regex.Match(txtvoterrno.Text, numericexpression).Success Then
            ErrorProvider1.SetError(txtvoterrno, "Register Number can only contain digits")
            valid = "false"
        End If

        If txtvoterrno.Text = "" Then
            ErrorProvider1.SetError(txtvoterrno, "Please enter the register number")
            valid = "false"
        End If

        If Not Regex.Match(txtvotername.Text, alphaspaceexpression).Success Then
            ErrorProvider1.SetError(txtvotername, "Voter's name cannot contain digits and special characters")
            valid = "false"
        End If

        If txtvotername.Text = "" Then
            ErrorProvider1.SetError(txtvotername, "Please enter the name")
            valid = "false"
        End If

        If cmbcourse.Text = "" Then
            ErrorProvider1.SetError(cmbcourse, "Please select the course")
            valid = "false"
        End If

        If valid = "false" Then
            valid = "false"
        Else
            valid = "true"
        End If

    End Sub

    Public Sub clearvoterform()
        txtvoterrno.Text = ""
        txtvotername.Text = ""
        cmbcourse.SelectedValue = -1
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        validateform()
        If valid = "true" Then
            Dim index As Integer = 0
            Dim execute As Boolean = True
            If updid = 0 Then
                For index = 0 To frmmain.dgvvoters.Rows.Count - 1
                    If frmmain.dgvvoters.Item(1, index).Value = txtvoterrno.Text Then
                        MessageBox.Show("Voter already exists")
                        execute = False
                        Me.Close()
                        Exit For
                    End If
                Next
            End If
            If updid <> 0 Then
                createcon()
                Dim query As String
                query = "UPDATE voter SET regno='" & txtvoterrno.Text & "',votername='" & txtvotername.Text & "',courseid='" & cmbcourse.SelectedValue & "' WHERE voterid=" & updid
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Voter details updated successfully...")
                closecon()
                updid = 0
                frmmain.loaddgvvoter()
                Me.Close()
            Else
                If execute = True Then
                    createcon()
                    Dim query As String
                    Dim pwd As Integer
                    pwd = Int((5000 * Rnd()) + 1005)
                    query = "INSERT INTO voter(regno,votername,courseid,password,status) VALUES('" & txtvoterrno.Text & "', '" & txtvotername.Text & "','" & cmbcourse.SelectedValue & "','" & pwd & "','Active')"
                    cmd = New SqlCommand(query, con)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Voter details inserted successfully...")
                    closecon()
                    clearvoterform()
                    frmmain.loaddgvvoter()
                End If
            End If
        End If
    End Sub

    Private Sub frmaddvoter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkcourse(cmbcourse)
        If updid <> 0 Then
            Dim qry As String
            Dim dr As SqlDataReader
            createcon()
            qry = "SELECT * FROM voter WHERE voterid=" & updid
            cmd = New SqlCommand(qry, con)
            dr = cmd.ExecuteReader
            While dr.Read = True
                txtvoterrno.Text = dr("regno").ToString
                txtvotername.Text = dr("votername").ToString
                cmbcourse.SelectedValue = dr("courseid").ToString
            End While
            closecon()
        End If
    End Sub

End Class