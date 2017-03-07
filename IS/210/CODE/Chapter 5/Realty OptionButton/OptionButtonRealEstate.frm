VERSION 5.00
Begin VB.Form frmOptionButtonRealty 
   Caption         =   "Option Button Realty Example"
   ClientHeight    =   2985
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7755
   LinkTopic       =   "Form1"
   ScaleHeight     =   2985
   ScaleWidth      =   7755
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame Frame2 
      Caption         =   "House Price"
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
      Left            =   3840
      TabIndex        =   8
      Top             =   720
      Width           =   3735
      Begin VB.OptionButton Option4 
         Caption         =   ">= $200,000"
         Height          =   255
         Left            =   120
         TabIndex        =   11
         Top             =   720
         Width           =   3015
      End
      Begin VB.OptionButton Option3 
         Caption         =   ">= $100,000 and < $200,000"
         Height          =   255
         Left            =   120
         TabIndex        =   10
         Top             =   480
         Width           =   3135
      End
      Begin VB.OptionButton Option2 
         Caption         =   "< $100,000"
         Height          =   255
         Left            =   120
         TabIndex        =   9
         Top             =   240
         Width           =   3375
      End
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Continue"
      Height          =   495
      Left            =   2970
      TabIndex        =   2
      Top             =   2400
      Width           =   1815
   End
   Begin VB.Frame Frame1 
      Caption         =   "Personal Income"
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
      Left            =   120
      TabIndex        =   3
      Top             =   720
      Width           =   3135
      Begin VB.OptionButton Option1 
         Caption         =   ">= $100,000"
         Height          =   255
         Left            =   120
         TabIndex        =   7
         Top             =   960
         Width           =   2415
      End
      Begin VB.OptionButton Option10 
         Caption         =   ">= $50,000 and < $100,000"
         Height          =   255
         Left            =   120
         TabIndex        =   6
         Top             =   720
         Width           =   3015
      End
      Begin VB.OptionButton Option9 
         Caption         =   ">= $30,000 and < $50,000"
         Height          =   255
         Left            =   120
         TabIndex        =   5
         Top             =   480
         Width           =   2535
      End
      Begin VB.OptionButton Option8 
         Caption         =   "< $30,000"
         Height          =   255
         Left            =   120
         TabIndex        =   4
         Top             =   240
         Width           =   2415
      End
   End
   Begin VB.Label Label2 
      Caption         =   "Personal Income"
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
      Left            =   240
      TabIndex        =   1
      Top             =   960
      Width           =   2415
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      Caption         =   "The Coach Realty"
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
      Left            =   1560
      TabIndex        =   0
      Top             =   120
      Width           =   4815
   End
End
Attribute VB_Name = "frmOptionButtonRealty"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
