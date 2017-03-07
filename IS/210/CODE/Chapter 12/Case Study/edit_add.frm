VERSION 5.00
Object = "{FAEEE763-117E-101B-8933-08002B2F4F5A}#1.1#0"; "DBLIST32.OCX"
Begin VB.Form frmAddEdit 
   Caption         =   "Add Employee"
   ClientHeight    =   3195
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7155
   LinkTopic       =   "Form2"
   ScaleHeight     =   3195
   ScaleWidth      =   7155
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdCancel 
      Caption         =   "&Cancel"
      Height          =   375
      Left            =   3720
      TabIndex        =   9
      Top             =   1200
      Width           =   1095
   End
   Begin VB.CommandButton cmdSave 
      Caption         =   "&Save"
      Height          =   375
      Left            =   2400
      TabIndex        =   8
      Top             =   1200
      Width           =   1095
   End
   Begin VB.TextBox txtEmployeeName 
      DataField       =   "EmployeeName"
      DataSource      =   "datPayroll"
      Height          =   285
      Left            =   0
      TabIndex        =   3
      Top             =   240
      Width           =   2055
   End
   Begin VB.TextBox txtHoursWorked 
      DataField       =   "HoursWorked"
      DataSource      =   "datPayroll"
      Height          =   285
      Left            =   2400
      TabIndex        =   2
      Top             =   240
      Width           =   1215
   End
   Begin VB.TextBox txtDay 
      DataField       =   "Day"
      DataSource      =   "datPayroll"
      Height          =   285
      Left            =   5640
      TabIndex        =   1
      Top             =   240
      Width           =   1455
   End
   Begin MSDBCtls.DBCombo dbcDepartment 
      Bindings        =   "edit_add.frx":0000
      DataField       =   "Department"
      DataSource      =   "datPayroll"
      Height          =   315
      Left            =   3960
      TabIndex        =   0
      Top             =   240
      Width           =   1575
      _ExtentX        =   2778
      _ExtentY        =   556
      _Version        =   393216
      ListField       =   "Department"
      BoundColumn     =   "Department"
      Text            =   ""
   End
   Begin VB.Label Label1 
      Caption         =   "Employee Name"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   0
      TabIndex        =   7
      Top             =   0
      Width           =   1575
   End
   Begin VB.Label Label2 
      Caption         =   "Hours Worked"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   2400
      TabIndex        =   6
      Top             =   0
      Width           =   1335
   End
   Begin VB.Label Label3 
      Caption         =   "Department"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   3960
      TabIndex        =   5
      Top             =   0
      Width           =   1215
   End
   Begin VB.Label Label4 
      Caption         =   "Day"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   5640
      TabIndex        =   4
      Top             =   0
      Width           =   1455
   End
End
Attribute VB_Name = "frmAddEdit"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdCancel_Click()
dbgPayroll.Enabled = True
Call DisableDataEntryBoxes
Call SetDataButtons
Form1.datPayroll.Recordset.CancelUpdate
End Sub

Private Sub cmdSave_Click()
dbgPayroll.Enabled = True
Call DisableDataEntryBoxes
Call SetDataButtons

Call SetDailyPay
Form1.datPayroll.Recordset.Update
End Sub
