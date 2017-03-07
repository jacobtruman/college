Imports System.Data.OleDb
Imports System.Data
Public Class frmAdvisor

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
    Friend WithEvents dtpAppointment As System.Windows.Forms.DateTimePicker
    Friend WithEvents calAppointment As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents rdobtnDay As System.Windows.Forms.RadioButton
    Friend WithEvents rdobtnWeek As System.Windows.Forms.RadioButton
    Friend WithEvents rdobtnMonth As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dtpAppointment = New System.Windows.Forms.DateTimePicker
        Me.calAppointment = New System.Windows.Forms.MonthCalendar
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.rdobtnDay = New System.Windows.Forms.RadioButton
        Me.rdobtnWeek = New System.Windows.Forms.RadioButton
        Me.rdobtnMonth = New System.Windows.Forms.RadioButton
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpAppointment
        '
        Me.dtpAppointment.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAppointment.Location = New System.Drawing.Point(16, 216)
        Me.dtpAppointment.MinDate = New Date(2005, 12, 31, 0, 0, 0, 0)
        Me.dtpAppointment.Name = "dtpAppointment"
        Me.dtpAppointment.Size = New System.Drawing.Size(272, 26)
        Me.dtpAppointment.TabIndex = 31
        Me.dtpAppointment.Value = New Date(2006, 4, 24, 0, 0, 0, 0)
        '
        'calAppointment
        '
        Me.calAppointment.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calAppointment.Location = New System.Drawing.Point(16, 248)
        Me.calAppointment.Name = "calAppointment"
        Me.calAppointment.TabIndex = 30
        Me.calAppointment.TitleBackColor = System.Drawing.Color.Red
        Me.calAppointment.TitleForeColor = System.Drawing.SystemColors.WindowText
        Me.calAppointment.TrailingForeColor = System.Drawing.SystemColors.InactiveCaptionText
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 88)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Advisor appointments management area"
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(296, 152)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ParentRowsVisible = False
        Me.DataGrid1.Size = New System.Drawing.Size(920, 536)
        Me.DataGrid1.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(400, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(504, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(400, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(592, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(296, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "week"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(296, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "oneday"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(392, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Label8"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(488, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Label9"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(592, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Label10"
        '
        'rdobtnDay
        '
        Me.rdobtnDay.Location = New System.Drawing.Point(312, 120)
        Me.rdobtnDay.Name = "rdobtnDay"
        Me.rdobtnDay.TabIndex = 43
        Me.rdobtnDay.Text = "Day"
        '
        'rdobtnWeek
        '
        Me.rdobtnWeek.Location = New System.Drawing.Point(448, 120)
        Me.rdobtnWeek.Name = "rdobtnWeek"
        Me.rdobtnWeek.TabIndex = 44
        Me.rdobtnWeek.Text = "Week"
        '
        'rdobtnMonth
        '
        Me.rdobtnMonth.Location = New System.Drawing.Point(552, 120)
        Me.rdobtnMonth.Name = "rdobtnMonth"
        Me.rdobtnMonth.TabIndex = 45
        Me.rdobtnMonth.Text = "Month"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(80, 176)
        Me.Label11.Name = "Label11"
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Label11"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 144)
        Me.Label12.Name = "Label12"
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "Label12"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(184, 152)
        Me.Label13.Name = "Label13"
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Label13"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(104, 120)
        Me.Label14.Name = "Label14"
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "Label14"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(752, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "delete"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(856, 64)
        Me.Label15.Name = "Label15"
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "Label15"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(744, 96)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 24)
        Me.Button2.TabIndex = 52
        Me.Button2.Text = " new"
        '
        'frmAdvisor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1224, 711)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.rdobtnMonth)
        Me.Controls.Add(Me.rdobtnWeek)
        Me.Controls.Add(Me.rdobtnDay)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpAppointment)
        Me.Controls.Add(Me.calAppointment)
        Me.Name = "frmAdvisor"
        Me.Text = "Advisor Appointment Management Area"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim recCount As Integer
    Dim dgridInd As Integer
    Dim today As Date
    Dim sqlToday As String
    Dim sqlPlus1 As String
    Dim sqlPlus2 As String
    Dim sqlPlus3 As String
    Dim sqlSubt1 As String
    Dim sqlSubt2 As String
    Dim sqlSubt3 As String
    Dim plus1 As Date
    Dim plus2 As Date
    Dim plus3 As Date
    Dim subt1 As Date
    Dim subt2 As Date
    Dim subt3 As Date
    Dim oConn As OleDbConnection
    Dim oComm As OleDbDataAdapter
    Dim sConn As String
    Dim sComm As String
    Dim oDataSet As New DataSet
    Dim db As String = "..\..\..\DB\COBAdvisingAppts.mdb"
    Dim TheAdvisor As String
    Dim theDay As Integer
    Dim theMonth As Integer
    Dim theYear As Integer
    Dim theDate As String
    Dim beginWK As String
    Dim endWK As String



    Private Sub frmAdvisor_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        ' Make the Advisor Functions form visible again
        clsForms.frmAdvisorFunctions.Visible = True
    End Sub

    Private Sub frmAdvisor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsForms.frmAdvisor = Me
        rdobtnDay.Checked = True
        TheDaysOfOurLives()
        'Dim TheAdvisor As String
        'TheAdvisor = "'" + frmLogin.UserID + "'"

        'Dim oConn As OleDbConnection
        'Dim oComm As OleDbDataAdapter
        'Dim sConn As String
        'Dim sComm As String
        'Dim oDataSet As New DataSet
        'Dim db As String = "..\..\..\DB\COBAdvisingAppts.mdb"

        ''Build the connection string 
        'sConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & db & "; Persist Security Info=False;"


        'sComm = "SELECT * FROM Appointments WHERE Advisor=" + TheAdvisor + " and Appointment LIKE '%/30/2006%'"



        ''Create the connection and command objects 
        'oConn = New OleDbConnection(sConn)
        'oComm = New OleDbDataAdapter(sComm, oConn)

        ''Fill the dataset with the results of the query 
        'oComm.Fill(oDataSet)

        ''Set the grid source to the dataset and bind the data 
        ''DataGrid1.DataSource = oDataSet.Tables("Availability").DefaultView
        ''DataGrid1.DataBind()






        ''OleDbDataAdapter1.Fill(DataSet11)
        'DataGrid1.DataSource = oDataSet
        ''DataGrid1.DataMember = "Appointment"







    End Sub

    Private Function TheDaysOfOurLives()

        DataGrid1.PreferredColumnWidth = 100
        DataGrid1.BackColor = System.Drawing.Color.Red
        DataGrid1.CaptionForeColor = System.Drawing.Color.Red
        DataGrid1.CaptionBackColor = System.Drawing.Color.Black
        DataGrid1.CaptionText = "UNLV College Of Business Advising"
        DataGrid1.PreferredRowHeight = 20


        today = calAppointment.SelectionStart
        sqlToday = "'%" + today + "%'"
        plus1 = calAppointment.SelectionRange.Start.AddDays(1)
        sqlPlus1 = plus1.Year & "-" & plus1.Month & "-" & plus1.Day

        If calAppointment.SelectionStart.DayOfWeek = DayOfWeek.Sunday Then
            theDay = theDay + 3
            Label14.Text = theDay

            Label14.Text = theDay
        ElseIf calAppointment.SelectionStart.DayOfWeek = DayOfWeek.Monday Then
            theDay = today.Day.ToString + 2

            Label14.Text = theDay
        ElseIf calAppointment.SelectionStart.Day = DayOfWeek.Tuesday Then
            theDay = today.Day.ToString + 1

            Label14.Text = theDay
        ElseIf calAppointment.SelectionStart.Day = DayOfWeek.Thursday Then
            theDay = today.Day.ToString - 1
            Label14.Text = theDay
        ElseIf calAppointment.SelectionStart.Day = DayOfWeek.Friday Then
            theDay = today.Day.ToString - 2
            Label14.Text = theDay
        ElseIf calAppointment.SelectionStart.Day = DayOfWeek.Saturday Then
            theDay = today.Day.ToString - 3
            Label14.Text = theDay

        End If


        If today.Month < 10 Then
            theMonth = "0" & today.Month
        Else
            theMonth = today.Month
        End If
        If plus1.Day < 10 Then
            theDay = "0" & today.Day
        Else
            theDay = today.Day
        End If
        theYear = today.Year
        theDate = theYear & "-" & theMonth & "-" & theDay
        beginWK = theYear & "-" & "0" & theMonth & "-" & theDay - 3
        endWK = theYear & "-" & "0" & theMonth & "-" & theDay + 3

        plus2 = calAppointment.SelectionRange.Start.AddDays(2)
        sqlPlus2 = "'%" + plus2 + "%'"
        plus3 = calAppointment.SelectionRange.Start.AddDays(3)
        sqlPlus3 = "'%" + plus3 + "%'"
        subt1 = calAppointment.SelectionRange.Start.AddDays(-1)
        sqlSubt3 = "'%" + subt1 + "%'"
        subt2 = calAppointment.SelectionRange.Start.AddDays(-2)
        sqlSubt2 = "'%" + subt2 + "%'"


        sqlSubt3 = "'%" + subt3 + "%'"


        'Dim TheAdvisor As String
        TheAdvisor = "'" + frmLogin.UserID + "'"

        'Dim oConn As OleDbConnection
        'Dim oComm As OleDbDataAdapter
        'Dim sConn As String
        'Dim sComm As String
        'Dim oDataSet As New DataSet
        'Dim db As String = "..\..\..\DB\COBAdvisingAppts.mdb"
        sConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & db & "; Persist Security Info=False;"
        'sComm = "SELECT * FROM Appointments WHERE Advisor=" + TheAdvisor
        If rdobtnDay.Checked = True Then
            sComm = "SELECT * FROM Appointments WHERE Advisor=" + TheAdvisor + " and Appointment LIKE" + sqlToday
        ElseIf rdobtnWeek.Checked = True Then
            sComm = "SELECT * FROM Appointments WHERE Advisor=" + TheAdvisor
            'sComm += " and Appointment > " + "'" + beginWK + "'" + " and < " + "'" + endWK + "'"
            sComm += " and Appointment LIKE '%3%'"
        End If

        'If rdobtnDay.Checked = True Then sComm = "SELECT * FROM Appointments WHERE Advisor=" + TheAdvisor + " and Appointment LIKE" + sqlToday
        'If rdobtnWeek.Checked = True Then sComm = "SELECT * FROM Appointments WHERE Advisor=" + TheAdvisor + " and Appointment LIKE" + sqlPlus1
        oConn = New OleDbConnection(sConn)
        oComm = New OleDbDataAdapter(sComm, oConn)
        oDataSet.Clear()
        oComm.Fill(oDataSet)
        DataGrid1.DataSource = oDataSet.Tables(0)


        Label2.Text = today
        Label5.Text = plus3
        Label3.Text = plus2
        Label4.Text = plus1
        Label8.Text = subt1
        Label9.Text = subt2
        Label10.Text = subt3
        Label11.Text = theDate
        Label12.Text = beginWK
        Label13.Text = endWK
        'Label14.Text = theDay

    End Function
    Private Sub calAppointment_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles calAppointment.DateChanged

        TheDaysOfOurLives()

        'today = calAppointment.SelectionStart
        'sqlToday = "'%" + today + "%'"
        'plus1 = calAppointment.SelectionRange.Start.AddDays(1)
        'plus2 = calAppointment.SelectionRange.Start.AddDays(2)
        'plus3 = calAppointment.SelectionRange.Start.AddDays(3)
        'subt1 = calAppointment.SelectionRange.Start.AddDays(-1)
        'subt2 = calAppointment.SelectionRange.Start.AddDays(-2)
        'subt3 = calAppointment.SelectionRange.Start.AddDays(-3)

        'Dim TheAdvisor As String
        'TheAdvisor = "'" + frmLogin.UserID + "'"

        'Dim oConn As OleDbConnection
        'Dim oComm As OleDbDataAdapter
        'Dim sConn As String
        'Dim sComm As String
        'Dim oDataSet As New DataSet
        'Dim db As String = "..\..\..\DB\COBAdvisingAppts.mdb"

        'Build the connection string 
        'sConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & db & "; Persist Security Info=False;"
        'If rdobtnDay.Checked = True Then sComm += " and Appointment LIKE" + sqlToday

        'sComm = "SELECT * FROM Appointments WHERE Advisor=" + TheAdvisor
        'sComm += " and Appointment LIKE" + sqlToday



        'Create the connection and command objects 
        'oConn = New OleDbConnection(sConn)
        'oComm = New OleDbDataAdapter(sComm, oConn)

        'Fill the dataset with the results of the query 
        'oComm.Fill(oDataSet)

        'Set the grid source to the dataset and bind the data 
        'DataGrid1.DataSource = oDataSet.Tables("Availability").DefaultView
        'DataGrid1.DataBind()






        'OleDbDataAdapter1.Fill(DataSet11)
        'DataGrid1.DataSource = oDataSet
        'DataGrid1.DataMember = "Appointment"


        'Label4.Text = System.DateTime.Today.ToShortDateString()


    End Sub




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        recCount = oDataSet.Tables(0).Rows.Count
        'recCount = oDataSet.Tables(0).Rows.RemoveAt
        'oDataSet.Tables(0).Rows.RemoveAt(1)
        dgridInd = DataGrid1.CurrentRowIndex

        If MsgBox("OK to delete selected appointment: " + "?", MsgBoxStyle.OKCancel, "Are you sure?") = MsgBoxResult.OK Then
            'delete it from the dataset
            oDataSet.Tables(0).Rows.RemoveAt(dgridInd)


            'update the table
            oDataSet.AcceptChanges()
            oComm.Update(oDataSet.Tables(0))
            MsgBox("An email will be sent to student")
        Else
            'reset the dataset 
            oDataSet.Tables(0).RejectChanges()
        End If


        '  Label15.Text = "selected=" & dgridInd & "     Count=" & recCount
        ' oDataSet.Tables(0).Rows.RemoveAt(dgridInd)
    End Sub

    Private Sub DataGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGrid1.Navigate
        Label15.Text = "selected=" & dgridInd & "     Count=" & recCount
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        recCount = oDataSet.Tables(0).Rows.Count
        'recCount = oDataSet.Tables(0).Rows.RemoveAt
        'oDataSet.Tables(0).Rows.RemoveAt(1)
        dgridInd = DataGrid1.CurrentRowIndex



        If MsgBox("OK to add new appointment " + "?", MsgBoxStyle.OKCancel, "Are you sure?") = MsgBoxResult.OK Then
            

            Dim cm As OleDb.OleDbCommandBuilder = New OleDb.OleDbCommandBuilder(oComm)
            'update the table
            oDataSet.AcceptChanges()
            oComm.Update(oDataSet)





            MsgBox("An email will be sent to student")
        Else
            'reset the dataset 
            oDataSet.Tables(0).RejectChanges()
        End If
    End Sub
End Class
