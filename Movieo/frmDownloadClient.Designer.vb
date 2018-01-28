<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDownloadClient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDownloadClient))
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.lblTitleLocation = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.lblTitleSize = New System.Windows.Forms.Label()
        Me.prgbarStatus = New System.Windows.Forms.ProgressBar()
        Me.BtnCancel = New CButtonLib.CButton()
        Me.bgStatus = New CButtonLib.CButton()
        Me.lblMovieTitle = New System.Windows.Forms.Label()
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.lblTitleSpeed = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblProgress
        '
        Me.lblProgress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblProgress.AutoEllipsis = True
        Me.lblProgress.BackColor = System.Drawing.Color.Transparent
        Me.lblProgress.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!)
        Me.lblProgress.Location = New System.Drawing.Point(242, 178)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(502, 25)
        Me.lblProgress.TabIndex = 0
        Me.lblProgress.Text = "Connecting"
        Me.lblProgress.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTitleLocation
        '
        Me.lblTitleLocation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTitleLocation.AutoSize = True
        Me.lblTitleLocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.lblTitleLocation.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblTitleLocation.Location = New System.Drawing.Point(310, 306)
        Me.lblTitleLocation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 0)
        Me.lblTitleLocation.Name = "lblTitleLocation"
        Me.lblTitleLocation.Size = New System.Drawing.Size(64, 19)
        Me.lblTitleLocation.TabIndex = 1060
        Me.lblTitleLocation.Text = "Location:"
        Me.lblTitleLocation.Visible = False
        '
        'lblLocation
        '
        Me.lblLocation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLocation.AutoEllipsis = True
        Me.lblLocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.lblLocation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLocation.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblLocation.Location = New System.Drawing.Point(380, 306)
        Me.lblLocation.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(298, 20)
        Me.lblLocation.TabIndex = 1061
        Me.lblLocation.Text = "\Downloads\"
        Me.lblLocation.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblLocation.Visible = False
        '
        'lblSize
        '
        Me.lblSize.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSize.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.lblSize.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblSize.Location = New System.Drawing.Point(351, 283)
        Me.lblSize.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(327, 17)
        Me.lblSize.TabIndex = 1065
        Me.lblSize.Text = "MB"
        Me.lblSize.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblSize.Visible = False
        '
        'lblTitleSize
        '
        Me.lblTitleSize.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTitleSize.AutoSize = True
        Me.lblTitleSize.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.lblTitleSize.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblTitleSize.Location = New System.Drawing.Point(310, 283)
        Me.lblTitleSize.Margin = New System.Windows.Forms.Padding(3, 4, 3, 0)
        Me.lblTitleSize.Name = "lblTitleSize"
        Me.lblTitleSize.Size = New System.Drawing.Size(35, 19)
        Me.lblTitleSize.TabIndex = 1064
        Me.lblTitleSize.Text = "Size:"
        Me.lblTitleSize.Visible = False
        '
        'prgbarStatus
        '
        Me.prgbarStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.prgbarStatus.Location = New System.Drawing.Point(225, 219)
        Me.prgbarStatus.Name = "prgbarStatus"
        Me.prgbarStatus.Size = New System.Drawing.Size(536, 12)
        Me.prgbarStatus.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prgbarStatus.TabIndex = 1066
        Me.prgbarStatus.Visible = False
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnCancel.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancel.BorderColor = System.Drawing.Color.White
        Me.BtnCancel.BorderShow = False
        Me.BtnCancel.ColorFillSolid = System.Drawing.Color.Firebrick
        Me.BtnCancel.Corners.All = 3
        Me.BtnCancel.Corners.LowerLeft = 3
        Me.BtnCancel.Corners.LowerRight = 3
        Me.BtnCancel.Corners.UpperLeft = 3
        Me.BtnCancel.Corners.UpperRight = 3
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.DesignerSelected = False
        Me.BtnCancel.DimFactorClick = -30
        Me.BtnCancel.DimFactorHover = -20
        Me.BtnCancel.FillType = CButtonLib.CButton.eFillType.Solid
        Me.BtnCancel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.BtnCancel.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnCancel.ImageIndex = 0
        Me.BtnCancel.Location = New System.Drawing.Point(443, 373)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.BtnCancel.Size = New System.Drawing.Size(100, 34)
        Me.BtnCancel.TabIndex = 1058
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.TextShadowShow = False
        '
        'bgStatus
        '
        Me.bgStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bgStatus.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.bgStatus.BorderShow = False
        Me.bgStatus.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.bgStatus.Corners.All = 4
        Me.bgStatus.Corners.LowerLeft = 4
        Me.bgStatus.Corners.LowerRight = 4
        Me.bgStatus.Corners.UpperLeft = 4
        Me.bgStatus.Corners.UpperRight = 4
        Me.bgStatus.DesignerSelected = False
        Me.bgStatus.DimFactorClick = 0
        Me.bgStatus.DimFactorHover = 0
        Me.bgStatus.FillType = CButtonLib.CButton.eFillType.Solid
        Me.bgStatus.FocalPoints.CenterPtX = 0!
        Me.bgStatus.FocalPoints.CenterPtY = 0!
        Me.bgStatus.ImageIndex = 0
        Me.bgStatus.Location = New System.Drawing.Point(303, 253)
        Me.bgStatus.Name = "bgStatus"
        Me.bgStatus.Size = New System.Drawing.Size(380, 80)
        Me.bgStatus.TabIndex = 1059
        Me.bgStatus.Text = ""
        Me.bgStatus.Visible = False
        '
        'lblMovieTitle
        '
        Me.lblMovieTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMovieTitle.AutoEllipsis = True
        Me.lblMovieTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblMovieTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!)
        Me.lblMovieTitle.Location = New System.Drawing.Point(242, 102)
        Me.lblMovieTitle.Name = "lblMovieTitle"
        Me.lblMovieTitle.Size = New System.Drawing.Size(502, 25)
        Me.lblMovieTitle.TabIndex = 1067
        Me.lblMovieTitle.Text = "Movie Title"
        Me.lblMovieTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblMovieTitle.Visible = False
        '
        'lblSpeed
        '
        Me.lblSpeed.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSpeed.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.lblSpeed.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblSpeed.Location = New System.Drawing.Point(390, 261)
        Me.lblSpeed.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(288, 17)
        Me.lblSpeed.TabIndex = 1069
        Me.lblSpeed.Text = "/Sec"
        Me.lblSpeed.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblSpeed.Visible = False
        '
        'lblTitleSpeed
        '
        Me.lblTitleSpeed.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTitleSpeed.AutoSize = True
        Me.lblTitleSpeed.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.lblTitleSpeed.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblTitleSpeed.Location = New System.Drawing.Point(310, 261)
        Me.lblTitleSpeed.Margin = New System.Windows.Forms.Padding(3, 4, 3, 0)
        Me.lblTitleSpeed.Name = "lblTitleSpeed"
        Me.lblTitleSpeed.Size = New System.Drawing.Size(49, 19)
        Me.lblTitleSpeed.TabIndex = 1068
        Me.lblTitleSpeed.Text = "Speed:"
        Me.lblTitleSpeed.Visible = False
        '
        'frmDownloadClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(986, 508)
        Me.Controls.Add(Me.lblSpeed)
        Me.Controls.Add(Me.lblTitleSpeed)
        Me.Controls.Add(Me.lblMovieTitle)
        Me.Controls.Add(Me.prgbarStatus)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.lblTitleSize)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.lblTitleLocation)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.bgStatus)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDownloadClient"
        Me.Opacity = 0.97R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Downloading Movie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblProgress As Label
    Public WithEvents BtnCancel As CButtonLib.CButton
    Friend WithEvents bgStatus As CButtonLib.CButton
    Friend WithEvents lblTitleLocation As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents lblSize As Label
    Friend WithEvents lblTitleSize As Label
    Friend WithEvents prgbarStatus As ProgressBar
    Friend WithEvents lblMovieTitle As Label
    Friend WithEvents lblSpeed As Label
    Friend WithEvents lblTitleSpeed As Label
End Class
