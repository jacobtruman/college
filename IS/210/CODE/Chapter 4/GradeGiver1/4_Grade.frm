VERSION 5.00
Begin VB.Form frmGrader 
   Caption         =   "Grade Giver"
   ClientHeight    =   3195
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   ScaleHeight     =   3195
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton CmdCompute 
      Caption         =   "Compute Grade"
      Height          =   375
      Left            =   360
      TabIndex        =   5
      Top             =   2400
      Width           =   1455
   End
   Begin VB.TextBox txtGrade 
      Height          =   375
      Left            =   360
      TabIndex        =   2
      Top             =   1320
      Width           =   1455
   End
   Begin VB.Label Label3 
      Alignment       =   2  'Center
      Caption         =   "Letter Grade"
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
      Left            =   3120
      TabIndex        =   4
      Top             =   1080
      Width           =   1335
   End
   Begin VB.Label Label2 
      Caption         =   "Numeric Grade"
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
      Left            =   360
      TabIndex        =   3
      Top             =   1080
      Width           =   1335
   End
   Begin VB.Label lblGrade 
      Alignment       =   2  'Center
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   48
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1215
      Left            =   3240
      TabIndex        =   1
      Top             =   1440
      Width           =   1215
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      Caption         =   "The Coach Grade Giver"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   4335
   End
End
Attribute VB_Name = "frmGrader"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub CmdCompute_Click()
Dim intGrade As Integer ' Declare temporary variable

intGrade = Val(txtGrade.Text) 'Convert user input to an Integer

'Compute Grade
If (intGrade >= 90) Then
   lblGrade.Caption = "A"
ElseIf (intGrade >= 80) Then
   lblGrade.Caption = "B"
ElseIf (intGrade >= 70) Then
   lblGrade.Caption = "C"
ElseIf (intGrade >= 60) Then
   lblGrade.Caption = "D"
Else
   lblGrade.Caption = "F"
End If

End Sub
