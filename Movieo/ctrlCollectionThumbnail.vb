Option Explicit On
Imports System.Drawing.Imaging

Public Class ctrlCollectionThumbnail

    Private Sub imgCollectionThumbnail_ClickButtonArea(sender As Object, e As EventArgs) Handles imgCollectionThumbnail.ClickButtonArea
        Movieo.panelCollectionsMovies.Controls.Clear()

        Movieo.lblCollectionsTitle.Text = lblCollectionTitle.Text
        Movieo.lblCollectionsComment.Text = lblCollectionDescription.Text

        Dim countMovie As Integer = 0
        For Each a As ctrlPosterTitle In Movieo.storeControlsAllMovies
            If itemsCollectionMovies.Items.Contains(a.infoImdbId) Then
                countMovie = countMovie + 1
                If countMovie <= 40 Then
                    Movieo.panelCollectionsMovies.Controls.Add(a)
                Else
                    Movieo.storeControlsCollectionsScroll.Add(a)
                End If
            End If
        Next

        Dim countSeen As Integer = 0
        For Each a As String In itemsCollectionMovies.Items
            Try
                If Movieo.listSeenList.Contains(Movieo.returnMovieTitle(a)) Then
                    countSeen = countSeen + 1
                End If
            Catch
            End Try
        Next

        Movieo.lblCollectionMoviesWatched.Text = CStr(countSeen) + "/" + itemsCollectionMovies.Items.Count.ToString + " movies watched"

        Movieo.tabsCollections.SelectedTab = Movieo.tabCollectionsMovies
    End Sub

    Private Sub InfoPoster_MouseEnter(sender As Object, e As EventArgs) Handles imgCollectionThumbnail.MouseEnter
        Try
            If Not imgCollectionThumbnailDefault.Image Is Nothing Then
                imgCollectionThumbnailDefault.Image.Dispose()
            End If
            imgCollectionThumbnailDefault.Image = New Bitmap(imgCollectionThumbnail.BackgroundImage)
            imgCollectionThumbnail.BorderShow = True
            imgCollectionThumbnail.BackgroundImage.Dispose()
            imgCollectionThumbnail.BackgroundImage = ChangeOpacity(imgCollectionThumbnailDefault.Image, 0.4)
            Update()
        Catch
        End Try
    End Sub

    Private Sub InfoPoster_MouseLeave(sender As Object, e As EventArgs) Handles imgCollectionThumbnail.MouseLeave
        Try
            imgCollectionThumbnail.BackgroundImage.Dispose()
            imgCollectionThumbnail.BorderShow = False
            imgCollectionThumbnail.BackgroundImage = ChangeOpacity(imgCollectionThumbnailDefault.Image, 1)
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

    Private Sub MovieTitle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = Movieo.panelMovies.BackColor
    End Sub

#Region "Get Quality"

    Public Function ReturnQuality(Link As String) As String
        If Link.ToLower.Contains("1080") Then
            Return "1080p"
        ElseIf Link.ToLower.Contains("hdts") Then
            Return "1080p"
        ElseIf Link.ToLower.Contains("bdrip") Then
            Return "1080p"
        ElseIf Link.ToLower.Contains("bd-rip") Then
            Return "1080p"
        ElseIf Link.ToLower.Contains("720") Then
            Return "720p"
        ElseIf Link.ToLower.Contains("webdl") Then
            Return "720p"
        ElseIf Link.ToLower.Contains("web-dl") Then
            Return "720p"
        ElseIf Link.ToLower.Contains("dvdrip") Then
            Return "720p"
        ElseIf Link.ToLower.Contains("dvd-rip") Then
            Return "720p"
        ElseIf Link.ToLower.Contains("hdrip") Then
            Return "720p"
        ElseIf Link.ToLower.Contains("hd-rip") Then
            Return "720p"
        ElseIf Link.ToLower.Contains("hdtv") Then
            Return "720p"
        ElseIf Link.ToLower.Contains("480") Then
            Return "480p"
        ElseIf Link.ToLower.Contains("camrip") Then
            Return "CAM"
        Else
            Return "n/a"
        End If
    End Function

#End Region

End Class