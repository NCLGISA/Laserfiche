<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRule
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
        Me.txtRuleName = New System.Windows.Forms.TextBox
        Me.txtSearchString = New System.Windows.Forms.TextBox
        Me.cmbExportFormat = New System.Windows.Forms.ComboBox
        Me.txtExportPath = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnOpen = New System.Windows.Forms.Button
        Me.OpenFolder = New System.Windows.Forms.FolderBrowserDialog
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(179, 251)
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
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Add"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'txtRuleName
        '
        Me.txtRuleName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtRuleName.Location = New System.Drawing.Point(111, 15)
        Me.txtRuleName.Name = "txtRuleName"
        Me.txtRuleName.Size = New System.Drawing.Size(211, 20)
        Me.txtRuleName.TabIndex = 1
        '
        'txtSearchString
        '
        Me.txtSearchString.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSearchString.Location = New System.Drawing.Point(111, 61)
        Me.txtSearchString.Multiline = True
        Me.txtSearchString.Name = "txtSearchString"
        Me.txtSearchString.Size = New System.Drawing.Size(211, 61)
        Me.txtSearchString.TabIndex = 2
        '
        'cmbExportFormat
        '
        Me.cmbExportFormat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbExportFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbExportFormat.FormattingEnabled = True
        Me.cmbExportFormat.Items.AddRange(New Object() {"TIFF", "PNG", "PDF - Many to 1", "PDF - 1 to 1"})
        Me.cmbExportFormat.Location = New System.Drawing.Point(111, 153)
        Me.cmbExportFormat.Name = "cmbExportFormat"
        Me.cmbExportFormat.Size = New System.Drawing.Size(175, 21)
        Me.cmbExportFormat.TabIndex = 3
        '
        'txtExportPath
        '
        Me.txtExportPath.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtExportPath.Location = New System.Drawing.Point(111, 200)
        Me.txtExportPath.Name = "txtExportPath"
        Me.txtExportPath.Size = New System.Drawing.Size(211, 20)
        Me.txtExportPath.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Rule Name:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "LF Search String:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Export Format:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Export Path:"
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(328, 198)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(26, 23)
        Me.btnOpen.TabIndex = 9
        Me.btnOpen.Text = "..."
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'AddRule
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(366, 292)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtExportPath)
        Me.Controls.Add(Me.cmbExportFormat)
        Me.Controls.Add(Me.txtSearchString)
        Me.Controls.Add(Me.txtRuleName)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddRule"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add New Rule"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents txtRuleName As System.Windows.Forms.TextBox
    Friend WithEvents txtSearchString As System.Windows.Forms.TextBox
    Friend WithEvents cmbExportFormat As System.Windows.Forms.ComboBox
    Friend WithEvents txtExportPath As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents OpenFolder As System.Windows.Forms.FolderBrowserDialog

End Class
