VERSION 5.00
Begin VB.Form frmDebug 
   Caption         =   "Debug"
   ClientHeight    =   3195
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   ScaleHeight     =   3195
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox txtOutput 
      Height          =   375
      Left            =   1200
      TabIndex        =   1
      Top             =   960
      Width           =   1935
   End
   Begin VB.CommandButton cmdDebug 
      Caption         =   "Debug"
      Height          =   375
      Left            =   1320
      TabIndex        =   0
      Top             =   2280
      Width           =   1695
   End
End
Attribute VB_Name = "frmDebug"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdDebug_Click()
Dim intInnerCounter As Integer
Dim intOuterCounter As Integer
Dim intSum As Long

intSum = 0

For intOuterCounter = 1 To 3
  For intInnerCounter = 1 To 100
    intSum = intSum + intInnerCounter
  Next intInnerCounter
Next intOuterCounter
  
txtOutput.Text = Str(intSum)

End Sub

