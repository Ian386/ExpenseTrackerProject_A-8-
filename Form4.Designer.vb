<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        btnHome = New Button()
        btnBudget = New Button()
        btnReports = New Button()
        btnHelp = New Button()
        btnWallet = New Button()
        btnTransaction = New Button()
        lblGreeting = New Label()
        btnClose = New Button()
        SuspendLayout()
        ' 
        ' btnHome
        ' 
        btnHome.ForeColor = SystemColors.ButtonHighlight
        btnHome.Image = My.Resources.Resources.download
        btnHome.Location = New Point(13, 449)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(112, 41)
        btnHome.TabIndex = 0
        btnHome.Text = "Home"
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' btnBudget
        ' 
        btnBudget.ForeColor = SystemColors.ButtonHighlight
        btnBudget.Image = My.Resources.Resources.download
        btnBudget.Location = New Point(157, 449)
        btnBudget.Name = "btnBudget"
        btnBudget.Size = New Size(112, 41)
        btnBudget.TabIndex = 1
        btnBudget.Text = "Budget"
        btnBudget.UseVisualStyleBackColor = True
        ' 
        ' btnReports
        ' 
        btnReports.ForeColor = SystemColors.ButtonHighlight
        btnReports.Image = My.Resources.Resources.download
        btnReports.Location = New Point(304, 449)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(112, 41)
        btnReports.TabIndex = 2
        btnReports.Text = "Reports"
        btnReports.UseVisualStyleBackColor = True
        ' 
        ' btnHelp
        ' 
        btnHelp.ForeColor = SystemColors.ButtonHighlight
        btnHelp.Image = My.Resources.Resources.download
        btnHelp.Location = New Point(451, 449)
        btnHelp.Name = "btnHelp"
        btnHelp.Size = New Size(112, 41)
        btnHelp.TabIndex = 3
        btnHelp.Text = "Help"
        btnHelp.UseVisualStyleBackColor = True
        ' 
        ' btnWallet
        ' 
        btnWallet.BackColor = SystemColors.ButtonHighlight
        btnWallet.BackgroundImage = My.Resources.Resources.download
        btnWallet.BackgroundImageLayout = ImageLayout.None
        btnWallet.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnWallet.ForeColor = SystemColors.ButtonHighlight
        btnWallet.Location = New Point(37, 168)
        btnWallet.Name = "btnWallet"
        btnWallet.Size = New Size(163, 76)
        btnWallet.TabIndex = 4
        btnWallet.Text = "Create New Wallet"
        btnWallet.UseVisualStyleBackColor = False
        ' 
        ' btnTransaction
        ' 
        btnTransaction.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTransaction.ForeColor = SystemColors.ButtonHighlight
        btnTransaction.Image = My.Resources.Resources.download
        btnTransaction.Location = New Point(370, 168)
        btnTransaction.Name = "btnTransaction"
        btnTransaction.Size = New Size(164, 76)
        btnTransaction.TabIndex = 5
        btnTransaction.Text = "+ Add Transaction"
        btnTransaction.UseVisualStyleBackColor = True
        ' 
        ' lblGreeting
        ' 
        lblGreeting.AutoSize = True
        lblGreeting.BackColor = Color.Transparent
        lblGreeting.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGreeting.ForeColor = SystemColors.ControlLightLight
        lblGreeting.Location = New Point(42, 46)
        lblGreeting.Name = "lblGreeting"
        lblGreeting.Size = New Size(88, 32)
        lblGreeting.TabIndex = 6
        lblGreeting.Text = "Label1"
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Red
        btnClose.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = SystemColors.Control
        btnClose.Location = New Point(474, 41)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(60, 43)
        btnClose.TabIndex = 8
        btnClose.Text = "Exit"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.download
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(587, 547)
        ControlBox = False
        Controls.Add(btnClose)
        Controls.Add(lblGreeting)
        Controls.Add(btnTransaction)
        Controls.Add(btnWallet)
        Controls.Add(btnHelp)
        Controls.Add(btnReports)
        Controls.Add(btnBudget)
        Controls.Add(btnHome)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Form4"
        Text = "Expense Tracker"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnHome As Button
    Friend WithEvents btnBudget As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents btnWallet As Button
    Friend WithEvents btnTransaction As Button
    Friend WithEvents lblGreeting As Label
    Friend WithEvents btnClose As Button
End Class
