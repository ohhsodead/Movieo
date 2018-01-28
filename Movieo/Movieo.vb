Imports System.IO
Imports System.Net
Imports Newtonsoft.Json

Public Class Movieo

#Region "Preferences (some can be changed for user prefences maybe)"

    Public devMode As Boolean = False
    Public linkMovies As String = "https://dl.dropbox.com/s/6zxx48xy5jido33/movies-posters.json?dl=0"
    Public linkReleaseNotes As String = "https://raw.githubusercontent.com/ekkash/movieo-beta/master/CHANGELOG.md"
    Public linkNotifications As String = "https://dl.dropbox.com/s/eqxi751t8z031na/movieo-notifications.txt?dl=0"
    Public linkMovieComments As String = "https://dl.dropbox.com/s/swbt9fkbknmoqzz/movieo-comments.txt?dl=0"
    Public linkNewReleases As String = "https://raw.githubusercontent.com/ekkash/movieo-beta/master/Data/new-releases.txt"
    Public linkTrending As String = "https://raw.githubusercontent.com/ekkash/movieo-beta/master/Data/trending.txt"
    Public linkTopRated As String = "https://raw.githubusercontent.com/ekkash/movieo-beta/master/Data/top-rated.txt"
    Public linkCollections As String = "https://dl.dropbox.com/s/bz42scp93c5we7r/movieo-collections.txt?dl=0"
    Public pathFavouritesList As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Movieo\Library\Favourites.txt"
    Public pathWatchList As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Movieo\Library\Watch List.txt"
    Public pathSeenList As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Movieo\Library\Seen List.txt"
    Public pathBlackList As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Movieo\Library\Black List.txt"
    Public pathMyLists As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Movieo\Library\My Lists\"
    Public pathDownloads As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Movieo\Downloads\"
    Public pathData As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Movieo\Data\"
    Public userDownloadsDirectory As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads\")

    'Updates
    Public linkLatestVersion As String = "https://dl.dropbox.com/s/n0lwh73gh15vpf5/movieo-version.txt?dl=0"
    Public pathInstallerFileName As String = "MovieoInstaller.exe"
    Public pathDownloadInstaller As String = userDownloadsDirectory + pathInstallerFileName

    Public Function getLatestInstaller(ByVal newVersion As Version) As String
        Return "https://github.com/ekkash/movieo-beta/releases/download/" + newVersion.ToString + "/" + pathInstallerFileName
    End Function

    Public pathUpdater As String = Application.StartupPath + "\Movieo Updater.exe"
    Public infoVersionText As String = "Beta Build v" + Application.ProductVersion
    Public ctrlSearchBoxWatermark As String = "Search movies, people, years..."
    Public msgBackupDatabaseError As String = "Movieo has bumped into an issue loading movies from our database. Information on your issue has been sent to us, we promise we'll be back up soon :)"
    Public msgNoInternetConnection As String = "Movieo is unable to access the internet to reach our server. Please check your internet connection and try again. If you have anymore issues then please email us at hi@movieo.info"
    Public SearchingTexts As ICollection(Of String) = {"Have a great day!",
        "Thank you for using Movieo." + vbNewLine + "We hope you enjoy!",
        "If nobody comes back from the future to" + vbNewLine + "stop you, then how bad of a decision" + vbNewLine + "can it really be?",
        "Pixelating the pixels.",
        "It's just you, me, and the loading screen.",
        "Doing the impossible.",
        "Each day will be better than the last." + vbNewLine + "This one especially.",
        "Sometimes you eat the bear and" + vbNewLine + "sometimes the bear, well, he eats you.",
        "Don't think of purple hippos",
        "The mystery of life isn't a problem to" + vbNewLine + "solve, but a reality of experience.",
        "Remember to get up && stretch" + vbNewLine + "once in a while.",
        "Teaching snakes to kick.",
        "While the satellite moves into position",
        "The Elders of the Internet would never stand for it.",
        "Go ahead, hold your breath and do ironman plank till loading complete",
        "It's not you. It's me.",
        "Computing the secret to life, the universe, and everything.",
        "Swapping time and space...",
        "Feel free to spin in your chair",
        "I'm not lazy, I'm just relaxed!!",
        "Cleaning off the cobwebs...",
        "Please hold on as we reheat our coffee",
        "Adults are just kids with money.",
        "I didn't choose the engineering life. The engineering life chose me.",
        "Finding someone to hold my beer",
        "Cracking military-grade encryption...",
        "Why so serious?",
        "I should have had a V8 this morning.",
        "What the what?",
        "@todo Insert witty loading message",
        "Wait, do you smell something burning?",
        "You shall not pass! yet..",
        "Laughing at your pictures-i mean, loading...",
        "Testing on Timmy... We're going to need another Timmy."}

    Public saveListsOnClose As Boolean = True
    Public intPostersPerScroll As Integer = 100
    Public intFadeOpacity As Double = 0.15

#End Region

#Region "Movieo"

    Public MainForm As Movieo

    Private Sub Movieo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainForm = Me

        TopMost = My.Settings.doOnTop

        Tab.SelectedTab = tabLoading 'Show loading page
        txtboxSearch.WaterMark = ctrlSearchBoxWatermark  'Set search bar watermark text
        If CheckForInternetConnection() = True Then 'Proceed to internet required functions
            timerCheckForUpdate.Enabled = My.Settings.doAutoUpdate
            LoadLists() 'Load movies into lists
            Dim tClient As WebClient = New WebClient
            tClient.DownloadFile(linkMovies, pathData + "movies-posters.json")
            timerStartup.Enabled = True
        Else
            'Show error form on movies tab - if no backup database file stored
            saveListsOnClose = False
            tabDiscover.Controls.Remove(panelMovies)
            tabDiscover.Controls.Remove(panelGenresCtrls)
            Dim a As New frmErrorTab
            a.TopLevel = False
            a.Show()
            tabDiscover.Controls.Add(a)
            a.Dock = DockStyle.Fill
            a.BringToFront()
            Tab.SelectedTab = tabDiscover
            Enabled = True
            txtboxSearch.Enabled = False
            txtboxSearchBG.Enabled = False
            imgSearchIcon.Enabled = False
            titleCoreLibrary.Enabled = False
            ShowPopupOk("No internet connection",
            msgNoInternetConnection, Me)
        End If
    End Sub

    'Save users list on application exit
    Private Sub Movieo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If saveListsOnClose = True Then
            SaveLists()
        End If
    End Sub

    Public Shared Function CheckForInternetConnection() As Boolean 'Returns the status of internet connection (must be able to access dropbox)
        Try
            Using client = New WebClient()
                Using stream = client.OpenRead("https://www.dropbox.com")
                    Return True
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

#End Region

#Region "Show Popups / Open folder"

    Public Sub ShowPopupOk(Title As String, Message As String, owns As Form)
        Try
            Dim a As New frmPopupOk
            a.DialogTitle.Text = Title
            a.DialogMessage.Text = Message
            a.ShowDialog(owns)
        Catch ex As Exception
        End Try
    End Sub

    Public Function ShowPopupYesNo(Title As String, Message As String, owns As Form) As DialogResult
        Try
            Dim a As New frmPopupYesNo
            a.DialogTitle.Text = Title
            a.DialogMessage.Text = Message
            a.ShowDialog(owns)
            Return a.DialogResult
        Catch ex As Exception
            Return DialogResult.No
        End Try
    End Function

    Public Sub ShowFile(file As String)
        Dim args As String = String.Format("/Select, ""{0}""", file)
        Dim pfi As New ProcessStartInfo("Explorer.exe", args)
        Process.Start(pfi)
    End Sub

#End Region

