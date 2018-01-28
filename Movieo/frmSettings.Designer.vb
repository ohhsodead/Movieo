<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.headerGeneral = New System.Windows.Forms.Label()
        Me.headerFeatures = New System.Windows.Forms.Label()
        Me.headerQuality = New System.Windows.Forms.Label()
        Me.headerDatabase = New System.Windows.Forms.Label()
        Me.Tab = New System.Windows.Forms.TabControl()
        Me.tabGeneral = New System.Windows.Forms.TabPage()
        Me.cmboBoxWatchedMoviesPanel = New System.Windows.Forms.Panel()
        Me.cmboTxtWatchedMovies = New CButtonLib.CButton()
        Me.cmboboxWatchedMovies = New System.Windows.Forms.ComboBox()
        Me.lblWatchedMovies = New System.Windows.Forms.Label()
        Me.chkShowRating = New System.Windows.Forms.CheckBox()
        Me.chkAlwaysOnTop = New System.Windows.Forms.CheckBox()
        Me.tabQuality = New System.Windows.Forms.TabPage()
        Me.chkShowMovieQuality = New System.Windows.Forms.CheckBox()
        Me.tabPlayback = New System.Windows.Forms.TabPage()
        Me.chckPlayFullscr = New System.Windows.Forms.CheckBox()
        Me.tabFeatures = New System.Windows.Forms.TabPage()
        Me.chckUserComments = New System.Windows.Forms.CheckBox()
        Me.chckDownloadBtn = New System.Windows.Forms.CheckBox()
        Me.tabDatabase = New System.Windows.Forms.TabPage()
        Me.btnDbExport = New CButtonLib.CButton()
        Me.chckBackupDb = New System.Windows.Forms.CheckBox()
        Me.txtDbDir = New System.Windows.Forms.TextBox()
        Me.txtDbDirBg = New CButtonLib.CButton()
        Me.imgOpenFolder = New System.Windows.Forms.PictureBox()
        Me.lblDbDir = New System.Windows.Forms.Label()
        Me.tabMiscellaneous = New System.Windows.Forms.TabPage()
        Me.chckAutoUpdate = New System.Windows.Forms.CheckBox()
        Me.panelTopHeaders = New System.Windows.Forms.Panel()
        Me.headerMiscellaneous = New System.Windows.Forms.Label()
        Me.headerPlayback = New System.Windows.Forms.Label()
        Me.meClose = New System.Windows.Forms.PictureBox()
        Me.Tab.SuspendLayout()
        Me.tabGeneral.SuspendLayout()
        Me.cmboBoxWatchedMoviesPanel.SuspendLayout()
        Me.tabQuality.SuspendLayout()
        Me.tabPlayback.SuspendLayout()
        Me.tabFeatures.SuspendLayout()
        Me.tabDatabase.SuspendLayout()
        CType(Me.imgOpenFolder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMiscellaneous.SuspendLayout()
        Me.panelTopHeaders.SuspendLayout()
        CType(Me.meClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'headerGeneral
        '
        Me.headerGeneral.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.headerGeneral.AutoSize = True
        Me.headerGeneral.Cursor = System.Windows.Forms.Cursors.Hand
        Me.headerGeneral.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.headerGeneral.Location = New System.Drawing.Point(88, 14)
        Me.headerGeneral.Name = "headerGeneral"
        Me.headerGeneral.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.headerGeneral.Size = New System.Drawing.Size(117, 30)
        Me.headerGeneral.TabIndex = 1051
        Me.headerGeneral.Text = "GENERAL"
        '
        'headerFeatures
        '
        Me.headerFeatures.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.headerFeatures.AutoSize = True
        Me.headerFeatures.Cursor = System.Windows.Forms.Cursors.Hand
        Me.headerFeatures.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerFeatures.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.headerFeatures.Location = New System.Drawing.Point(463, 14)
        Me.headerFeatures.Name = "headerFeatures"
        Me.headerFeatures.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.headerFeatures.Size = New System.Drawing.Size(123, 30)
        Me.headerFeatures.TabIndex = 1052
        Me.headerFeatures.Text = "FEATURES"
        '
        'headerQuality
        '
        Me.headerQuality.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.headerQuality.AutoSize = True
        Me.headerQuality.Cursor = System.Windows.Forms.Cursors.Hand
        Me.headerQuality.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerQuality.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.headerQuality.Location = New System.Drawing.Point(211, 14)
        Me.headerQuality.Name = "headerQuality"
        Me.headerQuality.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.headerQuality.Size = New System.Drawing.Size(112, 30)
        Me.headerQuality.TabIndex = 1053
        Me.headerQuality.Text = "QUALITY"
        '
        'headerDatabase
        '
        Me.headerDatabase.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.headerDatabase.AutoSize = True
        Me.headerDatabase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.headerDatabase.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerDatabase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.headerDatabase.Location = New System.Drawing.Point(592, 14)
        Me.headerDatabase.Name = "headerDatabase"
        Me.headerDatabase.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.headerDatabase.Size = New System.Drawing.Size(129, 30)
        Me.headerDatabase.TabIndex = 1054
        Me.headerDatabase.Text = "DATABASE"
        '
        'Tab
        '
        Me.Tab.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.Tab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab.Controls.Add(Me.tabGeneral)
        Me.Tab.Controls.Add(Me.tabQuality)
        Me.Tab.Controls.Add(Me.tabPlayback)
        Me.Tab.Controls.Add(Me.tabFeatures)
        Me.Tab.Controls.Add(Me.tabDatabase)
        Me.Tab.Controls.Add(Me.tabMiscellaneous)
        Me.Tab.Location = New System.Drawing.Point(-23, -4)
        Me.Tab.Multiline = True
        Me.Tab.Name = "Tab"
        Me.Tab.SelectedIndex = 0
        Me.Tab.Size = New System.Drawing.Size(1036, 569)
        Me.Tab.TabIndex = 1055
        '
        'tabGeneral
        '
        Me.tabGeneral.AutoScroll = True
        Me.tabGeneral.AutoScrollMargin = New System.Drawing.Size(20, 70)
        Me.tabGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.tabGeneral.Controls.Add(Me.cmboBoxWatchedMoviesPanel)
        Me.tabGeneral.Controls.Add(Me.cmboboxWatchedMovies)
        Me.tabGeneral.Controls.Add(Me.lblWatchedMovies)
        Me.tabGeneral.Controls.Add(Me.chkShowRating)
        Me.tabGeneral.Controls.Add(Me.chkAlwaysOnTop)
        Me.tabGeneral.Location = New System.Drawing.Point(23, 4)
        Me.tabGeneral.Name = "tabGeneral"
        Me.tabGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGeneral.Size = New System.Drawing.Size(1009, 561)
        Me.tabGeneral.TabIndex = 1
        Me.tabGeneral.Text = "GENERAL"
        '
        'cmboBoxWatchedMoviesPanel
        '
        Me.cmboBoxWatchedMoviesPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmboBoxWatchedMoviesPanel.BackColor = System.Drawing.Color.Transparent
        Me.cmboBoxWatchedMoviesPanel.Controls.Add(Me.cmboTxtWatchedMovies)
        Me.cmboBoxWatchedMoviesPanel.Location = New System.Drawing.Point(645, 216)
        Me.cmboBoxWatchedMoviesPanel.Name = "cmboBoxWatchedMoviesPanel"
        Me.cmboBoxWatchedMoviesPanel.Size = New System.Drawing.Size(135, 31)
        Me.cmboBoxWatchedMoviesPanel.TabIndex = 100000093
        '
        'cmboTxtWatchedMovies
        '
        Me.cmboTxtWatchedMovies.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmboTxtWatchedMovies.BackColor = System.Drawing.Color.Transparent
        Me.cmboTxtWatchedMovies.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.cmboTxtWatchedMovies.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.cmboTxtWatchedMovies.Corners.All = 2
        Me.cmboTxtWatchedMovies.Corners.LowerLeft = 2
        Me.cmboTxtWatchedMovies.Corners.LowerRight = 2
        Me.cmboTxtWatchedMovies.Corners.UpperLeft = 2
        Me.cmboTxtWatchedMovies.Corners.UpperRight = 2
        Me.cmboTxtWatchedMovies.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmboTxtWatchedMovies.DesignerSelected = False
        Me.cmboTxtWatchedMovies.DimFactorClick = 0
        Me.cmboTxtWatchedMovies.DimFactorHover = 0
        Me.cmboTxtWatchedMovies.FillType = CButtonLib.CButton.eFillType.Solid
        Me.cmboTxtWatchedMovies.FocalPoints.CenterPtX = 0!
        Me.cmboTxtWatchedMovies.FocalPoints.CenterPtY = 0!
        Me.cmboTxtWatchedMovies.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.cmboTxtWatchedMovies.ImageIndex = 0
        Me.cmboTxtWatchedMovies.Location = New System.Drawing.Point(0, 0)
        Me.cmboTxtWatchedMovies.Name = "cmboTxtWatchedMovies"
        Me.cmboTxtWatchedMovies.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.cmboTxtWatchedMovies.SideImage = CType(resources.GetObject("cmboTxtWatchedMovies.SideImage"), System.Drawing.Image)
        Me.cmboTxtWatchedMovies.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmboTxtWatchedMovies.SideImageSize = New System.Drawing.Size(18, 19)
        Me.cmboTxtWatchedMovies.Size = New System.Drawing.Size(134, 30)
        Me.cmboTxtWatchedMovies.TabIndex = 3
        Me.cmboTxtWatchedMovies.Text = "Fade"
        Me.cmboTxtWatchedMovies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmboTxtWatchedMovies.TextMargin = New System.Windows.Forms.Padding(4, 2, 2, 2)
        Me.cmboTxtWatchedMovies.TextShadow = System.Drawing.Color.White
        Me.cmboTxtWatchedMovies.TextShadowShow = False
        '
        'cmboboxWatchedMovies
        '
        Me.cmboboxWatchedMovies.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmboboxWatchedMovies.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmboboxWatchedMovies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboboxWatchedMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmboboxWatchedMovies.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.cmboboxWatchedMovies.ForeColor = System.Drawing.Color.White
        Me.cmboboxWatchedMovies.FormattingEnabled = True
        Me.cmboboxWatchedMovies.Items.AddRange(New Object() {"Fade", "Hide", "Show"})
        Me.cmboboxWatchedMovies.Location = New System.Drawing.Point(645, 220)
        Me.cmboboxWatchedMovies.Name = "cmboboxWatchedMovies"
        Me.cmboboxWatchedMovies.Size = New System.Drawing.Size(134, 27)
        Me.cmboboxWatchedMovies.TabIndex = 100000092
        Me.cmboboxWatchedMovies.TabStop = False
        Me.cmboboxWatchedMovies.Visible = False
        '
        'lblWatchedMovies
        '
        Me.lblWatchedMovies.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblWatchedMovies.AutoSize = True
        Me.lblWatchedMovies.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWatchedMovies.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblWatchedMovies.Location = New System.Drawing.Point(244, 220)
        Me.lblWatchedMovies.Name = "lblWatchedMovies"
        Me.lblWatchedMovies.Size = New System.Drawing.Size(124, 21)
        Me.lblWatchedMovies.TabIndex = 100000091
        Me.lblWatchedMovies.Text = "Watched movies"
        '
        'chkShowRating
        '
        Me.chkShowRating.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkShowRating.AutoSize = True
        Me.chkShowRating.Checked = True
        Me.chkShowRating.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowRating.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowRating.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.chkShowRating.Location = New System.Drawing.Point(248, 172)
        Me.chkShowRating.Name = "chkShowRating"
        Me.chkShowRating.Size = New System.Drawing.Size(190, 25)
        Me.chkShowRating.TabIndex = 100000095
        Me.chkShowRating.Text = "Show rating on posters"
        Me.chkShowRating.UseVisualStyleBackColor = True
        '
        'chkAlwaysOnTop
        '
        Me.chkAlwaysOnTop.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkAlwaysOnTop.AutoSize = True
        Me.chkAlwaysOnTop.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAlwaysOnTop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.chkAlwaysOnTop.Location = New System.Drawing.Point(248, 127)
        Me.chkAlwaysOnTop.Name = "chkAlwaysOnTop"
        Me.chkAlwaysOnTop.Size = New System.Drawing.Size(127, 25)
        Me.chkAlwaysOnTop.TabIndex = 100000094
        Me.chkAlwaysOnTop.Text = "Always on top"
        Me.chkAlwaysOnTop.UseVisualStyleBackColor = True
        '
        'tabQuality
        '
        Me.tabQuality.AutoScroll = True
        Me.tabQuality.AutoScrollMargin = New System.Drawing.Size(0, 70)
        Me.tabQuality.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.tabQuality.Controls.Add(Me.chkShowMovieQuality)
        Me.tabQuality.Location = New System.Drawing.Point(23, 4)
        Me.tabQuality.Name = "tabQuality"
        Me.tabQuality.Size = New System.Drawing.Size(1009, 561)
        Me.tabQuality.TabIndex = 4
        Me.tabQuality.Text = "QUALITY"
        '
        'chkShowMovieQuality
        '
        Me.chkShowMovieQuality.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkShowMovieQuality.AutoSize = True
        Me.chkShowMovieQuality.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowMovieQuality.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.chkShowMovieQuality.Location = New System.Drawing.Point(248, 127)
        Me.chkShowMovieQuality.Name = "chkShowMovieQuality"
        Me.chkShowMovieQuality.Size = New System.Drawing.Size(212, 25)
        Me.chkShowMovieQuality.TabIndex = 100000092
        Me.chkShowMovieQuality.Text = "Show movie quality on list"
        Me.chkShowMovieQuality.UseVisualStyleBackColor = True
        '
        'tabPlayback
        '
        Me.tabPlayback.AutoScroll = True
        Me.tabPlayback.AutoScrollMargin = New System.Drawing.Size(0, 70)
        Me.tabPlayback.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.tabPlayback.Controls.Add(Me.chckPlayFullscr)
        Me.tabPlayback.Location = New System.Drawing.Point(23, 4)
        Me.tabPlayback.Name = "tabPlayback"
        Me.tabPlayback.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPlayback.Size = New System.Drawing.Size(1009, 561)
        Me.tabPlayback.TabIndex = 0
        Me.tabPlayback.Text = "PLAYBACK"
        '
        'chckPlayFullscr
        '
        Me.chckPlayFullscr.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chckPlayFullscr.AutoSize = True
        Me.chckPlayFullscr.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckPlayFullscr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.chckPlayFullscr.Location = New System.Drawing.Point(248, 127)
        Me.chckPlayFullscr.Name = "chckPlayFullscr"
        Me.chckPlayFullscr.Size = New System.Drawing.Size(256, 25)
        Me.chckPlayFullscr.TabIndex = 100000063
        Me.chckPlayFullscr.Text = "Always start playing in fullscreen"
        Me.chckPlayFullscr.UseVisualStyleBackColor = True
        '
        'tabFeatures
        '
        Me.tabFeatures.AutoScroll = True
        Me.tabFeatures.AutoScrollMargin = New System.Drawing.Size(0, 70)
        Me.tabFeatures.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.tabFeatures.Controls.Add(Me.chckUserComments)
        Me.tabFeatures.Controls.Add(Me.chckDownloadBtn)
        Me.tabFeatures.Location = New System.Drawing.Point(23, 4)
        Me.tabFeatures.Name = "tabFeatures"
        Me.tabFeatures.Size = New System.Drawing.Size(1009, 561)
        Me.tabFeatures.TabIndex = 3
        Me.tabFeatures.Text = "FEATURES"
        '
        'chckUserComments
        '
        Me.chckUserComments.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chckUserComments.AutoSize = True
        Me.chckUserComments.Checked = True
        Me.chckUserComments.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chckUserComments.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckUserComments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.chckUserComments.Location = New System.Drawing.Point(248, 172)
        Me.chckUserComments.Name = "chckUserComments"
        Me.chckUserComments.Size = New System.Drawing.Size(179, 25)
        Me.chckUserComments.TabIndex = 100000066
        Me.chckUserComments.Text = "Show user comments"
        Me.chckUserComments.UseVisualStyleBackColor = True
        '
        'chckDownloadBtn
        '
        Me.chckDownloadBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chckDownloadBtn.AutoSize = True
        Me.chckDownloadBtn.Checked = True
        Me.chckDownloadBtn.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chckDownloadBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckDownloadBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.chckDownloadBtn.Location = New System.Drawing.Point(248, 127)
        Me.chckDownloadBtn.Name = "chckDownloadBtn"
        Me.chckDownloadBtn.Size = New System.Drawing.Size(228, 25)
        Me.chckDownloadBtn.TabIndex = 100000065
        Me.chckDownloadBtn.Text = "Download button for movies"
        Me.chckDownloadBtn.UseVisualStyleBackColor = True
        '
        'tabDatabase
        '
        Me.tabDatabase.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.tabDatabase.Controls.Add(Me.btnDbExport)
        Me.tabDatabase.Controls.Add(Me.chckBackupDb)
        Me.tabDatabase.Controls.Add(Me.txtDbDir)
        Me.tabDatabase.Controls.Add(Me.txtDbDirBg)
        Me.tabDatabase.Controls.Add(Me.imgOpenFolder)
        Me.tabDatabase.Controls.Add(Me.lblDbDir)
        Me.tabDatabase.Location = New System.Drawing.Point(23, 4)
        Me.tabDatabase.Name = "tabDatabase"
        Me.tabDatabase.Size = New System.Drawing.Size(1009, 561)
        Me.tabDatabase.TabIndex = 5
        Me.tabDatabase.Text = "DATABASE"
        '
        'btnDbExport
        '
        Me.btnDbExport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDbExport.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnDbExport.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnDbExport.Corners.All = 2
        Me.btnDbExport.Corners.LowerLeft = 2
        Me.btnDbExport.Corners.LowerRight = 2
        Me.btnDbExport.Corners.UpperLeft = 2
        Me.btnDbExport.Corners.UpperRight = 2
        Me.btnDbExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDbExport.DesignerSelected = False
        Me.btnDbExport.DimFactorClick = 0
        Me.btnDbExport.DimFactorHover = 0
        Me.btnDbExport.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnDbExport.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnDbExport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnDbExport.ImageIndex = 0
        Me.btnDbExport.Location = New System.Drawing.Point(248, 221)
        Me.btnDbExport.Name = "btnDbExport"
        Me.btnDbExport.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnDbExport.Size = New System.Drawing.Size(86, 32)
        Me.btnDbExport.TabIndex = 100000091
        Me.btnDbExport.Text = "Export..."
        Me.btnDbExport.TextShadowShow = False
        '
        'chckBackupDb
        '
        Me.chckBackupDb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chckBackupDb.AutoSize = True
        Me.chckBackupDb.Checked = True
        Me.chckBackupDb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chckBackupDb.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckBackupDb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.chckBackupDb.Location = New System.Drawing.Point(248, 127)
        Me.chckBackupDb.Name = "chckBackupDb"
        Me.chckBackupDb.Size = New System.Drawing.Size(194, 25)
        Me.chckBackupDb.TabIndex = 100000089
        Me.chckBackupDb.Text = "Create backup database"
        Me.chckBackupDb.UseVisualStyleBackColor = True
        '
        'txtDbDir
        '
        Me.txtDbDir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDbDir.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtDbDir.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDbDir.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.txtDbDir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtDbDir.Location = New System.Drawing.Point(414, 174)
        Me.txtDbDir.Name = "txtDbDir"
        Me.txtDbDir.ReadOnly = True
        Me.txtDbDir.Size = New System.Drawing.Size(315, 19)
        Me.txtDbDir.TabIndex = 100000090
        '
        'txtDbDirBg
        '
        Me.txtDbDirBg.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDbDirBg.BorderColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtDbDirBg.ColorFillSolid = System.Drawing.Color.Transparent
        Me.txtDbDirBg.Corners.All = 2
        Me.txtDbDirBg.Corners.LowerLeft = 2
        Me.txtDbDirBg.Corners.LowerRight = 2
        Me.txtDbDirBg.Corners.UpperLeft = 2
        Me.txtDbDirBg.Corners.UpperRight = 2
        Me.txtDbDirBg.DesignerSelected = False
        Me.txtDbDirBg.DimFactorClick = 0
        Me.txtDbDirBg.DimFactorHover = 0
        Me.txtDbDirBg.Enabled = False
        Me.txtDbDirBg.FillType = CButtonLib.CButton.eFillType.Solid
        Me.txtDbDirBg.ImageIndex = 0
        Me.txtDbDirBg.Location = New System.Drawing.Point(407, 171)
        Me.txtDbDirBg.Name = "txtDbDirBg"
        Me.txtDbDirBg.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.txtDbDirBg.Size = New System.Drawing.Size(329, 26)
        Me.txtDbDirBg.TabIndex = 100000093
        Me.txtDbDirBg.TabStop = False
        Me.txtDbDirBg.Text = ""
        '
        'imgOpenFolder
        '
        Me.imgOpenFolder.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.imgOpenFolder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgOpenFolder.Image = Global.Movieo.My.Resources.Resources.BrowseIconL
        Me.imgOpenFolder.Location = New System.Drawing.Point(745, 175)
        Me.imgOpenFolder.Name = "imgOpenFolder"
        Me.imgOpenFolder.Size = New System.Drawing.Size(20, 18)
        Me.imgOpenFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgOpenFolder.TabIndex = 100000094
        Me.imgOpenFolder.TabStop = False
        '
        'lblDbDir
        '
        Me.lblDbDir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDbDir.AutoSize = True
        Me.lblDbDir.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDbDir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblDbDir.Location = New System.Drawing.Point(244, 172)
        Me.lblDbDir.Name = "lblDbDir"
        Me.lblDbDir.Size = New System.Drawing.Size(142, 21)
        Me.lblDbDir.TabIndex = 100000092
        Me.lblDbDir.Text = "Database Directory"
        '
        'tabMiscellaneous
        '
        Me.tabMiscellaneous.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.tabMiscellaneous.Controls.Add(Me.chckAutoUpdate)
        Me.tabMiscellaneous.Location = New System.Drawing.Point(23, 4)
        Me.tabMiscellaneous.Name = "tabMiscellaneous"
        Me.tabMiscellaneous.Size = New System.Drawing.Size(1009, 561)
        Me.tabMiscellaneous.TabIndex = 6
        Me.tabMiscellaneous.Text = "MISCELLANEOUS"
        '
        'chckAutoUpdate
        '
        Me.chckAutoUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chckAutoUpdate.AutoSize = True
        Me.chckAutoUpdate.Checked = True
        Me.chckAutoUpdate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chckAutoUpdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckAutoUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.chckAutoUpdate.Location = New System.Drawing.Point(248, 127)
        Me.chckAutoUpdate.Name = "chckAutoUpdate"
        Me.chckAutoUpdate.Size = New System.Drawing.Size(229, 25)
        Me.chckAutoUpdate.TabIndex = 100000069
        Me.chckAutoUpdate.Text = "Check for updates on startup"
        Me.chckAutoUpdate.UseVisualStyleBackColor = True
        '
        'panelTopHeaders
        '
        Me.panelTopHeaders.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelTopHeaders.Controls.Add(Me.headerMiscellaneous)
        Me.panelTopHeaders.Controls.Add(Me.headerPlayback)
        Me.panelTopHeaders.Controls.Add(Me.meClose)
        Me.panelTopHeaders.Controls.Add(Me.headerGeneral)
        Me.panelTopHeaders.Controls.Add(Me.headerDatabase)
        Me.panelTopHeaders.Controls.Add(Me.headerFeatures)
        Me.panelTopHeaders.Controls.Add(Me.headerQuality)
        Me.panelTopHeaders.Location = New System.Drawing.Point(0, -1)
        Me.panelTopHeaders.Name = "panelTopHeaders"
        Me.panelTopHeaders.Size = New System.Drawing.Size(992, 60)
        Me.panelTopHeaders.TabIndex = 1056
        '
        'headerMiscellaneous
        '
        Me.headerMiscellaneous.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.headerMiscellaneous.AutoSize = True
        Me.headerMiscellaneous.Cursor = System.Windows.Forms.Cursors.Hand
        Me.headerMiscellaneous.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerMiscellaneous.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.headerMiscellaneous.Location = New System.Drawing.Point(727, 14)
        Me.headerMiscellaneous.Name = "headerMiscellaneous"
        Me.headerMiscellaneous.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.headerMiscellaneous.Size = New System.Drawing.Size(194, 30)
        Me.headerMiscellaneous.TabIndex = 1058
        Me.headerMiscellaneous.Text = "MISCELLANEOUS"
        '
        'headerPlayback
        '
        Me.headerPlayback.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.headerPlayback.AutoSize = True
        Me.headerPlayback.Cursor = System.Windows.Forms.Cursors.Hand
        Me.headerPlayback.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerPlayback.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.headerPlayback.Location = New System.Drawing.Point(329, 14)
        Me.headerPlayback.Name = "headerPlayback"
        Me.headerPlayback.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.headerPlayback.Size = New System.Drawing.Size(128, 30)
        Me.headerPlayback.TabIndex = 1056
        Me.headerPlayback.Text = "PLAYBACK"
        '
        'meClose
        '
        Me.meClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.meClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.meClose.Image = Global.Movieo.My.Resources.Resources.PopupCloseL
        Me.meClose.Location = New System.Drawing.Point(948, 16)
        Me.meClose.Name = "meClose"
        Me.meClose.Size = New System.Drawing.Size(28, 28)
        Me.meClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.meClose.TabIndex = 1055
        Me.meClose.TabStop = False
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1009, 561)
        Me.Controls.Add(Me.panelTopHeaders)
        Me.Controls.Add(Me.Tab)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSettings"
        Me.Opacity = 0.98R
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movieo Info"
        Me.Tab.ResumeLayout(False)
        Me.tabGeneral.ResumeLayout(False)
        Me.tabGeneral.PerformLayout()
        Me.cmboBoxWatchedMoviesPanel.ResumeLayout(False)
        Me.tabQuality.ResumeLayout(False)
        Me.tabQuality.PerformLayout()
        Me.tabPlayback.ResumeLayout(False)
        Me.tabPlayback.PerformLayout()
        Me.tabFeatures.ResumeLayout(False)
        Me.tabFeatures.PerformLayout()
        Me.tabDatabase.ResumeLayout(False)
        Me.tabDatabase.PerformLayout()
        CType(Me.imgOpenFolder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMiscellaneous.ResumeLayout(False)
        Me.tabMiscellaneous.PerformLayout()
        Me.panelTopHeaders.ResumeLayout(False)
        Me.panelTopHeaders.PerformLayout()
        CType(Me.meClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents headerGeneral As Label
    Friend WithEvents headerFeatures As Label
    Friend WithEvents headerQuality As Label
    Friend WithEvents headerDatabase As Label
    Friend WithEvents Tab As TabControl
    Friend WithEvents tabPlayback As TabPage
    Friend WithEvents tabGeneral As TabPage
    Friend WithEvents panelTopHeaders As Panel
    Friend WithEvents meClose As PictureBox
    Friend WithEvents tabFeatures As TabPage
    Friend WithEvents MsgEmail As ChreneLib.Controls.TextBoxes.CTextBox
    Friend WithEvents MsgText As ChreneLib.Controls.TextBoxes.CTextBox
    Friend WithEvents tabQuality As TabPage
    Friend WithEvents headerPlayback As Label
    Friend WithEvents tabDatabase As TabPage
    Friend WithEvents tabMiscellaneous As TabPage
    Friend WithEvents headerMiscellaneous As Label
    Friend WithEvents cmboBoxWatchedMoviesPanel As Panel
    Friend WithEvents cmboTxtWatchedMovies As CButtonLib.CButton
    Friend WithEvents cmboboxWatchedMovies As ComboBox
    Friend WithEvents lblWatchedMovies As Label
    Friend WithEvents chkShowRating As CheckBox
    Friend WithEvents chkAlwaysOnTop As CheckBox
    Friend WithEvents chkShowMovieQuality As CheckBox
    Friend WithEvents chckPlayFullscr As CheckBox
    Friend WithEvents chckUserComments As CheckBox
    Friend WithEvents chckDownloadBtn As CheckBox
    Friend WithEvents btnDbExport As CButtonLib.CButton
    Friend WithEvents chckBackupDb As CheckBox
    Friend WithEvents txtDbDir As TextBox
    Friend WithEvents txtDbDirBg As CButtonLib.CButton
    Friend WithEvents imgOpenFolder As PictureBox
    Friend WithEvents lblDbDir As Label
    Friend WithEvents chckAutoUpdate As CheckBox
End Class
