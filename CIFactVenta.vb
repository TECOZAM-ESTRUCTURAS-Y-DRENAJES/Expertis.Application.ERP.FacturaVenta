Imports Janus.Windows.GridEX

Public Class CIFactVenta
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        txtImporteDesde.Value = System.DBNull.Value
        txtImporteHasta.Value = System.DBNull.Value
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
    Friend WithEvents lblfwiEstado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblTotal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTotalA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents AdvFacturaDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblFacturaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvFacturaHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblFacturaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblImpDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblImpHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblContador As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxEjercicio As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblEjercicio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxContabilizado As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblContabilizado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvContador As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents txtImporteHasta As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents txtImporteDesde As Solmicro.Expertis.Engine.UI.NumericTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim Grid_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim cbxEjercicio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIFactVenta))
        Dim cbxContabilizado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.AdvFacturaDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFacturaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvFacturaHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFacturaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.lblImpDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.lblImpHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.lblContador = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxEjercicio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblEjercicio = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxContabilizado = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblContabilizado = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiEstado = New Solmicro.Expertis.Engine.UI.Label
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.AdvContador = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblTotal = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImporteHasta = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImporteDesde = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.cbxEjercicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxContabilizado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.suspendlayout()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.txtImporteHasta)
        Me.FilterPanel.Controls.Add(Me.txtImporteDesde)
        Me.FilterPanel.Controls.Add(Me.AdvContador)
        Me.FilterPanel.Controls.Add(Me.lblFacturaDesde)
        Me.FilterPanel.Controls.Add(Me.lblFacturaHasta)
        Me.FilterPanel.Controls.Add(Me.lblFechaDesde)
        Me.FilterPanel.Controls.Add(Me.lblFechaHasta)
        Me.FilterPanel.Controls.Add(Me.lblCliente)
        Me.FilterPanel.Controls.Add(Me.lblImpDesde)
        Me.FilterPanel.Controls.Add(Me.lblImpHasta)
        Me.FilterPanel.Controls.Add(Me.lblContador)
        Me.FilterPanel.Controls.Add(Me.lblEjercicio)
        Me.FilterPanel.Controls.Add(Me.lblContabilizado)
        Me.FilterPanel.Controls.Add(Me.lblfwiEstado)
        Me.FilterPanel.Controls.Add(Me.AdvFacturaDesde)
        Me.FilterPanel.Controls.Add(Me.AdvFacturaHasta)
        Me.FilterPanel.Controls.Add(Me.cbxFechaDesde)
        Me.FilterPanel.Controls.Add(Me.cbxFechaHasta)
        Me.FilterPanel.Controls.Add(Me.AdvCliente)
        Me.FilterPanel.Controls.Add(Me.cbxEjercicio)
        Me.FilterPanel.Controls.Add(Me.cbxContabilizado)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 205)
        Me.FilterPanel.Size = New System.Drawing.Size(624, 128)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Controls.Add(Me.Panel1)
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(624, 205)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Panel1, 0)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Grid, 0)
        '
        'Grid
        '
        Grid_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("Grid_DesignTimeLayout_Reference_0.Instance"), Object)
        Grid_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {Grid_DesignTimeLayout_Reference_0})
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EntityName = "FacturaVentaCabecera"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.ImageList = Me.ImageList1
        Me.Grid.KeyField = "IDFactura"
        Me.Grid.Size = New System.Drawing.Size(624, 173)
        Me.Grid.TabIndex = 12
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "vCtlCIFactVenta"
        '
        'CheckAll
        '
        Me.CheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.CheckAll.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'UncheckAll
        '
        Me.UncheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.UncheckAll.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.ShowAllCheckedItems.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'ClearFilter
        '
        Me.ClearFilter.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Export
        '
        Me.Export.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Toolbar
        '
        Me.Toolbar.Size = New System.Drawing.Size(320, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(624, 333)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(624, 333)
        '
        'AdvFacturaDesde
        '
        Me.AdvFacturaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.AdvFacturaDesde.EntityName = "FacturaVentaCabecera"
        Me.AdvFacturaDesde.Location = New System.Drawing.Point(101, 23)
        Me.AdvFacturaDesde.Name = "AdvFacturaDesde"
        Me.AdvFacturaDesde.PrimaryDataFields = "NFactura"
        Me.AdvFacturaDesde.SecondaryDataFields = "NFactura"
        Me.AdvFacturaDesde.Size = New System.Drawing.Size(112, 23)
        Me.AdvFacturaDesde.TabIndex = 1
        Me.AdvFacturaDesde.ViewName = "tbFacturaVentaCabecera"
        '
        'lblFacturaDesde
        '
        Me.lblFacturaDesde.Location = New System.Drawing.Point(8, 23)
        Me.lblFacturaDesde.Name = "lblFacturaDesde"
        Me.lblFacturaDesde.Size = New System.Drawing.Size(87, 13)
        Me.lblFacturaDesde.TabIndex = 0
        Me.lblFacturaDesde.Tag = "IdRec=4776;"
        Me.lblFacturaDesde.Text = "Nº Ftra Desde"
        '
        'AdvFacturaHasta
        '
        Me.AdvFacturaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.AdvFacturaHasta.EntityName = "FacturaVentaCabecera"
        Me.AdvFacturaHasta.Location = New System.Drawing.Point(101, 47)
        Me.AdvFacturaHasta.Name = "AdvFacturaHasta"
        Me.AdvFacturaHasta.PrimaryDataFields = "NFactura"
        Me.AdvFacturaHasta.SecondaryDataFields = "NFactura"
        Me.AdvFacturaHasta.Size = New System.Drawing.Size(112, 23)
        Me.AdvFacturaHasta.TabIndex = 2
        Me.AdvFacturaHasta.ViewName = "tbFacturaVentaCabecera"
        '
        'lblFacturaHasta
        '
        Me.lblFacturaHasta.Location = New System.Drawing.Point(8, 47)
        Me.lblFacturaHasta.Name = "lblFacturaHasta"
        Me.lblFacturaHasta.Size = New System.Drawing.Size(83, 13)
        Me.lblFacturaHasta.TabIndex = 2
        Me.lblFacturaHasta.Tag = "IdRec=4775;"
        Me.lblFacturaHasta.Text = "Nº Ftra Hasta"
        '
        'cbxFechaDesde
        '
        Me.cbxFechaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaDesde.Location = New System.Drawing.Point(296, 23)
        Me.cbxFechaDesde.Name = "cbxFechaDesde"
        Me.cbxFechaDesde.Size = New System.Drawing.Size(115, 21)
        Me.cbxFechaDesde.TabIndex = 4
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.Location = New System.Drawing.Point(216, 23)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(80, 13)
        Me.lblFechaDesde.TabIndex = 4
        Me.lblFechaDesde.Tag = "IdRec=4727;"
        Me.lblFechaDesde.Text = "Fecha Desde"
        '
        'cbxFechaHasta
        '
        Me.cbxFechaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaHasta.Location = New System.Drawing.Point(296, 48)
        Me.cbxFechaHasta.Name = "cbxFechaHasta"
        Me.cbxFechaHasta.Size = New System.Drawing.Size(115, 21)
        Me.cbxFechaHasta.TabIndex = 5
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.Location = New System.Drawing.Point(216, 48)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(76, 13)
        Me.lblFechaHasta.TabIndex = 5
        Me.lblFechaHasta.Tag = "IdRec=4726;"
        Me.lblFechaHasta.Text = "Fecha Hasta"
        '
        'AdvCliente
        '
        Me.AdvCliente.DisabledBackColor = System.Drawing.Color.White
        Me.AdvCliente.EntityName = "Cliente"
        Me.AdvCliente.Location = New System.Drawing.Point(101, 71)
        Me.AdvCliente.Name = "AdvCliente"
        Me.AdvCliente.PrimaryDataFields = "IDCliente"
        Me.AdvCliente.SecondaryDataFields = "IDCliente"
        Me.AdvCliente.Size = New System.Drawing.Size(112, 23)
        Me.AdvCliente.TabIndex = 3
        Me.AdvCliente.ViewName = "tbMaestroCliente"
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(8, 71)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblCliente.TabIndex = 6
        Me.lblCliente.Tag = "IdRec=4365;"
        Me.lblCliente.Text = "Cliente"
        '
        'lblImpDesde
        '
        Me.lblImpDesde.Location = New System.Drawing.Point(216, 72)
        Me.lblImpDesde.Name = "lblImpDesde"
        Me.lblImpDesde.Size = New System.Drawing.Size(75, 13)
        Me.lblImpDesde.TabIndex = 8
        Me.lblImpDesde.Tag = "IdRec=4778;"
        Me.lblImpDesde.Text = "Importe >="
        '
        'lblImpHasta
        '
        Me.lblImpHasta.Location = New System.Drawing.Point(216, 96)
        Me.lblImpHasta.Name = "lblImpHasta"
        Me.lblImpHasta.Size = New System.Drawing.Size(75, 13)
        Me.lblImpHasta.TabIndex = 9
        Me.lblImpHasta.Tag = "IdRec=4780;"
        Me.lblImpHasta.Text = "Importe <="
        '
        'lblContador
        '
        Me.lblContador.Location = New System.Drawing.Point(424, 23)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(60, 13)
        Me.lblContador.TabIndex = 10
        Me.lblContador.Tag = "IdRec=4809;"
        Me.lblContador.Text = "Contador"
        '
        'cbxEjercicio
        '
        cbxEjercicio_DesignTimeLayout.LayoutString = resources.GetString("cbxEjercicio_DesignTimeLayout.LayoutString")
        Me.cbxEjercicio.DesignTimeLayout = cbxEjercicio_DesignTimeLayout
        Me.cbxEjercicio.DisabledBackColor = System.Drawing.Color.White
        Me.cbxEjercicio.EntityName = "EjercicioContable"
        Me.cbxEjercicio.Location = New System.Drawing.Point(512, 72)
        Me.cbxEjercicio.Name = "cbxEjercicio"
        Me.cbxEjercicio.SecondaryDataFields = "IDEjercicio"
        Me.cbxEjercicio.SelectedIndex = -1
        Me.cbxEjercicio.SelectedItem = Nothing
        Me.cbxEjercicio.Size = New System.Drawing.Size(103, 21)
        Me.cbxEjercicio.TabIndex = 0
        '
        'lblEjercicio
        '
        Me.lblEjercicio.Location = New System.Drawing.Point(424, 72)
        Me.lblEjercicio.Name = "lblEjercicio"
        Me.lblEjercicio.Size = New System.Drawing.Size(55, 13)
        Me.lblEjercicio.TabIndex = 11
        Me.lblEjercicio.Tag = "IdRec=4467;"
        Me.lblEjercicio.Text = "Ejercicio"
        '
        'cbxContabilizado
        '
        Me.cbxContabilizado.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        cbxContabilizado_DesignTimeLayout.LayoutString = resources.GetString("cbxContabilizado_DesignTimeLayout.LayoutString")
        Me.cbxContabilizado.DesignTimeLayout = cbxContabilizado_DesignTimeLayout
        Me.cbxContabilizado.DisabledBackColor = System.Drawing.Color.White
        Me.cbxContabilizado.Location = New System.Drawing.Point(512, 48)
        Me.cbxContabilizado.Name = "cbxContabilizado"
        Me.cbxContabilizado.SelectedIndex = -1
        Me.cbxContabilizado.SelectedItem = Nothing
        Me.cbxContabilizado.Size = New System.Drawing.Size(104, 21)
        Me.cbxContabilizado.TabIndex = 9
        '
        'lblContabilizado
        '
        Me.lblContabilizado.Location = New System.Drawing.Point(424, 48)
        Me.lblContabilizado.Name = "lblContabilizado"
        Me.lblContabilizado.Size = New System.Drawing.Size(84, 13)
        Me.lblContabilizado.TabIndex = 12
        Me.lblContabilizado.Tag = "IdRec=4725;"
        Me.lblContabilizado.Text = "Contabilizado"
        '
        'lblfwiEstado
        '
        Me.lblfwiEstado.Location = New System.Drawing.Point(392, 360)
        Me.lblfwiEstado.Name = "lblfwiEstado"
        Me.lblfwiEstado.Size = New System.Drawing.Size(59, 13)
        Me.lblfwiEstado.TabIndex = 14
        Me.lblfwiEstado.Tag = "IdRec=4781;"
        Me.lblfwiEstado.Text = "Situación"
        '
        'AdvContador
        '
        Me.AdvContador.DisabledBackColor = System.Drawing.Color.White
        Me.AdvContador.DisplayField = "IDContador"
        Me.AdvContador.EntityName = "EntidadContador"
        Me.AdvContador.Location = New System.Drawing.Point(512, 23)
        Me.AdvContador.Name = "AdvContador"
        Me.AdvContador.SecondaryDataFields = "IDContador"
        Me.AdvContador.Size = New System.Drawing.Size(104, 23)
        Me.AdvContador.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblTotal)
        Me.Panel1.Controls.Add(Me.txtTotalA)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 173)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(624, 32)
        Me.Panel1.TabIndex = 2
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(448, 8)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 16
        Me.lblTotal.Text = "Total"
        '
        'txtTotalA
        '
        Me.txtTotalA.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalA.Enabled = False
        Me.txtTotalA.Location = New System.Drawing.Point(499, 6)
        Me.txtTotalA.Name = "txtTotalA"
        Me.txtTotalA.Size = New System.Drawing.Size(120, 21)
        Me.txtTotalA.TabIndex = 15
        '
        'txtImporteHasta
        '
        Me.txtImporteHasta.DisabledBackColor = System.Drawing.Color.White
        Me.txtImporteHasta.Location = New System.Drawing.Point(296, 96)
        Me.txtImporteHasta.Name = "txtImporteHasta"
        Me.txtImporteHasta.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtImporteHasta.Size = New System.Drawing.Size(115, 21)
        Me.txtImporteHasta.TabIndex = 7
        '
        'txtImporteDesde
        '
        Me.txtImporteDesde.DisabledBackColor = System.Drawing.Color.White
        Me.txtImporteDesde.Location = New System.Drawing.Point(296, 72)
        Me.txtImporteDesde.Name = "txtImporteDesde"
        Me.txtImporteDesde.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtImporteDesde.Size = New System.Drawing.Size(115, 21)
        Me.txtImporteDesde.TabIndex = 6
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "add2.ico")
        Me.ImageList1.Images.SetKeyName(1, "delete2.ico")
        Me.ImageList1.Images.SetKeyName(2, "scroll_warning.ico")
        '
        'CIFactVenta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(632, 421)
        Me.EntityName = "FacturaVentaCabecera"
        Me.KeyField = "IDFactura"
        Me.Name = "CIFactVenta"
        Me.UseCheck = True
        Me.ViewName = "vCtlCIFactVenta"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.cbxEjercicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxContabilizado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Enum IconIndex
        NoContabilizado = 0
        Contabilizado = 1
        ExistenEntregas = 2
    End Enum

    Private mMonedaA As MonedaInfo
    Private Const mstrEntidad As String = "FacturaVentaCabecera"
    Public MBlnContabilidad As Boolean

