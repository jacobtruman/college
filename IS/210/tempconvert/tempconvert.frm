VERSION 5.00
Begin VB.Form formConvert 
   Caption         =   "Temp Converter"
   ClientHeight    =   2415
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   6495
   Icon            =   "tempconvert.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   2415
   ScaleWidth      =   6495
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdExit 
      Caption         =   "Close"
      Height          =   375
      Left            =   5400
      TabIndex        =   5
      Top             =   1920
      Width           =   975
   End
   Begin VB.CommandButton cmdReset 
      Caption         =   "Reset"
      Height          =   375
      Left            =   2280
      TabIndex        =   4
      Top             =   1920
      Width           =   975
   End
   Begin VB.CommandButton cmdCelcius 
      Caption         =   "Convert"
      Height          =   375
      Left            =   3480
      TabIndex        =   3
      Top             =   1320
      Width           =   975
   End
   Begin VB.CommandButton cmdFarenheit 
      Caption         =   "Convert"
      Height          =   375
      Left            =   240
      TabIndex        =   2
      Top             =   1320
      Width           =   975
   End
   Begin VB.TextBox txtCelcius 
      Height          =   285
      Left            =   3480
      TabIndex        =   1
      Text            =   "0"
      Top             =   600
      Width           =   615
   End
   Begin VB.TextBox txtFarenheit 
      Height          =   285
      Left            =   240
      TabIndex        =   0
      Text            =   "0"
      Top             =   600
      Width           =   615
   End
   Begin VB.Frame frFtitle 
      Caption         =   "Farenheit"
      Height          =   1575
      Left            =   120
      TabIndex        =   6
      Top             =   240
      Width           =   3135
      Begin VB.Label lblf1 
         Caption         =   "Degrees Farenheit is equal to: "
         Height          =   255
         Left            =   840
         TabIndex        =   12
         Top             =   360
         Width           =   2175
      End
      Begin VB.Label lblc2 
         Caption         =   "Degrees Celcius."
         Height          =   255
         Left            =   840
         TabIndex        =   10
         Top             =   720
         Width           =   1215
      End
      Begin VB.Label lblFout 
         Caption         =   "0"
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
         TabIndex        =   8
         Top             =   720
         Width           =   615
      End
   End
   Begin VB.Frame frmCtitle 
      Caption         =   "Celcius"
      Height          =   1575
      Left            =   3360
      TabIndex        =   7
      Top             =   240
      Width           =   3015
      Begin VB.Label lblc1 
         Caption         =   "Degrees Celcius is equal to:"
         Height          =   255
         Left            =   840
         TabIndex        =   13
         Top             =   360
         Width           =   2055
      End
      Begin VB.Label lblf2 
         Caption         =   "Degrees Farenheit."
         Height          =   255
         Left            =   840
         TabIndex        =   11
         Top             =   720
         Width           =   1695
      End
      Begin VB.Label lblCout 
         Caption         =   "0"
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
         TabIndex        =   9
         Top             =   720
         Width           =   615
      End
   End
End
Attribute VB_Name = "formConvert"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdCelcius_Click()
Dim cel As Double
If IsNumeric(txtCelcius.Text) Then
cel = CDbl(txtCelcius.Text)
Else
MsgBox ("5tup1d Error: Please enter a Number")
txtCelcius.Text = 0
txtCelcius.SetFocus
Exit Sub
End If
Farenheit = (cel * 1.8) + 32
lblCout.Caption = Round(Farenheit, 1)
End Sub

Private Sub cmdExit_Click()
AllowExit = True
Unload Me
End Sub

Private Sub cmdFarenheit_Click()
Dim fahr As Double
If IsNumeric(txtFarenheit.Text) Then
fahr = CDbl(txtFarenheit.Text)
Else
MsgBox ("id10t Error: Please enter a Number")
txtFarenheit.Text = 0
txtFarenheit.SetFocus
Exit Sub
End If
Celcius = 5 / 9 * (fahr - 32)
lblFout.Caption = Round(Celcius, 1)
End Sub

Private Sub cmdReset_Click()
txtFarenheit.Text = 0
txtCelcius.Text = 0
lblCout.Caption = 0
lblFout.Caption = 0
End Sub
