Imports System.Collections.Generic

Public Class FrmImprimirDocs

#Region "Variables Privadas / Propiedades Públicas"

    Private MIDFactura As Integer
    Public WriteOnly Property IDFactura() As Integer
        Set(ByVal value As Integer)
            MIDFactura = value
        End Set
    End Property

    Private MNFactura As String
    Public WriteOnly Property NFactura() As String
        Set(ByVal value As String)
            MNFactura = value
        End Set
    End Property

    Private MIDProgram As Guid
    Public WriteOnly Property IDProgram() As Guid
        Set(ByVal value As Guid)
            MIDProgram = value
        End Set
    End Property

#End Region

#Region "Funciones/Procesos Privados"

    Private Sub LoadData()
        Dim DtReports As New DataTable
        DtReports.Columns.Add("Alias", GetType(String))
        DtReports.Columns.Add("Caption", GetType(String))
        For Each Rpt As ReportInfo In ExpertisApp.ProgramDescriptor(MIDProgram).Reports
            Dim DrNew As DataRow = DtReports.NewRow
            DrNew("Alias") = Rpt.Alias
            DrNew("Caption") = Rpt.Caption
            DtReports.Rows.Add(DrNew)
        Next
        DtReports.AcceptChanges()
        Me.CmbInformeFactura.DataSource = DtReports
        Me.CmbInformeFactura.Value = "IFV"

        Dim DtPrinters As New DataTable
        DtPrinters.Columns.Add("Impresora", GetType(String))
        For Each Printer As String In Drawing.Printing.PrinterSettings.InstalledPrinters
            Dim DrNew As DataRow = DtPrinters.NewRow
            DrNew("Impresora") = Printer
            DtPrinters.Rows.Add(DrNew)
        Next
        DtPrinters.AcceptChanges()
        Me.CmbImpresora.DataSource = DtPrinters
    End Sub

    Private Sub LoadOpciones()
        Dim DtOpciones As New DataTable
        DtOpciones.Columns.Add("IDOpcion", GetType(Integer))
        DtOpciones.Columns.Add("DescOpcion", GetType(String))

        For i As Integer = 0 To 3
            Dim DrNew As DataRow = DtOpciones.NewRow
            DrNew("IDOpcion") = i
            Select Case i
                Case 0
                    DrNew("DescOpcion") = "Vista Previa en Expertis"
                Case 1
                    DrNew("DescOpcion") = "Enviar a Impresora"
                Case 2
                    DrNew("DescOpcion") = "Guardar a directorio"
                Case 3
                    DrNew("DescOpcion") = "Enviar por Correo Electrónico"
            End Select
            DtOpciones.Rows.Add(DrNew)
        Next
        Me.CmbOpciones.DataSource = DtOpciones
        Me.CmbOpciones.Value = 0
    End Sub

    Private Function CheckData() As Boolean
        If Not Me.ChkFacturaExportacion.Checked AndAlso Not Me.ChkFacturaAduanas.Checked AndAlso _
           Not Me.ChkListaContenido.Checked AndAlso Not Me.ChkFacturaMaterial.Checked AndAlso _
           Not Me.ChkDAA.Checked AndAlso Not Me.ChkCertificadoOrigen.Checked AndAlso _
           Not Me.ChkAnaliticaVino.Checked AndAlso Not Me.ChkCartaCredito.Checked AndAlso _
           Not Me.chkCartaComisiones.Checked AndAlso _
           Not Me.chkComisiones.Checked Then
            ExpertisApp.GenerateMessage("No se ha seleccionado ningún informe para imprimir.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        Else
            If Length(Me.CmbOpciones.Value) > 0 Then
                Select Case CInt(Me.CmbOpciones.Value)
                    Case 1
                        If Length(Me.CmbImpresora.Text) = 0 Then
                            ExpertisApp.GenerateMessage("Debe especificar una impresora.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Return False
                        End If
                    Case 2
                        If Length(Me.TxtDirectorio.Text) = 0 Then
                            ExpertisApp.GenerateMessage("Debe especificar un directorio para generar los ficheros.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Return False
                        End If
                End Select
                If Me.ChkFacturaExportacion.Checked AndAlso Length(Me.CmbInformeFactura.Value) = 0 Then
                    ExpertisApp.GenerateMessage("Debe seleccionar un informe de Factura de Exportación.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                End If
            Else
                ExpertisApp.GenerateMessage("Debe seleccionar una opción para los informes.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub PrintDocs()
        Const cnRPT_ALIAS_CARTA As String = "CARTADIS"
        Const cnRPT_ALIAS_LISTADO As String = "COMISDIS"


        Me.Hide()
        Dim StrAdj As String = String.Empty
        Dim StrClave As String = String.Empty
        For Each Ctrl As Control In Me.FrmCab.Controls
            If TypeOf Ctrl Is Engine.UI.CheckBox Then
                If CType(Ctrl, Engine.UI.CheckBox).Checked Then
                    Dim RptDoc As Report
                    Select Case CType(Ctrl, Engine.UI.CheckBox).Name
                        Case "ChkFacturaExportacion"
                            Select Case CStr(Me.CmbInformeFactura.Value)
                                Case "IFV", "IFVA"
                                    RptDoc = New Report(CStr(Me.CmbInformeFactura.Value))
                                    Dim Source As New ReportAuxiliarTable("FacturaVentaCabecera")
                                    Source.Settings.CopiesDefaultvalue = 1
                                    Source.Settings.LinkField = "IDFactura"
                                    Dim DtFact As DataTable = New BE.DataEngine().Filter("vRptMntoFacturaVenta", New FilterItem("IDFactura", FilterOperator.Equal, MIDFactura))
                                    If Not DtFact Is Nothing AndAlso DtFact.Rows.Count > 0 Then
                                        Source.DataSource = DtFact
                                        RptDoc.DataSource = Source
                                    Else : RptDoc = Nothing
                                    End If
                                    StrClave = "Factura"
                            End Select
                        Case "ChkFacturaAduanas"
                            RptDoc = New Report("IFVADU")
                            Dim Source As New ReportAuxiliarTable("FacturaVentaCabecera")
                            Source.Settings.CopiesDefaultvalue = 1
                            Source.Settings.LinkField = "IDFactura"
                            Dim DtAduana As DataTable = New BE.DataEngine().Filter("vRptMntoFacturaVenta", New FilterItem("IDFactura", FilterOperator.Equal, MIDFactura))
                            If Not DtAduana Is Nothing AndAlso DtAduana.Rows.Count > 0 Then
                                Source.DataSource = DtAduana
                                RptDoc.DataSource = Source
                            Else : RptDoc = Nothing
                            End If
                            StrClave = "Aduana"
                        Case "ChkListaContenido"
                            RptDoc = New Report("IFVLSTC")
                            RptDoc.Filter.Add(New FilterItem("IDFactura", FilterOperator.Equal, MIDFactura))
                            StrClave = "ListaContenido"
                        Case "ChkFacturaMaterial"
                            RptDoc = New Report("IFVMAT")
                            Dim Source As New ReportAuxiliarTable("FacturaVentaCabecera")
                            Source.Settings.CopiesDefaultvalue = 1
                            Source.Settings.LinkField = "IDFactura"
                            Dim DtMat As DataTable = New BE.DataEngine().Filter("vRptMntoFacturaVentaMaterial", New FilterItem("IDFactura", FilterOperator.Equal, MIDFactura))
                            If Not DtMat Is Nothing AndAlso DtMat.Rows.Count > 0 Then
                                Source.DataSource = DtMat
                                RptDoc.DataSource = Source
                            Else : RptDoc = Nothing
                            End If
                            StrClave = "Material"
                        Case "ChkDAA"
                            Dim FilFactLin As New Filter
                            FilFactLin.Add("IDFactura", FilterOperator.Equal, MIDFactura)
                            FilFactLin.Add(New IsNullFilterItem("IDAlbaran", False))
                            Dim DtFactLin As DataTable = New FacturaVentaLinea().Filter(FilFactLin)
                            If Not DtFactLin Is Nothing AndAlso DtFactLin.Rows.Count > 0 Then
                                Dim MIDAlbaran As Integer = 0
                                Dim ClsAlbCab As New AlbaranVentaCabecera
                                Dim ClsDaaCab As New BdgDAACabecera
                                Dim FilDAAS As New Filter(FilterUnionOperator.Or)
                                For Each Dr As DataRow In DtFactLin.Select(String.Empty, "IDAlbaran")
                                    If MIDAlbaran <> Dr("IDAlbaran") Then
                                        Dim DtAlbCab As DataTable = ClsAlbCab.Filter(New FilterItem("IDAlbaran", FilterOperator.Equal, Dr("IDAlbaran")), "IDAlbaran", "IDDAA")
                                        If Not DtAlbCab Is Nothing AndAlso DtAlbCab.Rows.Count > 0 Then
                                            If Length(DtAlbCab.Rows(0)("IDDAA")) > 0 Then
                                                Dim DtDaaCab As DataTable = ClsDaaCab.Filter(New GuidFilterItem("IDDAA", DtAlbCab.Rows(0)("IDDAA")))
                                                If Not DtDaaCab Is Nothing AndAlso DtDaaCab.Rows.Count > 0 Then
                                                    Select Case CInt(DtDaaCab.Rows(0)("TipoEnvioDAA"))
                                                        Case 1 'enumTipoEnvioDaa.Intracomunitario
                                                            RptDoc = New Report("BDGMODELO501")
                                                        Case 2 'enumTipoEnvioDAA.Interno
                                                            RptDoc = New Report("BDGMODELO525")
                                                    End Select
                                                    FilDAAS.Add(New GuidFilterItem("IDDAA", DtDaaCab.Rows(0)("IDDAA")))
                                                End If
                                            End If
                                        End If
                                        MIDAlbaran = Dr("IDAlbaran")
                                    End If
                                Next
                                If Not FilDAAS Is Nothing AndAlso FilDAAS.Count > 0 Then
                                    RptDoc.Filter.Add(FilDAAS)
                                Else : RptDoc = Nothing
                                End If
                            End If
                            StrClave = "DAA"
                        Case "ChkCertificadoOrigen"

                        Case "ChkAnaliticaVino"
                            RptDoc = New Report("BDGANVINO")
                            Dim DtAnalisis As DataTable = New Business.Bodega.BdgVinoAnalisis().Filter(New FilterItem("IDFactura", FilterOperator.Equal, MIDFactura))
                            If Not DtAnalisis Is Nothing AndAlso DtAnalisis.Rows.Count > 0 Then
                                Dim FilAnalisis As New Filter(FilterUnionOperator.Or)
                                For Each DrAn As DataRow In DtAnalisis.Select
                                    FilAnalisis.Add(New GuidFilterItem("IDVinoAnalisis", DrAn("IDVinoAnalisis")))
                                Next
                                RptDoc.Filter.Add(FilAnalisis)
                            Else : RptDoc = Nothing
                            End If
                            StrClave = "Analitica"
                        Case "ChkCartaCredito"

                      
                    End Select
                    If Not RptDoc Is Nothing Then
                        Select Case CInt(Me.CmbOpciones.Value)
                            Case 1
                                RptDoc.ExportOptions.ExportType = ReportExportDestinationType.Printer
                                RptDoc.ExportOptions.PrintSettings.PrinterName = Me.CmbImpresora.Text
                            Case 2
                                RptDoc.ExportOptions.ExportType = ReportExportDestinationType.DiskFile
                                RptDoc.ExportOptions.FormatType = ReportExportFormatType.PDF
                                RptDoc.ExportOptions.ExportToDiskFile.DiskFileName = Me.TxtDirectorio.Text & "\" & StrClave & " - " & MNFactura & ".pdf"
                            Case 3
                                RptDoc.ExportOptions.ExportType = ReportExportDestinationType.DiskFile
                                RptDoc.ExportOptions.FormatType = ReportExportFormatType.PDF
                                If Not IO.Directory.Exists(ExpertisApp.Path & "\Mails") Then IO.Directory.CreateDirectory(ExpertisApp.Path & "\Mails")
                                RptDoc.ExportOptions.ExportToDiskFile.DiskFileName = ExpertisApp.Path & "\Mails\" & StrClave & " - " & MNFactura & ".pdf"
                                If StrAdj.Length > 0 Then StrAdj &= "; "
                                StrAdj &= ExpertisApp.Path & "\Mails\" & StrClave & " - " & MNFactura & ".pdf"
                        End Select
                        ExpertisApp.OpenReport(RptDoc)
                        RptDoc = Nothing
                    End If
                End If
            End If
        Next

        For Each Ctrl As Control In Me.FraDistribucion.Controls
            If TypeOf Ctrl Is Engine.UI.CheckBox Then
                If CType(Ctrl, Engine.UI.CheckBox).Checked Then

                    Dim rpt As Report
                    Select Case CType(Ctrl, Engine.UI.CheckBox).Name
                        Case "ChkCartaComisiones"
                            rpt = New Report(cnRPT_ALIAS_CARTA)
                            If Nz(cbxFechaDesde.Value, cnMinDate) <> cnMinDate Then rpt.Formulas("FechaDesde").Text = cbxFechaDesde.Value
                            If Nz(cbxFechaHasta.Value, cnMinDate) <> cnMinDate Then rpt.Formulas("FechaHasta").Text = cbxFechaHasta.Value
                            Dim f As New Filter
                            f.Add(New NumberFilterItem("IDFacturaAbono", MIDFactura))
                            rpt.Filter.Add(f)
                            StrClave = "Carta Comisiones"
                        Case "ChkComisiones"
                            rpt = New Report(cnRPT_ALIAS_LISTADO)
                            Dim f As New Filter
                            f.Add(New NumberFilterItem("IDFacturaAbono", MIDFactura))
                            rpt.Filter.Add(f)
                            StrClave = "Comisiones"
                    End Select


                    If Not rpt Is Nothing Then
                        Select Case CInt(Me.CmbOpciones.Value)
                            Case 1
                                rpt.ExportOptions.ExportType = ReportExportDestinationType.Printer
                                rpt.ExportOptions.PrintSettings.PrinterName = Me.CmbImpresora.Text
                            Case 2
                                rpt.ExportOptions.ExportType = ReportExportDestinationType.DiskFile
                                rpt.ExportOptions.FormatType = ReportExportFormatType.PDF
                                rpt.ExportOptions.ExportToDiskFile.DiskFileName = Me.TxtDirectorio.Text & "\" & StrClave & " - " & MNFactura & ".pdf"
                            Case 3
                                rpt.ExportOptions.ExportType = ReportExportDestinationType.DiskFile
                                rpt.ExportOptions.FormatType = ReportExportFormatType.PDF
                                If Not IO.Directory.Exists(ExpertisApp.Path & "\Mails") Then IO.Directory.CreateDirectory(ExpertisApp.Path & "\Mails")
                                rpt.ExportOptions.ExportToDiskFile.DiskFileName = ExpertisApp.Path & "\Mails\" & StrClave & " - " & MNFactura & ".pdf"
                                If StrAdj.Length > 0 Then StrAdj &= "; "
                                StrAdj &= ExpertisApp.Path & "\Mails\" & StrClave & " - " & MNFactura & ".pdf"
                        End Select
                        ExpertisApp.OpenReport(rpt)
                        rpt = Nothing
                    End If
                End If
            End If

        Next

        If CInt(Me.CmbOpciones.Value) = 3 Then
            Dim StSmtp As New Business.General.Correos.DataCorreos("FacturaVentaCabecera", ExpertisApp.Token.UserID)
            Dim StData As New MailOptionsInfo
            StData.SmtpServerConfig = ExpertisApp.ExecuteTask(Of Object, Object)(AddressOf Business.General.Correos.LoadSmtpServerInfo, StSmtp)
            Dim FrmEnvio As New frmSendMail
            FrmEnvio.VerAdjunto = False
            FrmEnvio.VerFichero = False
            FrmEnvio.EditarPara = True
            If FrmEnvio.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim Email As New EmailInfo
                Email.Asunto = FrmEnvio.Asunto
                Email.Email = FrmEnvio.Para
                Email.EMailsCC = FrmEnvio.ParaCC
                Email.EMailsCCO = FrmEnvio.ParaCCO
                Email.Mensaje = FrmEnvio.Mensaje
                Email.FicheroAdjunto = StrAdj
                ReDim Preserve StData.Mails(0)
                StData.Mails(0) = Email
                ERP.FactElecCorreo.Correos.SendMail(StData)

                IO.Directory.Delete(ExpertisApp.Path & "\Mails", True)
            End If
        End If
    End Sub

    Private Sub ChangeOption()
        Select Case CInt(Me.CmbOpciones.Value)
            Case 0, 3
                Me.LbLDirectorio.Visible = False : Me.TxtDirectorio.Visible = False : Me.BtnDirectorio.Visible = False
                Me.LblImpresora.Visible = False : Me.CmbImpresora.Visible = False
            Case 1
                Me.LbLDirectorio.Visible = False : Me.TxtDirectorio.Visible = False : Me.BtnDirectorio.Visible = False
                Me.LblImpresora.Visible = True : Me.CmbImpresora.Visible = True
            Case 2
                Me.LbLDirectorio.Visible = True : Me.TxtDirectorio.Visible = True : Me.BtnDirectorio.Visible = True
                Me.LblImpresora.Visible = False : Me.CmbImpresora.Visible = False
        End Select
    End Sub

#End Region

#Region "Eventos FrmImprimirDocs"

    Private Sub FrmImprimirDocs_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadData()
        LoadOpciones()
    End Sub

    Private Sub CmbOpciones_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbOpciones.ValueChanged
        ChangeOption()
    End Sub

#Region "Eventos Buttons"

    Private Sub BtnDirectorio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDirectorio.Click
        Dim FldDiag As New FolderBrowserDialog
        FldDiag.RootFolder = Environment.SpecialFolder.MyComputer
        FldDiag.Description = "Seleccione Directorio..."
        If FldDiag.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.TxtDirectorio.Text = FldDiag.SelectedPath
        End If
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If CheckData() Then
            Me.Cursor = Cursors.WaitCursor
            PrintDocs()
            Me.Cursor = Cursors.Default
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

#End Region

#End Region

End Class