Public Class frmTrailerPlayer
    Private Sub frmTrailerPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Location = Movieo.PointToScreen(Point.Empty)
        Size = Movieo.ClientSize
    End Sub

    Private Sub appClose_Click(sender As Object, e As EventArgs) Handles appClose.Click
        Close()
    End Sub

    Private Sub appClose_MouseMove(sender As Object, e As MouseEventArgs) Handles appClose.MouseMove
        Try
            appClose.Image = My.Resources.PopupCloseH
        Catch ex As Exception
        End Try
    End Sub

    Private Sub appClose_MouseLeave(sender As Object, e As EventArgs) Handles appClose.MouseLeave
        Try
            appClose.Image = My.Resources.PopupCloseL
        Catch ex As Exception
        End Try
    End Sub
End Class