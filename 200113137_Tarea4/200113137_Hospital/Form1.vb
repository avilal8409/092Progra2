Imports System.Math
Public Class Form1
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("Desea cerrar el programa?", vbQuestion + vbYesNo, "Finalizar programa") = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub DatosDelFormularioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosDelFormularioToolStripMenuItem.Click
        Limpiar_entradas()

    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click

        If counter < 6 Then

            ' caja nombre
            If (txt_nombre.Text <> "") Then
                vnombre(counter) = txt_nombre.Text
            Else
                MsgBox("Ingrese el nombre del paciente", vbQuestion, "Error")
                Exit Sub
            End If
            ' caja nit
            If (IsNumeric(txtnit.Text) And Val(txtnit.Text) > 0) Then
                vnit(counter) = txtnit.Text
            Else
                MsgBox("Ingrese el numero de nit", vbQuestion, "Error")
                txtnit.Focus()
                Exit Sub
            End If
            ' caja dias
            If (IsNumeric(txt_diashopsitalizado.Text) And Val(txt_diashopsitalizado.Text) > 0) Then
                vdias(counter) = txt_diashopsitalizado.Text
            Else
                MsgBox("Ingrese el numero de dias Hospitalizado", vbQuestion, "Error")
                txt_diashopsitalizado.Focus()
                Exit Sub
            End If
            ' caja tipo de habitacion
            Select Case (cmb_tipohabitacion.SelectedIndex)
                Case 0 : vtipohabitacion(counter) = "Privada"
                Case 1 : vtipohabitacion(counter) = "Semi-Privada"
                Case 2 : vtipohabitacion(counter) = "No Privada"
                Case Else
                    MsgBox("Seleccione un tipo de Habitacion", vbQuestion, "Error")
                    Exit Sub
            End Select

            ' honorarios medicos

            If IsNumeric(txthonorarios.Text) And Val(txthonorarios.Text) > 0 Then
                vhonorariosmedicos(counter) = txthonorarios.Text
            Else
                MsgBox("Ingrese el monto de honorarios medicos", vbQuestion, "Error")
                txthonorarios.Focus()
                Exit Sub
            End If


            ' tipo de servicio

            If ckc_Encamamiento.Checked = True Then
                vtiposervicio(counter) = "Encamamiento"
            End If

            If ckc_Maternidad.Checked = True Then
                vtiposervicio(counter) = "Maternidad"
            End If

            If ckc_Operacion.Checked = True Then
                vtiposervicio(counter) = "Operacion"
            End If

            If (ckc_Encamamiento.Checked = True) And (ckc_Maternidad.Checked = True) And (ckc_Operacion.Checked = True) Then
                vtiposervicio(counter) = "Encamamiento, Maternidad y Operacion"
            End If

            If (ckc_Encamamiento.Checked = True) And (ckc_Maternidad.Checked = True) Then
                vtiposervicio(counter) = "Encamamiento y Maternidad"
            End If

            If (ckc_Encamamiento.Checked = True) And (ckc_Operacion.Checked = True) Then
                vtiposervicio(counter) = "Encamamiento y Operacion"
            End If

            If (ckc_Maternidad.Checked = True) And (ckc_Operacion.Checked = True) Then
                vtiposervicio(counter) = "Maternidad y Operacion"
            End If

            If (ckc_Encamamiento.Checked = False) And (ckc_Maternidad.Checked = False) And (ckc_Operacion.Checked = False) Then
                MsgBox("Seleccione un tipo de Servicio", vbQuestion, "atencion")
                Exit Sub
            End If

            ' tipo de pago

            Select Case (cmb_formapago.SelectedIndex)
                Case 0 : vformapago(counter) = "Efectivo"
                Case 1 : vformapago(counter) = "cheque"
                Case 2 : vformapago(counter) = "Tarjeta Debito"
                Case 3 : vformapago(counter) = "Tarjeta Credito"

                Case Else
                    MsgBox("Seleccione un metodo de pago", vbQuestion, "Atencion")
                    Exit Sub
            End Select

            ' calculo de subtotal ( honorarios medicos + dias hospitalizados (tipo de habitacion y servicio)

            Select Case (cmb_tipohabitacion.SelectedIndex)
                Case 0

                    ' calculo de subtotal

                    If (ckc_Encamamiento.Checked = True) Then
                        vsubtotal(counter) = Round((Val(vhonorariosmedicos(counter)) + Val(vdias(counter) * privada_encamiento)), 2)
                    End If

                    If (ckc_Encamamiento.Checked = True) And (ckc_Operacion.Checked = True) Then
                        vsubtotal(counter) = Round((Val(vhonorariosmedicos(counter)) + Val(vdias(counter) * privada_encamiento) + Val(vdias(counter) * privada_operacion)), 2)
                    End If

                    If (ckc_Encamamiento.Checked = True) And (ckc_Operacion.Checked = True) And (ckc_Maternidad.Checked = True) Then
                        vsubtotal(counter) = Round((Val(vhonorariosmedicos(counter)) + Val(vdias(counter) * privada_encamiento) + Val(vdias(counter) * privada_operacion) + Val(vdias(counter) * privada_maternidad)), 2)
                    End If

                Case 1

                    If (ckc_Encamamiento.Checked = True) Then
                        vsubtotal(counter) = Round((Val(vhonorariosmedicos(counter)) + Val(vdias(counter) * sp_encamiento)), 2)
                    End If

                    If (ckc_Encamamiento.Checked = True) And (ckc_Operacion.Checked = True) Then
                        vsubtotal(counter) = Round((Val(vhonorariosmedicos(counter)) + Val(vdias(counter) * sp_encamiento) + Val(vdias(counter) * sp_operacion)), 2)
                    End If

                    If (ckc_Encamamiento.Checked = True) And (ckc_Operacion.Checked = True) And (ckc_Maternidad.Checked = True) Then
                        vsubtotal(counter) = Round((Val(vhonorariosmedicos(counter)) + Val(vdias(counter) * sp_encamiento) + Val(vdias(counter) * sp_operacion) + Val(vdias(counter) * sp_maternidad)), 2)
                    End If

                Case 2

                    If (ckc_Encamamiento.Checked = True) Then
                        vsubtotal(counter) = Round((Val(vhonorariosmedicos(counter)) + Val(vdias(counter) * nopriv_encamiento)), 2)
                    End If

                    If (ckc_Encamamiento.Checked = True) And (ckc_Operacion.Checked = True) Then
                        vsubtotal(counter) = Round((Val(vhonorariosmedicos(counter)) + Val(vdias(counter) * nopriv_encamiento) + Val(vdias(counter) * nopriv_operacion)), 2)
                    End If

                    If (ckc_Encamamiento.Checked = True) And (ckc_Operacion.Checked = True) And (ckc_Maternidad.Checked = True) Then
                        vsubtotal(counter) = Round((Val(vhonorariosmedicos(counter)) + Val(vdias(counter) * nopriv_encamiento) + Val(vdias(counter) * nopriv_operacion) + Val(vdias(counter) * nopriv_maternidad)), 2)
                    End If


            End Select

            ' calculo del descuento

            Select Case (cmb_formapago.SelectedIndex)
                Case 0 : vdescuento(counter) = Round((Val(vsubtotal(counter)) * efectivo_cheque), 2)
                Case 1 : vdescuento(counter) = Round((Val(vsubtotal(counter)) * efectivo_cheque), 2)
                Case 2 : vdescuento(counter) = Round((Val(vsubtotal(counter)) * tarjeta_debito), 2)
                Case 3 : vdescuento(counter) = Round((Val(vsubtotal(counter)) * tarjeta_credito), 2)

            End Select

            ' calculo total

            vtotal(counter) = Round(Val(vsubtotal(counter)) + Val(vdescuento(counter)), 2)

            ' mostrar datos en data grid

            DataGridView1.Rows.Add(vnombre(counter), vnit(counter), vdias(counter), vtipohabitacion(counter), vhonorariosmedicos(counter), vtiposervicio(counter), vformapago(counter), vsubtotal(counter), vdescuento(counter), vtotal(counter))

            'incremento contador
            counter += 1
        End If


        If counter = 6 Then
            MsgBox("Vectores Llenos, Limpiar vector", vbQuestion, "Warning")
            Exit Sub
        End If




    End Sub

    Private Sub VectoresYDataGridToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VectoresYDataGridToolStripMenuItem.Click
        Limpiar_Vectores()
    End Sub

    Private Sub txtnit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnit.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If


    End Sub

    Private Sub txt_diashopsitalizado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_diashopsitalizado.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txthonorarios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txthonorarios.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
