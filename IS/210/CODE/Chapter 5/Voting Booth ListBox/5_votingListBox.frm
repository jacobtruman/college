VERSION 5.00
Begin VB.Form frmListBoxVotingBooth 
   Caption         =   "ListBox Voting Booth"
   ClientHeight    =   3270
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   5760
   ForeColor       =   &H000000FF&
   LinkTopic       =   "Form1"
   ScaleHeight     =   3270
   ScaleWidth      =   5760
   StartUpPosition =   3  'Windows Default
   Begin VB.ListBox lstPhilaMayor 
      Height          =   450
      ItemData        =   "5_votingListBox.frx":0000
      Left            =   2880
      List            =   "5_votingListBox.frx":000A
      TabIndex        =   10
      Top             =   1920
      Width           =   2295
   End
   Begin VB.ListBox lstNYSen 
      Height          =   450
      ItemData        =   "5_votingListBox.frx":0025
      Left            =   120
      List            =   "5_votingListBox.frx":002F
      TabIndex        =   9
      Top             =   1920
      Width           =   2535
   End
   Begin VB.ListBox lstVicePres 
      Height          =   450
      ItemData        =   "5_votingListBox.frx":004F
      Left            =   2880
      List            =   "5_votingListBox.frx":0059
      TabIndex        =   8
      Top             =   960
      Width           =   2295
   End
   Begin VB.ListBox lstPres 
      Height          =   450
      ItemData        =   "5_votingListBox.frx":0079
      Left            =   120
      List            =   "5_votingListBox.frx":0089
      TabIndex        =   7
      Top             =   960
      Width           =   2535
   End
   Begin VB.CommandButton cmdResults 
      Caption         =   "Results"
      Height          =   495
      Left            =   3120
      TabIndex        =   2
      Top             =   2640
      Width           =   1695
   End
   Begin VB.CommandButton cmdVote 
      Caption         =   "Vote"
      Height          =   495
      Left            =   720
      TabIndex        =   1
      Top             =   2640
      Width           =   1695
   End
   Begin VB.Label Label5 
      Caption         =   "Mayor Philadelphia"
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
      Left            =   2880
      TabIndex        =   6
      Top             =   1680
      Width           =   2535
   End
   Begin VB.Label Label4 
      Caption         =   "NY Senator"
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
      Left            =   120
      TabIndex        =   5
      Top             =   1680
      Width           =   1575
   End
   Begin VB.Label Label3 
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
      Left            =   120
      TabIndex        =   4
      Top             =   720
      Width           =   2055
   End
   Begin VB.Label Label2 
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
      Left            =   2880
      TabIndex        =   3
      Top             =   720
      Width           =   2655
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
Attribute VB_Name = "frmListBoxVotingBooth"
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
Dim intLazloCount As Integer
Dim intClintonCount As Integer
Dim intStreetCount As Integer
Dim intKatzCount As Integer

Private Sub cmdResults_Click()
'President
lstPres.List(0) = lstPres.List(0) & " (" & intBushCount & ")"
lstPres.List(1) = lstPres.List(1) & " (" & intGoreCount & ")"
lstPres.List(2) = lstPres.List(2) & " (" & intNaderCount & ")"
lstPres.List(3) = lstPres.List(3) & " (" & intBuchannanCount & ")"

'Vice President
lstVicePres.List(0) = lstVicePres.List(0) & " (" & intCheneyCount & ")"
lstVicePres.List(1) = lstVicePres.List(1) & " (" & intLiebermanCount & ")"

'NY Senator
lstNYSen.List(0) = lstNYSen.List(0) & " (" & intLazloCount & ")"
lstNYSen.List(1) = lstNYSen.List(1) & " (" & intClintonCount & ")"

'Philadelphia Mayor
lstPhilaMayor.List(0) = lstPhilaMayor.List(0) & " (" & intStreetCount & ")"
lstPhilaMayor.List(1) = lstPhilaMayor.List(1) & " (" & intKatzCount & ")"
End Sub
Private Sub cmdVote_Click()
Select Case lstPres.Text
   Case "George Bush"
      intBushCount = intBushCount + 1
   Case "Al Gore"
      intGoreCount = intGoreCount + 1
   Case "Ralph Nader"
      intNaderCount = intNaderCount + 1
   Case "Pat Buchannan"
      intBuchannanCount = intBuchannanCount + 1
End Select
lstPres.ListIndex = -1 'Reset the ListBox to unselected

Select Case lstVicePres.Text
  Case "Dick Cheney"
     CheneyCount = CheneyCount + 1
  Case "Joe Lieberman"
     intLiebermanCount = intLiebermanCount + 1
End Select
lstVicePres.ListIndex = -1 'Reset the ListBox to unselected

Select Case lstNYSen.Text
  Case "Rick Lazlo"
     intLazloCount = intLazloCount + 1
  Case "Hillary Clinton"
     intClintonCount = intClintonCount + 1
End Select
lstNYSen.ListIndex = -1 'Reset the ListBox to unselected

Select Case lstPhilaMayor.Text
Case "John Street"
     intStreetCount = intStreetCount + 1
  Case "Sam Katz"
     intKatzCount = intKatzCount + 1
End Select
lstPhilaMayor.ListIndex = -1 'Reset the ListBox to unselected

End Sub
Private Sub Form_Load()
'Initialize the Voting values
intBushCount = 0
intGoreCount = 0
intNaderCount = 0
intBuchannanCount = 0
intCheneyCount = 0
intLiebermanCount = 0
intLazloCount = 0
intClintonCount = 0
intStreetCount = 0
intKatzCount = 0
intErrorCount = 0
End Sub
