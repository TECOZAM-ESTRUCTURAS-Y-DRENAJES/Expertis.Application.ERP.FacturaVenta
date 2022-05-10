Imports Janus.Windows.GridEX

Public Class CIFactVentaGestorCobros
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
    Friend WithEvents advNFacturaDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblFacturaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advNFacturaHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblFacturaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblImpDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblImpHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtImporteHasta As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents lblComunicadoGestorCobro As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxFechaComunicacionGestorCobro As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaComunicacionGestorCobro As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblOperario As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDOperario As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblProveedor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDProveedor As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents cbxComunicadoGestorCobro As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents txtImporteDesde As Solmicro.Expertis.Engine.UI.NumericTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxComunicadoGestorCobro_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIFactVentaGestorCobros))
        Me.advNFacturaDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFacturaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.advNFacturaHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFacturaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.lblImpDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.lblImpHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiEstado = New Solmicro.Expertis.Engine.UI.Label
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblTotal = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImporteHasta = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImporteDesde = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lblComunicadoGestorCobro = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaComunicacionGestorCobro = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaComunicacionGestorCobro = New Solmicro.Expertis.Engine.UI.Label
        Me.lblOperario = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDOperario = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDProveedor = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.cbxComunicadoGestorCobro = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.Panel1.suspendlayout()
        CType(Me.cbxComunicadoGestorCobro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.cbxComunicadoGestorCobro)
        Me.FilterPanel.Controls.Add(Me.lblComunicadoGestorCobro)
        Me.FilterPanel.Controls.Add(Me.cbxFechaComunicacionGestorCobro)
        Me.FilterPanel.Controls.Add(Me.lblFechaComunicacionGestorCobro)
        Me.FilterPanel.Controls.Add(Me.lblOperario)
        Me.FilterPanel.Controls.Add(Me.advIDOperario)
        Me.FilterPanel.Controls.Add(Me.lblProveedor)
        Me.FilterPanel.Controls.Add(Me.advIDProveedor)
        Me.FilterPanel.Controls.Add(Me.txtImporteHasta)
        Me.FilterPanel.Controls.Add(Me.txtImporteDesde)
        Me.FilterPanel.Controls.Add(Me.lblFacturaDesde)
        Me.FilterPanel.Controls.Add(Me.lblFacturaHasta)
        Me.FilterPanel.Controls.Add(Me.lblFechaDesde)
        Me.FilterPanel.Controls.Add(Me.lblFechaHasta)
        Me.FilterPanel.Controls.Add(Me.lblCliente)
        Me.FilterPanel.Controls.Add(Me.lblImpDesde)
        Me.FilterPanel.Controls.Add(Me.lblImpHasta)
        Me.FilterPanel.Controls.Add(Me.lblfwiEstado)
        Me.FilterPanel.Controls.Add(Me.advNFacturaDesde)
        Me.FilterPanel.Controls.Add(Me.advNFacturaHasta)
        Me.FilterPanel.Controls.Add(Me.cbxFechaDesde)
        Me.FilterPanel.Controls.Add(Me.cbxFechaHasta)
        Me.FilterPanel.Controls.Add(Me.advIDCliente)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 292)
        Me.FilterPanel.Size = New System.Drawing.Size(970, 103)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Controls.Add(Me.Panel1)
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(970, 292)
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
        Me.Grid.KeyField = "IDFactura"
        Me.Grid.Size = New System.Drawing.Size(970, 260)
        Me.Grid.TabIndex = 12
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "vCIFactVentaGestorCobros"
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
        Me.MainPanel.Size = New System.Drawing.Size(970, 395)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(970, 395)
        '
        'advNFacturaDesde
        '
        Me.advNFacturaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.advNFacturaDesde.EntityName = "FacturaVentaCabecera"
        Me.advNFacturaDesde.Location = New System.Drawing.Point(96, 23)
        Me.advNFacturaDesde.Name = "advNFacturaDesde"
        Me.advNFacturaDesde.PrimaryDataFields = "NFactura"
        Me.advNFacturaDesde.SecondaryDataFields = "NFactura"
        Me.advNFacturaDesde.Size = New System.Drawing.Size(114, 23)
        Me.advNFacturaDesde.TabIndex = 0
        Me.advNFacturaDesde.ViewName = "tbFacturaVentaCabecera"
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
        'advNFacturaHasta
        '
        Me.advNFacturaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.advNFacturaHasta.EntityName = "FacturaVentaCabecera"
        Me.advNFacturaHasta.Location = New System.Drawing.Point(96, 49)
        Me.advNFacturaHasta.Name = "advNFacturaHasta"
        Me.advNFacturaHasta.PrimaryDataFields = "NFactura"
        Me.advNFacturaHasta.SecondaryDataFields = "NFactura"
        Me.advNFacturaHasta.Size = New System.Drawing.Size(114, 23)
        Me.advNFacturaHasta.TabIndex = 1
        Me.advNFacturaHasta.ViewName = "tbFacturaVentaCabecera"
        '
        'lblFacturaHasta
        '
        Me.lblFacturaHasta.Location = New System.Drawing.Point(8, 54)
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
        Me.cbxFechaDesde.Size = New System.Drawing.Size(95, 21)
        Me.cbxFechaDesde.TabIndex = 3
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.Location = New System.Drawing.Point(215, 27)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(80, 13)
        Me.lblFechaDesde.TabIndex = 4
        Me.lblFechaDesde.Tag = "IdRec=4727;"
        Me.lblFechaDesde.Text = "Fecha Desde"
        '
        'cbxFechaHasta
        '
        Me.cbxFechaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaHasta.Location = New System.Drawing.Point(296, 49)
        Me.cbxFechaHasta.Name = "cbxFechaHasta"
        Me.cbxFechaHasta.Size = New System.Drawing.Size(95, 21)
        Me.cbxFechaHasta.TabIndex = 4
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.Location = New System.Drawing.Point(215, 51)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(76, 13)
        Me.lblFechaHasta.TabIndex = 5
        Me.lblFechaHasta.Tag = "IdRec=4726;"
        Me.lblFechaHasta.Text = "Fecha Hasta"
        '
        'advIDCliente
        '
        Me.advIDCliente.DisabledBackColor = System.Drawing.Color.White
        Me.advIDCliente.EntityName = "Cliente"
        Me.advIDCliente.Location = New System.Drawing.Point(96, 75)
        Me.advIDCliente.Name = "advIDCliente"
        Me.advIDCliente.PrimaryDataFields = "IDCliente"
        Me.advIDCliente.SecondaryDataFields = "IDCliente"
        Me.advIDCliente.Size = New System.Drawing.Size(114, 23)
        Me.advIDCliente.TabIndex = 2
        Me.advIDCliente.ViewName = "tbMaestroCliente"
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(8, 80)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblCliente.TabIndex = 6
        Me.lblCliente.Tag = "IdRec=4365;"
        Me.lblCliente.Text = "Cliente"
        '
        'lblImpDesde
        '
        Me.lblImpDesde.Location = New System.Drawing.Point(397, 28)
        Me.lblImpDesde.Name = "lblImpDesde"
        Me.lblImpDesde.Size = New System.Drawing.Size(75, 13)
        Me.lblImpDesde.TabIndex = 8
        Me.lblImpDesde.Tag = "IdRec=4778;"
        Me.lblImpDesde.Text = "Importe >="
        '
        'lblImpHasta
        '
        Me.lblImpHasta.Location = New System.Drawing.Point(397, 54)
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblTotal)
        Me.Panel1.Controls.Add(Me.txtTotalA)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 260)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(970, 32)
        Me.Panel1.TabIndex = 2
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(807, 10)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(35, 13)
        Me.lblTotal.TabIndex = 16
        Me.lblTotal.Text = "Total"
        '
        'txtTotalA
        '
        Me.txtTotalA.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalA.Enabled = False
        Me.txtTotalA.Location = New System.Drawing.Point(845, 6)
        Me.txtTotalA.Name = "txtTotalA"
        Me.txtTotalA.Size = New System.Drawing.Size(120, 21)
        Me.txtTotalA.TabIndex = 15
        '
        'txtImporteHasta
        '
        Me.txtImporteHasta.DisabledBackColor = System.Drawing.Color.White
        Me.txtImporteHasta.Location = New System.Drawing.Point(476, 49)
        Me.txtImporteHasta.Name = "txtImporteHasta"
        Me.txtImporteHasta.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtImporteHasta.Size = New System.Drawing.Size(104, 21)
        Me.txtImporteHasta.TabIndex = 6
        '
        'txtImporteDesde
        '
        Me.txtImporteDesde.DisabledBackColor = System.Drawing.Color.White
        Me.txtImporteDesde.Location = New System.Drawing.Point(476, 23)
        Me.txtImporteDesde.Name = "txtImporteDesde"
        Me.txtImporteDesde.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.txtImporteDesde.Size = New System.Drawing.Size(104, 21)
        Me.txtImporteDesde.TabIndex = 5
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'lblComunicadoGestorCobro
        '
        Me.lblComunicadoGestorCobro.Location = New System.Drawing.Point(774, 29)
        Me.lblComunicadoGestorCobro.Name = "lblComunicadoGestorCobro"
        Me.lblComunicadoGestorCobro.Size = New System.Drawing.Size(108, 13)
        Me.lblComunicadoGestorCobro.TabIndex = 204
        Me.lblComunicadoGestorCobro.Text = "Comunicado G.C."
        '
        'cbxFechaComunicacionGestorCobro
        '
        Me.cbxFechaComunicacionGestorCobro.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaComunicacionGestorCobro.Location = New System.Drawing.Point(870, 49)
        Me.cbxFechaComunicacionGestorCobro.Name = "cbxFechaComunicacionGestorCobro"
        Me.cbxFechaComunicacionGestorCobro.Size = New System.Drawing.Size(95, 21)
        Me.cbxFechaComunicacionGestorCobro.TabIndex = 10
        '
        'lblFechaComunicacionGestorCobro
        '
        Me.lblFechaComunicacionGestorCobro.Location = New System.Drawing.Point(774, 52)
        Me.lblFechaComunicacionGestorCobro.Name = "lblFechaComunicacionGestorCobro"
        Me.lblFechaComunicacionGestorCobro.Size = New System.Drawing.Size(101, 13)
        Me.lblFechaComunicacionGestorCobro.TabIndex = 203
        Me.lblFechaComunicacionGestorCobro.Text = "F. Comunicación"
        '
        'lblOperario
        '
        Me.lblOperario.Location = New System.Drawing.Point(585, 53)
        Me.lblOperario.Name = "lblOperario"
        Me.lblOperario.Size = New System.Drawing.Size(91, 13)
        Me.lblOperario.TabIndex = 200
        Me.lblOperario.Text = "Gestor Interno"
        '
        'advIDOperario
        '
        Me.advIDOperario.DisabledBackColor = System.Drawing.Color.White
        Me.advIDOperario.EntityName = "Operario"
        Me.advIDOperario.Location = New System.Drawing.Point(674, 49)
        Me.advIDOperario.Name = "advIDOperario"
        Me.advIDOperario.PrimaryDataFields = "IDOperario"
        Me.advIDOperario.SecondaryDataFields = "IDOperario"
        Me.advIDOperario.Size = New System.Drawing.Size(95, 23)
        Me.advIDOperario.TabIndex = 8
        '
        'lblProveedor
        '
        Me.lblProveedor.Location = New System.Drawing.Point(585, 27)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(93, 13)
        Me.lblProveedor.TabIndex = 198
        Me.lblProveedor.Text = "Gestor Externo"
        '
        'advIDProveedor
        '
        Me.advIDProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.advIDProveedor.EntityName = "Proveedor"
        Me.advIDProveedor.Location = New System.Drawing.Point(674, 23)
        Me.advIDProveedor.Name = "advIDProveedor"
        Me.advIDProveedor.PrimaryDataFields = "IDProveedor"
        Me.advIDProveedor.SecondaryDataFields = "IDProveedor"
        Me.advIDProveedor.Size = New System.Drawing.Size(95, 23)
        Me.advIDProveedor.TabIndex = 7
        '
        'cbxComunicadoGestorCobro
        '
        Me.cbxComunicadoGestorCobro.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        cbxComunicadoGestorCobro_DesignTimeLayout.LayoutString = resources.GetString("cbxComunicadoGestorCobro_DesignTimeLayout.LayoutString")
        Me.cbxComunicadoGestorCobro.DesignTimeLayout = cbxComunicadoGestorCobro_DesignTimeLayout
        Me.cbxComunicadoGestorCobro.DisabledBackColor = System.Drawing.Color.White
        Me.cbxComunicadoGestorCobro.Location = New System.Drawing.Point(870, 23)
        Me.cbxComunicadoGestorCobro.Name = "cbxComunicadoGestorCobro"
        Me.cbxComunicadoGestorCobro.SelectedIndex = -1
        Me.cbxComunicadoGestorCobro.SelectedItem = Nothing
        Me.cbxComunicadoGestorCobro.Size = New System.Drawing.Size(95, 21)
        Me.cbxComunicadoGestorCobro.TabIndex = 9
        '
        'CIFactVentaGestorCobros
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(978, 483)
        Me.EntityName = "FacturaVentaCabecera"
        Me.KeyField = "IDFactura"
        Me.Name = "CIFactVentaGestorCobros"
        Me.UseCheck = True
        Me.ViewName = "vCIFactVentaGestorCobros"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cbxComunicadoGestorCobro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mMonedaA As MonedaInfo

