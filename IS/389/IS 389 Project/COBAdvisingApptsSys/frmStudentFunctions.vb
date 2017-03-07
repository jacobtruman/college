Public Class frmStudentFunctions
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
    Friend WithEvents btnMakeAppt As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblStudentFunctions As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnMakeAppt = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblStudentFunctions = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnMakeAppt
        '
        Me.btnMakeAppt.BackColor = System.Drawing.Color.MistyRose
        Me.btnMakeAppt.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMakeAppt.Location = New System.Drawing.Point(64, 56)
        Me.btnMakeAppt.Name = "btnMakeAppt"
        Me.btnMakeAppt.Size = New System.Drawing.Size(168, 56)
        Me.btnMakeAppt.TabIndex = 11
        Me.btnMakeAppt.Text = "Make Appointment"
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.MistyRose
        Me.btnEdit.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(64, 128)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(168, 56)
        Me.btnEdit.TabIndex = 12
        Me.btnEdit.Text = "Edit My Account Profile"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.MistyRose
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(64, 200)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(168, 56)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit System"
        '
        'lblStudentFunctions
        '
        Me.lblStudentFunctions.Font = New System.Drawing.Font("Garamond", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentFunctions.Location = New System.Drawing.Point(8, 16)
        Me.lblStudentFunctions.Name = "lblStudentFunctions"
        Me.lblStudentFunctions.Size = New System.Drawing.Size(280, 32)
        Me.lblStudentFunctions.TabIndex = 14
        Me.lblStudentFunctions.Text = "Student Functions"
        Me.lblStudentFunctions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmStudentFunctions
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.lblStudentFunctions)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnMakeAppt)
        Me.Name = "frmStudentFunctions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Functions"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmStudentFunctions_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        Username = ""
        Permission = ""
        aStudent = False
        clsForms.frmLogin.Visible = True

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnMakeAppt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMakeAppt.Click

        aStudent = True

        Dim frmAppointment As New frmAppointment
        frmAppointment.Show()
        Me.Visible = False

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        aStudent = True

        Dim frmProfile As New frmProfile
        frmProfile.Show()
        Me.Visible = False

    End Sub

    Private Sub frmStudentFunctions_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        aStudent = False
        clsForms.frmStudentfunctions = Me
    End Sub
End Class
