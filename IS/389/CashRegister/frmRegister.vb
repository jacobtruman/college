Public Class frmRegister
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnPOCancel As System.Windows.Forms.Button
    Friend WithEvents btnDCode As System.Windows.Forms.Button
    Friend WithEvents btnMulItem As System.Windows.Forms.Button
    Friend WithEvents btnOne As System.Windows.Forms.Button
    Friend WithEvents btnFive As System.Windows.Forms.Button
    Friend WithEvents btnFour As System.Windows.Forms.Button
    Friend WithEvents btnThree As System.Windows.Forms.Button
    Friend WithEvents btnTwo As System.Windows.Forms.Button
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnEight As System.Windows.Forms.Button
    Friend WithEvents btnSeven As System.Windows.Forms.Button
    Friend WithEvents btnZero As System.Windows.Forms.Button
    Friend WithEvents btnNine As System.Windows.Forms.Button
    Friend WithEvents btnSix As System.Windows.Forms.Button
    Friend WithEvents btnDecimal As System.Windows.Forms.Button
    Friend WithEvents btnDblZero As System.Windows.Forms.Button
    Friend WithEvents lblNoUseBG As System.Windows.Forms.Label
    Friend WithEvents lblKPMsg As System.Windows.Forms.Label
    Friend WithEvents lblErrMsg As System.Windows.Forms.Label
    Friend WithEvents btnScan As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lboxItemName As System.Windows.Forms.ListBox
    Friend WithEvents lboxItemAmt As System.Windows.Forms.ListBox
    Friend WithEvents btnDuplicate As System.Windows.Forms.Button
    Friend WithEvents gboxPO As System.Windows.Forms.GroupBox
    Friend WithEvents gboxRR As System.Windows.Forms.GroupBox
    Friend WithEvents gboxKP As System.Windows.Forms.GroupBox
    Friend WithEvents gboxMsg As System.Windows.Forms.GroupBox
    Friend WithEvents btnPay As System.Windows.Forms.Button
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents btnCash As System.Windows.Forms.Button
    Friend WithEvents btnCard As System.Windows.Forms.Button
    Friend WithEvents btnFinish As System.Windows.Forms.Button
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents btnScanCard As System.Windows.Forms.Button
    Friend WithEvents lblScanCode As System.Windows.Forms.Label
    Friend WithEvents btnWeight As System.Windows.Forms.Button
    Friend WithEvents lblAmt As System.Windows.Forms.Label
    Friend WithEvents lblRTotal As System.Windows.Forms.Label
    Friend WithEvents btnDeleteAll As System.Windows.Forms.Button
    Friend WithEvents gboxCover As System.Windows.Forms.GroupBox
    Friend WithEvents lboxItemNum As System.Windows.Forms.ListBox
    Friend WithEvents lboxItemPrice As System.Windows.Forms.ListBox
    Friend WithEvents lboxItemLinePrice As System.Windows.Forms.ListBox
    Friend WithEvents btnManEnt As System.Windows.Forms.Button
    Friend WithEvents btnOverride As System.Windows.Forms.Button
    Friend WithEvents MulItem As System.Windows.Forms.Button
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents lblSubTotalTitle As System.Windows.Forms.Label
    Friend WithEvents lblTaxTitle As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblTotalTitle As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lblBalance As System.Windows.Forms.Label
    Friend WithEvents lblReceipt As System.Windows.Forms.Label
    Friend WithEvents lblReceiptTotals As System.Windows.Forms.Label
    Friend WithEvents gboxReceipt As System.Windows.Forms.GroupBox
    Friend WithEvents lboxReceiptTotal As System.Windows.Forms.ListBox
    Friend WithEvents lboxReceiptLinePrice As System.Windows.Forms.ListBox
    Friend WithEvents lboxReceiptAmt As System.Windows.Forms.ListBox
    Friend WithEvents lboxReceiptName As System.Windows.Forms.ListBox
    Friend WithEvents lboxReceiptPrice As System.Windows.Forms.ListBox
    Friend WithEvents lboxDiscounts As System.Windows.Forms.ListBox
    Friend WithEvents btnReceiptClose As System.Windows.Forms.Button
    Friend WithEvents gboxSearch As System.Windows.Forms.GroupBox
    Friend WithEvents lboxResults As System.Windows.Forms.ListBox
    Friend WithEvents btnPharmacy As System.Windows.Forms.Button
    Friend WithEvents btnToys As System.Windows.Forms.Button
    Friend WithEvents btnCanned As System.Windows.Forms.Button
    Friend WithEvents btnMeat As System.Windows.Forms.Button
    Friend WithEvents btnDairy As System.Windows.Forms.Button
    Friend WithEvents btnHygene As System.Windows.Forms.Button
    Friend WithEvents btnCleaning As System.Windows.Forms.Button
    Friend WithEvents btnDeli As System.Windows.Forms.Button
    Friend WithEvents btnBreakfast As System.Windows.Forms.Button
    Friend WithEvents btnCandy As System.Windows.Forms.Button
    Friend WithEvents btnFrozen As System.Windows.Forms.Button
    Friend WithEvents btnProduce As System.Windows.Forms.Button
    Friend WithEvents btnSrchcancel As System.Windows.Forms.Button
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents tmrOne As System.Windows.Forms.Timer
    Friend WithEvents lblTime As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        '
        'Begin Styles
        '
        Dim lboxesColor, lboxesFontColor, btnColor, btnFontColor, frmColor, frmFontColor, lboxesReceiptColor, lboxesReceiptFontColor, btnReceiptColor, btnReceiptFontColor
        lboxesFontColor = System.Drawing.Color.Black
        lboxesColor = System.Drawing.Color.PaleGreen
        btnColor = System.Drawing.Color.Teal
        btnFontColor = System.Drawing.Color.White
        frmColor = System.Drawing.Color.PaleTurquoise
        frmFontColor = System.Drawing.Color.Black
        lboxesReceiptColor = System.Drawing.Color.White
        lboxesReceiptFontColor = System.Drawing.Color.Black
        btnReceiptColor = System.Drawing.Color.Gray
        btnReceiptFontColor = System.Drawing.Color.Black
        '
        'End Styles
        '
        Me.components = New System.ComponentModel.Container
        Me.tmrOne = New System.Windows.Forms.Timer(Me.components)
        Me.btnLogout = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnPOCancel = New System.Windows.Forms.Button
        Me.btnDCode = New System.Windows.Forms.Button
        Me.btnMulItem = New System.Windows.Forms.Button
        Me.gboxPO = New System.Windows.Forms.GroupBox
        Me.lblAmt = New System.Windows.Forms.Label
        Me.btnPay = New System.Windows.Forms.Button
        Me.btnCheck = New System.Windows.Forms.Button
        Me.btnCash = New System.Windows.Forms.Button
        Me.btnCard = New System.Windows.Forms.Button
        Me.gboxRR = New System.Windows.Forms.GroupBox
        Me.btnOverride = New System.Windows.Forms.Button
        Me.lboxItemPrice = New System.Windows.Forms.ListBox
        Me.btnDeleteAll = New System.Windows.Forms.Button
        Me.lblRTotal = New System.Windows.Forms.Label
        Me.lboxItemLinePrice = New System.Windows.Forms.ListBox
        Me.lboxItemAmt = New System.Windows.Forms.ListBox
        Me.lboxItemName = New System.Windows.Forms.ListBox
        Me.btnDuplicate = New System.Windows.Forms.Button
        Me.btnFinish = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnWeight = New System.Windows.Forms.Button
        Me.btnManEnt = New System.Windows.Forms.Button
        Me.btnScan = New System.Windows.Forms.Button
        Me.gboxKP = New System.Windows.Forms.GroupBox
        Me.btnEnter = New System.Windows.Forms.Button
        Me.btnReset = New System.Windows.Forms.Button
        Me.btnEight = New System.Windows.Forms.Button
        Me.btnFive = New System.Windows.Forms.Button
        Me.btnSeven = New System.Windows.Forms.Button
        Me.btnZero = New System.Windows.Forms.Button
        Me.btnFour = New System.Windows.Forms.Button
        Me.btnNine = New System.Windows.Forms.Button
        Me.btnThree = New System.Windows.Forms.Button
        Me.btnTwo = New System.Windows.Forms.Button
        Me.btnOne = New System.Windows.Forms.Button
        Me.btnSix = New System.Windows.Forms.Button
        Me.btnDecimal = New System.Windows.Forms.Button
        Me.btnDblZero = New System.Windows.Forms.Button
        Me.lblErrMsg = New System.Windows.Forms.Label
        Me.lblKPMsg = New System.Windows.Forms.Label
        Me.gboxMsg = New System.Windows.Forms.GroupBox
        Me.lblMsg = New System.Windows.Forms.Label
        Me.btnScanCard = New System.Windows.Forms.Button
        Me.lblScanCode = New System.Windows.Forms.Label
        Me.lblNoUseBG = New System.Windows.Forms.Label
        Me.gboxCover = New System.Windows.Forms.GroupBox
        Me.lboxItemNum = New System.Windows.Forms.ListBox
        Me.lblTotalTitle = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.lblTaxTitle = New System.Windows.Forms.Label
        Me.lblTax = New System.Windows.Forms.Label
        Me.lblSubTotalTitle = New System.Windows.Forms.Label
        Me.lblSubTotal = New System.Windows.Forms.Label
        Me.lblUser = New System.Windows.Forms.Label
        Me.lblBalance = New System.Windows.Forms.Label
        Me.lblReceipt = New System.Windows.Forms.Label
        Me.lblReceiptTotals = New System.Windows.Forms.Label
        Me.gboxReceipt = New System.Windows.Forms.GroupBox
        Me.lboxReceiptTotal = New System.Windows.Forms.ListBox
        Me.lboxReceiptPrice = New System.Windows.Forms.ListBox
        Me.lboxReceiptLinePrice = New System.Windows.Forms.ListBox
        Me.lboxReceiptAmt = New System.Windows.Forms.ListBox
        Me.lboxReceiptName = New System.Windows.Forms.ListBox
        Me.lboxDiscounts = New System.Windows.Forms.ListBox
        Me.btnReceiptClose = New System.Windows.Forms.Button
        Me.gboxSearch = New System.Windows.Forms.GroupBox
        Me.lboxResults = New System.Windows.Forms.ListBox
        Me.btnPharmacy = New System.Windows.Forms.Button
        Me.btnToys = New System.Windows.Forms.Button
        Me.btnCanned = New System.Windows.Forms.Button
        Me.btnMeat = New System.Windows.Forms.Button
        Me.btnDairy = New System.Windows.Forms.Button
        Me.btnHygene = New System.Windows.Forms.Button
        Me.btnCleaning = New System.Windows.Forms.Button
        Me.btnDeli = New System.Windows.Forms.Button
        Me.btnBreakfast = New System.Windows.Forms.Button
        Me.btnCandy = New System.Windows.Forms.Button
        Me.btnFrozen = New System.Windows.Forms.Button
        Me.btnProduce = New System.Windows.Forms.Button
        Me.btnSrchcancel = New System.Windows.Forms.Button
        Me.btnSelect = New System.Windows.Forms.Button
        Me.lblTime = New System.Windows.Forms.Label
        Me.gboxSearch.SuspendLayout()
        Me.gboxPO.SuspendLayout()
        Me.gboxRR.SuspendLayout()
        Me.gboxKP.SuspendLayout()
        Me.gboxMsg.SuspendLayout()
        Me.gboxReceipt.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrOne
        '
        Me.tmrOne.Enabled = True
        '
        'frmRegister
        '
        Me.Controls.Add(Me.lblTime)
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.Add(Me.lboxItemNum)
        Me.Controls.Add(Me.gboxCover)
        Me.Controls.Add(Me.lblScanCode)
        Me.Controls.Add(Me.btnScanCard)
        Me.Controls.Add(Me.gboxPO)
        Me.Controls.Add(Me.btnScan)
        Me.Controls.Add(Me.gboxKP)
        Me.Controls.Add(Me.gboxMsg)
        Me.Controls.Add(Me.lblNoUseBG)
        Me.Controls.Add(Me.gboxRR)
        Me.Controls.Add(Me.gboxReceipt)
        Me.Controls.Add(Me.gboxSearch)
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frmRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Register"
        Me.gboxPO.ResumeLayout(False)
        Me.gboxRR.ResumeLayout(False)
        Me.gboxKP.ResumeLayout(False)
        Me.gboxMsg.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.ForeColor = frmFontColor
        Me.BackColor = frmColor
        '
        'gboxMsg
        '
        Me.gboxMsg.Controls.Add(Me.btnLogout)
        Me.gboxMsg.Controls.Add(Me.lblTotalTitle)
        Me.gboxMsg.Controls.Add(Me.lblTotal)
        Me.gboxMsg.Controls.Add(Me.lblTaxTitle)
        Me.gboxMsg.Controls.Add(Me.lblTax)
        Me.gboxMsg.Controls.Add(Me.lblSubTotalTitle)
        Me.gboxMsg.Controls.Add(Me.lblSubTotal)
        Me.gboxMsg.Controls.Add(Me.lblUser)
        Me.gboxMsg.Location = New System.Drawing.Point(480, 400)
        Me.gboxMsg.Name = "gboxMsg"
        Me.gboxMsg.Size = New System.Drawing.Size(304, 112)
        Me.gboxMsg.TabIndex = 57
        Me.gboxMsg.TabStop = False
        Me.gboxMsg.Text = "Message"
        '
        'gboxCover
        '
        Me.gboxCover.Location = New System.Drawing.Point(0, 800)
        Me.gboxCover.Name = "gboxCover"
        Me.gboxCover.Size = New System.Drawing.Size(0, 0)
        Me.gboxCover.TabIndex = 47
        Me.gboxCover.TabStop = False
        '
        'gboxKP
        '
        Me.gboxKP.Controls.Add(Me.btnEnter)
        Me.gboxKP.Controls.Add(Me.btnSearch)
        Me.gboxKP.Controls.Add(Me.btnCancel)
        Me.gboxKP.Controls.Add(Me.btnMulItem)
        Me.gboxKP.Controls.Add(Me.btnReset)
        Me.gboxKP.Controls.Add(Me.btnEight)
        Me.gboxKP.Controls.Add(Me.btnFive)
        Me.gboxKP.Controls.Add(Me.btnSeven)
        Me.gboxKP.Controls.Add(Me.btnZero)
        Me.gboxKP.Controls.Add(Me.btnFour)
        Me.gboxKP.Controls.Add(Me.btnNine)
        Me.gboxKP.Controls.Add(Me.btnThree)
        Me.gboxKP.Controls.Add(Me.btnTwo)
        Me.gboxKP.Controls.Add(Me.btnOne)
        Me.gboxKP.Controls.Add(Me.btnSix)
        Me.gboxKP.Controls.Add(Me.btnDecimal)
        Me.gboxKP.Controls.Add(Me.btnDblZero)
        Me.gboxKP.Controls.Add(Me.lblErrMsg)
        Me.gboxKP.Controls.Add(Me.lblKPMsg)
        Me.gboxKP.Location = New System.Drawing.Point(0, 0)
        Me.gboxKP.Name = "gboxKP"
        Me.gboxKP.Size = New System.Drawing.Size(0, 0)
        Me.gboxKP.TabIndex = 56
        Me.gboxKP.TabStop = False
        Me.gboxKP.Text = "Keypad"
        '
        'gboxRR
        '
        Me.gboxRR.Controls.Add(Me.btnOverride)
        Me.gboxRR.Controls.Add(Me.lboxItemPrice)
        Me.gboxRR.Controls.Add(Me.btnDeleteAll)
        Me.gboxRR.Controls.Add(Me.lblRTotal)
        Me.gboxRR.Controls.Add(Me.lboxItemLinePrice)
        Me.gboxRR.Controls.Add(Me.lboxItemAmt)
        Me.gboxRR.Controls.Add(Me.lboxItemName)
        Me.gboxRR.Controls.Add(Me.btnDuplicate)
        Me.gboxRR.Controls.Add(Me.btnFinish)
        Me.gboxRR.Controls.Add(Me.btnDelete)
        Me.gboxRR.Controls.Add(Me.btnWeight)
        Me.gboxRR.Controls.Add(Me.btnManEnt)
        Me.gboxRR.Location = New System.Drawing.Point(0, 0)
        Me.gboxRR.Name = "gboxRR"
        Me.gboxRR.Size = New System.Drawing.Size(784, 392)
        Me.gboxRR.TabIndex = 53
        Me.gboxRR.TabStop = False
        Me.gboxRR.Text = "Running Reciept"
        '
        'gboxReceipt
        '
        Me.gboxReceipt.BackColor = lboxesReceiptColor
        Me.gboxReceipt.Controls.Add(Me.lboxReceiptPrice)
        Me.gboxReceipt.Controls.Add(Me.lblReceipt)
        Me.gboxReceipt.Controls.Add(Me.lblReceiptTotals)
        Me.gboxReceipt.Controls.Add(Me.lboxReceiptTotal)
        Me.gboxReceipt.Controls.Add(Me.lboxReceiptLinePrice)
        Me.gboxReceipt.Controls.Add(Me.lboxReceiptAmt)
        Me.gboxReceipt.Controls.Add(Me.lboxReceiptName)
        Me.gboxReceipt.Controls.Add(Me.btnReceiptClose)
        Me.gboxReceipt.Location = New System.Drawing.Point(0, 0)
        Me.gboxReceipt.Name = "gboxReceipt"
        Me.gboxReceipt.Size = New System.Drawing.Size(0, 0)
        Me.gboxReceipt.TabIndex = 53
        Me.gboxReceipt.TabStop = False
        Me.gboxReceipt.Text = "Reciept"
        '
        'gboxPO
        '
        Me.gboxPO.Controls.Add(Me.lblAmt)
        Me.gboxPO.Controls.Add(Me.btnPOCancel)
        Me.gboxPO.Controls.Add(Me.btnDCode)
        Me.gboxPO.Controls.Add(Me.btnPay)
        Me.gboxPO.Controls.Add(Me.btnCheck)
        Me.gboxPO.Controls.Add(Me.btnCash)
        Me.gboxPO.Controls.Add(Me.btnCard)
        Me.gboxPO.Controls.Add(Me.lblBalance)
        Me.gboxPO.Location = New System.Drawing.Point(0, 0)
        Me.gboxPO.Name = "gboxPO"
        Me.gboxPO.Size = New System.Drawing.Size(0, 0)
        Me.gboxPO.TabIndex = 58
        Me.gboxPO.TabStop = False
        Me.gboxPO.Text = "Payment Options"
        '
        'btnLogout
        '
        Me.btnLogout.ForeColor = btnFontColor
        Me.btnLogout.BackColor = btnColor
        Me.btnLogout.Location = New System.Drawing.Point(216, 64)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(80, 40)
        Me.btnLogout.TabIndex = 59
        Me.btnLogout.Text = "Logout"
        '
        'btnSearch
        '
        Me.btnSearch.ForeColor = btnFontColor
        Me.btnSearch.BackColor = btnColor
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(208, 240)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(50, 50)
        Me.btnSearch.TabIndex = 59
        Me.btnSearch.Text = "Search"
        '
        'btnCancel
        '
        Me.btnCancel.ForeColor = btnFontColor
        Me.btnCancel.BackColor = btnColor
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(64, 240)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(50, 50)
        Me.btnCancel.TabIndex = 59
        Me.btnCancel.Text = "Cancel"
        '
        'btnPOCancel
        '
        Me.btnPOCancel.ForeColor = btnFontColor
        Me.btnPOCancel.BackColor = btnColor
        Me.btnPOCancel.Location = New System.Drawing.Point(392, 16)
        Me.btnPOCancel.Name = "btnPOCancel"
        Me.btnPOCancel.Size = New System.Drawing.Size(72, 40)
        Me.btnPOCancel.TabIndex = 59
        Me.btnPOCancel.Text = "Cancel"
        '
        'btnDCode
        '
        Me.btnDCode.ForeColor = btnFontColor
        Me.btnDCode.BackColor = btnColor
        Me.btnDCode.Location = New System.Drawing.Point(275, 16)
        Me.btnDCode.Name = "btnDCode"
        Me.btnDCode.Size = New System.Drawing.Size(100, 40)
        Me.btnDCode.TabIndex = 59
        Me.btnDCode.Text = "Coupon/Discount Code"
        '
        'btnMulItem
        '
        Me.btnMulItem.ForeColor = btnFontColor
        Me.btnMulItem.BackColor = btnColor
        Me.btnMulItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMulItem.Location = New System.Drawing.Point(0, 0)
        Me.btnMulItem.Name = "btnMulItem"
        Me.btnMulItem.Size = New System.Drawing.Size(0, 0)
        Me.btnMulItem.TabIndex = 60
        Me.btnMulItem.Text = "1/x"
        '
        'btnPay
        '
        Me.btnPay.ForeColor = btnFontColor
        Me.btnPay.BackColor = btnColor
        Me.btnPay.Location = New System.Drawing.Point(392, 64)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(72, 40)
        Me.btnPay.TabIndex = 3
        Me.btnPay.Text = "Submit Payment"
        '
        'btnCheck
        '
        Me.btnCheck.ForeColor = btnFontColor
        Me.btnCheck.BackColor = btnColor
        Me.btnCheck.Location = New System.Drawing.Point(88, 16)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(88, 40)
        Me.btnCheck.TabIndex = 2
        Me.btnCheck.Text = "Check/Money Order"
        '
        'btnCash
        '
        Me.btnCash.ForeColor = btnFontColor
        Me.btnCash.BackColor = btnColor
        Me.btnCash.Location = New System.Drawing.Point(184, 16)
        Me.btnCash.Name = "btnCash"
        Me.btnCash.Size = New System.Drawing.Size(75, 40)
        Me.btnCash.TabIndex = 1
        Me.btnCash.Text = "Cash"
        '
        'btnCard
        '
        Me.btnCard.ForeColor = btnFontColor
        Me.btnCard.BackColor = btnColor
        Me.btnCard.Location = New System.Drawing.Point(8, 16)
        Me.btnCard.Name = "btnCard"
        Me.btnCard.Size = New System.Drawing.Size(75, 40)
        Me.btnCard.TabIndex = 0
        Me.btnCard.Text = "Credit/Debit"
        '
        'btnOverride
        '
        Me.btnOverride.ForeColor = btnFontColor
        Me.btnOverride.BackColor = btnColor
        Me.btnOverride.Location = New System.Drawing.Point(232, 344)
        Me.btnOverride.Name = "btnOverride"
        Me.btnOverride.Size = New System.Drawing.Size(75, 40)
        Me.btnOverride.TabIndex = 48
        Me.btnOverride.Text = "Price Override"
        '
        'btnDeleteAll
        '
        Me.btnDeleteAll.ForeColor = btnFontColor
        Me.btnDeleteAll.BackColor = btnColor
        Me.btnDeleteAll.Location = New System.Drawing.Point(400, 344)
        Me.btnDeleteAll.Name = "btnDeleteAll"
        Me.btnDeleteAll.Size = New System.Drawing.Size(80, 40)
        Me.btnDeleteAll.TabIndex = 46
        Me.btnDeleteAll.Text = "Delete All"
        '
        'btnDuplicate
        '
        Me.btnDuplicate.ForeColor = btnFontColor
        Me.btnDuplicate.BackColor = btnColor
        Me.btnDuplicate.Location = New System.Drawing.Point(488, 344)
        Me.btnDuplicate.Name = "btnDuplicate"
        Me.btnDuplicate.Size = New System.Drawing.Size(80, 40)
        Me.btnDuplicate.TabIndex = 40
        Me.btnDuplicate.Text = "Duplicate"
        '
        'btnFinish
        '
        Me.btnFinish.ForeColor = btnFontColor
        Me.btnFinish.BackColor = btnColor
        Me.btnFinish.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinish.Location = New System.Drawing.Point(688, 344)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(88, 40)
        Me.btnFinish.TabIndex = 36
        Me.btnFinish.Text = "Checkout"
        '
        'btnDelete
        '
        Me.btnDelete.ForeColor = btnFontColor
        Me.btnDelete.BackColor = btnColor
        Me.btnDelete.Location = New System.Drawing.Point(312, 344)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 40)
        Me.btnDelete.TabIndex = 38
        Me.btnDelete.Text = "Delete"
        '
        'btnWeight
        '
        Me.btnWeight.ForeColor = btnFontColor
        Me.btnWeight.BackColor = btnColor
        Me.btnWeight.Location = New System.Drawing.Point(104, 344)
        Me.btnWeight.Name = "btnWeight"
        Me.btnWeight.Size = New System.Drawing.Size(88, 40)
        Me.btnWeight.TabIndex = 42
        Me.btnWeight.Text = "Weight"
        '
        'btnManEnt
        '
        Me.btnManEnt.ForeColor = btnFontColor
        Me.btnManEnt.BackColor = btnColor
        Me.btnManEnt.Location = New System.Drawing.Point(8, 344)
        Me.btnManEnt.Name = "btnManEnt"
        Me.btnManEnt.Size = New System.Drawing.Size(88, 40)
        Me.btnManEnt.TabIndex = 43
        Me.btnManEnt.Text = "Manual Entry"
        '
        'btnScan
        '
        Me.btnScan.ForeColor = btnFontColor
        Me.btnScan.BackColor = btnColor
        Me.btnScan.Location = New System.Drawing.Point(8, 520)
        Me.btnScan.Name = "btnScan"
        Me.btnScan.Size = New System.Drawing.Size(96, 40)
        Me.btnScan.TabIndex = 54
        Me.btnScan.Text = "Scan"
        '
        'btnScanCard
        '
        Me.btnScanCard.ForeColor = btnFontColor
        Me.btnScanCard.BackColor = btnColor
        Me.btnScanCard.Location = New System.Drawing.Point(272, 520)
        Me.btnScanCard.Name = "btnScanCard"
        Me.btnScanCard.Size = New System.Drawing.Size(75, 40)
        Me.btnScanCard.TabIndex = 60
        Me.btnScanCard.Text = "Scan Card"
        '
        'btnEnter
        '
        Me.btnEnter.ForeColor = btnFontColor
        Me.btnEnter.BackColor = btnColor
        Me.btnEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(120, 240)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(50, 50)
        Me.btnEnter.TabIndex = 43
        Me.btnEnter.Text = "Enter"
        '
        'btnReset
        '
        Me.btnReset.ForeColor = btnFontColor
        Me.btnReset.BackColor = btnColor
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(8, 240)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(50, 50)
        Me.btnReset.TabIndex = 43
        Me.btnReset.Text = "Reset"
        '
        'btnOne
        '
        Me.btnOne.ForeColor = btnFontColor
        Me.btnOne.BackColor = btnColor
        Me.btnOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOne.Location = New System.Drawing.Point(8, 16)
        Me.btnOne.Name = "btnOne"
        Me.btnOne.Size = New System.Drawing.Size(50, 50)
        Me.btnOne.TabIndex = 13
        Me.btnOne.Text = "1"
        '
        'btnTwo
        '
        Me.btnTwo.ForeColor = btnFontColor
        Me.btnTwo.BackColor = btnColor
        Me.btnTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTwo.Location = New System.Drawing.Point(64, 16)
        Me.btnTwo.Name = "btnTwo"
        Me.btnTwo.Size = New System.Drawing.Size(50, 50)
        Me.btnTwo.TabIndex = 12
        Me.btnTwo.Text = "2"
        '
        'btnThree
        '
        Me.btnThree.ForeColor = btnFontColor
        Me.btnThree.BackColor = btnColor
        Me.btnThree.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThree.Location = New System.Drawing.Point(120, 16)
        Me.btnThree.Name = "btnThree"
        Me.btnThree.Size = New System.Drawing.Size(50, 50)
        Me.btnThree.TabIndex = 9
        Me.btnThree.Text = "3"
        '
        'btnFour
        '
        Me.btnFour.ForeColor = btnFontColor
        Me.btnFour.BackColor = btnColor
        Me.btnFour.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFour.Location = New System.Drawing.Point(8, 72)
        Me.btnFour.Name = "btnFour"
        Me.btnFour.Size = New System.Drawing.Size(50, 50)
        Me.btnFour.TabIndex = 11
        Me.btnFour.Text = "4"
        '
        'btnFive
        '
        Me.btnFive.ForeColor = btnFontColor
        Me.btnFive.BackColor = btnColor
        Me.btnFive.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFive.Location = New System.Drawing.Point(64, 72)
        Me.btnFive.Name = "btnFive"
        Me.btnFive.Size = New System.Drawing.Size(50, 50)
        Me.btnFive.TabIndex = 16
        Me.btnFive.Text = "5"
        '
        'btnSix
        '
        Me.btnSix.ForeColor = btnFontColor
        Me.btnSix.BackColor = btnColor
        Me.btnSix.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSix.Location = New System.Drawing.Point(120, 72)
        Me.btnSix.Name = "btnSix"
        Me.btnSix.Size = New System.Drawing.Size(50, 50)
        Me.btnSix.TabIndex = 15
        Me.btnSix.Text = "6"
        '
        'btnSeven
        '
        Me.btnSeven.ForeColor = btnFontColor
        Me.btnSeven.BackColor = btnColor
        Me.btnSeven.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeven.Location = New System.Drawing.Point(8, 128)
        Me.btnSeven.Name = "btnSeven"
        Me.btnSeven.Size = New System.Drawing.Size(50, 50)
        Me.btnSeven.TabIndex = 17
        Me.btnSeven.Text = "7"
        '
        'btnEight
        '
        Me.btnEight.ForeColor = btnFontColor
        Me.btnEight.BackColor = btnColor
        Me.btnEight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEight.Location = New System.Drawing.Point(64, 128)
        Me.btnEight.Name = "btnEight"
        Me.btnEight.Size = New System.Drawing.Size(50, 50)
        Me.btnEight.TabIndex = 14
        Me.btnEight.Text = "8"
        '
        'btnNine
        '
        Me.btnNine.ForeColor = btnFontColor
        Me.btnNine.BackColor = btnColor
        Me.btnNine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNine.Location = New System.Drawing.Point(120, 128)
        Me.btnNine.Name = "btnNine"
        Me.btnNine.Size = New System.Drawing.Size(50, 50)
        Me.btnNine.TabIndex = 10
        Me.btnNine.Text = "9"
        '
        'btnZero
        '
        Me.btnZero.ForeColor = btnFontColor
        Me.btnZero.BackColor = btnColor
        Me.btnZero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZero.Location = New System.Drawing.Point(64, 184)
        Me.btnZero.Name = "btnZero"
        Me.btnZero.Size = New System.Drawing.Size(50, 50)
        Me.btnZero.TabIndex = 18
        Me.btnZero.Text = "0"
        '
        'btnDecimal
        '
        Me.btnDecimal.ForeColor = btnFontColor
        Me.btnDecimal.BackColor = btnColor
        Me.btnDecimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecimal.Location = New System.Drawing.Point(8, 184)
        Me.btnDecimal.Name = "btnDecimal"
        Me.btnDecimal.Size = New System.Drawing.Size(50, 50)
        Me.btnDecimal.TabIndex = 42
        Me.btnDecimal.Text = "."
        '
        'btnDblZero
        '
        Me.btnDblZero.ForeColor = btnFontColor
        Me.btnDblZero.BackColor = btnColor
        Me.btnDblZero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDblZero.Location = New System.Drawing.Point(120, 184)
        Me.btnDblZero.Name = "btnDblZero"
        Me.btnDblZero.Size = New System.Drawing.Size(50, 50)
        Me.btnDblZero.TabIndex = 41
        Me.btnDblZero.Text = ".00"
        '
        'lboxItemPrice
        '
        Me.lboxItemPrice.ForeColor = lboxesFontColor
        Me.lboxItemPrice.BackColor = lboxesColor
        Me.lboxItemPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lboxItemPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboxItemPrice.ItemHeight = 20
        Me.lboxItemPrice.Location = New System.Drawing.Point(600, 16)
        Me.lboxItemPrice.Name = "lboxItemPrice"
        Me.lboxItemPrice.Size = New System.Drawing.Size(88, 320)
        Me.lboxItemPrice.TabIndex = 47
        '
        'lboxItemLinePrice
        '
        Me.lboxItemLinePrice.ForeColor = lboxesFontColor
        Me.lboxItemLinePrice.BackColor = lboxesColor
        Me.lboxItemLinePrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lboxItemLinePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboxItemLinePrice.ItemHeight = 20
        Me.lboxItemLinePrice.Location = New System.Drawing.Point(688, 16)
        Me.lboxItemLinePrice.Name = "lboxItemLinePrice"
        Me.lboxItemLinePrice.Size = New System.Drawing.Size(88, 320)
        Me.lboxItemLinePrice.TabIndex = 43
        '
        'lboxItemAmt
        '
        Me.lboxItemAmt.ForeColor = lboxesFontColor
        Me.lboxItemAmt.BackColor = lboxesColor
        Me.lboxItemAmt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lboxItemAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboxItemAmt.ItemHeight = 20
        Me.lboxItemAmt.Location = New System.Drawing.Point(8, 16)
        Me.lboxItemAmt.Name = "lboxItemAmt"
        Me.lboxItemAmt.Size = New System.Drawing.Size(56, 320)
        Me.lboxItemAmt.TabIndex = 42
        '
        'lboxItemName
        '
        Me.lboxItemName.ForeColor = lboxesFontColor
        Me.lboxItemName.BackColor = lboxesColor
        Me.lboxItemName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lboxItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboxItemName.ItemHeight = 20
        Me.lboxItemName.Location = New System.Drawing.Point(64, 16)
        Me.lboxItemName.Name = "lboxItemName"
        Me.lboxItemName.Size = New System.Drawing.Size(536, 320)
        Me.lboxItemName.TabIndex = 65
        '
        'lboxReceiptAmt
        '
        Me.lboxReceiptAmt.ForeColor = lboxesReceiptFontColor
        Me.lboxReceiptAmt.BackColor = lboxesReceiptColor
        Me.lboxReceiptAmt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lboxReceiptAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboxReceiptAmt.ItemHeight = 20
        Me.lboxReceiptAmt.Location = New System.Drawing.Point(3, 95)
        Me.lboxReceiptAmt.Name = "lboxReceiptAmt"
        Me.lboxReceiptAmt.Size = New System.Drawing.Size(0, 0)
        Me.lboxReceiptAmt.TabIndex = 65
        '
        'lboxReceiptName
        '
        Me.lboxReceiptName.ForeColor = lboxesReceiptFontColor
        Me.lboxReceiptName.BackColor = lboxesReceiptColor
        Me.lboxReceiptName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lboxReceiptName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboxReceiptName.ItemHeight = 20
        Me.lboxReceiptName.Location = New System.Drawing.Point(32, 95)
        Me.lboxReceiptName.Name = "lboxReceiptName"
        Me.lboxReceiptName.Size = New System.Drawing.Size(0, 0)
        Me.lboxReceiptName.TabIndex = 65
        '
        'btnReceiptClose
        '
        Me.btnReceiptClose.ForeColor = btnReceiptFontColor
        Me.btnReceiptClose.BackColor = btnReceiptColor
        Me.btnReceiptClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceiptClose.Location = New System.Drawing.Point(0, 0)
        Me.btnReceiptClose.Name = "btnReceiptClose"
        Me.btnReceiptClose.Size = New System.Drawing.Size(50, 50)
        Me.btnReceiptClose.TabIndex = 41
        Me.btnReceiptClose.Text = "Close"
        '
        'lboxReceiptTotal
        '
        Me.lboxReceiptTotal.ForeColor = lboxesReceiptFontColor
        Me.lboxReceiptTotal.BackColor = lboxesReceiptColor
        Me.lboxReceiptTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lboxReceiptTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboxReceiptTotal.ItemHeight = 20
        Me.lboxReceiptTotal.Location = New System.Drawing.Point(64, 95)
        Me.lboxReceiptTotal.Name = "lboxReceiptTotal"
        Me.lboxReceiptTotal.Size = New System.Drawing.Size(0, 0)
        Me.lboxReceiptTotal.TabIndex = 65
        '
        'lboxReceiptPrice
        '
        Me.lboxReceiptPrice.ForeColor = lboxesReceiptFontColor
        Me.lboxReceiptPrice.BackColor = lboxesReceiptColor
        Me.lboxReceiptPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lboxReceiptPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboxReceiptPrice.ItemHeight = 20
        Me.lboxReceiptPrice.Location = New System.Drawing.Point(186, 95)
        Me.lboxReceiptPrice.Name = "lboxReceiptPrice"
        Me.lboxReceiptPrice.Size = New System.Drawing.Size(0, 0)
        Me.lboxReceiptPrice.TabIndex = 65
        '
        'lboxlboxReceiptLinePrice
        '
        Me.lboxReceiptLinePrice.ForeColor = lboxesReceiptFontColor
        Me.lboxReceiptLinePrice.BackColor = lboxesReceiptColor
        Me.lboxReceiptLinePrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lboxReceiptLinePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboxReceiptLinePrice.ItemHeight = 20
        Me.lboxReceiptLinePrice.Location = New System.Drawing.Point(240, 95)
        Me.lboxReceiptLinePrice.Name = "lboxReceiptLinePrice"
        Me.lboxReceiptLinePrice.Size = New System.Drawing.Size(0, 0)
        Me.lboxReceiptLinePrice.TabIndex = 65
        '
        'lblReceipt
        '
        Me.lblReceipt.ForeColor = lboxesReceiptFontColor
        Me.lblReceipt.BackColor = lboxesReceiptColor
        Me.lblReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceipt.Location = New System.Drawing.Point(50, 16)
        Me.lblReceipt.Name = "lblReceipt"
        Me.lblReceipt.Size = New System.Drawing.Size(194, 63)
        Me.lblReceipt.TabIndex = 4
        Me.lblReceipt.Text = ""
        Me.lblReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblReceiptTotals
        '
        Me.lblReceiptTotals.ForeColor = lboxesReceiptFontColor
        Me.lblReceiptTotals.BackColor = lboxesReceiptColor
        Me.lblReceiptTotals.Location = New System.Drawing.Point(52, 0)
        Me.lblReceiptTotals.Name = "lblReceiptTotals"
        Me.lblReceiptTotals.Size = New System.Drawing.Size(184, 62)
        Me.lblReceiptTotals.TabIndex = 4
        Me.lblReceiptTotals.Text = ""
        Me.lblReceiptTotals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAmt
        '
        Me.lblAmt.Location = New System.Drawing.Point(72, 64)
        Me.lblAmt.Name = "lblAmt"
        Me.lblAmt.Size = New System.Drawing.Size(120, 23)
        Me.lblAmt.TabIndex = 75
        Me.lblAmt.Text = "0"
        Me.lblAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblKPMsg
        '
        Me.lblKPMsg.Location = New System.Drawing.Point(172, 180)
        Me.lblKPMsg.Name = "lblKPMsg"
        Me.lblKPMsg.Size = New System.Drawing.Size(120, 23)
        Me.lblKPMsg.TabIndex = 75
        Me.lblKPMsg.Text = ""
        Me.lblKPMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRTotal
        '
        Me.lblRTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRTotal.Location = New System.Drawing.Point(592, 352)
        Me.lblRTotal.Name = "lblRTotal"
        Me.lblRTotal.Size = New System.Drawing.Size(88, 32)
        Me.lblRTotal.TabIndex = 44
        Me.lblRTotal.Text = "0"
        Me.lblRTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUser
        '
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(176, 24)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(120, 32)
        Me.lblUser.TabIndex = 44
        Me.lblUser.Text = ""
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblErrMsg
        '
        Me.lblErrMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrMsg.ForeColor = System.Drawing.Color.Green
        Me.lblErrMsg.Location = New System.Drawing.Point(175, 16)
        Me.lblErrMsg.Name = "lblErrMsg"
        Me.lblErrMsg.Size = New System.Drawing.Size(110, 80)
        Me.lblErrMsg.TabIndex = 60
        Me.lblErrMsg.Text = "User ID Please"
        Me.lblErrMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMsg
        '
        Me.lblMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.Location = New System.Drawing.Point(8, 24)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(200, 80)
        Me.lblMsg.TabIndex = 0
        Me.lblMsg.Text = "Thank you for shopping here"
        Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScanCode
        '
        Me.lblScanCode.BackColor = System.Drawing.Color.White
        Me.lblScanCode.Location = New System.Drawing.Point(120, 536)
        Me.lblScanCode.Name = "lblScanCode"
        Me.lblScanCode.TabIndex = 61
        Me.lblScanCode.Text = "Scan Code"
        '
        'lblNoUseBG
        '
        Me.lblNoUseBG.BackColor = System.Drawing.Color.White
        Me.lblNoUseBG.ForeColor = System.Drawing.Color.White
        Me.lblNoUseBG.Location = New System.Drawing.Point(0, 515)
        Me.lblNoUseBG.Name = "lblNoUseBG"
        Me.lblNoUseBG.Size = New System.Drawing.Size(792, 63)
        Me.lblNoUseBG.TabIndex = 64
        '
        'lboxItemNum
        '
        Me.lboxItemNum.Location = New System.Drawing.Point(0, 0)
        Me.lboxItemNum.Name = "lboxItemNum"
        Me.lboxItemNum.Size = New System.Drawing.Size(0, 0)
        Me.lboxItemNum.TabIndex = 39
        '
        'lboxDiscounts
        '
        Me.lboxDiscounts.Location = New System.Drawing.Point(0, 0)
        Me.lboxDiscounts.Name = "lboxDiscounts"
        Me.lboxDiscounts.Size = New System.Drawing.Size(0, 0)
        Me.lboxDiscounts.TabIndex = 39
        '
        'lblSubTotal
        '
        Me.lblSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.Location = New System.Drawing.Point(104, 24)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(64, 16)
        Me.lblSubTotal.TabIndex = 0
        Me.lblSubTotal.Text = "0"
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalTitle
        '
        Me.lblTotalTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTitle.Location = New System.Drawing.Point(16, 72)
        Me.lblTotalTitle.Name = "lblTotalTitle"
        Me.lblTotalTitle.Size = New System.Drawing.Size(88, 16)
        Me.lblTotalTitle.TabIndex = 66
        Me.lblTotalTitle.Text = "Total............."
        Me.lblTotalTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(104, 72)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(64, 16)
        Me.lblTotal.TabIndex = 65
        Me.lblTotal.Text = "0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTaxTitle
        '
        Me.lblTaxTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxTitle.Location = New System.Drawing.Point(16, 48)
        Me.lblTaxTitle.Name = "lblTaxTitle"
        Me.lblTaxTitle.Size = New System.Drawing.Size(88, 16)
        Me.lblTaxTitle.TabIndex = 63
        Me.lblTaxTitle.Text = "Tax @ 7%...."
        Me.lblTaxTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTax
        '
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(104, 48)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(64, 16)
        Me.lblTax.TabIndex = 62
        Me.lblTax.Text = "0"
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSubTotalTitle
        '
        Me.lblSubTotalTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotalTitle.Location = New System.Drawing.Point(16, 24)
        Me.lblSubTotalTitle.Name = "lblSubTotalTitle"
        Me.lblSubTotalTitle.Size = New System.Drawing.Size(88, 16)
        Me.lblSubTotalTitle.TabIndex = 60
        Me.lblSubTotalTitle.Text = "Sub Total......."
        Me.lblSubTotalTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBalance
        '
        Me.lblBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.Location = New System.Drawing.Point(248, 67)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(104, 20)
        Me.lblBalance.TabIndex = 1
        Me.lblBalance.Text = "0"
        '
        'gboxSearch
        '
        Me.gboxSearch.Controls.Add(Me.lboxResults)
        Me.gboxSearch.Controls.Add(Me.btnPharmacy)
        Me.gboxSearch.Controls.Add(Me.btnToys)
        Me.gboxSearch.Controls.Add(Me.btnCanned)
        Me.gboxSearch.Controls.Add(Me.btnMeat)
        Me.gboxSearch.Controls.Add(Me.btnDairy)
        Me.gboxSearch.Controls.Add(Me.btnHygene)
        Me.gboxSearch.Controls.Add(Me.btnCleaning)
        Me.gboxSearch.Controls.Add(Me.btnDeli)
        Me.gboxSearch.Controls.Add(Me.btnBreakfast)
        Me.gboxSearch.Controls.Add(Me.btnCandy)
        Me.gboxSearch.Controls.Add(Me.btnFrozen)
        Me.gboxSearch.Controls.Add(Me.btnProduce)
        Me.gboxSearch.Controls.Add(Me.btnSrchcancel)
        Me.gboxSearch.Controls.Add(Me.btnSelect)
        Me.gboxSearch.Location = New System.Drawing.Point(0, 0)
        Me.gboxSearch.Name = "gboxSearch"
        Me.gboxSearch.Size = New System.Drawing.Size(0, 0)
        Me.gboxSearch.TabIndex = 0
        Me.gboxSearch.TabStop = False
        Me.gboxSearch.Text = "Search"
        '
        'lboxResults
        '
        Me.lboxResults.ForeColor = lboxesReceiptFontColor
        Me.lboxResults.BackColor = lboxesReceiptColor
        Me.lboxResults.Location = New System.Drawing.Point(208, 16)
        Me.lboxResults.Name = "lboxResults"
        Me.lboxResults.Size = New System.Drawing.Size(168, 186)
        Me.lboxResults.TabIndex = 12
        '
        'btnPharmacy
        '
        Me.btnPharmacy.ForeColor = btnFontColor
        Me.btnPharmacy.BackColor = btnColor
        Me.btnPharmacy.Location = New System.Drawing.Point(72, 208)
        Me.btnPharmacy.Name = "btnPharmacy"
        Me.btnPharmacy.Size = New System.Drawing.Size(63, 63)
        Me.btnPharmacy.TabIndex = 11
        Me.btnPharmacy.Text = "Pharmacy"
        '
        'btnToys
        '
        Me.btnToys.ForeColor = btnFontColor
        Me.btnToys.BackColor = btnColor
        Me.btnToys.Location = New System.Drawing.Point(8, 208)
        Me.btnToys.Name = "btnToys"
        Me.btnToys.Size = New System.Drawing.Size(63, 63)
        Me.btnToys.TabIndex = 10
        Me.btnToys.Text = "Toys"
        '
        'btnCanned
        '
        Me.btnCanned.ForeColor = btnFontColor
        Me.btnCanned.BackColor = btnColor
        Me.btnCanned.Location = New System.Drawing.Point(136, 208)
        Me.btnCanned.Name = "btnCanned"
        Me.btnCanned.Size = New System.Drawing.Size(63, 63)
        Me.btnCanned.TabIndex = 9
        Me.btnCanned.Text = "Canned"
        '
        'btnMeat
        '
        Me.btnMeat.ForeColor = btnFontColor
        Me.btnMeat.BackColor = btnColor
        Me.btnMeat.Location = New System.Drawing.Point(136, 16)
        Me.btnMeat.Name = "btnMeat"
        Me.btnMeat.Size = New System.Drawing.Size(63, 63)
        Me.btnMeat.TabIndex = 8
        Me.btnMeat.Text = "Meat"
        '
        'btnDairy
        '
        Me.btnDairy.ForeColor = btnFontColor
        Me.btnDairy.BackColor = btnColor
        Me.btnDairy.Location = New System.Drawing.Point(136, 80)
        Me.btnDairy.Name = "btnDairy"
        Me.btnDairy.Size = New System.Drawing.Size(63, 63)
        Me.btnDairy.TabIndex = 7
        Me.btnDairy.Text = "Dairy"
        '
        'btnHygene
        '
        Me.btnHygene.ForeColor = btnFontColor
        Me.btnHygene.BackColor = btnColor
        Me.btnHygene.Location = New System.Drawing.Point(136, 144)
        Me.btnHygene.Name = "btnHygene"
        Me.btnHygene.Size = New System.Drawing.Size(63, 63)
        Me.btnHygene.TabIndex = 6
        Me.btnHygene.Text = "Hygene"
        '
        'btnCleaning
        '
        Me.btnCleaning.ForeColor = btnFontColor
        Me.btnCleaning.BackColor = btnColor
        Me.btnCleaning.Location = New System.Drawing.Point(72, 144)
        Me.btnCleaning.Name = "btnCleaning"
        Me.btnCleaning.Size = New System.Drawing.Size(63, 63)
        Me.btnCleaning.TabIndex = 5
        Me.btnCleaning.Text = "Cleaning"
        '
        'btnDeli
        '
        Me.btnDeli.ForeColor = btnFontColor
        Me.btnDeli.BackColor = btnColor
        Me.btnDeli.Location = New System.Drawing.Point(72, 80)
        Me.btnDeli.Name = "btnDeli"
        Me.btnDeli.Size = New System.Drawing.Size(63, 63)
        Me.btnDeli.TabIndex = 4
        Me.btnDeli.Text = "Deli"
        '
        'btnBreakfast
        '
        Me.btnBreakfast.ForeColor = btnFontColor
        Me.btnBreakfast.BackColor = btnColor
        Me.btnBreakfast.Location = New System.Drawing.Point(72, 16)
        Me.btnBreakfast.Name = "btnBreakfast"
        Me.btnBreakfast.Size = New System.Drawing.Size(63, 63)
        Me.btnBreakfast.TabIndex = 3
        Me.btnBreakfast.Text = "Breakfast"
        '
        'btnCandy
        '
        Me.btnCandy.ForeColor = btnFontColor
        Me.btnCandy.BackColor = btnColor
        Me.btnCandy.Location = New System.Drawing.Point(8, 144)
        Me.btnCandy.Name = "btnCandy"
        Me.btnCandy.Size = New System.Drawing.Size(63, 63)
        Me.btnCandy.TabIndex = 2
        Me.btnCandy.Text = "Candy"
        '
        'btnFrozen
        '
        Me.btnFrozen.ForeColor = btnFontColor
        Me.btnFrozen.BackColor = btnColor
        Me.btnFrozen.Location = New System.Drawing.Point(8, 80)
        Me.btnFrozen.Name = "btnFrozen"
        Me.btnFrozen.Size = New System.Drawing.Size(63, 63)
        Me.btnFrozen.TabIndex = 1
        Me.btnFrozen.Text = "Frozen"
        '
        'btnProduce
        '
        Me.btnProduce.ForeColor = btnFontColor
        Me.btnProduce.BackColor = btnColor
        Me.btnProduce.Location = New System.Drawing.Point(8, 16)
        Me.btnProduce.Name = "btnProduce"
        Me.btnProduce.Size = New System.Drawing.Size(63, 63)
        Me.btnProduce.TabIndex = 0
        Me.btnProduce.Text = "Produce"
        '
        'btnSrchCancel
        '
        Me.btnSrchcancel.ForeColor = btnFontColor
        Me.btnSrchcancel.BackColor = btnColor
        Me.btnSrchcancel.Location = New System.Drawing.Point(224, 216)
        Me.btnSrchcancel.Name = "btnSrchCancel"
        Me.btnSrchcancel.Size = New System.Drawing.Size(50, 50)
        Me.btnSrchcancel.TabIndex = 0
        Me.btnSrchcancel.Text = "Cancel"
        '
        'btnSelect
        '
        Me.btnSelect.ForeColor = btnFontColor
        Me.btnSelect.BackColor = btnColor
        Me.btnSelect.Location = New System.Drawing.Point(312, 216)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(50, 50)
        Me.btnSelect.TabIndex = 0
        Me.btnSelect.Text = "Select"
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(105, 430)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(280, 50)
        Me.lblTime.TabIndex = 0
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    End Sub

