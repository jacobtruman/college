Imports System.Data.OleDb

Public Class frmLogin
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
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents lblChangeLogin As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmLogin))
        Me.btnHelp = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnRegister = New System.Windows.Forms.Button
        Me.lblPassword = New System.Windows.Forms.Label
        Me.lblUserName = New System.Windows.Forms.Label
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.btnLogin = New System.Windows.Forms.Button
        Me.txtUserID = New System.Windows.Forms.TextBox
        Me.lblChangeLogin = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.MistyRose
        Me.btnHelp.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.Location = New System.Drawing.Point(392, 264)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(96, 32)
        Me.btnHelp.TabIndex = 4
        Me.btnHelp.Text = "Help"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(120, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(248, 48)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "New Users must register to make an appointment."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.MistyRose
        Me.btnRegister.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(256, 216)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(96, 32)
        Me.btnRegister.TabIndex = 3
        Me.btnRegister.Text = "Register"
        '
        'lblPassword
        '
        Me.lblPassword.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblPassword.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblPassword.Location = New System.Drawing.Point(136, 152)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(80, 23)
        Me.lblPassword.TabIndex = 7
        Me.lblPassword.Text = "Password"
        '
        'lblUserName
        '
        Me.lblUserName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblUserName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.Black
        Me.lblUserName.Location = New System.Drawing.Point(128, 88)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(232, 23)
        Me.lblUserName.TabIndex = 6
        Me.lblUserName.Text = "Username, SSN, or Student ID"
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(136, 176)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(212, 26)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.Text = ""
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.MistyRose
        Me.btnLogin.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(136, 216)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(100, 32)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Login"
        '
        'txtUserID
        '
        Me.txtUserID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.Location = New System.Drawing.Point(136, 112)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtUserID.Size = New System.Drawing.Size(212, 26)
        Me.txtUserID.TabIndex = 0
        Me.txtUserID.Text = ""
        '
        'lblChangeLogin
        '
        Me.lblChangeLogin.BackColor = System.Drawing.Color.MistyRose
        Me.lblChangeLogin.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangeLogin.Location = New System.Drawing.Point(136, 264)
        Me.lblChangeLogin.Name = "lblChangeLogin"
        Me.lblChangeLogin.Size = New System.Drawing.Size(216, 32)
        Me.lblChangeLogin.TabIndex = 8
        Me.lblChangeLogin.Text = "Change Login"
        '
        'frmLogin
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(504, 309)
        Me.Controls.Add(Me.lblChangeLogin)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Label6)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COB Advising - Login"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Shared UserID As String
    Dim db As String = "..\..\..\DB\COBAdvisingAppts.mdb"
    Dim dbCon As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & db & "; Persist Security Info=False;"

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click

        ' Open the New Registration form
        Dim frmNewRegister As New frmNewRegister
        frmNewRegister.Show()
        Me.Visible = False ' Make the Login form invisible

    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        UserValidation()
    End Sub

    ' Checks to see if a valid user ID and password were entered and if they are for the same user
    Private Sub UserValidation()

        Dim Password, sqlSelectUser, sqlSelectStudent, sqlSelectPassword As String
        Dim UserIDFound, PasswordFound, UserFound As Boolean ' Username found and Password found properties
        Dim oledbcon As New OleDbConnection(dbCon)

        ' Reset variables
        UserIDFound = False
        PasswordFound = False
        Permission = ""
        UserID = txtUserID.Text ' Get entered user ID
        Password = txtPassword.Text ' Get entered password

        Try
            ' Setup DataAdapter1 to read from the DB User Table
            Dim UserReader As OleDbDataReader
            oledbcon.Open() ' Open the connection to the DB

            sqlSelectUser = "SELECT Username, Password, Permission FROM [User] WHERE Username = '" & UserID & "' AND Password = '" & Password & "'"
            Dim searchCmd As OleDbCommand = New OleDbCommand(sqlSelectUser, oledbcon)
            UserReader = searchCmd.ExecuteReader()

            ' Read the DB User table and check if the entered user ID is a valid Username
            While UserReader.Read()
                Dim UserRead As Integer = 0 ' Represents the field count in a record
                For UserRead = 0 To UserReader.FieldCount - 1 ' Read a row one field at a time
                    Select Case UserRead
                        Case 0
                            If UserReader(UserRead) = UserID Then
                                Username = UserReader(UserRead)
                                UserIDFound = True
                            End If
                        Case 1
                            If UserReader(UserRead) = Password Then
                                Password = UserReader(UserRead)
                                PasswordFound = True
                            End If
                        Case 2
                            If UserIDFound = True And PasswordFound = True Then
                                Permission = UserReader(UserRead)
                            End If
                    End Select
                Next
            End While
            oledbcon.Close() ' Close the DB connention
        Catch ex As Exception
            MsgBox(ex.Message)
            UserIDFound = False
            oledbcon.Close()
        End Try


        If UserIDFound = False Then ' If the entered user ID was not a Username in the DB User table
            ' then it was either an invalid username or a SSN or student "L" number was entered
            ' Now check for a SSN or student "L" number in the DB Student table

            Try
                ' Setup DataAdapter2 to read from the DB Student table
                Dim Reader As OleDbDataReader
                oledbcon.Open()

                sqlSelectStudent = "SELECT Username, SSN, LNum FROM [Student] WHERE SSN = '" & UserID & "' OR LNum = '" & UserID & "'"
                Dim findCmd As OleDbCommand = New OleDbCommand(sqlSelectStudent, oledbcon)
                Reader = findCmd.ExecuteReader()

                ' Read the DB Student table and check if the entered user ID is a valid SSN or student "L" number
                While Reader.Read()
                    Dim read As Integer = 0 ' Represents the field count in a record
                    For read = 0 To Reader.FieldCount - 1
                        If IsDBNull(Reader(read)) = False Then
                            Select Case read
                                Case 0
                                    ' If the 
                                    If UserID = Reader(read) Then
                                        UserIDFound = True
                                    End If
                                Case 1
                                    If UserID = Reader(read) Then
                                        UserIDFound = True
                                    End If
                                Case 2
                                    If UserIDFound = True Then
                                        Username = Reader(read)
                                    End If
                            End Select
                            If UserIDFound = True And Username <> "" Then
                                Exit While
                            End If
                        End If
                    Next
                End While
                oledbcon.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                UserIDFound = False
                oledbcon.Close()
            End Try

            If UserIDFound = True And Username <> "" Then

                Try
                    Dim PasswordReader As System.Data.OleDb.OleDbDataReader
                    oledbcon.Open()

                    sqlSelectPassword = "SELECT Username, Password, Permission FROM [User] WHERE Username = '" & Username & "' AND Password = '" & Password & "'"
                    Dim getCmd As OleDbCommand = New OleDbCommand(sqlSelectPassword, oledbcon)
                    PasswordReader = getCmd.ExecuteReader()

                    While PasswordReader.Read()
                        Dim PWRead As Integer = 0
                        For PWRead = 0 To PasswordReader.FieldCount - 1
                            Select Case PWRead
                                Case 0
                                    If Username = PasswordReader(PWRead) Then
                                        UserFound = True
                                    End If
                                Case 1
                                    If UserFound = True Then
                                        If Password = PasswordReader(PWRead) Then
                                            PasswordFound = True
                                        End If
                                    End If
                                Case 2
                                    If UserFound = True And PasswordFound = True Then
                                        Permission = PasswordReader(PWRead)
                                    End If
                            End Select
                        Next
                    End While
                    oledbcon.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    PasswordFound = False
                    oledbcon.Close()
                End Try
            End If
        End If

        If UserIDFound = True And PasswordFound = True Then

            Select Case Permission

                Case "Student"
                    Dim frmStudentfunctions As New frmStudentFunctions
                    frmStudentfunctions.Show()
                    Me.Visible = False

                Case "Advisor"
                    Dim frmAdvisorFunctions As New frmAdvisorFunctions
                    frmAdvisorFunctions.Show()
                    Me.Visible = False

                Case "Staff"
                    Dim frmStaffFunctions As New frmStaffFunctions
                    frmStaffFunctions.Show()
                    Me.Visible = False

                Case "Admin"
                    Dim frmAdminFunctions As New frmAdminFunctions
                    frmAdminFunctions.Show()
                    Me.Visible = False

            End Select

        ElseIf UserIDFound = True And PasswordFound = False Then
            MsgBox("Invalid Password.")
            txtPassword.Focus()
            txtPassword.SelectAll()
        Else
            MsgBox("User ID not found.")
            txtUserID.Focus()
            txtUserID.SelectAll()
        End If

    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsForms.frmLogin = Me
        txtPassword.Text = ""
        txtUserID.Text = ""
        txtUserID.Focus()
    End Sub

    Private Sub frmLogin_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        txtUserID.Text = ""
        txtPassword.Text = ""
        txtUserID.Focus()
    End Sub

    Private Sub frmLogin_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        End
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Dim Help As New frmLoginHelp
        Help.ShowDialog(Me)
    End Sub

    Private Sub lblChangeLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblChangeLogin.Click
        Dim frmChangeLogin As New frmChangeLogin
        frmChangeLogin.Show()
        Me.Visible = False
    End Sub

End Class
