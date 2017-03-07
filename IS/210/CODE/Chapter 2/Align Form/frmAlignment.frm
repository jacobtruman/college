VERSION 5.00
Begin VB.Form frmAlignment 
   Caption         =   "Unaligned Picture"
   ClientHeight    =   5460
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   ScaleHeight     =   364
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   312
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdChangePicture 
      Caption         =   "Unaligned Picture"
      Height          =   495
      Left            =   120
      TabIndex        =   3
      Top             =   4680
      Width           =   1695
   End
   Begin VB.TextBox txtName 
      Height          =   375
      Left            =   120
      TabIndex        =   2
      Text            =   "Unaligned Controls"
      Top             =   4080
      Width           =   2175
   End
   Begin VB.PictureBox pctBabyPict 
      Height          =   3135
      Left            =   120
      Picture         =   "frmAlignment.frx":0000
      ScaleHeight     =   3075
      ScaleWidth      =   2715
      TabIndex        =   1
      Top             =   720
      Width           =   2775
   End
   Begin VB.Label lblTitle 
      Alignment       =   2  'Center
      Caption         =   "Unaligned Controls"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   4455
   End
End
Attribute VB_Name = "frmAlignment"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdChangePicture_Click()
lblTitle.Caption = "Cutest Boy in the World"
pctBabyPict.Picture = LoadPicture("C:\VB Coach\Chapter 2\Code\1st App\Billy.jpg")
txtName.Text = "Billy"
End Sub

Private Sub Form_Load()

End Sub
