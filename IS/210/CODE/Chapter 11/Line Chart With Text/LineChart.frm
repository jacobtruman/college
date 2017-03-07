VERSION 5.00
Begin VB.Form frmChart 
   Caption         =   "Line Chart with Text"
   ClientHeight    =   6345
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   9855
   LinkTopic       =   "Form1"
   ScaleHeight     =   6345
   ScaleWidth      =   9855
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdChart 
      Caption         =   "Chart"
      Height          =   375
      Left            =   4080
      TabIndex        =   1
      Top             =   5880
      Width           =   1695
   End
   Begin VB.PictureBox pctOutput 
      Height          =   5535
      Left            =   120
      ScaleHeight     =   5475
      ScaleWidth      =   9555
      TabIndex        =   0
      Top             =   120
      Width           =   9615
   End
End
Attribute VB_Name = "frmChart"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdChart_Click()
Dim intCurrentY As Integer 'Counter used to track Y label
Dim intMonth As Integer ' Counter used to loop threw months
Dim strMonths(0 To 11) As String 'Array to store month names

'Initialize Months
strMonths(0) = "JAN"
strMonths(1) = "FEB"
strMonths(2) = "MAR"
strMonths(3) = "APR"
strMonths(4) = "MAY"
strMonths(5) = "JUN"
strMonths(6) = "JUL"
strMonths(7) = "AUG"
strMonths(8) = "SEP"
strMonths(9) = "OCT"
strMonths(10) = "NOV"
strMonths(11) = "DEC"

pctOutput.Scale (0, 21000)-(13, 9000)

'Draw Y axis
pctOutput.Line (0.85, 9500)-(0.85, 20500)

pctOutput.CurrentX = 0.01

'Output the labels for the Y-axis
For intCurrentY = 10000 To 20000 Step 1000
  pctOutput.CurrentY = intCurrentY
  pctOutput.Print FormatCurrency(intCurrentY, 0)
Next intCurrentY



'Draw X Axis
pctOutput.Line (0.85, 9500)-(13, 9500)

'Draw Month Labels
For intMonth = 0 To 11
   pctOutput.CurrentY = 9400
   pctOutput.CurrentX = 0.9 + intMonth
   pctOutput.Print strMonths(intMonth)
Next intMonth


pctOutput.Line (1, 12400)-(2, 15120), vbBlue
pctOutput.Line (2, 15120)-(3, 12500), vbBlue
pctOutput.Line (3, 12500)-(4, 19995), vbBlue
pctOutput.Line (4, 19995)-(5, 10275), vbBlue
pctOutput.Line (5, 10275)-(6, 14222), vbBlue
pctOutput.Line (6, 14222)-(7, 12400), vbBlue
pctOutput.Line (7, 12400)-(8, 15120), vbBlue
pctOutput.Line (8, 15120)-(9, 12500), vbBlue
pctOutput.Line (9, 12500)-(10, 19995), vbBlue
pctOutput.Line (10, 19995)-(11, 10275), vbBlue
pctOutput.Line (11, 10275)-(12, 14222), vbBlue
End Sub
