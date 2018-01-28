Public Class frmRequestMovie


    Private Sub frmRequestMovie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Location = Movieo.PointToScreen(Point.Empty)
        Size = Movieo.ClientSize
    End Sub

    Private Sub btnFormSubmit_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnFormSubmit.ClickButtonArea
        If Not txtFormMovieTitle.Text = "" Then
            Try
                showMessage("Opening Default Mail Client...")
                Movieo.openMovieRequest(txtFormMovieTitle.Text)
                txtFormMovieTitle.Text = ""
                txtFormMoreInfo.Text = ""
            Catch ex As Exception
                showMessage("Unable to send your movie request.")
            End Try
        Else
            showMessage("Movie title can't be blank.")
        End If
    End Sub

    Private Sub BtnSubmitForm_MouseMove(sender As Object, e As EventArgs) Handles btnFormSubmit.MouseMove, btnFormSubmit.GotFocus
        sender.ForeColor = Color.White
        sender.BorderColor = Color.White
        sender.ColorFillSolid = Color.FromArgb(52, 59, 71)
    End Sub

    Private Sub BtnSubmitForm_MouseLeave(sender As Object, e As EventArgs) Handles btnFormSubmit.MouseLeave, btnFormSubmit.LostFocus
        sender.ForeColor = Color.FromArgb(172, 180, 191)
        sender.BorderColor = Color.FromArgb(86, 98, 115)
        sender.ColorFillSolid = Color.Transparent
    End Sub

#Region "Close Button / Image"

    'Close window image
    Private Sub MeClose_MouseMove(sender As Object, e As MouseEventArgs) Handles MeClose.MouseMove
        MeClose.Image = My.Resources.PopupCloseH
    End Sub

    Private Sub MeClose_MouseLeave(sender As Object, e As EventArgs) Handles MeClose.MouseLeave
        MeClose.Image = My.Resources.PopupCloseL
    End Sub

    Private Sub MeClose_MouseClick(sender As Object, e As EventArgs) Handles MeClose.Click
        My.Settings.Reload()
        Close()
    End Sub

#End Region

#Region "Notification Message"

    Private Sub HideSettingsConfirmation_Tick(sender As Object, e As EventArgs) Handles timerHideNotifications.Tick
        lblMessageSent.Visible = False
        timerHideNotifications.Enabled = False
    End Sub

    Private Sub HideSettingsConfirmation_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles lblMessageSent.ClickButtonArea
        lblMessageSent.Visible = False
        timerHideNotifications.Enabled = False
    End Sub

    Public Sub showMessage(Message As String)
        lblMessageSent.Text = Message
        lblMessageSent.Visible = True
        timerHideNotifications.Enabled = True
    End Sub

#End Region

End Class