Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class frmcourse

    Dim valid As String = "true"

    Public Sub validateform()

        valid = "true"
        ErrorProvider1.Clear()

        If Not Regex.Match(txtcourse.Text, alphaspaceexpression).Success Then
            ErrorProvider1.SetError(txtcourse, "Course name cannot contain digits and special characters")
            valid = "false"
        End If

        If txtcourse.Text = "" Then
            ErrorProvider1.SetError(txtcourse, "Please enter the course")
            valid = "false"
        End If

        If valid = "false" Then
            valid = "false"
        Else
            valid = "true"
        End If

    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        validateform()
        If valid = "true" Then
            If updid <> 0 Then
                createcon()
                Dim query As String
                query = "UPDATE course SET coursename='" & txtcourse.Text & "' WHERE courseid=" & updid
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Course details updated successfully...")
                closecon()
                updid = 0
                frmviewcourse.loaddgvcourse()
                Me.Close()
            Else
                createcon()
                Dim query As String
                query = "INSERT INTO course(coursename) VALUES('" & txtcourse.Text & "')"
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Course details inserted successfully...")
                closecon()
                frmviewcourse.loaddgvcourse()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub frmcourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If updid <> 0 Then
            Dim qry As String
            Dim dr As SqlDataReader
            createcon()
            qry = "SELECT * FROM course WHERE courseid=" & updid
            cmd = New SqlCommand(qry, con)
            dr = cmd.ExecuteReader
            While dr.Read = True
                txtcourse.Text = dr("coursename").ToString
            End While
            closecon()
        End If
    End Sub
End Class