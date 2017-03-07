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
    Private WithEvents Button1 As System.WinForms.Button
    
    Dim WithEvents Form1 As System.WinForms.Form

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.WinForms.Button()
        
        '@design Me.TrayHeight = 0
        '@design Me.TrayLargeIcon = False
        '@design Me.TrayAutoArrange = True
        Button1.Location = New System.Drawing.Point(104, 208)
        Button1.Size = New System.Drawing.Size(112, 32)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        
        Me.Text = "Form1"
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        
        Me.Controls.Add(Button1)
    End Sub
    
#End Region
    
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim grfGraphics As Graphics
        grfGraphics = Me.CreateGraphics
        
        Dim penDrawingPen As New Pen(Color.Red)
        grfGraphics.DrawEllipse(penDrawingPen, 50, 50, 40, 40)
        
        penDrawingPen.Color = Color.Blue
        grfGraphics.DrawLine(penDrawingPen, 70, 90, 70, 150)
        
        penDrawingPen.Color = Color.Yellow
        
        'Draw Arms
        grfGraphics.DrawLine(penDrawingPen, 70, 120, 55, 105)
        grfGraphics.DrawLine(penDrawingPen, 70, 120, 85, 105)
        
        'Draw Legs
        grfGraphics.DrawLine(penDrawingPen, 70, 150, 45, 170)
        grfGraphics.DrawLine(penDrawingPen, 70, 150, 95, 170)
        
        'Draw Feet
        Dim rctFoot As Rectangle
        Dim pntFoot As Point
        Dim szeFoot As Size
        
        szeFoot = New Size(20, 10)
        
        'Left Foot
        pntFoot = New Point(25, 160)
        rctFoot = New Rectangle(pntFoot, szeFoot)
        grfGraphics.DrawRectangle(penDrawingPen, rctFoot)
        
        'Right Foot
        pntFoot = New Point(95, 160)
        rctFoot = New Rectangle(pntFoot, szeFoot)
        grfGraphics.DrawRectangle(penDrawingPen, rctFoot)
        
        
        'Draw Adam Text
        Dim bshAdam As SolidBrush
        Dim fntAdam As Font
        
        bshAdam = New SolidBrush(System.Drawing.Color.Black)
        fntAdam = New Font("Times", 10)
        grfGraphics.DrawString("Adam", fntAdam, bshAdam, 55, 180)
        
        
    End Sub
    
End Class
