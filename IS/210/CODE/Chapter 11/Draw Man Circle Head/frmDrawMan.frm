VERSION 5.00
Begin VB.Form frmDrawMan 
   Appearance      =   0  'Flat
   BackColor       =   &H00C0C0C0&
   Caption         =   "Draw a Man"
   ClientHeight    =   3330
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   3390
   LinkTopic       =   "Form1"
   ScaleHeight     =   3330
   ScaleWidth      =   3390
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdDrawMan 
      Caption         =   "Draw Man"
      Height          =   375
      Left            =   840
      TabIndex        =   1
      Top             =   2880
      Width           =   1575
   End
   Begin VB.PictureBox pctOutput 
      Height          =   2535
      Left            =   120
      ScaleHeight     =   2475
      ScaleWidth      =   3075
      TabIndex        =   0
      Top             =   120
      Width           =   3135
   End
End
Attribute VB_Name = "frmDrawMan"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdDrawMan_Click()

pctOutput.Scale (0, 100)-(100, 0)

'Draw a Red Head
pctOutput.Circle (50, 80), 10, vbRed

'Draw a Blue Body
pctOutput.Line (50, 70)-(50, 25), vbBlue

'Draw a Yellow Left Leg
pctOutput.Line (50, 50)-(40, 60), vbYellow
pctOutput.Line (50, 50)-(60, 60), vbYellow

'Draw a Yellow Right Leg
pctOutput.Line (50, 25)-(35, 10), vbYellow
pctOutput.Line (50, 25)-(65, 10), vbYellow

'Draw the name Bob over the man.
pctOutput.CurrentX = 44
pctOutput.CurrentY = 10
pctOutput.Print "Adam"
End Sub
