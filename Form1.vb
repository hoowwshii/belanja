Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtnamabarang.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "B1" Then
            txtnamabarang.Text = "Shampoo"
            txtharga.Text = 5000
        ElseIf ComboBox1.Text = "B2" Then
            txtnamabarang.Text = "Sabun Mandi"
            txtharga.Text = 100000
        ElseIf ComboBox1.Text = "B3" Then
            txtnamabarang.Text = "Sabun muka"
            txtharga.Text = 7500
        ElseIf ComboBox1.Text = "B4" Then
            txtnamabarang.Text = "Palu"
            txtharga.Text = 50000
        ElseIf ComboBox1.Text = "B5" Then
            txtnamabarang.Text = "Arit"
            txtharga.Text = 50000
        ElseIf ComboBox1.Text = "B6" Then
            txtnamabarang.Text = "Sapu"
            txtharga.Text = 15000
        ElseIf ComboBox1.Text = "B6" Then
            txtnamabarang.Text = "Coklat"
            txtharga.Text = 20000
        ElseIf ComboBox1.Text = "B7" Then
            txtnamabarang.Text = "Kecap"
            txtharga.Text = 25000
        ElseIf ComboBox1.Text = "B8" Then
            txtnamabarang.Text = "Saus Sambal"
            txtharga.Text = 25000
        ElseIf ComboBox1.Text = "B9" Then
            txtnamabarang.Text = "Saus Tomat"
            txtharga.Text = 25000
        ElseIf ComboBox1.Text = "B10" Then
            txtnamabarang.Text = "Susu"
            txtharga.Text = 50000
        End If

    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtjumlah.TextChanged

        txttotalharga.Text = Val(txtjumlah.Text) * Val(txtharga.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtnamabarang.Text = ""
        txtharga.Text = ""
        txtjumlah.Text = ""
        txttotalharga.Text = ""
        ComboBox1.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class
