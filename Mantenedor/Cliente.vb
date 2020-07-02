Public Class Cliente
    Dim Cliente As New MantenedorTableAdapters.ClienteTableAdapter
    Private Function ValidarCliente()
        ValidarCliente = False
        If Trim(txt_nom.Text) = "" Then
            MsgBox("Debe ingresar un nombre al Cliente")
            txt_nom.Focus()
            Exit Function
        End If
        If Trim(txt_giro.Text) = "" Then
            MsgBox("Debe ingresar un giro al Cliente")
            txt_giro.Focus()
            Exit Function
        End If
        If Trim(txt_dir.Text) = "" Then
            MsgBox("Debe ingresar una dirección al Cliente")
            txt_dir.Focus()
            Exit Function
        End If
        If Trim(txt_tel.Text) = "" Then
            MsgBox("Debe ingresar un telefono al Cliente")
            txt_tel.Focus()
            Exit Function
        End If
        If Trim(txt_email.Text) = "" Then
            MsgBox("Debe ingresar un email al Cliente")
            txt_email.Focus()
            Exit Function
        End If
        If Trim(txt_ciu.Text) = "" Then
            MsgBox("Debe ingresar una ciudad al Cliente")
            txt_ciu.Focus()
            Exit Function
        End If
        ValidarCliente = True
    End Function
    Private Sub MostrarDatos()
        txt_nom.Text = Cliente.MostrarCliente(txt_rut.Text).Rows(0).Item(1).ToString
        txt_giro.Text = Cliente.MostrarCliente(txt_rut.Text).Rows(0).Item(2).ToString
        txt_dir.Text = Cliente.MostrarCliente(txt_rut.Text).Rows(0).Item(3).ToString
        txt_tel.Text = Cliente.MostrarCliente(txt_rut.Text).Rows(0).Item(4).ToString
        txt_email.Text = Cliente.MostrarCliente(txt_rut.Text).Rows(0).Item(5).ToString
        txt_ciu.Text = Cliente.MostrarCliente(txt_rut.Text).Rows(0).Item(6).ToString
    End Sub
    Private Sub Limpiar()
        txt_rut.Clear()
        txt_dv.Clear()
        txt_nom.Clear()
        txt_giro.Clear()
        txt_dir.Clear()
        txt_tel.Clear()
        txt_email.Clear()
        txt_ciu.Clear()
        txt_rut.Enabled = True
        txt_dv.Enabled = True
        txt_nom.Enabled = False
        txt_giro.Enabled = False
        txt_dir.Enabled = False
        txt_tel.Enabled = False
        txt_email.Enabled = False
        txt_ciu.Enabled = False
        btn_guardar.Enabled = False
        btn_eliminar.Enabled = False
        txt_rut.Focus()
    End Sub
    Private Sub Habilitar()
        txt_rut.Enabled = False
        txt_dv.Enabled = False
        txt_nom.Enabled = True
        txt_giro.Enabled = True
        txt_dir.Enabled = True
        txt_tel.Enabled = True
        txt_email.Enabled = True
        txt_ciu.Enabled = True
        btn_guardar.Enabled = True
        btn_eliminar.Enabled = True
        txt_nom.Focus()
    End Sub
    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            If Trim(txt_rut.Text) = "" Then
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
                    If Cliente.ExisteCliente(txt_rut.Text) > 0 Then
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
                MsgBox("Debe Ingresar un Nombre para el Cliente")
                txt_nom.Focus()
            Else
                txt_giro.Focus()
            End If
        End If
    End Sub
    Private Sub txt_giro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_giro.KeyPress
        Dim keyAscii As Short = CShort(Asc(e.KeyChar))
        keyAscii = CShort(SoloTexto(keyAscii))
        If keyAscii = 0 Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Or e.KeyChar = Chr(9) Or e.KeyChar = Chr(11) Then
            If Trim(txt_giro.Text) = "" Then
                MsgBox("Debe Ingresar un giro para el Cliente")
                txt_giro.Focus()
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
                MsgBox("Debe Ingresar una dirección para el Cliente")
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
                MsgBox("Debe Ingresar un telefono para el Proveedor")
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
                    txt_ciu.Focus()
                End If
            End If
        End If
    End Sub
    Private Sub txt_ciu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ciu.KeyPress
        Dim keyAscii As Short = CShort(Asc(e.KeyChar))
        keyAscii = CShort(SoloTexto(keyAscii))
        If keyAscii = 0 Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            If Trim(txt_ciu.Text) = "" Then
                MsgBox("Debe Ingresar una ciudad para el Cliente")
                txt_ciu.Focus()
            Else
                btn_guardar.Focus()
            End If
        End If
    End Sub
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If ValidarCliente() = True Then
            If Cliente.ExisteCliente(txt_rut.Text) > 0 Then
                Cliente.ActualizarCliente(txt_rut.Text, txt_nom.Text, txt_giro.Text, txt_dir.Text, txt_tel.Text, txt_email.Text, txt_ciu.Text, txt_rut.Text)
                MsgBox("El cliente fue actualizado con exito")
                Limpiar()
            Else
                Cliente.AgregarCliente(txt_rut.Text, txt_nom.Text, txt_giro.Text, txt_dir.Text, txt_tel.Text, txt_email.Text, txt_ciu.Text)
                MsgBox("El cliente fue agregado con exito")
                Limpiar()
            End If
        End If
    End Sub
    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If Cliente.ExisteCliente(txt_rut.Text) > 0 Then
            If MsgBox("Esta seguro que desea eliminar?", vbYesNo, "Eliminar Registro") - MsgBoxResult.Yes Then
                Cliente.EliminarCliente(txt_rut.Text)
                MsgBox("El Cliente fue eliminado con exito")
                Limpiar()
            End If
        Else
            MsgBox("El Cliente no existe")
        End If
    End Sub
    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Inicio.Show()
        Me.Hide()
    End Sub
    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
        Inicio.Close()
        Proveedor.Close()
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