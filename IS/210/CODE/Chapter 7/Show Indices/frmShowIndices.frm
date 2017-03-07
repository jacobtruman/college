VERSION 5.00
Object = "{5E9E78A0-531B-11CF-91F6-C2863C385E30}#1.0#0"; "MSFLXGRD.OCX"
Begin VB.Form frmShowIndices 
   Caption         =   "Show Indices"
   ClientHeight    =   1695
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   ScaleHeight     =   1695
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
   Begin MSFlexGridLib.MSFlexGrid grdStudents 
      Height          =   1575
      Left            =   240
      TabIndex        =   0
      Top             =   120
      Width           =   4335
      _ExtentX        =   7646
      _ExtentY        =   2778
      _Version        =   393216
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
End
Attribute VB_Name = "frmShowIndices"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False


Private Sub Form_Load()
grdStudents.FixedRows = 0
grdStudents.FixedCols = 0


grdStudents.Rows = 4
grdStudents.Cols = 3

grdStudents.Row = 0

grdStudents.Col = 0
grdStudents.Text = "(0,0)"

grdStudents.Col = 1
grdStudents.Text = "(0,1)"

grdStudents.Col = 2
grdStudents.Text = "(0,2)"

grdStudents.Row = 1

grdStudents.Col = 0
grdStudents.Text = "(1,0)"

grdStudents.Col = 1
grdStudents.Text = "(1,1)"

grdStudents.Col = 2
grdStudents.Text = "(1,2)"


grdStudents.Row = 2

grdStudents.Col = 0
grdStudents.Text = "(2,0)"

grdStudents.Col = 1
grdStudents.Text = "(2,1)"

grdStudents.Col = 2
grdStudents.Text = "(2,2)"

grdStudents.Row = 3

grdStudents.Col = 0
grdStudents.Text = "(3,0)"

grdStudents.Col = 1
grdStudents.Text = "(3,1)"

grdStudents.Col = 2
grdStudents.Text = "(3,2)"
End Sub
