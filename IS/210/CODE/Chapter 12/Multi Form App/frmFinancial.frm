VERSION 5.00
Begin VB.Form frmFinancial 
   Caption         =   "Financial Information"
   ClientHeight    =   3915
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   ScaleHeight     =   3915
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdHide 
      Caption         =   "&Hide"
      Height          =   375
      Left            =   1733
      TabIndex        =   11
      Top             =   3480
      Width           =   1215
   End
   Begin VB.Frame fraPayables 
      Caption         =   "Payables"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1215
      Left            =   240
      TabIndex        =   2
      Top             =   2040
      Width           =   4215
      Begin VB.TextBox txtPayableRate 
         Height          =   285
         Left            =   1680
         TabIndex        =   10
         Top             =   600
         Width           =   1215
      End
      Begin VB.TextBox txtPayableHours 
         Height          =   285
         Left            =   240
         TabIndex        =   9
         Top             =   600
         Width           =   1215
      End
      Begin VB.Label Label4 
         Caption         =   "Rate"
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
         Left            =   1680
         TabIndex        =   8
         Top             =   360
         Width           =   1095
      End
      Begin VB.Label Label2 
         Caption         =   "Hours"
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
         Left            =   240
         TabIndex        =   7
         Top             =   360
         Width           =   1095
      End
   End
   Begin VB.Frame fraBillables 
      Caption         =   "Billables"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1215
      Left            =   240
      TabIndex        =   1
      Top             =   600
      Width           =   4215
      Begin VB.TextBox txtBillableRate 
         Height          =   285
         Left            =   1680
         TabIndex        =   6
         Top             =   600
         Width           =   1335
      End
      Begin VB.TextBox txtBillableHours 
         Height          =   285
         Left            =   240
         TabIndex        =   4
         Top             =   600
         Width           =   1215
      End
      Begin VB.Label Label3 
         Caption         =   "Rate"
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
         Left            =   1680
         TabIndex        =   5
         Top             =   360
         Width           =   495
      End
      Begin VB.Label Label1 
         Caption         =   "Hours"
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
         Left            =   240
         TabIndex        =   3
         Top             =   360
         Width           =   615
      End
   End
   Begin VB.Label lblTitle 
      Alignment       =   2  'Center
      Caption         =   "Financials for "
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
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   4935
   End
End
Attribute VB_Name = "frmFinancial"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
