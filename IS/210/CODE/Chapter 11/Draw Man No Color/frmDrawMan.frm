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

'Draw Head
pctOutput.Scale (0, 100)-(100, 0)
pctOutput.Line (40, 90)-(60, 90)
pctOutput.Line (60, 90)-(60, 70)
pctOutput.Line (60, 70)-(40, 70)
pctOutput.Line (40, 70)-(40, 90)

'Draw Face

'Draw Mouth
pctOutput.Line (45, 77)-(45, 73)
pctOutput.Line (45, 73)-(55, 73)
pctOutput.Line (55, 73)-(55, 77)

'Draw Nose
pctOutput.Line (47, 80)-(47, 76)
pctOutput.Line (47, 76)-(53, 76)
pctOutput.Line (53, 76)-(53, 80)

'Draw Left Eye
pctOutput.Line (44, 85)-(46, 85)
pctOutput.Line (46, 85)-(46, 83)
pctOutput.Line (46, 83)-(44, 83)
pctOutput.Line (44, 83)-(44, 85)

'Draw Right Eye
pctOutput.Line (56, 85)-(54, 85)
pctOutput.Line (54, 85)-(54, 83)
pctOutput.Line (54, 83)-(56, 83)
pctOutput.Line (56, 83)-(56, 85)

'Draw Body
pctOutput.Line (50, 70)-(50, 25)

'Draw Left Leg
pctOutput.Line (50, 50)-(40, 60)
pctOutput.Line (50, 50)-(60, 60)

'Draw Right Leg
pctOutput.Line (50, 25)-(35, 10)
pctOutput.Line (50, 25)-(65, 10)

End Sub

