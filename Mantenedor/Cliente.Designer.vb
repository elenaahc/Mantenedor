<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_rut = New System.Windows.Forms.TextBox()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.txt_giro = New System.Windows.Forms.TextBox()
        Me.txt_dir = New System.Windows.Forms.TextBox()
        Me.txt_tel = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_ciu = New System.Windows.Forms.TextBox()
        Me.txt_dv = New System.Windows.Forms.TextBox()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(100, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mantenedor Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Rut"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Giro"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(69, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Direccion"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(69, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Telefono"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(69, 257)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(69, 293)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Ciudad"
        '
        'txt_rut
        '
        Me.txt_rut.AcceptsTab = True
        Me.txt_rut.Location = New System.Drawing.Point(138, 77)
        Me.txt_rut.MaxLength = 8
        Me.txt_rut.Name = "txt_rut"
        Me.txt_rut.Size = New System.Drawing.Size(131, 20)
        Me.txt_rut.TabIndex = 8
        Me.txt_rut.TabStop = False
        '
        'txt_nom
        '
        Me.txt_nom.AcceptsTab = True
        Me.txt_nom.Location = New System.Drawing.Point(138, 112)
        Me.txt_nom.MaxLength = 30
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(167, 20)
        Me.txt_nom.TabIndex = 9
        Me.txt_nom.TabStop = False
        '
        'txt_giro
        '
        Me.txt_giro.AcceptsTab = True
        Me.txt_giro.Location = New System.Drawing.Point(138, 148)
        Me.txt_giro.MaxLength = 30
        Me.txt_giro.Name = "txt_giro"
        Me.txt_giro.Size = New System.Drawing.Size(167, 20)
        Me.txt_giro.TabIndex = 10
        Me.txt_giro.TabStop = False
        '
        'txt_dir
        '
        Me.txt_dir.AcceptsTab = True
        Me.txt_dir.Location = New System.Drawing.Point(138, 182)
        Me.txt_dir.MaxLength = 30
        Me.txt_dir.Name = "txt_dir"
        Me.txt_dir.Size = New System.Drawing.Size(167, 20)
        Me.txt_dir.TabIndex = 11
        Me.txt_dir.TabStop = False
        '
        'txt_tel
        '
        Me.txt_tel.AcceptsTab = True
        Me.txt_tel.Location = New System.Drawing.Point(138, 220)
        Me.txt_tel.MaxLength = 12
        Me.txt_tel.Name = "txt_tel"
        Me.txt_tel.Size = New System.Drawing.Size(167, 20)
        Me.txt_tel.TabIndex = 12
        Me.txt_tel.TabStop = False
        '
        'txt_email
        '
        Me.txt_email.AcceptsTab = True
        Me.txt_email.Location = New System.Drawing.Point(138, 257)
        Me.txt_email.MaxLength = 30
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(167, 20)
        Me.txt_email.TabIndex = 13
        Me.txt_email.TabStop = False
        '
        'txt_ciu
        '
        Me.txt_ciu.AcceptsTab = True
        Me.txt_ciu.Location = New System.Drawing.Point(138, 293)
        Me.txt_ciu.MaxLength = 20
        Me.txt_ciu.Name = "txt_ciu"
        Me.txt_ciu.Size = New System.Drawing.Size(167, 20)
        Me.txt_ciu.TabIndex = 14
        Me.txt_ciu.TabStop = False
        '
        'txt_dv
        '
        Me.txt_dv.AcceptsTab = True
        Me.txt_dv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_dv.Location = New System.Drawing.Point(275, 77)
        Me.txt_dv.MaxLength = 1
        Me.txt_dv.Name = "txt_dv"
        Me.txt_dv.Size = New System.Drawing.Size(30, 20)
        Me.txt_dv.TabIndex = 15
        Me.txt_dv.TabStop = False
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(60, 348)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar.TabIndex = 16
        Me.btn_guardar.TabStop = False
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(194, 348)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminar.TabIndex = 17
        Me.btn_eliminar.TabStop = False
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(327, 348)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.btn_limpiar.TabIndex = 19
        Me.btn_limpiar.TabStop = False
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(382, 415)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_salir.TabIndex = 20
        Me.btn_salir.TabStop = False
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_volver
        '
        Me.btn_volver.Location = New System.Drawing.Point(12, 415)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(75, 23)
        Me.btn_volver.TabIndex = 21
        Me.btn_volver.TabStop = False
        Me.btn_volver.Text = "Regresar"
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 450)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.txt_dv)
        Me.Controls.Add(Me.txt_ciu)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_tel)
        Me.Controls.Add(Me.txt_dir)
        Me.Controls.Add(Me.txt_giro)
        Me.Controls.Add(Me.txt_nom)
        Me.Controls.Add(Me.txt_rut)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Cliente"
        Me.Text = "Cliente"
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
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_rut As TextBox
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents txt_giro As TextBox
    Friend WithEvents txt_dir As TextBox
    Friend WithEvents txt_tel As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_ciu As TextBox
    Friend WithEvents txt_dv As TextBox
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_volver As Button
End Class
