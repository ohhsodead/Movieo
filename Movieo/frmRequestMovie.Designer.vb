<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRequestMovie
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
        Me.Splitter1a = New System.Windows.Forms.Label()
        Me.lblHeaderRequestMovie = New System.Windows.Forms.Label()
        Me.timerHideNotifications = New System.Windows.Forms.Timer(Me.components)
        Me.MeClose = New System.Windows.Forms.PictureBox()
        Me.txtFormMovieTitle = New ChreneLib.Controls.TextBoxes.CTextBox()
        Me.btnFormSubmit = New CButtonLib.CButton()
        Me.lblSubContact = New System.Windows.Forms.Label()
        Me.txtFormEmailBG = New CButtonLib.CButton()
        Me.txtFormMoreInfo = New ChreneLib.Controls.TextBoxes.CTextBox()
        Me.CButton1 = New CButtonLib.CButton()
        Me.lblMessageSent = New CButtonLib.CButton()
        CType(Me.MeClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Splitter1a
        '
        Me.Splitter1a.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Splitter1a.AutoSize = True
        Me.Splitter1a.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Splitter1a.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Splitter1a.Location = New System.Drawing.Point(168, 152)
        Me.Splitter1a.MaximumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1a.MinimumSize = New System.Drawing.Size(750, 0)
        Me.Splitter1a.Name = "Splitter1a"
        Me.Splitter1a.Size = New System.Drawing.Size(750, 32)
        Me.Splitter1a.TabIndex = 100000000
        Me.Splitter1a.Text = "-------------------------------------------------------------------------"
        '
        'lblHeaderRequestMovie
        '
        Me.lblHeaderRequestMovie.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblHeaderRequestMovie.AutoSize = True
        Me.lblHeaderRequestMovie.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHeaderRequestMovie.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderRequestMovie.ForeColor = System.Drawing.Color.White
        Me.lblHeaderRequestMovie.Location = New System.Drawing.Point(425, 96)
        Me.lblHeaderRequestMovie.Name = "lblHeaderRequestMovie"
        Me.lblHeaderRequestMovie.Size = New System.Drawing.Size(242, 45)
        Me.lblHeaderRequestMovie.TabIndex = 100000000
        Me.lblHeaderRequestMovie.Text = "Request Movie"
        '
        'timerHideNotifications
        '
        Me.timerHideNotifications.Interval = 4000
        '
        'MeClose
        '
        Me.MeClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MeClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MeClose.Image = Global.Movieo.My.Resources.Resources.PopupCloseL
        Me.MeClose.Location = New System.Drawing.Point(1052, 12)
        Me.MeClose.Name = "MeClose"
        Me.MeClose.Size = New System.Drawing.Size(28, 28)
        Me.MeClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MeClose.TabIndex = 100000055
        Me.MeClose.TabStop = False
        '
        'txtFormMovieTitle
        '
        Me.txtFormMovieTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtFormMovieTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtFormMovieTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFormMovieTitle.Font = New System.Drawing.Font("Segoe UI", 12.5!)
        Me.txtFormMovieTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtFormMovieTitle.Location = New System.Drawing.Point(291, 301)
        Me.txtFormMovieTitle.MaxLength = 75
        Me.txtFormMovieTitle.Name = "txtFormMovieTitle"
        Me.txtFormMovieTitle.Size = New System.Drawing.Size(511, 23)
        Me.txtFormMovieTitle.TabIndex = 2
        Me.txtFormMovieTitle.WaterMark = "Movie Title & Year"
        Me.txtFormMovieTitle.WaterMarkActiveForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtFormMovieTitle.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.5!)
        Me.txtFormMovieTitle.WaterMarkForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        '
        'btnFormSubmit
        '
        Me.btnFormSubmit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnFormSubmit.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnFormSubmit.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnFormSubmit.Corners.All = 2
        Me.btnFormSubmit.Corners.LowerLeft = 2
        Me.btnFormSubmit.Corners.LowerRight = 2
        Me.btnFormSubmit.Corners.UpperLeft = 2
        Me.btnFormSubmit.Corners.UpperRight = 2
        Me.btnFormSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFormSubmit.DesignerSelected = False
        Me.btnFormSubmit.DimFactorClick = 0
        Me.btnFormSubmit.DimFactorHover = 0
        Me.btnFormSubmit.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnFormSubmit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.btnFormSubmit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnFormSubmit.ImageIndex = 0
        Me.btnFormSubmit.Location = New System.Drawing.Point(695, 387)
        Me.btnFormSubmit.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.btnFormSubmit.Name = "btnFormSubmit"
        Me.btnFormSubmit.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnFormSubmit.Size = New System.Drawing.Size(114, 37)
        Me.btnFormSubmit.TabIndex = 5
        Me.btnFormSubmit.Text = "Send Request"
        Me.btnFormSubmit.TextShadowShow = False
        '
        'lblSubContact
        '
        Me.lblSubContact.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSubContact.AutoSize = True
        Me.lblSubContact.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.lblSubContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblSubContact.Location = New System.Drawing.Point(181, 214)
        Me.lblSubContact.MaximumSize = New System.Drawing.Size(730, 0)
        Me.lblSubContact.MinimumSize = New System.Drawing.Size(730, 0)
        Me.lblSubContact.Name = "lblSubContact"
        Me.lblSubContact.Size = New System.Drawing.Size(730, 50)
        Me.lblSubContact.TabIndex = 1
        Me.lblSubContact.Text = "Search movies before sending the request. Please leave movie name and some additi" &
    "onal information to help us find the movie as quickly as possible."
        Me.lblSubContact.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtFormEmailBG
        '
        Me.txtFormEmailBG.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtFormEmailBG.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.txtFormEmailBG.ColorFillSolid = System.Drawing.Color.Transparent
        Me.txtFormEmailBG.Corners.All = 2
        Me.txtFormEmailBG.Corners.LowerLeft = 2
        Me.txtFormEmailBG.Corners.LowerRight = 2
        Me.txtFormEmailBG.Corners.UpperLeft = 2
        Me.txtFormEmailBG.Corners.UpperRight = 2
        Me.txtFormEmailBG.DesignerSelected = False
        Me.txtFormEmailBG.DimFactorClick = 0
        Me.txtFormEmailBG.DimFactorHover = 0
        Me.txtFormEmailBG.FillType = CButtonLib.CButton.eFillType.Solid
        Me.txtFormEmailBG.ImageIndex = 0
        Me.txtFormEmailBG.Location = New System.Drawing.Point(284, 295)
        Me.txtFormEmailBG.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.txtFormEmailBG.Name = "txtFormEmailBG"
        Me.txtFormEmailBG.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.txtFormEmailBG.Size = New System.Drawing.Size(525, 37)
        Me.txtFormEmailBG.TabIndex = 100000062
        Me.txtFormEmailBG.TabStop = False
        Me.txtFormEmailBG.Text = ""
        '
        'txtFormMoreInfo
        '
        Me.txtFormMoreInfo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtFormMoreInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtFormMoreInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFormMoreInfo.Font = New System.Drawing.Font("Segoe UI", 12.5!)
        Me.txtFormMoreInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtFormMoreInfo.Location = New System.Drawing.Point(291, 347)
        Me.txtFormMoreInfo.MaxLength = 75
        Me.txtFormMoreInfo.Name = "txtFormMoreInfo"
        Me.txtFormMoreInfo.Size = New System.Drawing.Size(511, 23)
        Me.txtFormMoreInfo.TabIndex = 3
        Me.txtFormMoreInfo.WaterMark = "Some More Info..."
        Me.txtFormMoreInfo.WaterMarkActiveForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtFormMoreInfo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.5!)
        Me.txtFormMoreInfo.WaterMarkForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        '
        'CButton1
        '
        Me.CButton1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CButton1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.CButton1.ColorFillSolid = System.Drawing.Color.Transparent
        Me.CButton1.Corners.All = 2
        Me.CButton1.Corners.LowerLeft = 2
        Me.CButton1.Corners.LowerRight = 2
        Me.CButton1.Corners.UpperLeft = 2
        Me.CButton1.Corners.UpperRight = 2
        Me.CButton1.DesignerSelected = False
        Me.CButton1.DimFactorClick = 0
        Me.CButton1.DimFactorHover = 0
        Me.CButton1.FillType = CButtonLib.CButton.eFillType.Solid
        Me.CButton1.ImageIndex = 0
        Me.CButton1.Location = New System.Drawing.Point(284, 341)
        Me.CButton1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.CButton1.Name = "CButton1"
        Me.CButton1.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.CButton1.Size = New System.Drawing.Size(525, 37)
        Me.CButton1.TabIndex = 100000064
        Me.CButton1.TabStop = False
        Me.CButton1.Text = ""
        '
        'lblMessageSent
        '
        Me.lblMessageSent.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMessageSent.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblMessageSent.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.lblMessageSent.Corners.All = 2
        Me.lblMessageSent.Corners.LowerLeft = 2
        Me.lblMessageSent.Corners.LowerRight = 2
        Me.lblMessageSent.Corners.UpperLeft = 2
        Me.lblMessageSent.Corners.UpperRight = 2
        Me.lblMessageSent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMessageSent.DesignerSelected = False
        Me.lblMessageSent.DimFactorClick = 0
        Me.lblMessageSent.DimFactorHover = 0
        Me.lblMessageSent.FillType = CButtonLib.CButton.eFillType.Solid
        Me.lblMessageSent.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!)
        Me.lblMessageSent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lblMessageSent.ImageIndex = 0
        Me.lblMessageSent.Location = New System.Drawing.Point(460, -2)
        Me.lblMessageSent.Name = "lblMessageSent"
        Me.lblMessageSent.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.lblMessageSent.Size = New System.Drawing.Size(172, 35)
        Me.lblMessageSent.TabIndex = 100000067
        Me.lblMessageSent.TabStop = False
        Me.lblMessageSent.Text = "Opening Mail Client..."
        Me.lblMessageSent.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblMessageSent.TextMargin = New System.Windows.Forms.Padding(2, 2, 2, 5)
        Me.lblMessageSent.TextShadowShow = False
        Me.lblMessageSent.Visible = False
        '
        'frmRequestMovie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(0, 70)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1092, 561)
        Me.Controls.Add(Me.lblMessageSent)
        Me.Controls.Add(Me.txtFormMoreInfo)
        Me.Controls.Add(Me.CButton1)
        Me.Controls.Add(Me.txtFormMovieTitle)
        Me.Controls.Add(Me.btnFormSubmit)
        Me.Controls.Add(Me.lblSubContact)
        Me.Controls.Add(Me.txtFormEmailBG)
        Me.Controls.Add(Me.MeClose)
        Me.Controls.Add(Me.Splitter1a)
        Me.Controls.Add(Me.lblHeaderRequestMovie)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRequestMovie"
        Me.Opacity = 0.98R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Request Movie"
        CType(Me.MeClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Splitter1a As Label
    Friend WithEvents lblHeaderRequestMovie As Label
    Friend WithEvents timerHideNotifications As Timer
    Friend WithEvents MeClose As PictureBox
    Friend WithEvents txtFormMovieTitle As ChreneLib.Controls.TextBoxes.CTextBox
    Friend WithEvents btnFormSubmit As CButtonLib.CButton
    Friend WithEvents lblSubContact As Label
    Friend WithEvents txtFormEmailBG As CButtonLib.CButton
    Friend WithEvents txtFormMoreInfo As ChreneLib.Controls.TextBoxes.CTextBox
    Friend WithEvents CButton1 As CButtonLib.CButton
    Friend WithEvents lblMessageSent As CButtonLib.CButton
End Class