#End Region

#Region "Variables"
    'Variables
    Const MyCRLF = Chr(13) + Chr(10)
    Dim typeBuffer As String
    Dim itemIndex As Integer
    Dim iCounter As Integer
    Dim btnAction As String

    Const listFile = "list01.txt"
    Const userFile = "user01.txt"
    Const productFile = "product01.txt"
    Const dcodesFile = "discounts01.txt"

    Dim eprFile As System.IO.File
    Dim eprRead As System.IO.StreamReader
    Dim eprContents As String
    Dim eprFile2 As System.IO.File
    Dim eprRead2 As System.IO.StreamReader
    Dim eprContents2 As String

    Dim chkDecimal As Integer
    Dim rTotal As Decimal
    Dim fTotal As Decimal
    Dim linePrice As Decimal
    Dim itemNum As Integer
    Dim itemName As String
    Dim itemPrice As Decimal
    Dim itemAmt As Double
    Dim itemCat As String
    Dim userID As String
    Dim passCode As String
    Dim userName As String
    Dim userFlag As Boolean
    Dim pFound As Boolean
    Dim cUserID As String
    Dim cPassCode As String
    Dim cUserName As String
    Dim theIndex As Integer
    Dim addedFlag As Boolean
    Dim amtPaid As Decimal
    Dim salesTax As Decimal
    Dim amtDue As Decimal
    Dim dCode As String
    Dim dAmt As Decimal
    Dim dItem As String
    Dim prevMsg As String
    Dim fileDelimeter As String = ","
    '
