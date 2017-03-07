VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "Student"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit

Private mstrFirstName As String
Private mstrLastName As String
Private mstrMajor As String
Private mintMidterm As Integer
Private mintFinalExam As Integer
Private mstrPassword As String
Private mstrSSN As String

Property Get intFinalExam(strPassword As String) As Integer
If (mstrPassword = strPassword) Then
    intFinalExam = mintFinalExam
Else
   MsgBox "Invalid Password"
End If
End Property

Property Get intMidterm(strPassword As String) As Integer
If (mstrPassword = strPassword) Then
    intMidterm = mintMidterm
Else
   MsgBox "Invalid Password"
End If
End Property

Property Get intSSN(strPassword As String) As String
If (mstrPassword = strPassword) Then
    intSSN = mintSSN
Else
   MsgBox "Invalid Password"
End If
End Property

Property Get strFirstName() As String
strFirstName = mstrFirstName
End Property

Property Get strLastName() As String
strLastName = mstrLastName
End Property

Property Get strMajor() As String
strMajor = mstrMajor
End Property


Public Sub InitializeStudent(strFirstName As String, strLastName As String, strSSN As String, strMajor As String, strPassword As String)
If (Len(mstrPassword) > 0) Then
  MsgBox "The password is already set"
Else
  mstrFirstName = strFirstName
  mstrLastName = strLastName
  mstrSSN = strSSN
  mstrMajor = strMajor
  mstrPassword = strPassword
End If
End Sub
Property Let strFirstName(strFirstName As String)
mstrFirstName = strFirstName
End Property

Property Let strLastName(strLastName As String)
mstrLastName = strLastName
End Property

Property Let strMajor(strMajor As String)
mstrMajor = strMajor
End Property

Property Let strSSN(strSSN As String)
mstrSSNName = strSSN
End Property

Public Sub SetMidterm(intMidterm As Integer, strPassword As String)
If (mstrPassword = strPassword) Then
  mintMidterm = intMidterm
Else
  MsgBox "Invalid Password"
End If
End Sub

Public Sub SetFinalExam(intFinalExam As Single, strPassword As String)
If (mstrPassword = strPassword) Then
  mintFinalExam = intFinalExam
Else
  MsgBox "Invalid Password"
End If
End Sub

