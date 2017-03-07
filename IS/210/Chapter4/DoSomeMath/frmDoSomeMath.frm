VERSION 5.00
Begin VB.Form frmDoSomeMath 
   Caption         =   "Let's Do Some Math!!"
   ClientHeight    =   6135
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   10800
   LinkTopic       =   "Form1"
   ScaleHeight     =   6135
   ScaleWidth      =   10800
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdCalculate 
      Caption         =   "Here are your results!"
      Height          =   495
      Left            =   840
      TabIndex        =   10
      Top             =   2280
      Width           =   1935
   End
   Begin VB.CheckBox chkDivide 
      Caption         =   "DIVIDE them"
      Height          =   255
      Left            =   7800
      TabIndex        =   9
      Top             =   1320
      Width           =   1575
   End
   Begin VB.CheckBox chkMultiply 
      Caption         =   "MULTIPLY Them"
      Height          =   255
      Left            =   7800
      TabIndex        =   8
      Top             =   840
      Width           =   1575
   End
   Begin VB.CheckBox chkSubtract 
      Caption         =   "SUBTRACT Them"
      Height          =   255
      Left            =   5520
      TabIndex        =   7
      Top             =   1320
      Width           =   1695
   End
   Begin VB.CheckBox chkAdd 
      Caption         =   "ADD Them"
      Height          =   255
      Left            =   5520
      TabIndex        =   6
      Top             =   840
      Width           =   1335
   End
   Begin VB.TextBox txtVal2 
      Height          =   285
      Left            =   1080
      TabIndex        =   4
      Top             =   1320
      Width           =   1215
   End
   Begin VB.TextBox txtVal1 
      Height          =   285
      Left            =   1080
      TabIndex        =   3
      Top             =   840
      Width           =   1215
   End
   Begin VB.Label lblResults 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00C00000&
      Height          =   2175
      Left            =   3360
      TabIndex        =   11
      Top             =   2280
      Width           =   4695
   End
   Begin VB.Label Label4 
      Caption         =   "What do you want to do with them?"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   5040
      TabIndex        =   5
      Top             =   240
      Width           =   5175
   End
   Begin VB.Label Label3 
      Alignment       =   1  'Right Justify
      Caption         =   "Number 2:"
      Height          =   255
      Left            =   120
      TabIndex        =   2
      Top             =   1320
      Width           =   855
   End
   Begin VB.Label Label2 
      Alignment       =   1  'Right Justify
      Caption         =   "Number 1:"
      Height          =   255
      Left            =   120
      TabIndex        =   1
      Top             =   840
      Width           =   855
   End
   Begin VB.Label Label1 
      Caption         =   "Give me two numbers:"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      TabIndex        =   0
      Top             =   240
      Width           =   3255
   End
End
Attribute VB_Name = "frmDoSomeMath"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit


'THIS APPLICATION WILL USE CHECKBOXES TO INDICATE WHICH
'ACTIONS THE USER WANTS TO PERFORM ON THE 2 GIVEN VALUES.

'IT WILL ALSO USE A SERIES OF 'IF' STRUCTURES TO VALIDATE
'THE DATA, AS WELL AS DETERMINE WHICH MATH OPERATIONS TO
'PERFORM BASED ON WHICH CHECKBOXES ARE CHECKED/UNCHECKED.

'THERE ARE NO FORM-LEVEL VARIABLE DECLARATIONS.....ALL
'CODE IS WRITTEN IN THE CLICK EVENT FOR THE cmcCalculate
'BUTTON


Private Sub cmdCalculate_Click()

'ALL VARIABLE DECLARATIONS SHOULD BE THE FIRST STATEMENTS
'IN THE CODE FOR THE EVENT.  THE VARIABLES WERE CREATED AS
'I WROTE THE CODE.......WHEN I DETERMINED THAT I WAS GOING
'TO NEED A VARIABLE, I SIMPLY CAME BACK UP HERE AND WROTE THE
'DECLARATION

