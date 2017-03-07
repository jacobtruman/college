VERSION 5.00
Begin VB.Form frmCounter 
   Caption         =   "Sample Counter Application"
   ClientHeight    =   3195
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   ScaleHeight     =   3195
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdReset 
      Caption         =   "Reset"
      Height          =   495
      Left            =   3000
      TabIndex        =   3
      Top             =   2040
      Width           =   1455
   End
   Begin VB.CommandButton cmdCounter 
      Caption         =   "Counter"
      Height          =   495
      Left            =   240
      TabIndex        =   2
      Top             =   2040
      Width           =   1455
   End
   Begin VB.Label lblCounter 
      Alignment       =   2  'Center
      Caption         =   "0"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   24
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   1793
      TabIndex        =   1
      Top             =   960
      Width           =   1095
   End
   Begin VB.Label lblTitle 
      Alignment       =   2  'Center
      Caption         =   "Sample Counter Application"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   4455
   End
End
Attribute VB_Name = "frmCounter"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim intCounter As Integer
Private Sub cmdCounter_Click()
intCounter = intCounter + 1 ' Increment counter by one
lblCounter.Caption = Str(intCounter) 'Assign result to Label
End Sub
Private Sub cmdReset_Click()
intCounter = 0 ' Reset counter variable
lblCounter = "0" 'Reset output label
End Sub
