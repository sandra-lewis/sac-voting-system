Public Class frmsplashscreen

    Private Sub frmsplashscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(3)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Me.Visible = False
            createtheme(frmvotingboard, "Voting Board")
            Me.Close()
        End If
    End Sub
End Class