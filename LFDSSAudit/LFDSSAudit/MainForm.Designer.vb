<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.gpbExportTo = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.chkCombineOne = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnAbort = New System.Windows.Forms.Button
        Me.lstFileType = New System.Windows.Forms.ListBox
        Me.FileSavePathBtn = New System.Windows.Forms.Button
        Me.txtFolderLoc = New System.Windows.Forms.TextBox
        Me.btnStart = New System.Windows.Forms.Button
        Me.radFile = New System.Windows.Forms.RadioButton
        Me.radPrinter = New System.Windows.Forms.RadioButton
        Me.txtCaseNumber = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnReset = New System.Windows.Forms.Button
        Me.mstFileMenu = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.menuHowTo = New System.Windows.Forms.ToolStripMenuItem
        Me.menuAbout = New System.Windows.Forms.ToolStripMenuItem
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.tssStatus = New System.Windows.Forms.ToolStripStatusLabel
        Me.tspProgress = New System.Windows.Forms.ToolStripProgressBar
        Me.AxAdobe = New AxAcroPDFLib.AxAcroPDF
        Me.StartDate = New System.Windows.Forms.DateTimePicker
        Me.chkSearchDate = New System.Windows.Forms.CheckBox
        Me.EndDate = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.radSpecificDate = New System.Windows.Forms.RadioButton
        Me.radDateRange = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.ProgramType = New System.Windows.Forms.ComboBox
        Me.DS = New System.Data.DataSet
        Me.gpbExportTo.SuspendLayout()
        Me.mstFileMenu.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.AxAdobe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpbExportTo
        '
        Me.gpbExportTo.Controls.Add(Me.Label8)
        Me.gpbExportTo.Controls.Add(Me.chkCombineOne)
        Me.gpbExportTo.Controls.Add(Me.Label4)
        Me.gpbExportTo.Controls.Add(Me.Label3)
        Me.gpbExportTo.Controls.Add(Me.btnAbort)
        Me.gpbExportTo.Controls.Add(Me.lstFileType)
        Me.gpbExportTo.Controls.Add(Me.FileSavePathBtn)
        Me.gpbExportTo.Controls.Add(Me.txtFolderLoc)
        Me.gpbExportTo.Controls.Add(Me.btnStart)
        Me.gpbExportTo.Controls.Add(Me.radFile)
        Me.gpbExportTo.Controls.Add(Me.radPrinter)
        Me.gpbExportTo.Location = New System.Drawing.Point(15, 207)
        Me.gpbExportTo.Name = "gpbExportTo"
        Me.gpbExportTo.Size = New System.Drawing.Size(508, 168)
        Me.gpbExportTo.TabIndex = 0
        Me.gpbExportTo.TabStop = False
        Me.gpbExportTo.Text = "Send Documents To"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(69, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 26)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Click here to see the help" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "regarding printing."
        '
        'chkCombineOne
        '
        Me.chkCombineOne.AutoSize = True
        Me.chkCombineOne.Location = New System.Drawing.Point(240, 118)
        Me.chkCombineOne.Name = "chkCombineOne"
        Me.chkCombineOne.Size = New System.Drawing.Size(184, 17)
        Me.chkCombineOne.TabIndex = 8
        Me.chkCombineOne.Text = "Combine Into One File (PDF Only)"
        Me.chkCombineOne.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "File Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Folder Location"
        '
        'btnAbort
        '
        Me.btnAbort.Enabled = False
        Me.btnAbort.Location = New System.Drawing.Point(402, 14)
        Me.btnAbort.Name = "btnAbort"
        Me.btnAbort.Size = New System.Drawing.Size(100, 23)
        Me.btnAbort.TabIndex = 10
        Me.btnAbort.Text = "Abort Export"
        Me.btnAbort.UseVisualStyleBackColor = True
        '
        'lstFileType
        '
        Me.lstFileType.FormattingEnabled = True
        Me.lstFileType.Items.AddRange(New Object() {"Adobe PDF (recomended)", "TIFF", "JPG"})
        Me.lstFileType.Location = New System.Drawing.Point(69, 118)
        Me.lstFileType.Name = "lstFileType"
        Me.lstFileType.Size = New System.Drawing.Size(154, 43)
        Me.lstFileType.TabIndex = 5
        '
        'FileSavePathBtn
        '
        Me.FileSavePathBtn.Location = New System.Drawing.Point(273, 78)
        Me.FileSavePathBtn.Name = "FileSavePathBtn"
        Me.FileSavePathBtn.Size = New System.Drawing.Size(32, 20)
        Me.FileSavePathBtn.TabIndex = 4
        Me.FileSavePathBtn.Text = "..."
        Me.FileSavePathBtn.UseVisualStyleBackColor = True
        '
        'txtFolderLoc
        '
        Me.txtFolderLoc.Location = New System.Drawing.Point(69, 78)
        Me.txtFolderLoc.Name = "txtFolderLoc"
        Me.txtFolderLoc.Size = New System.Drawing.Size(198, 20)
        Me.txtFolderLoc.TabIndex = 3
        '
        'btnStart
        '
        Me.btnStart.Enabled = False
        Me.btnStart.Location = New System.Drawing.Point(402, 53)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(100, 23)
        Me.btnStart.TabIndex = 8
        Me.btnStart.Text = "Start Export"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'radFile
        '
        Me.radFile.AutoSize = True
        Me.radFile.Location = New System.Drawing.Point(7, 59)
        Me.radFile.Name = "radFile"
        Me.radFile.Size = New System.Drawing.Size(41, 17)
        Me.radFile.TabIndex = 1
        Me.radFile.TabStop = True
        Me.radFile.Text = "File"
        Me.radFile.UseVisualStyleBackColor = True
        '
        'radPrinter
        '
        Me.radPrinter.AutoSize = True
        Me.radPrinter.Location = New System.Drawing.Point(7, 20)
        Me.radPrinter.Name = "radPrinter"
        Me.radPrinter.Size = New System.Drawing.Size(55, 17)
        Me.radPrinter.TabIndex = 0
        Me.radPrinter.TabStop = True
        Me.radPrinter.Text = "Printer"
        Me.radPrinter.UseVisualStyleBackColor = True
        '
        'txtCaseNumber
        '
        Me.txtCaseNumber.Location = New System.Drawing.Point(122, 32)
        Me.txtCaseNumber.MaxLength = 6
        Me.txtCaseNumber.Name = "txtCaseNumber"
        Me.txtCaseNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtCaseNumber.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "County Case Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Program Type:"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(417, 25)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 23)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'mstFileMenu
        '
        Me.mstFileMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.mstFileMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mstFileMenu.Location = New System.Drawing.Point(0, 0)
        Me.mstFileMenu.Name = "mstFileMenu"
        Me.mstFileMenu.Size = New System.Drawing.Size(540, 24)
        Me.mstFileMenu.TabIndex = 9
        Me.mstFileMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuHowTo, Me.menuAbout})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'menuHowTo
        '
        Me.menuHowTo.Name = "menuHowTo"
        Me.menuHowTo.Size = New System.Drawing.Size(138, 22)
        Me.menuHowTo.Text = "How To Use"
        '
        'menuAbout
        '
        Me.menuAbout.Name = "menuAbout"
        Me.menuAbout.Size = New System.Drawing.Size(138, 22)
        Me.menuAbout.Text = "About"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssStatus, Me.tspProgress})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 392)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(540, 22)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssStatus
        '
        Me.tssStatus.AutoSize = False
        Me.tssStatus.BackColor = System.Drawing.SystemColors.Control
        Me.tssStatus.Name = "tssStatus"
        Me.tssStatus.Size = New System.Drawing.Size(420, 17)
        Me.tssStatus.Text = "Please complete the information above..."
        Me.tssStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tspProgress
        '
        Me.tspProgress.Maximum = 10000
        Me.tspProgress.Name = "tspProgress"
        Me.tspProgress.Size = New System.Drawing.Size(100, 16)
        '
        'AxAdobe
        '
        Me.AxAdobe.Enabled = True
        Me.AxAdobe.Location = New System.Drawing.Point(12, 110)
        Me.AxAdobe.Name = "AxAdobe"
        Me.AxAdobe.OcxState = CType(resources.GetObject("AxAdobe.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAdobe.Size = New System.Drawing.Size(102, 39)
        Me.AxAdobe.TabIndex = 12
        Me.AxAdobe.Visible = False
        '
        'StartDate
        '
        Me.StartDate.Location = New System.Drawing.Point(309, 108)
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Size = New System.Drawing.Size(200, 20)
        Me.StartDate.TabIndex = 13
        '
        'chkSearchDate
        '
        Me.chkSearchDate.AutoSize = True
        Me.chkSearchDate.Location = New System.Drawing.Point(14, 19)
        Me.chkSearchDate.Name = "chkSearchDate"
        Me.chkSearchDate.Size = New System.Drawing.Size(100, 17)
        Me.chkSearchDate.TabIndex = 14
        Me.chkSearchDate.Text = "Search by Date"
        Me.chkSearchDate.UseVisualStyleBackColor = True
        '
        'EndDate
        '
        Me.EndDate.Location = New System.Drawing.Point(309, 148)
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Size = New System.Drawing.Size(200, 20)
        Me.EndDate.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(306, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Date/Start Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(306, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "End Date"
        '
        'radSpecificDate
        '
        Me.radSpecificDate.AutoSize = True
        Me.radSpecificDate.Location = New System.Drawing.Point(125, 19)
        Me.radSpecificDate.Name = "radSpecificDate"
        Me.radSpecificDate.Size = New System.Drawing.Size(89, 17)
        Me.radSpecificDate.TabIndex = 18
        Me.radSpecificDate.TabStop = True
        Me.radSpecificDate.Text = "Specific Date"
        Me.radSpecificDate.UseVisualStyleBackColor = True
        '
        'radDateRange
        '
        Me.radDateRange.AutoSize = True
        Me.radDateRange.Location = New System.Drawing.Point(125, 38)
        Me.radDateRange.Name = "radDateRange"
        Me.radDateRange.Size = New System.Drawing.Size(83, 17)
        Me.radDateRange.TabIndex = 19
        Me.radDateRange.TabStop = True
        Me.radDateRange.Text = "Date Range"
        Me.radDateRange.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.radDateRange)
        Me.GroupBox1.Controls.Add(Me.chkSearchDate)
        Me.GroupBox1.Controls.Add(Me.radSpecificDate)
        Me.GroupBox1.Location = New System.Drawing.Point(295, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 155)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.DarkRed
        Me.Label7.Location = New System.Drawing.Point(45, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 26)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Click here to see the help" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "regarding date searches."
        '
        'ProgramType
        '
        Me.ProgramType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProgramType.FormattingEnabled = True
        Me.ProgramType.Location = New System.Drawing.Point(120, 71)
        Me.ProgramType.MaxDropDownItems = 20
        Me.ProgramType.Name = "ProgramType"
        Me.ProgramType.Size = New System.Drawing.Size(162, 21)
        Me.ProgramType.TabIndex = 18
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(540, 414)
        Me.Controls.Add(Me.ProgramType)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.EndDate)
        Me.Controls.Add(Me.StartDate)
        Me.Controls.Add(Me.AxAdobe)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.mstFileMenu)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCaseNumber)
        Me.Controls.Add(Me.gpbExportTo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Randolph County DSS Auditor Tool"
        Me.gpbExportTo.ResumeLayout(False)
        Me.gpbExportTo.PerformLayout()
        Me.mstFileMenu.ResumeLayout(False)
        Me.mstFileMenu.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.AxAdobe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gpbExportTo As System.Windows.Forms.GroupBox
    Friend WithEvents radPrinter As System.Windows.Forms.RadioButton
    Friend WithEvents FileSavePathBtn As System.Windows.Forms.Button
    Friend WithEvents txtFolderLoc As System.Windows.Forms.TextBox
    Friend WithEvents radFile As System.Windows.Forms.RadioButton
    Friend WithEvents txtCaseNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lstFileType As System.Windows.Forms.ListBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mstFileMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAbort As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tssStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tspProgress As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents menuHowTo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkCombineOne As System.Windows.Forms.CheckBox
    Friend WithEvents AxAdobe As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents StartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkSearchDate As System.Windows.Forms.CheckBox
    Friend WithEvents EndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents radSpecificDate As System.Windows.Forms.RadioButton
    Friend WithEvents radDateRange As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents menuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ProgramType As System.Windows.Forms.ComboBox
    Friend WithEvents DS As System.Data.DataSet

End Class
