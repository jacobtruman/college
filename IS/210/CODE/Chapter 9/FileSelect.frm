VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   1500
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7155
   LinkTopic       =   "Form1"
   ScaleHeight     =   1500
   ScaleWidth      =   7155
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox txtFile 
      Height          =   375
      Left            =   150
      TabIndex        =   1
      Top             =   120
      Width           =   6855
   End
   Begin VB.CommandButton cmdSelect 
      Caption         =   "&Select File"
      Height          =   375
      Left            =   2850
      TabIndex        =   0
      Top             =   840
      Width           =   1455
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdSelect_Click()
'Set File Open dialog properties
With dlgFileOpen
    .CancelError = False
    .Filter = "*.txt"
    .DialogTitle = "Select an Text File"
    .ShowOpen
End With
   
If (Len(dlgFileOpen.FileName) > 0) Then
   txtFile = dlgFileOpen.FileName  'Set variable to input file name
Else
   MsgBox "No File Selected"
   Exit Sub
End If
End Sub
