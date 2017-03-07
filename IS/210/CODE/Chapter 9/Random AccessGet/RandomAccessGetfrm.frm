VERSION 5.00
Begin VB.Form frmRandomAccessStudent 
   Caption         =   "Random Access Student"
   ClientHeight    =   2445
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   6255
   LinkTopic       =   "Form1"
   ScaleHeight     =   2445
   ScaleWidth      =   6255
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdUpdate 
      Caption         =   "Update Student"
      Height          =   375
      Left            =   2040
      TabIndex        =   14
      Top             =   1800
      Width           =   1575
   End
   Begin VB.CommandButton cmdAddStudent 
      Caption         =   "&Add Student"
      Height          =   375
      Left            =   120
      TabIndex        =   13
      Top             =   1800
      Width           =   1695
   End
   Begin VB.CommandButton cmdSearch 
      Caption         =   "&Search"
      Height          =   375
      Left            =   4080
      TabIndex        =   11
      Top             =   1680
      Width           =   1815
   End
   Begin VB.TextBox txtSearch 
      Height          =   285
      Left            =   4080
      TabIndex        =   10
      Top             =   1320
      Width           =   1695
   End
   Begin VB.TextBox txtYear 
      Height          =   285
      Left            =   2040
      TabIndex        =   9
      Top             =   1080
      Width           =   1695
   End
   Begin VB.TextBox txtMajor 
      Height          =   285
      Left            =   120
      TabIndex        =   6
      Top             =   1080
      Width           =   1575
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
   Begin VB.Frame Frame1 
      Caption         =   "Student Number"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1335
      Left            =   3960
      TabIndex        =   12
      Top             =   960
      Width           =   2055
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
      TabIndex        =   8
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
      TabIndex        =   7
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
Dim TotalRecords As Integer
Dim RecordNumber As Integer

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

TotalRecords = TotalRecords + 1

Put #RecordNumber, TotalRecords, IndividualStudent

txtLast = ""
txtFirst = ""
txtMajor = ""
txtYear = ""
txtGPA = ""
End Sub
Private Sub cmdSearch_Click()
Dim IndividualStudent As StudentRecord

Get #RecordNumber, txtSearch, IndividualStudent

txtLast = IndividualStudent.LastName
txtFirst = IndividualStudent.FirstName
txtMajor = IndividualStudent.Major
txtYear = IndividualStudent.Year
txtGPA = IndividualStudent.GPA
End Sub

Private Sub cmdUpdate_Click()
Dim IndividualStudent As StudentRecord

IndividualStudent.LastName = txtLast
IndividualStudent.FirstName = txtFirst
IndividualStudent.Major = txtMajor
IndividualStudent.Year = txtYear
IndividualStudent.GPA = txtGPA

Put #RecordNumber, txtStudent, IndividualStudent

txtLast = ""
txtFirst = ""
txtMajor = ""
txtYear = ""
txtGPA = ""

End Sub

Private Sub Form_Load()
Dim IndividualStudent As StudentRecord

RecordNumber = FreeFile

Open "C:\VB Coach\Chapter 8\StudentsRandom.txt" For Random As #RecordNumber Len = Len(IndividualStudent)

TotalRecords = LOF(1) / Len(IndividualStudent)
End Sub

Private Sub Form_Unload(Cancel As Integer)
Close #RecordNumber
End Sub
