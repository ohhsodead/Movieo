Public Class frmPopupYesNo
    Private Sub btnYes_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnYes.ClickButtonArea
        Close()
    End Sub

    Private Sub btnNo_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnNo.ClickButtonArea
        Close()
    End Sub
End Class