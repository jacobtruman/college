VERSION 5.00
Begin VB.Form frmInvestment 
   Caption         =   "Investment Example"
   ClientHeight    =   2325
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   6780
   LinkTopic       =   "Form1"
   ScaleHeight     =   2325
   ScaleWidth      =   6780
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox txtDuration 
      Height          =   375
      Left            =   4680
      TabIndex        =   3
      Top             =   600
      Width           =   1575
   End
   Begin VB.TextBox txtPercentageReturn 
      Height          =   375
      Left            =   2580
      TabIndex        =   2
      Top             =   600
      Width           =   1575
   End
   Begin VB.TextBox txtInitialInvestment 
      Height          =   375
      Left            =   480
      TabIndex        =   1
      Top             =   600
      Width           =   1575
   End
   Begin VB.CommandButton cmdCalculate 
      Caption         =   "Calculate"
      Height          =   375
      Left            =   2520
      TabIndex        =   0
      Top             =   1560
      Width           =   1695
   End
   Begin VB.Label Label3 
      Caption         =   "Duration"
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
      Left            =   4680
      TabIndex        =   6
      Top             =   360
      Width           =   1695
   End
   Begin VB.Label Label2 
      Caption         =   "Return on Inv."
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
      Left            =   2640
      TabIndex        =   5
      Top             =   360
      Width           =   1575
   End
   Begin VB.Label Label1 
      Caption         =   "Initial Investment"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   480
      TabIndex        =   4
      Top             =   360
      Width           =   1575
   End
End
Attribute VB_Name = "frmInvestment"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdCalculate_Click()
'Declare local variables
Dim curValue As Currency
Dim intLoopCounter As Integer
Dim sngPercentageReturn As Single
Dim intDuration As Integer

'Initialize variables to values stored in TextBoxes
curValue = CCur(txtInitialInvestment.Text)
intDuration = CInt(txtDuration.Text)
sngPercentageReturn = CSng(txtPercentageReturn)

'Process Loop
For intLoopCounter = 1 To intDuration
  curValue = curValue + (curValue * sngPercentageReturn / 100)
Next intLoopCounter

MsgBox curValue
End Sub
