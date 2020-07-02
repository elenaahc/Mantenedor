Imports System.Data.SqlClient
Public Class Productos
    Dim Productos As New MantenedorTableAdapters.ProductoTableAdapter
    Private Function ValidarProducto()
        ValidarProducto = False
        If Trim(txt_id_prod.Text) = "" Then
            MsgBox("Debe ingresar una Id al Producto")
            txt_id_prod.Focus()
            Exit Function
        End If
        If Trim(txt_desc.Text) = "" Then
            MsgBox("Debe ingresar una descripción al Producto")
            txt_desc.Focus()
            Exit Function
        End If
        If Trim(txt_cant.Text) = "" Then
            MsgBox("Debe ingresar una cantidad al Producto")
            txt_cant.Focus()
            Exit Function
        End If
        If Trim(txt_val_prod.Text) = "" Then
            MsgBox("Debe ingresar un valor al Producto")
            txt_val_prod.Focus()
            Exit Function
        End If
        If Trim(txt_stock_min.Text) = "" Then
            MsgBox("Debe ingresar un stock minimo al Producto")
            txt_stock_min.Focus()
            Exit Function
        End If
        ValidarProducto = True
    End Function
    Private Sub MostrarDatos()
        cb_ud.SelectedValue = Productos.MostrarProducto(txt_id_prod.Text).Rows(0).Item(1).ToString
        txt_desc.Text = Productos.MostrarProducto(txt_id_prod.Text).Rows(0).Item(2).ToString
        txt_cant.Text = Productos.MostrarProducto(txt_id_prod.Text).Rows(0).Item(3).ToString
        txt_val_prod.Text = Productos.MostrarProducto(txt_id_prod.Text).Rows(0).Item(4).ToString
        txt_stock_min.Text = Productos.MostrarProducto(txt_id_prod.Text).Rows(0).Item(5).ToString
    End Sub
    Private Sub Limpiar()
        txt_id_prod.Clear()
        txt_desc.Clear()
        txt_cant.Clear()
        txt_val_prod.Clear()
        txt_stock_min.Clear()
        txt_id_prod.Focus()
        txt_id_prod.Enabled = True
        cb_ud.Enabled = False
        txt_desc.Enabled = False
        txt_cant.Enabled = False
        txt_val_prod.Enabled = False
        txt_stock_min.Enabled = False
        btn_guardar.Enabled = False
        btn_eliminar.Enabled = False
        txt_id_prod.Focus()
        Cargar()
    End Sub
    Private Sub Habilitar()
        txt_id_prod.Enabled = False
        cb_ud.Enabled = True
        txt_desc.Enabled = True
        txt_cant.Enabled = True
        txt_val_prod.Enabled = True
        txt_stock_min.Enabled = True
        btn_guardar.Enabled = True
        btn_eliminar.Enabled = True
        txt_desc.Focus()
    End Sub
    Private Sub Cargar()
        txt_id_prod.Focus()
        Dim connection As New SqlConnection("Server = DESKTOP-HKI745B; Database = Mantenedor; Integrated Security = True ")
        Dim command As New SqlCommand("Select * From U_Medida", connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        cb_ud.DataSource = table
        cb_ud.DisplayMember = "desc_U_M"
        cb_ud.ValueMember = "id_U_M"
    End Sub
    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_id_prod.Focus()
        Limpiar()
    End Sub
    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        Limpiar()
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
                If Productos.ExisteProducto(txt_id_prod.Text) > 0 Then
                    MostrarDatos()
                    Habilitar()
                Else
                    Habilitar()
                    cb_ud.Focus()
                End If
            End If
        End If
    End Sub
    Private Sub txt_desc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_desc.KeyPress
        Dim keyAscii As Short = CShort(Asc(e.KeyChar))
        keyAscii = CShort(SoloTexto(keyAscii))
        If keyAscii = 0 Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Or e.KeyChar = Chr(9) Or e.KeyChar = Chr(11) Then
            If Trim(txt_desc.Text) = "" Then
                MsgBox("Debe Ingresar una descripción")
                txt_desc.Focus()
            Else
                txt_cant.Focus()
            End If
        End If
    End Sub
    Private Sub txt_cant_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cant.KeyPress
        Dim keyAscii As Short = CShort(Asc(e.KeyChar))
        keyAscii = CShort(SoloNumeros(keyAscii))
        If keyAscii = 0 Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Or e.KeyChar = Chr(9) Or e.KeyChar = Chr(11) Then
            If Trim(txt_cant.Text) = "" Then
                MsgBox("Debe Ingresar una cantidad")
                txt_cant.Focus()
            Else
                txt_val_prod.Focus()
            End If
        End If
    End Sub
    Private Sub txt_val_prod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_val_prod.KeyPress
        Dim keyAscii As Short = CShort(Asc(e.KeyChar))
        keyAscii = CShort(SoloNumeros(keyAscii))
        If keyAscii = 0 Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Or e.KeyChar = Chr(9) Or e.KeyChar = Chr(11) Then
            If Trim(txt_cant.Text) = "" Then
                MsgBox("Debe Ingresar un valor")
                txt_val_prod.Focus()
            Else
                txt_stock_min.Focus()
            End If
        End If
    End Sub

    Private Sub txt_stock_min_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_stock_min.KeyPress
        Dim keyAscii As Short = CShort(Asc(e.KeyChar))
        keyAscii = CShort(SoloNumeros(keyAscii))
        If keyAscii = 0 Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Or e.KeyChar = Chr(9) Or e.KeyChar = Chr(11) Then
            If Trim(txt_cant.Text) = "" Then
                MsgBox("Debe Ingresar un Stock mínimo")
                txt_stock_min.Focus()
            Else
                btn_guardar.Focus()
            End If
        End If
    End Sub
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim itemSeleccionado As String = cb_ud.SelectedValue.ToString
        Try
            If ValidarProducto() = True Then
                If Productos.ExisteProducto(txt_id_prod.Text) > 0 Then
                    Productos.ActualizarProducto(txt_id_prod.Text, itemSeleccionado, txt_desc.Text, txt_cant.Text, txt_val_prod.Text, txt_stock_min.Text, txt_id_prod.Text)
                    MsgBox("Actualización exitosa")
                    Limpiar()
                Else
                    Productos.AgregarProducto(txt_id_prod.Text, itemSeleccionado, txt_desc.Text, txt_cant.Text, txt_val_prod.Text, txt_stock_min.Text)
                    MsgBox("Guardado exitoso")
                    Limpiar()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error de Datos")
        End Try
    End Sub
    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If Productos.ExisteProducto(txt_id_prod.Text) > 0 Then
            If MsgBox("Esta seguro que desea eliminar?", vbYesNo, "Eliminar Registro") = MsgBoxResult.Yes Then
                Productos.EliminarProducto(txt_id_prod.Text)
                MsgBox("El Producto fue eliminado con exito")
                Limpiar()
            End If
        Else
            MsgBox("El Producto no existe")
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
        Inicio.Close()
        Venta.Close()
        Compra.Close()
        VentasCliente.Close()
        VentasFecha.Close()
        ComprasFecha.Close()
        ExistenciaProductos.Close()
    End Sub
End Class