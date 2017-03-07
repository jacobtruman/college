VERSION 5.00
Begin VB.Form frmCheckBoxVoting 
   Caption         =   "CheckBox Voting Example"
   ClientHeight    =   3030
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   5760
   ForeColor       =   &H000000FF&
   LinkTopic       =   "Form1"
   ScaleHeight     =   3030
   ScaleWidth      =   5760
   StartUpPosition =   3  'Windows Default
   Begin VB.CheckBox chkLieberman 
      Caption         =   "Joe Lieberman"
      Height          =   195
      Left            =   3000
      TabIndex        =   10
      Top             =   1200
      Width           =   1935
   End
   Begin VB.CheckBox chkCheney 
      Caption         =   "Dick Cheney"
      Height          =   255
      Left            =   3000
      TabIndex        =   9
      Top             =   840
      Width           =   1815
   End
   Begin VB.CheckBox chkBuchannan 
      Caption         =   "Pat Buchannan"
      Height          =   195
      Left            =   600
      TabIndex        =   6
      Top             =   1800
      Width           =   2055
   End
   Begin VB.CheckBox chkNader 
      Caption         =   "Ralph Nader"
      Height          =   255
      Left            =   600
      TabIndex        =   5
      Top             =   1440
      Width           =   1935
   End
   Begin VB.CheckBox chkGore 
      Caption         =   "Al Gore"
      Height          =   375
      Left            =   600
      TabIndex        =   4
      Top             =   1080
      Width           =   1815
   End
   Begin VB.CheckBox chkBush 
      Caption         =   "George Bush"
      Height          =   255
      Left            =   600
      TabIndex        =   3
      Top             =   840
      Width           =   1695
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
   Begin VB.Label lblVicePresident 
      Caption         =   "Vice President"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   3000
      TabIndex        =   8
      Top             =   600
      Width           =   2175
   End
   Begin VB.Label lblPresident 
      Caption         =   "President"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   600
      TabIndex        =   7
      Top             =   600
      Width           =   1215
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
Attribute VB_Name = "frmCheckBoxVoting"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim intBushCount As Integer
Dim intGoreCount As Integer
Dim intNaderCount As Integer
Dim intBuchannanCount As Integer
Dim intCheneyCount As Integer
Dim intLibermanCount As Integer
Private Sub cmdResults_Click()

chkBush.Caption = chkBush.Caption & " (" & Str(intBushCount) & ")"
chkGore.Caption = chkGore.Caption & " (" & Str(intGoreCount) & ")"
chkNader.Caption = chkNader.Caption & " (" & Str(intNaderCount) & ")"
chkBuchannan.Caption = chkBuchannan.Caption & " (" & Str(intBuchannanCount) & ")"
chkCheney.Caption = chkCheney.Caption & " (" & Str(intCheneyCount) & ")"
chkLieberman.Caption = chkLieberman.Caption & " (" & Str(intLiebermanCount) & ")"

End Sub
Private Sub cmdVote_Click()
If (chkBush.Value = 1) Then
  intBushCount = intBushCount + 1
  chkBush.Value = 0 'Erase Vote
End If

If (chkGore.Value = 1) Then
  intGoreCount = intGoreCount + 1
  chkGore.Value = 0 'Erase Vote
End If

If (chkNader.Value = 1) Then
  NaderCount = NaderCount + 1
  chkNader.Value = 0 'Erase Vote
End If

If (chkBuchannan.Value = 1) Then
  BuchannanCount = BuchannanCount + 1
  chkBuchannan.Value = 0 'Erase Vote
End If

If (chkCheney.Value = 1) Then
  intCheneyCount = intCheneyCount + 1
  chkCheney.Value = 0 'Erase Vote
End If

If (chkLieberman.Value = 1) Then
  intLiebermanCount = intLiebermanCount + 1
  chkLieberman.Value = 0 'Erase Vote
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

