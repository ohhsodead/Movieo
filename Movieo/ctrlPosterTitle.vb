Option Explicit On
Imports System.ComponentModel
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net
Imports Newtonsoft.Json.Linq

Public Class ctrlPosterTitle

    Private Sub InfoPoster_Click(sender As Object, e As EventArgs) Handles imgPoster.Click
        ShowMovie()
    End Sub

    Public infoTitle As String
    Public infoYear As String
    Public infoCountry As String
    Public infoLanguage As String
    Public infoGenre As String
    Public infoPlot As String
    Public infoRuntime As String
    Public infoReleased As String
    Public infoRated As String
    Public infoProduction As String
    Public infoDirector As String
    Public infoWriter As String
    Public infoActors As String
    Public infoBoxOffice As String
    Public infoAwards As String
    Public infoImdbId As String
    Public infoImdbRating As String
    Public infoMetascore As String
    Public infoPosterUrl As String

    Public infoStreams As New List(Of Stream)

    Public infoFanartUrl As String
    Public infoTrailerUrl As String

    Public infoTagged As String

    Public Sub ShowMovie()
        Try
            'Prioritise already acquired information in the case of an error
            frmMovieDetails.infoTitle.Text = showTitle.Text
            frmMovieDetails.infoYear.Text = showYear.Text
            frmMovieDetails.infoCountry.Text = infoCountry
            frmMovieDetails.infoLanguage.Text = infoLanguage
            frmMovieDetails.infoImdbId = infoImdbId
            frmMovieDetails.infoRatingIMDb.Text = infoImdbRating
            frmMovieDetails.infoQuality.Text = ReturnHighestQuality(infoStreams)
            frmMovieDetails.infoPosterUrl = infoPosterUrl
            frmMovieDetails.infoFanartUrl = infoFanartUrl

            frmMovieDetails.infoDescription.Text = infoPlot
            frmMovieDetails.infoDuration.Text = infoRuntime
            frmMovieDetails.infoReleaseDate.Text = infoRated
            frmMovieDetails.infoRating.Text = infoRated
            frmMovieDetails.infoProduction.Text = infoProduction
            frmMovieDetails.infoBoxOffice.Text = infoBoxOffice
            frmMovieDetails.infoAwards.Text = infoAwards
            frmMovieDetails.infoTrailerUrl = infoTrailerUrl

            'Ratings
            frmMovieDetails.infoImdbId = infoImdbId
            frmMovieDetails.infoRatingIMDb.Text = infoImdbRating
            frmMovieDetails.infoRatingMetaScore.Text = infoMetascore
            frmMovieDetails.infoStreams = infoStreams

            Try
                'Split Director/Cast/Genres into clickable Labels to search

                Dim countDirector As Integer = 0
                frmMovieDetails.infoDirectors.Visible = False
                frmMovieDetails.infoDirectors.Text = infoDirector
                Dim directorInText() As String = Split(infoDirector, ", ")
                For Each director As String In directorInText.Reverse
                    countDirector = countDirector + 1
                    Dim aDirector As New Label
                    With aDirector
                        .AutoSize = True
                        .Font = Movieo.CreateFont("Segoe UI", 12.5, False, False, False)
                        .ForeColor = Color.FromArgb(150, 159, 170)
                        .Margin = New Padding(0, 13, 0, 0)
                        .Text = director
                        .BackColor = Color.Transparent
                        .Cursor = Cursors.Hand
                        .Name = director
                        .Show()
                        AddHandler .Click, AddressOf frmMovieDetails.searchItem_Click
                        AddHandler .MouseMove, AddressOf frmMovieDetails.searchItem_MouseMove
                        AddHandler .MouseLeave, AddressOf frmMovieDetails.searchItem_MouseLeave
                    End With
                    frmMovieDetails.InfoPanel1.Controls.Add(aDirector)
                    frmMovieDetails.InfoPanel1.Controls.SetChildIndex(aDirector, frmMovieDetails.InfoPanel1.Controls.IndexOf(frmMovieDetails.lblSubDirectors) + 1)
                    frmMovieDetails.dynControls.Add(aDirector)
                    If countDirector = 1 Then
                        frmMovieDetails.InfoPanel1.SetFlowBreak(aDirector, True)
                    End If
                Next

                frmMovieDetails.infoCast.Visible = False
                frmMovieDetails.infoCast.Text = infoActors
                Dim castInText() As String = Split(infoActors, ", ")
                For Each cast As String In castInText.Reverse
                    Dim aCast As New Label
                    With aCast
                        .AutoSize = True
                        .Font = Movieo.CreateFont("Segoe UI", 12.5, False, False, False)
                        .ForeColor = Color.FromArgb(150, 159, 170)
                        .Margin = New Padding(0, 7, 0, 0)
                        .Text = cast
                        .BackColor = Color.Transparent
                        .Cursor = Cursors.Hand
                        .Name = cast
                        .Show()
                        AddHandler .Click, AddressOf frmMovieDetails.searchItem_Click
                        AddHandler .MouseMove, AddressOf frmMovieDetails.searchItem_MouseMove
                        AddHandler .MouseLeave, AddressOf frmMovieDetails.searchItem_MouseLeave
                    End With
                    frmMovieDetails.InfoPanel1.Controls.Add(aCast)
                    frmMovieDetails.InfoPanel1.Controls.SetChildIndex(aCast, frmMovieDetails.InfoPanel1.Controls.IndexOf(frmMovieDetails.lblSubCast) + 1)
                    frmMovieDetails.dynControls.Add(aCast)
                Next

                frmMovieDetails.infoGenre.Visible = False
                frmMovieDetails.infoGenre.Text = infoGenre
                Dim countGenres As Integer = 0
                Dim genresInText() As String = Split(infoGenre, ", ")
                For Each genre As String In genresInText.Reverse
                    Dim aGenre As New Label
                    With aGenre
                        .AutoSize = True
                        .Font = Movieo.CreateFont("Segoe UI", 12.25, False, False, False)
                        .ForeColor = Color.FromArgb(172, 180, 191)
                        .Margin = New Padding(3, 5, 0, 20)
                        .Text = genre
                        .BackColor = Color.Transparent
                        .Cursor = Cursors.Hand
                        .Name = genre
                        .Show()
                        AddHandler .Click, AddressOf frmMovieDetails.genreItem_Click
                        AddHandler .MouseMove, AddressOf frmMovieDetails.genreItem_MouseMove
                        AddHandler .MouseLeave, AddressOf frmMovieDetails.genreItem_MouseLeave
                    End With
                    frmMovieDetails.InfoPanel1.Controls.Add(aGenre)
                    frmMovieDetails.InfoPanel1.Controls.SetChildIndex(aGenre, 3)
                    frmMovieDetails.dynControls.Add(aGenre)
                Next
            Catch
            End Try

            Try
                frmMovieDetails.imgPoster.BackgroundImage = New Bitmap(New MemoryStream(WebClient.DownloadData(infoPosterUrl)))
            Catch
            End Try

            Try
                frmBackgroundMovieDetails.BackgroundImage = ChangeOpacity(New Bitmap(New MemoryStream(WebClient.DownloadData(infoFanartUrl))), 0.8)
                frmBackgroundMovieDetails.Opacity = 1
                frmMovieDetails.Opacity = 0.8
            Catch
                frmBackgroundMovieDetails.Opacity = 0
            End Try

            frmMovieDetails.Show(frmBackgroundMovieDetails)
            frmBackgroundMovieDetails.Show(Movieo)
        Catch ex As Exception
            'False Positive (Ignore exception)
        End Try
    End Sub

    Private Sub InfoPoster_MouseEnter(sender As Object, e As EventArgs) Handles imgPoster.MouseEnter
        Try
            If Not imgPosterDefault.Image Is Nothing Then
                imgPosterDefault.Image.Dispose()
            End If
            imgPosterDefault.Image = New Bitmap(imgPoster.BackgroundImage)
            imgPoster.BorderShow = True
            imgPoster.BackgroundImage.Dispose()
            imgPoster.BackgroundImage = ChangeOpacity(imgPosterDefault.Image, 0.4)
            If My.Settings.doRatingOnPoster = True Then
                showImdbRating.Visible = True
            End If
            Update()
        Catch
        End Try
    End Sub

    Private Sub InfoPoster_MouseLeave(sender As Object, e As EventArgs) Handles imgPoster.MouseLeave
        Try
            showImdbRating.Visible = False
            imgPoster.BackgroundImage.Dispose()
            imgPoster.BorderShow = False
            imgPoster.BackgroundImage = ChangeOpacity(imgPosterDefault.Image, 1)
        Catch
        End Try
    End Sub

    Public Shared Function ChangeOpacity(ByVal img As Image, ByVal opacityvalue As Single) As Bitmap
        Try
            Dim bmp As New Bitmap(img.Width, img.Height)
            Dim graphics__1 As Graphics = Graphics.FromImage(bmp)
            Dim colormatrix As New ColorMatrix
            colormatrix.Matrix33 = opacityvalue
            Dim imgAttribute As New ImageAttributes
            imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.[Default], ColorAdjustType.Bitmap)
            graphics__1.DrawImage(img, New Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height,
            GraphicsUnit.Pixel, imgAttribute)
            graphics__1.Dispose()
            Return bmp
        Catch
            Return Nothing
        End Try
    End Function

    Private Shared WebClient As New WebClient()

    Private Sub MovieTitle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = Movieo.panelMovies.BackColor

        showImdbRating.Parent = imgPoster
        showImdbRating.BackColor = Color.Transparent
        showImdbRating.ShowFocus = CButtonLib.CButton.eFocus.None
        showImdbRating.BringToFront()
        showImdbRating.Location = New Point(64, 8)
        showImdbRating.Visible = False
    End Sub