#Region " Load "

    Private Sub CIFactVentaGestorCobros_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.DesignMode = False Then
            LoadERPData()
            LoadEnums()
            LoadToolbarActions()
            LoadGridActions()
            InitFilterCriteria()
        End If
    End Sub

    Private Sub LoadERPData()
        Dim m As New Moneda
        mMonedaA = ExpertisApp.ExecuteTask(Of Date, MonedaInfo)(AddressOf Moneda.MonedaA, cnMinDate)
    End Sub

    Private Sub LoadEnums()
        cbxComunicadoGestorCobro.DataSource = New EnumData("enumBoolean")
    End Sub

    Private Sub InitFilterCriteria()
        cbxComunicadoGestorCobro.Value = enumBoolean.Todos
    End Sub

    Private Sub LoadToolbarActions()
        Me.FormActions.Add("Comunicar a Gestor de Cobranza", AddressOf AccionGestorCobro)
    End Sub

    Private Sub LoadGridActions()
        Me.Grid.Actions.Add("Abrir Factura", AddressOf AccionAbrirFactura, ExpertisApp.GetIcon("xFacturaVenta.ico"))
        Me.Grid.Actions.Add("Abrir Cliente", AddressOf AccionAbrirCliente, ExpertisApp.GetIcon("xClientes.ico"))
    End Sub

