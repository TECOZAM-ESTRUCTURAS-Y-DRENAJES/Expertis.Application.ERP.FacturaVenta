Public Class frmDescontabilizar
    Inherits Solmicro.Expertis.Engine.UI.FormBase

#Region " Propiedades "

    Private mIDProcess As Guid
    Public WriteOnly Property IDProcess() As Guid
        Set(ByVal Value As Guid)
            mIDProcess = Value
        End Set
    End Property

#End Region

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents jngApuntesCobros As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents jngApuntesFact As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents cmdAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmdCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents jngFacturas As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents jngCobros As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents lblfwiCobros As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiFacturas As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiApuntesFact As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiApuntesCobros As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiSituacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblcfwiSituacion As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents fwiSituacion As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim jngApuntesCobros_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDescontabilizar))
        Dim jngApuntesFact_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim jngFacturas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim jngCobros_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim fwiSituacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.jngApuntesCobros = New Solmicro.Expertis.Engine.UI.Grid
        Me.jngApuntesFact = New Solmicro.Expertis.Engine.UI.Grid
        Me.cmdAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.jngFacturas = New Solmicro.Expertis.Engine.UI.Grid
        Me.jngCobros = New Solmicro.Expertis.Engine.UI.Grid
        Me.lblfwiCobros = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiFacturas = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiApuntesFact = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiApuntesCobros = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiSituacion = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcfwiSituacion = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.fwiSituacion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.Splitter1 = New System.Windows.Forms.Splitter
        CType(Me.jngApuntesCobros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jngApuntesFact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jngFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jngCobros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fwiSituacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'jngApuntesCobros
        '
        Me.jngApuntesCobros.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngApuntesCobros.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngApuntesCobros.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        jngApuntesCobros_DesignTimeLayout.LayoutString = resources.GetString("jngApuntesCobros_DesignTimeLayout.LayoutString")
        Me.jngApuntesCobros.DesignTimeLayout = jngApuntesCobros_DesignTimeLayout
        Me.jngApuntesCobros.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngApuntesCobros.EntityName = "DiarioContable"
        Me.jngApuntesCobros.Location = New System.Drawing.Point(4, 376)
        Me.jngApuntesCobros.Name = "jngApuntesCobros"
        Me.jngApuntesCobros.PrimaryDataFields = Nothing
        Me.jngApuntesCobros.RequeryManually = True
        Me.jngApuntesCobros.SecondaryDataFields = Nothing
        Me.jngApuntesCobros.Size = New System.Drawing.Size(600, 124)
        Me.jngApuntesCobros.TabIndex = 9
        Me.jngApuntesCobros.Tag = "IdRec=5455:5456:5666:5457:5458:4737:4738:5459:6583:4865:;"
        Me.jngApuntesCobros.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngApuntesCobros.ViewName = "vfrmFactVentaDescontApunteCobro"
        '
        'jngApuntesFact
        '
        Me.jngApuntesFact.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngApuntesFact.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngApuntesFact.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        jngApuntesFact_DesignTimeLayout.LayoutString = resources.GetString("jngApuntesFact_DesignTimeLayout.LayoutString")
        Me.jngApuntesFact.DesignTimeLayout = jngApuntesFact_DesignTimeLayout
        Me.jngApuntesFact.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngApuntesFact.EntityName = "DiarioContable"
        Me.jngApuntesFact.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jngApuntesFact.Location = New System.Drawing.Point(4, 144)
        Me.jngApuntesFact.Name = "jngApuntesFact"
        Me.jngApuntesFact.PrimaryDataFields = Nothing
        Me.jngApuntesFact.RequeryManually = True
        Me.jngApuntesFact.SecondaryDataFields = Nothing
        Me.jngApuntesFact.Size = New System.Drawing.Size(600, 108)
        Me.jngApuntesFact.TabIndex = 8
        Me.jngApuntesFact.Tag = "IdRec=5455:5456:4951:5457:5458:4737:4738:5459:4467:4865:;"
        Me.jngApuntesFact.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngApuntesFact.ViewName = "vfrmFactVentaDescontApunte"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(448, 508)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(76, 28)
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(528, 508)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(76, 28)
        Me.cmdCancelar.TabIndex = 1
        Me.cmdCancelar.Text = "Cancelar"
        '
        'jngFacturas
        '
        Me.jngFacturas.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngFacturas.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngFacturas.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        jngFacturas_DesignTimeLayout.LayoutString = resources.GetString("jngFacturas_DesignTimeLayout.LayoutString")
        Me.jngFacturas.DesignTimeLayout = jngFacturas_DesignTimeLayout
        Me.jngFacturas.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngFacturas.EntityName = "FacturaVentaCabecera"
        Me.jngFacturas.Location = New System.Drawing.Point(4, 18)
        Me.jngFacturas.Name = "jngFacturas"
        Me.jngFacturas.PrimaryDataFields = Nothing
        Me.jngFacturas.RequeryManually = True
        Me.jngFacturas.SecondaryDataFields = Nothing
        Me.jngFacturas.Size = New System.Drawing.Size(600, 106)
        Me.jngFacturas.TabIndex = 0
        Me.jngFacturas.Tag = "IdRec=5453:5433:6267:4763:4467:5454:4352:5043:4664:4398:5058:9465:9466:;"
        Me.jngFacturas.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngFacturas.ViewName = "frmFactVentaDescont"
        '
        'jngCobros
        '
        Me.jngCobros.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngCobros.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngCobros.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        jngCobros_DesignTimeLayout.LayoutString = resources.GetString("jngCobros_DesignTimeLayout.LayoutString")
        Me.jngCobros.DesignTimeLayout = jngCobros_DesignTimeLayout
        Me.jngCobros.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngCobros.EntityName = "Cobro"
        Me.jngCobros.Location = New System.Drawing.Point(4, 270)
        Me.jngCobros.Name = "jngCobros"
        Me.jngCobros.PrimaryDataFields = Nothing
        Me.jngCobros.RequeryManually = True
        Me.jngCobros.SecondaryDataFields = Nothing
        Me.jngCobros.Size = New System.Drawing.Size(600, 89)
        Me.jngCobros.TabIndex = 3
        Me.jngCobros.Tag = "IdRec=5029:6267:8125:6583:5454:5461:4398:4715:;"
        Me.jngCobros.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngCobros.ViewName = "vfrmFactVentaDescontCobro"
        '
        'lblfwiCobros
        '
        Me.lblfwiCobros.Location = New System.Drawing.Point(8, 257)
        Me.lblfwiCobros.Name = "lblfwiCobros"
        Me.lblfwiCobros.Size = New System.Drawing.Size(53, 13)
        Me.lblfwiCobros.TabIndex = 10
        Me.lblfwiCobros.Tag = "IdRec=5030;"
        Me.lblfwiCobros.Text = "Cobros:"
        '
        'lblfwiFacturas
        '
        Me.lblfwiFacturas.Location = New System.Drawing.Point(8, 4)
        Me.lblfwiFacturas.Name = "lblfwiFacturas"
        Me.lblfwiFacturas.Size = New System.Drawing.Size(143, 13)
        Me.lblfwiFacturas.TabIndex = 11
        Me.lblfwiFacturas.Tag = "IdRec=5031;"
        Me.lblfwiFacturas.Text = "Facturas seleccionadas:"
        '
        'lblfwiApuntesFact
        '
        Me.lblfwiApuntesFact.Location = New System.Drawing.Point(8, 129)
        Me.lblfwiApuntesFact.Name = "lblfwiApuntesFact"
        Me.lblfwiApuntesFact.Size = New System.Drawing.Size(148, 13)
        Me.lblfwiApuntesFact.TabIndex = 12
        Me.lblfwiApuntesFact.Tag = "IdRec=5032;"
        Me.lblfwiApuntesFact.Text = "Apuntes de las Facturas:"
        '
        'lblfwiApuntesCobros
        '
        Me.lblfwiApuntesCobros.Location = New System.Drawing.Point(8, 362)
        Me.lblfwiApuntesCobros.Name = "lblfwiApuntesCobros"
        Me.lblfwiApuntesCobros.Size = New System.Drawing.Size(141, 13)
        Me.lblfwiApuntesCobros.TabIndex = 13
        Me.lblfwiApuntesCobros.Tag = "IdRec=5033;"
        Me.lblfwiApuntesCobros.Text = "Apuntes de los Cobros:"
        '
        'lblfwiSituacion
        '
        Me.lblfwiSituacion.AutoSize = False
        Me.lblfwiSituacion.Location = New System.Drawing.Point(6, 507)
        Me.lblfwiSituacion.Name = "lblfwiSituacion"
        Me.lblfwiSituacion.Size = New System.Drawing.Size(154, 29)
        Me.lblfwiSituacion.TabIndex = 14
        Me.lblfwiSituacion.Tag = "IdRec=5097;"
        Me.lblfwiSituacion.Text = "Cambiar la situación de los Cobros a..."
        '
        'lblcfwiSituacion
        '
        Me.TryDataBinding(lblcfwiSituacion, New System.Windows.Forms.Binding("Text", Me.fwiSituacion, "DescEstado", True))
        Me.lblcfwiSituacion.Location = New System.Drawing.Point(223, 507)
        Me.lblcfwiSituacion.Name = "lblcfwiSituacion"
        Me.lblcfwiSituacion.Size = New System.Drawing.Size(209, 22)
        Me.lblcfwiSituacion.TabIndex = 15
        '
        'fwiSituacion
        '
        fwiSituacion_DesignTimeLayout.LayoutString = resources.GetString("fwiSituacion_DesignTimeLayout.LayoutString")
        Me.fwiSituacion.DesignTimeLayout = fwiSituacion_DesignTimeLayout
        Me.fwiSituacion.DisabledBackColor = System.Drawing.Color.White
        Me.fwiSituacion.EntityName = "EstadoCobro"
        Me.fwiSituacion.Location = New System.Drawing.Point(167, 507)
        Me.fwiSituacion.Name = "fwiSituacion"
        Me.fwiSituacion.PrimaryDataFields = "IDEstado"
        Me.fwiSituacion.SecondaryDataFields = "IDEstado"
        Me.fwiSituacion.SelectedIndex = -1
        Me.fwiSituacion.SelectedItem = Nothing
        Me.fwiSituacion.Size = New System.Drawing.Size(53, 21)
        Me.fwiSituacion.TabIndex = 16
        Me.fwiSituacion.ViewName = "cmbEstadoCobro"
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 541)
        Me.Splitter1.TabIndex = 17
        Me.Splitter1.TabStop = False
        '
        'frmDescontabilizar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(608, 541)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.fwiSituacion)
        Me.Controls.Add(Me.jngApuntesCobros)
        Me.Controls.Add(Me.jngApuntesFact)
        Me.Controls.Add(Me.jngFacturas)
        Me.Controls.Add(Me.jngCobros)
        Me.Controls.Add(Me.lblfwiCobros)
        Me.Controls.Add(Me.lblfwiFacturas)
        Me.Controls.Add(Me.lblfwiApuntesFact)
        Me.Controls.Add(Me.lblfwiApuntesCobros)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.lblfwiSituacion)
        Me.Controls.Add(Me.lblcfwiSituacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDescontabilizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Descontabilización de Facturas de Venta"
        CType(Me.jngApuntesCobros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jngApuntesFact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jngFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jngCobros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fwiSituacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private mstrIdFactura As String
    Private mstrIdCobro As String
    Private mContabilidadMultiple As Boolean

#Region " Carga del formulario "

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            'intAccion = enumAccion.Cancelar

            Dim objNegParametro As New Parametro
            mContabilidadMultiple = objNegParametro.ContabilidadMultiple
            fwiSituacion.Text = objNegParametro.CobroDescontSituacion
            objNegParametro = Nothing

            '// Se visualizan las facturas marcadas.
            Dim oFilter As New Filter
            With jngFacturas
                oFilter.Add(New GuidFilterItem("IdProcess", FilterOperator.Equal, mIDProcess))
                .Filter = oFilter
                .ReQuery()
            End With

            '// Se cargan el resto de los grids.
            CargarGrids()
        End If
    End Sub

    Private Sub CargarGrids()
        Dim oFilter As New Filter
        Dim objSortKey As Janus.Windows.GridEX.GridEXSortKey

        '//CARGAR APUNTES DE LA FACTURAS
        With jngApuntesFact
            'Filtro
            oFilter.Clear()
            oFilter.Add(New NumberFilterItem("IDTipoApunte", FilterOperator.Equal, enumDiarioTipoApunte.FactV))
            oFilter.Add(FiltrarGrid("IdDocumento", "IdFactura", "NDocumento", jngFacturas.DataSource, True))
            .Filter = oFilter
            'Ordenación
            objSortKey = New Janus.Windows.GridEX.GridEXSortKey
            objSortKey.Column = .Columns("NDocumento")
            .RootTable.SortKeys.Clear()
            .RootTable.SortKeys.Add(objSortKey)
            objSortKey = Nothing
            .ReQuery()
        End With

        '//CARGAR CobroS DE LAS FACTURAS
        With jngCobros
            'Filtro
            oFilter.Clear()
            oFilter.Add(FiltrarGrid("IdFactura", "IdFactura", "NFactura", jngFacturas.DataSource))
            .Filter = oFilter
            'Ordenación
            objSortKey = New Janus.Windows.GridEX.GridEXSortKey
            objSortKey.Column = .Columns("NFactura")
            .RootTable.SortKeys.Clear()
            .RootTable.SortKeys.Add(objSortKey)
            objSortKey = Nothing
            .ReQuery()
        End With

        '//CARGAR APUNTES DE LOS CobroS
        If jngCobros.RowCount > 0 Then
            With jngApuntesCobros
                'Filtro

                Dim oFilter1 As New Filter(FilterUnionOperator.Or)
                oFilter1.Add(New NumberFilterItem("IDTipoApunte", FilterOperator.Equal, enumDiarioTipoApunte.Cobro))
                oFilter1.Add(New NumberFilterItem("IDTipoApunte", FilterOperator.Equal, enumDiarioTipoApunte.LiquidacionRemesa))
                oFilter1.Add(New NumberFilterItem("IDTipoApunte", FilterOperator.Equal, enumDiarioTipoApunte.Remesa))
                oFilter1.Add(New NumberFilterItem("IDTipoApunte", FilterOperator.Equal, enumDiarioTipoApunte.RecibidoEfectoClte))
                oFilter1.Add(New NumberFilterItem("IDTipoApunte", FilterOperator.Equal, enumDiarioTipoApunte.Anticipo))
                oFilter1.Add(New NumberFilterItem("IDTipoApunte", FilterOperator.Equal, enumDiarioTipoApunte.CancelacionAnticipo))

                Dim oFilter2 As New Filter
                oFilter2.Add(FiltrarGrid("IdDocumento", "IdCobro", "NDocumento", jngCobros.DataSource, True, True))

                Dim f As New Filter(FilterUnionOperator.And)
                f.Add(oFilter1)
                f.Add(oFilter2)

                .Filter = f
                'Ordenación
                objSortKey = New Janus.Windows.GridEX.GridEXSortKey
                objSortKey.Column = .Columns("NDocumento")
                .RootTable.SortKeys.Clear()
                .RootTable.SortKeys.Add(objSortKey)
                objSortKey = Nothing
                .ReQuery()
            End With
        End If

        oFilter = Nothing
    End Sub

    Private Function FiltrarGrid(ByVal strCampo As String, ByVal strEnlace As String, _
                                ByVal strCampoOrder As String, ByVal dtGrid As DataTable, _
                                Optional ByVal blnDiarioCont As Boolean = False, _
                                Optional ByVal blnCobrosAgrupados As Boolean = False) As Filter

        Dim oFilter As New Filter(FilterUnionOperator.Or)
        Dim row As DataRow
        Dim objFilterCobro As New Filter(FilterUnionOperator.Or)

        If Not dtGrid Is Nothing AndAlso dtGrid.Rows.Count > 0 Then
            For Each row In dtGrid.Rows
                If blnDiarioCont Then
                    Dim oFilterAND As New Filter(FilterUnionOperator.And)
                    '   oFilterAND.Clear()
                    If Length(row("IDEjercicio")) > 0 Then
                        ' oFilterAND.Add(New StringFilterItem("IDEjercicio", FilterOperator.Equal, row("IDEjercicio")))
                        Dim fEjercicio As New Filter(FilterUnionOperator.Or)
                        fEjercicio.Add(New StringFilterItem("IDEjercicio", FilterOperator.Equal, row("IDEjercicio")))
                        If mContabilidadMultiple Then
                            If row.Table.Columns.Contains("IDEjercicioTributario") AndAlso Length(row("IDEjercicioTributario")) > 0 Then fEjercicio.Add(New StringFilterItem("IDEjercicio", FilterOperator.Equal, row("IDEjercicioTributario")))
                        End If

                        oFilterAND.Add(fEjercicio)
                    End If
                    If blnCobrosAgrupados AndAlso Length(row("IDCobroAgrupado")) > 0 AndAlso Length(row("IDEjercicioAgrupado")) > 0 Then
                        ' oFilterAND.Add(New StringFilterItem("IDEjercicio", FilterOperator.Equal, row("IDEjercicio")))
                        Dim fEjercicio As New Filter(FilterUnionOperator.Or)
                        fEjercicio.Add(New StringFilterItem("IDEjercicio", FilterOperator.Equal, row("IDEjercicioAgrupado")))
                        If mContabilidadMultiple Then
                            If row.Table.Columns.Contains("IDEjercicioTributarioAgrupado") AndAlso Length(row("IDEjercicioTributarioAgrupado")) > 0 Then fEjercicio.Add(New StringFilterItem("IDEjercicio", FilterOperator.Equal, row("IDEjercicioTributarioAgrupado")))
                        End If

                        oFilterAND.Add(fEjercicio)
                    End If
                    objFilterCobro.Add(strCampo, FilterOperator.Equal, row(strEnlace))
                    If blnCobrosAgrupados AndAlso Length(row("IDCobroAgrupado")) > 0 Then objFilterCobro.Add(New NumberFilterItem(strCampo, row("IDCobroAgrupado")))
                    oFilterAND.Add(objFilterCobro)
                    oFilter.Add(oFilterAND)
                    oFilterAND = Nothing
                Else
                    Dim oFilterOR As New Filter(FilterUnionOperator.Or)
                    oFilterOR.Add(strCampo, FilterOperator.Equal, row(strEnlace))
                    oFilter.Add(oFilterOR)
                End If
            Next row

        End If

        FiltrarGrid = oFilter
    End Function


#End Region

#Region " Formatero de los Grid "

    Private Sub jngFacturas_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngFacturas.SelectionChanged
        If CType(sender, Grid).SelectedItems.Count > 0 Then
            mstrIdFactura = CType(sender, Grid).SelectedItems(0).GetRow.DataRow("IDFactura")
            jngApuntesFact.Refresh()
            jngCobros.Refresh()
        End If
    End Sub

    Private Sub jngCobros_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngCobros.SelectionChanged
        If CType(sender, Grid).SelectedItems.Count > 0 Then
            mstrIdCobro = CType(sender, Grid).SelectedItems(0).GetRow.DataRow("IDCobro")
            jngApuntesCobros.Refresh()
        End If
    End Sub

    Private Sub jngApuntesFact_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles jngApuntesFact.FormattingRow
        FormatoGrid(sender, e, mstrIdFactura)
    End Sub

    Private Sub jngCobros_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles jngCobros.FormattingRow
        FormatoGrid(sender, e, mstrIdFactura)
    End Sub

    Private Sub jngApuntesCobros_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles jngApuntesCobros.FormattingRow
        FormatoGrid(sender, e, , mstrIdCobro)
    End Sub

    Private Sub FormatoGrid(ByVal objGrid As Grid, _
                         ByRef e As Janus.Windows.GridEX.RowLoadEventArgs, _
                         Optional ByVal strIdFactura As String = "", _
                         Optional ByVal strIdCobro As String = "")

        Select Case objGrid.Name
            Case "jngApuntesFact"
                If strIdFactura <> String.Empty Then
                    If e.Row.DataRow("IdDocumento") = strIdFactura Then
                        e.Row.RowStyle = objGrid.FormatStyles("ResaltadoFormatStyle")
                    Else
                        e.Row.RowStyle = Nothing
                    End If
                End If
            Case "jngCobros"
                If strIdFactura <> String.Empty Then
                    If e.Row.DataRow("IDFactura") = strIdFactura Then
                        e.Row.RowStyle = objGrid.FormatStyles("ResaltadoFormatStyle")
                    Else
                        e.Row.RowStyle = Nothing
                    End If
                End If
            Case "jngApuntesCobros"
                If strIdCobro <> String.Empty Then
                    If e.Row.DataRow("IdDocumento") = strIdCobro Then
                        e.Row.RowStyle = objGrid.FormatStyles("ResaltadoFormatStyle")
                    Else
                        e.Row.RowStyle = Nothing
                    End If
                End If
        End Select

    End Sub

#End Region

#Region " Aceptar/Cancelar "

    Private Sub cmdCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim lngNuevaSituacion As Integer
        Dim dtFact As DataTable
        Dim dtApuntesFact As DataTable
        Dim dtApuntesCobro As DataTable
        Dim objFilter As Filter
        Dim strFiltro As String
        Dim adr() As DataRow

        '//COMPROBAR LAS FACTURAS
        objFilter = New Filter
        With objFilter
            .Clear()
            .UnionOperator = FilterUnionOperator.Or
            .Add(New IsNullFilterItem("NDeclaracionIva", False))
            .Add(New IsNullFilterItem("AñoDeclaracionIva", False))
            strFiltro = .Compose(New AdoFilterComposer)
        End With

        If Not IsNothing(jngFacturas.DataSource) Then
            dtFact = jngFacturas.DataSource.Copy
            'strFiltro = "NDeclaracionIva<>NULL OR AñoDeclaracionIva<>NULL "
            adr = dtFact.Select(strFiltro)
            If Not IsNothing(adr) AndAlso adr.Length > 0 Then
                ExpertisApp.GenerateMessage("Alguna factura seleccionada está declarada. Debe desdeclararla/s antes de descontabilizar. Se cancelará el proceso.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            adr = Nothing

        End If

        '//COMPROBAR LOS APUNTES DE LAS FACTURAS
        With objFilter
            .Clear()
            .Add(New IsNullFilterItem("MesCierre", False))
            strFiltro = .Compose(New AdoFilterComposer)
        End With
        If Not IsNothing(jngApuntesFact.DataSource) Then
            dtApuntesFact = jngApuntesFact.DataSource.Copy
            'strFiltro = "MesCierre<>NULL"   
            adr = dtApuntesFact.Select(strFiltro)
            If Not IsNothing(adr) AndAlso adr.Length > 0 Then
                ExpertisApp.GenerateMessage("Alguna factura está contabilizada en un periodo cerrado.Debe deshacer el cierre de ese periodo para descontabilizar la factura.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            adr = Nothing
        End If


        '//Comprobar si alguno de los Cobros es agrupado.
        Dim objFilterCobroAgrupado As New Filter
        objFilterCobroAgrupado.Add(New IsNullFilterItem("IDCobroAgrupado", False))
        If Not IsNothing(jngCobros.DataSource) AndAlso CType(jngCobros.DataSource, DataTable).Rows.Count > 0 Then
            Dim adrCobrosAgrupados() As DataRow = CType(jngCobros.DataSource, DataTable).Select(objFilterCobroAgrupado.Compose(New AdoFilterComposer))
            If Not IsNothing(adrCobrosAgrupados) AndAlso adrCobrosAgrupados.Length > 0 Then
                ExpertisApp.GenerateMessage("Algún Cobro está Agrupado. No se puede descontabilizar una Factura con Cobros Agrupados. Debe descontabilizar y desagrupar dichos Cobros.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If


        '//COMPROBAR LOSAPUNTES DE LOS CobroS
        If Not IsNothing(jngApuntesCobros.DataSource) Then
            dtApuntesCobro = jngApuntesCobros.DataSource.Copy
            If Not IsNothing(dtApuntesCobro) AndAlso dtApuntesCobro.Rows.Count <> 0 Then
                'strFiltro = "MesCierre<>NULL"
                'adr = dtApuntesCobro.Select(strFiltro)
                'If Not IsNothing(adr) AndAlso adr.Length > 0 Then
                ExpertisApp.GenerateMessage("Deberá primero descontabilizar el cobro correspondiente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            'End If
        End If

        '//Comprobar si alguno de los Cobros ha Generado un Pago
        Dim objFilterCobroGP As New Filter
        objFilterCobroGP.Add(New NumberFilterItem("Situacion", enumCobroSituacion.GeneradoPago))
        If Not IsNothing(jngCobros.DataSource) AndAlso CType(jngCobros.DataSource, DataTable).Rows.Count > 0 Then
            Dim adrCobrosGP() As DataRow = CType(jngCobros.DataSource, DataTable).Select(objFilterCobroGP.Compose(New AdoFilterComposer))
            If Not IsNothing(adrCobrosGP) AndAlso adrCobrosGP.Length > 0 Then
                ExpertisApp.GenerateMessage("Algún Cobro ha Generado un Pago. Debe eliminar el Pago Generado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If


        If ExpertisApp.GenerateMessage("Se eliminarán todos los apuntes contables de las facturas contabilizadas y de los cobros contabilizados seleccionados.¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If (fwiSituacion.Text) = String.Empty Then
                lngNuevaSituacion = -1
            Else
                lngNuevaSituacion = fwiSituacion.Text
            End If

            Dim datDescont As New DataDescontabilizacion(mIDProcess, lngNuevaSituacion)
            ExpertisApp.ExecuteTask(Of DataDescontabilizacion)(AddressOf ContabilizacionFacturaVenta.Descontabilizar, datDescont)
        End If
        Me.Close()

    End Sub

#End Region

End Class
