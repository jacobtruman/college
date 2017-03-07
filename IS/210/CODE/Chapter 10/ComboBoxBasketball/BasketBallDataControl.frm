VERSION 5.00
Object = "{FAEEE763-117E-101B-8933-08002B2F4F5A}#1.1#0"; "DBLIST32.OCX"
Begin VB.Form frmBasketball 
   Caption         =   "Basketball Data Control With ComboBox"
   ClientHeight    =   4995
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7290
   LinkTopic       =   "Form1"
   ScaleHeight     =   4995
   ScaleWidth      =   7290
   StartUpPosition =   3  'Windows Default
   Begin MSDBCtls.DBCombo dbcTeam 
      Bindings        =   "BasketBallDataControl.frx":0000
      DataField       =   "Team"
      DataSource      =   "datBasketBall"
      Height          =   315
      Left            =   240
      TabIndex        =   24
      Top             =   1560
      Width           =   2655
      _ExtentX        =   4683
      _ExtentY        =   556
      _Version        =   393216
      ListField       =   "Team"
      BoundColumn     =   "Team"
      Text            =   ""
   End
   Begin VB.Data datTeam 
      Caption         =   "Data1"
      Connect         =   "Access 2000;"
      DatabaseName    =   "C:\VB Coach\Chapter 10\Code\ComboBoxBasketball\BasketBall.mdb"
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   300
      Left            =   0
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   "Team"
      Top             =   4320
      Visible         =   0   'False
      Width           =   1140
   End
   Begin MSDBCtls.DBCombo dbcPosition 
      Bindings        =   "BasketBallDataControl.frx":0016
      DataField       =   "Position"
      DataSource      =   "datBasketBall"
      Height          =   315
      Left            =   3240
      TabIndex        =   23
      Top             =   1560
      Width           =   2535
      _ExtentX        =   4471
      _ExtentY        =   556
      _Version        =   393216
      ListField       =   "Position"
      Text            =   ""
   End
   Begin VB.Data datPosition 
      Caption         =   "Position"
      Connect         =   "Access 2000;"
      DatabaseName    =   "C:\VB Coach\Chapter 10\Code\ComboBoxBasketball\BasketBall.mdb"
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   375
      Left            =   0
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   "Position"
      Top             =   4560
      Visible         =   0   'False
      Width           =   1140
   End
   Begin VB.CommandButton cmdDelete 
      Caption         =   "&Delete"
      Height          =   375
      Left            =   3098
      TabIndex        =   21
      Top             =   3240
      Width           =   1095
   End
   Begin VB.CommandButton cmdEdit 
      Caption         =   "&Edit"
      Height          =   375
      Left            =   1778
      TabIndex        =   20
      Top             =   3240
      Width           =   1095
   End
   Begin VB.CommandButton cmdCancel 
      Caption         =   "&Cancel"
      Height          =   375
      Left            =   5738
      TabIndex        =   19
      Top             =   3240
      Width           =   1095
   End
   Begin VB.CommandButton cmdSave 
      Caption         =   "&Save"
      Height          =   375
      Left            =   4418
      TabIndex        =   18
      Top             =   3240
      Width           =   1095
   End
   Begin VB.CommandButton cmdAdd 
      Caption         =   "&Add"
      Height          =   375
      Left            =   458
      TabIndex        =   17
      Top             =   3240
      Width           =   1095
   End
   Begin VB.CommandButton cmdLast 
      Caption         =   "&Last"
      Height          =   375
      Left            =   5059
      TabIndex        =   16
      Top             =   3840
      Width           =   1095
   End
   Begin VB.CommandButton cmdNext 
      Caption         =   "&Next"
      Height          =   375
      Left            =   3739
      TabIndex        =   15
      Top             =   3840
      Width           =   1095
   End
   Begin VB.CommandButton cmdPrev 
      Caption         =   "&Previous"
      Height          =   375
      Left            =   2419
      TabIndex        =   14
      Top             =   3840
      Width           =   1095
   End
   Begin VB.CommandButton cmdFirst 
      Caption         =   "&First"
      Height          =   375
      Left            =   1137
      TabIndex        =   13
      Top             =   3840
      Width           =   1095
   End
   Begin VB.TextBox txtAssists 
      DataField       =   "Assists"
      DataSource      =   "datBasketBall"
      Height          =   375
      Left            =   5040
      TabIndex        =   11
      Top             =   2400
      Width           =   2055
   End
   Begin VB.TextBox txtRebounds 
      DataField       =   "Rebounds"
      DataSource      =   "datBasketBall"
      Height          =   375
      Left            =   3480
      TabIndex        =   9
      Top             =   2400
      Width           =   1095
   End
   Begin VB.TextBox txtPoints 
      DataField       =   "Points"
      DataSource      =   "datBasketBall"
      Height          =   375
      Left            =   1920
      TabIndex        =   7
      Top             =   2400
      Width           =   1095
   End
   Begin VB.TextBox txtGamesPlayed 
      DataField       =   "Games Played"
      DataSource      =   "datBasketBall"
      Height          =   375
      Left            =   240
      TabIndex        =   5
      Top             =   2400
      Width           =   1215
   End
   Begin VB.TextBox txtFirst 
      DataField       =   "First Name"
      DataSource      =   "datBasketBall"
      Height          =   375
      Left            =   3240
      TabIndex        =   3
      Top             =   720
      Width           =   1935
   End
   Begin VB.TextBox txtLast 
      DataField       =   "Last Name"
      DataSource      =   "datBasketBall"
      Height          =   375
      Left            =   240
      TabIndex        =   0
      Top             =   720
      Width           =   2655
   End
   Begin VB.Data datBasketBall 
      Caption         =   "Basket Ball Statistics"
      Connect         =   "Access"
      DatabaseName    =   "C:\VB Coach\Chapter 10\Code\ComboBoxBasketball\BasketBall.mdb"
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   495
      Left            =   938
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   "PlayerStats"
      Top             =   4440
      Visible         =   0   'False
      Width           =   5415
   End
   Begin VB.Label Label8 
      Caption         =   "Position"
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
      Left            =   3240
      TabIndex        =   22
      Top             =   1320
      Width           =   1815
   End
   Begin VB.Label Label7 
      Caption         =   "Assists"
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
      Left            =   5040
      TabIndex        =   12
      Top             =   2160
      Width           =   735
   End
   Begin VB.Label Label6 
      Caption         =   "Rebounds"
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
      Left            =   3480
      TabIndex        =   10
      Top             =   2160
      Width           =   975
   End
   Begin VB.Label Label5 
      Caption         =   "Points"
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
      Left            =   1920
      TabIndex        =   8
      Top             =   2160
      Width           =   855
   End
   Begin VB.Label Label4 
      Caption         =   "Games Played"
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
      Left            =   240
      TabIndex        =   6
      Top             =   2160
      Width           =   1455
   End
   Begin VB.Label Label3 
      Caption         =   "Team"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   240
      TabIndex        =   4
      Top             =   1320
      Width           =   1935
   End
   Begin VB.Label Label2 
      Caption         =   "First Name"
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
      Left            =   3240
      TabIndex        =   2
      Top             =   480
      Width           =   1095
   End
   Begin VB.Label Label1 
      Caption         =   "Last Name"
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
      Left            =   240
      TabIndex        =   1
      Top             =   480
      Width           =   1215
   End
