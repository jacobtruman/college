VERSION 5.00
Begin VB.Form frmTVRatingsArrays 
   Caption         =   "TV Ratings Application"
   ClientHeight    =   4170
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4785
   LinkTopic       =   "Form1"
   ScaleHeight     =   4170
   ScaleWidth      =   4785
   StartUpPosition =   3  'Windows Default
   Begin VB.ComboBox cmoRating 
      Height          =   315
      Index           =   10
      ItemData        =   "RatingMultiArray.frx":0000
      Left            =   240
      List            =   "RatingMultiArray.frx":0022
      TabIndex        =   11
      Top             =   3360
      Width           =   735
   End
   Begin VB.ComboBox cmoRating 
      Height          =   315
      Index           =   9
      ItemData        =   "RatingMultiArray.frx":0045
      Left            =   3720
      List            =   "RatingMultiArray.frx":0067
      TabIndex        =   10
      Top             =   2520
      Width           =   735
   End
   Begin VB.ComboBox cmoRating 
      Height          =   315
      Index           =   8
      ItemData        =   "RatingMultiArray.frx":008A
      Left            =   2040
      List            =   "RatingMultiArray.frx":00AC
      TabIndex        =   9
      Top             =   2520
      Width           =   735
   End
   Begin VB.ComboBox cmoRating 
      Height          =   315
      Index           =   7
      ItemData        =   "RatingMultiArray.frx":00CF
      Left            =   240
      List            =   "RatingMultiArray.frx":00F1
      TabIndex        =   8
      Top             =   2520
      Width           =   735
   End
   Begin VB.ComboBox cmoRating 
      Height          =   315
      Index           =   6
      ItemData        =   "RatingMultiArray.frx":0114
      Left            =   3720
      List            =   "RatingMultiArray.frx":0136
      TabIndex        =   7
      Top             =   1680
      Width           =   735
   End
   Begin VB.ComboBox cmoRating 
      Height          =   315
      Index           =   5
      ItemData        =   "RatingMultiArray.frx":0159
      Left            =   2040
      List            =   "RatingMultiArray.frx":017B
      TabIndex        =   6
      Top             =   1680
      Width           =   735
   End
   Begin VB.ComboBox cmoRating 
      Height          =   315
      Index           =   4
      ItemData        =   "RatingMultiArray.frx":019E
      Left            =   240
      List            =   "RatingMultiArray.frx":01C0
      TabIndex        =   5
      Top             =   1680
      Width           =   735
   End
   Begin VB.ComboBox cmoRating 
      Height          =   315
      Index           =   3
      ItemData        =   "RatingMultiArray.frx":01E3
      Left            =   3720
      List            =   "RatingMultiArray.frx":0205
      TabIndex        =   4
      Top             =   840
      Width           =   735
   End
   Begin VB.ComboBox cmoRating 
      Height          =   315
      Index           =   2
      ItemData        =   "RatingMultiArray.frx":0228
      Left            =   1980
      List            =   "RatingMultiArray.frx":024A
      TabIndex        =   3
      Top             =   840
      Width           =   735
   End
   Begin VB.ComboBox cmoRating 
      Height          =   315
      Index           =   1
      ItemData        =   "RatingMultiArray.frx":026D
      Left            =   240
      List            =   "RatingMultiArray.frx":028F
      TabIndex        =   2
      Top             =   840
      Width           =   735
   End
   Begin VB.CommandButton cmdRating 
      Caption         =   "Submit Rating"
      Height          =   375
      Left            =   1365
      TabIndex        =   0
      Top             =   3720
      Width           =   2055
   End
   Begin VB.Label Label11 
      Caption         =   "Survivor"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   240
      TabIndex        =   21
      Top             =   3120
      Width           =   855
   End
   Begin VB.Label Label10 
      Caption         =   "Friends"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   3720
      TabIndex        =   20
      Top             =   2280
      Width           =   975
   End
   Begin VB.Label Label9 
      Caption         =   "Invisible Man"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   2040
      TabIndex        =   19
      Top             =   2280
      Width           =   1215
   End
   Begin VB.Label Label8 
      Caption         =   "First Wave"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   240
      TabIndex        =   18
      Top             =   2280
      Width           =   1095
   End
   Begin VB.Label Label7 
      Caption         =   "Angel"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   3720
      TabIndex        =   17
      Top             =   1440
      Width           =   735
   End
   Begin VB.Label Label6 
      Caption         =   "Buffy..."
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   2040
      TabIndex        =   16
      Top             =   1440
      Width           =   975
   End
   Begin VB.Label Label5 
      Caption         =   "Charmed"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   240
      TabIndex        =   15
      Top             =   1440
      Width           =   1335
   End
   Begin VB.Label Label4 
      Caption         =   "Roswell"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   3720
      TabIndex        =   14
      Top             =   600
      Width           =   1095
   End
   Begin VB.Label Label3 
      Caption         =   "Felicity"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   2040
      TabIndex        =   13
      Top             =   600
      Width           =   855
   End
   Begin VB.Label Label2 
      Caption         =   "Dawson's Creek"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   240
      TabIndex        =   12
      Top             =   600
      Width           =   1455
   End
   Begin VB.Label Label1 
      Caption         =   "TV Ratings"
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
      Left            =   1665
      TabIndex        =   1
      Top             =   120
      Width           =   1455
   End
End
Attribute VB_Name = "frmTVRatingsArrays"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim intRatings(1 To 10, 1 To 10) As Integer
Dim intTotalVotes As Integer
Private Sub cmdRating_Click()
Dim strOutputString As String
Dim intTVShow As Integer

'Process vote for each TV Show
For intTVShow = 1 To 10
  intRatings(intTVShow, cmoRating(intTVShow)) = _
        intRatings(intTVShow, cmoRating(intTVShow)) + 1
Next intTVShow

'Record Vote
intTotalVotes = intTotalVotes + 1

'Output Results
If (intTotalVotes = 10) Then
  For intTVShow = 1 To 10
    strOutputString = "TV Show #" + Str(intTVShow) + " "
    For intVote = 1 To 10
      strOutputString = strOutputString + Str(intVote) + "] " + Str(intRatings(intTVShow, intVote))
    Next intVote
    MsgBox strOutputString

  Next intTVShow
End If
End Sub


