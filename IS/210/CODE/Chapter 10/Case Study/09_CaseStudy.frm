VERSION 5.00
Object = "{00028C01-0000-0000-0000-000000000046}#1.0#0"; "DBGRID32.OCX"
Object = "{FAEEE763-117E-101B-8933-08002B2F4F5A}#1.1#0"; "DBLIST32.OCX"
Begin VB.Form frmPayroll 
   Caption         =   "Form1"
   ClientHeight    =   6810
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   9480
   LinkTopic       =   "Form1"
   MDIChild        =   -1  'True
   ScaleHeight     =   6810
   ScaleWidth      =   9480
   Begin MSDBCtls.DBCombo dbcDepartment 
      Bindings        =   "09_CaseStudy.frx":0000
      DataField       =   "Department"
      DataSource      =   "datPayroll"
      Height          =   315
      Left            =   4440
      TabIndex        =   13
      Top             =   600
      Width           =   1575
      _ExtentX        =   2778
      _ExtentY        =   556
      _Version        =   393216
      ListField       =   "Department"
      BoundColumn     =   "Department"
      Text            =   ""
   End
   Begin VB.Data datDepartment 
      Caption         =   "Data1"
      Connect         =   "Access 2000;"
      DatabaseName    =   "C:\VB Coach\Chapter 9\Payroll.mdb"
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   300
      Left            =   0
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   "Department"
      Top             =   6240
      Visible         =   0   'False
      Width           =   1335
   End
   Begin VB.TextBox txtDay 
      DataField       =   "Day"
      DataSource      =   "datPayroll"
      Height          =   285
      Left            =   6120
      TabIndex        =   11
      Top             =   600
      Width           =   1455
   End
   Begin VB.TextBox txtHoursWorked 
      DataField       =   "HoursWorked"
      DataSource      =   "datPayroll"
      Height          =   285
      Left            =   2880
      TabIndex        =   8
      Top             =   600
      Width           =   1215
   End
   Begin VB.TextBox txtEmployeeName 
      DataField       =   "EmployeeName"
      DataSource      =   "datPayroll"
      Height          =   285
      Left            =   480
      TabIndex        =   6
      Top             =   600
      Width           =   2055
   End
   Begin MSDBGrid.DBGrid dbgPayroll 
      Bindings        =   "09_CaseStudy.frx":001C
      Height          =   4215
      Left            =   360
      OleObjectBlob   =   "09_CaseStudy.frx":0035
      TabIndex        =   5
      Top             =   1560
      Width           =   8775
   End
   Begin VB.Data datPayroll 
      Caption         =   "Payroll"
      Connect         =   "Access 2000;"
      DatabaseName    =   "C:\VB Coach\Chapter 9\Payroll.mdb"
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   300
      Left            =   0
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   "Payroll"
      Top             =   6480
      Visible         =   0   'False
      Width           =   1695
   End
   Begin VB.CommandButton cmdAdd 
      Caption         =   "&Add"
      Height          =   375
      Left            =   1553
      TabIndex        =   4
      Top             =   6000
      Width           =   1095
   End
   Begin VB.CommandButton cmdSave 
      Caption         =   "&Save"
      Height          =   375
      Left            =   5513
      TabIndex        =   3
      Top             =   6000
      Width           =   1095
   End
   Begin VB.CommandButton cmdCancel 
      Caption         =   "&Cancel"
      Height          =   375
      Left            =   6833
      TabIndex        =   2
      Top             =   6000
      Width           =   1095
   End
   Begin VB.CommandButton cmdEdit 
      Caption         =   "&Edit"
      Height          =   375
      Left            =   2873
      TabIndex        =   1
      Top             =   6000
      Width           =   1095
   End
   Begin VB.CommandButton cmdDelete 
      Caption         =   "&Delete"
      Height          =   375
      Left            =   4193
      TabIndex        =   0
      Top             =   6000
      Width           =   1095
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
      Left            =   6120
      TabIndex        =   12
      Top             =   360
      Width           =   1455
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
      Left            =   4440
      TabIndex        =   10
      Top             =   360
      Width           =   1215
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
      Left            =   2880
      TabIndex        =   9
      Top             =   360
      Width           =   1335
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
      Left            =   480
      TabIndex        =   7
      Top             =   360
      Width           =   1575
   End
End
Attribute VB_Name = "frmPayroll"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Const SalesPayRate = 25
Const ProcessingPayRate = 15
Const ManagementPayRate = 50
Const PhonePayRate = 10
Private Sub SetDataSaveButtons()
cmdAdd.Enabled = False
cmdEdit.Enabled = False
cmdDelete.Enabled = False
cmdSave.Enabled = True
cmdCancel.Enabled = True
End Sub
Private Sub SetDataButtons()
cmdAdd.Enabled = True
cmdEdit.Enabled = True
cmdDelete.Enabled = True
cmdSave.Enabled = False
cmdCancel.Enabled = False
End Sub

Private Sub cmdAdd_Click()
dbgPayroll.Enabled = False
Call EnableDataEntryBoxes
Call SetDataSaveButtons

datPayroll.Recordset.AddNew
End Sub
Private Sub cmdCancel_Click()
dbgPayroll.Enabled = True
Call DisableDataEntryBoxes
Call SetDataButtons
datPayroll.Recordset.CancelUpdate
End Sub
Private Sub cmdDelete_Click()
With datPayroll.Recordset
    'Delete Record
    .Delete
    
    'Attempt to Move to a Valid Record
    .MoveNext
    
    'If past last record
    If .EOF Then
        'Attempt to Move to a Valid Record
        .MovePrevious
        'If no records exist
        If .BOF Then
            'Only allow Adding a Record
            cmdAdd.Enabled = True
            cmdEdit.Enabled = False
            cmdDelete.Enabled = False
            cmdSave.Enabled = False
            cmdCancel.Enabled = False
        End If
    End If
End With
End Sub

Private Sub cmdEdit_Click()
dbgPayroll.Enabled = False
Call EnableDataEntryBoxes
Call SetDataSaveButtons
datPayroll.Recordset.Edit
End Sub
Private Sub cmdSave_Click()
dbgPayroll.Enabled = True
Call DisableDataEntryBoxes
Call SetDataButtons

Call SetDailyPay

datPayroll.Recordset.Update
End Sub
Private Sub DisableDataEntryBoxes()
txtEmployeeName.Enabled = False
txtHoursWorked.Enabled = False
dbcDepartment.Enabled = False
txtDay.Enabled = False
End Sub
Private Sub EnableDataEntryBoxes()
txtEmployeeName.Enabled = True
txtHoursWorked.Enabled = True
dbcDepartment.Enabled = True
txtDay.Enabled = True
End Sub
Private Sub Form_Initialize()
Call SetDataButtons
Call DisableDataEntryBoxes
End Sub
Private Sub SetDailyPay()
With datPayroll.Recordset
    Select Case dbcDepartment
        Case "Sales"
            .Fields("Daily Pay") = txtHoursWorked * SalesPayRate
        Case "Processing"
            .Fields("Daily Pay") = txtHoursWorked * ProcessingPayRate
        Case "Management"
            .Fields("Daily Pay") = txtHoursWorked * ManagementPayRate
        Case "Phone"
            .Fields("Daily Pay") = txtHoursWorked * PhonePayRate
    End Select
End With
End Sub
