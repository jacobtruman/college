VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   5205
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4710
   LinkTopic       =   "Form1"
   ScaleHeight     =   5205
   ScaleWidth      =   4710
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command1 
      Caption         =   "Change Picture"
      Height          =   375
      Left            =   1440
      TabIndex        =   3
      Top             =   4680
      Width           =   1215
   End
   Begin VB.TextBox Text1 
      Height          =   375
      Left            =   480
      TabIndex        =   2
      Text            =   "Ally"
      Top             =   4200
      Width           =   2055
   End
   Begin VB.PictureBox Picture1 
      Height          =   3135
      Left            =   120
      Picture         =   "Form1.frx":0000
      ScaleHeight     =   3075
      ScaleWidth      =   2715
      TabIndex        =   1
      Top             =   960
      Width           =   2775
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      Caption         =   "Cutest Girl in the World"
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
      Left            =   240
      TabIndex        =   0
      Top             =   240
      Width           =   4095
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()
Label1.Caption = "Cutest Boy in the World"
Picture1.Picture = LoadPicture("C:\VB Coach\Chapter 2\Billy.jpg")
Text1.Text = "Billy"
End Sub
