<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentasFecha
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
        Me.date_picker = New System.Windows.Forms.DateTimePicker()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_buscar = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'volver_btn
        '
        Me.volver_btn.Location = New System.Drawing.Point(12, 341)
        Me.volver_btn.Name = "volver_btn"
        Me.volver_btn.Size = New System.Drawing.Size(75, 23)
        Me.volver_btn.TabIndex = 19
        Me.volver_btn.Text = "Volver"
        Me.volver_btn.UseVisualStyleBackColor = True
        '
        'salir_btn
        '
        Me.salir_btn.Location = New System.Drawing.Point(552, 341)
        Me.salir_btn.Name = "salir_btn"
        Me.salir_btn.Size = New System.Drawing.Size(75, 23)
        Me.salir_btn.TabIndex = 18
        Me.salir_btn.Text = "Salir"
        Me.salir_btn.UseVisualStyleBackColor = True
        '
        'reporte_btn
        '
        Me.reporte_btn.Location = New System.Drawing.Point(531, 118)
        Me.reporte_btn.Name = "reporte_btn"
        Me.reporte_btn.Size = New System.Drawing.Size(75, 23)
        Me.reporte_btn.TabIndex = 17
        Me.reporte_btn.Text = "Reporte"
        Me.reporte_btn.UseVisualStyleBackColor = True
        '
        'date_picker
        '
        Me.date_picker.Location = New System.Drawing.Point(27, 96)
        Me.date_picker.Name = "date_picker"
        Me.date_picker.Size = New System.Drawing.Size(200, 20)
        Me.date_picker.TabIndex = 15
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(27, 158)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(579, 157)
        Me.dgv.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 31)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Ventas Por Fecha"
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(233, 92)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(107, 33)
        Me.btn_buscar.TabIndex = 21
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'VentasFecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 376)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.volver_btn)
        Me.Controls.Add(Me.salir_btn)
        Me.Controls.Add(Me.reporte_btn)
        Me.Controls.Add(Me.date_picker)
        Me.Controls.Add(Me.dgv)
        Me.Name = "VentasFecha"
        Me.Text = "VentasFecha"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents volver_btn As Button
    Friend WithEvents salir_btn As Button
    Friend WithEvents reporte_btn As Button
    Friend WithEvents date_picker As DateTimePicker
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_buscar As Button
End Class
