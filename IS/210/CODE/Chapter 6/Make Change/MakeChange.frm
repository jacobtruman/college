VERSION 5.00
Begin VB.Form frmMakeChange 
   Caption         =   "Make Change"
   ClientHeight    =   5085
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   6225
   LinkTopic       =   "Form1"
   ScaleHeight     =   5085
   ScaleWidth      =   6225
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdMakeChange 
      Caption         =   "&Make Change"
      Height          =   375
      Left            =   2400
      TabIndex        =   6
      Top             =   4560
      Width           =   1455
   End
   Begin VB.TextBox txtChange 
      Height          =   2415
      Left            =   1125
      MultiLine       =   -1  'True
      TabIndex        =   4
      Top             =   1800
      Width           =   3975
   End
   Begin VB.TextBox txtAmountPaid 
      Height          =   285
      Left            =   3600
      TabIndex        =   1
      Top             =   960
      Width           =   1455
   End
   Begin VB.TextBox txtPurchasePrice 
      Height          =   285
      Left            =   1080
      TabIndex        =   0
      Top             =   960
      Width           =   1575
   End
   Begin VB.Label Label3 
      Caption         =   "Change"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   1125
      TabIndex        =   5
      Top             =   1560
      Width           =   2175
   End
   Begin VB.Label Label2 
      Caption         =   "Amount Paid"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   3600
      TabIndex        =   3
      Top             =   720
      Width           =   1335
   End
   Begin VB.Label Label1 
      Caption         =   "Purchase Price"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   1080
      TabIndex        =   2
      Top             =   720
      Width           =   1575
   End
End
Attribute VB_Name = "frmMakeChange"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdMakeChange_Click()
   Call MakeChange(Val(txtPurchasePrice), Val(txtAmountPaid))
End Sub
Private Sub MakeChange(PurchasePrice As Currency, AmountPaid As Currency)
Dim TotalChange As Currency


TotalChange = AmountPaid - PurchasePrice
Call PrintBills(TotalChange, 100)
Call PrintBills(TotalChange, 50)
Call PrintBills(TotalChange, 20)
Call PrintBills(TotalChange, 10)
Call PrintBills(TotalChange, 5)
Call PrintBills(TotalChange, 1)
Call PrintBills(TotalChange, 0.25)
Call PrintBills(TotalChange, 0.1)
Call PrintBills(TotalChange, 0.05)
Call PrintBills(TotalChange, 0.01)
End Sub

Private Sub PrintBills(TChange As Currency, Denomination As Currency)
Dim NumBills As Integer
  
NumBills = Int(TChange / Denomination)
TChange = TChange - Denomination * NumBills
  
If (NumBills > 0) Then
  If (Denomination >= 1) Then
     txtChange = txtChange & NumBills & " $" & Denomination & " bill"
  Else
     If (Denomination = 0.25) Then
        txtChange = txtChange & NumBills & " quarter"
     ElseIf (Denomination = 0.1) Then
        txtChange = txtChange & NumBills & " dime"
     ElseIf (Denomination = 0.05) Then
        txtChange = txtChange & NumBills & "nickle"
     ElseIf ((Denomination = 0.01) And (NumBills = 1)) Then
        txtChange = txtChange & NumBills & " penny"
     Else
        txtChange = txtChange & NumBills & " pennie"
     End If
  End If
      
  If (NumBills > 1) Then
     txtChange = txtChange + "s"
  End If
  txtChange = txtChange + vbNewLine
End If
End Sub
