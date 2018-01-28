Imports System.ComponentModel
Imports System.Net
Imports System.Text.RegularExpressions

Public Class frmMovieDetails

    Public infoPosterUrl As String
    Public infoSources As String()
    Public infoImdbId As String
    Public infoFanartUrl As String
    Public infoTrailerUrl As String

#Region "Lists Button Icons"

    Public imgFavouriteH As Bitmap = My.Resources.Favourite_H
    Public imgFavouriteL As Bitmap = My.Resources.Favourite_L
    Public imgFavouriteSticky As Bitmap = My.Resources.Favourite_H_STICKY
    '
    Public imgWatchListH As Bitmap = My.Resources.Watch_List_H
    Public imgWatchListL As Bitmap = My.Resources.Watch_List_L
    Public imgWatchListSticky As Bitmap = My.Resources.Watch_List_H_STICKY
    '
    Public imgSeenListH As Bitmap = My.Resources.Seen_List_H
    Public imgSeenListL As Bitmap = My.Resources.Seen_List_L
    Public imgSeenListSticky As Bitmap = My.Resources.Seen_List_H_STICKY
    '
    Public imgBlackListH As Bitmap = My.Resources.Black_List_Icon_H
    Public imgBlackListL As Bitmap = My.Resources.Black_List_Icon_L
    Public imgBlackListSticky As Bitmap = My.Resources.Black_List_H_STICKY
    '
    Public imgMyListsH As Bitmap = My.Resources.My_Lists_H
    Public imgMyListsL As Bitmap = My.Resources.My_Lists_L

#End Region

    Private Sub MovieInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Hide()
            Location = Movieo.PointToScreen(Point.Empty)
            Size = Movieo.ClientSize

            If Movieo.listFavourites.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
                btnFavouriteList.Image = imgFavouriteSticky
            Else
                btnFavouriteList.Image = imgFavouriteL
            End If

            If Movieo.listWatchList.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
                btnWatchList.Image = imgWatchListSticky
            Else
                btnWatchList.Image = imgWatchListL
            End If

            If Movieo.listSeenList.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
                btnSeenList.Image = imgSeenListSticky
            Else
                btnSeenList.Image = imgSeenListL
            End If

            If Movieo.listBlackList.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
                btnBlackList.Image = imgBlackListSticky
            Else
                btnBlackList.Image = imgBlackListL
            End If

            panelHeaders.Size = New Size(InfoPanel1.Size.Width, InfoPanel1.Size.Height)

            'Download button (settings)
            If My.Settings.doDownloadBtn = True Then
                btnDownloadMovie.Visible = True
            Else
                btnDownloadMovie.Visible = False
            End If

            btnWatchTrailer.Location = imgPoster.PointToClient(btnWatchTrailer.Parent.PointToScreen(btnWatchTrailer.Location))
            btnWatchTrailer.Parent = imgPoster
            btnWatchTrailer.BackColor = Color.Transparent
            btnWatchTrailer.BringToFront()
            btnWatchTrailer.Location = New Point((imgPoster.Width - btnWatchTrailer.Width) \ 2, (imgPoster.Height - btnWatchTrailer.Height) \ 2)

            'If Popcorn Time API doesn't have trailer available
            If infoTrailerUrl = "" Then
                btnWatchTrailer.Visible = False
            Else
                btnWatchTrailer.Visible = True
            End If
            Show()
        Catch ex As Exception
            Movieo.ShowPopupOk("Unable to load movie details", ex.Message, Me)
        End Try
    End Sub

