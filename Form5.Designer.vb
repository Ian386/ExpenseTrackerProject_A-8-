<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lbBudgetName = New Label()
        txtEnterBudgetName = New TextBox()
        lbAmount = New Label()
        txtBudgetAmount = New TextBox()
        lbTimeRange = New Label()
        cbTimeRange = New ComboBox()
        lbStartDate = New Label()
        txtStartDate = New TextBox()
        lbEndDate = New Label()
        TextBox1 = New TextBox()
        lbChooseWallet = New Label()
        cbChooseWalllet = New ComboBox()
        btnGoBackHome = New Button()
        Label1 = New Label()
        btnSaveNewBudget = New Button()
        clbBasics = New CheckedListBox()
        lbBasics = New Label()
        clbEnjoyments = New CheckedListBox()
        clbHealthCare = New CheckedListBox()
        clbOtherExpenses = New CheckedListBox()
        Label3 = New Label()
        lbHealthCare = New Label()
        Label2 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' lbBudgetName
        ' 
        lbBudgetName.AutoSize = True
        lbBudgetName.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbBudgetName.Location = New Point(22, 115)
        lbBudgetName.Name = "lbBudgetName"
        lbBudgetName.Size = New Size(134, 25)
        lbBudgetName.TabIndex = 0
        lbBudgetName.Text = "Budget Name "
        ' 
        ' txtEnterBudgetName
        ' 
        txtEnterBudgetName.Location = New Point(191, 115)
        txtEnterBudgetName.Name = "txtEnterBudgetName"
        txtEnterBudgetName.Size = New Size(210, 31)
        txtEnterBudgetName.TabIndex = 1
        txtEnterBudgetName.Text = "Enter Budget Name"
        ' 
        ' lbAmount
        ' 
        lbAmount.AutoSize = True
        lbAmount.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbAmount.Location = New Point(22, 185)
        lbAmount.Name = "lbAmount"
        lbAmount.Size = New Size(81, 25)
        lbAmount.TabIndex = 2
        lbAmount.Text = "Amount"
        ' 
        ' txtBudgetAmount
        ' 
        txtBudgetAmount.Location = New Point(191, 185)
        txtBudgetAmount.Name = "txtBudgetAmount"
        txtBudgetAmount.Size = New Size(210, 31)
        txtBudgetAmount.TabIndex = 3
        txtBudgetAmount.Text = "Amount"
        ' 
        ' lbTimeRange
        ' 
        lbTimeRange.AutoSize = True
        lbTimeRange.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbTimeRange.Location = New Point(22, 337)
        lbTimeRange.Name = "lbTimeRange"
        lbTimeRange.Size = New Size(113, 25)
        lbTimeRange.TabIndex = 4
        lbTimeRange.Text = "Time Range"
        ' 
        ' cbTimeRange
        ' 
        cbTimeRange.FormattingEnabled = True
        cbTimeRange.Items.AddRange(New Object() {"One time", "Weekly", "Monthly", "Yearly"})
        cbTimeRange.Location = New Point(191, 334)
        cbTimeRange.Name = "cbTimeRange"
        cbTimeRange.Size = New Size(210, 33)
        cbTimeRange.TabIndex = 5
        ' 
        ' lbStartDate
        ' 
        lbStartDate.AutoSize = True
        lbStartDate.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbStartDate.Location = New Point(22, 414)
        lbStartDate.Name = "lbStartDate"
        lbStartDate.Size = New Size(97, 25)
        lbStartDate.TabIndex = 6
        lbStartDate.Text = "Start date"
        ' 
        ' txtStartDate
        ' 
        txtStartDate.Location = New Point(191, 411)
        txtStartDate.Name = "txtStartDate"
        txtStartDate.Size = New Size(210, 31)
        txtStartDate.TabIndex = 7
        ' 
        ' lbEndDate
        ' 
        lbEndDate.AutoSize = True
        lbEndDate.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbEndDate.Location = New Point(33, 499)
        lbEndDate.Name = "lbEndDate"
        lbEndDate.Size = New Size(87, 25)
        lbEndDate.TabIndex = 8
        lbEndDate.Text = "End date"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(191, 496)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(210, 31)
        TextBox1.TabIndex = 9
        ' 
        ' lbChooseWallet
        ' 
        lbChooseWallet.AutoSize = True
        lbChooseWallet.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbChooseWallet.Location = New Point(22, 262)
        lbChooseWallet.Name = "lbChooseWallet"
        lbChooseWallet.Size = New Size(130, 25)
        lbChooseWallet.TabIndex = 10
        lbChooseWallet.Text = "Choose wallet"
        ' 
        ' cbChooseWalllet
        ' 
        cbChooseWalllet.FormattingEnabled = True
        cbChooseWalllet.Location = New Point(191, 259)
        cbChooseWalllet.Name = "cbChooseWalllet"
        cbChooseWalllet.Size = New Size(210, 33)
        cbChooseWalllet.TabIndex = 11
        ' 
        ' btnGoBackHome
        ' 
        btnGoBackHome.Location = New Point(33, 596)
        btnGoBackHome.Name = "btnGoBackHome"
        btnGoBackHome.Size = New Size(106, 47)
        btnGoBackHome.TabIndex = 12
        btnGoBackHome.Text = "GO BACK"
        btnGoBackHome.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(703, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(130, 28)
        Label1.TabIndex = 13
        Label1.Text = "CATEGORIES"
        ' 
        ' btnSaveNewBudget
        ' 
        btnSaveNewBudget.Location = New Point(879, 596)
        btnSaveNewBudget.Name = "btnSaveNewBudget"
        btnSaveNewBudget.Size = New Size(136, 47)
        btnSaveNewBudget.TabIndex = 18
        btnSaveNewBudget.Text = "SAVE BUDGET"
        btnSaveNewBudget.UseVisualStyleBackColor = True
        ' 
        ' clbBasics
        ' 
        clbBasics.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        clbBasics.FormattingEnabled = True
        clbBasics.Items.AddRange(New Object() {"Food & Drinks", "Bill", "Transport", "House Rent", "Fix & Maintenance", "Utilities", "Groceries"})
        clbBasics.Location = New Point(513, 115)
        clbBasics.Name = "clbBasics"
        clbBasics.Size = New Size(236, 221)
        clbBasics.TabIndex = 0
        ' 
        ' lbBasics
        ' 
        lbBasics.AutoSize = True
        lbBasics.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbBasics.Location = New Point(513, 76)
        lbBasics.Name = "lbBasics"
        lbBasics.Size = New Size(64, 25)
        lbBasics.TabIndex = 19
        lbBasics.Text = "Basics"
        ' 
        ' clbEnjoyments
        ' 
        clbEnjoyments.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        clbEnjoyments.FormattingEnabled = True
        clbEnjoyments.Items.AddRange(New Object() {"Entertainment", "Fashion", "Travel", "Beauty Care", "Party", "Gift", "Donation"})
        clbEnjoyments.Location = New Point(847, 115)
        clbEnjoyments.Name = "clbEnjoyments"
        clbEnjoyments.Size = New Size(198, 221)
        clbEnjoyments.TabIndex = 20
        ' 
        ' clbHealthCare
        ' 
        clbHealthCare.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        clbHealthCare.FormattingEnabled = True
        clbHealthCare.Items.AddRange(New Object() {"Doctor", "Sport", "Insurance", "Gym Membership"})
        clbHealthCare.Location = New Point(513, 399)
        clbHealthCare.Name = "clbHealthCare"
        clbHealthCare.Size = New Size(236, 128)
        clbHealthCare.TabIndex = 21
        ' 
        ' clbOtherExpenses
        ' 
        clbOtherExpenses.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        clbOtherExpenses.FormattingEnabled = True
        clbOtherExpenses.Items.AddRange(New Object() {"Fee & charge", "Investments", "Kids", "Other"})
        clbOtherExpenses.Location = New Point(847, 399)
        clbOtherExpenses.Name = "clbOtherExpenses"
        clbOtherExpenses.Size = New Size(198, 128)
        clbOtherExpenses.TabIndex = 22
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(847, 76)
        Label3.Name = "Label3"
        Label3.Size = New Size(149, 25)
        Label3.TabIndex = 23
        Label3.Text = "Enjoyment/Give"
        ' 
        ' lbHealthCare
        ' 
        lbHealthCare.AutoSize = True
        lbHealthCare.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbHealthCare.Location = New Point(513, 359)
        lbHealthCare.Name = "lbHealthCare"
        lbHealthCare.Size = New Size(112, 25)
        lbHealthCare.TabIndex = 24
        lbHealthCare.Text = "Health Care"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(847, 359)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 25)
        Label2.TabIndex = 25
        Label2.Text = "Other expenses"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(116, 40)
        Label4.Name = "Label4"
        Label4.Size = New Size(198, 25)
        Label4.TabIndex = 26
        Label4.Text = "BASIC INFORMATION"
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1084, 680)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(lbHealthCare)
        Controls.Add(Label3)
        Controls.Add(clbOtherExpenses)
        Controls.Add(clbHealthCare)
        Controls.Add(clbEnjoyments)
        Controls.Add(lbBasics)
        Controls.Add(clbBasics)
        Controls.Add(btnSaveNewBudget)
        Controls.Add(Label1)
        Controls.Add(btnGoBackHome)
        Controls.Add(cbChooseWalllet)
        Controls.Add(lbChooseWallet)
        Controls.Add(TextBox1)
        Controls.Add(lbEndDate)
        Controls.Add(txtStartDate)
        Controls.Add(lbStartDate)
        Controls.Add(cbTimeRange)
        Controls.Add(lbTimeRange)
        Controls.Add(txtBudgetAmount)
        Controls.Add(lbAmount)
        Controls.Add(txtEnterBudgetName)
        Controls.Add(lbBudgetName)
        Name = "Form5"
        Text = " Add New Budget Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbBudgetName As Label
    Friend WithEvents txtEnterBudgetName As TextBox
    Friend WithEvents lbAmount As Label
    Friend WithEvents txtBudgetAmount As TextBox
    Friend WithEvents lbTimeRange As Label
    Friend WithEvents cbTimeRange As ComboBox
    Friend WithEvents lbStartDate As Label
    Friend WithEvents txtStartDate As TextBox
    Friend WithEvents lbEndDate As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lbChooseWallet As Label
    Friend WithEvents cbChooseWalllet As ComboBox
    Friend WithEvents btnGoBackHome As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents gbEnjoyment As GroupBox
    Friend WithEvents gbHealthCare As GroupBox
    Friend WithEvents gbOther As GroupBox
    Friend WithEvents btnSaveNewBudget As Button
    Friend WithEvents clbBasics As CheckedListBox
    Friend WithEvents lbBasics As Label
    Friend WithEvents clbEnjoyments As CheckedListBox
    Friend WithEvents clbHealthCare As CheckedListBox
    Friend WithEvents clbOtherExpenses As CheckedListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbHealthCare As Label
    Friend WithEvents gbBasics As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
End Class
