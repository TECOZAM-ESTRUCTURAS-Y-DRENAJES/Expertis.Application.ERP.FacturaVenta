Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Windows.Forms          ' SaveFileDialog

Partial Public Class frmFechas

#Region "Eventos de botones"

    Private Sub bAceptar_Click(ByVal sender As System.Object, _
                               ByVal e As System.EventArgs) _
                               Handles bAceptar.Click

        Dim fDesde As Date, fHasta As Date
        If Not ValidarFechas(fDesde, fHasta) Then Exit Sub

        GeneraExcel(fDesde, fHasta)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub bCancelar_Click(ByVal sender As System.Object, _
                                ByVal e As System.EventArgs) _
                                Handles bCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

#End Region


#Region "Validaciones de fechas"
    Private Function ValidarFechas(ByRef f1 As Date, ByRef f2 As Date) As Boolean
        If Trim(cbFechaDesde.Text) = "" Then
            MsgBox("El campo 'Desde' no puede estar vacío.", _
                   MsgBoxStyle.Exclamation, "Falta la fecha inicial")
            cbFechaDesde.Focus() : Return False
        End If
        If Trim(cbFechaHasta.Text) = "" Then
            MsgBox("El campo 'Hasta' no puede estar vacío.", _
                   MsgBoxStyle.Exclamation, "Falta la fecha final")
            cbFechaHasta.Focus() : Return False
        End If

        If Not cbFechaDesde.Checked Then
            MsgBox("Seleccione la fecha 'Desde'.", _
                   MsgBoxStyle.Exclamation, "Falta la fecha inicial")
            cbFechaDesde.Focus() : Return False
        End If
        If Not cbFechaHasta.Checked Then
            MsgBox("Seleccione la fecha 'Hasta'.", _
                   MsgBoxStyle.Exclamation, "Falta la fecha final")
            cbFechaHasta.Focus() : Return False
        End If

        Try
            f1 = cbFechaDesde.Value.Date
            f2 = cbFechaHasta.Value.Date
        Catch
            MsgBox("Las fechas introducidas no son válidas.", _
                   MsgBoxStyle.Critical, "Error en fechas")
            Return False
        End Try

        If f1 > f2 Then
            MsgBox("La fecha 'Desde' debe ser anterior o igual a la fecha 'Hasta'.", _
                   MsgBoxStyle.Critical, "Rango incorrecto")
            cbFechaDesde.Focus() : Return False
        End If
        If f2 > Date.Today Then
            MsgBox("La fecha 'Hasta' no puede ser posterior a hoy.", _
                   MsgBoxStyle.Critical, "Fecha futura no válida")
            cbFechaHasta.Focus() : Return False
        End If

        Return True
    End Function
#End Region


#Region "Exportación a Excel"

    Public Sub GeneraExcel(ByVal fecha1 As Date, ByVal fecha2 As Date)

        Dim f As New Filter()
        f.Add("FECHA_FACTURA", FilterOperator.GreaterThanOrEqual, fecha1)
        f.Add("FECHA_FACTURA", FilterOperator.LessThanOrEqual, fecha2)

        Dim dt As DataTable = New BE.DataEngine().Filter("vListadoFactVencimientos", f)
        If dt.Rows.Count = 0 Then
            MsgBox("No hay registros en el rango seleccionado.", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim dlg As New SaveFileDialog() With { _
            .Title = "Guardar listado", _
            .Filter = "Excel (*.xlsx)|*.xlsx", _
            .FileName = "Vencimientos_" & Format(Now, "yyyyMMdd") & ".xlsx", _
            .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) _
        }
        If dlg.ShowDialog() <> DialogResult.OK Then Exit Sub
        Dim ruta As String = dlg.FileName

        Dim xl As Excel.Application = Nothing
        Dim wb As Excel.Workbook = Nothing
        Dim ws As Excel.Worksheet = Nothing

        Try
            xl = New Excel.Application : xl.Visible = False
            wb = xl.Workbooks.Add()
            ws = CType(wb.Sheets(1), Excel.Worksheet)
            ws.Name = "Listado1"

            'Cabeceras
            For c As Integer = 0 To dt.Columns.Count - 1
                ws.Cells(1, c + 1).Value = dt.Columns(c).ColumnName
                ws.Cells(1, c + 1).Font.Bold = True
            Next

            'Datos
            Dim data(dt.Rows.Count - 1, dt.Columns.Count - 1) As Object
            For r As Integer = 0 To dt.Rows.Count - 1
                For c As Integer = 0 To dt.Columns.Count - 1
                    data(r, c) = dt.Rows(r)(c)
                Next
            Next
            ws.Range("A2").Resize(dt.Rows.Count, dt.Columns.Count).Value = data
            ws.Columns.AutoFit()

            '--- 1. Autofiltro seguro --------------------------------------
            If ws.AutoFilterMode Then ws.AutoFilterMode = False
            ws.Rows(1).AutoFilter()        'solo la fila de cabecera

            '--- 2. Formato moneda -----------------------------------------
            Dim colImp As Integer = dt.Columns("IMPORTE_FACT").Ordinal + 1
            ws.Columns(colImp).NumberFormat = "#,##0.00 €"

            '--- 3. Freeze cabecera ----------------------------------------
            ws.Activate()                  'asegura ventana activa
            xl.ActiveWindow.SplitRow = 1
            xl.ActiveWindow.FreezePanes = True

            wb.SaveAs(ruta)
            MsgBox("Excel exportado correctamente.", _
                   MsgBoxStyle.Information, "Exportación OK")

        Catch ex As Exception
            MsgBox("ERROR al exportar:" & vbCrLf & ex.Message, _
                   MsgBoxStyle.Critical, "Exportar a Excel")

        Finally
            If wb IsNot Nothing Then wb.Close(False)
            If xl IsNot Nothing Then xl.Quit()
            ReleaseCom(ws) : ReleaseCom(wb) : ReleaseCom(xl)
        End Try
    End Sub

#End Region


#Region "Utilidades COM"

    Private Sub ReleaseCom(ByRef obj As Object)
        Try
            If obj IsNot Nothing AndAlso _
               Runtime.InteropServices.Marshal.IsComObject(obj) Then
                Runtime.InteropServices.Marshal.FinalReleaseComObject(obj)
            End If
        Finally
            obj = Nothing
        End Try
    End Sub

#End Region

End Class
