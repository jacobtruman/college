Imports System.Data.OleDb

Public Class frmAppointment
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
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblMainMsg As System.Windows.Forms.Label
    Friend WithEvents cbxAdvisor As System.Windows.Forms.ComboBox
    Friend WithEvents cbxReason As System.Windows.Forms.ComboBox
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents lblComments As System.Windows.Forms.Label
    Friend WithEvents lblReason As System.Windows.Forms.Label
    Friend WithEvents calAppointment As System.Windows.Forms.MonthCalendar
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents lblAdvisor As System.Windows.Forms.Label
    Friend WithEvents lblD0Tm0 As System.Windows.Forms.Label
    Friend WithEvents lblD0Tm1 As System.Windows.Forms.Label
    Friend WithEvents lblD0Tm2 As System.Windows.Forms.Label
    Friend WithEvents lblD0Tm3 As System.Windows.Forms.Label
    Friend WithEvents lblD0Tm4 As System.Windows.Forms.Label
    Friend WithEvents lblD0Tm5 As System.Windows.Forms.Label
    Friend WithEvents lblD0Tm6 As System.Windows.Forms.Label
    Friend WithEvents lblD0Tm7 As System.Windows.Forms.Label
    Friend WithEvents lblD0Tm8 As System.Windows.Forms.Label
    Friend WithEvents lblD0Tm9 As System.Windows.Forms.Label
    Friend WithEvents lblD0Tm10 As System.Windows.Forms.Label
    Friend WithEvents lblD0Tm11 As System.Windows.Forms.Label
    Friend WithEvents lblD0Tm12 As System.Windows.Forms.Label
    Friend WithEvents lblD0Tm13 As System.Windows.Forms.Label
    Friend WithEvents lblD0Tm14 As System.Windows.Forms.Label
    Friend WithEvents lblD0Tm15 As System.Windows.Forms.Label
    Friend WithEvents lblD0Tm16 As System.Windows.Forms.Label
    Friend WithEvents lblD0Tm17 As System.Windows.Forms.Label
    Friend WithEvents lblD1Tm0 As System.Windows.Forms.Label
    Friend WithEvents lblD1Tm1 As System.Windows.Forms.Label
    Friend WithEvents lblD1Tm2 As System.Windows.Forms.Label
    Friend WithEvents lblD1Tm3 As System.Windows.Forms.Label
    Friend WithEvents lblD1Tm4 As System.Windows.Forms.Label
    Friend WithEvents lblD1Tm5 As System.Windows.Forms.Label
    Friend WithEvents lblD1Tm6 As System.Windows.Forms.Label
    Friend WithEvents lblD1Tm7 As System.Windows.Forms.Label
    Friend WithEvents lblD1Tm8 As System.Windows.Forms.Label
    Friend WithEvents lblD1Tm9 As System.Windows.Forms.Label
    Friend WithEvents lblD1Tm10 As System.Windows.Forms.Label
    Friend WithEvents lblD1Tm11 As System.Windows.Forms.Label
    Friend WithEvents lblD1Tm12 As System.Windows.Forms.Label
    Friend WithEvents lblD1Tm13 As System.Windows.Forms.Label
    Friend WithEvents lblD1Tm14 As System.Windows.Forms.Label
    Friend WithEvents lblD1Tm15 As System.Windows.Forms.Label
    Friend WithEvents lblD1Tm16 As System.Windows.Forms.Label
    Friend WithEvents lblD1Tm17 As System.Windows.Forms.Label
    Friend WithEvents lblD2Tm0 As System.Windows.Forms.Label
    Friend WithEvents lblD2Tm1 As System.Windows.Forms.Label
    Friend WithEvents lblD2Tm2 As System.Windows.Forms.Label
    Friend WithEvents lblD2Tm3 As System.Windows.Forms.Label
    Friend WithEvents lblD2Tm4 As System.Windows.Forms.Label
    Friend WithEvents lblD2Tm5 As System.Windows.Forms.Label
    Friend WithEvents lblD2Tm6 As System.Windows.Forms.Label
    Friend WithEvents lblD2Tm7 As System.Windows.Forms.Label
    Friend WithEvents lblD2Tm8 As System.Windows.Forms.Label
    Friend WithEvents lblD2Tm9 As System.Windows.Forms.Label
    Friend WithEvents lblD2Tm10 As System.Windows.Forms.Label
    Friend WithEvents lblD2Tm11 As System.Windows.Forms.Label
    Friend WithEvents lblD2Tm12 As System.Windows.Forms.Label
    Friend WithEvents lblD2Tm13 As System.Windows.Forms.Label
    Friend WithEvents lblD2Tm14 As System.Windows.Forms.Label
    Friend WithEvents lblD2Tm15 As System.Windows.Forms.Label
    Friend WithEvents lblD2Tm16 As System.Windows.Forms.Label
    Friend WithEvents lblD2Tm17 As System.Windows.Forms.Label
    Friend WithEvents lblD3Tm0 As System.Windows.Forms.Label
    Friend WithEvents lblD3Tm1 As System.Windows.Forms.Label
    Friend WithEvents lblD3Tm2 As System.Windows.Forms.Label
    Friend WithEvents lblD3Tm3 As System.Windows.Forms.Label
    Friend WithEvents lblD3Tm4 As System.Windows.Forms.Label
    Friend WithEvents lblD3Tm5 As System.Windows.Forms.Label
    Friend WithEvents lblD3Tm6 As System.Windows.Forms.Label
    Friend WithEvents lblD3Tm7 As System.Windows.Forms.Label
    Friend WithEvents lblD3Tm8 As System.Windows.Forms.Label
    Friend WithEvents lblD3Tm9 As System.Windows.Forms.Label
    Friend WithEvents lblD3Tm10 As System.Windows.Forms.Label
    Friend WithEvents lblD3Tm11 As System.Windows.Forms.Label
    Friend WithEvents lblD3Tm12 As System.Windows.Forms.Label
    Friend WithEvents lblD3Tm13 As System.Windows.Forms.Label
    Friend WithEvents lblD3Tm14 As System.Windows.Forms.Label
    Friend WithEvents lblD3Tm15 As System.Windows.Forms.Label
    Friend WithEvents lblD3Tm16 As System.Windows.Forms.Label
    Friend WithEvents lblD3Tm17 As System.Windows.Forms.Label
    Friend WithEvents lblD4Tm0 As System.Windows.Forms.Label
    Friend WithEvents lblD4Tm1 As System.Windows.Forms.Label
    Friend WithEvents lblD4Tm2 As System.Windows.Forms.Label
    Friend WithEvents lblD4Tm3 As System.Windows.Forms.Label
    Friend WithEvents lblD4Tm4 As System.Windows.Forms.Label
    Friend WithEvents lblD4Tm5 As System.Windows.Forms.Label
    Friend WithEvents lblD4Tm6 As System.Windows.Forms.Label
    Friend WithEvents lblD4Tm7 As System.Windows.Forms.Label
    Friend WithEvents lblD4Tm8 As System.Windows.Forms.Label
    Friend WithEvents lblD4Tm9 As System.Windows.Forms.Label
    Friend WithEvents lblD4Tm10 As System.Windows.Forms.Label
    Friend WithEvents lblD4Tm11 As System.Windows.Forms.Label
    Friend WithEvents lblD4Tm12 As System.Windows.Forms.Label
    Friend WithEvents lblD4Tm13 As System.Windows.Forms.Label
    Friend WithEvents lblD4Tm14 As System.Windows.Forms.Label
    Friend WithEvents lblD4Tm15 As System.Windows.Forms.Label
    Friend WithEvents lblD4Tm16 As System.Windows.Forms.Label
    Friend WithEvents lblD4Tm17 As System.Windows.Forms.Label
    Friend WithEvents lblMonth As System.Windows.Forms.Label
    Friend WithEvents lblDay2 As System.Windows.Forms.Label
    Friend WithEvents lblDay1 As System.Windows.Forms.Label
    Friend WithEvents lblDay3 As System.Windows.Forms.Label
    Friend WithEvents lblDay4 As System.Windows.Forms.Label
    Friend WithEvents lblDay0 As System.Windows.Forms.Label
    Friend WithEvents gboxTimes As System.Windows.Forms.GroupBox

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAppointment))
        Me.lblMain = New System.Windows.Forms.Label
        Me.picLogo = New System.Windows.Forms.PictureBox
        Me.lblMainMsg = New System.Windows.Forms.Label
        Me.cbxAdvisor = New System.Windows.Forms.ComboBox
        Me.cbxReason = New System.Windows.Forms.ComboBox
        Me.txtComments = New System.Windows.Forms.TextBox
        Me.lblComments = New System.Windows.Forms.Label
        Me.lblReason = New System.Windows.Forms.Label
        Me.calAppointment = New System.Windows.Forms.MonthCalendar
        Me.btnSubmit = New System.Windows.Forms.Button
        Me.lblAdvisor = New System.Windows.Forms.Label
        Me.lblD0Tm0 = New System.Windows.Forms.Label
        Me.lblD0Tm1 = New System.Windows.Forms.Label
        Me.lblD0Tm2 = New System.Windows.Forms.Label
        Me.lblD0Tm3 = New System.Windows.Forms.Label
        Me.lblD0Tm4 = New System.Windows.Forms.Label
        Me.lblD0Tm5 = New System.Windows.Forms.Label
        Me.lblD0Tm6 = New System.Windows.Forms.Label
        Me.lblD0Tm7 = New System.Windows.Forms.Label
        Me.lblD0Tm8 = New System.Windows.Forms.Label
        Me.lblD0Tm9 = New System.Windows.Forms.Label
        Me.lblD0Tm10 = New System.Windows.Forms.Label
        Me.lblD0Tm11 = New System.Windows.Forms.Label
        Me.lblD0Tm12 = New System.Windows.Forms.Label
        Me.lblD0Tm13 = New System.Windows.Forms.Label
        Me.lblD0Tm14 = New System.Windows.Forms.Label
        Me.lblD0Tm15 = New System.Windows.Forms.Label
        Me.lblD0Tm16 = New System.Windows.Forms.Label
        Me.lblD0Tm17 = New System.Windows.Forms.Label
        Me.lblD1Tm0 = New System.Windows.Forms.Label
        Me.lblD1Tm1 = New System.Windows.Forms.Label
        Me.lblD1Tm2 = New System.Windows.Forms.Label
        Me.lblD1Tm3 = New System.Windows.Forms.Label
        Me.lblD1Tm4 = New System.Windows.Forms.Label
        Me.lblD1Tm5 = New System.Windows.Forms.Label
        Me.lblD1Tm6 = New System.Windows.Forms.Label
        Me.lblD1Tm7 = New System.Windows.Forms.Label
        Me.lblD1Tm8 = New System.Windows.Forms.Label
        Me.lblD1Tm9 = New System.Windows.Forms.Label
        Me.lblD1Tm10 = New System.Windows.Forms.Label
        Me.lblD1Tm11 = New System.Windows.Forms.Label
        Me.lblD1Tm12 = New System.Windows.Forms.Label
        Me.lblD1Tm13 = New System.Windows.Forms.Label
        Me.lblD1Tm14 = New System.Windows.Forms.Label
        Me.lblD1Tm15 = New System.Windows.Forms.Label
        Me.lblD1Tm16 = New System.Windows.Forms.Label
        Me.lblD1Tm17 = New System.Windows.Forms.Label
        Me.lblD2Tm0 = New System.Windows.Forms.Label
        Me.lblD2Tm1 = New System.Windows.Forms.Label
        Me.lblD2Tm2 = New System.Windows.Forms.Label
        Me.lblD2Tm3 = New System.Windows.Forms.Label
        Me.lblD2Tm4 = New System.Windows.Forms.Label
        Me.lblD2Tm5 = New System.Windows.Forms.Label
        Me.lblD2Tm6 = New System.Windows.Forms.Label
        Me.lblD2Tm7 = New System.Windows.Forms.Label
        Me.lblD2Tm8 = New System.Windows.Forms.Label
        Me.lblD2Tm9 = New System.Windows.Forms.Label
        Me.lblD2Tm10 = New System.Windows.Forms.Label
        Me.lblD2Tm11 = New System.Windows.Forms.Label
        Me.lblD2Tm12 = New System.Windows.Forms.Label
        Me.lblD2Tm13 = New System.Windows.Forms.Label
        Me.lblD2Tm14 = New System.Windows.Forms.Label
        Me.lblD2Tm15 = New System.Windows.Forms.Label
        Me.lblD2Tm16 = New System.Windows.Forms.Label
        Me.lblD2Tm17 = New System.Windows.Forms.Label
        Me.lblD3Tm0 = New System.Windows.Forms.Label
        Me.lblD3Tm1 = New System.Windows.Forms.Label
        Me.lblD3Tm2 = New System.Windows.Forms.Label
        Me.lblD3Tm3 = New System.Windows.Forms.Label
        Me.lblD3Tm4 = New System.Windows.Forms.Label
        Me.lblD3Tm5 = New System.Windows.Forms.Label
        Me.lblD3Tm6 = New System.Windows.Forms.Label
        Me.lblD3Tm7 = New System.Windows.Forms.Label
        Me.lblD3Tm8 = New System.Windows.Forms.Label
        Me.lblD3Tm9 = New System.Windows.Forms.Label
        Me.lblD3Tm10 = New System.Windows.Forms.Label
        Me.lblD3Tm11 = New System.Windows.Forms.Label
        Me.lblD3Tm12 = New System.Windows.Forms.Label
        Me.lblD3Tm13 = New System.Windows.Forms.Label
        Me.lblD3Tm14 = New System.Windows.Forms.Label
        Me.lblD3Tm15 = New System.Windows.Forms.Label
        Me.lblD3Tm16 = New System.Windows.Forms.Label
        Me.lblD3Tm17 = New System.Windows.Forms.Label
        Me.lblD4Tm0 = New System.Windows.Forms.Label
        Me.lblD4Tm1 = New System.Windows.Forms.Label
        Me.lblD4Tm2 = New System.Windows.Forms.Label
        Me.lblD4Tm3 = New System.Windows.Forms.Label
        Me.lblD4Tm4 = New System.Windows.Forms.Label
        Me.lblD4Tm5 = New System.Windows.Forms.Label
        Me.lblD4Tm6 = New System.Windows.Forms.Label
        Me.lblD4Tm7 = New System.Windows.Forms.Label
        Me.lblD4Tm8 = New System.Windows.Forms.Label
        Me.lblD4Tm9 = New System.Windows.Forms.Label
        Me.lblD4Tm10 = New System.Windows.Forms.Label
        Me.lblD4Tm11 = New System.Windows.Forms.Label
        Me.lblD4Tm12 = New System.Windows.Forms.Label
        Me.lblD4Tm13 = New System.Windows.Forms.Label
        Me.lblD4Tm14 = New System.Windows.Forms.Label
        Me.lblD4Tm15 = New System.Windows.Forms.Label
        Me.lblD4Tm16 = New System.Windows.Forms.Label
        Me.lblD4Tm17 = New System.Windows.Forms.Label
        Me.gboxTimes = New System.Windows.Forms.GroupBox
        Me.lblMonth = New System.Windows.Forms.Label
        Me.lblDay2 = New System.Windows.Forms.Label
        Me.lblDay1 = New System.Windows.Forms.Label
        Me.lblDay3 = New System.Windows.Forms.Label
        Me.lblDay4 = New System.Windows.Forms.Label
        Me.lblDay0 = New System.Windows.Forms.Label
        Me.gboxTimes.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMain
        '
        Me.lblMain.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMain.Font = New System.Drawing.Font("Garamond", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.Location = New System.Drawing.Point(16, 8)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(360, 112)
        Me.lblMain.TabIndex = 38
        Me.lblMain.Text = "College of Business Undergraduate Advising Appointments System"
        '
        'picLogo
        '
        Me.picLogo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(376, 0)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(264, 136)
        Me.picLogo.TabIndex = 39
        Me.picLogo.TabStop = False
        '
        'lblMainMsg
        '
        Me.lblMainMsg.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMainMsg.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainMsg.Location = New System.Drawing.Point(640, 8)
        Me.lblMainMsg.Name = "lblMainMsg"
        Me.lblMainMsg.Size = New System.Drawing.Size(360, 112)
        Me.lblMainMsg.TabIndex = 41
        Me.lblMainMsg.Text = "Attention! Messages Go Here. No appointments necessary to drop off signed documen" & _
        "ts."
        Me.lblMainMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbxAdvisor
        '
        Me.cbxAdvisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxAdvisor.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxAdvisor.Location = New System.Drawing.Point(176, 200)
        Me.cbxAdvisor.Name = "cbxAdvisor"
        Me.cbxAdvisor.Size = New System.Drawing.Size(120, 32)
        Me.cbxAdvisor.TabIndex = 55
        '
        'cbxReason
        '
        Me.cbxReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxReason.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxReason.Location = New System.Drawing.Point(208, 248)
        Me.cbxReason.Name = "cbxReason"
        Me.cbxReason.Size = New System.Drawing.Size(160, 27)
        Me.cbxReason.TabIndex = 57
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(24, 328)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(264, 48)
        Me.txtComments.TabIndex = 59
        Me.txtComments.Text = ""
        '
        'lblComments
        '
        Me.lblComments.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComments.Location = New System.Drawing.Point(104, 296)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(88, 23)
        Me.lblComments.TabIndex = 60
        Me.lblComments.Text = "Comments"
        '
        'lblReason
        '
        Me.lblReason.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReason.Location = New System.Drawing.Point(24, 248)
        Me.lblReason.Name = "lblReason"
        Me.lblReason.Size = New System.Drawing.Size(192, 23)
        Me.lblReason.TabIndex = 58
        Me.lblReason.Text = "Reason for Appointment:"
        Me.lblReason.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'calAppointment
        '
        Me.calAppointment.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calAppointment.Location = New System.Drawing.Point(16, 448)
        Me.calAppointment.Name = "calAppointment"
        Me.calAppointment.TabIndex = 52
        Me.calAppointment.TitleBackColor = System.Drawing.Color.Red
        Me.calAppointment.TitleForeColor = System.Drawing.SystemColors.WindowText
        Me.calAppointment.TrailingForeColor = System.Drawing.SystemColors.InactiveCaptionText
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.MistyRose
        Me.btnSubmit.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(64, 384)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(128, 40)
        Me.btnSubmit.TabIndex = 42
        Me.btnSubmit.Text = "Submit"
        '
        'lblAdvisor
        '
        Me.lblAdvisor.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdvisor.Location = New System.Drawing.Point(24, 208)
        Me.lblAdvisor.Name = "lblAdvisor"
        Me.lblAdvisor.Size = New System.Drawing.Size(152, 24)
        Me.lblAdvisor.TabIndex = 54
        Me.lblAdvisor.Text = "Select Advisor:"
        Me.lblAdvisor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblD0Tm0
        '
        Me.lblD0Tm0.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD0Tm0.Location = New System.Drawing.Point(16, 48)
        Me.lblD0Tm0.Name = "lblD0Tm0"
        Me.lblD0Tm0.Size = New System.Drawing.Size(35, 13)
        Me.lblD0Tm0.TabIndex = 80
        Me.lblD0Tm0.Text = "8:10"
        Me.lblD0Tm0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD0Tm1
        '
        Me.lblD0Tm1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD0Tm1.Location = New System.Drawing.Point(16, 64)
        Me.lblD0Tm1.Name = "lblD0Tm1"
        Me.lblD0Tm1.Size = New System.Drawing.Size(35, 13)
        Me.lblD0Tm1.TabIndex = 81
        Me.lblD0Tm1.Text = "8:40"
        Me.lblD0Tm1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD0Tm2
        '
        Me.lblD0Tm2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD0Tm2.Location = New System.Drawing.Point(16, 80)
        Me.lblD0Tm2.Name = "lblD0Tm2"
        Me.lblD0Tm2.Size = New System.Drawing.Size(35, 13)
        Me.lblD0Tm2.TabIndex = 64
        Me.lblD0Tm2.Text = "9:10"
        Me.lblD0Tm2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD0Tm3
        '
        Me.lblD0Tm3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD0Tm3.Location = New System.Drawing.Point(16, 96)
        Me.lblD0Tm3.Name = "lblD0Tm3"
        Me.lblD0Tm3.Size = New System.Drawing.Size(35, 13)
        Me.lblD0Tm3.TabIndex = 65
        Me.lblD0Tm3.Text = "9:40"
        Me.lblD0Tm3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD0Tm4
        '
        Me.lblD0Tm4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD0Tm4.Location = New System.Drawing.Point(16, 112)
        Me.lblD0Tm4.Name = "lblD0Tm4"
        Me.lblD0Tm4.Size = New System.Drawing.Size(35, 13)
        Me.lblD0Tm4.TabIndex = 66
        Me.lblD0Tm4.Text = "10:10"
        Me.lblD0Tm4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD0Tm5
        '
        Me.lblD0Tm5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD0Tm5.Location = New System.Drawing.Point(16, 128)
        Me.lblD0Tm5.Name = "lblD0Tm5"
        Me.lblD0Tm5.Size = New System.Drawing.Size(35, 13)
        Me.lblD0Tm5.TabIndex = 67
        Me.lblD0Tm5.Text = "10:40"
        Me.lblD0Tm5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD0Tm6
        '
        Me.lblD0Tm6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD0Tm6.Location = New System.Drawing.Point(16, 144)
        Me.lblD0Tm6.Name = "lblD0Tm6"
        Me.lblD0Tm6.Size = New System.Drawing.Size(35, 13)
        Me.lblD0Tm6.TabIndex = 68
        Me.lblD0Tm6.Text = "11:10"
        Me.lblD0Tm6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD0Tm7
        '
        Me.lblD0Tm7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD0Tm7.Location = New System.Drawing.Point(16, 160)
        Me.lblD0Tm7.Name = "lblD0Tm7"
        Me.lblD0Tm7.Size = New System.Drawing.Size(35, 13)
        Me.lblD0Tm7.TabIndex = 69
        Me.lblD0Tm7.Text = "11:40"
        Me.lblD0Tm7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD0Tm8
        '
        Me.lblD0Tm8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD0Tm8.Location = New System.Drawing.Point(16, 176)
        Me.lblD0Tm8.Name = "lblD0Tm8"
        Me.lblD0Tm8.Size = New System.Drawing.Size(35, 13)
        Me.lblD0Tm8.TabIndex = 70
        Me.lblD0Tm8.Text = "12:10"
        Me.lblD0Tm8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD0Tm9
        '
        Me.lblD0Tm9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD0Tm9.Location = New System.Drawing.Point(16, 192)
        Me.lblD0Tm9.Name = "lblD0Tm9"
        Me.lblD0Tm9.Size = New System.Drawing.Size(35, 13)
        Me.lblD0Tm9.TabIndex = 71
        Me.lblD0Tm9.Text = "12:40"
        Me.lblD0Tm9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD0Tm10
        '
        Me.lblD0Tm10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD0Tm10.Location = New System.Drawing.Point(16, 208)
        Me.lblD0Tm10.Name = "lblD0Tm10"
        Me.lblD0Tm10.Size = New System.Drawing.Size(35, 13)
        Me.lblD0Tm10.TabIndex = 72
        Me.lblD0Tm10.Text = "1:10"
        Me.lblD0Tm10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD0Tm11
        '
        Me.lblD0Tm11.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD0Tm11.Location = New System.Drawing.Point(16, 224)
        Me.lblD0Tm11.Name = "lblD0Tm11"
        Me.lblD0Tm11.Size = New System.Drawing.Size(35, 13)
        Me.lblD0Tm11.TabIndex = 73
        Me.lblD0Tm11.Text = "1:40"
        Me.lblD0Tm11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD0Tm12
        '
        Me.lblD0Tm12.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD0Tm12.Location = New System.Drawing.Point(16, 240)
        Me.lblD0Tm12.Name = "lblD0Tm12"
        Me.lblD0Tm12.Size = New System.Drawing.Size(35, 13)
        Me.lblD0Tm12.TabIndex = 74
        Me.lblD0Tm12.Text = "2:10"
        Me.lblD0Tm12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD0Tm13
        '
        Me.lblD0Tm13.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD0Tm13.Location = New System.Drawing.Point(16, 256)
        Me.lblD0Tm13.Name = "lblD0Tm13"
        Me.lblD0Tm13.Size = New System.Drawing.Size(35, 13)
        Me.lblD0Tm13.TabIndex = 75
        Me.lblD0Tm13.Text = "2:40"
        Me.lblD0Tm13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD0Tm14
        '
        Me.lblD0Tm14.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD0Tm14.Location = New System.Drawing.Point(16, 272)
        Me.lblD0Tm14.Name = "lblD0Tm14"
        Me.lblD0Tm14.Size = New System.Drawing.Size(35, 13)
        Me.lblD0Tm14.TabIndex = 76
        Me.lblD0Tm14.Text = "3:10"
        Me.lblD0Tm14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD0Tm15
        '
        Me.lblD0Tm15.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD0Tm15.Location = New System.Drawing.Point(16, 288)
        Me.lblD0Tm15.Name = "lblD0Tm15"
        Me.lblD0Tm15.Size = New System.Drawing.Size(35, 13)
        Me.lblD0Tm15.TabIndex = 77
        Me.lblD0Tm15.Text = "3:40"
        Me.lblD0Tm15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD0Tm16
        '
        Me.lblD0Tm16.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD0Tm16.Location = New System.Drawing.Point(16, 304)
        Me.lblD0Tm16.Name = "lblD0Tm16"
        Me.lblD0Tm16.Size = New System.Drawing.Size(35, 13)
        Me.lblD0Tm16.TabIndex = 78
        Me.lblD0Tm16.Text = "4:10"
        Me.lblD0Tm16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD0Tm17
        '
        Me.lblD0Tm17.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD0Tm17.Location = New System.Drawing.Point(16, 320)
        Me.lblD0Tm17.Name = "lblD0Tm17"
        Me.lblD0Tm17.Size = New System.Drawing.Size(35, 13)
        Me.lblD0Tm17.TabIndex = 79
        Me.lblD0Tm17.Text = "4:40"
        Me.lblD0Tm17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD1Tm0
        '
        Me.lblD1Tm0.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD1Tm0.Location = New System.Drawing.Point(90, 48)
        Me.lblD1Tm0.Name = "lblD1Tm0"
        Me.lblD1Tm0.Size = New System.Drawing.Size(35, 13)
        Me.lblD1Tm0.TabIndex = 80
        Me.lblD1Tm0.Text = "8:10"
        Me.lblD1Tm0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD1Tm1
        '
        Me.lblD1Tm1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD1Tm1.Location = New System.Drawing.Point(90, 64)
        Me.lblD1Tm1.Name = "lblD1Tm1"
        Me.lblD1Tm1.Size = New System.Drawing.Size(35, 13)
        Me.lblD1Tm1.TabIndex = 81
        Me.lblD1Tm1.Text = "8:40"
        Me.lblD1Tm1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD1Tm2
        '
        Me.lblD1Tm2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD1Tm2.Location = New System.Drawing.Point(90, 80)
        Me.lblD1Tm2.Name = "lblD1Tm2"
        Me.lblD1Tm2.Size = New System.Drawing.Size(35, 13)
        Me.lblD1Tm2.TabIndex = 64
        Me.lblD1Tm2.Text = "9:10"
        Me.lblD1Tm2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD1Tm3
        '
        Me.lblD1Tm3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD1Tm3.Location = New System.Drawing.Point(90, 96)
        Me.lblD1Tm3.Name = "lblD1Tm3"
        Me.lblD1Tm3.Size = New System.Drawing.Size(35, 13)
        Me.lblD1Tm3.TabIndex = 65
        Me.lblD1Tm3.Text = "9:40"
        Me.lblD1Tm3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD1Tm4
        '
        Me.lblD1Tm4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD1Tm4.Location = New System.Drawing.Point(90, 112)
        Me.lblD1Tm4.Name = "lblD1Tm4"
        Me.lblD1Tm4.Size = New System.Drawing.Size(35, 13)
        Me.lblD1Tm4.TabIndex = 66
        Me.lblD1Tm4.Text = "10:10"
        Me.lblD1Tm4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD1Tm5
        '
        Me.lblD1Tm5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD1Tm5.Location = New System.Drawing.Point(90, 128)
        Me.lblD1Tm5.Name = "lblD1Tm5"
        Me.lblD1Tm5.Size = New System.Drawing.Size(35, 13)
        Me.lblD1Tm5.TabIndex = 67
        Me.lblD1Tm5.Text = "10:40"
        Me.lblD1Tm5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD1Tm6
        '
        Me.lblD1Tm6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD1Tm6.Location = New System.Drawing.Point(90, 144)
        Me.lblD1Tm6.Name = "lblD1Tm6"
        Me.lblD1Tm6.Size = New System.Drawing.Size(35, 13)
        Me.lblD1Tm6.TabIndex = 68
        Me.lblD1Tm6.Text = "11:10"
        Me.lblD1Tm6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD1Tm7
        '
        Me.lblD1Tm7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD1Tm7.Location = New System.Drawing.Point(90, 160)
        Me.lblD1Tm7.Name = "lblD1Tm7"
        Me.lblD1Tm7.Size = New System.Drawing.Size(35, 13)
        Me.lblD1Tm7.TabIndex = 69
        Me.lblD1Tm7.Text = "11:40"
        Me.lblD1Tm7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD1Tm8
        '
        Me.lblD1Tm8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD1Tm8.Location = New System.Drawing.Point(90, 176)
        Me.lblD1Tm8.Name = "lblD1Tm8"
        Me.lblD1Tm8.Size = New System.Drawing.Size(35, 13)
        Me.lblD1Tm8.TabIndex = 70
        Me.lblD1Tm8.Text = "12:10"
        Me.lblD1Tm8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD1Tm9
        '
        Me.lblD1Tm9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD1Tm9.Location = New System.Drawing.Point(90, 192)
        Me.lblD1Tm9.Name = "lblD1Tm9"
        Me.lblD1Tm9.Size = New System.Drawing.Size(35, 13)
        Me.lblD1Tm9.TabIndex = 71
        Me.lblD1Tm9.Text = "12:40"
        Me.lblD1Tm9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD1Tm10
        '
        Me.lblD1Tm10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD1Tm10.Location = New System.Drawing.Point(90, 208)
        Me.lblD1Tm10.Name = "lblD1Tm10"
        Me.lblD1Tm10.Size = New System.Drawing.Size(35, 13)
        Me.lblD1Tm10.TabIndex = 72
        Me.lblD1Tm10.Text = "1:10"
        Me.lblD1Tm10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD1Tm11
        '
        Me.lblD1Tm11.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD1Tm11.Location = New System.Drawing.Point(90, 224)
        Me.lblD1Tm11.Name = "lblD1Tm11"
        Me.lblD1Tm11.Size = New System.Drawing.Size(35, 13)
        Me.lblD1Tm11.TabIndex = 73
        Me.lblD1Tm11.Text = "1:40"
        Me.lblD1Tm11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD1Tm12
        '
        Me.lblD1Tm12.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD1Tm12.Location = New System.Drawing.Point(90, 240)
        Me.lblD1Tm12.Name = "lblD1Tm12"
        Me.lblD1Tm12.Size = New System.Drawing.Size(35, 13)
        Me.lblD1Tm12.TabIndex = 74
        Me.lblD1Tm12.Text = "2:10"
        Me.lblD1Tm12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD1Tm13
        '
        Me.lblD1Tm13.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD1Tm13.Location = New System.Drawing.Point(90, 256)
        Me.lblD1Tm13.Name = "lblD1Tm13"
        Me.lblD1Tm13.Size = New System.Drawing.Size(35, 13)
        Me.lblD1Tm13.TabIndex = 75
        Me.lblD1Tm13.Text = "2:40"
        Me.lblD1Tm13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD1Tm14
        '
        Me.lblD1Tm14.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD1Tm14.Location = New System.Drawing.Point(90, 272)
        Me.lblD1Tm14.Name = "lblD1Tm14"
        Me.lblD1Tm14.Size = New System.Drawing.Size(35, 13)
        Me.lblD1Tm14.TabIndex = 76
        Me.lblD1Tm14.Text = "3:10"
        Me.lblD1Tm14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD1Tm15
        '
        Me.lblD1Tm15.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD1Tm15.Location = New System.Drawing.Point(90, 288)
        Me.lblD1Tm15.Name = "lblD1Tm15"
        Me.lblD1Tm15.Size = New System.Drawing.Size(35, 13)
        Me.lblD1Tm15.TabIndex = 77
        Me.lblD1Tm15.Text = "3:40"
        Me.lblD1Tm15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD1Tm16
        '
        Me.lblD1Tm16.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD1Tm16.Location = New System.Drawing.Point(90, 304)
        Me.lblD1Tm16.Name = "lblD1Tm16"
        Me.lblD1Tm16.Size = New System.Drawing.Size(35, 13)
        Me.lblD1Tm16.TabIndex = 78
        Me.lblD1Tm16.Text = "4:10"
        Me.lblD1Tm16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD1Tm17
        '
        Me.lblD1Tm17.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD1Tm17.Location = New System.Drawing.Point(90, 320)
        Me.lblD1Tm17.Name = "lblD1Tm17"
        Me.lblD1Tm17.Size = New System.Drawing.Size(35, 13)
        Me.lblD1Tm17.TabIndex = 79
        Me.lblD1Tm17.Text = "4:40"
        Me.lblD1Tm17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD2Tm0
        '
        Me.lblD2Tm0.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD2Tm0.Location = New System.Drawing.Point(164, 48)
        Me.lblD2Tm0.Name = "lblD2Tm0"
        Me.lblD2Tm0.Size = New System.Drawing.Size(35, 13)
        Me.lblD2Tm0.TabIndex = 80
        Me.lblD2Tm0.Text = "8:10"
        Me.lblD2Tm0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD2Tm1
        '
        Me.lblD2Tm1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD2Tm1.Location = New System.Drawing.Point(164, 64)
        Me.lblD2Tm1.Name = "lblD2Tm1"
        Me.lblD2Tm1.Size = New System.Drawing.Size(35, 13)
        Me.lblD2Tm1.TabIndex = 81
        Me.lblD2Tm1.Text = "8:40"
        Me.lblD2Tm1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD2Tm2
        '
        Me.lblD2Tm2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD2Tm2.Location = New System.Drawing.Point(164, 80)
        Me.lblD2Tm2.Name = "lblD2Tm2"
        Me.lblD2Tm2.Size = New System.Drawing.Size(35, 13)
        Me.lblD2Tm2.TabIndex = 64
        Me.lblD2Tm2.Text = "9:10"
        Me.lblD2Tm2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD2Tm3
        '
        Me.lblD2Tm3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD2Tm3.Location = New System.Drawing.Point(164, 96)
        Me.lblD2Tm3.Name = "lblD2Tm3"
        Me.lblD2Tm3.Size = New System.Drawing.Size(35, 13)
        Me.lblD2Tm3.TabIndex = 65
        Me.lblD2Tm3.Text = "9:40"
        Me.lblD2Tm3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD2Tm4
        '
        Me.lblD2Tm4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD2Tm4.Location = New System.Drawing.Point(164, 112)
        Me.lblD2Tm4.Name = "lblD2Tm4"
        Me.lblD2Tm4.Size = New System.Drawing.Size(35, 13)
        Me.lblD2Tm4.TabIndex = 66
        Me.lblD2Tm4.Text = "10:10"
        Me.lblD2Tm4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD2Tm5
        '
        Me.lblD2Tm5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD2Tm5.Location = New System.Drawing.Point(164, 128)
        Me.lblD2Tm5.Name = "lblD2Tm5"
        Me.lblD2Tm5.Size = New System.Drawing.Size(35, 13)
        Me.lblD2Tm5.TabIndex = 67
        Me.lblD2Tm5.Text = "10:40"
        Me.lblD2Tm5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD2Tm6
        '
        Me.lblD2Tm6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD2Tm6.Location = New System.Drawing.Point(164, 144)
        Me.lblD2Tm6.Name = "lblD2Tm6"
        Me.lblD2Tm6.Size = New System.Drawing.Size(35, 13)
        Me.lblD2Tm6.TabIndex = 68
        Me.lblD2Tm6.Text = "11:10"
        Me.lblD2Tm6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD2Tm7
        '
        Me.lblD2Tm7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD2Tm7.Location = New System.Drawing.Point(164, 160)
        Me.lblD2Tm7.Name = "lblD2Tm7"
        Me.lblD2Tm7.Size = New System.Drawing.Size(35, 13)
        Me.lblD2Tm7.TabIndex = 69
        Me.lblD2Tm7.Text = "11:40"
        Me.lblD2Tm7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD2Tm8
        '
        Me.lblD2Tm8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD2Tm8.Location = New System.Drawing.Point(164, 176)
        Me.lblD2Tm8.Name = "lblD2Tm8"
        Me.lblD2Tm8.Size = New System.Drawing.Size(35, 13)
        Me.lblD2Tm8.TabIndex = 70
        Me.lblD2Tm8.Text = "12:10"
        Me.lblD2Tm8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD2Tm9
        '
        Me.lblD2Tm9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD2Tm9.Location = New System.Drawing.Point(164, 192)
        Me.lblD2Tm9.Name = "lblD2Tm9"
        Me.lblD2Tm9.Size = New System.Drawing.Size(35, 13)
        Me.lblD2Tm9.TabIndex = 71
        Me.lblD2Tm9.Text = "12:40"
        Me.lblD2Tm9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD2Tm10
        '
        Me.lblD2Tm10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD2Tm10.Location = New System.Drawing.Point(164, 208)
        Me.lblD2Tm10.Name = "lblD2Tm10"
        Me.lblD2Tm10.Size = New System.Drawing.Size(35, 13)
        Me.lblD2Tm10.TabIndex = 72
        Me.lblD2Tm10.Text = "1:10"
        Me.lblD2Tm10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD2Tm11
        '
        Me.lblD2Tm11.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD2Tm11.Location = New System.Drawing.Point(164, 224)
        Me.lblD2Tm11.Name = "lblD2Tm11"
        Me.lblD2Tm11.Size = New System.Drawing.Size(35, 13)
        Me.lblD2Tm11.TabIndex = 73
        Me.lblD2Tm11.Text = "1:40"
        Me.lblD2Tm11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD2Tm12
        '
        Me.lblD2Tm12.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD2Tm12.Location = New System.Drawing.Point(164, 240)
        Me.lblD2Tm12.Name = "lblD2Tm12"
        Me.lblD2Tm12.Size = New System.Drawing.Size(35, 13)
        Me.lblD2Tm12.TabIndex = 74
        Me.lblD2Tm12.Text = "2:10"
        Me.lblD2Tm12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD2Tm13
        '
        Me.lblD2Tm13.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD2Tm13.Location = New System.Drawing.Point(164, 256)
        Me.lblD2Tm13.Name = "lblD2Tm13"
        Me.lblD2Tm13.Size = New System.Drawing.Size(35, 13)
        Me.lblD2Tm13.TabIndex = 75
        Me.lblD2Tm13.Text = "2:40"
        Me.lblD2Tm13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD2Tm14
        '
        Me.lblD2Tm14.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD2Tm14.Location = New System.Drawing.Point(164, 272)
        Me.lblD2Tm14.Name = "lblD2Tm14"
        Me.lblD2Tm14.Size = New System.Drawing.Size(35, 13)
        Me.lblD2Tm14.TabIndex = 76
        Me.lblD2Tm14.Text = "3:10"
        Me.lblD2Tm14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD2Tm15
        '
        Me.lblD2Tm15.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD2Tm15.Location = New System.Drawing.Point(164, 288)
        Me.lblD2Tm15.Name = "lblD2Tm15"
        Me.lblD2Tm15.Size = New System.Drawing.Size(35, 13)
        Me.lblD2Tm15.TabIndex = 77
        Me.lblD2Tm15.Text = "3:40"
        Me.lblD2Tm15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD2Tm16
        '
        Me.lblD2Tm16.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD2Tm16.Location = New System.Drawing.Point(164, 304)
        Me.lblD2Tm16.Name = "lblD2Tm16"
        Me.lblD2Tm16.Size = New System.Drawing.Size(35, 13)
        Me.lblD2Tm16.TabIndex = 78
        Me.lblD2Tm16.Text = "4:10"
        Me.lblD2Tm16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD2Tm17
        '
        Me.lblD2Tm17.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD2Tm17.Location = New System.Drawing.Point(164, 320)
        Me.lblD2Tm17.Name = "lblD2Tm17"
        Me.lblD2Tm17.Size = New System.Drawing.Size(35, 13)
        Me.lblD2Tm17.TabIndex = 79
        Me.lblD2Tm17.Text = "4:40"
        Me.lblD2Tm17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD3Tm0
        '
        Me.lblD3Tm0.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD3Tm0.Location = New System.Drawing.Point(238, 48)
        Me.lblD3Tm0.Name = "lblD3Tm0"
        Me.lblD3Tm0.Size = New System.Drawing.Size(35, 13)
        Me.lblD3Tm0.TabIndex = 80
        Me.lblD3Tm0.Text = "8:10"
        Me.lblD3Tm0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD3Tm1
        '
        Me.lblD3Tm1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD3Tm1.Location = New System.Drawing.Point(238, 64)
        Me.lblD3Tm1.Name = "lblD3Tm1"
        Me.lblD3Tm1.Size = New System.Drawing.Size(35, 13)
        Me.lblD3Tm1.TabIndex = 81
        Me.lblD3Tm1.Text = "8:40"
        Me.lblD3Tm1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD3Tm2
        '
        Me.lblD3Tm2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD3Tm2.Location = New System.Drawing.Point(238, 80)
        Me.lblD3Tm2.Name = "lblD3Tm2"
        Me.lblD3Tm2.Size = New System.Drawing.Size(35, 13)
        Me.lblD3Tm2.TabIndex = 64
        Me.lblD3Tm2.Text = "9:10"
        Me.lblD3Tm2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD3Tm3
        '
        Me.lblD3Tm3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD3Tm3.Location = New System.Drawing.Point(238, 96)
        Me.lblD3Tm3.Name = "lblD3Tm3"
        Me.lblD3Tm3.Size = New System.Drawing.Size(35, 13)
        Me.lblD3Tm3.TabIndex = 65
        Me.lblD3Tm3.Text = "9:40"
        Me.lblD3Tm3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD3Tm4
        '
        Me.lblD3Tm4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD3Tm4.Location = New System.Drawing.Point(238, 112)
        Me.lblD3Tm4.Name = "lblD3Tm4"
        Me.lblD3Tm4.Size = New System.Drawing.Size(35, 13)
        Me.lblD3Tm4.TabIndex = 66
        Me.lblD3Tm4.Text = "10:10"
        Me.lblD3Tm4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD3Tm5
        '
        Me.lblD3Tm5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD3Tm5.Location = New System.Drawing.Point(238, 128)
        Me.lblD3Tm5.Name = "lblD3Tm5"
        Me.lblD3Tm5.Size = New System.Drawing.Size(35, 13)
        Me.lblD3Tm5.TabIndex = 67
        Me.lblD3Tm5.Text = "10:40"
        Me.lblD3Tm5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD3Tm6
        '
        Me.lblD3Tm6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD3Tm6.Location = New System.Drawing.Point(238, 144)
        Me.lblD3Tm6.Name = "lblD3Tm6"
        Me.lblD3Tm6.Size = New System.Drawing.Size(35, 13)
        Me.lblD3Tm6.TabIndex = 68
        Me.lblD3Tm6.Text = "11:10"
        Me.lblD3Tm6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD3Tm7
        '
        Me.lblD3Tm7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD3Tm7.Location = New System.Drawing.Point(238, 160)
        Me.lblD3Tm7.Name = "lblD3Tm7"
        Me.lblD3Tm7.Size = New System.Drawing.Size(35, 13)
        Me.lblD3Tm7.TabIndex = 69
        Me.lblD3Tm7.Text = "11:40"
        Me.lblD3Tm7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD3Tm8
        '
        Me.lblD3Tm8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD3Tm8.Location = New System.Drawing.Point(238, 176)
        Me.lblD3Tm8.Name = "lblD3Tm8"
        Me.lblD3Tm8.Size = New System.Drawing.Size(35, 13)
        Me.lblD3Tm8.TabIndex = 70
        Me.lblD3Tm8.Text = "12:10"
        Me.lblD3Tm8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD3Tm9
        '
        Me.lblD3Tm9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD3Tm9.Location = New System.Drawing.Point(238, 192)
        Me.lblD3Tm9.Name = "lblD3Tm9"
        Me.lblD3Tm9.Size = New System.Drawing.Size(35, 13)
        Me.lblD3Tm9.TabIndex = 71
        Me.lblD3Tm9.Text = "12:40"
        Me.lblD3Tm9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD3Tm10
        '
        Me.lblD3Tm10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD3Tm10.Location = New System.Drawing.Point(238, 208)
        Me.lblD3Tm10.Name = "lblD3Tm10"
        Me.lblD3Tm10.Size = New System.Drawing.Size(35, 13)
        Me.lblD3Tm10.TabIndex = 72
        Me.lblD3Tm10.Text = "1:10"
        Me.lblD3Tm10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD3Tm11
        '
        Me.lblD3Tm11.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD3Tm11.Location = New System.Drawing.Point(238, 224)
        Me.lblD3Tm11.Name = "lblD3Tm11"
        Me.lblD3Tm11.Size = New System.Drawing.Size(35, 13)
        Me.lblD3Tm11.TabIndex = 73
        Me.lblD3Tm11.Text = "1:40"
        Me.lblD3Tm11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD3Tm12
        '
        Me.lblD3Tm12.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD3Tm12.Location = New System.Drawing.Point(238, 240)
        Me.lblD3Tm12.Name = "lblD3Tm12"
        Me.lblD3Tm12.Size = New System.Drawing.Size(35, 13)
        Me.lblD3Tm12.TabIndex = 74
        Me.lblD3Tm12.Text = "2:10"
        Me.lblD3Tm12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD3Tm13
        '
        Me.lblD3Tm13.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD3Tm13.Location = New System.Drawing.Point(238, 256)
        Me.lblD3Tm13.Name = "lblD3Tm13"
        Me.lblD3Tm13.Size = New System.Drawing.Size(35, 13)
        Me.lblD3Tm13.TabIndex = 75
        Me.lblD3Tm13.Text = "2:40"
        Me.lblD3Tm13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD3Tm14
        '
        Me.lblD3Tm14.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD3Tm14.Location = New System.Drawing.Point(238, 272)
        Me.lblD3Tm14.Name = "lblD3Tm14"
        Me.lblD3Tm14.Size = New System.Drawing.Size(35, 13)
        Me.lblD3Tm14.TabIndex = 76
        Me.lblD3Tm14.Text = "3:10"
        Me.lblD3Tm14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD3Tm15
        '
        Me.lblD3Tm15.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD3Tm15.Location = New System.Drawing.Point(238, 288)
        Me.lblD3Tm15.Name = "lblD3Tm15"
        Me.lblD3Tm15.Size = New System.Drawing.Size(35, 13)
        Me.lblD3Tm15.TabIndex = 77
        Me.lblD3Tm15.Text = "3:40"
        Me.lblD3Tm15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD3Tm16
        '
        Me.lblD3Tm16.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD3Tm16.Location = New System.Drawing.Point(238, 304)
        Me.lblD3Tm16.Name = "lblD3Tm16"
        Me.lblD3Tm16.Size = New System.Drawing.Size(35, 13)
        Me.lblD3Tm16.TabIndex = 78
        Me.lblD3Tm16.Text = "4:10"
        Me.lblD3Tm16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD3Tm17
        '
        Me.lblD3Tm17.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD3Tm17.Location = New System.Drawing.Point(238, 320)
        Me.lblD3Tm17.Name = "lblD3Tm17"
        Me.lblD3Tm17.Size = New System.Drawing.Size(35, 13)
        Me.lblD3Tm17.TabIndex = 79
        Me.lblD3Tm17.Text = "4:40"
        Me.lblD3Tm17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD4Tm0
        '
        Me.lblD4Tm0.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD4Tm0.Location = New System.Drawing.Point(312, 48)
        Me.lblD4Tm0.Name = "lblD4Tm0"
        Me.lblD4Tm0.Size = New System.Drawing.Size(35, 13)
        Me.lblD4Tm0.TabIndex = 80
        Me.lblD4Tm0.Text = "8:10"
        Me.lblD4Tm0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD4Tm1
        '
        Me.lblD4Tm1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD4Tm1.Location = New System.Drawing.Point(312, 64)
        Me.lblD4Tm1.Name = "lblD4Tm1"
        Me.lblD4Tm1.Size = New System.Drawing.Size(35, 13)
        Me.lblD4Tm1.TabIndex = 81
        Me.lblD4Tm1.Text = "8:40"
        Me.lblD4Tm1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD4Tm2
        '
        Me.lblD4Tm2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD4Tm2.Location = New System.Drawing.Point(312, 80)
        Me.lblD4Tm2.Name = "lblD4Tm2"
        Me.lblD4Tm2.Size = New System.Drawing.Size(35, 13)
        Me.lblD4Tm2.TabIndex = 64
        Me.lblD4Tm2.Text = "9:10"
        Me.lblD4Tm2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD4Tm3
        '
        Me.lblD4Tm3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD4Tm3.Location = New System.Drawing.Point(312, 96)
        Me.lblD4Tm3.Name = "lblD4Tm3"
        Me.lblD4Tm3.Size = New System.Drawing.Size(35, 13)
        Me.lblD4Tm3.TabIndex = 65
        Me.lblD4Tm3.Text = "9:40"
        Me.lblD4Tm3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD4Tm4
        '
        Me.lblD4Tm4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD4Tm4.Location = New System.Drawing.Point(312, 112)
        Me.lblD4Tm4.Name = "lblD4Tm4"
        Me.lblD4Tm4.Size = New System.Drawing.Size(35, 13)
        Me.lblD4Tm4.TabIndex = 66
        Me.lblD4Tm4.Text = "10:10"
        Me.lblD4Tm4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD4Tm5
        '
        Me.lblD4Tm5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD4Tm5.Location = New System.Drawing.Point(312, 128)
        Me.lblD4Tm5.Name = "lblD4Tm5"
        Me.lblD4Tm5.Size = New System.Drawing.Size(35, 13)
        Me.lblD4Tm5.TabIndex = 67
        Me.lblD4Tm5.Text = "10:40"
        Me.lblD4Tm5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD4Tm6
        '
        Me.lblD4Tm6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD4Tm6.Location = New System.Drawing.Point(312, 144)
        Me.lblD4Tm6.Name = "lblD4Tm6"
        Me.lblD4Tm6.Size = New System.Drawing.Size(35, 13)
        Me.lblD4Tm6.TabIndex = 68
        Me.lblD4Tm6.Text = "11:10"
        Me.lblD4Tm6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD4Tm7
        '
        Me.lblD4Tm7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD4Tm7.Location = New System.Drawing.Point(312, 160)
        Me.lblD4Tm7.Name = "lblD4Tm7"
        Me.lblD4Tm7.Size = New System.Drawing.Size(35, 13)
        Me.lblD4Tm7.TabIndex = 69
        Me.lblD4Tm7.Text = "11:40"
        Me.lblD4Tm7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD4Tm8
        '
        Me.lblD4Tm8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD4Tm8.Location = New System.Drawing.Point(312, 176)
        Me.lblD4Tm8.Name = "lblD4Tm8"
        Me.lblD4Tm8.Size = New System.Drawing.Size(35, 13)
        Me.lblD4Tm8.TabIndex = 70
        Me.lblD4Tm8.Text = "12:10"
        Me.lblD4Tm8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD4Tm9
        '
        Me.lblD4Tm9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD4Tm9.Location = New System.Drawing.Point(312, 192)
        Me.lblD4Tm9.Name = "lblD4Tm9"
        Me.lblD4Tm9.Size = New System.Drawing.Size(35, 13)
        Me.lblD4Tm9.TabIndex = 71
        Me.lblD4Tm9.Text = "12:40"
        Me.lblD4Tm9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD4Tm10
        '
        Me.lblD4Tm10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD4Tm10.Location = New System.Drawing.Point(312, 208)
        Me.lblD4Tm10.Name = "lblD4Tm10"
        Me.lblD4Tm10.Size = New System.Drawing.Size(35, 13)
        Me.lblD4Tm10.TabIndex = 72
        Me.lblD4Tm10.Text = "1:10"
        Me.lblD4Tm10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD4Tm11
        '
        Me.lblD4Tm11.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD4Tm11.Location = New System.Drawing.Point(312, 224)
        Me.lblD4Tm11.Name = "lblD4Tm11"
        Me.lblD4Tm11.Size = New System.Drawing.Size(35, 13)
        Me.lblD4Tm11.TabIndex = 73
        Me.lblD4Tm11.Text = "1:40"
        Me.lblD4Tm11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD4Tm12
        '
        Me.lblD4Tm12.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD4Tm12.Location = New System.Drawing.Point(312, 240)
        Me.lblD4Tm12.Name = "lblD4Tm12"
        Me.lblD4Tm12.Size = New System.Drawing.Size(35, 13)
        Me.lblD4Tm12.TabIndex = 74
        Me.lblD4Tm12.Text = "2:10"
        Me.lblD4Tm12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD4Tm13
        '
        Me.lblD4Tm13.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD4Tm13.Location = New System.Drawing.Point(312, 256)
        Me.lblD4Tm13.Name = "lblD4Tm13"
        Me.lblD4Tm13.Size = New System.Drawing.Size(35, 13)
        Me.lblD4Tm13.TabIndex = 75
        Me.lblD4Tm13.Text = "2:40"
        Me.lblD4Tm13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD4Tm14
        '
        Me.lblD4Tm14.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD4Tm14.Location = New System.Drawing.Point(312, 272)
        Me.lblD4Tm14.Name = "lblD4Tm14"
        Me.lblD4Tm14.Size = New System.Drawing.Size(35, 13)
        Me.lblD4Tm14.TabIndex = 76
        Me.lblD4Tm14.Text = "3:10"
        Me.lblD4Tm14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD4Tm15
        '
        Me.lblD4Tm15.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD4Tm15.Location = New System.Drawing.Point(312, 288)
        Me.lblD4Tm15.Name = "lblD4Tm15"
        Me.lblD4Tm15.Size = New System.Drawing.Size(35, 13)
        Me.lblD4Tm15.TabIndex = 77
        Me.lblD4Tm15.Text = "3:40"
        Me.lblD4Tm15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD4Tm16
        '
        Me.lblD4Tm16.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD4Tm16.Location = New System.Drawing.Point(312, 304)
        Me.lblD4Tm16.Name = "lblD4Tm16"
        Me.lblD4Tm16.Size = New System.Drawing.Size(35, 13)
        Me.lblD4Tm16.TabIndex = 78
        Me.lblD4Tm16.Text = "4:10"
        Me.lblD4Tm16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblD4Tm17
        '
        Me.lblD4Tm17.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblD4Tm17.Location = New System.Drawing.Point(312, 320)
        Me.lblD4Tm17.Name = "lblD4Tm17"
        Me.lblD4Tm17.Size = New System.Drawing.Size(35, 13)
        Me.lblD4Tm17.TabIndex = 79
        Me.lblD4Tm17.Text = "4:40"
        Me.lblD4Tm17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gboxTimes
        '
        Me.gboxTimes.Controls.Add(Me.lblDay0)
        Me.gboxTimes.Controls.Add(Me.lblDay4)
        Me.gboxTimes.Controls.Add(Me.lblDay3)
        Me.gboxTimes.Controls.Add(Me.lblDay1)
        Me.gboxTimes.Controls.Add(Me.lblDay2)
        Me.gboxTimes.Controls.Add(Me.lblD0Tm0)
        Me.gboxTimes.Controls.Add(Me.lblD0Tm1)
        Me.gboxTimes.Controls.Add(Me.lblD0Tm2)
        Me.gboxTimes.Controls.Add(Me.lblD0Tm3)
        Me.gboxTimes.Controls.Add(Me.lblD0Tm4)
        Me.gboxTimes.Controls.Add(Me.lblD0Tm5)
        Me.gboxTimes.Controls.Add(Me.lblD0Tm6)
        Me.gboxTimes.Controls.Add(Me.lblD0Tm7)
        Me.gboxTimes.Controls.Add(Me.lblD0Tm8)
        Me.gboxTimes.Controls.Add(Me.lblD0Tm9)
        Me.gboxTimes.Controls.Add(Me.lblD0Tm10)
        Me.gboxTimes.Controls.Add(Me.lblD0Tm11)
        Me.gboxTimes.Controls.Add(Me.lblD0Tm12)
        Me.gboxTimes.Controls.Add(Me.lblD0Tm13)
        Me.gboxTimes.Controls.Add(Me.lblD0Tm14)
        Me.gboxTimes.Controls.Add(Me.lblD0Tm15)
        Me.gboxTimes.Controls.Add(Me.lblD0Tm16)
        Me.gboxTimes.Controls.Add(Me.lblD0Tm17)
        Me.gboxTimes.Controls.Add(Me.lblD1Tm0)
        Me.gboxTimes.Controls.Add(Me.lblD1Tm1)
        Me.gboxTimes.Controls.Add(Me.lblD1Tm2)
        Me.gboxTimes.Controls.Add(Me.lblD1Tm3)
        Me.gboxTimes.Controls.Add(Me.lblD1Tm4)
        Me.gboxTimes.Controls.Add(Me.lblD1Tm5)
        Me.gboxTimes.Controls.Add(Me.lblD1Tm6)
        Me.gboxTimes.Controls.Add(Me.lblD1Tm7)
        Me.gboxTimes.Controls.Add(Me.lblD1Tm8)
        Me.gboxTimes.Controls.Add(Me.lblD1Tm9)
        Me.gboxTimes.Controls.Add(Me.lblD1Tm10)
        Me.gboxTimes.Controls.Add(Me.lblD1Tm11)
        Me.gboxTimes.Controls.Add(Me.lblD1Tm12)
        Me.gboxTimes.Controls.Add(Me.lblD1Tm13)
        Me.gboxTimes.Controls.Add(Me.lblD1Tm14)
        Me.gboxTimes.Controls.Add(Me.lblD1Tm15)
        Me.gboxTimes.Controls.Add(Me.lblD1Tm16)
        Me.gboxTimes.Controls.Add(Me.lblD1Tm17)
        Me.gboxTimes.Controls.Add(Me.lblD2Tm0)
        Me.gboxTimes.Controls.Add(Me.lblD2Tm1)
        Me.gboxTimes.Controls.Add(Me.lblD2Tm2)
        Me.gboxTimes.Controls.Add(Me.lblD2Tm3)
        Me.gboxTimes.Controls.Add(Me.lblD2Tm4)
        Me.gboxTimes.Controls.Add(Me.lblD2Tm5)
        Me.gboxTimes.Controls.Add(Me.lblD2Tm6)
        Me.gboxTimes.Controls.Add(Me.lblD2Tm7)
        Me.gboxTimes.Controls.Add(Me.lblD2Tm8)
        Me.gboxTimes.Controls.Add(Me.lblD2Tm9)
        Me.gboxTimes.Controls.Add(Me.lblD2Tm10)
        Me.gboxTimes.Controls.Add(Me.lblD2Tm11)
        Me.gboxTimes.Controls.Add(Me.lblD2Tm12)
        Me.gboxTimes.Controls.Add(Me.lblD2Tm13)
        Me.gboxTimes.Controls.Add(Me.lblD2Tm14)
        Me.gboxTimes.Controls.Add(Me.lblD2Tm15)
        Me.gboxTimes.Controls.Add(Me.lblD2Tm16)
        Me.gboxTimes.Controls.Add(Me.lblD2Tm17)
        Me.gboxTimes.Controls.Add(Me.lblD3Tm0)
        Me.gboxTimes.Controls.Add(Me.lblD3Tm1)
        Me.gboxTimes.Controls.Add(Me.lblD3Tm2)
        Me.gboxTimes.Controls.Add(Me.lblD3Tm3)
        Me.gboxTimes.Controls.Add(Me.lblD3Tm4)
        Me.gboxTimes.Controls.Add(Me.lblD3Tm5)
        Me.gboxTimes.Controls.Add(Me.lblD3Tm6)
        Me.gboxTimes.Controls.Add(Me.lblD3Tm7)
        Me.gboxTimes.Controls.Add(Me.lblD3Tm8)
        Me.gboxTimes.Controls.Add(Me.lblD3Tm9)
        Me.gboxTimes.Controls.Add(Me.lblD3Tm10)
        Me.gboxTimes.Controls.Add(Me.lblD3Tm11)
        Me.gboxTimes.Controls.Add(Me.lblD3Tm12)
        Me.gboxTimes.Controls.Add(Me.lblD3Tm13)
        Me.gboxTimes.Controls.Add(Me.lblD3Tm14)
        Me.gboxTimes.Controls.Add(Me.lblD3Tm15)
        Me.gboxTimes.Controls.Add(Me.lblD3Tm16)
        Me.gboxTimes.Controls.Add(Me.lblD3Tm17)
        Me.gboxTimes.Controls.Add(Me.lblD4Tm0)
        Me.gboxTimes.Controls.Add(Me.lblD4Tm1)
        Me.gboxTimes.Controls.Add(Me.lblD4Tm2)
        Me.gboxTimes.Controls.Add(Me.lblD4Tm3)
        Me.gboxTimes.Controls.Add(Me.lblD4Tm4)
        Me.gboxTimes.Controls.Add(Me.lblD4Tm5)
        Me.gboxTimes.Controls.Add(Me.lblD4Tm6)
        Me.gboxTimes.Controls.Add(Me.lblD4Tm7)
        Me.gboxTimes.Controls.Add(Me.lblD4Tm8)
        Me.gboxTimes.Controls.Add(Me.lblD4Tm9)
        Me.gboxTimes.Controls.Add(Me.lblD4Tm10)
        Me.gboxTimes.Controls.Add(Me.lblD4Tm11)
        Me.gboxTimes.Controls.Add(Me.lblD4Tm12)
        Me.gboxTimes.Controls.Add(Me.lblD4Tm13)
        Me.gboxTimes.Controls.Add(Me.lblD4Tm14)
        Me.gboxTimes.Controls.Add(Me.lblD4Tm15)
        Me.gboxTimes.Controls.Add(Me.lblD4Tm16)
        Me.gboxTimes.Controls.Add(Me.lblD4Tm17)
        Me.gboxTimes.Controls.Add(Me.lblMonth)
        Me.gboxTimes.Location = New System.Drawing.Point(296, 320)
        Me.gboxTimes.Name = "gboxTimes"
        Me.gboxTimes.Size = New System.Drawing.Size(363, 344)
        Me.gboxTimes.TabIndex = 82
        Me.gboxTimes.TabStop = False
        Me.gboxTimes.Text = "Times"
        '
        'lblMonth
        '
        Me.lblMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonth.Location = New System.Drawing.Point(136, 16)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(100, 16)
        Me.lblMonth.TabIndex = 83
        Me.lblMonth.Text = "Month"
        Me.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDay2
        '
        Me.lblDay2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay2.Location = New System.Drawing.Point(164, 32)
        Me.lblDay2.Name = "lblDay2"
        Me.lblDay2.Size = New System.Drawing.Size(35, 13)
        Me.lblDay2.TabIndex = 84
        Me.lblDay2.Text = "Day2"
        Me.lblDay2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDay1
        '
        Me.lblDay1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay1.Location = New System.Drawing.Point(90, 32)
        Me.lblDay1.Name = "lblDay1"
        Me.lblDay1.Size = New System.Drawing.Size(35, 13)
        Me.lblDay1.TabIndex = 85
        Me.lblDay1.Text = "Day1"
        Me.lblDay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDay3
        '
        Me.lblDay3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay3.Location = New System.Drawing.Point(238, 32)
        Me.lblDay3.Name = "lblDay3"
        Me.lblDay3.Size = New System.Drawing.Size(35, 13)
        Me.lblDay3.TabIndex = 86
        Me.lblDay3.Text = "Day3"
        Me.lblDay3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDay4
        '
        Me.lblDay4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay4.Location = New System.Drawing.Point(312, 32)
        Me.lblDay4.Name = "lblDay4"
        Me.lblDay4.Size = New System.Drawing.Size(35, 13)
        Me.lblDay4.TabIndex = 87
        Me.lblDay4.Text = "Day4"
        Me.lblDay4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDay0
        '
        Me.lblDay0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay0.Location = New System.Drawing.Point(16, 32)
        Me.lblDay0.Name = "lblDay0"
        Me.lblDay0.Size = New System.Drawing.Size(35, 13)
        Me.lblDay0.TabIndex = 88
        Me.lblDay0.Text = "Day0"
        Me.lblDay0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAppointment
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1016, 677)
        Me.Controls.Add(Me.gboxTimes)
        Me.Controls.Add(Me.cbxAdvisor)
        Me.Controls.Add(Me.cbxReason)
        Me.Controls.Add(Me.txtComments)
        Me.Controls.Add(Me.lblComments)
        Me.Controls.Add(Me.lblReason)
        Me.Controls.Add(Me.calAppointment)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblAdvisor)
        Me.Controls.Add(Me.lblMainMsg)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.picLogo)
        Me.Name = "frmAppointment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COB Advising - Make Appointment"
        Me.gboxTimes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim db As String = "..\..\..\DB\COBAdvisingAppts.mdb"
    Dim dbCon As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & db & "; Persist Security Info=False;"
    Dim sql As String
    Dim blockOut() As Integer = {8, 9}
    Dim selFlag As Boolean = False


    Private Sub frmAppointment_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Studentfunctions.Visible = True
    End Sub

    Private Sub frmAppointment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadDayTimes("4/30/2006 8:00:00")
    End Sub

