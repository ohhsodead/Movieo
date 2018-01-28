Public Class frmErrorTab
    Private Sub TabPageError_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = Movieo.tabDiscover.BackColor
    End Sub

    Private Sub btnRestart_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnRestart.ClickButtonArea
        Application.Restart()
    End Sub
End Class