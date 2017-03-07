VERSION 5.00
Object = "{00028C01-0000-0000-0000-000000000046}#1.0#0"; "DBGRID32.OCX"
Begin VB.Form frmBeautifying 
   Caption         =   "Beautifying The Data Grid"
   ClientHeight    =   6360
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   10035
   LinkTopic       =   "Form1"
   ScaleHeight     =   6360
   ScaleWidth      =   10035
   StartUpPosition =   3  'Windows Default
   Begin MSDBGrid.DBGrid grdBasketball 
      Bindings        =   "Beautifying.frx":0000
      Height          =   5655
      Left            =   120
      OleObjectBlob   =   "Beautifying.frx":001C
      TabIndex        =   0
      Top             =   120
      Width           =   9735
   End
   Begin VB.Data datBasketBall 
      Caption         =   "Player Stats"
      Connect         =   "Access 2000;"
      DatabaseName    =   "C:\VB Coach\Chapter 10\Code\DataBoundGrid\BasketBall.mdb"
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   345
      Left            =   360
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   "PlayerStats"
      Top             =   5880
      Width           =   9015
   End
End
Attribute VB_Name = "frmBeautifying"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
