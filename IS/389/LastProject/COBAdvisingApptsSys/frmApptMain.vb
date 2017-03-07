Public Class frmApptMain
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
    Friend WithEvents lblMain As System.Windows.Forms.Label
    Friend WithEvents lblMainMsg As System.Windows.Forms.Label
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents txtMI As System.Windows.Forms.TextBox
    Friend WithEvents txtMajor As System.Windows.Forms.TextBox
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents txtPhoneNum As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtColDept As System.Windows.Forms.TextBox
    Friend WithEvents lblFName As System.Windows.Forms.Label
    Friend WithEvents lblLName As System.Windows.Forms.Label
    Friend WithEvents lblMI As System.Windows.Forms.Label
    Friend WithEvents lblPhoneNum As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents txtInstructions As System.Windows.Forms.TextBox
    Friend WithEvents lblMajor As System.Windows.Forms.Label
    Friend WithEvents lblColDept As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents grpStatus As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnAdmitted As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnNotAdmitted As System.Windows.Forms.RadioButton
    Friend WithEvents grpAppointment As System.Windows.Forms.GroupBox
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents lblReq1 As System.Windows.Forms.Label
    Friend WithEvents lblRequired As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents calAppointment As System.Windows.Forms.MonthCalendar
    Friend WithEvents dtpAppointment As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblAdvisor As System.Windows.Forms.Label
    Friend WithEvents cbxAdvisor As System.Windows.Forms.ComboBox
    Friend WithEvents lblConfirm As System.Windows.Forms.TextBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents cbxReason As System.Windows.Forms.ComboBox
    Friend WithEvents lblReason As System.Windows.Forms.Label
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents lblComments As System.Windows.Forms.Label
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmApptMain))
        Me.lblMain = New System.Windows.Forms.Label
        Me.lblMainMsg = New System.Windows.Forms.Label
        Me.txtLName = New System.Windows.Forms.TextBox
        Me.txtMI = New System.Windows.Forms.TextBox
        Me.txtMajor = New System.Windows.Forms.TextBox
        Me.txtFName = New System.Windows.Forms.TextBox
        Me.txtPhoneNum = New System.Windows.Forms.TextBox
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.txtColDept = New System.Windows.Forms.TextBox
        Me.lblFName = New System.Windows.Forms.Label
        Me.lblLName = New System.Windows.Forms.Label
        Me.lblMI = New System.Windows.Forms.Label
        Me.lblPhoneNum = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.lblID = New System.Windows.Forms.Label
        Me.txtInstructions = New System.Windows.Forms.TextBox
        Me.lblMajor = New System.Windows.Forms.Label
        Me.lblColDept = New System.Windows.Forms.Label
        Me.lblEmail = New System.Windows.Forms.Label
        Me.grpStatus = New System.Windows.Forms.GroupBox
        Me.rbtnNotAdmitted = New System.Windows.Forms.RadioButton
        Me.rbtnAdmitted = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.grpAppointment = New System.Windows.Forms.GroupBox
        Me.btnSelect = New System.Windows.Forms.Button
        Me.btnFirst = New System.Windows.Forms.Button
        Me.lblReq1 = New System.Windows.Forms.Label
        Me.lblRequired = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.calAppointment = New System.Windows.Forms.MonthCalendar
        Me.dtpAppointment = New System.Windows.Forms.DateTimePicker
        Me.lblAdvisor = New System.Windows.Forms.Label
        Me.cbxAdvisor = New System.Windows.Forms.ComboBox
        Me.lblConfirm = New System.Windows.Forms.TextBox
        Me.btnSubmit = New System.Windows.Forms.Button
        Me.cbxReason = New System.Windows.Forms.ComboBox
        Me.lblReason = New System.Windows.Forms.Label
        Me.txtComments = New System.Windows.Forms.TextBox
        Me.lblComments = New System.Windows.Forms.Label
        Me.picLogo = New System.Windows.Forms.PictureBox
        Me.grpStatus.SuspendLayout()
        Me.grpAppointment.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMain
        '
        Me.lblMain.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMain.Font = New System.Drawing.Font("Garamond", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.Location = New System.Drawing.Point(16, 8)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(360, 112)
        Me.lblMain.TabIndex = 0
        Me.lblMain.Text = "College of Business Undergraduate Advising Appointments System"
        '
        'lblMainMsg
        '
        Me.lblMainMsg.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMainMsg.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainMsg.Location = New System.Drawing.Point(640, 8)
        Me.lblMainMsg.Name = "lblMainMsg"
        Me.lblMainMsg.Size = New System.Drawing.Size(360, 112)
        Me.lblMainMsg.TabIndex = 1
        Me.lblMainMsg.Text = "Attention! Messages Go Here. No appointments necessary to drop off signed documen" & _
        "ts."
        Me.lblMainMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(328, 312)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(136, 26)
        Me.txtLName.TabIndex = 3
        Me.txtLName.Text = ""
        '
        'txtMI
        '
        Me.txtMI.Location = New System.Drawing.Point(480, 312)
        Me.txtMI.Name = "txtMI"
        Me.txtMI.Size = New System.Drawing.Size(40, 26)
        Me.txtMI.TabIndex = 4
        Me.txtMI.Text = ""
        '
        'txtMajor
        '
        Me.txtMajor.Location = New System.Drawing.Point(536, 312)
        Me.txtMajor.Name = "txtMajor"
        Me.txtMajor.Size = New System.Drawing.Size(136, 26)
        Me.txtMajor.TabIndex = 5
        Me.txtMajor.Text = ""
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(176, 312)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(136, 26)
        Me.txtFName.TabIndex = 6
        Me.txtFName.Text = ""
        '
        'txtPhoneNum
        '
        Me.txtPhoneNum.Location = New System.Drawing.Point(176, 368)
        Me.txtPhoneNum.Name = "txtPhoneNum"
        Me.txtPhoneNum.Size = New System.Drawing.Size(136, 26)
        Me.txtPhoneNum.TabIndex = 7
        Me.txtPhoneNum.Text = ""
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(176, 424)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(136, 26)
        Me.txtEmail.TabIndex = 8
        Me.txtEmail.Text = ""
        '
        'txtColDept
        '
        Me.txtColDept.Location = New System.Drawing.Point(688, 312)
        Me.txtColDept.Name = "txtColDept"
        Me.txtColDept.Size = New System.Drawing.Size(136, 26)
        Me.txtColDept.TabIndex = 9
        Me.txtColDept.Text = ""
        '
        'lblFName
        '
        Me.lblFName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFName.Location = New System.Drawing.Point(176, 288)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(88, 23)
        Me.lblFName.TabIndex = 10
        Me.lblFName.Text = "First Name"
        '
        'lblLName
        '
        Me.lblLName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLName.Location = New System.Drawing.Point(328, 288)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(88, 23)
        Me.lblLName.TabIndex = 11
        Me.lblLName.Text = "Last Name"
        '
        'lblMI
        '
        Me.lblMI.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMI.Location = New System.Drawing.Point(480, 288)
        Me.lblMI.Name = "lblMI"
        Me.lblMI.Size = New System.Drawing.Size(40, 23)
        Me.lblMI.TabIndex = 12
        Me.lblMI.Text = "M.I."
        '
        'lblPhoneNum
        '
        Me.lblPhoneNum.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneNum.Location = New System.Drawing.Point(176, 344)
        Me.lblPhoneNum.Name = "lblPhoneNum"
        Me.lblPhoneNum.Size = New System.Drawing.Size(112, 23)
        Me.lblPhoneNum.TabIndex = 13
        Me.lblPhoneNum.Text = "Phone Number"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(328, 368)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(136, 26)
        Me.txtID.TabIndex = 14
        Me.txtID.Text = ""
        '
        'lblID
        '
        Me.lblID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(328, 344)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(144, 23)
        Me.lblID.TabIndex = 15
        Me.lblID.Text = "SSN or Student ID"
        '
        'txtInstructions
        '
        Me.txtInstructions.BackColor = System.Drawing.SystemColors.Info
        Me.txtInstructions.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstructions.Location = New System.Drawing.Point(16, 136)
        Me.txtInstructions.Multiline = True
        Me.txtInstructions.Name = "txtInstructions"
        Me.txtInstructions.ReadOnly = True
        Me.txtInstructions.Size = New System.Drawing.Size(984, 144)
        Me.txtInstructions.TabIndex = 16
        Me.txtInstructions.Text = "1) Instructions go here. 2) How to use this system. 3) First time users of this s" & _
        "ystem must..."
        '
        'lblMajor
        '
        Me.lblMajor.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMajor.Location = New System.Drawing.Point(536, 288)
        Me.lblMajor.Name = "lblMajor"
        Me.lblMajor.Size = New System.Drawing.Size(56, 23)
        Me.lblMajor.TabIndex = 17
        Me.lblMajor.Text = "Major"
        '
        'lblColDept
        '
        Me.lblColDept.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColDept.Location = New System.Drawing.Point(688, 288)
        Me.lblColDept.Name = "lblColDept"
        Me.lblColDept.Size = New System.Drawing.Size(128, 23)
        Me.lblColDept.TabIndex = 18
        Me.lblColDept.Text = "College or Dept"
        '
        'lblEmail
        '
        Me.lblEmail.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(176, 400)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(56, 23)
        Me.lblEmail.TabIndex = 19
        Me.lblEmail.Text = "Email"
        '
        'grpStatus
        '
        Me.grpStatus.Controls.Add(Me.rbtnNotAdmitted)
        Me.grpStatus.Controls.Add(Me.rbtnAdmitted)
        Me.grpStatus.Controls.Add(Me.Label5)
        Me.grpStatus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStatus.Location = New System.Drawing.Point(16, 336)
        Me.grpStatus.Name = "grpStatus"
        Me.grpStatus.Size = New System.Drawing.Size(144, 104)
        Me.grpStatus.TabIndex = 20
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
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(8, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 16)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "*"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'grpAppointment
        '
        Me.grpAppointment.Controls.Add(Me.btnSelect)
        Me.grpAppointment.Controls.Add(Me.btnFirst)
        Me.grpAppointment.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAppointment.Location = New System.Drawing.Point(840, 288)
        Me.grpAppointment.Name = "grpAppointment"
        Me.grpAppointment.Size = New System.Drawing.Size(160, 120)
        Me.grpAppointment.TabIndex = 21
        Me.grpAppointment.TabStop = False
        Me.grpAppointment.Text = "Make Appointment"
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.MistyRose
        Me.btnSelect.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.Location = New System.Drawing.Point(16, 72)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(128, 40)
        Me.btnSelect.TabIndex = 1
        Me.btnSelect.Text = "Select Advisor"
        '
        'btnFirst
        '
        Me.btnFirst.BackColor = System.Drawing.Color.MistyRose
        Me.btnFirst.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirst.Location = New System.Drawing.Point(16, 24)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(128, 40)
        Me.btnFirst.TabIndex = 0
        Me.btnFirst.Text = "First Available"
        '
        'lblReq1
        '
        Me.lblReq1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReq1.ForeColor = System.Drawing.Color.Red
        Me.lblReq1.Location = New System.Drawing.Point(136, 296)
        Me.lblReq1.Name = "lblReq1"
        Me.lblReq1.Size = New System.Drawing.Size(16, 16)
        Me.lblReq1.TabIndex = 22
        Me.lblReq1.Text = "*"
        Me.lblReq1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblRequired
        '
        Me.lblRequired.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRequired.Location = New System.Drawing.Point(24, 296)
        Me.lblRequired.Name = "lblRequired"
        Me.lblRequired.Size = New System.Drawing.Size(112, 23)
        Me.lblRequired.TabIndex = 23
        Me.lblRequired.Text = "Required Field"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(160, 312)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "*"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(312, 312)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 16)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "*"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(464, 312)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 16)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "*"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(160, 368)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "*"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'calAppointment
        '
        Me.calAppointment.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calAppointment.Location = New System.Drawing.Point(16, 488)
        Me.calAppointment.Name = "calAppointment"
        Me.calAppointment.TabIndex = 28
        Me.calAppointment.TitleBackColor = System.Drawing.Color.Red
        Me.calAppointment.TitleForeColor = System.Drawing.SystemColors.WindowText
        Me.calAppointment.TrailingForeColor = System.Drawing.SystemColors.InactiveCaptionText
        '
        'dtpAppointment
        '
        Me.dtpAppointment.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAppointment.Location = New System.Drawing.Point(16, 456)
        Me.dtpAppointment.Name = "dtpAppointment"
        Me.dtpAppointment.Size = New System.Drawing.Size(272, 26)
        Me.dtpAppointment.TabIndex = 29
        '
        'lblAdvisor
        '
        Me.lblAdvisor.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdvisor.Location = New System.Drawing.Point(296, 496)
        Me.lblAdvisor.Name = "lblAdvisor"
        Me.lblAdvisor.Size = New System.Drawing.Size(152, 24)
        Me.lblAdvisor.TabIndex = 30
        Me.lblAdvisor.Text = "Select Advisor:"
        Me.lblAdvisor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbxAdvisor
        '
        Me.cbxAdvisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxAdvisor.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxAdvisor.Location = New System.Drawing.Point(448, 488)
        Me.cbxAdvisor.Name = "cbxAdvisor"
        Me.cbxAdvisor.Size = New System.Drawing.Size(376, 32)
        Me.cbxAdvisor.TabIndex = 31
        '
        'lblConfirm
        '
        Me.lblConfirm.BackColor = System.Drawing.SystemColors.Info
        Me.lblConfirm.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirm.Location = New System.Drawing.Point(304, 528)
        Me.lblConfirm.Multiline = True
        Me.lblConfirm.Name = "lblConfirm"
        Me.lblConfirm.ReadOnly = True
        Me.lblConfirm.Size = New System.Drawing.Size(696, 176)
        Me.lblConfirm.TabIndex = 32
        Me.lblConfirm.Text = "Any final instructions and appointment confirmation go here. 1) A confirmation em" & _
        "ail has been sent to you. 2) Print this page for your records...etc."
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.MistyRose
        Me.btnSubmit.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(856, 480)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(128, 40)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit"
        '
        'cbxReason
        '
        Me.cbxReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxReason.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxReason.Location = New System.Drawing.Point(664, 368)
        Me.cbxReason.Name = "cbxReason"
        Me.cbxReason.Size = New System.Drawing.Size(160, 27)
        Me.cbxReason.TabIndex = 33
        '
        'lblReason
        '
        Me.lblReason.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReason.Location = New System.Drawing.Point(480, 368)
        Me.lblReason.Name = "lblReason"
        Me.lblReason.Size = New System.Drawing.Size(192, 23)
        Me.lblReason.TabIndex = 34
        Me.lblReason.Text = "Reason for Appointment:"
        Me.lblReason.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(328, 424)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(672, 48)
        Me.txtComments.TabIndex = 35
        Me.txtComments.Text = ""
        '
        'lblComments
        '
        Me.lblComments.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComments.Location = New System.Drawing.Point(336, 400)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(88, 23)
        Me.lblComments.TabIndex = 36
        Me.lblComments.Text = "Comments"
        '
        'picLogo
        '
        Me.picLogo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(376, 0)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(264, 136)
        Me.picLogo.TabIndex = 37
        Me.picLogo.TabStop = False
        '
        'frmApptMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 19)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1016, 713)
        Me.Controls.Add(Me.cbxAdvisor)
        Me.Controls.Add(Me.cbxReason)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtColDept)
        Me.Controls.Add(Me.txtMajor)
        Me.Controls.Add(Me.txtMI)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(Me.txtPhoneNum)
        Me.Controls.Add(Me.txtComments)
        Me.Controls.Add(Me.lblComments)
        Me.Controls.Add(Me.lblReason)
        Me.Controls.Add(Me.lblConfirm)
        Me.Controls.Add(Me.dtpAppointment)
        Me.Controls.Add(Me.calAppointment)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblRequired)
        Me.Controls.Add(Me.lblReq1)
        Me.Controls.Add(Me.grpStatus)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblColDept)
        Me.Controls.Add(Me.lblMajor)
        Me.Controls.Add(Me.txtInstructions)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblPhoneNum)
        Me.Controls.Add(Me.lblMI)
        Me.Controls.Add(Me.lblLName)
        Me.Controls.Add(Me.lblFName)
        Me.Controls.Add(Me.lblMainMsg)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.grpAppointment)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblAdvisor)
        Me.Controls.Add(Me.picLogo)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmApptMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COB Advising Appointments - Main Page"
        Me.grpStatus.ResumeLayout(False)
        Me.grpAppointment.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim Login As New frmTempLogin
        Login.Show()
    End Sub

End Class
