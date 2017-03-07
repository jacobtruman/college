VERSION 5.00
Object = "{0ECD9B60-23AA-11D0-B351-00A0C9055D8E}#6.0#0"; "MSHFLXGD.OCX"
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Begin VB.Form frmPatient 
   BorderStyle     =   4  'Fixed ToolWindow
   Caption         =   "Patient Search"
   ClientHeight    =   7785
   ClientLeft      =   5730
   ClientTop       =   4575
   ClientWidth     =   7815
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   Picture         =   "frmPatient.frx":0000
   ScaleHeight     =   7785
   ScaleWidth      =   7815
   ShowInTaskbar   =   0   'False
   Begin VB.CommandButton cmdMenu 
      Caption         =   "Main Menu"
      Height          =   495
      Left            =   6000
      TabIndex        =   7
      Top             =   240
      Width           =   1575
   End
   Begin VB.TextBox txtSearch 
      BackColor       =   &H00C0C0C0&
      Height          =   375
      Left            =   360
      TabIndex        =   0
      Top             =   600
      Width           =   2895
   End
   Begin VB.CommandButton cmdEmail 
      Caption         =   "E-mail"
      Height          =   495
      Left            =   6360
      TabIndex        =   6
      Top             =   1080
      Width           =   1215
   End
   Begin VB.CommandButton cmdPhone 
      Caption         =   "Phone #"
      Height          =   495
      Left            =   5160
      TabIndex        =   5
      Top             =   1080
      Width           =   1215
   End
   Begin VB.CommandButton cmdZIP 
      Caption         =   "ZIP"
      Height          =   495
      Left            =   3960
      TabIndex        =   4
      Top             =   1080
      Width           =   1215
   End
   Begin VB.CommandButton cmdDOB 
      Caption         =   "D.O.B."
      Height          =   495
      Left            =   2760
      TabIndex        =   3
      Top             =   1080
      Width           =   1215
   End
   Begin VB.CommandButton cmdLname 
      Caption         =   "Last Name"
      Height          =   495
      Left            =   1560
      TabIndex        =   2
      Top             =   1080
      Width           =   1215
   End
   Begin MSAdodcLib.Adodc Adodc1 
      Height          =   375
      Left            =   4560
      Top             =   3960
      Visible         =   0   'False
      Width           =   2655
      _ExtentX        =   4683
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
   Begin MSHierarchicalFlexGridLib.MSHFlexGrid MSHFlexGrid1 
      Height          =   1815
      Left            =   4200
      TabIndex        =   8
      Top             =   5880
      Visible         =   0   'False
      Width           =   3495
      _ExtentX        =   6165
      _ExtentY        =   3201
      _Version        =   393216
      _NumberOfBands  =   1
      _Band(0).Cols   =   2
   End
   Begin VB.CommandButton cmdSSN 
      Caption         =   "SSN"
      Height          =   495
      Left            =   360
      TabIndex        =   1
      Top             =   1080
      Width           =   1215
   End
   Begin VB.Label lblEmail 
      BackStyle       =   0  'Transparent
      Caption         =   "E-mail"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   960
      TabIndex        =   19
      Top             =   7080
      Width           =   4995
   End
   Begin VB.Label lblPhone 
      BackStyle       =   0  'Transparent
      Caption         =   "Phone"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   960
      TabIndex        =   18
      Top             =   6480
      Width           =   4995
   End
   Begin VB.Label lblZip 
      BackStyle       =   0  'Transparent
      Caption         =   "Zip"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   960
      TabIndex        =   17
      Top             =   5880
      Width           =   4995
   End
   Begin VB.Label lblSSN 
      BackStyle       =   0  'Transparent
      Caption         =   "SSN"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   960
      TabIndex        =   16
      Top             =   1680
      Width           =   4995
   End
   Begin VB.Label lblState 
      BackStyle       =   0  'Transparent
      Caption         =   "State"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   960
      TabIndex        =   15
      Top             =   5280
      Width           =   4995
   End
   Begin VB.Label lblCity 
      BackStyle       =   0  'Transparent
      Caption         =   "City"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   960
      TabIndex        =   14
      Top             =   4680
      Width           =   4995
   End
   Begin VB.Label lblAddress 
      BackStyle       =   0  'Transparent
      Caption         =   "Address"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   960
      TabIndex        =   13
      Top             =   4080
      Width           =   4995
   End
   Begin VB.Label lblDOB 
      BackStyle       =   0  'Transparent
      Caption         =   "Date of Birth"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   960
      TabIndex        =   12
      Top             =   3480
      Width           =   4995
   End
   Begin VB.Label lblLname 
      BackStyle       =   0  'Transparent
      Caption         =   "Last Name"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   960
      TabIndex        =   11
      Top             =   2880
      Width           =   4995
   End
   Begin VB.Label lblFname 
      BackStyle       =   0  'Transparent
      Caption         =   "First Name"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   960
      TabIndex        =   10
      Top             =   2280
      Width           =   4995
   End
   Begin VB.Label lblSearch 
      BackStyle       =   0  'Transparent
      Caption         =   "Search For a Patient By:"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   -1  'True
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00C00000&
      Height          =   375
      Left            =   360
      TabIndex        =   9
      Top             =   120
      Width           =   3615
   End
