<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        comboBoxBudget = New ComboBox()
        lblBudget = New Label()
        lblCategory = New Label()
        comboBoxCategory = New ComboBox()
        lblAmount = New Label()
        txtAmount = New TextBox()
        btnSave = New Button()
        btnClose = New Button()
        btnHome = New Button()
        SuspendLayout()
        ' 
        ' comboBoxBudget
        ' 
        comboBoxBudget.DropDownStyle = ComboBoxStyle.DropDownList
        comboBoxBudget.FormattingEnabled = True
        comboBoxBudget.Location = New Point(184, 91)
        comboBoxBudget.Name = "comboBoxBudget"
        comboBoxBudget.Size = New Size(182, 33)
        comboBoxBudget.TabIndex = 0
        ' 
        ' lblBudget
        ' 
        lblBudget.AutoSize = True
        lblBudget.Location = New Point(37, 88)
        lblBudget.Name = "lblBudget"
        lblBudget.Size = New Size(120, 25)
        lblBudget.TabIndex = 1
        lblBudget.Text = "Select Budget"
        ' 
        ' lblCategory
        ' 
        lblCategory.AutoSize = True
        lblCategory.Location = New Point(37, 159)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(84, 25)
        lblCategory.TabIndex = 2
        lblCategory.Text = "Category"
        ' 
        ' comboBoxCategory
        ' 
        comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList
        comboBoxCategory.FormattingEnabled = True
        comboBoxCategory.Location = New Point(184, 157)
        comboBoxCategory.Name = "comboBoxCategory"
        comboBoxCategory.Size = New Size(182, 33)
        comboBoxCategory.TabIndex = 3
        ' 
        ' lblAmount
        ' 
        lblAmount.AutoSize = True
        lblAmount.Location = New Point(37, 240)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New Size(77, 25)
        lblAmount.TabIndex = 4
        lblAmount.Text = "Amount"
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(184, 240)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(182, 31)
        txtAmount.TabIndex = 5
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = SystemColors.ActiveCaption
        btnSave.BackgroundImage = My.Resources.Resources.download
        btnSave.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = SystemColors.ButtonHighlight
        btnSave.Location = New Point(404, 231)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(112, 43)
        btnSave.TabIndex = 6
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(335, 344)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(112, 34)
        btnClose.TabIndex = 7
        btnClose.Text = "Exit"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnHome
        ' 
        btnHome.Location = New Point(86, 344)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(112, 34)
        btnHome.TabIndex = 8
        btnHome.Text = "Go Back"
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(549, 433)
        Controls.Add(btnHome)
        Controls.Add(btnClose)
        Controls.Add(btnSave)
        Controls.Add(txtAmount)
        Controls.Add(lblAmount)
        Controls.Add(comboBoxCategory)
        Controls.Add(lblCategory)
        Controls.Add(lblBudget)
        Controls.Add(comboBoxBudget)
        Name = "Form8"
        Text = "Form8"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents comboBoxBudget As ComboBox
    Friend WithEvents lblBudget As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents comboBoxCategory As ComboBox
    Friend WithEvents lblAmount As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnHome As Button
End Class
