VERSION 5.00
Begin VB.Form frmPuzzle 
   Caption         =   "Puzzle"
   ClientHeight    =   4755
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   6030
   LinkTopic       =   "Form1"
   ScaleHeight     =   4755
   ScaleWidth      =   6030
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdStart 
      Caption         =   "&Start"
      Height          =   615
      Left            =   4200
      TabIndex        =   20
      Top             =   3840
      Width           =   1575
   End
   Begin VB.CommandButton cmdDown 
      Caption         =   "&Down"
      Height          =   495
      Left            =   4440
      TabIndex        =   19
      Top             =   2280
      Width           =   615
   End
   Begin VB.CommandButton cmdLeft 
      Caption         =   "&Left"
      Height          =   495
      Left            =   3840
      TabIndex        =   18
      Top             =   1680
      Width           =   615
   End
   Begin VB.CommandButton cmdRight 
      Caption         =   "&Right"
      Height          =   495
      Left            =   5040
      TabIndex        =   17
      Top             =   1680
      Width           =   615
   End
   Begin VB.CommandButton cmdUp 
      Caption         =   "&Up"
      Height          =   495
      Left            =   4440
      TabIndex        =   16
      Top             =   1080
      Width           =   615
   End
   Begin VB.PictureBox pctGamePiece 
      BorderStyle     =   0  'None
      Height          =   800
      Index           =   15
      Left            =   2760
      Picture         =   "Puzzle.frx":0000
      ScaleHeight     =   795
      ScaleWidth      =   795
      TabIndex        =   15
      Top             =   3000
      Width           =   800
   End
   Begin VB.PictureBox pctGamePiece 
      BorderStyle     =   0  'None
      Height          =   800
      Index           =   14
      Left            =   1920
      Picture         =   "Puzzle.frx":0831
      ScaleHeight     =   795
      ScaleWidth      =   795
      TabIndex        =   14
      Top             =   3000
      Width           =   800
   End
   Begin VB.PictureBox pctGamePiece 
      BorderStyle     =   0  'None
      Height          =   800
      Index           =   13
      Left            =   1080
      Picture         =   "Puzzle.frx":1B72
      ScaleHeight     =   795
      ScaleWidth      =   795
      TabIndex        =   13
      Top             =   3000
      Width           =   800
   End
   Begin VB.PictureBox pctGamePiece 
      BorderStyle     =   0  'None
      Height          =   800
      Index           =   12
      Left            =   240
      Picture         =   "Puzzle.frx":2E21
      ScaleHeight     =   795
      ScaleWidth      =   795
      TabIndex        =   12
      Top             =   3000
      Width           =   800
   End
   Begin VB.PictureBox pctGamePiece 
      BorderStyle     =   0  'None
      Height          =   800
      Index           =   11
      Left            =   2760
      Picture         =   "Puzzle.frx":4217
      ScaleHeight     =   795
      ScaleWidth      =   795
      TabIndex        =   11
      Top             =   2160
      Width           =   800
   End
   Begin VB.PictureBox pctGamePiece 
      BorderStyle     =   0  'None
      Height          =   800
      Index           =   10
      Left            =   1920
      Picture         =   "Puzzle.frx":55D7
      ScaleHeight     =   795
      ScaleWidth      =   795
      TabIndex        =   10
      Top             =   2160
      Width           =   800
   End
   Begin VB.PictureBox pctGamePiece 
      BorderStyle     =   0  'None
      Height          =   800
      Index           =   9
      Left            =   1080
      Picture         =   "Puzzle.frx":67C2
      ScaleHeight     =   795
      ScaleWidth      =   795
      TabIndex        =   9
      Top             =   2160
      Width           =   800
   End
   Begin VB.PictureBox pctGamePiece 
      BorderStyle     =   0  'None
      Height          =   800
      Index           =   8
      Left            =   240
      Picture         =   "Puzzle.frx":7B58
      ScaleHeight     =   795
      ScaleWidth      =   795
      TabIndex        =   8
      Top             =   2160
      Width           =   800
   End
   Begin VB.PictureBox pctGamePiece 
      BorderStyle     =   0  'None
      Height          =   800
      Index           =   7
      Left            =   2760
      Picture         =   "Puzzle.frx":8A6D
      ScaleHeight     =   795
      ScaleWidth      =   795
      TabIndex        =   7
      Top             =   1320
      Width           =   800
   End
   Begin VB.PictureBox pctGamePiece 
      BorderStyle     =   0  'None
      Height          =   800
      Index           =   6
      Left            =   1920
      Picture         =   "Puzzle.frx":9A22
      ScaleHeight     =   795
      ScaleWidth      =   795
      TabIndex        =   6
      Top             =   1320
      Width           =   800
   End
   Begin VB.PictureBox pctGamePiece 
      BorderStyle     =   0  'None
      Height          =   800
      Index           =   5
      Left            =   1080
      Picture         =   "Puzzle.frx":A7E5
      ScaleHeight     =   795
      ScaleWidth      =   795
      TabIndex        =   5
      Top             =   1320
      Width           =   800
   End
   Begin VB.PictureBox pctGamePiece 
      BorderStyle     =   0  'None
      Height          =   800
      Index           =   4
      Left            =   240
      Picture         =   "Puzzle.frx":B72F
      ScaleHeight     =   795
      ScaleWidth      =   795
      TabIndex        =   4
      Top             =   1320
      Width           =   800
   End
   Begin VB.PictureBox pctGamePiece 
      BorderStyle     =   0  'None
      Height          =   800
      Index           =   3
      Left            =   2760
      Picture         =   "Puzzle.frx":C598
      ScaleHeight     =   795
      ScaleWidth      =   795
      TabIndex        =   3
      Top             =   480
      Width           =   800
   End
   Begin VB.PictureBox pctGamePiece 
      BorderStyle     =   0  'None
      Height          =   800
      Index           =   2
      Left            =   1920
      Picture         =   "Puzzle.frx":D2F7
      ScaleHeight     =   795
      ScaleWidth      =   795
      TabIndex        =   2
      Top             =   480
      Width           =   800
   End
   Begin VB.PictureBox pctGamePiece 
      BorderStyle     =   0  'None
      Height          =   800
      Index           =   1
      Left            =   1080
      Picture         =   "Puzzle.frx":E20E
      ScaleHeight     =   795
      ScaleWidth      =   795
      TabIndex        =   1
      Top             =   480
      Width           =   800
   End
   Begin VB.PictureBox pctGamePiece 
      BorderStyle     =   0  'None
      Height          =   800
      Index           =   0
      Left            =   240
      Picture         =   "Puzzle.frx":F0E6
      ScaleHeight     =   795
      ScaleWidth      =   795
      TabIndex        =   0
      Top             =   480
      Width           =   800
   End
