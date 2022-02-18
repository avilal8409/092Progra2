Public Class Form1
    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        rbsmall.Checked = False
        rbmedium.Checked = False
        rblarge.Checked = False
    End Sub
    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        limpiar()
    End Sub

    Private Sub txtcalculo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcalculo.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        If MsgBox("Desea cerrar el programa?", vbQuestion + vbYesNo, "Finalizar programa") = vbYes Then
            Me.Close()
        Else
            limpiar()

        End If
    End Sub

    Private Sub rbsmall_CheckedChanged(sender As Object, e As EventArgs) Handles rbsmall.CheckedChanged
        If rbsmall.Checked = True Then
            gbcalculo.Visible = True
        Else
            gbcalculo.Visible = False

        End If
    End Sub

    Private Sub rbmedium_CheckedChanged(sender As Object, e As EventArgs) Handles rbmedium.CheckedChanged
        If rbmedium.Checked = True Then
            gbcalculo.Visible = True
        Else
            gbcalculo.Visible = False

        End If
    End Sub

    Private Sub rblarge_CheckedChanged(sender As Object, e As EventArgs) Handles rblarge.CheckedChanged
        If rblarge.Checked = True Then
            gbcalculo.Visible = True
        Else
            gbcalculo.Visible = False

        End If
    End Sub

    Private Sub txtcalculo_TextChanged(sender As Object, e As EventArgs) Handles txtcalculo.TextChanged
        If Val(txtcalculo.Text) > 0 Then
            gbmateriales.Visible = True
        Else
            gbmateriales.Visible = False

        End If
    End Sub

    Private Sub btcalcular_Click(sender As Object, e As EventArgs) Handles btcalcular.Click

        If rbsmall.Checked = True Or rbmedium.Checked = True Or rblarge.Checked = True Then
        ElseIf rbsmall.Checked = True Then
            gbcalculo.Visible = True
        ElseIf rbmedium.Checked = True Then
            gbcalculo.Visible = True
        ElseIf rblarge.Checked = True Then
            gbcalculo.Visible = True
        Else
            MsgBox("Seleccione una talla", vbQuestion, "Error")
            Exit Sub
        End If

        ' cuadro de mensaje de la 2da caja de error

        If Val(txtcalculo.Text) <= 0 Then
            MsgBox("Ingrese una cantidad diferente de cero", vbQuestion, "Error de Calculo")
            Exit Sub
        End If

        ' if para abrir la form 2 
        If (rbsmall.Checked = True Or rbmedium.Checked = True Or rblarge.Checked = True) And (rbalgodon.Checked = True Or rbseda.Checked = True Or rblona.Checked = True) Then
            f2resulprecios.Show()
            Me.Hide()
        Else
            MsgBox("Seleccione un tipo de material", vbQuestion, "Error")
        End If



    End Sub
End Class
