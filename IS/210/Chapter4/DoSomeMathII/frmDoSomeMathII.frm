VERSION 5.00
Begin VB.Form frmDoSomeMathII 
   Caption         =   "Let's Do Some Math!!"
   ClientHeight    =   6135
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   10800
   LinkTopic       =   "Form1"
   ScaleHeight     =   6135
   ScaleWidth      =   10800
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdReset 
      Caption         =   "Reset Form"
      CausesValidation=   0   'False
      Height          =   495
      Left            =   3840
      TabIndex        =   12
      Top             =   5280
      Width           =   1335
   End
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
Attribute VB_Name = "frmDoSomeMathII"
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
    
'CAST INTO DOUBLE DATATYPE VARIABLES.

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



Private Sub cmdReset_Click()

'THE CODE IN THIS EVENT WILL RESET THE TEXTBOXES AND CHECKBOXES SO
'THE USER CAN START OVER

    'reset the textboxes
    txtVal1.Text = vbNullString
    txtVal2.Text = vbNullString
    
    'reset/uncheck all the checkboxes
    chkAdd.Value = vbUnchecked
    chkSubtract.Value = vbUnchecked
    chkMultiply.Value = vbUnchecked
    chkDivide.Value = vbUnchecked
    
    'reset the label to display nothing
    lblResults.Caption = ""
    
    'finally, put the cursor in the first value textbox
    txtVal1.SetFocus
    
    
End Sub

Private Sub txtVal1_KeyPress(KeyAscii As Integer)

'Error checking procedure....parse the present key pressed and look for non-numeric
'key values.  0-9 are legit, as are control keys(space bar...etc)

    If ((KeyAscii < vbKeySpace) Or (KeyAscii = 46)) Then
        'ignore these control keys
    ElseIf ((KeyAscii >= vbKey0) And (KeyAscii <= vbKey9)) Then
        'ignore....these are the keys we want them to press!
    Else
        'these are the ones we want to trap and notify the user not to press
        'after the message box display, supress the faulty key that was pressed
    MsgBox "Please enter only numeric data."
    KeyAscii = 0
End If

End Sub



Private Sub txtVal1_Validate(Cancel As Boolean)

'CHECK TO SEE IF THE TEXTBOX IS EMPTY

    If txtVal1.Text = vbNullString Or txtVal1.Text = "" Then
        MsgBox "Enter a value for number 1."
        txtVal1.SetFocus
        Cancel = True
    End If
    
End Sub

Private Sub txtVal2_KeyPress(KeyAscii As Integer)

    'Error checking procedure....parse the present key pressed and look for non-numeric
'key values.  0-9 are legit, as are control keys(space bar...etc)

    If ((KeyAscii < vbKeySpace) Or (KeyAscii = 46)) Then
        'ignore these control keys
    ElseIf ((KeyAscii >= vbKey0) And (KeyAscii <= vbKey9)) Then
        'ignore....these are the keys we want them to press!
    Else
        'these are the ones we want to trap and notify the user not to press
        'after the message box display, supress the faulty key that was pressed
    MsgBox "Please enter only numeric data."
    KeyAscii = 0
End If

End Sub

Private Sub txtVal2_Validate(Cancel As Boolean)

    If txtVal2.Text = vbNullString Or txtVal2.Text = "" Then
        MsgBox "Enter a value for number 2."
        txtVal2.SetFocus
        Cancel = True
    End If
    
End Sub
