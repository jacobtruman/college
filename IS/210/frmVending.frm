VERSION 5.00
Begin VB.Form frmVending 
   Caption         =   "Vending Machine"
   ClientHeight    =   5535
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   6825
   LinkTopic       =   "Form1"
   ScaleHeight     =   5535
   ScaleWidth      =   6825
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame fmePrices 
      Caption         =   "Prices"
      Height          =   2055
      Left            =   5640
      TabIndex        =   40
      Top             =   1680
      Width           =   1095
      Begin VB.Label lblEs 
         Alignment       =   2  'Center
         BackColor       =   &H8000000D&
         Caption         =   "E's - $.60"
         Height          =   255
         Left            =   120
         TabIndex        =   45
         Top             =   1680
         Width           =   855
      End
      Begin VB.Label lblDs 
         Alignment       =   2  'Center
         BackColor       =   &H8000000D&
         Caption         =   "D's - $.65"
         Height          =   255
         Left            =   120
         TabIndex        =   44
         Top             =   1320
         Width           =   855
      End
      Begin VB.Label lblCs 
         Alignment       =   2  'Center
         BackColor       =   &H8000000D&
         Caption         =   "C's - $.55"
         Height          =   255
         Left            =   120
         TabIndex        =   43
         Top             =   960
         Width           =   855
      End
      Begin VB.Label lblBs 
         Alignment       =   2  'Center
         BackColor       =   &H8000000D&
         Caption         =   "B's - $.55"
         Height          =   255
         Left            =   120
         TabIndex        =   42
         Top             =   600
         Width           =   855
      End
      Begin VB.Label lblAs 
         Alignment       =   2  'Center
         BackColor       =   &H8000000D&
         Caption         =   "A's - $.55"
         Height          =   255
         Left            =   120
         TabIndex        =   41
         Top             =   240
         Width           =   855
      End
   End
   Begin VB.CommandButton cmdReset 
      Caption         =   "Reset"
      Height          =   375
      Left            =   4920
      TabIndex        =   39
      Top             =   5040
      Width           =   1215
   End
   Begin VB.CommandButton cmdProc 
      Caption         =   "Proccess"
      Height          =   375
      Left            =   3600
      TabIndex        =   38
      Top             =   5040
      Width           =   1215
   End
   Begin VB.Frame fmeSel 
      Caption         =   "Selections"
      Height          =   2055
      Left            =   720
      TabIndex        =   15
      Top             =   1680
      Width           =   4815
      Begin VB.Label lblE3a 
         Alignment       =   2  'Center
         BackColor       =   &H80000013&
         Height          =   255
         Left            =   4320
         TabIndex        =   68
         Top             =   1680
         Width           =   375
      End
      Begin VB.Label lblD3a 
         Alignment       =   2  'Center
         BackColor       =   &H80000013&
         Height          =   255
         Left            =   4320
         TabIndex        =   67
         Top             =   1320
         Width           =   375
      End
      Begin VB.Label lblC3a 
         Alignment       =   2  'Center
         BackColor       =   &H80000013&
         Height          =   255
         Left            =   4320
         TabIndex        =   66
         Top             =   960
         Width           =   375
      End
      Begin VB.Label lblB3a 
         Alignment       =   2  'Center
         BackColor       =   &H80000013&
         Height          =   255
         Left            =   4320
         TabIndex        =   65
         Top             =   600
         Width           =   375
      End
      Begin VB.Label lblA3a 
         Alignment       =   2  'Center
         BackColor       =   &H80000013&
         Height          =   255
         Left            =   4320
         TabIndex        =   64
         Top             =   240
         Width           =   375
      End
      Begin VB.Label lblE2a 
         Alignment       =   2  'Center
         BackColor       =   &H80000013&
         Height          =   255
         Left            =   2760
         TabIndex        =   63
         Top             =   1680
         Width           =   375
      End
      Begin VB.Label lblD2a 
         Alignment       =   2  'Center
         BackColor       =   &H80000013&
         Height          =   255
         Left            =   2760
         TabIndex        =   62
         Top             =   1320
         Width           =   375
      End
      Begin VB.Label lblC2a 
         Alignment       =   2  'Center
         BackColor       =   &H80000013&
         Height          =   255
         Left            =   2760
         TabIndex        =   61
         Top             =   960
         Width           =   375
      End
      Begin VB.Label lblB2a 
         Alignment       =   2  'Center
         BackColor       =   &H80000013&
         Height          =   255
         Left            =   2760
         TabIndex        =   60
         Top             =   600
         Width           =   375
      End
      Begin VB.Label lblA2a 
         Alignment       =   2  'Center
         BackColor       =   &H80000013&
         Height          =   255
         Left            =   2760
         TabIndex        =   59
         Top             =   240
         Width           =   375
      End
      Begin VB.Label lblE1a 
         Alignment       =   2  'Center
         BackColor       =   &H80000013&
         Height          =   255
         Left            =   1200
         TabIndex        =   58
         Top             =   1680
         Width           =   375
      End
      Begin VB.Label lblD1a 
         Alignment       =   2  'Center
         BackColor       =   &H80000013&
         Height          =   255
         Left            =   1200
         TabIndex        =   57
         Top             =   1320
         Width           =   375
      End
      Begin VB.Label lblC1a 
         Alignment       =   2  'Center
         BackColor       =   &H80000013&
         Height          =   255
         Left            =   1200
         TabIndex        =   56
         Top             =   960
         Width           =   375
      End
      Begin VB.Label lblB1a 
         Alignment       =   2  'Center
         BackColor       =   &H80000010&
         Height          =   255
         Left            =   1200
         TabIndex        =   55
         Top             =   600
         Width           =   375
      End
      Begin VB.Label lblA1a 
         Alignment       =   2  'Center
         BackColor       =   &H80000010&
         Height          =   255
         Left            =   1200
         TabIndex        =   54
         Top             =   240
         Width           =   375
      End
      Begin VB.Label lblE3 
         Alignment       =   2  'Center
         BackColor       =   &H8000000D&
         Caption         =   "Lays BBQ"
         Height          =   255
         Left            =   3240
         TabIndex        =   30
         Top             =   1680
         Width           =   975
      End
      Begin VB.Label lblE2 
         Alignment       =   2  'Center
         BackColor       =   &H8000000D&
         Caption         =   "Fritos"
         Height          =   255
         Left            =   1680
         TabIndex        =   29
         Top             =   1680
         Width           =   975
      End
      Begin VB.Label lblE1 
         Alignment       =   2  'Center
         BackColor       =   &H8000000D&
         Caption         =   "Doritos"
         Height          =   255
         Left            =   120
         TabIndex        =   28
         Top             =   1680
         Width           =   975
      End
      Begin VB.Label lblD3 
         Alignment       =   2  'Center
         BackColor       =   &H8000000D&
         Caption         =   "Ho Ho's"
         Height          =   255
         Left            =   3240
         TabIndex        =   27
         Top             =   1320
         Width           =   975
      End
      Begin VB.Label lblD2 
         Alignment       =   2  'Center
         BackColor       =   &H8000000D&
         Caption         =   "Sweet Rolls"
         Height          =   255
         Left            =   1680
         TabIndex        =   26
         Top             =   1320
         Width           =   975
      End
      Begin VB.Label lblD1 
         Alignment       =   2  'Center
         BackColor       =   &H8000000D&
         Caption         =   "Twinkie"
         Height          =   255
         Left            =   120
         TabIndex        =   25
         Top             =   1320
         Width           =   975
      End
      Begin VB.Label lblC3 
         Alignment       =   2  'Center
         BackColor       =   &H8000000D&
         Caption         =   "Reeses"
         Height          =   255
         Left            =   3240
         TabIndex        =   24
         Top             =   960
         Width           =   975
      End
      Begin VB.Label lblC2 
         Alignment       =   2  'Center
         BackColor       =   &H8000000D&
         Caption         =   "Snickers"
         Height          =   255
         Left            =   1680
         TabIndex        =   23
         Top             =   960
         Width           =   975
      End
      Begin VB.Label lblC1 
         Alignment       =   2  'Center
         BackColor       =   &H8000000D&
         Caption         =   "Symphony"
         Height          =   255
         Left            =   120
         TabIndex        =   22
         Top             =   960
         Width           =   975
      End
      Begin VB.Label lblB3 
         Alignment       =   2  'Center
         BackColor       =   &H8000000D&
         Caption         =   "Milkey Way"
         Height          =   255
         Left            =   3240
         TabIndex        =   21
         Top             =   600
         Width           =   975
      End
      Begin VB.Label lblB2 
         Alignment       =   2  'Center
         BackColor       =   &H8000000D&
         Caption         =   "Bar None"
         Height          =   255
         Left            =   1680
         TabIndex        =   20
         Top             =   600
         Width           =   975
      End
      Begin VB.Label lblB1 
         Alignment       =   2  'Center
         BackColor       =   &H8000000D&
         Caption         =   "Skittles"
         Height          =   255
         Left            =   120
         TabIndex        =   19
         Top             =   600
         Width           =   975
      End
      Begin VB.Label lblA3 
         Alignment       =   2  'Center
         BackColor       =   &H8000000D&
         Caption         =   "Almond Joy"
         Height          =   255
         Left            =   3240
         TabIndex        =   18
         Top             =   240
         Width           =   975
      End
      Begin VB.Label lblA2 
         Alignment       =   2  'Center
         BackColor       =   &H8000000D&
         Caption         =   "Heath"
         Height          =   255
         Left            =   1680
         TabIndex        =   17
         Top             =   240
         Width           =   975
      End
      Begin VB.Label lblA1 
         Alignment       =   2  'Center
         BackColor       =   &H8000000D&
         Caption         =   "Butterfinger"
         Height          =   255
         Left            =   120
         TabIndex        =   16
         Top             =   240
         Width           =   975
      End
   End
   Begin VB.Frame fmeBtns 
      Caption         =   "Buttons"
      Height          =   1215
      Left            =   2400
      TabIndex        =   6
      Top             =   240
      Width           =   2535
      Begin VB.CommandButton cmd3 
         Caption         =   "3"
         Height          =   375
         Left            =   1800
         TabIndex        =   14
         Top             =   720
         Width           =   375
      End
      Begin VB.CommandButton cmd2 
         Caption         =   "2"
         Height          =   375
         Left            =   1080
         TabIndex        =   13
         Top             =   720
         Width           =   375
      End
      Begin VB.CommandButton cmd1 
         Caption         =   "1"
         Height          =   375
         Left            =   360
         TabIndex        =   12
         Top             =   720
         Width           =   375
      End
      Begin VB.CommandButton cmdE 
         Caption         =   "E"
         Height          =   375
         Left            =   2040
         TabIndex        =   11
         Top             =   240
         Width           =   375
      End
      Begin VB.CommandButton cmdD 
         Caption         =   "D"
         Height          =   375
         Left            =   1560
         TabIndex        =   10
         Top             =   240
         Width           =   375
      End
      Begin VB.CommandButton cmdC 
         Caption         =   "C"
         Height          =   375
         Left            =   1080
         TabIndex        =   9
         Top             =   240
         Width           =   375
      End
      Begin VB.CommandButton cmdB 
         Caption         =   "B"
         Height          =   375
         Left            =   600
         TabIndex        =   8
         Top             =   240
         Width           =   375
      End
      Begin VB.CommandButton cmdA 
         Caption         =   "A"
         Height          =   375
         Left            =   120
         TabIndex        =   7
         Top             =   240
         Width           =   375
      End
   End
   Begin VB.Frame fmeMoney 
      Caption         =   "Money"
      Height          =   1215
      Left            =   240
      TabIndex        =   0
      Top             =   240
      Width           =   1935
      Begin VB.CommandButton cmdDlr 
         Caption         =   "$1"
         Height          =   375
         Left            =   720
         TabIndex        =   5
         Top             =   720
         Width           =   495
      End
      Begin VB.CommandButton cmdHlf 
         Caption         =   "$.50"
         Height          =   375
         Left            =   120
         TabIndex        =   4
         Top             =   720
         Width           =   495
      End
      Begin VB.CommandButton cmdQtr 
         Caption         =   "$.25"
         Height          =   375
         Left            =   1320
         TabIndex        =   3
         Top             =   240
         Width           =   495
      End
      Begin VB.CommandButton cmdDme 
         Caption         =   "$.10"
         Height          =   375
         Left            =   720
         TabIndex        =   2
         Top             =   240
         Width           =   495
      End
      Begin VB.CommandButton cmdNkl 
         Caption         =   "$.05"
         Height          =   375
         Left            =   120
         TabIndex        =   1
         Top             =   240
         Width           =   495
      End
   End
   Begin VB.Label lbl3 
      Alignment       =   2  'Center
      BackColor       =   &H8000000D&
      Caption         =   "3"
      Height          =   255
      Left            =   4320
      TabIndex        =   53
      Top             =   3840
      Width           =   375
   End
   Begin VB.Label lbl2 
      Alignment       =   2  'Center
      BackColor       =   &H8000000D&
      Caption         =   "2"
      Height          =   255
      Left            =   2880
      TabIndex        =   52
      Top             =   3840
      Width           =   375
   End
   Begin VB.Label lbl1 
      Alignment       =   2  'Center
      BackColor       =   &H8000000D&
      Caption         =   "1"
      Height          =   255
      Left            =   1320
      TabIndex        =   51
      Top             =   3840
      Width           =   375
   End
   Begin VB.Label lblE 
      Alignment       =   2  'Center
      BackColor       =   &H8000000D&
      Caption         =   "E"
      Height          =   255
      Left            =   240
      TabIndex        =   50
      Top             =   3360
      Width           =   375
   End
   Begin VB.Label lblD 
      Alignment       =   2  'Center
      BackColor       =   &H8000000D&
      Caption         =   "D"
      Height          =   255
      Left            =   240
      TabIndex        =   49
      Top             =   3000
      Width           =   375
   End
   Begin VB.Label lblC 
      Alignment       =   2  'Center
      BackColor       =   &H8000000D&
      Caption         =   "C"
      Height          =   255
      Left            =   240
      TabIndex        =   48
      Top             =   2640
      Width           =   375
   End
   Begin VB.Label lblB 
      Alignment       =   2  'Center
      BackColor       =   &H8000000D&
      Caption         =   "B"
      Height          =   255
      Left            =   240
      TabIndex        =   47
      Top             =   2280
      Width           =   375
   End
   Begin VB.Label lblA 
      Alignment       =   2  'Center
      BackColor       =   &H8000000D&
      Caption         =   "A"
      Height          =   255
      Left            =   240
      TabIndex        =   46
      Top             =   1920
      Width           =   375
   End
   Begin VB.Label lblSeln 
      Alignment       =   2  'Center
      BorderStyle     =   1  'Fixed Single
      Height          =   255
      Left            =   5160
      TabIndex        =   37
      Top             =   1080
      Width           =   375
   End
   Begin VB.Label lblSell 
      Alignment       =   2  'Center
      BorderStyle     =   1  'Fixed Single
      Height          =   255
      Left            =   5160
      TabIndex        =   36
      Top             =   600
      Width           =   375
   End
   Begin VB.Label lblChoice 
      Alignment       =   2  'Center
      Height          =   1095
      Left            =   240
      TabIndex        =   35
      Top             =   4320
      Width           =   3255
   End
   Begin VB.Label lblChng2 
      Alignment       =   2  'Center
      BorderStyle     =   1  'Fixed Single
      Height          =   255
      Left            =   5160
      TabIndex        =   34
      Top             =   4680
      Width           =   975
   End
   Begin VB.Label lblChng1 
      Alignment       =   2  'Center
      Caption         =   "Change"
      Height          =   255
      Left            =   3960
      TabIndex        =   33
      Top             =   4680
      Width           =   735
   End
   Begin VB.Label lblamt1 
      Alignment       =   2  'Center
      Caption         =   "Amount"
      Height          =   255
      Left            =   3960
      TabIndex        =   32
      Top             =   4320
      Width           =   735
   End
   Begin VB.Label lblAmt2 
      Alignment       =   2  'Center
      BorderStyle     =   1  'Fixed Single
      Height          =   255
      Left            =   5160
      TabIndex        =   31
      Top             =   4320
      Width           =   975
   End
