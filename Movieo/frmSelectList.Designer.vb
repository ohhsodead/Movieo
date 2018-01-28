<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSelectList
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
        Me.itemsBackground = New CButtonLib.CButton()
        Me.itemsMyListsPath = New System.Windows.Forms.ListBox()
        Me.meClose = New System.Windows.Forms.PictureBox()
        Me.itemsMyListsTitle = New System.Windows.Forms.ListBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnAddRemoveMovie = New CButtonLib.CButton()
        CType(Me.meClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'itemsBackground
        '
        Me.itemsBackground.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.itemsBackground.BackColor = System.Drawing.Color.Transparent
        Me.itemsBackground.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.itemsBackground.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.itemsBackground.Corners.All = 2
        Me.itemsBackground.Corners.LowerLeft = 2
        Me.itemsBackground.Corners.LowerRight = 2
        Me.itemsBackground.Corners.UpperLeft = 2
        Me.itemsBackground.Corners.UpperRight = 2
        Me.itemsBackground.Cursor = System.Windows.Forms.Cursors.Hand
        Me.itemsBackground.DesignerSelected = False
        Me.itemsBackground.DimFactorClick = 0
        Me.itemsBackground.DimFactorHover = 0
        Me.itemsBackground.FillType = CButtonLib.CButton.eFillType.Solid
        Me.itemsBackground.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.itemsBackground.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.itemsBackground.ImageIndex = 0
        Me.itemsBackground.Location = New System.Drawing.Point(298, 207)
        Me.itemsBackground.Margin = New System.Windows.Forms.Padding(0)
        Me.itemsBackground.Name = "itemsBackground"
        Me.itemsBackground.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.itemsBackground.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.itemsBackground.SideImageSize = New System.Drawing.Size(14, 15)
        Me.itemsBackground.Size = New System.Drawing.Size(390, 181)
        Me.itemsBackground.TabIndex = 9999
        Me.itemsBackground.TabStop = False
        Me.itemsBackground.Text = ""
        Me.itemsBackground.TextShadow = System.Drawing.Color.White
        Me.itemsBackground.TextShadowShow = False
        '
        'itemsMyListsPath
        '
        Me.itemsMyListsPath.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.itemsMyListsPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.itemsMyListsPath.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.itemsMyListsPath.Font = New System.Drawing.Font("Segoe UI Semibold", 10.75!)
        Me.itemsMyListsPath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.itemsMyListsPath.FormattingEnabled = True
        Me.itemsMyListsPath.HorizontalScrollbar = True
        Me.itemsMyListsPath.ItemHeight = 19
        Me.itemsMyListsPath.Location = New System.Drawing.Point(301, 212)
        Me.itemsMyListsPath.Name = "itemsMyListsPath"
        Me.itemsMyListsPath.Size = New System.Drawing.Size(384, 171)
        Me.itemsMyListsPath.TabIndex = 0
        Me.itemsMyListsPath.TabStop = False
        Me.itemsMyListsPath.UseTabStops = False
        '
        'meClose
        '
        Me.meClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.meClose.BackColor = System.Drawing.Color.Transparent
        Me.meClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.meClose.Image = Global.Movieo.My.Resources.Resources.PopupCloseL
        Me.meClose.Location = New System.Drawing.Point(946, 12)
        Me.meClose.Name = "meClose"
        Me.meClose.Size = New System.Drawing.Size(28, 28)
        Me.meClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.meClose.TabIndex = 100000056
        Me.meClose.TabStop = False
        '
        'itemsMyListsTitle
        '
        Me.itemsMyListsTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.itemsMyListsTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.itemsMyListsTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.itemsMyListsTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.75!)
        Me.itemsMyListsTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.itemsMyListsTitle.FormattingEnabled = True
        Me.itemsMyListsTitle.HorizontalScrollbar = True
        Me.itemsMyListsTitle.ItemHeight = 19
        Me.itemsMyListsTitle.Location = New System.Drawing.Point(301, 212)
        Me.itemsMyListsTitle.Name = "itemsMyListsTitle"
        Me.itemsMyListsTitle.Size = New System.Drawing.Size(384, 171)
        Me.itemsMyListsTitle.TabIndex = 0
        Me.itemsMyListsTitle.UseTabStops = False
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 17.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(444, 129)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(98, 31)
        Me.lblTitle.TabIndex = 9999
        Me.lblTitle.Text = "My Lists"
        '
        'btnAddRemoveMovie
        '
        Me.btnAddRemoveMovie.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddRemoveMovie.BackColor = System.Drawing.Color.Transparent
        Me.btnAddRemoveMovie.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnAddRemoveMovie.BorderShow = False
        Me.btnAddRemoveMovie.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnAddRemoveMovie.Corners.All = 2
        Me.btnAddRemoveMovie.Corners.LowerLeft = 2
        Me.btnAddRemoveMovie.Corners.LowerRight = 2
        Me.btnAddRemoveMovie.Corners.UpperLeft = 2
        Me.btnAddRemoveMovie.Corners.UpperRight = 2
        Me.btnAddRemoveMovie.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddRemoveMovie.DesignerSelected = False
        Me.btnAddRemoveMovie.DimFactorClick = -15
        Me.btnAddRemoveMovie.DimFactorHover = -15
        Me.btnAddRemoveMovie.Enabled = False
        Me.btnAddRemoveMovie.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnAddRemoveMovie.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!)
        Me.btnAddRemoveMovie.ImageIndex = 0
        Me.btnAddRemoveMovie.Location = New System.Drawing.Point(576, 395)
        Me.btnAddRemoveMovie.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAddRemoveMovie.Name = "btnAddRemoveMovie"
        Me.btnAddRemoveMovie.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnAddRemoveMovie.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddRemoveMovie.SideImageSize = New System.Drawing.Size(14, 15)
        Me.btnAddRemoveMovie.Size = New System.Drawing.Size(112, 30)
        Me.btnAddRemoveMovie.TabIndex = 1
        Me.btnAddRemoveMovie.Text = "Add / Remove"
        Me.btnAddRemoveMovie.TextShadow = System.Drawing.Color.White
        Me.btnAddRemoveMovie.TextShadowShow = False
        '
        'frmSelectList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(986, 561)
        Me.Controls.Add(Me.btnAddRemoveMovie)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.itemsMyListsTitle)
        Me.Controls.Add(Me.meClose)
        Me.Controls.Add(Me.itemsBackground)
        Me.Controls.Add(Me.itemsMyListsPath)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSelectList"
        Me.Opacity = 0.98R
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Available Streams"
        CType(Me.meClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents itemsBackground As CButtonLib.CButton
    Friend WithEvents itemsMyListsPath As ListBox
    Friend WithEvents meClose As PictureBox
    Friend WithEvents itemsMyListsTitle As ListBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnAddRemoveMovie As CButtonLib.CButton
End Class
