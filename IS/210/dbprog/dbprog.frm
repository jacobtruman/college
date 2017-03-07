VERSION 5.00
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Begin VB.Form frmdbprog 
   Caption         =   "Form1"
   ClientHeight    =   5775
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   5280
   LinkTopic       =   "Form1"
   ScaleHeight     =   5775
   ScaleWidth      =   5280
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame Frame1 
      Caption         =   "Frame1"
      Height          =   975
      Left            =   240
      TabIndex        =   28
      Top             =   4680
      Width           =   3975
      Begin VB.TextBox txtsnum 
         Height          =   285
         Left            =   2040
         TabIndex        =   31
         Top             =   360
         Width           =   855
      End
      Begin VB.CommandButton cmdSearch 
         Caption         =   "Search"
         Height          =   375
         Left            =   240
         TabIndex        =   29
         Top             =   360
         Width           =   735
      End
      Begin VB.Label lblsnum 
         Caption         =   "Call Number"
         Height          =   255
         Left            =   1080
         TabIndex        =   30
         Top             =   360
         Width           =   855
      End
   End
   Begin VB.CommandButton cmdExit 
      Caption         =   "Exit"
      Height          =   375
      Left            =   4320
      TabIndex        =   23
      Top             =   5160
      Width           =   735
   End
   Begin VB.CommandButton cmdLast 
      Caption         =   "Last"
      Height          =   375
      Left            =   3960
      TabIndex        =   9
      Top             =   3960
      Width           =   855
   End
   Begin VB.CommandButton cmdFirst 
      Caption         =   "First"
      Height          =   375
      Left            =   2760
      TabIndex        =   8
      Top             =   3960
      Width           =   855
   End
   Begin VB.CommandButton cmdPrev 
      Caption         =   "Previous"
      Height          =   375
      Left            =   1680
      TabIndex        =   7
      Top             =   3960
      Width           =   855
   End
   Begin VB.CommandButton cmdNext 
      Caption         =   "Next"
      Height          =   375
      Left            =   480
      TabIndex        =   6
      Top             =   3960
      Width           =   855
   End
   Begin VB.TextBox txtdspace 
      DataField       =   "dspace"
      DataSource      =   "adodbprog"
      Height          =   285
      Left            =   3600
      TabIndex        =   5
      Top             =   1440
      Width           =   1215
   End
   Begin VB.TextBox txtaddr 
      DataField       =   "addr"
      DataSource      =   "adodbprog"
      Height          =   285
      Left            =   1320
      TabIndex        =   4
      Top             =   1920
      Width           =   3495
   End
   Begin VB.TextBox txtdesc 
      DataField       =   "desc"
      DataSource      =   "adodbprog"
      Height          =   285
      Left            =   3600
      TabIndex        =   3
      Top             =   960
      Width           =   1215
   End
   Begin VB.TextBox txtauth 
      DataField       =   "auth"
      DataSource      =   "adodbprog"
      Height          =   285
      Left            =   3600
      TabIndex        =   2
      Top             =   480
      Width           =   1215
   End
   Begin VB.TextBox txtlang 
      DataField       =   "lang"
      DataSource      =   "adodbprog"
      Height          =   285
      Left            =   1320
      TabIndex        =   1
      Top             =   1440
      Width           =   1215
   End
   Begin VB.TextBox txttitle 
      DataField       =   "title"
      DataSource      =   "adodbprog"
      Height          =   285
      Left            =   1320
      TabIndex        =   0
      Top             =   960
      Width           =   1215
   End
   Begin VB.Frame frmeNav 
      Caption         =   "Navigation"
      Height          =   975
      Left            =   240
      TabIndex        =   10
      Top             =   3600
      Width           =   4815
   End
   Begin MSAdodcLib.Adodc adodbprog 
      Height          =   375
      Left            =   240
      Top             =   3120
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
      Connect         =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\donotmove\School\MIS 210\dbprog\dbprg.mdb;Persist Security Info=False"
      OLEDBString     =   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\donotmove\School\MIS 210\dbprog\dbprg.mdb;Persist Security Info=False"
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "websites"
      Caption         =   "Websites"
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
   Begin VB.Frame frmeInfo 
      Caption         =   "Website Information"
      Height          =   3015
      Left            =   240
      TabIndex        =   11
      Top             =   120
      Width           =   4815
      Begin VB.CommandButton cmdDelete 
         Caption         =   "Delete"
         Height          =   375
         Left            =   3120
         TabIndex        =   32
         Top             =   2400
         Width           =   735
      End
      Begin VB.CommandButton cmdCancel 
         Caption         =   "Cancel"
         Height          =   375
         Left            =   2160
         TabIndex        =   22
         Top             =   2400
         Width           =   735
      End
      Begin VB.CommandButton cmdNew 
         Caption         =   "New"
         Height          =   375
         Left            =   240
         TabIndex        =   21
         Top             =   2400
         Width           =   735
      End
      Begin VB.CommandButton cmdEdit 
         Caption         =   "Edit"
         Height          =   375
         Left            =   1200
         TabIndex        =   20
         Top             =   2400
         Width           =   735
      End
      Begin VB.TextBox txtnum 
         DataField       =   "callnum"
         DataSource      =   "adodbprog"
         Height          =   285
         Left            =   1080
         TabIndex        =   19
         Top             =   360
         Width           =   1215
      End
      Begin VB.Label lblnum 
         Caption         =   "Call Number"
         Height          =   255
         Left            =   120
         TabIndex        =   18
         Top             =   360
         Width           =   855
      End
      Begin VB.Label lbldspace 
         Caption         =   "Disk Space"
         Height          =   255
         Left            =   2400
         TabIndex        =   17
         Top             =   1320
         Width           =   855
      End
      Begin VB.Label lbladdr 
         Caption         =   "Address"
         Height          =   255
         Left            =   120
         TabIndex        =   16
         Top             =   1800
         Width           =   855
      End
      Begin VB.Label lbldesc 
         Caption         =   "Description"
         Height          =   255
         Left            =   2400
         TabIndex        =   15
         Top             =   840
         Width           =   855
      End
      Begin VB.Label lblauth 
         Caption         =   "Author"
         Height          =   255
         Left            =   2400
         TabIndex        =   14
         Top             =   360
         Width           =   855
      End
      Begin VB.Label lbllang 
         Caption         =   "Language"
         Height          =   255
         Left            =   120
         TabIndex        =   13
         Top             =   1320
         Width           =   855
      End
      Begin VB.Label lbltitle 
         Caption         =   "Title"
         Height          =   255
         Left            =   120
         TabIndex        =   12
         Top             =   840
         Width           =   855
      End
   End
   Begin VB.Label lblRecCnt 
      Height          =   255
      Left            =   4560
      TabIndex        =   27
      Top             =   3240
      Width           =   495
   End
   Begin VB.Label lblAbsPos 
      Height          =   255
      Left            =   3720
      TabIndex        =   26
      Top             =   3240
      Width           =   375
   End
   Begin VB.Label lblOf 
      Caption         =   "of"
      Height          =   255
      Left            =   4200
      TabIndex        =   25
      Top             =   3240
      Width           =   255
   End
   Begin VB.Label lblRecord 
      Caption         =   "Record"
      Height          =   255
      Left            =   3000
      TabIndex        =   24
      Top             =   3240
      Width           =   615
   End
