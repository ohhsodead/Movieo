<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ctrlContextMenuPlayer
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
        Me.btnVLC = New CButtonLib.CButton()
        Me.btnDefault = New CButtonLib.CButton()
        Me.SuspendLayout()
        '
        'btnVLC
        '
        Me.btnVLC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVLC.BackColor = System.Drawing.Color.Transparent
        Me.btnVLC.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnVLC.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnVLC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVLC.DesignerSelected = False
        Me.btnVLC.DimFactorClick = 20
        Me.btnVLC.DimFactorHover = 20
        Me.btnVLC.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnVLC.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnVLC.ForeColor = System.Drawing.Color.Silver
        Me.btnVLC.ImageIndex = 0
        Me.btnVLC.Location = New System.Drawing.Point(-1, 37)
        Me.btnVLC.Margin = New System.Windows.Forms.Padding(0)
        Me.btnVLC.Name = "btnVLC"
        Me.btnVLC.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnVLC.Size = New System.Drawing.Size(157, 32)
        Me.btnVLC.TabIndex = 1
        Me.btnVLC.Text = "VLC"
        Me.btnVLC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVLC.TextMargin = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnVLC.TextShadowShow = False
        '
        'btnDefault
        '
        Me.btnDefault.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDefault.BackColor = System.Drawing.Color.Transparent
        Me.btnDefault.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnDefault.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnDefault.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDefault.DesignerSelected = False
        Me.btnDefault.DimFactorClick = 20
        Me.btnDefault.DimFactorHover = 20
        Me.btnDefault.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnDefault.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnDefault.ForeColor = System.Drawing.Color.Silver
        Me.btnDefault.ImageIndex = 0
        Me.btnDefault.Location = New System.Drawing.Point(-1, 5)
        Me.btnDefault.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDefault.Name = "btnDefault"
        Me.btnDefault.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnDefault.Size = New System.Drawing.Size(157, 32)
        Me.btnDefault.TabIndex = 0
        Me.btnDefault.Text = "Default (WMP)"
        Me.btnDefault.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDefault.TextMargin = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnDefault.TextShadowShow = False
        '
        'ctrlContextMenuPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(155, 74)
        Me.Controls.Add(Me.btnVLC)
        Me.Controls.Add(Me.btnDefault)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ctrlContextMenuPlayer"
        Me.Opacity = 0.98R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "External Players"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDefault As CButtonLib.CButton
    Friend WithEvents btnVLC As CButtonLib.CButton
End Class
