VERSION 5.00
Begin VB.Form frmDragandDrop 
   Caption         =   "Drag and Drop"
   ClientHeight    =   1395
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7515
   LinkTopic       =   "Form1"
   ScaleHeight     =   1395
   ScaleWidth      =   7515
   StartUpPosition =   3  'Windows Default
   Begin VB.PictureBox pctBullseye 
      BorderStyle     =   0  'None
      Height          =   855
      Left            =   5880
      Picture         =   "DragAndDrop.frx":0000
      ScaleHeight     =   855
      ScaleWidth      =   1455
      TabIndex        =   1
      Top             =   240
      Width           =   1455
   End
   Begin VB.PictureBox pctGun 
      BorderStyle     =   0  'None
      DragIcon        =   "DragAndDrop.frx":2377
      DragMode        =   1  'Automatic
      Height          =   855
      Left            =   120
      Picture         =   "DragAndDrop.frx":2E31
      ScaleHeight     =   855
      ScaleWidth      =   1815
      TabIndex        =   0
      Top             =   120
      Width           =   1815
   End
End
Attribute VB_Name = "frmDragandDrop"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub pctBullseye_DragDrop(Source As Control, X As Single, Y As Single)
pctBullseye.Picture = LoadPicture("C:\VB Coach\Chapter 11\Code\Drag And Drop Example\HitBullseye.jpg")
Source.Visible = False
End Sub


Private Sub pctBullseye_DragOver(Source As Control, X As Single, Y As Single, State As Integer)
pctBullseye.Picture = LoadPicture("C:\VB Coach\Code\Chapter 11\Drag And Drop Example\DraggedOver.bmp")
End Sub