End
Attribute VB_Name = "frmVending"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim intAmt2 As Currency
Dim intChng2 As Currency
Dim aamt As Currency
Dim bamt As Currency
Dim camt As Currency
Dim damt As Currency
Dim eamt As Currency
Dim intA1a As Integer
Dim intA2a As Integer
Dim intA3a As Integer
Dim intB1a As Integer
Dim intB2a As Integer
Dim intB3a As Integer
Dim intC1a As Integer
Dim intC2a As Integer
Dim intC3a As Integer
Dim intD1a As Integer
Dim intD2a As Integer
Dim intD3a As Integer
Dim intE1a As Integer
Dim intE2a As Integer
Dim intE3a As Integer


Private Sub Form_Load()
    intAmt2 = 0
    intChng2 = 0
    lblA1a = 5
    lblA2a = 3
    lblA3a = 6
    lblB1a = 8
    lblB2a = 4
    lblB3a = 6
    lblC1a = 3
    lblC2a = 9
    lblC3a = 2
    lblD1a = 4
    lblD2a = 6
    lblD3a = 7
    lblE1a = 4
    lblE2a = 8
    lblE3a = 6
    aamt = 0.55
    bamt = 0.55
    camt = 0.55
    damt = 0.65
    eamt = 0.6
End Sub

