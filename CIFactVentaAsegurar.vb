Imports Janus.Windows.GridEX

Public Class CIFactVentaAsegurar
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
    Friend WithEvents lblAsegurada As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxAsegurada As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblEntidadAseguradora As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxEntAseg As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents txtImporteHasta As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents lblEmpresa As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cboEmpresa As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblContabilizado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxAsegurable As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents txtImporteDesde As Solmicro.Expertis.Engine.UI.NumericTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxAsegurada_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxEntAseg_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cboEmpresa_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxAsegurable_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIFactVentaAsegurar))
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
        Me.lblfwiEstado = New Solmicro.Expertis.Engine.UI.Label
        Me.lblAsegurada = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxAsegurada = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblEntidadAseguradora = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxEntAseg = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblTotal = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImporteHasta = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImporteDesde = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lblEmpresa = New Solmicro.Expertis.Engine.UI.Label
        Me.cboEmpresa = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblContabilizado = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxAsegurable = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.cbxAsegurada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxEntAseg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.suspendlayout()
        CType(Me.cboEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxAsegurable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.lblContabilizado)
        Me.FilterPanel.Controls.Add(Me.cbxAsegurable)
        Me.FilterPanel.Controls.Add(Me.lblEmpresa)
        Me.FilterPanel.Controls.Add(Me.cboEmpresa)
        Me.FilterPanel.Controls.Add(Me.txtImporteHasta)
        Me.FilterPanel.Controls.Add(Me.txtImporteDesde)
        Me.FilterPanel.Controls.Add(Me.lblEntidadAseguradora)
        Me.FilterPanel.Controls.Add(Me.lblAsegurada)
        Me.FilterPanel.Controls.Add(Me.lblFacturaDesde)
        Me.FilterPanel.Controls.Add(Me.lblFacturaHasta)
        Me.FilterPanel.Controls.Add(Me.lblFechaDesde)
        Me.FilterPanel.Controls.Add(Me.lblFechaHasta)
        Me.FilterPanel.Controls.Add(Me.lblCliente)
        Me.FilterPanel.Controls.Add(Me.lblImpDesde)
        Me.FilterPanel.Controls.Add(Me.lblImpHasta)
        Me.FilterPanel.Controls.Add(Me.lblfwiEstado)
        Me.FilterPanel.Controls.Add(Me.cbxEntAseg)
        Me.FilterPanel.Controls.Add(Me.cbxAsegurada)
        Me.FilterPanel.Controls.Add(Me.AdvFacturaDesde)
        Me.FilterPanel.Controls.Add(Me.AdvFacturaHasta)
        Me.FilterPanel.Controls.Add(Me.cbxFechaDesde)
        Me.FilterPanel.Controls.Add(Me.cbxFechaHasta)
        Me.FilterPanel.Controls.Add(Me.AdvCliente)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 206)
        Me.FilterPanel.Size = New System.Drawing.Size(624, 127)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Controls.Add(Me.Panel1)
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(624, 206)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Panel1, 0)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Grid, 0)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "FacturaVentaCabecera"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.ImageList = Me.ImageList1
        Me.Grid.KeyField = "IDFactura;Empresa"
        Me.Grid.Size = New System.Drawing.Size(624, 174)
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
        Me.AdvFacturaDesde.Location = New System.Drawing.Point(96, 23)
        Me.AdvFacturaDesde.Name = "AdvFacturaDesde"
        Me.AdvFacturaDesde.PrimaryDataFields = "NFactura"
        Me.AdvFacturaDesde.SecondaryDataFields = "NFactura"
        Me.AdvFacturaDesde.Size = New System.Drawing.Size(114, 23)
        Me.AdvFacturaDesde.TabIndex = 0
        Me.AdvFacturaDesde.ViewName = "tbFacturaVentaCabecera"
        '
        'lblFacturaDesde
        '
        Me.lblFacturaDesde.Location = New System.Drawing.Point(8, 28)
        Me.lblFacturaDesde.Name = "lblFacturaDesde"
        Me.lblFacturaDesde.Size = New System.Drawing.Size(87, 13)
        Me.lblFacturaDesde.TabIndex = 0
        Me.lblFacturaDesde.Tag = "IdRec=4776;"
        Me.lblFacturaDesde.Text = "Nº Fra. Desde"
        '
        'AdvFacturaHasta
        '
        Me.AdvFacturaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.AdvFacturaHasta.EntityName = "FacturaVentaCabecera"
        Me.AdvFacturaHasta.Location = New System.Drawing.Point(96, 47)
        Me.AdvFacturaHasta.Name = "AdvFacturaHasta"
        Me.AdvFacturaHasta.PrimaryDataFields = "NFactura"
        Me.AdvFacturaHasta.SecondaryDataFields = "NFactura"
        Me.AdvFacturaHasta.Size = New System.Drawing.Size(114, 23)
        Me.AdvFacturaHasta.TabIndex = 1
        Me.AdvFacturaHasta.ViewName = "tbFacturaVentaCabecera"
        '
        'lblFacturaHasta
        '
        Me.lblFacturaHasta.Location = New System.Drawing.Point(8, 52)
        Me.lblFacturaHasta.Name = "lblFacturaHasta"
        Me.lblFacturaHasta.Size = New System.Drawing.Size(83, 13)
        Me.lblFacturaHasta.TabIndex = 2
        Me.lblFacturaHasta.Tag = "IdRec=4775;"
        Me.lblFacturaHasta.Text = "Nº Fra. Hasta"
        '
        'cbxFechaDesde
        '
        Me.cbxFechaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaDesde.Location = New System.Drawing.Point(296, 23)
        Me.cbxFechaDesde.Name = "cbxFechaDesde"
        Me.cbxFechaDesde.Size = New System.Drawing.Size(115, 21)
        Me.cbxFechaDesde.TabIndex = 3
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.Location = New System.Drawing.Point(216, 27)
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
        Me.cbxFechaHasta.TabIndex = 4
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.Location = New System.Drawing.Point(216, 52)
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
        Me.AdvCliente.Location = New System.Drawing.Point(96, 71)
        Me.AdvCliente.Name = "AdvCliente"
        Me.AdvCliente.PrimaryDataFields = "IDCliente"
        Me.AdvCliente.SecondaryDataFields = "IDCliente"
        Me.AdvCliente.Size = New System.Drawing.Size(114, 23)
        Me.AdvCliente.TabIndex = 2
        Me.AdvCliente.ViewName = "tbMaestroCliente"
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(8, 76)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblCliente.TabIndex = 6
        Me.lblCliente.Tag = "IdRec=4365;"
        Me.lblCliente.Text = "Cliente"
        '
        'lblImpDesde
        '
        Me.lblImpDesde.Location = New System.Drawing.Point(216, 76)
        Me.lblImpDesde.Name = "lblImpDesde"
        Me.lblImpDesde.Size = New System.Drawing.Size(75, 13)
        Me.lblImpDesde.TabIndex = 8
        Me.lblImpDesde.Tag = "IdRec=4778;"
        Me.lblImpDesde.Text = "Importe >="
        '
        'lblImpHasta
        '
        Me.lblImpHasta.Location = New System.Drawing.Point(424, 76)
        Me.lblImpHasta.Name = "lblImpHasta"
        Me.lblImpHasta.Size = New System.Drawing.Size(75, 13)
        Me.lblImpHasta.TabIndex = 9
        Me.lblImpHasta.Tag = "IdRec=4780;"
        Me.lblImpHasta.Text = "Importe <="
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
        'lblAsegurada
        '
        Me.lblAsegurada.Location = New System.Drawing.Point(424, 51)
        Me.lblAsegurada.Name = "lblAsegurada"
        Me.lblAsegurada.Size = New System.Drawing.Size(68, 13)
        Me.lblAsegurada.TabIndex = 19
        Me.lblAsegurada.Tag = "IdRec=11023;"
        Me.lblAsegurada.Text = "Asegurada"
        '
        'cbxAsegurada
        '
        Me.cbxAsegurada.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        cbxAsegurada_DesignTimeLayout.LayoutString = resources.GetString("cbxAsegurada_DesignTimeLayout.LayoutString")
        Me.cbxAsegurada.DesignTimeLayout = cbxAsegurada_DesignTimeLayout
        Me.cbxAsegurada.DisabledBackColor = System.Drawing.Color.White
        Me.cbxAsegurada.Location = New System.Drawing.Point(512, 47)
        Me.cbxAsegurada.Name = "cbxAsegurada"
        Me.cbxAsegurada.SelectedIndex = -1
        Me.cbxAsegurada.SelectedItem = Nothing
        Me.cbxAsegurada.Size = New System.Drawing.Size(104, 21)
        Me.cbxAsegurada.TabIndex = 8
        '
        'lblEntidadAseguradora
        '
        Me.lblEntidadAseguradora.Location = New System.Drawing.Point(424, 27)
        Me.lblEntidadAseguradora.Name = "lblEntidadAseguradora"
        Me.lblEntidadAseguradora.Size = New System.Drawing.Size(85, 13)
        Me.lblEntidadAseguradora.TabIndex = 21
        Me.lblEntidadAseguradora.Tag = ""
        Me.lblEntidadAseguradora.Text = "Entidad Aseg."
        '
        'cbxEntAseg
        '
        Me.cbxEntAseg.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        cbxEntAseg_DesignTimeLayout.LayoutString = resources.GetString("cbxEntAseg_DesignTimeLayout.LayoutString")
        Me.cbxEntAseg.DesignTimeLayout = cbxEntAseg_DesignTimeLayout
        Me.cbxEntAseg.DisabledBackColor = System.Drawing.Color.White
        Me.cbxEntAseg.EntityName = "Aseguradora"
        Me.cbxEntAseg.Location = New System.Drawing.Point(512, 23)
        Me.cbxEntAseg.Name = "cbxEntAseg"
        Me.cbxEntAseg.SecondaryDataFields = "IDAseguradora"
        Me.cbxEntAseg.SelectedIndex = -1
        Me.cbxEntAseg.SelectedItem = Nothing
        Me.cbxEntAseg.Size = New System.Drawing.Size(104, 21)
        Me.cbxEntAseg.TabIndex = 7
        Me.cbxEntAseg.ViewName = "tbMaestroAseguradora"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblTotal)
        Me.Panel1.Controls.Add(Me.txtTotalA)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 174)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(624, 32)
        Me.Panel1.TabIndex = 2
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(448, 10)
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
        Me.txtImporteHasta.Location = New System.Drawing.Point(512, 72)
        Me.txtImporteHasta.Name = "txtImporteHasta"
        Me.txtImporteHasta.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtImporteHasta.Size = New System.Drawing.Size(104, 21)
        Me.txtImporteHasta.TabIndex = 9
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
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'lblEmpresa
        '
        Me.lblEmpresa.Location = New System.Drawing.Point(424, 101)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(57, 13)
        Me.lblEmpresa.TabIndex = 23
        Me.lblEmpresa.Tag = ""
        Me.lblEmpresa.Text = "Empresa"
        '
        'cboEmpresa
        '
        cboEmpresa_DesignTimeLayout.LayoutString = resources.GetString("cboEmpresa_DesignTimeLayout.LayoutString")
        Me.cboEmpresa.DesignTimeLayout = cboEmpresa_DesignTimeLayout
        Me.cboEmpresa.DisabledBackColor = System.Drawing.Color.White
        Me.cboEmpresa.DisplayMember = "DescBaseDatos"
        Me.cboEmpresa.Location = New System.Drawing.Point(512, 97)
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.SelectedIndex = -1
        Me.cboEmpresa.SelectedItem = Nothing
        Me.cboEmpresa.Size = New System.Drawing.Size(104, 21)
        Me.cboEmpresa.TabIndex = 22
        Me.cboEmpresa.ValueMember = "IDBaseDatos"
        '
        'lblContabilizado
        '
        Me.lblContabilizado.Location = New System.Drawing.Point(216, 101)
        Me.lblContabilizado.Name = "lblContabilizado"
        Me.lblContabilizado.Size = New System.Drawing.Size(71, 13)
        Me.lblContabilizado.TabIndex = 25
        Me.lblContabilizado.Tag = "IdRec=4725;"
        Me.lblContabilizado.Text = "Asegurable"
        '
        'cbxAsegurable
        '
        Me.cbxAsegurable.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        cbxAsegurable_DesignTimeLayout.LayoutString = resources.GetString("cbxAsegurable_DesignTimeLayout.LayoutString")
        Me.cbxAsegurable.DesignTimeLayout = cbxAsegurable_DesignTimeLayout
        Me.cbxAsegurable.DisabledBackColor = System.Drawing.Color.White
        Me.cbxAsegurable.Location = New System.Drawing.Point(296, 96)
        Me.cbxAsegurable.Name = "cbxAsegurable"
        Me.cbxAsegurable.SelectedIndex = -1
        Me.cbxAsegurable.SelectedItem = Nothing
        Me.cbxAsegurable.Size = New System.Drawing.Size(115, 21)
        Me.cbxAsegurable.TabIndex = 24
        '
        'CIFactVentaAsegurar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(632, 421)
        Me.EntityName = "FacturaVentaCabecera"
        Me.KeyField = "IDFactura;Empresa"
        Me.Name = "CIFactVentaAsegurar"
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
        CType(Me.cbxAsegurada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxEntAseg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cboEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxAsegurable, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private MBlnContabilidad As Boolean

#Region " Load "

    'Private Sub CIFactVentaAsegurar_CheckingRecord(ByVal sender As Object, ByVal e As Engine.UI.CheckingEventArgs) Handles Me.CheckingRecord
    '    If Length(e.Row.DataRow("IDMotivoNoAsegurado")) > 0 Then
    '        e.Cancel = True
    '    End If
    'End Sub

    Private Sub CIFactVenta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.DesignMode = False Then
            LoadERPData()
            LoadEnums()
            LoadToolbarActions()
            LoadGridActions()
            LoadEmpresas()
        End If
    End Sub

    Private Sub LoadEmpresas()
        Me.cboEmpresa.DataSource = New Comunes().GetUserDataBase
    End Sub

    Private Sub LoadERPData()
        Dim m As New Moneda
        mMonedaA = ExpertisApp.ExecuteTask(Of Date, MonedaInfo)(AddressOf Moneda.MonedaA, cnMinDate)

        Dim dtMotivos As DataTable = New MotivoNoAsegurado().Filter()
        Grid.Columns("IDMotivoNoAsegurado").DropDown.SetDataBinding(dtMotivos, Nothing)
        Grid.Columns("IDMotivoNoAsegurado").EditType = Janus.Windows.GridEX.EditType.MultiColumnCombo
    End Sub

    Private Sub LoadEnums()
        cbxAsegurada.DataSource = New EnumData(GetType(enumBoolean))
        cbxAsegurada.Value = enumBoolean.No

        cbxAsegurable.DataSource = New EnumData(GetType(enumBoolean))
        cbxAsegurable.Value = enumBoolean.Todos
    End Sub

    Private Sub LoadToolbarActions()
        Me.FormActions.Add("Declaración de ventas a entidad aseguradora", AddressOf AccionDeclaracion)
    End Sub

    Private Sub LoadGridActions()
        Me.Grid.Actions.Add("Abrir Factura", AddressOf AccionAbrirFactura, ExpertisApp.GetIcon("xFacturaVenta.ico"))
        Me.Grid.Actions.Add("Abrir Cliente", AddressOf AccionAbrirCliente, ExpertisApp.GetIcon("xClientes.ico"))
    End Sub

#End Region

#Region " Toolbar Actions "



    Private Sub FrmActionClosed(ByVal sender As Object, ByVal e As System.EventArgs)
        RemoveHandler CType(sender, Form).Closed, AddressOf FrmActionClosed
        If CType(sender, Form).DialogResult = DialogResult.OK Then
            Me.UnCheckAllRecords()
            Me.DeleteServerChecks()
            Me.Execute()
        End If
    End Sub

    Private Sub AccionDeclaracion()

        Dim dtMarcados As DataTable = Me.CheckedRecords
        If Not dtMarcados Is Nothing AndAlso dtMarcados.Rows.Count > 0 Then
            'Dim mIDProcess As Guid
            'Dim mstrIDProcess As String

            'mIDProcess = Grid.SaveServerChecks()
            'mstrIDProcess = mIDProcess.ToString
            Dim StData As New FacturaVentaCabecera.DataDeclaracion
            StData.IdProcess = Nothing : StData.dt = dtMarcados
            Dim strCliente As String = ExpertisApp.ExecuteTask(Of FacturaVentaCabecera.DataDeclaracion, String)(AddressOf FacturaVentaCabecera.AccionDeclaracion, StData)
            If Length(strCliente) > 0 Then
                ExpertisApp.GenerateMessage("Riesgo superado en los clientes: |", MessageBoxButtons.OK, MessageBoxIcon.Information, strCliente)
            End If
        Else
            ExpertisApp.GenerateMessage("Proceso cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
       
        UnCheckAllRecords()
        Me.Execute()
    End Sub

#End Region

#Region " Grid Actions "

    Private Sub AccionAbrirFactura()
        If Me.Grid.GetValue("Empresa") = ExpertisApp.Token.DataBase.DataBaseName Then
            If Length(Grid.GetValue("IDFactura")) > 0 Then
                ExpertisApp.OpenForm("MFACTV", New NumberFilterItem("IDFactura", Grid.GetValue("IDFactura")))
            End If
        End If
    End Sub

    Private Sub AccionAbrirCliente()
        If Me.Grid.GetValue("Empresa") = ExpertisApp.Token.DataBase.DataBaseName Then
            If Length(Grid.GetValue("IDCliente")) > 0 Then
                ExpertisApp.OpenForm("MCLIENTE", New StringFilterItem("IDCliente", Grid.GetValue("IDCliente")))
            End If
        End If
    End Sub

#End Region

#Region " Grid "

    'Private Sub Grid_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
    '    If e.Row.RowType = RowType.Record Then
    '        If e.Row.Cells("Estado").Value = enumfvcEstado.fvcContabilizado Then
    '            e.Row.RowStyle = Grid.FormatStyles("ContabilizadoFormatStyle")
    '            e.Row.Cells("Estado").ImageIndex = IconIndex.Contabilizado
    '        Else
    '            e.Row.Cells("Estado").ImageIndex = IconIndex.NoContabilizado
    '        End If
    '        If CBool(e.Row.Cells("EntregasACuenta").Value) Then 'Entregas a Cuenta Cliente
    '            e.Row.Cells("EntregasACuenta").ImageIndex = IconIndex.ExistenEntregas
    '        End If
    '    End If
    'End Sub

    Private Sub Grid_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        Select Case e.Column.Key
            Case "IDMotivoNoAsegurado"
                e.Cancel = True
        End Select
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

    Private Sub AdvContador_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs)
        e.Filter.Add("Entidad", FilterOperator.Equal, mstrEntidad)
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
        cbxAsegurada.Value = enumBoolean.Todos
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
        
        If cbxAsegurada.Value <> enumBoolean.Todos Then
            e.Filter.Add("EnviadaEntidadAseguradora", FilterOperator.Equal, cbxAsegurada.Value, FilterType.Numeric)
        End If

        If cbxAsegurable.Value <> enumBoolean.Todos Then
            e.Filter.Add("Asegurable", FilterOperator.Equal, cbxAsegurable.Value, FilterType.Boolean)
        End If
        If Length(cbxEntAseg.Value) > 0 Then
            e.Filter.Add(New LikeFilterItem("IDAseguradora", cbxEntAseg.Value))
            'Else
            '    e.Filter.Add(New IsNullFilterItem("IDAseguradora", False))
        End If


        e.Cancel = True

        Dim fEmpresasOrigen As New Filter
        If Length(Me.cboEmpresa.Value) > 0 Then fEmpresasOrigen.Add(New GuidFilterItem("IDBaseDatos", Me.cboEmpresa.Value))

        Dim DtGrid As New DataTable
        Dim QueryMultipleDB As New GetQueryMultipleDB
        Dim data As New BEGetQueryMultipleDB.DataGetQueryMultipleDB(Me.ViewName, e.Filter.InnerFilter, fEmpresasOrigen, True)
        DtGrid = QueryMultipleDB.Execute(data)

        Me.Grid.DataSource = Nothing
        Me.Grid.AddCheckColumnToDataSource(DtGrid, Nothing)
        If Me.Grid.RootTable.Groups.Count = 0 Then
            Me.Grid.Columns("Empresa").Visible = True
            Me.Grid.RootTable.Groups.Clear()
            Dim GrpEmpresa As New Janus.Windows.GridEX.GridEXGroup
            GrpEmpresa.Column = Me.Grid.Columns("Empresa")
            GrpEmpresa.GroupPrefix = "Empresa:"
            GrpEmpresa.HeaderCaption = "Empresa"
            GrpEmpresa.SortOrder = Janus.Windows.GridEX.SortOrder.Ascending
            Me.Grid.RootTable.Groups.Add(GrpEmpresa)
        End If
        Me.BindEditEvents(DtGrid)
        Me.Grid.DataSource = DtGrid
        '//Calculamos aqui el total, por que al cancelar no salta el evento de QueryExecuted
        txtTotalA.Value = xRound(Grid.GetTotal(Grid.Columns("ImpTotalA"), AggregateFunction.Sum), mMonedaA.NDecimalesImporte)
        For i As Integer = 0 To Me.UiCommandManager1.Commands.Count - 1
            Me.UiCommandManager1.Commands(i).Enabled = Janus.Windows.UI.InheritableBoolean.True
        Next
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