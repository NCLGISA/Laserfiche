Public Class MainForm

    Dim ProgramReady As Boolean
    Dim CaseReady As Boolean

    Dim TempPDFPath As String
    Dim TempPath As String = System.IO.Path.GetTempPath

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            DS.ReadXml("Settings.xml")
            With ProgramType
                .DataSource = DS.Tables(0)
                .DisplayMember = "pretty_name"
                .ValueMember = "search_command"
                .SelectedIndex = 0
            End With
        Catch ex As Exception
            If System.IO.File.Exists(My.Settings.UpdatePath & "\Settings.xml") = True Then
                Dim Caught As Boolean = False
                Try
                    System.IO.File.Copy(My.Settings.UpdatePath & "\Settings.xml", "Settings.xml", False)
                Catch ex2 As Exception
                    MsgBox("Your searches XML file could not be found and an attempt to update has failed!" & vbCrLf & "If the problem persists, please contact your systems administrator." & vbCrLf & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Error Updating Searches")
                    Caught = True
                End Try
                If Caught = False Then
                    MsgBox("Your searches XML file could not be found so one was taken from your update location.", MsgBoxStyle.Information, "Updated Searches")
                    DS.ReadXml("Settings.xml")
                    With ProgramType
                        .DataSource = DS.Tables(0)
                        .DisplayMember = "pretty_name"
                        .ValueMember = "search_command"
                        .SelectedIndex = 0
                    End With
                End If
            Else
                MsgBox("No search settings were found.  Go to Settings and create some, or contact the systems administrator.", MsgBoxStyle.Critical, "No Settings Found")
                Dim TempTable As New Data.DataTable("search_settings")
                Dim TempColum1 As New System.Data.DataColumn("pretty_name")
                TempColum1.DataType = System.Type.GetType("System.String")
                TempTable.Columns.Add(TempColum1)
                Dim TempColum2 As New System.Data.DataColumn("search_command")
                TempColum2.DataType = System.Type.GetType("System.String")
                TempTable.Columns.Add(TempColum2)

                DS.Tables.Add(TempTable)
            End If

        End Try

        lstFileType.SelectedIndex = 0

        txtFolderLoc.Text = TempPath
        StartDate.Enabled = False
        EndDate.Enabled = False

        radSpecificDate.Enabled = False
        radDateRange.Enabled = False

        If System.Diagnostics.Debugger.IsAttached = False Then
            About.labVersion.Text = My.Application.Info.Version.ToString
        Else
            About.labVersion.Text = "Debug Mode"
        End If

    End Sub

    Private Sub CheckForCompleted()
        If CaseReady = True And ProgramReady = True Then
            btnStart.Enabled = True
        Else
            btnStart.Enabled = False
        End If
    End Sub

    Private Sub FileSavePathBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileSavePathBtn.Click
        FolderBrowserDialog1.ShowDialog()
        If FolderBrowserDialog1.SelectedPath = "" Then
            txtFolderLoc.Text = TempPath
        Else
            txtFolderLoc.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub txtFolderLoc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFolderLoc.TextChanged
        radFile.Select()
    End Sub

    Private Sub cboInstalledPrinters_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        radPrinter.Select()
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        lstFileType.SelectedIndex = 0

        Dim TempPath As String = System.IO.Path.GetTempPath
        txtFolderLoc.Text = TempPath

        CaseReady = False
        ProgramReady = False

        txtCaseNumber.Text = ""
        ProgramType.SelectedIndex = -1
        tssStatus.Text = "Please complete the information above..."

        StartDate.Enabled = False
        EndDate.Enabled = False

        radSpecificDate.Enabled = False
        radDateRange.Enabled = False

        chkSearchDate.Checked = False
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Dim strSearchCommand As String = ""
        If chkSearchDate.Checked = True Then
            If radSpecificDate.Checked = True Then
                strSearchCommand = Replace(ProgramType.SelectedValue, "~CASENUMBER~", """" & txtCaseNumber.Text & """,[Date]=""" & StartDate.Value.Date.ToShortDateString & """")
            ElseIf radDateRange.Checked = True Then
                strSearchCommand = Replace(ProgramType.SelectedValue, "~CASENUMBER~", """" & txtCaseNumber.Text & """,[Date]>=""" & StartDate.Value.Date.ToShortDateString & """,[Date]<=""" & EndDate.Value.Date.ToShortDateString & """")
            End If
        Else
            strSearchCommand = Replace(ProgramType.SelectedValue, "~CASENUMBER~", """" & txtCaseNumber.Text & """")
        End If
        If radFile.Checked = True Then
            If chkCombineOne.Checked = True Then
                BackgroundWorker1.RunWorkerAsync(New Object() {0, txtFolderLoc.Text.ToString, lstFileType.SelectedIndex, strSearchCommand, True, txtCaseNumber.Text})
            Else
                BackgroundWorker1.RunWorkerAsync(New Object() {0, txtFolderLoc.Text.ToString, lstFileType.SelectedIndex, strSearchCommand, False, txtCaseNumber.Text})
            End If
        ElseIf radPrinter.Checked = True Then
            BackgroundWorker1.RunWorkerAsync(New Object() {1, "", 0, strSearchCommand, False, txtCaseNumber.Text})
        End If

        tssStatus.Text = "Searching LaserFiche, this may take several minutes!"

        btnStart.Enabled = False
        btnReset.Enabled = False
        btnAbort.Enabled = True

        lstFileType.Enabled = False
        txtCaseNumber.Enabled = False
        ProgramType.Enabled = False

        StartDate.Enabled = False
        EndDate.Enabled = False

        radSpecificDate.Enabled = False
        radDateRange.Enabled = False

        radSpecificDate.Enabled = False
        radDateRange.Enabled = False

        chkSearchDate.Enabled = False

        radFile.Enabled = False
        radPrinter.Enabled = False

        txtFolderLoc.Enabled = False
        chkCombineOne.Enabled = False

        FileSavePathBtn.Enabled = False

    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim BW As System.ComponentModel.BackgroundWorker = CType(sender, System.ComponentModel.BackgroundWorker)
        Dim ARGS As Object() = DirectCast(e.Argument, Object())

        Dim ARG1 As Integer = CInt(ARGS(0))
        Dim ARG2 As String = CStr(ARGS(1))
        Dim ARG3 As Integer = CInt(ARGS(2))
        Dim ARG4 As String = CStr(ARGS(3))
        Dim ARG5 As Boolean = ARGS(4)
        Dim ARG6 As String = CStr(ARGS(5))

        e.Result = ProcessSelection(BW, ARG1, ARG2, ARG3, ARG4, ARG5, ARG6)
    End Sub

    Public Function ProcessSelection(ByVal BW As System.ComponentModel.BackgroundWorker, _
        ByVal ExportTo As Integer, ByVal ExportPath As String, ByVal ExportFileType As Integer, ByVal SearchCommand As String, ByVal OneFile As Boolean, ByVal CaseNumber As String)
        ' Creates a new LFApplication object.
        Dim LFApp As LFSO83Lib.LFApplication = New LFSO83Lib.LFApplication
        ' Finds the LFAppropriate LFServerer.
        Dim LFServer As LFSO83Lib.LFServer = LFApp.GetServerByName("RCIMAGE02")
        ' Gets the repository from the LFServerer.
        Dim LFDB As LFSO83Lib.LFDatabase = LFServer.GetDatabaseByName("Randolph-County-Records")
        ' Creates a new LFConnection object.
        Dim LFConn As New LFSO83Lib.LFConnection
        ' Sets the user name and password.
        LFConn.UserName = ""
        LFConn.Password = ""
        ' LFConnects to repository.
        LFConn.Create(LFDB)


        ' Gets a search object from the repository.
        Dim NewSearch As LFSO83Lib.LFSearch = LFDB.CreateSearch()
        ' Defines the word the search will look for.
        NewSearch.Command = SearchCommand
        ' Starts searching. 
        'NewSearch.BeginSearch(True)
        NewSearch.BeginSearch(False)
        ' Loops while the search is in progress.
        While NewSearch.SearchStatus = LFSO83Lib.Search_Status.SEARCH_STATUS_IN_PROGRESS
            If BW.CancellationPending = True Then
                LFConn.Terminate()
                Return 1
                Exit Function
            End If
            ' Updates on each loop.
            NewSearch.UpdateSearchStatus()
        End While

        ' Gets the search hits (instances of the word). 
        Dim AllHits As LFSO83Lib.ILFCollection = NewSearch.GetSearchHits()
        BW.ReportProgress(0, New Object() {1, AllHits.Count.ToString})
        If AllHits.Count = 0 Then
            LFConn.Terminate()
            Return 2
        End If
        Dim ProgressStep As Integer = 10000 / AllHits.Count
        Dim PDFFiles As New ArrayList
        For i As Integer = 1 To AllHits.Count

            If BW.CancellationPending = True Then
                LFConn.Terminate()
                Return 1
                Exit Function
            End If

            Dim Hit As LFSO83Lib.LFSearchHit = AllHits.Item(i)
            Dim EntryHit As LFSO83Lib.ILFEntry = Hit.Entry


            If ExportTo = 0 Then
                If OneFile = True Then
                    Dim Exporter As New PdfExporter83.PdfExporter
                    Dim LFDoc As LFSO83Lib.LFDocument = LFDB.GetEntryByID(EntryHit.ID)

                    Dim FileExt As String = ".pdf"

                    Dim strFileName As String = EntryHit.ID
                    Dim PDFTempFilePath As String = System.IO.Path.GetTempPath & strFileName & FileExt

                    Try
                        Dim Arr() As Byte = Exporter.ExportPages(LFDoc)
                        Dim Pdf As New IO.FileStream(PDFTempFilePath, IO.FileMode.Create)
                        Pdf.Write(Arr, 0, Arr.Length)
                        Pdf.Close()
                    Catch ex As Exception

                    End Try


                    BW.ReportProgress(ProgressStep, New Object() {0, ""})
                    PDFFiles.Add(PDFTempFilePath.ToString)
                Else
                    Dim FileExt As String = ""
                    Select Case ExportFileType
                        Case 0
                            Dim Exporter As New PdfExporter83.PdfExporter
                            Dim LFDoc As LFSO83Lib.LFDocument = LFDB.GetEntryByID(EntryHit.ID)
                            FileExt = ".pdf"
                            Dim strFileName As String = Replace(EntryHit.Name, "/", "-") & "-" & EntryHit.ID
                            Dim PDFFilePath As String = ExportPath & "\" & strFileName & FileExt
                            Try
                                Dim Arr() As Byte = Exporter.ExportPages(LFDoc)
                                Dim Pdf As New IO.FileStream(PDFFilePath, IO.FileMode.Create)
                                Pdf.Write(Arr, 0, Arr.Length)
                                Pdf.Close()
                            Catch ex As Exception

                            End Try
                        Case 1
                            Dim Exporter As New DocumentProcessor83.DocumentExporter
                            Exporter.SourceDocument = LFDB.GetEntryByID(EntryHit.ID)
                            Exporter.Format = DocumentProcessor83.Document_Format.DOCUMENT_FORMAT_TIFFG4
                            FileExt = ".tif"
                            Dim strFileName As String = Replace(EntryHit.Name, "/", "-") & "-" & EntryHit.ID
                            Dim PDFFilePath As String = ExportPath & "\" & strFileName & FileExt
                            Exporter.ExportToFile(PDFFilePath)
                        Case 2
                            Dim Exporter As New DocumentProcessor83.DocumentExporter
                            Exporter.SourceDocument = LFDB.GetEntryByID(EntryHit.ID)
                            Exporter.Format = DocumentProcessor83.Document_Format.DOCUMENT_FORMAT_JPEG
                            FileExt = ".jpg"
                            Dim strFileName As String = Replace(EntryHit.Name, "/", "-") & "-" & EntryHit.ID
                            Dim PDFFilePath As String = ExportPath & "\" & strFileName & FileExt
                            Exporter.ExportToFile(PDFFilePath)
                    End Select
                    
                    BW.ReportProgress(ProgressStep, New Object() {0, ""})
                End If
            End If

            If ExportTo = 1 Then
                Dim Exporter As New PdfExporter83.PdfExporter
                Dim LFDoc As LFSO83Lib.LFDocument = LFDB.GetEntryByID(EntryHit.ID)

                Dim FileExt As String = ".pdf"

                Dim strFileName As String = EntryHit.ID
                Dim PDFTempFilePath As String = System.IO.Path.GetTempPath & strFileName & FileExt

                Try
                    Dim Arr() As Byte = Exporter.ExportPages(LFDoc)
                    Dim Pdf As New IO.FileStream(PDFTempFilePath, IO.FileMode.Create)
                    Pdf.Write(Arr, 0, Arr.Length)
                    Pdf.Close()
                Catch ex As Exception

                End Try

                PDFFiles.Add(PDFTempFilePath.ToString)
                BW.ReportProgress(ProgressStep, New Object() {0, ""})
            End If
        Next

        If ExportTo = 1 Then
            BW.ReportProgress(0, New Object() {2, ""})
            Dim BigPDF As New iTextSharp.text.Document
            Dim Writer As iTextSharp.text.pdf.PdfWriter = iTextSharp.text.pdf.PdfWriter.GetInstance(BigPDF, New System.IO.FileStream(System.IO.Path.GetTempPath & CaseNumber & ".pdf", IO.FileMode.Create))
            BigPDF.Open()
            Dim PDFCB As iTextSharp.text.pdf.PdfContentByte = Writer.DirectContent
            Dim PDFPage As iTextSharp.text.pdf.PdfImportedPage
            For Each PDFFile As String In PDFFiles
                Dim PDFReader As New iTextSharp.text.pdf.PdfReader(PDFFile)
                Dim PageCount As Integer = PDFReader.NumberOfPages
                For p As Integer = 1 To PageCount
                    Dim CurrentPDFSize As iTextSharp.text.Rectangle = PDFReader.GetPageSizeWithRotation(p)
                    BigPDF.SetPageSize(CurrentPDFSize)
                    BigPDF.NewPage()
                    PDFPage = Writer.GetImportedPage(PDFReader, p)
                    Dim PDFRotation As Integer = PDFReader.GetPageRotation(p)
                    If PDFRotation = 90 Or PDFRotation = 270 Then
                        PDFCB.AddTemplate(PDFPage, 0, -1.0F, 1.0F, 0, 0, PDFReader.GetPageSizeWithRotation(p).Height)
                    Else
                        PDFCB.AddTemplate(PDFPage, 1.0F, 0, 0, 1.0F, 0, 0)
                    End If
                Next
                PDFReader.Close()
            Next
            BigPDF.Close()

            Try
                AxAdobe.LoadFile(System.IO.Path.GetTempPath & CaseNumber & ".pdf")
                AxAdobe.printWithDialog()
            Catch Ex As Exception
                MsgBox("There was a problem loading the Adobe ActiveX Component." & vbCrLf & "Please make sure that Adobe Reader 7.0 or later is properly installed." & vbCrLf & "You may want to try exporting to a file, then printing it manually.", MsgBoxStyle.Critical, "Error")
                LFConn.Terminate()
                Return 3
                For Each PDFFile As String In PDFFiles
                    System.IO.File.Delete(PDFFile)
                Next
                Exit Function
            End Try

            For Each PDFFile As String In PDFFiles
                System.IO.File.Delete(PDFFile)
            Next

        End If

        If ExportTo = 0 And OneFile = True Then
            BW.ReportProgress(0, New Object() {3, ""})
            Dim BigPDF As New iTextSharp.text.Document
            Dim Writer As iTextSharp.text.pdf.PdfWriter = iTextSharp.text.pdf.PdfWriter.GetInstance(BigPDF, New System.IO.FileStream(ExportPath & "\" & CaseNumber & ".pdf", IO.FileMode.Create))
            BigPDF.Open()
            Dim PDFCB As iTextSharp.text.pdf.PdfContentByte = Writer.DirectContent
            Dim PDFPage As iTextSharp.text.pdf.PdfImportedPage
            Dim OneFileProgress As Integer = 100 / PDFFiles.Count
            For Each PDFFile As String In PDFFiles
                If IO.File.Exists(PDFFile) Then
                    Dim PDFReader As New iTextSharp.text.pdf.PdfReader(PDFFile)
                    Dim PageCount As Integer = PDFReader.NumberOfPages
                    For p As Integer = 1 To PageCount
                        Dim CurrentPDFSize As iTextSharp.text.Rectangle = PDFReader.GetPageSizeWithRotation(p)
                        BigPDF.SetPageSize(CurrentPDFSize)
                        BigPDF.NewPage()
                        PDFPage = Writer.GetImportedPage(PDFReader, p)
                        Dim PDFRotation As Integer = PDFReader.GetPageRotation(p)
                        If PDFRotation = 90 Or PDFRotation = 270 Then
                            PDFCB.AddTemplate(PDFPage, 0, -1.0F, 1.0F, 0, 0, PDFReader.GetPageSizeWithRotation(p).Height)
                        Else
                            PDFCB.AddTemplate(PDFPage, 1.0F, 0, 0, 1.0F, 0, 0)
                        End If
                    Next
                    PDFReader.Close()
                    BW.ReportProgress(OneFileProgress, New Object() {3, ""})
                End If

            Next
            BigPDF.Close()
            For Each PDFFile As String In PDFFiles
                System.IO.File.Delete(PDFFile)
            Next
        End If

        LFConn.Terminate()
        Return 0
    End Function

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Dim BWStat As Object() = DirectCast(e.UserState, Object())

        Dim BWStat1 As Integer = CInt(BWStat(0))
        Dim BWStat2 As String = CStr(BWStat(1))

        If BWStat1 = 3 Then
            tssStatus.Text = "Combining PDFs into one."
        End If

        If BWStat1 = 2 Then
            tssStatus.Text = "Preparing to print, BE SURE TO SELECT ALL PAGES!"
        End If

        If BWStat1 = 1 Then
            tssStatus.Text = "Searching done, exporting " & BWStat2 & " documents."
        End If

        If e.ProgressPercentage = 0 Then
            tspProgress.Value = 0
        Else
            tspProgress.Increment(e.ProgressPercentage)
        End If

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If e.Result = 0 Then
            MsgBox("Done Exporting!", MsgBoxStyle.Information, "Done")
            tssStatus.Text = "Please complete the information above..."
        ElseIf e.Result = 1 Then
            MsgBox("Operation Canceled!", MsgBoxStyle.Critical, "Canceled")
            tssStatus.Text = "Please complete the information above..."
        ElseIf e.Result = 2 Then
            MsgBox("No Results Found!", MsgBoxStyle.Critical, "None Found")
            tssStatus.Text = "Please complete the information above..."
        ElseIf e.Result = 3 Then
            MsgBox("Export Failed!", MsgBoxStyle.Critical, "Failed")
            tssStatus.Text = "Please complete the information above..."
        End If

        txtCaseNumber.Text = ""
        CaseReady = False
        CheckForCompleted()
        tspProgress.Value = 0
        btnAbort.Enabled = False
        btnReset.Enabled = True

        txtCaseNumber.Enabled = True
        ProgramType.Enabled = True

        chkSearchDate.Enabled = True

        If chkSearchDate.Checked = True Then
            StartDate.Enabled = True
            radSpecificDate.Enabled = True
            radDateRange.Enabled = True
            If radDateRange.Checked = True Then
                EndDate.Enabled = True
            End If
        End If

        radFile.Enabled = True
        radPrinter.Enabled = True

        If radPrinter.Checked = False Then
            txtFolderLoc.Enabled = True
            chkCombineOne.Enabled = True
            FileSavePathBtn.Enabled = True
            lstFileType.Enabled = True
        End If

        
    End Sub

    Private Sub btnAbort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbort.Click
        BackgroundWorker1.CancelAsync()
    End Sub

    Private Sub txtCaseNumber_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCaseNumber.TextChanged
        If System.Text.RegularExpressions.Regex.IsMatch(txtCaseNumber.Text.ToString, "\d\d\d\d\d\d") = True Then
            CaseReady = True
            CheckForCompleted()
            If ProgramType.SelectedIndex = -1 Then
                tssStatus.ForeColor = System.Drawing.Color.Blue
                tssStatus.Text = "Select Program Type..."
            Else
                tssStatus.ForeColor = System.Drawing.Color.Blue
                tssStatus.Text = "Check your selection and click Stat Export..."
            End If
        Else
            CaseReady = False
            CheckForCompleted()
            tssStatus.ForeColor = System.Drawing.Color.Red
            tssStatus.Text = "Case Number is not six numbers!"
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuHowTo.Click
        HowTo.ShowDialog()
    End Sub

    Private Sub lstFileType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstFileType.SelectedIndexChanged
        If lstFileType.SelectedIndex <> 0 Then
            chkCombineOne.Enabled = False
            chkCombineOne.Checked = False
        Else
            chkCombineOne.Enabled = True
        End If
    End Sub

    Private Sub radPrinter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radPrinter.CheckedChanged
        txtFolderLoc.Enabled = False
        FileSavePathBtn.Enabled = False
        chkCombineOne.Enabled = False
        lstFileType.Enabled = False
    End Sub

    Private Sub radFile_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radFile.CheckedChanged
        txtFolderLoc.Enabled = True
        FileSavePathBtn.Enabled = True
        chkCombineOne.Enabled = True
        lstFileType.Enabled = True
    End Sub

    Private Sub chkSearchDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSearchDate.CheckedChanged
        If chkSearchDate.Checked = True Then
            StartDate.Enabled = True
            EndDate.Enabled = False

            radSpecificDate.Enabled = True
            radDateRange.Enabled = True
            radSpecificDate.Checked = True
        Else
            StartDate.Enabled = False
            EndDate.Enabled = False

            radSpecificDate.Enabled = False
            radDateRange.Enabled = False
        End If
    End Sub

    Private Sub radDateRange_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radDateRange.CheckedChanged
        EndDate.Enabled = True
    End Sub

    Private Sub radSpecificDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radSpecificDate.CheckedChanged
        EndDate.Enabled = False
    End Sub

    Private Sub menuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuAbout.Click
        About.ShowDialog()
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        HowTo.ShowDialog()
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        HowTo.ShowDialog()
    End Sub

    Private Sub ProgramType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProgramType.SelectedIndexChanged
        If ProgramType.SelectedIndex <> -1 Then
            ProgramReady = True
        Else
            tssStatus.ForeColor = System.Drawing.Color.Blue
            tssStatus.Text = "Select Program Type..."
            ProgramReady = False
            CheckForCompleted()
            Exit Sub
        End If
        If System.Text.RegularExpressions.Regex.IsMatch(txtCaseNumber.Text.ToString, "\d\d\d\d\d\d") = True Then
            tssStatus.ForeColor = System.Drawing.Color.Blue
            tssStatus.Text = "Check your selection and click Stat Export..."
        Else
            tssStatus.ForeColor = System.Drawing.Color.Red
            tssStatus.Text = "Case Number is not six numbers!"
        End If
        CheckForCompleted()
    End Sub
End Class
