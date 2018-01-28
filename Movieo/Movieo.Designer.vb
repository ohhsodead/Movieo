<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Movieo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Movieo))
        Me.Tab = New System.Windows.Forms.TabControl()
        Me.tabDiscover = New System.Windows.Forms.TabPage()
        Me.panelGenresCtrls = New System.Windows.Forms.Panel()
        Me.btnGenreAction = New CButtonLib.CButton()
        Me.btnGenreAdventure = New CButtonLib.CButton()
        Me.btnGenreAnimation = New CButtonLib.CButton()
        Me.btnFilterTopRated = New CButtonLib.CButton()
        Me.btnGenreComedy = New CButtonLib.CButton()
        Me.btnFilterNewReleases = New CButtonLib.CButton()
        Me.btnGenreCrime = New CButtonLib.CButton()
        Me.btnFilterTrending = New CButtonLib.CButton()
        Me.btnGenreDocumentary = New CButtonLib.CButton()
        Me.btnGenreRomance = New CButtonLib.CButton()
        Me.btnGenreDrama = New CButtonLib.CButton()
        Me.btnGenreSciFi = New CButtonLib.CButton()
        Me.btnGenreFamily = New CButtonLib.CButton()
        Me.btnGenreMystery = New CButtonLib.CButton()
        Me.btnGenreFantasy = New CButtonLib.CButton()
        Me.btnGenreThriller = New CButtonLib.CButton()
        Me.btnGenreAllMovies = New CButtonLib.CButton()
        Me.btnGenreMusic = New CButtonLib.CButton()
        Me.btnGenreHistory = New CButtonLib.CButton()
        Me.btnGenreWar = New CButtonLib.CButton()
        Me.btnGenreWestern = New CButtonLib.CButton()
        Me.btnGenreHorror = New CButtonLib.CButton()
        Me.panelMovies = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabCollections = New System.Windows.Forms.TabPage()
        Me.tabsCollections = New System.Windows.Forms.TabControl()
        Me.tabCollectionsHome = New System.Windows.Forms.TabPage()
        Me.panelCollectionsItems = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabCollectionsMovies = New System.Windows.Forms.TabPage()
        Me.panelCollectionsCtrls = New System.Windows.Forms.FlowLayoutPanel()
        Me.panelCollectionsDetails = New System.Windows.Forms.FlowLayoutPanel()
        Me.imgCollectionsB2Browse = New System.Windows.Forms.PictureBox()
        Me.lblCollectionsTitle = New System.Windows.Forms.Label()
        Me.lblCollectionsComment = New System.Windows.Forms.Label()
        Me.lblCollectionMoviesWatched = New System.Windows.Forms.Label()
        Me.panelCollectionsMovies = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabLibrary = New System.Windows.Forms.TabPage()
        Me.panelLibraryCtrls = New System.Windows.Forms.Panel()
        Me.lblEmptyPanelMyLists = New System.Windows.Forms.Label()
        Me.panelMyCoreListsCtrls = New System.Windows.Forms.Panel()
        Me.btnListsFavourites = New CButtonLib.CButton()
        Me.btnListsWatch = New CButtonLib.CButton()
        Me.btnListsSeen = New CButtonLib.CButton()
        Me.btnListsBlack = New CButtonLib.CButton()
        Me.lblHeaderLibrary = New System.Windows.Forms.Label()
        Me.lblHeaderMyLists = New System.Windows.Forms.Label()
        Me.panelMyListsCtrls = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabsLibrary = New System.Windows.Forms.TabControl()
        Me.tabLibraryFavourites = New System.Windows.Forms.TabPage()
        Me.lblEmptyFavourites = New System.Windows.Forms.Label()
        Me.panelLibraryFavourites = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabLibraryWatchList = New System.Windows.Forms.TabPage()
        Me.lblEmptyWatchList = New System.Windows.Forms.Label()
        Me.panelLibraryWatchList = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabLibrarySeenList = New System.Windows.Forms.TabPage()
        Me.lblEmptySeenList = New System.Windows.Forms.Label()
        Me.panelLibrarySeenList = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabLibraryBlackList = New System.Windows.Forms.TabPage()
        Me.lblEmptyBlackList = New System.Windows.Forms.Label()
        Me.panelLibraryBlackList = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabLibraryMyLists = New System.Windows.Forms.TabPage()
        Me.lblEmptyMyLists = New System.Windows.Forms.Label()
        Me.panelMyListsMovies = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabDownloads = New System.Windows.Forms.TabPage()
        Me.lblEmptyDownloads = New System.Windows.Forms.Label()
        Me.panelDownloads = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabSearches = New System.Windows.Forms.TabPage()
        Me.tabsSearches = New System.Windows.Forms.TabControl()
        Me.tabSearchesHome = New System.Windows.Forms.TabPage()
        Me.lblSearch3 = New System.Windows.Forms.Label()
        Me.imgSearch3 = New System.Windows.Forms.PictureBox()
        Me.lblSearch1 = New System.Windows.Forms.Label()
        Me.imgSearch1 = New System.Windows.Forms.PictureBox()
        Me.lblSearch2 = New System.Windows.Forms.Label()
        Me.imgSearch2 = New System.Windows.Forms.PictureBox()
        Me.tabSearchesMovies = New System.Windows.Forms.TabPage()
        Me.lblEmptyPanelSearches = New System.Windows.Forms.Label()
        Me.panelSearches = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabLoading = New System.Windows.Forms.TabPage()
        Me.lblLoading = New System.Windows.Forms.Label()
        Me.richtxtMovieDb = New System.Windows.Forms.RichTextBox()
        Me.lblLoadingSub = New System.Windows.Forms.Label()
        Me.TextUseBrowseTab = New System.Windows.Forms.Label()
        Me.timerStartup = New System.Windows.Forms.Timer(Me.components)
        Me.timerCheckForUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.panelTabTitles = New System.Windows.Forms.Panel()
        Me.btnCreateList = New CButtonLib.CButton()
        Me.titleCoreCollections = New CButtonLib.CButton()
        Me.titleCoreLibrary = New CButtonLib.CButton()
        Me.txtboxSearch = New ChreneLib.Controls.TextBoxes.CTextBox()
        Me.btnInfoMenu = New System.Windows.Forms.PictureBox()
        Me.titleCoreDiscover = New CButtonLib.CButton()
        Me.imgSearchIcon = New System.Windows.Forms.PictureBox()
        Me.txtboxSearchBG = New CButtonLib.CButton()
        Me.titleCoreDownloads = New CButtonLib.CButton()
        Me.timerResetFilters = New System.Windows.Forms.Timer(Me.components)
        Me.timerFilterGenre = New System.Windows.Forms.Timer(Me.components)
        Me.timerSearchMovies = New System.Windows.Forms.Timer(Me.components)
        Me.timerHideNotifications = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.timerHideNotification = New System.Windows.Forms.Timer(Me.components)
        Me.timerHideNotificationss = New System.Windows.Forms.Timer(Me.components)
        Me.timerCountdownLiveMovie = New System.Windows.Forms.Timer(Me.components)
        Me.timerGoToTime = New System.Windows.Forms.Timer(Me.components)
        Me.icoLoadingWeb = New System.Windows.Forms.PictureBox()
        Me.Tab.SuspendLayout()
        Me.tabDiscover.SuspendLayout()
        Me.panelGenresCtrls.SuspendLayout()
        Me.tabCollections.SuspendLayout()
        Me.tabsCollections.SuspendLayout()
        Me.tabCollectionsHome.SuspendLayout()
        Me.tabCollectionsMovies.SuspendLayout()
        Me.panelCollectionsCtrls.SuspendLayout()
        Me.panelCollectionsDetails.SuspendLayout()
        CType(Me.imgCollectionsB2Browse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabLibrary.SuspendLayout()
        Me.panelLibraryCtrls.SuspendLayout()
        Me.panelMyCoreListsCtrls.SuspendLayout()
        Me.tabsLibrary.SuspendLayout()
        Me.tabLibraryFavourites.SuspendLayout()
        Me.tabLibraryWatchList.SuspendLayout()
        Me.tabLibrarySeenList.SuspendLayout()
        Me.tabLibraryBlackList.SuspendLayout()
        Me.tabLibraryMyLists.SuspendLayout()
        Me.tabDownloads.SuspendLayout()
        Me.tabSearches.SuspendLayout()
        Me.tabsSearches.SuspendLayout()
        Me.tabSearchesHome.SuspendLayout()
        CType(Me.imgSearch3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSearch1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSearch2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSearchesMovies.SuspendLayout()
        Me.tabLoading.SuspendLayout()
        Me.panelTabTitles.SuspendLayout()
        CType(Me.btnInfoMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSearchIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icoLoadingWeb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tab
        '
        Me.Tab.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.Tab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab.CausesValidation = False
        Me.Tab.Controls.Add(Me.tabDiscover)
        Me.Tab.Controls.Add(Me.tabCollections)
        Me.Tab.Controls.Add(Me.tabLibrary)
        Me.Tab.Controls.Add(Me.tabDownloads)
        Me.Tab.Controls.Add(Me.tabSearches)
        Me.Tab.Controls.Add(Me.tabLoading)
        Me.Tab.Location = New System.Drawing.Point(-23, 36)
        Me.Tab.Multiline = True
        Me.Tab.Name = "Tab"
        Me.Tab.SelectedIndex = 0
        Me.Tab.Size = New System.Drawing.Size(1318, 701)
        Me.Tab.TabIndex = 1000
        Me.Tab.TabStop = False
        '
        'tabDiscover
        '
        Me.tabDiscover.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabDiscover.Controls.Add(Me.panelGenresCtrls)
        Me.tabDiscover.Controls.Add(Me.panelMovies)
        Me.tabDiscover.Location = New System.Drawing.Point(23, 4)
        Me.tabDiscover.Margin = New System.Windows.Forms.Padding(0)
        Me.tabDiscover.Name = "tabDiscover"
        Me.tabDiscover.Size = New System.Drawing.Size(1291, 693)
        Me.tabDiscover.TabIndex = 0
        Me.tabDiscover.Text = "DISCOVER"
        '
        'panelGenresCtrls
        '
        Me.panelGenresCtrls.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panelGenresCtrls.AutoScroll = True
        Me.panelGenresCtrls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelGenresCtrls.Controls.Add(Me.btnGenreAction)
        Me.panelGenresCtrls.Controls.Add(Me.btnGenreAdventure)
        Me.panelGenresCtrls.Controls.Add(Me.btnGenreAnimation)
        Me.panelGenresCtrls.Controls.Add(Me.btnFilterTopRated)
        Me.panelGenresCtrls.Controls.Add(Me.btnGenreComedy)
        Me.panelGenresCtrls.Controls.Add(Me.btnFilterNewReleases)
        Me.panelGenresCtrls.Controls.Add(Me.btnGenreCrime)
        Me.panelGenresCtrls.Controls.Add(Me.btnFilterTrending)
        Me.panelGenresCtrls.Controls.Add(Me.btnGenreDocumentary)
        Me.panelGenresCtrls.Controls.Add(Me.btnGenreRomance)
        Me.panelGenresCtrls.Controls.Add(Me.btnGenreDrama)
        Me.panelGenresCtrls.Controls.Add(Me.btnGenreSciFi)
        Me.panelGenresCtrls.Controls.Add(Me.btnGenreFamily)
        Me.panelGenresCtrls.Controls.Add(Me.btnGenreMystery)
        Me.panelGenresCtrls.Controls.Add(Me.btnGenreFantasy)
        Me.panelGenresCtrls.Controls.Add(Me.btnGenreThriller)
        Me.panelGenresCtrls.Controls.Add(Me.btnGenreAllMovies)
        Me.panelGenresCtrls.Controls.Add(Me.btnGenreMusic)
        Me.panelGenresCtrls.Controls.Add(Me.btnGenreHistory)
        Me.panelGenresCtrls.Controls.Add(Me.btnGenreWar)
        Me.panelGenresCtrls.Controls.Add(Me.btnGenreWestern)
        Me.panelGenresCtrls.Controls.Add(Me.btnGenreHorror)
        Me.panelGenresCtrls.Location = New System.Drawing.Point(0, 0)
        Me.panelGenresCtrls.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.panelGenresCtrls.Name = "panelGenresCtrls"
        Me.panelGenresCtrls.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.panelGenresCtrls.Size = New System.Drawing.Size(172, 693)
        Me.panelGenresCtrls.TabIndex = 100020
        '
        'btnGenreAction
        '
        Me.btnGenreAction.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreAction.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnGenreAction.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreAction.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreAction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreAction.DesignerSelected = False
        Me.btnGenreAction.DimFactorClick = 0
        Me.btnGenreAction.DimFactorHover = 0
        Me.btnGenreAction.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreAction.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnGenreAction.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnGenreAction.ImageIndex = 0
        Me.btnGenreAction.Location = New System.Drawing.Point(9, 93)
        Me.btnGenreAction.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreAction.Name = "btnGenreAction"
        Me.btnGenreAction.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreAction.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreAction.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreAction.Size = New System.Drawing.Size(153, 28)
        Me.btnGenreAction.TabIndex = 100019
        Me.btnGenreAction.TabStop = False
        Me.btnGenreAction.Text = "Action"
        Me.btnGenreAction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreAction.TextMargin = New System.Windows.Forms.Padding(10, 2, 2, 2)
        Me.btnGenreAction.TextShadow = System.Drawing.Color.White
        Me.btnGenreAction.TextShadowShow = False
        '
        'btnGenreAdventure
        '
        Me.btnGenreAdventure.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreAdventure.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnGenreAdventure.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreAdventure.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreAdventure.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreAdventure.DesignerSelected = False
        Me.btnGenreAdventure.DimFactorClick = 0
        Me.btnGenreAdventure.DimFactorHover = 0
        Me.btnGenreAdventure.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreAdventure.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnGenreAdventure.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnGenreAdventure.ImageIndex = 0
        Me.btnGenreAdventure.Location = New System.Drawing.Point(9, 121)
        Me.btnGenreAdventure.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreAdventure.Name = "btnGenreAdventure"
        Me.btnGenreAdventure.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreAdventure.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreAdventure.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreAdventure.Size = New System.Drawing.Size(153, 28)
        Me.btnGenreAdventure.TabIndex = 100020
        Me.btnGenreAdventure.TabStop = False
        Me.btnGenreAdventure.Text = "Adventure"
        Me.btnGenreAdventure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreAdventure.TextMargin = New System.Windows.Forms.Padding(10, 2, 2, 2)
        Me.btnGenreAdventure.TextShadow = System.Drawing.Color.White
        Me.btnGenreAdventure.TextShadowShow = False
        '
        'btnGenreAnimation
        '
        Me.btnGenreAnimation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreAnimation.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnGenreAnimation.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreAnimation.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreAnimation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreAnimation.DesignerSelected = False
        Me.btnGenreAnimation.DimFactorClick = 0
        Me.btnGenreAnimation.DimFactorHover = 0
        Me.btnGenreAnimation.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreAnimation.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnGenreAnimation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnGenreAnimation.ImageIndex = 0
        Me.btnGenreAnimation.Location = New System.Drawing.Point(9, 149)
        Me.btnGenreAnimation.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreAnimation.Name = "btnGenreAnimation"
        Me.btnGenreAnimation.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreAnimation.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreAnimation.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreAnimation.Size = New System.Drawing.Size(153, 28)
        Me.btnGenreAnimation.TabIndex = 100021
        Me.btnGenreAnimation.TabStop = False
        Me.btnGenreAnimation.Text = "Animation"
        Me.btnGenreAnimation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreAnimation.TextMargin = New System.Windows.Forms.Padding(10, 2, 2, 2)
        Me.btnGenreAnimation.TextShadow = System.Drawing.Color.White
        Me.btnGenreAnimation.TextShadowShow = False
        '
        'btnFilterTopRated
        '
        Me.btnFilterTopRated.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFilterTopRated.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnFilterTopRated.BorderColor = System.Drawing.Color.Transparent
        Me.btnFilterTopRated.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnFilterTopRated.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFilterTopRated.DesignerSelected = False
        Me.btnFilterTopRated.DimFactorClick = 0
        Me.btnFilterTopRated.DimFactorHover = 0
        Me.btnFilterTopRated.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnFilterTopRated.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnFilterTopRated.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnFilterTopRated.ImageIndex = 0
        Me.btnFilterTopRated.Location = New System.Drawing.Point(9, 65)
        Me.btnFilterTopRated.Margin = New System.Windows.Forms.Padding(0)
        Me.btnFilterTopRated.Name = "btnFilterTopRated"
        Me.btnFilterTopRated.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnFilterTopRated.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFilterTopRated.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnFilterTopRated.Size = New System.Drawing.Size(153, 28)
        Me.btnFilterTopRated.TabIndex = 100042
        Me.btnFilterTopRated.TabStop = False
        Me.btnFilterTopRated.Text = "Top Rated"
        Me.btnFilterTopRated.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFilterTopRated.TextMargin = New System.Windows.Forms.Padding(10, 2, 2, 2)
        Me.btnFilterTopRated.TextShadow = System.Drawing.Color.White
        Me.btnFilterTopRated.TextShadowShow = False
        '
        'btnGenreComedy
        '
        Me.btnGenreComedy.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreComedy.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnGenreComedy.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreComedy.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreComedy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreComedy.DesignerSelected = False
        Me.btnGenreComedy.DimFactorClick = 0
        Me.btnGenreComedy.DimFactorHover = 0
        Me.btnGenreComedy.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreComedy.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnGenreComedy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnGenreComedy.ImageIndex = 0
        Me.btnGenreComedy.Location = New System.Drawing.Point(9, 177)
        Me.btnGenreComedy.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreComedy.Name = "btnGenreComedy"
        Me.btnGenreComedy.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreComedy.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreComedy.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreComedy.Size = New System.Drawing.Size(153, 28)
        Me.btnGenreComedy.TabIndex = 100022
        Me.btnGenreComedy.TabStop = False
        Me.btnGenreComedy.Text = "Comedy"
        Me.btnGenreComedy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreComedy.TextMargin = New System.Windows.Forms.Padding(10, 2, 2, 2)
        Me.btnGenreComedy.TextShadow = System.Drawing.Color.White
        Me.btnGenreComedy.TextShadowShow = False
        '
        'btnFilterNewReleases
        '
        Me.btnFilterNewReleases.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFilterNewReleases.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnFilterNewReleases.BorderColor = System.Drawing.Color.Transparent
        Me.btnFilterNewReleases.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnFilterNewReleases.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFilterNewReleases.DesignerSelected = False
        Me.btnFilterNewReleases.DimFactorClick = 0
        Me.btnFilterNewReleases.DimFactorHover = 0
        Me.btnFilterNewReleases.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnFilterNewReleases.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnFilterNewReleases.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnFilterNewReleases.ImageIndex = 0
        Me.btnFilterNewReleases.Location = New System.Drawing.Point(9, 37)
        Me.btnFilterNewReleases.Margin = New System.Windows.Forms.Padding(0)
        Me.btnFilterNewReleases.Name = "btnFilterNewReleases"
        Me.btnFilterNewReleases.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnFilterNewReleases.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFilterNewReleases.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnFilterNewReleases.Size = New System.Drawing.Size(153, 28)
        Me.btnFilterNewReleases.TabIndex = 100041
        Me.btnFilterNewReleases.TabStop = False
        Me.btnFilterNewReleases.Text = "New Releases"
        Me.btnFilterNewReleases.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFilterNewReleases.TextMargin = New System.Windows.Forms.Padding(10, 2, 2, 2)
        Me.btnFilterNewReleases.TextShadow = System.Drawing.Color.White
        Me.btnFilterNewReleases.TextShadowShow = False
        '
        'btnGenreCrime
        '
        Me.btnGenreCrime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreCrime.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnGenreCrime.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreCrime.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreCrime.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreCrime.DesignerSelected = False
        Me.btnGenreCrime.DimFactorClick = 0
        Me.btnGenreCrime.DimFactorHover = 0
        Me.btnGenreCrime.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreCrime.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnGenreCrime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnGenreCrime.ImageIndex = 0
        Me.btnGenreCrime.Location = New System.Drawing.Point(9, 205)
        Me.btnGenreCrime.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreCrime.Name = "btnGenreCrime"
        Me.btnGenreCrime.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreCrime.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreCrime.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreCrime.Size = New System.Drawing.Size(153, 28)
        Me.btnGenreCrime.TabIndex = 100023
        Me.btnGenreCrime.TabStop = False
        Me.btnGenreCrime.Text = "Crime"
        Me.btnGenreCrime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreCrime.TextMargin = New System.Windows.Forms.Padding(10, 2, 2, 2)
        Me.btnGenreCrime.TextShadow = System.Drawing.Color.White
        Me.btnGenreCrime.TextShadowShow = False
        '
        'btnFilterTrending
        '
        Me.btnFilterTrending.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFilterTrending.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnFilterTrending.BorderColor = System.Drawing.Color.Transparent
        Me.btnFilterTrending.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnFilterTrending.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFilterTrending.DesignerSelected = False
        Me.btnFilterTrending.DimFactorClick = 0
        Me.btnFilterTrending.DimFactorHover = 0
        Me.btnFilterTrending.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnFilterTrending.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnFilterTrending.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnFilterTrending.ImageIndex = 0
        Me.btnFilterTrending.Location = New System.Drawing.Point(9, 9)
        Me.btnFilterTrending.Margin = New System.Windows.Forms.Padding(0)
        Me.btnFilterTrending.Name = "btnFilterTrending"
        Me.btnFilterTrending.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnFilterTrending.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFilterTrending.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnFilterTrending.Size = New System.Drawing.Size(153, 28)
        Me.btnFilterTrending.TabIndex = 100040
        Me.btnFilterTrending.TabStop = False
        Me.btnFilterTrending.Text = "Trending"
        Me.btnFilterTrending.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFilterTrending.TextMargin = New System.Windows.Forms.Padding(10, 2, 2, 2)
        Me.btnFilterTrending.TextShadow = System.Drawing.Color.White
        Me.btnFilterTrending.TextShadowShow = False
        '
        'btnGenreDocumentary
        '
        Me.btnGenreDocumentary.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreDocumentary.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnGenreDocumentary.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreDocumentary.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreDocumentary.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreDocumentary.DesignerSelected = False
        Me.btnGenreDocumentary.DimFactorClick = 0
        Me.btnGenreDocumentary.DimFactorHover = 0
        Me.btnGenreDocumentary.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreDocumentary.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnGenreDocumentary.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnGenreDocumentary.ImageIndex = 0
        Me.btnGenreDocumentary.Location = New System.Drawing.Point(9, 233)
        Me.btnGenreDocumentary.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreDocumentary.Name = "btnGenreDocumentary"
        Me.btnGenreDocumentary.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreDocumentary.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreDocumentary.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreDocumentary.Size = New System.Drawing.Size(153, 28)
        Me.btnGenreDocumentary.TabIndex = 100024
        Me.btnGenreDocumentary.TabStop = False
        Me.btnGenreDocumentary.Text = "Documentary"
        Me.btnGenreDocumentary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreDocumentary.TextMargin = New System.Windows.Forms.Padding(10, 2, 2, 2)
        Me.btnGenreDocumentary.TextShadow = System.Drawing.Color.White
        Me.btnGenreDocumentary.TextShadowShow = False
        '
        'btnGenreRomance
        '
        Me.btnGenreRomance.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreRomance.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnGenreRomance.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreRomance.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreRomance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreRomance.DesignerSelected = False
        Me.btnGenreRomance.DimFactorClick = 0
        Me.btnGenreRomance.DimFactorHover = 0
        Me.btnGenreRomance.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreRomance.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnGenreRomance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnGenreRomance.ImageIndex = 0
        Me.btnGenreRomance.Location = New System.Drawing.Point(9, 457)
        Me.btnGenreRomance.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreRomance.Name = "btnGenreRomance"
        Me.btnGenreRomance.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreRomance.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreRomance.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreRomance.Size = New System.Drawing.Size(153, 28)
        Me.btnGenreRomance.TabIndex = 100033
        Me.btnGenreRomance.TabStop = False
        Me.btnGenreRomance.Text = "Romance"
        Me.btnGenreRomance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreRomance.TextMargin = New System.Windows.Forms.Padding(10, 2, 2, 2)
        Me.btnGenreRomance.TextShadow = System.Drawing.Color.White
        Me.btnGenreRomance.TextShadowShow = False
        '
        'btnGenreDrama
        '
        Me.btnGenreDrama.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreDrama.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnGenreDrama.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreDrama.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreDrama.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreDrama.DesignerSelected = False
        Me.btnGenreDrama.DimFactorClick = 0
        Me.btnGenreDrama.DimFactorHover = 0
        Me.btnGenreDrama.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreDrama.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnGenreDrama.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnGenreDrama.ImageIndex = 0
        Me.btnGenreDrama.Location = New System.Drawing.Point(9, 261)
        Me.btnGenreDrama.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreDrama.Name = "btnGenreDrama"
        Me.btnGenreDrama.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreDrama.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreDrama.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreDrama.Size = New System.Drawing.Size(153, 28)
        Me.btnGenreDrama.TabIndex = 100025
        Me.btnGenreDrama.TabStop = False
        Me.btnGenreDrama.Text = "Drama"
        Me.btnGenreDrama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreDrama.TextMargin = New System.Windows.Forms.Padding(10, 2, 2, 2)
        Me.btnGenreDrama.TextShadow = System.Drawing.Color.White
        Me.btnGenreDrama.TextShadowShow = False
        '
        'btnGenreSciFi
        '
        Me.btnGenreSciFi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreSciFi.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnGenreSciFi.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreSciFi.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreSciFi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreSciFi.DesignerSelected = False
        Me.btnGenreSciFi.DimFactorClick = 0
        Me.btnGenreSciFi.DimFactorHover = 0
        Me.btnGenreSciFi.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreSciFi.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnGenreSciFi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnGenreSciFi.ImageIndex = 0
        Me.btnGenreSciFi.Location = New System.Drawing.Point(9, 485)
        Me.btnGenreSciFi.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreSciFi.Name = "btnGenreSciFi"
        Me.btnGenreSciFi.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreSciFi.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreSciFi.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreSciFi.Size = New System.Drawing.Size(153, 28)
        Me.btnGenreSciFi.TabIndex = 100034
        Me.btnGenreSciFi.TabStop = False
        Me.btnGenreSciFi.Text = "Sci-Fi"
        Me.btnGenreSciFi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreSciFi.TextMargin = New System.Windows.Forms.Padding(10, 2, 2, 2)
        Me.btnGenreSciFi.TextShadow = System.Drawing.Color.White
        Me.btnGenreSciFi.TextShadowShow = False
        '
        'btnGenreFamily
        '
        Me.btnGenreFamily.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreFamily.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnGenreFamily.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreFamily.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreFamily.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreFamily.DesignerSelected = False
        Me.btnGenreFamily.DimFactorClick = 0
        Me.btnGenreFamily.DimFactorHover = 0
        Me.btnGenreFamily.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreFamily.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnGenreFamily.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnGenreFamily.ImageIndex = 0
        Me.btnGenreFamily.Location = New System.Drawing.Point(9, 289)
        Me.btnGenreFamily.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreFamily.Name = "btnGenreFamily"
        Me.btnGenreFamily.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreFamily.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreFamily.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreFamily.Size = New System.Drawing.Size(153, 28)
        Me.btnGenreFamily.TabIndex = 100026
        Me.btnGenreFamily.TabStop = False
        Me.btnGenreFamily.Text = "Family"
        Me.btnGenreFamily.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreFamily.TextMargin = New System.Windows.Forms.Padding(10, 2, 2, 2)
        Me.btnGenreFamily.TextShadow = System.Drawing.Color.White
        Me.btnGenreFamily.TextShadowShow = False
        '
        'btnGenreMystery
        '
        Me.btnGenreMystery.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreMystery.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnGenreMystery.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreMystery.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreMystery.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreMystery.DesignerSelected = True
        Me.btnGenreMystery.DimFactorClick = 0
        Me.btnGenreMystery.DimFactorHover = 0
        Me.btnGenreMystery.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreMystery.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnGenreMystery.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnGenreMystery.ImageIndex = 0
        Me.btnGenreMystery.Location = New System.Drawing.Point(9, 429)
        Me.btnGenreMystery.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreMystery.Name = "btnGenreMystery"
        Me.btnGenreMystery.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreMystery.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreMystery.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreMystery.Size = New System.Drawing.Size(153, 28)
        Me.btnGenreMystery.TabIndex = 100032
        Me.btnGenreMystery.TabStop = False
        Me.btnGenreMystery.Text = "Mystery"
        Me.btnGenreMystery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreMystery.TextMargin = New System.Windows.Forms.Padding(10, 2, 2, 2)
        Me.btnGenreMystery.TextShadow = System.Drawing.Color.White
        Me.btnGenreMystery.TextShadowShow = False
        '
        'btnGenreFantasy
        '
        Me.btnGenreFantasy.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreFantasy.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnGenreFantasy.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreFantasy.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreFantasy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreFantasy.DesignerSelected = False
        Me.btnGenreFantasy.DimFactorClick = 0
        Me.btnGenreFantasy.DimFactorHover = 0
        Me.btnGenreFantasy.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreFantasy.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnGenreFantasy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnGenreFantasy.ImageIndex = 0
        Me.btnGenreFantasy.Location = New System.Drawing.Point(9, 317)
        Me.btnGenreFantasy.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreFantasy.Name = "btnGenreFantasy"
        Me.btnGenreFantasy.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreFantasy.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreFantasy.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreFantasy.Size = New System.Drawing.Size(153, 28)
        Me.btnGenreFantasy.TabIndex = 100027
        Me.btnGenreFantasy.TabStop = False
        Me.btnGenreFantasy.Text = "Fantasy"
        Me.btnGenreFantasy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreFantasy.TextMargin = New System.Windows.Forms.Padding(10, 2, 2, 2)
        Me.btnGenreFantasy.TextShadow = System.Drawing.Color.White
        Me.btnGenreFantasy.TextShadowShow = False
        '
        'btnGenreThriller
        '
        Me.btnGenreThriller.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreThriller.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnGenreThriller.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreThriller.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreThriller.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreThriller.DesignerSelected = False
        Me.btnGenreThriller.DimFactorClick = 0
        Me.btnGenreThriller.DimFactorHover = 0
        Me.btnGenreThriller.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreThriller.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnGenreThriller.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnGenreThriller.ImageIndex = 0
        Me.btnGenreThriller.Location = New System.Drawing.Point(9, 513)
        Me.btnGenreThriller.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreThriller.Name = "btnGenreThriller"
        Me.btnGenreThriller.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreThriller.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreThriller.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreThriller.Size = New System.Drawing.Size(153, 28)
        Me.btnGenreThriller.TabIndex = 100036
        Me.btnGenreThriller.TabStop = False
        Me.btnGenreThriller.Text = "Thriller"
        Me.btnGenreThriller.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreThriller.TextMargin = New System.Windows.Forms.Padding(10, 2, 2, 2)
        Me.btnGenreThriller.TextShadow = System.Drawing.Color.White
        Me.btnGenreThriller.TextShadowShow = False
        '
        'btnGenreAllMovies
        '
        Me.btnGenreAllMovies.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreAllMovies.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnGenreAllMovies.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreAllMovies.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreAllMovies.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreAllMovies.DesignerSelected = False
        Me.btnGenreAllMovies.DimFactorClick = 0
        Me.btnGenreAllMovies.DimFactorHover = 0
        Me.btnGenreAllMovies.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreAllMovies.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnGenreAllMovies.ImageIndex = 0
        Me.btnGenreAllMovies.Location = New System.Drawing.Point(9, 597)
        Me.btnGenreAllMovies.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreAllMovies.Name = "btnGenreAllMovies"
        Me.btnGenreAllMovies.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreAllMovies.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreAllMovies.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreAllMovies.Size = New System.Drawing.Size(153, 28)
        Me.btnGenreAllMovies.TabIndex = 100039
        Me.btnGenreAllMovies.TabStop = False
        Me.btnGenreAllMovies.Text = "Any Genre"
        Me.btnGenreAllMovies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreAllMovies.TextMargin = New System.Windows.Forms.Padding(10, 2, 2, 2)
        Me.btnGenreAllMovies.TextShadow = System.Drawing.Color.White
        Me.btnGenreAllMovies.TextShadowShow = False
        '
        'btnGenreMusic
        '
        Me.btnGenreMusic.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreMusic.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnGenreMusic.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreMusic.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreMusic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreMusic.DesignerSelected = False
        Me.btnGenreMusic.DimFactorClick = 0
        Me.btnGenreMusic.DimFactorHover = 0
        Me.btnGenreMusic.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreMusic.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnGenreMusic.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnGenreMusic.ImageIndex = 0
        Me.btnGenreMusic.Location = New System.Drawing.Point(9, 401)
        Me.btnGenreMusic.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreMusic.Name = "btnGenreMusic"
        Me.btnGenreMusic.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreMusic.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreMusic.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreMusic.Size = New System.Drawing.Size(153, 28)
        Me.btnGenreMusic.TabIndex = 100031
        Me.btnGenreMusic.TabStop = False
        Me.btnGenreMusic.Text = "Music"
        Me.btnGenreMusic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreMusic.TextMargin = New System.Windows.Forms.Padding(10, 2, 2, 2)
        Me.btnGenreMusic.TextShadow = System.Drawing.Color.White
        Me.btnGenreMusic.TextShadowShow = False
        '
        'btnGenreHistory
        '
        Me.btnGenreHistory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnGenreHistory.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreHistory.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreHistory.DesignerSelected = False
        Me.btnGenreHistory.DimFactorClick = 0
        Me.btnGenreHistory.DimFactorHover = 0
        Me.btnGenreHistory.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreHistory.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnGenreHistory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnGenreHistory.ImageIndex = 0
        Me.btnGenreHistory.Location = New System.Drawing.Point(9, 345)
        Me.btnGenreHistory.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreHistory.Name = "btnGenreHistory"
        Me.btnGenreHistory.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreHistory.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreHistory.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreHistory.Size = New System.Drawing.Size(153, 28)
        Me.btnGenreHistory.TabIndex = 100029
        Me.btnGenreHistory.TabStop = False
        Me.btnGenreHistory.Text = "History"
        Me.btnGenreHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreHistory.TextMargin = New System.Windows.Forms.Padding(10, 2, 2, 2)
        Me.btnGenreHistory.TextShadow = System.Drawing.Color.White
        Me.btnGenreHistory.TextShadowShow = False
        '
        'btnGenreWar
        '
        Me.btnGenreWar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreWar.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnGenreWar.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreWar.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreWar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreWar.DesignerSelected = False
        Me.btnGenreWar.DimFactorClick = 0
        Me.btnGenreWar.DimFactorHover = 0
        Me.btnGenreWar.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreWar.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnGenreWar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnGenreWar.ImageIndex = 0
        Me.btnGenreWar.Location = New System.Drawing.Point(9, 541)
        Me.btnGenreWar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreWar.Name = "btnGenreWar"
        Me.btnGenreWar.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreWar.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreWar.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreWar.Size = New System.Drawing.Size(153, 28)
        Me.btnGenreWar.TabIndex = 100037
        Me.btnGenreWar.TabStop = False
        Me.btnGenreWar.Text = "War"
        Me.btnGenreWar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreWar.TextMargin = New System.Windows.Forms.Padding(10, 2, 2, 2)
        Me.btnGenreWar.TextShadow = System.Drawing.Color.White
        Me.btnGenreWar.TextShadowShow = False
        '
        'btnGenreWestern
        '
        Me.btnGenreWestern.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreWestern.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnGenreWestern.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreWestern.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreWestern.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreWestern.DesignerSelected = False
        Me.btnGenreWestern.DimFactorClick = 0
        Me.btnGenreWestern.DimFactorHover = 0
        Me.btnGenreWestern.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreWestern.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnGenreWestern.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnGenreWestern.ImageIndex = 0
        Me.btnGenreWestern.Location = New System.Drawing.Point(9, 569)
        Me.btnGenreWestern.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreWestern.Name = "btnGenreWestern"
        Me.btnGenreWestern.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreWestern.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreWestern.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreWestern.Size = New System.Drawing.Size(153, 28)
        Me.btnGenreWestern.TabIndex = 100038
        Me.btnGenreWestern.TabStop = False
        Me.btnGenreWestern.Text = "Western"
        Me.btnGenreWestern.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreWestern.TextMargin = New System.Windows.Forms.Padding(10, 2, 2, 2)
        Me.btnGenreWestern.TextShadow = System.Drawing.Color.White
        Me.btnGenreWestern.TextShadowShow = False
        '
        'btnGenreHorror
        '
        Me.btnGenreHorror.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenreHorror.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnGenreHorror.BorderColor = System.Drawing.Color.Transparent
        Me.btnGenreHorror.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnGenreHorror.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenreHorror.DesignerSelected = False
        Me.btnGenreHorror.DimFactorClick = 0
        Me.btnGenreHorror.DimFactorHover = 0
        Me.btnGenreHorror.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnGenreHorror.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnGenreHorror.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnGenreHorror.ImageIndex = 0
        Me.btnGenreHorror.Location = New System.Drawing.Point(9, 373)
        Me.btnGenreHorror.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenreHorror.Name = "btnGenreHorror"
        Me.btnGenreHorror.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnGenreHorror.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenreHorror.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnGenreHorror.Size = New System.Drawing.Size(153, 28)
        Me.btnGenreHorror.TabIndex = 100030
        Me.btnGenreHorror.TabStop = False
        Me.btnGenreHorror.Text = "Horror"
        Me.btnGenreHorror.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenreHorror.TextMargin = New System.Windows.Forms.Padding(10, 2, 2, 2)
        Me.btnGenreHorror.TextShadow = System.Drawing.Color.White
        Me.btnGenreHorror.TextShadowShow = False
        '
        'panelMovies
        '
        Me.panelMovies.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelMovies.AutoScroll = True
        Me.panelMovies.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.panelMovies.Location = New System.Drawing.Point(172, 0)
        Me.panelMovies.Margin = New System.Windows.Forms.Padding(0, 6, 3, 3)
        Me.panelMovies.Name = "panelMovies"
        Me.panelMovies.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.panelMovies.Size = New System.Drawing.Size(1119, 693)
        Me.panelMovies.TabIndex = 10006
        '
        'tabCollections
        '
        Me.tabCollections.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabCollections.Controls.Add(Me.tabsCollections)
        Me.tabCollections.Location = New System.Drawing.Point(23, 4)
        Me.tabCollections.Name = "tabCollections"
        Me.tabCollections.Size = New System.Drawing.Size(1291, 693)
        Me.tabCollections.TabIndex = 12
        Me.tabCollections.Text = "tabCollections"
        '
        'tabsCollections
        '
        Me.tabsCollections.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabsCollections.Controls.Add(Me.tabCollectionsHome)
        Me.tabsCollections.Controls.Add(Me.tabCollectionsMovies)
        Me.tabsCollections.Location = New System.Drawing.Point(-4, -22)
        Me.tabsCollections.Name = "tabsCollections"
        Me.tabsCollections.SelectedIndex = 0
        Me.tabsCollections.Size = New System.Drawing.Size(1299, 719)
        Me.tabsCollections.TabIndex = 100011
        Me.tabsCollections.TabStop = False
        '
        'tabCollectionsHome
        '
        Me.tabCollectionsHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabCollectionsHome.Controls.Add(Me.panelCollectionsItems)
        Me.tabCollectionsHome.Location = New System.Drawing.Point(4, 22)
        Me.tabCollectionsHome.Name = "tabCollectionsHome"
        Me.tabCollectionsHome.Size = New System.Drawing.Size(1291, 693)
        Me.tabCollectionsHome.TabIndex = 0
        Me.tabCollectionsHome.Text = "TabPage1"
        '
        'panelCollectionsItems
        '
        Me.panelCollectionsItems.AutoScroll = True
        Me.panelCollectionsItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.panelCollectionsItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelCollectionsItems.Location = New System.Drawing.Point(0, 0)
        Me.panelCollectionsItems.Margin = New System.Windows.Forms.Padding(0, 6, 3, 3)
        Me.panelCollectionsItems.Name = "panelCollectionsItems"
        Me.panelCollectionsItems.Padding = New System.Windows.Forms.Padding(6, 4, 4, 0)
        Me.panelCollectionsItems.Size = New System.Drawing.Size(1291, 693)
        Me.panelCollectionsItems.TabIndex = 10008
        '
        'tabCollectionsMovies
        '
        Me.tabCollectionsMovies.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabCollectionsMovies.Controls.Add(Me.panelCollectionsCtrls)
        Me.tabCollectionsMovies.Location = New System.Drawing.Point(4, 22)
        Me.tabCollectionsMovies.Name = "tabCollectionsMovies"
        Me.tabCollectionsMovies.Size = New System.Drawing.Size(1291, 693)
        Me.tabCollectionsMovies.TabIndex = 1
        Me.tabCollectionsMovies.Text = "tabSearchesHome"
        '
        'panelCollectionsCtrls
        '
        Me.panelCollectionsCtrls.AutoScroll = True
        Me.panelCollectionsCtrls.Controls.Add(Me.panelCollectionsDetails)
        Me.panelCollectionsCtrls.Controls.Add(Me.panelCollectionsMovies)
        Me.panelCollectionsCtrls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelCollectionsCtrls.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.panelCollectionsCtrls.Location = New System.Drawing.Point(0, 0)
        Me.panelCollectionsCtrls.Name = "panelCollectionsCtrls"
        Me.panelCollectionsCtrls.Size = New System.Drawing.Size(1291, 693)
        Me.panelCollectionsCtrls.TabIndex = 0
        '
        'panelCollectionsDetails
        '
        Me.panelCollectionsDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelCollectionsDetails.AutoSize = True
        Me.panelCollectionsDetails.Controls.Add(Me.imgCollectionsB2Browse)
        Me.panelCollectionsDetails.Controls.Add(Me.lblCollectionsTitle)
        Me.panelCollectionsDetails.Controls.Add(Me.lblCollectionsComment)
        Me.panelCollectionsDetails.Controls.Add(Me.lblCollectionMoviesWatched)
        Me.panelCollectionsDetails.Location = New System.Drawing.Point(0, 3)
        Me.panelCollectionsDetails.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.panelCollectionsDetails.Name = "panelCollectionsDetails"
        Me.panelCollectionsDetails.Size = New System.Drawing.Size(300, 75)
        Me.panelCollectionsDetails.TabIndex = 100032
        '
        'imgCollectionsB2Browse
        '
        Me.imgCollectionsB2Browse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgCollectionsB2Browse.Image = Global.Movieo.My.Resources.Resources.ArrowLeftH
        Me.imgCollectionsB2Browse.Location = New System.Drawing.Point(11, 3)
        Me.imgCollectionsB2Browse.Margin = New System.Windows.Forms.Padding(11, 3, 0, 3)
        Me.imgCollectionsB2Browse.Name = "imgCollectionsB2Browse"
        Me.imgCollectionsB2Browse.Size = New System.Drawing.Size(23, 23)
        Me.imgCollectionsB2Browse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCollectionsB2Browse.TabIndex = 100031
        Me.imgCollectionsB2Browse.TabStop = False
        '
        'lblCollectionsTitle
        '
        Me.lblCollectionsTitle.AutoSize = True
        Me.panelCollectionsDetails.SetFlowBreak(Me.lblCollectionsTitle, True)
        Me.lblCollectionsTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 12.25!)
        Me.lblCollectionsTitle.ForeColor = System.Drawing.Color.White
        Me.lblCollectionsTitle.Location = New System.Drawing.Point(34, 3)
        Me.lblCollectionsTitle.Margin = New System.Windows.Forms.Padding(0, 3, 3, 0)
        Me.lblCollectionsTitle.Name = "lblCollectionsTitle"
        Me.lblCollectionsTitle.Size = New System.Drawing.Size(123, 23)
        Me.lblCollectionsTitle.TabIndex = 100028
        Me.lblCollectionsTitle.Text = "Collection Title"
        '
        'lblCollectionsComment
        '
        Me.lblCollectionsComment.AutoSize = True
        Me.panelCollectionsDetails.SetFlowBreak(Me.lblCollectionsComment, True)
        Me.lblCollectionsComment.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.lblCollectionsComment.ForeColor = System.Drawing.Color.DarkGray
        Me.lblCollectionsComment.Location = New System.Drawing.Point(12, 33)
        Me.lblCollectionsComment.Margin = New System.Windows.Forms.Padding(12, 4, 3, 0)
        Me.lblCollectionsComment.Name = "lblCollectionsComment"
        Me.lblCollectionsComment.Size = New System.Drawing.Size(138, 19)
        Me.lblCollectionsComment.TabIndex = 100030
        Me.lblCollectionsComment.Text = "Collection Comment"
        '
        'lblCollectionMoviesWatched
        '
        Me.lblCollectionMoviesWatched.AutoSize = True
        Me.lblCollectionMoviesWatched.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.lblCollectionMoviesWatched.ForeColor = System.Drawing.Color.DarkGray
        Me.lblCollectionMoviesWatched.Location = New System.Drawing.Point(12, 56)
        Me.lblCollectionMoviesWatched.Margin = New System.Windows.Forms.Padding(12, 4, 3, 0)
        Me.lblCollectionMoviesWatched.Name = "lblCollectionMoviesWatched"
        Me.lblCollectionMoviesWatched.Size = New System.Drawing.Size(132, 19)
        Me.lblCollectionMoviesWatched.TabIndex = 100032
        Me.lblCollectionMoviesWatched.Text = "?/? movies watched"
        '
        'panelCollectionsMovies
        '
        Me.panelCollectionsMovies.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelCollectionsMovies.AutoSize = True
        Me.panelCollectionsMovies.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.panelCollectionsMovies.Location = New System.Drawing.Point(1, 87)
        Me.panelCollectionsMovies.Margin = New System.Windows.Forms.Padding(1, 6, 3, 3)
        Me.panelCollectionsMovies.Name = "panelCollectionsMovies"
        Me.panelCollectionsMovies.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.panelCollectionsMovies.Size = New System.Drawing.Size(299, 0)
        Me.panelCollectionsMovies.TabIndex = 10008
        '
        'tabLibrary
        '
        Me.tabLibrary.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabLibrary.Controls.Add(Me.panelLibraryCtrls)
        Me.tabLibrary.Controls.Add(Me.tabsLibrary)
        Me.tabLibrary.Location = New System.Drawing.Point(23, 4)
        Me.tabLibrary.Margin = New System.Windows.Forms.Padding(0)
        Me.tabLibrary.Name = "tabLibrary"
        Me.tabLibrary.Size = New System.Drawing.Size(1291, 693)
        Me.tabLibrary.TabIndex = 10
        Me.tabLibrary.Text = "tabMyLists"
        '
        'panelLibraryCtrls
        '
        Me.panelLibraryCtrls.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panelLibraryCtrls.AutoScroll = True
        Me.panelLibraryCtrls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelLibraryCtrls.Controls.Add(Me.lblEmptyPanelMyLists)
        Me.panelLibraryCtrls.Controls.Add(Me.panelMyCoreListsCtrls)
        Me.panelLibraryCtrls.Controls.Add(Me.lblHeaderLibrary)
        Me.panelLibraryCtrls.Controls.Add(Me.lblHeaderMyLists)
        Me.panelLibraryCtrls.Controls.Add(Me.panelMyListsCtrls)
        Me.panelLibraryCtrls.Location = New System.Drawing.Point(0, 0)
        Me.panelLibraryCtrls.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.panelLibraryCtrls.Name = "panelLibraryCtrls"
        Me.panelLibraryCtrls.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.panelLibraryCtrls.Size = New System.Drawing.Size(172, 693)
        Me.panelLibraryCtrls.TabIndex = 100021
        '
        'lblEmptyPanelMyLists
        '
        Me.lblEmptyPanelMyLists.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmptyPanelMyLists.AutoSize = True
        Me.lblEmptyPanelMyLists.BackColor = System.Drawing.Color.Transparent
        Me.lblEmptyPanelMyLists.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.lblEmptyPanelMyLists.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.lblEmptyPanelMyLists.Location = New System.Drawing.Point(21, 175)
        Me.lblEmptyPanelMyLists.Name = "lblEmptyPanelMyLists"
        Me.lblEmptyPanelMyLists.Size = New System.Drawing.Size(131, 38)
        Me.lblEmptyPanelMyLists.TabIndex = 999
        Me.lblEmptyPanelMyLists.Text = "You haven't created" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "any lists yet!"
        Me.lblEmptyPanelMyLists.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelMyCoreListsCtrls
        '
        Me.panelMyCoreListsCtrls.Controls.Add(Me.btnListsFavourites)
        Me.panelMyCoreListsCtrls.Controls.Add(Me.btnListsWatch)
        Me.panelMyCoreListsCtrls.Controls.Add(Me.btnListsSeen)
        Me.panelMyCoreListsCtrls.Controls.Add(Me.btnListsBlack)
        Me.panelMyCoreListsCtrls.Location = New System.Drawing.Point(9, 32)
        Me.panelMyCoreListsCtrls.Name = "panelMyCoreListsCtrls"
        Me.panelMyCoreListsCtrls.Size = New System.Drawing.Size(154, 112)
        Me.panelMyCoreListsCtrls.TabIndex = 100041
        '
        'btnListsFavourites
        '
        Me.btnListsFavourites.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnListsFavourites.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnListsFavourites.BorderColor = System.Drawing.Color.Transparent
        Me.btnListsFavourites.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnListsFavourites.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListsFavourites.DesignerSelected = False
        Me.btnListsFavourites.DimFactorClick = 0
        Me.btnListsFavourites.DimFactorHover = 0
        Me.btnListsFavourites.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnListsFavourites.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnListsFavourites.ImageIndex = 0
        Me.btnListsFavourites.Location = New System.Drawing.Point(0, 0)
        Me.btnListsFavourites.Margin = New System.Windows.Forms.Padding(0)
        Me.btnListsFavourites.Name = "btnListsFavourites"
        Me.btnListsFavourites.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnListsFavourites.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnListsFavourites.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnListsFavourites.Size = New System.Drawing.Size(154, 28)
        Me.btnListsFavourites.TabIndex = 100019
        Me.btnListsFavourites.TabStop = False
        Me.btnListsFavourites.Text = "Favourites"
        Me.btnListsFavourites.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListsFavourites.TextMargin = New System.Windows.Forms.Padding(10, 2, 2, 2)
        Me.btnListsFavourites.TextShadow = System.Drawing.Color.White
        Me.btnListsFavourites.TextShadowShow = False
        '
        'btnListsWatch
        '
        Me.btnListsWatch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnListsWatch.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnListsWatch.BorderColor = System.Drawing.Color.Transparent
        Me.btnListsWatch.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnListsWatch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListsWatch.DesignerSelected = False
        Me.btnListsWatch.DimFactorClick = 0
        Me.btnListsWatch.DimFactorHover = 0
        Me.btnListsWatch.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnListsWatch.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnListsWatch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnListsWatch.ImageIndex = 0
        Me.btnListsWatch.Location = New System.Drawing.Point(0, 28)
        Me.btnListsWatch.Margin = New System.Windows.Forms.Padding(0)
        Me.btnListsWatch.Name = "btnListsWatch"
        Me.btnListsWatch.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnListsWatch.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnListsWatch.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnListsWatch.Size = New System.Drawing.Size(154, 28)
        Me.btnListsWatch.TabIndex = 100020
        Me.btnListsWatch.TabStop = False
        Me.btnListsWatch.Text = "Watch List"
        Me.btnListsWatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListsWatch.TextMargin = New System.Windows.Forms.Padding(10, 2, 2, 2)
        Me.btnListsWatch.TextShadow = System.Drawing.Color.White
        Me.btnListsWatch.TextShadowShow = False
        '
        'btnListsSeen
        '
        Me.btnListsSeen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnListsSeen.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnListsSeen.BorderColor = System.Drawing.Color.Transparent
        Me.btnListsSeen.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnListsSeen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListsSeen.DesignerSelected = False
        Me.btnListsSeen.DimFactorClick = 0
        Me.btnListsSeen.DimFactorHover = 0
        Me.btnListsSeen.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnListsSeen.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnListsSeen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnListsSeen.ImageIndex = 0
        Me.btnListsSeen.Location = New System.Drawing.Point(0, 56)
        Me.btnListsSeen.Margin = New System.Windows.Forms.Padding(0)
        Me.btnListsSeen.Name = "btnListsSeen"
        Me.btnListsSeen.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnListsSeen.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnListsSeen.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnListsSeen.Size = New System.Drawing.Size(154, 28)
        Me.btnListsSeen.TabIndex = 100021
        Me.btnListsSeen.TabStop = False
        Me.btnListsSeen.Text = "Seen List"
        Me.btnListsSeen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListsSeen.TextMargin = New System.Windows.Forms.Padding(10, 2, 2, 2)
        Me.btnListsSeen.TextShadow = System.Drawing.Color.White
        Me.btnListsSeen.TextShadowShow = False
        '
        'btnListsBlack
        '
        Me.btnListsBlack.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnListsBlack.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnListsBlack.BorderColor = System.Drawing.Color.Transparent
        Me.btnListsBlack.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnListsBlack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListsBlack.DesignerSelected = False
        Me.btnListsBlack.DimFactorClick = 0
        Me.btnListsBlack.DimFactorHover = 0
        Me.btnListsBlack.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnListsBlack.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnListsBlack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnListsBlack.ImageIndex = 0
        Me.btnListsBlack.Location = New System.Drawing.Point(0, 84)
        Me.btnListsBlack.Margin = New System.Windows.Forms.Padding(0)
        Me.btnListsBlack.Name = "btnListsBlack"
        Me.btnListsBlack.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnListsBlack.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnListsBlack.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnListsBlack.Size = New System.Drawing.Size(154, 28)
        Me.btnListsBlack.TabIndex = 100039
        Me.btnListsBlack.TabStop = False
        Me.btnListsBlack.Text = "Black List"
        Me.btnListsBlack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListsBlack.TextMargin = New System.Windows.Forms.Padding(10, 2, 2, 2)
        Me.btnListsBlack.TextShadow = System.Drawing.Color.White
        Me.btnListsBlack.TextShadowShow = False
        '
        'lblHeaderLibrary
        '
        Me.lblHeaderLibrary.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHeaderLibrary.AutoSize = True
        Me.lblHeaderLibrary.BackColor = System.Drawing.Color.Transparent
        Me.lblHeaderLibrary.Font = New System.Drawing.Font("Segoe UI Semibold", 7.5!)
        Me.lblHeaderLibrary.ForeColor = System.Drawing.Color.White
        Me.lblHeaderLibrary.Location = New System.Drawing.Point(19, 12)
        Me.lblHeaderLibrary.Margin = New System.Windows.Forms.Padding(3, 0, 3, 6)
        Me.lblHeaderLibrary.Name = "lblHeaderLibrary"
        Me.lblHeaderLibrary.Size = New System.Drawing.Size(75, 12)
        Me.lblHeaderLibrary.TabIndex = 100040
        Me.lblHeaderLibrary.Text = "MY CORE LISTS"
        Me.lblHeaderLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHeaderMyLists
        '
        Me.lblHeaderMyLists.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHeaderMyLists.AutoSize = True
        Me.lblHeaderMyLists.BackColor = System.Drawing.Color.Transparent
        Me.lblHeaderMyLists.Font = New System.Drawing.Font("Segoe UI Semibold", 7.5!)
        Me.lblHeaderMyLists.ForeColor = System.Drawing.Color.White
        Me.lblHeaderMyLists.Location = New System.Drawing.Point(19, 154)
        Me.lblHeaderMyLists.Name = "lblHeaderMyLists"
        Me.lblHeaderMyLists.Size = New System.Drawing.Size(91, 12)
        Me.lblHeaderMyLists.TabIndex = 10009
        Me.lblHeaderMyLists.Text = "MY CREATED LISTS"
        Me.lblHeaderMyLists.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelMyListsCtrls
        '
        Me.panelMyListsCtrls.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelMyListsCtrls.AutoSize = True
        Me.panelMyListsCtrls.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.panelMyListsCtrls.Location = New System.Drawing.Point(9, 175)
        Me.panelMyListsCtrls.MaximumSize = New System.Drawing.Size(154, 0)
        Me.panelMyListsCtrls.MinimumSize = New System.Drawing.Size(154, 0)
        Me.panelMyListsCtrls.Name = "panelMyListsCtrls"
        Me.panelMyListsCtrls.Size = New System.Drawing.Size(154, 0)
        Me.panelMyListsCtrls.TabIndex = 10009
        '
        'tabsLibrary
        '
        Me.tabsLibrary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabsLibrary.Controls.Add(Me.tabLibraryFavourites)
        Me.tabsLibrary.Controls.Add(Me.tabLibraryWatchList)
        Me.tabsLibrary.Controls.Add(Me.tabLibrarySeenList)
        Me.tabsLibrary.Controls.Add(Me.tabLibraryBlackList)
        Me.tabsLibrary.Controls.Add(Me.tabLibraryMyLists)
        Me.tabsLibrary.Location = New System.Drawing.Point(168, -22)
        Me.tabsLibrary.Name = "tabsLibrary"
        Me.tabsLibrary.SelectedIndex = 0
        Me.tabsLibrary.Size = New System.Drawing.Size(1127, 719)
        Me.tabsLibrary.TabIndex = 100009
        Me.tabsLibrary.TabStop = False
        '
        'tabLibraryFavourites
        '
        Me.tabLibraryFavourites.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabLibraryFavourites.Controls.Add(Me.lblEmptyFavourites)
        Me.tabLibraryFavourites.Controls.Add(Me.panelLibraryFavourites)
        Me.tabLibraryFavourites.Location = New System.Drawing.Point(4, 22)
        Me.tabLibraryFavourites.Name = "tabLibraryFavourites"
        Me.tabLibraryFavourites.Size = New System.Drawing.Size(1119, 693)
        Me.tabLibraryFavourites.TabIndex = 0
        Me.tabLibraryFavourites.Text = "tabLibraryFavourites"
        '
        'lblEmptyFavourites
        '
        Me.lblEmptyFavourites.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmptyFavourites.BackColor = System.Drawing.Color.Transparent
        Me.lblEmptyFavourites.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblEmptyFavourites.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblEmptyFavourites.Location = New System.Drawing.Point(138, 80)
        Me.lblEmptyFavourites.Name = "lblEmptyFavourites"
        Me.lblEmptyFavourites.Size = New System.Drawing.Size(841, 56)
        Me.lblEmptyFavourites.TabIndex = 10007
        Me.lblEmptyFavourites.Text = "Nothing to see here..."
        Me.lblEmptyFavourites.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelLibraryFavourites
        '
        Me.panelLibraryFavourites.AutoScroll = True
        Me.panelLibraryFavourites.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.panelLibraryFavourites.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelLibraryFavourites.Location = New System.Drawing.Point(0, 0)
        Me.panelLibraryFavourites.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.panelLibraryFavourites.Name = "panelLibraryFavourites"
        Me.panelLibraryFavourites.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.panelLibraryFavourites.Size = New System.Drawing.Size(1119, 693)
        Me.panelLibraryFavourites.TabIndex = 10008
        '
        'tabLibraryWatchList
        '
        Me.tabLibraryWatchList.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabLibraryWatchList.Controls.Add(Me.lblEmptyWatchList)
        Me.tabLibraryWatchList.Controls.Add(Me.panelLibraryWatchList)
        Me.tabLibraryWatchList.Location = New System.Drawing.Point(4, 22)
        Me.tabLibraryWatchList.Name = "tabLibraryWatchList"
        Me.tabLibraryWatchList.Size = New System.Drawing.Size(1119, 693)
        Me.tabLibraryWatchList.TabIndex = 1
        Me.tabLibraryWatchList.Text = "tabLibraryWatchList"
        '
        'lblEmptyWatchList
        '
        Me.lblEmptyWatchList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmptyWatchList.BackColor = System.Drawing.Color.Transparent
        Me.lblEmptyWatchList.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblEmptyWatchList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblEmptyWatchList.Location = New System.Drawing.Point(138, 80)
        Me.lblEmptyWatchList.Name = "lblEmptyWatchList"
        Me.lblEmptyWatchList.Size = New System.Drawing.Size(841, 56)
        Me.lblEmptyWatchList.TabIndex = 10007
        Me.lblEmptyWatchList.Text = "Nothing to see here..."
        Me.lblEmptyWatchList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelLibraryWatchList
        '
        Me.panelLibraryWatchList.AutoScroll = True
        Me.panelLibraryWatchList.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.panelLibraryWatchList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelLibraryWatchList.Location = New System.Drawing.Point(0, 0)
        Me.panelLibraryWatchList.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.panelLibraryWatchList.Name = "panelLibraryWatchList"
        Me.panelLibraryWatchList.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.panelLibraryWatchList.Size = New System.Drawing.Size(1119, 693)
        Me.panelLibraryWatchList.TabIndex = 10008
        '
        'tabLibrarySeenList
        '
        Me.tabLibrarySeenList.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabLibrarySeenList.Controls.Add(Me.lblEmptySeenList)
        Me.tabLibrarySeenList.Controls.Add(Me.panelLibrarySeenList)
        Me.tabLibrarySeenList.Location = New System.Drawing.Point(4, 22)
        Me.tabLibrarySeenList.Name = "tabLibrarySeenList"
        Me.tabLibrarySeenList.Size = New System.Drawing.Size(1119, 693)
        Me.tabLibrarySeenList.TabIndex = 2
        Me.tabLibrarySeenList.Text = "tabLibrarySeenList"
        '
        'lblEmptySeenList
        '
        Me.lblEmptySeenList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmptySeenList.BackColor = System.Drawing.Color.Transparent
        Me.lblEmptySeenList.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblEmptySeenList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblEmptySeenList.Location = New System.Drawing.Point(138, 80)
        Me.lblEmptySeenList.Name = "lblEmptySeenList"
        Me.lblEmptySeenList.Size = New System.Drawing.Size(841, 56)
        Me.lblEmptySeenList.TabIndex = 10007
        Me.lblEmptySeenList.Text = "Nothing to see here..."
        Me.lblEmptySeenList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelLibrarySeenList
        '
        Me.panelLibrarySeenList.AutoScroll = True
        Me.panelLibrarySeenList.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.panelLibrarySeenList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelLibrarySeenList.Location = New System.Drawing.Point(0, 0)
        Me.panelLibrarySeenList.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.panelLibrarySeenList.Name = "panelLibrarySeenList"
        Me.panelLibrarySeenList.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.panelLibrarySeenList.Size = New System.Drawing.Size(1119, 693)
        Me.panelLibrarySeenList.TabIndex = 10008
        '
        'tabLibraryBlackList
        '
        Me.tabLibraryBlackList.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabLibraryBlackList.Controls.Add(Me.lblEmptyBlackList)
        Me.tabLibraryBlackList.Controls.Add(Me.panelLibraryBlackList)
        Me.tabLibraryBlackList.Location = New System.Drawing.Point(4, 22)
        Me.tabLibraryBlackList.Name = "tabLibraryBlackList"
        Me.tabLibraryBlackList.Size = New System.Drawing.Size(1119, 693)
        Me.tabLibraryBlackList.TabIndex = 3
        Me.tabLibraryBlackList.Text = "tabLibraryBlackList"
        '
        'lblEmptyBlackList
        '
        Me.lblEmptyBlackList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmptyBlackList.BackColor = System.Drawing.Color.Transparent
        Me.lblEmptyBlackList.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblEmptyBlackList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblEmptyBlackList.Location = New System.Drawing.Point(141, 80)
        Me.lblEmptyBlackList.Name = "lblEmptyBlackList"
        Me.lblEmptyBlackList.Size = New System.Drawing.Size(835, 56)
        Me.lblEmptyBlackList.TabIndex = 10007
        Me.lblEmptyBlackList.Text = "Nothing to see here..."
        Me.lblEmptyBlackList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelLibraryBlackList
        '
        Me.panelLibraryBlackList.AutoScroll = True
        Me.panelLibraryBlackList.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.panelLibraryBlackList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelLibraryBlackList.Location = New System.Drawing.Point(0, 0)
        Me.panelLibraryBlackList.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.panelLibraryBlackList.Name = "panelLibraryBlackList"
        Me.panelLibraryBlackList.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.panelLibraryBlackList.Size = New System.Drawing.Size(1119, 693)
        Me.panelLibraryBlackList.TabIndex = 10008
        '
        'tabLibraryMyLists
        '
        Me.tabLibraryMyLists.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabLibraryMyLists.Controls.Add(Me.lblEmptyMyLists)
        Me.tabLibraryMyLists.Controls.Add(Me.panelMyListsMovies)
        Me.tabLibraryMyLists.Location = New System.Drawing.Point(4, 22)
        Me.tabLibraryMyLists.Name = "tabLibraryMyLists"
        Me.tabLibraryMyLists.Size = New System.Drawing.Size(1119, 693)
        Me.tabLibraryMyLists.TabIndex = 4
        Me.tabLibraryMyLists.Text = "tabLibraryMyLists"
        '
        'lblEmptyMyLists
        '
        Me.lblEmptyMyLists.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmptyMyLists.BackColor = System.Drawing.Color.Transparent
        Me.lblEmptyMyLists.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblEmptyMyLists.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblEmptyMyLists.Location = New System.Drawing.Point(138, 80)
        Me.lblEmptyMyLists.Name = "lblEmptyMyLists"
        Me.lblEmptyMyLists.Size = New System.Drawing.Size(841, 56)
        Me.lblEmptyMyLists.TabIndex = 10010
        Me.lblEmptyMyLists.Text = "Nothing to see here..."
        Me.lblEmptyMyLists.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelMyListsMovies
        '
        Me.panelMyListsMovies.AutoScroll = True
        Me.panelMyListsMovies.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.panelMyListsMovies.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMyListsMovies.Location = New System.Drawing.Point(0, 0)
        Me.panelMyListsMovies.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.panelMyListsMovies.Name = "panelMyListsMovies"
        Me.panelMyListsMovies.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.panelMyListsMovies.Size = New System.Drawing.Size(1119, 693)
        Me.panelMyListsMovies.TabIndex = 10009
        '
        'tabDownloads
        '
        Me.tabDownloads.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabDownloads.Controls.Add(Me.lblEmptyDownloads)
        Me.tabDownloads.Controls.Add(Me.panelDownloads)
        Me.tabDownloads.Location = New System.Drawing.Point(23, 4)
        Me.tabDownloads.Name = "tabDownloads"
        Me.tabDownloads.Size = New System.Drawing.Size(1291, 693)
        Me.tabDownloads.TabIndex = 13
        Me.tabDownloads.Text = "tabDownloads"
        '
        'lblEmptyDownloads
        '
        Me.lblEmptyDownloads.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmptyDownloads.BackColor = System.Drawing.Color.Transparent
        Me.lblEmptyDownloads.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblEmptyDownloads.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblEmptyDownloads.Location = New System.Drawing.Point(138, 80)
        Me.lblEmptyDownloads.Name = "lblEmptyDownloads"
        Me.lblEmptyDownloads.Size = New System.Drawing.Size(1013, 56)
        Me.lblEmptyDownloads.TabIndex = 10009
        Me.lblEmptyDownloads.Text = "Nothing to see here..."
        Me.lblEmptyDownloads.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelDownloads
        '
        Me.panelDownloads.AutoScroll = True
        Me.panelDownloads.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.panelDownloads.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelDownloads.Location = New System.Drawing.Point(0, 0)
        Me.panelDownloads.Margin = New System.Windows.Forms.Padding(4, 6, 3, 3)
        Me.panelDownloads.Name = "panelDownloads"
        Me.panelDownloads.Padding = New System.Windows.Forms.Padding(4, 6, 0, 0)
        Me.panelDownloads.Size = New System.Drawing.Size(1291, 693)
        Me.panelDownloads.TabIndex = 10010
        '
        'tabSearches
        '
        Me.tabSearches.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabSearches.Controls.Add(Me.tabsSearches)
        Me.tabSearches.Location = New System.Drawing.Point(23, 4)
        Me.tabSearches.Name = "tabSearches"
        Me.tabSearches.Size = New System.Drawing.Size(1291, 693)
        Me.tabSearches.TabIndex = 11
        Me.tabSearches.Text = "tabSearches"
        '
        'tabsSearches
        '
        Me.tabsSearches.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabsSearches.Controls.Add(Me.tabSearchesHome)
        Me.tabsSearches.Controls.Add(Me.tabSearchesMovies)
        Me.tabsSearches.Location = New System.Drawing.Point(-4, -22)
        Me.tabsSearches.Name = "tabsSearches"
        Me.tabsSearches.SelectedIndex = 0
        Me.tabsSearches.Size = New System.Drawing.Size(1299, 719)
        Me.tabsSearches.TabIndex = 100010
        '
        'tabSearchesHome
        '
        Me.tabSearchesHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabSearchesHome.Controls.Add(Me.lblSearch3)
        Me.tabSearchesHome.Controls.Add(Me.imgSearch3)
        Me.tabSearchesHome.Controls.Add(Me.lblSearch1)
        Me.tabSearchesHome.Controls.Add(Me.imgSearch1)
        Me.tabSearchesHome.Controls.Add(Me.lblSearch2)
        Me.tabSearchesHome.Controls.Add(Me.imgSearch2)
        Me.tabSearchesHome.Location = New System.Drawing.Point(4, 22)
        Me.tabSearchesHome.Name = "tabSearchesHome"
        Me.tabSearchesHome.Size = New System.Drawing.Size(1291, 693)
        Me.tabSearchesHome.TabIndex = 0
        Me.tabSearchesHome.Text = "tabSearchesHome"
        '
        'lblSearch3
        '
        Me.lblSearch3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSearch3.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblSearch3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.lblSearch3.Location = New System.Drawing.Point(836, 188)
        Me.lblSearch3.Name = "lblSearch3"
        Me.lblSearch3.Size = New System.Drawing.Size(198, 44)
        Me.lblSearch3.TabIndex = 5
        Me.lblSearch3.Text = "Paste HTTP links"
        Me.lblSearch3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'imgSearch3
        '
        Me.imgSearch3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.imgSearch3.Image = Global.Movieo.My.Resources.Resources.iconURLs
        Me.imgSearch3.Location = New System.Drawing.Point(890, 79)
        Me.imgSearch3.Margin = New System.Windows.Forms.Padding(100, 3, 100, 3)
        Me.imgSearch3.Name = "imgSearch3"
        Me.imgSearch3.Size = New System.Drawing.Size(90, 90)
        Me.imgSearch3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSearch3.TabIndex = 4
        Me.imgSearch3.TabStop = False
        '
        'lblSearch1
        '
        Me.lblSearch1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSearch1.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblSearch1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.lblSearch1.Location = New System.Drawing.Point(256, 188)
        Me.lblSearch1.Name = "lblSearch1"
        Me.lblSearch1.Size = New System.Drawing.Size(198, 44)
        Me.lblSearch1.TabIndex = 3
        Me.lblSearch1.Text = "Search for movies"
        Me.lblSearch1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'imgSearch1
        '
        Me.imgSearch1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.imgSearch1.Image = Global.Movieo.My.Resources.Resources.iconMovies
        Me.imgSearch1.Location = New System.Drawing.Point(310, 79)
        Me.imgSearch1.Margin = New System.Windows.Forms.Padding(100, 3, 100, 3)
        Me.imgSearch1.Name = "imgSearch1"
        Me.imgSearch1.Size = New System.Drawing.Size(90, 90)
        Me.imgSearch1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSearch1.TabIndex = 2
        Me.imgSearch1.TabStop = False
        '
        'lblSearch2
        '
        Me.lblSearch2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSearch2.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblSearch2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.lblSearch2.Location = New System.Drawing.Point(546, 188)
        Me.lblSearch2.Name = "lblSearch2"
        Me.lblSearch2.Size = New System.Drawing.Size(198, 44)
        Me.lblSearch2.TabIndex = 1
        Me.lblSearch2.Text = "Search for actors, directors and writers"
        Me.lblSearch2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'imgSearch2
        '
        Me.imgSearch2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.imgSearch2.Image = Global.Movieo.My.Resources.Resources.iconActors
        Me.imgSearch2.Location = New System.Drawing.Point(600, 79)
        Me.imgSearch2.Margin = New System.Windows.Forms.Padding(100, 3, 100, 3)
        Me.imgSearch2.Name = "imgSearch2"
        Me.imgSearch2.Size = New System.Drawing.Size(90, 90)
        Me.imgSearch2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSearch2.TabIndex = 0
        Me.imgSearch2.TabStop = False
        '
        'tabSearchesMovies
        '
        Me.tabSearchesMovies.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabSearchesMovies.Controls.Add(Me.lblEmptyPanelSearches)
        Me.tabSearchesMovies.Controls.Add(Me.panelSearches)
        Me.tabSearchesMovies.Location = New System.Drawing.Point(4, 22)
        Me.tabSearchesMovies.Name = "tabSearchesMovies"
        Me.tabSearchesMovies.Size = New System.Drawing.Size(1291, 693)
        Me.tabSearchesMovies.TabIndex = 1
        Me.tabSearchesMovies.Text = "tabSearchesHome"
        '
        'lblEmptyPanelSearches
        '
        Me.lblEmptyPanelSearches.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmptyPanelSearches.BackColor = System.Drawing.Color.Transparent
        Me.lblEmptyPanelSearches.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblEmptyPanelSearches.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblEmptyPanelSearches.Location = New System.Drawing.Point(138, 80)
        Me.lblEmptyPanelSearches.Name = "lblEmptyPanelSearches"
        Me.lblEmptyPanelSearches.Size = New System.Drawing.Size(1013, 56)
        Me.lblEmptyPanelSearches.TabIndex = 10007
        Me.lblEmptyPanelSearches.Text = "No results found :/"
        Me.lblEmptyPanelSearches.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelSearches
        '
        Me.panelSearches.AutoScroll = True
        Me.panelSearches.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.panelSearches.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelSearches.Location = New System.Drawing.Point(0, 0)
        Me.panelSearches.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.panelSearches.Name = "panelSearches"
        Me.panelSearches.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.panelSearches.Size = New System.Drawing.Size(1291, 693)
        Me.panelSearches.TabIndex = 10008
        '
        'tabLoading
        '
        Me.tabLoading.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tabLoading.Controls.Add(Me.lblLoading)
        Me.tabLoading.Controls.Add(Me.richtxtMovieDb)
        Me.tabLoading.Controls.Add(Me.lblLoadingSub)
        Me.tabLoading.Location = New System.Drawing.Point(23, 4)
        Me.tabLoading.Name = "tabLoading"
        Me.tabLoading.Size = New System.Drawing.Size(1291, 693)
        Me.tabLoading.TabIndex = 5
        Me.tabLoading.Text = "tabLoading"
        '
        'lblLoading
        '
        Me.lblLoading.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLoading.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblLoading.ForeColor = System.Drawing.Color.White
        Me.lblLoading.Location = New System.Drawing.Point(236, 82)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(818, 26)
        Me.lblLoading.TabIndex = 39
        Me.lblLoading.Text = "Loading..."
        Me.lblLoading.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'richtxtMovieDb
        '
        Me.richtxtMovieDb.Location = New System.Drawing.Point(3, 3)
        Me.richtxtMovieDb.Name = "richtxtMovieDb"
        Me.richtxtMovieDb.Size = New System.Drawing.Size(120, 96)
        Me.richtxtMovieDb.TabIndex = 23
        Me.richtxtMovieDb.Text = ""
        Me.richtxtMovieDb.Visible = False
        '
        'lblLoadingSub
        '
        Me.lblLoadingSub.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLoadingSub.Font = New System.Drawing.Font("Segoe UI Semibold", 13.5!)
        Me.lblLoadingSub.ForeColor = System.Drawing.Color.White
        Me.lblLoadingSub.Location = New System.Drawing.Point(236, 114)
        Me.lblLoadingSub.Name = "lblLoadingSub"
        Me.lblLoadingSub.Size = New System.Drawing.Size(818, 223)
        Me.lblLoadingSub.TabIndex = 38
        Me.lblLoadingSub.Text = "Please wait, we're loading your movies" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This may take a while..."
        Me.lblLoadingSub.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TextUseBrowseTab
        '
        Me.TextUseBrowseTab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextUseBrowseTab.BackColor = System.Drawing.Color.Transparent
        Me.TextUseBrowseTab.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextUseBrowseTab.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.TextUseBrowseTab.Location = New System.Drawing.Point(127, 224)
        Me.TextUseBrowseTab.Name = "TextUseBrowseTab"
        Me.TextUseBrowseTab.Size = New System.Drawing.Size(1040, 253)
        Me.TextUseBrowseTab.TabIndex = 19
        Me.TextUseBrowseTab.Text = "Use the 'Movies' tab to find a movie :)"
        Me.TextUseBrowseTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timerStartup
        '
        Me.timerStartup.Interval = 650
        '
        'timerCheckForUpdate
        '
        '
        'panelTabTitles
        '
        Me.panelTabTitles.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.panelTabTitles.Controls.Add(Me.btnCreateList)
        Me.panelTabTitles.Controls.Add(Me.titleCoreCollections)
        Me.panelTabTitles.Controls.Add(Me.titleCoreLibrary)
        Me.panelTabTitles.Controls.Add(Me.txtboxSearch)
        Me.panelTabTitles.Controls.Add(Me.btnInfoMenu)
        Me.panelTabTitles.Controls.Add(Me.titleCoreDiscover)
        Me.panelTabTitles.Controls.Add(Me.imgSearchIcon)
        Me.panelTabTitles.Controls.Add(Me.txtboxSearchBG)
        Me.panelTabTitles.Controls.Add(Me.titleCoreDownloads)
        Me.panelTabTitles.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTabTitles.Location = New System.Drawing.Point(0, 0)
        Me.panelTabTitles.Name = "panelTabTitles"
        Me.panelTabTitles.Size = New System.Drawing.Size(1291, 40)
        Me.panelTabTitles.TabIndex = 1027
        '
        'btnCreateList
        '
        Me.btnCreateList.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnCreateList.BorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnCreateList.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnCreateList.Corners.All = 2
        Me.btnCreateList.Corners.LowerLeft = 2
        Me.btnCreateList.Corners.LowerRight = 2
        Me.btnCreateList.Corners.UpperLeft = 2
        Me.btnCreateList.Corners.UpperRight = 2
        Me.btnCreateList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreateList.DesignerSelected = False
        Me.btnCreateList.DimFactorClick = 0
        Me.btnCreateList.DimFactorHover = 0
        Me.btnCreateList.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnCreateList.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.btnCreateList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnCreateList.ImageIndex = 0
        Me.btnCreateList.Location = New System.Drawing.Point(1113, 6)
        Me.btnCreateList.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.btnCreateList.Name = "btnCreateList"
        Me.btnCreateList.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnCreateList.SideImageSize = New System.Drawing.Size(298, 300)
        Me.btnCreateList.Size = New System.Drawing.Size(109, 28)
        Me.btnCreateList.TabIndex = 100029
        Me.btnCreateList.Text = "CREATE A LIST"
        Me.btnCreateList.TextShadowShow = False
        '
        'titleCoreCollections
        '
        Me.titleCoreCollections.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.titleCoreCollections.BackColor = System.Drawing.Color.Transparent
        Me.titleCoreCollections.BorderColor = System.Drawing.Color.Transparent
        Me.titleCoreCollections.BorderShow = False
        Me.titleCoreCollections.ColorFillSolid = System.Drawing.Color.Transparent
        Me.titleCoreCollections.Corners.UpperLeft = 2
        Me.titleCoreCollections.Corners.UpperRight = 2
        Me.titleCoreCollections.Cursor = System.Windows.Forms.Cursors.Hand
        Me.titleCoreCollections.DesignerSelected = False
        Me.titleCoreCollections.DimFactorClick = 0
        Me.titleCoreCollections.DimFactorHover = 0
        Me.titleCoreCollections.FillType = CButtonLib.CButton.eFillType.Solid
        Me.titleCoreCollections.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.titleCoreCollections.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.titleCoreCollections.ImageIndex = 0
        Me.titleCoreCollections.Location = New System.Drawing.Point(91, 8)
        Me.titleCoreCollections.Margin = New System.Windows.Forms.Padding(0)
        Me.titleCoreCollections.Name = "titleCoreCollections"
        Me.titleCoreCollections.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.titleCoreCollections.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.titleCoreCollections.SideImageSize = New System.Drawing.Size(14, 15)
        Me.titleCoreCollections.Size = New System.Drawing.Size(100, 24)
        Me.titleCoreCollections.TabIndex = 100027
        Me.titleCoreCollections.TabStop = False
        Me.titleCoreCollections.Text = "COLLECTIONS"
        Me.titleCoreCollections.TextMargin = New System.Windows.Forms.Padding(2, 4, 2, 2)
        Me.titleCoreCollections.TextShadow = System.Drawing.Color.White
        Me.titleCoreCollections.TextShadowShow = False
        '
        'titleCoreLibrary
        '
        Me.titleCoreLibrary.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.titleCoreLibrary.BackColor = System.Drawing.Color.Transparent
        Me.titleCoreLibrary.BorderColor = System.Drawing.Color.Transparent
        Me.titleCoreLibrary.BorderShow = False
        Me.titleCoreLibrary.ColorFillSolid = System.Drawing.Color.Transparent
        Me.titleCoreLibrary.Corners.UpperLeft = 2
        Me.titleCoreLibrary.Corners.UpperRight = 2
        Me.titleCoreLibrary.Cursor = System.Windows.Forms.Cursors.Hand
        Me.titleCoreLibrary.DesignerSelected = False
        Me.titleCoreLibrary.DimFactorClick = 0
        Me.titleCoreLibrary.DimFactorHover = 0
        Me.titleCoreLibrary.FillType = CButtonLib.CButton.eFillType.Solid
        Me.titleCoreLibrary.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.titleCoreLibrary.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.titleCoreLibrary.ImageIndex = 0
        Me.titleCoreLibrary.Location = New System.Drawing.Point(191, 8)
        Me.titleCoreLibrary.Margin = New System.Windows.Forms.Padding(0)
        Me.titleCoreLibrary.Name = "titleCoreLibrary"
        Me.titleCoreLibrary.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.titleCoreLibrary.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.titleCoreLibrary.SideImageSize = New System.Drawing.Size(14, 15)
        Me.titleCoreLibrary.Size = New System.Drawing.Size(66, 24)
        Me.titleCoreLibrary.TabIndex = 100006
        Me.titleCoreLibrary.TabStop = False
        Me.titleCoreLibrary.Text = "LIBRARY"
        Me.titleCoreLibrary.TextMargin = New System.Windows.Forms.Padding(2, 4, 2, 2)
        Me.titleCoreLibrary.TextShadow = System.Drawing.Color.White
        Me.titleCoreLibrary.TextShadowShow = False
        '
        'txtboxSearch
        '
        Me.txtboxSearch.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtboxSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.txtboxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.txtboxSearch.ForeColor = System.Drawing.Color.White
        Me.txtboxSearch.Location = New System.Drawing.Point(851, 10)
        Me.txtboxSearch.MaxLength = 50
        Me.txtboxSearch.Name = "txtboxSearch"
        Me.txtboxSearch.Size = New System.Drawing.Size(213, 18)
        Me.txtboxSearch.TabIndex = 100022
        Me.txtboxSearch.WaterMark = "Search movies, people, years..."
        Me.txtboxSearch.WaterMarkActiveForeColor = System.Drawing.Color.White
        Me.txtboxSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.txtboxSearch.WaterMarkForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        '
        'btnInfoMenu
        '
        Me.btnInfoMenu.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnInfoMenu.BackColor = System.Drawing.Color.Transparent
        Me.btnInfoMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInfoMenu.Image = Global.Movieo.My.Resources.Resources.DropletsIconL
        Me.btnInfoMenu.Location = New System.Drawing.Point(1249, 5)
        Me.btnInfoMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.btnInfoMenu.Name = "btnInfoMenu"
        Me.btnInfoMenu.Size = New System.Drawing.Size(34, 32)
        Me.btnInfoMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnInfoMenu.TabIndex = 1006
        Me.btnInfoMenu.TabStop = False
        '
        'titleCoreDiscover
        '
        Me.titleCoreDiscover.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.titleCoreDiscover.BackColor = System.Drawing.Color.Transparent
        Me.titleCoreDiscover.BorderColor = System.Drawing.Color.Transparent
        Me.titleCoreDiscover.BorderShow = False
        Me.titleCoreDiscover.ColorFillSolid = System.Drawing.Color.Transparent
        Me.titleCoreDiscover.Corners.UpperLeft = 2
        Me.titleCoreDiscover.Corners.UpperRight = 2
        Me.titleCoreDiscover.Cursor = System.Windows.Forms.Cursors.Hand
        Me.titleCoreDiscover.DesignerSelected = False
        Me.titleCoreDiscover.DimFactorClick = 0
        Me.titleCoreDiscover.DimFactorHover = 0
        Me.titleCoreDiscover.FillType = CButtonLib.CButton.eFillType.Solid
        Me.titleCoreDiscover.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.titleCoreDiscover.ImageIndex = 0
        Me.titleCoreDiscover.Location = New System.Drawing.Point(15, 8)
        Me.titleCoreDiscover.Margin = New System.Windows.Forms.Padding(0)
        Me.titleCoreDiscover.Name = "titleCoreDiscover"
        Me.titleCoreDiscover.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.titleCoreDiscover.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.titleCoreDiscover.SideImageSize = New System.Drawing.Size(14, 15)
        Me.titleCoreDiscover.Size = New System.Drawing.Size(76, 24)
        Me.titleCoreDiscover.TabIndex = 2
        Me.titleCoreDiscover.TabStop = False
        Me.titleCoreDiscover.Text = "DISCOVER"
        Me.titleCoreDiscover.TextMargin = New System.Windows.Forms.Padding(2, 4, 2, 2)
        Me.titleCoreDiscover.TextShadow = System.Drawing.Color.White
        Me.titleCoreDiscover.TextShadowShow = False
        '
        'imgSearchIcon
        '
        Me.imgSearchIcon.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.imgSearchIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.imgSearchIcon.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgSearchIcon.Image = CType(resources.GetObject("imgSearchIcon.Image"), System.Drawing.Image)
        Me.imgSearchIcon.Location = New System.Drawing.Point(828, 12)
        Me.imgSearchIcon.Margin = New System.Windows.Forms.Padding(0)
        Me.imgSearchIcon.Name = "imgSearchIcon"
        Me.imgSearchIcon.Size = New System.Drawing.Size(18, 18)
        Me.imgSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSearchIcon.TabIndex = 100026
        Me.imgSearchIcon.TabStop = False
        '
        'txtboxSearchBG
        '
        Me.txtboxSearchBG.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxSearchBG.BackColor = System.Drawing.Color.Transparent
        Me.txtboxSearchBG.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.txtboxSearchBG.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.txtboxSearchBG.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxSearchBG.DesignerSelected = False
        Me.txtboxSearchBG.DimFactorClick = 0
        Me.txtboxSearchBG.DimFactorHover = 0
        Me.txtboxSearchBG.FillType = CButtonLib.CButton.eFillType.Solid
        Me.txtboxSearchBG.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtboxSearchBG.ImageIndex = 0
        Me.txtboxSearchBG.Location = New System.Drawing.Point(816, 0)
        Me.txtboxSearchBG.Name = "txtboxSearchBG"
        Me.txtboxSearchBG.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.txtboxSearchBG.Size = New System.Drawing.Size(255, 40)
        Me.txtboxSearchBG.TabIndex = 100025
        Me.txtboxSearchBG.Text = ""
        Me.txtboxSearchBG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtboxSearchBG.TextShadow = System.Drawing.Color.White
        Me.txtboxSearchBG.TextShadowShow = False
        '
        'titleCoreDownloads
        '
        Me.titleCoreDownloads.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.titleCoreDownloads.BackColor = System.Drawing.Color.Transparent
        Me.titleCoreDownloads.BorderColor = System.Drawing.Color.Transparent
        Me.titleCoreDownloads.BorderShow = False
        Me.titleCoreDownloads.ColorFillSolid = System.Drawing.Color.Transparent
        Me.titleCoreDownloads.Corners.UpperLeft = 2
        Me.titleCoreDownloads.Corners.UpperRight = 2
        Me.titleCoreDownloads.Cursor = System.Windows.Forms.Cursors.Hand
        Me.titleCoreDownloads.DesignerSelected = False
        Me.titleCoreDownloads.DimFactorClick = 0
        Me.titleCoreDownloads.DimFactorHover = 0
        Me.titleCoreDownloads.FillType = CButtonLib.CButton.eFillType.Solid
        Me.titleCoreDownloads.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.titleCoreDownloads.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.titleCoreDownloads.ImageIndex = 0
        Me.titleCoreDownloads.Location = New System.Drawing.Point(256, 8)
        Me.titleCoreDownloads.Margin = New System.Windows.Forms.Padding(0)
        Me.titleCoreDownloads.Name = "titleCoreDownloads"
        Me.titleCoreDownloads.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.titleCoreDownloads.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.titleCoreDownloads.SideImageSize = New System.Drawing.Size(14, 15)
        Me.titleCoreDownloads.Size = New System.Drawing.Size(99, 24)
        Me.titleCoreDownloads.TabIndex = 100028
        Me.titleCoreDownloads.TabStop = False
        Me.titleCoreDownloads.Text = "DOWNLOADS"
        Me.titleCoreDownloads.TextMargin = New System.Windows.Forms.Padding(2, 4, 2, 2)
        Me.titleCoreDownloads.TextShadow = System.Drawing.Color.White
        Me.titleCoreDownloads.TextShadowShow = False
        '
        'timerResetFilters
        '
        Me.timerResetFilters.Interval = 750
        '
        'timerFilterGenre
        '
        Me.timerFilterGenre.Interval = 750
        '
        'timerSearchMovies
        '
        Me.timerSearchMovies.Interval = 750
        '
        'timerHideNotifications
        '
        Me.timerHideNotifications.Interval = 1000
        '
        'timerHideNotification
        '
        Me.timerHideNotification.Interval = 4000
        '
        'timerHideNotificationss
        '
        Me.timerHideNotificationss.Interval = 4000
        '
        'timerCountdownLiveMovie
        '
        Me.timerCountdownLiveMovie.Interval = 4000
        '
        'timerGoToTime
        '
        Me.timerGoToTime.Interval = 500
        '
        'icoLoadingWeb
        '
        Me.icoLoadingWeb.Location = New System.Drawing.Point(0, 0)
        Me.icoLoadingWeb.Name = "icoLoadingWeb"
        Me.icoLoadingWeb.Size = New System.Drawing.Size(100, 50)
        Me.icoLoadingWeb.TabIndex = 0
        Me.icoLoadingWeb.TabStop = False
        '
        'Movieo
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1291, 733)
        Me.Controls.Add(Me.panelTabTitles)
        Me.Controls.Add(Me.Tab)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(864, 369)
        Me.Name = "Movieo"
        Me.Text = "Movieo - Discover and watch movies instantly"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Tab.ResumeLayout(False)
        Me.tabDiscover.ResumeLayout(False)
        Me.panelGenresCtrls.ResumeLayout(False)
        Me.tabCollections.ResumeLayout(False)
        Me.tabsCollections.ResumeLayout(False)
        Me.tabCollectionsHome.ResumeLayout(False)
        Me.tabCollectionsMovies.ResumeLayout(False)
        Me.panelCollectionsCtrls.ResumeLayout(False)
        Me.panelCollectionsCtrls.PerformLayout()
        Me.panelCollectionsDetails.ResumeLayout(False)
        Me.panelCollectionsDetails.PerformLayout()
        CType(Me.imgCollectionsB2Browse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabLibrary.ResumeLayout(False)
        Me.panelLibraryCtrls.ResumeLayout(False)
        Me.panelLibraryCtrls.PerformLayout()
        Me.panelMyCoreListsCtrls.ResumeLayout(False)
        Me.tabsLibrary.ResumeLayout(False)
        Me.tabLibraryFavourites.ResumeLayout(False)
        Me.tabLibraryWatchList.ResumeLayout(False)
        Me.tabLibrarySeenList.ResumeLayout(False)
        Me.tabLibraryBlackList.ResumeLayout(False)
        Me.tabLibraryMyLists.ResumeLayout(False)
        Me.tabDownloads.ResumeLayout(False)
        Me.tabSearches.ResumeLayout(False)
        Me.tabsSearches.ResumeLayout(False)
        Me.tabSearchesHome.ResumeLayout(False)
        CType(Me.imgSearch3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSearch1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSearch2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSearchesMovies.ResumeLayout(False)
        Me.tabLoading.ResumeLayout(False)
        Me.panelTabTitles.ResumeLayout(False)
        Me.panelTabTitles.PerformLayout()
        CType(Me.btnInfoMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSearchIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icoLoadingWeb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tab As TabControl
    Friend WithEvents tabDiscover As TabPage
    Friend WithEvents timerStartup As Timer
    Friend WithEvents tabLoading As TabPage
    Friend WithEvents txtPlayingTitle As Label
    Friend WithEvents TextUseBrowseTab As Label
    Friend WithEvents timerCheckForUpdate As Timer
    Friend WithEvents icoLoadingWeb As PictureBox
    Friend WithEvents GoFilm As Button
    Friend WithEvents FaveMovie As Button
    Friend WithEvents iconReportMovie As Button
    Friend WithEvents iconCloseMovie As Button
    Friend WithEvents panelTabTitles As Panel
    Public WithEvents titleCoreDiscover As CButtonLib.CButton
    Friend WithEvents btnInfoMenu As PictureBox
    Friend WithEvents richtxtMovieDb As RichTextBox
    Friend WithEvents panelMovies As FlowLayoutPanel
    Friend WithEvents titleCoreLibrary As CButtonLib.CButton
    Friend WithEvents tabLibrary As TabPage
    Friend WithEvents tabsLibrary As TabControl
    Friend WithEvents tabLibraryFavourites As TabPage
    Friend WithEvents tabLibraryWatchList As TabPage
    Friend WithEvents tabLibrarySeenList As TabPage
    Friend WithEvents tabLibraryBlackList As TabPage
    Friend WithEvents lblEmptyFavourites As Label
    Friend WithEvents panelLibraryFavourites As FlowLayoutPanel
    Friend WithEvents lblEmptyWatchList As Label
    Friend WithEvents panelLibraryWatchList As FlowLayoutPanel
    Friend WithEvents lblEmptySeenList As Label
    Friend WithEvents panelLibrarySeenList As FlowLayoutPanel
    Friend WithEvents lblEmptyBlackList As Label
    Friend WithEvents panelLibraryBlackList As FlowLayoutPanel
    Friend WithEvents txtboxSearch As ChreneLib.Controls.TextBoxes.CTextBox
    Friend WithEvents imgSearchIcon As PictureBox
    Friend WithEvents txtboxSearchBG As CButtonLib.CButton
    Friend WithEvents timerResetFilters As Timer
    Friend WithEvents timerFilterGenre As Timer
    Friend WithEvents timerSearchMovies As Timer
    Friend WithEvents tabSearches As TabPage
    Friend WithEvents tabsSearches As TabControl
    Friend WithEvents tabSearchesHome As TabPage
    Friend WithEvents tabSearchesMovies As TabPage
    Friend WithEvents lblEmptyPanelSearches As Label
    Friend WithEvents panelSearches As FlowLayoutPanel
    Friend WithEvents lblSearch3 As Label
    Friend WithEvents imgSearch3 As PictureBox
    Friend WithEvents lblSearch1 As Label
    Friend WithEvents imgSearch1 As PictureBox
    Friend WithEvents lblSearch2 As Label
    Friend WithEvents imgSearch2 As PictureBox
    Friend WithEvents panelGenresCtrls As Panel
    Friend WithEvents btnGenreAllMovies As CButtonLib.CButton
    Friend WithEvents btnGenreWestern As CButtonLib.CButton
    Friend WithEvents btnGenreWar As CButtonLib.CButton
    Friend WithEvents btnGenreThriller As CButtonLib.CButton
    Friend WithEvents btnGenreSciFi As CButtonLib.CButton
    Friend WithEvents btnGenreRomance As CButtonLib.CButton
    Friend WithEvents btnGenreMystery As CButtonLib.CButton
    Friend WithEvents btnGenreMusic As CButtonLib.CButton
    Friend WithEvents btnGenreHorror As CButtonLib.CButton
    Friend WithEvents btnGenreHistory As CButtonLib.CButton
    Friend WithEvents btnGenreFantasy As CButtonLib.CButton
    Friend WithEvents btnGenreFamily As CButtonLib.CButton
    Friend WithEvents btnGenreDrama As CButtonLib.CButton
    Friend WithEvents btnGenreDocumentary As CButtonLib.CButton
    Friend WithEvents btnGenreCrime As CButtonLib.CButton
    Friend WithEvents btnGenreComedy As CButtonLib.CButton
    Friend WithEvents btnGenreAnimation As CButtonLib.CButton
    Friend WithEvents btnGenreAdventure As CButtonLib.CButton
    Friend WithEvents btnGenreAction As CButtonLib.CButton
    Friend WithEvents timerHideNotifications As Timer
    Friend WithEvents panelLibraryCtrls As Panel
    Friend WithEvents btnListsBlack As CButtonLib.CButton
    Friend WithEvents btnListsSeen As CButtonLib.CButton
    Friend WithEvents btnListsWatch As CButtonLib.CButton
    Friend WithEvents btnListsFavourites As CButtonLib.CButton
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents timerHideNotification As Timer
    Friend WithEvents timerHideNotificationss As Timer
    Friend WithEvents tabCollections As TabPage
    Friend WithEvents titleCoreCollections As CButtonLib.CButton
    Friend WithEvents tabsCollections As TabControl
    Friend WithEvents tabCollectionsHome As TabPage
    Friend WithEvents panelCollectionsItems As FlowLayoutPanel
    Friend WithEvents tabCollectionsMovies As TabPage
    Friend WithEvents panelCollectionsMovies As FlowLayoutPanel
    Friend WithEvents panelCollectionsCtrls As FlowLayoutPanel
    Friend WithEvents lblCollectionsTitle As Label
    Friend WithEvents lblCollectionsComment As Label
    Friend WithEvents panelCollectionsDetails As FlowLayoutPanel
    Friend WithEvents imgCollectionsB2Browse As PictureBox
    Friend WithEvents titleCoreDownloads As CButtonLib.CButton
    Friend WithEvents lblCollectionMoviesWatched As Label
    Friend WithEvents tabDownloads As TabPage
    Friend WithEvents lblEmptyDownloads As Label
    Friend WithEvents panelDownloads As FlowLayoutPanel
    Friend WithEvents btnFilterTrending As CButtonLib.CButton
    Friend WithEvents btnFilterTopRated As CButtonLib.CButton
    Friend WithEvents btnFilterNewReleases As CButtonLib.CButton
    Friend WithEvents timerCountdownLiveMovie As Timer
    Friend WithEvents timerGoToTime As Timer
    Friend WithEvents lblLoadingSub As Label
    Friend WithEvents lblLoading As Label
    Friend WithEvents panelMyListsCtrls As FlowLayoutPanel
    Friend WithEvents tabLibraryMyLists As TabPage
    Friend WithEvents panelMyListsMovies As FlowLayoutPanel
    Friend WithEvents btnCreateList As CButtonLib.CButton
    Friend WithEvents lblHeaderLibrary As Label
    Friend WithEvents lblHeaderMyLists As Label
    Friend WithEvents lblEmptyMyLists As Label
    Friend WithEvents panelMyCoreListsCtrls As Panel
    Friend WithEvents lblEmptyPanelMyLists As Label
End Class
