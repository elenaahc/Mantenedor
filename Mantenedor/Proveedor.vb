Public Class Proveedor
    Dim Proveedor As New MantenedorTableAdapters.ProveedorTableAdapter
    Private Function ValidarProveedor()
        ValidarProveedor = False
        If Trim(txt_nom.Text) = "" Then
            MsgBox("Debe ingresar un nombre al Proveedor")
            txt_nom.Focus()
            Exit Function
        End If
        If Trim(txt_dir.Text) = "" Then
            MsgBox("Debe ingresar una dirección al Proveedor")
            txt_dir.Focus()
            Exit Function
        End If
        If Trim(txt_tel.Text) = "" Then
            MsgBox("Debe ingresar un Telefono al Proveedor")
            txt_tel.Focus()
            Exit Function
        End If
        If Trim(txt_email.Text) = "" Then
            MsgBox("Debe ingresar un Email al Proveedor")
            txt_email.Focus()
            Exit Function
        End If
        If ValidaMail(txt_email.Text) = False Then
            MsgBox("Debe ingresar un correo valido")
            txt_email.Focus()
            Exit Function
        End If
        ValidarProveedor = True
    End Function
    Private Sub MostrarDatos()
        txt_nom.Text = Proveedor.MostrarProveedor(txt_rut.Text).Rows(0).Item(1).ToString
        txt_dir.Text = Proveedor.MostrarProveedor(txt_rut.Text).Rows(0).Item(2).ToString
        txt_tel.Text = Proveedor.MostrarProveedor(txt_rut.Text).Rows(0).Item(3).ToString
        txt_email.Text = Proveedor.MostrarProveedor(txt_rut.Text).Rows(0).Item(4).ToString
    End Sub
    Private Sub Limpiar()
        txt_rut.Clear()
        txt_dv.Clear()
        txt_nom.Clear()
        txt_dir.Clear()
        txt_tel.Clear()
        txt_email.Clear()
        txt_rut.Enabled = True
        txt_dv.Enabled = True
        txt_nom.Enabled = False
        txt_dir.Enabled = False
        txt_tel.Enabled = False
        txt_email.Enabled = False
        btn_guardar.Enabled = False
        btn_eliminar.Enabled = False
        txt_rut.Focus()
    End Sub
    Private Sub Habilitar()
        txt_rut.Enabled = False
        txt_dv.Enabled = False
        txt_nom.Enabled = True
        txt_dir.Enabled = True
        txt_tel.Enabled = True
        txt_email.Enabled = True
        btn_guardar.Enabled = True
        btn_eliminar.Enabled = True
        txt_nom.Focus()
    End Sub
    Private Sub Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
    End Sub
    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        Limpiar()
    End Sub
    Private Sub txt_rut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_rut.KeyPress
        Dim keyAscii As Short = CShort(Asc(e.KeyChar))
        keyAscii = CShort(SoloNumeros(keyAscii))
        If keyAscii = 0 Then
            e.Handled = True
        End If

        If e.KeyChar = Chr(13) Or e.KeyChar = Chr(9) Or e.KeyChar = Chr(11) Then
            If txt_rut.Text = "" Then
                MsgBox("Debe ingresar un rut")
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
                    If Proveedor.ExisteProveedor(txt_rut.Text) > 0 Then
                        MostrarDatos()
                        Habilitar()
                    Else
                        Habilitar()
                        txt_nom.Focus()
                    End If
                Else
                    MsgBox("Rut Incorrecto")
                    Limpiar()
                End If
            End If
        End If
    End Sub
    Private Sub txt_nom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nom.KeyPress
        Dim keyAscii As Short = CShort(Asc(e.KeyChar))
        keyAscii = CShort(SoloTexto(keyAscii))
        If keyAscii = 0 Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Or e.KeyChar = Chr(9) Or e.KeyChar = Chr(11) Then
            If Trim(txt_nom.Text) = "" Then
                MsgBox("Debe Ingresar un Nombre para el Proveedor")
                txt_nom.Focus()
            Else
                txt_dir.Focus()
            End If
        End If
    End Sub
    Private Sub txt_dir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_dir.KeyPress
        Dim keyAscii As Short = CShort(Asc(e.KeyChar))
        keyAscii = CShort(TextoNumeros(keyAscii))
        If keyAscii = 0 Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Or e.KeyChar = Chr(9) Or e.KeyChar = Chr(11) Then
            If Trim(txt_dir.Text) = "" Then
                MsgBox("Debe Ingresar una dirección para el Proveedor")
                txt_dir.Focus()
            Else
                txt_tel.Focus()
            End If
        End If
    End Sub
    Private Sub txt_tel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_tel.KeyPress
        Dim keyAscii As Short = CShort(Asc(e.KeyChar))
        keyAscii = CShort(SoloNumerost(keyAscii))
        If keyAscii = 0 Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Or e.KeyChar = Chr(9) Or e.KeyChar = Chr(11) Then
            If Trim(txt_dir.Text) = "" Then
                MsgBox("Debe Ingresar un numero para el Proveedor")
                txt_tel.Focus()
            Else
                txt_email.Focus()
            End If
        End If
    End Sub
    Private Sub txt_email_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_email.KeyPress
        Dim keyAscii As Short = CShort(Asc(e.KeyChar))
        If e.KeyChar = Chr(13) Or e.KeyChar = Chr(9) Or e.KeyChar = Chr(11) Then
            If Trim(txt_email.Text) = "" Then
                MsgBox("Debe Ingresar un email para el Proveedor")
                txt_email.Focus()
            Else
                If ValidaMail(txt_email.Text) = False Then
                    MsgBox("Debe ingresar un correo valido")
                    txt_email.Focus()
                Else
                    btn_guardar.Focus()
                End If
            End If
        End If
    End Sub
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Try
            If ValidarProveedor() = True Then
                If Proveedor.ExisteProveedor(txt_rut.Text) > 0 Then
                    Proveedor.ActualizarProveedor(txt_rut.Text, txt_nom.Text, txt_dir.Text, txt_tel.Text, txt_email.Text, txt_rut.Text)
                    MsgBox("El Proveedor fue actualizado con exito")
                    Limpiar()
                Else
                    Proveedor.AgregarProveedor(txt_rut.Text, txt_nom.Text, txt_dir.Text, txt_tel.Text, txt_email.Text)
                    MsgBox("El Proveedor fue agregado con exito")
                    Limpiar()
                End If
            End If
        Catch ex As Exception

            MsgBox("Error de datos")
        End Try
    End Sub
    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If Proveedor.ExisteProveedor(txt_rut.Text) > 0 Then
            If MsgBox("Esta seguro que desea eliminar?", vbYesNo, "Eliminar Registro") = MsgBoxResult.Yes Then
                Proveedor.EliminarProveedor(txt_rut.Text)
                MsgBox("El Proveedor fue eliminado con exito")
                Limpiar()
            End If
        Else
            MsgBox("El Proveedor no existe")
        End If
    End Sub
    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Inicio.Show()
        Me.Hide()
    End Sub
    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
        Cliente.Close()
        Inicio.Close()
        Unidad_Medida.Close()
        Productos.Close()
        Venta.Close()
        Compra.Close()
        VentasCliente.Close()
        VentasFecha.Close()
        ComprasFecha.Close()
        ExistenciaProductos.Close()
    End Sub
End Class