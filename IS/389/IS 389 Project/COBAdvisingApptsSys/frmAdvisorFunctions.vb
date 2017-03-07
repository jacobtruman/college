Public Class frmAdvisorFunctions
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
    Friend WithEvents lblAdvisorFunctions As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnVPAppointments As System.Windows.Forms.Button
    Friend WithEvents btnManageSchedule As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblAdvisorFunctions = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnVPAppointments = New System.Windows.Forms.Button
        Me.btnManageSchedule = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblAdvisorFunctions
        '
        Me.lblAdvisorFunctions.Font = New System.Drawing.Font("Garamond", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdvisorFunctions.Location = New System.Drawing.Point(6, 16)
        Me.lblAdvisorFunctions.Name = "lblAdvisorFunctions"
        Me.lblAdvisorFunctions.Size = New System.Drawing.Size(280, 32)
        Me.lblAdvisorFunctions.TabIndex = 18
        Me.lblAdvisorFunctions.Text = "Advisor Functions"
        Me.lblAdvisorFunctions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.MistyRose
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(62, 200)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(168, 56)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "Exit System"
        '
        'btnVPAppointments
        '
        Me.btnVPAppointments.BackColor = System.Drawing.Color.MistyRose
        Me.btnVPAppointments.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVPAppointments.Location = New System.Drawing.Point(62, 128)
        Me.btnVPAppointments.Name = "btnVPAppointments"
        Me.btnVPAppointments.Size = New System.Drawing.Size(168, 56)
        Me.btnVPAppointments.TabIndex = 16
        Me.btnVPAppointments.Text = "View/Print Appointments"
        '
        'btnManageSchedule
        '
        Me.btnManageSchedule.BackColor = System.Drawing.Color.MistyRose
        Me.btnManageSchedule.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageSchedule.Location = New System.Drawing.Point(62, 56)
        Me.btnManageSchedule.Name = "btnManageSchedule"
        Me.btnManageSchedule.Size = New System.Drawing.Size(168, 56)
        Me.btnManageSchedule.TabIndex = 15
        Me.btnManageSchedule.Text = "Manage Schedule"
        '
        'frmAdvisorFunctions
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.lblAdvisorFunctions)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnVPAppointments)
        Me.Controls.Add(Me.btnManageSchedule)
        Me.Name = "frmAdvisorFunctions"
        Me.Text = "COB Advising - Advisor Functions"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnManageSchedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManageSchedule.Click

        ' Open the advisor's schedule management form
        Dim frmAdvisor As New frmAdvisor
        frmAdvisor.Show()
        Me.Visible = False ' Make Advisor Functions form invisible

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close Advisor Functions form
        Me.Close()
    End Sub

    Private Sub frmAdvisorFunctions_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        ' Reset public shared variables
        Username = ""
        Permission = ""
        clsForms.frmLogin.Visible = True ' Make the Login form visible

    End Sub

    Private Sub frmAdvisorFunctions_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsForms.frmAdvisorFunctions = Me
    End Sub

    Private Sub btnVPAppointments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVPAppointments.Click

        Dim frmVPAppointments As New frmVPAppointments
        frmVPAppointments.Show()
        Me.Visible = False

    End Sub

End Class
