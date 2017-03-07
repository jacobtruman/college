Public Class Form1
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
    Friend WithEvents lblRecsInFile As System.Windows.Forms.Label
    Friend WithEvents lblRecsProc As System.Windows.Forms.Label
    Friend WithEvents lblExcep As System.Windows.Forms.Label
    Friend WithEvents lblRecsInFileVal As System.Windows.Forms.Label
    Friend WithEvents lblRecsProcVal As System.Windows.Forms.Label
    Friend WithEvents lblExcepVal As System.Windows.Forms.Label
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.lblRecsInFile = New System.Windows.Forms.Label
        Me.lblRecsProc = New System.Windows.Forms.Label
        Me.lblExcep = New System.Windows.Forms.Label
        Me.lblRecsInFileVal = New System.Windows.Forms.Label
        Me.lblRecsProcVal = New System.Windows.Forms.Label
        Me.lblExcepVal = New System.Windows.Forms.Label
        Me.btnRun = New System.Windows.Forms.Button
        Me.btnQuit = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.SuspendLayout()
        '
        'lblRecsInFile
        '
        Me.lblRecsInFile.Location = New System.Drawing.Point(24, 0)
        Me.lblRecsInFile.Name = "lblRecsInFile"
        Me.lblRecsInFile.Size = New System.Drawing.Size(88, 23)
        Me.lblRecsInFile.TabIndex = 0
        Me.lblRecsInFile.Text = "Records in File"
        Me.lblRecsInFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRecsProc
        '
        Me.lblRecsProc.Location = New System.Drawing.Point(0, 24)
        Me.lblRecsProc.Name = "lblRecsProc"
        Me.lblRecsProc.Size = New System.Drawing.Size(112, 23)
        Me.lblRecsProc.TabIndex = 1
        Me.lblRecsProc.Text = "Records Processed"
        Me.lblRecsProc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblExcep
        '
        Me.lblExcep.Location = New System.Drawing.Point(40, 48)
        Me.lblExcep.Name = "lblExcep"
        Me.lblExcep.Size = New System.Drawing.Size(72, 23)
        Me.lblExcep.TabIndex = 2
        Me.lblExcep.Text = "Exceptions"
        Me.lblExcep.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRecsInFileVal
        '
        Me.lblRecsInFileVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecsInFileVal.Location = New System.Drawing.Point(128, 0)
        Me.lblRecsInFileVal.Name = "lblRecsInFileVal"
        Me.lblRecsInFileVal.Size = New System.Drawing.Size(40, 23)
        Me.lblRecsInFileVal.TabIndex = 3
        Me.lblRecsInFileVal.Text = "0"
        Me.lblRecsInFileVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRecsProcVal
        '
        Me.lblRecsProcVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecsProcVal.ForeColor = System.Drawing.Color.Blue
        Me.lblRecsProcVal.Location = New System.Drawing.Point(128, 24)
        Me.lblRecsProcVal.Name = "lblRecsProcVal"
        Me.lblRecsProcVal.Size = New System.Drawing.Size(40, 23)
        Me.lblRecsProcVal.TabIndex = 4
        Me.lblRecsProcVal.Text = "0"
        Me.lblRecsProcVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblExcepVal
        '
        Me.lblExcepVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExcepVal.ForeColor = System.Drawing.Color.Red
        Me.lblExcepVal.Location = New System.Drawing.Point(128, 48)
        Me.lblExcepVal.Name = "lblExcepVal"
        Me.lblExcepVal.Size = New System.Drawing.Size(40, 23)
        Me.lblExcepVal.TabIndex = 5
        Me.lblExcepVal.Text = "0"
        Me.lblExcepVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(64, 88)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(48, 24)
        Me.btnRun.TabIndex = 6
        Me.btnRun.Text = "Run"
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(120, 88)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(48, 24)
        Me.btnQuit.TabIndex = 7
        Me.btnQuit.Text = "Quit"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(5, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 54)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(176, 117)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.lblExcepVal)
        Me.Controls.Add(Me.lblRecsProcVal)
        Me.Controls.Add(Me.lblRecsInFileVal)
        Me.Controls.Add(Me.lblExcep)
        Me.Controls.Add(Me.lblRecsProc)
        Me.Controls.Add(Me.lblRecsInFile)
        Me.Name = "Form1"
        Me.Text = "Jacob Truman"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Close()
    End Sub

    Private Sub btnRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun.Click
        ' Declaring the eprFile for I/O (Reading)
        Const testFile = "C:\test01.txt"
        Dim eprFile As System.IO.File
        Dim eprRead As System.IO.StreamReader
        Dim eprContents As String
        Dim netPay As Decimal
        Dim fullName As String
        Dim FName As String
        Dim LName As String
        Dim Initial As String
        Dim WCode As Char
        Dim Rate As Double
        Dim Other As Double
        Dim fileDelimeter As String = ","

        Dim pCounter As Integer
        Dim cCounter As Integer
        Dim iCounter As Integer
        Dim eCounter As Integer
        Dim msg As String

        pCounter = 0
        cCounter = 0
        eCounter = 0
        eprRead = eprFile.OpenText(testFile)
        Do Until eprRead.Peek = -1
            cCounter += 1
            lblRecsInFileVal.Text = cCounter
            eprContents = eprRead.ReadLine()
            Dim splitRecord = Split(eprContents, fileDelimeter)
            msg = ""
            For iCounter = 0 To UBound(splitRecord)
                msg = msg & iCounter & ":" & Chr(9)
                msg = msg & splitRecord(iCounter) & Chr(10)
            Next
            'MsgBox(msg)
            netPay = 0
            LName = splitRecord(0)
            FName = splitRecord(1)
            Initial = splitRecord(2)
            WCode = splitRecord(3)
            Rate = splitRecord(4)
            Other = splitRecord(5)
            If WCode = "H" Then
                pCounter += 1
                'MsgBox("Hourly paid worker record")
                netPay = CalcNetHourlyPay(Rate, Other)
            ElseIf WCode = "S" Then
                pCounter += 1
                'MsgBox("Salaried worker record")
                netPay = CalcNetSalariedPay(Rate, Other)
            Else
                'MsgBox("Exception record found")
                eCounter += 1
                lblExcepVal.Text = eCounter
            End If
            lblRecsProcVal.Text = pCounter
            'fullName = FName & Initial & LName
            fullName = FormatOutput(FName, Initial, LName)
            'MsgBox(fullName & " , Net Pay=$" & netPay)
        Loop
        eprRead.Close()
    End Sub

    Private Function FormatOutput(ByVal strFName As String, ByVal strInitial As String, ByVal strLName As String)
        Dim strName As String
        If strInitial = "" Then
            strName = strFName & " " & strLName
        Else
            strName = strFName & " " & strInitial & " " & strLName
        End If
        FormatOutput = strName

    End Function

    Private Function CalcNetHourlyPay(ByVal HourlyRate As Double, ByVal HoursWorked As Double)
        Dim GrossPay As Double
        Dim Deductions As Double
        GrossPay = CalcGrossHourlyPay(HourlyRate, HoursWorked)
        Deductions = CalcDeductions(GrossPay)
        CalcNetHourlyPay = GrossPay - Deductions
    End Function

    Private Function CalcGrossHourlyPay(ByVal hRate As Double, ByVal hWorked As Double)
        CalcGrossHourlyPay = hRate * hWorked
        'MsgBox("hRate=" & hRate & ", hWorked=" & hWorked & ", GrossPay=" & CalcGrossHourlyPay)
    End Function

    Private Function CalcNetSalariedPay(ByVal baseSalary As Double, ByVal anyBonuses As Double)

        Dim GrossPay As Double
        Dim Deductions As Double

        GrossPay = CalcGrossSalariedPay(baseSalary, anyBonuses)
        Deductions = CalcDeductions(GrossPay)
        CalcNetSalariedPay = GrossPay - Deductions

    End Function

    Private Function CalcGrossSalariedPay(ByVal baseSalary As Double, ByVal anyBonuses As Double)

        CalcGrossSalariedPay = baseSalary + anyBonuses
        'MsgBox("Base=" & baseSalary & ", Bonus=" & anyBonuses & ", GrossPay=" & CalcGrossSalariedPay)


    End Function

    Private Function CalcDeductions(ByVal grossPay As Double)
        Dim taxWithHeld As Double
        Dim insPremium As Double

        Select Case grossPay
            Case Is < 50000
                taxWithHeld = grossPay * 0.2
            Case Is < 100000
                taxWithHeld = grossPay * 0.3
            Case Else
                taxWithHeld = grossPay * 0.4
        End Select
        'MsgBox(taxWithHeld)
        insPremium = 10% * (grossPay = taxWithHeld)
        CalcDeductions = taxWithHeld + insPremium
        'MsgBox("Deduxtions=" & CalcDeductions)
    End Function
End Class