#Region "Create/Save/Load/Reset Lists"

    Public listFavourites As New List(Of String)
    Public listWatchList As New List(Of String)
    Public listSeenList As New List(Of String)
    Public listBlackList As New List(Of String)

    Public listMoviesTrending As New List(Of String)
    Public listMoviesTopRated As New List(Of String)
    Public listMoviesNewReleases As New List(Of String)

    Public listMoviesDownloads As New List(Of String)

    Public listRecentlyWatchedTimes As New List(Of String)

    Private Sub LoadLists()
        Try
            Dim client As New WebClient()

            'Trending Movies
            Dim dataTrending As StreamReader = New StreamReader(client.OpenRead(linkTrending))
            Dim jsonDataTrending As DataAPI = JsonConvert.DeserializeObject(Of DataAPI)(dataTrending.ReadToEnd)

            For Each itemTrending As String In jsonDataTrending.Movies
                If Not itemTrending = "" Then
                    listMoviesTrending.Add(itemTrending)
                End If
            Next

            'New Releases Movies
            Dim dataNewReleases As StreamReader = New StreamReader(client.OpenRead(linkNewReleases))
            Dim jsonDataNewReleases As DataAPI = JsonConvert.DeserializeObject(Of DataAPI)(dataNewReleases.ReadToEnd)

            For Each movieItem As String In jsonDataNewReleases.Movies
                If Not movieItem = "" Then
                    listMoviesNewReleases.Add(movieItem)
                End If
            Next

            'Top Rated
            Dim dataTopRated As StreamReader = New StreamReader(client.OpenRead(linkTopRated))
            Dim jsonDataTopRated As DataAPI = JsonConvert.DeserializeObject(Of DataAPI)(dataTopRated.ReadToEnd)

            For Each movieItem As String In jsonDataTopRated.Movies
                If Not movieItem = "" Then
                    listMoviesTopRated.Add(movieItem)
                End If
            Next

            'Collections - Probably should have used JSON, this was easier at the time. Maybe I'll do this one day. who knows?) (When uploaded to GitHub, I recommend using JSON, like: Trending files, etc.)
            Dim dataCollections As String = client.DownloadString(linkCollections)
            Dim splitDataCollections As String() = Split(dataCollections, vbNewLine)

            For Each collectionItem As String In splitDataCollections
                If Not collectionItem = "" Then
                    Dim collectionItems As String() = Split(collectionItem, "|")

                    Dim a As New ctrlCollectionThumbnail With {
                        .TopLevel = False,
                        .Visible = True
                    }
                    a.lblCollectionTitle.Text = collectionItems(0)
                    a.lblCollectionDescription.Text = collectionItems(1)
                    a.imgCollectionThumbnail.BackgroundImage = New Bitmap(New MemoryStream(client.DownloadData(collectionItems(2))))
                    a.imgCollectionThumbnail.BackgroundImage = ctrlPosterTitle.ChangeOpacity(a.imgCollectionThumbnail.BackgroundImage, 0.7)

                    Dim movieInCollections As String() = Split(collectionItems(3), "*")
                    For Each movie As String In movieInCollections
                        a.itemsCollectionMovies.Items.Add(movie)
                    Next

                    a.Show()
                    panelCollectionsItems.Controls.Add(a)
                    storeControlsCollections.Add(a)
                End If
            Next
        Catch
        End Try

        Try
            'Load User Lists Files
            Dim decFavourites() As String = File.ReadAllLines(pathFavouritesList)
            listFavourites.AddRange(decFavourites)

            Dim decWatchList() As String = File.ReadAllLines(pathWatchList)
            listWatchList.AddRange(decWatchList)

            Dim decSeenList() As String = File.ReadAllLines(pathSeenList)
            listSeenList.AddRange(decSeenList)

            Dim decBlackListed() As String = File.ReadAllLines(pathBlackList)
            listBlackList.AddRange(decBlackListed)

            Dim RecentlyWatchedItem As String = My.Settings.listLastWatched
            If RecentlyWatchedItem <> "" Then
                listRecentlyWatchedTimes.Clear()
                listRecentlyWatchedTimes.AddRange(RecentlyWatchedItem.Split(","))
            End If

            loadDownloadsList()
            loadMyLists()
        Catch ex As Exception
            CreateFolders()
        End Try
    End Sub

    Private Sub loadDownloadsList()
        listMoviesDownloads.Clear()

        For Each fileName As String In My.Computer.FileSystem.GetFiles(pathDownloads, FileIO.SearchOption.SearchTopLevelOnly, {"*.mp4", "*.avi", "*.mkv"})
            Dim cutFileName As String = fileName.Replace(pathDownloads, "")
            listMoviesDownloads.Add(cutFileName.Substring(0, cutFileName.Length - 4))
        Next
    End Sub

    Private Sub SaveLists()
        Try
            'Favourite Movies
            Dim BuildLists1 As New Text.StringBuilder()
            For Each MovieItem As String In listFavourites
                BuildLists1.AppendLine(MovieItem)
            Next
            File.WriteAllText(pathFavouritesList, BuildLists1.ToString())

            'Watch List Movies
            Dim BuildLists2 As New Text.StringBuilder()
            For Each MovieItem As String In listWatchList
                BuildLists2.AppendLine(MovieItem)
            Next
            File.WriteAllText(pathWatchList, BuildLists2.ToString())

            'Seen List Movies
            Dim BuildLists3 As New Text.StringBuilder()
            For Each MovieItem As String In listSeenList
                BuildLists3.AppendLine(MovieItem)
            Next
            File.WriteAllText(pathSeenList, BuildLists3.ToString())

            'Black List Movies
            Dim BuildLists4 As New Text.StringBuilder()
            For Each MovieItem As String In listBlackList
                BuildLists4.AppendLine(MovieItem)
            Next
            File.WriteAllText(pathBlackList, BuildLists4.ToString())

            'Recently Watched
            Dim itemRecentlyWatched As New List(Of String)
            For Each itemRecentlyWatchedInt As String In listRecentlyWatchedTimes
                itemRecentlyWatched.Add(itemRecentlyWatchedInt)
            Next
            My.Settings.listLastWatched = String.Join(",", itemRecentlyWatched.ToArray)

            My.Settings.Save()
        Catch ex As Exception
            ShowPopupOk("Issue saving your lists", ex.Message, Me)
        End Try
    End Sub

    Public Sub CreateFolders()
        My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Movieo\Data\")
        My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Movieo\Library\My Lists\")
        My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Movieo\Downloads\")
        My.Computer.FileSystem.CreateDirectory(pathDownloads)
    End Sub

#End Region

