Public Class MntoUnidadTramitadora

    Private Sub Grid_AddingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Grid.AddingRecord
        Dim DtUnidades As DataTable = Me.Grid.DataSource
        Dim DrFind() As DataRow = DtUnidades.Select("IDUnidadTramitadora = '" & Me.Grid.GetValue("IDUnidadTramitadora") & "'")
        If DrFind.Length > 0 Then
            ExpertisApp.GenerateMessage("La Unidad | ya está introducida en la tabla.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Me.Grid.GetValue("IDUnidadTramitadora"))
            e.Cancel = True
        End If
    End Sub

    Private Sub Grid_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        If Grid.Row <> Grid.newTopRowPosition Then
            If e.Column.Key = "IDUnidadTramitadora" Then
                e.Cancel = True
            End If
        End If
    End Sub

End Class