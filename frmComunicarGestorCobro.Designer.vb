<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComunicarGestorCobro
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
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cbxFechaComunicacionGestorCobro = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaComunicacionGestorCobro = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescOperario = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.lblOperario = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDOperario = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ulDescProveedor = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.lblProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDProveedor = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.Panel1.suspendlayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbAceptar)
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 91)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(466, 35)
        Me.Panel1.TabIndex = 3
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(146, 3)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(85, 28)
        Me.cmbAceptar.TabIndex = 0
        Me.cmbAceptar.Text = "Aceptar"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(235, 3)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(85, 28)
        Me.cmbCancelar.TabIndex = 1
        Me.cmbCancelar.Text = "Cancelar"
        '
        'cbxFechaComunicacionGestorCobro
        '
        Me.cbxFechaComunicacionGestorCobro.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaComunicacionGestorCobro.Location = New System.Drawing.Point(142, 64)
        Me.cbxFechaComunicacionGestorCobro.Name = "cbxFechaComunicacionGestorCobro"
        Me.cbxFechaComunicacionGestorCobro.Size = New System.Drawing.Size(102, 21)
        Me.cbxFechaComunicacionGestorCobro.TabIndex = 2
        '
        'lblFechaComunicacionGestorCobro
        '
        Me.lblFechaComunicacionGestorCobro.Location = New System.Drawing.Point(17, 68)
        Me.lblFechaComunicacionGestorCobro.Name = "lblFechaComunicacionGestorCobro"
        Me.lblFechaComunicacionGestorCobro.Size = New System.Drawing.Size(124, 13)
        Me.lblFechaComunicacionGestorCobro.TabIndex = 200
        Me.lblFechaComunicacionGestorCobro.Text = "Fecha Comunicación"
        '
        'ulDescOperario
        '
        Me.ulDescOperario.Location = New System.Drawing.Point(248, 38)
        Me.ulDescOperario.Name = "ulDescOperario"
        Me.ulDescOperario.Size = New System.Drawing.Size(206, 23)
        Me.ulDescOperario.TabIndex = 199
        '
        'lblOperario
        '
        Me.lblOperario.Location = New System.Drawing.Point(17, 42)
        Me.lblOperario.Name = "lblOperario"
        Me.lblOperario.Size = New System.Drawing.Size(91, 13)
        Me.lblOperario.TabIndex = 198
        Me.lblOperario.Text = "Gestor Interno"
        '
        'advIDOperario
        '
        Me.advIDOperario.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescOperario", ulDescOperario)})
        Me.advIDOperario.DisabledBackColor = System.Drawing.Color.White
        Me.advIDOperario.EntityName = "Operario"
        Me.advIDOperario.Location = New System.Drawing.Point(142, 38)
        Me.advIDOperario.Name = "advIDOperario"
        Me.advIDOperario.PrimaryDataFields = "IDOperario"
        Me.advIDOperario.SecondaryDataFields = "IDOperario"
        Me.advIDOperario.Size = New System.Drawing.Size(102, 23)
        Me.advIDOperario.TabIndex = 1
        '
        'ulDescProveedor
        '
        Me.ulDescProveedor.Location = New System.Drawing.Point(248, 12)
        Me.ulDescProveedor.Name = "ulDescProveedor"
        Me.ulDescProveedor.Size = New System.Drawing.Size(206, 23)
        Me.ulDescProveedor.TabIndex = 196
        '
        'lblProveedor
        '
        Me.lblProveedor.Location = New System.Drawing.Point(17, 16)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(93, 13)
        Me.lblProveedor.TabIndex = 195
        Me.lblProveedor.Text = "Gestor Externo"
        '
        'advIDProveedor
        '
        Me.advIDProveedor.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescProveedor", ulDescProveedor)})
        Me.advIDProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.advIDProveedor.EntityName = "Proveedor"
        Me.advIDProveedor.Location = New System.Drawing.Point(142, 12)
        Me.advIDProveedor.Name = "advIDProveedor"
        Me.advIDProveedor.SecondaryDataFields = "IDProveedor"
        Me.advIDProveedor.Size = New System.Drawing.Size(102, 23)
        Me.advIDProveedor.TabIndex = 0
        '
        'frmComunicarGestorCobro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 126)
        Me.Controls.Add(Me.cbxFechaComunicacionGestorCobro)
        Me.Controls.Add(Me.lblFechaComunicacionGestorCobro)
        Me.Controls.Add(Me.ulDescOperario)
        Me.Controls.Add(Me.lblOperario)
        Me.Controls.Add(Me.advIDOperario)
        Me.Controls.Add(Me.ulDescProveedor)
        Me.Controls.Add(Me.lblProveedor)
        Me.Controls.Add(Me.advIDProveedor)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmComunicarGestorCobro"
        Me.Text = "Comunicación del Gestor de Cobranza"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents cbxFechaComunicacionGestorCobro As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaComunicacionGestorCobro As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulDescOperario As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents lblOperario As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDOperario As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents ulDescProveedor As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents lblProveedor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDProveedor As Solmicro.Expertis.Engine.UI.AdvSearch
End Class