#Region "Get Quality from URL File Name"

    Public Function ReturnHighestQuality(URLs As List(Of Stream)) As String
        For Each Url In URLs
            If Url.URL.ToLower.Contains("1080") Then
                Return "1080p"
            ElseIf Url.URL.ToLower.Contains("hdts") Then
                Return "1080p"
            ElseIf Url.URL.ToLower.Contains("bdrip") Then
                Return "1080p"
            ElseIf Url.URL.ToLower.Contains("bd-rip") Then
                Return "1080p"
            ElseIf Url.URL.ToLower.Contains("720") Then
                Return "720p"
            ElseIf Url.URL.ToLower.Contains("webdl") Then
                Return "720p"
            ElseIf Url.URL.ToLower.Contains("web-dl") Then
                Return "720p"
            ElseIf Url.URL.ToLower.Contains("dvdrip") Then
                Return "720p"
            ElseIf Url.URL.ToLower.Contains("dvd-rip") Then
                Return "720p"
            ElseIf Url.URL.ToLower.Contains("hdrip") Then
                Return "720p"
            ElseIf Url.URL.ToLower.Contains("hd-rip") Then
                Return "720p"
            ElseIf Url.URL.ToLower.Contains("hdtv") Then
                Return "720p"
            ElseIf Url.URL.ToLower.Contains("480") Then
                Return "480p"
            ElseIf Url.URL.ToLower.Contains("camrip") Then
                Return "CAM"
            Else
                Return "n/a"
            End If
        Next
        Return "n/a"
    End Function

#End Region

End Class