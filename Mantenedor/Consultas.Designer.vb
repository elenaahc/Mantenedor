<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultas
    Inherits System.Windows.Forms.Form

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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.venta_rut_clie = New System.Windows.Forms.Button()
        Me.venta_fecha = New System.Windows.Forms.Button()
        Me.compra_fecha = New System.Windows.Forms.Button()
        Me.stock_prod = New System.Windows.Forms.Button()
        Me.salir_btn = New System.Windows.Forms.Button()
        Me.volver_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(124, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Consultas"
        '
        'venta_rut_clie
        '
        Me.venta_rut_clie.Location = New System.Drawing.Point(140, 66)
        Me.venta_rut_clie.Name = "venta_rut_clie"
        Me.venta_rut_clie.Size = New System.Drawing.Size(107, 47)
        Me.venta_rut_clie.TabIndex = 1
        Me.venta_rut_clie.Text = "Ventas por Cliente"
        Me.venta_rut_clie.UseVisualStyleBackColor = True
        '
        'venta_fecha
        '
        Me.venta_fecha.Location = New System.Drawing.Point(140, 131)
        Me.venta_fecha.Name = "venta_fecha"
        Me.venta_fecha.Size = New System.Drawing.Size(107, 47)
        Me.venta_fecha.TabIndex = 2
        Me.venta_fecha.Text = "Venta por Fecha"
        Me.venta_fecha.UseVisualStyleBackColor = True
        '
        'compra_fecha
        '
        Me.compra_fecha.Location = New System.Drawing.Point(140, 193)
        Me.compra_fecha.Name = "compra_fecha"
        Me.compra_fecha.Size = New System.Drawing.Size(107, 47)
        Me.compra_fecha.TabIndex = 3
        Me.compra_fecha.Text = "Compra por Fecha"
        Me.compra_fecha.UseVisualStyleBackColor = True
        '
        'stock_prod
        '
        Me.stock_prod.Location = New System.Drawing.Point(140, 255)
        Me.stock_prod.Name = "stock_prod"
        Me.stock_prod.Size = New System.Drawing.Size(107, 47)
        Me.stock_prod.TabIndex = 4
        Me.stock_prod.Text = "Existencia Productos"
        Me.stock_prod.UseVisualStyleBackColor = True
        '
        'salir_btn
        '
        Me.salir_btn.Location = New System.Drawing.Point(319, 321)
        Me.salir_btn.Name = "salir_btn"
        Me.salir_btn.Size = New System.Drawing.Size(75, 23)
        Me.salir_btn.TabIndex = 11
        Me.salir_btn.Text = "Salir"
        Me.salir_btn.UseVisualStyleBackColor = True
        '
        'volver_btn
        '
        Me.volver_btn.Location = New System.Drawing.Point(3, 321)
        Me.volver_btn.Name = "volver_btn"
        Me.volver_btn.Size = New System.Drawing.Size(75, 23)
        Me.volver_btn.TabIndex = 12
        Me.volver_btn.Text = "Volver"
        Me.volver_btn.UseVisualStyleBackColor = True
        '
        'Consultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 356)
        Me.Controls.Add(Me.volver_btn)
        Me.Controls.Add(Me.salir_btn)
        Me.Controls.Add(Me.stock_prod)
        Me.Controls.Add(Me.compra_fecha)
        Me.Controls.Add(Me.venta_fecha)
        Me.Controls.Add(Me.venta_rut_clie)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Consultas"
        Me.Text = "Consultas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents venta_rut_clie As Button
    Friend WithEvents venta_fecha As Button
    Friend WithEvents compra_fecha As Button
    Friend WithEvents stock_prod As Button
    Friend WithEvents salir_btn As Button
    Friend WithEvents volver_btn As Button
End Class
