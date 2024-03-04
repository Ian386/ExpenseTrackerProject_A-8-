Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get the current time
        Dim currentTime As DateTime = DateTime.Now

        ' Determine the appropriate greeting based on the time of day
        Dim greeting As String
        If currentTime.Hour < 12 Then
            greeting = "Good morning"
        ElseIf currentTime.Hour < 18 Then
            greeting = "Good afternoon"
        Else
            greeting = "Good evening"
        End If

        ' Update the label text
        lblGreeting.Text = greeting
    End Sub

    Private Sub btnWallet_Click(sender As Object, e As EventArgs) Handles btnWallet.Click
        Me.Close()
        Dim form3Instance As New Form3()
        form3Instance.Show()
    End Sub
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
        Dim form4Instance As New Form4()
        form4Instance.Show()
    End Sub

    Private Sub btnBudget_Click(sender As Object, e As EventArgs) Handles btnBudget.Click
        Me.Close()
        Dim form5Instance As New Form5()
        form5Instance.Show()
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        Me.Close()
        Dim form6Instance As New Form6()
        form6Instance.Show()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Me.Close()
        Dim form7Instance As New Form7()
        form7Instance.Show()
    End Sub

    Private Sub btnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
        Me.Close()
        Dim form8Instance As New Form8()
        form8Instance.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class