#End Region

    Private Sub frmRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        disableModKeys()
        btnSearch.Visible() = False
        btnScanCard.Enabled() = False
        btnFinish.Enabled() = False
        btnMulItem.Visible() = False
        lblRTotal.Text = Format(lblRTotal.Text, "$0.00")
        lblSubTotal.Text = Format(lblSubTotal.Text, "$0.00")
        lblTotal.Text = Format(lblTotal.Text, "$0.00")
        lblTax.Text = Format(lblTax.Text, "$0.00")
        loadLogin()
    End Sub

#Region "Keypad"
    '
    'Begin Number Buttons
    '
    Private Sub btnOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOne.Click
        processBtn(1)
    End Sub

    Private Sub btnTwo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTwo.Click
        processBtn(2)
    End Sub

    Private Sub btnThree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThree.Click
        processBtn(3)
    End Sub

    Private Sub btnFour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFour.Click
        processBtn(4)
    End Sub

    Private Sub btnFive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFive.Click
        processBtn(5)
    End Sub

    Private Sub btnSix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSix.Click
        processBtn(6)
    End Sub

    Private Sub btnSeven_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeven.Click
        processBtn(7)
    End Sub

    Private Sub btnEight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEight.Click
        processBtn(8)
    End Sub

    Private Sub btnNine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNine.Click
        processBtn(9)
    End Sub

    Private Sub btnZero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZero.Click
        processBtn(0)
    End Sub

    Private Sub btnDecimal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecimal.Click
        processBtn(".")
    End Sub

    Private Sub btnDblZero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDblZero.Click
        processBtn(".00")
    End Sub
    '
    'Begin Number Buttons
    '

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        processBtn("Enter", btnAction)
        btnSearch.Visible() = False
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        processBtn("Reset", "Reset")
        btnMulItem.Enabled = False
    End Sub

    Private Sub btnMulItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMulItem.Click
        '
        'Set multiple of item being eneterd
        '
        getProductByNum(typeBuffer)
        If (pFound) Then
            btnAction = "ManEntFound"
            itemNum = typeBuffer
            typeBuffer = ""
            chngErrMsg("Enter number of current item", "Black")
            lblKPMsg.Text = ""
        Else
            chngErrMsg("Invalid Product Number", "Red")
            lblKPMsg.Text = ""
        End If
    End Sub
    '
