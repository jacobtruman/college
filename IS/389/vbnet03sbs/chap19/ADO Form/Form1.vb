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
    Friend WithEvents txtInstructor As System.Windows.Forms.TextBox
    Friend WithEvents lblInstructor As System.Windows.Forms.Label
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.Container

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents DsInstructors1 As ADO_Form.DsInstructors
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnFirst = New System.Windows.Forms.Button
        Me.btnLast = New System.Windows.Forms.Button
        Me.btnPrev = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.btnLoad = New System.Windows.Forms.Button
        Me.lblInstructor = New System.Windows.Forms.Label
        Me.txtInstructor = New System.Windows.Forms.TextBox
        Me.lblCount = New System.Windows.Forms.Label
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.DsInstructors1 = New ADO_Form.DsInstructors
        CType(Me.DsInstructors1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(120, 176)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(72, 32)
        Me.btnFirst.TabIndex = 6
        Me.btnFirst.Text = "First"
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(208, 176)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(72, 32)
        Me.btnLast.TabIndex = 7
        Me.btnLast.Text = "Last"
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(120, 224)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(72, 32)
        Me.btnPrev.TabIndex = 3
        Me.btnPrev.Text = "Prev"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(208, 224)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(72, 32)
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = "Next"
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(24, 224)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(80, 32)
        Me.btnLoad.TabIndex = 2
        Me.btnLoad.Text = "Load Data"
        '
        'lblInstructor
        '
        Me.lblInstructor.Location = New System.Drawing.Point(16, 96)
        Me.lblInstructor.Name = "lblInstructor"
        Me.lblInstructor.Size = New System.Drawing.Size(88, 16)
        Me.lblInstructor.TabIndex = 1
        Me.lblInstructor.Text = "Instructor"
        Me.lblInstructor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtInstructor
        '
        Me.txtInstructor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsInstructors1, "Instructors.Instructor"))
        Me.txtInstructor.Location = New System.Drawing.Point(112, 96)
        Me.txtInstructor.Name = "txtInstructor"
        Me.txtInstructor.Size = New System.Drawing.Size(152, 20)
        Me.txtInstructor.TabIndex = 0
        Me.txtInstructor.Text = ""
        '
        'lblCount
        '
        Me.lblCount.Location = New System.Drawing.Point(112, 120)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(128, 24)
        Me.lblCount.TabIndex = 8
        Me.lblCount.Text = "Record 0 of 0"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Instructors", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Instructor", "Instructor"), New System.Data.Common.DataColumnMapping("InstructorID", "InstructorID")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT Instructor, InstructorID FROM Instructors"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO Instructors(Instructor) VALUES (?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Instructor", System.Data.OleDb.OleDbType.VarWChar, 50, "Instructor"))
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE Instructors SET Instructor = ? WHERE (InstructorID = ?) AND (Instructor = " & _
        "? OR ? IS NULL AND Instructor IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Instructor", System.Data.OleDb.OleDbType.VarWChar, 50, "Instructor"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InstructorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InstructorID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Instructor", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Instructor", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Instructor1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Instructor", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM Instructors WHERE (InstructorID = ?) AND (Instructor = ? OR ? IS NULL" & _
        " AND Instructor IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_InstructorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InstructorID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Instructor", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Instructor", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Instructor1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Instructor", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=0;Data Source=""C:\vbnet03sbs\chap19\Students.mdb"";Jet OLEDB:Engine T" & _
        "ype=4;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SF" & _
        "P=False;persist security info=False;Extended Properties=;Mode=Share Deny None;Je" & _
        "t OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet OLEDB:" & _
        "Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=Fals" & _
        "e;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1"
        '
        'DsInstructors1
        '
        Me.DsInstructors1.DataSetName = "DsInstructors"
        Me.DsInstructors1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.lblInstructor)
        Me.Controls.Add(Me.txtInstructor)
        Me.Name = "Form1"
        Me.Text = "ADO Form"
        CType(Me.DsInstructors1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Count()
        Dim Records, Current As Integer
        Records = Me.BindingContext( _
          DsInstructors1, "Instructors").Count
        Current = Me.BindingContext( _
          DsInstructors1, "Instructors").Position + 1
        lblCount.Text = "Record " & Current.ToString & " of " & _
          Records.ToString
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        DsInstructors1.Clear()
        OleDbDataAdapter1.Fill(DsInstructors1)
        Count()
    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        Me.BindingContext(DsInstructors1, "Instructors").Position = 0
        Count()
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Me.BindingContext(DsInstructors1, "Instructors").Position = _
          Me.BindingContext(DsInstructors1, "Instructors").Count - 1
        Count()
    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        Me.BindingContext(DsInstructors1, "Instructors").Position -= 1
        Count()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Me.BindingContext(DsInstructors1, "Instructors").Position += 1
        Count()
    End Sub
End Class
