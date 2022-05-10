Public Class frmLogos
    Inherits Solmicro.Expertis.Engine.UI.FormBase

    Public blEstado As Boolean
    Public opcion As String = ""
    Public nFacturaAct As Integer = 0



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        blEstado = False
        ' Control de Nº de factura
        If CInt(hFactura.Text) < CInt(DdFactura.Text) Or CInt(hFactura.Text) < 0 Then
            MsgBox("Debe de indicar un Nº factura hasta mayor que 0 y que el Nº factura desde.", MsgBoxStyle.Exclamation, "Control de rango de facturas.")
            hFactura.Focus()
            Exit Sub
        End If
        If CInt(DdFactura.Text) < 0 Then
            MsgBox("El Nº de factura desde debe ser mayor que 0.", MsgBoxStyle.Exclamation, "Control de rango de facturas.")
            DdFactura.Focus()
            Exit Sub
        End If
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        blEstado = True
        Me.Close()
    End Sub

    Private Sub frmLogos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RadioButton1.Checked = True
        DdFactura.Enabled = False
        hfactura.Enabled = False

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

        If True Then
            DdFactura.Enabled = True
            hfactura.Enabled = True

        End If

    End Sub
End Class