VERSION 5.00
Begin VB.Form frmMenuExample 
   Caption         =   "Menu Example"
   ClientHeight    =   4635
   ClientLeft      =   165
   ClientTop       =   735
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   ScaleHeight     =   4635
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
   Begin VB.PictureBox pctRacing 
      Height          =   3135
      Left            =   893
      Picture         =   "frmMenuExample.frx":0000
      ScaleHeight     =   3075
      ScaleWidth      =   2835
      TabIndex        =   0
      Top             =   1200
      Width           =   2895
   End
   Begin VB.Label lblTitle 
      Alignment       =   2  'Center
      Caption         =   "Racewalk Competition"
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
      Left            =   120
      TabIndex        =   1
      Top             =   120
      Width           =   4455
   End
   Begin VB.Menu mnuPicture 
      Caption         =   "&Picture"
      Begin VB.Menu mnuAddBorder 
         Caption         =   "&Add Border"
      End
      Begin VB.Menu mnuRemoveBorder 
         Caption         =   "&Remove Border"
      End
   End
   Begin VB.Menu mnuLabel 
      Caption         =   "&Label"
      Begin VB.Menu mnuChangeSize 
         Caption         =   "Change &Size"
         Begin VB.Menu mnuGrow 
            Caption         =   "&Grow"
         End
         Begin VB.Menu mnuShrink 
            Caption         =   "&Shrink"
         End
      End
      Begin VB.Menu mnuChangeColor 
         Caption         =   "Change &Color"
         Begin VB.Menu mnuBlack 
            Caption         =   "&Black"
         End
         Begin VB.Menu mnuBlue 
            Caption         =   "B&lue"
         End
         Begin VB.Menu mnuRed 
            Caption         =   "&Red"
         End
         Begin VB.Menu mnuYellow 
            Caption         =   "&Yellow"
         End
         Begin VB.Menu mnuMagenta 
            Caption         =   "&Magenta"
         End
      End
   End
End
Attribute VB_Name = "frmMenuExample"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub mnuAddBorder_Click()
pctRacing.BorderStyle = 1
End Sub

Private Sub mnuBlack_Click()
lblTitle.ForeColor = vbBlack
End Sub
Private Sub mnuBlue_Click()
lblTitle.ForeColor = vbBlue
End Sub
Private Sub mnuRed_Click()
lblTitle.ForeColor = vbRed
End Sub
Private Sub mnuGrow_Click()
lblTitle.Font.Size = Str(Val(lblTitle.Font.Size) + 2)
End Sub

Private Sub mnuRemoveBorder_Click()
pctRacing.BorderStyle = 0
End Sub

Private Sub mnuShrink_Click()
lblTitle.Font.Size = Str(Val(lblTitle.Font.Size - 2))
End Sub

