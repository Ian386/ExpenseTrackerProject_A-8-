Imports System.IO
Imports System.Numerics
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography.Xml
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class Form8
    Private selectedBudget As String = Nothing
    Private selectedCategory As String = Nothing
    Private enteredAmount As Decimal = 0

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboBoxBudget.Items.AddRange({"Budget 1", "Budget 2", "Budget 3", "Budget 4", "Budget 5"})
        comboBoxBudget.SelectedIndex = 0

        comboBoxCategory.Items.AddRange({"Food & Drinks", "Bill", "Transport", "House Rent", "Fix & Maintenance", "Utilities", "Groceries", "Entertainment", "Fashion", "Travel", "Beauty Care", "Party", "Gift", "Donation", "Doctor", "Sport", "Insurance", "Gym Membership", "Fee & charge", "Investments", "Kids", "Other"})
        comboBoxCategory.SelectedIndex = 0
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Get the selected budget
        selectedBudget = comboBoxBudget.SelectedItem.ToString()

        ' Get the selected category
        selectedCategory = comboBoxCategory.SelectedItem.ToString()

        ' Get the entered amount
        If Decimal.TryParse(txtAmount.Text, enteredAmount) Then
            ' Valid amount entered
            ' Do something with the selected budget, selected category, and entered amount
            MessageBox.Show("Selected Budget: " & selectedBudget & vbCrLf &
                            "Selected Category: " & selectedCategory & vbCrLf &
                            "Amount: " & enteredAmount.ToString("C"))
            ' You can save the data to a database or perform further processing here
        Else
            ' Invalid amount entered
            MessageBox.Show("Please enter a valid amount.")
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
        Dim form4Instance As New Form4()
        form4Instance.Show()
    End Sub
End Class