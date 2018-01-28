Public Class ctrlContextMenuPlayer

    Dim pathVLC As String = "C:\Program Files (x86)\VideoLAN\VLC\vlc.exe"

    Private Sub ctrlContextMenuPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(pathVLC) Then
            btnVLC.Visible = True
            Size = New Size(155, 74)
        Else
            btnVLC.Visible = False
            Size = New Size(155, 42)
        End If
    End Sub


    Private Sub btnDefault_MouseMove(sender As Object, e As MouseEventArgs) Handles btnDefault.MouseMove, btnVLC.MouseMove
        sender.ForeColor = Color.White
    End Sub

    Private Sub btnDefault_MouseLeave(sender As Object, e As EventArgs) Handles btnDefault.MouseLeave, btnVLC.MouseLeave
        sender.ForeColor = Color.Silver
    End Sub

    Private Sub OnDeactivated_Deactivate(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Deactivate
        Hide()
    End Sub

    Private Sub OnMouseDown_MouseDown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.MouseDown
        Hide()
    End Sub

    Private Sub OnKeyDown_KeyDown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.KeyDown
        Hide()
    End Sub

    Private Sub OnLostFocus_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.LostFocus
        Hide()
    End Sub

    Private Sub btnDefault_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnDefault.ClickButtonArea
        If frmMovieDetails.infoFanartUrl = "" Then
            frmSelectSource.Opacity = 0.98
        Else
            frmSelectSource.Opacity = 0.85
        End If

        Dim getUrlFromUser As String = Movieo.returnSource(Me, frmMovieDetails.infoTitle.Text + " (" + frmMovieDetails.infoYear.Text + ")", frmMovieDetails.infoStreams, "watch")

        If Not getUrlFromUser = Nothing Then
            frmMediaPlayer.Text = "Watching " + frmMovieDetails.infoTitle.Text + " (" + frmMovieDetails.infoYear.Text + ")"
            frmMediaPlayer.MediaPlayerControl.URL = getUrlFromUser
            frmMediaPlayer.Show(Me)
        End If
    End Sub

    Private Sub btnVLC_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnVLC.ClickButtonArea
        If frmMovieDetails.infoFanartUrl = "" Then
            frmSelectSource.Opacity = 0.98
        Else
            frmSelectSource.Opacity = 0.85
        End If

        Dim getUrlFromUser As String = Movieo.returnSource(frmMovieDetails, frmMovieDetails.infoTitle.Text + " (" + frmMovieDetails.infoYear.Text + ")", frmMovieDetails.infoStreams, "watch")

        If Not getUrlFromUser = Nothing Then
            Dim VLC As Process = New Process
            VLC.StartInfo.FileName = pathVLC
            VLC.StartInfo.Arguments = ("-vvv " + getUrlFromUser)
            VLC.Start()
        End If
    End Sub
End Class