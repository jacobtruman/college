VERSION 5.00
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Object = "{CDE57A40-8B86-11D0-B3C6-00A0C90AEA82}#1.0#0"; "MSDATGRD.OCX"
Begin VB.Form frmPayroll 
   Caption         =   "Payroll"
   ClientHeight    =   6810
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   9480
   LinkTopic       =   "Form1"
   MDIChild        =   -1  'True
   ScaleHeight     =   6810
   ScaleWidth      =   9480
   Begin VB.CommandButton cmdPicture 
      Caption         =   "&Picture"
      Height          =   375
      Left            =   8160
      TabIndex        =   6
      Top             =   4560
      Width           =   1215
   End
   Begin MSDataGridLib.DataGrid grdPayroll 
      Bindings        =   "11_CaseStudy.frx":0000
      Height          =   4215
      Left            =   120
      TabIndex        =   5
      Top             =   120
      Width           =   9135
      _ExtentX        =   16113
      _ExtentY        =   7435
      _Version        =   393216
      HeadLines       =   1
      RowHeight       =   15
      BeginProperty HeadFont {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ColumnCount     =   2
      BeginProperty Column00 
         DataField       =   ""
         Caption         =   ""
         BeginProperty DataFormat {6D835690-900B-11D0-9484-00A0C91110ED} 
            Type            =   0
            Format          =   ""
            HaveTrueFalseNull=   0
            FirstDayOfWeek  =   0
            FirstWeekOfYear =   0
            LCID            =   1033
            SubFormatType   =   0
         EndProperty
      EndProperty
      BeginProperty Column01 
         DataField       =   ""
         Caption         =   ""
         BeginProperty DataFormat {6D835690-900B-11D0-9484-00A0C91110ED} 
            Type            =   0
            Format          =   ""
            HaveTrueFalseNull=   0
            FirstDayOfWeek  =   0
            FirstWeekOfYear =   0
            LCID            =   1033
            SubFormatType   =   0
         EndProperty
      EndProperty
      SplitCount      =   1
      BeginProperty Split0 
         BeginProperty Column00 
         EndProperty
         BeginProperty Column01 
         EndProperty
      EndProperty
   End
   Begin MSAdodcLib.Adodc datPayroll 
      Height          =   330
      Left            =   2520
      Top             =   5040
      Visible         =   0   'False
      Width           =   4455
      _ExtentX        =   7858
      _ExtentY        =   582
      ConnectMode     =   0
      CursorLocation  =   3
      IsolationLevel  =   -1
      ConnectionTimeout=   15
      CommandTimeout  =   30
      CursorType      =   3
      LockType        =   3
      CommandType     =   2
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
      Connect         =   $"11_CaseStudy.frx":0019
      OLEDBString     =   $"11_CaseStudy.frx":018C
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "Payroll"
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
   Begin VB.CommandButton cmdAdd 
      Caption         =   "&Add"
      Height          =   375
      Left            =   1553
      TabIndex        =   4
      Top             =   4560
      Width           =   1095
   End
   Begin VB.CommandButton cmdSave 
      Caption         =   "&Save"
      Height          =   375
      Left            =   5513
      TabIndex        =   3
      Top             =   4560
      Width           =   1095
   End
   Begin VB.CommandButton cmdCancel 
      Caption         =   "&Cancel"
      Height          =   375
      Left            =   6833
      TabIndex        =   2
      Top             =   4560
      Width           =   1095
   End
   Begin VB.CommandButton cmdEdit 
      Caption         =   "&Edit"
      Height          =   375
      Left            =   2873
      TabIndex        =   1
      Top             =   4560
      Width           =   1095
   End
   Begin VB.CommandButton cmdDelete 
      Caption         =   "&Delete"
      Height          =   375
      Left            =   4193
      TabIndex        =   0
      Top             =   4560
      Width           =   1095
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


Private Sub cmdAdd_Click()
datPayroll.Recordset.AddNew
frmAddEdit.Caption = "Add Payroll Record"
frmAddEdit.Show
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

Private Sub cmdPicture_Click()
frmPicture.pctPicture.Picture = LoadPicture(datPayroll.Recordset.Fields("Picture"))
frmPicture.Show
End Sub
