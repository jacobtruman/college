Public Class frmProfile
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
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtColDept As System.Windows.Forms.TextBox
    Friend WithEvents txtMajor As System.Windows.Forms.TextBox
    Friend WithEvents txtMI As System.Windows.Forms.TextBox
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents txtPhoneNum As System.Windows.Forms.TextBox
    Friend WithEvents grpStatus As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnNotAdmitted As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnAdmitted As System.Windows.Forms.RadioButton
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblColDept As System.Windows.Forms.Label
    Friend WithEvents lblMajor As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents lblPhoneNum As System.Windows.Forms.Label
    Friend WithEvents lblMI As System.Windows.Forms.Label
    Friend WithEvents lblLName As System.Windows.Forms.Label
    Friend WithEvents lblFName As System.Windows.Forms.Label
    Friend WithEvents lblMain As System.Windows.Forms.Label
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents txtUpdateInfo As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmProfile))
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.txtColDept = New System.Windows.Forms.TextBox
        Me.txtMajor = New System.Windows.Forms.TextBox
        Me.txtMI = New System.Windows.Forms.TextBox
        Me.txtLName = New System.Windows.Forms.TextBox
        Me.txtFName = New System.Windows.Forms.TextBox
        Me.txtPhoneNum = New System.Windows.Forms.TextBox
        Me.grpStatus = New System.Windows.Forms.GroupBox
        Me.rbtnNotAdmitted = New System.Windows.Forms.RadioButton
        Me.rbtnAdmitted = New System.Windows.Forms.RadioButton
        Me.lblEmail = New System.Windows.Forms.Label
        Me.lblColDept = New System.Windows.Forms.Label
        Me.lblMajor = New System.Windows.Forms.Label
        Me.lblID = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.lblPhoneNum = New System.Windows.Forms.Label
        Me.lblMI = New System.Windows.Forms.Label
        Me.lblLName = New System.Windows.Forms.Label
        Me.lblFName = New System.Windows.Forms.Label
        Me.lblMain = New System.Windows.Forms.Label
        Me.picLogo = New System.Windows.Forms.PictureBox
        Me.btnSubmit = New System.Windows.Forms.Button
        Me.txtUpdateInfo = New System.Windows.Forms.TextBox
        Me.grpStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(488, 216)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(136, 26)
        Me.txtEmail.TabIndex = 44
        Me.txtEmail.Text = ""
        '
        'txtColDept
        '
        Me.txtColDept.Location = New System.Drawing.Point(336, 216)
        Me.txtColDept.Name = "txtColDept"
        Me.txtColDept.Size = New System.Drawing.Size(136, 26)
        Me.txtColDept.TabIndex = 45
        Me.txtColDept.Text = ""
        '
        'txtMajor
        '
        Me.txtMajor.Location = New System.Drawing.Point(184, 216)
        Me.txtMajor.Name = "txtMajor"
        Me.txtMajor.Size = New System.Drawing.Size(136, 26)
        Me.txtMajor.TabIndex = 41
        Me.txtMajor.Text = ""
        '
        'txtMI
        '
        Me.txtMI.Location = New System.Drawing.Point(304, 160)
        Me.txtMI.Name = "txtMI"
        Me.txtMI.Size = New System.Drawing.Size(40, 26)
        Me.txtMI.TabIndex = 40
        Me.txtMI.Text = ""
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(160, 160)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(136, 26)
        Me.txtLName.TabIndex = 39
        Me.txtLName.Text = ""
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(16, 160)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(136, 26)
        Me.txtFName.TabIndex = 42
        Me.txtFName.Text = ""
        '
        'txtPhoneNum
        '
        Me.txtPhoneNum.Location = New System.Drawing.Point(504, 160)
        Me.txtPhoneNum.Name = "txtPhoneNum"
        Me.txtPhoneNum.Size = New System.Drawing.Size(136, 26)
        Me.txtPhoneNum.TabIndex = 43
        Me.txtPhoneNum.Text = ""
        '
        'grpStatus
        '
        Me.grpStatus.Controls.Add(Me.rbtnNotAdmitted)
        Me.grpStatus.Controls.Add(Me.rbtnAdmitted)
        Me.grpStatus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStatus.Location = New System.Drawing.Point(8, 192)
        Me.grpStatus.Name = "grpStatus"
        Me.grpStatus.Size = New System.Drawing.Size(144, 104)
        Me.grpStatus.TabIndex = 55
        Me.grpStatus.TabStop = False
        Me.grpStatus.Text = "Admission Status"
        '
        'rbtnNotAdmitted
        '
        Me.rbtnNotAdmitted.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnNotAdmitted.Location = New System.Drawing.Point(16, 72)
        Me.rbtnNotAdmitted.Name = "rbtnNotAdmitted"
        Me.rbtnNotAdmitted.Size = New System.Drawing.Size(120, 24)
        Me.rbtnNotAdmitted.TabIndex = 1
        Me.rbtnNotAdmitted.Text = "Not Admitted"
        '
        'rbtnAdmitted
        '
        Me.rbtnAdmitted.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnAdmitted.Location = New System.Drawing.Point(16, 32)
        Me.rbtnAdmitted.Name = "rbtnAdmitted"
        Me.rbtnAdmitted.Size = New System.Drawing.Size(96, 24)
        Me.rbtnAdmitted.TabIndex = 0
        Me.rbtnAdmitted.Text = "Admitted"
        '
        'lblEmail
        '
        Me.lblEmail.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(488, 192)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(56, 23)
        Me.lblEmail.TabIndex = 54
        Me.lblEmail.Text = "Email"
        '
        'lblColDept
        '
        Me.lblColDept.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColDept.Location = New System.Drawing.Point(336, 192)
        Me.lblColDept.Name = "lblColDept"
        Me.lblColDept.Size = New System.Drawing.Size(128, 23)
        Me.lblColDept.TabIndex = 53
        Me.lblColDept.Text = "College or Dept"
        '
        'lblMajor
        '
        Me.lblMajor.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMajor.Location = New System.Drawing.Point(184, 192)
        Me.lblMajor.Name = "lblMajor"
        Me.lblMajor.Size = New System.Drawing.Size(56, 23)
        Me.lblMajor.TabIndex = 52
        Me.lblMajor.Text = "Major"
        '
        'lblID
        '
        Me.lblID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(360, 136)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(144, 23)
        Me.lblID.TabIndex = 51
        Me.lblID.Text = "SSN or Student ID"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(360, 160)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(136, 26)
        Me.txtID.TabIndex = 50
        Me.txtID.Text = ""
        '
        'lblPhoneNum
        '
        Me.lblPhoneNum.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneNum.Location = New System.Drawing.Point(504, 136)
        Me.lblPhoneNum.Name = "lblPhoneNum"
        Me.lblPhoneNum.Size = New System.Drawing.Size(112, 23)
        Me.lblPhoneNum.TabIndex = 49
        Me.lblPhoneNum.Text = "Phone Number"
        '
        'lblMI
        '
        Me.lblMI.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMI.Location = New System.Drawing.Point(304, 136)
        Me.lblMI.Name = "lblMI"
        Me.lblMI.Size = New System.Drawing.Size(40, 23)
        Me.lblMI.TabIndex = 48
        Me.lblMI.Text = "M.I."
        '
        'lblLName
        '
        Me.lblLName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLName.Location = New System.Drawing.Point(160, 136)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(88, 23)
        Me.lblLName.TabIndex = 47
        Me.lblLName.Text = "Last Name"
        '
        'lblFName
        '
        Me.lblFName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFName.Location = New System.Drawing.Point(16, 136)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(88, 23)
        Me.lblFName.TabIndex = 46
        Me.lblFName.Text = "First Name"
        '
        'lblMain
        '
        Me.lblMain.Font = New System.Drawing.Font("Garamond", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.Location = New System.Drawing.Point(16, 8)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(360, 112)
        Me.lblMain.TabIndex = 67
        Me.lblMain.Text = "College of Business Undergraduate Advising Appointments System"
        '
        'picLogo
        '
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(376, 0)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(264, 136)
        Me.picLogo.TabIndex = 68
        Me.picLogo.TabStop = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.MistyRose
        Me.btnSubmit.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(512, 248)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(128, 40)
        Me.btnSubmit.TabIndex = 69
        Me.btnSubmit.Text = "Submit"
        '
        'txtUpdateInfo
        '
        Me.txtUpdateInfo.BackColor = System.Drawing.SystemColors.Info
        Me.txtUpdateInfo.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdateInfo.Location = New System.Drawing.Point(168, 248)
        Me.txtUpdateInfo.Name = "txtUpdateInfo"
        Me.txtUpdateInfo.ReadOnly = True
        Me.txtUpdateInfo.Size = New System.Drawing.Size(328, 44)
        Me.txtUpdateInfo.TabIndex = 70
        Me.txtUpdateInfo.Text = "Profile Updated"
        Me.txtUpdateInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmProfile
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 19)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(656, 301)
        Me.Controls.Add(Me.txtUpdateInfo)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtColDept)
        Me.Controls.Add(Me.txtMajor)
        Me.Controls.Add(Me.txtMI)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(Me.txtPhoneNum)
        Me.Controls.Add(Me.grpStatus)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblColDept)
        Me.Controls.Add(Me.lblMajor)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblPhoneNum)
        Me.Controls.Add(Me.lblMI)
        Me.Controls.Add(Me.lblLName)
        Me.Controls.Add(Me.lblFName)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmProfile"
        Me.Text = "COB Advising - Edit Profile"
        Me.grpStatus.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmProfile_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        clsForms.frmStudentfunctions.Visible = True
    End Sub

    Private Sub frmProfile_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsForms.frmProfile = Me
    End Sub
End Class
