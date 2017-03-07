VERSION 5.00
Object = "{5E9E78A0-531B-11CF-91F6-C2863C385E30}#1.0#0"; "MSFLXGRD.OCX"
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   5145
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   8865
   LinkTopic       =   "Form1"
   ScaleHeight     =   5145
   ScaleWidth      =   8865
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdTotal 
      Caption         =   "Calculate Total"
      Height          =   375
      Left            =   5880
      TabIndex        =   4
      Top             =   4680
      Width           =   2055
   End
   Begin VB.CommandButton cmdAdd 
      Caption         =   "Add Employee"
      Height          =   375
      Left            =   3240
      TabIndex        =   3
      Top             =   4680
      Width           =   2175
   End
   Begin VB.TextBox txtEmployee 
      Height          =   375
      Left            =   240
      TabIndex        =   0
      Top             =   4080
      Width           =   2415
   End
   Begin VB.TextBox txtHours 
      Height          =   375
      Left            =   3000
      TabIndex        =   1
      Top             =   4080
      Width           =   1095
   End
   Begin VB.ComboBox cmbDepartment 
      Height          =   315
      ItemData        =   "08_CaseStudy.frx":0000
      Left            =   5040
      List            =   "08_CaseStudy.frx":0010
      TabIndex        =   2
      Top             =   4080
      Width           =   1335
   End
   Begin MSFlexGridLib.MSFlexGrid flxEmployees 
      Height          =   1695
      Left            =   360
      TabIndex        =   7
      Top             =   1560
      Width           =   7815
      _ExtentX        =   13785
      _ExtentY        =   2990
      _Version        =   393216
   End
   Begin VB.PictureBox Picture1 
      BorderStyle     =   0  'None
      Height          =   1335
      Left            =   120
      Picture         =   "08_CaseStudy.frx":003A
      ScaleHeight     =   1335
      ScaleWidth      =   1575
      TabIndex        =   5
      Top             =   240
      Width           =   1575
   End
   Begin VB.Label Label2 
      Caption         =   "Employee Name"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   240
      TabIndex        =   10
      Top             =   3600
      Width           =   2055
   End
   Begin VB.Label Label3 
      Caption         =   "Hours Worked"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   3000
      TabIndex        =   9
      Top             =   3600
      Width           =   1815
   End
   Begin VB.Label Label6 
      Caption         =   "Department"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   5040
      TabIndex        =   8
      Top             =   3600
      Width           =   1455
   End
   Begin VB.Label Label1 
      Caption         =   "Payroll Accounting System"
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
      Left            =   2760
      TabIndex        =   6
      Top             =   360
      Width           =   3975
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Const SalesPayRate = 25
Const ProcessingPayRate = 15
Const ManagementPayRate = 50
Const PhonePayRate = 10
Private Sub cmdTotal_Click()
Dim CurrentRow As Integer
Dim Total As Currency

Total = 0
CurrentRow = 1
flxEmployees.Col = 4


Do While (flxEmployees.Rows > CurrentRow)
flxEmployees.Row = CurrentRow
Total = Total + flxEmployees.Text
CurrentRow = CurrentRow + 1
Loop

MsgBox Total
End Sub
Private Sub cmdAdd_Click()
flxEmployees.Rows = flxEmployees.Rows + 1

flxEmployees.Row = flxEmployees.Rows - 1

flxEmployees.Col = 0
flxEmployees.Text = flxEmployees.Rows - 1

flxEmployees.Col = 1
flxEmployees.Text = txtEmployee

flxEmployees.Col = 2
flxEmployees.Text = txtHours

flxEmployees.Col = 3
flxEmployees.Text = cmbDepartment

flxEmployees.Col = 4
'First Week's Calculations
Select Case cmbDepartment
Case "Sales"
  flxEmployees.Text = txtHours * SalesPayRate
Case "Processing"
  flxEmployees.Text = txtHours * ProcessingPayRate
Case "Management"
  flxEmployees.Text = txtHours * ManagementPayRate
Case "Phone"
  flxEmployees.Text = txtHours * PhonePayRate
End Select
End Sub

Private Sub Form_Load()
Dim PayrollFile As Integer
Dim InputLine As String

flxEmployees.Rows = 1
flxEmployees.Cols = 5

flxEmployees.Row = 0
flxEmployees.Col = 0
flxEmployees.Text = "Employee #"


flxEmployees.Col = 1
flxEmployees.Text = "Employee Name"

flxEmployees.Col = 2
flxEmployees.Text = "Hours Worked"

flxEmployees.Col = 3
flxEmployees.Text = "Department"

flxEmployees.Col = 4
flxEmployees.Text = "Weekly Pay"

PayrollFile = FreeFile
Open "C:\VB Coach\Chapter 8\CaseStudy.txt" For Input As #PayrollFile

Do While Not (EOF(1))
  Line Input #PayrollFile, InputLine
  flxEmployees.Rows = flxEmployees.Rows + 1
  flxEmployees.Row = flxEmployees.Rows - 1
  
  'Employee Number
  flxEmployees.Col = 0
  flxEmployees.Text = Str(flxEmployees.Row)
  
  
  'Employee Name
  flxEmployees.Col = 1
  flxEmployees.Text = Trim(Mid(InputLine, 1, 20))
  
  'Hours Worked
  flxEmployees.Col = 2
  flxEmployees.Text = Trim(Mid(InputLine, 21, 10))
  
  'Department
  flxEmployees.Col = 3
  flxEmployees.Text = Trim(Mid(InputLine, 31, 15))
  
  'Weekly Pay
  flxEmployees.Col = 4
  flxEmployees.Text = Trim(Mid(InputLine, 46, 10))
  
  
    
Loop

Close #PayrollFile

End Sub

Private Sub Form_Unload(Cancel As Integer)
Dim CurrentRow As Integer
Dim PayrollFile As Integer

Dim EmployeeName As String
Dim HoursWorked As String
Dim Department As String
Dim WeeklyPay As String

PayrollFile = FreeFile
Open "C:\VB Coach\Chapter 8\CaseStudy.txt" For Output As #PayrollFile

CurrentRow = 1

Do While (CurrentRow < flxEmployees.Rows)
  'Employee Name
  flxEmployees.Row = CurrentRow
  flxEmployees.Col = 1
  EmployeeName = PadRight(flxEmployees.Text, 20)
  
  'Hours Worked
  flxEmployees.Col = 2
  HoursWorked = PadRight(flxEmployees.Text, 10)
  
  'Department
  flxEmployees.Col = 3
  Department = PadRight(flxEmployees.Text, 15)
  
  'Weekly Pay
  flxEmployees.Col = 4
  WeeklyPay = PadRight(flxEmployees.Text, 10)
  
  Print #PayrollFile, EmployeeName + HoursWorked + Department + WeeklyPay
  CurrentRow = CurrentRow + 1
Loop

Close #PayrollFile

End Sub

Function PadRight(Value As String, Size As Integer) As String

Value = Trim(Value)
PadRight = Value + Space(Size - Len(Value))
End Function

