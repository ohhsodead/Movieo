Imports System.IO

Public Class frmImportExport

#Region "Base"

    Private Sub frmImportExport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set position/size of window
        Location = Movieo.PointToScreen(Point.Empty)
        Size = Movieo.ClientSize

        cmboboxImportTo.Items.Clear()
        cmboboxExportFrom.Items.Clear()

        Dim defaultLists = {"Watch List", "Seen List", "Black List"}
        cmboboxImportTo.Items.AddRange(defaultLists)
        cmboboxExportFrom.Items.AddRange(defaultLists)

        For Each fileName As String In My.Computer.FileSystem.GetFiles(Movieo.pathMyLists, FileIO.SearchOption.SearchTopLevelOnly, "*.txt")
            Dim cutFileName As String = fileName.Replace(Movieo.pathMyLists, "")
            cmboboxImportTo.Items.Add(cutFileName.Substring(0, cutFileName.Length - 4))
            cmboboxExportFrom.Items.Add(cutFileName.Substring(0, cutFileName.Length - 4))
        Next

        cmboboxImportFrom.SelectedIndex = 0
        cmboboxImportTo.SelectedIndex = 0
        cmboboxExportFrom.SelectedIndex = 0
    End Sub

    'Prevent lag on scroll
    Private Sub MyBase_Scroll(sender As Object, e As ScrollEventArgs) Handles MyBase.Scroll
        sender.Update()
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

    Private Sub headerImport_Click(sender As Object, e As EventArgs) Handles headerImport.Click
        Tab.SelectedTab = tabImport
    End Sub

    Private Sub headerExport_Click(sender As Object, e As EventArgs) Handles headerExport.Click
        Tab.SelectedTab = tabExport
    End Sub

    Private Sub LblAbout_MouseMove(sender As Object, e As MouseEventArgs) Handles headerExport.MouseMove, headerImport.MouseMove
        sender.ForeColor = SelectedTabColour
    End Sub

    Private Sub LblAbout_MouseLeave(sender As Object, e As EventArgs) Handles headerExport.MouseLeave, headerImport.MouseLeave
        If sender IsNot CurrentTab Then sender.ForeColor = NonSelectedTabColour
    End Sub

    Dim CurrentTab As Object = tabImport
    Dim SelectedTabColour As Color = Color.FromArgb(172, 180, 191)
    Dim NonSelectedTabColour As Color = Color.FromArgb(86, 98, 115)

    Private Sub Tab_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tab.SelectedIndexChanged
        If Tab.SelectedIndex = 0 Then
            CurrentTab = headerImport
            headerImport.ForeColor = SelectedTabColour
            headerExport.ForeColor = NonSelectedTabColour
        ElseIf Tab.SelectedIndex = 1 Then
            CurrentTab = headerExport
            headerImport.ForeColor = NonSelectedTabColour
            headerExport.ForeColor = SelectedTabColour
        End If
    End Sub

#End Region