#End Region

#Region "Search Buttons"
    '
    'Begin buttons that search search funtion
    '
    Private Sub btnProduce_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProduce.Click
        processSrchBtn("Produce")
    End Sub

    Private Sub btnFrozen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrozen.Click
        processSrchBtn("Frozen")
    End Sub

    Private Sub btnCandy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCandy.Click
        processSrchBtn("Candy")
    End Sub

    Private Sub btnToys_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToys.Click
        processSrchBtn("Toys")
    End Sub

    Private Sub btnBreakfast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBreakfast.Click
        processSrchBtn("Breakfast")
    End Sub

    Private Sub btnDeli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeli.Click
        processSrchBtn("Deli")
    End Sub

    Private Sub btnCleaning_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCleaning.Click
        processSrchBtn("Cleaning")
    End Sub

    Private Sub btnPharmacy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPharmacy.Click
        processSrchBtn("Pharmacy")
    End Sub

    Private Sub btnMeat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMeat.Click
        processSrchBtn("Meat")
    End Sub

    Private Sub btnDairy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDairy.Click
        processSrchBtn("Dairy")
    End Sub

    Private Sub btnHygene_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHygene.Click
        processSrchBtn("Hygene")
    End Sub

    Private Sub btnCanned_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCanned.Click
        processSrchBtn("Canned")
    End Sub
    '
    'End buttons that search search funtion
    '

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim tempMsg As String
        '
        'Determine is what message to print on next screen by what button was puched before
        '
        If ((btnAction = "Weight") Or (InStr(lblErrMsg.Text, "Weight") <> 0)) Then
            tempMsg = "Weight in lbs of " & itemName & "?"
            btnDecimal.Visible() = True
            btnAction = "ManEntFound"
        ElseIf ((btnAction = "ManEnt") Or (InStr(lblErrMsg.Text, "How many") <> 0)) Then
            '
            'Check for plural itemName, set message based on outcome
            '
            If (InStr(StrReverse(itemName), "s") = 1) Then
                tempMsg = "How many " & itemName & "?"
            Else
                tempMsg = "How many " & itemName & "s?"
            End If
            btnDecimal.Visible() = False
            btnAction = "ManEntFound"
        Else
            tempMsg = ""
        End If
        lblKPMsg.Text = ""
        loadKeypad(btnAction, tempMsg)
        btnMulItem.Visible() = False
        lboxResults.Items.Clear()
        hideSearch()
        enableEtcKeys()
    End Sub

    Private Sub btnSrchCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSrchcancel.Click
        '
        'Cancel Serch and bring back up the keypad
        '
        hideSearch()
        lboxResults.Items.Clear()
        loadKeypad(btnAction, prevMsg)
    End Sub
