<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmImportExport
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
        Me.headerImport = New System.Windows.Forms.Label()
        Me.headerExport = New System.Windows.Forms.Label()
        Me.Tab = New System.Windows.Forms.TabControl()
        Me.tabImport = New System.Windows.Forms.TabPage()
        Me.btnStartImporting = New CButtonLib.CButton()
        Me.lblImportFile = New System.Windows.Forms.Label()
        Me.btnImportChooseFile = New System.Windows.Forms.Button()
        Me.cmboBoxPanelImportTo = New System.Windows.Forms.Panel()
        Me.cmboLblImportTo = New CButtonLib.CButton()
        Me.cmboboxImportTo = New System.Windows.Forms.ComboBox()
        Me.lblSubImportData = New System.Windows.Forms.Label()
        Me.lblImportTo = New System.Windows.Forms.Label()
        Me.lblHeaderImportData = New System.Windows.Forms.Label()
        Me.cmboBoxPanelImportFrom = New System.Windows.Forms.Panel()
        Me.cmboLblImportFrom = New CButtonLib.CButton()
        Me.cmboboxImportFrom = New System.Windows.Forms.ComboBox()
        Me.lblImportFrom = New System.Windows.Forms.Label()
        Me.tabExport = New System.Windows.Forms.TabPage()
        Me.btnStartExporting = New CButtonLib.CButton()
        Me.cmboBoxPanelExportFrom = New System.Windows.Forms.Panel()
        Me.cmboLblExportFrom = New CButtonLib.CButton()
        Me.cmboboxExportFrom = New System.Windows.Forms.ComboBox()
        Me.lblExportFrom = New System.Windows.Forms.Label()
        Me.lblSubExportData = New System.Windows.Forms.Label()
        Me.lblHeaderExportData = New System.Windows.Forms.Label()
        Me.panelTopHeaders = New System.Windows.Forms.Panel()
        Me.meClose = New System.Windows.Forms.PictureBox()
        Me.timerHideNotifications = New System.Windows.Forms.Timer(Me.components)
        Me.lblStatus = New CButtonLib.CButton()
        Me.Tab.SuspendLayout()
        Me.tabImport.SuspendLayout()
        Me.cmboBoxPanelImportTo.SuspendLayout()
        Me.cmboBoxPanelImportFrom.SuspendLayout()
        Me.tabExport.SuspendLayout()
        Me.cmboBoxPanelExportFrom.SuspendLayout()
        Me.panelTopHeaders.SuspendLayout()
        CType(Me.meClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'headerImport
        '
        Me.headerImport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.headerImport.AutoSize = True
        Me.headerImport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.headerImport.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerImport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.headerImport.Location = New System.Drawing.Point(397, 14)
        Me.headerImport.Name = "headerImport"
        Me.headerImport.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.headerImport.Size = New System.Drawing.Size(105, 30)
        Me.headerImport.TabIndex = 1051
        Me.headerImport.Text = "IMPORT"
        '
        'headerExport
        '
        Me.headerExport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.headerExport.AutoSize = True
        Me.headerExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.headerExport.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerExport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.headerExport.Location = New System.Drawing.Point(508, 14)
        Me.headerExport.Name = "headerExport"
        Me.headerExport.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.headerExport.Size = New System.Drawing.Size(103, 30)
        Me.headerExport.TabIndex = 1053
        Me.headerExport.Text = "EXPORT"
        '
        'Tab
        '
        Me.Tab.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.Tab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab.Controls.Add(Me.tabImport)
        Me.Tab.Controls.Add(Me.tabExport)
        Me.Tab.Location = New System.Drawing.Point(-23, -4)
        Me.Tab.Multiline = True
        Me.Tab.Name = "Tab"
        Me.Tab.SelectedIndex = 0
        Me.Tab.Size = New System.Drawing.Size(1036, 614)
        Me.Tab.TabIndex = 1055
        '
        'tabImport
        '
        Me.tabImport.AutoScroll = True
        Me.tabImport.AutoScrollMargin = New System.Drawing.Size(20, 70)
        Me.tabImport.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.tabImport.Controls.Add(Me.btnStartImporting)
        Me.tabImport.Controls.Add(Me.lblImportFile)
        Me.tabImport.Controls.Add(Me.btnImportChooseFile)
        Me.tabImport.Controls.Add(Me.cmboBoxPanelImportTo)
        Me.tabImport.Controls.Add(Me.cmboboxImportTo)
        Me.tabImport.Controls.Add(Me.lblSubImportData)
        Me.tabImport.Controls.Add(Me.lblImportTo)
        Me.tabImport.Controls.Add(Me.lblHeaderImportData)
        Me.tabImport.Controls.Add(Me.cmboBoxPanelImportFrom)
        Me.tabImport.Controls.Add(Me.cmboboxImportFrom)
        Me.tabImport.Controls.Add(Me.lblImportFrom)
        Me.tabImport.Location = New System.Drawing.Point(23, 4)
        Me.tabImport.Name = "tabImport"
        Me.tabImport.Padding = New System.Windows.Forms.Padding(3)
        Me.tabImport.Size = New System.Drawing.Size(1009, 606)
        Me.tabImport.TabIndex = 1
        Me.tabImport.Text = "IMPORT"
        '
        'btnStartImporting
        '
        Me.btnStartImporting.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnStartImporting.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnStartImporting.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnStartImporting.Corners.All = 2
        Me.btnStartImporting.Corners.LowerLeft = 2
        Me.btnStartImporting.Corners.LowerRight = 2
        Me.btnStartImporting.Corners.UpperLeft = 2
        Me.btnStartImporting.Corners.UpperRight = 2
        Me.btnStartImporting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStartImporting.DesignerSelected = False
        Me.btnStartImporting.DimFactorClick = 0
        Me.btnStartImporting.DimFactorHover = 0
        Me.btnStartImporting.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnStartImporting.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.btnStartImporting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnStartImporting.ImageIndex = 0
        Me.btnStartImporting.Location = New System.Drawing.Point(406, 483)
        Me.btnStartImporting.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.btnStartImporting.Name = "btnStartImporting"
        Me.btnStartImporting.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnStartImporting.Size = New System.Drawing.Size(197, 37)
        Me.btnStartImporting.TabIndex = 6
        Me.btnStartImporting.TabStop = False
        Me.btnStartImporting.Text = "START IMPORTING"
        Me.btnStartImporting.TextShadowShow = False
        '
        'lblImportFile
        '
        Me.lblImportFile.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblImportFile.AutoSize = True
        Me.lblImportFile.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.lblImportFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblImportFile.Location = New System.Drawing.Point(480, 439)
        Me.lblImportFile.Name = "lblImportFile"
        Me.lblImportFile.Size = New System.Drawing.Size(94, 17)
        Me.lblImportFile.TabIndex = 99999
        Me.lblImportFile.Text = "No file chosen"
        '
        'btnImportChooseFile
        '
        Me.btnImportChooseFile.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnImportChooseFile.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnImportChooseFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.btnImportChooseFile.Location = New System.Drawing.Point(406, 438)
        Me.btnImportChooseFile.Name = "btnImportChooseFile"
        Me.btnImportChooseFile.Size = New System.Drawing.Size(72, 21)
        Me.btnImportChooseFile.TabIndex = 5
        Me.btnImportChooseFile.TabStop = False
        Me.btnImportChooseFile.Text = "Choose file"
        Me.btnImportChooseFile.UseVisualStyleBackColor = True
        '
        'cmboBoxPanelImportTo
        '
        Me.cmboBoxPanelImportTo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmboBoxPanelImportTo.BackColor = System.Drawing.Color.Transparent
        Me.cmboBoxPanelImportTo.Controls.Add(Me.cmboLblImportTo)
        Me.cmboBoxPanelImportTo.Location = New System.Drawing.Point(406, 385)
        Me.cmboBoxPanelImportTo.Name = "cmboBoxPanelImportTo"
        Me.cmboBoxPanelImportTo.Size = New System.Drawing.Size(197, 31)
        Me.cmboBoxPanelImportTo.TabIndex = 100000096
        '
        'cmboLblImportTo
        '
        Me.cmboLblImportTo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmboLblImportTo.BackColor = System.Drawing.Color.Transparent
        Me.cmboLblImportTo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.cmboLblImportTo.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.cmboLblImportTo.Corners.All = 2
        Me.cmboLblImportTo.Corners.LowerLeft = 2
        Me.cmboLblImportTo.Corners.LowerRight = 2
        Me.cmboLblImportTo.Corners.UpperLeft = 2
        Me.cmboLblImportTo.Corners.UpperRight = 2
        Me.cmboLblImportTo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmboLblImportTo.DesignerSelected = False
        Me.cmboLblImportTo.DimFactorClick = 0
        Me.cmboLblImportTo.DimFactorHover = 0
        Me.cmboLblImportTo.FillType = CButtonLib.CButton.eFillType.Solid
        Me.cmboLblImportTo.FocalPoints.CenterPtX = 0!
        Me.cmboLblImportTo.FocalPoints.CenterPtY = 0!
        Me.cmboLblImportTo.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.cmboLblImportTo.ImageIndex = 0
        Me.cmboLblImportTo.Location = New System.Drawing.Point(0, 0)
        Me.cmboLblImportTo.Name = "cmboLblImportTo"
        Me.cmboLblImportTo.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.cmboLblImportTo.SideImage = Global.Movieo.My.Resources.Resources.ArrowDownH
        Me.cmboLblImportTo.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmboLblImportTo.SideImageSize = New System.Drawing.Size(18, 19)
        Me.cmboLblImportTo.Size = New System.Drawing.Size(197, 30)
        Me.cmboLblImportTo.TabIndex = 4
        Me.cmboLblImportTo.Text = "Watch List"
        Me.cmboLblImportTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmboLblImportTo.TextMargin = New System.Windows.Forms.Padding(4, 2, 2, 2)
        Me.cmboLblImportTo.TextShadow = System.Drawing.Color.White
        Me.cmboLblImportTo.TextShadowShow = False
        '
        'cmboboxImportTo
        '
        Me.cmboboxImportTo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmboboxImportTo.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmboboxImportTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboboxImportTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmboboxImportTo.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.cmboboxImportTo.ForeColor = System.Drawing.Color.White
        Me.cmboboxImportTo.FormattingEnabled = True
        Me.cmboboxImportTo.Items.AddRange(New Object() {"Watch List", "Seen List", "Black List"})
        Me.cmboboxImportTo.Location = New System.Drawing.Point(406, 389)
        Me.cmboboxImportTo.Name = "cmboboxImportTo"
        Me.cmboboxImportTo.Size = New System.Drawing.Size(197, 27)
        Me.cmboboxImportTo.TabIndex = 100000095
        Me.cmboboxImportTo.TabStop = False
        Me.cmboboxImportTo.Visible = False
        '
        'lblSubImportData
        '
        Me.lblSubImportData.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSubImportData.AutoSize = True
        Me.lblSubImportData.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.lblSubImportData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblSubImportData.Location = New System.Drawing.Point(139, 179)
        Me.lblSubImportData.MaximumSize = New System.Drawing.Size(730, 0)
        Me.lblSubImportData.MinimumSize = New System.Drawing.Size(730, 0)
        Me.lblSubImportData.Name = "lblSubImportData"
        Me.lblSubImportData.Size = New System.Drawing.Size(730, 46)
        Me.lblSubImportData.TabIndex = 99999
        Me.lblSubImportData.Text = "Import movies from other services" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "into any of your lists."
        Me.lblSubImportData.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblImportTo
        '
        Me.lblImportTo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblImportTo.AutoSize = True
        Me.lblImportTo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.lblImportTo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblImportTo.Location = New System.Drawing.Point(445, 348)
        Me.lblImportTo.Name = "lblImportTo"
        Me.lblImportTo.Size = New System.Drawing.Size(118, 21)
        Me.lblImportTo.TabIndex = 99999
        Me.lblImportTo.Text = "AND PUT INTO"
        '
        'lblHeaderImportData
        '
        Me.lblHeaderImportData.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblHeaderImportData.AutoSize = True
        Me.lblHeaderImportData.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHeaderImportData.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderImportData.ForeColor = System.Drawing.Color.White
        Me.lblHeaderImportData.Location = New System.Drawing.Point(402, 126)
        Me.lblHeaderImportData.Name = "lblHeaderImportData"
        Me.lblHeaderImportData.Size = New System.Drawing.Size(204, 45)
        Me.lblHeaderImportData.TabIndex = 99999
        Me.lblHeaderImportData.Text = "Import Data"
        '
        'cmboBoxPanelImportFrom
        '
        Me.cmboBoxPanelImportFrom.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmboBoxPanelImportFrom.BackColor = System.Drawing.Color.Transparent
        Me.cmboBoxPanelImportFrom.Controls.Add(Me.cmboLblImportFrom)
        Me.cmboBoxPanelImportFrom.Location = New System.Drawing.Point(406, 297)
        Me.cmboBoxPanelImportFrom.Name = "cmboBoxPanelImportFrom"
        Me.cmboBoxPanelImportFrom.Size = New System.Drawing.Size(197, 31)
        Me.cmboBoxPanelImportFrom.TabIndex = 100000093
        '
        'cmboLblImportFrom
        '
        Me.cmboLblImportFrom.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmboLblImportFrom.BackColor = System.Drawing.Color.Transparent
        Me.cmboLblImportFrom.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.cmboLblImportFrom.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.cmboLblImportFrom.Corners.All = 2
        Me.cmboLblImportFrom.Corners.LowerLeft = 2
        Me.cmboLblImportFrom.Corners.LowerRight = 2
        Me.cmboLblImportFrom.Corners.UpperLeft = 2
        Me.cmboLblImportFrom.Corners.UpperRight = 2
        Me.cmboLblImportFrom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmboLblImportFrom.DesignerSelected = False
        Me.cmboLblImportFrom.DimFactorClick = 0
        Me.cmboLblImportFrom.DimFactorHover = 0
        Me.cmboLblImportFrom.FillType = CButtonLib.CButton.eFillType.Solid
        Me.cmboLblImportFrom.FocalPoints.CenterPtX = 0!
        Me.cmboLblImportFrom.FocalPoints.CenterPtY = 0!
        Me.cmboLblImportFrom.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.cmboLblImportFrom.ImageIndex = 0
        Me.cmboLblImportFrom.Location = New System.Drawing.Point(0, 0)
        Me.cmboLblImportFrom.Name = "cmboLblImportFrom"
        Me.cmboLblImportFrom.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.cmboLblImportFrom.SideImage = Global.Movieo.My.Resources.Resources.ArrowDownH
        Me.cmboLblImportFrom.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmboLblImportFrom.SideImageSize = New System.Drawing.Size(18, 19)
        Me.cmboLblImportFrom.Size = New System.Drawing.Size(197, 30)
        Me.cmboLblImportFrom.TabIndex = 3
        Me.cmboLblImportFrom.Text = "IMDb"
        Me.cmboLblImportFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmboLblImportFrom.TextMargin = New System.Windows.Forms.Padding(4, 2, 2, 2)
        Me.cmboLblImportFrom.TextShadow = System.Drawing.Color.White
        Me.cmboLblImportFrom.TextShadowShow = False
        '
        'cmboboxImportFrom
        '
        Me.cmboboxImportFrom.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmboboxImportFrom.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmboboxImportFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboboxImportFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmboboxImportFrom.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.cmboboxImportFrom.ForeColor = System.Drawing.Color.White
        Me.cmboboxImportFrom.FormattingEnabled = True
        Me.cmboboxImportFrom.Items.AddRange(New Object() {"IMDb"})
        Me.cmboboxImportFrom.Location = New System.Drawing.Point(406, 301)
        Me.cmboboxImportFrom.Name = "cmboboxImportFrom"
        Me.cmboboxImportFrom.Size = New System.Drawing.Size(197, 27)
        Me.cmboboxImportFrom.TabIndex = 100000092
        Me.cmboboxImportFrom.TabStop = False
        Me.cmboboxImportFrom.Visible = False
        '
        'lblImportFrom
        '
        Me.lblImportFrom.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblImportFrom.AutoSize = True
        Me.lblImportFrom.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.lblImportFrom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblImportFrom.Location = New System.Drawing.Point(445, 260)
        Me.lblImportFrom.Name = "lblImportFrom"
        Me.lblImportFrom.Size = New System.Drawing.Size(119, 21)
        Me.lblImportFrom.TabIndex = 99999
        Me.lblImportFrom.Text = "IMPORT FROM"
        '
        'tabExport
        '
        Me.tabExport.AutoScroll = True
        Me.tabExport.AutoScrollMargin = New System.Drawing.Size(0, 70)
        Me.tabExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.tabExport.Controls.Add(Me.btnStartExporting)
        Me.tabExport.Controls.Add(Me.cmboBoxPanelExportFrom)
        Me.tabExport.Controls.Add(Me.cmboboxExportFrom)
        Me.tabExport.Controls.Add(Me.lblExportFrom)
        Me.tabExport.Controls.Add(Me.lblSubExportData)
        Me.tabExport.Controls.Add(Me.lblHeaderExportData)
        Me.tabExport.Location = New System.Drawing.Point(23, 4)
        Me.tabExport.Name = "tabExport"
        Me.tabExport.Size = New System.Drawing.Size(1009, 606)
        Me.tabExport.TabIndex = 4
        Me.tabExport.Text = "EXPORT"
        '
        'btnStartExporting
        '
        Me.btnStartExporting.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnStartExporting.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnStartExporting.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnStartExporting.Corners.All = 2
        Me.btnStartExporting.Corners.LowerLeft = 2
        Me.btnStartExporting.Corners.LowerRight = 2
        Me.btnStartExporting.Corners.UpperLeft = 2
        Me.btnStartExporting.Corners.UpperRight = 2
        Me.btnStartExporting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStartExporting.DesignerSelected = False
        Me.btnStartExporting.DimFactorClick = 0
        Me.btnStartExporting.DimFactorHover = 0
        Me.btnStartExporting.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnStartExporting.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.btnStartExporting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnStartExporting.ImageIndex = 0
        Me.btnStartExporting.Location = New System.Drawing.Point(406, 325)
        Me.btnStartExporting.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.btnStartExporting.Name = "btnStartExporting"
        Me.btnStartExporting.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnStartExporting.Size = New System.Drawing.Size(197, 37)
        Me.btnStartExporting.TabIndex = 2
        Me.btnStartExporting.TabStop = False
        Me.btnStartExporting.Text = "START EXPORTING"
        Me.btnStartExporting.TextShadowShow = False
        '
        'cmboBoxPanelExportFrom
        '
        Me.cmboBoxPanelExportFrom.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmboBoxPanelExportFrom.BackColor = System.Drawing.Color.Transparent
        Me.cmboBoxPanelExportFrom.Controls.Add(Me.cmboLblExportFrom)
        Me.cmboBoxPanelExportFrom.Location = New System.Drawing.Point(406, 270)
        Me.cmboBoxPanelExportFrom.Name = "cmboBoxPanelExportFrom"
        Me.cmboBoxPanelExportFrom.Size = New System.Drawing.Size(197, 31)
        Me.cmboBoxPanelExportFrom.TabIndex = 100000102
        '
        'cmboLblExportFrom
        '
        Me.cmboLblExportFrom.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmboLblExportFrom.BackColor = System.Drawing.Color.Transparent
        Me.cmboLblExportFrom.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.cmboLblExportFrom.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.cmboLblExportFrom.Corners.All = 2
        Me.cmboLblExportFrom.Corners.LowerLeft = 2
        Me.cmboLblExportFrom.Corners.LowerRight = 2
        Me.cmboLblExportFrom.Corners.UpperLeft = 2
        Me.cmboLblExportFrom.Corners.UpperRight = 2
        Me.cmboLblExportFrom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmboLblExportFrom.DesignerSelected = False
        Me.cmboLblExportFrom.DimFactorClick = 0
        Me.cmboLblExportFrom.DimFactorHover = 0
        Me.cmboLblExportFrom.FillType = CButtonLib.CButton.eFillType.Solid
        Me.cmboLblExportFrom.FocalPoints.CenterPtX = 0!
        Me.cmboLblExportFrom.FocalPoints.CenterPtY = 0!
        Me.cmboLblExportFrom.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.cmboLblExportFrom.ImageIndex = 0
        Me.cmboLblExportFrom.Location = New System.Drawing.Point(0, 0)
        Me.cmboLblExportFrom.Name = "cmboLblExportFrom"
        Me.cmboLblExportFrom.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.cmboLblExportFrom.SideImage = Global.Movieo.My.Resources.Resources.ArrowDownH
        Me.cmboLblExportFrom.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmboLblExportFrom.SideImageSize = New System.Drawing.Size(18, 19)
        Me.cmboLblExportFrom.Size = New System.Drawing.Size(197, 30)
        Me.cmboLblExportFrom.TabIndex = 0
        Me.cmboLblExportFrom.Text = "Watch List"
        Me.cmboLblExportFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmboLblExportFrom.TextMargin = New System.Windows.Forms.Padding(4, 2, 2, 2)
        Me.cmboLblExportFrom.TextShadow = System.Drawing.Color.White
        Me.cmboLblExportFrom.TextShadowShow = False
        '
        'cmboboxExportFrom
        '
        Me.cmboboxExportFrom.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmboboxExportFrom.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmboboxExportFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboboxExportFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmboboxExportFrom.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.cmboboxExportFrom.ForeColor = System.Drawing.Color.White
        Me.cmboboxExportFrom.FormattingEnabled = True
        Me.cmboboxExportFrom.Items.AddRange(New Object() {"Watch List", "Seen List", "Black List"})
        Me.cmboboxExportFrom.Location = New System.Drawing.Point(406, 274)
        Me.cmboboxExportFrom.Name = "cmboboxExportFrom"
        Me.cmboboxExportFrom.Size = New System.Drawing.Size(196, 27)
        Me.cmboboxExportFrom.TabIndex = 100000101
        Me.cmboboxExportFrom.TabStop = False
        Me.cmboboxExportFrom.Visible = False
        '
        'lblExportFrom
        '
        Me.lblExportFrom.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblExportFrom.AutoSize = True
        Me.lblExportFrom.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.lblExportFrom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblExportFrom.Location = New System.Drawing.Point(445, 233)
        Me.lblExportFrom.Name = "lblExportFrom"
        Me.lblExportFrom.Size = New System.Drawing.Size(117, 21)
        Me.lblExportFrom.TabIndex = 99999
        Me.lblExportFrom.Text = "EXPORT FROM"
        '
        'lblSubExportData
        '
        Me.lblSubExportData.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSubExportData.AutoSize = True
        Me.lblSubExportData.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.lblSubExportData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblSubExportData.Location = New System.Drawing.Point(139, 179)
        Me.lblSubExportData.MaximumSize = New System.Drawing.Size(730, 0)
        Me.lblSubExportData.MinimumSize = New System.Drawing.Size(730, 0)
        Me.lblSubExportData.Name = "lblSubExportData"
        Me.lblSubExportData.Size = New System.Drawing.Size(730, 23)
        Me.lblSubExportData.TabIndex = 99999
        Me.lblSubExportData.Text = "Export any list into a CSV file."
        Me.lblSubExportData.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblHeaderExportData
        '
        Me.lblHeaderExportData.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblHeaderExportData.AutoSize = True
        Me.lblHeaderExportData.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHeaderExportData.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderExportData.ForeColor = System.Drawing.Color.White
        Me.lblHeaderExportData.Location = New System.Drawing.Point(404, 126)
        Me.lblHeaderExportData.Name = "lblHeaderExportData"
        Me.lblHeaderExportData.Size = New System.Drawing.Size(200, 45)
        Me.lblHeaderExportData.TabIndex = 99999
        Me.lblHeaderExportData.Text = "Export Data"
        '
        'panelTopHeaders
        '
        Me.panelTopHeaders.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelTopHeaders.Controls.Add(Me.meClose)
        Me.panelTopHeaders.Controls.Add(Me.headerImport)
        Me.panelTopHeaders.Controls.Add(Me.headerExport)
        Me.panelTopHeaders.Location = New System.Drawing.Point(0, -1)
        Me.panelTopHeaders.Name = "panelTopHeaders"
        Me.panelTopHeaders.Size = New System.Drawing.Size(992, 60)
        Me.panelTopHeaders.TabIndex = 1056
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
        'timerHideNotifications
        '
        Me.timerHideNotifications.Interval = 4000
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblStatus.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblStatus.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.lblStatus.Corners.All = 2
        Me.lblStatus.Corners.LowerLeft = 2
        Me.lblStatus.Corners.LowerRight = 2
        Me.lblStatus.Corners.UpperLeft = 2
        Me.lblStatus.Corners.UpperRight = 2
        Me.lblStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblStatus.DesignerSelected = False
        Me.lblStatus.DimFactorClick = 0
        Me.lblStatus.DimFactorHover = 0
        Me.lblStatus.FillType = CButtonLib.CButton.eFillType.Solid
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lblStatus.ImageIndex = 0
        Me.lblStatus.Location = New System.Drawing.Point(426, 56)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.lblStatus.Size = New System.Drawing.Size(157, 35)
        Me.lblStatus.TabIndex = 100001
        Me.lblStatus.TabStop = False
        Me.lblStatus.Text = "Importing Data..."
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblStatus.TextMargin = New System.Windows.Forms.Padding(2, 2, 2, 5)
        Me.lblStatus.TextShadowShow = False
        Me.lblStatus.Visible = False
        '
        'frmImportExport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1009, 606)
        Me.Controls.Add(Me.panelTopHeaders)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Tab)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmImportExport"
        Me.Opacity = 0.98R
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movieo Info"
        Me.Tab.ResumeLayout(False)
        Me.tabImport.ResumeLayout(False)
        Me.tabImport.PerformLayout()
        Me.cmboBoxPanelImportTo.ResumeLayout(False)
        Me.cmboBoxPanelImportFrom.ResumeLayout(False)
        Me.tabExport.ResumeLayout(False)
        Me.tabExport.PerformLayout()
        Me.cmboBoxPanelExportFrom.ResumeLayout(False)
        Me.panelTopHeaders.ResumeLayout(False)
        Me.panelTopHeaders.PerformLayout()
        CType(Me.meClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents headerImport As Label
    Friend WithEvents headerExport As Label
    Friend WithEvents Tab As TabControl
    Friend WithEvents tabImport As TabPage
    Friend WithEvents panelTopHeaders As Panel
    Friend WithEvents meClose As PictureBox
    Friend WithEvents MsgEmail As ChreneLib.Controls.TextBoxes.CTextBox
    Friend WithEvents MsgText As ChreneLib.Controls.TextBoxes.CTextBox
    Friend WithEvents tabExport As TabPage
    Friend WithEvents cmboBoxPanelImportFrom As Panel
    Friend WithEvents cmboLblImportFrom As CButtonLib.CButton
    Friend WithEvents cmboboxImportFrom As ComboBox
    Friend WithEvents lblImportFrom As Label
    Friend WithEvents lblHeaderImportData As Label
    Friend WithEvents lblSubImportData As Label
    Friend WithEvents cmboBoxPanelImportTo As Panel
    Friend WithEvents cmboLblImportTo As CButtonLib.CButton
    Friend WithEvents cmboboxImportTo As ComboBox
    Friend WithEvents lblImportTo As Label
    Friend WithEvents lblImportFile As Label
    Friend WithEvents btnImportChooseFile As Button
    Friend WithEvents btnStartImporting As CButtonLib.CButton
    Friend WithEvents btnStartExporting As CButtonLib.CButton
    Friend WithEvents cmboBoxPanelExportFrom As Panel
    Friend WithEvents cmboLblExportFrom As CButtonLib.CButton
    Friend WithEvents cmboboxExportFrom As ComboBox
    Friend WithEvents lblExportFrom As Label
    Friend WithEvents lblSubExportData As Label
    Friend WithEvents lblHeaderExportData As Label
    Friend WithEvents timerHideNotifications As Timer
    Friend WithEvents lblStatus As CButtonLib.CButton
End Class
