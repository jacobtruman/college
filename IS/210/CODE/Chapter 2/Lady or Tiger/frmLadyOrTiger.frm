VERSION 5.00
Begin VB.Form frmLadyOrTiger 
   Caption         =   "Lady Or The Tiger"
   ClientHeight    =   5745
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   8085
   LinkTopic       =   "Form1"
   ScaleHeight     =   383
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   539
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdRightDoor 
      Caption         =   "Right Door"
      Height          =   495
      Left            =   5520
      TabIndex        =   6
      Top             =   5040
      Width           =   1695
   End
   Begin VB.CommandButton cmdLeftDoor 
      Caption         =   "Left Door"
      Height          =   495
      Left            =   1200
      TabIndex        =   5
      Top             =   5040
      Width           =   1695
   End
   Begin VB.TextBox txtQuestion 
      Height          =   375
      Left            =   3240
      TabIndex        =   3
      Top             =   2640
      Width           =   1935
   End
   Begin VB.PictureBox pctRightDoor 
      BorderStyle     =   0  'None
      Height          =   3615
      Left            =   5520
      Picture         =   "frmLadyOrTiger.frx":0000
      ScaleHeight     =   3615
      ScaleWidth      =   1695
      TabIndex        =   2
      Top             =   1200
      Width           =   1695
   End
   Begin VB.PictureBox pctLeftDoor 
      BorderStyle     =   0  'None
      Height          =   3615
      Left            =   1200
      Picture         =   "frmLadyOrTiger.frx":7BD9
      ScaleHeight     =   3615
      ScaleWidth      =   1695
      TabIndex        =   1
      Top             =   1200
      Width           =   1695
   End
   Begin VB.Label lblQuestion 
      Caption         =   "Question"
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
      Left            =   3240
      TabIndex        =   4
      Top             =   2400
      Width           =   1815
   End
   Begin VB.Label lbltitle 
      Alignment       =   2  'Center
      Caption         =   "Pick a Door Wisely"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   240
      TabIndex        =   0
      Top             =   240
      Width           =   7575
   End
End
Attribute VB_Name = "frmLadyOrTiger"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdLeftDoor_Click()
txtQuestion.Text = ""
pctLeftDoor.Picture = LoadPicture("C:\VB Coach\Chapter 2\Code\Lady or Tiger\Tiger.gif")
lbltitle.Caption = "Guilty"
End Sub

Private Sub cmdRightDoor_Click()
txtQuestion.Text = ""
pctRightDoor = LoadPicture("C:\VB Coach\Chapter 2\Code\Lady or Tiger\Lady.gif")
lbltitle.Caption = "Innocent"
End Sub
