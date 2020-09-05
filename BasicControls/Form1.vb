Public Class Form1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim str As String
        If cboSex.Text = Nothing Then
            MessageBox.Show("Sex is not set. Please choose one.", "Sex field is empty.",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            str = txtFN.Text & " " & txtMN.Text & " " & txtLN.Text & " is " &
                          txtAge.Text & " years old. " & cboSex.Text
            lstResults.Items.Add(str)
            ClearTextboxes()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstResults.Items.Clear()
    End Sub

    Private Sub ClearTextboxes()
        txtFN.Clear()
        txtMN.Clear()
        txtLN.Clear()
        txtAge.Clear()
        cboSex.Text = Nothing
    End Sub

    Private Sub txtAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAge.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
