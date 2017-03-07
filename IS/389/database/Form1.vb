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
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txt1 = New System.Windows.Forms.TextBox
        Me.txt2 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(48, 88)
        Me.txt1.Name = "txt1"
        Me.txt1.TabIndex = 0
        Me.txt1.Text = "TextBox1"
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(48, 56)
        Me.txt2.Name = "txt2"
        Me.txt2.TabIndex = 1
        Me.txt2.Text = "TextBox2"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(64, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(176, 136)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Button2"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim iCounter As Integer = 0
    Dim sql As String = "Select * from pupils"

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = ..\school.mdb"
        con.Open()

        'MsgBox("A Connection to the Database is now open")

        da = New OleDb.OleDbDataAdapter(sql, con)

        da.Fill(ds, "AddressBook")

        con.Close()

        txt1.Text = ds.Tables("AddressBook").Rows(0).Item("LastName")
        txt2.Text = ds.Tables("AddressBook").Rows(0).Item("FirstName")

        'MsgBox("The Connection to the Database is now Closed")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        iCounter += 1
        txt1.Text = ds.Tables("AddressBook").Rows(iCounter).Item("LastName")
        txt2.Text = ds.Tables("AddressBook").Rows(iCounter).Item("FirstName")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)

        ds.Tables("AddressBook").Rows(iCounter).Item("LastName") = txt1.Text
        ds.Tables("AddressBook").Rows(iCounter).Item("FirstName") = txt2.Text

        da.Update(ds, "AddressBook")

        MsgBox("Data updated")


    End Sub
End Class
