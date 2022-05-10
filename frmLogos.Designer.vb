<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogos
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
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.RadioButton1 = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.RadioButton2 = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.DdFactura = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.hfactura = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.Button1 = New Solmicro.Expertis.Engine.UI.Button
        Me.Button2 = New Solmicro.Expertis.Engine.UI.Button
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.hfactura)
        Me.Frame1.Controls.Add(Me.DdFactura)
        Me.Frame1.Controls.Add(Me.RadioButton2)
        Me.Frame1.Controls.Add(Me.RadioButton1)
        Me.Frame1.Location = New System.Drawing.Point(22, 16)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(173, 122)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Rangos de Impresión"
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(21, 20)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(125, 23)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "Registro Actual"
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(21, 51)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(144, 23)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Desde/Hasta Factura"
        '
        'DdFactura
        '
        Me.DdFactura.DisabledBackColor = System.Drawing.Color.White
        Me.DdFactura.Location = New System.Drawing.Point(21, 80)
        Me.DdFactura.Name = "DdFactura"
        Me.DdFactura.Size = New System.Drawing.Size(54, 21)
        Me.DdFactura.TabIndex = 2
        '
        'hfactura
        '
        Me.hfactura.DisabledBackColor = System.Drawing.Color.White
        Me.hfactura.Location = New System.Drawing.Point(98, 80)
        Me.hfactura.Name = "hfactura"
        Me.hfactura.Size = New System.Drawing.Size(56, 21)
        Me.hfactura.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(22, 166)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Aceptar"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(120, 166)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Cancelar"
        '
        'frmLogos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(216, 213)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Frame1)
        Me.Name = "frmLogos"
        Me.Text = "frmLogos"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Frame1 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents hfactura As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents DdFactura As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents RadioButton2 As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents RadioButton1 As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents Button1 As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Button2 As Solmicro.Expertis.Engine.UI.Button
End Class
