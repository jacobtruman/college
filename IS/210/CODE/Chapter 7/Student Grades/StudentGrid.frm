VERSION 5.00
Object = "{5E9E78A0-531B-11CF-91F6-C2863C385E30}#1.0#0"; "MSFLXGRD.OCX"
Begin VB.Form frmStudentGrades 
   Caption         =   "Student Grades"
   ClientHeight    =   3915
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   9930
   LinkTopic       =   "Form1"
   ScaleHeight     =   3915
   ScaleWidth      =   9930
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdAddStudent 
      Caption         =   "Add Student"
      Height          =   375
      Left            =   6600
      TabIndex        =   7
      Top             =   120
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
   Begin MSFlexGridLib.MSFlexGrid grdStudents 
      Height          =   2415
      Left            =   360
      TabIndex        =   0
      Top             =   1320
      Width           =   7215
      _ExtentX        =   12726
      _ExtentY        =   4260
      _Version        =   393216
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
Attribute VB_Name = "frmStudentGrades"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdAddStudent_Click()
grdStudents.Rows = grdStudents.Rows + 1

grdStudents.Row = grdStudents.Rows - 1
grdStudents.Col = 0
grdStudents.Text = grdStudents.Row
grdStudents.Col = 1
grdStudents.Text = txtLast.Text
grdStudents.Col = 2
grdStudents.Text = txtFirst.Text
grdStudents.Col = 3
grdStudents.Text = txtGPA.Text
End Sub


Private Sub Form_Load()
grdStudents.Rows = 1
grdStudents.Cols = 4

grdStudents.Row = 0

grdStudents.Col = 0
grdStudents.Text = "Student #"

grdStudents.Col = 1
grdStudents.Text = "Last Name"

grdStudents.Col = 2
grdStudents.Text = "First Name"

grdStudents.Col = 3
grdStudents.Text = "GPA"

End Sub