Private Sub cmdNkl_Click()
    intAmt2 = intAmt2 + 0.05
    lblAmt2.Caption = Str(intAmt2)
End Sub

Private Sub cmdDme_Click()
    intAmt2 = intAmt2 + 0.1
    lblAmt2.Caption = Str(intAmt2)
End Sub

Private Sub cmdQtr_Click()
    intAmt2 = intAmt2 + 0.25
    lblAmt2.Caption = Str(intAmt2)
End Sub

Private Sub cmdHlf_Click()
    intAmt2 = intAmt2 + 0.5
    lblAmt2.Caption = Str(intAmt2)
End Sub

Private Sub cmdDlr_Click()
    intAmt2 = intAmt2 + 1
    lblAmt2.Caption = Str(intAmt2)
End Sub

Private Sub cmdA_Click()
    lblSell.Caption = "A"
End Sub

Private Sub cmdB_Click()
    lblSell.Caption = "B"
End Sub

Private Sub cmdC_Click()
    lblSell.Caption = "C"
End Sub

Private Sub cmdD_Click()
    lblSell.Caption = "D"
End Sub

Private Sub cmdE_Click()
    lblSell.Caption = "E"
End Sub

Private Sub cmd1_Click()
    lblSeln.Caption = "1"
End Sub

Private Sub cmd2_Click()
    lblSeln.Caption = "2"
