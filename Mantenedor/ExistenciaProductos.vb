Imports System.Data.SqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Data
Public Class ExistenciaProductos
    Private Sub venta_rut_clie_Click(sender As Object, e As EventArgs) Handles venta_rut_clie.Click
        Dim cnn As New SqlConnection("Server = DESKTOP-HKI745B; Database = Mantenedor; Integrated Security = True ")
        Dim cmd As SqlCommand
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT id_prod as IDProducto, desc_prod as Descripción, cant_prod as Cantidad FROM Producto"
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        cnn.Open()
        cmd.ExecuteNonQuery()
        da.Fill(dt)
        Me.dgv.DataSource = dt
        cnn.Close()
    End Sub

    Private Sub volver_btn_Click(sender As Object, e As EventArgs) Handles volver_btn.Click
        Me.Close()
        Consultas.Show()
    End Sub

    Private Sub salir_btn_Click(sender As Object, e As EventArgs) Handles salir_btn.Click
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
        Inicio.Close()
    End Sub

    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        'funcion para obtener el tamaño de la columnas del datagridview
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function

    Public Sub ExportarDatosPDF(ByVal document As Document)
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView.
        Dim datatable As New PdfPTable(dgv.ColumnCount)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(dgv)
        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER

        'Se crea el encabezado en el PDF.

        Dim encabezado As New Paragraph("Reporte de Stock de Productos", New Font(Font.Name = "Tahoma", 20, Font.Bold))

        'Se crea el texto abajo del encabezado.
        Dim texto As New Phrase("Realizado a la fecha :" + Now.Date(), New Font(Font.Name = "Tahoma", 14, Font.Bold))
        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To dgv.ColumnCount - 1
            datatable.AddCell(dgv.Columns(i).HeaderText)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1
        'Se generan las columnas del DataGridView.
        For i As Integer = 0 To dgv.RowCount - 1
            For j As Integer = 0 To dgv.ColumnCount - 1
                datatable.AddCell(dgv(j, i).Value.ToString())
            Next
            datatable.CompleteRow()
        Next
        Dim saltoLinea As New Paragraph("-----------------------------------------------------", New Font(Font.Name = "Tahoma", 14, Font.Bold))
        Dim autor As New Phrase("Consulta por Manuel Cruces, Elena Hernández.", New Font(Font.Name = "Tahoma", 14, Font.Bold))
        'Se agrega el PDFTable al documento.
        document.Add(encabezado)
        document.Add(texto)
        document.Add(datatable)
        document.Add(saltoLinea)
        document.Add(autor)
    End Sub

    Private Sub reporte_btn_Click(sender As Object, e As EventArgs) Handles reporte_btn.Click

        Try
            'Intentar generar el documento.
            Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Existencia de productos.pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF(doc)
            doc.Close()
            Process.Start(filename)
        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox.
            MessageBox.Show("No se puede generar el documento PDF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class