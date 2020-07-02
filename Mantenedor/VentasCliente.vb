Imports System.Data.SqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Data
Public Class VentasCliente

    Dim Clientes As New MantenedorTableAdapters.ClienteTableAdapter

    Private Sub venta_rut_clie_Click(sender As Object, e As EventArgs) Handles venta_rut_clie.Click
        If Trim(rut_clie_txt.Text) = "" Then
            MsgBox("Debe ingresar un rut")
            rut_clie_txt.Focus()
        Else
            dv_clie_txt.Focus()
        End If

        If dv_clie_txt.Text = "" Then
            MsgBox("Debe ingresar un dígito verificador")
            dv_clie_txt.Focus()
        Else
            If validarRut(rut_clie_txt.Text) = dv_clie_txt.Text Then
                If Clientes.ExisteCliente(rut_clie_txt.Text) > 0 Then
                    venta_rut_clie.Focus()
                    MsgBox("Rut Válido")

                    Dim cnn As New SqlConnection("Server = DESKTOP-HKI745B; Database = Mantenedor; Integrated Security = True ")
                    Dim cmd As SqlCommand
                    cmd = New SqlCommand()
                    cmd.Connection = cnn
                    cmd.CommandText = "SELECT id_venta as IDVenta, fec_ven as Fecha, obs_ven as Observación, val_ven as Valor, por_iva_ven as ValorIVA FROM Venta WHERE (rut_clie = @rut_clie)"
                    Dim da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable

                    cnn.Open()
                    Dim param As SqlParameter
                    param = New SqlParameter()
                    param.ParameterName = “@rut_clie”
                    param.SqlDbType = SqlDbType.VarChar
                    param.Size = 8
                    param.Value = rut_clie_txt.Text
                    cmd.Parameters.Add(param)
                    cmd.ExecuteNonQuery()
                    da.Fill(dt)
                    Me.dgv.DataSource = dt
                    cnn.Close()
                Else
                    MsgBox("Rut NO está registrado en nuestros servidores")
                End If
            Else
                MsgBox("Rut Incorrecto")

            End If
        End If
    End Sub

    Private Sub rut_clie_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rut_clie_txt.KeyPress
        Dim keyAscii As Short = CShort(Asc(e.KeyChar))
        keyAscii = CShort(SoloNumeros(keyAscii))
        If keyAscii = 0 Then
            e.Handled = True
        End If

        If e.KeyChar = Chr(13) Or e.KeyChar = Chr(9) Or e.KeyChar = Chr(11) Then
            If Trim(rut_clie_txt.Text) = "" Then
                MsgBox("Debe ingresar un rut")
                rut_clie_txt.Focus()
            Else
                dv_clie_txt.Focus()
            End If
        End If
    End Sub

    Private Sub volver_btn_Click(sender As Object, e As EventArgs) Handles volver_btn.Click
        Me.Hide()
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
        Inicio.Close()
        VentasFecha.Close()
        ComprasFecha.Close()
        ExistenciaProductos.Close()

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

        Dim encabezado As New Paragraph("Reporte de Ventas por cliente", New Font(Font.Name = "Tahoma", 20, Font.Bold))

        'Se crea el texto abajo del encabezado.
        Dim texto As New Phrase("Realizado a la fecha :" + Now.Date(), New Font(Font.Name = "Tahoma", 14, Font.Bold))
        Dim rut As New Paragraph("Rut Cliente: " + rut_clie_txt.Text + "-" + dv_clie_txt.Text, New Font(Font.Name = "Tahoma", 14, Font.Bold))
        Dim saltoLinea2 As New Phrase("-----------------------------------------------------", New Font(Font.Name = "Tahoma", 14, Font.Bold))
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
        document.Add(rut)
        document.Add(saltoLinea2)
        document.Add(datatable)
        document.Add(saltoLinea)
        document.Add(autor)
    End Sub

    Private Sub reporte_btn_Click(sender As Object, e As EventArgs) Handles reporte_btn.Click
        Try
            'Intentar generar el documento.
            Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Ventas por cliente.pdf"
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