#Region " Label Clicks "

    Private Sub lblD0Tm0_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm0.Click
        selColors(lblD0Tm0)
    End Sub

    Private Sub lblD0Tm0_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm0.MouseHover
        onColors(lblD0Tm0)
    End Sub

    Private Sub lblD0Tm0_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm0.MouseLeave
        offColors(lblD0Tm0)
    End Sub

    Private Sub lblD0Tm1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm1.Click
        selColors(lblD0Tm1)
    End Sub

    Private Sub lblD0Tm1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm1.MouseHover
        onColors(lblD0Tm1)
    End Sub

    Private Sub lblD0Tm1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm1.MouseLeave
        offColors(lblD0Tm1)
    End Sub

    Private Sub lblD0Tm2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm2.Click
        selColors(lblD0Tm2)
    End Sub

    Private Sub lblD0Tm2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm2.MouseHover
        onColors(lblD0Tm2)
    End Sub

    Private Sub lblD0Tm2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm2.MouseLeave
        offColors(lblD0Tm2)
    End Sub

    Private Sub lblD0Tm3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm3.Click
        selColors(lblD0Tm3)
    End Sub

    Private Sub lblD0Tm3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm3.MouseHover
        onColors(lblD0Tm3)
    End Sub

    Private Sub lblD0Tm3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm3.MouseLeave
        offColors(lblD0Tm3)
    End Sub

    Private Sub lblD0Tm4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm4.Click
        selColors(lblD0Tm4)
    End Sub

    Private Sub lblD0Tm4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm4.MouseHover
        onColors(lblD0Tm4)
    End Sub

    Private Sub lblD0Tm4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm4.MouseLeave
        offColors(lblD0Tm4)
    End Sub

    Private Sub lblD0Tm5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm5.Click
        selColors(lblD0Tm5)
    End Sub

    Private Sub lblD0Tm5_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm5.MouseHover
        onColors(lblD0Tm5)
    End Sub

    Private Sub lblD0Tm5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm5.MouseLeave
        offColors(lblD0Tm5)
    End Sub

    Private Sub lblD0Tm6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm6.Click
        selColors(lblD0Tm6)
    End Sub

    Private Sub lblD0Tm6_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm6.MouseHover
        onColors(lblD0Tm6)
    End Sub

    Private Sub lblD0Tm6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm6.MouseLeave
        offColors(lblD0Tm6)
    End Sub

    Private Sub lblD0Tm7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm7.Click
        selColors(lblD0Tm7)
    End Sub

    Private Sub lblD0Tm7_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm7.MouseHover
        onColors(lblD0Tm7)
    End Sub

    Private Sub lblD0Tm7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm7.MouseLeave
        offColors(lblD0Tm7)
    End Sub

    Private Sub lblD0Tm8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm8.Click
        selColors(lblD0Tm8)
    End Sub

    Private Sub lblD0Tm8_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm8.MouseHover
        onColors(lblD0Tm8)
    End Sub

    Private Sub lblD0Tm8_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm8.MouseLeave
        offColors(lblD0Tm8)
    End Sub

    Private Sub lblD0Tm9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm9.Click
        selColors(lblD0Tm9)
    End Sub

    Private Sub lblD0Tm9_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm9.MouseHover
        onColors(lblD0Tm9)
    End Sub

    Private Sub lblD0Tm9_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm9.MouseLeave
        offColors(lblD0Tm9)
    End Sub

    Private Sub lblD0Tm10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm10.Click
        selColors(lblD0Tm10)
    End Sub

    Private Sub lblD0Tm10_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm10.MouseHover
        onColors(lblD0Tm10)
    End Sub

    Private Sub lblD0Tm10_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm10.MouseLeave
        offColors(lblD0Tm10)
    End Sub

    Private Sub lblD0Tm11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm11.Click
        selColors(lblD0Tm11)
    End Sub

    Private Sub lblD0Tm11_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm11.MouseHover
        onColors(lblD0Tm11)
    End Sub

    Private Sub lblD0Tm11_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm11.MouseLeave
        offColors(lblD0Tm11)
    End Sub

    Private Sub lblD0Tm12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm12.Click
        selColors(lblD0Tm12)
    End Sub

    Private Sub lblD0Tm12_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm12.MouseHover
        onColors(lblD0Tm12)
    End Sub

    Private Sub lblD0Tm12_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm12.MouseLeave
        offColors(lblD0Tm12)
    End Sub

    Private Sub lblD0Tm13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm13.Click
        selColors(lblD0Tm13)
    End Sub

    Private Sub lblD0Tm13_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm13.MouseHover
        onColors(lblD0Tm13)
    End Sub

    Private Sub lblD0Tm13_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm13.MouseLeave
        offColors(lblD0Tm13)
    End Sub

    Private Sub lblD0Tm14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm14.Click
        selColors(lblD0Tm14)
    End Sub

    Private Sub lblD0Tm14_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm14.MouseHover
        onColors(lblD0Tm14)
    End Sub

    Private Sub lblD0Tm14_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm14.MouseLeave
        offColors(lblD0Tm14)
    End Sub

    Private Sub lblD0Tm15_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm15.Click
        selColors(lblD0Tm15)
    End Sub

    Private Sub lblD0Tm15_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm15.MouseHover
        onColors(lblD0Tm15)
    End Sub

    Private Sub lblD0Tm15_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm15.MouseLeave
        offColors(lblD0Tm15)
    End Sub

    Private Sub lblD0Tm16_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm16.Click
        selColors(lblD0Tm16)
    End Sub

    Private Sub lblD0Tm16_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm16.MouseHover
        onColors(lblD0Tm16)
    End Sub

    Private Sub lblD0Tm16_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm16.MouseLeave
        offColors(lblD0Tm16)
    End Sub

    Private Sub lblD0Tm17_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm17.Click
        selColors(lblD0Tm17)
    End Sub

    Private Sub lblD0Tm17_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm17.MouseHover
        onColors(lblD0Tm17)
    End Sub

    Private Sub lblD0Tm17_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD0Tm17.MouseLeave
        offColors(lblD0Tm17)
    End Sub

    Private Sub lblD1Tm0_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm0.Click
        selColors(lblD1Tm0)
    End Sub

    Private Sub lblD1Tm0_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm0.MouseHover
        onColors(lblD1Tm0)
    End Sub

    Private Sub lblD1Tm0_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm0.MouseLeave
        offColors(lblD1Tm0)
    End Sub

    Private Sub lblD1Tm1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm1.Click
        selColors(lblD1Tm1)
    End Sub

    Private Sub lblD1Tm1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm1.MouseHover
        onColors(lblD1Tm1)
    End Sub

    Private Sub lblD1Tm1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm1.MouseLeave
        offColors(lblD1Tm1)
    End Sub

    Private Sub lblD1Tm2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm2.Click
        selColors(lblD1Tm2)
    End Sub

    Private Sub lblD1Tm2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm2.MouseHover
        onColors(lblD1Tm2)
    End Sub

    Private Sub lblD1Tm2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm2.MouseLeave
        offColors(lblD1Tm2)
    End Sub

    Private Sub lblD1Tm3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm3.Click
        selColors(lblD1Tm3)
    End Sub

    Private Sub lblD1Tm3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm3.MouseHover
        onColors(lblD1Tm3)
    End Sub

    Private Sub lblD1Tm3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm3.MouseLeave
        offColors(lblD1Tm3)
    End Sub

    Private Sub lblD1Tm4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm4.Click
        selColors(lblD1Tm4)
    End Sub

    Private Sub lblD1Tm4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm4.MouseHover
        onColors(lblD1Tm4)
    End Sub

    Private Sub lblD1Tm4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm4.MouseLeave
        offColors(lblD1Tm4)
    End Sub

    Private Sub lblD1Tm5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm5.Click
        selColors(lblD1Tm5)
    End Sub

    Private Sub lblD1Tm5_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm5.MouseHover
        onColors(lblD1Tm5)
    End Sub

    Private Sub lblD1Tm5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm5.MouseLeave
        offColors(lblD1Tm5)
    End Sub

    Private Sub lblD1Tm6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm6.Click
        selColors(lblD1Tm6)
    End Sub

    Private Sub lblD1Tm6_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm6.MouseHover
        onColors(lblD1Tm6)
    End Sub

    Private Sub lblD1Tm6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm6.MouseLeave
        offColors(lblD1Tm6)
    End Sub

    Private Sub lblD1Tm7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm7.Click
        selColors(lblD1Tm7)
    End Sub

    Private Sub lblD1Tm7_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm7.MouseHover
        onColors(lblD1Tm7)
    End Sub

    Private Sub lblD1Tm7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm7.MouseLeave
        offColors(lblD1Tm7)
    End Sub

    Private Sub lblD1Tm8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm8.Click
        selColors(lblD1Tm8)
    End Sub

    Private Sub lblD1Tm8_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm8.MouseHover
        onColors(lblD1Tm8)
    End Sub

    Private Sub lblD1Tm8_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm8.MouseLeave
        offColors(lblD1Tm8)
    End Sub

    Private Sub lblD1Tm9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm9.Click
        selColors(lblD1Tm9)
    End Sub

    Private Sub lblD1Tm9_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm9.MouseHover
        onColors(lblD1Tm9)
    End Sub

    Private Sub lblD1Tm9_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm9.MouseLeave
        offColors(lblD1Tm9)
    End Sub

    Private Sub lblD1Tm10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm10.Click
        selColors(lblD1Tm10)
    End Sub

    Private Sub lblD1Tm10_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm10.MouseHover
        onColors(lblD1Tm10)
    End Sub

    Private Sub lblD1Tm10_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm10.MouseLeave
        offColors(lblD1Tm10)
    End Sub

    Private Sub lblD1Tm11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm11.Click
        selColors(lblD1Tm11)
    End Sub

    Private Sub lblD1Tm11_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm11.MouseHover
        onColors(lblD1Tm11)
    End Sub

    Private Sub lblD1Tm11_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm11.MouseLeave
        offColors(lblD1Tm11)
    End Sub

    Private Sub lblD1Tm12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm12.Click
        selColors(lblD1Tm12)
    End Sub

    Private Sub lblD1Tm12_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm12.MouseHover
        onColors(lblD1Tm12)
    End Sub

    Private Sub lblD1Tm12_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm12.MouseLeave
        offColors(lblD1Tm12)
    End Sub

    Private Sub lblD1Tm13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm13.Click
        selColors(lblD1Tm13)
    End Sub

    Private Sub lblD1Tm13_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm13.MouseHover
        onColors(lblD1Tm13)
    End Sub

    Private Sub lblD1Tm13_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm13.MouseLeave
        offColors(lblD1Tm13)
    End Sub

    Private Sub lblD1Tm14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm14.Click
        selColors(lblD1Tm14)
    End Sub

    Private Sub lblD1Tm14_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm14.MouseHover
        onColors(lblD1Tm14)
    End Sub

    Private Sub lblD1Tm14_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm14.MouseLeave
        offColors(lblD1Tm14)
    End Sub

    Private Sub lblD1Tm15_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm15.Click
        selColors(lblD1Tm15)
    End Sub

    Private Sub lblD1Tm15_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm15.MouseHover
        onColors(lblD1Tm15)
    End Sub

    Private Sub lblD1Tm15_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm15.MouseLeave
        offColors(lblD1Tm15)
    End Sub

    Private Sub lblD1Tm16_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm16.Click
        selColors(lblD1Tm16)
    End Sub

    Private Sub lblD1Tm16_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm16.MouseHover
        onColors(lblD1Tm16)
    End Sub

    Private Sub lblD1Tm16_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm16.MouseLeave
        offColors(lblD1Tm16)
    End Sub

    Private Sub lblD1Tm17_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm17.Click
        selColors(lblD1Tm17)
    End Sub

    Private Sub lblD1Tm17_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm17.MouseHover
        onColors(lblD1Tm17)
    End Sub

    Private Sub lblD1Tm17_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD1Tm17.MouseLeave
        offColors(lblD1Tm17)
    End Sub

    Private Sub lblD2Tm0_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm0.Click
        selColors(lblD2Tm0)
    End Sub

    Private Sub lblD2Tm0_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm0.MouseHover
        onColors(lblD2Tm0)
    End Sub

    Private Sub lblD2Tm0_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm0.MouseLeave
        offColors(lblD2Tm0)
    End Sub

    Private Sub lblD2Tm1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm1.Click
        selColors(lblD2Tm1)
    End Sub

    Private Sub lblD2Tm1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm1.MouseHover
        onColors(lblD2Tm1)
    End Sub

    Private Sub lblD2Tm1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm1.MouseLeave
        offColors(lblD2Tm1)
    End Sub

    Private Sub lblD2Tm2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm2.Click
        selColors(lblD2Tm2)
    End Sub

    Private Sub lblD2Tm2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm2.MouseHover
        onColors(lblD2Tm2)
    End Sub

    Private Sub lblD2Tm2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm2.MouseLeave
        offColors(lblD2Tm2)
    End Sub

    Private Sub lblD2Tm3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm3.Click
        selColors(lblD2Tm3)
    End Sub

    Private Sub lblD2Tm3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm3.MouseHover
        onColors(lblD2Tm3)
    End Sub

    Private Sub lblD2Tm3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm3.MouseLeave
        offColors(lblD2Tm3)
    End Sub

    Private Sub lblD2Tm4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm4.Click
        selColors(lblD2Tm4)
    End Sub

    Private Sub lblD2Tm4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm4.MouseHover
        onColors(lblD2Tm4)
    End Sub

    Private Sub lblD2Tm4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm4.MouseLeave
        offColors(lblD2Tm4)
    End Sub

    Private Sub lblD2Tm5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm5.Click
        selColors(lblD2Tm5)
    End Sub

    Private Sub lblD2Tm5_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm5.MouseHover
        onColors(lblD2Tm5)
    End Sub

    Private Sub lblD2Tm5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm5.MouseLeave
        offColors(lblD2Tm5)
    End Sub

    Private Sub lblD2Tm6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm6.Click
        selColors(lblD2Tm6)
    End Sub

    Private Sub lblD2Tm6_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm6.MouseHover
        onColors(lblD2Tm6)
    End Sub

    Private Sub lblD2Tm6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm6.MouseLeave
        offColors(lblD2Tm6)
    End Sub

    Private Sub lblD2Tm7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm7.Click
        selColors(lblD2Tm7)
    End Sub

    Private Sub lblD2Tm7_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm7.MouseHover
        onColors(lblD2Tm7)
    End Sub

    Private Sub lblD2Tm7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm7.MouseLeave
        offColors(lblD2Tm7)
    End Sub

    Private Sub lblD2Tm8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm8.Click
        selColors(lblD2Tm8)
    End Sub

    Private Sub lblD2Tm8_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm8.MouseHover
        onColors(lblD2Tm8)
    End Sub

    Private Sub lblD2Tm8_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm8.MouseLeave
        offColors(lblD2Tm8)
    End Sub

    Private Sub lblD2Tm9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm9.Click
        selColors(lblD2Tm9)
    End Sub

    Private Sub lblD2Tm9_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm9.MouseHover
        onColors(lblD2Tm9)
    End Sub

    Private Sub lblD2Tm9_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm9.MouseLeave
        offColors(lblD2Tm9)
    End Sub

    Private Sub lblD2Tm10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm10.Click
        selColors(lblD2Tm10)
    End Sub

    Private Sub lblD2Tm10_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm10.MouseHover
        onColors(lblD2Tm10)
    End Sub

    Private Sub lblD2Tm10_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm10.MouseLeave
        offColors(lblD2Tm10)
    End Sub

    Private Sub lblD2Tm11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm11.Click
        selColors(lblD2Tm11)
    End Sub

    Private Sub lblD2Tm11_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm11.MouseHover
        onColors(lblD2Tm11)
    End Sub

    Private Sub lblD2Tm11_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm11.MouseLeave
        offColors(lblD2Tm11)
    End Sub

    Private Sub lblD2Tm12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm12.Click
        selColors(lblD2Tm12)
    End Sub

    Private Sub lblD2Tm12_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm12.MouseHover
        onColors(lblD2Tm12)
    End Sub

    Private Sub lblD2Tm12_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm12.MouseLeave
        offColors(lblD2Tm12)
    End Sub

    Private Sub lblD2Tm13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm13.Click
        selColors(lblD2Tm13)
    End Sub

    Private Sub lblD2Tm13_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm13.MouseHover
        onColors(lblD2Tm13)
    End Sub

    Private Sub lblD2Tm13_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm13.MouseLeave
        offColors(lblD2Tm13)
    End Sub

    Private Sub lblD2Tm14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm14.Click
        selColors(lblD2Tm14)
    End Sub

    Private Sub lblD2Tm14_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm14.MouseHover
        onColors(lblD2Tm14)
    End Sub

    Private Sub lblD2Tm14_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm14.MouseLeave
        offColors(lblD2Tm14)
    End Sub

    Private Sub lblD2Tm15_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm15.Click
        selColors(lblD2Tm15)
    End Sub

    Private Sub lblD2Tm15_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm15.MouseHover
        onColors(lblD2Tm15)
    End Sub

    Private Sub lblD2Tm15_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm15.MouseLeave
        offColors(lblD2Tm15)
    End Sub

    Private Sub lblD2Tm16_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm16.Click
        selColors(lblD2Tm16)
    End Sub

    Private Sub lblD2Tm16_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm16.MouseHover
        onColors(lblD2Tm16)
    End Sub

    Private Sub lblD2Tm16_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm16.MouseLeave
        offColors(lblD2Tm16)
    End Sub

    Private Sub lblD2Tm17_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm17.Click
        selColors(lblD2Tm17)
    End Sub

    Private Sub lblD2Tm17_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm17.MouseHover
        onColors(lblD2Tm17)
    End Sub

    Private Sub lblD2Tm17_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD2Tm17.MouseLeave
        offColors(lblD2Tm17)
    End Sub

    Private Sub lblD3Tm0_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm0.Click
        selColors(lblD3Tm0)
    End Sub

    Private Sub lblD3Tm0_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm0.MouseHover
        onColors(lblD3Tm0)
    End Sub

    Private Sub lblD3Tm0_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm0.MouseLeave
        offColors(lblD3Tm0)
    End Sub

    Private Sub lblD3Tm1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm1.Click
        selColors(lblD3Tm1)
    End Sub

    Private Sub lblD3Tm1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm1.MouseHover
        onColors(lblD3Tm1)
    End Sub

    Private Sub lblD3Tm1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm1.MouseLeave
        offColors(lblD3Tm1)
    End Sub

    Private Sub lblD3Tm2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm2.Click
        selColors(lblD3Tm2)
    End Sub

    Private Sub lblD3Tm2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm2.MouseHover
        onColors(lblD3Tm2)
    End Sub

    Private Sub lblD3Tm2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm2.MouseLeave
        offColors(lblD3Tm2)
    End Sub

    Private Sub lblD3Tm3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm3.Click
        selColors(lblD3Tm3)
    End Sub

    Private Sub lblD3Tm3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm3.MouseHover
        onColors(lblD3Tm3)
    End Sub

    Private Sub lblD3Tm3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm3.MouseLeave
        offColors(lblD3Tm3)
    End Sub

    Private Sub lblD3Tm4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm4.Click
        selColors(lblD3Tm4)
    End Sub

    Private Sub lblD3Tm4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm4.MouseHover
        onColors(lblD3Tm4)
    End Sub

    Private Sub lblD3Tm4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm4.MouseLeave
        offColors(lblD3Tm4)
    End Sub

    Private Sub lblD3Tm5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm5.Click
        selColors(lblD3Tm5)
    End Sub

    Private Sub lblD3Tm5_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm5.MouseHover
        onColors(lblD3Tm5)
    End Sub

    Private Sub lblD3Tm5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm5.MouseLeave
        offColors(lblD3Tm5)
    End Sub

    Private Sub lblD3Tm6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm6.Click
        selColors(lblD3Tm6)
    End Sub

    Private Sub lblD3Tm6_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm6.MouseHover
        onColors(lblD3Tm6)
    End Sub

    Private Sub lblD3Tm6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm6.MouseLeave
        offColors(lblD3Tm6)
    End Sub

    Private Sub lblD3Tm7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm7.Click
        selColors(lblD3Tm7)
    End Sub

    Private Sub lblD3Tm7_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm7.MouseHover
        onColors(lblD3Tm7)
    End Sub

    Private Sub lblD3Tm7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm7.MouseLeave
        offColors(lblD3Tm7)
    End Sub

    Private Sub lblD3Tm8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm8.Click
        selColors(lblD3Tm8)
    End Sub

    Private Sub lblD3Tm8_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm8.MouseHover
        onColors(lblD3Tm8)
    End Sub

    Private Sub lblD3Tm8_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm8.MouseLeave
        offColors(lblD3Tm8)
    End Sub

    Private Sub lblD3Tm9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm9.Click
        selColors(lblD3Tm9)
    End Sub

    Private Sub lblD3Tm9_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm9.MouseHover
        onColors(lblD3Tm9)
    End Sub

    Private Sub lblD3Tm9_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm9.MouseLeave
        offColors(lblD3Tm9)
    End Sub

    Private Sub lblD3Tm10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm10.Click
        selColors(lblD3Tm10)
    End Sub

    Private Sub lblD3Tm10_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm10.MouseHover
        onColors(lblD3Tm10)
    End Sub

    Private Sub lblD3Tm10_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm10.MouseLeave
        offColors(lblD3Tm10)
    End Sub

    Private Sub lblD3Tm11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm11.Click
        selColors(lblD3Tm11)
    End Sub

    Private Sub lblD3Tm11_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm11.MouseHover
        onColors(lblD3Tm11)
    End Sub

    Private Sub lblD3Tm11_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm11.MouseLeave
        offColors(lblD3Tm11)
    End Sub

    Private Sub lblD3Tm12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm12.Click
        selColors(lblD3Tm12)
    End Sub

    Private Sub lblD3Tm12_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm12.MouseHover
        onColors(lblD3Tm12)
    End Sub

    Private Sub lblD3Tm12_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm12.MouseLeave
        offColors(lblD3Tm12)
    End Sub

    Private Sub lblD3Tm13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm13.Click
        selColors(lblD3Tm13)
    End Sub

    Private Sub lblD3Tm13_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm13.MouseHover
        onColors(lblD3Tm13)
    End Sub

    Private Sub lblD3Tm13_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm13.MouseLeave
        offColors(lblD3Tm13)
    End Sub

    Private Sub lblD3Tm14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm14.Click
        selColors(lblD3Tm14)
    End Sub

    Private Sub lblD3Tm14_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm14.MouseHover
        onColors(lblD3Tm14)
    End Sub

    Private Sub lblD3Tm14_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm14.MouseLeave
        offColors(lblD3Tm14)
    End Sub

    Private Sub lblD3Tm15_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm15.Click
        selColors(lblD3Tm15)
    End Sub

    Private Sub lblD3Tm15_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm15.MouseHover
        onColors(lblD3Tm15)
    End Sub

    Private Sub lblD3Tm15_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm15.MouseLeave
        offColors(lblD3Tm15)
    End Sub

    Private Sub lblD3Tm16_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm16.Click
        selColors(lblD3Tm16)
    End Sub

    Private Sub lblD3Tm16_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm16.MouseHover
        onColors(lblD3Tm16)
    End Sub

    Private Sub lblD3Tm16_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm16.MouseLeave
        offColors(lblD3Tm16)
    End Sub

    Private Sub lblD3Tm17_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm17.Click
        selColors(lblD3Tm17)
    End Sub

    Private Sub lblD3Tm17_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm17.MouseHover
        onColors(lblD3Tm17)
    End Sub

    Private Sub lblD3Tm17_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD3Tm17.MouseLeave
        offColors(lblD3Tm17)
    End Sub

    Private Sub lblD4Tm0_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm0.Click
        selColors(lblD4Tm0)
    End Sub

    Private Sub lblD4Tm0_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm0.MouseHover
        onColors(lblD4Tm0)
    End Sub

    Private Sub lblD4Tm0_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm0.MouseLeave
        offColors(lblD4Tm0)
    End Sub

    Private Sub lblD4Tm1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm1.Click
        selColors(lblD4Tm1)
    End Sub

    Private Sub lblD4Tm1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm1.MouseHover
        onColors(lblD4Tm1)
    End Sub

    Private Sub lblD4Tm1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm1.MouseLeave
        offColors(lblD4Tm1)
    End Sub

    Private Sub lblD4Tm2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm2.Click
        selColors(lblD4Tm2)
    End Sub

    Private Sub lblD4Tm2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm2.MouseHover
        onColors(lblD4Tm2)
    End Sub

    Private Sub lblD4Tm2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm2.MouseLeave
        offColors(lblD4Tm2)
    End Sub

    Private Sub lblD4Tm3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm3.Click
        selColors(lblD4Tm3)
    End Sub

    Private Sub lblD4Tm3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm3.MouseHover
        onColors(lblD4Tm3)
    End Sub

    Private Sub lblD4Tm3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm3.MouseLeave
        offColors(lblD4Tm3)
    End Sub

    Private Sub lblD4Tm4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm4.Click
        selColors(lblD4Tm4)
    End Sub

    Private Sub lblD4Tm4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm4.MouseHover
        onColors(lblD4Tm4)
    End Sub

    Private Sub lblD4Tm4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm4.MouseLeave
        offColors(lblD4Tm4)
    End Sub

    Private Sub lblD4Tm5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm5.Click
        selColors(lblD4Tm5)
    End Sub

    Private Sub lblD4Tm5_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm5.MouseHover
        onColors(lblD4Tm5)
    End Sub

    Private Sub lblD4Tm5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm5.MouseLeave
        offColors(lblD4Tm5)
    End Sub

    Private Sub lblD4Tm6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm6.Click
        selColors(lblD4Tm6)
    End Sub

    Private Sub lblD4Tm6_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm6.MouseHover
        onColors(lblD4Tm6)
    End Sub

    Private Sub lblD4Tm6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm6.MouseLeave
        offColors(lblD4Tm6)
    End Sub

    Private Sub lblD4Tm7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm7.Click
        selColors(lblD4Tm7)
    End Sub

    Private Sub lblD4Tm7_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm7.MouseHover
        onColors(lblD4Tm7)
    End Sub

    Private Sub lblD4Tm7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm7.MouseLeave
        offColors(lblD4Tm7)
    End Sub

    Private Sub lblD4Tm8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm8.Click
        selColors(lblD4Tm8)
    End Sub

    Private Sub lblD4Tm8_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm8.MouseHover
        onColors(lblD4Tm8)
    End Sub

    Private Sub lblD4Tm8_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm8.MouseLeave
        offColors(lblD4Tm8)
    End Sub

    Private Sub lblD4Tm9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm9.Click
        selColors(lblD4Tm9)
    End Sub

    Private Sub lblD4Tm9_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm9.MouseHover
        onColors(lblD4Tm9)
    End Sub

    Private Sub lblD4Tm9_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm9.MouseLeave
        offColors(lblD4Tm9)
    End Sub

    Private Sub lblD4Tm10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm10.Click
        selColors(lblD4Tm10)
    End Sub

    Private Sub lblD4Tm10_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm10.MouseHover
        onColors(lblD4Tm10)
    End Sub

    Private Sub lblD4Tm10_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm10.MouseLeave
        offColors(lblD4Tm10)
    End Sub

    Private Sub lblD4Tm11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm11.Click
        selColors(lblD4Tm11)
    End Sub

    Private Sub lblD4Tm11_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm11.MouseHover
        onColors(lblD4Tm11)
    End Sub

    Private Sub lblD4Tm11_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm11.MouseLeave
        offColors(lblD4Tm11)
    End Sub

    Private Sub lblD4Tm12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm12.Click
        selColors(lblD4Tm12)
    End Sub

    Private Sub lblD4Tm12_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm12.MouseHover
        onColors(lblD4Tm12)
    End Sub

    Private Sub lblD4Tm12_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm12.MouseLeave
        offColors(lblD4Tm12)
    End Sub

    Private Sub lblD4Tm13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm13.Click
        selColors(lblD4Tm13)
    End Sub

    Private Sub lblD4Tm13_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm13.MouseHover
        onColors(lblD4Tm13)
    End Sub

    Private Sub lblD4Tm13_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm13.MouseLeave
        offColors(lblD4Tm13)
    End Sub

    Private Sub lblD4Tm14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm14.Click
        selColors(lblD4Tm14)
    End Sub

    Private Sub lblD4Tm14_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm14.MouseHover
        onColors(lblD4Tm14)
    End Sub

    Private Sub lblD4Tm14_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm14.MouseLeave
        offColors(lblD4Tm14)
    End Sub

    Private Sub lblD4Tm15_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm15.Click
        selColors(lblD4Tm15)
    End Sub

    Private Sub lblD4Tm15_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm15.MouseHover
        onColors(lblD4Tm15)
    End Sub

    Private Sub lblD4Tm15_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm15.MouseLeave
        offColors(lblD4Tm15)
    End Sub

    Private Sub lblD4Tm16_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm16.Click
        selColors(lblD4Tm16)
    End Sub

    Private Sub lblD4Tm16_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm16.MouseHover
        onColors(lblD4Tm16)
    End Sub

    Private Sub lblD4Tm16_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm16.MouseLeave
        offColors(lblD4Tm16)
    End Sub

    Private Sub lblD4Tm17_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm17.Click
        selColors(lblD4Tm17)
    End Sub

    Private Sub lblD4Tm17_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm17.MouseHover
        onColors(lblD4Tm17)
    End Sub

    Private Sub lblD4Tm17_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblD4Tm17.MouseLeave
        offColors(lblD4Tm17)
    End Sub