#End Region

#Region "Listbox Selections"
    Private Sub lboxItemName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lboxItemName.SelectedIndexChanged

        'get information on item in list that is selected
        '
        itemIndex = lboxItemName.SelectedIndex
        setSelected(itemIndex)
        If (itemIndex >= 0) Then

            'turn on delete and duplicate buttons if an item is selected
            '
            enableModKeys()
        Else
            'turn off delete and duplicate buttons if an item is not selected
            '
            disableModKeys()
        End If
    End Sub

    Private Sub lboxItemAmt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lboxItemAmt.SelectedIndexChanged

        'get information on item in list that is selected
        '
        itemIndex = lboxItemAmt.SelectedIndex
        setSelected(itemIndex)
    End Sub

    Private Sub lboxItemPrice_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lboxItemPrice.SelectedIndexChanged

        'get information on item in list that is selected
        '
        itemIndex = lboxItemPrice.SelectedIndex
        setSelected(itemIndex)
    End Sub

    Private Sub lboxItemLinePrice_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lboxItemLinePrice.SelectedIndexChanged

        'get information on item in list that is selected
        '
        itemIndex = lboxItemLinePrice.SelectedIndex
        setSelected(itemIndex)
    End Sub

    Private Sub lboxResults_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lboxResults.SelectedIndexChanged
        '
        'Turn select button on or off, based on if an item is selected or not
        '
        If (lboxResults.SelectedIndex < 0) Then
            btnSelect.Enabled() = False
        Else
            btnSelect.Enabled() = True
        End If
        '
        'get information on item in list that is selected
        '
        Dim splitRecord = Split(lboxResults.Items.Item(lboxResults.SelectedIndex), "  ")
        itemNum = splitRecord(0)
        itemName = splitRecord(1)
    End Sub
