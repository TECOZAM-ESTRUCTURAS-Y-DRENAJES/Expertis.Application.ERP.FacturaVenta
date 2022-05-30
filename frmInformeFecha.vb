Imports Janus.Windows.GridEX
Public Class frmInformeFecha
    Inherits Solmicro.Expertis.Engine.UI.FormBase

    Public blEstado As Boolean
    Public fecha1 As Date
    Public fecha2 As Date
    Public dtObrasSelect As DataTable
    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        cargarGridObras()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'IBIS. David. 02/06/2010. Controlado esto, ya que daba errores.
        If FechaDesde.Text = "" Or FechaHasta.Text = "" Then
            ExpertisApp.GenerateMessage("Debe indicar fechas para poder continuar o pulse Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'VM = Nz(fwiMes.Value, 0)
        fecha1 = Nz(FechaDesde.Value, "01-01-1979")
        'VA = Nz(fwiAno.Value, 0)
        fecha2 = Nz(FechaHasta.Value, "31-12-2040")
        crearDataTableObras()

        blEstado = False
        Me.Close()
    End Sub
    Public Sub cargarGridObras()
        Dim f As New Filter
        Dim dtObras As DataTable = New BE.DataEngine().Filter("tbObraCabecera", f, "IDObra,NObra,DescObra")
        'Recorro la tabla para solo sacar las que no tengan alq-
        Dim cont As Integer = 0
        For Each dr As DataRow In dtObras.Rows
            If (dtObras(cont)("NObra").ToString.Contains("ALQ") Or dtObras(cont)("NObra").ToString.Contains("alq")) Then
                dr.Delete()
            End If
            cont += 1
        Next
        gridObras.DataSource = dtObras
        'gridObras.UseCheck = True

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        blEstado = True
        Me.Close()
    End Sub
    Public Sub crearDataTableObras()
        Dim dt As DataTable = New DataTable
        Dim dc As New DataColumn("NObra")
        dt.Columns.Add(dc)
        For Each row As GridEXRow In gridObras.GetCheckedRows
            Dim drG As DataRow = dt.NewRow
            Dim nObra As String = row.Cells.Item("NObra").Value
            drG.Item("NObra") = nObra
            dt.Rows.Add(drG)

        Next
        dtObrasSelect = dt

    End Sub
End Class