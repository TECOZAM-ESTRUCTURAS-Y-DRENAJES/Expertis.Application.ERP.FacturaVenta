<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFechas
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
        Me.cbFechaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.cbFechaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.bAceptar = New System.Windows.Forms.Button
        Me.bCancelar = New System.Windows.Forms.Button
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.cbFechaHasta)
        Me.Frame1.Controls.Add(Me.cbFechaDesde)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Location = New System.Drawing.Point(12, 12)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(246, 119)
        Me.Frame1.TabIndex = 7
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Filtros Fecha"
        '
        'cbFechaHasta
        '
        Me.cbFechaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbFechaHasta.Location = New System.Drawing.Point(107, 69)
        Me.cbFechaHasta.Name = "cbFechaHasta"
        Me.cbFechaHasta.Size = New System.Drawing.Size(120, 21)
        Me.cbFechaHasta.TabIndex = 101
        '
        'cbFechaDesde
        '
        Me.cbFechaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbFechaDesde.Location = New System.Drawing.Point(107, 33)
        Me.cbFechaDesde.Name = "cbFechaDesde"
        Me.cbFechaDesde.Size = New System.Drawing.Size(120, 21)
        Me.cbFechaDesde.TabIndex = 100
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hasta"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde"
        '
        'bAceptar
        '
        Me.bAceptar.Location = New System.Drawing.Point(171, 137)
        Me.bAceptar.Name = "bAceptar"
        Me.bAceptar.Size = New System.Drawing.Size(87, 23)
        Me.bAceptar.TabIndex = 104
        Me.bAceptar.Text = "Aceptar"
        Me.bAceptar.UseVisualStyleBackColor = True
        '
        'bCancelar
        '
        Me.bCancelar.Location = New System.Drawing.Point(12, 137)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(87, 23)
        Me.bCancelar.TabIndex = 105
        Me.bCancelar.Text = "Cancelar"
        Me.bCancelar.UseVisualStyleBackColor = True
        '
        'frmFechas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 171)
        Me.Controls.Add(Me.bAceptar)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.Frame1)
        Me.Name = "frmFechas"
        Me.Text = "frmFechas"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Frame1 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents cbFechaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents cbFechaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents bAceptar As System.Windows.Forms.Button
    Friend WithEvents bCancelar As System.Windows.Forms.Button
End Class
