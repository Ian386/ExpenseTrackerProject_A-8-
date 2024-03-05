Public Class Form3
    Private enteredName As String = Nothing
    Private selectedCurrency As String = Nothing
    Private enteredAmount As Decimal = 0

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate ComboBox with currency options
        ComboBoxCurrency.Items.AddRange({"USD", "CAD", "EUR", "AED", "AUD", "CNY", "CZK", "DJF", "EGP", "GBP", "HKD", "KES", "JPY", "SOS", "SEK", "TZC", "UGX", "UYU", "UZS", "VND", "XAF", "ZAR"})
        ' Set default selected item if needed
        ComboBoxCurrency.SelectedIndex = 0
    End Sub
    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Get the entered name
        enteredName = txtName.Text

        ' Get the selected currency
        selectedCurrency = ComboBoxCurrency.SelectedItem.ToString()

        ' Get the entered amount
        If Decimal.TryParse(txtAmount.Text, enteredAmount) Then
            ' Valid amount entered
            ' Do something with the entered name, selected currency, and amount
            MessageBox.Show("Name: " & enteredName & vbCrLf &
                            "Currency: " & selectedCurrency & vbCrLf &
                            "Amount: " & enteredAmount.ToString("C"))
            ' You can save the data to a database or perform further processing here
        Else
            ' Invalid amount entered
            MessageBox.Show("Please enter a valid amount.")
        End If
    End Sub

    Private Sub bthHome_Click(sender As Object, e As EventArgs) Handles bthHome.Click
        ' Close the current form (Form3) and show the home form (Form1)
        Form4.Show()
        Me.Close()
    End Sub
End Class

