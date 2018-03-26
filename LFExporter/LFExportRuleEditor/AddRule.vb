Imports System.Windows.Forms

Public Class AddRule

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If txtRuleName.Text = "" Then
            MsgBox("A rule must have a Name", MsgBoxStyle.Critical, "Error Adding Rule")
            Exit Sub
        End If

        If txtSearchString.Text = "" Then
            MsgBox("A rule must have a Search String", MsgBoxStyle.Critical, "Error Adding Rule")
            Exit Sub
        End If

        If cmbExportFormat.SelectedItem = "" Then
            MsgBox("A rule must have a Export Format", MsgBoxStyle.Critical, "Error Adding Rule")
            Exit Sub
        End If

        If txtExportPath.Text = "" Then
            MsgBox("A rule must have a Export Path", MsgBoxStyle.Critical, "Error Adding Rule")
            Exit Sub
        End If

        Main.ExportRules.Rows.Add(txtRuleName.Text, txtSearchString.Text, cmbExportFormat.SelectedItem, txtExportPath.Text)

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        OpenFolder.ShowDialog()
        If OpenFolder.SelectedPath <> "" Then
            txtExportPath.Text = OpenFolder.SelectedPath
        End If
    End Sub
End Class
