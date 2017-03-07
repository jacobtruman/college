VERSION 5.00
Begin VB.Form frmPersonnel 
   Caption         =   "Personnel Information"
   ClientHeight    =   5190
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   3780
   LinkTopic       =   "Form1"
   ScaleHeight     =   5190
   ScaleWidth      =   3780
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdProfit 
      Caption         =   "&Profit"
      Height          =   375
      Left            =   1200
      TabIndex        =   8
      Top             =   4800
      Width           =   1455
   End
   Begin VB.CommandButton cmdFinancial 
      Caption         =   "&Financial"
      Height          =   375
      Left            =   2003
      TabIndex        =   7
      Top             =   4320
      Width           =   1455
   End
   Begin VB.CommandButton cmdDemographics 
      Caption         =   "&Demographics"
      Height          =   375
      Left            =   323
      TabIndex        =   6
      Top             =   4320
      Width           =   1455
   End
   Begin VB.TextBox txtLastName 
      Height          =   285
      Left            =   1883
      TabIndex        =   5
      Top             =   1320
      Width           =   1695
   End
   Begin VB.TextBox txtFirstName 
      Height          =   285
      Left            =   203
      TabIndex        =   4
      Top             =   1320
      Width           =   1455
   End
   Begin VB.PictureBox Picture1 
      Height          =   2295
      Left            =   743
      Picture         =   "frmPersonnel.frx":0000
      ScaleHeight     =   2235
      ScaleWidth      =   2235
      TabIndex        =   1
      Top             =   1800
      Width           =   2295
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
      Left            =   1883
      TabIndex        =   3
      Top             =   1080
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
      Left            =   203
      TabIndex        =   2
      Top             =   1080
      Width           =   1215
   End
   Begin VB.Label lblTitle 
      Caption         =   "Personnel Information"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   323
      TabIndex        =   0
      Top             =   240
      Width           =   3135
   End
End
Attribute VB_Name = "frmPersonnel"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdDemographics_Click()
frmDemographics.Show
End Sub

Private Sub cmdFinancial_Click()
frmFinancial.lblTitle.Caption = "Financials for " + Trim(txtFirstName.Text) & " " & Trim(txtLastName.Text)
frmFinancial.Show
End Sub

Private Sub cmdProfit_Click()
MsgBox Trim(txtFirstName.Text) & " " & Trim(txtLastName.Text) & " Net Profit is " & _
Str(Val(frmFinancial.txtBillableHours.Text) * Val(frmFinancial.txtBillableRate.Text) - Val(frmFinancial.txtPayableHours.Text) * Val(frmFinancial.txtPayableRate.Text)) & _
" he can be reached at " & frmDemographics.txtHomePhone, vbOKOnly, "Profit"
End Sub
