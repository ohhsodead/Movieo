<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCreateList
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
        Me.txtTitle = New ChreneLib.Controls.TextBoxes.CTextBox()
        Me.btnFrmCreateList = New CButtonLib.CButton()
        Me.underline0 = New CButtonLib.CButton()
        Me.txtDescription = New ChreneLib.Controls.TextBoxes.CTextBox()
        Me.underline1 = New CButtonLib.CButton()
        Me.meClose = New System.Windows.Forms.PictureBox()
        Me.timerHideNotifications = New System.Windows.Forms.Timer(Me.components)
        Me.lblStatus = New CButtonLib.CButton()
        Me.txtMovies = New ChreneLib.Controls.TextBoxes.CTextBox()
        Me.underline2 = New CButtonLib.CButton()
        CType(Me.meClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTitle
        '
        Me.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.txtTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtTitle.Location = New System.Drawing.Point(260, 112)
        Me.txtTitle.MaxLength = 255
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(572, 36)
        Me.txtTitle.TabIndex = 0
        Me.txtTitle.WaterMark = "Title"
        Me.txtTitle.WaterMarkActiveForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtTitle.WaterMarkFont = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.txtTitle.WaterMarkForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        '
        'btnFrmCreateList
        '
        Me.btnFrmCreateList.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnFrmCreateList.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnFrmCreateList.ColorFillSolid = System.Drawing.Color.Transparent
        Me.btnFrmCreateList.Corners.All = 2
        Me.btnFrmCreateList.Corners.LowerLeft = 2
        Me.btnFrmCreateList.Corners.LowerRight = 2
        Me.btnFrmCreateList.Corners.UpperLeft = 2
        Me.btnFrmCreateList.Corners.UpperRight = 2
        Me.btnFrmCreateList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFrmCreateList.DesignerSelected = False
        Me.btnFrmCreateList.DimFactorClick = 0
        Me.btnFrmCreateList.DimFactorHover = 0
        Me.btnFrmCreateList.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnFrmCreateList.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.btnFrmCreateList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnFrmCreateList.ImageIndex = 0
        Me.btnFrmCreateList.Location = New System.Drawing.Point(696, 251)
        Me.btnFrmCreateList.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.btnFrmCreateList.Name = "btnFrmCreateList"
        Me.btnFrmCreateList.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnFrmCreateList.Size = New System.Drawing.Size(143, 37)
        Me.btnFrmCreateList.TabIndex = 3
        Me.btnFrmCreateList.Text = "SAVE TO MY LISTS"
        Me.btnFrmCreateList.TextShadowShow = False
        '
        'underline0
        '
        Me.underline0.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.underline0.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.underline0.ColorFillSolid = System.Drawing.Color.Transparent
        Me.underline0.Corners.All = 2
        Me.underline0.Corners.LowerLeft = 2
        Me.underline0.Corners.LowerRight = 2
        Me.underline0.Corners.UpperLeft = 2
        Me.underline0.Corners.UpperRight = 2
        Me.underline0.DesignerSelected = False
        Me.underline0.DimFactorClick = 0
        Me.underline0.DimFactorHover = 0
        Me.underline0.FillType = CButtonLib.CButton.eFillType.Solid
        Me.underline0.ImageIndex = 0
        Me.underline0.Location = New System.Drawing.Point(253, 161)
        Me.underline0.Margin = New System.Windows.Forms.Padding(3, 10, 3, 6)
        Me.underline0.Name = "underline0"
        Me.underline0.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.underline0.Size = New System.Drawing.Size(586, 1)
        Me.underline0.TabIndex = 100000062
        Me.underline0.TabStop = False
        Me.underline0.Text = ""
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI", 12.5!)
        Me.txtDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtDescription.Location = New System.Drawing.Point(260, 183)
        Me.txtDescription.MaxLength = 75
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(572, 23)
        Me.txtDescription.TabIndex = 1
        Me.txtDescription.WaterMark = "Description"
        Me.txtDescription.WaterMarkActiveForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtDescription.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.5!)
        Me.txtDescription.WaterMarkForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        '
        'underline1
        '
        Me.underline1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.underline1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.underline1.ColorFillSolid = System.Drawing.Color.Transparent
        Me.underline1.Corners.All = 2
        Me.underline1.Corners.LowerLeft = 2
        Me.underline1.Corners.LowerRight = 2
        Me.underline1.Corners.UpperLeft = 2
        Me.underline1.Corners.UpperRight = 2
        Me.underline1.DesignerSelected = False
        Me.underline1.DimFactorClick = 0
        Me.underline1.DimFactorHover = 0
        Me.underline1.FillType = CButtonLib.CButton.eFillType.Solid
        Me.underline1.ImageIndex = 0
        Me.underline1.Location = New System.Drawing.Point(253, 219)
        Me.underline1.Margin = New System.Windows.Forms.Padding(3, 10, 3, 6)
        Me.underline1.Name = "underline1"
        Me.underline1.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.underline1.Size = New System.Drawing.Size(586, 1)
        Me.underline1.TabIndex = 100000064
        Me.underline1.TabStop = False
        Me.underline1.Text = ""
        '
        'meClose
        '
        Me.meClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.meClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.meClose.Image = Global.Movieo.My.Resources.Resources.PopupCloseL
        Me.meClose.Location = New System.Drawing.Point(1052, 12)
        Me.meClose.Name = "meClose"
        Me.meClose.Size = New System.Drawing.Size(28, 28)
        Me.meClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.meClose.TabIndex = 100000055
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
        Me.lblStatus.Location = New System.Drawing.Point(482, -2)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.lblStatus.Size = New System.Drawing.Size(128, 35)
        Me.lblStatus.TabIndex = 99999
        Me.lblStatus.TabStop = False
        Me.lblStatus.Text = "Creating List..."
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblStatus.TextMargin = New System.Windows.Forms.Padding(2, 2, 2, 5)
        Me.lblStatus.TextShadowShow = False
        Me.lblStatus.Visible = False
        '
        'txtMovies
        '
        Me.txtMovies.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtMovies.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtMovies.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMovies.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtMovies.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtMovies.Location = New System.Drawing.Point(260, 258)
        Me.txtMovies.MaxLength = 75
        Me.txtMovies.Name = "txtMovies"
        Me.txtMovies.Size = New System.Drawing.Size(391, 22)
        Me.txtMovies.TabIndex = 2
        Me.txtMovies.WaterMark = "Add a movie ex. Deadpool (2016), Frozen (2013)"
        Me.txtMovies.WaterMarkActiveForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtMovies.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtMovies.WaterMarkForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        '
        'underline2
        '
        Me.underline2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.underline2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.underline2.ColorFillSolid = System.Drawing.Color.Transparent
        Me.underline2.Corners.All = 2
        Me.underline2.Corners.LowerLeft = 2
        Me.underline2.Corners.LowerRight = 2
        Me.underline2.Corners.UpperLeft = 2
        Me.underline2.Corners.UpperRight = 2
        Me.underline2.DesignerSelected = False
        Me.underline2.DimFactorClick = 0
        Me.underline2.DimFactorHover = 0
        Me.underline2.FillType = CButtonLib.CButton.eFillType.Solid
        Me.underline2.ImageIndex = 0
        Me.underline2.Location = New System.Drawing.Point(253, 251)
        Me.underline2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.underline2.Name = "underline2"
        Me.underline2.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.underline2.Size = New System.Drawing.Size(405, 37)
        Me.underline2.TabIndex = 100000069
        Me.underline2.TabStop = False
        Me.underline2.Text = ""
        '
        'frmCreateList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScrollMargin = New System.Drawing.Size(0, 70)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1092, 561)
        Me.Controls.Add(Me.txtMovies)
        Me.Controls.Add(Me.underline2)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.underline1)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.btnFrmCreateList)
        Me.Controls.Add(Me.underline0)
        Me.Controls.Add(Me.meClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCreateList"
        Me.Opacity = 0.98R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create List"
        CType(Me.meClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents meClose As PictureBox
    Friend WithEvents txtTitle As ChreneLib.Controls.TextBoxes.CTextBox
    Friend WithEvents btnFrmCreateList As CButtonLib.CButton
    Friend WithEvents underline0 As CButtonLib.CButton
    Friend WithEvents txtDescription As ChreneLib.Controls.TextBoxes.CTextBox
    Friend WithEvents underline1 As CButtonLib.CButton
    Friend WithEvents timerHideNotifications As Timer
    Friend WithEvents lblStatus As CButtonLib.CButton
    Friend WithEvents txtMovies As ChreneLib.Controls.TextBoxes.CTextBox
    Friend WithEvents underline2 As CButtonLib.CButton
End Class