#Region "Startup Timer / Grab Movies / Store Movies"

    Private Sub StartupTimer_Tick(sender As Object, e As EventArgs) Handles timerStartup.Tick
        GrabMovies(pathData + "movies-posters.json")

        Tab.SelectedTab = tabDiscover
        timerStartup.Enabled = False
    End Sub

    'Count movies
    Dim MovieItem As Integer

    'Get movies, display in movies and both lists
    Public NetDl = New WebClient()
    Dim Movies() As String
    Public storeControlsAllMovies As New List(Of Control)
    Public storeControlsCollections As New List(Of Control)

    Public Sub GrabMovies(Content As String)
        MovieItem = 0

        Tab.SelectedTab = tabLoading

        'Remove movies from  
        panelLibraryBlackList.Controls.Clear()
        panelLibrarySeenList.Controls.Clear()
        panelLibraryWatchList.Controls.Clear()
        panelLibraryFavourites.Controls.Clear()

        Movies = File.ReadAllLines(Content)

        For Each Movie As String In Movies.Reverse
            If Not Movie = "" Then
                MovieItem = MovieItem + 1

                Dim m As OMDbAPI = JsonConvert.DeserializeObject(Of OMDbAPI)(Movie)

                Dim tClient As WebClient = New WebClient
                Dim TitleAndYear = m.Title.Replace("&", "&&") + " (" + m.Year + ")"

                Dim a As New ctrlPosterTitle
                a.TopLevel = False
                a.Hide()

                'Deserialize Details from OMDb API
                a.showTitle.Text = m.Title.Replace("&", "&&") 'UI
                a.showYear.Text = m.Year 'UI

                a.infoTitle = m.Title.Replace("&", "&&")
                a.infoYear = m.Year
                a.infoGenre = m.Genre
                a.infoDirector = m.Director
                a.infoActors = m.Actors
                a.infoCountry = m.Country
                a.infoLanguage = m.Language
                a.infoCountry = m.Country
                a.infoProduction = m.Production
                a.infoBoxOffice = m.BoxOffice
                a.infoAwards = m.Awards
                a.infoRuntime = m.Runtime
                a.infoRated = m.Rated
                a.infoLanguage = m.Language
                a.infoPlot = m.Plot
                a.infoFanartUrl = m.imageFanart
                a.infoTrailerUrl = m.trailerUrl

                'Ratings
                a.infoImdbId = m.ImdbID
                a.infoImdbRating = m.ImdbRating
                a.showImdbRating.Text = "IMDb " + a.infoImdbRating

                'Poster
                a.infoPosterUrl = m.Poster

                Try
                    a.imgPoster.BackgroundImage = Image.FromStream(New MemoryStream(tClient.DownloadData(m.Poster)))
                Catch ex As Exception
                End Try

                'Movie Link
                a.infoStreams = m.Streams
                a.showQuality.Text = a.ReturnHighestQuality(m.Streams)
                If My.Settings.doQualityOnPoster = True Then a.showQuality.Visible = True

                a.Name = a.infoImdbId
                a.Show()

                If listMoviesNewReleases.Contains(TitleAndYear) Then
                    a.infoTagged = "New Releases"
                ElseIf listMoviesTopRated.Contains(TitleAndYear) Then
                    a.infoTagged = "Top Rated"
                ElseIf listMoviesTrending.Contains(TitleAndYear) Then
                    a.infoTagged = "Trending"
                End If

                If MovieItem <= intPostersPerScroll Then
                    If Not listBlackList.Contains(TitleAndYear) Then
                        If listSeenList.Contains(TitleAndYear) Then
                            If My.Settings.doWatchedMovies = 0 Then
                                a.imgPoster.BackgroundImage = a.ChangeOpacity(a.imgPoster.BackgroundImage, intFadeOpacity)
                                panelMovies.Controls.Add(a)
                            ElseIf My.Settings.doWatchedMovies = 1 Then
                                'Do nothing
                            ElseIf My.Settings.doWatchedMovies = 2 Then
                                panelMovies.Controls.Add(a)
                            End If
                        Else
                            panelMovies.Controls.Add(a)
                        End If
                    End If
                Else
                    storeControlsScroll.Add(a)
                End If

                If Not listBlackList.Contains(TitleAndYear) Then
                    If listSeenList.Contains(TitleAndYear) Then
                        If My.Settings.doWatchedMovies = 0 Then
                            a.imgPoster.BackgroundImage = a.ChangeOpacity(a.imgPoster.BackgroundImage, 0.1)
                            storeControlsAllMovies.Add(a)
                        ElseIf My.Settings.doWatchedMovies = 1 Then
                            'Do nothing
                        ElseIf My.Settings.doWatchedMovies = 2 Then
                            storeControlsAllMovies.Add(a)
                        End If
                    Else
                        storeControlsAllMovies.Add(a)
                    End If
                End If

                If listFavourites.Contains(TitleAndYear) Then
                    Dim newCtrl As New ctrlPosterTitle()
                    newCtrl = a
                    panelLibraryFavourites.Controls.Add(newCtrl)
                End If

                If listWatchList.Contains(TitleAndYear) Then
                    Dim newCtrl As New ctrlPosterTitle()
                    newCtrl = a
                    panelLibraryWatchList.Controls.Add(newCtrl)
                End If

                If listSeenList.Contains(TitleAndYear) Then
                    Dim newCtrl As New ctrlPosterTitle()
                    newCtrl = a
                    panelLibrarySeenList.Controls.Add(newCtrl)
                End If

                If listBlackList.Contains(TitleAndYear) Then
                    Dim newCtrl As New ctrlPosterTitle()
                    newCtrl = a
                    panelLibraryBlackList.Controls.Add(newCtrl)
                End If

                If listMoviesDownloads.Contains(TitleAndYear) Then
                    Dim newCtrl As New ctrlPosterTitle()
                    newCtrl = a
                    panelDownloads.Controls.Add(newCtrl)
                End If

                If MovieItem Mod 200 = 0 Then 'Change loading text every X movies
                    lblLoadingSub.Text = RandomText(SearchingTexts)
                    Threading.Thread.Sleep(650)
                End If

            End If
        Next
    End Sub

#End Region

