Public Class frmAdvisor
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
    Friend WithEvents dtpAppointment As System.Windows.Forms.DateTimePicker
    Friend WithEvents calAppointment As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dtpAppointment = New System.Windows.Forms.DateTimePicker
        Me.calAppointment = New System.Windows.Forms.MonthCalendar
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'dtpAppointment
        '
        Me.dtpAppointment.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAppointment.Location = New System.Drawing.Point(16, 216)
        Me.dtpAppointment.Name = "dtpAppointment"
        Me.dtpAppointment.Size = New System.Drawing.Size(272, 26)
        Me.dtpAppointment.TabIndex = 31
        '
        'calAppointment
        '
        Me.calAppointment.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calAppointment.Location = New System.Drawing.Point(16, 248)
        Me.calAppointment.Name = "calAppointment"
        Me.calAppointment.TabIndex = 30
        Me.calAppointment.TitleBackColor = System.Drawing.Color.Red
        Me.calAppointment.TitleForeColor = System.Drawing.SystemColors.WindowText
        Me.calAppointment.TrailingForeColor = System.Drawing.SystemColors.InactiveCaptionText
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(152, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(344, 88)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Advisor appointments management area"
        '
        'frmAdvisor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(696, 477)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpAppointment)
        Me.Controls.Add(Me.calAppointment)
        Me.Name = "frmAdvisor"
        Me.Text = "frmAdvisor"
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
