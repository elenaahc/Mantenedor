<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Productos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cb_ud = New System.Windows.Forms.ComboBox()
        Me.txt_id_prod = New System.Windows.Forms.TextBox()
        Me.txt_desc = New System.Windows.Forms.TextBox()
        Me.txt_cant = New System.Windows.Forms.TextBox()
        Me.txt_val_prod = New System.Windows.Forms.TextBox()
        Me.txt_stock_min = New System.Windows.Forms.TextBox()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mantenedor Productos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ID Unidad de Medida"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Descripción"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cantidad de Productos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Valor Producto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(46, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Stock Mínimo"
        '
        'cb_ud
        '
        Me.cb_ud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_ud.FormattingEnabled = True
        Me.cb_ud.Location = New System.Drawing.Point(193, 121)
        Me.cb_ud.Name = "cb_ud"
        Me.cb_ud.Size = New System.Drawing.Size(121, 21)
        Me.cb_ud.TabIndex = 7
        '
        'txt_id_prod
        '
        Me.txt_id_prod.Location = New System.Drawing.Point(193, 86)
        Me.txt_id_prod.MaxLength = 11
        Me.txt_id_prod.Name = "txt_id_prod"
        Me.txt_id_prod.Size = New System.Drawing.Size(100, 20)
        Me.txt_id_prod.TabIndex = 8
        '
        'txt_desc
        '
        Me.txt_desc.Location = New System.Drawing.Point(193, 156)
        Me.txt_desc.MaxLength = 20
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.Size = New System.Drawing.Size(100, 20)
        Me.txt_desc.TabIndex = 9
        '
        'txt_cant
        '
        Me.txt_cant.Location = New System.Drawing.Point(193, 191)
        Me.txt_cant.MaxLength = 10
        Me.txt_cant.Name = "txt_cant"
        Me.txt_cant.Size = New System.Drawing.Size(100, 20)
        Me.txt_cant.TabIndex = 10
        '
        'txt_val_prod
        '
        Me.txt_val_prod.Location = New System.Drawing.Point(193, 226)
        Me.txt_val_prod.MaxLength = 10
        Me.txt_val_prod.Name = "txt_val_prod"
        Me.txt_val_prod.Size = New System.Drawing.Size(100, 20)
        Me.txt_val_prod.TabIndex = 11
        '
        'txt_stock_min
        '
        Me.txt_stock_min.Location = New System.Drawing.Point(193, 261)
        Me.txt_stock_min.MaxLength = 10
        Me.txt_stock_min.Name = "txt_stock_min"
        Me.txt_stock_min.Size = New System.Drawing.Size(100, 20)
        Me.txt_stock_min.TabIndex = 12
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(72, 338)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar.TabIndex = 13
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(194, 338)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminar.TabIndex = 14
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(327, 338)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.btn_limpiar.TabIndex = 15
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'btn_volver
        '
        Me.btn_volver.Location = New System.Drawing.Point(12, 415)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(75, 23)
        Me.btn_volver.TabIndex = 27
        Me.btn_volver.TabStop = False
        Me.btn_volver.Text = "Regresar"
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(382, 415)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_salir.TabIndex = 28
        Me.btn_salir.TabStop = False
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 450)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.txt_stock_min)
        Me.Controls.Add(Me.txt_val_prod)
        Me.Controls.Add(Me.txt_cant)
        Me.Controls.Add(Me.txt_desc)
        Me.Controls.Add(Me.txt_id_prod)
        Me.Controls.Add(Me.cb_ud)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Productos"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cb_ud As ComboBox
    Friend WithEvents txt_id_prod As TextBox
    Friend WithEvents txt_desc As TextBox
    Friend WithEvents txt_cant As TextBox
    Friend WithEvents txt_val_prod As TextBox
    Friend WithEvents txt_stock_min As TextBox
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents btn_volver As Button
    Friend WithEvents btn_salir As Button
End Class
