VERSION 5.00
Begin VB.Form frmchkcalc 
   Caption         =   "Check Calculator"
   ClientHeight    =   4470
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   6360
   LinkTopic       =   "Form1"
   ScaleHeight     =   4470
   ScaleWidth      =   6360
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdReset 
      Caption         =   "Reset"
      Height          =   375
      Left            =   480
      TabIndex        =   12
      Top             =   2400
      Width           =   975
   End
   Begin VB.TextBox txtNum2 
      Height          =   285
      Left            =   360
      TabIndex        =   7
      Text            =   "0"
      Top             =   960
      Width           =   1335
   End
   Begin VB.CommandButton cmdExecute 
      Caption         =   "Execute"
      Height          =   375
      Left            =   480
      TabIndex        =   6
      Top             =   1800
      Width           =   975
   End
   Begin VB.TextBox txtNum1 
      Height          =   285
      Left            =   360
      TabIndex        =   4
      Text            =   "0"
      Top             =   480
      Width           =   1335
   End
   Begin VB.CheckBox chkMult 
      Caption         =   "Multiply"
      Height          =   255
      Left            =   3600
      TabIndex        =   3
      Top             =   1200
      Width           =   855
   End
   Begin VB.CheckBox chkDiv 
      Caption         =   "Divide"
      Height          =   255
      Left            =   3600
      TabIndex        =   2
      Top             =   1560
      Width           =   855
   End
   Begin VB.CheckBox chkSub 
      Caption         =   "Subtract"
      Height          =   255
      Left            =   3600
      TabIndex        =   1
      Top             =   840
      Width           =   975
   End
   Begin VB.CheckBox chkAdd 
      Caption         =   "Add"
      Height          =   255
      Left            =   3600
      TabIndex        =   0
      Top             =   480
      Width           =   615
   End
   Begin VB.Label lblOps 
      Caption         =   "What operations would you like to execute?"
      Height          =   255
      Left            =   3000
      TabIndex        =   14
      Top             =   120
      Width           =   3135
   End
   Begin VB.Label lblNums 
      Caption         =   "Numbers"
      Height          =   255
      Left            =   360
      TabIndex        =   13
      Top             =   120
      Width           =   735
   End
   Begin VB.Label lblAnsMssg 
      Height          =   495
      Left            =   2040
      TabIndex        =   11
      Top             =   2160
      Width           =   4215
   End
   Begin VB.Label lblDivAns 
      Height          =   255
      Left            =   2040
      TabIndex        =   10
      Top             =   3840
      Width           =   4215
   End
   Begin VB.Label lblMultAns 
      Height          =   255
      Left            =   2040
      TabIndex        =   9
      Top             =   3480
      Width           =   4215
   End
   Begin VB.Label lblSubAns 
      Height          =   255
      Left            =   2040
      TabIndex        =   8
      Top             =   3120
      Width           =   4215
   End
   Begin VB.Label lblAddAns 
      Height          =   255
      Left            =   2040
      TabIndex        =   5
      Top             =   2760
      Width           =   4215
   End
End
Attribute VB_Name = "frmchkcalc"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdExecute_Click()
Dim cel As Double
If IsNumeric(txtNum1.Text) And IsNumeric(txtNum2.Text) Then
num1 = CDbl(txtNum1.Text)
num2 = CDbl(txtNum2.Text)
Mssg = "The Answers for " & num1 & " and " & num2 & " are:"
Else
MsgBox ("5tup1d Error: Please enter a Number")
txtNum1.Text = 0
txtNum2.Text = 0
txtNum1.SetFocus
Exit Sub
End If
If (chkAdd = Checked) Then
lblAddAns = "ADDITION: " & num1 + num2
Else
lblAddAns = "ADDITION: Not Checked"
End If
If (chkSub = Checked) Then
lblSubAns = "SUBTRACTION: " & num1 - num2
Else
lblSubAns = "SUBTRACTION: Not Checked"
End If
If (chkMult = Checked) Then
lblMultAns = "MULTIPLICATION: " & num1 * num2
Else
lblMultAns = "MULTIPLICATION: Not Checked"
End If
If (chkDiv = Checked) And (num2 = 0) Then
lblDivAns = "DIVISION: Undefined"
ElseIf (chkDiv = Unchecked) Then
lblDivAns = "DIVISION: Not Checked"
Else
lblDivAns = "DIVISION: " & num1 / num2
End If
lblAnsMssg = Mssg
End Sub

Private Sub cmdReset_Click()
txtNum1.Text = 0
txtNum2.Text = 0
chkAdd = Unchecked
chkSub = Unchecked
chkMult = Unchecked
chkDiv = Unchecked
lblAddAns = ""
lblSubAns = ""
lblMultAns = ""
lblDivAns = ""
lblAnsMssg = ""
Exit Sub
End Sub

Private Sub txtNum1_Change()
Dim cel As Double
If IsNumeric(txtNum1.Text) Then
num1 = CDbl(txtNum1.Text)
Else
MsgBox ("5tup1d Error: Please enter a Number")
txtNum1.Text = 0
txtNum1.SetFocus
Exit Sub
End If
End Sub

Private Sub txtNum2_Change()
Dim cel As Double
If IsNumeric(txtNum2.Text) Then
num2 = CDbl(txtNum2.Text)
Else
MsgBox ("5tup1d Error: Please enter a Number")
txtNum2.Text = 0
txtNum2.SetFocus
Exit Sub
End If
End Sub


