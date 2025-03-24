Public Class frmModifyPipeLenght
    'Dim oOldPipeLenght As String
    Dim oNewPipeLenghtB As Integer


    Private Sub btnReplacePipe_Click(sender As Object, e As EventArgs) Handles btnReplacePipe.Click

        FormPiping.oNewPipeLenght = oNewPipeLenghtB
        Me.Hide()
    End Sub


    Private Sub cbxNewPipeLenght_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxNewPipeLenght.SelectedIndexChanged
        oNewPipeLenghtB = cbxNewPipeLenght.Text
        If oNewPipeLenghtB < 50 Then
            oNewPipeLenghtB = 50
            cbxNewPipeLenght.Text = 50
        End If
        If oNewPipeLenghtB > 6000 Then
            oNewPipeLenghtB = 6000
            cbxNewPipeLenght.Text = 6000
        End If

    End Sub

    Private Sub cbxNewPipeLenght_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxNewPipeLenght.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
        If Asc(e.KeyChar) = 22 Then
            e.KeyChar = ""
        End If
        If Asc(e.KeyChar) = 13 Then
            oNewPipeLenghtB = cbxNewPipeLenght.Text
            If oNewPipeLenghtB < 50 Then
                oNewPipeLenghtB = 50
                cbxNewPipeLenght.Text = 50
            End If
            If oNewPipeLenghtB > 6000 Then
                oNewPipeLenghtB = 6000
                cbxNewPipeLenght.Text = 6000
            End If
            FormPiping.oNewPipeLenght = oNewPipeLenghtB
            Me.Hide()


        End If
    End Sub

    Private Sub cbxNewPipeLenght_MouseLeave(sender As Object, e As EventArgs) Handles cbxNewPipeLenght.MouseLeave
        If cbxNewPipeLenght.Text = "" Then
            cbxNewPipeLenght.Text = "50"
        End If
        oNewPipeLenghtB = cbxNewPipeLenght.Text
        If oNewPipeLenghtB < 50 Then
            oNewPipeLenghtB = 50
            cbxNewPipeLenght.Text = 50
        End If
        If oNewPipeLenghtB > 6000 Then
            oNewPipeLenghtB = 6000
            cbxNewPipeLenght.Text = 6000
        End If
    End Sub



    Private Sub cbxNewPipeLenght_LostFocus(sender As Object, e As EventArgs) Handles cbxNewPipeLenght.LostFocus
        If cbxNewPipeLenght.Text = "" Then
            cbxNewPipeLenght.Text = "50"
        End If
        oNewPipeLenghtB = cbxNewPipeLenght.Text
        If oNewPipeLenghtB < 50 Then
            oNewPipeLenghtB = 50
            cbxNewPipeLenght.Text = 50
        End If
        If oNewPipeLenghtB > 6000 Then
            oNewPipeLenghtB = 6000
            cbxNewPipeLenght.Text = 6000
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        oNewPipeLenghtB = FormPiping.oOldPipeLenght
        FormPiping.oNewPipeLenght = oNewPipeLenghtB
        Me.Hide()
    End Sub



End Class