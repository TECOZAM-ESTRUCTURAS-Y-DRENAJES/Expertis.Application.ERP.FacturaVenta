<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTextoBancos
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
        Dim cbBancos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTextoBancos))
        Me.bAceptar = New System.Windows.Forms.Button
        Me.bCancelar = New System.Windows.Forms.Button
        Me.cbBancos = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.cbFechaV = New Solmicro.Expertis.Engine.UI.CalendarBox
        CType(Me.cbBancos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bAceptar
        '
        Me.bAceptar.Location = New System.Drawing.Point(30, 171)
        Me.bAceptar.Name = "bAceptar"
        Me.bAceptar.Size = New System.Drawing.Size(87, 23)
        Me.bAceptar.TabIndex = 2
        Me.bAceptar.Text = "Aceptar"
        Me.bAceptar.UseVisualStyleBackColor = True
        '
        'bCancelar
        '
        Me.bCancelar.Location = New System.Drawing.Point(245, 171)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(87, 23)
        Me.bCancelar.TabIndex = 3
        Me.bCancelar.Text = "Cancelar"
        Me.bCancelar.UseVisualStyleBackColor = True
        '
        'cbBancos
        '
        cbBancos_DesignTimeLayout.LayoutString = resources.GetString("cbBancos_DesignTimeLayout.LayoutString")
        Me.cbBancos.DesignTimeLayout = cbBancos_DesignTimeLayout
        Me.cbBancos.DisabledBackColor = System.Drawing.Color.White
        Me.cbBancos.Location = New System.Drawing.Point(133, 32)
        Me.cbBancos.Name = "cbBancos"
        Me.cbBancos.SelectedIndex = -1
        Me.cbBancos.SelectedItem = Nothing
        Me.cbBancos.Size = New System.Drawing.Size(121, 21)
        Me.cbBancos.TabIndex = 1
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.cbFechaV)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.cbBancos)
        Me.Frame1.Location = New System.Drawing.Point(30, 27)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(302, 124)
        Me.Frame1.TabIndex = 5
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Datos factura"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(33, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Banco:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(33, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fecha Venc:"
        '
        'cbFechaV
        '
        Me.cbFechaV.DisabledBackColor = System.Drawing.Color.White
        Me.cbFechaV.Location = New System.Drawing.Point(133, 68)
        Me.cbFechaV.Name = "cbFechaV"
        Me.cbFechaV.Size = New System.Drawing.Size(121, 21)
        Me.cbFechaV.TabIndex = 25
        '
        'frmTextoBancos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 209)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.bAceptar)
        Me.Controls.Add(Me.bCancelar)
        Me.Name = "frmTextoBancos"
        Me.Text = "frmTextoBancos"
        CType(Me.cbBancos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bAceptar As System.Windows.Forms.Button
    Friend WithEvents bCancelar As System.Windows.Forms.Button
    Friend WithEvents cbBancos As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents Frame1 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents cbFechaV As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
End Class
