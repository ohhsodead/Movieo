Imports System.IO

Public Class ctrlContextMenuMyLists

    Public oldTitle As String

    Private Sub btnChangelog_MouseMove(sender As Object, e As MouseEventArgs) Handles btnRemoveList.MouseMove, btnEditList.MouseMove
        sender.ForeColor = Color.White
    End Sub

    Private Sub btnChangelog_MouseLeave(sender As Object, e As EventArgs) Handles btnRemoveList.MouseLeave, btnEditList.MouseLeave
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

    Private Sub btnEditList_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnEditList.ClickButtonArea
        Try
            Hide()
            frmCreateList.replaceList = True
            frmCreateList.oldTitle = oldTitle
            frmCreateList.ShowDialog(Movieo)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnRemoveList_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnRemoveList.ClickButtonArea
        Try
            Hide()
            File.Delete(Movieo.pathMyLists + oldTitle + ".txt")
            Movieo.loadMyLists()
            Movieo.selectedList = Movieo.btnListsFavourites.Text
            Movieo.tabsLibrary.SelectedTab = Movieo.tabLibraryFavourites
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ctrlContextMenuMyLists_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class