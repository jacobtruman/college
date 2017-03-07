VERSION 5.00
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Begin VB.Form frmPayrollChart 
   Caption         =   "Form1"
   ClientHeight    =   6255
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   10305
   LinkTopic       =   "Form1"
   ScaleHeight     =   6255
   ScaleWidth      =   10305
   StartUpPosition =   3  'Windows Default
   Begin VB.PictureBox pctOneMonth 
      BorderStyle     =   0  'None
      DragIcon        =   "frmPayrollChart.frx":0000
      DragMode        =   1  'Automatic
      Height          =   855
      Left            =   360
      Picture         =   "frmPayrollChart.frx":014A
      ScaleHeight     =   855
      ScaleWidth      =   855
      TabIndex        =   3
      Top             =   720
      Width           =   855
   End
   Begin VB.PictureBox pctTwoMonths 
      BorderStyle     =   0  'None
      DragIcon        =   "frmPayrollChart.frx":153F
      DragMode        =   1  'Automatic
      Height          =   735
      Left            =   360
      Picture         =   "frmPayrollChart.frx":1689
      ScaleHeight     =   735
      ScaleWidth      =   735
      TabIndex        =   2
      Top             =   1680
      Width           =   735
   End
   Begin VB.PictureBox pctThreeMonth 
      BorderStyle     =   0  'None
      DragIcon        =   "frmPayrollChart.frx":2AF7
      DragMode        =   1  'Automatic
      Height          =   855
      Left            =   360
      Picture         =   "frmPayrollChart.frx":2C41
      ScaleHeight     =   855
      ScaleWidth      =   855
      TabIndex        =   1
      Top             =   2640
      Width           =   855
   End
   Begin VB.PictureBox pctChart 
      Height          =   4695
      Left            =   1680
      ScaleHeight     =   4635
      ScaleWidth      =   8115
      TabIndex        =   0
      Top             =   720
      Width           =   8175
   End
   Begin MSAdodcLib.Adodc adoPayroll 
      Height          =   495
      Left            =   2640
      Top             =   5520
      Visible         =   0   'False
      Width           =   6135
      _ExtentX        =   10821
      _ExtentY        =   873
      ConnectMode     =   0
      CursorLocation  =   3
      IsolationLevel  =   -1
      ConnectionTimeout=   15
      CommandTimeout  =   30
      CursorType      =   3
      LockType        =   3
      CommandType     =   1
      CursorOptions   =   0
      CacheSize       =   50
      MaxRecords      =   0
      BOFAction       =   0
      EOFAction       =   0
      ConnectStringType=   1
      Appearance      =   1
      BackColor       =   -2147483643
      ForeColor       =   -2147483640
      Orientation     =   0
      Enabled         =   -1
      Connect         =   "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=C:\VB Coach\Code\Chapter 10\Case Study\Payroll.mdb"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.3.51;Persist Security Info=False;Data Source=C:\VB Coach\Code\Chapter 10\Case Study\Payroll.mdb"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "Select * from Payroll"
      Caption         =   "Adodc1"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      _Version        =   393216
   End
   Begin VB.Label lblTitle 
      Alignment       =   2  'Center
      Caption         =   "Payroll"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   750
      TabIndex        =   4
      Top             =   120
      Width           =   9015
   End
End
Attribute VB_Name = "frmPayrollChart"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Const SalesPayRate = 25
Const ProcessingPayRate = 15
Const ManagementPayRate = 50
Const PhonePayRate = 10
Private Function DrawAxis(curMaxValue As Currency, curMinValue As Currency) As Currency

Dim curRange As Currency
Dim curMinChartValue As Currency

curRange = curMaxValue - curMinValue

'Compute Chart Minimum Value
curMinChartValue = Max2(curMinValue - curRange * 0.1, 0)

'Clear Previous Chart
pctChart.Cls

'Set scale of chart to just larger and smaller than the max and min values
pctChart.Scale (0, curMaxValue + curRange * 0.1)-(5, curMinChartValue - curRange * 0.1)

'Draw X-Axis
pctChart.Line (0.5, curMinChartValue)-(4.5, curMinChartValue)

'Add Labels to X-Axis
pctChart.CurrentX = 0
pctChart.CurrentY = curMinChartValue
pctChart.Print curMinChartValue
pctChart.Line (0.4, curMinChartValue)-(0.5, curMinChartValue)

pctChart.CurrentX = 0
pctChart.CurrentY = curMaxValue
pctChart.Print curMaxValue
pctChart.Line (0.4, curMaxValue)-(0.5, curMaxValue)

