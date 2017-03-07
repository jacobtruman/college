Public Class frmTimeBlocks
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
    Friend WithEvents dtpException As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblMonday As System.Windows.Forms.Label
    Friend WithEvents lblTuesday As System.Windows.Forms.Label
    Friend WithEvents lblThursday As System.Windows.Forms.Label
    Friend WithEvents lblFriday As System.Windows.Forms.Label
    Friend WithEvents lblFirst As System.Windows.Forms.Label
    Friend WithEvents grpDays As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblException As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMonFirst As System.Windows.Forms.TextBox
    Friend WithEvents txtMonBL As System.Windows.Forms.TextBox
    Friend WithEvents txtMonAL As System.Windows.Forms.TextBox
    Friend WithEvents txtMonLast As System.Windows.Forms.TextBox
    Friend WithEvents txtTuesLast As System.Windows.Forms.TextBox
    Friend WithEvents txtTuesAL As System.Windows.Forms.TextBox
    Friend WithEvents txtTuesBL As System.Windows.Forms.TextBox
    Friend WithEvents txtTuesFirst As System.Windows.Forms.TextBox
    Friend WithEvents txtThursLast As System.Windows.Forms.TextBox
    Friend WithEvents txtThursAL As System.Windows.Forms.TextBox
    Friend WithEvents txtThursBL As System.Windows.Forms.TextBox
    Friend WithEvents txtThursFirst As System.Windows.Forms.TextBox
    Friend WithEvents txtFriLast As System.Windows.Forms.TextBox
    Friend WithEvents txtFriAL As System.Windows.Forms.TextBox
    Friend WithEvents txtFriBL As System.Windows.Forms.TextBox
    Friend WithEvents txtFriFirst As System.Windows.Forms.TextBox
    Friend WithEvents txtExceptLast As System.Windows.Forms.TextBox
    Friend WithEvents txtExceptAL As System.Windows.Forms.TextBox
    Friend WithEvents txtExceptBL As System.Windows.Forms.TextBox
    Friend WithEvents txtExceptFirst As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dtpException = New System.Windows.Forms.DateTimePicker
        Me.txtMonFirst = New System.Windows.Forms.TextBox
        Me.txtMonBL = New System.Windows.Forms.TextBox
        Me.txtMonAL = New System.Windows.Forms.TextBox
        Me.txtMonLast = New System.Windows.Forms.TextBox
        Me.txtTuesLast = New System.Windows.Forms.TextBox
        Me.txtTuesAL = New System.Windows.Forms.TextBox
        Me.txtTuesBL = New System.Windows.Forms.TextBox
        Me.txtTuesFirst = New System.Windows.Forms.TextBox
        Me.txtThursLast = New System.Windows.Forms.TextBox
        Me.txtThursAL = New System.Windows.Forms.TextBox
        Me.txtThursBL = New System.Windows.Forms.TextBox
        Me.txtThursFirst = New System.Windows.Forms.TextBox
        Me.txtFriLast = New System.Windows.Forms.TextBox
        Me.txtFriAL = New System.Windows.Forms.TextBox
        Me.txtFriBL = New System.Windows.Forms.TextBox
        Me.txtFriFirst = New System.Windows.Forms.TextBox
        Me.lblMonday = New System.Windows.Forms.Label
        Me.lblTuesday = New System.Windows.Forms.Label
        Me.lblThursday = New System.Windows.Forms.Label
        Me.lblFriday = New System.Windows.Forms.Label
        Me.lblFirst = New System.Windows.Forms.Label
        Me.grpDays = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblException = New System.Windows.Forms.Label
        Me.txtExceptLast = New System.Windows.Forms.TextBox
        Me.txtExceptAL = New System.Windows.Forms.TextBox
        Me.txtExceptBL = New System.Windows.Forms.TextBox
        Me.txtExceptFirst = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.grpDays.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpException
        '
        Me.dtpException.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpException.Location = New System.Drawing.Point(144, 320)
        Me.dtpException.MinDate = New Date(2006, 1, 1, 0, 0, 0, 0)
        Me.dtpException.Name = "dtpException"
        Me.dtpException.Size = New System.Drawing.Size(328, 32)
        Me.dtpException.TabIndex = 33
        '
        'txtMonFirst
        '
        Me.txtMonFirst.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonFirst.Location = New System.Drawing.Point(144, 96)
        Me.txtMonFirst.Name = "txtMonFirst"
        Me.txtMonFirst.Size = New System.Drawing.Size(120, 32)
        Me.txtMonFirst.TabIndex = 38
        Me.txtMonFirst.Text = ""
        '
        'txtMonBL
        '
        Me.txtMonBL.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonBL.Location = New System.Drawing.Point(280, 96)
        Me.txtMonBL.Name = "txtMonBL"
        Me.txtMonBL.Size = New System.Drawing.Size(120, 32)
        Me.txtMonBL.TabIndex = 39
        Me.txtMonBL.Text = ""
        '
        'txtMonAL
        '
        Me.txtMonAL.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonAL.Location = New System.Drawing.Point(416, 96)
        Me.txtMonAL.Name = "txtMonAL"
        Me.txtMonAL.Size = New System.Drawing.Size(120, 32)
        Me.txtMonAL.TabIndex = 40
        Me.txtMonAL.Text = ""
        '
        'txtMonLast
        '
        Me.txtMonLast.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonLast.Location = New System.Drawing.Point(552, 96)
        Me.txtMonLast.Name = "txtMonLast"
        Me.txtMonLast.Size = New System.Drawing.Size(120, 32)
        Me.txtMonLast.TabIndex = 41
        Me.txtMonLast.Text = ""
        '
        'txtTuesLast
        '
        Me.txtTuesLast.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTuesLast.Location = New System.Drawing.Point(552, 152)
        Me.txtTuesLast.Name = "txtTuesLast"
        Me.txtTuesLast.Size = New System.Drawing.Size(120, 32)
        Me.txtTuesLast.TabIndex = 45
        Me.txtTuesLast.Text = ""
        '
        'txtTuesAL
        '
        Me.txtTuesAL.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTuesAL.Location = New System.Drawing.Point(416, 152)
        Me.txtTuesAL.Name = "txtTuesAL"
        Me.txtTuesAL.Size = New System.Drawing.Size(120, 32)
        Me.txtTuesAL.TabIndex = 44
        Me.txtTuesAL.Text = ""
        '
        'txtTuesBL
        '
        Me.txtTuesBL.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTuesBL.Location = New System.Drawing.Point(280, 152)
        Me.txtTuesBL.Name = "txtTuesBL"
        Me.txtTuesBL.Size = New System.Drawing.Size(120, 32)
        Me.txtTuesBL.TabIndex = 43
        Me.txtTuesBL.Text = ""
        '
        'txtTuesFirst
        '
        Me.txtTuesFirst.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTuesFirst.Location = New System.Drawing.Point(144, 152)
        Me.txtTuesFirst.Name = "txtTuesFirst"
        Me.txtTuesFirst.Size = New System.Drawing.Size(120, 32)
        Me.txtTuesFirst.TabIndex = 42
        Me.txtTuesFirst.Text = ""
        '
        'txtThursLast
        '
        Me.txtThursLast.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThursLast.Location = New System.Drawing.Point(552, 208)
        Me.txtThursLast.Name = "txtThursLast"
        Me.txtThursLast.Size = New System.Drawing.Size(120, 32)
        Me.txtThursLast.TabIndex = 49
        Me.txtThursLast.Text = ""
        '
        'txtThursAL
        '
        Me.txtThursAL.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThursAL.Location = New System.Drawing.Point(416, 208)
        Me.txtThursAL.Name = "txtThursAL"
        Me.txtThursAL.Size = New System.Drawing.Size(120, 32)
        Me.txtThursAL.TabIndex = 48
        Me.txtThursAL.Text = ""
        '
        'txtThursBL
        '
        Me.txtThursBL.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThursBL.Location = New System.Drawing.Point(280, 208)
        Me.txtThursBL.Name = "txtThursBL"
        Me.txtThursBL.Size = New System.Drawing.Size(120, 32)
        Me.txtThursBL.TabIndex = 47
        Me.txtThursBL.Text = ""
        '
        'txtThursFirst
        '
        Me.txtThursFirst.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThursFirst.Location = New System.Drawing.Point(144, 208)
        Me.txtThursFirst.Name = "txtThursFirst"
        Me.txtThursFirst.Size = New System.Drawing.Size(120, 32)
        Me.txtThursFirst.TabIndex = 46
        Me.txtThursFirst.Text = ""
        '
        'txtFriLast
        '
        Me.txtFriLast.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFriLast.Location = New System.Drawing.Point(552, 264)
        Me.txtFriLast.Name = "txtFriLast"
        Me.txtFriLast.Size = New System.Drawing.Size(120, 32)
        Me.txtFriLast.TabIndex = 53
        Me.txtFriLast.Text = ""
        '
        'txtFriAL
        '
        Me.txtFriAL.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFriAL.Location = New System.Drawing.Point(416, 264)
        Me.txtFriAL.Name = "txtFriAL"
        Me.txtFriAL.Size = New System.Drawing.Size(120, 32)
        Me.txtFriAL.TabIndex = 52
        Me.txtFriAL.Text = ""
        '
        'txtFriBL
        '
        Me.txtFriBL.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFriBL.Location = New System.Drawing.Point(280, 264)
        Me.txtFriBL.Name = "txtFriBL"
        Me.txtFriBL.Size = New System.Drawing.Size(120, 32)
        Me.txtFriBL.TabIndex = 51
        Me.txtFriBL.Text = ""
        '
        'txtFriFirst
        '
        Me.txtFriFirst.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFriFirst.Location = New System.Drawing.Point(144, 264)
        Me.txtFriFirst.Name = "txtFriFirst"
        Me.txtFriFirst.Size = New System.Drawing.Size(120, 32)
        Me.txtFriFirst.TabIndex = 50
        Me.txtFriFirst.Text = ""
        '
        'lblMonday
        '
        Me.lblMonday.BackColor = System.Drawing.Color.Transparent
        Me.lblMonday.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonday.Location = New System.Drawing.Point(0, 48)
        Me.lblMonday.Name = "lblMonday"
        Me.lblMonday.Size = New System.Drawing.Size(120, 23)
        Me.lblMonday.TabIndex = 54
        Me.lblMonday.Text = "Monday:"
        Me.lblMonday.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTuesday
        '
        Me.lblTuesday.BackColor = System.Drawing.Color.Transparent
        Me.lblTuesday.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTuesday.Location = New System.Drawing.Point(0, 104)
        Me.lblTuesday.Name = "lblTuesday"
        Me.lblTuesday.Size = New System.Drawing.Size(120, 23)
        Me.lblTuesday.TabIndex = 55
        Me.lblTuesday.Text = "Tuesday:"
        Me.lblTuesday.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblThursday
        '
        Me.lblThursday.BackColor = System.Drawing.Color.Transparent
        Me.lblThursday.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThursday.Location = New System.Drawing.Point(0, 160)
        Me.lblThursday.Name = "lblThursday"
        Me.lblThursday.Size = New System.Drawing.Size(120, 23)
        Me.lblThursday.TabIndex = 56
        Me.lblThursday.Text = "Thursday:"
        Me.lblThursday.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFriday
        '
        Me.lblFriday.BackColor = System.Drawing.Color.Transparent
        Me.lblFriday.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFriday.Location = New System.Drawing.Point(0, 216)
        Me.lblFriday.Name = "lblFriday"
        Me.lblFriday.Size = New System.Drawing.Size(120, 23)
        Me.lblFriday.TabIndex = 57
        Me.lblFriday.Text = "Friday:"
        Me.lblFriday.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFirst
        '
        Me.lblFirst.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirst.Location = New System.Drawing.Point(8, 56)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(104, 23)
        Me.lblFirst.TabIndex = 58
        Me.lblFirst.Text = "First"
        Me.lblFirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpDays
        '
        Me.grpDays.Controls.Add(Me.lblFriday)
        Me.grpDays.Controls.Add(Me.lblThursday)
        Me.grpDays.Controls.Add(Me.lblMonday)
        Me.grpDays.Controls.Add(Me.lblTuesday)
        Me.grpDays.Controls.Add(Me.lblException)
        Me.grpDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDays.Location = New System.Drawing.Point(16, 56)
        Me.grpDays.Name = "grpDays"
        Me.grpDays.Size = New System.Drawing.Size(120, 312)
        Me.grpDays.TabIndex = 59
        Me.grpDays.TabStop = False
        Me.grpDays.Text = "Day"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblFirst)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(144, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(536, 88)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Appointment"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(408, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 23)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Last"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(136, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 48)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Before Lunch"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblException
        '
        Me.lblException.BackColor = System.Drawing.Color.Transparent
        Me.lblException.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblException.Location = New System.Drawing.Point(-8, 272)
        Me.lblException.Name = "lblException"
        Me.lblException.Size = New System.Drawing.Size(128, 23)
        Me.lblException.TabIndex = 59
        Me.lblException.Text = "Exception:"
        Me.lblException.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtExceptLast
        '
        Me.txtExceptLast.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExceptLast.Location = New System.Drawing.Point(552, 376)
        Me.txtExceptLast.Name = "txtExceptLast"
        Me.txtExceptLast.Size = New System.Drawing.Size(120, 32)
        Me.txtExceptLast.TabIndex = 64
        Me.txtExceptLast.Text = ""
        '
        'txtExceptAL
        '
        Me.txtExceptAL.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExceptAL.Location = New System.Drawing.Point(416, 376)
        Me.txtExceptAL.Name = "txtExceptAL"
        Me.txtExceptAL.Size = New System.Drawing.Size(120, 32)
        Me.txtExceptAL.TabIndex = 63
        Me.txtExceptAL.Text = ""
        '
        'txtExceptBL
        '
        Me.txtExceptBL.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExceptBL.Location = New System.Drawing.Point(280, 376)
        Me.txtExceptBL.Name = "txtExceptBL"
        Me.txtExceptBL.Size = New System.Drawing.Size(120, 32)
        Me.txtExceptBL.TabIndex = 62
        Me.txtExceptBL.Text = ""
        '
        'txtExceptFirst
        '
        Me.txtExceptFirst.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExceptFirst.Location = New System.Drawing.Point(144, 376)
        Me.txtExceptFirst.Name = "txtExceptFirst"
        Me.txtExceptFirst.Size = New System.Drawing.Size(120, 32)
        Me.txtExceptFirst.TabIndex = 61
        Me.txtExceptFirst.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(272, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 48)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "After Lunch"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.MistyRose
        Me.btnCancel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(312, 424)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(168, 56)
        Me.btnCancel.TabIndex = 65
        Me.btnCancel.Text = "Cancel"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.MistyRose
        Me.btnUpdate.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(504, 424)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(168, 56)
        Me.btnUpdate.TabIndex = 66
        Me.btnUpdate.Text = "Update"
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.MistyRose
        Me.btnRefresh.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(120, 424)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(168, 56)
        Me.btnRefresh.TabIndex = 67
        Me.btnRefresh.Text = "Refresh"
        '
        'frmTimeBlocks
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(696, 494)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtExceptLast)
        Me.Controls.Add(Me.txtExceptAL)
        Me.Controls.Add(Me.txtExceptBL)
        Me.Controls.Add(Me.txtExceptFirst)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpDays)
        Me.Controls.Add(Me.txtFriLast)
        Me.Controls.Add(Me.txtFriAL)
        Me.Controls.Add(Me.txtFriBL)
        Me.Controls.Add(Me.txtFriFirst)
        Me.Controls.Add(Me.txtThursLast)
        Me.Controls.Add(Me.txtThursAL)
        Me.Controls.Add(Me.txtThursBL)
        Me.Controls.Add(Me.txtThursFirst)
        Me.Controls.Add(Me.txtTuesLast)
        Me.Controls.Add(Me.txtTuesAL)
        Me.Controls.Add(Me.txtTuesBL)
        Me.Controls.Add(Me.txtTuesFirst)
        Me.Controls.Add(Me.txtMonLast)
        Me.Controls.Add(Me.txtMonAL)
        Me.Controls.Add(Me.txtMonBL)
        Me.Controls.Add(Me.txtMonFirst)
        Me.Controls.Add(Me.dtpException)
        Me.Name = "frmTimeBlocks"
        Me.Text = "COB Advising - Manage Time Blocks"
        Me.grpDays.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmTimeBlocks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsForms.frmTimeBlocks = Me
    End Sub

    Private Sub frmTimeBlocks_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        clsForms.frmAdminFunctions.Visible = True
    End Sub

End Class
