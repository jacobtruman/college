Public Class frmStaffFunctions
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
    Friend WithEvents lblStaffFunctions As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnMakeAppt As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblStaffFunctions = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnMakeAppt = New System.Windows.Forms.Button
        Me.btnView = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblStaffFunctions
        '
        Me.lblStaffFunctions.Font = New System.Drawing.Font("Garamond", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffFunctions.Location = New System.Drawing.Point(6, 16)
        Me.lblStaffFunctions.Name = "lblStaffFunctions"
        Me.lblStaffFunctions.Size = New System.Drawing.Size(280, 32)
        Me.lblStaffFunctions.TabIndex = 18
        Me.lblStaffFunctions.Text = "Staff Functions"
        Me.lblStaffFunctions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.MistyRose
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(64, 272)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(168, 56)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "Exit System"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.MistyRose
        Me.btnAdd.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(62, 128)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(168, 56)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "Add Student"
        '
        'btnMakeAppt
        '
        Me.btnMakeAppt.BackColor = System.Drawing.Color.MistyRose
        Me.btnMakeAppt.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMakeAppt.Location = New System.Drawing.Point(62, 56)
        Me.btnMakeAppt.Name = "btnMakeAppt"
        Me.btnMakeAppt.Size = New System.Drawing.Size(168, 56)
        Me.btnMakeAppt.TabIndex = 15
        Me.btnMakeAppt.Text = "Make Appointment"
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.MistyRose
        Me.btnView.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Location = New System.Drawing.Point(64, 200)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(168, 56)
        Me.btnView.TabIndex = 19
        Me.btnView.Text = "Appointment Preparation"
        '
        'frmStaffFunctions
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(292, 341)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.lblStaffFunctions)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnMakeAppt)
        Me.Name = "frmStaffFunctions"
        Me.Text = "COB Advising - Staff Functions"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmStaffFunctions_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsForms.frmStaffFunctions = Me
        aStaff = False
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnMakeAppt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMakeAppt.Click

        aStaff = True

        Dim frmAppointment As New frmAppointment
        frmAppointment.Show()
        Me.Visible = False

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        aStaff = True

        ' Open the New Registration form
        Dim frmNewRegister As New frmNewRegister
        frmNewRegister.Show()
        Me.Visible = False ' Make the Staff Functions form invisible

    End Sub

    Private Sub frmStaffFunctions_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        aStaff = False
        clsForms.frmLogin.Visible = True
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click

    End Sub
End Class
