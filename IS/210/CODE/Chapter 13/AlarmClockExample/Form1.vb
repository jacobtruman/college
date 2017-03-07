Option Strict Off


Imports System.ComponentModel
Imports System.Drawing
Imports System.WinForms


Public Class Form1
    Inherits System.WinForms.Form

    Public Sub New()
        MyBase.New

        Form1 = Me

        'This call is required by the Win Form Designer.
        InitializeComponent

        'TODO: Add any initialization after the InitializeComponent() call
    End Sub

    'Form overrides dispose to clean up the component list.
    Overrides Public Sub Dispose()
        MyBase.Dispose
        components.Dispose
    End Sub 

#Region " Windows Form Designer generated code "

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.Container
    Private WithEvents txtTime As System.WinForms.TextBox
    Private WithEvents Button1 As System.WinForms.Button
    
    Dim WithEvents Form1 As System.WinForms.Form

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.WinForms.Button()
        Me.txtTime = New System.WinForms.TextBox()
        
        '@design Me.TrayHeight = 0
        '@design Me.TrayLargeIcon = False
        '@design Me.TrayAutoArrange = True
        Button1.Location = New System.Drawing.Point(88, 80)
        Button1.Size = New System.Drawing.Size(120, 32)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        
        txtTime.Location = New System.Drawing.Point(64, 24)
        txtTime.TabIndex = 1
        txtTime.Size = New System.Drawing.Size(160, 20)
        
        Me.Text = "Form1"
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        
        Me.Controls.Add(txtTime)
        Me.Controls.Add(Button1)
    End Sub
    
#End Region
    
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim test As AlarmClock
        Dim test2 As Object
        test2 = New AlarmClock(2, 10, 1)
        test = New AlarmClock(3, 12, 0)
        txtTime.Text = test.Time
        test.SetAlarm(3, 12, 1)
        test.Increment()
        test.Increment()
        txtTime.Text = test.time
        test.TestMessage()
        test2.TestMessage()
    End Sub
    
End Class
