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
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblTextBoxLabel As System.Windows.Forms.Label
    Friend WithEvents lstCountryBox As System.Windows.Forms.ListBox
    Friend WithEvents lblCountry As System.Windows.Forms.Label
    Friend WithEvents lblGreeting As System.Windows.Forms.Label
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label
        Me.lblTextBoxLabel = New System.Windows.Forms.Label
        Me.lstCountryBox = New System.Windows.Forms.ListBox
        Me.lblCountry = New System.Windows.Forms.Label
        Me.lblGreeting = New System.Windows.Forms.Label
        Me.btnQuit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(8, 8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(280, 24)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "International Welcome Program"
        '
        'lblTextBoxLabel
        '
        Me.lblTextBoxLabel.Location = New System.Drawing.Point(48, 40)
        Me.lblTextBoxLabel.Name = "lblTextBoxLabel"
        Me.lblTextBoxLabel.Size = New System.Drawing.Size(120, 23)
        Me.lblTextBoxLabel.TabIndex = 1
        Me.lblTextBoxLabel.Text = "Choose a country"
        '
        'lstCountryBox
        '
        Me.lstCountryBox.Location = New System.Drawing.Point(48, 80)
        Me.lstCountryBox.Name = "lstCountryBox"
        Me.lstCountryBox.Size = New System.Drawing.Size(120, 69)
        Me.lstCountryBox.TabIndex = 2
        '
        'lblCountry
        '
        Me.lblCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountry.Location = New System.Drawing.Point(48, 168)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(120, 23)
        Me.lblCountry.TabIndex = 3
        '
        'lblGreeting
        '
        Me.lblGreeting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGreeting.ForeColor = System.Drawing.Color.Red
        Me.lblGreeting.Location = New System.Drawing.Point(48, 208)
        Me.lblGreeting.Name = "lblGreeting"
        Me.lblGreeting.Size = New System.Drawing.Size(192, 23)
        Me.lblGreeting.TabIndex = 4
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(104, 240)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.TabIndex = 5
        Me.btnQuit.Text = "Quit"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.lblGreeting)
        Me.Controls.Add(Me.lblCountry)
        Me.Controls.Add(Me.lstCountryBox)
        Me.Controls.Add(Me.lblTextBoxLabel)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.Text = "Case Greeting"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstCountryBox.Items.Add("England")
        lstCountryBox.Items.Add("Germany")
        lstCountryBox.Items.Add("Mexico")
        lstCountryBox.Items.Add("Italy")
    End Sub

    Private Sub lstCountryBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCountryBox.SelectedIndexChanged
        lblCountry.Text = lstCountryBox.Text
        Select Case lstCountryBox.SelectedIndex
            Case 0
                lblGreeting.Text = "Hello, programmer"
            Case 1
                lblGreeting.Text = "Hallo, programmierer"
            Case 2
                lblGreeting.Text = "Hola, programador"
            Case 3
                lblGreeting.Text = "Ciao, programmatore"
        End Select
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        End
    End Sub

    Private Sub lstCountryBox_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstCountryBox.MouseHover
        If lstCountryBox.SelectedIndex < 0 Or _
            lstCountryBox.SelectedIndex > 4 Then
            lblGreeting.Text = "Please click the country name"
        End If
    End Sub
End Class
