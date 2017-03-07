VERSION 5.00
Begin VB.Form frmBasketball 
   Caption         =   "Basketball Data Control"
   ClientHeight    =   3735
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7290
   LinkTopic       =   "Form1"
   ScaleHeight     =   3735
   ScaleWidth      =   7290
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox txtTeam 
      DataField       =   "Team"
      DataSource      =   "datBasketball"
      Height          =   375
      Left            =   240
      TabIndex        =   13
      Top             =   1560
      Width           =   2655
   End
   Begin VB.TextBox txtAssists 
      DataField       =   "Assists"
      DataSource      =   "datBasketBall"
      Height          =   375
      Left            =   5040
      TabIndex        =   11
      Top             =   2400
      Width           =   2055
   End
   Begin VB.TextBox txtRebounds 
      DataField       =   "Rebounds"
      DataSource      =   "datBasketBall"
      Height          =   375
      Left            =   3480
      TabIndex        =   9
      Top             =   2400
      Width           =   1095
   End
   Begin VB.TextBox txtPoints 
      DataField       =   "Points"
      DataSource      =   "datBasketBall"
      Height          =   375
      Left            =   1920
      TabIndex        =   7
      Top             =   2400
      Width           =   1095
   End
   Begin VB.TextBox txtGamesPlayed 
      DataField       =   "Games Played"
      DataSource      =   "datBasketBall"
      Height          =   375
      Left            =   240
      TabIndex        =   5
      Top             =   2400
      Width           =   1215
   End
   Begin VB.TextBox txtFirst 
      DataField       =   "First Name"
      DataSource      =   "datBasketBall"
      Height          =   375
      Left            =   3240
      TabIndex        =   3
      Top             =   720
      Width           =   1935
   End
   Begin VB.TextBox txtLast 
      DataField       =   "Last Name"
      DataSource      =   "datBasketBall"
      Height          =   375
      Left            =   240
      TabIndex        =   0
      Top             =   720
      Width           =   2655
   End
   Begin VB.Data datBasketball 
      Caption         =   "Basketball Statistics"
      Connect         =   "Access"
      DatabaseName    =   "C:\VB Coach\Chapter 10\Code\EasyBasketBallDataControl\BasketBall.mdb"
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   495
      Left            =   960
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   "PlayerStats"
      Top             =   3120
      Width           =   5415
   End
   Begin VB.Label Label7 
      Caption         =   "Assists"
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
      Left            =   5040
      TabIndex        =   12
      Top             =   2160
      Width           =   735
   End
   Begin VB.Label Label6 
      Caption         =   "Rebounds"
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
      Left            =   3480
      TabIndex        =   10
      Top             =   2160
      Width           =   975
   End
   Begin VB.Label Label5 
      Caption         =   "Points"
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
      Left            =   1920
      TabIndex        =   8
      Top             =   2160
      Width           =   855
   End
   Begin VB.Label Label4 
      Caption         =   "Games Played"
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
      TabIndex        =   6
      Top             =   2160
      Width           =   1455
   End
   Begin VB.Label Label3 
      Caption         =   "Team"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   240
      TabIndex        =   4
      Top             =   1320
      Width           =   1935
   End
   Begin VB.Label Label2 
      Caption         =   "First Name"
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
      Left            =   3240
      TabIndex        =   2
      Top             =   480
      Width           =   1095
   End
   Begin VB.Label Label1 
      Caption         =   "Last Name"
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
      TabIndex        =   1
      Top             =   480
      Width           =   1215
   End
End
Attribute VB_Name = "frmBasketBall"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