#Region "Main - Tabs"

    Private Sub Movieo_KeyDown(sender As Object, e As KeyEventArgs) Handles Tab.KeyDown
        e.Handled = True
    End Sub

    Private Sub titleMyListsBrowse_Click(sender As Object, e As EventArgs) Handles titleCoreDiscover.ClickButtonArea
        Tab.SelectedTab = tabDiscover
    End Sub

    Private Sub titleMyLists_ClickButtonArea(sender As Object, e As EventArgs) Handles titleCoreLibrary.ClickButtonArea
        selectedList = btnListsFavourites.Text
        tabsLibrary.SelectedTab = tabLibraryFavourites
        Tab.SelectedTab = tabLibrary
    End Sub

    Private Sub titleCoreCollections_ClickButtonArea(sender As Object, e As EventArgs) Handles titleCoreCollections.ClickButtonArea
        Tab.SelectedTab = tabCollections
    End Sub

    Private Sub titleCoreDownloads_ClickButtonArea(sender As Object, e As EventArgs) Handles titleCoreDownloads.ClickButtonArea
        Tab.SelectedTab = tabDownloads
    End Sub

    'Tab Title Effects
    Private Sub titleMovies_MouseMove(sender As Object, e As MouseEventArgs) Handles titleCoreDiscover.MouseMove, titleCoreLibrary.MouseMove, titleCoreCollections.MouseMove, titleCoreDownloads.MouseMove
        sender.ForeColor = Color.White
    End Sub

    Private Sub titleMovies_MouseLeave(sender As Object, e As EventArgs) Handles titleCoreDiscover.MouseLeave, titleCoreLibrary.MouseLeave, titleCoreCollections.MouseLeave, titleCoreDownloads.MouseLeave
        If Not Tab.SelectedTab.Name.Replace("tab", "").ToLower.Contains(sender.Text.ToString.Replace(" ", "").ToLower) Then
            sender.ForeColor = Color.FromArgb(161, 168, 179)
        End If
    End Sub

    'Selected Tabs
    Dim SearchboxIsActive As Boolean = False
    Dim GoToNextTab As Integer = 0

    Private Sub appTabs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tab.SelectedIndexChanged
        If Tab.SelectedIndex = 0 Then
            titleCoreDiscover.ForeColor = Color.White
            titleCoreCollections.ForeColor = Color.FromArgb(161, 168, 179)
            titleCoreLibrary.ForeColor = Color.FromArgb(161, 168, 179)
            titleCoreDownloads.ForeColor = Color.FromArgb(161, 168, 179)
            SearchboxInactive()
            'btnGenre_Click(btnGenreAllMovies, e)
        ElseIf Tab.SelectedIndex = 1 Then
            titleCoreDiscover.ForeColor = Color.FromArgb(161, 168, 179)
            titleCoreCollections.ForeColor = Color.White
            titleCoreLibrary.ForeColor = Color.FromArgb(161, 168, 179)
            titleCoreDownloads.ForeColor = Color.FromArgb(161, 168, 179)
            SearchboxInactive()
        ElseIf Tab.SelectedIndex = 2 Then
            titleCoreDiscover.ForeColor = Color.FromArgb(161, 168, 179)
            titleCoreCollections.ForeColor = Color.FromArgb(161, 168, 179)
            titleCoreLibrary.ForeColor = Color.White
            titleCoreDownloads.ForeColor = Color.FromArgb(161, 168, 179)
            SearchboxInactive()
            selectedList = btnListsFavourites.Text
            loadMyLists()
        ElseIf Tab.SelectedIndex = 3 Then
            titleCoreDiscover.ForeColor = Color.FromArgb(161, 168, 179)
            titleCoreCollections.ForeColor = Color.FromArgb(161, 168, 179)
            titleCoreLibrary.ForeColor = Color.FromArgb(161, 168, 179)
            titleCoreDownloads.ForeColor = Color.White
            SearchboxInactive()
        ElseIf Tab.SelectedIndex = 4 Then
            titleCoreDiscover.ForeColor = Color.FromArgb(161, 168, 179)
            titleCoreCollections.ForeColor = Color.FromArgb(161, 168, 179)
            titleCoreLibrary.ForeColor = Color.FromArgb(161, 168, 179)
            titleCoreDownloads.ForeColor = Color.FromArgb(161, 168, 179)
            SearchboxActive()
        ElseIf Tab.SelectedIndex = 5 Then
            titleCoreDiscover.ForeColor = Color.FromArgb(161, 168, 179)
            titleCoreCollections.ForeColor = Color.FromArgb(161, 168, 179)
            titleCoreLibrary.ForeColor = Color.FromArgb(161, 168, 179)
            titleCoreDownloads.ForeColor = Color.FromArgb(161, 168, 179)
            SearchboxInactive()
        ElseIf Tab.SelectedIndex = 6 Then
            titleCoreCollections.ForeColor = Color.FromArgb(161, 168, 179)
            titleCoreLibrary.ForeColor = Color.FromArgb(161, 168, 179)
            titleCoreDownloads.ForeColor = Color.FromArgb(161, 168, 179)
            lblLoadingSub.Text = RandomText(SearchingTexts)
            SearchboxActive()
        End If
    End Sub

    'Generate a random loading screen text
    Public Function RandomText(ByVal Items As ICollection(Of String)) As String
        Dim Rndm As New Random()
        Dim StringList As New List(Of String)(Items)
        Return StringList(Rndm.Next(0, Items.Count))
    End Function

    Public storeControlsScroll As New List(Of Control)

    Private Sub PanelMovies_Scroll(sender As Object, e As ScrollEventArgs) Handles panelMovies.Scroll
        Try
            Dim vs As VScrollProperties = panelMovies.VerticalScroll
            If e.NewValue = (vs.Maximum - vs.LargeChange) + 1 Then
                If storeControlsScroll.Count >= intPostersPerScroll Then
                    For Each ctrlMovie In storeControlsScroll.Take(intPostersPerScroll)
                        panelMovies.Controls.Add(ctrlMovie)
                    Next
                    storeControlsScroll.RemoveRange(0, intPostersPerScroll)
                Else
                    For Each ctrlMovie In storeControlsScroll
                        panelMovies.Controls.Add(ctrlMovie)
                    Next
                    storeControlsScroll.Clear()
                End If
            End If
        Catch ex As Exception
        End Try

        panelMovies.Update()
    End Sub

    Private Sub panelMyListsFavourites_Scroll(sender As Object, e As ScrollEventArgs) Handles panelLibraryFavourites.Scroll
        panelLibraryFavourites.Update()
    End Sub

    Private Sub panelMyListsWatchList_Scroll(sender As Object, e As ScrollEventArgs) Handles panelLibraryWatchList.Scroll
        panelLibraryWatchList.Update()
    End Sub

    Private Sub panelMyListsSeenList_Scroll(sender As Object, e As ScrollEventArgs) Handles panelLibrarySeenList.Scroll
        panelLibrarySeenList.Update()
    End Sub

    Private Sub panelMyListsBlackList_Scroll(sender As Object, e As ScrollEventArgs) Handles panelLibraryBlackList.Scroll
        panelLibraryBlackList.Update()
    End Sub

    Private Sub panelMyListsMovies_Scroll(sender As Object, e As ScrollEventArgs) Handles panelMyListsMovies.Scroll
        panelMyListsMovies.Update()
    End Sub

    Private Sub panelSearches_Scroll(sender As Object, e As ScrollEventArgs) Handles panelSearches.Scroll
        panelSearches.Update()
    End Sub

    Private Sub panelDownloads_Scroll(sender As Object, e As ScrollEventArgs) Handles panelDownloads.Scroll
        panelDownloads.Update()
    End Sub

#End Region

#Region "Collections (beta)"

    Public storeControlsCollectionsScroll As New List(Of Control)

    Private Sub imgCollectionsB2Browse_Click(sender As Object, e As EventArgs) Handles imgCollectionsB2Browse.Click
        tabsCollections.SelectedTab = tabCollectionsHome
    End Sub

    Private Sub panelCollectionsItems_Scroll(sender As Object, e As ScrollEventArgs) Handles panelCollectionsItems.Scroll
        Try
            Dim vs As VScrollProperties = panelCollectionsItems.VerticalScroll
            If e.NewValue = (vs.Maximum - vs.LargeChange) + 1 Then
                If storeControlsCollectionsScroll.Count >= intPostersPerScroll Then
                    For Each ctrlMovie In storeControlsCollectionsScroll.Take(intPostersPerScroll)
                        panelCollectionsItems.Controls.Add(ctrlMovie)
                    Next
                    storeControlsCollectionsScroll.RemoveRange(0, intPostersPerScroll)
                Else
                    For Each ctrlMovie In storeControlsCollectionsScroll
                        panelCollectionsItems.Controls.Add(ctrlMovie)
                    Next
                    storeControlsCollectionsScroll.Clear()
                End If
            End If
        Catch ex As Exception
        End Try

        panelCollectionsItems.Update()
    End Sub

    Private Sub panelCollectionsCtrls_Scroll(sender As Object, e As ScrollEventArgs) Handles panelCollectionsCtrls.Scroll
        panelCollectionsCtrls.Update()
    End Sub

#End Region