#Region " Load "

    Protected Overridable Sub CIFactVenta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.DesignMode = False Then
            LoadERPData()
            LoadEnums()
            LoadToolbarActions()
            LoadGridActions()
        End If
    End Sub

    Private Sub LoadERPData()
        Dim m As New Moneda
        mMonedaA = ExpertisApp.ExecuteTask(Of Date, MonedaInfo)(AddressOf Moneda.MonedaA, cnMinDate)
        Dim ClsParam As New Parametro
        MBlnContabilidad = ClsParam.Contabilidad
        If ClsParam.ExpertisSAAS Then Grid.Columns("EntregasACuenta").Visible = False
        If Not MBlnContabilidad Then
            lblContabilizado.Text = ExpertisApp.Traslate("Validada")
            cbxEjercicio.Visible = False
            lblEjercicio.Visible = False
        End If
    End Sub

    Private Sub LoadEnums()
        Dim ClsParam As New Parametro
        If ClsParam.DobleContabilidad Then
            cbxContabilizado.DataSource = New EnumData("enumContabilizadoTodos")
            cbxContabilizado.Value = enumContabilizadoTodos.NoContabilizado
        Else
            cbxContabilizado.DataSource = New EnumData("enumSiNo")
            cbxContabilizado.Value = enumBoolean.No
        End If


    End Sub

    Private Sub LoadToolbarActions()
        If MBlnContabilidad Then
            Me.FormActions.Add("Contabilizar", AddressOf AccionContabilizar, ExpertisApp.GetIcon("import1.ico"))
            Me.FormActions.Add("Descontabilizar", AddressOf AccionDescontabilizar, ExpertisApp.GetIcon("export1.ico"))
        Else
            Me.FormActions.Add("Validar Factura y crear Cobros en cartera", AddressOf AccionContabilizar, ExpertisApp.GetIcon("import1.ico"))
            Me.FormActions.Add("Modificar Factura y eliminar Cobros en cartera", AddressOf AccionDescontabilizar, ExpertisApp.GetIcon("export1.ico"))
        End If
    End Sub

    Private Sub LoadGridActions()
        Me.Grid.Actions.Add("Abrir Factura", AddressOf AccionAbrirFactura, ExpertisApp.GetIcon("xFacturaVenta.ico"))
        Me.Grid.Actions.Add("Abrir Cliente", AddressOf AccionAbrirCliente, ExpertisApp.GetIcon("xClientes.ico"))
    End Sub

