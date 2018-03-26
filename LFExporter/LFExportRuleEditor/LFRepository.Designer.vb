<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LFRepository
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtLFServer = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtLFUser = New System.Windows.Forms.TextBox
        Me.txtLFPass = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.chkIntegratedSec = New System.Windows.Forms.CheckBox
        Me.btnTest = New System.Windows.Forms.Button
        Me.cmbLFRepos = New System.Windows.Forms.ComboBox
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(176, 207)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 9
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 10
        Me.Cancel_Button.Text = "Cancel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LaserFiche Server:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "LaserFiche Repository:"
        '
        'txtLFServer
        '
        Me.txtLFServer.Location = New System.Drawing.Point(133, 26)
        Me.txtLFServer.Name = "txtLFServer"
        Me.txtLFServer.Size = New System.Drawing.Size(189, 20)
        Me.txtLFServer.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "LaserFiche Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "LaserFiche User:"
        '
        'txtLFUser
        '
        Me.txtLFUser.Location = New System.Drawing.Point(133, 125)
        Me.txtLFUser.Name = "txtLFUser"
        Me.txtLFUser.Size = New System.Drawing.Size(189, 20)
        Me.txtLFUser.TabIndex = 5
        '
        'txtLFPass
        '
        Me.txtLFPass.Location = New System.Drawing.Point(133, 156)
        Me.txtLFPass.Name = "txtLFPass"
        Me.txtLFPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtLFPass.Size = New System.Drawing.Size(189, 20)
        Me.txtLFPass.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(234, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Using a LaserFiche user is highly recommended."
        '
        'chkIntegratedSec
        '
        Me.chkIntegratedSec.AutoSize = True
        Me.chkIntegratedSec.Location = New System.Drawing.Point(15, 185)
        Me.chkIntegratedSec.Name = "chkIntegratedSec"
        Me.chkIntegratedSec.Size = New System.Drawing.Size(141, 17)
        Me.chkIntegratedSec.TabIndex = 7
        Me.chkIntegratedSec.Text = "Windows Authentication"
        Me.chkIntegratedSec.UseVisualStyleBackColor = True
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(15, 210)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(108, 23)
        Me.btnTest.TabIndex = 8
        Me.btnTest.Text = "Test Connection"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'cmbLFRepos
        '
        Me.cmbLFRepos.FormattingEnabled = True
        Me.cmbLFRepos.Location = New System.Drawing.Point(133, 61)
        Me.cmbLFRepos.Name = "cmbLFRepos"
        Me.cmbLFRepos.Size = New System.Drawing.Size(191, 21)
        Me.cmbLFRepos.TabIndex = 4
        '
        'LFRepository
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(336, 248)
        Me.Controls.Add(Me.cmbLFRepos)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.chkIntegratedSec)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLFPass)
        Me.Controls.Add(Me.txtLFUser)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLFServer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LFRepository"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "LaserFiche Repository"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLFServer As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLFUser As System.Windows.Forms.TextBox
    Friend WithEvents txtLFPass As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkIntegratedSec As System.Windows.Forms.CheckBox
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents cmbLFRepos As System.Windows.Forms.ComboBox

End Class