#Region "Library - Tabs"

    Private Sub tabsMyLists_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabsLibrary.SelectedIndexChanged
        For Each a As Control In panelMyCoreListsCtrls.Controls
            If a.Text = selectedList Then
                a.BackColor = Color.FromArgb(43, 50, 61)
                a.ForeColor = Color.White

                For Each ab As Control In panelMyListsCtrls.Controls
                    ab.BackColor = Color.FromArgb(24, 32, 45)
                    ab.ForeColor = Color.FromArgb(161, 168, 179)
                Next
            Else
                a.BackColor = Color.FromArgb(24, 32, 45)
                a.ForeColor = Color.FromArgb(161, 168, 179)
            End If
        Next
    End Sub

    'Go to selected tab
    Private Sub titleMyListsFavourites_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnListsFavourites.ClickButtonArea
        panelLibraryFavourites.Controls.Clear()

        For Each a As ctrlPosterTitle In storeControlsAllMovies
            If listFavourites.Contains(a.infoTitle + " (" + a.infoYear + ")") Then
                panelLibraryFavourites.Controls.Add(a)
            End If
        Next

        selectedList = Sender.text
        tabsLibrary.SelectedTab = tabLibraryFavourites
    End Sub

    Private Sub titleMyListsWatchList_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnListsWatch.ClickButtonArea
        panelLibraryWatchList.Controls.Clear()

        For Each a As ctrlPosterTitle In storeControlsAllMovies
            If listWatchList.Contains(a.infoTitle + " (" + a.infoYear + ")") Then
                panelLibraryWatchList.Controls.Add(a)
            End If
        Next

        selectedList = Sender.text
        tabsLibrary.SelectedTab = tabLibraryWatchList
    End Sub

    Private Sub titleMyListsSeenList_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnListsSeen.ClickButtonArea
        panelLibrarySeenList.Controls.Clear()

        For Each a As ctrlPosterTitle In storeControlsAllMovies
            If listSeenList.Contains(a.infoTitle + " (" + a.infoYear + ")") Then
                panelLibrarySeenList.Controls.Add(a)
            End If
        Next

        selectedList = Sender.text
        tabsLibrary.SelectedTab = tabLibrarySeenList
    End Sub

    Private Sub titleMyListsBlackList_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnListsBlack.ClickButtonArea
        panelLibraryBlackList.Controls.Clear()

        For Each a As ctrlPosterTitle In storeControlsAllMovies
            If listBlackList.Contains(a.infoTitle + " (" + a.infoYear + ")") Then
                panelLibraryBlackList.Controls.Add(a)
            End If
        Next

        selectedList = Sender.text
        tabsLibrary.SelectedTab = tabLibraryBlackList
    End Sub

    'Tab Title Effects
    Public selectedList As String = "Favourites"

    Private Sub btnLists_MouseMove(sender As Object, e As MouseEventArgs) Handles btnListsFavourites.MouseMove, btnListsWatch.MouseMove, btnListsSeen.MouseMove, btnListsBlack.MouseMove
        sender.BackColor = Color.FromArgb(43, 50, 61)
        sender.ForeColor = Color.White
    End Sub

    Private Sub btnLists_MouseLeave(sender As Object, e As EventArgs) Handles btnListsFavourites.MouseLeave, btnListsWatch.MouseLeave, btnListsSeen.MouseLeave, btnListsBlack.MouseLeave
        If Not selectedList = sender.Text Then
            sender.BackColor = Color.FromArgb(24, 32, 45)
            sender.ForeColor = Color.FromArgb(161, 168, 179)
        End If
    End Sub

#End Region

