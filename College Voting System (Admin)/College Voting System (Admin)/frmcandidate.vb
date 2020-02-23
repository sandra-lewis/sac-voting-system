Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class frmcandidate

    Dim vid As Integer
    Dim valid As String = "true"

    Public Sub validateform()

        valid = "true"
        ErrorProvider1.Clear()

        If Not Regex.Match(txtcandrno.Text, numericexpression).Success Then
            ErrorProvider1.SetError(txtcandrno, "Register Number can only contain digits")
            valid = "false"
        End If

        If txtcandrno.Text = "" Then
            ErrorProvider1.SetError(txtcandrno, "Please enter the register number")
            valid = "false"
        End If

        If cmbcandpost.Text = "" Then
            ErrorProvider1.SetError(cmbcandpost, "Please select the post")
            valid = "false"
        End If

        If valid = "false" Then
            valid = "false"
        Else
            valid = "true"
        End If

    End Sub

    Public Sub selectedstudent()
        Dim sql As String
        Dim ds As New DataSet
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        createcon()
        If txtcandrno.Text <> "" Then
            sql = "SELECT voter.voterid, voter.votername, course.coursename FROM voter LEFT JOIN course ON course.courseid=voter.courseid  WHERE voter.regno='" & txtcandrno.Text & "' AND voter.status='Active'"
            cmd = New SqlCommand(sql, con)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                vid = dr(0)
                txtcandname.Text = dr(1).ToString
                txtcandcourse.Text = dr(2).ToString
            End If
        Else
            txtcandname.Text = ""
            txtcandcourse.Text = ""
        End If
        closecon()
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        validateform()
        If valid = "true" Then
            Dim query As String
            Dim index As Integer = 0
            Dim insert As Boolean = True
            For index = 0 To frmmain.dgvcandidates.Rows.Count - 1
                If frmmain.dgvcandidates.Item(1, index).Value = txtcandrno.Text Then
                    MessageBox.Show("Candidate already exists")
                    insert = False
                    clearcandform()
                    Exit For
                End If
            Next
            If insert = True Then
                createcon()
                query = "INSERT INTO candidate(voterid,postid) VALUES('" & vid & "','" & cmbcandpost.SelectedValue & "')"
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Candidate details inserted successfully...")
                closecon()
                clearcandform()
                frmmain.loaddgvcandidate()
            End If
        End If
    End Sub

    Private Sub frmcandidate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbpost(cmbcandpost)
    End Sub

    Private Sub txtcandrno_TextChanged(sender As Object, e As EventArgs) Handles txtcandrno.TextChanged
        selectedstudent()  
    End Sub

    Public Sub clearcandform()
        txtcandrno.Text = ""
        cmbcandpost.SelectedValue = -1
    End Sub
End Class