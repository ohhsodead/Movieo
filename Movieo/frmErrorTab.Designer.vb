<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmErrorTab
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmErrorTab))
        Me.TextError = New System.Windows.Forms.Label()
        Me.btnRestart = New CButtonLib.CButton()
        Me.SuspendLayout()
        '
        'TextError
        '
        Me.TextError.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextError.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!)
        Me.TextError.ForeColor = System.Drawing.Color.White
        Me.TextError.Location = New System.Drawing.Point(223, 110)
        Me.TextError.Name = "TextError"
        Me.TextError.Size = New System.Drawing.Size(758, 81)
        Me.TextError.TabIndex = 9999
        Me.TextError.Text = "Oops!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Something's gone wrong..."
        Me.TextError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRestart
        '
        Me.btnRestart.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnRestart.BackColor = System.Drawing.Color.Transparent
        Me.btnRestart.ColorFillSolid = System.Drawing.Color.SteelBlue
        Me.btnRestart.Corners.All = 2
        Me.btnRestart.Corners.LowerLeft = 2
        Me.btnRestart.Corners.LowerRight = 2
        Me.btnRestart.Corners.UpperLeft = 2
        Me.btnRestart.Corners.UpperRight = 2
        Me.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestart.DesignerSelected = True
        Me.btnRestart.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnRestart.DimFactorClick = -10
        Me.btnRestart.DimFactorHover = -10
        Me.btnRestart.FillType = CButtonLib.CButton.eFillType.Solid
        Me.btnRestart.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnRestart.ImageIndex = 0
        Me.btnRestart.Location = New System.Drawing.Point(554, 213)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.ShowFocus = CButtonLib.CButton.eFocus.None
        Me.btnRestart.SideImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRestart.SideImageBehindText = False
        Me.btnRestart.SideImageIsClickable = True
        Me.btnRestart.SideImageSize = New System.Drawing.Size(20, 20)
        Me.btnRestart.Size = New System.Drawing.Size(96, 32)
        Me.btnRestart.TabIndex = 10000
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.TextMargin = New System.Windows.Forms.Padding(2, 3, 2, 2)
        Me.btnRestart.TextShadowShow = False
        '
        'frmErrorTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1205, 545)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.TextError)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmErrorTab"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Oops!"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextError As Label
    Public WithEvents btnRestart As CButtonLib.CButton
End Class