#End Region

    Private Function onColors(ByVal theObj As Object)
        'theObj.BackColor = System.Drawing.Color.Blue
        'theObj.ForeColor = System.Drawing.Color.White
        theObj.ForeColor = System.Drawing.Color.Blue
        theObj.Cursor = Cursors.Hand
    End Function

    Private Function offColors(ByVal theObj As Object)
        If selFlag = False Then
            theObj.BackColor = System.Drawing.Color.WhiteSmoke
            theObj.ForeColor = System.Drawing.Color.Black
        Else
            theObj.ForeColor = System.Drawing.Color.White
        End If
    End Function

    Private Function selColors(ByVal theObj As Object)
        theObj.BackColor = System.Drawing.Color.Red
        theObj.ForeColor = System.Drawing.Color.White
        selFlag = True
    End Function

    Private Function setDayLabels(ByVal startDate As DateTime)
        Dim startDay As Integer = startDate.DayOfWeek
        Select Case startDay
            Case Is = 0
                lblDay0.Text = "Sun"
                lblDay1.Text = "Mon"
                lblDay2.Text = "Tue"
                lblDay3.Text = "Wed"
                lblDay4.Text = "Thu"
            Case Is = 1
                lblDay0.Text = "Mon"
                lblDay1.Text = "Tue"
                lblDay2.Text = "Wed"
                lblDay3.Text = "Thu"
                lblDay4.Text = "Fri"
            Case Is = 2
                lblDay0.Text = "Tue"
                lblDay1.Text = "Wed"
                lblDay2.Text = "Thu"
                lblDay3.Text = "Fri"
                lblDay4.Text = "Sat"
            Case Is = 3
                lblDay0.Text = "Wed"
                lblDay1.Text = "Thu"
                lblDay2.Text = "Fri"
                lblDay3.Text = "Sat"
                lblDay4.Text = "Sun"
            Case Is = 4
                lblDay0.Text = "Thu"
                lblDay1.Text = "Fri"
                lblDay2.Text = "Sat"
                lblDay3.Text = "Sun"
                lblDay4.Text = "Mon"
            Case Is = 5
                lblDay0.Text = "Fri"
                lblDay1.Text = "Sat"
                lblDay2.Text = "Sun"
                lblDay3.Text = "Mon"
                lblDay4.Text = "Tue"
            Case Is = 6
                lblDay0.Text = "Sat"
                lblDay1.Text = "Sun"
                lblDay2.Text = "Mon"
                lblDay3.Text = "Tue"
                lblDay4.Text = "Wed"
        End Select
    End Function

    Private Function setMonthLabel(ByVal startDate As DateTime)
        Dim StartMonth As Integer = startDate.Month
        Select Case StartMonth
            Case Is = 1
                lblMonth.Text = "January"
            Case Is = 2
                lblMonth.Text = "February"
            Case Is = 3
                lblMonth.Text = "March"
            Case Is = 4
                lblMonth.Text = "April"
            Case Is = 5
                lblMonth.Text = "May"
            Case Is = 6
                lblMonth.Text = "June"
            Case Is = 7
                lblMonth.Text = "July"
            Case Is = 8
                lblMonth.Text = "August"
            Case Is = 9
                lblMonth.Text = "September"
            Case Is = 10
                lblMonth.Text = "October"
            Case Is = 11
                lblMonth.Text = "November"
            Case Is = 12
                lblMonth.Text = "December"
        End Select
    End Function

    Private Function loadDayTimes(ByVal startDate As DateTime)
        Dim objread As OleDbDataReader
        Dim oledbcon As New OleDbConnection(dbCon)
        Dim myDateTimeValue As String
        Dim myDate As DateTime
        Dim tempDate As DateTime = DateTime.Parse(startDate)
        Dim StartDay As Integer = tempDate.Day
        Dim theFormats As String()
        setMonthLabel(tempDate)
        setDayLabels(tempDate)
        theFormats = tempDate.AddDays(7).GetDateTimeFormats()
        Dim endDate As String = theFormats(73)

        Try
            oledbcon.Open()

            sql = "SELECT Appointment FROM Appointment WHERE Appointment > '" + startDate + "' AND Appointment < '" + endDate + "' ORDER BY Appointment"
            Dim cmd As OleDbCommand = New OleDbCommand(sql, oledbcon)
            objread = cmd.ExecuteReader

            Dim iCounter, jCounter As Integer
            Dim tm0, tm1, tm2, tm3, tm4, tm5, tm6, tm7, tm8, tm9, tm10, tm11, tm12, tm13, tm14, tm15, tm16, tm17 As Integer
            Dim fCounter() As Object = {tm0, tm1, tm2, tm3, tm4, tm5, tm6, tm7, tm8, tm9, tm10, tm11, tm12, tm13, tm14, tm15, tm16, tm17}
            Dim txtCounter() As Object = {lblD0Tm0, lblD0Tm1, lblD0Tm2, lblD0Tm3, lblD0Tm4, lblD0Tm5, lblD0Tm6, lblD0Tm7, lblD0Tm8, lblD0Tm9, lblD0Tm10, lblD0Tm11, lblD0Tm12, lblD0Tm13, lblD0Tm14, lblD0Tm15, lblD0Tm16, lblD0Tm17}
            For iCounter = 0 To UBound(blockOut)
                txtCounter(blockOut(iCounter)).Enabled = False
            Next

            Dim theDay As Integer
            Dim tCounter As Integer
            For tCounter = 0 To 6
                theDay = tempDate.AddDays(tCounter).Day
                For jCounter = 0 To 17
                    While objread.Read
                        For iCounter = 0 To objread.FieldCount() - 1
                            myDate = DateTime.Parse(objread.GetValue(iCounter))
                            Dim year As Integer = myDate.Year
                            Dim month As Integer = myDate.Month
                            Dim day As Integer = myDate.Day
                            Dim hour As String = myDate.Hour
                            Dim minute As String = myDate.Minute
                            Dim second As Integer = myDate.Second
                            Dim theTime As String = hour + ":" + minute
                            If (theDay = day) Then
                                If (txtCounter(jCounter).Text = theTime) Then
                                    fCounter(jCounter) += 1
                                    If (fCounter(jCounter) >= 3) Then
                                        txtCounter(jCounter).Enabled = False
                                    End If
                                End If
                            End If
                        Next
                    End While
                    objread.Close()
                    objread = cmd.ExecuteReader
                Next
            Next

            objread.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            oledbcon.Close()
        End Try
    End Function

    Private Sub calAppointment_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles calAppointment.DateChanged
        loadDayTimes(calAppointment.SelectionStart.Date)
    End Sub
End Class
