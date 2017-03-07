VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Puzzle"
   ClientHeight    =   4755
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   3765
   LinkTopic       =   "Form1"
   ScaleHeight     =   4755
   ScaleWidth      =   3765
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdStart 
      Caption         =   "&Start"
      Height          =   615
      Left            =   1095
      TabIndex        =   16
      Top             =   3960
      Width           =   1575
   End
   Begin VB.PictureBox pctGamePiece 
      BorderStyle     =   0  'None
      DragIcon        =   "Puzzle.frx":0000
      DragMode        =   1  'Automatic
      Height          =   800
      Index           =   15
      Left            =   2742
      Picture         =   "Puzzle.frx":0442
      ScaleHeight     =   795
      ScaleWidth      =   795
      TabIndex        =   15
      Top             =   3000
      Width           =   800
   End
   Begin VB.PictureBox pctGamePiece 
      BorderStyle     =   0  'None
      DragIcon        =   "Puzzle.frx":0C73
      DragMode        =   1  'Automatic
      Height          =   800
      Index           =   14
      Left            =   1902
      Picture         =   "Puzzle.frx":10B5
      ScaleHeight     =   795
      ScaleWidth      =   795
      TabIndex        =   14
      Top             =   3000
      Width           =   800
   End
   Begin VB.PictureBox pctGamePiece 
      BorderStyle     =   0  'None
      DragIcon        =   "Puzzle.frx":23F6
      DragMode        =   1  'Automatic
      Height          =   800
      Index           =   13
      Left            =   1062
      Picture         =   "Puzzle.frx":2838
      ScaleHeight     =   795
      ScaleWidth      =   795
      TabIndex        =   13
      Top             =   3000
      Width           =   800
   End
   Begin VB.PictureBox pctGamePiece 
      BorderStyle     =   0  'None
      DragIcon        =   "Puzzle.frx":3AE7
      DragMode        =   1  'Automatic
      Height          =   800
      Index           =   12
      Left            =   222
      Picture         =   "Puzzle.frx":3F29
      ScaleHeight     =   795
      ScaleWidth      =   795
      TabIndex        =   12
      Top             =   3000
      Width           =   800
   End
   Begin VB.PictureBox pctGamePiece 
      BorderStyle     =   0  'None
      DragIcon        =   "Puzzle.frx":531F
      DragMode        =   1  'Automatic
      Height          =   800
      Index           =   11
      Left            =   2742
      Picture         =   "Puzzle.frx":5761
      ScaleHeight     =   795
      ScaleWidth      =   795
      TabIndex        =   11
      Top             =   2160
      Width           =   800
   End
   Begin VB.PictureBox pctGamePiece 
      BorderStyle     =   0  'None
      DragIcon        =   "Puzzle.frx":6B21
      DragMode        =   1  'Automatic
      Height          =   800
      Index           =   10
      Left            =   1902
      Picture         =   "Puzzle.frx":6F63
      ScaleHeight     =   795
      ScaleWidth      =   795
      TabIndex        =   10
      Top             =   2160
      Width           =   800
   End
   Begin VB.PictureBox pctGamePiece 
      BorderStyle     =   0  'None
      DragIcon        =   "Puzzle.frx":814E
      DragMode        =   1  'Automatic
      Height          =   800
      Index           =   9
      Left            =   1062
      Picture         =   "Puzzle.frx":8590
      ScaleHeight     =   795
      ScaleWidth      =   795
      TabIndex        =   9
      Top             =   2160
      Width           =   800
   End
   Begin VB.PictureBox pctGamePiece 
      BorderStyle     =   0  'None
      DragIcon        =   "Puzzle.frx":9926
      DragMode        =   1  'Automatic
      Height          =   800
      Index           =   8
      Left            =   222
      Picture         =   "Puzzle.frx":9D68
      ScaleHeight     =   795
      ScaleWidth      =   795
      TabIndex        =   8
      Top             =   2160
      Width           =   800
   End
   Begin VB.PictureBox pctGamePiece 
      BorderStyle     =   0  'None
      DragIcon        =   "Puzzle.frx":AC7D
      DragMode        =   1  'Automatic
      Height          =   800
      Index           =   7
      Left            =   2742
      Picture         =   "Puzzle.frx":B0BF
      ScaleHeight     =   795
      ScaleWidth      =   795
      TabIndex        =   7
      Top             =   1320
      Width           =   800
   End
   Begin VB.PictureBox pctGamePiece 
      BorderStyle     =   0  'None
      DragIcon        =   "Puzzle.frx":C074
      DragMode        =   1  'Automatic
      Height          =   800
      Index           =   6
      Left            =   1902
      Picture         =   "Puzzle.frx":C4B6
      ScaleHeight     =   795
      ScaleWidth      =   795
      TabIndex        =   6
      Top             =   1320
      Width           =   800
   End
   Begin VB.PictureBox pctGamePiece 
      BorderStyle     =   0  'None
      DragIcon        =   "Puzzle.frx":D279
      DragMode        =   1  'Automatic
      Height          =   800
      Index           =   5
      Left            =   1062
      Picture         =   "Puzzle.frx":D6BB
      ScaleHeight     =   795
      ScaleWidth      =   795
      TabIndex        =   5
      Top             =   1320
      Width           =   800
   End
   Begin VB.PictureBox pctGamePiece 
      BorderStyle     =   0  'None
      DragIcon        =   "Puzzle.frx":E605
      DragMode        =   1  'Automatic
      Height          =   800
      Index           =   4
      Left            =   222
      Picture         =   "Puzzle.frx":EA47
      ScaleHeight     =   795
      ScaleWidth      =   795
      TabIndex        =   4
      Top             =   1320
      Width           =   800
   End
   Begin VB.PictureBox pctGamePiece 
      BorderStyle     =   0  'None
      DragIcon        =   "Puzzle.frx":F8B0
      DragMode        =   1  'Automatic
      Height          =   800
      Index           =   3
      Left            =   2742
      Picture         =   "Puzzle.frx":FCF2
      ScaleHeight     =   795
      ScaleWidth      =   795
      TabIndex        =   3
      Top             =   480
      Width           =   800
   End
   Begin VB.PictureBox pctGamePiece 
      BorderStyle     =   0  'None
      DragIcon        =   "Puzzle.frx":10A51
      DragMode        =   1  'Automatic
      Height          =   800
      Index           =   2
      Left            =   1902
      Picture         =   "Puzzle.frx":10E93
      ScaleHeight     =   795
      ScaleWidth      =   795
      TabIndex        =   2
      Top             =   480
      Width           =   800
   End
   Begin VB.PictureBox pctGamePiece 
      BorderStyle     =   0  'None
      DragIcon        =   "Puzzle.frx":11DAA
      DragMode        =   1  'Automatic
      Height          =   800
      Index           =   1
      Left            =   1062
      Picture         =   "Puzzle.frx":121EC
      ScaleHeight     =   795
      ScaleWidth      =   795
      TabIndex        =   1
      Top             =   480
      Width           =   800
   End
   Begin VB.PictureBox pctGamePiece 
      BorderStyle     =   0  'None
      DragIcon        =   "Puzzle.frx":130C4
      DragMode        =   1  'Automatic
      Height          =   800
      Index           =   0
      Left            =   222
      Picture         =   "Puzzle.frx":13506
      ScaleHeight     =   795
      ScaleWidth      =   795
      TabIndex        =   0
      Top             =   480
      Width           =   800
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim GamePieces(0 To 15) As Integer
Private Sub cmdStart_Click()
Call Initialize
End Sub

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
pctGamePiece(15).Picture = LoadPicture("c:\VB Coach\Chapter 8\Blank.jpg")
End Sub
Private Sub pctGamePiece_DragDrop(Index As Integer, Source As Control, X As Single, Y As Single)
Dim intIndexDiff As Integer

intIndexDiff = Index - Source.Index
If ((GamePieces(Index) = 0) And ((intIndexDiff = 1) Or _
    (intIndexDiff = -1) Or (intIndexDiff = 4) Or (intIndexDiff = -4))) Then
    
    'Move internal representation of new square to piece
    GamePieces(Index) = GamePieces(Source.Index)
  
    'Set internal representation of old square to blank
    GamePieces(Source.Index) = 0
   
    'Copy old piece to new location
    pctGamePiece(Index).Picture = pctGamePiece(Source.Index).Picture
    
    'Copy blank piece to old location
    pctGamePiece(Source.Index).Picture = LoadPicture("c:\VB Coach\Chapter 8\Blank.jpg")
Else
     MsgBox "Invalid Destination Square"
End If
End Sub
