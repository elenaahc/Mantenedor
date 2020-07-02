<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VentasCliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dv_clie_txt = New System.Windows.Forms.TextBox()
        Me.rut_clie_txt = New System.Windows.Forms.TextBox()
        Me.venta_rut_clie = New System.Windows.Forms.Button()
        Me.volver_btn = New System.Windows.Forms.Button()
        Me.salir_btn = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.reporte_btn = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dv_clie_txt
        '
        Me.dv_clie_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.dv_clie_txt.Location = New System.Drawing.Point(107, 77)
        Me.dv_clie_txt.MaxLength = 1
        Me.dv_clie_txt.Name = "dv_clie_txt"
        Me.dv_clie_txt.Size = New System.Drawing.Size(26, 20)
        Me.dv_clie_txt.TabIndex = 11
        '
        'rut_clie_txt
        '
        Me.rut_clie_txt.Location = New System.Drawing.Point(26, 77)
        Me.rut_clie_txt.MaxLength = 8
        Me.rut_clie_txt.Name = "rut_clie_txt"
        Me.rut_clie_txt.Size = New System.Drawing.Size(75, 20)
        Me.rut_clie_txt.TabIndex = 10
        '
        'venta_rut_clie
        '
        Me.venta_rut_clie.Location = New System.Drawing.Point(139, 70)
        Me.venta_rut_clie.Name = "venta_rut_clie"
        Me.venta_rut_clie.Size = New System.Drawing.Size(107, 33)
        Me.venta_rut_clie.TabIndex = 9
        Me.venta_rut_clie.Text = "Buscar"
        Me.venta_rut_clie.UseVisualStyleBackColor = True
        '
        'volver_btn
        '
        Me.volver_btn.Location = New System.Drawing.Point(12, 353)
        Me.volver_btn.Name = "volver_btn"
        Me.volver_btn.Size = New System.Drawing.Size(75, 23)
        Me.volver_btn.TabIndex = 16
        Me.volver_btn.Text = "Volver"
        Me.volver_btn.UseVisualStyleBackColor = True
        '
        'salir_btn
        '
        Me.salir_btn.Location = New System.Drawing.Point(510, 353)
        Me.salir_btn.Name = "salir_btn"
        Me.salir_btn.Size = New System.Drawing.Size(75, 23)
        Me.salir_btn.TabIndex = 15
        Me.salir_btn.Text = "Salir"
        Me.salir_btn.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(26, 118)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(544, 184)
        Me.dgv.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 31)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Ventas Por Cliente"
        '
        'reporte_btn
        '
        Me.reporte_btn.Location = New System.Drawing.Point(495, 80)
        Me.reporte_btn.Name = "reporte_btn"
        Me.reporte_btn.Size = New System.Drawing.Size(75, 23)
        Me.reporte_btn.TabIndex = 18
        Me.reporte_btn.Text = "Reporte"
        Me.reporte_btn.UseVisualStyleBackColor = True
        '
        'VentasCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 388)
        Me.Controls.Add(Me.reporte_btn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.volver_btn)
        Me.Controls.Add(Me.salir_btn)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.dv_clie_txt)
        Me.Controls.Add(Me.rut_clie_txt)
        Me.Controls.Add(Me.venta_rut_clie)
        Me.Name = "VentasCliente"
        Me.Text = "VentasCliente"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dv_clie_txt As TextBox
    Friend WithEvents rut_clie_txt As TextBox
    Friend WithEvents venta_rut_clie As Button
    Friend WithEvents volver_btn As Button
    Friend WithEvents salir_btn As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents reporte_btn As Button

    Friend WithEvents IdventaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RutclieDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FecvenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObsvenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValvenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PorivavenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
