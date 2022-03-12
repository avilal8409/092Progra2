Imports System.Math
Public Class Form1
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

        If MsgBox("Desea cerrar el programa?", vbQuestion + vbYesNo, "Finalizar programa") = vbYes Then
            Me.Close()
        End If

    End Sub

    Private Sub LimpiarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarTodoToolStripMenuItem.Click
        Limpiar_Entradas()
        MsgBox("Datos de Entrada Limpios, Ingrese de nuevo", vbQuestion, "Ready")
    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click

        If (counter < 8) Then

            Select Case (combolenguaje.SelectedItem)
                Case "Frances" : Module1.Academia(counter, 0) = "Frances"
                Case "Ingles" : Module1.Academia(counter, 0) = "Ingles"
                Case "Portugues" : Module1.Academia(counter, 0) = "Portugues"
                Case Else : MsgBox("Seleccione un Lenguaje", vbQuestion, "Atencion")
                    Exit Sub
            End Select

            If (IsNumeric(txtcarne.Text) And Val(txtcarne.Text) > 0) Then
                Module1.Academia(counter, 1) = txtcarne.Text
            Else
                MsgBox("Carnet nulo/invalido. Solo debe contener numeros sin espacios o caracteres especiales", vbQuestion, "Atencion")
                txtcarne.Focus()
                Exit Sub
            End If

            If (txtnombre.Text <> "") Then
                Module1.Academia(counter, 2) = txtnombre.Text
            Else
                MsgBox("Ingrese Nombre de estudiante", vbQuestion, "Atencion")
                txtnombre.Focus()
                Exit Sub
            End If

            'importando la info del day time picker

            Module1.Academia(counter, 3) = (Format(dtpfecha.Value))



            ' if checkbox dias

            If ckcviernes.Checked = True Then
                    Module1.Academia(counter, 4) = "Viernes"
                End If
                If ckcsabado.Checked = True Then
                    Module1.Academia(counter, 4) = "Sabado"
                End If
                If (ckcviernes.Checked = True) And (ckcsabado.Checked = True) Then
                    Module1.Academia(counter, 4) = "Viernes y Sabado"
                End If
                If (ckcviernes.Checked = False) And (ckcsabado.Checked = False) Then
                    MsgBox("Seleccione un dia", vbQuestion, "Atencion")
                    ckcviernes.Focus()
                    Exit Sub
                End If

                If (IsNumeric(txthoras.Text) And Val(txthoras.Text) > 0) Then
                    Module1.Academia(counter, 5) = (txthoras.Text)
                Else
                    MsgBox("Ingrese la cantidad de horas a cursar por dia", vbQuestion, "Atencion")
                    txthoras.Focus()
                    Exit Sub
                End If

                ' calculo de subtotal

                Select Case (combolenguaje.SelectedItem)
                    Case "Frances"
                        If ckcviernes.Checked = True Then
                            Module1.Academia(counter, 6) = Str(Val(txthoras.Text) * Frances)
                        End If
                        If ckcsabado.Checked = True Then
                            Module1.Academia(counter, 6) = Str(Val(txthoras.Text) * Frances)
                        End If
                        If (ckcviernes.Checked = True) And (ckcsabado.Checked = True) Then
                            Module1.Academia(counter, 6) = Str(Val(txthoras.Text) * Frances * 2)
                        End If

                    Case "Ingles" : Module1.Academia(counter, 6) = Str(Val(txthoras.Text) * Ingles)
                        If ckcviernes.Checked = True Then
                            Module1.Academia(counter, 6) = Str(Val(txthoras.Text) * Ingles)
                        End If
                        If ckcsabado.Checked = True Then
                            Module1.Academia(counter, 6) = Str(Val(txthoras.Text) * Ingles)
                        End If
                        If (ckcviernes.Checked = True) And (ckcsabado.Checked = True) Then
                            Module1.Academia(counter, 6) = Str(Val(txthoras.Text) * Ingles * 2)
                        End If


                    Case "Portugues" : Module1.Academia(counter, 6) = Str(Val(txthoras.Text) * Portugues)
                        If ckcviernes.Checked = True Then
                            Module1.Academia(counter, 6) = Str(Val(txthoras.Text) * Portugues)
                        End If
                        If ckcsabado.Checked = True Then
                            Module1.Academia(counter, 6) = Str(Val(txthoras.Text) * Portugues)
                        End If
                        If (ckcviernes.Checked = True) And (ckcsabado.Checked = True) Then
                            Module1.Academia(counter, 6) = Str(Val(txthoras.Text) * Portugues * 2)
                        End If
                End Select

                ' calculo de descuento por metodo de pago columna 7

                If rbefectivo.Checked = True Then
                    Module1.Academia(counter, 7) = Round((Val(Module1.Academia(counter, 6)) * efectivo), 2)

                End If
                If rbcheque.Checked = True Then
                    Module1.Academia(counter, 7) = Round((Val(Module1.Academia(counter, 6)) * cheque), 2)
                End If
                If (rbefectivo.Checked = False) And (rbcheque.Checked = False) Then
                    MsgBox("No Selecciono un medio de pago", vbQuestion, "atencion")
                    Exit Sub
                End If

                ' calculo de descuento por dos dias en un curso

                If (ckcviernes.Checked = True) And (ckcsabado.Checked = True) Then
                    Module1.Academia(counter, 8) = Round(Val(Module1.Academia(counter, 6) * Desc5percentage), 2)
                Else
                    Module1.Academia(counter, 8) = "No aplica"
                End If


                ' calculo columna total

                If Module1.Academia(counter, 8) = "No aplica" Then
                    Module1.Academia(counter, 9) = Round(Val(Val(Module1.Academia(counter, 6)) + Val(Module1.Academia(counter, 7))), 2)
                End If

                If Module1.Academia(counter, 8) <> "No aplica" Then
                    Module1.Academia(counter, 9) = Round(Val(Val(Module1.Academia(counter, 6)) + Val(Module1.Academia(counter, 7))) + Val(Module1.Academia(counter, 8)), 2)
                End If


            ' mostrar medio de pago

            If rbefectivo.Checked = True Then

                Module1.Academia(counter, 10) = "Efectivo"
            End If

            If rbcheque.Checked = True Then
                Module1.Academia(counter, 10) = "cheque"
            End If


            DataGridView1.Rows.Add(Module1.Academia(counter, 0), Module1.Academia(counter, 1), Module1.Academia(counter, 2), Module1.Academia(counter, 3), Module1.Academia(counter, 4), Module1.Academia(counter, 5), Module1.Academia(counter, 6), Module1.Academia(counter, 7), Module1.Academia(counter, 8), Module1.Academia(counter, 9), Module1.Academia(counter, 10))


            counter += 1

            Else
                MsgBox("Vectores llenos", vbQuestion, "Atencion")


        End If

        If (counter = 8) Then
            MsgBox("Matriz Llena", vbQuestion, "Warning")
            Exit Sub
        End If



    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        Limpiar_Vectores()

        MsgBox("Matriz y contadores Limpios", vbQuestion, "Ready")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class
