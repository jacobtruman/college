VERSION 5.00
Begin VB.Form frmRating 
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
      ItemData        =   "Rating.frx":0000
      Left            =   1920
      List            =   "Rating.frx":0022
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
Attribute VB_Name = "frmRating"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim Ratings(1 To 10) As Integer
Dim TotalVotes As Integer
Private Sub cmdRating_Click()
Dim OutputString As String
Ratings(cmbRating) = Ratings(cmbRating) + 1
TotalVotes = TotalVotes + 1
If (TotalVotes = 10) Then
  For Vote = 1 To 10
    OutputString = OutputString + Str(Vote) + "] " + Str(Ratings(Vote))
  Next Vote
  MsgBox OutputString
End If
End Sub