#Region "Import"

    Private Sub cmboLblImportFrom_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles cmboLblImportFrom.ClickButtonArea
        cmboboxImportFrom.DroppedDown = True
    End Sub

    Private Sub cmboboxImportFrom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboboxImportFrom.SelectedIndexChanged
        cmboLblImportFrom.Text = cmboboxImportFrom.SelectedItem.ToString
    End Sub

    Private Sub cmboLblImportTo_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles cmboLblImportTo.ClickButtonArea
        cmboboxImportTo.DroppedDown = True
    End Sub

    Private Sub cmboboxImportTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboboxImportTo.SelectedIndexChanged
        cmboLblImportTo.Text = cmboboxImportTo.SelectedItem.ToString
    End Sub

    Dim fileToImportPath As String = ""

    Private Sub btnImportChooseFile_Click(sender As Object, e As EventArgs) Handles btnImportChooseFile.Click
        Dim a As New OpenFileDialog
        a.Title = "Open"
        a.Filter = "CSV File|*.csv"

        If a.ShowDialog = DialogResult.OK Then
            lblImportFile.Text = a.SafeFileName
            fileToImportPath = a.FileName
        End If
    End Sub

    Private Sub btnFormSubmit_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnStartImporting.ClickButtonArea
        If fileToImportPath = "" Then
            lblImportFile.Text = "Please choose a file"
        Else
            If cmboboxImportFrom.SelectedIndex = 0 AndAlso cmboboxImportTo.SelectedIndex = 0 Then
                ImportIMDb("Watch List")
            ElseIf cmboboxImportFrom.SelectedIndex = 0 AndAlso cmboboxImportTo.SelectedIndex = 1 Then
                ImportIMDb("Seen List")
            ElseIf cmboboxImportFrom.SelectedIndex = 0 AndAlso cmboboxImportTo.SelectedIndex = 2 Then
                ImportIMDb("Black List")
            ElseIf cmboboxImportFrom.SelectedIndex = 0 AndAlso cmboboxImportTo.SelectedIndex >= 3 Then
                ImportIMDb(cmboboxImportTo.GetItemText(cmboboxImportTo.SelectedItem))
            End If
        End If
    End Sub

    Private Sub btnStartImporting_MouseMove(sender As Object, e As EventArgs) Handles btnStartImporting.MouseMove, btnStartImporting.GotFocus
        sender.ForeColor = Color.White
        sender.BorderColor = Color.White
        sender.ColorFillSolid = Color.FromArgb(52, 59, 71)
    End Sub

    Private Sub btnStartImporting_MouseLeave(sender As Object, e As EventArgs) Handles btnStartImporting.MouseLeave, btnStartImporting.LostFocus
        sender.ForeColor = Color.FromArgb(172, 180, 191)
        sender.BorderColor = Color.FromArgb(86, 98, 115)
        sender.ColorFillSolid = Color.Transparent
    End Sub

    Private Sub ImportIMDb(nameList As String)
        Try
            Dim MyReader As New FileIO.TextFieldParser(fileToImportPath)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")

            Dim currentRow As String()
            While Not MyReader.EndOfData()
                Try
                    currentRow = MyReader.ReadFields()
                    If Not currentRow(5) = "Title" Then
                        Dim movieIMDbId = currentRow(1)
                        Dim movieTitle = currentRow(5)
                        Dim movieYear = currentRow(11)
                        Dim movieTitleYear As String = movieTitle + " (" + movieYear + ")"

                        If nameList = "Watch List" Then
                            If Movieo.listWatchList.Contains(movieTitleYear) Then
                                Movieo.removeMovieFromCoreList(Movieo.panelLibraryWatchList, Movieo.listWatchList, movieTitle, movieYear, movieIMDbId)
                            Else
                                Movieo.addMovieToCoreList(Movieo.panelLibraryWatchList, Movieo.listWatchList, movieTitle, movieYear, movieIMDbId)

                                If Movieo.listBlackList.Contains(movieTitleYear) Then
                                    Movieo.removeMovieFromCoreList(Movieo.panelLibraryBlackList, Movieo.listBlackList, movieTitle, movieYear, movieIMDbId)
                                End If

                                If Movieo.listSeenList.Contains(movieTitleYear) Then
                                    Movieo.removeMovieFromCoreList(Movieo.panelLibrarySeenList, Movieo.listSeenList, movieTitle, movieYear, movieIMDbId)
                                End If
                            End If
                        ElseIf nameList = "Seen List" Then
                            If Movieo.listWatchList.Contains(movieTitleYear) Then
                                Movieo.removeMovieFromCoreList(Movieo.panelLibrarySeenList, Movieo.listSeenList, movieTitle, movieYear, movieIMDbId)
                            Else
                                Movieo.addMovieToCoreList(Movieo.panelLibrarySeenList, Movieo.listSeenList, movieTitle, movieYear, movieIMDbId)

                                If Movieo.listBlackList.Contains(movieTitleYear) Then
                                    Movieo.removeMovieFromCoreList(Movieo.panelLibraryBlackList, Movieo.listBlackList, movieTitle, movieYear, movieIMDbId)
                                End If

                                If Movieo.listSeenList.Contains(movieTitleYear) Then
                                    Movieo.removeMovieFromCoreList(Movieo.panelLibrarySeenList, Movieo.listSeenList, movieTitle, movieYear, movieIMDbId)
                                End If
                            End If
                        ElseIf nameList = "Black List" Then
                            If Movieo.listWatchList.Contains(movieTitleYear) Then
                                Movieo.removeMovieFromCoreList(Movieo.panelLibraryBlackList, Movieo.listBlackList, movieTitle, movieYear, movieIMDbId)
                            Else
                                Movieo.addMovieToCoreList(Movieo.panelLibraryBlackList, Movieo.listBlackList, movieTitle, movieYear, movieIMDbId)

                                If Movieo.listBlackList.Contains(movieTitleYear) Then
                                    Movieo.removeMovieFromCoreList(Movieo.panelLibraryBlackList, Movieo.listBlackList, movieTitle, movieYear, movieIMDbId)
                                End If

                                If Movieo.listSeenList.Contains(movieTitleYear) Then
                                    Movieo.removeMovieFromCoreList(Movieo.panelLibrarySeenList, Movieo.listSeenList, movieTitle, movieYear, movieIMDbId)
                                End If
                            End If
                        Else
                            Movieo.addMovieToMyList(nameList, movieTitleYear)
                        End If
                    End If
                Catch
                End Try
            End While
            showMessage("List Successfully Imported!")
        Catch ex As Exception
            showMessage("Unable to Import List")
            Movieo.ShowPopupOk("Unable to Import List", ex.InnerException.Message, Me)
        End Try
    End Sub

