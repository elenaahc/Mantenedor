Public Class Inicio
    Private Sub btn_cliente_Click(sender As Object, e As EventArgs) Handles btn_cliente.Click
        Cliente.Show()
        Me.Hide()
    End Sub
    Private Sub btn_proveedor_Click(sender As Object, e As EventArgs) Handles btn_proveedor.Click
        Proveedor.Show()
        Me.Hide()
    End Sub

    Private Sub btn_U_M_Click(sender As Object, e As EventArgs) Handles btn_U_M.Click
        Unidad_Medida.Show()
        Me.Hide()
    End Sub

    Private Sub btn_producto_Click(sender As Object, e As EventArgs) Handles btn_producto.Click
        Productos.Show()
        Me.Hide()
    End Sub

    Private Sub btn_venta_Click(sender As Object, e As EventArgs) Handles btn_venta.Click
        Venta.Show()
        Me.Hide()
    End Sub

    Private Sub btn_compra_Click(sender As Object, e As EventArgs) Handles btn_compra.Click
        Compra.Show()
        Me.Hide()
    End Sub
    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
        Cliente.Close()
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

    Private Sub consultas_btn_Click(sender As Object, e As EventArgs) Handles consultas_btn.Click
        Consultas.Show()
        Me.Hide()
    End Sub
End Class
