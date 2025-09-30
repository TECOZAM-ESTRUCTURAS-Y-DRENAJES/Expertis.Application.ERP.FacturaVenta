Imports OfficeOpenXml
Imports OfficeOpenXml.Style
Imports Solmicro.Expertis.Engine
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Text

Public Class frmGenerarCESCE
    Const DB_DCZ As String = "xDrenajesPortugal50R2"
    Private Shared ReadOnly culturaES As New Globalization.CultureInfo("es-ES")

    Private Sub frmGenerarCESCE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With cbFormato
            .DropDownStyle = ComboBoxStyle.DropDownList
            .Items.Clear()
            .Items.AddRange(New Object() {"CSV", "EXCEL"})
            .SelectedIndex = 0
        End With

        Dim meses As New List(Of KeyValuePair(Of Integer, String))()
        For m As Integer = 1 To 12
            Dim nombre As String = culturaES.DateTimeFormat.MonthNames(m - 1)
            nombre = culturaES.TextInfo.ToTitleCase(nombre)
            meses.Add(New KeyValuePair(Of Integer, String)(m, nombre))
        Next

        With cbMes
            .DropDownStyle = ComboBoxStyle.DropDownList
            .DataSource = meses
            .DisplayMember = "Value"
            .ValueMember = "Key"
            .SelectedValue = Date.Today.AddMonths(-1).Month
        End With

        Dim ref As Date = New Date(Today.Year, Today.Month, 1).AddMonths(-1)

        numAnio.Minimum = 2000
        numAnio.Maximum = 2100
        numAnio.Value = ref.Year
    End Sub


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            Dim formato As String = CStr(cbFormato.SelectedItem)
            Dim mes As Integer = CInt(cbMes.SelectedValue)
            Dim anio As Integer = CInt(numAnio.Value)

            Dim desde As New Date(anio, mes, 1)
            Dim hasta As Date = desde.AddMonths(1)

            Dim ok As Boolean
            If String.Equals(formato, "CSV", StringComparison.OrdinalIgnoreCase) Then
                ok = GenerarCsv(desde, hasta)
            Else
                ok = GenerarExcel(desde, hasta)
            End If

            If ok Then
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        Catch ex As Exception
            ShowError("Se ha producido un error al ejecutar la exportación.", ex)
        End Try
    End Sub

    Public Function GenerarDatosCESCE(ByVal desde As Date, ByVal hasta As Date) As DataTable
        Dim f As New Filter
        f.Add("FechaFactura", FilterOperator.GreaterThanOrEqual, desde)
        f.Add("FechaFactura", FilterOperator.LessThan, hasta)
        f.Add("CifCliente", FilterOperator.NotEqual, "B49243215")               ' Seco
        f.Add("CifCliente", FilterOperator.NotEqual, "B49226616")               ' Ferrallas
        f.Add("CifCliente", FilterOperator.NotEqual, "B83214668")               ' Tecozam
        f.Add("CifCliente", FilterOperator.NotEqual, "NO931198114")             ' Norge
        f.Add("CifCliente", FilterOperator.NotEqual, "GB141257732")             ' UK
        f.Add("CifCliente", FilterOperator.NotEqual, "PT509252559")             ' DCZ

        Dim dtFactTECO As DataTable = New FacturaVentaCabecera().Filter(f)
        Dim dtFactDCZ As DataTable = New BE.DataEngine().Filter(DB_DCZ & "..tbFacturaVentaCabecera", f)
        Dim dtFact As DataTable = dtFactTECO.Copy
        dtFact.Merge(dtFactDCZ, True, MissingSchemaAction.Add)

        Dim c As Integer = dtFact.Rows.Count : Dim c2 As Integer = dtFactDCZ.Rows.Count : Dim c3 As Integer = dtFactTECO.Rows.Count

        Dim dt As New DataTable()
        dt.Columns.Add("CIF", GetType(String))
        dt.Columns.Add("FechaFactura", GetType(String))
        dt.Columns.Add("Importe", GetType(String))
        dt.Columns.Add("Vencimiento", GetType(String))
        dt.Columns.Add("NombreFactura", GetType(String))
        dt.Columns.Add("Referencia", GetType(String))

        For Each drow As DataRow In dtFact.Rows
            ' CIF
            Dim cif As String = ""
            If drow.Table.Columns.Contains("CifCliente") AndAlso Not IsDBNull(drow("CifCliente")) Then
                cif = drow("CifCliente").ToString()
                cif = cif.Replace(".", "").Replace("-", "").Replace(" ", "").Trim()
            End If

            ' Fecha
            Dim fecha As String = ""
            If Not IsDBNull(drow("FechaFactura")) Then
                fecha = CDate(drow("FechaFactura")).ToString("dd/MM/yy")
            End If

            ' Importe
            Dim importe As String = "0,00"
            If drow.Table.Columns.Contains("ImpTotal") AndAlso Not IsDBNull(drow("ImpTotal")) Then
                Dim valor As Decimal = Convert.ToDecimal(drow("ImpTotal"))
                importe = valor.ToString("N2", culturaES)
            End If

            ' Vencimiento
            Dim vencimiento As String = ""
            If Not IsDBNull(drow("FechaVencimiento")) Then
                vencimiento = CDate(drow("FechaVencimiento")).ToString("dd/MM/yy")
            End If

            ' NumFactura
            Dim nFactura As String = If(Not IsDBNull(drow("NFacturaExtendida")), drow("NFacturaExtendida").ToString(), "")

            ' Referencia
            Dim referencia As String = getNObra(drow("IDFactura"), drow("SyncDB"))

            dt.Rows.Add(New Object() {cif, fecha, importe, vencimiento, nFactura, referencia})
        Next

        Return dt
    End Function

    Public Function GenerarCsv(ByVal desde As Date, ByVal hasta As Date) As Boolean
        Try
            Dim sfd As New SaveFileDialog()
            sfd.Filter = "CSV (delimitado por comas)|*.csv|Todos los archivos|*.*"
            sfd.Title = "Guardar CSV CESCE"
            sfd.FileName = "9165409_" & desde.ToString("MMyy", Globalization.CultureInfo.InvariantCulture) & ".csv"

            If sfd.ShowDialog() = DialogResult.OK Then
                Dim dtLineas As DataTable = GenerarDatosCESCE(desde, hasta)

                Dim sb As New StringBuilder()
                'sb.AppendLine("CIF,FechaFactura,Importe,Vencimiento,NFactura,Referencia")

                Dim r As DataRow
                For Each r In dtLineas.Rows
                    Dim line As String = String.Join(",", New String() { _
                        CStr(r("CIF")), _
                        CStr(r("FechaFactura")), _
                        """" & r("Importe").Replace("""", """""") & """", _
                        CStr(r("Vencimiento")), _
                        CStr(r("NombreFactura")), _
                        CStr(r("Referencia")) _
                    })
                    sb.AppendLine(line)
                Next

                File.WriteAllText(sfd.FileName, sb.ToString(), New UTF8Encoding(True))
                ShowInfo("CSV generado correctamente:" & Environment.NewLine & sfd.FileName)
                Return True
            End If
        Catch ex As Exception
            ShowError("No se pudo generar el CSV.", ex)
            Return False
        End Try
    End Function

    Public Function GenerarExcel(ByVal desde As Date, ByVal hasta As Date) As Boolean
        Try
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial

            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "Archivos de Excel|*.xlsx|Todos los archivos|*.*"
            saveFileDialog1.Title = "Guardar archivo"
            saveFileDialog1.FileName = "9165409_" & desde.ToString("MMyy", Globalization.CultureInfo.InvariantCulture) & ".xlsx"

            If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim dtFact As DataTable = GenerarDatosCESCE(desde, hasta)

                Dim rutaArchivo As String = saveFileDialog1.FileName

                Using package As New ExcelPackage()
                    Dim worksheet = package.Workbook.Worksheets.Add("Hoja 1")
                    worksheet.Cells("A1").LoadFromDataTable(dtFact, False)
                    Dim fileInfo As New IO.FileInfo(rutaArchivo)
                    package.SaveAs(fileInfo)
                End Using
            End If

            ShowInfo("Excel generado correctamente:" & Environment.NewLine & saveFileDialog1.FileName)
            Return True
        Catch ex As Exception
            ShowError("No se pudo generar el Excel.", ex)
            Return False
        End Try

    End Function

    Public Function getNObra(ByVal idFact As Integer, ByVal db As String) As String
        Dim f As New Filter
        f.Add("IDFactura", FilterOperator.Equal, idFact)
        Dim dt As DataTable = New BE.DataEngine().Filter(db & "..frmMntoFacturaVenta", f)

        If dt.Rows.Count <> 0 Then
            Return dt.Rows(0)("NObra")
        Else
            Return ""
        End If
    End Function

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub ShowInfo(ByVal msg As String)
        MessageBox.Show(msg, "CESCE", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ShowError(ByVal msg As String, Optional ByVal ex As Exception = Nothing)
        If Not ex Is Nothing Then msg &= Environment.NewLine & ex.Message
        MessageBox.Show(msg, "CESCE", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub


End Class