End
Attribute VB_Name = "frmPatient"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
' Group 1
' 04/20/2006
' IS 475 Report Menu
' Scott Nordeen
' David Lewis
' Jacob Truman
' Wesley Segafredo

Option Explicit
Dim rstPatient As ADODB.Recordset

Private Sub cmdDOB_Click()
    Do While Not rstPatient.EOF
       If txtSearch.Text = rstPatient.Fields("pat_dob") Then Call DisplayPatient
       If rstPatient.EOF <> True Then rstPatient.MoveNext
    Loop
    rstPatient.Requery
End Sub

Private Sub cmdEmail_Click()
    Do While Not rstPatient.EOF
       If txtSearch.Text = rstPatient.Fields("pat_email") Then Call DisplayPatient
       If rstPatient.EOF <> True Then rstPatient.MoveNext
    Loop
    rstPatient.Requery
End Sub

Private Sub cmdLname_Click()
    Do While Not rstPatient.EOF
       If txtSearch.Text = rstPatient.Fields("pat_lname") Then Call DisplayPatient
       If rstPatient.EOF <> True Then rstPatient.MoveNext
    Loop
    rstPatient.Requery
End Sub

Private Sub cmdMenu_Click()
    frmPatient.Hide
    frmReports.Show
    Call ClearLabels
End Sub

Public Sub ClearLabels()
    txtSearch.Text = ""
    lblSSN.Caption = ""
    lblFname.Caption = ""
    lblLname.Caption = ""
    lblDOB.Caption = ""
    lblAddress.Caption = ""
    lblCity.Caption = ""
    lblState.Caption = ""
    lblZip.Caption = ""
    lblPhone.Caption = ""
    lblEmail.Caption = ""
End Sub

Public Sub DisplayPatient()
    Call ClearLabels
    lblSSN.Caption = rstPatient.Fields("pat_ssn")
    lblFname.Caption = rstPatient.Fields("pat_fname")
    lblLname.Caption = rstPatient.Fields("pat_lname")
    lblDOB.Caption = rstPatient.Fields("pat_dob")
    lblAddress.Caption = rstPatient.Fields("pat_address")
    lblCity.Caption = rstPatient.Fields("pat_city")
    lblState.Caption = rstPatient.Fields("pat_state")
    lblZip.Caption = rstPatient.Fields("pat_zip")
    lblPhone.Caption = rstPatient.Fields("pat_phone")
    lblEmail.Caption = rstPatient.Fields("pat_email")
End Sub

Private Sub cmdPhone_Click()
    Do While Not rstPatient.EOF
       If txtSearch.Text = rstPatient.Fields("pat_phone") Then Call DisplayPatient
       If rstPatient.EOF <> True Then rstPatient.MoveNext
    Loop
    rstPatient.Requery
End Sub

Private Sub cmdSSN_Click()
    Do While Not rstPatient.EOF
       If txtSearch.Text = rstPatient.Fields("pat_ssn") Then Call DisplayPatient
       If rstPatient.EOF <> True Then rstPatient.MoveNext
    Loop
    rstPatient.Requery
End Sub

Private Sub cmdZIP_Click()
    Do While Not rstPatient.EOF
       If txtSearch.Text = rstPatient.Fields("pat_zip") Then Call DisplayPatient
       If rstPatient.EOF <> True Then rstPatient.MoveNext
    Loop
    rstPatient.Requery
End Sub

Private Sub Form_Load()
    Call ClearLabels
    With Adodc1
        .ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
            App.Path & "\medDB.mdb;Persist Security Info=False"

        .RecordSource = "select * from patient"
    End With
    Set MSHFlexGrid1.DataSource = Adodc1
    
    Set rstPatient = Adodc1.Recordset
End Sub
