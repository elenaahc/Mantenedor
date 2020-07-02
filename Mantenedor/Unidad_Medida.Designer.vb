<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Unidad_Medida
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.UMedida = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DescripcionTxt = New System.Windows.Forms.TextBox()
        Me.GuardarBtn = New System.Windows.Forms.Button()
        Me.EliminarBtn = New System.Windows.Forms.Button()
        Me.ID_UMTxt = New System.Windows.Forms.TextBox()
        Me.LimpiarBtn = New System.Windows.Forms.Button()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UMedida
        '
        Me.UMedida.AutoSize = True
        Me.UMedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UMedida.Location = New System.Drawing.Point(21, 19)
        Me.UMedida.Name = "UMedida"
        Me.UMedida.Size = New System.Drawing.Size(420, 31)
        Me.UMedida.TabIndex = 0
        Me.UMedida.Text = "Mantenedor de Unidad de medida"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Unidad de medida"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descripción"
        '
        'DescripcionTxt
        '
        Me.DescripcionTxt.Location = New System.Drawing.Point(200, 206)
        Me.DescripcionTxt.MaxLength = 30
        Me.DescripcionTxt.Name = "DescripcionTxt"
        Me.DescripcionTxt.Size = New System.Drawing.Size(100, 20)
        Me.DescripcionTxt.TabIndex = 4
        '
        'GuardarBtn
        '
        Me.GuardarBtn.Location = New System.Drawing.Point(72, 338)
        Me.GuardarBtn.Name = "GuardarBtn"
        Me.GuardarBtn.Size = New System.Drawing.Size(75, 23)
        Me.GuardarBtn.TabIndex = 5
        Me.GuardarBtn.Text = "Guardar"
        Me.GuardarBtn.UseVisualStyleBackColor = True
        '
        'EliminarBtn
        '
        Me.EliminarBtn.Location = New System.Drawing.Point(200, 338)
        Me.EliminarBtn.Name = "EliminarBtn"
        Me.EliminarBtn.Size = New System.Drawing.Size(75, 23)
        Me.EliminarBtn.TabIndex = 6
        Me.EliminarBtn.Text = "Eliminar"
        Me.EliminarBtn.UseVisualStyleBackColor = True
        '
        'ID_UMTxt
        '
        Me.ID_UMTxt.Location = New System.Drawing.Point(200, 123)
        Me.ID_UMTxt.MaxLength = 10
        Me.ID_UMTxt.Name = "ID_UMTxt"
        Me.ID_UMTxt.Size = New System.Drawing.Size(100, 20)
        Me.ID_UMTxt.TabIndex = 7
        '
        'LimpiarBtn
        '
        Me.LimpiarBtn.Location = New System.Drawing.Point(327, 338)
        Me.LimpiarBtn.Name = "LimpiarBtn"
        Me.LimpiarBtn.Size = New System.Drawing.Size(75, 23)
        Me.LimpiarBtn.TabIndex = 8
        Me.LimpiarBtn.Text = "Limpiar"
        Me.LimpiarBtn.UseVisualStyleBackColor = True
        '
        'btn_volver
        '
        Me.btn_volver.Location = New System.Drawing.Point(12, 415)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(75, 23)
        Me.btn_volver.TabIndex = 27
        Me.btn_volver.TabStop = False
        Me.btn_volver.Text = "Regresar"
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(382, 415)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_salir.TabIndex = 28
        Me.btn_salir.TabStop = False
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'Unidad_Medida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 450)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.LimpiarBtn)
        Me.Controls.Add(Me.ID_UMTxt)
        Me.Controls.Add(Me.EliminarBtn)
        Me.Controls.Add(Me.GuardarBtn)
        Me.Controls.Add(Me.DescripcionTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UMedida)
        Me.Name = "Unidad_Medida"
        Me.Text = "Unidad_Medida"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UMedida As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DescripcionTxt As TextBox
    Friend WithEvents GuardarBtn As Button
    Friend WithEvents EliminarBtn As Button
    Friend WithEvents ID_UMTxt As TextBox
    Friend WithEvents LimpiarBtn As Button
    Friend WithEvents btn_volver As Button
    Friend WithEvents btn_salir As Button
End Class