#End Region

#Region "Other Buttons"
    Private Sub btnScan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScan.Click
        eprRead = eprFile.OpenText(listFile)

        'Read file to simulate items scanned
        '
        Do Until eprRead.Peek = -1
            eprContents = eprRead.ReadLine()
            Dim splitRecord = Split(eprContents, fileDelimeter)
            itemNum = splitRecord(0)
            itemAmt = splitRecord(1)

            chkList(itemNum)
            If (addedFlag = True) Then

                'if item already on list, add to number of that item
                '
                incItemNum(theIndex, lboxItemAmt.Items.Item(theIndex), itemAmt, lboxItemPrice.Items.Item(theIndex), lboxItemLinePrice.Items.Item(theIndex))
            Else
                'if item is new, add item
                '
                addNewItem(itemNum, itemAmt)
            End If
            setSelected(-1)
        Loop
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        '
        'Call function to remove one item, its price from the Running total and the Line Price
        '
        decItemNum(itemIndex, lboxItemAmt.SelectedItem, lboxItemPrice.SelectedItem, lboxItemLinePrice.SelectedItem)
        '
        'if the item only has one left, remove it completely
        '
        If ((lboxItemAmt.SelectedItem - 1) < 0) Then
            Dim tempindex = itemIndex
            lboxItemNum.Items.RemoveAt(tempindex)
            lboxItemAmt.Items.RemoveAt(tempindex)
            lboxItemPrice.Items.RemoveAt(tempindex)
            lboxItemLinePrice.Items.RemoveAt(tempindex)
            lboxItemName.Items.RemoveAt(tempindex)
        End If
        If (lboxItemNum.Items.Count = 0) Then
            btnFinish.Enabled() = False
            btnLogout.Enabled() = True
        End If
    End Sub

    Private Sub btnOverride_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOverride.Click
        disableEtcKeys()
        loadKeypad("Override", "Enter new price for " & itemName)
        btnDecimal.Visible() = True
        btnDblZero.Visible() = True
    End Sub

    Private Sub btnPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay.Click
        amtDue -= amtPaid
        amtPaid = 0
        lblAmt.Text = Format(amtPaid, "$0.00")
        lblBalance.Text = Format(amtDue, "$0.00")
        '
        'If bill is paid, create a receipt
        '
        If (amtDue <= 0.0) Then
            If (amtDue < 0.0) Then
                amtDue = Format((-1 * amtDue), "$0.00")
            End If
            buildReciept()
            setSelected(-1)
            btnFinish.Enabled() = False
            updatePrices(0)
            hidePaymentOps()
            disableModKeys()
            rTotal = 0.0
        End If
        enablePOKeys()
        btnPay.Enabled = False
    End Sub

    Private Sub btnCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCard.Click
        loadKeypad("payCard", "Enter ammount to be paid and Swipe card")
        disablePOKeys()
    End Sub

    Private Sub btnReceiptClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReceiptClose.Click
        gboxReceipt.Visible() = False
        enableEtcKeys()
    End Sub

    Private Sub btnScanCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScanCard.Click
        btnScanCard.Enabled() = False
        btnPay.Enabled() = True
    End Sub

    Private Sub btnDCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDCode.Click
        loadKeypad("dCode", "Enter Dicsount Code")
        disablePOKeys()
        btnDecimal.Visible() = False
        btnDblZero.Visible() = False
    End Sub

    Private Sub btnCash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCash.Click
        loadKeypad("payCash", "Enter ammount to be paid")
        disablePOKeys()
    End Sub

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        loadKeypad("payCard", "Enter ammount and Swipe card")
        disablePOKeys()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        loadSearch()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If InStr(btnAction, "pay") <> 0 Or (btnAction = "dCode") Then
            enablePOKeys()
        Else
            enableEtcKeys()
            If (lboxItemName.SelectedIndex < 0) Then
                disableModKeys()
            End If
        End If
        hideKeypad()
        btnMulItem.Visible() = False
        btnSearch.Visible() = False
        btnPay.Enabled() = False
        typeBuffer = ""
        lblKPMsg.Text = ""
    End Sub

    Private Sub btnPOCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPOCancel.Click
        typeBuffer = ""
        lblAmt.Text = ""
        hidePaymentOps()
        hideKeypad()
        enableEtcKeys()
        If (lboxItemName.SelectedIndex < 0) Then
            disableModKeys()
        End If
    End Sub

    Private Sub btnManEnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManEnt.Click
        disableEtcKeys()
        btnMulItem.Location = New System.Drawing.Point(120, 184)
        btnMulItem.Size = New System.Drawing.Size(50, 50)
        btnSearch.Visible() = True
        btnMulItem.Visible() = True
        btnMulItem.Enabled = False
        loadKeypad("ManEnt", "Enter Item Number, or search for an Item")
        btnDecimal.Visible() = False
        btnDblZero.Visible() = False
    End Sub

    Private Sub btnDeleteAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteAll.Click
        rTotal -= lboxItemPrice.SelectedItem * lboxItemAmt.SelectedItem
        Dim tempindex = itemIndex
        lboxItemNum.Items.RemoveAt(tempindex)
        lboxItemAmt.Items.RemoveAt(tempindex)
        lboxItemPrice.Items.RemoveAt(tempindex)
        lboxItemLinePrice.Items.RemoveAt(tempindex)
        lboxItemName.Items.RemoveAt(tempindex)
        setSelected(-1)
        If (lboxItemNum.Items.Count = 0) Then
            btnFinish.Enabled() = False
            btnLogout.Enabled() = True
        End If
        updatePrices(rTotal)
    End Sub

    Private Sub btnDuplicate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDuplicate.Click
        incItemNum(itemIndex, lboxItemAmt.SelectedItem, 1, lboxItemPrice.SelectedItem, lboxItemLinePrice.SelectedItem)
        setSelected(itemIndex)
    End Sub

    Private Sub btnFinish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinish.Click
        loadPaymentOps()
    End Sub

    Private Sub btnWeight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWeight.Click
        disableEtcKeys()
        loadKeypad("Weight", "Enter Item Number, or search for an Item")
        btnSearch.Visible() = True
        btnDecimal.Visible() = False
        btnDblZero.Visible() = False
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        loadLogin()
        'Me.Close()
    End Sub
#End Region