End
Attribute VB_Name = "frmdbprog"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Enum State
    begin
    ending
    middle
    enedit
    disedit
End Enum

Private Sub Form_Load()
    Call Buttons(begin)
    Call EditButtons(disedit)
    Call locktxt
    Call absPos
End Sub

Private Sub cmdNext_Click()
With adodbprog.Recordset
    .MoveNext
If (.RecordCount >= .AbsolutePosition) Then
    Call Buttons(middle)
    Call absPos
End If
If (.RecordCount = .AbsolutePosition) Then
    Call Buttons(ending)
    Call absPos
End If
End With
End Sub

Private Sub cmdPrev_Click()
With adodbprog.Recordset
    .MovePrevious
If (.RecordCount >= .AbsolutePosition) Then
    Call Buttons(middle)
    Call absPos
End If
If (.AbsolutePosition = 1) Then
    Call Buttons(begin)
    Call absPos
End If
End With
End Sub

Private Sub cmdFirst_Click()
With adodbprog.Recordset
    .MoveFirst
    Call Buttons(begin)
    Call absPos
End With
End Sub

Private Sub cmdLast_Click()
With adodbprog.Recordset
    .MoveLast
    Call Buttons(ending)
    Call absPos
End With
End Sub

Private Sub Buttons(st As State)
If (st = begin) Then
    cmdNext.Enabled = True
    cmdPrev.Enabled = False
    cmdFirst.Enabled = False
    cmdLast.Enabled = True
ElseIf (st = ending) Then
    cmdNext.Enabled = False
    cmdPrev.Enabled = True
    cmdFirst.Enabled = True
    cmdLast.Enabled = False
ElseIf (st = middle) Then
    cmdNext.Enabled = True
    cmdPrev.Enabled = True
    cmdFirst.Enabled = True
    cmdLast.Enabled = True
End If
End Sub

Private Sub EditButtons(st As State)
If (st = disedit) Then
    cmdNew.Enabled = False
    cmdCancel.Enabled = False
    cmdDelete.Enabled = False
ElseIf (st = enedit) Then
    cmdNew.Enabled = False
    cmdCancel.Enabled = False
    cmdDelete.Enabled = False
    cmdNext.Enabled = False
    cmdPrev.Enabled = False
    cmdFirst.Enabled = False
    cmdLast.Enabled = False
End If
End Sub

Private Sub absPos()
    lblAbsPos = adodbprog.Recordset.AbsolutePosition
    lblRecCnt = adodbprog.Recordset.RecordCount
End Sub

Private Sub locktxt()
Dim ctlCurrent As Control
    For Each ctlCurrent In Controls
        If TypeOf ctlCurrent Is TextBox Then
            ctlCurrent.Locked = True
        End If
    Next
End Sub

Private Sub unlocktxt()
Dim ctlCurrent As Control
    For Each ctlCurrent In Controls
        If TypeOf ctlCurrent Is TextBox Then
            ctlCurrent.Locked = False
        End If
    Next
End Sub

Private Sub cmdExit_Click()
    Unload Me
End Sub
