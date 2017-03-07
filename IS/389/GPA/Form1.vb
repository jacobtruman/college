Public Class MainForm
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lboxGCode As System.Windows.Forms.ListBox
    Friend WithEvents lblIDTitle As System.Windows.Forms.Label
    Friend WithEvents lblNameTitle As System.Windows.Forms.Label
    Friend WithEvents lblGCodeTitle As System.Windows.Forms.Label
    Friend WithEvents lboxLnum As System.Windows.Forms.ListBox
    Friend WithEvents lboxName As System.Windows.Forms.ListBox
    Friend WithEvents lboxPercent As System.Windows.Forms.ListBox
    Friend WithEvents lboxGrade As System.Windows.Forms.ListBox
    Friend WithEvents lblPercentTitle As System.Windows.Forms.Label
    Friend WithEvents lblRunningGPA As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnTests As System.Windows.Forms.Button
    Friend WithEvents btnStudents As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAssignments As System.Windows.Forms.Button
    Friend WithEvents lblDs As System.Windows.Forms.Label
    Friend WithEvents lblBs As System.Windows.Forms.Label
    Friend WithEvents lblAs As System.Windows.Forms.Label
    Friend WithEvents lblFs As System.Windows.Forms.Label
    Friend WithEvents lblCs As System.Windows.Forms.Label
    Friend WithEvents lblGraphSub As System.Windows.Forms.Label
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents lblLName As System.Windows.Forms.Label
    Friend WithEvents lblFName As System.Windows.Forms.Label
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents txtGCode As System.Windows.Forms.TextBox
    Friend WithEvents lblLNumber As System.Windows.Forms.Label
    Friend WithEvents txtLnum As System.Windows.Forms.TextBox
    Friend WithEvents gboxInput As System.Windows.Forms.GroupBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents lblGCode As System.Windows.Forms.Label
    Friend WithEvents txtAssignMax As System.Windows.Forms.TextBox
    Friend WithEvents lblAssignMax As System.Windows.Forms.Label
    Friend WithEvents lblAssignNum As System.Windows.Forms.Label
    Friend WithEvents txtAssignNum As System.Windows.Forms.TextBox
    Friend WithEvents btnGrades As System.Windows.Forms.Button
    Friend WithEvents lblGrade As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnTests = New System.Windows.Forms.Button
        Me.btnStudents = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnModify = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.lboxLnum = New System.Windows.Forms.ListBox
        Me.lboxName = New System.Windows.Forms.ListBox
        Me.lboxGCode = New System.Windows.Forms.ListBox
        Me.lboxPercent = New System.Windows.Forms.ListBox
        Me.lboxGrade = New System.Windows.Forms.ListBox
        Me.lblTitle = New System.Windows.Forms.Label
        Me.lblIDTitle = New System.Windows.Forms.Label
        Me.btnAssignments = New System.Windows.Forms.Button
        Me.lblNameTitle = New System.Windows.Forms.Label
        Me.lblGCodeTitle = New System.Windows.Forms.Label
        Me.lblPercentTitle = New System.Windows.Forms.Label
        Me.lblGrade = New System.Windows.Forms.Label
        Me.lblRunningGPA = New System.Windows.Forms.Label
        Me.lblDs = New System.Windows.Forms.Label
        Me.lblBs = New System.Windows.Forms.Label
        Me.lblAs = New System.Windows.Forms.Label
        Me.lblFs = New System.Windows.Forms.Label
        Me.lblCs = New System.Windows.Forms.Label
        Me.lblGraphSub = New System.Windows.Forms.Label
        Me.gboxInput = New System.Windows.Forms.GroupBox
        Me.btnSubmit = New System.Windows.Forms.Button
        Me.txtGCode = New System.Windows.Forms.TextBox
        Me.lblGCode = New System.Windows.Forms.Label
        Me.lblLNumber = New System.Windows.Forms.Label
        Me.txtLnum = New System.Windows.Forms.TextBox
        Me.txtFName = New System.Windows.Forms.TextBox
        Me.lblFName = New System.Windows.Forms.Label
        Me.lblLName = New System.Windows.Forms.Label
        Me.txtLName = New System.Windows.Forms.TextBox
        Me.txtAssignMax = New System.Windows.Forms.TextBox
        Me.lblAssignMax = New System.Windows.Forms.Label
        Me.lblAssignNum = New System.Windows.Forms.Label
        Me.txtAssignNum = New System.Windows.Forms.TextBox
        Me.btnGrades = New System.Windows.Forms.Button
        Me.gboxInput.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnTests
        '
        Me.btnTests.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTests.Location = New System.Drawing.Point(8, 120)
        Me.btnTests.Name = "btnTests"
        Me.btnTests.TabIndex = 3
        Me.btnTests.Text = "Tests"
        '
        'btnStudents
        '
        Me.btnStudents.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudents.Location = New System.Drawing.Point(8, 24)
        Me.btnStudents.Name = "btnStudents"
        Me.btnStudents.TabIndex = 0
        Me.btnStudents.Text = "Students"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(8, 304)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        '
        'btnModify
        '
        Me.btnModify.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.Location = New System.Drawing.Point(8, 336)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.TabIndex = 5
        Me.btnModify.Text = "Modify"
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(8, 368)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Delete"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(664, 368)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        '
        'lboxLnum
        '
        Me.lboxLnum.BackColor = System.Drawing.Color.White
        Me.lboxLnum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lboxLnum.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboxLnum.ItemHeight = 14
        Me.lboxLnum.Location = New System.Drawing.Point(96, 24)
        Me.lboxLnum.Name = "lboxLnum"
        Me.lboxLnum.Size = New System.Drawing.Size(64, 364)
        Me.lboxLnum.TabIndex = 8
        '
        'lboxName
        '
        Me.lboxName.BackColor = System.Drawing.Color.White
        Me.lboxName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lboxName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboxName.ItemHeight = 14
        Me.lboxName.Location = New System.Drawing.Point(232, 24)
        Me.lboxName.Name = "lboxName"
        Me.lboxName.Size = New System.Drawing.Size(104, 364)
        Me.lboxName.TabIndex = 10
        '
        'lboxGCode
        '
        Me.lboxGCode.BackColor = System.Drawing.Color.White
        Me.lboxGCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lboxGCode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboxGCode.ItemHeight = 14
        Me.lboxGCode.Location = New System.Drawing.Point(160, 24)
        Me.lboxGCode.Name = "lboxGCode"
        Me.lboxGCode.Size = New System.Drawing.Size(72, 364)
        Me.lboxGCode.TabIndex = 9
        '
        'lboxPercent
        '
        Me.lboxPercent.BackColor = System.Drawing.Color.White
        Me.lboxPercent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lboxPercent.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboxPercent.ItemHeight = 14
        Me.lboxPercent.Location = New System.Drawing.Point(336, 24)
        Me.lboxPercent.Name = "lboxPercent"
        Me.lboxPercent.Size = New System.Drawing.Size(40, 364)
        Me.lboxPercent.TabIndex = 11
        '
        'lboxGrade
        '
        Me.lboxGrade.BackColor = System.Drawing.Color.White
        Me.lboxGrade.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lboxGrade.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboxGrade.ItemHeight = 14
        Me.lboxGrade.Location = New System.Drawing.Point(376, 24)
        Me.lboxGrade.Name = "lboxGrade"
        Me.lboxGrade.Size = New System.Drawing.Size(40, 364)
        Me.lboxGrade.TabIndex = 12
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(432, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(304, 72)
        Me.lblTitle.TabIndex = 55
        Me.lblTitle.Text = "Student GPA Calculator"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIDTitle
        '
        Me.lblIDTitle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDTitle.Location = New System.Drawing.Point(96, 0)
        Me.lblIDTitle.Name = "lblIDTitle"
        Me.lblIDTitle.Size = New System.Drawing.Size(64, 23)
        Me.lblIDTitle.TabIndex = 55
        Me.lblIDTitle.Text = "L Num"
        Me.lblIDTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAssignments
        '
        Me.btnAssignments.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssignments.Location = New System.Drawing.Point(8, 88)
        Me.btnAssignments.Name = "btnAssignments"
        Me.btnAssignments.TabIndex = 2
        Me.btnAssignments.Text = "Assignments"
        '
        'lblNameTitle
        '
        Me.lblNameTitle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameTitle.Location = New System.Drawing.Point(232, 0)
        Me.lblNameTitle.Name = "lblNameTitle"
        Me.lblNameTitle.Size = New System.Drawing.Size(104, 23)
        Me.lblNameTitle.TabIndex = 55
        Me.lblNameTitle.Text = "Name"
        Me.lblNameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGCodeTitle
        '
        Me.lblGCodeTitle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGCodeTitle.Location = New System.Drawing.Point(160, 0)
        Me.lblGCodeTitle.Name = "lblGCodeTitle"
        Me.lblGCodeTitle.Size = New System.Drawing.Size(72, 23)
        Me.lblGCodeTitle.TabIndex = 55
        Me.lblGCodeTitle.Text = "Grade Code"
        Me.lblGCodeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPercentTitle
        '
        Me.lblPercentTitle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentTitle.Location = New System.Drawing.Point(336, 0)
        Me.lblPercentTitle.Name = "lblPercentTitle"
        Me.lblPercentTitle.Size = New System.Drawing.Size(40, 23)
        Me.lblPercentTitle.TabIndex = 55
        Me.lblPercentTitle.Text = "%"
        Me.lblPercentTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGrade
        '
        Me.lblGrade.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrade.Location = New System.Drawing.Point(376, 0)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(40, 23)
        Me.lblGrade.TabIndex = 55
        Me.lblGrade.Text = "Grade"
        Me.lblGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRunningGPA
        '
        Me.lblRunningGPA.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRunningGPA.Location = New System.Drawing.Point(480, 360)
        Me.lblRunningGPA.Name = "lblRunningGPA"
        Me.lblRunningGPA.Size = New System.Drawing.Size(120, 32)
        Me.lblRunningGPA.TabIndex = 55
        Me.lblRunningGPA.Text = "Class GPA"
        Me.lblRunningGPA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDs
        '
        Me.lblDs.BackColor = System.Drawing.Color.Green
        Me.lblDs.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDs.Location = New System.Drawing.Point(488, 96)
        Me.lblDs.Name = "lblDs"
        Me.lblDs.Size = New System.Drawing.Size(48, 16)
        Me.lblDs.TabIndex = 55
        Me.lblDs.Text = "D's"
        Me.lblDs.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblBs
        '
        Me.lblBs.BackColor = System.Drawing.Color.Green
        Me.lblBs.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBs.Location = New System.Drawing.Point(616, 96)
        Me.lblBs.Name = "lblBs"
        Me.lblBs.Size = New System.Drawing.Size(48, 16)
        Me.lblBs.TabIndex = 55
        Me.lblBs.Text = "B's"
        Me.lblBs.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblAs
        '
        Me.lblAs.BackColor = System.Drawing.Color.Green
        Me.lblAs.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAs.Location = New System.Drawing.Point(680, 96)
        Me.lblAs.Name = "lblAs"
        Me.lblAs.Size = New System.Drawing.Size(48, 16)
        Me.lblAs.TabIndex = 55
        Me.lblAs.Text = "A's"
        Me.lblAs.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblFs
        '
        Me.lblFs.BackColor = System.Drawing.Color.Green
        Me.lblFs.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFs.Location = New System.Drawing.Point(424, 96)
        Me.lblFs.Name = "lblFs"
        Me.lblFs.Size = New System.Drawing.Size(48, 16)
        Me.lblFs.TabIndex = 55
        Me.lblFs.Text = "F's"
        Me.lblFs.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblCs
        '
        Me.lblCs.BackColor = System.Drawing.Color.Green
        Me.lblCs.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCs.Location = New System.Drawing.Point(552, 96)
        Me.lblCs.Name = "lblCs"
        Me.lblCs.Size = New System.Drawing.Size(48, 256)
        Me.lblCs.TabIndex = 55
        Me.lblCs.Text = "C's"
        Me.lblCs.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblGraphSub
        '
        Me.lblGraphSub.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGraphSub.Location = New System.Drawing.Point(520, 72)
        Me.lblGraphSub.Name = "lblGraphSub"
        Me.lblGraphSub.TabIndex = 55
        Me.lblGraphSub.Text = "Grade Graph"
        Me.lblGraphSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gboxInput
        '
        Me.gboxInput.Controls.Add(Me.btnSubmit)
        Me.gboxInput.Controls.Add(Me.txtGCode)
        Me.gboxInput.Controls.Add(Me.lblGCode)
        Me.gboxInput.Controls.Add(Me.lblLNumber)
        Me.gboxInput.Controls.Add(Me.txtLnum)
        Me.gboxInput.Controls.Add(Me.txtFName)
        Me.gboxInput.Controls.Add(Me.lblFName)
        Me.gboxInput.Controls.Add(Me.lblLName)
        Me.gboxInput.Controls.Add(Me.txtLName)
        Me.gboxInput.Controls.Add(Me.txtAssignMax)
        Me.gboxInput.Controls.Add(Me.lblAssignMax)
        Me.gboxInput.Controls.Add(Me.lblAssignNum)
        Me.gboxInput.Controls.Add(Me.txtAssignNum)
        Me.gboxInput.Location = New System.Drawing.Point(136, 96)
        Me.gboxInput.Name = "gboxInput"
        Me.gboxInput.Size = New System.Drawing.Size(248, 160)
        Me.gboxInput.TabIndex = 55
        Me.gboxInput.TabStop = False
        Me.gboxInput.Text = "Submit/Update"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(160, 120)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.TabIndex = 26
        Me.btnSubmit.Text = "Submit"
        '
        'txtGCode
        '
        Me.txtGCode.Location = New System.Drawing.Point(136, 40)
        Me.txtGCode.Name = "txtGCode"
        Me.txtGCode.Size = New System.Drawing.Size(0, 20)
        Me.txtGCode.TabIndex = 21
        Me.txtGCode.Text = ""
        '
        'lblGCode
        '
        Me.lblGCode.Location = New System.Drawing.Point(16, 40)
        Me.lblGCode.Name = "lblGCode"
        Me.lblGCode.Size = New System.Drawing.Size(0, 0)
        Me.lblGCode.TabIndex = 55
        Me.lblGCode.Text = "Grade Code"
        Me.lblGCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLNumber
        '
        Me.lblLNumber.Location = New System.Drawing.Point(16, 16)
        Me.lblLNumber.Name = "lblLNumber"
        Me.lblLNumber.Size = New System.Drawing.Size(0, 0)
        Me.lblLNumber.TabIndex = 55
        Me.lblLNumber.Text = "L Number"
        Me.lblLNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLnum
        '
        Me.txtLnum.Location = New System.Drawing.Point(136, 16)
        Me.txtLnum.Name = "txtLnum"
        Me.txtLnum.Size = New System.Drawing.Size(0, 20)
        Me.txtLnum.TabIndex = 20
        Me.txtLnum.Text = ""
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(136, 88)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(0, 20)
        Me.txtFName.TabIndex = 23
        Me.txtFName.Text = ""
        '
        'lblFName
        '
        Me.lblFName.Location = New System.Drawing.Point(16, 88)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(0, 0)
        Me.lblFName.TabIndex = 55
        Me.lblFName.Text = "First name"
        Me.lblFName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLName
        '
        Me.lblLName.Location = New System.Drawing.Point(16, 64)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(0, 0)
        Me.lblLName.TabIndex = 55
        Me.lblLName.Text = "Last name"
        Me.lblLName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(136, 64)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(0, 20)
        Me.txtLName.TabIndex = 22
        Me.txtLName.Text = ""
        '
        'txtAssignMax
        '
        Me.txtAssignMax.Location = New System.Drawing.Point(136, 40)
        Me.txtAssignMax.Name = "txtAssignMax"
        Me.txtAssignMax.TabIndex = 25
        Me.txtAssignMax.Text = ""
        '
        'lblAssignMax
        '
        Me.lblAssignMax.Location = New System.Drawing.Point(16, 40)
        Me.lblAssignMax.Name = "lblAssignMax"
        Me.lblAssignMax.TabIndex = 55
        Me.lblAssignMax.Text = "Max Score"
        '
        'lblAssignNum
        '
        Me.lblAssignNum.Location = New System.Drawing.Point(16, 16)
        Me.lblAssignNum.Name = "lblAssignNum"
        Me.lblAssignNum.TabIndex = 55
        Me.lblAssignNum.Text = "Assignment #"
        '
        'txtAssignNum
        '
        Me.txtAssignNum.Location = New System.Drawing.Point(136, 16)
        Me.txtAssignNum.Name = "txtAssignNum"
        Me.txtAssignNum.TabIndex = 24
        Me.txtAssignNum.Text = ""
        '
        'btnGrades
        '
        Me.btnGrades.Location = New System.Drawing.Point(8, 56)
        Me.btnGrades.Name = "btnGrades"
        Me.btnGrades.TabIndex = 1
        Me.btnGrades.Text = "Grades"
        '
        'MainForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(744, 397)
        Me.Controls.Add(Me.btnGrades)
        Me.Controls.Add(Me.gboxInput)
        Me.Controls.Add(Me.lblGraphSub)
        Me.Controls.Add(Me.lblCs)
        Me.Controls.Add(Me.lblFs)
        Me.Controls.Add(Me.lblAs)
        Me.Controls.Add(Me.lblBs)
        Me.Controls.Add(Me.lblDs)
        Me.Controls.Add(Me.lblRunningGPA)
        Me.Controls.Add(Me.lblGrade)
        Me.Controls.Add(Me.lblPercentTitle)
        Me.Controls.Add(Me.lblGCodeTitle)
        Me.Controls.Add(Me.lblNameTitle)
        Me.Controls.Add(Me.btnAssignments)
        Me.Controls.Add(Me.lblIDTitle)
        Me.Controls.Add(Me.lboxGrade)
        Me.Controls.Add(Me.lboxPercent)
        Me.Controls.Add(Me.lboxGCode)
        Me.Controls.Add(Me.lboxName)
        Me.Controls.Add(Me.lboxLnum)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnStudents)
        Me.Controls.Add(Me.btnTests)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "MainForm"
        Me.Text = "GPA Calculator"
        Me.gboxInput.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"
    Dim eprFile As System.IO.File
    Dim eprRead As System.IO.StreamReader
    Dim eprContents As String
    Dim eprFile2 As System.IO.File
    Dim eprRead2 As System.IO.StreamReader
    Dim eprContents2 As String
    Const stuFile = "students.txt"
    Const assignFile = "assignments.txt"
    Const gradeFile = "grades.txt"
    Const tempFile = "temp.txt"
    Dim fileDelimeter As Char = ","

    Dim fname As String
    Dim lname As String
    Dim lnum As String
    Dim gcode As String
    Dim assignNum As String
    Dim assignMax As String
    Dim assignType As String
    Dim currBtn As String
    Dim selStud As String

    Dim amtA As Integer
    Dim amtB As Integer
    Dim amtC As Integer
    Dim amtD As Integer
    Dim amtF As Integer
    Dim numAssignments As Decimal = 0.0
    Dim numStudents As Integer
    Dim runTotal As Decimal = 0.0
    Dim runGPA As Decimal = 0.0

    Dim theSelectedIndex As Integer
    Dim prevSelected As Integer

    Dim frmType As String = "Student"

