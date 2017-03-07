VERSION 5.00
Begin VB.Form frmReports 
   BorderStyle     =   4  'Fixed ToolWindow
   Caption         =   "Report Generator"
   ClientHeight    =   4395
   ClientLeft      =   7215
   ClientTop       =   6420
   ClientWidth     =   5190
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   Picture         =   "frmReports.frx":0000
   ScaleHeight     =   4395
   ScaleWidth      =   5190
   ShowInTaskbar   =   0   'False
   Begin VB.CommandButton cmdExit 
      Caption         =   "Exit"
      Height          =   495
      Left            =   1785
      TabIndex        =   3
      Top             =   3480
      Width           =   1215
   End
   Begin VB.CommandButton cmdDoctor 
      Caption         =   "Doctor Search"
      Height          =   495
      Left            =   1785
      TabIndex        =   2
      Top             =   2760
      Width           =   1215
   End
   Begin VB.CommandButton cmdPatient 
      Caption         =   "Patient Search"
      Height          =   495
      Left            =   1785
      TabIndex        =   1
      Top             =   2040
      Width           =   1215
   End
   Begin VB.CommandButton cmdMedMailList 
      Caption         =   "Medication Mailing List"
      Height          =   495
      Left            =   1785
      TabIndex        =   0
      Top             =   1320
      Width           =   1215
   End
   Begin VB.Label lblTitle 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "C.M.C. Database Report Generator"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   975
      Left            =   600
      TabIndex        =   4
      Top             =   240
      Width           =   4215
   End
End
Attribute VB_Name = "frmReports"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
' Group 1
' 04/20/2006
' IS 475 Report Menu
' Scott Nordeen
' David Lewis
' Jacob Truman
' Wesley Segafredo

Private Sub cmdDoctor_Click()
    frmDoctor.Show
    frmReports.Hide
End Sub

Private Sub cmdExit_Click()
    End
End Sub

Private Sub cmdMedMailList_Click()
    frmMedApp.Show
    frmReports.Hide
End Sub

Private Sub cmdPatient_Click()
    frmPatient.Show
    frmReports.Hide
End Sub
