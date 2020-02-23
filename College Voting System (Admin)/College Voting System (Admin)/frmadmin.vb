Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class frmadmin

    Dim valid As String = "true"

    Public Sub validateform()

        valid = "true"
        ErrorProvider1.Clear()

        If Not Regex.Match(txtadminname.Text, alphaspaceexpression).Success Then
            ErrorProvider1.SetError(txtadminname, "Admin name cannot contain digits and special characters")
            valid = "false"
        End If

        If txtadminname.Text = "" Then
            ErrorProvider1.SetError(txtadminname, "Please enter the admin's name")
            valid = "false"
        End If

        If Not Regex.Match(txtloginid.Text, alphanumericexpression).Success Then
            ErrorProvider1.SetError(txtloginid, "Login ID cannot contain spaces and special characters")
            valid = "false"
        End If

        If txtloginid.Text = "" Then
            ErrorProvider1.SetError(txtloginid, "Please enter your Login ID")
            valid = "false"
        End If

        If pwdb.Text.Length < 8 Then
            ErrorProvider1.SetError(pwdb, "Minimum password length must be 8 characters")
            valid = "false"
        End If

        If pwdb.Text = "" Then
            ErrorProvider1.SetError(pwdb, "Please enter your password")
            valid = "false"
        End If

        If pwdb.Text <> pwdbconfirm.Text Then
            ErrorProvider1.SetError(pwdbconfirm, "Password mismatch")
            valid = "false"
        End If

        If pwdbconfirm.Text = "" Then
            ErrorProvider1.SetError(pwdbconfirm, "Please confirm your password")
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
            ' ###  Update statement : Step 3 - Update statement starts here
            If updid <> 0 Then
                createcon()
                Dim query As String
                query = "UPDATE admin SET adminname='" & txtadminname.Text & "',loginid='" & txtloginid.Text & "',password='" & pwdb.Text & "' WHERE adminid=" & updid
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Admin details updated successfully...")
                closecon()
                updid = 0
                frmviewadmin.loaddgvadmin()
                Me.Close()
                ' ###  Update statement : Step 3 - Update statement ends here
            Else
                createcon()
                Dim query As String
                query = "INSERT INTO admin(adminname,loginid,password) VALUES('" & txtadminname.Text & "', '" & txtloginid.Text & "','" & pwdb.Text & "')"
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Admin details inserted successfully...")
                closecon()
                frmviewadmin.loaddgvadmin()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub frmadmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ###  Update statement : Step 2 - Retrieving and displaying values in the form starts here
        If updid <> 0 Then
            Dim qry As String
            Dim dr As SqlDataReader
            createcon()
            qry = "SELECT * FROM admin WHERE adminid=" & updid
            cmd = New SqlCommand(qry, con)
            dr = cmd.ExecuteReader
            While dr.Read = True
                txtadminname.Text = dr("adminname").ToString
                txtloginid.Text = dr("loginid").ToString
                pwdb.Text = dr("password").ToString
                pwdbconfirm.Text = dr("password").ToString
            End While
            closecon()
        End If
        ' ###  Update statemet : Step 2 - Retrieving and displaying values in the form ends here
    End Sub
End Class