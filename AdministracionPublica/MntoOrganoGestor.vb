Public Class MntoOrganoGestor

    Private Sub Grid_AddingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Grid.AddingRecord
        Dim DtOrganos As DataTable = Me.Grid.DataSource
        Dim DrFind() As DataRow = DtOrganos.Select("IDOrganoGestor = '" & Me.Grid.GetValue("IDOrganoGestor") & "'")
        If DrFind.Length > 0 Then
            ExpertisApp.GenerateMessage("El Órgano Gestor | ya existe en la tabla.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Me.Grid.GetValue("IDOrganoGestor"))
            e.Cancel = True
        End If
    End Sub

    Private Sub Grid_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        If Grid.Row <> Grid.newTopRowPosition Then
            If e.Column.Key = "IDOrganoGestor" Then
                e.Cancel = True
            End If
        End If
    End Sub

End Class