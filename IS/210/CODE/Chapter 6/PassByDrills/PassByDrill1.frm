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
   Begin VB.CommandButton cmdCalculate 
      Caption         =   "&Calculate"
      Height          =   375
      Left            =   1200
      TabIndex        =   0
      Top             =   1680
      Width           =   1935
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdCalculate_Click()
Dim TestValue As Integer
TestValue = 5
MsgBox Str(SumValues(TestValue)) + " " + Str(TestValue)
End Sub

Private Function SumValues(ByVal MaxNum As Integer) As Integer
Dim Sum As Integer
Sum = 0
Do While (MaxNum > 0)
  Sum = Sum + MaxNum
  MaxNum = MaxNum - 1
Loop
SumValues = Sum
End Function

