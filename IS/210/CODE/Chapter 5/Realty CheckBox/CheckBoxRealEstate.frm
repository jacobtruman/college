VERSION 5.00
Begin VB.Form frmCheckBox 
   Caption         =   "CheckBox Example"
   ClientHeight    =   3585
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7110
   LinkTopic       =   "Form1"
   ScaleHeight     =   3585
   ScaleWidth      =   7110
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command1 
      Caption         =   "Continue"
      Height          =   495
      Left            =   2520
      TabIndex        =   8
      Top             =   2880
      Width           =   1815
   End
   Begin VB.CheckBox Check6 
      Caption         =   "Burglar Alarm"
      Height          =   255
      Left            =   4800
      TabIndex        =   7
      Top             =   2160
      Width           =   1455
   End
   Begin VB.CheckBox Check5 
      Caption         =   "Fire Alarm"
      Height          =   255
      Left            =   4800
      TabIndex        =   6
      Top             =   1680
      Width           =   1935
   End
   Begin VB.CheckBox Check4 
      Caption         =   "Finsihed Basement"
      Height          =   255
      Left            =   2520
      TabIndex        =   5
      Top             =   2160
      Width           =   1695
   End
   Begin VB.CheckBox Check3 
      Caption         =   "Fenced Yard"
      Height          =   255
      Left            =   2520
      TabIndex        =   4
      Top             =   1680
      Width           =   1815
   End
   Begin VB.CheckBox Check2 
      Caption         =   "Pool"
      Height          =   255
      Left            =   480
      TabIndex        =   3
      Top             =   1680
      Width           =   1095
   End
   Begin VB.CheckBox Check1 
      Caption         =   "Water Front"
      Height          =   255
      Left            =   480
      TabIndex        =   1
      Top             =   2160
      Width           =   1215
   End
   Begin VB.Label Label2 
      Caption         =   "House Ammenities"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   360
      TabIndex        =   2
      Top             =   840
      Width           =   5895
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
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   6975
   End
End
Attribute VB_Name = "frmCheckBox"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