#Region "Searchable Labels Events"

    Public Sub searchItem_Click(sender As Object, e As EventArgs)
        Try
            If Not sender.Text = "N/A" Then
                frmBackgroundMovieDetails.Hide()
                Hide()
                Movieo.txtboxSearch.Focus()
                Movieo.txtboxSearch.Text = sender.text
                Movieo.Tab.SelectedTab = Movieo.tabLoading
                Movieo.timerSearchMovies.Enabled = True
                Close()
            End If
        Catch ex As Exception
            'False Positive
        End Try
    End Sub

    Public Sub searchItem_MouseMove(sender As Object, e As EventArgs)
        sender.ForeColor = Color.White
    End Sub

    Public Sub searchItem_MouseLeave(sender As Object, e As EventArgs)
        sender.ForeColor = Color.FromArgb(150, 159, 170)
    End Sub

    Public Sub genreItem_MouseMove(sender As Object, e As EventArgs)
        sender.ForeColor = Color.White
    End Sub

    Public Sub genreItem_MouseLeave(sender As Object, e As EventArgs)
        sender.ForeColor = Color.FromArgb(172, 180, 191)
    End Sub

    Public Sub genreItem_Click(sender As Object, e As EventArgs)
        frmBackgroundMovieDetails.Hide()
        Hide()
        For Each a As Control In Movieo.panelGenresCtrls.Controls
            If sender.Text = a.Text Then
                a.BackColor = Color.FromArgb(43, 50, 61)
                a.ForeColor = Color.White
            Else
                a.BackColor = Color.FromArgb(24, 32, 45)
                a.ForeColor = Color.FromArgb(161, 168, 179)
            End If
        Next

        Movieo.panelMovies.Controls.Clear()
        Movieo.storeControlsScroll.Clear()

        Movieo.selectedGenre = sender.Text

        Dim countMovie As Integer = 0

        For Each a In Movieo.storeControlsAllMovies
            For Each ab As Control In a.Controls
                If ab.Name = "InfoGenre" Then
                    If ab.Text.ToLower.Contains(sender.Text.ToString.ToLower) Then
                        countMovie = countMovie + 1
                        If countMovie <= 40 Then
                            Movieo.panelMovies.Controls.Add(a)
                        Else
                            Movieo.storeControlsScroll.Add(a)
                        End If
                    End If
                End If
            Next
        Next
        Close()
    End Sub
#End Region

#Region "Close Button"

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

#End Region

