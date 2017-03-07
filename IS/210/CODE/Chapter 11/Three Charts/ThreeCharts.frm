VERSION 5.00
Begin VB.Form frmChart 
   Caption         =   "Chart with $0 - $100,000"
   ClientHeight    =   3750
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   ScaleHeight     =   3750
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command1 
      Caption         =   "Chart"
      Height          =   375
      Left            =   1440
      TabIndex        =   1
      Top             =   3240
      Width           =   1695
   End
   Begin VB.PictureBox pctOutput 
      Height          =   2775
      Left            =   120
      ScaleHeight     =   2715
      ScaleWidth      =   4275
      TabIndex        =   0
      Top             =   120
      Width           =   4335
   End
End
Attribute VB_Name = "frmChart"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()
pctOutput.Scale (10000, 20000)-(13, 0)
pctOutput.Line (1, 12400)-(2, 15120)
pctOutput.Line (2, 15120)-(3, 12500)
pctOutput.Line (3, 12500)-(4, 19995)
pctOutput.Line (4, 19995)-(5, 10275)
pctOutput.Line (5, 10275)-(6, 14222)
pctOutput.Line (6, 14222)-(7, 12400)
pctOutput.Line (7, 12400)-(8, 15120)
pctOutput.Line (8, 15120)-(9, 12500)
pctOutput.Line (9, 12500)-(10, 19995)
pctOutput.Line (10, 19995)-(11, 10275)
pctOutput.Line (11, 10275)-(12, 14222)
End Sub