#End Region

#Region "select boxes"

    Private Sub lboxName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lboxName.SelectedIndexChanged
        selectedLine(lboxName.SelectedIndex())
    End Sub

    Private Sub lboxName_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lboxName.DoubleClick
        If (theSelectedIndex >= 0) Then
            currBtn = "Modify"
            loadInput(currBtn)
        End If
    End Sub

    Private Sub lboxLnum_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lboxLnum.SelectedIndexChanged
        selectedLine(lboxLnum.SelectedIndex())
    End Sub

    Private Sub lboxLnum_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lboxLnum.DoubleClick
        If (theSelectedIndex >= 0) Then
            currBtn = "Modify"
            loadInput(currBtn)
        End If
    End Sub

    Private Sub lboxGCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lboxGCode.SelectedIndexChanged
        selectedLine(lboxGCode.SelectedIndex())
    End Sub

    Private Sub lboxGCode_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lboxGCode.DoubleClick
        If (theSelectedIndex >= 0) Then
            currBtn = "Modify"
            loadInput(currBtn)
        End If
    End Sub

    Private Sub lboxPercent_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lboxPercent.SelectedIndexChanged
        selectedLine(lboxPercent.SelectedIndex())
    End Sub

    Private Sub lboxPercent_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lboxPercent.DoubleClick
        If (theSelectedIndex >= 0) Then
            currBtn = "Modify"
            loadInput(currBtn)
        End If
    End Sub

    Private Sub lboxGrade_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lboxGrade.SelectedIndexChanged, lboxGrade.SelectedIndexChanged
        selectedLine(lboxGrade.SelectedIndex())
    End Sub

    Private Sub lboxGrade_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lboxGrade.DoubleClick
        If (theSelectedIndex >= 0) Then
            currBtn = "Modify"
            loadInput(currBtn)
        End If
    End Sub

    Private Function selectedLine(ByVal selIndex As Integer)
        Dim lboxArr() As Object = {lboxGCode, lboxName, lboxLnum}
        Dim iCounter As Integer
        theSelectedIndex = selIndex
        'lboxGrade.SelectedIndex() = selIndex
        'lboxPercent.SelectedIndex() = selIndex
        For iCounter = 0 To UBound(lboxArr)
            lboxArr(iCounter).SelectedIndex() = selIndex
        Next
        btnModify.Enabled() = True
        btnDelete.Enabled() = True
    End Function

    Private Function deSelectLine()
        Dim selIndex = -1
        Dim lboxArr() As Object = {lboxGCode, lboxName, lboxLnum}
        Dim iCounter As Integer
        theSelectedIndex = selIndex
        'lboxGrade.SelectedIndex() = selIndex
        'lboxPercent.SelectedIndex() = selIndex
        For iCounter = 0 To UBound(lboxArr)
            lboxArr(iCounter).SelectedIndex() = selIndex
        Next
        btnModify.Enabled() = False
        btnDelete.Enabled() = False
    End Function
