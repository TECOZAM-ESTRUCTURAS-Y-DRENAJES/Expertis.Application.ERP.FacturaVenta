Public Class MntoOficinaContable

    Private Sub Grid_AddingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Grid.AddingRecord
        Dim DtOficinas As DataTable = Me.Grid.DataSource
        Dim DrFind() As DataRow = DtOficinas.Select("IDOficinaContable = '" & Me.Grid.GetValue("IDOficinaContable") & "'")
        If DrFind.Length > 0 Then
            ExpertisApp.GenerateMessage("La Oficina Contable | ya existe en la tabla.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Me.Grid.GetValue("IDOficinaContable"))
            e.Cancel = True
        End If
    End Sub

    Private Sub Grid_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        If Me.Grid.Row <> Me.Grid.newTopRowPosition Then
            If e.Column.Key = "IDOficinaContable" Then
                e.Cancel = True
            End If
        End If
    End Sub

End Class