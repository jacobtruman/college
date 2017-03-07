VERSION 5.00
Object = "{5E9E78A0-531B-11CF-91F6-C2863C385E30}#1.0#0"; "MSFLXGRD.OCX"
Begin VB.Form frmStudenGrades 
   Caption         =   "Student Grades with Search"
   ClientHeight    =   4425
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   9930
   LinkTopic       =   "Form1"
   ScaleHeight     =   4425
   ScaleWidth      =   9930
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdSave 
      Caption         =   "&Save"
      Height          =   375
      Left            =   6600
      TabIndex        =   14
      Top             =   960
      Width           =   2055
   End
   Begin VB.TextBox txtSearch 
      Height          =   375
      Left            =   7680
      TabIndex        =   13
      Top             =   2400
      Width           =   2055
   End
   Begin VB.CommandButton cmdSearch 
      Caption         =   "&Search"
      Height          =   375
      Left            =   7680
      TabIndex        =   12
      Top             =   1800
      Width           =   2055
   End
   Begin VB.TextBox txtYear 
      Height          =   285
      Left            =   2280
      TabIndex        =   11
      Top             =   1440
      Width           =   1695
   End
   Begin VB.TextBox txtMajor 
      Height          =   285
      Left            =   360
      TabIndex        =   8
      Top             =   1440
      Width           =   1575
   End
   Begin VB.CommandButton Command1 
      Caption         =   "&Add Student"
      Height          =   375
      Left            =   6600
      TabIndex        =   7
      Top             =   480
      Width           =   2055
   End
   Begin VB.TextBox txtGPA 
      Height          =   285
      Left            =   4200
      TabIndex        =   6
      Top             =   840
      Width           =   1575
   End
   Begin VB.TextBox txtLast 
      Height          =   285
      Left            =   2280
      TabIndex        =   4
      Top             =   840
      Width           =   1695
   End
   Begin VB.TextBox txtFirst 
      Height          =   285
      Left            =   360
      TabIndex        =   1
      Top             =   840
      Width           =   1575
   End
   Begin MSFlexGridLib.MSFlexGrid flxStudents 
      Height          =   2415
      Left            =   360
      TabIndex        =   0
      Top             =   1800
      Width           =   7215
      _ExtentX        =   12726
      _ExtentY        =   4260
      _Version        =   393216
      Cols            =   6
      AllowUserResizing=   1
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
      Left            =   2280
      TabIndex        =   10
      Top             =   1200
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
      Left            =   360
      TabIndex        =   9
      Top             =   1200
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
      Left            =   4200
      TabIndex        =   5
      Top             =   600
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
      Left            =   2280
      TabIndex        =   3
      Top             =   600
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
      Left            =   360
      TabIndex        =   2
      Top             =   600
      Width           =   1575
   End
End
Attribute VB_Name = "frmStudenGrades"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdSave_Click()
Dim CurrentRow As Integer

Dim StudentNumber As Integer
Dim LastName As String
Dim FirstName As String
Dim Major As String
Dim Year As String
Dim GPA As Single

Open "C:\VB Coach\Chapter 8\StudentsComma.txt" For Output As #1

CurrentRow = 1

Do While (CurrentRow < flxStudents.Rows)
  'Student #
  flxStudents.Row = CurrentRow
  flxStudents.Col = 0
  StudentNumber = Trim(flxStudents.Text)
  
  'Last Name
  flxStudents.Col = 1
  LastName = Trim(flxStudents.Text)
  
  'First Name
  flxStudents.Col = 2
  FirstName = Trim(flxStudents.Text)
  
  'Major
  flxStudents.Col = 3
  Major = Trim(flxStudents.Text)
  
  'Year
  flxStudents.Col = 4
  Year = Trim(flxStudents.Text)
  
  'GPA
  flxStudents.Col = 5
  GPA = Trim(flxStudents.Text)
  
  Write #1, StudentNumber, LastName, FirstName, Major, Year, GPA
  CurrentRow = CurrentRow + 1
Loop

Close #1

End Sub

Function PadRight(Value As String, Size As Integer) As String

Value = Trim(Value)
PadRight = Value + Space(Size - Len(Value))
End Function


Private Sub cmdSearch_Click()
If (SearchGrid(flxStudents, txtSearch.Text)) Then
  MsgBox ("The searched value was found")
Else
  MsgBox ("The searched value was not found")
End If
End Sub
Function SearchGrid(grdGrid As MSFlexGrid, strSearchString As String) As Boolean
Dim intRow As Integer
Dim intColumn As Integer

SearchGrid = False

For intRow = 0 To grdGrid.Rows - 1
  grdGrid.Row = intRow
  For intColumn = 0 To grdGrid.Cols - 1
     grdGrid.Col = intColumn
     If (grdGrid.Text = strSearchString) Then
        SearchGrid = True
     End If
  Next intColumn
Next intRow

End Function



Private Sub Command1_Click()
flxStudents.Rows = flxStudents.Rows + 1

flxStudents.Row = flxStudents.Rows - 1
flxStudents.Col = 0
flxStudents.Text = flxStudents.Row
flxStudents.Col = 1
flxStudents.Text = txtLast
flxStudents.Col = 2
flxStudents.Text = txtFirst
flxStudents.Col = 3
flxStudents.Text = txtMajor
flxStudents.Col = 4
flxStudents.Text = txtYear
flxStudents.Col = 5
flxStudents.Text = txtGPA
End Sub


Private Sub Form_Load()
flxStudents.Rows = 1
flxStudents.Cols = 6

flxStudents.FormatString = "<Student# |<Last Name   |<First Name|<Major                         |<Year      |<GPA   |"

flxStudents.Row = 0

flxStudents.Col = 0
flxStudents.Text = "Student #"

flxStudents.Col = 1
flxStudents.Text = "Last Name"

flxStudents.Col = 2
flxStudents.Text = "First Name"

flxStudents.Col = 3
flxStudents.Text = "Major"

flxStudents.Col = 4
flxStudents.Text = "Year"

flxStudents.Col = 5
flxStudents.Text = "GPA"


Dim InputLine As String
Open "C:\VB Coach\Chapter 8\StudentsFixed.txt" For Input As #1

Do While Not (EOF(1))
  Line Input #1, InputLine
  flxStudents.Rows = flxStudents.Rows + 1
  flxStudents.Row = flxStudents.Rows - 1
  
  'Student #
  flxStudents.Col = 0
  flxStudents.Text = Trim(Mid(InputLine, 1, 5))
  
  'Last Name
  flxStudents.Col = 1
  flxStudents.Text = Trim(Mid(InputLine, 6, 10))
  
  'First Name
  flxStudents.Col = 2
  flxStudents.Text = Trim(Mid(InputLine, 16, 10))
  
  'Major
  flxStudents.Col = 3
  flxStudents.Text = Trim(Mid(InputLine, 25, 25))
  
  'Year
  flxStudents.Col = 4
  flxStudents.Text = Trim(Mid(InputLine, 51, 10))
  
  'GPA
  flxStudents.Col = 5
  flxStudents.Text = Trim(Mid(InputLine, 61, 5))
    
Loop

Close #1

End Sub
