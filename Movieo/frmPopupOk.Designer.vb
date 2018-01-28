<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPopupOk
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
        Me.btnOk = New CButtonLib.CButton()
        Me.panelBottom = New CButtonLib.CButton()
        Me.SuspendLayout()
        '
        'DialogMessage
        '
        Me.DialogMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DialogMessage.BackColor = System.Drawing.Color.Transparent
        Me.DialogMessage.Cursor = System.Windows.Forms.Cursors.Default
        Me.DialogMessage.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.DialogMessage.ForeColor = System.Drawing.Color.White
        Me.DialogMessage.Location = New System.Drawing.Point(19, 52)
        Me.DialogMessage.Name = "DialogMessage"
        Me.DialogMessage.Size = New System.Drawing.Size(467, 65)
        Me.DialogMessage.TabIndex = 999
        Me.DialogMessage.Text = "Message" & Global.Microsoft.VisualBasic.ChrW(13)
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
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnOk.ColorFillSolid = System.Drawing.Color.SteelBlue
        Me.btnOk.Corners.All = 2
        Me.btnOk.Corners.LowerLeft = 2
        Me.btnOk.Corners.LowerRight = 2
        Me.btnOk.Corners.UpperLeft = 2
        Me.btnOk.Corners.UpperRight = 2
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.DesignerSelected = False
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOk.DimFactorClick = 0
        Me.btnOk.DimFactorHover = 10
        Me.btnOk.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnOk.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.btnOk.ImageIndex = 0
        Me.btnOk.Location = New System.Drawing.Point(403, 143)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnOk.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOk.SideImageBehindText = False
        Me.btnOk.SideImageIsClickable = True
        Me.btnOk.SideImageSize = New System.Drawing.Size(20, 20)
        Me.btnOk.Size = New System.Drawing.Size(89, 30)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "Ok"
        Me.btnOk.TextMargin = New System.Windows.Forms.Padding(2, 3, 2, 2)
        Me.btnOk.TextShadowShow = False
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
        Me.panelBottom.Location = New System.Drawing.Point(-1, 128)
        Me.panelBottom.Name = "panelBottom"
        Me.panelBottom.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.panelBottom.Size = New System.Drawing.Size(509, 62)
        Me.panelBottom.TabIndex = 10002
        Me.panelBottom.TabStop = False
        Me.panelBottom.Text = ""
        '
        'frmPopupOk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(507, 189)
        Me.Controls.Add(Me.DialogMessage)
        Me.Controls.Add(Me.DialogTitle)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.panelBottom)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPopupOk"
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
    Public WithEvents btnOk As CButtonLib.CButton
    Friend WithEvents panelBottom As CButtonLib.CButton
End Class
