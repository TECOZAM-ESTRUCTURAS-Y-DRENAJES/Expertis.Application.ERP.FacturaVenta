Public Class frmComunicarGestorCobro

    Private Sub frmComunicarGestorCobro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cbxFechaComunicacionGestorCobro.Value = Date.Today
    End Sub

    Private Sub advIDProveedor_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles advIDProveedor.SelectionChanged
        advIDOperario.Text = String.Empty
    End Sub
    Private Sub advIDProveedor_NotInList(ByVal sender As Object, ByVal e As Engine.UI.NotInListEventArgs) Handles advIDProveedor.NotInList
        e.Cancel = True
    End Sub
    
    Private Sub advIDOperario_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles advIDOperario.SelectionChanged
        advIDProveedor.Text = String.Empty
    End Sub
    Private Sub advIDOperario_NotInList(ByVal sender As Object, ByVal e As Engine.UI.NotInListEventArgs) Handles advIDOperario.NotInList
        e.Cancel = True
    End Sub

    Private Sub cmbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.None
        If Length(advIDProveedor.Text) = 0 AndAlso Length(advIDOperario.Text) = 0 Then
            ExpertisApp.GenerateMessage("Debe de indicar un Gestor.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Length(cbxFechaComunicacionGestorCobro.Value) = 0 Then
            ExpertisApp.GenerateMessage("Debe de indicar una Fecha de Comunicación.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

End Class