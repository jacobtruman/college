Public Class frmChangeLogin
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
    Friend WithEvents btnPassword As System.Windows.Forms.Button
    Friend WithEvents btnUserName As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblOld As System.Windows.Forms.Label
    Friend WithEvents lblNew As System.Windows.Forms.Label
    Friend WithEvents txtOld As System.Windows.Forms.TextBox
    Friend WithEvents txtNew As System.Windows.Forms.TextBox
    Friend WithEvents txtConfirm As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirm As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnPassword = New System.Windows.Forms.Button
        Me.btnUserName = New System.Windows.Forms.Button
        Me.lblOld = New System.Windows.Forms.Label
        Me.lblNew = New System.Windows.Forms.Label
        Me.txtOld = New System.Windows.Forms.TextBox
        Me.txtNew = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtConfirm = New System.Windows.Forms.TextBox
        Me.lblConfirm = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnPassword
        '
        Me.btnPassword.BackColor = System.Drawing.Color.MistyRose
        Me.btnPassword.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPassword.Location = New System.Drawing.Point(24, 80)
        Me.btnPassword.Name = "btnPassword"
        Me.btnPassword.Size = New System.Drawing.Size(128, 40)
        Me.btnPassword.TabIndex = 2
        Me.btnPassword.Text = "Change Password"
        '
        'btnUserName
        '
        Me.btnUserName.BackColor = System.Drawing.Color.MistyRose
        Me.btnUserName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserName.Location = New System.Drawing.Point(24, 16)
        Me.btnUserName.Name = "btnUserName"
        Me.btnUserName.Size = New System.Drawing.Size(128, 40)
        Me.btnUserName.TabIndex = 3
        Me.btnUserName.Text = "Change Username"
        '
        'lblOld
        '
        Me.lblOld.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOld.Location = New System.Drawing.Point(192, 8)
        Me.lblOld.Name = "lblOld"
        Me.lblOld.TabIndex = 4
        Me.lblOld.Text = "Old"
        '
        'lblNew
        '
        Me.lblNew.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNew.Location = New System.Drawing.Point(192, 72)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.TabIndex = 5
        Me.lblNew.Text = "New"
        '
        'txtOld
        '
        Me.txtOld.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOld.Location = New System.Drawing.Point(192, 32)
        Me.txtOld.Name = "txtOld"
        Me.txtOld.Size = New System.Drawing.Size(208, 26)
        Me.txtOld.TabIndex = 6
        Me.txtOld.Text = ""
        '
        'txtNew
        '
        Me.txtNew.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNew.Location = New System.Drawing.Point(192, 96)
        Me.txtNew.Name = "txtNew"
        Me.txtNew.Size = New System.Drawing.Size(208, 26)
        Me.txtNew.TabIndex = 7
        Me.txtNew.Text = ""
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MistyRose
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(24, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 40)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Submit"
        '
        'txtConfirm
        '
        Me.txtConfirm.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirm.Location = New System.Drawing.Point(192, 160)
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.Size = New System.Drawing.Size(208, 26)
        Me.txtConfirm.TabIndex = 10
        Me.txtConfirm.Text = ""
        '
        'lblConfirm
        '
        Me.lblConfirm.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirm.Location = New System.Drawing.Point(192, 136)
        Me.lblConfirm.Name = "lblConfirm"
        Me.lblConfirm.Size = New System.Drawing.Size(104, 23)
        Me.lblConfirm.TabIndex = 9
        Me.lblConfirm.Text = "Confirm New"
        '
        'frmChangeLogin
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(432, 197)
        Me.Controls.Add(Me.txtConfirm)
        Me.Controls.Add(Me.lblConfirm)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtNew)
        Me.Controls.Add(Me.txtOld)
        Me.Controls.Add(Me.lblNew)
        Me.Controls.Add(Me.lblOld)
        Me.Controls.Add(Me.btnUserName)
        Me.Controls.Add(Me.btnPassword)
        Me.Name = "frmChangeLogin"
        Me.Text = "COB Advising - Change Login"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnUserName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserName.Click
        lblOld.Text = "Old Username"
        lblNew.Text = "New Username"
        lblConfirm.Text = "Confirm New Username"
    End Sub

    Private Sub btnPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPassword.Click
        lblOld.Text = "Old Password"
        lblNew.Text = "New Password"
        lblConfirm.Text = "Confirm New Password"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("Updated")
        Me.Close()
    End Sub

    Private Sub frmChangeLogin_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        clsForms.frmLogin.Visible = True
    End Sub

    Private Sub frmChangeLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsForms.frmChangeLogin = Me
    End Sub
End Class
