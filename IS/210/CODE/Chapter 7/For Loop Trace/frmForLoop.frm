VERSION 5.00
Begin VB.Form frmForLoop 
   Caption         =   "For Loop Trace"
   ClientHeight    =   3195
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   ScaleHeight     =   3195
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdForLoop 
      Caption         =   "For Loop"
      Height          =   495
      Left            =   1440
      TabIndex        =   0
      Top             =   2400
      Width           =   2175
   End
End
Attribute VB_Name = "frmForLoop"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdForLoop_Click()
Dim intSum As Integer
Dim intCounter As Integer

intSum = 0

For intCounter = 1 To 5
    intSum = intSum + intCounter
Next intCounter

MsgBox Str(intSum)
End Sub
