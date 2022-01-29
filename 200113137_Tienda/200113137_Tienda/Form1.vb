Public Class Form1
    'definicion de variables y constanstes

    Const precioArroz As Double = 2.0
    Const preciofrijol As Double = 1.75
    Const precioAzucar As Double = 2.5
    Const IVA As Double = 0.12

    Dim pago_antes_iva As Double = 0
    Dim valor_iva As Double = 0
    Dim pago_con_iva As Double = 0
    Dim descuento As Double = 0
    Dim pago_total As Double = 0


    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        'Codigo de los calculos de la tarea 2

        'ejecuccion de calculos

        pago_antes_iva = (Val(txt_arroz.Text) * precioArroz) + (Val(txt_frijol.Text) * preciofrijol) + (Val(txt_azucar.Text) * precioAzucar)
        valor_iva = (pago_antes_iva * IVA)
        pago_con_iva = (pago_antes_iva + valor_iva)
        descuento = ((pago_con_iva) * 0.025)
        pago_total = (pago_con_iva - descuento)

        ' despliegue de resultados
        ' "Q" moneda el & es para concatnar, el STR para que sea string, y creo que me
        ' hubiera quedado mas facil declar la libreria al inicio, XD. 
        ' ,2, son 2 decimales

        lblpagoantesiva.Text = "Q" & Str(System.Math.Round(pago_antes_iva, 2))
        lblvaloriva.Text = "Q" & Str(System.Math.Round(valor_iva, 2))
        lblpagoconiva.Text = "Q" & Str(System.Math.Round(pago_con_iva, 2))
        lbldescuento.Text = "Q" & Str(System.Math.Round(descuento, 2))
        lblpagototal.Text = "Q" & Str(System.Math.Round(pago_total, 2))

        GroupBox3.Visible = True


    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        'Codigo para limpiar los resultados

        'limpieza de textbox

        txt_arroz.Clear()
        txt_frijol.Clear()
        txt_azucar.Clear()

        'limpieza de labels luego de mostrar resultados

        lblpagoantesiva.Text = "0"
        lblvaloriva.Text = "0"
        lblpagoconiva.Text = "0"
        lbldescuento.Text = "0"
        lblpagototal.Text = "0"

        'me deja el cursor en el textbox del arroz
        txt_arroz.Focus()

        'ocultar el groupbox de check out

        GroupBox3.Visible = False

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        'codigo para salir del programa
        Me.Close()

    End Sub

    Private Sub txt_arroz_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_arroz.KeyPress
        'codigo para limitar el ingreso de datos a valores numericos
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_frijol_TextChanged(sender As Object, e As EventArgs) Handles txt_frijol.TextChanged

    End Sub

    Private Sub txt_frijol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_frijol.KeyPress
        'codigo para limitar el ingreso de datos a valores numericos
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_azucar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_azucar.KeyPress
        'codigo para limitar el ingreso de datos a valores numericos
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