pctChart.CurrentX = 0
pctChart.CurrentY = curMaxValue / 2
pctChart.Print curMaxValue / 2
pctChart.Line (0.4, curMaxValue / 2)-(0.5, curMaxValue / 2)


'Draw Y-Axis
pctChart.Line (0.5, curMinChartValue)-(0.5, curMaxValue + curRange * 0.05)

'Add Labels to Y-Axis
pctChart.CurrentY = curMinChartValue * 0.95
pctChart.CurrentX = 0.7
pctChart.Print "Management"

pctChart.CurrentX = 1.85
pctChart.CurrentY = curMinChartValue * 0.95
pctChart.Print "Phone"

pctChart.CurrentX = 2.75
pctChart.CurrentY = curMinChartValue * 0.95
pctChart.Print "Processing"

pctChart.CurrentX = 3.88
pctChart.CurrentY = curMinChartValue * 0.95
pctChart.Print "Sales"

'Return the Minimum Chart Value
DrawAxis = curMinChartValue

End Function

Private Sub pctChart_DragDrop(Source As Control, X As Single, Y As Single)
Dim dteFirstDay As Date
Dim curManagement As Currency
Dim curPhone As Currency
Dim curProcessing As Currency
Dim curSales As Currency

Dim curMinValue As Currency
Dim curMaxValue As Currency
Dim curMinChartValue As Currency

'Compute the number of days to display data for
Select Case Source.Name
    Case "pctOneMonth"
        dteFirstDay = Date - 30
        lblTitle = "Payroll for the Last 30 Days"
    Case "pctTwoMonths"
        dteFirstDay = Date - 60
        lblTitle = "Payroll for the Last 60 Days"
    Case "pctThreeMonths"
        dteFirstDay = Date - 90
        lblTitle = "Payroll for the Last 90 Days"
End Select

'Query database for new data
adoPayroll.RecordSource = "Select Sum([Daily Pay])as DailyPay, Department from payroll where Day >= #" & CDate(dteFirstDay) & "# group by Department order by Department"
adoPayroll.Refresh

'Gather totals for each department
adoPayroll.Recordset.MoveFirst
curManagement = adoPayroll.Recordset.Fields(0)

adoPayroll.Recordset.MoveNext
curPhone = adoPayroll.Recordset.Fields(0)

adoPayroll.Recordset.MoveNext
curProcessing = adoPayroll.Recordset.Fields(0)

adoPayroll.Recordset.MoveNext
curSales = adoPayroll.Recordset.Fields(0)

'Compute Min and Max Values
curMinValue = Min(curManagement, curPhone, curProcessing, curSales)
curMaxValue = Max(curManagement, curPhone, curProcessing, curSales)

'Draw Axis and labels for chart
curMinChartValue = DrawAxis(curMaxValue, curMinValue)

'Draw Management Bar
pctChart.Line (0.9, curMinChartValue)-(1.1, curManagement), vbBlue, BF

'Draw Phone Bar
pctChart.Line (1.9, curMinChartValue)-(2.1, curPhone), vbBlue, BF

'Draw Processing Bar
pctChart.Line (2.9, curMinChartValue)-(3.1, curProcessing), vbBlue, BF

'Draw Sales Bar
pctChart.Line (3.9, curMinChartValue)-(4.1, curSales), vbBlue, BF
End Sub

Private Function Max2(curVal1 As Currency, curVal2 As Currency) As Currency
If (curVal1 > curVal2) Then
   Max2 = curVal1
Else
    Max2 = curVal2
End If
End Function

Private Function Max(curVal1 As Currency, curVal2 As Currency, curVal3 As Currency, curVal4 As Currency) As Currency
If (curVal1 > curVal2) And (curVal1 > curVal3) And (curVal1 > curVal4) Then
   Max = curVal1
ElseIf (curVal2 > curVal3) And (curVal2 > curVal4) Then
   Max = curVal2
ElseIf (curVal3 > curVal4) Then
    Max = curVal3
Else
    Max = curVal4
End If
End Function

Private Function Min(curVal1 As Currency, curVal2 As Currency, curVal3 As Currency, curVal4 As Currency) As Currency
If (curVal1 < curVal2) And (curVal1 < curVal3) And (curVal1 < curVal4) Then
   Min = curVal1
ElseIf (curVal2 < curVal3) And (curVal2 < curVal4) Then
   Min = curVal2
ElseIf (curVal3 < curVal4) Then
    Min = curVal3
Else
    Min = curVal4
End If
End Function

