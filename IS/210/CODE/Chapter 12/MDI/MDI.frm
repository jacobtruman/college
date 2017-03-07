VERSION 5.00
Begin VB.MDIForm MDIForm1 
   BackColor       =   &H8000000C&
   Caption         =   "Main Form"
   ClientHeight    =   5550
   ClientLeft      =   165
   ClientTop       =   735
   ClientWidth     =   4680
   LinkTopic       =   "MDIForm1"
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
   Begin VB.Menu mnuWindow 
      Caption         =   "&Window"
      Begin VB.Menu mnuDemographics 
         Caption         =   "&Demographics"
      End
      Begin VB.Menu mnuFinancial 
         Caption         =   "&Financial"
      End
      Begin VB.Menu mnuPersonnel 
         Caption         =   "&Personnel"
      End
   End
   Begin VB.Menu mnuArrange 
      Caption         =   "&Arrange"
      Begin VB.Menu mnuCascade 
         Caption         =   "&Cascade"
      End
      Begin VB.Menu mnuTileHorizontally 
         Caption         =   "Tile &Horizontally"
      End
      Begin VB.Menu mnuVertically 
         Caption         =   "Tile &Vertically"
      End
   End
End
Attribute VB_Name = "MDIForm1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub mnuDemographics_Click()
frmDemographics.Show
End Sub
Private Sub mnuFinancial_Click()
frmFinancial.Show
End Sub
Private Sub mnuPersonnel_Click()
frmPersonnel.Show
End Sub
Private Sub mnuCascade_Click()
MDIForm1.Arrange vbCascade
End Sub
Private Sub mnuTileHorizontally_Click()
MDIForm1.Arrange vbTileHorizontal
End Sub
Private Sub mnuVertically_Click()
MDIForm1.Arrange vbTileVertical
End Sub

