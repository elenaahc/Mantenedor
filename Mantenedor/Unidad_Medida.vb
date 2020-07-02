Public Class Unidad_Medida

    Dim UnidadMedida As New MantenedorTableAdapters.U_MedidaTableAdapter
    Private Function ValidarUnidadMedida()
        ValidarUnidadMedida = False
        If Trim(ID_UMTxt.Text) = "" Then
            MsgBox("Ingrese ID")
            ID_UMTxt.Focus()
            Exit Function
        End If
        If Trim(DescripcionTxt.Text) = "" Then
            MsgBox("Ingrese Descripción")
            DescripcionTxt.Focus()
            Exit Function
        End If
        ValidarUnidadMedida = True
    End Function
    Private Sub MostrarDatos()
        DescripcionTxt.Text = UnidadMedida.MostrarUM(ID_UMTxt.Text).Rows(0).Item(1).ToString
    End Sub
    Private Sub Limpiar()
        ID_UMTxt.Clear()
        DescripcionTxt.Clear()
        DescripcionTxt.Enabled = False
        ID_UMTxt.Enabled = True
        ID_UMTxt.Focus()
    End Sub
    Private Sub Habilitar()
        ID_UMTxt.Enabled = False
        DescripcionTxt.Enabled = True
        DescripcionTxt.Focus()
    End Sub
    Private Sub Unidad_Medida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
    End Sub
    Private Sub LimpiarBtn_Click(sender As Object, e As EventArgs) Handles LimpiarBtn.Click
        Limpiar()
    End Sub
    Private Sub ID_UMTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ID_UMTxt.KeyPress
        Dim keyAscii As Short = CShort(Asc(e.KeyChar))
        keyAscii = CShort(TextoNumeros(keyAscii))
        If keyAscii = 0 Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            If ID_UMTxt.Text = " " Then
                MsgBox("Ingrese ID")
                ID_UMTxt.Focus()
            Else
                If UnidadMedida.ExisteUM(ID_UMTxt.Text) > 0 Then
                    MostrarDatos()
                    Habilitar()
                Else
                    Habilitar()
                    DescripcionTxt.Focus()
                End If
            End If
        End If
    End Sub
    Private Sub DescripcionTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DescripcionTxt.KeyPress
        Dim keyAscii As Short = CShort(Asc(e.KeyChar))
        keyAscii = CShort(SoloTexto(keyAscii))
        If keyAscii = 0 Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            If Trim(DescripcionTxt.Text) = "" Then
                MsgBox("Debe ingresar una Descripción para la Unidad de Medida")
                DescripcionTxt.Focus()
            Else

                GuardarBtn.Focus()
            End If
        End If
    End Sub
    Private Sub GuardarBtn_Click(sender As Object, e As EventArgs) Handles GuardarBtn.Click
        Try
            If ValidarUnidadMedida() = True Then
                If UnidadMedida.ExisteUM(ID_UMTxt.Text) > 0 Then
                    UnidadMedida.ActualizarUM(ID_UMTxt.Text, DescripcionTxt.Text, ID_UMTxt.Text)
                    MsgBox("Actualización exitosa")
                    Limpiar()
                Else
                    UnidadMedida.AgregarUM(ID_UMTxt.Text, DescripcionTxt.Text)
                    MsgBox("Guardado exitoso")
                    Limpiar()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error de datos")
        End Try
    End Sub
    Private Sub EliminarBtn_Click(sender As Object, e As EventArgs) Handles EliminarBtn.Click
        Try
            If ValidarUnidadMedida() = True Then
                If UnidadMedida.ExisteUM(ID_UMTxt.Text) > 0 Then
                    UnidadMedida.EliminarUM(ID_UMTxt.Text)
                    MsgBox("Eliminado con exito")
                    Limpiar()
                Else
                    MsgBox("Unidad de medida inexistente")
                    Limpiar()
                End If
            End If
        Catch
            MsgBox("Error de datos")
        End Try
    End Sub
    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Inicio.Show()
        Me.Hide()
    End Sub
    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
        Cliente.Close()
        Proveedor.Close()
        Inicio.Close()
        Productos.Close()
        Venta.Close()
        Compra.Close()
        VentasCliente.Close()
        VentasFecha.Close()
        ComprasFecha.Close()
        ExistenciaProductos.Close()
    End Sub
End Class