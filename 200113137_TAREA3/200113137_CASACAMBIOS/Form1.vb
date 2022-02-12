Public Class Form1
    Private Sub cbcompra_CheckedChanged(sender As Object, e As EventArgs) Handles cbcompra.CheckedChanged
        If cbcompra.Checked = True Then
            txtcompra.Enabled = True
            gbcompramoneda.Visible = True
        Else
            txtcompra.Enabled = False
            gbcompramoneda.Visible = False
        End If



    End Sub

    Private Sub cbventa_CheckedChanged(sender As Object, e As EventArgs) Handles cbventa.CheckedChanged
        If cbventa.Checked = True Then
            txtventa.Enabled = True
            gbventamoneda.Visible = True
        Else
            txtventa.Enabled = False
            gbventamoneda.Visible = False
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpiar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (MsgBox("Desea Salir?", vbQuestion + vbYesNo, "Salir") = vbYes) Then
            Me.Close()
        Else
            limpiar()
        End If

    End Sub

    Private Sub txtcompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcompra.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If

        End If

    End Sub

    Private Sub txtventa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtventa.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If

        End If
    End Sub
End Class
