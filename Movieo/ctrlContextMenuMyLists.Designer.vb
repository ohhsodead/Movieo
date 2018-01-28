<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ctrlContextMenuMyLists
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
        Me.btnRemoveList = New CButtonLib.CButton()
        Me.btnEditList = New CButtonLib.CButton()
        Me.SuspendLayout()
        '
        'btnRemoveList
        '
        Me.btnRemoveList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveList.BackColor = System.Drawing.Color.Transparent
        Me.btnRemoveList.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnRemoveList.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnRemoveList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemoveList.DesignerSelected = False
        Me.btnRemoveList.DimFactorClick = 20
        Me.btnRemoveList.DimFactorHover = 20
        Me.btnRemoveList.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnRemoveList.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnRemoveList.ForeColor = System.Drawing.Color.Silver
        Me.btnRemoveList.ImageIndex = 0
        Me.btnRemoveList.Location = New System.Drawing.Point(-1, 37)
        Me.btnRemoveList.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRemoveList.Name = "btnRemoveList"
        Me.btnRemoveList.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnRemoveList.Size = New System.Drawing.Size(157, 32)
        Me.btnRemoveList.TabIndex = 1
        Me.btnRemoveList.Text = "Remove"
        Me.btnRemoveList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemoveList.TextMargin = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnRemoveList.TextShadowShow = False
        '
        'btnEditList
        '
        Me.btnEditList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditList.BackColor = System.Drawing.Color.Transparent
        Me.btnEditList.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnEditList.ColorFillSolid = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnEditList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditList.DesignerSelected = False
        Me.btnEditList.DimFactorClick = 20
        Me.btnEditList.DimFactorHover = 20
        Me.btnEditList.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnEditList.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnEditList.ForeColor = System.Drawing.Color.Silver
        Me.btnEditList.ImageIndex = 0
        Me.btnEditList.Location = New System.Drawing.Point(-1, 5)
        Me.btnEditList.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEditList.Name = "btnEditList"
        Me.btnEditList.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnEditList.Size = New System.Drawing.Size(157, 32)
        Me.btnEditList.TabIndex = 0
        Me.btnEditList.Text = "Edit"
        Me.btnEditList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditList.TextMargin = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnEditList.TextShadowShow = False
        '
        'ctrlContextMenuMyLists
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(155, 74)
        Me.Controls.Add(Me.btnRemoveList)
        Me.Controls.Add(Me.btnEditList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ctrlContextMenuMyLists"
        Me.Opacity = 0.98R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Info"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEditList As CButtonLib.CButton
    Friend WithEvents btnRemoveList As CButtonLib.CButton
End Class
