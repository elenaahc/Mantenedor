<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Me.btn_cliente = New System.Windows.Forms.Button()
        Me.btn_proveedor = New System.Windows.Forms.Button()
        Me.btn_U_M = New System.Windows.Forms.Button()
        Me.btn_producto = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_venta = New System.Windows.Forms.Button()
        Me.btn_compra = New System.Windows.Forms.Button()
        Me.consultas_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_cliente
        '
        Me.btn_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cliente.Location = New System.Drawing.Point(135, 83)
        Me.btn_cliente.Name = "btn_cliente"
        Me.btn_cliente.Size = New System.Drawing.Size(193, 34)
        Me.btn_cliente.TabIndex = 0
        Me.btn_cliente.Text = "Cliente"
        Me.btn_cliente.UseVisualStyleBackColor = True
        '
        'btn_proveedor
        '
        Me.btn_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_proveedor.Location = New System.Drawing.Point(135, 123)
        Me.btn_proveedor.Name = "btn_proveedor"
        Me.btn_proveedor.Size = New System.Drawing.Size(193, 34)
        Me.btn_proveedor.TabIndex = 1
        Me.btn_proveedor.Text = "Proveedor"
        Me.btn_proveedor.UseVisualStyleBackColor = True
        '
        'btn_U_M
        '
        Me.btn_U_M.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_U_M.Location = New System.Drawing.Point(135, 163)
        Me.btn_U_M.Name = "btn_U_M"
        Me.btn_U_M.Size = New System.Drawing.Size(193, 34)
        Me.btn_U_M.TabIndex = 2
        Me.btn_U_M.Text = "Unidad de Medida"
        Me.btn_U_M.UseVisualStyleBackColor = True
        '
        'btn_producto
        '
        Me.btn_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_producto.Location = New System.Drawing.Point(135, 203)
        Me.btn_producto.Name = "btn_producto"
        Me.btn_producto.Size = New System.Drawing.Size(193, 34)
        Me.btn_producto.TabIndex = 3
        Me.btn_producto.Text = "Producto"
        Me.btn_producto.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(154, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Mantenedor"
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(382, 415)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_salir.TabIndex = 26
        Me.btn_salir.TabStop = False
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_venta
        '
        Me.btn_venta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_venta.Location = New System.Drawing.Point(135, 243)
        Me.btn_venta.Name = "btn_venta"
        Me.btn_venta.Size = New System.Drawing.Size(193, 34)
        Me.btn_venta.TabIndex = 27
        Me.btn_venta.Text = "Venta"
        Me.btn_venta.UseVisualStyleBackColor = True
        '
        'btn_compra
        '
        Me.btn_compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_compra.Location = New System.Drawing.Point(135, 283)
        Me.btn_compra.Name = "btn_compra"
        Me.btn_compra.Size = New System.Drawing.Size(193, 34)
        Me.btn_compra.TabIndex = 28
        Me.btn_compra.Text = "Compra"
        Me.btn_compra.UseVisualStyleBackColor = True
        '
        'consultas_btn
        '
        Me.consultas_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.consultas_btn.Location = New System.Drawing.Point(135, 323)
        Me.consultas_btn.Name = "consultas_btn"
        Me.consultas_btn.Size = New System.Drawing.Size(193, 34)
        Me.consultas_btn.TabIndex = 29
        Me.consultas_btn.Text = "Consultas"
        Me.consultas_btn.UseVisualStyleBackColor = True
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 450)
        Me.Controls.Add(Me.consultas_btn)
        Me.Controls.Add(Me.btn_compra)
        Me.Controls.Add(Me.btn_venta)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_producto)
        Me.Controls.Add(Me.btn_U_M)
        Me.Controls.Add(Me.btn_proveedor)
        Me.Controls.Add(Me.btn_cliente)
        Me.Name = "Inicio"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_cliente As Button
    Friend WithEvents btn_proveedor As Button
    Friend WithEvents btn_U_M As Button
    Friend WithEvents btn_producto As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_venta As Button
    Friend WithEvents btn_compra As Button
    Friend WithEvents consultas_btn As Button
End Class