'------------ ONE variable declaration per line!!!!!! --------
    Dim resultstring As String
    Dim var1 As Double
    Dim var2 As Double
    Dim addresult As Double
    Dim subresult As Double
    Dim multresult As Double
    Dim divresult As Double
    
'LET'S CHECK AND SEE IF THEY ENTERED LEGITIMATE VALUES THAT
'CAN BE CAST INTO A NUMERIC DATATYPE.

    If (Not (IsNumeric(txtVal1.Text)) And Not (IsNumeric(txtVal2.Text))) Then
        MsgBox "Enter valid numeric data in BOTH textboxes please."
        txtVal1.SetFocus
        Exit Sub
    ElseIf Not IsNumeric(txtVal1.Text) Then
        MsgBox "Enter valid numeric data in the FIRST textbox please."
        txtVal1.SetFocus
        Exit Sub
    ElseIf Not IsNumeric(txtVal2.Text) Then
       MsgBox "Enter valid numeric data in the SECOND textbox please."
        txtVal2.SetFocus
        Exit Sub
    Else
        'this is called an "empty statement" because we are not taking
        'any action in this part of the if statement...the values in
        'the textboxes are good values
    End If
    
    
'DUE TO THE "EXIT SUB" STATEMENTS IN THE ABOVE IF STATEMENT, IF THE PROGRAM
'GETS TO THIS POINT WE CAN SAFELY ASSUME THAT WE HAVE VALUES IN THE TEXTBOXES
'THAT CAN BE CAST INTO DOUBLE DATATYPE VARIABLES.

    var1 = CDbl(txtVal1.Text)
    var2 = CDbl(txtVal2.Text)
    
    
'I ALSO INITIALIZE THE STRING VARIABLE AT THIS POINT BECAUSE I AM GOING
'TO START BUILDING THE MESSAGE THAT THE USER WILL SEE.  I AM USING A HEADER
'THAT IS COMMON TO THE MESSAGE REGARDLESS OF WHICH MATH OPERATIONS ARE
'PERFORMED

    resultstring = "The results of " & var1 & " and " & var2 & " are as " _
                & "follows:" & vbCrLf & vbCrLf
                
                
'A SERIES OF "IF.....ELSE.....END IF" STATEMENTS TO CHECK THE .VALUE
'PROPERTY OF EACH CHECKBOX.  IF CHECKED, PERFORM THE MATH AND ADD TO
'THE MESSAGE STRING.  IF NOT CHECKED, INICATE THAT ISN'T SELECTED

    If chkAdd.Value = vbChecked Then
        addresult = var1 + var2
        resultstring = resultstring & "ADDITION:  " & addresult & vbCrLf
    Else
        resultstring = resultstring & "ADDITION:  not selected." & vbCrLf
    End If
    
    If chkSubtract.Value = vbChecked Then
        subresult = var1 - var2
        resultstring = resultstring & "SUBTRACTION:  " & subresult & vbCrLf
    Else
        resultstring = resultstring & "SUBTRACTION:  not selected." & vbCrLf
    End If
    
    If chkMultiply.Value = vbChecked Then
        multresult = var1 * var2
        resultstring = resultstring & "MULTIPLICATION:  " & multresult & _
                       vbCrLf
    Else
        resultstring = resultstring & "MULTIPLICATION:  not selected." & vbCrLf
    End If
    
'IN ORDER TO DO THE DIVISION, WE HAVE TO MAKE SURE THAT THE DENOMINATOR IS NOT ZERO!!
'WE ONLY CHECK FOR ZERO IF THE DIVISION CHECKBOX IS CHECKED.

    If chkDivide.Value = vbChecked Then
        If var2 = 0 Then
            resultstring = resultstring & "DIVISION:  can't divide by 0!"
        Else
            divresult = var1 / var2
            resultstring = resultstring & "DIVISION:  " & divresult
        End If
    Else
        resultstring = resultstring & "DIVISION:  not selected."
    End If
        
'DISPLAY THE RESULT STRING IN THE LABEL CONTROL

    lblResults.Caption = resultstring
    
End Sub
