<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPopupYesNo
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
        Me.DialogMessage = New System.Windows.Forms.Label()
        Me.DialogTitle = New System.Windows.Forms.Label()
        Me.btnYes = New CButtonLib.CButton()
        Me.panelBottom = New CButtonLib.CButton()
        Me.btnNo = New CButtonLib.CButton()
        Me.SuspendLayout()
        '
        'DialogMessage
        '
        Me.DialogMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DialogMessage.BackColor = System.Drawing.Color.Transparent
        Me.DialogMessage.Cursor = System.Windows.Forms.Cursors.Default
        Me.DialogMessage.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DialogMessage.ForeColor = System.Drawing.Color.White
        Me.DialogMessage.Location = New System.Drawing.Point(19, 52)
        Me.DialogMessage.Name = "DialogMessage"
        Me.DialogMessage.Size = New System.Drawing.Size(467, 75)
        Me.DialogMessage.TabIndex = 999
        Me.DialogMessage.Text = "Message"
        '
        'DialogTitle
        '
        Me.DialogTitle.AutoSize = True
        Me.DialogTitle.BackColor = System.Drawing.Color.Transparent
        Me.DialogTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.DialogTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!)
        Me.DialogTitle.ForeColor = System.Drawing.Color.White
        Me.DialogTitle.Location = New System.Drawing.Point(16, 15)
        Me.DialogTitle.Name = "DialogTitle"
        Me.DialogTitle.Size = New System.Drawing.Size(62, 32)
        Me.DialogTitle.TabIndex = 999
        Me.DialogTitle.Text = "Title"
        '
        'btnYes
        '
        Me.btnYes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnYes.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnYes.ColorFillSolid = System.Drawing.Color.SteelBlue
        Me.btnYes.Corners.All = 2
        Me.btnYes.Corners.LowerLeft = 2
        Me.btnYes.Corners.LowerRight = 2
        Me.btnYes.Corners.UpperLeft = 2
        Me.btnYes.Corners.UpperRight = 2
        Me.btnYes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnYes.DesignerSelected = False
        Me.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.btnYes.DimFactorClick = 0
        Me.btnYes.DimFactorHover = 10
        Me.btnYes.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnYes.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.btnYes.ImageIndex = 0
        Me.btnYes.Location = New System.Drawing.Point(403, 161)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnYes.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnYes.SideImageBehindText = False
        Me.btnYes.SideImageIsClickable = True
        Me.btnYes.SideImageSize = New System.Drawing.Size(20, 20)
        Me.btnYes.Size = New System.Drawing.Size(89, 30)
        Me.btnYes.TabIndex = 1
        Me.btnYes.Text = "Yes"
        Me.btnYes.TextMargin = New System.Windows.Forms.Padding(2, 3, 2, 2)
        Me.btnYes.TextShadowShow = False
        '
        'panelBottom
        '
        Me.panelBottom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.panelBottom.BorderColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.panelBottom.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.panelBottom.DesignerSelected = False
        Me.panelBottom.DimFactorClick = 0
        Me.panelBottom.DimFactorHover = 0
        Me.panelBottom.FillType = CButtonLib.CButton.eFillType.Solid
        Me.panelBottom.ForeColor = System.Drawing.Color.Black
        Me.panelBottom.ImageIndex = 0
        Me.panelBottom.Location = New System.Drawing.Point(-1, 146)
        Me.panelBottom.Name = "panelBottom"
        Me.panelBottom.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.panelBottom.Size = New System.Drawing.Size(509, 62)
        Me.panelBottom.TabIndex = 10000
        Me.panelBottom.TabStop = False
        Me.panelBottom.Text = ""
        '
        'btnNo
        '
        Me.btnNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnNo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnNo.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnNo.Corners.All = 2
        Me.btnNo.Corners.LowerLeft = 2
        Me.btnNo.Corners.LowerRight = 2
        Me.btnNo.Corners.UpperLeft = 2
        Me.btnNo.Corners.UpperRight = 2
        Me.btnNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNo.DesignerSelected = False
        Me.btnNo.DialogResult = System.Windows.Forms.DialogResult.No
        Me.btnNo.DimFactorClick = 0
        Me.btnNo.DimFactorHover = 10
        Me.btnNo.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnNo.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.btnNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnNo.ImageIndex = 0
        Me.btnNo.Location = New System.Drawing.Point(308, 161)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnNo.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNo.SideImageBehindText = False
        Me.btnNo.SideImageIsClickable = True
        Me.btnNo.SideImageSize = New System.Drawing.Size(20, 20)
        Me.btnNo.Size = New System.Drawing.Size(89, 30)
        Me.btnNo.TabIndex = 10001
        Me.btnNo.Text = "Nope"
        Me.btnNo.TextMargin = New System.Windows.Forms.Padding(2, 3, 2, 2)
        Me.btnNo.TextShadowShow = False
        '
        'frmPopupYesNo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(507, 207)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.DialogMessage)
        Me.Controls.Add(Me.DialogTitle)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.panelBottom)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPopupYesNo"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dialog"
        Me.TransparencyKey = System.Drawing.Color.Black
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DialogMessage As Label
    Friend WithEvents DialogTitle As Label
    Public WithEvents btnYes As CButtonLib.CButton
    Friend WithEvents panelBottom As CButtonLib.CButton
    Public WithEvents btnNo As CButtonLib.CButton
End Class
