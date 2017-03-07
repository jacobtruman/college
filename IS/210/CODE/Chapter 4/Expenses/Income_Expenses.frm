VERSION 5.00
Begin VB.Form frmIncomeExpenses 
   Caption         =   "Income and Expenses"
   ClientHeight    =   3195
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   ScaleHeight     =   3195
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdCalculate 
      Caption         =   "Calculate"
      Height          =   495
      Left            =   1440
      TabIndex        =   7
      Top             =   2400
      Width           =   2055
   End
   Begin VB.TextBox txtDifference 
      Height          =   285
      Left            =   120
      TabIndex        =   4
      Top             =   1680
      Width           =   1695
   End
   Begin VB.TextBox txtExpenses 
      Height          =   285
      Left            =   2400
      TabIndex        =   1
      Top             =   720
      Width           =   1695
   End
   Begin VB.TextBox txtIncome 
      Height          =   285
      Left            =   120
      TabIndex        =   0
      Top             =   720
      Width           =   1695
   End
   Begin VB.Label lblResult 
      Height          =   255
      Left            =   120
      TabIndex        =   6
      Top             =   120
      Width           =   4215
   End
   Begin VB.Label lblDifference 
      Caption         =   "Difference"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   5
      Top             =   1440
      Width           =   1335
   End
   Begin VB.Label lblExpenses 
      Caption         =   "Expenses"
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
      Left            =   2400
      TabIndex        =   3
      Top             =   480
      Width           =   1575
   End
   Begin VB.Label lblIncome 
      Caption         =   "Income"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   2
      Top             =   480
      Width           =   1815
   End
End
Attribute VB_Name = "frmIncomeExpenses"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdCalculate_Click()
'Declare local variables
Dim sngIncome As Single
Dim sngExpenses As Single
Dim sngDifference

'Convert Text Values
sngIncome = Val(txtIncome.Text)
sngExpenses = Val(txtExpenses.Text)

'Calculate Difference
sngDifference = sngIncome - sngExpenses

'Compute results
If (sngDifference > 0) Then
    lblResult.Caption = "You did a good job!"
End If

If (sngDifference < 0) Then
    lblResult.Caption = "You need to be more frugal"
End If

If (sngDifference = 0) Then
    lblResult.Caption = "You balanced your spending!"
End If

txtDifference.Text = Str(sngDifference)

End Sub
