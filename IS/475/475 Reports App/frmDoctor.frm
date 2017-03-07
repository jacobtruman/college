VERSION 5.00
Object = "{0ECD9B60-23AA-11D0-B351-00A0C9055D8E}#6.0#0"; "MSHFLXGD.OCX"
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Begin VB.Form frmDoctor 
   BorderStyle     =   4  'Fixed ToolWindow
   Caption         =   "Doctor Search"
   ClientHeight    =   9945
   ClientLeft      =   5850
   ClientTop       =   3270
   ClientWidth     =   7695
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   Picture         =   "frmDoctor.frx":0000
   ScaleHeight     =   9945
   ScaleWidth      =   7695
   ShowInTaskbar   =   0   'False
   Begin MSAdodcLib.Adodc Adodc1 
      Height          =   375
      Left            =   3600
      Top             =   9000
      Visible         =   0   'False
      Width           =   2775
      _ExtentX        =   4895
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
      Height          =   2055
      Left            =   2520
      TabIndex        =   17
      Top             =   7320
      Visible         =   0   'False
      Width           =   5175
      _ExtentX        =   9128
      _ExtentY        =   3625
      _Version        =   393216
      _NumberOfBands  =   1
      _Band(0).Cols   =   2
   End
   Begin VB.CommandButton cmdMenu 
      Caption         =   "Main Menu"
      Height          =   495
      Left            =   5880
      TabIndex        =   6
      Top             =   240
      Width           =   1575
   End
   Begin VB.TextBox txtSearch 
      BackColor       =   &H00C0C0C0&
      Height          =   375
      Left            =   240
      TabIndex        =   0
      Top             =   600
      Width           =   2895
   End
   Begin VB.CommandButton cmdEmail 
      Caption         =   "E-mail"
      Height          =   495
      Left            =   5760
      TabIndex        =   5
      Top             =   1080
      Width           =   1215
   End
   Begin VB.CommandButton cmdMobile 
      Caption         =   "Mobile Phone"
      Height          =   495
      Left            =   4560
      TabIndex        =   4
      Top             =   1080
      Width           =   1215
   End
   Begin VB.CommandButton cmdOffice 
      Caption         =   "Office Phone"
      Height          =   495
      Left            =   3360
      TabIndex        =   3
      Top             =   1080
      Width           =   1215
   End
   Begin VB.CommandButton cmdLname 
      Caption         =   "Last Name"
      Height          =   495
      Left            =   2160
      TabIndex        =   2
      Top             =   1080
      Width           =   1215
   End
   Begin VB.CommandButton cmdID 
      Caption         =   "ID #"
      Height          =   495
      Left            =   960
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
      Left            =   480
      TabIndex        =   19
      Top             =   7920
      Width           =   4995
   End
   Begin VB.Label lblMphone 
      BackStyle       =   0  'Transparent
      Caption         =   "Mobile Phone"
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
      Left            =   480
      TabIndex        =   18
      Top             =   7320
      Width           =   4995
   End
   Begin VB.Label lblTitle 
      BackStyle       =   0  'Transparent
      Caption         =   "Title"
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
      Left            =   480
      TabIndex        =   16
      Top             =   2520
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
      Left            =   480
      TabIndex        =   15
      Top             =   3120
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
      Left            =   480
      TabIndex        =   14
      Top             =   3720
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
      Left            =   480
      TabIndex        =   13
      Top             =   4320
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
      Left            =   480
      TabIndex        =   12
      Top             =   4920
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
      Left            =   480
      TabIndex        =   11
      Top             =   5520
      Width           =   4995
   End
   Begin VB.Label lblID 
      BackStyle       =   0  'Transparent
      Caption         =   "ID #"
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
      Left            =   480
      TabIndex        =   10
      Top             =   1920
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
      Left            =   480
      TabIndex        =   9
      Top             =   6120
      Width           =   4995
   End
   Begin VB.Label lblPhone 
      BackStyle       =   0  'Transparent
      Caption         =   "Office Phone"
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
      Left            =   480
      TabIndex        =   8
      Top             =   6720
      Width           =   4995
   End
   Begin VB.Label lblSearch 
      BackStyle       =   0  'Transparent
      Caption         =   "Search For a Doctor By:"
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
      Left            =   240
      TabIndex        =   7
      Top             =   120
      Width           =   3615
   End
