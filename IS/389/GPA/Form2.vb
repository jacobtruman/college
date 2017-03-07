Public Class Form2
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
    Friend WithEvents gboxInput As System.Windows.Forms.GroupBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents txtAssignMax As System.Windows.Forms.TextBox
    Friend WithEvents lblAssignMax As System.Windows.Forms.Label
    Friend WithEvents lblAssignNum As System.Windows.Forms.Label
    Friend WithEvents txtAssignNum As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gboxInput = New System.Windows.Forms.GroupBox
        Me.btnSubmit = New System.Windows.Forms.Button
        Me.txtAssignMax = New System.Windows.Forms.TextBox
        Me.lblAssignMax = New System.Windows.Forms.Label
        Me.lblAssignNum = New System.Windows.Forms.Label
        Me.txtAssignNum = New System.Windows.Forms.TextBox
        Me.gboxInput.SuspendLayout()
        Me.SuspendLayout()
        '
        'gboxInput
        '
        Me.gboxInput.Controls.Add(Me.btnSubmit)
        Me.gboxInput.Controls.Add(Me.txtAssignMax)
        Me.gboxInput.Controls.Add(Me.lblAssignMax)
        Me.gboxInput.Controls.Add(Me.lblAssignNum)
        Me.gboxInput.Controls.Add(Me.txtAssignNum)
        Me.gboxInput.Location = New System.Drawing.Point(22, 56)
        Me.gboxInput.Name = "gboxInput"
        Me.gboxInput.Size = New System.Drawing.Size(248, 160)
        Me.gboxInput.TabIndex = 43
        Me.gboxInput.TabStop = False
        Me.gboxInput.Text = "Submit/Update"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(160, 120)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.TabIndex = 8
        Me.btnSubmit.Text = "Submit"
        '
        'txtAssignMax
        '
        Me.txtAssignMax.Location = New System.Drawing.Point(136, 40)
        Me.txtAssignMax.Name = "txtAssignMax"
        Me.txtAssignMax.TabIndex = 7
        Me.txtAssignMax.Text = ""
        '
        'lblAssignMax
        '
        Me.lblAssignMax.Location = New System.Drawing.Point(16, 40)
        Me.lblAssignMax.Name = "lblAssignMax"
        Me.lblAssignMax.TabIndex = 6
        Me.lblAssignMax.Text = "Max Points"
        Me.lblAssignMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAssignNum
        '
        Me.lblAssignNum.Location = New System.Drawing.Point(16, 16)
        Me.lblAssignNum.Name = "lblAssignNum"
        Me.lblAssignNum.TabIndex = 5
        Me.lblAssignNum.Text = "Assignment #"
        Me.lblAssignNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAssignNum
        '
        Me.txtAssignNum.Location = New System.Drawing.Point(136, 16)
        Me.txtAssignNum.Name = "txtAssignNum"
        Me.txtAssignNum.TabIndex = 4
        Me.txtAssignNum.Text = ""
        '
        'Form2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.gboxInput)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.gboxInput.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
