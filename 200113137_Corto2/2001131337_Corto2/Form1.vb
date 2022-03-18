Imports System.Math
Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("Desea cerrar el programa?", vbQuestion + vbYesNo, "Finalizar programa") = vbYes Then
            Me.Close()
        End If

    End Sub

    Private Sub txt_articulos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_articulos.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CalclularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalclularToolStripMenuItem.Click

        If counter < 6 Then

            If Val(txt_articulos.Text <> "") And (Val(txt_articulos.Text)) > 0 Then
                cantidad(counter) = Str(txt_articulos.Text)
            Else
                MessageBox.Show("cantidad no valida o nula, intente de nuevo")
                txt_articulos.Focus()
                Exit Sub
            End If

            ' mostrar en lista el combo

            Select Case (ComboBox1.Text)

                Case "Tablet" : articulo(counter) = ComboBox1.Text
                    ' mostrar precio del articulo listbox 5
                    precio(counter) = Str(ptablet)

                Case "Drone" : articulo(counter) = ComboBox1.Text
                    ' mostrar precio del articulo listbox 5
                    precio(counter) = Str(pdrone)
                Case "Celular" : articulo(counter) = ComboBox1.Text
                    ' mostrar precio del articulo listbox 5
                    precio(counter) = Str(pcelular)
                Case "Televisor" : articulo(counter) = ComboBox1.Text
                    ' mostrar precio del articulo listbox 5
                    precio(counter) = Str(ptv)
                Case Else : MessageBox.Show("articulo no seleccionado")

            End Select

            ' mostrar nombre empleado

            If (txtnombre.Text <> "") Then
                nombre_empleado(counter) = txtnombre.Text
            Else
                MessageBox.Show("Nombre en blanco, intente de nuevo")
                txtnombre.Focus()
                Exit Sub
            End If


            'mostrar sueldo nominal

            If (IsNumeric(txt_sueldo.Text)) And (Val(txt_sueldo.Text > 0)) Then
                sueldo(counter) = Str(Math.Round(Val(txt_sueldo.Text), 2))
            Else
                MessageBox.Show("Verifique sueldo, intente de nuevo")
                txt_sueldo.Focus()
                Exit Sub
            End If

            'valor compra

            compra(counter) = Str(Math.Round(Val(cantidad(counter)) * Val(precio(counter)), 2))

            'comision x venta

            comi_venta(counter) = Str(Math.Round(Val(cantidad(counter)) * Val(precio(counter) * comision), 2))

            ' bono

            If (Val(comi_venta(counter) < 2000)) Then
                bono(counter) = Str(Math.Round(0.03 * Val(comi_venta(counter)), 2))
            End If

            If (Val(comi_venta(counter) > 2000) And Val(comi_venta(counter) < 5000)) Then
                bono(counter) = Str(Math.Round(0.04 * Val(comi_venta(counter)), 2))
            End If

            If (Val(comi_venta(counter) > 5000)) Then
                bono(counter) = Str(Math.Round(0.05 * Val(comi_venta(counter)), 2))
            End If

            ' calculo sueldo total

            sueldo_total(counter) = Str(Val(sueldo(counter)) + Val(comi_venta(counter)) + Val(bono(counter)))



            ListBox1.Items.Add(Str(cantidad(counter)))
                ListBox2.Items.Add(articulo(counter))
                ListBox3.Items.Add(nombre_empleado(counter))
                ListBox4.Items.Add(sueldo(counter))
                ListBox5.Items.Add(precio(counter))
                ListBox6.Items.Add(compra(counter))
                ListBox7.Items.Add(comi_venta(counter))
            ListBox8.Items.Add(bono(counter))
            ListBox9.Items.Add(sueldo_total(counter))

            counter += 1
        End If
        If counter = 6 Then
            MsgBox("Vectores llenos, limpiar vector", vbQuestion, "Atencion")
            Exit Sub
        End If



    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click

    End Sub

    Private Sub EntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradasToolStripMenuItem.Click

        limpiar_entradas()

    End Sub

    Private Sub VectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VectoresToolStripMenuItem.Click
        limpiar_vectores()

    End Sub
End Class
