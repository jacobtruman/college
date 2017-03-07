VERSION 5.00
Begin VB.Form frmPayrollSystem 
   Caption         =   "Form1"
   ClientHeight    =   5070
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7890
   LinkTopic       =   "Form1"
   ScaleHeight     =   5070
   ScaleWidth      =   7890
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton CmdCalculate 
      Caption         =   "Calculate"
      Height          =   375
      Left            =   1200
      TabIndex        =   19
      Top             =   4440
      Width           =   2055
   End
   Begin VB.TextBox txtEmployee2 
      Height          =   375
      Left            =   240
      TabIndex        =   18
      Top             =   2520
      Width           =   2775
   End
   Begin VB.TextBox txtTotalPay 
      Height          =   375
      Left            =   5640
      TabIndex        =   16
      Top             =   4320
      Width           =   1935
   End
   Begin VB.TextBox txtWeeklyPay4 
      Height          =   375
      Left            =   5640
      TabIndex        =   15
      Top             =   3720
      Width           =   1935
   End
   Begin VB.TextBox txtWeeklyPay3 
      Height          =   375
      Left            =   5640
      TabIndex        =   14
      Top             =   3120
      Width           =   1935
   End
   Begin VB.TextBox txtWeeklyPay2 
      Height          =   375
      Left            =   5640
      TabIndex        =   13
      Top             =   2520
      Width           =   1935
   End
   Begin VB.TextBox txtHours4 
      Height          =   375
      Left            =   3480
      TabIndex        =   12
      Top             =   3720
      Width           =   1095
   End
   Begin VB.TextBox txtHours3 
      Height          =   375
      Left            =   3480
      TabIndex        =   11
      Top             =   3120
      Width           =   1095
   End
   Begin VB.TextBox txtHours2 
      Height          =   375
      Left            =   3480
      TabIndex        =   10
      Top             =   2520
      Width           =   1095
   End
   Begin VB.TextBox txtEmployee4 
      Height          =   375
      Left            =   240
      TabIndex        =   9
      Top             =   3720
      Width           =   2775
   End
   Begin VB.TextBox txtEmployee3 
      Height          =   375
      Left            =   240
      TabIndex        =   8
      Top             =   3120
      Width           =   2775
   End
   Begin VB.TextBox txtWeeklyPay1 
      Height          =   375
      Left            =   5640
      TabIndex        =   7
      Top             =   1920
      Width           =   1935
   End
   Begin VB.TextBox txtHours1 
      Height          =   375
      Left            =   3480
      TabIndex        =   6
      Top             =   1920
      Width           =   1095
   End
   Begin VB.TextBox txtEmployee1 
      Height          =   375
      Left            =   240
      TabIndex        =   5
      Top             =   1920
      Width           =   2775
   End
   Begin VB.PictureBox Picture1 
      BorderStyle     =   0  'None
      Height          =   1215
      Left            =   240
      Picture         =   "3_CaseStudy.frx":0000
      ScaleHeight     =   1215
      ScaleWidth      =   1575
      TabIndex        =   0
      Top             =   120
      Width           =   1575
   End
   Begin VB.Label Label5 
      Alignment       =   1  'Right Justify
      Caption         =   "Total Payroll"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   3120
      TabIndex        =   17
      Top             =   4440
      Width           =   2415
   End
   Begin VB.Label Label4 
      Caption         =   "Weekly Pay"
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
      Left            =   5640
      TabIndex        =   4
      Top             =   1440
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
      Left            =   3480
      TabIndex        =   3
      Top             =   1440
      Width           =   1935
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
      TabIndex        =   2
      Top             =   1440
      Width           =   2055
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      Caption         =   "Payroll Accounting System"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000D&
      Height          =   495
      Left            =   2400
      TabIndex        =   1
      Top             =   240
      Width           =   4815
   End
End
Attribute VB_Name = "frmPayrollSystem"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Const sngPayRate As Single = 9.5

Private Sub CmdCalculate_Click()
'Temporary Variables to Store Calculations
Dim curTotalPay As Currency
Dim curWeeklyPay As Currency

'First Person's Calculations
'Compute weekly pay of 1st person
curWeeklyPay = Val(txtHours1.Text) * sngPayRate
'Convert weekly pay to String and output
txtWeeklyPay1.Text = curWeeklyPay
'Initialize total pay to first person's weekly pay
curTotalPay = curWeeklyPay

'Second Person's Calculations
'Compute weekly pay of 2nd person
curWeeklyPay = Val(txtHours2.Text) * sngPayRate
'Convert weekly pay to String and output
txtWeeklyPay2.Text = curWeeklyPay
'Add to total pay 2nd person's pay
curTotalPay = curTotalPay + curWeeklyPay

'Third Person's Calculations
'Compute weekly pay of 3rd person
curWeeklyPay = Val(txtHours3.Text) * sngPayRate
'Convert weekly pay to String and output
txtWeeklyPay3.Text = curWeeklyPay
'Add to total pay 3rd person's pay
curTotalPay = curTotalPay + curWeeklyPay

'Fourth Person's Calculations
'Compute weekly pay of fourth person
curWeeklyPay = Val(txtHours4.Text) * sngPayRate
'Convert weekly pay to String and output
txtWeeklyPay4.Text = curWeeklyPay
'Add to total pay 4th person's pay
curTotalPay = curTotalPay + curWeeklyPay

'Convert Total Pay to a string and copy to TextBox
txtTotalPay.Text = Str(curTotalPay)
End Sub
