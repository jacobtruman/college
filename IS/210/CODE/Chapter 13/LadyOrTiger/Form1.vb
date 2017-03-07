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
    Private WithEvents lblTitle As System.WinForms.Label
    Private WithEvents cmdRightDoor As System.WinForms.Button
    Private WithEvents cmdLeftDoor As System.WinForms.Button
    Private WithEvents pctLeftDoor As System.WinForms.PictureBox
    Private WithEvents pctRightDoor As System.WinForms.PictureBox
    
    Dim WithEvents Form1 As System.WinForms.Form

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        
        Me.components = New System.ComponentModel.Container()
        Me.pctLeftDoor = New System.WinForms.PictureBox()
        Me.pctRightDoor = New System.WinForms.PictureBox()
        Me.cmdLeftDoor = New System.WinForms.Button()
        Me.lblTitle = New System.WinForms.Label()
        Me.cmdRightDoor = New System.WinForms.Button()
        
        '@design Me.TrayHeight = 0
        '@design Me.TrayLargeIcon = False
        '@design Me.TrayAutoArrange = True
        pctLeftDoor.Location = New System.Drawing.Point(104, 88)
        pctLeftDoor.Size = New System.Drawing.Size(104, 232)
        pctLeftDoor.TabIndex = 1
        pctLeftDoor.TabStop = False
        pctLeftDoor.Image = CType(resources.GetObject("pctLeftDoor.Image"), System.Drawing.Image)
        
        pctRightDoor.Location = New System.Drawing.Point(304, 88)
        pctRightDoor.Size = New System.Drawing.Size(104, 240)
        pctRightDoor.TabIndex = 0
        pctRightDoor.TabStop = False
        pctRightDoor.Image = CType(resources.GetObject("pctRightDoor.Image"), System.Drawing.Image)
        
        cmdLeftDoor.Location = New System.Drawing.Point(120, 336)
        cmdLeftDoor.Size = New System.Drawing.Size(80, 24)
        cmdLeftDoor.TabIndex = 2
        cmdLeftDoor.Text = "Left Door"
        
        lblTitle.Location = New System.Drawing.Point(88, 16)
        lblTitle.Text = "Pick a Door Wisely"
        lblTitle.Size = New System.Drawing.Size(344, 32)
        lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14!, System.Drawing.FontStyle.Bold)
        lblTitle.TabIndex = 4
        lblTitle.TextAlign = System.WinForms.HorizontalAlignment.Center
        
        cmdRightDoor.Location = New System.Drawing.Point(320, 336)
        cmdRightDoor.Size = New System.Drawing.Size(80, 24)
        cmdRightDoor.TabIndex = 3
        cmdRightDoor.Text = "Right Door"
        
        Me.Text = "Lady or the Tiger?"
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(504, 365)
        
        Me.Controls.Add(lblTitle)
        Me.Controls.Add(cmdRightDoor)
        Me.Controls.Add(cmdLeftDoor)
        Me.Controls.Add(pctLeftDoor)
        Me.Controls.Add(pctRightDoor)
    End Sub
    
#End Region
    
    Protected Sub cmdRightDoor_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        pctRightDoor.Image = Image.FromFile("Y:\SimpleApp2\Tiger.gif")
        lblTitle.Text = "Guilty"
    End Sub
    
    Protected Sub cmdLeftDoor_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        pctLeftDoor.Image = Image.FromFile("Y:\SimpleApp2\Lady.gif")
        lblTitle.Text = "Innocent"
    End Sub
    
End Class
