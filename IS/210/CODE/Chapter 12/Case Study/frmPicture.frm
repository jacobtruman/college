VERSION 5.00
Begin VB.Form frmPicture 
   Caption         =   "Picture"
   ClientHeight    =   3195
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   MDIChild        =   -1  'True
   ScaleHeight     =   3195
   ScaleWidth      =   4680
   Begin VB.CommandButton cmdClose 
      Caption         =   "&Close"
      Height          =   375
      Left            =   1680
      TabIndex        =   1
      Top             =   2640
      Width           =   1455
   End
   Begin VB.PictureBox pctPicture 
      Height          =   2295
      Left            =   720
      ScaleHeight     =   2235
      ScaleWidth      =   3195
      TabIndex        =   0
      Top             =   240
      Width           =   3255
   End
End
Attribute VB_Name = "frmPicture"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdClose_Click()
Me.Hide
End Sub
