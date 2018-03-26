Imports System.Windows.Forms

Public Class LFRepository

    Dim LFSOApp As New LFSO83Lib.LFApplication

    Dim LFServer As String
    Dim LFRepos As String

    Dim LFUser As String
    Dim LFPass As String

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Main.LFSettings.Clear()
        Main.LFSettings.Rows.Add("LFServer", txtLFServer.Text)
        Main.LFSettings.Rows.Add("LFRepos", cmbLFRepos.SelectedItem)
        Main.LFSettings.Rows.Add("LFUser", LFUser)
        Main.LFSettings.Rows.Add("LFPass", Main.EncryptPass(LFPass))

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub chkIntegratedSec_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIntegratedSec.CheckedChanged
        If chkIntegratedSec.Checked = True Then
            txtLFUser.Enabled = False
            txtLFPass.Enabled = False
        Else
            txtLFUser.Enabled = True
            txtLFPass.Enabled = True
        End If
    End Sub

    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click
        Dim LFServerObj As New LFSO83Lib.LFServer
        Dim LFReposObj As New LFSO83Lib.LFDatabase
        Dim LFConn As New LFSO83Lib.LFConnection

        Try
            If chkIntegratedSec.Checked = True Then
                LFUser = ""
                LFPass = ""
            Else
                LFUser = txtLFUser.Text
                LFPass = txtLFPass.Text
            End If

            LFServerObj = LFSOApp.GetServerByName(txtLFServer.Text)
            LFReposObj = LFServerObj.GetDatabaseByName(cmbLFRepos.SelectedItem)

            LFConn.UserName = LFUser
            LFConn.Password = LFPass
        Catch ex As Exception

        End Try

        Try
            LFConn.Create(LFReposObj)
            MsgBox("Connected Successfully!", MsgBoxStyle.Information, "Successful")
        Catch ex As Exception
            MsgBox("Connection Failed!" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Failed")
        End Try
    End Sub

    Private Sub cmbLFRepos_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmbLFRepos.MouseDown
        Try
            cmbLFRepos.Items.Clear()
            Dim LFServerObj As LFSO83Lib.LFServer = LFSOApp.GetServerByName(txtLFServer.Text)
            Dim AllRepos As LFSO83Lib.ILFCollection = LFServerObj.GetAllDatabases()

            Dim i As Integer = 1
            Do Until i > AllRepos.Count
                Dim DB As LFSO83Lib.LFDatabase = AllRepos.Item(i)
                cmbLFRepos.Items.Add(DB.Name)
                i = i + 1
            Loop
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LFRepository_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            txtLFServer.Text = Main.LFSettings.Select("Option = 'LFServer'")(0).Item("Value")
            cmbLFRepos.Items.Add(Main.LFSettings.Select("Option = 'LFRepos'")(0).Item("Value"))
            cmbLFRepos.SelectedItem = Main.LFSettings.Select("Option = 'LFRepos'")(0).Item("Value")
            txtLFUser.Text = Main.LFSettings.Select("Option = 'LFUser'")(0).Item("Value")
            txtLFPass.Text = Main.DecryptPass(Main.LFSettings.Select("Option = 'LFPass'")(0).Item("Value"))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtLFUser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLFUser.TextChanged
        LFUser = txtLFUser.Text
    End Sub

    Private Sub txtLFPass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLFPass.TextChanged
        LFPass = txtLFPass.Text
    End Sub


End Class
