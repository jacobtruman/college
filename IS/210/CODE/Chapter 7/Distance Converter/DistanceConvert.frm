VERSION 5.00
Begin VB.Form frmConverter 
   Caption         =   "Miles"
   ClientHeight    =   5100
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   5550
   LinkTopic       =   "Form1"
   ScaleHeight     =   5100
   ScaleWidth      =   5550
   StartUpPosition =   3  'Windows Default
   Begin VB.ComboBox cmbConvertFrom 
      Height          =   315
      ItemData        =   "DistanceConvert.frx":0000
      Left            =   3840
      List            =   "DistanceConvert.frx":0002
      TabIndex        =   6
      Text            =   "Miles"
      Top             =   600
      Width           =   1215
   End
   Begin VB.TextBox txtInterval 
      Height          =   285
      Left            =   1920
      TabIndex        =   5
      Top             =   600
      Width           =   1575
   End
   Begin VB.TextBox txtTotalDistance 
      Height          =   285
      Left            =   120
      TabIndex        =   2
      Top             =   600
      Width           =   1575
   End
   Begin VB.TextBox txtOutput 
      BeginProperty Font 
         Name            =   "Courier New"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   3855
      Left            =   120
      MultiLine       =   -1  'True
      TabIndex        =   1
      Top             =   1080
      Width           =   4335
   End
   Begin VB.CommandButton cmdCompute 
      Caption         =   "Compute"
      Height          =   375
      Left            =   4560
      TabIndex        =   0
      Top             =   4560
      Width           =   975
   End
   Begin VB.Label Label3 
      Caption         =   "Units"
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
      Left            =   3840
      TabIndex        =   7
      Top             =   240
      Width           =   1215
   End
   Begin VB.Label Label2 
      Caption         =   "Interval"
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
      TabIndex        =   4
      Top             =   240
      Width           =   1455
   End
   Begin VB.Label Label1 
      Caption         =   "Total Distance"
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
      Left            =   120
      TabIndex        =   3
      Top             =   240
      Width           =   1575
   End
End
Attribute VB_Name = "frmConverter"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdCompute_Click()
'Variable Declarations
Dim dblCurrentDistance As Double
Dim dblTotalDistance As Double
Dim dblInterval As Double
Dim intIntervalNumber As Integer
Dim dblConvertValue As Double

'Constant Declarations
Const dblConvertFromKilometers As Double = 0.6215
Const dblConvertFromMiles As Double = 1.609

'Initialize Variables
dblCurrentDistance = Val(txtInterval.Text)
dblInterval = Val(txtInterval.Text)
dblTotalDistance = Val(txtTotalDistance.Text)
intIntervalNumber = 1


'Select Conversion Factor
If (cmbConvertFrom.Text = "Miles") Then
  dblConvertValue = dblConvertFromMiles
Else
  dblConvertValue = dblConvertFromKilometers
End If

'Display Header
txtOutput = "          Original   Converted" & vbNewLine & _
            "Interval  Distance   Distance" & vbNewLine & _
            "--------  --------   ---------" & vbNewLine

'Generate Chart
Do Until (dblCurrentDistance > dblTotalDistance)
  txtOutput.Text = txtOutput.Text & Format(intIntervalNumber, "@@@@0.00") & _
  " " & Format(dblCurrentDistance, "@@@@@@@@@") & " " & _
  Format(dblCurrentDistance * dblConvertValue, "@@@@@@@@@@@") & _
  vbNewLine
  intIntervalNumber = intIntervalNumber + 1
  dblCurrentDistance = dblCurrentDistance + dblInterval
Loop
End Sub
