<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExistenciaProductos
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
        Me.volver_btn = New System.Windows.Forms.Button()
        Me.salir_btn = New System.Windows.Forms.Button()
        Me.reporte_btn = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.venta_rut_clie = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'volver_btn
        '
        Me.volver_btn.Location = New System.Drawing.Point(12, 321)
        Me.volver_btn.Name = "volver_btn"
        Me.volver_btn.Size = New System.Drawing.Size(75, 23)
        Me.volver_btn.TabIndex = 18
        Me.volver_btn.Text = "Volver"
        Me.volver_btn.UseVisualStyleBackColor = True
        '
        'salir_btn
        '
        Me.salir_btn.Location = New System.Drawing.Point(407, 321)
        Me.salir_btn.Name = "salir_btn"
        Me.salir_btn.Size = New System.Drawing.Size(75, 23)
        Me.salir_btn.TabIndex = 17
        Me.salir_btn.Text = "Salir"
        Me.salir_btn.UseVisualStyleBackColor = True
        '
        'reporte_btn
        '
        Me.reporte_btn.Location = New System.Drawing.Point(393, 119)
        Me.reporte_btn.Name = "reporte_btn"
        Me.reporte_btn.Size = New System.Drawing.Size(75, 23)
        Me.reporte_btn.TabIndex = 16
        Me.reporte_btn.Text = "Reporte"
        Me.reporte_btn.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(18, 148)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(450, 157)
        Me.dgv.TabIndex = 14
        '
        'venta_rut_clie
        '
        Me.venta_rut_clie.Location = New System.Drawing.Point(18, 93)
        Me.venta_rut_clie.Name = "venta_rut_clie"
        Me.venta_rut_clie.Size = New System.Drawing.Size(107, 33)
        Me.venta_rut_clie.TabIndex = 29
        Me.venta_rut_clie.Text = "Buscar"
        Me.venta_rut_clie.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 31)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Existencia Productos"
        '
        'ExistenciaProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 356)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.venta_rut_clie)
        Me.Controls.Add(Me.volver_btn)
        Me.Controls.Add(Me.salir_btn)
        Me.Controls.Add(Me.reporte_btn)
        Me.Controls.Add(Me.dgv)
        Me.Name = "ExistenciaProductos"
        Me.Text = "ExistenciaProductos"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents volver_btn As Button
    Friend WithEvents salir_btn As Button
    Friend WithEvents reporte_btn As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents venta_rut_clie As Button
    Friend WithEvents Label1 As Label
End Class
