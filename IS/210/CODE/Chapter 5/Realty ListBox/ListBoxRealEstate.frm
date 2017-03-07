VERSION 5.00
Begin VB.Form frmRealtyListBox 
   Caption         =   "ListBox Realty Example"
   ClientHeight    =   3075
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7170
   LinkTopic       =   "Form1"
   ScaleHeight     =   3075
   ScaleWidth      =   7170
   StartUpPosition =   3  'Windows Default
   Begin VB.ListBox lstHousePrice 
      Height          =   840
      ItemData        =   "ListBoxRealEstate.frx":0000
      Left            =   3840
      List            =   "ListBoxRealEstate.frx":000D
      TabIndex        =   5
      Top             =   1320
      Width           =   2655
   End
   Begin VB.ListBox lstPersonalIncome 
      Height          =   840
      ItemData        =   "ListBoxRealEstate.frx":0046
      Left            =   240
      List            =   "ListBoxRealEstate.frx":0056
      TabIndex        =   4
      Top             =   1320
      Width           =   2535
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Continue"
      Height          =   495
      Left            =   2760
      TabIndex        =   2
      Top             =   2400
      Width           =   1815
   End
   Begin VB.Label Label3 
      Caption         =   "House Price"
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
      Left            =   3840
      TabIndex        =   3
      Top             =   960
      Width           =   2295
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
Attribute VB_Name = "frmRealtyListBox"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