#End Region

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gboxInput.Visible() = False
        btnModify.Enabled() = False
        btnDelete.Enabled() = False
        readFile(stuFile)
        deSelectLine()
        getGPA(selStud)
    End Sub

    Private Function chkList(ByVal theItem As String, ByVal lboxField As Object)
        Dim addedFlag As Boolean = False
        '
        'Check to see if item is already on the list
        '
        Dim iCounter As Integer = 0
        Do While iCounter <= lboxField.Items.Count - 1
            If (theItem = lboxField.Items.Item(iCounter)) Then
                addedFlag = True
                Return addedFlag
            End If
            iCounter += 1
        Loop
        Return addedFlag
    End Function

    Private Function loadInput(ByVal btnType As String)
        Dim myCounter As Integer
        If (frmType = "Student") Then
            Dim myArray() As Object = {txtGCode, lblGCode, lblLNumber, txtLnum, txtFName, lblFName, lblLName, txtLName}
            showFields(myArray, btnType)
            If (btnType = "Modify") Then
                Dim splitName = Split(lboxName.SelectedItem, ", ")
                txtLName.Text = splitName(0)
                txtFName.Text = splitName(1)
                txtGCode.Text = lboxGCode.SelectedItem
                txtLnum.Text = lboxLnum.SelectedItem
            End If
        ElseIf (frmType = "Assignment") Then
            Dim myArray() As Object = {txtAssignMax, lblAssignMax, lblAssignNum, txtAssignNum}
            showFields(myArray, btnType)
            If (btnType = "Modify") Then
                txtAssignMax.Text = lboxLnum.SelectedItem
                txtAssignNum.Text = lboxName.SelectedItem
            End If
        ElseIf (frmType = "Test") Then
            Dim myArray() As Object = {txtAssignMax, lblAssignMax, lblAssignNum, txtAssignNum}
            showFields(myArray, btnType)
            txtAssignMax.Text = lboxLnum.SelectedItem
            txtAssignNum.Text = lboxName.SelectedItem
        End If
        gboxInput.Visible() = True
        disableStuLists()
        '
        'gives box "zoom in" effect
        '
        While (myCounter < 120)
            gboxInput.Location = New System.Drawing.Point(0 + myCounter, 0 + myCounter)
            gboxInput.Size = New System.Drawing.Size(152 + myCounter, 64 + myCounter)
            myCounter += 1
        End While
    End Function

    Private Function hideInput()
        Dim myCounter As Integer
        '
        'gives box "zoom out" effect
        '
        While (myCounter < 120)
            gboxInput.Location = New System.Drawing.Point(120 - myCounter, 120 - myCounter)
            gboxInput.Size = New System.Drawing.Size(248 - myCounter, 160 - myCounter)
            myCounter += 1
        End While
        gboxInput.Visible() = False
        enableStuLists()
        If (frmType = "Student") Then
            Dim myArray() As Object = {txtGCode, lblGCode, lblLNumber, txtLnum, txtFName, lblFName, lblLName, txtLName}
            hideFields(myArray)
        ElseIf (frmType = "Assignment") Then
            Dim myArray() As Object = {txtAssignMax, lblAssignMax, lblAssignNum, txtAssignNum}
            hideFields(myArray)
        ElseIf (frmType = "Test") Then
            Dim myArray() As Object = {txtAssignMax, lblAssignMax, lblAssignNum, txtAssignNum}
            hideFields(myArray)
        End If
    End Function

    Private Function disableStuLists()
        lboxName.Enabled() = False
        lboxPercent.Enabled() = False
        lboxGrade.Enabled() = False
        lboxGCode.Enabled() = False
        lboxLnum.Enabled() = False
    End Function

    Private Function enableStuLists()
        lboxName.Enabled() = True
        lboxPercent.Enabled() = True
        lboxGrade.Enabled() = True
        lboxGCode.Enabled() = True
        lboxLnum.Enabled() = True
    End Function

    Private Function showFields(ByVal currArray As Object, ByVal btnType As String)
        Dim iCounter As Integer
        For iCounter = 0 To UBound(currArray)
            currArray(iCounter).Size = New System.Drawing.Size(100, 20)
            currArray(iCounter).Visible() = True
        Next
    End Function

    Private Function hideFields(ByVal currArray As Object)
        Dim iCounter As Integer
        For iCounter = 0 To UBound(currArray)
            currArray(iCounter).Size = New System.Drawing.Size(0, 0)
            currArray(iCounter).Visible() = False
        Next
    End Function

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        currBtn = "Add"
        loadInput(currBtn)
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim wrText As String
        Dim theFile As Object
        If (currBtn = "Add") Then
            If (frmType = "Student") Then
                wrText = txtLName.Text & "," & txtFName.Text & "," & txtGCode.Text & "," & txtLnum.Text
                theFile = stuFile
                writeToFile(wrText, theFile)
            ElseIf ((frmType = "Assignment") Or (frmType = "Test")) Then
                wrText = txtAssignNum.Text & "," & txtAssignMax.Text & "," & frmType
                theFile = assignFile
                writeToFile(wrText, theFile)
            End If
        ElseIf (currBtn = "Modify") Then
            Dim oFile As System.IO.File
            Dim oWrite As System.IO.StreamWriter
            oWrite = oFile.CreateText(tempFile)
            oWrite.Close()
            If (frmType = "Student") Then
                theFile = stuFile
            ElseIf ((frmType = "Assignment") Or (frmType = "Test")) Then
                theFile = assignFile
            End If
            eprRead = eprFile.OpenText(theFile)

            Do Until eprRead.Peek = -1
                eprContents = eprRead.ReadLine()
                Dim splitRecord = Split(eprContents, fileDelimeter)
                If (theFile = stuFile) Then
                    lname = splitRecord(0)
                    fname = splitRecord(1)
                    gcode = splitRecord(2)
                    lnum = splitRecord(3)
                    If (gcode <> lboxGCode.SelectedItem) Then
                        wrText = lname & "," & fname & "," & gcode & "," & lnum
                    Else
                        wrText = txtLName.Text & "," & txtFName.Text & "," & txtGCode.Text & "," & txtLnum.Text
                    End If
                ElseIf (theFile = assignFile) Then
                    assignNum = splitRecord(0)
                    assignMax = splitRecord(1)
                    assignType = splitRecord(2)
                    If (assignNum <> lboxName.SelectedItem) Then
                        wrText = assignNum & "," & assignMax & "," & assignType
                    Else
                        wrText = txtAssignNum.Text & "," & txtAssignMax.Text & "," & frmType
                    End If
                End If
                writeToFile(wrText, tempFile)
            Loop
            eprRead.Close()

            System.IO.File.Delete(theFile)
            System.IO.File.Copy(tempFile, theFile)
            System.IO.File.Delete(tempFile)
        End If
        clearListBoxes()
        readFile(theFile)
        deSelectLine()
        hideInput()
        clearText()
    End Sub

    Private Sub btnAssignments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssignments.Click
        clearListBoxes()
        frmType = "Assignment"
        readFile(assignFile)
        deSelectLine()
    End Sub

    Private Sub btnTests_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTests.Click
        clearListBoxes()
        frmType = "Test"
        readFile(assignFile)
        deSelectLine()
    End Sub

    Private Sub btnStudents_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudents.Click
        clearListBoxes()
        frmType = "Student"
        readFile(stuFile)
        deSelectLine()
    End Sub

    Private Function readFile(ByVal currFile As Object)
        eprRead = eprFile.OpenText(currFile)
        Do Until eprRead.Peek = -1
            eprContents = eprRead.ReadLine()
            Dim splitRecord = Split(eprContents, fileDelimeter)
            If (currFile = stuFile) Then
                lname = splitRecord(0)
                fname = splitRecord(1)
                gcode = splitRecord(2)
                lnum = splitRecord(3)
                If (chkList(gcode, lboxLnum) = False) Then
                    lboxName.Items.Add(lname & ", " & fname)
                    lboxLnum.Items.Add(lnum)
                    lboxGCode.Items.Add(gcode)
                End If
            ElseIf (currFile = assignFile) Then
                assignNum = splitRecord(0)
                assignMax = splitRecord(1)
                assignType = splitRecord(2)
                If (chkList(assignNum, lboxLnum) = False) Then
                    If (assignType = frmType) Then
                        lboxName.Items.Add(assignNum)
                        lboxLnum.Items.Add(assignMax)
                        lboxGCode.Items.Add(assignType)
                    End If
                End If
            End If
        Loop
        eprRead.Close()
    End Function

    Private Function clearListBoxes()
        Dim currArray() As Object = {lboxGCode, lboxPercent, lboxName, lboxLnum, lboxGrade}
        Dim iCounter As Integer
        For iCounter = 0 To UBound(currArray)
            currArray(iCounter).Items.Clear()
        Next
    End Function

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        currBtn = "Modify"
        loadInput(currBtn)
    End Sub

    Private Function writeToFile(ByVal wrText As String, ByVal currFile As Object)
        Dim eprWrite As New System.IO.StreamWriter(currFile, True)
        eprWrite.WriteLine(wrText)
        eprWrite.Close()
    End Function

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim iCounter As Integer
        Dim theFile As Object
        Dim wrText As String

        Dim oFile As System.IO.File
        Dim oWrite As System.IO.StreamWriter
        oWrite = oFile.CreateText(tempFile)
        oWrite.Close()
        If (frmType = "Student") Then
            theFile = stuFile
        ElseIf ((frmType = "Assignment") Or (frmType = "Test")) Then
            theFile = assignFile
        End If
        eprRead = eprFile.OpenText(theFile)

        Do Until eprRead.Peek = -1
            eprContents = eprRead.ReadLine()
            Dim splitRecord = Split(eprContents, fileDelimeter)
            If (theFile = stuFile) Then
                lname = splitRecord(0)
                fname = splitRecord(1)
                gcode = splitRecord(2)
                lnum = splitRecord(3)
                If (gcode <> lboxGCode.SelectedItem) Then
                    wrText = lname & "," & fname & "," & gcode & "," & lnum
                    writeToFile(wrText, tempFile)
                End If
            ElseIf (theFile = assignFile) Then
                assignNum = splitRecord(0)
                assignMax = splitRecord(1)
                assignType = splitRecord(2)
                If (assignNum <> lboxName.SelectedItem) Then
                    wrText = assignNum & "," & assignMax & "," & assignType
                    writeToFile(wrText, tempFile)
                End If
            End If
        Loop
        eprRead.Close()

        System.IO.File.Delete(theFile)
        System.IO.File.Copy(tempFile, theFile)
        System.IO.File.Delete(tempFile)
        clearListBoxes()
        readFile(theFile)
        deSelectLine()
    End Sub

    Private Function clearText()
        Dim textArr() As Object = {txtLName, txtFName, txtLnum, txtGCode, txtAssignNum, txtAssignMax}
        Dim iCounter As Integer
        For iCounter = 0 To UBound(textArr)
            textArr(iCounter).Text = ""
        Next
    End Function

    Private Sub btnGrades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrades.Click
        selStud = lboxGCode.SelectedItem
        clearListBoxes()
        Dim assignNamesArr(100) As String
        Dim assignMaxesArr(100) As String
        Dim iCounter As Integer = 0
        Dim addedFlag As Boolean = False
        Dim grdAmt As Decimal
        amtA = 0
        amtB = 0
        amtC = 0
        amtD = 0
        amtF = 0

        eprRead = eprFile.OpenText(assignFile)
        Do Until eprRead.Peek = -1
            eprContents = eprRead.ReadLine()
            Dim splitRecord = Split(eprContents, fileDelimeter)
            assignNamesArr(iCounter) = splitRecord(0)
            assignMaxesArr(iCounter) = splitRecord(1)
            iCounter += 1
        Loop
        eprRead.Close()

        numAssignments = iCounter
        iCounter = 0
        Do Until iCounter = numAssignments
            eprRead = eprFile.OpenText(gradeFile)
            Do Until eprRead.Peek = -1
                eprContents = eprRead.ReadLine()
                Dim splitRecord = Split(eprContents, fileDelimeter)
                If (selStud = splitRecord(0)) Then
                    If (assignNamesArr(iCounter) = splitRecord(1)) Then
                        addedFlag = True
                        lboxLnum.Items.Add(selStud)
                        lboxName.Items.Add(assignNamesArr(iCounter))
                        lboxGCode.Items.Add(splitRecord(2))
                        grdAmt = Format(((splitRecord(2) / assignMaxesArr(iCounter)) * 100), "0.0")
                        lboxPercent.Items.Add(grdAmt)
                    End If
                End If
            Loop
            If (addedFlag = False) Then
                lboxLnum.Items.Add(selStud)
                lboxName.Items.Add(assignNamesArr(iCounter))
                grdAmt = 0
                lboxGCode.Items.Add(Format(grdAmt, "0.0"))
                lboxPercent.Items.Add(grdAmt)
            End If
            If (grdAmt >= 90) Then
                amtA += 1
            ElseIf ((grdAmt < 90) And (grdAmt >= 80)) Then
                amtB += 1
            ElseIf ((grdAmt < 80) And (grdAmt >= 70)) Then
                amtC += 1
            ElseIf ((grdAmt < 70) And (grdAmt >= 60)) Then
                amtD += 1
            ElseIf (grdAmt < 60) Then
                amtF += 1
            End If
            iCounter += 1
            eprRead.Close()
        Loop
        updateGraph(numAssignments)
        getGPA(selStud)
    End Sub

    Private Function updateGraph(ByVal numItems As Integer)
        Dim grdletters() As Object = {lblAs, lblBs, lblCs, lblDs, lblFs}
        Dim grdAmts() As Object = {amtA, amtB, amtC, amtD, amtF}
        Dim iCounter As Integer
        For iCounter = 0 To UBound(grdletters)
            Dim gHeight As Integer = 16
            gHeight += ((grdAmts(iCounter) / numItems) * 240)
            grdletters(iCounter).Size = New System.Drawing.Size(48, gHeight)
        Next
    End Function

    Private Function getGPA(ByVal whoseGPA As String)
        selStud = lboxGCode.SelectedItem
        clearListBoxes()
        Dim assignNamesArr(100) As String
        Dim assignMaxesArr(100) As String
        Dim studNamesArr(100) As String
        Dim studGCodeArr(100) As String
        Dim iCounter As Integer = 0
        Dim jCounter As Integer = 0
        Dim addedFlag As Boolean
        Dim grdAmt As Decimal
        amtA = 0
        amtB = 0
        amtC = 0
        amtD = 0
        amtF = 0

        eprRead = eprFile.OpenText(assignFile)
        Do Until eprRead.Peek = -1
            eprContents = eprRead.ReadLine()
            Dim splitRecord = Split(eprContents, fileDelimeter)
            assignNamesArr(iCounter) = splitRecord(0)
            assignMaxesArr(iCounter) = splitRecord(1)
            iCounter += 1
        Loop
        eprRead.Close()
        numAssignments = iCounter

        iCounter = 0
        eprRead = eprFile.OpenText(stuFile)
        Do Until eprRead.Peek = -1
            eprContents = eprRead.ReadLine()
            Dim splitRecord = Split(eprContents, fileDelimeter)
            studNamesArr(iCounter) = splitRecord(0) & ", " & splitRecord(1)
            studGCodeArr(iCounter) = splitRecord(2)
            iCounter += 1
        Loop
        eprRead.Close()

        numStudents = iCounter
        jCounter = 0
        Do Until jCounter = numStudents + 1
            selStud = studGCodeArr(jCounter)
            iCounter = 0
            Do Until iCounter = numAssignments
                eprRead = eprFile.OpenText(gradeFile)
                Do Until eprRead.Peek = -1
                    eprContents = eprRead.ReadLine()
                    Dim splitRecord = Split(eprContents, fileDelimeter)
                    If (selStud = splitRecord(0)) Then
                        If (assignNamesArr(iCounter) = splitRecord(1)) Then
                            addedFlag = True
                            lboxLnum.Items.Add(selStud)
                            lboxName.Items.Add(assignNamesArr(iCounter))
                            lboxGCode.Items.Add(splitRecord(2))
                            grdAmt = Format(((splitRecord(2) / assignMaxesArr(iCounter)) * 100), "0.0")
                            lboxPercent.Items.Add(grdAmt)
                            runTotal += grdAmt
                        End If
                    End If
                Loop
                If (addedFlag = False) Then
                    MsgBox(addedFlag)
                    lboxLnum.Items.Add(selStud)
                    lboxName.Items.Add(assignNamesArr(iCounter))
                    grdAmt = 0
                    lboxGCode.Items.Add(Format(grdAmt, "0.0"))
                    lboxPercent.Items.Add(grdAmt)
                    addedFlag = False
                End If
                If (grdAmt >= 97) Then
                    amtA += 1
                    runGPA += 4
                ElseIf ((grdAmt > 93) And (grdAmt <= 96)) Then
                    amtA += 1
                    runGPA += 4
                ElseIf ((grdAmt > 90) And (grdAmt <= 92)) Then
                    amtA += 1
                    runGPA += 3.7
                ElseIf ((grdAmt > 87) And (grdAmt <= 89)) Then
                    amtB += 1
                    runGPA += 3.3
                ElseIf ((grdAmt > 83) And (grdAmt <= 86)) Then
                    amtB += 1
                    runGPA += 3
                ElseIf ((grdAmt > 80) And (grdAmt <= 82)) Then
                    amtB += 1
                    runGPA += 2.7
                ElseIf ((grdAmt > 77) And (grdAmt <= 79)) Then
                    amtC += 1
                    runGPA += 2.3
                ElseIf ((grdAmt > 73) And (grdAmt <= 76)) Then
                    amtC += 1
                    runGPA += 2
                ElseIf ((grdAmt > 70) And (grdAmt <= 72)) Then
                    amtC += 1
                    runGPA += 1.7
                ElseIf ((grdAmt > 67) And (grdAmt <= 69)) Then
                    amtD += 1
                    runGPA += 1.3
                ElseIf ((grdAmt > 63) And (grdAmt <= 66)) Then
                    amtD += 1
                    runGPA += 1
                ElseIf ((grdAmt > 60) And (grdAmt <= 62)) Then
                    amtD += 1
                    runGPA += 0.7
                ElseIf (grdAmt < 60) Then
                    amtF += 1
                End If
                iCounter += 1
                eprRead.Close()
            Loop
            jCounter += 1
        Loop
        MsgBox(amtF)
        MsgBox(Format((runGPA / numAssignments), "0.0"))
        updateGraph(numAssignments)
    End Function
End Class
