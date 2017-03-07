VERSION 5.00
Object = "{5E9E78A0-531B-11CF-91F6-C2863C385E30}#1.0#0"; "MSFLXGRD.OCX"
Begin VB.Form frmCaseStudy 
   Caption         =   "Payroll Accounting System"
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
      ItemData        =   "07_CaseStudy.frx":0000
      Left            =   5040
      List            =   "07_CaseStudy.frx":0010
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
      Height          =   1215
      Left            =   120
      Picture         =   "07_CaseStudy.frx":003A
      ScaleHeight     =   1215
      ScaleWidth      =   1575
      TabIndex        =   5
      Top             =   120
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
Attribute VB_Name = "frmCaseStudy"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Const intSalesPayRate = 25
Const intProcessingPayRate = 15
Const intManagementPayRate = 50
Const intPhonePayRate = 10
Private Sub cmdTotal_Click()
Dim intCurrentRow As Integer
Dim curTotal As Currency

curTotal = 0
intCurrentRow = 1
flxEmployees.Col = 4


Do While (flxEmployees.Rows > intCurrentRow)
    flxEmployees.Row = intCurrentRow
    curTotal = curTotal + CCur(flxEmployees.Text)
    intCurrentRow = intCurrentRow + 1
Loop

MsgBox Str(curTotal)
End Sub
Private Sub cmdAdd_Click()
flxEmployees.Rows = flxEmployees.Rows + 1

flxEmployees.Row = flxEmployees.Rows - 1

flxEmployees.Col = 0
flxEmployees.Text = flxEmployees.Rows - 1

flxEmployees.Col = 1
flxEmployees.Text = txtEmployee.Text

flxEmployees.Col = 2
flxEmployees.Text = txtHours.Text

flxEmployees.Col = 3
flxEmployees.Text = cmbDepartment.Text

flxEmployees.Col = 4
'First Week's Calculations
Select Case cmbDepartment
Case "Sales"
  flxEmployees.Text = Str(Val(txtHours.Text) * intSalesPayRate)
Case "Processing"
  flxEmployees.Text = Str(Val(txtHours.Text) * intProcessingPayRate)
Case "Management"
  flxEmployees.Text = Str(Val(txtHours.Text) * intManagementPayRate)
Case "Phone"
  flxEmployees.Text = Str(Val(txtHours.Text) * intPhonePayRate)
End Select
End Sub

Private Sub Form_Load()
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
End Sub