#Region "Lists Buttons"

    Private Sub BtnFavouriteList_MouseMove(sender As Object, e As MouseEventArgs) Handles btnFavouriteList.MouseMove
        If Movieo.listFavourites.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            btnFavouriteList.Image = imgFavouriteSticky
        Else
            btnFavouriteList.Image = imgFavouriteH
        End If
    End Sub

    Private Sub BtnFavouriteList_MouseLeave(sender As Object, e As EventArgs) Handles btnFavouriteList.MouseLeave
        If Movieo.listFavourites.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            btnFavouriteList.Image = imgFavouriteSticky
        Else
            btnFavouriteList.Image = imgFavouriteL
        End If
    End Sub

    Private Sub BtnFavouriteList_Click(sender As Object, e As EventArgs) Handles btnFavouriteList.Click
        If Movieo.listFavourites.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            Movieo.removeMovieFromCoreList(Movieo.panelLibraryFavourites, Movieo.listFavourites, infoTitle.Text, infoYear.Text, infoImdbId)
            btnFavouriteList.Image = imgFavouriteL
            showMessage(infoTitle.Text + " (" + infoYear.Text + ")" + " removed from Favourites")
        Else
            Movieo.addMovieToCoreList(Movieo.panelLibraryFavourites, Movieo.listFavourites, infoTitle.Text, infoYear.Text, infoImdbId)
            btnFavouriteList.Image = imgFavouriteSticky
            showMessage(infoTitle.Text + " (" + infoYear.Text + ")" + " added to Favourites")
        End If
    End Sub

    Private Sub BtnWatchList_MouseMove(sender As Object, e As MouseEventArgs) Handles btnWatchList.MouseMove
        If Movieo.listWatchList.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            btnWatchList.Image = imgWatchListSticky
        Else
            btnWatchList.Image = imgWatchListH
        End If
    End Sub

    Private Sub BtnWatchList_MouseLeave(sender As Object, e As EventArgs) Handles btnWatchList.MouseLeave
        If Movieo.listWatchList.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            btnWatchList.Image = imgWatchListSticky
        Else
            btnWatchList.Image = imgWatchListL
        End If
    End Sub

    Private Sub btnWatchList_Click(sender As Object, e As EventArgs) Handles btnWatchList.Click
        If Movieo.listWatchList.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            Movieo.removeMovieFromCoreList(Movieo.panelLibraryWatchList, Movieo.listWatchList, infoTitle.Text, infoYear.Text, infoImdbId)
            btnWatchList.Image = imgWatchListL
            showMessage(infoTitle.Text + " (" + infoYear.Text + ")" + " removed from Watch List")
        Else
            Movieo.addMovieToCoreList(Movieo.panelLibraryWatchList, Movieo.listWatchList, infoTitle.Text, infoYear.Text, infoImdbId)
            btnWatchList.Image = imgWatchListSticky
            showMessage(infoTitle.Text + " (" + infoYear.Text + ")" + " added to Watch List")

            If Movieo.listSeenList.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
                Movieo.removeMovieFromCoreList(Movieo.panelLibrarySeenList, Movieo.listSeenList, infoTitle.Text, infoYear.Text, infoImdbId)
                btnSeenList.Image = imgSeenListL
            End If

            If Movieo.listBlackList.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
                Movieo.removeMovieFromCoreList(Movieo.panelLibraryBlackList, Movieo.listBlackList, infoTitle.Text, infoYear.Text, infoImdbId)
                btnBlackList.Image = imgBlackListL
            End If
        End If
    End Sub

    Private Sub btnSeenList_MouseMove(sender As Object, e As MouseEventArgs) Handles btnSeenList.MouseMove
        If Movieo.listSeenList.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            btnSeenList.Image = imgSeenListSticky
        Else
            btnSeenList.Image = imgSeenListH
        End If
    End Sub

    Private Sub btnSeenList_MouseLeave(sender As Object, e As EventArgs) Handles btnSeenList.MouseLeave
        If Movieo.listSeenList.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            btnSeenList.Image = imgSeenListSticky
        Else
            btnSeenList.Image = imgSeenListL
        End If
    End Sub

    Private Sub btnSeenList_Click(sender As Object, e As EventArgs) Handles btnSeenList.Click
        If Movieo.listSeenList.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            Movieo.removeMovieFromCoreList(Movieo.panelLibrarySeenList, Movieo.listSeenList, infoTitle.Text, infoYear.Text, infoImdbId)
            btnSeenList.Image = imgSeenListL
            showMessage(infoTitle.Text + " (" + infoYear.Text + ")" + " removed from Seen List")
        Else
            Movieo.addMovieToCoreList(Movieo.panelLibrarySeenList, Movieo.listSeenList, infoTitle.Text, infoYear.Text, infoImdbId)
            btnSeenList.Image = imgSeenListSticky
            showMessage(infoTitle.Text + " (" + infoYear.Text + ")" + " added to Seen List")

            If Movieo.listWatchList.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
                Movieo.removeMovieFromCoreList(Movieo.panelLibraryWatchList, Movieo.listWatchList, infoTitle.Text, infoYear.Text, infoImdbId)
                btnWatchList.Image = imgWatchListL
            End If

            If Movieo.listBlackList.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
                Movieo.removeMovieFromCoreList(Movieo.panelLibraryBlackList, Movieo.listBlackList, infoTitle.Text, infoYear.Text, infoImdbId)
                btnBlackList.Image = imgBlackListL
            End If
        End If
    End Sub

    Private Sub BtnBlackList_MouseMove(sender As Object, e As MouseEventArgs) Handles btnBlackList.MouseMove
        If Movieo.listBlackList.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            btnBlackList.Image = imgBlackListSticky
        Else
            btnBlackList.Image = imgBlackListH
        End If
    End Sub

    Private Sub BtnBlackList_MouseLeave(sender As Object, e As EventArgs) Handles btnBlackList.MouseLeave
        If Movieo.listBlackList.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            btnBlackList.Image = imgBlackListSticky
        Else
            btnBlackList.Image = imgBlackListL
        End If
    End Sub

    Private Sub BtnBlackList_Click(sender As Object, e As EventArgs) Handles btnBlackList.Click
        If Movieo.listBlackList.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
            Movieo.removeMovieFromCoreList(Movieo.panelLibraryBlackList, Movieo.listBlackList, infoTitle.Text, infoYear.Text, infoImdbId)
            btnBlackList.Image = imgBlackListL
            showMessage(infoTitle.Text + " (" + infoYear.Text + ")" + " removed from Black List")
        Else
            Movieo.addMovieToCoreList(Movieo.panelLibraryBlackList, Movieo.listBlackList, infoTitle.Text, infoYear.Text, infoImdbId)
            btnBlackList.Image = imgBlackListSticky
            showMessage(infoTitle.Text + " (" + infoYear.Text + ")" + " added to Black List")

            If Movieo.listWatchList.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
                Movieo.removeMovieFromCoreList(Movieo.panelLibraryWatchList, Movieo.listWatchList, infoTitle.Text, infoYear.Text, infoImdbId)
                btnWatchList.Image = imgWatchListL
            End If

            If Movieo.listSeenList.Contains(infoTitle.Text + " (" + infoYear.Text + ")") Then
                Movieo.removeMovieFromCoreList(Movieo.panelLibrarySeenList, Movieo.listSeenList, infoTitle.Text, infoYear.Text, infoImdbId)
                btnSeenList.Image = imgSeenListL
            End If
        End If
    End Sub


    Private Sub btnMyList_MouseMove(sender As Object, e As MouseEventArgs) Handles btnMyList.MouseMove
        btnMyList.Image = imgMyListsH
    End Sub

    Private Sub btnMyList_MouseLeave(sender As Object, e As EventArgs) Handles btnMyList.MouseLeave
        btnMyList.Image = imgMyListsL
    End Sub

    Private Sub btnMyList_Click(sender As Object, e As EventArgs) Handles btnMyList.Click
        listAddRemove(infoTitle.Text + " (" + infoYear.Text + ")")
    End Sub

    Public Sub listAddRemove(Title As String)
        Try
            Dim a As New frmSelectList
            a.TopLevel = True
            a.currentMovie = Title

            a.itemsMyListsTitle.Items.Clear()
            a.itemsMyListsPath.Items.Clear()

            Dim exts As String() = {"*.txt"}
            Dim fileNames = My.Computer.FileSystem.GetFiles(Movieo.pathMyLists, FileIO.SearchOption.SearchTopLevelOnly, exts)

            For Each fileName As String In fileNames
                Dim cutFileName As String = fileName.Replace(Movieo.pathMyLists, "")
                a.itemsMyListsTitle.Items.Add(cutFileName.Substring(0, cutFileName.Length - 4))
                a.itemsMyListsPath.Items.Add(fileName)
            Next
            a.ShowDialog()
        Catch ex As Exception
            showMessage("Unable to add/remove movie to list.")
        End Try
    End Sub

