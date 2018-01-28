Imports System.IO

Public Class frmSelectList

    Public currentMovie As String

    Private Sub frmSelectSource_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Location = Movieo.PointToScreen(Point.Empty)
        Size = Movieo.ClientSize
        btnAddRemoveMovie.Enabled = False
    End Sub

    Private Sub itemsMovieSourcesTitle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles itemsMyListsTitle.SelectedIndexChanged
        Try
            If Not itemsMyListsTitle.SelectedIndex = -1 Then
                itemsMyListsPath.SelectedIndex = itemsMyListsTitle.SelectedIndex
                btnAddRemoveMovie.Enabled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnAddRemoveMovie_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnAddRemoveMovie.ClickButtonArea
        Dim moviesList() As String = File.ReadAllLines(itemsMyListsPath.SelectedItem.ToString())
        Dim copyList As New List(Of String)
        Dim isAdd As Boolean

        For Each movieItem As String In moviesList
            copyList.Add(movieItem)
        Next

        If copyList.Contains(currentMovie) Then
            For Each movie As String In moviesList
                If movie = currentMovie Then
                    copyList.Remove(currentMovie)
                    isAdd = False
                End If
            Next
        Else
            copyList.Add(currentMovie)
            isAdd = True
        End If

        Dim buildList As New Text.StringBuilder()
        For Each movieItem As String In copyList
            buildList.AppendLine(movieItem)
        Next

        File.Delete(itemsMyListsPath.SelectedItem.ToString())
        File.WriteAllText(Movieo.pathMyLists + itemsMyListsTitle.SelectedItem.ToString() + ".txt", buildList.ToString())
        If isAdd = True Then
            frmMovieDetails.showMessage(currentMovie + " added to " + itemsMyListsTitle.SelectedItem.ToString)
        Else
            frmMovieDetails.showMessage(currentMovie + " removed from " + itemsMyListsTitle.SelectedItem.ToString)
        End If
        Close()
    End Sub

#Region "Close Button"

    Private Sub meClose_Click(sender As Object, e As EventArgs) Handles meClose.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub meClose_MouseMove(sender As Object, e As MouseEventArgs) Handles meClose.MouseMove
        meClose.Image = My.Resources.PopupCloseH
    End Sub

    Private Sub meClose_MouseLeave(sender As Object, e As EventArgs) Handles meClose.MouseLeave
        meClose.Image = My.Resources.PopupCloseL
    End Sub

#End Region

End Class