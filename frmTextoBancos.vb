Public Class frmTextoBancos

    Public banco As String
    Public fvencimiento As String

    Private Sub frmTextoBancos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        Dim f As New Filter
        dt = New BE.DataEngine().Filter("tbMaestroBancosFacturaVenta", f)

        Dim dtBancos As New DataTable
        dtBancos.Columns.Add("Banco")

        Dim fila As DataRow
        For Each dr As DataRow In dt.Rows
            fila = dtBancos.NewRow()
            fila("Banco") = dr("Banco")
            dtBancos.Rows.Add(fila)
        Next

        cbBancos.DataSource = dtBancos
        cbBancos.ValueMember = "Banco"
        cbBancos.DisplayMember = "Banco"
    End Sub

    Private Sub bCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCancelar.Click
        Me.Close()
    End Sub

    Private Sub bAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAceptar.Click
        banco = cbBancos.Value.ToString
        fvencimiento = cbFechaV.Value.ToString
        If Len(banco) = 0 Or Len(fvencimiento) = 0 Then
            MsgBox("Los dos campos son obligatorios.")
        Else
            Me.Close()
        End If
    End Sub
End Class