#End Region

#Region "Watch Movie, Download Movie & Watch Trailer (beta)"

    Public IsMovieUrlContextOpen As Boolean = False

    Private Sub btnWatchMovie_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnWatchMovie.ClickButtonArea
        Try
            If infoFanartUrl = "" Then
                frmSelectSource.Opacity = 0.98
            Else
                frmSelectSource.Opacity = 0.85
            End If

            Dim getUrlFromUser As String = Movieo.returnSource(Me, infoTitle.Text + " (" + infoYear.Text + ")", infoSources, "watch")

            If Not getUrlFromUser = Nothing Then
                frmMediaPlayer.Text = "Watching " + infoTitle.Text + " (" + infoYear.Text + ")"
                frmMediaPlayer.MediaPlayerControl.URL = getUrlFromUser
                frmMediaPlayer.Show(Me)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnWatchMovie_MouseMove(sender As Object, e As MouseEventArgs) Handles btnWatchMovie.MouseMove
        sender.ForeColor = Color.White
        sender.BorderColor = Color.FromArgb(87, 102, 125)
        sender.ColorFillSolid = Color.FromArgb(87, 102, 125)

        sender.SideImage = My.Resources.ArrowDownSpaceH
        sender.SideImageSize = New Size(32, 18)
    End Sub

    Private Sub btnWatchMovie_MouseLeave(sender As Object, e As EventArgs) Handles btnWatchMovie.MouseLeave
        sender.ForeColor = Color.FromArgb(172, 180, 191)
        sender.BorderColor = Color.FromArgb(60, 70, 85)
        sender.ColorFillSolid = Color.FromArgb(60, 70, 85)

        sender.SideImage = My.Resources.ArrowDownSpace
        sender.SideImageSize = New Size(32, 18)
    End Sub

    Private Sub btnWatchTrailer_Click(Sender As Object, e As MouseEventArgs) Handles btnWatchTrailer.Click
        Try
            If Not infoTrailerUrl = "" Then
                frmTrailerPlayer.swfPlayer.Movie = infoTrailerUrl.Replace("watch?v=", "v/") 'Valid Example: https://youtube.com/v/kmJLuwP3MbY
                frmTrailerPlayer.Show(Me)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnDownloadMovie_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnDownloadMovie.ClickButtonArea
        Try
            If infoFanartUrl = "" Then
                frmSelectSource.Opacity = 0.98
            Else
                frmSelectSource.Opacity = 0.85
            End If

            Dim getUrlFromUser As String = Movieo.returnSource(Me, infoTitle.Text + " (" + infoYear.Text + ")", infoSources, "download")

            If Not getUrlFromUser = Nothing Then
                frmDownloadClient.doDownload(getUrlFromUser, infoTitle.Text, infoYear.Text)
                frmDownloadClient.Show()
            End If
        Catch ex As Exception
            Show()
            Movieo.ShowPopupOk("Unable to download movie", "It seems there's an issue connecting to the stream. Please try using a different source. ", Me)
        End Try
    End Sub

    Private Sub btnWatchDownloads_MouseMove(sender As Object, e As MouseEventArgs) Handles btnDownloadMovie.MouseMove
        sender.ForeColor = Color.White
        sender.BorderColor = Color.FromArgb(87, 102, 125)
        sender.ColorFillSolid = Color.FromArgb(87, 102, 125)
    End Sub

    Private Sub btnWatchDownloads_MouseLeave(sender As Object, e As EventArgs) Handles btnDownloadMovie.MouseLeave
        sender.ForeColor = Color.FromArgb(172, 180, 191)
        sender.BorderColor = Color.FromArgb(60, 70, 85)
        sender.ColorFillSolid = Color.FromArgb(60, 70, 85)
    End Sub

