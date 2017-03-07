VERSION 5.00
Begin VB.Form frmRandomAccessStudent 
   Caption         =   "Random Access Student"
   ClientHeight    =   2445
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   5850
   LinkTopic       =   "Form1"
   ScaleHeight     =   2445
   ScaleWidth      =   5850
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox txtYear 
      Height          =   285
      Left            =   2040
      TabIndex        =   10
      Top             =   1080
      Width           =   1695
   End
   Begin VB.TextBox txtMajor 
      Height          =   285
      Left            =   120
      TabIndex        =   7
      Top             =   1080
      Width           =   1575
   End
   Begin VB.CommandButton cmdAddStudent 
      Caption         =   "&Add Student"
      Height          =   375
      Left            =   120
      TabIndex        =   6
      Top             =   1800
      Width           =   2055
   End
   Begin VB.TextBox txtGPA 
      Height          =   285
      Left            =   3960
      TabIndex        =   5
      Top             =   480
      Width           =   1575
   End
   Begin VB.TextBox txtLast 
      Height          =   285
      Left            =   2040
      TabIndex        =   3
      Top             =   480
      Width           =   1695
   End
   Begin VB.TextBox txtFirst 
      Height          =   285
      Left            =   120
      TabIndex        =   0
      Top             =   480
      Width           =   1575
   End
   Begin VB.Label Label5 
      Caption         =   "Year"
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
      Left            =   2040
      TabIndex        =   9
      Top             =   840
      Width           =   1455
   End
   Begin VB.Label Label4 
      Caption         =   "Major"
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
      Top             =   840
      Width           =   1335
   End
   Begin VB.Label Label3 
      Caption         =   "GPA"
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
      Left            =   3960
      TabIndex        =   4
      Top             =   240
      Width           =   1095
   End
   Begin VB.Label Label2 
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
      Left            =   2040
      TabIndex        =   2
      Top             =   240
      Width           =   1215
   End
   Begin VB.Label Label1 
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
      Left            =   120
      TabIndex        =   1
      Top             =   240
      Width           =   1575
   End
End
Attribute VB_Name = "frmRandomAccessStudent"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim CurrentRecordNumber As Integer

Private Type StudentRecord
  LastName As String * 10
  FirstName As String * 10
  Major As String * 25
  Year As String * 10
  GPA As Single
End Type
Private Sub cmdAddStudent_Click()
Dim IndividualStudent As StudentRecord

IndividualStudent.LastName = txtLast
IndividualStudent.FirstName = txtFirst
IndividualStudent.Major = txtMajor
IndividualStudent.Year = txtYear
IndividualStudent.GPA = txtGPA

CurrentRecordNumber = CurrentRecordNumber + 1

Put #1, CurrentRecordNumber, IndividualStudent

txtLast = ""
txtFirst = ""
txtMajor = ""
txtYear = ""
txtGPA = ""
End Sub

Private Sub Form_Load()
Dim IndividualStudent As StudentRecord

CurrentStudentNumber = 0

Open "C:\VB Coach\Chapter 8\StudentsRandom.txt" For Random As #1 Len = Len(IndividualStudent)

End Sub

Private Sub Form_Unload(Cancel As Integer)
Close #1
End Sub
