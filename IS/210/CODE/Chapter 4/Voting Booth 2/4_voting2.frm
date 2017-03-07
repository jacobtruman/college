VERSION 5.00
Begin VB.Form frmVoting 
   Caption         =   "Error Tracking Voting Booth."
   ClientHeight    =   3195
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   ScaleHeight     =   3195
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox txtVote 
      Height          =   285
      Left            =   120
      TabIndex        =   4
      Top             =   1080
      Width           =   3255
   End
   Begin VB.CommandButton cmdResults 
      Caption         =   "Results"
      Height          =   495
      Left            =   2880
      TabIndex        =   2
      Top             =   1560
      Width           =   1695
   End
   Begin VB.CommandButton cmdVote 
      Caption         =   "Vote"
      Height          =   495
      Left            =   240
      TabIndex        =   1
      Top             =   1560
      Width           =   1695
   End
   Begin VB.Label lblResults 
      Height          =   735
      Left            =   120
      TabIndex        =   5
      Top             =   2280
      Width           =   4335
   End
   Begin VB.Label Label2 
      Caption         =   "Enter the name of the candidate you wish to cast your vote for"
      Height          =   255
      Left            =   120
      TabIndex        =   3
      Top             =   720
      Width           =   4455
   End
   Begin VB.Label Label1 
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
Dim intErrorCount As Integer

Private Sub cmdResults_Click()
lblResults = "Bush had " & intBushCount & " Votes, Gore had " _
& intGoreCount & " Votes, Nader had " & intNaderCount & _
" Votes, and there were " & intErrorCount & " Errors"
End Sub

Private Sub cmdVote_Click()
If (txtVote.Text = "Bush") Then
  intBushCount = intBushCount + 1
ElseIf (txtVote.Text = "Gore") Then
  intGoreCount = intGoreCount + 1
ElseIf (txtVote.Text = "Nader") Then
  intNaderCount = intNaderCount + 1
Else
  intErrorCount = intErrorCount + 1
End If

'Erase the vote
txtVote.Text = ""
End Sub

Private Sub Form_Load()
'Initialize the Voting values
intBushCount = 0
intGoreCount = 0
intNaderCount = 0
intErrorCount = 0
End Sub
