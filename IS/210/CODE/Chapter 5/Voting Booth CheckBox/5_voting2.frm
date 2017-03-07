VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
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
      Begin VB.OptionButton optLiberman 
         Caption         =   "Joe Liberman"
         Height          =   255
         Left            =   120
         TabIndex        =   6
         Top             =   480
         Width           =   2295
      End
      Begin VB.OptionButton optChaney 
         Caption         =   "Dick Chaney"
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
      Begin VB.OptionButton optBucannan 
         Caption         =   "Pat Bucannan"
         Height          =   255
         Left            =   120
         TabIndex        =   10
         Top             =   960
         Width           =   1815
      End
      Begin VB.OptionButton optNadar 
         Caption         =   "Ralph Nadar"
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
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim BushCount As Integer
Dim GoreCount As Integer
Dim NadarCount As Integer
Dim BucannanCount As Integer
Dim ChaneyCount As Integer
Dim LibermanCount As Integer
Dim ErrorCount As Integer
Private Sub cmdResults_Click()

optBush.Caption = optBush.Caption & " (" & BushCount & ")"
optGore.Caption = optGore.Caption & " (" & GoreCount & ")"
optNadar.Caption = optNadar.Caption & " (" & NadarCount & ")"
optBucannan.Caption = optBucannan.Caption & " (" & BucannanCount & ")"
optChaney.Caption = optChaney.Caption & " (" & ChaneyCount & ")"
optLiberman.Caption = optLiberman.Caption & " (" & LibermanCount & ")"


End Sub

Private Sub cmdVote_Click()
If (optBush = True) Then
  BushCount = BushCount + 1
  optBush.Value = False 'Erase Vote
End If

If (optGore = True) Then
  GoreCount = GoreCount + 1
  optGore.Value = False 'Erase Vote
End If

If (optNadar = True) Then
  NadarCount = NadarCount + 1
  optNadar.Value = False 'Erase Vote
End If

If (optBucannan = True) Then
  BucannanCount = BucannanCount + 1
  optBucannan.Value = False 'Erase Vote
End If

If (optChaney = True) Then
  ChaneyCount = ChaneyCount + 1
  optChaney.Value = False 'Erase Vote
End If

If (optLiberman = True) Then
  LibermanCount = LibermanCount + 1
  optLiberman.Value = False 'Erase Vote
End If

End Sub

Private Sub Form_Load()
'Initialize the Voting values
BushCount = 0
GoreCount = 0
NadarCount = 0
BucannanCount = 0
ChaneyCount = 0
LibermanCount = 0
ErrorCount = 0
End Sub
