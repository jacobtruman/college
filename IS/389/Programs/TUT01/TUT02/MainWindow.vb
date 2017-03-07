Public Class MainWindow
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
    Friend WithEvents lblMainWindow As System.Windows.Forms.Label
    Friend WithEvents btnGoTest As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblMainWindow = New System.Windows.Forms.Label()
        Me.btnGoTest = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMainWindow
        '
        Me.lblMainWindow.Location = New System.Drawing.Point(80, 64)
        Me.lblMainWindow.Name = "lblMainWindow"
        Me.lblMainWindow.Size = New System.Drawing.Size(112, 23)
        Me.lblMainWindow.TabIndex = 0
        Me.lblMainWindow.Text = "This is Main Window"
        Me.lblMainWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGoTest
        '
        Me.btnGoTest.Location = New System.Drawing.Point(80, 120)
        Me.btnGoTest.Name = "btnGoTest"
        Me.btnGoTest.Size = New System.Drawing.Size(112, 23)
        Me.btnGoTest.TabIndex = 1
        Me.btnGoTest.Text = "Go to Test"
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(208, 232)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "Quit"
        '
        'MainWindow
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnQuit, Me.btnGoTest, Me.lblMainWindow})
        Me.Name = "MainWindow"
        Me.Text = "Jacob Truman"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click

        Me.Dispose()

    End Sub

    Private Sub btnGoTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoTest.Click
        Dim frmTest As New Test(Me)

        frmTest.Top = Me.Top
        frmTest.Left = Me.Left
        frmTest.Show()
        Me.Visible = False

    End Sub
End Class