End Sub

Private Sub cmd3_Click()
    lblSeln.Caption = "3"
End Sub

Private Sub cmdReset_Click()
    lblSeln.Caption = ""
    lblSell.Caption = ""
    intAmt2 = 0
    lblAmt2.Caption = ""
    lblChng2.Caption = ""
    lblChoice.Caption = ""
End Sub

Private Sub cmdProc_Click()
    selnum = lblSell & lblSeln
    If (selnum = "") Then
        Mssg = "Please make a selection"
    ElseIf (selnum = "A1") Then
        If (intAmt2 >= aamt) Then
            Mssg = "Please remove your " & lblA1 & " and any change due."
            intChng2 = intAmt2 - aamt
            lblChng2.Caption = Str(intChng2)
            lblAmt2.Caption = ""
            intAmt2 = 0
            intA1a = lblA1a - 1
            lblA1a.Caption = Str(intA1a)
        Else
            more = aamt - intAmt2
            Mssg = "You need to insert $" & more & " more."
        End If
    ElseIf (selnum = "A2") Then
        If (intAmt2 >= aamt) Then
            Mssg = "Please remove your " & lblA2 & " and any change due."
            intChng2 = intAmt2 - aamt
            lblChng2.Caption = Str(intChng2)
            lblAmt2.Caption = ""
            intAmt2 = 0
            intA2a = lblA2a - 1
            lblA2a.Caption = Str(intA2a)
        Else
            more = aamt - intAmt2
            Mssg = "You need to insert $" & more & " more."
        End If
    ElseIf (selnum = "A3") Then
        If (intAmt2 >= aamt) Then
            Mssg = "Please remove your " & lblA3 & " and any change due."
            intChng2 = intAmt2 - aamt
            lblChng2.Caption = Str(intChng2)
            lblAmt2.Caption = ""
            intAmt2 = 0
            intA3a = lblA3a - 1
            lblA3a.Caption = Str(intA3a)
        Else
            more = aamt - intAmt2
            Mssg = "You need to insert $" & more & " more."
        End If
    ElseIf (selnum = "B1") Then
        If (intAmt2 >= aamt) Then
            Mssg = "Please remove your " & lblB1 & " and any change due."
            intChng2 = intAmt2 - aamt
            lblChng2.Caption = Str(intChng2)
            lblAmt2.Caption = ""
            intAmt2 = 0
            intB1a = lblB1a - 1
            lblB1a.Caption = Str(intB1a)
        Else
            more = aamt - intAmt2
            Mssg = "You need to insert $" & more & " more."
        End If
    ElseIf (selnum = "B2") Then
        If (intAmt2 >= aamt) Then
            Mssg = "Please remove your " & lblB2 & " and any change due."
            intChng2 = intAmt2 - aamt
            lblChng2.Caption = Str(intChng2)
            lblAmt2.Caption = ""
            intAmt2 = 0
            intB2a = lblB2a - 1
            lblB2a.Caption = Str(intB2a)
        Else
            more = aamt - intAmt2
            Mssg = "You need to insert $" & more & " more."
        End If
    ElseIf (selnum = "B3") Then
        If (intAmt2 >= aamt) Then
            Mssg = "Please remove your " & lblB3 & " and any change due."
            intChng2 = intAmt2 - aamt
            lblChng2.Caption = Str(intChng2)
            lblAmt2.Caption = ""
            intAmt2 = 0
            intB3a = lblB3a - 1
            lblB3a.Caption = Str(intB3a)
        Else
            more = aamt - intAmt2
            Mssg = "You need to insert $" & more & " more."
        End If
    ElseIf (selnum = "C1") Then
        If (intAmt2 >= aamt) Then
            Mssg = "Please remove your " & lblC1 & " and any change due."
            intChng2 = intAmt2 - aamt
            lblChng2.Caption = Str(intChng2)
            lblAmt2.Caption = ""
            intAmt2 = 0
            intC1a = lblC1a - 1
            lblC1a.Caption = Str(intC1a)
        Else
            more = aamt - intAmt2
            Mssg = "You need to insert $" & more & " more."
        End If
    ElseIf (selnum = "C2") Then
        If (intAmt2 >= aamt) Then
            Mssg = "Please remove your " & lblC2 & " and any change due."
            intChng2 = intAmt2 - aamt
            lblChng2.Caption = Str(intChng2)
            lblAmt2.Caption = ""
            intAmt2 = 0
            intC2a = lblC2a - 1
            lblC2a.Caption = Str(intC2a)
        Else
            more = aamt - intAmt2
            Mssg = "You need to insert $" & more & " more."
        End If
    ElseIf (selnum = "C3") Then
        If (intAmt2 >= aamt) Then
            Mssg = "Please remove your " & lblC3 & " and any change due."
            intChng2 = intAmt2 - aamt
            lblChng2.Caption = Str(intChng2)
            lblAmt2.Caption = ""
            intAmt2 = 0
            intC3a = lblC3a - 1
            lblC3a.Caption = Str(intC3a)
        Else
            more = aamt - intAmt2
            Mssg = "You need to insert $" & more & " more."
        End If
    ElseIf (selnum = "D1") Then
        If (intAmt2 >= aamt) Then
            Mssg = "Please remove your " & lblD1 & " and any change due."
            intChng2 = intAmt2 - aamt
            lblChng2.Caption = Str(intChng2)
            lblAmt2.Caption = ""
            intAmt2 = 0
            intD1a = lblD1a - 1
            lblD1a.Caption = Str(intD1a)
        Else
            more = aamt - intAmt2
            Mssg = "You need to insert $" & more & " more."
        End If
    ElseIf (selnum = "D2") Then
        If (intAmt2 >= aamt) Then
            Mssg = "Please remove your " & lblD2 & " and any change due."
            intChng2 = intAmt2 - aamt
            lblChng2.Caption = Str(intChng2)
            lblAmt2.Caption = ""
            intAmt2 = 0
            intD2a = lblD2a - 1
            lblD2a.Caption = Str(intD2a)
        Else
            more = aamt - intAmt2
            Mssg = "You need to insert $" & more & " more."
        End If
    ElseIf (selnum = "D3") Then
        If (intAmt2 >= aamt) Then
            Mssg = "Please remove your " & lblD3 & " and any change due."
            intChng2 = intAmt2 - aamt
            lblChng2.Caption = Str(intChng2)
            lblAmt2.Caption = ""
            intAmt2 = 0
            intD3a = lblD3a - 1
            lblD3a.Caption = Str(intD3a)
        Else
            more = aamt - intAmt2
            Mssg = "You need to insert $" & more & " more."
        End If
    ElseIf (selnum = "E1") Then
        If (intAmt2 >= aamt) Then
            Mssg = "Please remove your " & lblE1 & " and any change due."
            intChng2 = intAmt2 - aamt
            lblChng2.Caption = Str(intChng2)
            lblAmt2.Caption = ""
            intAmt2 = 0
            intE1a = lblE1a - 1
            lblE1a.Caption = Str(intE1a)
        Else
            more = aamt - intAmt2
            Mssg = "You need to insert $" & more & " more."
        End If
    ElseIf (selnum = "E2") Then
        If (intAmt2 >= aamt) Then
            Mssg = "Please remove your " & lblE2 & " and any change due."
            intChng2 = intAmt2 - aamt
            lblChng2.Caption = Str(intChng2)
            lblAmt2.Caption = ""
            intAmt2 = 0
            intE2a = lblE2a - 1
            lblE2a.Caption = Str(intE2a)
        Else
            more = aamt - intAmt2
            Mssg = "You need to insert $" & more & " more."
        End If
    ElseIf (selnum = "E3") Then
        If (intAmt2 >= aamt) Then
            Mssg = "Please remove your " & lblE3 & " and any change due."
            intChng2 = intAmt2 - aamt
            lblChng2.Caption = Str(intChng2)
            lblAmt2.Caption = ""
            intAmt2 = 0
            intE3a = lblE3a - 1
            lblE3a.Caption = Str(intE3a)
        Else
            more = aamt - intAmt2
            Mssg = "You need to insert $" & more & " more."
        End If
    End If
    lblChoice.Caption = Mssg
End Sub
