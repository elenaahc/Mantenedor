Module Mod_Funciones
    Public Function validarRut(ByVal rut_Verificar As String) As String
        Dim rutLimpio As String
        Dim DigVer As String
        Dim suma As Integer
        Dim contador As Integer = 2
        Dim valida As Boolean = True
        Dim retorno As Boolean = False
        rutLimpio = rut_Verificar.Replace(".", "")

        Dim i As Integer
        For i = rutLimpio.Length - 1 To 0 Step -1
            If contador > 7 Then
                contador = 2
            End If
            Try
                suma += Integer.Parse(rutLimpio(i).ToString()) * contador
                contador += 1
            Catch ex As Exception
                valida = False
            End Try
        Next
        DigVer = "?"
        If valida Then
            Dim dv As Integer = 11 - (suma Mod 11)
            DigVer = dv.ToString()

            If DigVer = "10" Then
                DigVer = "K"
            End If
            If DigVer = "11" Then
                DigVer = "0"
            End If
        End If
        Return DigVer
    End Function
    Public Function SoloNumeros(ByVal Keyascii As Short) As Short
        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            SoloNumeros = 0
        Else
            SoloNumeros = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumeros = Keyascii
            Case 9
                SoloNumeros = Keyascii
            Case 11
                SoloNumeros = Keyascii
            Case 13
                SoloNumeros = Keyascii
        End Select
    End Function

    Public Function SoloNumerosd(ByVal Keyascii As Short) As Short
        If InStr("1234567890Kk", Chr(Keyascii)) = 0 Then
            SoloNumerosd = 0
        Else
            SoloNumerosd = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumerosd = Keyascii
            Case 9
                SoloNumerosd = Keyascii
            Case 11
                SoloNumerosd = Keyascii
            Case 13
                SoloNumerosd = Keyascii
        End Select
    End Function
    Public Function SoloNumerost(ByVal Keyascii As Short) As Short
        If InStr("1234567890+", Chr(Keyascii)) = 0 Then
            SoloNumerost = 0
        Else
            SoloNumerost = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumerost = Keyascii
            Case 9
                SoloNumerost = Keyascii
            Case 11
                SoloNumerost = Keyascii
            Case 13
                SoloNumerost = Keyascii
        End Select
    End Function
    Public Function SoloTexto(ByVal Keyascii As Short) As Short
        If InStr("abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ ", Chr(Keyascii)) = 0 Then
            SoloTexto = 0
        Else
            SoloTexto = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloTexto = Keyascii
            Case 13
                SoloTexto = Keyascii
        End Select
    End Function
    Public Function ValidaMail(ByVal mail As String)
        ValidaMail = False
        Dim i As Integer
        For i = mail.Length - 1 To 0 Step -1
            If mail(i) = "@" Then
                ValidaMail = True
            End If
        Next
    End Function

    Public Function TextoNumeros(ByVal Keyascii As Short) As Short
        If InStr("abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ1234567890 ", Chr(Keyascii)) = 0 Then
            TextoNumeros = 0
        Else
            TextoNumeros = Keyascii
        End If
        Select Case Keyascii
            Case 8
                TextoNumeros = Keyascii
            Case 13
                TextoNumeros = Keyascii
        End Select
    End Function

End Module
