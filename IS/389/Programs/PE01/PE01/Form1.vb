Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents lblScreenSaver As System.Windows.Forms.Label
    Friend WithEvents tmrGoLeft As System.Windows.Forms.Timer
    Friend WithEvents tmrGoRight As System.Windows.Forms.Timer
    Friend WithEvents tmrGoUp As System.Windows.Forms.Timer
    Friend WithEvents tmrGoDown As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.lblScreenSaver = New System.Windows.Forms.Label
        Me.tmrGoLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGoRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGoUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGoDown = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblScreenSaver
        '
        Me.lblScreenSaver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScreenSaver.Location = New System.Drawing.Point(104, 128)
        Me.lblScreenSaver.Name = "lblScreenSaver"
        Me.lblScreenSaver.Size = New System.Drawing.Size(112, 16)
        Me.lblScreenSaver.TabIndex = 0
        Me.lblScreenSaver.Text = "Click to Start"
        '
        'tmrGoLeft
        '
        Me.tmrGoLeft.Enabled = True
        '
        'tmrGoRight
        '
        '
        'tmrGoUp
        '
        Me.tmrGoUp.Enabled = True
        '
        'tmrGoDown
        '
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.lblScreenSaver)
        Me.Name = "Form1"
        Me.Text = "Jacob Truman"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub tmrGoLeft_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGoLeft.Tick
        Dim myLeft As Integer

        myLeft = lblScreenSaver.Left - 10
        If myLeft < 0 Then
            lblScreenSaver.Left = 0
            tmrGoRight.Enabled = True
            tmrGoLeft.Enabled = False
        Else
            lblScreenSaver.Left = myLeft
        End If
    End Sub

    Private Sub tmrGoRight_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGoRight.Tick
        Dim myRight As Integer

        myRight = lblScreenSaver.Left + 10
        If myRight > ActiveForm.Width - lblScreenSaver.Width Then
            lblScreenSaver.Left = ActiveForm.Width - lblScreenSaver.Width
            tmrGoLeft.Enabled = True
            tmrGoRight.Enabled = False
        Else
            lblScreenSaver.Left = myRight
        End If
    End Sub

    Private Sub tmrGoUp_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGoUp.Tick
        Dim myUp As Integer

        myUp = lblScreenSaver.Top - 10
        If myUp < 0 Then
            lblScreenSaver.Top = 0
            tmrGoDown.Enabled = True
            tmrGoUp.Enabled = False
        Else
            lblScreenSaver.Top = myUp
        End If
    End Sub

    Private Sub tmrGoDown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGoDown.Tick
        Dim myDown As Integer

        myDown = lblScreenSaver.Top + 10
        If myDown > ActiveForm.Height - lblScreenSaver.Height - 28 Then
            lblScreenSaver.Top = ActiveForm.Height - lblScreenSaver.Height - 28
            tmrGoUp.Enabled = True
            tmrGoDown.Enabled = False
        Else
            lblScreenSaver.Top = myDown
        End If
    End Sub

    Private Sub Form1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click
        Dim frmForm2 As New Form2(Me)

        frmForm2.Top = Me.Top
        frmForm2.Left = Me.Left
        frmForm2.Show()
        Me.Visible() = False
    End Sub

    Private Sub lblScreenSaver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblScreenSaver.Click
        Dim frmForm2 As New Form2(Me)

        frmForm2.Top = Me.Top
        frmForm2.Left = Me.Left
        frmForm2.Show()
        Me.Visible() = False
    End Sub
End Class
