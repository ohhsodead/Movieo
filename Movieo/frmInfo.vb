Imports System.Globalization
Imports System.Net
Imports System.Text.RegularExpressions

Public Class frmInfo

    Private Sub frmInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set selected tab
        Tab.SelectedTab = Movieo.InfoSelectedTab

        'Set position/size of window
        Location = Movieo.PointToScreen(Point.Empty)
        Size = Movieo.ClientSize

        'Latest changelog text
        Try
            lblChangelogFull.Text = New WebClient().DownloadString(Movieo.linkReleaseNotes)
        Catch ex As Exception
            lblChangelogFull.Text = ex.Message
        End Try

        lblAboutVersion.Text = Movieo.infoVersionText
    End Sub

    'Close window image
    Private Sub MeClose_MouseMove(sender As Object, e As MouseEventArgs) Handles meClose.MouseMove
        Try
            meClose.Image = My.Resources.PopupCloseH
        Catch ex As Exception
        End Try
    End Sub

    Private Sub MeClose_MouseLeave(sender As Object, e As EventArgs) Handles meClose.MouseLeave
        Try
            meClose.Image = My.Resources.PopupCloseL
        Catch ex As Exception
        End Try
    End Sub

    Private Sub MeClose_MouseClick(sender As Object, e As EventArgs) Handles meClose.MouseClick
        Close()
    End Sub

    'Tabs
    Private Sub LblAbout_Click(sender As Object, e As EventArgs) Handles lblTabAbout.Click
        Tab.SelectedTab = tabAbout
    End Sub

    Private Sub LblLegal_Click(sender As Object, e As EventArgs) Handles lblTabLegal.Click
        Tab.SelectedTab = tabLegal
    End Sub

    Private Sub LblFAQ_Click(sender As Object, e As EventArgs) Handles lblTabFAQ.Click
        Tab.SelectedTab = tabHelpFaq
    End Sub

    Private Sub LblChangelog_Click(sender As Object, e As EventArgs) Handles lblTabChangelog.Click
        Tab.SelectedTab = tabChangelog
    End Sub

    Private Sub LblContact_Click(sender As Object, e As EventArgs) Handles lblTabContact.Click
        Tab.SelectedTab = tabContact
    End Sub

    Private Sub LblAbout_MouseMove(sender As Object, e As MouseEventArgs) Handles lblTabContact.MouseMove, lblTabChangelog.MouseMove, lblTabLegal.MouseMove, lblTabFAQ.MouseMove, lblTabAbout.MouseMove
        sender.ForeColor = SelectedTabColour
    End Sub

    Private Sub LblAbout_MouseLeave(sender As Object, e As EventArgs) Handles lblTabContact.MouseLeave, lblTabChangelog.MouseLeave, lblTabLegal.MouseLeave, lblTabFAQ.MouseLeave, lblTabAbout.MouseLeave
        If sender IsNot CurrentTab Then sender.ForeColor = NonSelectedTabColour
    End Sub

    Dim CurrentTab As Object = lblTabAbout
    Dim SelectedTabColour As Color = Color.FromArgb(172, 180, 191)
    Dim NonSelectedTabColour As Color = Color.FromArgb(86, 98, 115)

    Private Sub Tab_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tab.SelectedIndexChanged
        If Tab.SelectedIndex = 0 Then
            CurrentTab = lblTabAbout
            lblTabAbout.ForeColor = SelectedTabColour
            lblTabLegal.ForeColor = NonSelectedTabColour
            lblTabFAQ.ForeColor = NonSelectedTabColour
            lblTabChangelog.ForeColor = NonSelectedTabColour
            lblTabContact.ForeColor = NonSelectedTabColour
        ElseIf Tab.SelectedIndex = 1 Then
            CurrentTab = lblTabLegal
            lblTabAbout.ForeColor = NonSelectedTabColour
            lblTabLegal.ForeColor = SelectedTabColour
            lblTabFAQ.ForeColor = NonSelectedTabColour
            lblTabChangelog.ForeColor = NonSelectedTabColour
            lblTabContact.ForeColor = NonSelectedTabColour
        ElseIf Tab.SelectedIndex = 2 Then
            CurrentTab = lblTabFAQ
            lblTabAbout.ForeColor = NonSelectedTabColour
            lblTabLegal.ForeColor = NonSelectedTabColour
            lblTabFAQ.ForeColor = SelectedTabColour
            lblTabChangelog.ForeColor = NonSelectedTabColour
            lblTabContact.ForeColor = NonSelectedTabColour
        ElseIf Tab.SelectedIndex = 3 Then
            CurrentTab = lblTabChangelog
            lblTabAbout.ForeColor = NonSelectedTabColour
            lblTabLegal.ForeColor = NonSelectedTabColour
            lblTabFAQ.ForeColor = NonSelectedTabColour
            lblTabChangelog.ForeColor = SelectedTabColour
            lblTabContact.ForeColor = NonSelectedTabColour
        ElseIf Tab.SelectedIndex = 4 Then
            CurrentTab = lblTabContact
            lblTabAbout.ForeColor = NonSelectedTabColour
            lblTabLegal.ForeColor = NonSelectedTabColour
            lblTabFAQ.ForeColor = NonSelectedTabColour
            lblTabChangelog.ForeColor = NonSelectedTabColour
            lblTabContact.ForeColor = SelectedTabColour
        End If
    End Sub

    'Data provider link
    Private Sub ImgProvider_Click(sender As Object, e As EventArgs)
        Process.Start("http://omdbapi.com/")
    End Sub

    'Share links
    Private Sub BtnShareTw_Click(sender As Object, e As EventArgs) Handles btnShareTwitter.Click
        Process.Start("https://twitter.com/intent/tweet?text=https://twitter.com/intent/tweet?url=http%3A%2F%2Fmovieo.info%2F&text=Watch%20and%20discover%20movies%20instantly%20with%20Movieo!%20Download%20it%20at%20&original_referer=")
    End Sub

    Private Sub BtnShareFb_Click(sender As Object, e As EventArgs) Handles btnShareFacebook.Click
        Process.Start("https://www.facebook.com/sharer/sharer.php?u=http://movieo.info")
    End Sub

    'Message submit button
    Private Sub BtnSubmitForm_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnSendMail.ClickButtonArea
        Process.Start("")
    End Sub

    'Social links 
    Private Sub lblSocialTwitter_Click(sender As Object, e As EventArgs) Handles lblSocialTwitter.Click
        Process.Start("http://twitter.com/invdevs")
    End Sub

    Private Sub lblSocialGitHub_Click(sender As Object, e As EventArgs) Handles lblSocialGitHub.Click
        Process.Start("https://github.com/ekkash/")
    End Sub

    Private Sub TabAbout_Scroll(sender As Object, e As ScrollEventArgs) Handles tabAbout.Scroll
        tabAbout.Update()
    End Sub

    Private Sub TabHelpFaq_Scroll(sender As Object, e As ScrollEventArgs) Handles tabHelpFaq.Scroll
        tabHelpFaq.Update()
    End Sub

    Private Sub TabLegal_Scroll(sender As Object, e As ScrollEventArgs) Handles tabLegal.Scroll
        tabLegal.Update()
    End Sub

    Private Sub TabChangelog_Scroll(sender As Object, e As ScrollEventArgs) Handles tabChangelog.Scroll
        tabChangelog.Update()
    End Sub

    Private Sub TabContact_Scroll(sender As Object, e As ScrollEventArgs) Handles tabContact.Scroll
        tabContact.Update()
    End Sub

#Region "DATA PROVIDERS"

    Private Sub imgProviderDropbox_Click(sender As Object, e As EventArgs) Handles imgProviderDropbox.Click
        Process.Start("https://dropbox.com")
    End Sub

    Private Sub imgProviderOMDbAPI_Click(sender As Object, e As EventArgs) Handles imgProviderOMDbAPI.Click
        Process.Start("https://omdbapi.com")
    End Sub

    Private Sub imgProviderPopcornTime_Click(sender As Object, e As EventArgs) Handles imgProviderPopcornTime.Click
        Process.Start("https://popcorntime.sh")
    End Sub

#End Region

End Class