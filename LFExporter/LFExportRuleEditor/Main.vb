Public Class Main

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Settings.ReadXml("Settings.xml")
        Catch ex As Exception
            LFRepository.ShowDialog()
            Settings.WriteXml("Settings.xml")
        End Try
        RulesGrid.DataSource = ExportRules
    End Sub

    Private Sub LaserFicheSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaserFicheSettingsToolStripMenuItem.Click
        LFRepository.ShowDialog()
    End Sub

    Private Sub NewRuleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewRuleToolStripMenuItem.Click
        AddRule.txtRuleName.Text = ""
        AddRule.txtSearchString.Text = ""
        AddRule.txtExportPath.Text = ""
        AddRule.ShowDialog()
        RulesGrid.Refresh()
    End Sub

    Private Sub SaveSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveSettingsToolStripMenuItem.Click
        Settings.WriteXml("Settings.xml")
    End Sub

    Public Function EncryptPass(ByVal clearText As String)
        Dim SYM As New Encryption.Symmetric(Encryption.Symmetric.Provider.TripleDES)
        Dim KEY As New Encryption.Data("laserfiche")
        Dim encryptedData As Encryption.Data
        encryptedData = SYM.Encrypt(New Encryption.Data(clearText), KEY)
        Dim encryptedPass As String = encryptedData.ToString
        Return encryptedPass
    End Function

    Public Function DecryptPass(ByVal encrpytedString As String)
        Dim sym As New Encryption.Symmetric(Encryption.Symmetric.Provider.TripleDES)
        Dim key As New Encryption.Data("laserfiche")
        Dim encryptedData As New Encryption.Data
        encryptedData.Text = encrpytedString
        Dim decryptedData As Encryption.Data
        decryptedData = sym.Decrypt(encryptedData, key)
        Return decryptedData.ToString
    End Function
End Class
