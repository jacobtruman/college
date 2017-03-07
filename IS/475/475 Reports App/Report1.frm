VERSION 5.00
Object = "{0ECD9B60-23AA-11D0-B351-00A0C9055D8E}#6.0#0"; "MSHFLXGD.OCX"
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Begin VB.Form frmMedApp 
   BorderStyle     =   4  'Fixed ToolWindow
   Caption         =   "Medication Notification Mailing List Report"
   ClientHeight    =   3810
   ClientLeft      =   7290
   ClientTop       =   5415
   ClientWidth     =   5385
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   Picture         =   "Report1.frx":0000
   ScaleHeight     =   3810
   ScaleWidth      =   5385
   ShowInTaskbar   =   0   'False
   Begin MSHierarchicalFlexGridLib.MSHFlexGrid MSHFlexGrid2 
      Height          =   855
      Left            =   600
      TabIndex        =   8
      Top             =   5040
      Width           =   4095
      _ExtentX        =   7223
      _ExtentY        =   1508
      _Version        =   393216
      _NumberOfBands  =   1
      _Band(0).Cols   =   2
   End
   Begin MSAdodcLib.Adodc Adodc2 
      Height          =   375
      Left            =   120
      Top             =   4560
      Visible         =   0   'False
      Width           =   3255
      _ExtentX        =   5741
      _ExtentY        =   661
      ConnectMode     =   0
      CursorLocation  =   3
      IsolationLevel  =   -1
      ConnectionTimeout=   15
      CommandTimeout  =   30
      CursorType      =   3
      LockType        =   3
      CommandType     =   8
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
      Connect         =   ""
      OLEDBString     =   ""
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   ""
      Caption         =   "Adodc2"
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
   Begin VB.CommandButton cmdPrint 
      Caption         =   "Print Report"
      Height          =   495
      Left            =   2880
      TabIndex        =   3
      Top             =   2400
      Width           =   1215
   End
   Begin VB.CommandButton cmdShow 
      Caption         =   "Show Report"
      Height          =   495
      Left            =   1200
      TabIndex        =   2
      Top             =   2400
      Width           =   1215
   End
   Begin VB.CommandButton cmdMM 
      Caption         =   "Main Menu"
      Height          =   495
      Left            =   3840
      TabIndex        =   4
      Top             =   3120
      Width           =   1215
   End
   Begin VB.ComboBox Combo1 
      BackColor       =   &H00C0FFFF&
      Height          =   315
      Left            =   1118
      TabIndex        =   0
      Top             =   480
      Width           =   3135
   End
   Begin MSAdodcLib.Adodc Adodc1 
      Height          =   375
      Left            =   120
      Top             =   4080
      Visible         =   0   'False
      Width           =   3255
      _ExtentX        =   5741
      _ExtentY        =   661
      ConnectMode     =   0
      CursorLocation  =   3
      IsolationLevel  =   -1
      ConnectionTimeout=   15
      CommandTimeout  =   30
      CursorType      =   3
      LockType        =   3
      CommandType     =   8
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
      Connect         =   ""
      OLEDBString     =   ""
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   ""
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
   Begin VB.CommandButton cmdCreate 
      Caption         =   "Create Mailing List"
      Height          =   375
      Left            =   1778
      TabIndex        =   1
      Top             =   1080
      Width           =   1815
   End
   Begin MSHierarchicalFlexGridLib.MSHFlexGrid MSHFlexGrid1 
      Height          =   855
      Left            =   3480
      TabIndex        =   6
      Top             =   4080
      Width           =   1815
      _ExtentX        =   3201
      _ExtentY        =   1508
      _Version        =   393216
      _NumberOfBands  =   1
      _Band(0).Cols   =   2
   End
   Begin VB.Label lblCreate 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Report Created"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   0
      TabIndex        =   7
      Top             =   1680
      Width           =   5415
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "Select Medication to Generate Report About"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   -1  'True
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   255
      Left            =   218
      TabIndex        =   5
      Top             =   120
      Width           =   4935
   End
End
Attribute VB_Name = "frmMedApp"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
' Group 1
' 04/20/2006
' IS 475 Medication Report
' Scott Nordeen
' David Lewis
' Jacob Truman
' Wesley Segafredo

Option Explicit
Dim rstMedications As ADODB.Recordset
Dim report As String

Private Sub cmdCreate_Click()
    Dim rstPatients As ADODB.Recordset
    report = ""
    Dim searchValue As String
    searchValue = Combo1.Text
    Dim sqlQuery As String
    sqlQuery = "SELECT DISTINCT pat_fname, pat_lname, pat_address, pat_city, pat_state, pat_zip From patient WHERE pat_ssn IN (SELECT pat_ssn FROM prescriptions WHERE presc_num IN (SELECT presc_num from presclines WHERE med_name = '" & searchValue & "'))"

    ' patient table
    With Adodc2
        .ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
            App.Path & "\medDB.mdb;Persist Security Info=False"

        .RecordSource = sqlQuery
    End With
    Set MSHFlexGrid2.DataSource = Adodc2
    Set rstPatients = New ADODB.Recordset
    Set rstPatients = Adodc2.Recordset
    rstPatients.Requery
    Do While Not rstPatients.EOF
        report = report & rstPatients.Fields("pat_fname") & " " & rstPatients.Fields("pat_lname") & vbCrLf _
                 & rstPatients.Fields("pat_address") & vbCrLf _
                 & rstPatients.Fields("pat_city") & ", " & rstPatients.Fields("pat_state") & " " & rstPatients.Fields("pat_zip") & vbCrLf & vbCrLf
        If rstPatients.EOF <> True Then rstPatients.MoveNext
    Loop
    
    If searchValue = "Select A Medication" Then lblCreate.Caption = "No Medication Was Selected"
    lblCreate.Caption = searchValue & " Report Created"
    Adodc2.Refresh
End Sub

Private Sub cmdMM_Click()
    frmReports.Show
    frmMedApp.Hide
End Sub

Private Sub cmdPrint_Click()
    ' print
End Sub

Private Sub cmdShow_Click()
    MsgBox (report)
End Sub

Private Sub Form_Load()
    ' medication table
    With Adodc1
        .ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
            App.Path & "\medDB.mdb;Persist Security Info=False"

        .RecordSource = "select med_name from medications"
    End With
    
    Set MSHFlexGrid1.DataSource = Adodc1
    Set rstMedications = Adodc1.Recordset

    Do While Not rstMedications.EOF
        Combo1.AddItem rstMedications.Fields(0)
        If rstMedications.EOF <> True Then rstMedications.MoveNext
    Loop
    lblCreate.Caption = ""
    Combo1.Text = "Select A Medication"
    
End Sub
