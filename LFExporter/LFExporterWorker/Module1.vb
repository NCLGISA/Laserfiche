Module Module1

    Dim LFServer As String
    Dim LFRepos As String
    Dim LFUser As String
    Dim LFPass As String
    Dim myLog As New EventLog()
    Dim LFSettings As DataTable
    Dim ExportRules As DataTable
    Dim LastRunDate As String
    Dim Settings As DataSet

    Sub Main()
        If Not EventLog.SourceExists("LF Exporter") Then
            ' Create the source, if it does not already exist.
            ' An event log source should not be created and immediately used.
            ' There is a latency time to enable the source, it should be created
            ' prior to executing the application that uses the source.
            ' Execute this sample a second time to use the new source.
            EventLog.CreateEventSource("LF Exporter", "Application")
            Console.WriteLine("Created Event Source")
            'The source is created.  Exit the application to allow it to be registered.
            Return
        End If

        ' Create an EventLog instance and assign its source.
        myLog.Source = "LF Exporter"

        LoadSettings()
        Console.WriteLine("Settings Loaded Successfully...")
        Console.WriteLine("We have " & ExportRules.Rows.Count.ToString & " rules to run...")

        ProcessRules()

        LFSettings.Select("Option = 'LastRunDate'")(0).Item("Value") = System.DateTime.Today.ToShortDateString
        Settings.WriteXml("Settings.xml")
    End Sub

    Public Sub LoadSettings()
        Try
            Settings = New DataSet
            Settings.ReadXml("Settings.xml")
            LFSettings = Settings.Tables("LFSettings")
            LFServer = LFSettings.Select("Option = 'LFServer'")(0).Item("Value")
            LFRepos = LFSettings.Select("Option = 'LFRepos'")(0).Item("Value")
            LFUser = LFSettings.Select("Option = 'LFUser'")(0).Item("Value")
            LFPass = DecryptPass(LFSettings.Select("Option = 'LFPass'")(0).Item("Value"))

            ExportRules = Settings.Tables("ExportRules")

            If LFSettings.Select("Option = 'LastRunDate'").Length = 0 Then
                LFSettings.Rows.Add("LastRunDate", System.DateTime.Today.ToShortDateString)
                Settings.WriteXml("Settings.xml")
            Else
                LastRunDate = LFSettings.Select("Option = 'LastRunDate'")(0).Item("Value")
            End If
        Catch ex As Exception
            Console.WriteLine("Error loading settings... check Settings.xml")
            myLog.WriteEntry("Error loading settings, check Settings.xml")
            Environment.Exit(0)
        End Try

    End Sub

    Public Sub ProcessRules()
        Dim StartTime As DateTime = Date.Now

        Dim app As New LFSO83Lib.LFApplication


        ' Finds the appropriate server.
        Dim serv As LFSO83Lib.LFServer = app.GetServerByName(LFServer)
        ' Gets the repository from the server.
        Dim db As LFSO83Lib.LFDatabase = serv.GetDatabaseByName(LFRepos)
        ' Creates a new connection object.
        Dim conn As New LFSO83Lib.LFConnection
        ' Sets the user name and password.
        conn.UserName = LFUser
        conn.Password = LFPass
        ' Connects to repository.
        Try
            conn.Create(db)
        Catch Ex As Exception
            Console.WriteLine("Error Logging into the LaserFiche Repository... Check Username and Password")
            myLog.WriteEntry("Error Logging into the LaserFiche Repository... Check Username and Password" & vbCrLf & "Error Message: " & Ex.Message)
            Environment.Exit(0)
        End Try


        For Each Row As DataRow In ExportRules.Rows
            Console.WriteLine("Running Rule: " & Row.Item("RuleName"))
            ' Gets a search object from the repository.
            Dim NewSearch As LFSO83Lib.LFSearch = db.CreateSearch
            ' Defines the word the search will look for.
            'NewSearch.Command = My.Settings.SearchCommand & " & {LF:Created>""4/1/2007""}"
            NewSearch.Command = Row.Item("SearchString") & " & {LF:Created>=""" & LastRunDate & """}"
            ' Starts searching.
            Console.WriteLine("Starting Search...")
            NewSearch.BeginSearch(False)
            ' Loops while the search is in progress.
            While NewSearch.SearchStatus = LFSO83Lib.Search_Status.SEARCH_STATUS_IN_PROGRESS
                ' Updates on each loop.
                NewSearch.UpdateSearchStatus()

            End While

            ' Gets the search hits (instances of the word).

            Console.WriteLine("Searching Completed...")

            Dim AllHits As LFSO83Lib.ILFCollection = NewSearch.GetSearchHits()
            Dim DocsFound As String = AllHits.Count.ToString

            If AllHits.Count > 0 Then

                Console.WriteLine("Found " & DocsFound & " documents that will be exported...")

                Select Case (Row.Item("ExportType"))
                    Case "PDF - Many to 1"
                        Dim BigPDF As New iTextSharp.text.Document
                        Dim Writer As iTextSharp.text.pdf.PdfWriter = iTextSharp.text.pdf.PdfWriter.GetInstance(BigPDF, New System.IO.FileStream(Row.Item("ExportPath") & "\" & Row.Item("RuleName") & Replace(System.DateTime.Today.ToShortDateString, "/", "-") & ".pdf", IO.FileMode.Create))
                        BigPDF.Open()
                        Dim FilesToDelete As New ArrayList
                        For i As Integer = 1 To AllHits.Count
                            Dim Hit As LFSO83Lib.LFSearchHit = AllHits.Item(i)
                            Dim EntryHit As LFSO83Lib.ILFEntry = Hit.Entry

                            Dim Doc As LFSO83Lib.ILFDocument = db.GetEntryByID(EntryHit.ID)

                            Dim Exporter As New PdfExporter83.PdfExporter

                            Dim TempPDFPath As String = System.IO.Path.GetTempPath & "TempPDF" & EntryHit.ID & ".pdf"
                            Exporter.ExportPagesToFile(Doc, TempPDFPath)

                            Dim PDFCB As iTextSharp.text.pdf.PdfContentByte = Writer.DirectContent
                            Dim PDFPage As iTextSharp.text.pdf.PdfImportedPage
                            Dim PDFReader As New iTextSharp.text.pdf.PdfReader(TempPDFPath)
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

                            FilesToDelete.Add(TempPDFPath)

                        Next
                        BigPDF.Close()

                        For Each File As String In FilesToDelete
                            System.IO.File.Delete(File)
                        Next
                    Case "PDF - 1 to 1"
                        For i As Integer = 1 To AllHits.Count
                            Dim Hit As LFSO83Lib.LFSearchHit = AllHits.Item(i)
                            Dim EntryHit As LFSO83Lib.ILFEntry = Hit.Entry

                            Dim Doc As LFSO83Lib.ILFDocument = db.GetEntryByID(EntryHit.ID)

                            Dim Exporter As New PdfExporter83.PdfExporter

                            Dim PDFPath As String = Row.Item("ExportPath") & "\" & Row.Item("RuleName") & Replace(System.DateTime.Today.ToShortDateString, "/", "-") & EntryHit.ID & ".pdf"
                            Exporter.ExportPagesToFile(Doc, PDFPath)
                        Next

                        '**** Old code that was not migrated to SDK 8.3
                        'Case "PNG"
                        'For i As Integer = 1 To AllHits.Count
                        'Dim Hit As LFSO83Lib.LFSearchHit = AllHits.Item(i)
                        'Dim EntryHit As LFSO83Lib.ILFEntry = Hit.Entry

                        'Dim Exporter As New DocumentProcessor72.DocumentExporter
                        'Exporter.SourceDocument = db.GetEntryByID(EntryHit.ID)
                        'Exporter.Format = DocumentProcessor72.Document_Format.DOCUMENT_FORMAT_PNG
                        'Dim PDFPath As String = Row.Item("ExportPath") & "\" & Row.Item("RuleName") & Replace(System.DateTime.Today.ToShortDateString, "/", "-") & EntryHit.ID & ".png"
                        'Exporter.ExportToFile(PDFPath)
                        'Next
                        'Case "TIF"
                        'For i As Integer = 1 To AllHits.Count
                        'Dim Hit As LFSO83Lib.LFSearchHit = AllHits.Item(i)
                        'Dim EntryHit As LFSO83Lib.ILFEntry = Hit.Entry

                        'Dim Exporter As New DocumentProcessor72.DocumentExporter
                        'Exporter.SourceDocument = db.GetEntryByID(EntryHit.ID)
                        'Exporter.Format = DocumentProcessor72.Document_Format.DOCUMENT_FORMAT_TIFFG4
                        'Dim PDFPath As String = Row.Item("ExportPath") & "\" & Row.Item("RuleName") & Replace(System.DateTime.Today.ToShortDateString, "/", "-") & EntryHit.ID & ".tif"
                        'Exporter.ExportToFile(PDFPath)
                        'Next
                End Select

                Console.WriteLine("Successfully exported to " & Row.Item("ExportPath"))
                System.Threading.Thread.Sleep(2000)
            Else

                Console.WriteLine("No Documents Found! Exiting...")
                System.Threading.Thread.Sleep(2000)
            End If

            myLog.WriteEntry("Start Time: " & StartTime.ToString & vbCrLf & "Documents Exported: " & DocsFound & vbCrLf & "Search Command: " & Row.Item("SearchString") & vbCrLf & "Search Date: " & LastRunDate & vbCrLf & "Export Path: " & Row.Item("ExportPath"))
        Next

        conn.Terminate()

    End Sub

    Public Function DecryptPass(ByVal encrpytedString As String)
        Dim sym As New Encryption.Symmetric(Encryption.Symmetric.Provider.TripleDES)
        Dim key As New Encryption.Data("laserfiche")
        Dim encryptedData As New Encryption.Data
        encryptedData.Text = encrpytedString
        Dim decryptedData As Encryption.Data
        decryptedData = sym.Decrypt(encryptedData, key)
        Return decryptedData.ToString
    End Function

    Public Function EncryptPass(ByVal clearText As String)
        Dim SYM As New Encryption.Symmetric(Encryption.Symmetric.Provider.TripleDES)
        Dim KEY As New Encryption.Data("laserfiche")
        Dim encryptedData As Encryption.Data
        encryptedData = SYM.Encrypt(New Encryption.Data(clearText), KEY)
        Dim encryptedPass As String = encryptedData.ToString
        Return encryptedPass
    End Function

End Module
