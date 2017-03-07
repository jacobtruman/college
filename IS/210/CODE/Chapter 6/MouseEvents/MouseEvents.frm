VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   3930
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7140
   LinkTopic       =   "Form1"
   ScaleHeight     =   3930
   ScaleWidth      =   7140
   StartUpPosition =   3  'Windows Default
   Begin VB.PictureBox Picture1 
      Height          =   3615
      Left            =   120
      Picture         =   "MouseEvents.frx":0000
      ScaleHeight     =   3555
      ScaleWidth      =   6795
      TabIndex        =   0
      Top             =   120
      Width           =   6855
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Picture1_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
Picture1.Picture = LoadPicture("c:\VB Coach\Code\Chapter 6\MouseEvents\Ouch.jpg")
End Sub
Private Sub Picture1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Picture1.Picture = LoadPicture("c:\VB Coach\Code\Chapter 6\MouseEvents\DontTouchThis.jpg")
End Sub
Private Sub Picture1_MouseUp(Button As Integer, Shift As Integer, X As Single, Y As Single)
Picture1.Picture = LoadPicture("c:\VB Coach\Code\Chapter 6\MouseEvents\DontTouchThis.jpg")
End Sub
