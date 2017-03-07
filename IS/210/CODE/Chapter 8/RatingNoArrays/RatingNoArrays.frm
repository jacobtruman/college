VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   2310
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4545
   LinkTopic       =   "Form1"
   ScaleHeight     =   2310
   ScaleWidth      =   4545
   StartUpPosition =   3  'Windows Default
   Begin VB.ComboBox cmbRating 
      Height          =   315
      ItemData        =   "RatingNoArrays.frx":0000
      Left            =   1920
      List            =   "RatingNoArrays.frx":0022
      TabIndex        =   1
      Top             =   1080
      Width           =   735
   End
   Begin VB.CommandButton cmdRating 
      Caption         =   "Submit Rating"
      Height          =   375
      Left            =   1245
      TabIndex        =   0
      Top             =   1800
      Width           =   2055
   End
   Begin VB.Label Label1 
      Caption         =   "Rating"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   1845
      TabIndex        =   2
      Top             =   480
      Width           =   855
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim Rating1 As Integer
Dim Rating2 As Integer
Dim Rating3 As Integer
Dim Rating4 As Integer
Dim Rating5 As Integer
Dim Rating6 As Integer
Dim Rating7 As Integer
Dim Rating8 As Integer
Dim Rating9 As Integer
Dim Rating10 As Integer
Dim TotalVotes As Integer
Private Sub cmdRating_Click()
Select Case cmbRating
  Case 1
    Rating1 = Rating1 + 1
  Case 2
    Rating1 = Rating1 + 1
  Case 3
    Rating1 = Rating1 + 1
  Case 4
    Rating1 = Rating1 + 1
  Case 5
    Rating1 = Rating1 + 1
  Case 6
    Rating1 = Rating1 + 1
  Case 7
    Rating1 = Rating1 + 1
   Case 8
    Rating1 = Rating1 + 1
  Case 9
    Rating1 = Rating1 + 1
  Case 10
    Rating1 = Rating1 + 1
End Select

TotalVotes = TotalVotes + 1

If (TotalVotes = 10) Then
  Call OutputResults
End If
End Sub

Private Sub OutputResults()
Dim OutputString As String
    OutputString = OutputString + "1] " + Str(Rating1) + _
    ", 2] " + Str(Rating2) + ", 3]" + Str(Rating3) + _
    ", 4] " + Str(Rating4) + ", 5]" + Str(Rating5) + _
    ", 6] " + Str(Rating6) + ", 7]" + Str(Rating7) + _
    ", 8] " + Str(Rating8) + ", 9]" + Str(Rating9) + _
    ", 10] " + Str(Rating10)
  MsgBox OutputString
End Sub