#End Region

#Region " Toolbar Actions "

    Private Sub AccionGestorCobro()
        If Grid.CheckedRecords.Rows.Count > 0 Then
            Dim frm As New frmComunicarGestorCobro
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.Cursor = Cursors.WaitCursor

                Dim IDFactura(-1) As Object
                For Each drMarcados As DataRow In Grid.CheckedRecords.Rows
                    ReDim Preserve IDFactura(UBound(IDFactura) + 1)
                    IDFactura(UBound(IDFactura)) = drMarcados("IDFactura")
                Next
                Dim IDGestor As String = frm.advIDOperario.Text
                Dim GestorInterno As Boolean = True
                If Length(IDGestor) = 0 Then
                    IDGestor = frm.advIDProveedor.Text
                    GestorInterno = False
                End If

                Dim data As New FacturaVentaCabecera.dataAddGestorCobro(IDFactura, IDGestor, GestorInterno, frm.cbxFechaComunicacionGestorCobro.Value)
                ExpertisApp.ExecuteTask(Of FacturaVentaCabecera.dataAddGestorCobro)(AddressOf FacturaVentaCabecera.AddGestorCobro, data)

                Me.Cursor = Cursors.Default
                ExpertisApp.GenerateMessage("Proceso finalizado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UnCheckAllRecords()
                Me.Execute()

                Dim rpt As New Report("LFACTCOM")
                rpt.Filter.Add(New InListFilterItem("IDFactura", IDFactura, FilterType.Numeric, True))
                ExpertisApp.OpenReport(rpt)
            Else
                ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            ExpertisApp.GenerateMessage("No hay registros marcados.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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

    Private Sub AdvFacturaDesde_SelectionChanged(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchSelectionChangedEventArgs) Handles advNFacturaDesde.SelectionChanged
        advNFacturaHasta.Text = advNFacturaDesde.Text
    End Sub

    Private Sub cbxFechaDesde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxFechaDesde.ValueChanged
        If IsDate(cbxFechaHasta.Value) Then
            cbxFechaHasta.Value = cbxFechaDesde.Value
        End If
    End Sub

#Region " Query Execute "

    Private Sub CIFactVentaGestorCobros_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("NFactura", FilterOperator.GreaterThanOrEqual, advNFacturaDesde.Text, FilterType.String)
        e.Filter.Add("NFactura", FilterOperator.LessThanOrEqual, advNFacturaHasta.Text, FilterType.String)
        e.Filter.Add("ImpTotal", FilterOperator.GreaterThanOrEqual, txtImporteDesde.Value, FilterType.Numeric)
        e.Filter.Add("ImpTotal", FilterOperator.LessThanOrEqual, txtImporteHasta.Value, FilterType.Numeric)
        e.Filter.Add("FechaFactura", FilterOperator.GreaterThanOrEqual, cbxFechaDesde.Value, FilterType.DateTime)
        e.Filter.Add("FechaFactura", FilterOperator.LessThanOrEqual, cbxFechaHasta.Value, FilterType.DateTime)
        If Length(advIDCliente.Text) > 0 Then e.Filter.Add(New LikeFilterItem("IDCliente", advIDCliente.Text))

        Dim f_OR As New Filter(FilterUnionOperator.Or)
        If Length(advIDProveedor.Text) > 0 Then f_OR.Add("IDProveedor", FilterOperator.Equal, advIDProveedor.Text, FilterType.String)
        If Length(advIDOperario.Text) > 0 Then f_OR.Add("IDOperario", FilterOperator.Equal, advIDOperario.Text, FilterType.String)
        e.Filter.Add(f_OR)
        If cbxComunicadoGestorCobro.Value <> enumBoolean.Todos Then
            e.Filter.Add("ComunicadoGestorCobro", FilterOperator.Equal, cbxComunicadoGestorCobro.Value, FilterType.Boolean)
        End If
        e.Filter.Add("FechaComunicacionGestorCobro", FilterOperator.Equal, cbxFechaComunicacionGestorCobro.Value, FilterType.DateTime)
    End Sub

    Private Sub CIFactVentaGestorCobros_QueryExecuted(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutedEventArgs) Handles MyBase.QueryExecuted
        txtTotalA.Value = xRound(Grid.GetTotal(Grid.Columns("ImpTotalA"), AggregateFunction.Sum), mMonedaA.NDecimalesImporte)
    End Sub

    Private Sub CIFactVentaGestorCobros_FilterCleared(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.FilterCleared
        InitFilterCriteria()
    End Sub

#End Region

#Region " Informes "

    Private Sub CIFactVentaGestorCobros_SetReportSelectionCriteria(ByVal sender As Object, ByVal e As Engine.UI.ReportSelectionCriteriaEventArgs) Handles Me.SetReportSelectionCriteria
        Select Case e.Alias
            Case "LFACTCOM"
                If Length(advNFacturaDesde.Text) > 0 Then e.Filter.Add("NFactura", FilterOperator.GreaterThanOrEqual, advNFacturaDesde.Text, FilterType.String)
                If Length(advNFacturaHasta.Text) > 0 Then e.Filter.Add("NFactura", FilterOperator.LessThanOrEqual, advNFacturaHasta.Text, FilterType.String)
                If Length(advIDOperario.Text) > 0 Then e.Filter.Add("IDOperario", FilterOperator.Equal, advIDOperario.Text, FilterType.String)
                If Length(advIDProveedor.Text) > 0 Then e.Filter.Add("IDProveedor", FilterOperator.Equal, advIDProveedor.Text, FilterType.String)
                If Length(cbxFechaComunicacionGestorCobro.Value) > 0 Then e.Filter.Add("FechaComunicacionGestorCobro", FilterOperator.Equal, cbxFechaComunicacionGestorCobro.Value, FilterType.DateTime)
                If Length(txtImporteDesde.Value) > 0 Then e.Filter.Add("ImpTotal", FilterOperator.GreaterThanOrEqual, txtImporteDesde.Value, FilterType.Numeric)
                If Length(txtImporteHasta.Value) > 0 Then e.Filter.Add("ImpTotal", FilterOperator.LessThanOrEqual, txtImporteHasta.Value, FilterType.Numeric)
                If Length(cbxFechaDesde.Value) > 0 Then e.Filter.Add("FechaFactura", FilterOperator.GreaterThanOrEqual, cbxFechaDesde.Value, FilterType.DateTime)
                If Length(cbxFechaHasta.Value) > 0 Then e.Filter.Add("FechaFactura", FilterOperator.LessThanOrEqual, cbxFechaHasta.Value, FilterType.DateTime)
                If Length(advIDCliente.Text) > 0 Then e.Filter.Add(New LikeFilterItem("IDCliente", advIDCliente.Text))
        End Select
    End Sub

#End Region

End Class