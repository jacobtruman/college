VERSION 5.00
Begin VB.Form frmTravel 
   BackColor       =   &H00008000&
   Caption         =   "Travel"
   ClientHeight    =   5460
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4680
   FillColor       =   &H00FFFFFF&
   LinkTopic       =   "Form1"
   ScaleHeight     =   364
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   312
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdChangeDestination 
      Caption         =   "Change Destination"
      Height          =   495
      Left            =   1493
      TabIndex        =   3
      Top             =   4680
      Width           =   1695
   End
   Begin VB.TextBox txtName 
      ForeColor       =   &H00000000&
      Height          =   375
      Left            =   1253
      TabIndex        =   2
      Text            =   "Ireland"
      Top             =   4080
      Width           =   2175
   End
   Begin VB.PictureBox pctTravel 
      Height          =   2775
      Left            =   953
      Picture         =   "FRMTRA~1.frx":0000
      ScaleHeight     =   2715
      ScaleWidth      =   2715
      TabIndex        =   1
      Top             =   840
      Width           =   2775
   End
   Begin VB.Label lblTitle 
      Alignment       =   2  'Center
      BackColor       =   &H00008000&
      Caption         =   "Ireland is the Place to be!"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   495
      Left            =   113
      TabIndex        =   0
      Top             =   120
      Width           =   4455
   End
End
Attribute VB_Name = "frmTravel"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdChangeDestination_Click()
lblTitle.Caption = "Egypt is the Place to be!"
pctTravel.Picture = LoadPicture("C:\VB Coach\Code\Chapter 2\Color App\Egypt.jpg")
txtName.Text = "Egypt"
frmTravel.BackColor = vbYellow
lblTitle.BackColor = vbYellow
End Sub
