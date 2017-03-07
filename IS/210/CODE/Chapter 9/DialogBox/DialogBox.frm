VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   3195
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   ScaleHeight     =   3195
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command1 
      Caption         =   "Command1"
      Height          =   375
      Left            =   1080
      TabIndex        =   2
      Top             =   600
      Width           =   1575
   End
   Begin MSComDlg.CommonDialog dlgExample 
      Left            =   1560
      Top             =   2760
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.CommandButton cmdOpen 
      Caption         =   "&Open"
      Height          =   375
      Left            =   2280
      TabIndex        =   1
      Top             =   1800
      Width           =   1215
   End
   Begin VB.CommandButton cmdSaveAs 
      Caption         =   "&Save As"
      Height          =   375
      Left            =   600
      TabIndex        =   0
      Top             =   1800
      Width           =   1215
   End
   Begin MSComDlg.CommonDialog dlgFileSave 
      Left            =   240
      Top             =   2640
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub cmdOpen_Click()
Dim txtFile As String

'Set File Open dialog properties
With dlgExample
    .CancelError = False
 '   .Filter = "XXX|*.txt"
 '   .DialogTitle = "Select an Text File"
    .ShowOpen
End With
   
If (Len(dlgExample.FileName) > 0) Then
   txtFile = dlgExample.FileName  'Set variable to input file name
Else
   MsgBox "No File Selected"
   Exit Sub
End If

End Sub

Private Sub cmdSaveAs_Click()
Dim TextFileName As String ' Variable to store filename

'Set File Open dialog properties
With dlgFileSave
    .CancelError = False
'    .Filter = "Text Files(*.txt)|*.txt"
    .DialogTitle = "Save Text File as"
    .ShowSave
End With
   
If (Len(dlgFileSave.FileName) > 0) Then
   TextFileName = dlgFileSave.FileName  'Set variable to filename
Else
   MsgBox "No File Selected"
   Exit Sub
End If
End Sub

Private Sub Command1_Click()
' Set CancelError is True
  CommonDialog1.CancelError = True
  ' Set filters
  CommonDialog1.Filter = "All Files (*.*)|*.*|Text Files" & _
  "(*.txt)|*.txt|Batch Files (*.bat)|*.bat"
  ' Specify default filter
  CommonDialog1.FilterIndex = 2
  ' Display the Open dialog box
  CommonDialog1.ShowOpen
End Sub