End
Attribute VB_Name = "frmPuzzle"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim GamePieces(0 To 15) As Integer
Dim CurrentPos As Integer
Private Sub cmdUp_Click()
If (UpValid() = True) Then
   'Move internal representation of new square to piece
   GamePieces(CurrentPos - 4) = GamePieces(CurrentPos)
   'Set internal representation of old square to blank
   GamePieces(CurrentPos) = 0
   
   Call MoveHighlight(CurrentPos, CurrentPos - 4)
   pctGamePiece(CurrentPos).Picture = LoadPicture("c:\VB Coach\Chapter 8\Blank.jpg")
   CurrentPos = CurrentPos - 4
   pctGamePiece(CurrentPos).Picture = LoadPicture("c:\VB Coach\Chapter 8\" + Trim(Str(GamePieces(CurrentPos))) + ".jpg")
   
Else
   MsgBox "Invalid Move"
End If
End Sub
Private Sub cmdDown_Click()
If (DownValid() = True) Then
   'Move internal representation of new square to piece
   GamePieces(CurrentPos + 4) = GamePieces(CurrentPos)
   'Set internal representation of old square to blank
   GamePieces(CurrentPos) = 0
   
   Call MoveHighlight(CurrentPos, CurrentPos + 4)
   pctGamePiece(CurrentPos).Picture = LoadPicture("c:\VB Coach\Chapter 8\Blank.jpg")
   CurrentPos = CurrentPos + 4
   pctGamePiece(CurrentPos).Picture = LoadPicture("c:\VB Coach\Chapter 8\" + Trim(Str(GamePieces(CurrentPos))) + ".jpg")
Else
   MsgBox "Invalid Move"
End If
End Sub

Private Sub cmdRight_Click()
If (RightValid() = True) Then
   'Move internal representation of new square to piece
   GamePieces(CurrentPos + 1) = GamePieces(CurrentPos)
   'Set internal representation of old square to blank
   GamePieces(CurrentPos) = 0
   
   Call MoveHighlight(CurrentPos, CurrentPos + 1)
   pctGamePiece(CurrentPos).Picture = LoadPicture("c:\VB Coach\Chapter 8\Blank.jpg")
   CurrentPos = CurrentPos + 1
   pctGamePiece(CurrentPos).Picture = LoadPicture("c:\VB Coach\Chapter 8\" + Trim(Str(GamePieces(CurrentPos))) + ".jpg")
Else
   MsgBox "Invalid Move"
End If
End Sub
Private Sub cmdLeft_Click()
If (LeftValid() = True) Then
   'Move internal representation of new square to piece
   GamePieces(CurrentPos - 1) = GamePieces(CurrentPos)
   'Set internal representation of old square to blank
   GamePieces(CurrentPos) = 0
   
   Call MoveHighlight(CurrentPos, CurrentPos - 1)
   pctGamePiece(CurrentPos).Picture = LoadPicture("c:\VB Coach\Chapter 8\Blank.jpg")
   CurrentPos = CurrentPos - 1
   pctGamePiece(CurrentPos).Picture = LoadPicture("c:\VB Coach\Chapter 8\" + Trim(Str(GamePieces(CurrentPos))) + ".jpg")
Else
   MsgBox "Invalid Move"
End If
End Sub
Private Function UpValid() As Boolean
UpValid = True

'Check that we are in the left most spot
If (CurrentPos >= 0) And (CurrentPos <= 3) Then
   UpValid = False
'Check that the space above the current one is blank
ElseIf (GamePieces(CurrentPos - 4) <> 0) Then
   UpValid = False
End If
End Function
Private Function DownValid() As Boolean
DownValid = True

'Check that we are in the left most spot
If (CurrentPos >= 12) And (CurrentPos <= 15) Then
   DownValid = False
'Check that the space above the current one is blank
ElseIf (GamePieces(CurrentPos + 4) <> 0) Then
   DownValid = False
End If
End Function

Private Function LeftValid() As Boolean
LeftValid = True

'Check that we are in the left most spot
If (CurrentPos = 0) Or (CurrentPos = 4) Or _
   (CurrentPos = 8) Or (CurrenPos = 12) Then
   LeftValid = False
'Check that the space the left is blank
ElseIf (GamePieces(CurrentPos - 1) <> 0) Then
   LeftValid = False
End If
End Function
Private Function RightValid() As Boolean
RightValid = True

'Check that we are in the left most spot
If (CurrentPos = 3) Or (CurrentPos = 7) Or _
   (CurrentPos = 11) Or (CurrenPos = 15) Then
   RightValid = False
'Check that the space the right is blank
ElseIf (GamePieces(CurrentPos + 1) <> 0) Then
   RightValid = False
End If
End Function

Private Sub Form_Load()
Call Initialize
End Sub

Private Sub Initialize()
Dim Index As Integer
Dim TempGamePieces(0 To 14) As Integer
Dim NewIndex As Integer

'Initialize the pieces in the Temp array
For Index = 0 To 14
  TempGamePieces(Index) = Index + 1
Next Index

'Loop thru the pieces left to place
For Index = 14 To 0 Step -1
    'Pick a piece randomly
    NewIndex = Int((Index + 1) * Rnd)
    
    'Copy the randomly selected piece to the Game array
    GamePieces(Index) = TempGamePieces(NewIndex)
    
    'load the associated picture
    pctGamePiece(Index).Picture = LoadPicture("c:\VB Coach\Chapter 8\" + Trim(Str(TempGamePieces(NewIndex))) + ".jpg")
    
    'remove the selected piece by copying an unused one over it
    TempGamePieces(NewIndex) = TempGamePieces(Index)
Next Index

'Set the last spot to blank
GamePieces(15) = 0
End Sub

Private Sub pctGamePiece_Click(Index As Integer)
'Change border
Call MoveHighlight(CurrentPos, Index)

'Set new current piece
CurrentPos = Index
End Sub

Private Sub MoveHighlight(CurrentPosition As Integer, NewPosition As Integer)
'Remove border from previous current piece
pctGamePiece(CurrentPosition).BorderStyle = 0

'Set border of new current piece
pctGamePiece(NewPosition).BorderStyle = 1
End Sub
