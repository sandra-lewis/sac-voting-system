Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class frmlogin

    Dim valid As String = "true"

    Public Sub validateform()

        valid = "true"
        ErrorProvider1.Clear()

        If Not Regex.Match(txtloginid.Text, alphanumericexpression).Success Then
            ErrorProvider1.SetError(txtloginid, "Login ID cannot contain spaces and special characters")
            valid = "false"
        End If

        If txtloginid.Text = "" Then
            ErrorProvider1.SetError(txtloginid, "Please enter your Login ID")
            valid = "false"
        End If

        If pwdblogin.Text.Length < 8 Then
            ErrorProvider1.SetError(pwdblogin, "Minimum password length must be 8 characters")
            valid = "false"
        End If

        If pwdblogin.Text = "" Then
            ErrorProvider1.SetError(pwdblogin, "Please enter your password")
            valid = "false"
        End If

        If valid = "false" Then
            valid = "false"
        Else
            valid = "true"
        End If

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        validateform()
        If valid = "true" Then
            Dim qry As String
            Dim dr As SqlDataReader
            createcon()
            qry = "SELECT * FROM admin WHERE loginid='" & txtloginid.Text & "' AND password='" & pwdblogin.Text & "'"
            cmd = New SqlCommand(qry, con)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                Me.Visible = False
                createtheme(frmmain, "College Voting System")
                Me.Close()
            Else
                MessageBox.Show("You have entered invalid login credentials..", "Failed to Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            closecon()
        End If
    End Sub
End Class
