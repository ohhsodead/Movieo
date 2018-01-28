Imports System.IO
Imports System.Text.RegularExpressions

Public Class frmCreateList

    Public replaceList As Boolean = False
    Public oldTitle As String = ""

    Private Sub frmRequestMovie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Location = Movieo.PointToScreen(Point.Empty)
        Size = Movieo.ClientSize

        If replaceList = True Then
            txtTitle.Text = oldTitle
            txtMovies.Visible = False
            underline2.Visible = False
        Else
            txtTitle.Text = ""
            txtDescription.Text = ""
            txtMovies.Visible = True
            underline2.Visible = True
        End If

        txtTitle.Focus()
    End Sub

    Dim invalidPathChars() As Char = Path.GetInvalidPathChars()

    Private Sub btnFormSubmit_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnFrmCreateList.ClickButtonArea
        Try
            If Not txtTitle.Text = "" Then
                If replaceList = True Then
                    showMessage("Saving your list...")
                    Dim moviesList() As String = File.ReadAllLines(Movieo.pathMyLists + oldTitle + ".txt")
                    Dim copyList As New List(Of String)

                    For Each movieItem As String In moviesList
                        copyList.Add(movieItem)
                    Next

                    Dim buildList As New Text.StringBuilder()
                    For Each movieItem As String In copyList
                        buildList.AppendLine(movieItem)
                    Next

                    File.Delete(Movieo.pathMyLists + oldTitle + ".txt")

                    File.WriteAllText(Movieo.pathMyLists + cleanListTitle(txtTitle.Text) + ".txt", buildList.ToString())
                    showMessage("Your list has been saved!")
                    Movieo.loadMyLists()
                    Close()
                Else
                    If Not File.Exists(Movieo.pathMyLists + txtTitle.Text + ".txt") Then
                        Try
                            showMessage("Creating your list...")
                            Dim movieInText As String() = Split(txtMovies.Text, ", ")
                            Dim buildList As New Text.StringBuilder()
                            For Each movieItem As String In movieInText
                                buildList.AppendLine(movieItem)
                            Next
                            File.WriteAllText(Movieo.pathMyLists + cleanListTitle(txtTitle.Text) + ".txt", buildList.ToString())
                            showMessage("You have successfully created a list!")
                            Movieo.loadMyLists()
                            Close()
                        Catch ex As Exception
                            showMessage("Unable to create list.")
                        End Try
                    Else
                        showMessage("List already exists.")
                    End If
                End If
            Else
                showMessage("Title can't be blank.")
            End If
        Catch ex As Exception
            showMessage("Unable to Create List")
            Movieo.ShowPopupOk("Unable to create list", ex.InnerException.Message, Me)
        End Try
    End Sub

    Private Function cleanListTitle(UserInput As String) As String
        For Each invalidChar In Path.GetInvalidFileNameChars
            UserInput = UserInput.Replace(invalidChar, "")
        Next
        Return UserInput
    End Function

    Private Sub BtnSubmitForm_MouseMove(sender As Object, e As EventArgs) Handles btnFrmCreateList.MouseMove, btnFrmCreateList.GotFocus
        sender.ForeColor = Color.White
        sender.BorderColor = Color.White
        sender.ColorFillSolid = Color.FromArgb(52, 59, 71)
    End Sub

    Private Sub BtnSubmitForm_MouseLeave(sender As Object, e As EventArgs) Handles btnFrmCreateList.MouseLeave, btnFrmCreateList.LostFocus
        sender.ForeColor = Color.FromArgb(172, 180, 191)
        sender.BorderColor = Color.FromArgb(86, 98, 115)
        sender.ColorFillSolid = Color.Transparent
    End Sub

#Region "Close Form"

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

    Private Sub MeClose_MouseClick(sender As Object, e As EventArgs) Handles meClose.MouseClick
        Close()
    End Sub

#End Region

#Region "Notification Message"

    Private Sub HideSettingsConfirmation_Tick(sender As Object, e As EventArgs) Handles timerHideNotifications.Tick
        lblStatus.Visible = False
        timerHideNotifications.Enabled = False
    End Sub

    Public Sub showMessage(Message As String)
        timerHideNotifications.Enabled = False

        lblStatus.Text = Message
        Dim myFont As New Font(lblStatus.Font.FontFamily, Me.lblStatus.Font.Size)
        Dim mySize = lblStatus.CreateGraphics.MeasureString(Message, myFont)

        lblStatus.Width = CType(Math.Round(mySize.Width, 0), Integer) + 20
        lblStatus.Height = CType(Math.Round(mySize.Height, 0), Integer) + 14
        lblStatus.Location = New Point((ClientSize.Width - lblStatus.Width) \ 2, -1)
        lblStatus.Visible = True
        timerHideNotifications.Enabled = True
    End Sub

#End Region

End Class