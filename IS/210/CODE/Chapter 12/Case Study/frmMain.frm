VERSION 5.00
Begin VB.MDIForm frmMain 
   BackColor       =   &H8000000C&
   Caption         =   "Payroll"
   ClientHeight    =   3195
   ClientLeft      =   165
   ClientTop       =   735
   ClientWidth     =   4680
   LinkTopic       =   "MDIForm1"
   StartUpPosition =   3  'Windows Default
   Begin VB.Menu mnuWindow 
      Caption         =   "Window"
      Begin VB.Menu mnuData 
         Caption         =   "Data"
      End
      Begin VB.Menu mnuChart 
         Caption         =   "Chart"
      End
   End
   Begin VB.Menu mnuArrange 
      Caption         =   "Arrange"
      Begin VB.Menu mnuCascade 
         Caption         =   "Cascade"
      End
      Begin VB.Menu mnuHorizontal 
         Caption         =   "Tile Horizontally"
      End
      Begin VB.Menu mnuVerticle 
         Caption         =   "Tile Vertically"
      End
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub mnuChart_Click()
frmPayrollChart.Show
End Sub

Private Sub mnuData_Click()
frmPayroll.Show
End Sub