#Region "My Lists"

    Private Sub btnCreateList_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnCreateList.ClickButtonArea
        frmCreateList.replaceList = False
        frmCreateList.oldTitle = ""
        frmCreateList.ShowDialog(Me)
    End Sub

    Private Sub btnCreateList_MouseMove(sender As Object, e As EventArgs) Handles btnCreateList.MouseMove
        sender.ForeColor = Color.White
        sender.BorderColor = Color.White
        sender.ColorFillSolid = Color.FromArgb(52, 59, 71)
    End Sub

    Private Sub btnCreateList_MouseLeave(sender As Object, e As EventArgs) Handles btnCreateList.MouseLeave
        sender.ForeColor = Color.FromArgb(161, 168, 179)
        sender.BorderColor = Color.FromArgb(161, 168, 179)
        sender.ColorFillSolid = Color.Transparent
    End Sub

    Private Sub panelMyListsCtrls_ControlAdded(sender As Object, e As ControlEventArgs) Handles panelMyListsCtrls.ControlAdded
        If panelMyListsCtrls.Controls.Count = 0 Then
            lblEmptyPanelMyLists.Visible = True
        Else
            lblEmptyPanelMyLists.Visible = False
        End If
    End Sub

    Private Sub panelMyListsCtrls_ControlRemoved(sender As Object, e As ControlEventArgs) Handles panelMyListsCtrls.ControlRemoved
        If panelMyListsCtrls.Controls.Count = 0 Then
            lblEmptyPanelMyLists.Visible = True
        Else
            lblEmptyPanelMyLists.Visible = False
        End If
    End Sub


    Public Sub loadMyLists()
        Try
            panelMyListsCtrls.Controls.Clear()

            Dim exts As String() = {"*.txt"}
            Dim fileNames = My.Computer.FileSystem.GetFiles(pathMyLists, FileIO.SearchOption.SearchTopLevelOnly, exts)

            For Each fileName As String In fileNames
                Dim cutFileName As String = fileName.Replace(pathMyLists, "")
                Dim a As New CButtonLib.CButton
                a.Hide()
                a.BackColor = Color.Transparent
                a.ForeColor = Color.FromArgb(161, 168, 179)
                a.ColorFillSolid = Color.Transparent
                a.BorderColor = Color.Transparent
                a.TextMargin = New Padding(10, 2, 2, 2)
                a.ShowFocus = CButtonLib.CButton.eFocus.None
                a.Font = CreateFont("Segoe UI Semibold", 10, False, False, False)
                a.Text = cutFileName.Substring(0, cutFileName.Length - 4)
                a.TextAlign = ContentAlignment.MiddleLeft
                a.TextShadowShow = False
                a.FillType = CButtonLib.CButton.eFillType.Solid
                a.Cursor = Cursors.Hand
                a.Size = New Size(154, 28)
                a.Margin = New Padding(0, 0, 0, 0)
                If selectedList = a.Text Then
                    a.BackColor = Color.FromArgb(43, 50, 61)
                    a.ForeColor = Color.White
                End If
                a.Show()
                AddHandler a.ClickButtonArea, AddressOf ctrlMyLists_ClickButtonArea
                AddHandler a.MouseMove, AddressOf ctrlMyLists_MouseMove
                AddHandler a.MouseLeave, AddressOf ctrlMyLists_MouseLeave
                AddHandler a.SideImageClicked, AddressOf ctrlMyLists_SideImageClicked
                panelMyListsCtrls.Controls.Add(a)
            Next
        Catch ex As Exception
            'No Lists to load
        End Try
    End Sub

    Public Sub ctrlMyLists_SideImageClicked(sender As Object, e As MouseEventArgs)
        ctrlContextMenuMyLists.oldTitle = sender.Text
        ctrlContextMenuMyLists.Location = sender.PointToScreen(Point.Empty)
        ctrlContextMenuMyLists.Size = New Size(ctrlContextMenuMyLists.Size.Width, ctrlContextMenuMyLists.Size.Height)
        ctrlContextMenuMyLists.Show()
    End Sub

    Public Sub ctrlMyLists_ClickButtonArea(sender As Object, e As EventArgs)
        Try
            panelMyListsMovies.Controls.Clear()

            Dim moviesInList() As String = File.ReadAllLines(pathMyLists + "\" + sender.Text + ".txt")

            For Each movie As String In moviesInList
                For Each a As ctrlPosterTitle In storeControlsAllMovies
                    If movie = a.infoTitle + " (" + a.infoYear + ")" Then
                        panelMyListsMovies.Controls.Add(a)
                    End If
                Next
            Next

            For Each a As Control In panelMyListsCtrls.Controls
                a.BackColor = Color.FromArgb(24, 32, 45)
                a.ForeColor = Color.FromArgb(161, 168, 179)
            Next

            tabsLibrary.SelectedTab = tabLibraryMyLists
            selectedList = sender.Text

            For Each a As Control In panelMyCoreListsCtrls.Controls
                a.BackColor = Color.FromArgb(24, 32, 45)
                a.ForeColor = Color.FromArgb(161, 168, 179)
            Next
        Catch ex As Exception
            sender.hide()
            Tab.SelectedTab = tabLibrary
            selectedList = btnListsFavourites.Text
            tabsLibrary.SelectedTab = tabLibraryFavourites
        End Try
    End Sub

    Public Sub ctrlMyLists_MouseMove(sender As Object, e As MouseEventArgs)
        sender.BackColor = Color.FromArgb(43, 50, 61)
        sender.ForeColor = Color.White

        sender.SideImageIsClickable = True
        sender.SideImage = My.Resources.Edit_Icon
        sender.SideImageAlign = ContentAlignment.MiddleRight
        sender.SideImageSize = New Size(21, 15)
    End Sub

    Public Sub ctrlMyLists_MouseLeave(sender As Object, e As EventArgs)
        If Not selectedList = sender.Text Then
            sender.BackColor = Color.Transparent
            sender.ForeColor = Color.FromArgb(161, 168, 179)
        End If

        sender.SideImageIsClickable = False
        sender.SideImage = Nothing
    End Sub

#End Region

#Region "Downloads - Tab"

    Private Sub panelDownloads_ControlAdded(sender As Object, e As ControlEventArgs) Handles panelDownloads.ControlAdded
        lblEmptyDownloads.Visible = False
    End Sub

#End Region

#Region "Add/Remove Movies to/from Core Lists"

    'Add Movie to Lists
    Public Sub addMovieToCoreList(toPanel As FlowLayoutPanel, toList As List(Of String), movieTitle As String, movieYear As String, movieIMDbId As String)
        Try
            toList.Add(movieTitle + " (" + movieYear + ")")
        Catch ex As Exception
            ShowPopupOk("Unable to add movie", ex.Message, Me)
        End Try
    End Sub

    Public Sub removeMovieFromCoreList(fromPanel As FlowLayoutPanel, fromList As List(Of String), movieTitle As String, movieYear As String, movieIMDbId As String)
        Try
            fromList.Remove(movieTitle + " (" + movieYear + ")")
        Catch ex As Exception
            ShowPopupOk("Unable to remove movie", ex.Message, Me)
        End Try
    End Sub

#End Region

#Region "Search Movies"

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtboxSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Tab.SelectedTab = tabLoading
            timerSearchMovies.Enabled = True
        End If
    End Sub

    Private Sub timerSearchMovies_Tick(sender As Object, e As EventArgs) Handles timerSearchMovies.Tick
        If txtboxSearch.Text = "" Then
            tabsSearches.SelectedTab = tabSearchesHome
            Tab.SelectedTab = tabSearches
        Else
            If ifURL(txtboxSearch.Text) = True Then
                frmMediaPlayer.Text = "Title Unavailable"
                frmMediaPlayer.MediaPlayerControl.URL = txtboxSearch.Text
                frmMediaPlayer.Show(Me)
                txtboxSearch.Text = ""
                Tab.SelectedTab = tabDiscover
            Else
                searchMovies()
                tabsSearches.SelectedTab = tabSearchesMovies
                Tab.SelectedTab = tabSearches
            End If
        End If
        timerSearchMovies.Enabled = False
    End Sub

    Public Shared Function ifURL(source As String) As Boolean
        Dim uriResult As Uri
        Return (Uri.TryCreate(source, UriKind.Absolute, uriResult) _
                    AndAlso (uriResult.Scheme = Uri.UriSchemeHttp))
    End Function

    Public Sub searchMovies()
        panelSearches.Controls.Clear()

        For Each a As ctrlPosterTitle In storeControlsAllMovies
            If a.infoTitle.ToLower.Contains(txtboxSearch.Text.ToString.ToLower) OrElse a.infoYear = txtboxSearch.Text OrElse a.infoActors.ToLower.Contains(txtboxSearch.Text.ToString.ToLower) OrElse a.infoImdbId = txtboxSearch.Text Then
                panelSearches.Controls.Add(a)
            End If
        Next
    End Sub

    Private Sub TxtSearchBg_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles txtboxSearchBG.ClickButtonArea
        txtboxSearch.Focus()
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged
        If txtboxSearch.Text = "" Then
            tabsSearches.SelectedTab = tabSearchesHome
        End If
    End Sub

    Private Sub txtboxSearch_Enter(sender As Object, e As EventArgs) Handles txtboxSearch.Enter
        txtboxSearch.Text = ""
        panelSearches.Controls.Clear()
        tabsSearches.SelectedTab = tabSearchesHome
        Tab.SelectedTab = tabSearches
        SearchboxActive()
        txtboxSearch.Focus()
    End Sub

    Private Sub txtboxSearch_Leave(sender As Object, e As EventArgs) Handles txtboxSearch.Leave
        If Not Tab.SelectedIndex = 3 Or Not Tab.SelectedIndex = 2 Then
            SearchboxInactive()
        End If
    End Sub

    Private Sub panelSearches_ControlAdded(sender As Object, e As ControlEventArgs) Handles panelSearches.ControlAdded
        If panelSearches.Controls.Count = 0 Then
            lblEmptyPanelSearches.Visible = True
        Else
            lblEmptyPanelSearches.Visible = False
        End If
    End Sub


    Private Sub panelSearches_ControlRemoved(sender As Object, e As ControlEventArgs) Handles panelSearches.ControlRemoved
        If panelSearches.Controls.Count = 0 Then
            lblEmptyPanelSearches.Visible = True
        Else
            lblEmptyPanelSearches.Visible = False
        End If
    End Sub

    'Search Box Active/Inactive
    Public Sub SearchboxInactive()
        txtboxSearch.BackColor = Color.FromArgb(59, 63, 77)
        txtboxSearchBG.BorderColor = Color.FromArgb(59, 63, 77)
        txtboxSearchBG.ColorFillSolid = Color.FromArgb(59, 63, 77)
        imgSearchIcon.BackColor = Color.FromArgb(59, 63, 77)
        imgSearchIcon.Image = My.Resources.SearchIconL
    End Sub

    Public Sub SearchboxActive()
        txtboxSearch.BackColor = Color.FromArgb(80, 85, 105)
        txtboxSearchBG.BorderColor = Color.FromArgb(80, 85, 105)
        txtboxSearchBG.ColorFillSolid = Color.FromArgb(80, 85, 105)
        imgSearchIcon.BackColor = Color.FromArgb(80, 85, 105)
        imgSearchIcon.Image = My.Resources.SearchIconH
    End Sub

#End Region

#Region "Filter Movies by Genre / Movies"

    Public selectedGenre As String = "Any Genre"
    Public selectedGenreObject As Object = btnGenreAllMovies

    Public Sub btnGenre_Click(sender As Object, e As EventArgs) Handles btnFilterTrending.Click, btnFilterNewReleases.Click, btnFilterTopRated.Click, btnGenreAllMovies.Click, btnGenreDrama.Click, btnGenreFamily.Click, btnGenreFantasy.Click, btnGenreComedy.Click, btnGenreCrime.Click, btnGenreDocumentary.Click, btnGenreSciFi.Click, btnGenreThriller.Click, btnGenreWar.Click, btnGenreWestern.Click, btnGenreMusic.Click, btnGenreMystery.Click, btnGenreRomance.Click, btnGenreHistory.Click, btnGenreHorror.Click, btnGenreAnimation.Click, btnGenreAdventure.Click, btnGenreAction.Click
        Try
            If sender.Text = "Any Genre" Then
                For Each a As Control In panelGenresCtrls.Controls
                    a.BackColor = Color.FromArgb(24, 32, 45)
                    a.ForeColor = Color.FromArgb(161, 168, 179)
                Next

                sender.BackColor = Color.FromArgb(43, 50, 61)
                sender.ForeColor = Color.White

                panelMovies.Controls.Clear()
                storeControlsScroll.Clear()

                selectedGenre = sender.Text
                selectedGenreObject = sender

                Dim countMovie As Integer = 0

                For Each a In storeControlsAllMovies
                    countMovie = countMovie + 1
                    If countMovie <= intPostersPerScroll Then
                        panelMovies.Controls.Add(a)
                    Else
                        storeControlsScroll.Add(a)
                    End If
                Next
            ElseIf sender.Text = "Trending" Then
                For Each a As Control In panelGenresCtrls.Controls
                    a.BackColor = Color.FromArgb(24, 32, 45)
                    a.ForeColor = Color.FromArgb(161, 168, 179)
                Next

                sender.BackColor = Color.FromArgb(43, 50, 61)
                sender.ForeColor = Color.White

                panelMovies.Controls.Clear()
                storeControlsScroll.Clear()

                selectedGenre = sender.text
                selectedGenreObject = sender

                Dim countMovie As Integer = 0

                For Each a As ctrlPosterTitle In storeControlsAllMovies
                    If a.infoTagged = "Trending" Then
                        countMovie = countMovie + 1
                        If countMovie <= intPostersPerScroll Then
                            panelMovies.Controls.Add(a)
                        Else
                            storeControlsScroll.Add(a)
                        End If
                    End If
                Next

            ElseIf sender.Text = "New Releases" Then
                For Each a As Control In panelGenresCtrls.Controls
                    a.BackColor = Color.FromArgb(24, 32, 45)
                    a.ForeColor = Color.FromArgb(161, 168, 179)
                Next

                sender.BackColor = Color.FromArgb(43, 50, 61)
                sender.ForeColor = Color.White

                panelMovies.Controls.Clear()
                storeControlsScroll.Clear()

                selectedGenre = sender.text
                selectedGenreObject = sender

                Dim countMovie As Integer = 0

                For Each a As ctrlPosterTitle In storeControlsAllMovies
                    If a.infoTagged = "New Releases" Then
                        countMovie = countMovie + 1
                        If countMovie <= intPostersPerScroll Then
                            panelMovies.Controls.Add(a)
                        Else
                            storeControlsScroll.Add(a)
                        End If
                    End If
                Next
            ElseIf sender.Text = "Top Rated" Then
                For Each a As Control In panelGenresCtrls.Controls
                    a.BackColor = Color.FromArgb(24, 32, 45)
                    a.ForeColor = Color.FromArgb(161, 168, 179)
                Next

                sender.BackColor = Color.FromArgb(43, 50, 61)
                sender.ForeColor = Color.White

                panelMovies.Controls.Clear()
                storeControlsScroll.Clear()

                selectedGenre = sender.text
                selectedGenreObject = sender

                Dim countMovie As Integer = 0

                For Each a As ctrlPosterTitle In storeControlsAllMovies
                    If a.infoTagged = "Top Rated" Then
                        countMovie = countMovie + 1
                        If countMovie <= intPostersPerScroll Then
                            panelMovies.Controls.Add(a)
                        Else
                            storeControlsScroll.Add(a)
                        End If
                    End If
                Next
            Else
                For Each a As Control In panelGenresCtrls.Controls
                    a.BackColor = Color.FromArgb(24, 32, 45)
                    a.ForeColor = Color.FromArgb(161, 168, 179)
                Next

                sender.BackColor = Color.FromArgb(43, 50, 61)
                sender.ForeColor = Color.White

                panelMovies.Controls.Clear()
                storeControlsScroll.Clear()

                selectedGenre = sender.text
                selectedGenreObject = sender

                Dim countMovie As Integer = 0


                For Each a As ctrlPosterTitle In storeControlsAllMovies
                    If a.infoGenre.ToLower.Contains(sender.Text.ToString.ToLower) Then
                        countMovie = countMovie + 1
                        If countMovie <= intPostersPerScroll Then
                            panelMovies.Controls.Add(a)
                        Else
                            storeControlsScroll.Add(a)
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnGenre_MouseMove(sender As Object, e As MouseEventArgs) Handles btnGenreDrama.MouseMove, btnGenreFamily.MouseMove, btnGenreFantasy.MouseMove, btnGenreComedy.MouseMove, btnGenreCrime.MouseMove, btnGenreDocumentary.MouseMove, btnGenreAllMovies.MouseMove, btnGenreSciFi.MouseMove, btnGenreThriller.MouseMove, btnGenreWar.MouseMove, btnGenreWestern.MouseMove, btnGenreMusic.MouseMove, btnGenreMystery.MouseMove, btnGenreRomance.MouseMove, btnGenreHistory.MouseMove, btnGenreHorror.MouseMove, btnGenreAnimation.MouseMove, btnGenreAdventure.MouseMove, btnGenreAction.MouseMove
        sender.BackColor = Color.FromArgb(43, 50, 61)
        sender.ForeColor = Color.White
    End Sub

    Private Sub btnGenre_MouseLeave(sender As Object, e As EventArgs) Handles btnGenreDrama.MouseLeave, btnGenreFamily.MouseLeave, btnGenreFantasy.MouseLeave, btnGenreComedy.MouseLeave, btnGenreCrime.MouseLeave, btnGenreDocumentary.MouseLeave, btnGenreAllMovies.MouseLeave, btnGenreSciFi.MouseLeave, btnGenreThriller.MouseLeave, btnGenreWar.MouseLeave, btnGenreWestern.MouseLeave, btnGenreMusic.MouseLeave, btnGenreMystery.MouseLeave, btnGenreRomance.MouseLeave, btnGenreHistory.MouseLeave, btnGenreHorror.MouseLeave, btnGenreAnimation.MouseLeave, btnGenreAdventure.MouseLeave, btnGenreAction.MouseLeave
        If Not selectedGenre = sender.Text Then
            sender.BackColor = Color.FromArgb(24, 32, 45)
            sender.ForeColor = Color.FromArgb(161, 168, 179)
        End If
    End Sub

    Private Sub btnFilterTrending_MouseMove(sender As Object, e As MouseEventArgs) Handles btnFilterTrending.MouseMove, btnFilterNewReleases.MouseMove, btnFilterTopRated.MouseMove
        sender.BackColor = Color.FromArgb(43, 50, 61)
        sender.ForeColor = Color.White
    End Sub

    Private Sub btnFilterTrending_MouseLeave(sender As Object, e As EventArgs) Handles btnFilterTrending.MouseLeave, btnFilterNewReleases.MouseLeave, btnFilterTopRated.MouseLeave
        If Not selectedGenre = sender.Text Then
            sender.BackColor = Color.FromArgb(24, 32, 45)
            sender.ForeColor = Color.FromArgb(161, 168, 179)
        End If
    End Sub

#End Region

#Region "Info Context Menu"

    Public InfoSelectedTab As TabPage = frmInfo.tabAbout

    Public IsContextOpen As Boolean = False

    Private Sub btnInfoMenu_Click(sender As Object, e As EventArgs) Handles btnInfoMenu.Click
        Dim a As New ctrlContextMenuInfo
        Dim ab As Point = New Point(-ctrlContextMenuInfo.Size.Width + btnInfoMenu.Size.Width + 5, btnInfoMenu.Size.Height)
        ctrlContextMenuInfo.Location = btnInfoMenu.PointToScreen(ab)
        ctrlContextMenuInfo.Size = New Size(a.Size.Width, a.Size.Height - a.btnAboutMovieo.Size.Height)
        btnInfoMenu.Image = My.Resources.DropletsIconH
        ctrlContextMenuInfo.Show()
        IsContextOpen = True
    End Sub

    Private Sub btnInfoMenu_MouseMove(sender As Object, e As MouseEventArgs) Handles btnInfoMenu.MouseMove
        If IsContextOpen = True Then
            btnInfoMenu.Image = My.Resources.DropletsIconH
        Else
            btnInfoMenu.Image = My.Resources.DropletsIconH
        End If
    End Sub

    Private Sub btnInfoMenu_MouseLeave(sender As Object, e As EventArgs) Handles btnInfoMenu.MouseLeave
        If IsContextOpen = True Then
            btnInfoMenu.Image = My.Resources.DropletsIconH
        Else
            btnInfoMenu.Image = My.Resources.DropletsIconL
        End If
    End Sub

#End Region

#Region "Show Empty Panel Message"

    Private Sub panelMyListsFavourites_ControlAdded(sender As Object, e As ControlEventArgs) Handles panelLibraryFavourites.ControlAdded, panelLibraryFavourites.ControlRemoved
        If panelLibraryFavourites.Controls.Count = 0 Then
            lblEmptyFavourites.Visible = True
        Else
            lblEmptyFavourites.Visible = False
        End If
    End Sub

    Private Sub panelMyListsWatchList_ControlAdded(sender As Object, e As ControlEventArgs) Handles panelLibraryWatchList.ControlAdded, panelLibraryWatchList.ControlRemoved
        If panelLibraryWatchList.Controls.Count = 0 Then
            lblEmptyWatchList.Visible = True
        Else
            lblEmptyWatchList.Visible = False
        End If
    End Sub

    Private Sub panelMyListsSeenList_ControlAdded(sender As Object, e As ControlEventArgs) Handles panelLibrarySeenList.ControlAdded, panelLibrarySeenList.ControlRemoved
        If panelLibrarySeenList.Controls.Count = 0 Then
            lblEmptySeenList.Visible = True
        Else
            lblEmptySeenList.Visible = False
        End If
    End Sub

    Private Sub panelMyListsBlackList_ControlAdded(sender As Object, e As ControlEventArgs) Handles panelLibraryBlackList.ControlAdded, panelLibraryBlackList.ControlRemoved
        If panelLibraryBlackList.Controls.Count = 0 Then
            lblEmptyBlackList.Visible = True
        Else
            lblEmptyBlackList.Visible = False
        End If
    End Sub

    Private Sub panelMyListsMovies_ControlAdded(sender As Object, e As ControlEventArgs) Handles panelMyListsMovies.ControlAdded, panelMyListsMovies.ControlRemoved
        If panelMyListsMovies.Controls.Count = 0 Then
            lblEmptyMyLists.Visible = True
        Else
            lblEmptyMyLists.Visible = False
        End If
    End Sub

#End Region

#Region "Check for Update"

    Private Sub GetUpdateNotification_Tick(sender As Object, e As EventArgs) Handles timerCheckForUpdate.Tick
        Try
            Dim request As HttpWebRequest = WebRequest.Create(linkLatestVersion)
            Dim response As HttpWebResponse = request.GetResponse()
            Dim sr As StreamReader = New StreamReader(response.GetResponseStream())

            Dim newVersion As Version = New Version(sr.ReadToEnd())
            Dim curVersion As Version = Reflection.Assembly.GetExecutingAssembly().GetName().Version

            If curVersion.CompareTo(newVersion) < 0 Then
                Try
                    MessageBox.Show("There is a new update available.", "New Update (" + newVersion.ToString() + ")")
                    Dim client = New WebClient()
                    client.DownloadFile(getLatestInstaller(newVersion), pathDownloadInstaller)
                    Process.Start(pathDownloadInstaller)
                    Application.Exit()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Update Failed")
                    Application.Exit()
                End Try
            End If

            timerCheckForUpdate.Enabled = False
        Catch ex As Exception
            timerCheckForUpdate.Enabled = False
        End Try
    End Sub

#End Region

#Region "Select Source"

    Public Function returnSource(parent As Form, movie As String, streams As List(Of Stream), type As String) As String
        Try
            Dim WebClient As New WebClient()
            Dim a As New frmSelectSource
            a.TopLevel = True
            a.Top = parent.ClientRectangle.Top
            a.Left = parent.ClientRectangle.Left
            a.Size = parent.Size

            a.itemsMovieSourcesTitle.Items.Clear()
            a.itemsMovieSources.Items.Clear()

            For Each source In streams
                a.itemsMovieSourcesTitle.Items.Add(source.Name)
                a.itemsMovieSources.Items.Add(source.URL)
            Next

            If type = "watch" Then
                Dim exts As String() = {"*.mp4", "*.avi", "*.mkv"}
                Dim fileNames = My.Computer.FileSystem.GetFiles(pathDownloads, FileIO.SearchOption.SearchTopLevelOnly, exts)

                For Each fileName As String In fileNames
                    Dim cutFileName As String = fileName.Replace(pathDownloads, "")

                    If cutFileName.Substring(0, cutFileName.Length - 4) = movie Then
                        a.itemsMovieSourcesTitle.Items.Add(cutFileName + " (local)")
                        a.itemsMovieSources.Items.Add(fileName)
                    End If
                Next
            End If

            If a.ShowDialog(parent) = DialogResult.OK Then
                If Not a.itemsMovieSourcesTitle.SelectedIndex = -1 Then
                    Return a.itemsMovieSources.SelectedItem.ToString
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

#End Region

#Region "Drag & Drop"

    Private Sub Movieo_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            frmMediaPlayer.Text = "Watching " + Dir(path)
            frmMediaPlayer.MediaPlayerControl.URL = path
            frmMediaPlayer.Show(Me)
        Next
    End Sub

    Private Sub Movieo_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

#End Region

#Region "Get Movie Title by IMDb Id"

    Public Function returnMovieTitle(imdbId As String) As String
        Try
            For Each a As ctrlPosterTitle In storeControlsAllMovies
                If a.infoImdbId = imdbId Then
                    Return a.infoTitle + " (" + a.infoYear + ")"
                End If
            Next
        Catch
            Return Nothing
        End Try
    End Function

#End Region

#Region "Get IMDb Id by Movie Tilte"

    Public Function returnIMDb(movieTitleAndYear As String) As String
        Try
            For Each a As ctrlPosterTitle In storeControlsAllMovies
                If movieTitleAndYear = a.infoTitle + " (" + a.infoYear + ")" Then
                    Return a.infoImdbId
                End If
            Next
        Catch
            Return """"""""
        End Try
    End Function

#End Region

#Region "Add Movie to My List"

    Public Sub addMovieToMyList(listTitle As String, movieTitle As String)
        Dim moviesListPath As String = pathMyLists + listTitle + ".txt"

        Dim moviesList() As String = File.ReadAllLines(moviesListPath)
        Dim copyList As New List(Of String)

        For Each movieItem As String In moviesList
            copyList.Add(movieItem)
        Next

        If Not copyList.Contains(movieTitle) Then
            copyList.Add(movieTitle)
        End If

        Dim buildList As New Text.StringBuilder()
        For Each movieItem As String In copyList
            buildList.AppendLine(movieItem)
        Next

        File.Delete(moviesListPath)
        File.WriteAllText(moviesListPath, buildList.ToString())
    End Sub

#End Region

#Region "Open New Issue (GitHub)"

    Public Shared Sub openBrokenFile(ByVal webFile As String)
        Process.Start("https://github.com/ekkash/movieo-beta/issues/new?title=" & "[Broken File] " & Path.GetFileName(webFile) & "&body=" &
                        "Host: " & New Uri(webFile).Host.Replace("www.", "") & "%0A" &
                        "Name: " & Path.GetFileName(webFile) & "%0A" &
                        "URL: " & New Uri(webFile).AbsoluteUri + "%0A" &
                        "----------------------- %0A" &
                        "*Before creating an issue for a web file, ensure you're able to access the same website (file host) in your browser, as sometimes files can't be accessed due to the server's permissions.*")
    End Sub

    Public Shared Sub openMovieRequest(ByVal movieTitle As String)
        Process.Start("https://github.com/ekkash/movieo-beta/issues/new?title=" & "[Movie Request] " & movieTitle & "&body=" &
                        "----------------------- %0A")
    End Sub

#End Region

#Region "Create Font"

    'Thanks to https://stackoverflow.com/questions/1350993/vb-net-how-to-compose-and-apply-a-font-to-a-label-in-runtime
    Public Function CreateFont(ByVal fontName As String,
                           ByVal fontSize As Integer,
                           ByVal isBold As Boolean,
                           ByVal isItalic As Boolean,
                           ByVal isStrikeout As Boolean) As Font

        Dim styles As FontStyle = FontStyle.Regular

        If (isBold) Then
            styles = styles Or FontStyle.Bold
        End If

        If (isItalic) Then
            styles = styles Or FontStyle.Italic
        End If

        If (isStrikeout) Then
            styles = styles Or FontStyle.Strikeout
        End If

        Dim newFont As New Font(fontName, fontSize, styles)
        Return newFont
    End Function

#End Region

    Private Sub Movieo_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        'btnGenre_Click(selectedGenreObject, e)
    End Sub
End Class