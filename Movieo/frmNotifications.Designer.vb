<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNotifications
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotifications))
        Me.splitterTop = New System.Windows.Forms.Label()
        Me.lblTopHeader = New System.Windows.Forms.Label()
        Me.meClose = New System.Windows.Forms.PictureBox()
        Me.timerGetNotifications = New System.Windows.Forms.Timer(Me.components)
        Me.panelNotifications = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblStatus = New System.Windows.Forms.Label()
        CType(Me.meClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'splitterTop
        '
        Me.splitterTop.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.splitterTop.AutoSize = True
        Me.splitterTop.BackColor = System.Drawing.Color.Transparent
        Me.splitterTop.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.splitterTop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.splitterTop.Location = New System.Drawing.Point(180, 152)
        Me.splitterTop.MaximumSize = New System.Drawing.Size(745, 0)
        Me.splitterTop.MinimumSize = New System.Drawing.Size(745, 0)
        Me.splitterTop.Name = "splitterTop"
        Me.splitterTop.Size = New System.Drawing.Size(745, 32)
        Me.splitterTop.TabIndex = 100
        Me.splitterTop.Text = "-------------------------------------------------------------------------"
        '
        'lblTopHeader
        '
        Me.lblTopHeader.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTopHeader.AutoSize = True
        Me.lblTopHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblTopHeader.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTopHeader.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopHeader.ForeColor = System.Drawing.Color.White
        Me.lblTopHeader.Location = New System.Drawing.Point(446, 96)
        Me.lblTopHeader.Name = "lblTopHeader"
        Me.lblTopHeader.Size = New System.Drawing.Size(213, 45)
        Me.lblTopHeader.TabIndex = 100
        Me.lblTopHeader.Text = "Notifications"
        '
        'meClose
        '
        Me.meClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.meClose.BackColor = System.Drawing.Color.Transparent
        Me.meClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.meClose.Image = Global.Movieo.My.Resources.Resources.PopupCloseL
        Me.meClose.Location = New System.Drawing.Point(1059, 23)
        Me.meClose.Name = "meClose"
        Me.meClose.Size = New System.Drawing.Size(28, 28)
        Me.meClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.meClose.TabIndex = 100000055
        Me.meClose.TabStop = False
        '
        'timerGetNotifications
        '
        Me.timerGetNotifications.Interval = 600
        '
        'panelNotifications
        '
        Me.panelNotifications.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.panelNotifications.AutoSize = True
        Me.panelNotifications.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelNotifications.BackColor = System.Drawing.Color.Transparent
        Me.panelNotifications.Location = New System.Drawing.Point(184, 220)
        Me.panelNotifications.MaximumSize = New System.Drawing.Size(745, 0)
        Me.panelNotifications.MinimumSize = New System.Drawing.Size(745, 100)
        Me.panelNotifications.Name = "panelNotifications"
        Me.panelNotifications.Size = New System.Drawing.Size(745, 100)
        Me.panelNotifications.TabIndex = 100
        Me.panelNotifications.Visible = False
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 13.75!)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(187, 232)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(730, 229)
        Me.lblStatus.TabIndex = 100
        Me.lblStatus.Text = "Loading..."
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmNotifications
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(0, 70)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1109, 561)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.panelNotifications)
        Me.Controls.Add(Me.meClose)
        Me.Controls.Add(Me.splitterTop)
        Me.Controls.Add(Me.lblTopHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNotifications"
        Me.Opacity = 0.98R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notifications"
        CType(Me.meClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents splitterTop As Label
    Friend WithEvents lblTopHeader As Label
    Friend WithEvents meClose As PictureBox
    Friend WithEvents timerGetNotifications As Timer
    Friend WithEvents panelNotifications As FlowLayoutPanel
    Friend WithEvents lblStatus As Label
End Class
