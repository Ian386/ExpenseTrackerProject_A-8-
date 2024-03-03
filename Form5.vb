Public Class Form5
    'declare variables to be used within the whole project
    Private Shared _budgetAmount As Decimal
    Private Shared _timeRange As String
    Private Shared _startDate As Date
    Private Shared _endDate As Date
    Private Shared _BudgetName As String
    'get the checked items from the checked list boxes in this form
    Private Shared _CheckedItems As New List(Of String)


    Public Shared Property BudgetAmount As Decimal
        Get
            Return _budgetAmount
        End Get
        Set(value As Decimal)
            _budgetAmount = value
        End Set
    End Property

    Public Shared Property TimeRange As String
        Get
            Return _timeRange
        End Get
        Set(value As String)
            _timeRange = value
        End Set
    End Property

    Public Shared Property StartDate As Date
        Get
            Return _startDate
        End Get
        Set(value As Date)
            _startDate = value
        End Set
    End Property

    Public Shared Property EndDate As Date
        Get
            Return _endDate
        End Get
        Set(value As Date)
            _endDate = value
        End Set
    End Property
    Public Shared Property BudgetName As String
        Get
            Return _BudgetName
        End Get
        Set(value As String)
            _BudgetName = value
        End Set
    End Property

    Public Shared Property CheckedItems As List(Of String)
        Get
            Return _checkedItems
        End Get
        Set(value As List(Of String))
            _checkedItems = value
        End Set
    End Property

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbStartDate.Visible = False
        lbEndDate.Visible = False
        txtStartDate.Visible = False
        txtEndDate.Visible = False
    End Sub

    Private Sub btnGoBackHome_Click(sender As Object, e As EventArgs) Handles btnGoBackHome.Click
        Me.Close()
        Form4.Show()
    End Sub

    Private Sub txtStartDate_TextChanged(sender As Object, e As EventArgs) Handles txtStartDate.TextChanged
        'convert to date

        If Date.TryParse(txtStartDate.Text, StartDate) Then
            StartDate = txtStartDate.Text
            StartDate = StartDate.ToString("yyyy-MM-dd")
        Else
            ' Invalid input, handle the error
            Console.WriteLine("Invalid Start Date. Please enter a valid date.")
        End If

    End Sub

    Private Sub txtEndDate_TextChanged(sender As Object, e As EventArgs) Handles txtEndDate.TextChanged
        'convert to date

        If Date.TryParse(txtEndDate.Text, EndDate) Then
            EndDate = txtEndDate.Text
            EndDate = EndDate.ToString("yyyy-MM-dd")
        Else
            ' Invalid input, handle the error
            Console.WriteLine("Invalid Start Date. Please enter a valid date.")
        End If


    End Sub

    Private Sub txtBudgetAmount_TextChanged(sender As Object, e As EventArgs) Handles txtBudgetAmount.TextChanged

        If Decimal.TryParse(txtBudgetAmount.Text, BudgetAmount) Then
            BudgetAmount = txtBudgetAmount.Text
        Else
            ' Invalid input, handle the error
            MsgBox("Invalid Budget Amount. Please enter a valid amount.")
        End If

    End Sub

    Private Sub txtEnterBudgetName_TextChanged(sender As Object, e As EventArgs) Handles txtEnterBudgetName.TextChanged
        'save the budget name
        BudgetName = txtEnterBudgetName.Text
    End Sub

    Private Sub btnSaveNewBudget_Click(sender As Object, e As EventArgs) Handles btnSaveNewBudget.Click
        'save checked items to the list
        For Each item As Object In clbBasics.CheckedItems
            CheckedItems.Add(item.ToString())
        Next
        For Each item As Object In clbEnjoyments.CheckedItems
            CheckedItems.Add(item.ToString())
        Next
        For Each item As Object In clbHealthCare.CheckedItems
            CheckedItems.Add(item.ToString())
        Next
        For Each item As Object In clbOtherExpenses.CheckedItems
            CheckedItems.Add(item.ToString())
        Next

        'save the budget amount
        BudgetAmount = txtBudgetAmount.Text
        'save the time range
        TimeRange = cbTimeRange.SelectedItem

        'close the form and open the next form
        Me.Close()
        Form4.Show()
    End Sub

    Private Sub cbTimeRange_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTimeRange.SelectedIndexChanged
        'show the start and end date text boxes if the user selects a custom time range
        If cbTimeRange.SelectedItem = "One time" Then
            lbStartDate.Visible = True
            lbEndDate.Visible = True
            txtStartDate.Visible = True
            txtEndDate.Visible = True
        Else
            lbStartDate.Visible = False
            lbEndDate.Visible = False
            txtStartDate.Visible = False
            txtEndDate.Visible = False
        End If
    End Sub
End Class