#End Region

#Region "Export"

    Private Sub cmboboxExportFrom_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles cmboLblExportFrom.ClickButtonArea
        cmboboxExportFrom.DroppedDown = True
    End Sub

    Private Sub cmboboxExportFrom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboboxExportFrom.SelectedIndexChanged
        cmboLblExportFrom.Text = cmboboxExportFrom.SelectedItem.ToString
    End Sub

    Private Sub btnStartExporting_MouseMove(sender As Object, e As EventArgs) Handles btnStartExporting.MouseMove, btnStartExporting.GotFocus
        sender.ForeColor = Color.White
        sender.BorderColor = Color.White
        sender.ColorFillSolid = Color.FromArgb(52, 59, 71)
    End Sub

    Private Sub btnStartExporting_MouseLeave(sender As Object, e As EventArgs) Handles btnStartExporting.MouseLeave, btnStartExporting.LostFocus
        sender.ForeColor = Color.FromArgb(172, 180, 191)
        sender.BorderColor = Color.FromArgb(86, 98, 115)
        sender.ColorFillSolid = Color.Transparent
    End Sub

    Private Sub btnStartExporting_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnStartExporting.ClickButtonArea
        If cmboboxExportFrom.SelectedIndex = 0 Then
            ExportList(Movieo.listWatchList)
        ElseIf cmboboxExportFrom.SelectedIndex = 1 Then
            ExportList(Movieo.listSeenList)
        ElseIf cmboboxExportFrom.SelectedIndex = 2 Then
            ExportList(Movieo.listBlackList)
        ElseIf cmboboxExportFrom.SelectedIndex >= 3 Then
            ExportMyList(cmboboxExportFrom.SelectedItem.ToString)
        End If
    End Sub

    Public Sub ExportList(itemsList As List(Of String))
        Try
            Dim a As New FolderBrowserDialog

            If a.ShowDialog() = DialogResult.OK Then
                Dim csvFile As String = a.SelectedPath + "\" + cmboboxExportFrom.SelectedItem.ToString.Replace(" ", "") + "-" + Date.Now.ToString("yyyy-MM-dd") + ".csv"

                If File.Exists(csvFile) Then
                    File.Delete(csvFile)
                End If

                Dim objWriter As StreamWriter = File.AppendText(csvFile)

                objWriter.WriteLine("imdb_id,title,year")
                For Each MovieItem As String In itemsList
                    If Not MovieItem = "" Then
                        objWriter.WriteLine(Movieo.returnIMDb(MovieItem) + "," + MovieItem.Substring(0, MovieItem.Length - 7) + "," + MovieItem.Substring(MovieItem.Length - 5, 4))
                    End If
                Next

                objWriter.Close()
            End If
            showMessage("List Successfully Exported!")
        Catch ex As Exception
            showMessage("Unable to Export List")
            Movieo.ShowPopupOk("Unable to Export List", ex.Message, Me)
        End Try
    End Sub

    Public Sub ExportMyList(listTitle As String)
        Try
            Dim moviesListPath As String() = File.ReadAllLines(Movieo.pathMyLists + listTitle + ".txt")

            Dim a As New FolderBrowserDialog

            If a.ShowDialog() = DialogResult.OK Then
                Dim csvFile As String = a.SelectedPath + "\" + cmboboxExportFrom.SelectedItem.ToString.Replace(" ", "") + "-" + Date.Now.ToString("yyyy-MM-dd") + ".csv"

                If File.Exists(csvFile) Then
                    File.Delete(csvFile)
                End If

                Dim objWriter As StreamWriter = File.AppendText(csvFile)

                objWriter.WriteLine("imdb_id,title,year")
                For Each MovieItem As String In moviesListPath
                    If Not MovieItem = "" Then
                        objWriter.WriteLine(Movieo.returnIMDb(MovieItem) + "," + MovieItem.Substring(0, MovieItem.Length - 7) + "," + MovieItem.Substring(MovieItem.Length - 5, 4))
                    End If
                Next

                objWriter.Close()
            End If
            showMessage("List Successfully Exported!")
        Catch ex As Exception
            showMessage("Unable to Export List")
            Movieo.ShowPopupOk("Unable to Export List", ex.Message, Me)
        End Try
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
        lblStatus.Location = New Point((ClientSize.Width - lblStatus.Width) \ 2, 56)
        lblStatus.Visible = True
        timerHideNotifications.Enabled = True
    End Sub

#End Region

End Class