End
Attribute VB_Name = "frmBasketBall"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdAdd_Click()
Call EnableTextBoxes
Call DisableNavButtons
Call SetDataSaveButtons

datBasketBall.Recordset.AddNew

End Sub
Private Sub cmdCancel_Click()
Call DisableTextBoxes
Call SetNavButtons
Call SetDataButtons
datBasketBall.Recordset.CancelUpdate
End Sub

Private Sub cmdDelete_Click()
With datBasketBall.Recordset
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
            'Disable the Navigational Controls
            Call DisableNavButtons
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
datBasketBall.Recordset.Edit
Call EnableTextBoxes
Call DisableNavButtons
Call SetDataSaveButtons
End Sub
Private Sub cmdSave_Click()
Call DisableTextBoxes
Call SetNavButtons
Call SetDataButtons
datBasketBall.Recordset.Update
End Sub
Private Sub cmdFirst_Click()
datBasketBall.Recordset.MoveFirst
cmdPrev.Enabled = False
cmdNext.Enabled = True
End Sub
Private Sub cmdLast_Click()
datBasketBall.Recordset.MoveLast
cmdNext.Enabled = False
cmdPrev.Enabled = True
End Sub
Private Sub cmdNext_Click()
With datBasketBall.Recordset
  .MoveNext

If (.RecordCount = .AbsolutePosition + 1) Then
  cmdNext.Enabled = False
End If

End With

cmdPrev.Enabled = True

End Sub
Private Sub cmdPrev_Click()
With datBasketBall.Recordset
  .MovePrevious
  
  If (.AbsolutePosition = 0) Then
    cmdPrev.Enabled = False
  End If
End With

cmdNext.Enabled = True

End Sub

Private Sub Form_Initialize()
Call SetNavButtons
Call SetDataButtons
Call DisableTextBoxes
End Sub

Private Sub SetNavButtons()
With datBasketBall.Recordset

    'CmdPrev should be disabled when we are at the first record
    If (.AbsolutePosition = 0) Then
       cmdPrev.Enabled = False
    Else
       cmdPrev.Enabled = True
    End If
    
    'CmdNext should be disabled when we are at the last record
    If (.AbsolutePosition + 1 = .RecordCount) Then
       cmdNext.Enabled = False
    Else
       cmdNext.Enabled = True
    End If
    
    cmdFirst.Enabled = True
    cmdLast.Enabled = True
End With
End Sub
Private Sub DisableNavButtons()
cmdFirst.Enabled = False
cmdLast.Enabled = False
cmdNext.Enabled = False
cmdPrev.Enabled = False
End Sub

Private Sub DisableTextBoxes()
txtLast.Enabled = False
txtFirst.Enabled = False
dbcTeam.Enabled = False
txtGamesPlayed.Enabled = False
txtPoints.Enabled = False
txtRebounds.Enabled = False
txtAssists.Enabled = False
dbcPosition.Enabled = False
End Sub
Private Sub EnableTextBoxes()
txtLast.Enabled = True
txtFirst.Enabled = True
dbcTeam.Enabled = True
txtGamesPlayed.Enabled = True
txtPoints.Enabled = True
txtRebounds.Enabled = True
txtAssists.Enabled = True
dbcPosition.Enabled = True
End Sub
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