#End Region

#Region " Toolbar Actions "

    Protected Overridable Sub AccionContabilizar()
        Dim dtMarcados As DataTable = Me.CheckedRecords
        If Not dtMarcados Is Nothing AndAlso dtMarcados.Rows.Count > 0 Then
            Dim G As Guid = Grid.SaveServerChecks()
            Dim mstrIDProcess As String = G.ToString
            Dim de As New BE.DataEngine
            Dim dt As DataTable = de.Filter("CtlCIFactVentaContValidacion", New StringFilterItem("IDProcess", FilterOperator.Equal, mstrIDProcess))
            If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
                If MBlnContabilidad Then
                    ExpertisApp.GenerateMessage("Existen facturas seleccionadas contabilizadas o pertenecientes a un ejercicio cerrado que no intervendrán en el proceso.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    ExpertisApp.GenerateMessage("Existen facturas seleccionadas ya validadas.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Exit Sub
            End If
            If MBlnContabilidad Then
                Dim SimInfo As New DataSimulacionContableInfo
                SimInfo.TipoContabilizacion = enumTipoContabilizacion.tcFacturaVenta
                SimInfo.IDEjercicio = String.Empty
                SimInfo.GuidSimulacion = G
                SimInfo.Caption = "Simulación Contable - FACTURAS VENTA -"
                Dim oFrm As Form = ExpertisApp.OpenForm("CISIMUCONT", , SimInfo, Me)
                AddHandler oFrm.Closed, AddressOf FrmActionClosed
            Else
                Dim StrIDS(dtMarcados.Rows.Count - 1) As String
                Dim j As Integer = 0
                For Each Dr As DataRow In dtMarcados.Select
                    StrIDS(j) = Dr("IDFactura")
                    j += 1
                Next
                Dim FilDatos As New Filter
                FilDatos.Add(New InListFilterItem("IDFactura", StrIDS, FilterType.Numeric))
                Dim StData As New FacturaVentaCabecera.DataContabilizacion
                StData.FilFact = FilDatos : StData.Estado = CInt(enumfvcEstado.fvcContabilizado)
                If ExpertisApp.ExecuteTask(Of FacturaVentaCabecera.DataContabilizacion, Boolean)(AddressOf FacturaVentaCabecera.CambiarEstadoContabFacturas, StData) Then
                    ExpertisApp.GenerateMessage("Facturas seleccionadas Validadas y Cobros Generados.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Me.UnCheckAllRecords()
                Me.Execute()
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
  
    Private Sub AccionDescontabilizar()
        Dim dtGrid As DataTable = Me.CheckedRecords
        If Not dtGrid Is Nothing AndAlso dtGrid.Rows.Count > 0 Then
            Dim mIDProcess As Guid = Grid.SaveServerChecks()
            ' Dim mstrIDProcess As String = mIDProcess.ToString

            Dim BEDataEngine As New BE.DataEngine

            Dim dt As DataTable = BEDataEngine.Filter("CtlCIFactVentaDescontValidacion", New GuidFilterItem("IDProcess", FilterOperator.Equal, mIDProcess))
            BEDataEngine = Nothing
            If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
                If MBlnContabilidad Then
                    ExpertisApp.GenerateMessage("Existen facturas seleccionadas descontabilizadas o pertenecientes a un ejercicio cerrado que no intervendrán en el proceso.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    ExpertisApp.GenerateMessage("Existen facturas seleccionadas que ya son modificables.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Exit Sub
            End If
            If MBlnContabilidad Then

                Dim frm As New frmDescontabilizar
                frm.IDProcess = mIDProcess
                frm.ShowDialog()
            Else
                Dim StrIDs(dtGrid.Rows.Count - 1) As String
                Dim j As Integer = 0
                For Each Dr As DataRow In dtGrid.Select
                    StrIDs(j) = Dr("IDFactura")
                    j += 1
                Next
                Dim FilDatos As New Filter
                FilDatos.Add(New InListFilterItem("IDFactura", StrIDs, FilterType.Numeric))
                Dim StData As New FacturaVentaCabecera.DataContabilizacion
                StData.FilFact = FilDatos : StData.Estado = CInt(enumfvcEstado.fvcNoContabilizado)
                If ExpertisApp.ExecuteTask(Of FacturaVentaCabecera.DataContabilizacion, Boolean)(AddressOf FacturaVentaCabecera.CambiarEstadoContabFacturas, StData) Then
                    ExpertisApp.GenerateMessage("Puede modificar su factura, recuerde validar de nuevo para crear los cobros.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

            UnCheckAllRecords()
            Me.Execute()

        Else

            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub FrmActionClosed(ByVal sender As Object, ByVal e As System.EventArgs)
        RemoveHandler CType(sender, Form).Closed, AddressOf FrmActionClosed
        If CType(sender, Form).DialogResult = DialogResult.OK Then
            Me.UnCheckAllRecords()
            Me.DeleteServerChecks()
            Me.Execute()
        End If
    End Sub

   

#End Region

#Region " Grid Actions "

    Private Sub AccionAbrirFactura()
        If Length(Grid.GetValue("IDFactura")) > 0 Then
            ExpertisApp.OpenForm("MFACTV", New NumberFilterItem("IDFactura", Grid.GetValue("IDFactura")))
        End If
    End Sub

    Private Sub AccionAbrirCliente()
        If Length(Grid.GetValue("IDCliente")) > 0 Then
            ExpertisApp.OpenForm("MCLIENTE", New StringFilterItem("IDCliente", Grid.GetValue("IDCliente")))
        End If
    End Sub

#End Region

#Region " Grid "

    Private Sub Grid_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
        If e.Row.RowType = RowType.Record Then
            If e.Row.Cells("Estado").Value = enumfvcEstado.fvcContabilizado Then
                e.Row.RowStyle = Grid.FormatStyles("ContabilizadoFormatStyle")
                e.Row.Cells("Estado").ImageIndex = IconIndex.Contabilizado
            Else
                e.Row.Cells("Estado").ImageIndex = IconIndex.NoContabilizado
            End If
            If CBool(e.Row.Cells("EntregasACuenta").Value) Then 'Entregas a Cuenta Cliente
                e.Row.Cells("EntregasACuenta").ImageIndex = IconIndex.ExistenEntregas
            Else
                e.Row.Cells("EntregasACuenta").ImageIndex = 3
            End If
        End If
    End Sub

    Private Sub Grid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.Click
        Dim objArea As Janus.Windows.GridEX.GridArea = Grid.HitTest()
        If objArea = Janus.Windows.GridEX.GridArea.Cell Then
            Dim objCol As Janus.Windows.GridEX.GridEXColumn = Grid.ColumnFromPoint()
            If Not IsNothing(objCol) Then
                Select Case objCol.Key
                    Case "EntregasACuenta"
                        If Grid.Value("EntregasACuenta") Then
                            Dim frmVerEntregas As New frmVerEntregasACuenta
                            frmVerEntregas.AñadirEntregas = False
                            frmVerEntregas.CircuitoOrigen = Circuito.Ventas
                            frmVerEntregas.IDClienteProveedor = Grid.Value("IDCliente")
                            frmVerEntregas.DescClienteProveedor = Grid.Value("DescCliente")
                            frmVerEntregas.ShowDialog(Me)
                        End If
                End Select
            End If
        End If
    End Sub

#End Region

    Private Sub AdvContador_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvContador.SetPredefinedFilter
        e.Filter.Add("Entidad", FilterOperator.Equal, mstrEntidad)
    End Sub

    Private Sub AdvFacturaDesde_Hasta_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvFacturaDesde.SetPredefinedFilter, AdvFacturaHasta.SetPredefinedFilter
        If Length(cbxEjercicio.Value) > 0 Then
            e.Filter.Add("IDEjercicio", FilterOperator.Equal, cbxEjercicio.Value, FilterType.String)
        End If
    End Sub

    Private Sub AdvFacturaDesde_SelectionChanged(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvFacturaDesde.SelectionChanged
        AdvFacturaHasta.Text = AdvFacturaDesde.Text
    End Sub

    Private Sub cbxFechaDesde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxFechaDesde.ValueChanged
        If IsDate(cbxFechaHasta.Value) Then
            cbxFechaHasta.Value = cbxFechaDesde.Value
        End If
    End Sub

#Region " Query Execute "

    Private Sub CIFactVenta_FilterClearing(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterClearing
        cbxContabilizado.Value = enumBoolean.No
        cbxFechaDesde.TextBox.Clear()
        cbxFechaHasta.TextBox.Clear()
    End Sub

    Private Sub CIFactVenta_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("NFactura", FilterOperator.GreaterThanOrEqual, AdvFacturaDesde.Text, FilterType.String)
        e.Filter.Add("NFactura", FilterOperator.LessThanOrEqual, AdvFacturaHasta.Text, FilterType.String)
        e.Filter.Add("ImpTotalA", FilterOperator.GreaterThanOrEqual, txtImporteDesde.Value, FilterType.Numeric)
        e.Filter.Add("ImpTotalA", FilterOperator.LessThanOrEqual, txtImporteHasta.Value, FilterType.Numeric)
        e.Filter.Add("FechaFactura", FilterOperator.GreaterThanOrEqual, cbxFechaDesde.Value, FilterType.DateTime)
        e.Filter.Add("FechaFactura", FilterOperator.LessThanOrEqual, cbxFechaHasta.Value, FilterType.DateTime)
        If Length(AdvCliente.Text) > 0 Then
            e.Filter.Add(New LikeFilterItem("IDCliente", AdvCliente.Text))
        End If
        If Length(AdvContador.Text) > 0 Then
            e.Filter.Add(New LikeFilterItem("IDContador", AdvContador.Text))
        End If
        If Length(cbxEjercicio.Text) > 0 Then
            e.Filter.Add(New LikeFilterItem("IDEjercicio", cbxEjercicio.Text))
        End If

        If cbxContabilizado.Value <> enumContabilizadoTodos.Todos Then

            e.Filter.Add("Estado", FilterOperator.Equal, cbxContabilizado.Value, FilterType.Numeric)
        End If

    End Sub

    Private Sub CIFactVenta_QueryExecuted(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutedEventArgs) Handles MyBase.QueryExecuted
        txtTotalA.Value = xRound(Grid.GetTotal(Grid.Columns("ImpTotalA"), AggregateFunction.Sum), mMonedaA.NDecimalesImporte)
    End Sub

#End Region

#Region " Informes "

    Private Sub CIFactVenta_SetReportDataSource(ByVal sender As Object, ByVal e As Engine.UI.ReportDataSourceEventArgs) Handles MyBase.SetReportDataSource
        e.AuxiliarTableSettings.CopiesSource = "NumeroCopias"
    End Sub

#End Region

End Class
