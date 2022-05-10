<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImprimirDocs
    Inherits Solmicro.Expertis.Engine.UI.FormBase

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim CmbInformeFactura_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImprimirDocs))
        Dim CmbImpresora_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim CmbOpciones_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.PnlButtons = New Solmicro.Expertis.Engine.UI.Panel
        Me.BtnCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.BtnAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.FrmCab = New Solmicro.Expertis.Engine.UI.Frame
        Me.CmbInformeFactura = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.ChkCartaCredito = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.ChkAnaliticaVino = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.ChkCertificadoOrigen = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.ChkDAA = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.ChkFacturaMaterial = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.ChkListaContenido = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.ChkFacturaAduanas = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.ChkFacturaExportacion = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.FrmOpciones = New Solmicro.Expertis.Engine.UI.Frame
        Me.CmbImpresora = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.LblImpresora = New Solmicro.Expertis.Engine.UI.Label
        Me.BtnDirectorio = New Solmicro.Expertis.Engine.UI.Button
        Me.TxtDirectorio = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LbLDirectorio = New Solmicro.Expertis.Engine.UI.Label
        Me.LblSeleccione = New Solmicro.Expertis.Engine.UI.Label
        Me.CmbOpciones = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.FraDistribucion = New Solmicro.Expertis.Engine.UI.Frame
        Me.chkCartaComisiones = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkComisiones = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.cbxFechaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.cbxFechaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFecha = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaH = New Solmicro.Expertis.Engine.UI.Label
        Me.PnlButtons.suspendlayout()
        Me.FrmCab.SuspendLayout()
        CType(Me.CmbInformeFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FrmOpciones.SuspendLayout()
        CType(Me.CmbImpresora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraDistribucion.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlButtons
        '
        Me.PnlButtons.Controls.Add(Me.BtnCancelar)
        Me.PnlButtons.Controls.Add(Me.BtnAceptar)
        Me.PnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlButtons.Location = New System.Drawing.Point(0, 427)
        Me.PnlButtons.Name = "PnlButtons"
        Me.PnlButtons.Size = New System.Drawing.Size(471, 45)
        Me.PnlButtons.TabIndex = 13
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(246, 6)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(88, 32)
        Me.BtnCancelar.TabIndex = 15
        Me.BtnCancelar.Text = "Cancelar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(136, 6)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(88, 32)
        Me.BtnAceptar.TabIndex = 14
        Me.BtnAceptar.Text = "Aceptar"
        '
        'FrmCab
        '
        Me.FrmCab.Controls.Add(Me.CmbInformeFactura)
        Me.FrmCab.Controls.Add(Me.ChkCartaCredito)
        Me.FrmCab.Controls.Add(Me.ChkAnaliticaVino)
        Me.FrmCab.Controls.Add(Me.ChkCertificadoOrigen)
        Me.FrmCab.Controls.Add(Me.ChkDAA)
        Me.FrmCab.Controls.Add(Me.ChkFacturaMaterial)
        Me.FrmCab.Controls.Add(Me.ChkListaContenido)
        Me.FrmCab.Controls.Add(Me.ChkFacturaAduanas)
        Me.FrmCab.Controls.Add(Me.ChkFacturaExportacion)
        Me.FrmCab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmCab.Location = New System.Drawing.Point(0, 0)
        Me.FrmCab.Name = "FrmCab"
        Me.FrmCab.Size = New System.Drawing.Size(471, 270)
        Me.FrmCab.TabIndex = 1
        Me.FrmCab.TabStop = False
        Me.FrmCab.Text = "Documentos"
        '
        'CmbInformeFactura
        '
        CmbInformeFactura_DesignTimeLayout.LayoutString = resources.GetString("CmbInformeFactura_DesignTimeLayout.LayoutString")
        Me.CmbInformeFactura.DesignTimeLayout = CmbInformeFactura_DesignTimeLayout
        Me.CmbInformeFactura.DisabledBackColor = System.Drawing.Color.White
        Me.CmbInformeFactura.DisplayMember = "Caption"
        Me.CmbInformeFactura.Location = New System.Drawing.Point(260, 32)
        Me.CmbInformeFactura.Name = "CmbInformeFactura"
        Me.CmbInformeFactura.SelectedIndex = -1
        Me.CmbInformeFactura.SelectedItem = Nothing
        Me.CmbInformeFactura.Size = New System.Drawing.Size(174, 21)
        Me.CmbInformeFactura.TabIndex = 1
        Me.CmbInformeFactura.ValueMember = "Alias"
        '
        'ChkCartaCredito
        '
        Me.ChkCartaCredito.Enabled = False
        Me.ChkCartaCredito.Location = New System.Drawing.Point(22, 233)
        Me.ChkCartaCredito.Name = "ChkCartaCredito"
        Me.ChkCartaCredito.Size = New System.Drawing.Size(155, 23)
        Me.ChkCartaCredito.TabIndex = 8
        Me.ChkCartaCredito.Text = "Carta de Crédito"
        Me.ChkCartaCredito.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center
        '
        'ChkAnaliticaVino
        '
        Me.ChkAnaliticaVino.Checked = True
        Me.ChkAnaliticaVino.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkAnaliticaVino.Location = New System.Drawing.Point(22, 204)
        Me.ChkAnaliticaVino.Name = "ChkAnaliticaVino"
        Me.ChkAnaliticaVino.Size = New System.Drawing.Size(158, 23)
        Me.ChkAnaliticaVino.TabIndex = 7
        Me.ChkAnaliticaVino.Text = "Analítica del Vino"
        Me.ChkAnaliticaVino.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center
        '
        'ChkCertificadoOrigen
        '
        Me.ChkCertificadoOrigen.Enabled = False
        Me.ChkCertificadoOrigen.Location = New System.Drawing.Point(22, 175)
        Me.ChkCertificadoOrigen.Name = "ChkCertificadoOrigen"
        Me.ChkCertificadoOrigen.Size = New System.Drawing.Size(184, 23)
        Me.ChkCertificadoOrigen.TabIndex = 6
        Me.ChkCertificadoOrigen.Text = "Certificado de Origen"
        Me.ChkCertificadoOrigen.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center
        '
        'ChkDAA
        '
        Me.ChkDAA.Checked = True
        Me.ChkDAA.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkDAA.Location = New System.Drawing.Point(22, 146)
        Me.ChkDAA.Name = "ChkDAA"
        Me.ChkDAA.Size = New System.Drawing.Size(288, 23)
        Me.ChkDAA.TabIndex = 5
        Me.ChkDAA.Text = "Documento de Acompañamiento (DAA)"
        Me.ChkDAA.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center
        '
        'ChkFacturaMaterial
        '
        Me.ChkFacturaMaterial.Checked = True
        Me.ChkFacturaMaterial.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkFacturaMaterial.Location = New System.Drawing.Point(22, 117)
        Me.ChkFacturaMaterial.Name = "ChkFacturaMaterial"
        Me.ChkFacturaMaterial.Size = New System.Drawing.Size(355, 23)
        Me.ChkFacturaMaterial.TabIndex = 4
        Me.ChkFacturaMaterial.Text = "Factura de Material sin Cargo (regalos y publicidad)"
        Me.ChkFacturaMaterial.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center
        '
        'ChkListaContenido
        '
        Me.ChkListaContenido.Checked = True
        Me.ChkListaContenido.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkListaContenido.Location = New System.Drawing.Point(22, 88)
        Me.ChkListaContenido.Name = "ChkListaContenido"
        Me.ChkListaContenido.Size = New System.Drawing.Size(166, 23)
        Me.ChkListaContenido.TabIndex = 3
        Me.ChkListaContenido.Text = "Lista de Contenido"
        Me.ChkListaContenido.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center
        '
        'ChkFacturaAduanas
        '
        Me.ChkFacturaAduanas.Checked = True
        Me.ChkFacturaAduanas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkFacturaAduanas.Location = New System.Drawing.Point(22, 59)
        Me.ChkFacturaAduanas.Name = "ChkFacturaAduanas"
        Me.ChkFacturaAduanas.Size = New System.Drawing.Size(166, 23)
        Me.ChkFacturaAduanas.TabIndex = 2
        Me.ChkFacturaAduanas.Text = "Factura de Aduanas"
        Me.ChkFacturaAduanas.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center
        '
        'ChkFacturaExportacion
        '
        Me.ChkFacturaExportacion.Checked = True
        Me.ChkFacturaExportacion.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkFacturaExportacion.Location = New System.Drawing.Point(22, 30)
        Me.ChkFacturaExportacion.Name = "ChkFacturaExportacion"
        Me.ChkFacturaExportacion.Size = New System.Drawing.Size(218, 23)
        Me.ChkFacturaExportacion.TabIndex = 0
        Me.ChkFacturaExportacion.Text = "Factura de Venta Exportación"
        Me.ChkFacturaExportacion.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center
        '
        'FrmOpciones
        '
        Me.FrmOpciones.Controls.Add(Me.CmbImpresora)
        Me.FrmOpciones.Controls.Add(Me.LblImpresora)
        Me.FrmOpciones.Controls.Add(Me.BtnDirectorio)
        Me.FrmOpciones.Controls.Add(Me.TxtDirectorio)
        Me.FrmOpciones.Controls.Add(Me.LbLDirectorio)
        Me.FrmOpciones.Controls.Add(Me.LblSeleccione)
        Me.FrmOpciones.Controls.Add(Me.CmbOpciones)
        Me.FrmOpciones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FrmOpciones.Location = New System.Drawing.Point(0, 353)
        Me.FrmOpciones.Name = "FrmOpciones"
        Me.FrmOpciones.Size = New System.Drawing.Size(471, 74)
        Me.FrmOpciones.TabIndex = 9
        Me.FrmOpciones.TabStop = False
        Me.FrmOpciones.Text = "Opciones"
        '
        'CmbImpresora
        '
        CmbImpresora_DesignTimeLayout.LayoutString = resources.GetString("CmbImpresora_DesignTimeLayout.LayoutString")
        Me.CmbImpresora.DesignTimeLayout = CmbImpresora_DesignTimeLayout
        Me.CmbImpresora.DisabledBackColor = System.Drawing.Color.White
        Me.CmbImpresora.DisplayMember = "Impresora"
        Me.CmbImpresora.Location = New System.Drawing.Point(123, 47)
        Me.CmbImpresora.Name = "CmbImpresora"
        Me.CmbImpresora.SelectedIndex = -1
        Me.CmbImpresora.SelectedItem = Nothing
        Me.CmbImpresora.Size = New System.Drawing.Size(311, 21)
        Me.CmbImpresora.TabIndex = 11
        Me.CmbImpresora.ValueMember = "Impresora"
        Me.CmbImpresora.Visible = False
        '
        'LblImpresora
        '
        Me.LblImpresora.Location = New System.Drawing.Point(6, 51)
        Me.LblImpresora.Name = "LblImpresora"
        Me.LblImpresora.Size = New System.Drawing.Size(67, 13)
        Me.LblImpresora.TabIndex = 5
        Me.LblImpresora.Text = "Impresora"
        Me.LblImpresora.Visible = False
        '
        'BtnDirectorio
        '
        Me.BtnDirectorio.Icon = CType(resources.GetObject("BtnDirectorio.Icon"), System.Drawing.Icon)
        Me.BtnDirectorio.Location = New System.Drawing.Point(440, 45)
        Me.BtnDirectorio.Name = "BtnDirectorio"
        Me.BtnDirectorio.Size = New System.Drawing.Size(26, 23)
        Me.BtnDirectorio.TabIndex = 12
        Me.BtnDirectorio.Visible = False
        '
        'TxtDirectorio
        '
        Me.TxtDirectorio.DisabledBackColor = System.Drawing.Color.White
        Me.TxtDirectorio.Location = New System.Drawing.Point(123, 47)
        Me.TxtDirectorio.Name = "TxtDirectorio"
        Me.TxtDirectorio.ReadOnly = True
        Me.TxtDirectorio.Size = New System.Drawing.Size(311, 21)
        Me.TxtDirectorio.TabIndex = 3
        Me.TxtDirectorio.Visible = False
        '
        'LbLDirectorio
        '
        Me.LbLDirectorio.Location = New System.Drawing.Point(6, 51)
        Me.LbLDirectorio.Name = "LbLDirectorio"
        Me.LbLDirectorio.Size = New System.Drawing.Size(63, 13)
        Me.LbLDirectorio.TabIndex = 2
        Me.LbLDirectorio.Text = "Directorio"
        Me.LbLDirectorio.Visible = False
        '
        'LblSeleccione
        '
        Me.LblSeleccione.Location = New System.Drawing.Point(6, 24)
        Me.LblSeleccione.Name = "LblSeleccione"
        Me.LblSeleccione.Size = New System.Drawing.Size(111, 13)
        Me.LblSeleccione.TabIndex = 1
        Me.LblSeleccione.Text = "Seleccione Opción"
        '
        'CmbOpciones
        '
        CmbOpciones_DesignTimeLayout.LayoutString = resources.GetString("CmbOpciones_DesignTimeLayout.LayoutString")
        Me.CmbOpciones.DesignTimeLayout = CmbOpciones_DesignTimeLayout
        Me.CmbOpciones.DisabledBackColor = System.Drawing.Color.White
        Me.CmbOpciones.DisplayMember = "DescOpcion"
        Me.CmbOpciones.Location = New System.Drawing.Point(123, 20)
        Me.CmbOpciones.Name = "CmbOpciones"
        Me.CmbOpciones.SelectedIndex = -1
        Me.CmbOpciones.SelectedItem = Nothing
        Me.CmbOpciones.Size = New System.Drawing.Size(311, 21)
        Me.CmbOpciones.TabIndex = 10
        Me.CmbOpciones.ValueMember = "IDOpcion"
        '
        'FraDistribucion
        '
        Me.FraDistribucion.Controls.Add(Me.lblFechaH)
        Me.FraDistribucion.Controls.Add(Me.lblFecha)
        Me.FraDistribucion.Controls.Add(Me.cbxFechaHasta)
        Me.FraDistribucion.Controls.Add(Me.cbxFechaDesde)
        Me.FraDistribucion.Controls.Add(Me.chkComisiones)
        Me.FraDistribucion.Controls.Add(Me.chkCartaComisiones)
        Me.FraDistribucion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FraDistribucion.Location = New System.Drawing.Point(0, 270)
        Me.FraDistribucion.Name = "FraDistribucion"
        Me.FraDistribucion.Size = New System.Drawing.Size(471, 83)
        Me.FraDistribucion.TabIndex = 14
        Me.FraDistribucion.TabStop = False
        Me.FraDistribucion.Text = "Distribución"
        '
        'chkCartaComisiones
        '
        Me.chkCartaComisiones.Location = New System.Drawing.Point(22, 20)
        Me.chkCartaComisiones.Name = "chkCartaComisiones"
        Me.chkCartaComisiones.Size = New System.Drawing.Size(155, 23)
        Me.chkCartaComisiones.TabIndex = 9
        Me.chkCartaComisiones.Text = "Carta Comisiones"
        Me.chkCartaComisiones.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center
        '
        'chkComisiones
        '
        Me.chkComisiones.Location = New System.Drawing.Point(22, 49)
        Me.chkComisiones.Name = "chkComisiones"
        Me.chkComisiones.Size = New System.Drawing.Size(121, 23)
        Me.chkComisiones.TabIndex = 10
        Me.chkComisiones.Text = "Comisiones"
        Me.chkComisiones.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center
        '
        'cbxFechaDesde
        '
        Me.cbxFechaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaDesde.Location = New System.Drawing.Point(253, 20)
        Me.cbxFechaDesde.Name = "cbxFechaDesde"
        Me.cbxFechaDesde.Size = New System.Drawing.Size(95, 21)
        Me.cbxFechaDesde.TabIndex = 11
        '
        'cbxFechaHasta
        '
        Me.cbxFechaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaHasta.Location = New System.Drawing.Point(364, 20)
        Me.cbxFechaHasta.Name = "cbxFechaHasta"
        Me.cbxFechaHasta.Size = New System.Drawing.Size(95, 21)
        Me.cbxFechaHasta.TabIndex = 12
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(208, 24)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(40, 13)
        Me.lblFecha.TabIndex = 13
        Me.lblFecha.Text = "Fecha"
        '
        'lblFechaH
        '
        Me.lblFechaH.Location = New System.Drawing.Point(350, 24)
        Me.lblFechaH.Name = "lblFechaH"
        Me.lblFechaH.Size = New System.Drawing.Size(12, 13)
        Me.lblFechaH.TabIndex = 14
        Me.lblFechaH.Text = "-"
        '
        'FrmImprimirDocs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 472)
        Me.Controls.Add(Me.FrmCab)
        Me.Controls.Add(Me.FraDistribucion)
        Me.Controls.Add(Me.FrmOpciones)
        Me.Controls.Add(Me.PnlButtons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmImprimirDocs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir Documentación"
        Me.PnlButtons.ResumeLayout(False)
        Me.FrmCab.ResumeLayout(False)
        Me.FrmCab.PerformLayout()
        CType(Me.CmbInformeFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FrmOpciones.ResumeLayout(False)
        Me.FrmOpciones.PerformLayout()
        CType(Me.CmbImpresora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraDistribucion.ResumeLayout(False)
        Me.FraDistribucion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlButtons As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents BtnCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents BtnAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents FrmCab As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents FrmOpciones As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents CmbOpciones As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents LblSeleccione As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents CmbImpresora As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents LblImpresora As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents BtnDirectorio As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents TxtDirectorio As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents LbLDirectorio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ChkCartaCredito As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents ChkAnaliticaVino As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents ChkCertificadoOrigen As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents ChkDAA As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents ChkFacturaMaterial As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents ChkListaContenido As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents ChkFacturaAduanas As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents ChkFacturaExportacion As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents CmbInformeFactura As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents FraDistribucion As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents chkComisiones As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkCartaComisiones As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents lblFechaH As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFecha As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents cbxFechaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
End Class
