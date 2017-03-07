VERSION 5.00
Begin VB.Form frmDemographics 
   Caption         =   "Demographics"
   ClientHeight    =   5040
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   5040
   LinkTopic       =   "Form1"
   ScaleHeight     =   5040
   ScaleWidth      =   5040
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdHide 
      Caption         =   "&Hide"
      Height          =   375
      Left            =   1913
      TabIndex        =   20
      Top             =   4560
      Width           =   1215
   End
   Begin VB.Frame fraAddress 
      Caption         =   "Address"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1815
      Left            =   120
      TabIndex        =   3
      Top             =   960
      Width           =   4815
      Begin VB.TextBox txtZip 
         Height          =   285
         Left            =   3000
         TabIndex        =   11
         Top             =   1440
         Width           =   1455
      End
      Begin VB.TextBox txtState 
         Height          =   285
         Left            =   2040
         TabIndex        =   10
         Top             =   1440
         Width           =   735
      End
      Begin VB.TextBox txtCity 
         Height          =   285
         Left            =   120
         TabIndex        =   8
         Top             =   1440
         Width           =   1815
      End
      Begin VB.TextBox txtAddress2 
         Height          =   285
         Left            =   120
         TabIndex        =   6
         Top             =   840
         Width           =   4335
      End
      Begin VB.TextBox txtAddress1 
         Height          =   285
         Left            =   120
         TabIndex        =   5
         Top             =   480
         Width           =   4335
      End
      Begin VB.Label Label5 
         Caption         =   "Zip Code"
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
         Left            =   3000
         TabIndex        =   12
         Top             =   1200
         Width           =   1215
      End
      Begin VB.Label Label4 
         Caption         =   "State"
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
         Top             =   1200
         Width           =   495
      End
      Begin VB.Label Label3 
         Caption         =   "City"
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
         Top             =   1200
         Width           =   495
      End
      Begin VB.Label Label2 
         Caption         =   "Street"
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
         TabIndex        =   4
         Top             =   240
         Width           =   1575
      End
   End
   Begin VB.TextBox txtBusinessPhone 
      Height          =   285
      Left            =   2400
      TabIndex        =   2
      Top             =   3360
      Width           =   2175
   End
   Begin VB.TextBox txtHomePhone 
      Height          =   285
      Left            =   240
      TabIndex        =   1
      Top             =   3360
      Width           =   1935
   End
   Begin VB.Frame fraPhone 
      Caption         =   "Phone"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1575
      Left            =   120
      TabIndex        =   13
      Top             =   2880
      Width           =   4815
      Begin VB.TextBox txtFax 
         Height          =   285
         Left            =   2280
         TabIndex        =   18
         Top             =   1080
         Width           =   2175
      End
      Begin VB.TextBox txtCellular 
         Height          =   285
         Left            =   120
         TabIndex        =   16
         Top             =   1080
         Width           =   2055
      End
      Begin VB.Label Label8 
         Caption         =   "Fax"
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
         TabIndex        =   19
         Top             =   840
         Width           =   1815
      End
      Begin VB.Label Label10 
         Caption         =   "Cellular"
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
         TabIndex        =   17
         Top             =   840
         Width           =   975
      End
      Begin VB.Label Label7 
         Caption         =   "Business"
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
         TabIndex        =   15
         Top             =   240
         Width           =   975
      End
      Begin VB.Label Label6 
         Caption         =   "Home"
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
         TabIndex        =   14
         Top             =   240
         Width           =   855
      End
   End
   Begin VB.Label lblTitle 
      Alignment       =   2  'Center
      Caption         =   "Demographics for "
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
      Left            =   60
      TabIndex        =   0
      Top             =   240
      Width           =   4935
   End
End
Attribute VB_Name = "frmDemographics"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdHide_Click()
Me.Hide
End Sub

Private Sub Form_Activate()
lblTitle.Caption = "Demographics for " + Trim(frmPersonnel.txtFirstName.Text) & _
" " & Trim(frmPersonnel.txtLastName.Text)
End Sub
