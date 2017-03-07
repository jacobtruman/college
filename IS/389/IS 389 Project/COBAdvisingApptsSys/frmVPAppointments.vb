Public Class frmVPAppointments
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dtpAppointment = New System.Windows.Forms.DateTimePicker
        Me.calAppointment = New System.Windows.Forms.MonthCalendar
        Me.SuspendLayout()
        '
        'dtpAppointment
        '
        Me.dtpAppointment.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAppointment.Location = New System.Drawing.Point(16, 200)
        Me.dtpAppointment.Name = "dtpAppointment"
        Me.dtpAppointment.Size = New System.Drawing.Size(240, 26)
        Me.dtpAppointment.TabIndex = 33
        '
        'calAppointment
        '
        Me.calAppointment.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calAppointment.Location = New System.Drawing.Point(16, 232)
        Me.calAppointment.Name = "calAppointment"
        Me.calAppointment.TabIndex = 32
        Me.calAppointment.TitleBackColor = System.Drawing.Color.Red
        Me.calAppointment.TitleForeColor = System.Drawing.SystemColors.WindowText
        Me.calAppointment.TrailingForeColor = System.Drawing.SystemColors.InactiveCaptionText
        '
        'frmVPAppointments
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(672, 462)
        Me.Controls.Add(Me.dtpAppointment)
        Me.Controls.Add(Me.calAppointment)
        Me.Name = "frmVPAppointments"
        Me.Text = "frmVPAppointments"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmVPAppointments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsForms.frmVPAppointments = Me
    End Sub

    Private Sub frmVPAppointments_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        clsForms.frmAdvisorFunctions.Visible = True
    End Sub
End Class
