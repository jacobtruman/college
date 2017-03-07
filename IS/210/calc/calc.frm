VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   3195
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   ScaleHeight     =   3195
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox txtcalc 
      Height          =   285
      Left            =   2400
      TabIndex        =   10
      Text            =   "0"
      Top             =   720
      Width           =   2055
   End
   Begin VB.CommandButton btn0 
      Caption         =   "0"
      Height          =   375
      Index           =   8
      Left            =   960
      TabIndex        =   9
      Top             =   2040
      Width           =   375
   End
   Begin VB.CommandButton btn9 
      Caption         =   "9"
      Height          =   375
      Index           =   7
      Left            =   1440
      TabIndex        =   8
      Top             =   1560
      Width           =   375
   End
   Begin VB.CommandButton btn8 
      Caption         =   "8"
      Height          =   375
      Index           =   6
      Left            =   960
      TabIndex        =   7
      Top             =   1560
      Width           =   375
   End
   Begin VB.CommandButton btn7 
      Caption         =   "7"
      Height          =   375
      Index           =   5
      Left            =   480
      TabIndex        =   6
      Top             =   1560
      Width           =   375
   End
   Begin VB.CommandButton btn6 
      Caption         =   "6"
      Height          =   375
      Index           =   4
      Left            =   1440
      TabIndex        =   5
      Top             =   1080
      Width           =   375
   End
   Begin VB.CommandButton btn3 
      Caption         =   "3"
      Height          =   375
      Index           =   3
      Left            =   1440
      TabIndex        =   4
      Top             =   600
      Width           =   375
   End
   Begin VB.CommandButton btn4 
      Caption         =   "4"
      Height          =   375
      Index           =   2
      Left            =   480
      TabIndex        =   3
      Top             =   1080
      Width           =   375
   End
   Begin VB.CommandButton btn5 
      Caption         =   "5"
      Height          =   375
      Index           =   0
      Left            =   960
      TabIndex        =   2
      Top             =   1080
      Width           =   375
   End
   Begin VB.CommandButton btn2 
      Caption         =   "2"
      Height          =   375
      Index           =   1
      Left            =   960
      TabIndex        =   1
      Top             =   600
      Width           =   375
   End
   Begin VB.CommandButton btn1 
      Caption         =   "1"
      Height          =   375
      Index           =   0
      Left            =   480
      TabIndex        =   0
      Top             =   600
      Width           =   375
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdadd_Click()
Dim intTotal As Integer
Dim txt1val As Integer
Dim txt2val As Integer
txt1val = txt1
txt2val = txt2
intTotal = txt1val + txt2val
txttotal.Text = Str(intTotal)
End Sub