#Region "Functions"
    Private Function processBtn(ByVal btnValue As String)
        '
        'Process numeric buttons on keypad
        '
        btnEnter.Enabled() = True
        If (btnValue = ".00") Then
            disableKeypad()
        ElseIf (btnValue = ".") Then
            chkDecimal = 1
            btnDecimal.Enabled() = False
            btnDblZero.Enabled() = False
        End If
        If (chkDecimal > 0) Then
            chkDecimal += 1
        End If
        If (chkDecimal = 4) Then
            disableKeypad()
        End If
        typeBuffer += btnValue
        lblKPMsg.Text = typeBuffer
        If (typeBuffer = "") Then
            btnMulItem.Enabled = False
        Else
            btnMulItem.Enabled = True
        End If
    End Function

    Private Function processBtn(ByVal btnValue As String, ByVal currAction As String)
        '
        'Read Login file - compare User ID entered to see if it exists
        '
        If (currAction = "lgn1") Then
            eprRead = eprFile.OpenText(userFile)
            Do Until eprRead.Peek = -1
                eprContents = eprRead.ReadLine()
                Dim splitRecord = Split(eprContents, fileDelimeter)
                userID = splitRecord(0)
                passCode = splitRecord(1)
                userName = splitRecord(2)

                If (userID = typeBuffer) Then
                    userFlag = True
                    cUserID = userID
                    cPassCode = passCode
                    cUserName = userName
                    lblUser.Text = "Cashier: " & cUserName
                End If
            Loop
            If (userFlag) Then
                '
                'User ID is valid, request passcode
                '
                chngErrMsg("Passcode Please", "Black")
                typeBuffer = ""
                lblKPMsg.Text = ""
                btnAction = "lgn2"
                btnEnter.Text = "Login"
            Else
                '
                'Error when User ID does not exist
                '
                chngErrMsg("Incorrect User ID", "Red")
                typeBuffer = ""
                lblKPMsg.Text = ""
            End If
        ElseIf (currAction = "lgn2") Then
            If (typeBuffer = cPassCode) Then
                '
                'Login successful, load program
                '
                chngErrMsg("Login Successful", "Black")
                typeBuffer = ""
                lblKPMsg.Text = ""
                btnEnter.Text = "Enter"
                hideLogin()
            Else
                '
                'Error when passcode does not match
                '
                chngErrMsg("Incorrect Passcode", "Red")
                typeBuffer = ""
            End If
        ElseIf (currAction = "Reset") Then
            '
            'Reset the Buffer
            '
            If (btnAction = "lgn2") Then
                btnAction = "lgn1"
                chngErrMsg("User ID Please", "Black")
                btnEnter.Text = "Enter"
            End If
            typeBuffer = ""
            lblKPMsg.Text = ""
            enableKeypad()
        ElseIf (currAction = "Override") Then
            '
            'Override the price of selected item
            '
            changePrice(itemIndex, lboxItemAmt.SelectedItem, typeBuffer, lboxItemLinePrice.SelectedItem)
            hideKeypad()
            enableEtcKeys()
            enableKeypad()
            setSelected(itemIndex)
            lblKPMsg.Text = ""
            typeBuffer = ""
        ElseIf (currAction = "ManEnt") Then
            '
            'Enter an item manually
            '
            pFound = False
            If (itemAmt < 1) Then
                itemAmt = 1
            End If
            getProductByNum(typeBuffer)
            If (pFound) Then
                hideKeypad()
                enableEtcKeys()
                disableModKeys()
                chkList(itemNum)
                If (addedFlag = True) Then
                    '
                    'if item already on list, add to number of that item
                    '
                    incItemNum(theIndex, lboxItemAmt.Items.Item(theIndex), itemAmt, lboxItemPrice.Items.Item(theIndex), lboxItemLinePrice.Items.Item(theIndex))
                Else
                    '
                    'if item is new, add item
                    '
                    addNewItem(itemNum, itemAmt)
                End If
                setSelected(-1)
                lblKPMsg.Text = ""
                typeBuffer = ""
                btnMulItem.Visible() = False
                btnSearch.Visible() = False
                itemAmt = 0
            Else
                chngErrMsg("Invalid Product Number", "Red")
                lblKPMsg.Text = ""
                typeBuffer = ""
            End If
        ElseIf (currAction = "Weight") Then
            '
            'Enter an item then its weight
            '
            getProductByNum(typeBuffer)
            If (pFound) Then
                btnDecimal.Visible() = True
                btnAction = "ManEntFound"
                itemNum = typeBuffer
                chngErrMsg("Weight of the selected item?", "Black")
                lblKPMsg.Text = ""
                typeBuffer = ""
                btnMulItem.Visible() = False
                btnSearch.Visible() = False
                pFound = False
                setSelected(-1)
                itemAmt = 0
            Else
                chngErrMsg("Invalid Product Number", "Red")
                lblKPMsg.Text = ""
                typeBuffer = ""
            End If
        ElseIf (currAction = "ManEntFound") Then
            '
            'Item has been found, now to add it
            '
            itemAmt = typeBuffer
            hideKeypad()
            enableEtcKeys()
            disableModKeys()
            chkList(itemNum)
            If (addedFlag = True) Then

                'if item already on list, add to number of that item
                '
                incItemNum(theIndex, lboxItemAmt.Items.Item(theIndex), itemAmt, lboxItemPrice.Items.Item(theIndex), lboxItemLinePrice.Items.Item(theIndex))
            Else
                'if item is new, add item
                '
                addNewItem(itemNum, itemAmt)
            End If
            setSelected(-1)
            lblKPMsg.Text = ""
            typeBuffer = ""
            btnMulItem.Visible() = False
            btnSearch.Visible() = False
        ElseIf ((currAction = "payCard") Or (currAction = "payCash") Or (currAction = "payCheck")) Then
            '
            'Process different payment methods
            '
            amtPaid += typeBuffer
            lblAmt.Text = Format(amtPaid, "$0.00")
            lblKPMsg.Text = ""
            typeBuffer = ""
            hideKeypad()
            If (currAction = "payCard") Then
                btnScanCard.Enabled() = True
            Else
                btnPay.Enabled() = True
            End If
        ElseIf (currAction = "dCode") Then
            '
            'Process discount code
            '
            addedFlag = False
            eprRead = eprFile.OpenText(dcodesFile)
            '
            'Search through available discounts in discount file
            '
            Do Until eprRead.Peek = -1
                eprContents = eprRead.ReadLine()
                Dim splitRecord = Split(eprContents, fileDelimeter)
                If (addedFlag = False) Then
                    dCode = splitRecord(0)
                    dAmt = splitRecord(1)
                    dItem = splitRecord(2)
                End If
                If (typeBuffer = dCode) Then
                    addedFlag = True
                End If
            Loop
            If (addedFlag = True) Then
                '
                'If discount code is found, check if the item has already been entered
                '
                chkList(dItem)
                If (addedFlag = True) Then
                    '
                    'Check if the discount has already been enetered
                    '
                    chkDList(dCode)
                    If (addedFlag <> True) Then
                        '
                        'if discount is new, add discount
                        '
                        addNewDiscount(dCode, dAmt, dItem)
                    End If
                End If
                hideKeypad()
                enablePOKeys()
                btnPay.Enabled() = False
                lblKPMsg.Text = ""
                typeBuffer = ""
            Else
                chngErrMsg("Invalid Discount Code", "Red")
                lblKPMsg.Text = ""
                typeBuffer = ""
            End If
        End If
        If (typeBuffer = "") Then
            btnEnter.Enabled() = False
        End If
    End Function

    Private Function chkList(ByVal theItem As String)
        addedFlag = False
        '
        'Check to see if item is already on the list
        '
        iCounter = 0
        Do While iCounter <= lboxItemNum.Items.Count - 1
            If (theItem = lboxItemNum.Items.Item(iCounter)) Then
                addedFlag = True
                theIndex = iCounter
            End If
            iCounter += 1
        Loop
    End Function

    Private Function chkDList(ByVal theItem As String)
        addedFlag = False
        '
        'Check to see if item is already on the list
        '
        iCounter = 0
        Do While iCounter <= lboxDiscounts.Items.Count - 1
            If (theItem = lboxDiscounts.Items.Item(iCounter)) Then
                addedFlag = True
                theIndex = iCounter
            End If
            iCounter += 1
        Loop
    End Function

    Private Function disableModKeys()
        btnDelete.Enabled() = False
        btnDeleteAll.Enabled() = False
        btnDuplicate.Enabled() = False
        btnOverride.Enabled() = False
    End Function

    Private Function enableModKeys()
        btnDelete.Enabled() = True
        btnDeleteAll.Enabled() = True
        btnDuplicate.Enabled() = True
        btnOverride.Enabled() = True
    End Function

    Private Function disableKeypad()
        btnOne.Enabled() = False
        btnTwo.Enabled() = False
        btnThree.Enabled() = False
        btnFour.Enabled() = False
        btnFive.Enabled() = False
        btnSix.Enabled() = False
        btnSeven.Enabled() = False
        btnEight.Enabled() = False
        btnNine.Enabled() = False
        btnZero.Enabled() = False
        btnDecimal.Enabled() = False
        btnDblZero.Enabled() = False
    End Function

    Private Function enableKeypad()
        btnOne.Enabled() = True
        btnTwo.Enabled() = True
        btnThree.Enabled() = True
        btnFour.Enabled() = True
        btnFive.Enabled() = True
        btnSix.Enabled() = True
        btnSeven.Enabled() = True
        btnEight.Enabled() = True
        btnNine.Enabled() = True
        btnZero.Enabled() = True
        btnDecimal.Enabled() = True
        btnDblZero.Enabled() = True
        If (typeBuffer = "") Then
            btnEnter.Enabled() = False
        End If
    End Function

    Private Function disablePOKeys()
        btnCash.Enabled() = False
        btnCard.Enabled() = False
        btnDCode.Enabled() = False
        btnPay.Enabled() = False
        btnCheck.Enabled() = False
        btnPOCancel.Enabled() = False
    End Function

    Private Function enablePOKeys()
        btnCash.Enabled() = True
        btnCard.Enabled() = True
        btnCheck.Enabled() = True
        btnDCode.Enabled() = True
        btnPay.Enabled() = True
        If (amtDue >= fTotal) Then
            btnPOCancel.Enabled() = True
        End If
    End Function

    Private Function disableEtcKeys()
        btnWeight.Enabled() = False
        btnScan.Enabled() = False
        btnLogout.Enabled() = False
        btnFinish.Enabled() = False
        btnManEnt.Enabled() = False
        lboxItemName.Enabled() = False
        lboxItemAmt.Enabled() = False
        lboxItemPrice.Enabled() = False
        lboxItemLinePrice.Enabled() = False
        disableModKeys()
    End Function

    Private Function enableEtcKeys()
        btnWeight.Enabled() = True
        btnScan.Enabled() = True
        If (lboxItemNum.Items.Count = 0) Then
            btnFinish.Enabled() = False
            btnLogout.Enabled() = True
        Else
            btnFinish.Enabled() = True
            btnLogout.Enabled() = False
            If (lboxItemNum.SelectedIndex >= 0) Then
                enableModKeys()
            End If
        End If
        btnManEnt.Enabled() = True
        lboxItemName.Enabled() = True
        lboxItemAmt.Enabled() = True
        lboxItemPrice.Enabled() = True
        lboxItemLinePrice.Enabled() = True
    End Function

    Private Function setSelected(ByVal selIndex As Integer)
        '
        'Set the selected Item back to the previously selected item
        '
        lboxItemNum.SelectedIndex() = selIndex
        lboxItemAmt.SelectedIndex() = selIndex
        lboxItemPrice.SelectedIndex() = selIndex
        lboxItemLinePrice.SelectedIndex() = selIndex
        lboxItemName.SelectedIndex() = selIndex
    End Function

    Private Function incItemNum(ByVal currIndex As String, ByVal currAmt As Double, ByVal addAmt As Double, ByVal addPrice As Decimal, ByVal addLine As Decimal)
        rTotal += addPrice * addAmt
        addLine += addPrice * addAmt
        lboxItemAmt.Items.RemoveAt(currIndex)
        lboxItemAmt.Items.Insert(currIndex, currAmt + addAmt)
        lboxItemLinePrice.Items.RemoveAt(currIndex)
        lboxItemLinePrice.Items.Insert(currIndex, Format(addLine, "$0.00"))
        updatePrices(rTotal)
        setSelected(currIndex)
    End Function

    Private Function decItemNum(ByVal currIndex As String, ByVal currAmt As Double, ByVal subPrice As Decimal, ByVal subLine As Decimal)
        rTotal -= subPrice
        subLine -= subPrice
        lboxItemAmt.Items.RemoveAt(currIndex)
        lboxItemAmt.Items.Insert(currIndex, currAmt - 1)
        lboxItemLinePrice.Items.RemoveAt(currIndex)
        lboxItemLinePrice.Items.Insert(currIndex, Format(subLine, "$0.00"))
        updatePrices(rTotal)
        setSelected(currIndex)
    End Function

    Private Function changePrice(ByVal chngIndex As String, ByVal chngAmt As Double, ByVal chngPrice As Decimal, ByVal chngLine As Decimal)
        rTotal -= chngLine
        rTotal += chngPrice * chngAmt
        chngLine = chngPrice * chngAmt
        lboxItemPrice.Items.RemoveAt(chngIndex)
        lboxItemPrice.Items.Insert(chngIndex, Format(chngPrice, "$0.00"))
        lboxItemLinePrice.Items.RemoveAt(chngIndex)
        lboxItemLinePrice.Items.Insert(chngIndex, Format(chngLine, "$0.00"))
        updatePrices(rTotal)
    End Function

    Private Function addNewItem(ByVal currNum As String, ByVal currAmt As Double)
        getProductByNum(currNum)
        rTotal += itemPrice * currAmt
        linePrice = itemPrice * currAmt
        lboxItemNum.Items.Add(currNum)
        lboxItemAmt.Items.Add(currAmt)
        lboxItemName.Items.Add(itemName)
        lboxItemPrice.Items.Add(Format(itemPrice, "$0.00"))
        lboxItemLinePrice.Items.Add(Format(linePrice, "$0.00"))
        btnFinish.Enabled() = True
        btnLogout.Enabled() = False
        updatePrices(rTotal)
    End Function

    Private Function addNewDiscount(ByVal currNum As String, ByVal currAmt As Decimal, ByVal currItem As String)
        rTotal -= lboxItemLinePrice.Items.Item(theIndex)
        itemPrice = (lboxItemPrice.Items.Item(theIndex) - (lboxItemPrice.Items.Item(theIndex) * currAmt))
        linePrice = itemPrice * lboxItemAmt.Items.Item(theIndex)
        rTotal += linePrice
        rTotal = Format(rTotal, "$0.00")
        linePrice = Format(linePrice, "$0.00")
        itemPrice = Format(itemPrice, "$0.00")
        lboxDiscounts.Items.Add(currNum)
        lboxItemPrice.Items.RemoveAt(theIndex)
        lboxItemPrice.Items.Insert(theIndex, itemPrice)
        lboxItemLinePrice.Items.RemoveAt(theIndex)
        lboxItemLinePrice.Items.Insert(theIndex, linePrice)
        btnFinish.Enabled() = True
        btnLogout.Enabled() = False
        updatePrices(rTotal)
    End Function

    Private Function loadLogin()
        gboxCover.Location = New System.Drawing.Point(-8, -8)
        gboxCover.Size = New System.Drawing.Size(808, 584)
        gboxCover.BringToFront()
        loadKeypad("lgn1", "User ID Please")
        btnCancel.Visible() = False
        btnDecimal.Visible() = False
        btnDblZero.Visible() = False
    End Function

    Private Function hideLogin()
        gboxCover.Location = New System.Drawing.Point(0, 0)
        gboxCover.Size = New System.Drawing.Size(0, 0)
        btnCancel.Visible() = True
        btnDecimal.Visible() = True
        btnDblZero.Visible() = True
        hideKeypad()
    End Function

    Private Function loadKeypad(ByVal KPAction As String, ByVal KPMsg As String)
        chkDecimal = 0
        enableKeypad()
        btnAction = KPAction
        prevMsg = KPMsg
        chngErrMsg(KPMsg, "Black")
        gboxKP.Location = New System.Drawing.Point(245, 60)
        gboxKP.Size = New System.Drawing.Size(296, 296)
        gboxKP.BringToFront()
    End Function

    Private Function hideKeypad()
        gboxKP.Location = New System.Drawing.Point(0, 0)
        gboxKP.Size = New System.Drawing.Size(0, 0)
    End Function

    Private Function hidePaymentOps()
        gboxPO.Location = New System.Drawing.Point(0, 0)
        gboxPO.Size = New System.Drawing.Size(0, 0)
        lblAmt.Text = 0
    End Function

    Private Function loadPaymentOps()
        gboxPO.Location = New System.Drawing.Point(0, 400)
        gboxPO.Size = New System.Drawing.Size(472, 112)
        disableEtcKeys()
        gboxPO.BringToFront()
        enablePOKeys()
        btnPay.Enabled() = False
        amtPaid = 0
        lblAmt.Text = Format(lblAmt.Text, "$0.00")
    End Function

    Private Function chngErrMsg(ByVal errMsg As String, ByVal msgColor As String)
        lblErrMsg.Text = errMsg
        lblErrMsg.ForeColor = System.Drawing.Color.FromName(msgColor)
    End Function

    Private Function getProductByNum(ByVal productNum As String)
        eprRead2 = eprFile2.OpenText(productFile)
        Dim prodNum As Integer
        Dim prodName As String
        Dim prodPrice As Decimal
        Dim prodCat As String
        Do Until eprRead2.Peek = -1
            eprContents2 = eprRead2.ReadLine()
            Dim splitRecord = Split(eprContents2, fileDelimeter)
            prodNum = splitRecord(0)
            prodName = splitRecord(1)
            prodPrice = splitRecord(2)
            prodCat = splitRecord(3)
            If (productNum = prodNum) Then
                pFound = True
                itemNum = prodNum
                itemName = prodName
                itemPrice = prodPrice
                itemCat = prodCat
            End If
        Loop
    End Function

    Private Function getProductByCat(ByVal productCat As String)
        eprRead2 = eprFile2.OpenText(productFile)
        Dim prodNum As Integer
        Dim prodName As String
        Dim prodPrice As Decimal
        Dim prodCat As String
        Do Until eprRead2.Peek = -1
            eprContents2 = eprRead2.ReadLine()
            Dim splitRecord = Split(eprContents2, fileDelimeter)
            prodNum = splitRecord(0)
            prodName = splitRecord(1)
            prodPrice = splitRecord(2)
            prodCat = splitRecord(3)
            If (productCat = prodNum) Then
                itemNum = prodNum
                itemName = prodName
                itemPrice = prodPrice
                itemCat = prodCat
            End If
        Loop
    End Function

    Private Function updatePrices(ByVal passRTotal As Decimal)
        salesTax = 0.07 * passRTotal
        fTotal = passRTotal + salesTax
        amtDue = fTotal
        lblBalance.Text = Format(amtDue, "$0.00")
        lblRTotal.Text = Format(passRTotal, "$0.00")
        lblSubTotal.Text = Format(passRTotal, "$0.00")
        lblTax.Text = Format(salesTax, "$0.00")
        lblTotal.Text = Format(fTotal, "$0.00")
    End Function

    Private Function buildReciept()
        Dim reciept As String
        Dim lboxHeight As Integer
        lboxHeight = 0
        While lboxItemNum.Items.Count > 0
            '
            'Go thru each item, add it to receipt, remove it from list
            '
            lboxHeight += 16
            lboxReceiptAmt.Items.Add(lboxItemAmt.Items.Item(lboxItemNum.Items.Count - 1))
            lboxReceiptPrice.Items.Add(lboxItemPrice.Items.Item(lboxItemNum.Items.Count - 1))
            lboxReceiptLinePrice.Items.Add(lboxItemLinePrice.Items.Item(lboxItemNum.Items.Count - 1))
            lboxReceiptName.Items.Add(lboxItemName.Items.Item(lboxItemNum.Items.Count - 1))
            lboxItemAmt.Items.RemoveAt(lboxItemNum.Items.Count - 1)
            lboxItemPrice.Items.RemoveAt(lboxItemNum.Items.Count - 1)
            lboxItemLinePrice.Items.RemoveAt(lboxItemNum.Items.Count - 1)
            lboxItemName.Items.RemoveAt(lboxItemNum.Items.Count - 1)
            lboxItemNum.Items.RemoveAt(lboxItemNum.Items.Count - 1)
        End While
        '
        'Set the height of the receipt based on number of items on list
        '
        lboxReceiptAmt.Size = New System.Drawing.Size(20, lboxHeight)
        lboxReceiptName.Size = New System.Drawing.Size(150, lboxHeight)
        lboxReceiptPrice.Size = New System.Drawing.Size(50, lboxHeight)
        lboxReceiptLinePrice.Size = New System.Drawing.Size(50, lboxHeight)
        btnReceiptClose.Location = New System.Drawing.Point(235, lboxHeight + 175)
        lblReceiptTotals.Location = New System.Drawing.Point(100, lboxHeight + 100)
        lblReceiptTotals.Text = "Sub Total............" & Format(rTotal, "$0.00") & MyCRLF & "Tax @ 7%..........." & Format(salesTax, "$0.00") & MyCRLF & "Total..................." & Format(fTotal, "$0.00") & MyCRLF & "Amount Paid......." & Format((fTotal + amtDue), "$0.00") & MyCRLF & "Change..............." & Format(amtDue, "$0.00")
        lblReceipt.Text = "Thank you for shopping Food 'R' Us" & MyCRLF & "123 Store Ln." & MyCRLF & "Las Vegas NV, 89154" & MyCRLF & "Cashier: " & cUserName & MyCRLF & System.DateTime.Now

        gboxReceipt.Location = New System.Drawing.Point(200, 0)
        gboxReceipt.Size = New System.Drawing.Size(294, lboxHeight + 240)
        gboxReceipt.BringToFront()
    End Function

    Private Function loadSearch()
        typeBuffer = ""
        gboxSearch.Visible() = True
        gboxSearch.Location = New System.Drawing.Point(232, 24)
        gboxSearch.Size = New System.Drawing.Size(384, 280)
        gboxSearch.BringToFront()
        btnSelect.Enabled() = False
        hideKeypad()
    End Function

    Private Function hideSearch()
        gboxSearch.Location = New System.Drawing.Point(0, 0)
        gboxSearch.Size = New System.Drawing.Size(0, 0)
        gboxSearch.Visible() = False
    End Function

    Private Function processSrchBtn(ByVal srchCat As String)
        lboxResults.Items.Clear()
        eprRead = eprFile.OpenText(productFile)
        '
        'Read file to simulate items scanned
        '
        Do Until eprRead.Peek = -1
            eprContents = eprRead.ReadLine()
            Dim splitRecord = Split(eprContents, fileDelimeter)
            itemNum = splitRecord(0)
            itemName = splitRecord(1)
            itemCat = splitRecord(3)
            If (itemCat = srchCat) Then
                '
                'if item already on list, add list
                '
                lboxResults.Items.Add(itemNum & "  " & itemName)
            End If
        Loop
    End Function

    Private Sub tmrOne_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrOne.Tick
        lblTime.Text = System.DateTime.Now
    End Sub
#End Region
End Class
