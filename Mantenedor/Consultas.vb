Public Class Consultas
    Private Sub venta_rut_clie_Click(sender As Object, e As EventArgs) Handles venta_rut_clie.Click
        Me.Hide()
        VentasCliente.Show()
    End Sub

    Private Sub venta_fecha_Click(sender As Object, e As EventArgs) Handles venta_fecha.Click
        Me.Hide()
        VentasFecha.Show()
    End Sub
    Private Sub compra_fecha_Click(sender As Object, e As EventArgs) Handles compra_fecha.Click
        Me.Hide()
        ComprasFecha.Show()
    End Sub
    Private Sub stock_prod_Click(sender As Object, e As EventArgs) Handles stock_prod.Click
        Me.Hide()
        ExistenciaProductos.Show()
    End Sub
    Private Sub volver_btn_Click(sender As Object, e As EventArgs) Handles volver_btn.Click
        Me.Hide()
        Inicio.Show()
    End Sub
    Private Sub salir_btn_Click(sender As Object, e As EventArgs) Handles salir_btn.Click
        Me.Close()
        Inicio.Close()
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
End Class