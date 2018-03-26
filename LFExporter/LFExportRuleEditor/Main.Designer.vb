<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewRuleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LaserFicheSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RulesGrid = New System.Windows.Forms.DataGridView
        Me.Settings = New System.Data.DataSet
        Me.LFSettings = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.ExportRules = New System.Data.DataTable
        Me.RuleName = New System.Data.DataColumn
        Me.SearchString = New System.Data.DataColumn
        Me.ExportType = New System.Data.DataColumn
        Me.ExportPath = New System.Data.DataColumn
        Me.MenuStrip1.SuspendLayout()
        CType(Me.RulesGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Settings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LFSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportRules, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(581, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewRuleToolStripMenuItem, Me.SaveSettingsToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewRuleToolStripMenuItem
        '
        Me.NewRuleToolStripMenuItem.Name = "NewRuleToolStripMenuItem"
        Me.NewRuleToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.NewRuleToolStripMenuItem.Text = "New Rule"
        '
        'SaveSettingsToolStripMenuItem
        '
        Me.SaveSettingsToolStripMenuItem.Name = "SaveSettingsToolStripMenuItem"
        Me.SaveSettingsToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.SaveSettingsToolStripMenuItem.Text = "Save Settings"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(137, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaserFicheSettingsToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'LaserFicheSettingsToolStripMenuItem
        '
        Me.LaserFicheSettingsToolStripMenuItem.Name = "LaserFicheSettingsToolStripMenuItem"
        Me.LaserFicheSettingsToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.LaserFicheSettingsToolStripMenuItem.Text = "LaserFiche Settings"
        '
        'RulesGrid
        '
        Me.RulesGrid.AllowUserToAddRows = False
        Me.RulesGrid.AllowUserToOrderColumns = True
        Me.RulesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RulesGrid.Location = New System.Drawing.Point(0, 27)
        Me.RulesGrid.Name = "RulesGrid"
        Me.RulesGrid.Size = New System.Drawing.Size(581, 412)
        Me.RulesGrid.TabIndex = 1
        '
        'Settings
        '
        Me.Settings.DataSetName = "Settings"
        Me.Settings.Tables.AddRange(New System.Data.DataTable() {Me.LFSettings, Me.ExportRules})
        '
        'LFSettings
        '
        Me.LFSettings.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2})
        Me.LFSettings.TableName = "LFSettings"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Option"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Value"
        '
        'ExportRules
        '
        Me.ExportRules.Columns.AddRange(New System.Data.DataColumn() {Me.RuleName, Me.SearchString, Me.ExportType, Me.ExportPath})
        Me.ExportRules.TableName = "ExportRules"
        '
        'RuleName
        '
        Me.RuleName.Caption = "Rule Name"
        Me.RuleName.ColumnName = "RuleName"
        '
        'SearchString
        '
        Me.SearchString.Caption = "Search String"
        Me.SearchString.ColumnName = "SearchString"
        '
        'ExportType
        '
        Me.ExportType.Caption = "Export Type"
        Me.ExportType.ColumnName = "ExportType"
        '
        'ExportPath
        '
        Me.ExportPath.Caption = "Export Type"
        Me.ExportPath.ColumnName = "ExportPath"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 440)
        Me.Controls.Add(Me.RulesGrid)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "LaserFiche Exporter Rule Editor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.RulesGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Settings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LFSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportRules, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewRuleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaserFicheSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RulesGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Settings As System.Data.DataSet
    Friend WithEvents LFSettings As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents ExportRules As System.Data.DataTable
    Friend WithEvents RuleName As System.Data.DataColumn
    Friend WithEvents SearchString As System.Data.DataColumn
    Friend WithEvents ExportType As System.Data.DataColumn
    Friend WithEvents ExportPath As System.Data.DataColumn
    Friend WithEvents SaveSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