End
Attribute VB_Name = "frmDoctor"
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

Dim rstDoctors As ADODB.Recordset

Private Sub cmdEmail_Click()
    Do While Not rstDoctors.EOF
       If txtSearch.Text = rstDoctors.Fields("doc_email") Then Call DisplayDoctor
       If rstDoctors.EOF <> True Then rstDoctors.MoveNext
    Loop
    rstDoctors.Requery

End Sub

Private Sub cmdID_Click()
    Do While Not rstDoctors.EOF
       If txtSearch.Text = rstDoctors.Fields("doc_id") Then Call DisplayDoctor
       If rstDoctors.EOF <> True Then rstDoctors.MoveNext
    Loop
    rstDoctors.Requery
End Sub

Private Sub cmdLname_Click()
    Do While Not rstDoctors.EOF
       If txtSearch.Text = rstDoctors.Fields("doc_lname") Then Call DisplayDoctor
       If rstDoctors.EOF <> True Then rstDoctors.MoveNext
    Loop
    rstDoctors.Requery
End Sub

Private Sub cmdMenu_Click()
    frmDoctor.Hide
    frmReports.Show
    Call ClearLabels
End Sub
Public Sub DisplayDoctor()
    Call ClearLabels
    lblID.Caption = rstDoctors.Fields("doc_id")
    lblTitle.Caption = rstDoctors.Fields("doc_position")
    lblFname.Caption = rstDoctors.Fields("doc_fname")
    lblLname.Caption = rstDoctors.Fields("doc_lname")
    lblAddress.Caption = rstDoctors.Fields("doc_address")
    lblCity.Caption = rstDoctors.Fields("doc_city")
    lblState.Caption = rstDoctors.Fields("doc_state")
    lblZip.Caption = rstDoctors.Fields("doc_zip")
    lblPhone.Caption = rstDoctors.Fields("doc_phone")
    lblMphone.Caption = rstDoctors.Fields("doc_mobile")
    lblEmail.Caption = rstDoctors.Fields("doc_email")
End Sub

Public Sub ClearLabels()
    txtSearch.Text = ""
    lblID.Caption = ""
    lblTitle.Caption = ""
    lblFname.Caption = ""
    lblLname.Caption = ""
    lblAddress.Caption = ""
    lblCity.Caption = ""
    lblState.Caption = ""
    lblZip.Caption = ""
    lblPhone.Caption = ""
    lblMphone.Caption = ""
    lblEmail.Caption = ""
End Sub

Private Sub cmdMobile_Click()
    Do While Not rstDoctors.EOF
       If txtSearch.Text = rstDoctors.Fields("doc_mobile") Then Call DisplayDoctor
       If rstDoctors.EOF <> True Then rstDoctors.MoveNext
    Loop
    rstDoctors.Requery

End Sub

Private Sub cmdOffice_Click()
    Do While Not rstDoctors.EOF
       If txtSearch.Text = rstDoctors.Fields("doc_phone") Then Call DisplayDoctor
       If rstDoctors.EOF <> True Then rstDoctors.MoveNext
    Loop
    rstDoctors.Requery

End Sub

Private Sub Form_Load()
    Call ClearLabels
    With Adodc1
        .ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
            App.Path & "\medDB.mdb;Persist Security Info=False"

        .RecordSource = "select * from doctor"
    End With
    Set MSHFlexGrid1.DataSource = Adodc1
    
    Set rstDoctors = Adodc1.Recordset
End Sub
