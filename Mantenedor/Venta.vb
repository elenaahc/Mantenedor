Imports System.Data.SqlClient
Public Class Venta
    Dim Venta As New MantenedorTableAdapters.VentaTableAdapter
    Dim Clientes As New MantenedorTableAdapters.ClienteTableAdapter
    Dim Producto As New MantenedorTableAdapters.ProductoTableAdapter
    Dim DetVenta As New MantenedorTableAdapters.Det_P_VentaTableAdapter
    Dim totalVentaNeto As Integer
    Dim ValorIva As Integer
    Dim ValorTotal As Integer
    Dim maxStock As Integer
    Dim sumarStock As Integer
    Dim stockInicialProducto As Integer
    Private Function ValidarVenta()
        ValidarVenta = False
        If Trim(txt_id_venta.Text) = "" Then
            MsgBox("Debe ingresar una ID a la Venta")
            txt_id_venta.Focus()
            Exit Function
        End If
        If Trim(txt_rut.Text) = "" Then
            MsgBox("Debe ingresar un rut de cliente a la Venta")
            txt_rut.Focus()
            Exit Function
        End If
        If Trim(txt_fec_ven.Text) = "" Then
            MsgBox("Debe ingresar una fecha a la Venta")
            txt_fec_ven.Focus()
            Exit Function
        End If
        If Trim(txt_obs.Text) = "" Then
            MsgBox("Debe ingresar una observación a la Venta")
            txt_obs.Focus()
            Exit Function
        End If
        If Trim(txt_val_ven.Text) = "" Then
            MsgBox("Debe ingresar un valor a la Venta")
            txt_val_ven.Focus()
            Exit Function
        End If
        If Trim(txt_por_iva.Text) = "" Then
            MsgBox("Debe ingresar un porcentaje a la Venta")
            txt_por_iva.Focus()
            Exit Function
        End If
        ValidarVenta = True
    End Function
    'Private Sub MostrarDatos()
    '    txt_rut.Text = Venta.MostrarVenta(txt_id_venta.Text).Rows(0).Item(1).ToString
    '    txt_fec_ven.Text = Venta.MostrarVenta(txt_id_venta.Text).Rows(0).Item(2).ToString
    '    txt_obs.Text = Venta.MostrarVenta(txt_id_venta.Text).Rows(0).Item(3).ToString
    '    txt_val_ven.Text = Venta.MostrarVenta(txt_id_venta.Text).Rows(0).Item(4).ToString
    '    txt_por_iva.Text = Venta.MostrarVenta(txt_id_venta.Text).Rows(0).Item(5).ToString
    'End Sub
    Private Sub MostrarDatosCliente()
        txt_nom.Text = Clientes.MostrarCliente(txt_rut.Text).Rows(0).Item(1).ToString
        txt_giro.Text = Clientes.MostrarCliente(txt_rut.Text).Rows(0).Item(2).ToString
        txt_dir.Text = Clientes.MostrarCliente(txt_rut.Text).Rows(0).Item(3).ToString
        txt_tel.Text = Clientes.MostrarCliente(txt_rut.Text).Rows(0).Item(4).ToString
        txt_email.Text = Clientes.MostrarCliente(txt_rut.Text).Rows(0).Item(5).ToString
        txt_ciu.Text = Clientes.MostrarCliente(txt_rut.Text).Rows(0).Item(6).ToString
    End Sub
    Private Sub MostrarDatosProd()
        txt_id_prod.Text = Producto.MostrarProducto(txt_id_prod.Text).Rows(0).Item(0).ToString
        txt_cant.Text = Producto.MostrarProducto(txt_id_prod.Text).Rows(0).Item(3).ToString
        txt_val_prod.Text = Producto.MostrarProducto(txt_id_prod.Text).Rows(0).Item(4).ToString
        txt_stock_min.Text = Producto.MostrarProducto(txt_id_prod.Text).Rows(0).Item(5).ToString
    End Sub
    Private Sub Limpiar()
        'venta
        txt_id_venta.Focus()
        txt_id_venta.Clear()
        txt_id_venta.Enabled = True
        txt_fec_ven.Enabled = False
        txt_obs.Enabled = False
        txt_val_ven.Enabled = False
        txt_val_ven.Clear()
        txt_por_iva.Clear()
        txt_por_iva.Enabled = False
        'cliente
        txt_rut.Clear()
        txt_dv.Clear()
        txt_nom.Clear()
        txt_giro.Clear()
        txt_dir.Clear()
        txt_tel.Clear()
        txt_email.Clear()
        txt_ciu.Clear()
        txt_rut.Enabled = False
        txt_dv.Enabled = False
        txt_nom.Enabled = False
        txt_giro.Enabled = False
        txt_dir.Enabled = False
        txt_tel.Enabled = False
        txt_email.Enabled = False
        txt_ciu.Enabled = False
        'producto
        txt_id_prod.Clear()
        txt_cant.Clear()
        txt_val_prod.Clear()
        txt_stock_min.Value = 0
        txt_obs.Clear()
        txt_id_prod.Enabled = False
        cb_desc.Enabled = False
        txt_cant.Enabled = False
        txt_val_prod.Enabled = False
        txt_stock_min.Enabled = False
        txt_obs.Enabled = False
        txt_vtotal.Clear()
        txt_vtotal.Enabled = False

        txt_v_n.Text = 0
        txt_por_iva.Text = 0
        txt_val_ven.Text = 0
        dgv1.Rows.Clear()
        btn_guardar.Enabled = False
        CargarProducto()
    End Sub
    Private Sub Habilitar()
        'venta
        txt_id_venta.Enabled = False
        txt_fec_ven.Enabled = True
        txt_obs.Enabled = True
        txt_val_ven.Enabled = True
        txt_por_iva.Enabled = True
        'cliente
        txt_rut.Focus()
        txt_rut.Enabled = True
        txt_dv.Enabled = True
        txt_nom.Enabled = True
        txt_giro.Enabled = True
        txt_dir.Enabled = True
        txt_tel.Enabled = True
        txt_email.Enabled = True
        txt_ciu.Enabled = True
        'producto
        txt_id_prod.Enabled = True
        cb_desc.Enabled = True
        txt_cant.Enabled = True
        txt_val_prod.Enabled = True
        txt_stock_min.Enabled = True
        txt_obs.Enabled = True
        txt_vtotal.Enabled = True

        btn_guardar.Enabled = True
    End Sub
    Private Sub LimpiarBtn_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        Limpiar()
    End Sub
    Private Sub CargarProducto()
        Dim connection As New SqlConnection("Server = DESKTOP-HKI745B; Database = Mantenedor; Integrated Security = True ")
        Dim command As New SqlCommand("Select * From Producto", connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        cb_desc.DataSource = table
        cb_desc.DisplayMember = "desc_prod"
        cb_desc.ValueMember = "id_prod"
    End Sub
    Private Sub Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
        txt_id_prod.Text = ""
    End Sub
    Private Sub txt_id_venta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_id_venta.KeyPress
        Dim keyAscii As Short = CShort(Asc(e.KeyChar))
        keyAscii = CShort(TextoNumeros(keyAscii))
        If keyAscii = 0 Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Or e.KeyChar = Chr(9) Or e.KeyChar = Chr(11) Then
            If Trim(txt_id_venta.Text) = "" Then
                MsgBox("Debe Ingresar una ID a la Venta")
                txt_id_venta.Focus()
            Else
                If Venta.ExisteVenta(txt_id_venta.Text) > 0 Then
                    MsgBox("Esta ID ya existe")

                Else
                    Habilitar()
                    txt_rut.Focus()
                End If
            End If
        End If
    End Sub
    Private Sub txt_rut_clie_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_rut.KeyPress
        Dim keyAscii As Short = CShort(Asc(e.KeyChar))
        keyAscii = CShort(SoloNumeros(keyAscii))
        If keyAscii = 0 Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Or e.KeyChar = Chr(9) Or e.KeyChar = Chr(11) Then
            If Trim(txt_rut.Text) = "" Then
                MsgBox("Debe Ingresar un rut a la Venta")
                txt_rut.Focus()
            Else
                txt_dv.Focus()
            End If
        End If
    End Sub
    Private Sub txt_dv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_dv.KeyPress
        Dim keyAscii As Short = CShort(Asc(e.KeyChar))
        keyAscii = CShort(SoloNumerosd(keyAscii))
        If keyAscii = 0 Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Or e.KeyChar = Chr(9) Or e.KeyChar = Chr(11) Then
            If txt_dv.Text = "" Then
                MsgBox("Debe ingresar un digito verificador")
                txt_dv.Focus()
            Else
                If validarRut(txt_rut.Text) = txt_dv.Text Then
                    If Venta.ExisteCliente(txt_rut.Text) > 0 Then
                        MostrarDatosCliente()
                        Habilitar()
                    Else
                        MsgBox("Este cliente no está registrado en nuestros servidores")
                        Limpiar()
                    End If
                Else
                    MsgBox("Rut Incorrecto")
                    Limpiar()
                End If
            End If
        End If
    End Sub
    Private Sub txt_fec_ven_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_fec_ven.KeyPress
        Dim keyAscii As Short = CShort(Asc(e.KeyChar))
        keyAscii = CShort(TextoNumeros(keyAscii))
        If keyAscii = 0 Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Or e.KeyChar = Chr(9) Or e.KeyChar = Chr(11) Then
            If Trim(txt_fec_ven.Text) = "" Then
                MsgBox("Debe Ingresar una fecha a la Venta")
                txt_fec_ven.Focus()
            Else
                txt_obs.Focus()
            End If
        End If
    End Sub

    Private Sub txt_obs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_obs.KeyPress
        Dim keyAscii As Short = CShort(Asc(e.KeyChar))
        keyAscii = CShort(TextoNumeros(keyAscii))
        If keyAscii = 0 Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Or e.KeyChar = Chr(9) Or e.KeyChar = Chr(11) Then
            If Trim(txt_obs.Text) = "" Then
                MsgBox("Debe Ingresar una observación a la Venta")
                txt_obs.Focus()
            Else
                txt_val_ven.Focus()
            End If
        End If
    End Sub
    Private Sub txt_val_ven_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_val_ven.KeyPress
        Dim keyAscii As Short = CShort(Asc(e.KeyChar))
        keyAscii = CShort(SoloNumeros(keyAscii))
        If keyAscii = 0 Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Or e.KeyChar = Chr(9) Or e.KeyChar = Chr(11) Then
            If Trim(txt_val_ven.Text) = "" Then
                MsgBox("Debe Ingresar un valor a la Venta")
                txt_val_ven.Focus()
            Else
                txt_por_iva.Focus()
            End If
        End If
    End Sub

    Private Sub txt_por_iva_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_por_iva.KeyPress
        Dim keyAscii As Short = CShort(Asc(e.KeyChar))
        keyAscii = CShort(SoloNumeros(keyAscii))
        If keyAscii = 0 Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Or e.KeyChar = Chr(9) Or e.KeyChar = Chr(11) Then
            If Trim(txt_por_iva.Text) = "" Then
                MsgBox("Debe Ingresar un porcentaje a la Venta")
                txt_por_iva.Focus()
            Else
                btn_guardar.Focus()
            End If
        End If
    End Sub

    Private Sub txt_id_prod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_id_prod.KeyPress
        Dim keyAscii As Short = CShort(Asc(e.KeyChar))
        keyAscii = CShort(TextoNumeros(keyAscii))
        If keyAscii = 0 Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            If txt_id_prod.Text = " " Then
                MsgBox("Ingrese ID")
                txt_id_prod.Focus()
            Else
                If Producto.ExisteProducto(txt_id_prod.Text) > 0 Then
                    MostrarDatosProd()
                    Habilitar()
                Else
                    Habilitar()
                    btn_agregar.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub cb_desc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_desc.SelectedIndexChanged
        txt_id_prod.Text = cb_desc.SelectedValue.ToString
        If Producto.ExisteProducto(txt_id_prod.Text) > 0 Then
            MostrarDatosProd()
            stockInicialProducto = txt_cant.Text
            maxStock = txt_cant.Text
        End If
    End Sub
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        'validacion de que tenga el valor total calculado
        If txt_stock_min.Value > txt_cant.Text Then
            MsgBox("La cantidad ingresada supera el stock actual")
        Else
            If txt_vtotal.Text = "" Then
                MsgBox("Debe calcular el valor total del producto")
            Else
                dgv1.Rows.Add(txt_id_prod.Text, cb_desc.Text.ToString, txt_stock_min.Text, txt_val_prod.Text, txt_vtotal.Text)

                totalVentaNeto = 0
                For i = 0 To dgv1.RowCount - 1
                    totalVentaNeto = totalVentaNeto + dgv1.Item(4, i).Value
                    txt_v_n.Text = totalVentaNeto
                Next

                ValorIva = totalVentaNeto * 0.19
                txt_por_iva.Text = ValorIva

                ValorTotal = totalVentaNeto + ValorIva
                txt_val_ven.Text = ValorTotal

                If maxStock <= 0 Then
                    txt_cant.Text = maxStock
                Else
                    maxStock = txt_cant.Text - txt_stock_min.Text
                End If

                txt_cant.Text = maxStock

                Dim cnn As New SqlConnection("Server = DESKTOP-HKI745B; Database = Mantenedor; Integrated Security = True ")
                Dim cmd As SqlCommand
                cmd = New SqlCommand()
                cmd.Connection = cnn
                cmd.CommandText = "UPDATE Producto SET cant_prod = @cant_prod Where id_prod = @id_prod"

                cnn.Open()
                Dim param As SqlParameter
                param = New SqlParameter()
                param.ParameterName = “@cant_prod”
                param.SqlDbType = SqlDbType.Int
                param.Size = 8
                param.Value = txt_cant.Text
                Dim param2 As SqlParameter
                param2 = New SqlParameter()
                param2.ParameterName = “@id_prod”
                param2.SqlDbType = SqlDbType.VarChar
                param2.Size = 10
                param2.Value = txt_id_prod.Text

                cmd.Parameters.Add(param)
                cmd.Parameters.Add(param2)
                cmd.ExecuteNonQuery()

                cnn.Close()

                If maxStock > txt_cant.Text Then
                    MsgBox("Excede el máximo de disponibilidad")
                    txt_cant.Text = "Agotado"
                End If

            End If
        End If

    End Sub
    Private Sub ValorTotalProducto()
        Dim valTotalProd As Integer
        valTotalProd = txt_stock_min.Value * txt_val_prod.Text
        txt_vtotal.Text = valTotalProd
    End Sub
    Private Sub txt_stock_min_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_stock_min.KeyPress
        ValorTotalProducto()
        If txt_stock_min.Value > txt_cant.Text Then
            MsgBox("La cantidad ingresada supera el stock actual")
        End If
    End Sub
    Private Sub btn_restar_Click(sender As Object, e As EventArgs) Handles btn_restar.Click
        If txt_vtotal.Text = "" Or dgv1.Rows.Count = 0 Then
            MsgBox("Debe ingresar un producto")
        Else
            totalVentaNeto = txt_v_n.Text
            If dgv1.Rows.Count - 1 = -1 Then
                MsgBox("No hay items para restar")
            Else
                totalVentaNeto = totalVentaNeto - dgv1.Item(4, dgv1.Rows.Count - 1).Value

                sumarStock = dgv1.Item(2, dgv1.Rows.Count - 1).Value
                txt_cant.Text = sumarStock + txt_cant.Text

                Dim cnn As New SqlConnection("Server = DESKTOP-HKI745B; Database = Mantenedor; Integrated Security = True ")
                Dim cmd As SqlCommand
                cmd = New SqlCommand()
                cmd.Connection = cnn
                cmd.CommandText = "UPDATE Producto SET cant_prod = @cant_prod Where id_prod = @id_prod"

                cnn.Open()
                Dim param As SqlParameter
                param = New SqlParameter()
                param.ParameterName = “@cant_prod”
                param.SqlDbType = SqlDbType.Int
                param.Size = 8
                param.Value = txt_cant.Text
                Dim param2 As SqlParameter
                param2 = New SqlParameter()
                param2.ParameterName = “@id_prod”
                param2.SqlDbType = SqlDbType.VarChar
                param2.Size = 10
                param2.Value = txt_id_prod.Text

                cmd.Parameters.Add(param)
                cmd.Parameters.Add(param2)
                cmd.ExecuteNonQuery()

                cnn.Close()
                '..
                dgv1.Rows.RemoveAt(dgv1.Rows.Count - 1)
                txt_v_n.Text = totalVentaNeto

                ValorIva = totalVentaNeto * 0.19
                txt_por_iva.Text = ValorIva

                If dgv1.Rows.Count - 1 = 0 Then
                    ValorTotal = totalVentaNeto + ValorIva
                    txt_val_ven.Text = ValorTotal
                Else
                    ValorTotal = totalVentaNeto - ValorIva
                    txt_val_ven.Text = ValorTotal
                End If
            End If
        End If
    End Sub
    Private Sub GuardarBtn_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If ValidarVenta() = True Then
            If Venta.ExisteCliente(txt_rut.Text) > 0 Then

                Venta.AgregarVenta(txt_id_venta.Text, txt_rut.Text, txt_fec_ven.Text, txt_obs.Text, txt_val_ven.Text, txt_por_iva.Text)
                For i = 0 To dgv1.RowCount - 1
                    Dim idProd As String = dgv1.Item(0, i).Value.ToString
                    Dim cant As String = dgv1.Item(2, i).Value.ToString
                    Dim monto As String = dgv1.Item(4, i).Value.ToString
                    Dim linea As Integer = i + 1
                    DetVenta.AgregarDetVenta(txt_id_venta.Text, idProd, i + 1, cant, monto)
                Next
                MsgBox("La venta fue agregada con éxito")
                Limpiar()
            End If
        End If
    End Sub
    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Inicio.Show()
        Me.Hide()
    End Sub
    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
        Cliente.Close()
        Proveedor.Close()
        Unidad_Medida.Close()
        Productos.Close()
        Inicio.Close()
        Compra.Close()
        VentasCliente.Close()
        VentasFecha.Close()
        ComprasFecha.Close()
        ExistenciaProductos.Close()
    End Sub
End Class