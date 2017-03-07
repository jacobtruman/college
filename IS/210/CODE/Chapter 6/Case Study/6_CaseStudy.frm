VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   5790
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   11790
   LinkTopic       =   "Form1"
   ScaleHeight     =   5790
   ScaleWidth      =   11790
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox txtTotalNet 
      Height          =   375
      Left            =   9840
      TabIndex        =   36
      Top             =   4320
      Width           =   1455
   End
   Begin VB.TextBox txtTotalTax 
      Height          =   375
      Left            =   8160
      TabIndex        =   35
      Top             =   4320
      Width           =   1455
   End
   Begin VB.TextBox txtNet4 
      Height          =   375
      Left            =   9840
      TabIndex        =   34
      Top             =   3720
      Width           =   1455
   End
   Begin VB.TextBox txtNet3 
      Height          =   375
      Left            =   9840
      TabIndex        =   33
      Top             =   3120
      Width           =   1455
   End
   Begin VB.TextBox txtNet2 
      Height          =   375
      Left            =   9840
      TabIndex        =   32
      Top             =   2520
      Width           =   1455
   End
   Begin VB.TextBox txtNet1 
      Height          =   375
      Left            =   9840
      TabIndex        =   31
      Top             =   1920
      Width           =   1455
   End
   Begin VB.TextBox txtTax4 
      Height          =   375
      Left            =   8160
      TabIndex        =   28
      Top             =   3720
      Width           =   1455
   End
   Begin VB.TextBox txtTax3 
      Height          =   375
      Left            =   8160
      TabIndex        =   27
      Top             =   3120
      Width           =   1455
   End
   Begin VB.TextBox txtTax2 
      Height          =   375
      Left            =   8160
      TabIndex        =   26
      Top             =   2520
      Width           =   1455
   End
   Begin VB.TextBox txtTax1 
      Height          =   375
      Left            =   8160
      TabIndex        =   25
      Top             =   1920
      Width           =   1455
   End
   Begin VB.ComboBox cmbDept4 
      Height          =   315
      ItemData        =   "6_CaseStudy.frx":0000
      Left            =   4920
      List            =   "6_CaseStudy.frx":0010
      TabIndex        =   24
      Top             =   3720
      Width           =   1335
   End
   Begin VB.ComboBox cmbDept3 
      Height          =   315
      ItemData        =   "6_CaseStudy.frx":003A
      Left            =   4920
      List            =   "6_CaseStudy.frx":004A
      TabIndex        =   23
      Top             =   3120
      Width           =   1335
   End
   Begin VB.ComboBox cmbDept2 
      Height          =   315
      ItemData        =   "6_CaseStudy.frx":0074
      Left            =   4920
      List            =   "6_CaseStudy.frx":0084
      TabIndex        =   22
      Top             =   2520
      Width           =   1335
   End
   Begin VB.ComboBox cmbDept1 
      Height          =   315
      ItemData        =   "6_CaseStudy.frx":00AE
      Left            =   4920
      List            =   "6_CaseStudy.frx":00BE
      TabIndex        =   21
      Top             =   1920
      Width           =   1335
   End
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
   Begin VB.TextBox txtTotalGross 
      Height          =   375
      Left            =   6480
      TabIndex        =   16
      Top             =   4320
      Width           =   1455
   End
   Begin VB.TextBox txtGross4 
      Height          =   375
      Left            =   6480
      TabIndex        =   15
      Top             =   3720
      Width           =   1455
   End
   Begin VB.TextBox txtGross3 
      Height          =   375
      Left            =   6480
      TabIndex        =   14
      Top             =   3120
      Width           =   1455
   End
   Begin VB.TextBox txtGross2 
      Height          =   375
      Left            =   6480
      TabIndex        =   13
      Top             =   2520
      Width           =   1455
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
   Begin VB.TextBox txtGross1 
      Height          =   375
      Left            =   6480
      TabIndex        =   7
      Top             =   1920
      Width           =   1455
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
      Left            =   120
      Picture         =   "6_CaseStudy.frx":00E8
      ScaleHeight     =   1215
      ScaleWidth      =   1575
      TabIndex        =   0
      Top             =   120
      Width           =   1575
   End
   Begin VB.Label Label8 
      Caption         =   "Net Pay"
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
      Left            =   9840
      TabIndex        =   30
      Top             =   1560
      Width           =   1215
   End
   Begin VB.Label Label7 
      Caption         =   "Tax"
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
      Left            =   8160
      TabIndex        =   29
      Top             =   1560
      Width           =   615
   End
   Begin VB.Label Label6 
      Caption         =   "Dept."
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
      Left            =   4920
      TabIndex        =   20
      Top             =   1560
      Width           =   855
   End
   Begin VB.Label Label5 
      Alignment       =   1  'Right Justify
      Caption         =   "Totals"
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
      Left            =   5280
      TabIndex        =   17
      Top             =   4320
      Width           =   1095
   End
   Begin VB.Label Label4 
      Caption         =   "Gross Pay"
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
      Left            =   6480
      TabIndex        =   4
      Top             =   1560
      Width           =   1455
   End
   Begin VB.Label Label3 
      Caption         =   "Hours"
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
      Top             =   1560
      Width           =   1095
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
      Top             =   1560
      Width           =   2055
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      Caption         =   "Payroll Account System"
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
      Left            =   2280
      TabIndex        =   1
      Top             =   240
      Width           =   4815
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
Const TaxRate = 0.28

'Temporary Variables to Store Calculations
Dim tmpTotalGross As Currency
Dim tmpTotalTax As Currency
Dim tmpTotalNet As Currency

Private Sub ComputePay(Hours As TextBox, Dept As ComboBox, Gross As TextBox, Tax As TextBox, Net As TextBox)

Select Case Dept
Case "Sales"
 Gross = Hours * SalesPayRate
Case "Processing"
 Gross = Hours * ProcessingPayRate
Case "Management"
 Gross = Hours * ManagementPayRate
Case "Phone"
 Gross = Hours * PhonePayRate
End Select

Tax = Gross * TaxRate
Net = Gross - Tax

tmpTotalGross = tmpTotalGross + Gross
tmpTotalTax = tmpTotalTax + Tax
tmpTotalNet = tmpTotalNet + Net

End Sub
Private Sub CmdCalculate_Click()

'First Week's Calculations
ComputePay txtHours1, cmbDept1, txtGross1, txtTax1, txtNet1
ComputePay txtHours2, cmbDept2, txtGross2, txtTax2, txtNet2
ComputePay txtHours3, cmbDept3, txtGross3, txtTax3, txtNet3
ComputePay txtHours4, cmbDept4, txtGross4, txtTax4, txtNet4


'Copy the Total's to their TextBoxes
txtTotalGross = tmpTotalGross
txtTotalTax = tmpTotalTax
txtTotalNet = tmpTotalNet
End Sub

