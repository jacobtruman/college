VERSION 5.00
Begin VB.Form frmOptionButtonVoting 
   Caption         =   "OptionButton Voting Booth"
   ClientHeight    =   3030
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   5760
   ForeColor       =   &H000000FF&
   LinkTopic       =   "Form1"
   ScaleHeight     =   3030
   ScaleWidth      =   5760
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame Frame2 
      Caption         =   "Vice President"
      Height          =   855
      Left            =   2880
      TabIndex        =   4
      Top             =   840
      Width           =   2535
      Begin VB.OptionButton optLieberman 
         Caption         =   "Joe Lieberman"
         Height          =   255
         Left            =   120
         TabIndex        =   6
         Top             =   480
         Width           =   2295
      End
      Begin VB.OptionButton optCheney 
         Caption         =   "Dick Cheney"
         Height          =   255
         Left            =   120
         TabIndex        =   5
         Top             =   240
         Width           =   2295
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "President"
      Height          =   1335
      Left            =   120
      TabIndex        =   3
      Top             =   840
      Width           =   2535
      Begin VB.OptionButton optBuchannan 
         Caption         =   "Pat Buchannan"
         Height          =   255
         Left            =   120
         TabIndex        =   10
         Top             =   960
         Width           =   1815
      End
      Begin VB.OptionButton optNader 
         Caption         =   "Ralph Nader"
         Height          =   255
         Left            =   120
         TabIndex        =   9
         Top             =   720
         Width           =   2175
      End
      Begin VB.OptionButton optGore 
         Caption         =   "Al Gore"
         Height          =   255
         Left            =   120
         TabIndex        =   8
         Top             =   480
         Width           =   2175
      End
      Begin VB.OptionButton optBush 
         Caption         =   "George Bush"
         Height          =   255
         Left            =   120
         TabIndex        =   7
         Top             =   240
         Width           =   2055
      End
   End
   Begin VB.CommandButton cmdResults 
      Caption         =   "Results"
      Height          =   495
      Left            =   3120
      TabIndex        =   2
      Top             =   2400
      Width           =   1695
   End
   Begin VB.CommandButton cmdVote 
      Caption         =   "Vote"
      Height          =   495
      Left            =   600
      TabIndex        =   1
      Top             =   2400
      Width           =   1695
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
      Left            =   653
      TabIndex        =   0
      Top             =   120
      Width           =   4455
   End
End
Attribute VB_Name = "frmOptionButtonVoting"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim intBushCount As Integer
Dim intGoreCount As Integer
Dim intNaderCount As Integer
Dim intBuchannanCount As Integer
Dim intCheneyCount As Integer
Dim intLiebermanCount As Integer
Dim intErrorCount As Integer
Private Sub cmdResults_Click()

optBush.Caption = optBush.Caption & " (" & intBushCount & ")"
optGore.Caption = optGore.Caption & " (" & intGoreCount & ")"
optNader.Caption = optNader.Caption & " (" & intNaderCount & ")"
optBuchannan.Caption = optBuchannan.Caption & " (" & intBuchannanCount & ")"
optCheney.Caption = optCheney.Caption & " (" & intCheneyCount & ")"
optLieberman.Caption = optLieberman.Caption & " (" & intLiebermanCount & ")"

End Sub

Private Sub cmdVote_Click()
If (optBush.Value = True) Then
  intBushCount = intBushCount + 1
  optBush.Value = False 'Erase Vote
End If

If (optGore.Value = True) Then
  intGoreCount = intGoreCount + 1
  optGore.Value = False 'Erase Vote
End If

If (optNader.Value = True) Then
  intNaderCount = NaderCount + 1
  optNader.Value = False 'Erase Vote
End If

If (optBuchannan.Value = True) Then
  intBuchannanCount = intBuchannanCount + 1
  optBuchannan.Value = False 'Erase Vote
End If

If (optCheney.Value = True) Then
  intCheneyCount = intCheneyCount + 1
  optCheney.Value = False 'Erase Vote
End If

If (optLieberman.Value = True) Then
  intLiebermanCount = intLiebermanCount + 1
  optLieberman.Value = False 'Erase Vote
End If

End Sub

Private Sub Form_Load()
'Initialize the Voting values
intBushCount = 0
intGoreCount = 0
intNaderCount = 0
intBuchannanCount = 0
intCheneyCount = 0
intLiebermanCount = 0
intErrorCount = 0
End Sub
