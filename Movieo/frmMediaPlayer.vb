
Imports AxWMPLib

Public Class frmMediaPlayer

    Dim firstLoad As Boolean

    Private Sub FastWeb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tab.SelectedTab = tabStatus
        firstLoad = True

        MediaPlayerControl.uiMode = "full"
        MediaPlayerControl.stretchToFit = True

        timerUntilConnected.Enabled = True
    End Sub

    Private Sub btnReportBroken_ClickButtonArea(sender As Object, e As EventArgs) Handles btnReportBroken.ClickButtonArea
        MediaPlayerControl.Ctlcontrols.pause()
        Movieo.openBrokenFile(MediaPlayerControl.URL)
    End Sub

    Private Sub btnReportBroken_MouseMove(sender As Object, e As MouseEventArgs) Handles btnReportBroken.MouseMove
        sender.ForeColor = Color.White
        sender.BorderColor = Color.White
        sender.ColorFillSolid = Color.FromArgb(52, 59, 71)
    End Sub

    Private Sub btnReportBroken_MouseLeave(sender As Object, e As EventArgs) Handles btnReportBroken.MouseLeave
        sender.ForeColor = Color.FromArgb(172, 180, 191)
        sender.BorderColor = Color.FromArgb(172, 180, 191)
        sender.ColorFillSolid = Color.Transparent
    End Sub

    Public Sub MediaPlayerControl_PlayStateChange(ByVal sender As Object, ByVal e As _WMPOCXEvents_PlayStateChangeEvent) Handles MediaPlayerControl.PlayStateChange
        MediaPlayerControl.uiMode = "full"
        MediaPlayerControl.stretchToFit = True

        'Test the current state of the player, display a message for each state. (https://msdn.microsoft.com/en-us/library/windows/desktop/dd562460)
        Select Case e.newState
            Case 0 ' Undefined
                'currentStateLabel.Text = "Undefined"
            Case 1 ' Stopped
                lblErrorText.Text = "You have finished watching: " + Text.Replace("Watching ", "") + vbNewLine + "We hope you enjoyed!"
                tab.SelectedTab = tabStatus
            Case 2 ' Paused
                'currentStateLabel.Text = "Paused"
            Case 3 ' Playing
                If firstLoad = True Then
                    timerGoToTime.Enabled = True
                End If
            Case 4 ' ScanForward
                'currentStateLabel.Text = "ScanForward"
            Case 5 ' ScanReverse
                'currentStateLabel.Text = "ScanReverse"
            Case 6 ' Buffering
                'currentStateLabel.Text = "Buffering"
            Case 7 ' Waiting
                'currentStateLabel.Text = "Waiting"
            Case 8 ' MediaEnded
                'currentStateLabel.Text = "MediaEnded" 
            Case 9 ' Transitioning
                'currentStateLabel.Text = "Transitioning"
            Case 10 ' Ready
                'currentStateLabel.Text = "Ready"
            Case 11 ' Reconnecting
                'currentStateLabel.Text = "Reconnecting"
            Case 12 ' Last
                'Last
            Case Else
                'currentStateLabel.Text = ("Unknown State:  " + e.newState.ToString())
        End Select
    End Sub

    Private Sub timerGoToTime_Tick(sender As Object, e As EventArgs) Handles timerGoToTime.Tick
        Try

            For Each a As String In Movieo.listRecentlyWatchedTimes
                Dim aCredential As String() = Split(a, "~")
                If Text = aCredential(0) Then
                    MediaPlayerControl.Ctlcontrols.currentPosition = CDbl(aCredential(1))
                    firstLoad = False
                    timerGoToTime.Enabled = False
                End If
            Next
        Catch ex As Exception
            firstLoad = False
            timerGoToTime.Enabled = False
        End Try
    End Sub

    Private Sub MediaPlayerControl_EndOfStream(sender As Object, e As _WMPOCXEvents_EndOfStreamEvent) Handles MediaPlayerControl.EndOfStream
        lblErrorText.Text = "You have finished watching: " + Text.Replace("Watching  ", "") + vbNewLine + "We hope you enjoyed!"
        tab.SelectedTab = tabStatus
    End Sub

    Private Sub MediaPlayerControl_MediaError(sender As Object, e As _WMPOCXEvents_MediaErrorEvent) Handles MediaPlayerControl.MediaError
        lblErrorText.Text = "Unable to connect to server. If the problem persists then use the 'Report Broken' button above so that we can fix the link."
        tab.SelectedTab = tabStatus
    End Sub

    Private Sub tab_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tab.SelectedIndexChanged
        If tab.SelectedIndex = 0 Then
            Opacity = 100
        ElseIf tab.SelectedIndex = 1 Then
            Opacity = 0.97
        End If
    End Sub

    Private Sub timerUntilConnected_Tick(sender As Object, e As EventArgs) Handles timerUntilConnected.Tick
        If MediaPlayerControl.playState = WMPLib.WMPPlayState.wmppsReconnecting Then
            tab.SelectedTab = tabStatus
        ElseIf MediaPlayerControl.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            tab.SelectedTab = tabPlayer
            If My.Settings.doFullScr = True Then
                MediaPlayerControl.fullScreen = True
            End If
            timerUntilConnected.Enabled = False
        End If
    End Sub
End Class