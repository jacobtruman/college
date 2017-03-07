Public Class Clock
    Protected mintHour As Integer
    Protected mintMinute As Integer
    Protected mintSecond As Integer
    Public Property Hour() As Integer
        Get
            Return mintHour
        End Get
        Set
            mintHour = value
        End Set
    End Property
    Public Property Minute() As Integer
        Get
            Return mintMinute
        End Get
        Set
            mintMinute = value
        End Set
    End Property
    Public Property Second() As Integer
        Get
            Return mintSecond
        End Get
        Set
            mintSecond = value
        End Set
    End Property
    Public Overridable Function Time() As String
        Return mintHour.ToString & ":" & mintMinute.ToString & ":" & mintSecond.ToString
    End Function
    Public Sub New(ByVal intH As Integer, ByVal intM As Integer, ByVal intS As Integer)
        minthour = intH
        mintminute = intM
        mintsecond = intS
    End Sub
    Public Sub New()
        minthour = 12
        mintminute = 0
        mintsecond = 0
    End Sub
    Public Overridable Sub Increment()
        mintsecond += 1
        If (Mintsecond = 60) Then
            mintSecond = 0
            mintMinute += 1
            If (mintMinute = 60) Then
                mintMinute = 0
                minthour = minthour + 1
                If minthour = 24 Then
                    minthour = 0
                End If
            End If
        End If
    End Sub
End Class

Public Class AlarmClock
    Inherits Clock
    Private mintAlarmHour As Integer
    Private mintAlarmMinute As Integer
    Private mintAlarmSecond As Integer
    Private mintAlarmSet As Boolean
    Public Sub New(ByVal intH As Integer, ByVal intM As Integer, ByVal intS As Integer)
        MyBase.New(intH, intM, intS)
        mintAlarmSet = False
    End Sub
    Public Overrides Sub Increment()
        MyBase.Increment()
        If (mintAlarmHour = mintHour) And (mintAlarmMinute = mintAlarmMinute) _
            And (mintAlarmSecond = mintAlarmSecond) Then
            MsgBox("ALARM")
        End If
    End Sub
    
    Public Sub SetAlarm(ByVal intH As Integer, ByVal intM As Integer, ByVal intS As Integer)
        mintAlarmHour = intH
        mintAlarmMinute = intM
        mintAlarmSecond = intS
        mintAlarmSet = True
    End Sub
    
    Public Sub ShutAlarm()
        mintAlarmSet = False
    End Sub
    
    Public Sub TestMessage()
        MsgBox("This is a test of the Alarm Clock Class")
    End Sub
    
    Public Overrides Function Time() As String
        If (mintALarmSet = True) Then
            Return MyBase.Time() & " *"
        Else
            Return MyBase.Time()
        End If
    End Function
End Class