<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrailerPlayer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTrailerPlayer))
        Me.appClose = New System.Windows.Forms.PictureBox()
        Me.swfPlayer = New AxShockwaveFlashObjects.AxShockwaveFlash()
        CType(Me.appClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.swfPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'appClose
        '
        Me.appClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.appClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.appClose.Image = Global.Movieo.My.Resources.Resources.PopupCloseL
        Me.appClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.appClose.Location = New System.Drawing.Point(1178, 12)
        Me.appClose.Name = "appClose"
        Me.appClose.Size = New System.Drawing.Size(28, 28)
        Me.appClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.appClose.TabIndex = 49
        Me.appClose.TabStop = False
        '
        'swfPlayer
        '
        Me.swfPlayer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.swfPlayer.Enabled = True
        Me.swfPlayer.Location = New System.Drawing.Point(173, 12)
        Me.swfPlayer.Name = "swfPlayer"
        Me.swfPlayer.OcxState = CType(resources.GetObject("swfPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.swfPlayer.Size = New System.Drawing.Size(872, 539)
        Me.swfPlayer.TabIndex = 50
        '
        'frmTrailerPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1218, 563)
        Me.Controls.Add(Me.swfPlayer)
        Me.Controls.Add(Me.appClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTrailerPlayer"
        Me.Opacity = 0.97R
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Watch Tailer"
        CType(Me.appClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.swfPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents appClose As PictureBox
    Friend WithEvents swfPlayer As AxShockwaveFlashObjects.AxShockwaveFlash
End Class
