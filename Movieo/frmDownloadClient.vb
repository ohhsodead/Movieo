Imports System.ComponentModel
Imports System.Net

Public Class frmDownloadClient

    Private Sub DownloadClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Location = Movieo.PointToScreen(Point.Empty)
        Size = Movieo.ClientSize

        lblProgress.Text = "Connecting"
        BtnCancel.Text = "Cancel"
    End Sub

    Dim client As WebClient = New WebClient

    Dim TitleAndYear As String
    Dim Title As String

    Public Sub doDownload(MovieLink As String, MovieTitle As String, MovieYear As String)
        Try
            lblProgress.Text = "Connecting"
            If Not My.Computer.FileSystem.DirectoryExists(Movieo.pathDownloads) Then
                My.Computer.FileSystem.CreateDirectory(Movieo.pathDownloads)
            End If
            TitleAndYear = MovieTitle + " (" + MovieYear + ")"
            Title = MovieTitle
            Dim DownloadDirectory As String = Movieo.pathDownloads + TitleAndYear + "." + MovieLink.Substring(MovieLink.Length - 3)
            lblLocation.Text = DownloadDirectory
            AddHandler client.DownloadProgressChanged, AddressOf client_ProgressChanged
            AddHandler client.DownloadFileCompleted, AddressOf client_DownloadCompleted
            SW = Stopwatch.StartNew
            client.DownloadFileAsync(New Uri(MovieLink), DownloadDirectory)
        Catch ex As Exception
            lblProgress.Text = "Download Failed :/"
            Movieo.ShowPopupOk("Unable to download movie", ex.Message, Me)
        End Try
    End Sub

    Dim SW As Stopwatch
    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Try
            lblMovieTitle.Text = TitleAndYear
            lblMovieTitle.Visible = True
            prgbarStatus.Visible = True
            bgStatus.Visible = True
            lblTitleSize.Visible = True
            lblTitleSpeed.Visible = True
            lblTitleLocation.Visible = True
            lblSize.Visible = True
            lblSpeed.Visible = True
            lblLocation.Visible = True

            Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
            Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
            Dim percentage As Double = bytesIn / totalBytes * 100

            prgbarStatus.Value = Int32.Parse(Math.Truncate(percentage).ToString())

            lblProgress.Text = "Downloading " + "(" + prgbarStatus.Value.ToString + "%)"
            Dim SmallFormat As String = FormatBytes(e.BytesReceived).ToString
            lblSize.Text = SmallFormat + "/" + FormatBytes(e.TotalBytesToReceive)
            lblSpeed.Text = (e.BytesReceived / SW.ElapsedMilliseconds).ToString + " KB/Sec"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)
        Try
            If Not e.Cancelled AndAlso e.Error Is Nothing Then
                lblProgress.Text = "Download Completed!"
                BtnCancel.Text = "Close"

                lblMovieTitle.Visible = False
                prgbarStatus.Visible = False
                bgStatus.Visible = False
                lblTitleSize.Visible = False
                lblTitleSpeed.Visible = False
                lblTitleLocation.Visible = False
                lblSize.Visible = False
                lblSpeed.Visible = False
                lblLocation.Visible = False
            Else
                lblProgress.Text = "Download Failed :("
                BtnCancel.Text = "Close"

                lblMovieTitle.Visible = False
                prgbarStatus.Visible = False
                bgStatus.Visible = False
                lblTitleSize.Visible = False
                lblTitleSpeed.Visible = False
                lblTitleLocation.Visible = False
                lblSize.Visible = False
                lblSpeed.Visible = False
                lblLocation.Visible = False

                Movieo.ShowPopupOk("Unable to download movie.", e.Error.InnerException.Message, Me)
            End If
        Catch ex As Exception
        End Try
    End Sub

    'Bytes to Megabytes by Creator
    Dim DoubleBytes As Double
    Public Function FormatBytes(ByVal BytesCaller As ULong) As String
        Try
            Select Case BytesCaller
                Case Is >= 1099511627776
                    DoubleBytes = CDbl(BytesCaller / 1099511627776) 'TB
                    Return FormatNumber(DoubleBytes, 2) & " TB"
                Case 1073741824 To 1099511627775
                    DoubleBytes = CDbl(BytesCaller / 1073741824) 'GB
                    Return FormatNumber(DoubleBytes, 2) & " GB"
                Case 1048576 To 1073741823
                    DoubleBytes = CDbl(BytesCaller / 1048576) 'MB
                    Return FormatNumber(DoubleBytes, 2) & " MB"
                Case 1024 To 1048575
                    DoubleBytes = CDbl(BytesCaller / 1024) 'KB
                    Return FormatNumber(DoubleBytes, 2) & " KB"
                Case 0 To 1023
                    DoubleBytes = BytesCaller 'bytes
                    Return FormatNumber(DoubleBytes, 2) & " bytes"
                Case Else
                    Return ""
            End Select
        Catch
            Return ""
        End Try
    End Function

    Private Sub CButton2_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles BtnCancel.ClickButtonArea
        Try
            client.CancelAsync()
            client.Dispose()
            Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub lblLocation_Click(sender As Object, e As EventArgs) Handles lblLocation.Click
        Movieo.ShowFile(lblLocation.Text)
    End Sub
End Class