#End Region

#Region "Go to Movie on Website (IMDb)"

    Private Sub ImgImdb_Click(sender As Object, e As EventArgs) Handles infoRatingIMDb.Click, imgImdb.Click
        Try
            Process.Start("http://www.imdb.com/title/" + infoImdbId)
        Catch ex As Exception
            Movieo.ShowPopupOk("Unable to open URL", ex.Message, Me)
        End Try
    End Sub

    Private Sub frmMovieDetails_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Show()
    End Sub

#End Region


#Region "Notification Message"

    Private Sub timerHideNotification_Tick(sender As Object, e As EventArgs) Handles timerHideNotifications.Tick
        lblStatus.Visible = False
        timerHideNotifications.Enabled = False
    End Sub

    Private Sub lblMessageSent_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles lblStatus.ClickButtonArea
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
        TimeStamp = Date.Now
        timerHideNotifications.Enabled = True
    End Sub

    Dim TimeStamp As Date

    Public Shared Function TimeAgo(dt As Date) As String
        Dim span As TimeSpan = DateTime.Now - dt
        If span.Days > 365 Then
            Dim years As Integer = (span.Days / 365)
            If span.Days Mod 365 <> 0 Then
                years += 1
            End If
            Return [String].Format("about {0} {1} ago", years, If(years = 1, "year", "years"))
        End If
        If span.Days > 30 Then
            Dim months As Integer = (span.Days / 30)
            If span.Days Mod 31 <> 0 Then
                months += 1
            End If
            Return [String].Format("about {0} {1} ago", months, If(months = 1, "month", "months"))
        End If
        If span.Days > 0 Then
            Return [String].Format("about {0} {1} ago", span.Days, If(span.Days = 1, "day", "days"))
        End If
        If span.Hours > 0 Then
            Return [String].Format("about {0} {1} ago", span.Hours, If(span.Hours = 1, "hour", "hours"))
        End If
        If span.Minutes > 0 Then
            Return [String].Format("about {0} {1} ago", span.Minutes, If(span.Minutes = 1, "minute", "minutes"))
        End If
        If span.Seconds > 5 Then
            Return [String].Format("about {0} seconds ago", span.Seconds)
        End If
        If span.Seconds <= 5 Then
            Return "just now"
        End If
        Return String.Empty
    End Function

#End Region

#Region "Cast Items (Remove on Form Close)"

    Public dynControls As New List(Of Label)

    Private Sub frmMovieDetails_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        Try
            dynControls.Clear()
            frmBackgroundMovieDetails.Close()
        Catch ex As Exception
        End Try
    End Sub

#End Region

    Private Sub btnWatchMovie_SideImageClicked(Sender As Object, e As MouseEventArgs) Handles btnWatchMovie.SideImageClicked
        ctrlContextMenuPlayer.Location = Sender.PointToScreen(Point.Empty)
        ctrlContextMenuPlayer.Size = New Size(ctrlContextMenuPlayer.Size.Width, ctrlContextMenuPlayer.Size.Height)
        ctrlContextMenuPlayer.Show()
    End Sub

    Private Sub btnWatchTrailer_Click(sender As Object, e As EventArgs) Handles btnWatchTrailer.Click

    End Sub
End Class