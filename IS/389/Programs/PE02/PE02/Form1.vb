Public Class frmMain
    Inherits System.Windows.Forms.Form

    ' Create and initialize Circlae class
    Private objCircle As Graphics = CreateGraphics()
    ' Set diameter of Circle
    Private Const c_intDiameter As Integer = 25
    Private Const c_intDiameter2 As Integer = 10

    'Create Random class
    Dim objRandom As Random = New Random

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
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnRun = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(208, 232)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.TabIndex = 0
        Me.btnRun.Text = "Run"
        '
        'ComboBox1
        '
        Me.ComboBox1.Items.AddRange(New Object() {"100", "90", "80", "70", "60", "50", "40", "30", "20", "10"})
        Me.ComboBox1.Location = New System.Drawing.Point(112, 232)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(48, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.Text = "90"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 235)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "The class is"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(165, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "% full"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnRun)
        Me.Name = "frmMain"
        Me.Text = "Jacob Truman"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun.Click
        Const numRows = 8, numSeats = 8
        Dim seatArray As Integer(,) = New Integer(numSeats, numRows) {}
        Dim solnArray As Integer(,) = New Integer(numSeats, numRows) {}
        Dim g_Left, g_Top, g_Left2, g_Top2, posX1, posY1, iCounter, jCounter, intChance As Integer
        Dim perOccu As Double
        Dim strEdge, strDirection As String
        Dim solnNotPossible As Boolean

        perOccu = ComboBox1.SelectedItem / 10

        ' Create and display an array representing occupied seats
        g_Left = 0
        g_Top = 0
        For iCounter = numRows To 1 Step -1
            For jCounter = 1 To numSeats
                intChance = objRandom.Next(1, 11)
                If intChance <= perOccu Then
                    seatArray(jCounter, iCounter) = 1
                    DisplayCircle("Red", g_Left, g_Top, c_intDiameter)
                    'objCircle.FillEllipse(New SolidBrush(Color.Red), _
                    '   g_Left, g_Top, c_intDiameter, c_intDiameter)
                Else
                    seatArray(jCounter, iCounter) = 0
                    DisplayCircle("Black", g_Left, g_Top, c_intDiameter)
                    'objCircle.FillEllipse(New SolidBrush(Color.Black), _
                    '    g_Left, g_Top, c_intDiameter, c_intDiameter)
                End If
                g_Left += c_intDiameter * 1.1
            Next
            g_Left = 0
            g_Top += c_intDiameter * 1.1
        Next

        ' Initialize the solution array with zeros
        For iCounter = numRows To 1 Step -1
            For jCounter = 1 To numSeats
                solnArray(jCounter, iCounter) = 0
            Next
        Next

        ' Set the Start and End positions
        posX1 = objRandom.Next(1, 9)
        posY1 = 1
        solnArray(posX1, posY1) = 1

        ' Repaint seating arrangement, showing Start position
        g_Left = 0
        g_Top = 0
        For iCounter = numRows To 1 Step -1
            For jCounter = 1 To numSeats
                If seatArray(jCounter, iCounter) = 1 Then
                    DisplayCircle("Red", g_Left, g_Top, c_intDiameter)
                    'objCircle.FillEllipse(New SolidBrush(Color.Red), _
                    '    g_Left, g_Top, c_intDiameter, c_intDiameter)
                    If solnArray(jCounter, iCounter) = 1 Then
                        g_Left2 = g_Left + (c_intDiameter - c_intDiameter2) / 2
                        g_Top2 = g_Top + (c_intDiameter - c_intDiameter2) / 2
                        DisplayCircle("Green", g_Left2, g_Top2, c_intDiameter2)
                        'objCircle.FillEllipse(New SolidBrush(Color.Green), _
                        '   g_Left2, g_Top2, c_intDiameter2, c_intDiameter2)
                    End If
                Else
                    DisplayCircle("Black", g_Left, g_Top, c_intDiameter)
                    'objCircle.FillEllipse(New SolidBrush(Color.Black), _
                    '    g_Left, g_Top, c_intDiameter, c_intDiameter)
                    If solnArray(jCounter, iCounter) = 1 Then
                        g_Left2 = g_Left + (c_intDiameter - c_intDiameter2) / 2
                        g_Top2 = g_Top + (c_intDiameter - c_intDiameter2) / 2
                        DisplayCircle("White", g_Left2, g_Top2, c_intDiameter2)
                        'objCircle.FillEllipse(New SolidBrush(Color.White), _
                        '    g_Left2, g_Top2, c_intDiameter2, c_intDiameter2)
                    End If
                End If
                g_Left += c_intDiameter * 1.1
            Next
            g_Left = 0
            g_Top += c_intDiameter * 1.1
        Next
        MsgBox("Start position = (" & posX1 & ", " & posY1 & ")")

        ' Begin search algorithm
        If seatArray(posX1, posY1) = 0 Then
            MsgBox("Start Position is unoccupied", MsgBoxStyle.Critical, _
                "Solution Not Possible")
        Else
            strEdge = "Left"
            strDirection = "Left"
            solnNotPossible = False
            Do Until posY1 = numRows Or solnNotPossible
                If strEdge = "Left" Then
                    Select Case strDirection
                        Case "Forward"
                            posY1 += 1
                            strDirection = "Left"
                            If seatArray(posX1, posY1) = 0 Then
                                posY1 -= 1
                                strDirection = "Right"
                            Else
                                solnArray(posX1, posY1) += 1
                            End If
                        Case "Left"
                            posX1 -= 1
                            strDirection = "Forward"
                            If posX1 = 0 Then
                                posX1 = 1
                            ElseIf seatArray(posX1, posY1) = 0 Then
                                posX1 += 1
                            Else
                                solnArray(posX1, posY1) += 1
                                strDirection = "Left"
                            End If
                        Case "Right"
                            posX1 += 1
                            strDirection = "Forward"
                            If posX1 = numSeats + 1 Then
                                posX1 = numSeats
                                If seatArray(posX1, posY1 + 1) = 0 Then
                                    solnNotPossible = True
                                End If
                            ElseIf seatArray(posX1, posY1) = 0 Then
                                posX1 -= 1
                                strEdge = "Right"
                                strDirection = "Back"
                            Else
                                solnArray(posX1, posY1) += 1
                            End If
                    End Select
                Else
                    Select Case strDirection
                        Case "Back"
                            posY1 -= 1
                            strDirection = "Right"
                            If posY1 = 0 Then
                                posY1 = 1
                                If posX1 = numSeats Or seatArray(posX1 + 1, posY1) = 0 Then
                                    solnNotPossible = True
                                End If
                            ElseIf seatArray(posX1, posY1) = 0 Then
                                posY1 += 1
                                strDirection = "Left"
                            Else
                                solnArray(posX1, posY1) += 1
                            End If
                        Case "Right"
                            posX1 += 1
                            strDirection = "Right"
                            If posX1 = numSeats + 1 Then
                                posX1 = numSeats
                                If posY1 = 1 Or seatArray(posX1, posY1 + 1) = 0 Then
                                    solnNotPossible = True
                                End If
                            ElseIf seatArray(posX1, posY1) = 0 Then
                                posX1 -= 1
                                strDirection = "Back"
                            Else
                                solnArray(posX1, posY1) += 1
                                If seatArray(posX1, posY1 + 1) = 1 Then
                                    strEdge = "Left"
                                    strDirection = "Forward"
                                End If
                            End If
                        Case "Left"
                            posX1 -= 1
                            strDirection = "Back"
                            If posX1 = 0 Then
                                posX1 = 1
                                If posY1 = 1 Or seatArray(posX1, posY1 - 1) = 0 Then
                                    solnNotPossible = True
                                End If
                            ElseIf seatArray(posX1, posY1) = 0 Then
                                posX1 += 1
                                strDirection = "Forward"
                            Else
                                solnArray(posX1, posY1) += 1
                            End If
                        Case "Forward"
                            posY1 += 1
                            strDirection = "Left"
                            If seatArray(posX1, posY1) = 0 Then
                                posY1 -= 1
                                strDirection = "Right"
                            Else
                                solnArray(posX1, posY1) += 1
                            End If
                    End Select
                End If
            Loop
            If solnNotPossible Then
                MsgBox("Solution not possible", MsgBoxStyle.Critical, _
                    "Search Result")
            Else
                MsgBox("Solution found", MsgBoxStyle.Exclamation, _
                    "Search Result")
            End If
        End If

        ' Show results of search
        g_Left = 0
        g_Top = 0
        For iCounter = numRows To 1 Step -1
            For jCounter = 1 To numSeats
                If seatArray(jCounter, iCounter) = 1 Then
                    DisplayCircle("Red", g_Left, g_Top, c_intDiameter)
                    'objCircle.FillEllipse(New SolidBrush(Color.Red), _
                    '    g_Left, g_Top, c_intDiameter, c_intDiameter)
                    If solnArray(jCounter, iCounter) >= 1 Then
                        g_Left2 = g_Left + (c_intDiameter - c_intDiameter2) / 2
                        g_Top2 = g_Top + (c_intDiameter - c_intDiameter2) / 2
                        DisplayCircle("Blue", g_Left2, g_Top2, c_intDiameter2)
                        'objCircle.FillEllipse(New SolidBrush(Color.Blue), _
                        '    g_Left2, g_Top2, c_intDiameter2, c_intDiameter2)
                    End If
                Else
                    DisplayCircle("Black", g_Left, g_Top, c_intDiameter)
                    'objCircle.FillEllipse(New SolidBrush(Color.Black), _
                    '    g_Left, g_Top, c_intDiameter, c_intDiameter)
                    If solnArray(jCounter, iCounter) >= 1 Then
                        g_Left2 = g_Left + (c_intDiameter - c_intDiameter2) / 2
                        g_Top2 = g_Top + (c_intDiameter - c_intDiameter2) / 2
                        DisplayCircle("Blue", g_Left2, g_Top2, c_intDiameter2)
                        'objCircle.FillEllipse(New SolidBrush(Color.Blue), _
                        '    g_Left2, g_Top2, c_intDiameter2, c_intDiameter2)
                    End If
                End If
                g_Left += c_intDiameter * 1.1
            Next
            g_Left = 0
            g_Top += c_intDiameter * 1.1
        Next
    End Sub

    ' Draw Red, Black, Green, or Blue circle
    Sub DisplayCircle(ByVal gColor As String, ByVal gLeft As Integer, _
        ByVal gTop As Integer, ByVal gDiameter As Integer)

        Select Case gColor
            Case "Red"
                objCircle.FillEllipse(New SolidBrush(Color.Red), _
                    gLeft, gTop, gDiameter, gDiameter)
            Case "Black"
                objCircle.FillEllipse(New SolidBrush(Color.Black), _
                    gLeft, gTop, gDiameter, gDiameter)
            Case "Green"
                objCircle.FillEllipse(New SolidBrush(Color.Green), _
                    gLeft, gTop, gDiameter, gDiameter)
            Case "White"
                objCircle.FillEllipse(New SolidBrush(Color.White), _
                    gLeft, gTop, gDiameter, gDiameter)
            Case "Blue"
                objCircle.FillEllipse(New SolidBrush(Color.Blue), _
                    gLeft, gTop, gDiameter, gDiameter)
        End Select
    End Sub

End Class
