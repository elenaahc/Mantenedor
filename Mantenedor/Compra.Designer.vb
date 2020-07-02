<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compra
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
        Me.txt_v_n = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_stock_min = New System.Windows.Forms.NumericUpDown()
        Me.cb_desc = New System.Windows.Forms.ComboBox()
        Me.txt_vtotal = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_fec_com = New System.Windows.Forms.DateTimePicker()
        Me.btn_restar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_val_prod = New System.Windows.Forms.TextBox()
        Me.txt_cant = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_id_prod = New System.Windows.Forms.TextBox()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.id_prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc_prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cant_prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor_unitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_val = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.txt_por_iva = New System.Windows.Forms.TextBox()
        Me.txt_val_com = New System.Windows.Forms.TextBox()
        Me.txt_obs = New System.Windows.Forms.TextBox()
        Me.txt_id_compra = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_tel = New System.Windows.Forms.TextBox()
        Me.txt_dir = New System.Windows.Forms.TextBox()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.txt_dv = New System.Windows.Forms.TextBox()
        Me.txt_rut = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_nf = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.txt_stock_min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_v_n
        '
        Me.txt_v_n.AcceptsTab = True
        Me.txt_v_n.Location = New System.Drawing.Point(647, 280)
        Me.txt_v_n.Name = "txt_v_n"
        Me.txt_v_n.ReadOnly = True
        Me.txt_v_n.Size = New System.Drawing.Size(120, 20)
        Me.txt_v_n.TabIndex = 128
        Me.txt_v_n.TabStop = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(571, 287)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(57, 13)
        Me.Label23.TabIndex = 127
        Me.Label23.Text = "Valor Neto"
        '
        'txt_stock_min
        '
        Me.txt_stock_min.Location = New System.Drawing.Point(318, 172)
        Me.txt_stock_min.Maximum = New Decimal(New Integer() {276447231, 23283, 0, 0})
        Me.txt_stock_min.Name = "txt_stock_min"
        Me.txt_stock_min.Size = New System.Drawing.Size(120, 20)
        Me.txt_stock_min.TabIndex = 126
        '
        'cb_desc
        '
        Me.cb_desc.DisplayMember = "desc_prod"
        Me.cb_desc.FormattingEnabled = True
        Me.cb_desc.Location = New System.Drawing.Point(85, 210)
        Me.cb_desc.Name = "cb_desc"
        Me.cb_desc.Size = New System.Drawing.Size(127, 21)
        Me.cb_desc.TabIndex = 125
        '
        'txt_vtotal
        '
        Me.txt_vtotal.Location = New System.Drawing.Point(501, 212)
        Me.txt_vtotal.Name = "txt_vtotal"
        Me.txt_vtotal.ReadOnly = True
        Me.txt_vtotal.Size = New System.Drawing.Size(100, 20)
        Me.txt_vtotal.TabIndex = 124
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(438, 215)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(44, 13)
        Me.Label22.TabIndex = 123
        Me.Label22.Text = "V. Total"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(18, 30)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(751, 13)
        Me.Label21.TabIndex = 122
        Me.Label21.Text = "_________________________________________________________________________________" &
    "___________________________________________"
        '
        'txt_fec_com
        '
        Me.txt_fec_com.Location = New System.Drawing.Point(561, 8)
        Me.txt_fec_com.Name = "txt_fec_com"
        Me.txt_fec_com.Size = New System.Drawing.Size(200, 20)
        Me.txt_fec_com.TabIndex = 121
        '
        'btn_restar
        '
        Me.btn_restar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_restar.Location = New System.Drawing.Point(638, 210)
        Me.btn_restar.Name = "btn_restar"
        Me.btn_restar.Size = New System.Drawing.Size(75, 23)
        Me.btn_restar.TabIndex = 120
        Me.btn_restar.Text = "-"
        Me.btn_restar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.Location = New System.Drawing.Point(638, 170)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregar.TabIndex = 119
        Me.btn_agregar.Text = "+"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(16, 235)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(751, 13)
        Me.Label20.TabIndex = 118
        Me.Label20.Text = "_________________________________________________________________________________" &
    "___________________________________________"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(18, 150)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(751, 13)
        Me.Label19.TabIndex = 117
        Me.Label19.Text = "_________________________________________________________________________________" &
    "___________________________________________"
        '
        'txt_val_prod
        '
        Me.txt_val_prod.Location = New System.Drawing.Point(318, 212)
        Me.txt_val_prod.Name = "txt_val_prod"
        Me.txt_val_prod.ReadOnly = True
        Me.txt_val_prod.Size = New System.Drawing.Size(100, 20)
        Me.txt_val_prod.TabIndex = 116
        '
        'txt_cant
        '
        Me.txt_cant.Location = New System.Drawing.Point(501, 172)
        Me.txt_cant.Name = "txt_cant"
        Me.txt_cant.ReadOnly = True
        Me.txt_cant.Size = New System.Drawing.Size(100, 20)
        Me.txt_cant.TabIndex = 115
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(453, 175)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 13)
        Me.Label15.TabIndex = 114
        Me.Label15.Text = "Stock "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(253, 215)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 13)
        Me.Label16.TabIndex = 113
        Me.Label16.Text = "V. Unitario"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(253, 175)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 13)
        Me.Label17.TabIndex = 112
        Me.Label17.Text = "Cantidad"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(16, 215)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 13)
        Me.Label18.TabIndex = 111
        Me.Label18.Text = "Descripción"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 179)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 13)
        Me.Label14.TabIndex = 110
        Me.Label14.Text = "ID Producto"
        '
        'txt_id_prod
        '
        Me.txt_id_prod.Location = New System.Drawing.Point(81, 172)
        Me.txt_id_prod.Name = "txt_id_prod"
        Me.txt_id_prod.ReadOnly = True
        Me.txt_id_prod.Size = New System.Drawing.Size(100, 20)
        Me.txt_id_prod.TabIndex = 109
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_prod, Me.desc_prod, Me.cant_prod, Me.valor_unitario, Me.total_val})
        Me.dgv1.Location = New System.Drawing.Point(21, 265)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.Size = New System.Drawing.Size(544, 150)
        Me.dgv1.TabIndex = 96
        '
        'id_prod
        '
        Me.id_prod.HeaderText = "Código"
        Me.id_prod.Name = "id_prod"
        Me.id_prod.ReadOnly = True
        '
        'desc_prod
        '
        Me.desc_prod.HeaderText = "Descripción"
        Me.desc_prod.Name = "desc_prod"
        Me.desc_prod.ReadOnly = True
        '
        'cant_prod
        '
        Me.cant_prod.HeaderText = "Cantidad"
        Me.cant_prod.Name = "cant_prod"
        Me.cant_prod.ReadOnly = True
        '
        'valor_unitario
        '
        Me.valor_unitario.HeaderText = "Valor Unitario"
        Me.valor_unitario.Name = "valor_unitario"
        Me.valor_unitario.ReadOnly = True
        '
        'total_val
        '
        Me.total_val.HeaderText = "Valor Total"
        Me.total_val.Name = "total_val"
        Me.total_val.ReadOnly = True
        '
        'btn_volver
        '
        Me.btn_volver.Location = New System.Drawing.Point(15, 445)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(75, 23)
        Me.btn_volver.TabIndex = 95
        Me.btn_volver.TabStop = False
        Me.btn_volver.Text = "Regresar"
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(694, 445)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_salir.TabIndex = 94
        Me.btn_salir.TabStop = False
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(613, 445)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.btn_limpiar.TabIndex = 93
        Me.btn_limpiar.TabStop = False
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(526, 445)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar.TabIndex = 91
        Me.btn_guardar.TabStop = False
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'txt_por_iva
        '
        Me.txt_por_iva.AcceptsTab = True
        Me.txt_por_iva.Location = New System.Drawing.Point(647, 326)
        Me.txt_por_iva.Name = "txt_por_iva"
        Me.txt_por_iva.ReadOnly = True
        Me.txt_por_iva.Size = New System.Drawing.Size(119, 20)
        Me.txt_por_iva.TabIndex = 89
        Me.txt_por_iva.TabStop = False
        '
        'txt_val_com
        '
        Me.txt_val_com.AcceptsTab = True
        Me.txt_val_com.Location = New System.Drawing.Point(646, 369)
        Me.txt_val_com.Name = "txt_val_com"
        Me.txt_val_com.ReadOnly = True
        Me.txt_val_com.Size = New System.Drawing.Size(120, 20)
        Me.txt_val_com.TabIndex = 88
        Me.txt_val_com.TabStop = False
        '
        'txt_obs
        '
        Me.txt_obs.AcceptsTab = True
        Me.txt_obs.Location = New System.Drawing.Point(371, 442)
        Me.txt_obs.MaxLength = 50
        Me.txt_obs.Name = "txt_obs"
        Me.txt_obs.Size = New System.Drawing.Size(120, 20)
        Me.txt_obs.TabIndex = 87
        Me.txt_obs.TabStop = False
        '
        'txt_id_compra
        '
        Me.txt_id_compra.AcceptsTab = True
        Me.txt_id_compra.Location = New System.Drawing.Point(67, 8)
        Me.txt_id_compra.MaxLength = 50
        Me.txt_id_compra.Name = "txt_id_compra"
        Me.txt_id_compra.Size = New System.Drawing.Size(66, 20)
        Me.txt_id_compra.TabIndex = 86
        Me.txt_id_compra.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(571, 329)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Porcentaje Iva"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(571, 376)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "Valor Compra"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(298, 445)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Observación"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(483, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Fecha Compra"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "ID Compra"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(262, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 31)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Compras"
        '
        'txt_email
        '
        Me.txt_email.AcceptsTab = True
        Me.txt_email.Location = New System.Drawing.Point(348, 100)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.ReadOnly = True
        Me.txt_email.Size = New System.Drawing.Size(167, 20)
        Me.txt_email.TabIndex = 139
        Me.txt_email.TabStop = False
        '
        'txt_tel
        '
        Me.txt_tel.AcceptsTab = True
        Me.txt_tel.Location = New System.Drawing.Point(348, 57)
        Me.txt_tel.Name = "txt_tel"
        Me.txt_tel.ReadOnly = True
        Me.txt_tel.Size = New System.Drawing.Size(167, 20)
        Me.txt_tel.TabIndex = 138
        Me.txt_tel.TabStop = False
        '
        'txt_dir
        '
        Me.txt_dir.AcceptsTab = True
        Me.txt_dir.Location = New System.Drawing.Point(87, 137)
        Me.txt_dir.Name = "txt_dir"
        Me.txt_dir.ReadOnly = True
        Me.txt_dir.Size = New System.Drawing.Size(167, 20)
        Me.txt_dir.TabIndex = 137
        Me.txt_dir.TabStop = False
        '
        'txt_nom
        '
        Me.txt_nom.AcceptsTab = True
        Me.txt_nom.Location = New System.Drawing.Point(87, 97)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.ReadOnly = True
        Me.txt_nom.Size = New System.Drawing.Size(167, 20)
        Me.txt_nom.TabIndex = 136
        Me.txt_nom.TabStop = False
        '
        'txt_dv
        '
        Me.txt_dv.AcceptsTab = True
        Me.txt_dv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_dv.Location = New System.Drawing.Point(224, 57)
        Me.txt_dv.MaxLength = 1
        Me.txt_dv.Name = "txt_dv"
        Me.txt_dv.Size = New System.Drawing.Size(30, 20)
        Me.txt_dv.TabIndex = 135
        Me.txt_dv.TabStop = False
        '
        'txt_rut
        '
        Me.txt_rut.AcceptsTab = True
        Me.txt_rut.Location = New System.Drawing.Point(87, 57)
        Me.txt_rut.MaxLength = 8
        Me.txt_rut.Name = "txt_rut"
        Me.txt_rut.Size = New System.Drawing.Size(131, 20)
        Me.txt_rut.TabIndex = 134
        Me.txt_rut.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(293, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(293, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 132
        Me.Label8.Text = "Telefono"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 137)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 131
        Me.Label9.Text = "Direccion"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 130
        Me.Label10.Text = "Nombre"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 13)
        Me.Label11.TabIndex = 129
        Me.Label11.Text = "Rut"
        '
        'txt_nf
        '
        Me.txt_nf.AcceptsTab = True
        Me.txt_nf.Location = New System.Drawing.Point(224, 438)
        Me.txt_nf.MaxLength = 100
        Me.txt_nf.Name = "txt_nf"
        Me.txt_nf.Size = New System.Drawing.Size(52, 20)
        Me.txt_nf.TabIndex = 140
        Me.txt_nf.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(154, 445)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 141
        Me.Label12.Text = "N° Factura"
        '
        'Compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 481)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_nf)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_tel)
        Me.Controls.Add(Me.txt_dir)
        Me.Controls.Add(Me.txt_nom)
        Me.Controls.Add(Me.txt_dv)
        Me.Controls.Add(Me.txt_rut)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_v_n)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txt_stock_min)
        Me.Controls.Add(Me.cb_desc)
        Me.Controls.Add(Me.txt_vtotal)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txt_fec_com)
        Me.Controls.Add(Me.btn_restar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txt_val_prod)
        Me.Controls.Add(Me.txt_cant)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txt_id_prod)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.txt_por_iva)
        Me.Controls.Add(Me.txt_val_com)
        Me.Controls.Add(Me.txt_obs)
        Me.Controls.Add(Me.txt_id_compra)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Compra"
        Me.Text = "Compra"
        CType(Me.txt_stock_min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_v_n As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txt_stock_min As NumericUpDown
    Friend WithEvents cb_desc As ComboBox
    Friend WithEvents txt_vtotal As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txt_fec_com As DateTimePicker
    Friend WithEvents btn_restar As Button
    Friend WithEvents btn_agregar As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txt_val_prod As TextBox
    Friend WithEvents txt_cant As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_id_prod As TextBox
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents id_prod As DataGridViewTextBoxColumn
    Friend WithEvents desc_prod As DataGridViewTextBoxColumn
    Friend WithEvents cant_prod As DataGridViewTextBoxColumn
    Friend WithEvents valor_unitario As DataGridViewTextBoxColumn
    Friend WithEvents total_val As DataGridViewTextBoxColumn
    Friend WithEvents btn_volver As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents txt_por_iva As TextBox
    Friend WithEvents txt_val_com As TextBox
    Friend WithEvents txt_obs As TextBox
    Friend WithEvents txt_id_compra As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_tel As TextBox
    Friend WithEvents txt_dir As TextBox
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents txt_dv As TextBox
    Friend WithEvents txt_rut As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_nf As TextBox
    Friend WithEvents Label12 As Label
End Class
