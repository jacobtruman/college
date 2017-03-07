VERSION 5.00
Object = "{00028C01-0000-0000-0000-000000000046}#1.0#0"; "DBGRID32.OCX"
Begin VB.Form frmBasketballGrid 
   Caption         =   "Basketball Data Bound Grid"
   ClientHeight    =   4710
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   9360
   LinkTopic       =   "Form1"
   ScaleHeight     =   4710
   ScaleWidth      =   9360
   StartUpPosition =   3  'Windows Default
   Begin VB.Data datBasketBall 
      Caption         =   "Player Stats"
      Connect         =   "Access 2000;"
      DatabaseName    =   "C:\VB Coach\Chapter 10\Code\DataBoundGrid\BasketBall.mdb"
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   300
      Left            =   240
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   "PlayerStats"
      Top             =   4320
      Width           =   9015
   End
   Begin MSDBGrid.DBGrid dbg 
      Bindings        =   "DataBoundGrid.frx":0000
      Height          =   3855
      Left            =   240
      OleObjectBlob   =   "DataBoundGrid.frx":001C
      TabIndex        =   0
      Top             =   240
      Width           =   9015
   End
End
Attribute VB_Name = "frmBasketballGrid"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
