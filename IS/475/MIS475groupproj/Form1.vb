Imports System.Data.OleDb
Imports ADOX

Public Class frmFrontEnd
    Inherits System.Windows.Forms.Form

    'Global Variables
    'Dim Conn As New ADODB.Connection
    'Dim Rec As New ADODB.Recordset

    'Dim cn As OleDbConnection
    'Dim cmd As OleDbCommand
    'Dim dr As OleDbDataReader

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
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents cmdDoctors As System.Windows.Forms.Button
    Friend WithEvents cmdPatients As System.Windows.Forms.Button
    Friend WithEvents cmdHospitals As System.Windows.Forms.Button
    Friend WithEvents cmdAbout As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFrontEnd))
        Me.cmdExit = New System.Windows.Forms.Button
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.cmdDoctors = New System.Windows.Forms.Button
        Me.cmdPatients = New System.Windows.Forms.Button
        Me.cmdHospitals = New System.Windows.Forms.Button
        Me.cmdAbout = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.SuspendLayout()
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(112, 240)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(72, 24)
        Me.cmdExit.TabIndex = 4
        Me.cmdExit.Text = "E&xit"
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Jet OLEDB:Database Password=;Data Source=""groupproj.mdb"";Password=" & _
        ";Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsof" & _
        "t.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Propert" & _
        "ies=;Mode=""ReadWrite|Share Deny None"";Jet OLEDB:New Database Password=;Jet OLEDB" & _
        ":Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet O" & _
        "LEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Databa" & _
        "se=False"
        '
        'cmdDoctors
        '
        Me.cmdDoctors.Location = New System.Drawing.Point(8, 40)
        Me.cmdDoctors.Name = "cmdDoctors"
        Me.cmdDoctors.Size = New System.Drawing.Size(280, 23)
        Me.cmdDoctors.TabIndex = 1
        Me.cmdDoctors.Text = "&Doctor Records"
        '
        'cmdPatients
        '
        Me.cmdPatients.Location = New System.Drawing.Point(8, 8)
        Me.cmdPatients.Name = "cmdPatients"
        Me.cmdPatients.Size = New System.Drawing.Size(280, 23)
        Me.cmdPatients.TabIndex = 0
        Me.cmdPatients.Text = "&Patient Records"
        '
        'cmdHospitals
        '
        Me.cmdHospitals.Location = New System.Drawing.Point(8, 72)
        Me.cmdHospitals.Name = "cmdHospitals"
        Me.cmdHospitals.Size = New System.Drawing.Size(280, 23)
        Me.cmdHospitals.TabIndex = 2
        Me.cmdHospitals.Text = "&Hospital Records"
        '
        'cmdAbout
        '
        Me.cmdAbout.Location = New System.Drawing.Point(112, 216)
        Me.cmdAbout.Name = "cmdAbout"
        Me.cmdAbout.Size = New System.Drawing.Size(72, 24)
        Me.cmdAbout.TabIndex = 3
        Me.cmdAbout.Text = "&About..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(296, 272)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'frmFrontEnd
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.cmdAbout)
        Me.Controls.Add(Me.cmdHospitals)
        Me.Controls.Add(Me.cmdPatients)
        Me.Controls.Add(Me.cmdDoctors)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmFrontEnd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Group 1 - Database Front End"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        'Exit Program
        End
    End Sub

    Private Sub frmFrontEnd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdDoctor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDoctors.Click
        'Show Doctor Data Form
        Dim objStupidFormObject As New DoctorDataForm1
        objStupidFormObject.Show()
        'Hide Main Form
        Me.Hide()
    End Sub

    Private Sub cmdAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAbout.Click
        'Show "About" Information
        MsgBox("IS 475 - Database Design & Implementation" & (Chr(13)) & "Spring 2006" & (Chr(13)) & "Group 1" & (Chr(13)) & (Chr(13)) & "Jacob Truman" & (Chr(13)) & "Wesley Segafredo" & (Chr(13)) & "Scott Nordeen" & (Chr(13)) & "David Lewis" & (Chr(13)) & (Chr(13)) & "(end of credits)", MsgBoxStyle.Information, "About...")
    End Sub

    Private Sub cmdPatients_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPatients.Click
        'Show Patient Data Form
        Dim objStupidFormObject As New PatientDataForm1
        objStupidFormObject.Show()
        'Hide Main Form
        Me.Hide()
    End Sub

    Private Sub cmdHospitals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHospitals.Click
        'Show Hospital Data Form
        Dim objStupidFormObject As New HospitalDataForm1
        objStupidFormObject.Show()
        'Hide Main Form
        Me.Hide()
    End Sub
End Class
