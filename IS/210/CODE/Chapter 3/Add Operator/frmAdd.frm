VERSION 5.00
Begin VB.Form frmAdd 
   Caption         =   "Addition Operator"
   ClientHeight    =   1980
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4635
   LinkTopic       =   "Form1"
   ScaleHeight     =   1980
   ScaleWidth      =   4635
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox txtOutput 
      Height          =   375
      Left            =   1493
      TabIndex        =   1
      Top             =   480
      Width           =   1695
   End
   Begin VB.CommandButton CmdAdd 
      Caption         =   "Add"
      Height          =   495
      Left            =   1800
      TabIndex        =   0
      Top             =   1200
      Width           =   1215
   End
End
Attribute VB_Name = "frmAdd"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub CmdAdd_Click()

Dim intTotal As Integer 'Declares an Integer variable

intTotal = 1 + 1 'Performs the addition and stores the result

'Note conversion of Integer to String
txtOutput.Text = Str(intTotal) ' Store result in Textbox

End Sub
