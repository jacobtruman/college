VERSION 5.00
Begin VB.Form frmSalesTax 
   Caption         =   "Sales Tax Calculation"
   ClientHeight    =   3195
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   ScaleHeight     =   3195
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox txtFinalPrice 
      Height          =   375
      Left            =   2400
      TabIndex        =   2
      Top             =   1680
      Width           =   2175
   End
   Begin VB.TextBox txtSalesTax 
      Height          =   375
      Left            =   2400
      TabIndex        =   1
      Top             =   1200
      Width           =   2175
   End
   Begin VB.CommandButton cmdCalculate 
      Caption         =   "Calculate"
      Height          =   495
      Left            =   1320
      TabIndex        =   3
      Top             =   2400
      Width           =   2175
   End
   Begin VB.TextBox txtPurchasePrice 
      Height          =   375
      Left            =   2400
      TabIndex        =   0
      Top             =   720
      Width           =   2175
   End
   Begin VB.Label lblFinalPrice 
      Caption         =   "Final Price:"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   1080
      TabIndex        =   7
      Top             =   1680
      Width           =   1335
   End
   Begin VB.Label lblSalesTax 
      Caption         =   "Sales Tax:"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   1080
      TabIndex        =   6
      Top             =   1200
      Width           =   1215
   End
   Begin VB.Label lblPurchasePrice 
      Caption         =   "Purchase Price:"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   600
      TabIndex        =   5
      Top             =   720
      Width           =   1815
   End
   Begin VB.Label Label1 
      Caption         =   "Sales Tax Calculation"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   840
      TabIndex        =   4
      Top             =   0
      Width           =   3135
   End
End
Attribute VB_Name = "frmSalesTax"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdCalculate_Click()
 Const curSalesTaxRate As Currency = 0.06 'Sales Tax Rate
 
 'Variables to store temporary values
 Dim curSalesTaxAmount As Currency
 Dim curFinalPrice As Currency
 Dim curPurchasePrice As Currency
 
 'Convert text in TextBox to a numerical value
 curPurchasePrice = Val(txtPurchasePrice.Text)
 
 'Calculate the Amount of the Sales Tax
 curSalesTaxAmount = curSalesTaxRate * curPurchasePrice
 
 'Calculate the total price with the sales tax included
 curFinalPrice = curPurchasePrice + curSalesTaxAmount
 
 txtSalesTax.Text = Str(curSalesTaxAmount)
 txtFinalPrice.Text = Str(curFinalPrice)
End Sub
