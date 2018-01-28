Public Class frmSettings

#Region "Base"

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set position/size of window
        Location = Movieo.PointToScreen(Point.Empty)
        Size = Movieo.ClientSize

        'General
        chkAlwaysOnTop.Checked = My.Settings.doOnTop
        chkShowRating.Checked = My.Settings.doRatingOnPoster
        cmboboxWatchedMovies.SelectedIndex = My.Settings.doWatchedMovies

        'Quality
        chkShowMovieQuality.Checked = My.Settings.doQualityOnPoster

        'Playback
        chckPlayFullscr.Checked = My.Settings.doFullScr

        'Features
        chckDownloadBtn.Checked = My.Settings.doDownloadBtn
        chckUserComments.Checked = My.Settings.doUserComments

        'Database
        chckBackupDb.Checked = My.Settings.doBackupDb
        txtDbDir.Text = Movieo.pathData + "open-movies.json"

        'Miscellaneous
        chckAutoUpdate.Checked = My.Settings.doAutoUpdate
    End Sub

    'Prevent lag on scroll
    Private Sub MyBase_Scroll(sender As Object, e As ScrollEventArgs) Handles MyBase.Scroll
        sender.update()
    End Sub

#End Region

#Region "Close Window"

    Private Sub MeClose_MouseMove(sender As Object, e As MouseEventArgs) Handles meClose.MouseMove
        Try
            meClose.Image = My.Resources.PopupCloseH
        Catch ex As Exception
        End Try
    End Sub

    Private Sub MeClose_MouseLeave(sender As Object, e As EventArgs) Handles meClose.MouseLeave
        Try
            meClose.Image = My.Resources.PopupCloseL
        Catch ex As Exception
        End Try
    End Sub

    Private Sub meClose_Click(sender As Object, e As EventArgs) Handles meClose.Click
        My.Settings.Save()
        Close()
    End Sub

#End Region

#Region "Tabs"

    Private Sub headerGeneral_Click(sender As Object, e As EventArgs) Handles headerGeneral.Click
        Tab.SelectedTab = tabGeneral
    End Sub

    Private Sub headerQuality_Click(sender As Object, e As EventArgs) Handles headerQuality.Click
        Tab.SelectedTab = tabQuality
    End Sub

    Private Sub headerPlayback_Click(sender As Object, e As EventArgs) Handles headerPlayback.Click
        Tab.SelectedTab = tabPlayback
    End Sub

    Private Sub headerFeatures_Click(sender As Object, e As EventArgs) Handles headerFeatures.Click
        Tab.SelectedTab = tabFeatures
    End Sub

    Private Sub headerDatabase_Click(sender As Object, e As EventArgs) Handles headerDatabase.Click
        Tab.SelectedTab = tabDatabase
    End Sub

    Private Sub headerMiscellaneous_Click(sender As Object, e As EventArgs) Handles headerMiscellaneous.Click
        Tab.SelectedTab = tabMiscellaneous
    End Sub

    Private Sub LblAbout_MouseMove(sender As Object, e As MouseEventArgs) Handles headerMiscellaneous.MouseMove, headerDatabase.MouseMove, headerFeatures.MouseMove, headerPlayback.MouseMove, headerQuality.MouseMove, headerGeneral.MouseMove
        sender.ForeColor = SelectedTabColour
    End Sub

    Private Sub LblAbout_MouseLeave(sender As Object, e As EventArgs) Handles headerMiscellaneous.MouseLeave, headerDatabase.MouseLeave, headerFeatures.MouseLeave, headerPlayback.MouseLeave, headerQuality.MouseLeave, headerGeneral.MouseLeave
        If sender IsNot CurrentTab Then sender.ForeColor = NonSelectedTabColour
    End Sub

    Dim CurrentTab As Object = headerGeneral
    Dim SelectedTabColour As Color = Color.FromArgb(172, 180, 191)
    Dim NonSelectedTabColour As Color = Color.FromArgb(86, 98, 115)

    Private Sub Tab_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tab.SelectedIndexChanged
        If Tab.SelectedIndex = 0 Then
            CurrentTab = headerGeneral
            headerGeneral.ForeColor = SelectedTabColour
            headerQuality.ForeColor = NonSelectedTabColour
            headerPlayback.ForeColor = NonSelectedTabColour
            headerFeatures.ForeColor = NonSelectedTabColour
            headerDatabase.ForeColor = NonSelectedTabColour
            headerMiscellaneous.ForeColor = NonSelectedTabColour
        ElseIf Tab.SelectedIndex = 1 Then
            CurrentTab = headerQuality
            headerGeneral.ForeColor = NonSelectedTabColour
            headerQuality.ForeColor = SelectedTabColour
            headerPlayback.ForeColor = NonSelectedTabColour
            headerFeatures.ForeColor = NonSelectedTabColour
            headerDatabase.ForeColor = NonSelectedTabColour
            headerMiscellaneous.ForeColor = NonSelectedTabColour
        ElseIf Tab.SelectedIndex = 2 Then
            CurrentTab = headerPlayback
            headerGeneral.ForeColor = NonSelectedTabColour
            headerQuality.ForeColor = NonSelectedTabColour
            headerPlayback.ForeColor = SelectedTabColour
            headerFeatures.ForeColor = NonSelectedTabColour
            headerDatabase.ForeColor = NonSelectedTabColour
            headerMiscellaneous.ForeColor = NonSelectedTabColour
        ElseIf Tab.SelectedIndex = 3 Then
            CurrentTab = headerFeatures
            headerGeneral.ForeColor = NonSelectedTabColour
            headerQuality.ForeColor = NonSelectedTabColour
            headerPlayback.ForeColor = NonSelectedTabColour
            headerFeatures.ForeColor = SelectedTabColour
            headerDatabase.ForeColor = NonSelectedTabColour
            headerMiscellaneous.ForeColor = NonSelectedTabColour
        ElseIf Tab.SelectedIndex = 4 Then
            CurrentTab = headerDatabase
            headerGeneral.ForeColor = NonSelectedTabColour
            headerQuality.ForeColor = NonSelectedTabColour
            headerPlayback.ForeColor = NonSelectedTabColour
            headerFeatures.ForeColor = NonSelectedTabColour
            headerDatabase.ForeColor = SelectedTabColour
            headerMiscellaneous.ForeColor = NonSelectedTabColour
        ElseIf Tab.SelectedIndex = 5 Then
            CurrentTab = headerMiscellaneous
            headerGeneral.ForeColor = NonSelectedTabColour
            headerQuality.ForeColor = NonSelectedTabColour
            headerPlayback.ForeColor = NonSelectedTabColour
            headerFeatures.ForeColor = NonSelectedTabColour
            headerDatabase.ForeColor = NonSelectedTabColour
            headerMiscellaneous.ForeColor = SelectedTabColour
        End If
    End Sub

