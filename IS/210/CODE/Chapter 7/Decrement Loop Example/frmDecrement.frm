VERSION 5.00
Begin VB.Form frmDecrement 
   Caption         =   "Decrement Loop Example"
   ClientHeight    =   3195
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   ScaleHeight     =   3195
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdOutput 
      Caption         =   "Output"
      Height          =   375
      Left            =   1440
      TabIndex        =   1
      Top             =   1920
      Width           =   1695
   End
   Begin VB.TextBox txtOutput 
      Height          =   285
      Left            =   1320
      TabIndex        =   0
      Top             =   1200
      Width           =   1815
   End
End
Attribute VB_Name = "frmDecrement"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdOutput_Click()
Dim intCounter As Integer

For intCounter = 5 To 1 Step -1
  txtOutput.Text = txtOutput.Text & Str(intCounter) & " "
Next intCounter

End Sub
