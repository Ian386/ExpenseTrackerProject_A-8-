<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        lblName = New Label()
        txtName = New TextBox()
        lblCurrency = New Label()
        ComboBoxCurrency = New ComboBox()
        lblAmount = New Label()
        txtAmount = New TextBox()
        btnSave = New Button()
        bthHome = New Button()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(28, 52)
        lblName.Name = "lblName"
        lblName.Size = New Size(39, 15)
        lblName.TabIndex = 0
        lblName.Text = "Name"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(95, 44)
        txtName.Name = "txtName"
        txtName.Size = New Size(187, 23)
        txtName.TabIndex = 1
        ' 
        ' lblCurrency
        ' 
        lblCurrency.AutoSize = True
        lblCurrency.Location = New Point(26, 96)
        lblCurrency.Name = "lblCurrency"
        lblCurrency.Size = New Size(55, 15)
        lblCurrency.TabIndex = 2
        lblCurrency.Text = "Currency"
        ' 
        ' ComboBoxCurrency
        ' 
        ComboBoxCurrency.FormattingEnabled = True
        ComboBoxCurrency.Location = New Point(95, 88)
        ComboBoxCurrency.Name = "ComboBoxCurrency"
        ComboBoxCurrency.Size = New Size(187, 23)
        ComboBoxCurrency.TabIndex = 3
        ' 
        ' lblAmount
        ' 
        lblAmount.AutoSize = True
        lblAmount.Location = New Point(31, 143)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New Size(51, 15)
        lblAmount.TabIndex = 4
        lblAmount.Text = "Amount"
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(95, 135)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(187, 23)
        txtAmount.TabIndex = 5
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(95, 289)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 6
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' bthHome
        ' 
        bthHome.Location = New Point(567, 279)
        bthHome.Name = "bthHome"
        bthHome.Size = New Size(75, 23)
        bthHome.TabIndex = 7
        bthHome.Text = "Home"
        bthHome.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(bthHome)
        Controls.Add(btnSave)
        Controls.Add(txtAmount)
        Controls.Add(lblAmount)
        Controls.Add(ComboBoxCurrency)
        Controls.Add(lblCurrency)
        Controls.Add(txtName)
        Controls.Add(lblName)
        Name = "Form3"
        Text = "Wallet"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblCurrency As Label
    Friend WithEvents ComboBoxCurrency As ComboBox
    Friend WithEvents lblAmount As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents bthHome As Button
End Class
