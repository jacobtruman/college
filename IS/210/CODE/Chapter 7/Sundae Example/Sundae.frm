VERSION 5.00
Begin VB.Form frmSundae 
   Caption         =   "Sundae Example"
   ClientHeight    =   4515
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   5805
   LinkTopic       =   "Form1"
   ScaleHeight     =   4515
   ScaleWidth      =   5805
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdOrderSundae 
      Caption         =   "Order Sundae"
      Height          =   495
      Left            =   240
      TabIndex        =   7
      Top             =   3840
      Width           =   1935
   End
   Begin VB.ListBox lstFlavors 
      Height          =   2400
      ItemData        =   "Sundae.frx":0000
      Left            =   2520
      List            =   "Sundae.frx":0019
      MultiSelect     =   1  'Simple
      TabIndex        =   4
      Top             =   1440
      Width           =   2415
   End
   Begin VB.OptionButton optButterscotch 
      Caption         =   "Butterscotch"
      Height          =   375
      Left            =   480
      TabIndex        =   3
      Top             =   2520
      Width           =   1335
   End
   Begin VB.OptionButton optChocolate 
      Caption         =   "Chocolate"
      Height          =   375
      Left            =   480
      TabIndex        =   2
      Top             =   2160
      Width           =   1215
   End
   Begin VB.OptionButton optHotFudge 
      Caption         =   "Hot Fudge"
      Height          =   375
      Left            =   480
      TabIndex        =   1
      Top             =   1800
      Width           =   1215
   End
   Begin VB.Frame Frame1 
      Caption         =   "Toppings"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1695
      Left            =   240
      TabIndex        =   6
      Top             =   1440
      Width           =   1935
   End
   Begin VB.Label Label3 
      Caption         =   "Flavors"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   2520
      TabIndex        =   5
      Top             =   1080
      Width           =   2415
   End
   Begin VB.Label Label1 
      Caption         =   "Ice Cream Sundae"
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
      Left            =   1215
      TabIndex        =   0
      Top             =   240
      Width           =   3375
   End
End
Attribute VB_Name = "frmSundae"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdOrderSundae_Click()
'Declare Variables
Dim intCounter As Integer
Dim strOutputString As String
Dim intSelectedCount As Integer

'Initialize Variables
intSelectedCount = 0
strOutputString = "A "

'Select Type of Sundae
If (optHotFudge.Value = True) Then
  strOutputString = strOutputString + "Hot Fudge "
End If

If (optChocolate.Value = True) Then
  strOutputString = strOutputString + "Chocolate "
End If

If (optButterscotch.Value = True) Then
  strOutputString = strOutputString + "Butterscotch "
End If

strOutputString = strOutputString + "Sundae with "

'Select Ice Cream Flavors
For intCounter = 0 To lstFlavors.ListCount - 1
  If (lstFlavors.Selected(intCounter) = True) Then
     intSelectedCount = intSelectedCount + 1
     
     If (intSelectedCount = 3) Then
       strOutputString = strOutputString + "and "
     End If
     
     strOutputString = strOutputString + lstFlavors.List(intCounter)
 
     If (intSelectedCount < 3) Then
        strOutputString = strOutputString + ", "
     End If
  End If
Next intCounter

strOutputString = strOutputString + " Ice Cream"

MsgBox strOutputString
End Sub

