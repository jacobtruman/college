VERSION 5.00
Begin VB.Form frmInStock 
   Caption         =   "In Stock"
   ClientHeight    =   3195
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   ScaleHeight     =   3195
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdCalculate 
      Caption         =   "Calculate"
      Height          =   375
      Left            =   1560
      TabIndex        =   2
      Top             =   1800
      Width           =   1695
   End
   Begin VB.TextBox txtStockAmount 
      Height          =   375
      Left            =   2280
      TabIndex        =   0
      Top             =   1080
      Width           =   1455
   End
   Begin VB.Label lblInStock 
      Height          =   375
      Left            =   360
      TabIndex        =   3
      Top             =   240
      Width           =   2055
   End
   Begin VB.Label lblAmount 
      Caption         =   "Amount in Stock"
      Height          =   375
      Left            =   840
      TabIndex        =   1
      Top             =   1200
      Width           =   1215
   End
End
Attribute VB_Name = "frmInStock"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdCalculate_Click()
If (Val(txtStockAmount.Text) > 0) Then
  lblInStock.Caption = "Product is in Stock"
End If

If (Val(txtStockAmount.Text) <= 0) Then
  lblInStock.Caption = "Product is Sold Out"
End If
End Sub
