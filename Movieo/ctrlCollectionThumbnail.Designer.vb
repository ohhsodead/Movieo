<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ctrlCollectionThumbnail
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
        Me.lblCollectionTitle = New System.Windows.Forms.Label()
        Me.imgCollectionThumbnail = New CButtonLib.CButton()
        Me.imgCollectionThumbnailDefault = New CButtonLib.CButton()
        Me.imageBackgroundEffect = New System.Windows.Forms.PictureBox()
        Me.lblCollectionDescription = New System.Windows.Forms.Label()
        Me.itemsCollectionMovies = New System.Windows.Forms.ListBox()
        CType(Me.imageBackgroundEffect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCollectionTitle
        '
        Me.lblCollectionTitle.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblCollectionTitle.AutoEllipsis = True
        Me.lblCollectionTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblCollectionTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.lblCollectionTitle.ForeColor = System.Drawing.Color.White
        Me.lblCollectionTitle.Location = New System.Drawing.Point(10, 190)
        Me.lblCollectionTitle.Margin = New System.Windows.Forms.Padding(3)
        Me.lblCollectionTitle.Name = "lblCollectionTitle"
        Me.lblCollectionTitle.Size = New System.Drawing.Size(315, 25)
        Me.lblCollectionTitle.TabIndex = 43
        Me.lblCollectionTitle.Text = "Collection Title"
        Me.lblCollectionTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'imgCollectionThumbnail
        '
        Me.imgCollectionThumbnail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgCollectionThumbnail.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.imgCollectionThumbnail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgCollectionThumbnail.BorderColor = System.Drawing.Color.White
        Me.imgCollectionThumbnail.BorderShow = False
        Me.imgCollectionThumbnail.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.imgCollectionThumbnail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgCollectionThumbnail.DesignerSelected = False
        Me.imgCollectionThumbnail.DimFactorClick = 0
        Me.imgCollectionThumbnail.DimFactorHover = 0
        Me.imgCollectionThumbnail.FillType = CButtonLib.CButton.eFillType.Solid
        Me.imgCollectionThumbnail.ForeColor = System.Drawing.Color.DarkGray
        Me.imgCollectionThumbnail.ImageIndex = 0
        Me.imgCollectionThumbnail.Location = New System.Drawing.Point(7, 10)
        Me.imgCollectionThumbnail.Name = "imgCollectionThumbnail"
        Me.imgCollectionThumbnail.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.imgCollectionThumbnail.Size = New System.Drawing.Size(312, 174)
        Me.imgCollectionThumbnail.TabIndex = 38
        Me.imgCollectionThumbnail.TabStop = False
        Me.imgCollectionThumbnail.Text = ""
        '
        'imgCollectionThumbnailDefault
        '
        Me.imgCollectionThumbnailDefault.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgCollectionThumbnailDefault.BackColor = System.Drawing.Color.Transparent
        Me.imgCollectionThumbnailDefault.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgCollectionThumbnailDefault.BorderColor = System.Drawing.Color.White
        Me.imgCollectionThumbnailDefault.BorderShow = False
        Me.imgCollectionThumbnailDefault.ColorFillSolid = System.Drawing.Color.Transparent
        Me.imgCollectionThumbnailDefault.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgCollectionThumbnailDefault.DesignerSelected = False
        Me.imgCollectionThumbnailDefault.DimFactorClick = 0
        Me.imgCollectionThumbnailDefault.DimFactorHover = 0
        Me.imgCollectionThumbnailDefault.FillType = CButtonLib.CButton.eFillType.Solid
        Me.imgCollectionThumbnailDefault.ForeColor = System.Drawing.Color.DarkGray
        Me.imgCollectionThumbnailDefault.ImageIndex = 0
        Me.imgCollectionThumbnailDefault.Location = New System.Drawing.Point(7, 10)
        Me.imgCollectionThumbnailDefault.Name = "imgCollectionThumbnailDefault"
        Me.imgCollectionThumbnailDefault.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.imgCollectionThumbnailDefault.Size = New System.Drawing.Size(312, 174)
        Me.imgCollectionThumbnailDefault.TabIndex = 44
        Me.imgCollectionThumbnailDefault.TabStop = False
        Me.imgCollectionThumbnailDefault.Text = ""
        '
        'imageBackgroundEffect
        '
        Me.imageBackgroundEffect.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imageBackgroundEffect.Image = Global.Movieo.My.Resources.Resources.PosterGlow
        Me.imageBackgroundEffect.Location = New System.Drawing.Point(-5, 2)
        Me.imageBackgroundEffect.Name = "imageBackgroundEffect"
        Me.imageBackgroundEffect.Size = New System.Drawing.Size(338, 188)
        Me.imageBackgroundEffect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imageBackgroundEffect.TabIndex = 45
        Me.imageBackgroundEffect.TabStop = False
        '
        'lblCollectionDescription
        '
        Me.lblCollectionDescription.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblCollectionDescription.AutoEllipsis = True
        Me.lblCollectionDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblCollectionDescription.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCollectionDescription.ForeColor = System.Drawing.Color.White
        Me.lblCollectionDescription.Location = New System.Drawing.Point(11, 216)
        Me.lblCollectionDescription.Margin = New System.Windows.Forms.Padding(3)
        Me.lblCollectionDescription.Name = "lblCollectionDescription"
        Me.lblCollectionDescription.Size = New System.Drawing.Size(308, 15)
        Me.lblCollectionDescription.TabIndex = 51
        Me.lblCollectionDescription.Text = "Collection Description"
        '
        'itemsCollectionMovies
        '
        Me.itemsCollectionMovies.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.itemsCollectionMovies.FormattingEnabled = True
        Me.itemsCollectionMovies.Location = New System.Drawing.Point(183, 39)
        Me.itemsCollectionMovies.Name = "itemsCollectionMovies"
        Me.itemsCollectionMovies.Size = New System.Drawing.Size(120, 95)
        Me.itemsCollectionMovies.TabIndex = 50
        Me.itemsCollectionMovies.Visible = False
        '
        'ctrlCollectionThumbnail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(328, 240)
        Me.ControlBox = False
        Me.Controls.Add(Me.itemsCollectionMovies)
        Me.Controls.Add(Me.imgCollectionThumbnail)
        Me.Controls.Add(Me.lblCollectionTitle)
        Me.Controls.Add(Me.imgCollectionThumbnailDefault)
        Me.Controls.Add(Me.imageBackgroundEffect)
        Me.Controls.Add(Me.lblCollectionDescription)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ctrlCollectionThumbnail"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "PosterTitle"
        CType(Me.imageBackgroundEffect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents imgCollectionThumbnail As CButtonLib.CButton
    Friend WithEvents lblCollectionTitle As Label
    Public WithEvents imgCollectionThumbnailDefault As CButtonLib.CButton
    Friend WithEvents imageBackgroundEffect As PictureBox
    Friend WithEvents lblCollectionDescription As Label
    Friend WithEvents itemsCollectionMovies As ListBox
End Class
