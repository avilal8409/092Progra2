Imports System.Math
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("Desea cerrar el programa?", vbQuestion + vbYesNo, "Finalizar programa") = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click

        If counter < 7 Then
            ' columan 0,1  < Cantidad >
            If (IsNumeric(txtcantidad.Text)) And (Val(txtcantidad.Text) > 0) Then
                'verificacion que sea un valor numerico y mayor que cero
                cantidad(counter) = Str(txtcantidad.Text)
            Else
                MsgBox("Cantidad en blanco, nula o cero, verificar", vbQuestion, "Verificar cantidad")
                txtcantidad.Focus()
                Exit Sub
            End If

            ' columan 0,2 < tamano >
            Select Case (combo_tamano.Text)
                Case "Individual" : tamano(counter) = combo_tamano.Text
                    ' columan 0,3 < Mano de obra>
                    mano_obra(counter) = Str(p_individual)
                    ' columan 0,6 < Cantidad de yardas >
                    yardas(counter) = Str(y_individual)

                Case "Double" : tamano(counter) = combo_tamano.Text
                    ' columan 0,3 < Mano de obra>
                    mano_obra(counter) = Str(p_doble)
                    ' columan 0,6 < Cantidad de yardas >
                    yardas(counter) = Str(y_doble)
                Case "Sofa" : tamano(counter) = combo_tamano.Text
                    ' columan 0,3 < Mano de obra>
                    mano_obra(counter) = Str(p_sofa)
                    ' columan 0,6 < Cantidad de yardas >
                    yardas(counter) = Str(y_sofa)

                Case Else
                    MsgBox("Seleccione un tipo de tamano", vbQuestion, "Verificar Seleccion")
                    Exit Sub
            End Select

            ' columan 0,4 < Material, cuero o cuerina>

            If rb_cuero.Checked = True Then
                telas(counter) = rb_cuero.Text
                ' columan 0,5 < Precio, materia>
                precio_telas(counter) = Str(p_cuero)
            End If
            If rb_cuerina.Checked = True Then
                telas(counter) = rb_cuerina.Text
                ' columan 0,5 < Precio, materia>
                precio_telas(counter) = Str(p_erina)
            End If
            If (rb_cuero.Checked = False) And (rb_cuerina.Checked = False) Then
                MsgBox("Seleccione un tipo de Material (cuero/ina)", vbQuestion, "Verificar Material")
                Exit Sub
            End If

            ' columan 0,7 <subtotal = (Precio de Tela * Yardas * cantidad) >

            subtotal(counter) = Str(Math.Round(Val(precio_telas(counter)) * Val(yardas(counter)) * Val(cantidad(counter)), 2))

            ' columan 0,8 <total = subtotal + Mano de Obra >

            total(counter) = Str(Math.Round(Val(subtotal(counter)) + Val(mano_obra(counter)), 2))

            'columan 0,9 <Precio venta = 1.65 * Total +  >

            precioventa(counter) = "Q" & Str(Math.Round(1.65 * total(counter), 2))

            'columna 0,10  <Numero de venta o factura >

            factura(counter) = "Fel - " & Str(100 + Val(counter))

            'Mostrar datos
            Data_Mostrar.Rows.Add(cantidad(counter), tamano(counter), mano_obra(counter), telas(counter), precio_telas(counter), yardas(counter), subtotal(counter), total(counter), precioventa(counter), factura(counter))

            'incremento contador
            counter += 1

        End If

        If counter = 7 Then
            MsgBox("Vectores llenos, limpiar vector", vbQuestion, "Atencion")
            Exit Sub
        End If



    End Sub

    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub VectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VectoresToolStripMenuItem.Click
        Limpiar_Vectores()

    End Sub

    Private Sub EntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradasToolStripMenuItem.Click
        Limpiar_Entradas()

    End Sub
End Class