#End Region

#Region "General"

    Private Sub chkAlwaysOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles chkAlwaysOnTop.CheckedChanged
        My.Settings.doOnTop = chkAlwaysOnTop.Checked
        Movieo.TopMost = True
    End Sub

    Private Sub chkShowRating_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowRating.CheckedChanged
        My.Settings.doRatingOnPoster = chkShowRating.Checked
    End Sub

    Private Sub cmboTxtWatchedMovies_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles cmboTxtWatchedMovies.ClickButtonArea
        cmboboxWatchedMovies.DroppedDown = True
    End Sub

    Private Sub cmboboxWatchedMovies_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboboxWatchedMovies.SelectedIndexChanged
        cmboTxtWatchedMovies.Text = cmboboxWatchedMovies.SelectedItem.ToString
        My.Settings.doWatchedMovies = cmboboxWatchedMovies.SelectedIndex
    End Sub

#End Region

#Region "Quality"

    Private Sub chkShowMovieQuality_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowMovieQuality.CheckedChanged
        My.Settings.doQualityOnPoster = chkShowMovieQuality.Checked
    End Sub

#End Region

#Region "Playback"

    Private Sub chckPlayFullscr_CheckedChanged(Sender As Object, e As EventArgs) Handles chckPlayFullscr.CheckedChanged
        My.Settings.doFullScr = chckPlayFullscr.Checked
    End Sub

#End Region

#Region "Features"

    Private Sub chckDownloadBtn_CheckedChanged(Sender As Object, e As EventArgs) Handles chckDownloadBtn.CheckedChanged
        My.Settings.doDownloadBtn = chckDownloadBtn.Checked
    End Sub

    Private Sub chckUserComments_CheckedChanged(Sender As Object, e As EventArgs) Handles chckUserComments.CheckedChanged
        My.Settings.doUserComments = chckUserComments.Checked
    End Sub

#End Region

#Region "Database"

    Private Sub chckBackupDb_CheckedChanged(sender As Object, e As EventArgs) Handles chckBackupDb.CheckedChanged
        My.Settings.doBackupDb = chckBackupDb.Checked
    End Sub

    Private Sub btnDbExport_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnDbExport.ClickButtonArea
        Dim ab As New SaveFileDialog
        If ab.ShowDialog = DialogResult.OK Then
            Try
                Movieo.NetDl.DownloadFile(Movieo.linkMovies, ab.FileName)
            Catch ex As Exception
                Movieo.ShowPopupOk("Unable to download database", ex.InnerException.Message, Me)
            End Try
        End If
    End Sub

    Private Sub imgOpenFolder_Click(Sender As Object, e As EventArgs) Handles imgOpenFolder.Click
        Movieo.ShowFile(txtDbDir.Text)
    End Sub

    Private Sub imgOpenFolder_MouseMove(Sender As Object, e As MouseEventArgs) Handles imgOpenFolder.MouseMove
        imgOpenFolder.Image = My.Resources.BrowseIconH
    End Sub

    Private Sub imgOpenFolder_MouseLeave(Sender As Object, e As EventArgs) Handles imgOpenFolder.MouseLeave
        imgOpenFolder.Image = My.Resources.BrowseIconL
    End Sub

#End Region

#Region "Miscellaneous"

    Private Sub chckAutoUpdate_CheckedChanged(Sender As Object, e As EventArgs) Handles chckAutoUpdate.CheckedChanged
        My.Settings.doAutoUpdate = chckAutoUpdate.Checked
    End Sub

#End Region

End Class