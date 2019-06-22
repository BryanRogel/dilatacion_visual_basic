
Public Class Dilatación



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label2.Click

    End Sub


    Private Sub cmbtipo_Click(sender As Object, e As EventArgs) Handles cmbtipo.Click, cmbopcion.Click

        'Esta parte remplaza la coma por el punto como separador decimal'

        Dim culture As New System.Globalization.CultureInfo("es-ES")
        culture.NumberFormat.CurrencyDecimalSeparator = "."
        culture.NumberFormat.CurrencyGroupSeparator = ","
        culture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture = culture

        llenar_combobox()
        llenar_combobox_tipo()

    End Sub

    'Evaluación del tipo de dilatación que se buscará'
    Friend Sub llenar_combobox()

        Select Case cmbtipo.Text

            Case "Lineal"
                cmbopcion.Items.Clear()
                cmbopcion.Items.Insert(0, "Coeficiente de dilatación lineal (a)")
                cmbopcion.Items.Insert(1, "Longitud inicial (Li)")
                cmbopcion.Items.Insert(2, "Longitud final (Lf)")
                cmbopcion.Items.Insert(3, "Temperatura inicial (Til)")
                cmbopcion.Items.Insert(4, "Temperatura final (Tfl)")
                cmbopcion.Items.Insert(5, "Variación lineal (L△)")

            Case "Volumétrica"
                cmbopcion.Items.Clear()
                cmbopcion.Items.Insert(0, "Coeficiente de dilatación volumétrica (y)")
                cmbopcion.Items.Insert(1, "Volumen inicial (Vi)")
                cmbopcion.Items.Insert(2, "Volumen final (Vf)")
                cmbopcion.Items.Insert(3, "Temperatura inicial (Tiv)")
                cmbopcion.Items.Insert(4, "Temperatura final (Tfv)")
                cmbopcion.Items.Insert(5, "Variación volumétrica (△V)")

            Case "Superficial"
                cmbopcion.Items.Clear()
                cmbopcion.Items.Insert(0, "Coeficiente de dilatación superficial (b)")
                cmbopcion.Items.Insert(1, "Área inicial (Ai)")
                cmbopcion.Items.Insert(2, "Área final (Af)")
                cmbopcion.Items.Insert(3, "Temperatura inicial (Tis)")
                cmbopcion.Items.Insert(4, "Temperatura final (Tfs)")
                cmbopcion.Items.Insert(5, "Variación superficial (△A)")

        End Select
    End Sub

    'LLena el combobox con los el tipo de material'
    Friend Sub llenar_combobox_tipo()
        cmb1.Items.Clear()
        cmb1.Items.Insert(0, "Abeto long")
        cmb1.Items.Insert(1, "Abeto tang")
        cmb1.Items.Insert(2, "Abeto radial")
        cmb1.Items.Insert(3, "Acero")
        cmb1.Items.Insert(4, "Acero inoxidable 10.1")
        cmb1.Items.Insert(5, "Acero inoxidable 17.3")
        cmb1.Items.Insert(6, "Aluminio")
        cmb1.Items.Insert(7, "Arseniuro de galio")
        cmb1.Items.Insert(8, "Carburo de silicio")
        cmb1.Items.Insert(9, "Cinc")
        cmb1.Items.Insert(10, "Cobre")
        cmb1.Items.Insert(11, "Concreto 0.7")
        cmb1.Items.Insert(12, "Concreto 1.2")
        cmb1.Items.Insert(13, "Cuarzo")
        cmb1.Items.Insert(14, "Diamante")
        cmb1.Items.Insert(15, "Etanol")
        cmb1.Items.Insert(16, "Fibra de carbono")
        cmb1.Items.Insert(17, "Gasolina")
        cmb1.Items.Insert(18, "Grafito")
        cmb1.Items.Insert(19, "Hielo")
        cmb1.Items.Insert(20, "Hierro")
        cmb1.Items.Insert(21, "Invar")
        cmb1.Items.Insert(22, "Hormigón 8")
        cmb1.Items.Insert(23, "Hormigón 12")
        cmb1.Items.Insert(24, "Latón")
        cmb1.Items.Insert(25, "Madera de roble")
        cmb1.Items.Insert(26, "Oro")
        cmb1.Items.Insert(27, "Plata")
        cmb1.Items.Insert(28, "Plomo")
        cmb1.Items.Insert(29, "PP")
        cmb1.Items.Insert(30, "PVC")
        cmb1.Items.Insert(31, "Sílice")
        cmb1.Items.Insert(32, "Vidrio 7")
        cmb1.Items.Insert(33, "Vidrio 9")
        cmb1.Items.Insert(34, "Vidrio borosilicato")
        cmb1.Items.Insert(35, "Vidrio pirex")
        cmb1.Items.Insert(36, "Zafiro")
        cmb1.Items.Insert(37, "Zinc")
    End Sub

    'Método para limpiar campos'
    Friend Sub limpiar()
        txt1.Clear()
        txt2.Clear()
        txt5.Clear()
        txt4.Clear()
        cmb1.SelectedIndex = -1
        total.Visible = False
        ep.Clear()
        res.Visible = False
    End Sub

    'Método para mostrar botones de calcular, limpiar y label de resultado'
    Friend Sub mostrar_botones()
        btnCalcular.Visible = True
        BtnLimpiar.Visible = True
        total.Visible = False
    End Sub

    'Método para mostrar campos cuando se seleccione calcular el coeficiente de dilatación'
    Friend Sub campos_coeficiente()
        lbl1.Visible = True
        lbl2.Visible = True
        lbl4.Visible = True
        lbl5.Visible = True
        txt1.Visible = True
        txt2.Visible = True
        txt4.Visible = True
        txt5.Visible = True
    End Sub

    'Método para mostrar campos y combobox con los tipos de materiales'
    Friend Sub campos()
        lbl1.Visible = True
        lbl2.Visible = True
        lbl4.Visible = True
        lbl5.Visible = True
        txt1.Visible = True
        cmb1.Visible = True
        txt4.Visible = True
        txt5.Visible = True
        txt2.Visible = False
    End Sub

    'Método para mostrar campos dependiendo de la selección inicial'
    Friend Sub seleccion()
        Select Case cmbopcion.Text

            Case "Coeficiente de dilatación lineal (a)"
                cmb1.Visible = False
                lbl1.Text = "Longitud inicial:"
                lbl2.Text = "Variación lineal:"
                lbl4.Text = "Temperatura inicial:"
                lbl5.Text = "Temperatura final:"
                campos_coeficiente()

            Case "Longitud inicial (Li)"
                lbl1.Text = "Longitud final:"
                lbl2.Text = "Coeficiente de dilatación lineal:"
                lbl4.Text = "Temperatura inicial:"
                lbl5.Text = "Temperatura final:"
                campos()

            Case "Longitud final (Lf)"
                lbl1.Text = "Longitud inicial:"
                lbl2.Text = "Coeficiente de dilatación lineal:"
                lbl4.Text = "Temperatura inicial:"
                lbl5.Text = "Temperatura final:"
                campos()

            Case "Temperatura inicial (Til)"
                lbl1.Text = "Longitud final:"
                lbl2.Text = "Coeficiente de dilatación lineal:"
                lbl4.Text = "Dilatación lineal:"
                lbl5.Text = "Temperatura final:"
                campos()

            Case "Temperatura final (Tfl)"
                lbl1.Text = "Longitud inicial:"
                lbl2.Text = "Coeficiente de dilatación lineal:"
                lbl4.Text = "Dilatación lineal:"
                lbl5.Text = "Temperatura inicial:"
                campos()

            Case "Variación lineal (L△)"
                lbl1.Text = "Longitud inicial:"
                lbl2.Text = "Coeficiente de dilatación lineal:"
                lbl4.Text = "Temperatura inicial:"
                lbl5.Text = "Temperatura final:"
                campos()

            Case "Coeficiente de dilatación volumétrica (y)"
                cmb1.Visible = False
                lbl1.Text = "Volumen inicial:"
                lbl2.Text = "Variación volumétrica:"
                lbl4.Text = "Temperatura inicial:"
                lbl5.Text = "Temperatura final:"
                campos_coeficiente()

            Case "Volumen inicial (Vi)"
                lbl1.Text = "Volumen final:"
                lbl2.Text = "Coeficiente de dilatación volumétrica:"
                lbl4.Text = "Temperatura inicial:"
                lbl5.Text = "Temperatura final:"
                campos()

            Case "Volumen final (Vf)"
                lbl1.Text = "Volumen inicial:"
                lbl2.Text = "Coeficiente de dilatación volumétrica:"
                lbl4.Text = "Temperatura inicial:"
                lbl5.Text = "Temperatura final:"
                campos()

            Case "Temperatura inicial (Tiv)"
                lbl1.Text = "Volumen inicial:"
                lbl2.Text = "Coeficiente de dilatación volumétrica:"
                lbl4.Text = "Variación volumétrica:"
                lbl5.Text = "Temperatura final:"
                campos()

            Case "Temperatura final (Tfv)"
                lbl1.Text = "Volumen inicial:"
                lbl2.Text = "Coeficiente de dilatación volumétrica:"
                lbl4.Text = "Variación volumétrica:"
                lbl5.Text = "Temperatura inicial:"
                campos()

            Case "Variación volumétrica (△V)"
                lbl1.Text = "Volumen inicial:"
                lbl2.Text = "Coeficiente de dilatación volumétrica:"
                lbl4.Text = "Temperatura inicial:"
                lbl5.Text = "Temperatura final:"
                campos()

            Case "Coeficiente de dilatación superficial (b)"
                cmb1.Visible = False
                lbl1.Text = "Área inicial:"
                lbl2.Text = "Variación superficial:"
                lbl4.Text = "Temperatura inicial:"
                lbl5.Text = "Temperatura final:"
                campos_coeficiente()

            Case "Área inicial (Ai)"
                lbl1.Text = "Área final:"
                lbl2.Text = "Coeficiente de dilatación superficial:"
                lbl4.Text = "Temperatura inicial:"
                lbl5.Text = "Temperatura final:"
                campos()

            Case "Área final (Af)"
                lbl1.Text = "Área inicial:"
                lbl2.Text = "Coeficiente de dilatación superficial:"
                lbl4.Text = "Temperatura inicial:"
                lbl5.Text = "Temperatura final:"
                campos()

            Case "Temperatura inicial (Tis)"
                lbl1.Text = "Área inicial:"
                lbl2.Text = "Coeficiente de dilatación superficial:"
                lbl4.Text = "Variación superficial:"
                lbl5.Text = "Temperatura final:"
                campos()

            Case "Temperatura final (Tfs)"
                lbl1.Text = "Área final:"
                lbl2.Text = "Coeficiente de dilatación superficial:"
                lbl4.Text = "Variación superficial:"
                lbl5.Text = "Temperatura inicial:"
                campos()

            Case "Variación superficial (△A)"
                lbl1.Text = "Área inicial:"
                lbl2.Text = "Coeficiente de dilatación Superficial:"
                lbl4.Text = "Temperatura inicial:"
                lbl5.Text = "Temperatura final:"
                campos()

        End Select
    End Sub

    Private Sub cmbtipo_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lbl2.Click

    End Sub

    Private Sub lbl1_Click(sender As Object, e As EventArgs) Handles lbl1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        res.Visible = False

        cmbopcion.DropDownStyle = ComboBoxStyle.DropDownList
        cmbtipo.DropDownStyle = ComboBoxStyle.DropDownList
        cmb1.DropDownStyle = ComboBoxStyle.DropDownList

    End Sub

    Private Sub cmbopcion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbopcion.SelectedIndexChanged

        limpiar()
        mostrar_botones()
        seleccion()

    End Sub

    Private Sub txt1_TextChanged(sender As Object, e As EventArgs) Handles txt1.TextChanged

    End Sub

    Private Sub txt2_TextChanged(sender As Object, e As EventArgs) Handles txt2.TextChanged

    End Sub

    Private Sub txt3_TextChanged(sender As Object, e As EventArgs)

    End Sub
    'Validación de números'
    Private Sub txt1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt1.KeyPress
        Dim cadena As String = sender.Text
        Dim filtro As String = "1234567890"

        If Len(cadena) = 0 Then
            filtro += "-"
        End If
        If Len(cadena) > 0 Then
            filtro += "."
        End If

        For Each caracter In filtro
            If e.KeyChar = caracter Then
                e.Handled = False
                Exit For
            Else
                e.Handled = True
            End If
        Next

        If e.KeyChar = "0" And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            sender.Text = ""
        ElseIf e.KeyChar <> "0" And e.KeyChar <> "." And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            sender.Text = ""
        End If

        If Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If

        If e.KeyChar = "." And Not cadena.IndexOf(".") Then
            e.Handled = True
        End If
    End Sub
    'Validación de números'
    Private Sub txt4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt4.KeyPress
        Dim cadena As String = sender.Text
        Dim filtro As String = "1234567890"

        If Len(cadena) = 0 Then
            filtro += "-"
        End If
        If Len(cadena) > 0 Then
            filtro += "."
        End If

        For Each caracter In filtro
            If e.KeyChar = caracter Then
                e.Handled = False
                Exit For
            Else
                e.Handled = True
            End If
        Next

        If e.KeyChar = "0" And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            sender.Text = ""
        ElseIf e.KeyChar <> "0" And e.KeyChar <> "." And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            sender.Text = ""
        End If

        If Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If

        If e.KeyChar = "." And Not cadena.IndexOf(".") Then
            e.Handled = True
        End If
    End Sub
    'Validación de números'
    Private Sub txt5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt5.KeyPress
        Dim cadena As String = sender.Text
        Dim filtro As String = "1234567890"

        If Len(cadena) = 0 Then
            filtro += "-"
        End If
        If Len(cadena) > 0 Then
            filtro += "."
        End If

        For Each caracter In filtro
            If e.KeyChar = caracter Then
                e.Handled = False
                Exit For
            Else
                e.Handled = True
            End If
        Next

        If e.KeyChar = "0" And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            sender.Text = ""
        ElseIf e.KeyChar <> "0" And e.KeyChar <> "." And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            sender.Text = ""
        End If

        If Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If

        If e.KeyChar = "." And Not cadena.IndexOf(".") Then
            e.Handled = True
        End If
    End Sub
    'Validación de números'
    Private Sub txt2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt2.KeyPress
        Dim cadena As String = sender.Text
        Dim filtro As String = "1234567890"

        If Len(cadena) = 0 Then
            filtro += "-"
        End If
        If Len(cadena) > 0 Then
            filtro += "."
        End If

        For Each caracter In filtro
            If e.KeyChar = caracter Then
                e.Handled = False
                Exit For
            Else
                e.Handled = True
            End If
        Next

        If e.KeyChar = "0" And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            sender.Text = ""
        ElseIf e.KeyChar <> "0" And e.KeyChar <> "." And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            sender.Text = ""
        End If

        If Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If

        If e.KeyChar = "." And Not cadena.IndexOf(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnLimpiar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BtnLimpiar.KeyPress

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        limpiar()
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        ep.Clear()

        Dim num As Integer 'Se inicializa a 0 y aumenta su valor en 1 por cada error'
        num = 0

        If txt1.Text = "" Then
            ep.SetError(txt1, "Campo Vacío")
            txt1.Focus()
            num = Convert.ToInt32(num) + 1

        ElseIf txt2.Text = "" And txt2.Visible = True Then

            ep.SetError(txt2, "Campo Vacío")
            txt2.Focus()
            num = Convert.ToInt32(num) + 1

        ElseIf cmb1.Text = "" And txt2.Visible = False Then

            ep.SetError(cmb1, "No se seleccionó ningún valor")
            num = Convert.ToInt32(num) + 1

        ElseIf txt4.Text = "" Then
            ep.SetError(txt4, "Campo Vacío")
            txt4.Focus()
            num = Convert.ToInt32(num) + 1

        ElseIf txt5.Text = "" Then

            ep.SetError(txt5, "Campo Vacío")
            txt5.Focus()
            num = Convert.ToInt32(num) + 1
        End If

        If num = 0 Then  'Si no hubo error, procegira a asignar el valor del tipo de material a la variable "datos"'
            Dim datos As Decimal
            Dim sngNumero As Decimal

            datos = 0

            Select Case cmb1.Text
                Case "Acero"
                    datos = 0.000012

                Case "Aluminio"
                    datos = 0.000023

                Case "Cinc"
                    datos = 0.000026

                Case "Zinc"
                    datos = 0.000026

                Case "Cobre"
                    datos = 0.000018

                Case "Concreto 0.7"
                    datos = 0.000007

                Case "Concreto 1.2"
                    datos = 0.000012

                Case "Diamante"
                    datos = 0.0000012

                Case "Hierro"
                    datos = 0.000012

                Case "Latón"
                    datos = 0.00001

                Case "Plata"
                    datos = 0.000019

                Case "Plomo"
                    datos = 0.00003

                Case "Vidrio 9"
                    datos = 0.000009

                Case "Vidrio 7"
                    datos = 0.000007

                Case "Vidrio pirex"
                    datos = 0.000003

                Case "Hormigón 8"
                    datos = 0.000008

                Case "Hormigón 12"
                    datos = 0.000012

                Case "Oro"
                    datos = 0.000014

                Case "Cuarzo"
                    datos = 0.0000004

                Case "Fibra de carbono"
                    datos = -0.0000008

                Case "Vidrio borosilicato"
                    datos = 0.0000033

                Case "Abeto tang"
                    datos = 0.000045

                Case "Abeto long"
                    datos = 0.0000035

                Case "Zafiro"
                    datos = 0.0000053

                Case "Invar"
                    datos = 0.0000004

                Case "Hielo"
                    datos = 0.000051

                Case "Etanol"
                    datos = 0.00025

                Case "Carburo de silicio"
                    datos = 0.00000277

                Case "Arseniuro de galio"
                    datos = 0.0000058

                Case "Madera de roble"
                    datos = 0.000054

                Case "PP"
                    datos = 0.00015

                Case "Sílice"
                    datos = 0.00000256

                Case "Grafito"
                    datos = 0.000008

                Case "Gasolina"
                    datos = 0.000317

                Case "Abeto radial"
                    datos = 0.000027

                Case "PVC"
                    datos = 0.000052

                Case "Acero inoxidable 10.1"
                    datos = 0.0000101

                Case "Acero inoxidable 17.3"
                    datos = 0.0000173

            End Select

            Select Case cmbtipo.Text 'Dependiendo de su selección, el valor almacenado en datos se multiplicará'

                Case "Volumétrica"
                    datos = datos * 3

                Case "Superficial"
                    datos = datos * 2

            End Select

            Select Case cmbopcion.Text

                Case "Coeficiente de dilatación lineal (a)"
                    sngNumero = Val(Convert.ToDouble(txt2.Text) / ((Convert.ToDouble(txt5.Text) - Convert.ToDouble(txt4.Text)) * Convert.ToDouble(txt1.Text)))
                    total.Text = (Fix(sngNumero * (10 ^ 4))) / (10 ^ 4)
                    total.Visible = True

                Case "Longitud inicial (Li)"
                    sngNumero = Val(Convert.ToDouble(txt1.Text) / (1 + datos * (Convert.ToDouble(txt5.Text) - Convert.ToDouble(txt4.Text))))
                    total.Text = (Fix(sngNumero * (10 ^ 4))) / (10 ^ 4)
                    total.Visible = True

                Case "Longitud final (Lf)"
                    sngNumero = Val(Convert.ToDouble(txt1.Text) * (1 + datos * (Convert.ToDouble(txt5.Text) - Convert.ToDouble(txt4.Text))))
                    total.Text = (Fix(sngNumero * (10 ^ 4))) / (10 ^ 4)
                    total.Visible = True

                Case "Temperatura inicial (Til)"
                    sngNumero = Val(Convert.ToDouble(txt5.Text) - (Convert.ToDouble(txt4.Text) / datos * Convert.ToDouble(txt1.Text)))
                    total.Text = (Fix(sngNumero * (10 ^ 4))) / (10 ^ 4)
                    total.Visible = True

                Case "Temperatura final (Tfl)"
                    sngNumero = Val((Convert.ToDouble(txt4.Text) / (datos * Convert.ToDouble(txt1.Text))) + Convert.ToDouble(txt5.Text))
                    total.Text = (Fix(sngNumero * (10 ^ 4))) / (10 ^ 4)
                    total.Visible = True

                Case "Variación lineal (L△)"
                    sngNumero = Val(datos * Convert.ToDouble(txt1.Text) * (Convert.ToDouble(txt5.Text) - Convert.ToDouble(txt4.Text)))
                    total.Text = (Fix(sngNumero * (10 ^ 4))) / (10 ^ 4)
                    total.Visible = True

                Case "Coeficiente de dilatación volumétrica (y)"
                    sngNumero = Val(Convert.ToDouble(txt2.Text) / ((Convert.ToDouble(txt5.Text) - Convert.ToDouble(txt4.Text)) * Convert.ToDouble(txt1.Text)))
                    total.Text = (Fix(sngNumero * (10 ^ 4))) / (10 ^ 4)
                    total.Visible = True

                Case "Volumen inicial (Vi)"
                    sngNumero = Val(Convert.ToDouble(txt1.Text) / (1 + datos * (Convert.ToDouble(txt5.Text) - Convert.ToDouble(txt4.Text))))
                    total.Text = (Fix(sngNumero * (10 ^ 4))) / (10 ^ 4)
                    total.Visible = True

                Case "Volumen final (Vf)"
                    sngNumero = Val(Convert.ToDouble(txt1.Text) * (1 + datos * (Convert.ToDouble(txt5.Text) - Convert.ToDouble(txt4.Text))))
                    total.Text = (Fix(sngNumero * (10 ^ 4))) / (10 ^ 4)
                    total.Visible = True

                Case "Temperatura inicial (Tiv)"
                    sngNumero = Val(Convert.ToDouble(txt5.Text) - (Convert.ToDouble(txt4.Text) / (datos * Convert.ToDouble(txt1.Text))))
                    total.Text = sngNumero
                    total.Visible = True

                Case "Temperatura final (Tfv)"
                    sngNumero = Val((Convert.ToDouble(txt4.Text) / (datos * Convert.ToDouble(txt1.Text))) + Convert.ToDouble(txt5.Text))
                    total.Text = (Fix(sngNumero * (10 ^ 4))) / (10 ^ 4)
                    total.Visible = True

                Case "Variación volumétrica (△V)"
                    sngNumero = Val(datos * Convert.ToDouble(txt1.Text) * (Convert.ToDouble(txt5.Text) - Convert.ToDouble(txt4.Text)))
                    total.Text = (Fix(sngNumero * (10 ^ 4))) / (10 ^ 4)
                    total.Visible = True

                Case "Coeficiente de dilatación superficial (b)"
                    sngNumero = Val(Convert.ToDouble(txt2.Text) / ((Convert.ToDouble(txt5.Text) - Convert.ToDouble(txt4.Text)) * Convert.ToDouble(txt1.Text)))
                    total.Text = (Fix(sngNumero * (10 ^ 4))) / (10 ^ 4)
                    total.Visible = True

                Case "Área inicial (Ai)"
                    sngNumero = Val(Convert.ToDouble(txt1.Text) / (1 + datos * (Convert.ToDouble(txt5.Text) - Convert.ToDouble(txt4.Text))))
                    total.Text = (Fix(sngNumero * (10 ^ 4))) / (10 ^ 4)
                    total.Visible = True

                Case "Área final (Af)"
                    sngNumero = Val(Convert.ToDouble(txt1.Text) * (1 + datos * (Convert.ToDouble(txt5.Text) - Convert.ToDouble(txt4.Text))))
                    total.Text = (Fix(sngNumero * (10 ^ 4))) / (10 ^ 4)
                    total.Visible = True

                Case "Temperatura inicial (Tis)"
                    sngNumero = Val(Convert.ToDouble(txt5.Text) - (Convert.ToDouble(txt4.Text) / (datos * Convert.ToDouble(txt1.Text))))
                    total.Text = (Fix(sngNumero * (10 ^ 4))) / (10 ^ 4)
                    total.Visible = True

                Case "Temperatura final (Tfs)"
                    sngNumero = Val((Convert.ToDouble(txt4.Text) / (datos * Convert.ToDouble(txt1.Text))) + Convert.ToDouble(txt5.Text))
                    total.Text = (Fix(sngNumero * (10 ^ 4))) / (10 ^ 4)
                    total.Visible = True

                Case "Variación superficial (△A)"

                    sngNumero = Val(datos * Convert.ToDouble(txt1.Text) * (Convert.ToDouble(txt5.Text) - Convert.ToDouble(txt4.Text)))

                    total.Text = (Fix(sngNumero * (10 ^ 4))) / (10 ^ 4) 'Se lo trunca a 2 cifras

                    total.Visible = True

            End Select

            res.Visible = True

        End If

    End Sub

    Private Sub cmbtipo_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbtipo.SelectedIndexChanged

    End Sub

    Private Sub txt1_Validated(sender As Object, e As EventArgs) Handles txt1.Validated

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub txt4_TextChanged(sender As Object, e As EventArgs) Handles txt4.TextChanged

    End Sub

    Private Sub txt5_TextChanged(sender As Object, e As EventArgs) Handles txt5.TextChanged

    End Sub

    Private Sub lbl4_Click(sender As Object, e As EventArgs) Handles lbl4.Click

    End Sub

    Private Sub lbl5_Click(sender As Object, e As EventArgs) Handles lbl5.Click

    End Sub

    Private Sub cmb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb1.SelectedIndexChanged

    End Sub

    Private Sub total_Click(sender As Object, e As EventArgs) Handles total.Click

    End Sub

    Private Sub res_Click(sender As Object, e As EventArgs) Handles res.Click

    End Sub
End Class
