VERSION 5.00
Begin VB.Form frmTV 
   Caption         =   "TV "
   ClientHeight    =   4050
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   6495
   LinkTopic       =   "Form1"
   ScaleHeight     =   4050
   ScaleWidth      =   6495
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdVerify 
      Caption         =   "Verify"
      Height          =   375
      Left            =   2400
      TabIndex        =   18
      Top             =   3360
      Width           =   1695
   End
   Begin VB.ComboBox cmbTVShow 
      Height          =   315
      Index           =   8
      ItemData        =   "TVControlArrays.frx":0000
      Left            =   4440
      List            =   "TVControlArrays.frx":0022
      TabIndex        =   9
      Top             =   2520
      Width           =   1815
   End
   Begin VB.ComboBox cmbTVShow 
      Height          =   315
      Index           =   7
      ItemData        =   "TVControlArrays.frx":00A1
      Left            =   2400
      List            =   "TVControlArrays.frx":00C3
      TabIndex        =   8
      Top             =   2520
      Width           =   1815
   End
   Begin VB.ComboBox cmbTVShow 
      Height          =   315
      Index           =   6
      ItemData        =   "TVControlArrays.frx":0142
      Left            =   360
      List            =   "TVControlArrays.frx":0164
      TabIndex        =   7
      Top             =   2520
      Width           =   1815
   End
   Begin VB.ComboBox cmbTVShow 
      Height          =   315
      Index           =   5
      ItemData        =   "TVControlArrays.frx":01E3
      Left            =   4440
      List            =   "TVControlArrays.frx":0205
      TabIndex        =   6
      Top             =   1560
      Width           =   1815
   End
   Begin VB.ComboBox cmbTVShow 
      Height          =   315
      Index           =   4
      ItemData        =   "TVControlArrays.frx":0284
      Left            =   2400
      List            =   "TVControlArrays.frx":02A6
      TabIndex        =   5
      Top             =   1560
      Width           =   1815
   End
   Begin VB.ComboBox cmbTVShow 
      Height          =   315
      Index           =   3
      ItemData        =   "TVControlArrays.frx":0325
      Left            =   360
      List            =   "TVControlArrays.frx":0347
      TabIndex        =   4
      Top             =   1560
      Width           =   1815
   End
   Begin VB.ComboBox cmbTVShow 
      Height          =   315
      Index           =   2
      ItemData        =   "TVControlArrays.frx":03C6
      Left            =   4440
      List            =   "TVControlArrays.frx":03E8
      TabIndex        =   3
      Top             =   600
      Width           =   1815
   End
   Begin VB.ComboBox cmbTVShow 
      Height          =   315
      Index           =   1
      ItemData        =   "TVControlArrays.frx":0467
      Left            =   2400
      List            =   "TVControlArrays.frx":0489
      TabIndex        =   2
      Top             =   600
      Width           =   1815
   End
   Begin VB.ComboBox cmbTVShow 
      Height          =   315
      Index           =   0
      ItemData        =   "TVControlArrays.frx":0508
      Left            =   360
      List            =   "TVControlArrays.frx":052A
      TabIndex        =   0
      Top             =   600
      Width           =   1815
   End
   Begin VB.Label Label3 
      Caption         =   "9th"
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
      Index           =   6
      Left            =   4440
      TabIndex        =   17
      Top             =   2280
      Width           =   735
   End
   Begin VB.Label Label3 
      Caption         =   "8th"
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
      Index           =   5
      Left            =   2400
      TabIndex        =   16
      Top             =   2280
      Width           =   735
   End
   Begin VB.Label Label3 
      Caption         =   "7th"
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
      Index           =   4
      Left            =   360
      TabIndex        =   15
      Top             =   2280
      Width           =   735
   End
   Begin VB.Label Label3 
      Caption         =   "6th"
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
      Index           =   3
      Left            =   4440
      TabIndex        =   14
      Top             =   1320
      Width           =   735
   End
   Begin VB.Label Label3 
      Caption         =   "5th"
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
      Index           =   2
      Left            =   2400
      TabIndex        =   13
      Top             =   1320
      Width           =   735
   End
   Begin VB.Label Label3 
      Caption         =   "4th"
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
      Index           =   1
      Left            =   360
      TabIndex        =   12
      Top             =   1320
      Width           =   735
   End
   Begin VB.Label Label3 
      Caption         =   "3rd"
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
      Index           =   0
      Left            =   4440
      TabIndex        =   11
      Top             =   240
      Width           =   735
   End
   Begin VB.Label Label2 
      Caption         =   "2nd"
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
      Left            =   2400
      TabIndex        =   10
      Top             =   240
      Width           =   855
   End
   Begin VB.Label Label1 
      Caption         =   "1st"
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
      Left            =   360
      TabIndex        =   1
      Top             =   240
      Width           =   615
   End
End
Attribute VB_Name = "frmTV"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdVerify_Click()
Dim CurrentShow As Integer
Dim ShowToCheck As Integer
Dim DuplicateFound As Boolean

DuplicateFound = False

For CurrentShow = 0 To 8
  For ShowToCheck = CurrentShow + 1 To 8
    If (cmbTVShow(CurrentShow) = cmbTVShow(ShowToCheck)) Then
      DuplicateFound = True
    End If
  Next ShowToCheck
Next CurrentShow

If (DuplicateFound = True) Then
  MsgBox "Duplicate Found"
Else
  MsgBox "Votes are Valid"
End If
End Sub
