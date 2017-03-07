VERSION 5.00
Begin VB.Form frmVoting 
   Caption         =   "TextBox Based Voting Booth"
   ClientHeight    =   3195
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   ScaleHeight     =   3195
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdResults 
      Caption         =   "Results"
      Height          =   495
      Left            =   2880
      TabIndex        =   5
      Top             =   1440
      Width           =   1575
   End
   Begin VB.CommandButton cmdVote 
      Caption         =   "Vote"
      Height          =   495
      Left            =   120
      TabIndex        =   4
      Top             =   1440
      Width           =   1575
   End
   Begin VB.TextBox txtVote 
      Height          =   285
      Left            =   120
      TabIndex        =   3
      Top             =   960
      Width           =   2535
   End
   Begin VB.Label lblResults 
      Height          =   735
      Left            =   120
      TabIndex        =   2
      Top             =   2280
      Width           =   4455
   End
   Begin VB.Label lblDirections 
      Caption         =   "Enter the name of the candidate you wish to cast your vote for"
      Height          =   375
      Left            =   120
      TabIndex        =   1
      Top             =   600
      Width           =   4455
   End
   Begin VB.Label lblTitle 
      Alignment       =   2  'Center
      Caption         =   "The Coach Voting Booth"
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
Attribute VB_Name = "frmVoting"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim intBushCount As Integer
Dim intGoreCount As Integer
Dim intNaderCount As Integer


Private Sub cmdResults_Click()
lblResults = "Bush had " & Str(intBushCount) & _
" Votes, Gore had " & intGoreCount & _
" Votes, and Nader had " & intNaderCount & " Votes"
End Sub

Private Sub cmdVote_Click()
If (txtVote.Text = "Bush") Then
  intBushCount = intBushCount + 1
End If
If (txtVote.Text = "Gore") Then
  intGoreCount = intGoreCount + 1
End If
If (txtVote.Text = "Nader") Then
  intNaderCount = intNaderCount + 1
End If

'Erase the vote
txtVote.Text = ""
End Sub

Private Sub Form_Load()
'Initialize the Voting values
BushCount = 0
GoreCount = 0
NadarCount = 0
End Sub
