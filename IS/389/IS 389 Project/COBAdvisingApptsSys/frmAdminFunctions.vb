Public Class frmAdminFunctions
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
    Friend WithEvents lblAdminFunctions As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnTime As System.Windows.Forms.Button
    Friend WithEvents btnManageUsers As System.Windows.Forms.Button
    Friend WithEvents btnChangeDB As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblAdminFunctions = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnTime = New System.Windows.Forms.Button
        Me.btnManageUsers = New System.Windows.Forms.Button
        Me.btnChangeDB = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblAdminFunctions
        '
        Me.lblAdminFunctions.Font = New System.Drawing.Font("Garamond", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdminFunctions.Location = New System.Drawing.Point(6, 16)
        Me.lblAdminFunctions.Name = "lblAdminFunctions"
        Me.lblAdminFunctions.Size = New System.Drawing.Size(280, 32)
        Me.lblAdminFunctions.TabIndex = 18
        Me.lblAdminFunctions.Text = "Admin Functions"
        Me.lblAdminFunctions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.MistyRose
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(62, 272)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(168, 56)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "Exit System"
        '
        'btnTime
        '
        Me.btnTime.BackColor = System.Drawing.Color.MistyRose
        Me.btnTime.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTime.Location = New System.Drawing.Point(62, 128)
        Me.btnTime.Name = "btnTime"
        Me.btnTime.Size = New System.Drawing.Size(168, 56)
        Me.btnTime.TabIndex = 16
        Me.btnTime.Text = "Manage        Time Blocks"
        '
        'btnManageUsers
        '
        Me.btnManageUsers.BackColor = System.Drawing.Color.MistyRose
        Me.btnManageUsers.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageUsers.Location = New System.Drawing.Point(62, 56)
        Me.btnManageUsers.Name = "btnManageUsers"
        Me.btnManageUsers.Size = New System.Drawing.Size(168, 56)
        Me.btnManageUsers.TabIndex = 15
        Me.btnManageUsers.Text = "Manage Users"
        '
        'btnChangeDB
        '
        Me.btnChangeDB.BackColor = System.Drawing.Color.MistyRose
        Me.btnChangeDB.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeDB.Location = New System.Drawing.Point(64, 200)
        Me.btnChangeDB.Name = "btnChangeDB"
        Me.btnChangeDB.Size = New System.Drawing.Size(168, 56)
        Me.btnChangeDB.TabIndex = 19
        Me.btnChangeDB.Text = "Change           DB Directory"
        '
        'frmAdminFunctions
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(292, 341)
        Me.Controls.Add(Me.btnChangeDB)
        Me.Controls.Add(Me.lblAdminFunctions)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnTime)
        Me.Controls.Add(Me.btnManageUsers)
        Me.Name = "frmAdminFunctions"
        Me.Text = "COB Advising - Admin Functions"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAdminFunctions_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsForms.frmAdminFunctions = Me
    End Sub

    Private Sub btnManageUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManageUsers.Click

        Dim frmManageUsers As New frmManageUsers
        frmManageUsers.Show()
        Me.Visible = False

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmAdminFunctions_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        clsForms.frmLogin.Visible = True
    End Sub

    Private Sub btnTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTime.Click

        Dim frmTimeBlocks As New frmTimeBlocks
        frmTimeBlocks.Show()
        Me.Visible = False

    End Sub

End Class
