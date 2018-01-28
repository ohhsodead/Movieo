<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ctrlPosterTitle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctrlPosterTitle))
        Me.showYear = New System.Windows.Forms.Label()
        Me.showTitle = New System.Windows.Forms.Label()
        Me.showQuality = New System.Windows.Forms.Label()
        Me.imgPoster = New CButtonLib.CButton()
        Me.imgPosterDefault = New CButtonLib.CButton()
        Me.showImdbRating = New CButtonLib.CButton()
        Me.imgEffect = New System.Windows.Forms.PictureBox()
        CType(Me.imgEffect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'showYear
        '
        Me.showYear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.showYear.AutoSize = True
        Me.showYear.BackColor = System.Drawing.Color.Transparent
        Me.showYear.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.showYear.ForeColor = System.Drawing.Color.DarkGray
        Me.showYear.Location = New System.Drawing.Point(7, 251)
        Me.showYear.Margin = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.showYear.Name = "showYear"
        Me.showYear.Size = New System.Drawing.Size(33, 17)
        Me.showYear.TabIndex = 23
        Me.showYear.Text = "Year"
        '
        'showTitle
        '
        Me.showTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.showTitle.AutoEllipsis = True
        Me.showTitle.BackColor = System.Drawing.Color.Transparent
        Me.showTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.showTitle.ForeColor = System.Drawing.Color.White
        Me.showTitle.Location = New System.Drawing.Point(6, 228)
        Me.showTitle.Margin = New System.Windows.Forms.Padding(3)
        Me.showTitle.Name = "showTitle"
        Me.showTitle.Size = New System.Drawing.Size(148, 25)
        Me.showTitle.TabIndex = 43
        Me.showTitle.Text = "Movie Title"
        Me.showTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'showQuality
        '
        Me.showQuality.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.showQuality.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.showQuality.ForeColor = System.Drawing.Color.DarkGray
        Me.showQuality.Location = New System.Drawing.Point(92, 251)
        Me.showQuality.Name = "showQuality"
        Me.showQuality.Size = New System.Drawing.Size(61, 18)
        Me.showQuality.TabIndex = 56
        Me.showQuality.Text = "Quality"
        Me.showQuality.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.showQuality.Visible = False
        '
        'imgPoster
        '
        Me.imgPoster.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgPoster.BackColor = System.Drawing.Color.Transparent
        Me.imgPoster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgPoster.BorderColor = System.Drawing.Color.White
        Me.imgPoster.BorderShow = False
        Me.imgPoster.ColorFillSolid = System.Drawing.Color.Transparent
        Me.imgPoster.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgPoster.DesignerSelected = False
        Me.imgPoster.DimFactorClick = 0
        Me.imgPoster.DimFactorHover = 0
        Me.imgPoster.FillType = CButtonLib.CButton.eFillType.Solid
        Me.imgPoster.ForeColor = System.Drawing.Color.DarkGray
        Me.imgPoster.ImageIndex = 0
        Me.imgPoster.Location = New System.Drawing.Point(7, 8)
        Me.imgPoster.Name = "imgPoster"
        Me.imgPoster.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.imgPoster.Size = New System.Drawing.Size(146, 214)
        Me.imgPoster.TabIndex = 38
        Me.imgPoster.TabStop = False
        Me.imgPoster.Text = ""
        '
        'imgPosterDefault
        '
        Me.imgPosterDefault.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgPosterDefault.BackColor = System.Drawing.Color.Transparent
        Me.imgPosterDefault.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgPosterDefault.BorderColor = System.Drawing.Color.White
        Me.imgPosterDefault.BorderShow = False
        Me.imgPosterDefault.ColorFillSolid = System.Drawing.Color.Transparent
        Me.imgPosterDefault.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgPosterDefault.DesignerSelected = True
        Me.imgPosterDefault.DimFactorClick = 0
        Me.imgPosterDefault.DimFactorHover = 0
        Me.imgPosterDefault.FillType = CButtonLib.CButton.eFillType.Solid
        Me.imgPosterDefault.ForeColor = System.Drawing.Color.DarkGray
        Me.imgPosterDefault.ImageIndex = 0
        Me.imgPosterDefault.Location = New System.Drawing.Point(8, 8)
        Me.imgPosterDefault.Name = "imgPosterDefault"
        Me.imgPosterDefault.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.imgPosterDefault.Size = New System.Drawing.Size(144, 212)
        Me.imgPosterDefault.TabIndex = 44
        Me.imgPosterDefault.TabStop = False
        Me.imgPosterDefault.Text = ""
        '
        'showImdbRating
        '
        Me.showImdbRating.BorderColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.showImdbRating.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.showImdbRating.Corners.All = 12
        Me.showImdbRating.Corners.LowerLeft = 12
        Me.showImdbRating.Corners.LowerRight = 12
        Me.showImdbRating.Corners.UpperLeft = 12
        Me.showImdbRating.Corners.UpperRight = 12
        Me.showImdbRating.DesignerSelected = False
        Me.showImdbRating.FillType = CButtonLib.CButton.eFillType.Solid
        Me.showImdbRating.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showImdbRating.ForeColor = System.Drawing.Color.Black
        Me.showImdbRating.ImageIndex = 0
        Me.showImdbRating.Location = New System.Drawing.Point(74, 13)
        Me.showImdbRating.Name = "showImdbRating"
        Me.showImdbRating.Size = New System.Drawing.Size(74, 26)
        Me.showImdbRating.TabIndex = 58
        Me.showImdbRating.Text = "IMDB 0.0"
        Me.showImdbRating.TextMargin = New System.Windows.Forms.Padding(2, 3, 2, 2)
        Me.showImdbRating.TextShadow = System.Drawing.Color.Gray
        Me.showImdbRating.TextShadowShow = False
        Me.showImdbRating.Visible = False
        '
        'imgEffect
        '
        Me.imgEffect.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgEffect.Image = Global.Movieo.My.Resources.Resources.PosterGlow
        Me.imgEffect.Location = New System.Drawing.Point(-2, -3)
        Me.imgEffect.Name = "imgEffect"
        Me.imgEffect.Size = New System.Drawing.Size(165, 233)
        Me.imgEffect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgEffect.TabIndex = 45
        Me.imgEffect.TabStop = False
        '
        'ctrlPosterTitle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(161, 278)
        Me.ControlBox = False
        Me.Controls.Add(Me.showImdbRating)
        Me.Controls.Add(Me.showQuality)
        Me.Controls.Add(Me.imgPoster)
        Me.Controls.Add(Me.showYear)
        Me.Controls.Add(Me.showTitle)
        Me.Controls.Add(Me.imgPosterDefault)
        Me.Controls.Add(Me.imgEffect)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ctrlPosterTitle"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "PosterTitle"
        CType(Me.imgEffect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents showYear As Label
    Public WithEvents imgPoster As CButtonLib.CButton
    Friend WithEvents showTitle As Label
    Public WithEvents imgPosterDefault As CButtonLib.CButton
    Friend WithEvents imgEffect As PictureBox
    Friend WithEvents showQuality As Label
    Friend WithEvents showImdbRating As CButtonLib.CButton
End Class
