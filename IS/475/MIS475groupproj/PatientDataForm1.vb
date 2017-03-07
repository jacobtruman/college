Public Class PatientDataForm1
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
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents objpatients As MIS475groupproj.patients
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnCancelAll As System.Windows.Forms.Button
    Friend WithEvents lblpat_address As System.Windows.Forms.Label
    Friend WithEvents lblpat_city As System.Windows.Forms.Label
    Friend WithEvents lblpat_dob As System.Windows.Forms.Label
    Friend WithEvents lblpat_email As System.Windows.Forms.Label
    Friend WithEvents lblpat_fname As System.Windows.Forms.Label
    Friend WithEvents editpat_address As System.Windows.Forms.TextBox
    Friend WithEvents editpat_city As System.Windows.Forms.TextBox
    Friend WithEvents editpat_dob As System.Windows.Forms.TextBox
    Friend WithEvents editpat_email As System.Windows.Forms.TextBox
    Friend WithEvents editpat_fname As System.Windows.Forms.TextBox
    Friend WithEvents lblpat_lname As System.Windows.Forms.Label
    Friend WithEvents lblpat_phone As System.Windows.Forms.Label
    Friend WithEvents lblpat_ssn As System.Windows.Forms.Label
    Friend WithEvents lblpat_state As System.Windows.Forms.Label
    Friend WithEvents lblpat_zip As System.Windows.Forms.Label
    Friend WithEvents editpat_lname As System.Windows.Forms.TextBox
    Friend WithEvents editpat_phone As System.Windows.Forms.TextBox
    Friend WithEvents editpat_ssn As System.Windows.Forms.TextBox
    Friend WithEvents editpat_state As System.Windows.Forms.TextBox
    Friend WithEvents editpat_zip As System.Windows.Forms.TextBox
    Friend WithEvents btnNavFirst As System.Windows.Forms.Button
    Friend WithEvents btnNavPrev As System.Windows.Forms.Button
    Friend WithEvents lblNavLocation As System.Windows.Forms.Label
    Friend WithEvents btnNavNext As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents cmdGoBack As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PatientDataForm1))
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.objpatients = New MIS475groupproj.patients
        Me.btnLoad = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnCancelAll = New System.Windows.Forms.Button
        Me.lblpat_address = New System.Windows.Forms.Label
        Me.lblpat_city = New System.Windows.Forms.Label
        Me.lblpat_dob = New System.Windows.Forms.Label
        Me.lblpat_email = New System.Windows.Forms.Label
        Me.lblpat_fname = New System.Windows.Forms.Label
        Me.editpat_address = New System.Windows.Forms.TextBox
        Me.editpat_city = New System.Windows.Forms.TextBox
        Me.editpat_dob = New System.Windows.Forms.TextBox
        Me.editpat_email = New System.Windows.Forms.TextBox
        Me.editpat_fname = New System.Windows.Forms.TextBox
        Me.lblpat_lname = New System.Windows.Forms.Label
        Me.lblpat_phone = New System.Windows.Forms.Label
        Me.lblpat_ssn = New System.Windows.Forms.Label
        Me.lblpat_state = New System.Windows.Forms.Label
        Me.lblpat_zip = New System.Windows.Forms.Label
        Me.editpat_lname = New System.Windows.Forms.TextBox
        Me.editpat_phone = New System.Windows.Forms.TextBox
        Me.editpat_ssn = New System.Windows.Forms.TextBox
        Me.editpat_state = New System.Windows.Forms.TextBox
        Me.editpat_zip = New System.Windows.Forms.TextBox
        Me.btnNavFirst = New System.Windows.Forms.Button
        Me.btnNavPrev = New System.Windows.Forms.Button
        Me.lblNavLocation = New System.Windows.Forms.Label
        Me.btnNavNext = New System.Windows.Forms.Button
        Me.btnLast = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.cmdGoBack = New System.Windows.Forms.Button
        CType(Me.objpatients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT pat_address, pat_city, pat_dob, pat_email, pat_fname, pat_lname, pat_phone" & _
        ", pat_ssn, pat_state, pat_zip FROM patient"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Data Source=""groupproj.mdb"";Jet OLEDB:Engine Type=5;Jet OLEDB:Glob" & _
        "al Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System datab" & _
        "ase=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Mode=R" & _
        "eadWrite;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on C" & _
        "ompact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OL" & _
        "EDB:Encrypt Database=False"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO patient(pat_address, pat_city, pat_dob, pat_email, pat_fname, pat_lna" & _
        "me, pat_phone, pat_ssn, pat_state, pat_zip) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?" & _
        ")"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("pat_address", System.Data.OleDb.OleDbType.VarWChar, 50, "pat_address"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("pat_city", System.Data.OleDb.OleDbType.VarWChar, 50, "pat_city"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("pat_dob", System.Data.OleDb.OleDbType.VarWChar, 50, "pat_dob"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("pat_email", System.Data.OleDb.OleDbType.VarWChar, 50, "pat_email"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("pat_fname", System.Data.OleDb.OleDbType.VarWChar, 30, "pat_fname"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("pat_lname", System.Data.OleDb.OleDbType.VarWChar, 30, "pat_lname"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("pat_phone", System.Data.OleDb.OleDbType.VarWChar, 50, "pat_phone"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("pat_ssn", System.Data.OleDb.OleDbType.Integer, 0, "pat_ssn"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("pat_state", System.Data.OleDb.OleDbType.VarWChar, 2, "pat_state"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("pat_zip", System.Data.OleDb.OleDbType.VarWChar, 50, "pat_zip"))
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE patient SET pat_address = ?, pat_city = ?, pat_dob = ?, pat_email = ?, pat" & _
        "_fname = ?, pat_lname = ?, pat_phone = ?, pat_ssn = ?, pat_state = ?, pat_zip = " & _
        "? WHERE (pat_ssn = ?) AND (pat_address = ? OR ? IS NULL AND pat_address IS NULL)" & _
        " AND (pat_city = ? OR ? IS NULL AND pat_city IS NULL) AND (pat_dob = ?) AND (pat" & _
        "_email = ? OR ? IS NULL AND pat_email IS NULL) AND (pat_fname = ?) AND (pat_lnam" & _
        "e = ?) AND (pat_phone = ? OR ? IS NULL AND pat_phone IS NULL) AND (pat_state = ?" & _
        " OR ? IS NULL AND pat_state IS NULL) AND (pat_zip = ? OR ? IS NULL AND pat_zip I" & _
        "S NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("pat_address", System.Data.OleDb.OleDbType.VarWChar, 50, "pat_address"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("pat_city", System.Data.OleDb.OleDbType.VarWChar, 50, "pat_city"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("pat_dob", System.Data.OleDb.OleDbType.VarWChar, 50, "pat_dob"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("pat_email", System.Data.OleDb.OleDbType.VarWChar, 50, "pat_email"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("pat_fname", System.Data.OleDb.OleDbType.VarWChar, 30, "pat_fname"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("pat_lname", System.Data.OleDb.OleDbType.VarWChar, 30, "pat_lname"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("pat_phone", System.Data.OleDb.OleDbType.VarWChar, 50, "pat_phone"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("pat_ssn", System.Data.OleDb.OleDbType.Integer, 0, "pat_ssn"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("pat_state", System.Data.OleDb.OleDbType.VarWChar, 2, "pat_state"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("pat_zip", System.Data.OleDb.OleDbType.VarWChar, 50, "pat_zip"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_pat_ssn", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pat_ssn", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_pat_address", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pat_address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_pat_address1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pat_address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_pat_city", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pat_city", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_pat_city1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pat_city", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_pat_dob", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pat_dob", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_pat_email", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pat_email", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_pat_email1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pat_email", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_pat_fname", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pat_fname", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_pat_lname", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pat_lname", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_pat_phone", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pat_phone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_pat_phone1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pat_phone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_pat_state", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pat_state", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_pat_state1", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pat_state", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_pat_zip", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pat_zip", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_pat_zip1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pat_zip", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM patient WHERE (pat_ssn = ?) AND (pat_address = ? OR ? IS NULL AND pat" & _
        "_address IS NULL) AND (pat_city = ? OR ? IS NULL AND pat_city IS NULL) AND (pat_" & _
        "dob = ?) AND (pat_email = ? OR ? IS NULL AND pat_email IS NULL) AND (pat_fname =" & _
        " ?) AND (pat_lname = ?) AND (pat_phone = ? OR ? IS NULL AND pat_phone IS NULL) A" & _
        "ND (pat_state = ? OR ? IS NULL AND pat_state IS NULL) AND (pat_zip = ? OR ? IS N" & _
        "ULL AND pat_zip IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_pat_ssn", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pat_ssn", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_pat_address", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pat_address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_pat_address1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pat_address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_pat_city", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pat_city", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_pat_city1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pat_city", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_pat_dob", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pat_dob", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_pat_email", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pat_email", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_pat_email1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pat_email", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_pat_fname", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pat_fname", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_pat_lname", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pat_lname", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_pat_phone", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pat_phone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_pat_phone1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pat_phone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_pat_state", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pat_state", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_pat_state1", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pat_state", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_pat_zip", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pat_zip", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_pat_zip1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pat_zip", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "patient", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("pat_address", "pat_address"), New System.Data.Common.DataColumnMapping("pat_city", "pat_city"), New System.Data.Common.DataColumnMapping("pat_dob", "pat_dob"), New System.Data.Common.DataColumnMapping("pat_email", "pat_email"), New System.Data.Common.DataColumnMapping("pat_fname", "pat_fname"), New System.Data.Common.DataColumnMapping("pat_lname", "pat_lname"), New System.Data.Common.DataColumnMapping("pat_phone", "pat_phone"), New System.Data.Common.DataColumnMapping("pat_ssn", "pat_ssn"), New System.Data.Common.DataColumnMapping("pat_state", "pat_state"), New System.Data.Common.DataColumnMapping("pat_zip", "pat_zip")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'objpatients
        '
        Me.objpatients.DataSetName = "patients"
        Me.objpatients.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(10, 10)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.TabStop = False
        Me.btnLoad.Text = "&Load"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(365, 10)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.TabStop = False
        Me.btnUpdate.Text = "&Update"
        '
        'btnCancelAll
        '
        Me.btnCancelAll.Location = New System.Drawing.Point(365, 43)
        Me.btnCancelAll.Name = "btnCancelAll"
        Me.btnCancelAll.TabIndex = 2
        Me.btnCancelAll.TabStop = False
        Me.btnCancelAll.Text = "Ca&ncel All"
        '
        'lblpat_address
        '
        Me.lblpat_address.Location = New System.Drawing.Point(232, 72)
        Me.lblpat_address.Name = "lblpat_address"
        Me.lblpat_address.Size = New System.Drawing.Size(56, 23)
        Me.lblpat_address.TabIndex = 3
        Me.lblpat_address.Text = "Address"
        Me.lblpat_address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblpat_city
        '
        Me.lblpat_city.Location = New System.Drawing.Point(240, 96)
        Me.lblpat_city.Name = "lblpat_city"
        Me.lblpat_city.Size = New System.Drawing.Size(40, 23)
        Me.lblpat_city.TabIndex = 4
        Me.lblpat_city.Text = "City"
        Me.lblpat_city.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblpat_dob
        '
        Me.lblpat_dob.Location = New System.Drawing.Point(10, 144)
        Me.lblpat_dob.Name = "lblpat_dob"
        Me.lblpat_dob.Size = New System.Drawing.Size(70, 23)
        Me.lblpat_dob.TabIndex = 5
        Me.lblpat_dob.Text = "Date of Birth"
        Me.lblpat_dob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblpat_email
        '
        Me.lblpat_email.Location = New System.Drawing.Point(80, 200)
        Me.lblpat_email.Name = "lblpat_email"
        Me.lblpat_email.TabIndex = 6
        Me.lblpat_email.Text = "E-Mail"
        Me.lblpat_email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblpat_fname
        '
        Me.lblpat_fname.Location = New System.Drawing.Point(8, 72)
        Me.lblpat_fname.Name = "lblpat_fname"
        Me.lblpat_fname.Size = New System.Drawing.Size(64, 23)
        Me.lblpat_fname.TabIndex = 7
        Me.lblpat_fname.Text = "First Name"
        Me.lblpat_fname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'editpat_address
        '
        Me.editpat_address.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objpatients, "patient.pat_address"))
        Me.editpat_address.Location = New System.Drawing.Point(296, 72)
        Me.editpat_address.Name = "editpat_address"
        Me.editpat_address.Size = New System.Drawing.Size(144, 20)
        Me.editpat_address.TabIndex = 4
        Me.editpat_address.Text = ""
        Me.editpat_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'editpat_city
        '
        Me.editpat_city.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objpatients, "patient.pat_city"))
        Me.editpat_city.Location = New System.Drawing.Point(296, 96)
        Me.editpat_city.Name = "editpat_city"
        Me.editpat_city.Size = New System.Drawing.Size(144, 20)
        Me.editpat_city.TabIndex = 5
        Me.editpat_city.Text = ""
        Me.editpat_city.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'editpat_dob
        '
        Me.editpat_dob.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objpatients, "patient.pat_dob"))
        Me.editpat_dob.Location = New System.Drawing.Point(96, 144)
        Me.editpat_dob.Name = "editpat_dob"
        Me.editpat_dob.Size = New System.Drawing.Size(128, 20)
        Me.editpat_dob.TabIndex = 3
        Me.editpat_dob.Text = ""
        Me.editpat_dob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'editpat_email
        '
        Me.editpat_email.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objpatients, "patient.pat_email"))
        Me.editpat_email.Location = New System.Drawing.Point(192, 200)
        Me.editpat_email.Name = "editpat_email"
        Me.editpat_email.Size = New System.Drawing.Size(168, 20)
        Me.editpat_email.TabIndex = 9
        Me.editpat_email.Text = ""
        Me.editpat_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'editpat_fname
        '
        Me.editpat_fname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objpatients, "patient.pat_fname"))
        Me.editpat_fname.Location = New System.Drawing.Point(96, 72)
        Me.editpat_fname.Name = "editpat_fname"
        Me.editpat_fname.Size = New System.Drawing.Size(128, 20)
        Me.editpat_fname.TabIndex = 0
        Me.editpat_fname.Text = ""
        Me.editpat_fname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblpat_lname
        '
        Me.lblpat_lname.Location = New System.Drawing.Point(8, 96)
        Me.lblpat_lname.Name = "lblpat_lname"
        Me.lblpat_lname.Size = New System.Drawing.Size(64, 23)
        Me.lblpat_lname.TabIndex = 13
        Me.lblpat_lname.Text = "Last Name"
        Me.lblpat_lname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblpat_phone
        '
        Me.lblpat_phone.Location = New System.Drawing.Point(80, 176)
        Me.lblpat_phone.Name = "lblpat_phone"
        Me.lblpat_phone.TabIndex = 14
        Me.lblpat_phone.Text = "Phone #"
        Me.lblpat_phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblpat_ssn
        '
        Me.lblpat_ssn.Location = New System.Drawing.Point(8, 120)
        Me.lblpat_ssn.Name = "lblpat_ssn"
        Me.lblpat_ssn.Size = New System.Drawing.Size(88, 23)
        Me.lblpat_ssn.TabIndex = 15
        Me.lblpat_ssn.Text = "Social Security #"
        Me.lblpat_ssn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblpat_state
        '
        Me.lblpat_state.Location = New System.Drawing.Point(240, 120)
        Me.lblpat_state.Name = "lblpat_state"
        Me.lblpat_state.Size = New System.Drawing.Size(40, 23)
        Me.lblpat_state.TabIndex = 16
        Me.lblpat_state.Text = "State"
        Me.lblpat_state.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblpat_zip
        '
        Me.lblpat_zip.Location = New System.Drawing.Point(224, 144)
        Me.lblpat_zip.Name = "lblpat_zip"
        Me.lblpat_zip.Size = New System.Drawing.Size(64, 23)
        Me.lblpat_zip.TabIndex = 17
        Me.lblpat_zip.Text = "ZIP Code"
        Me.lblpat_zip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'editpat_lname
        '
        Me.editpat_lname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objpatients, "patient.pat_lname"))
        Me.editpat_lname.Location = New System.Drawing.Point(96, 96)
        Me.editpat_lname.Name = "editpat_lname"
        Me.editpat_lname.Size = New System.Drawing.Size(128, 20)
        Me.editpat_lname.TabIndex = 1
        Me.editpat_lname.Text = ""
        Me.editpat_lname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'editpat_phone
        '
        Me.editpat_phone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objpatients, "patient.pat_phone"))
        Me.editpat_phone.Location = New System.Drawing.Point(192, 176)
        Me.editpat_phone.Name = "editpat_phone"
        Me.editpat_phone.Size = New System.Drawing.Size(168, 20)
        Me.editpat_phone.TabIndex = 8
        Me.editpat_phone.Text = ""
        Me.editpat_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'editpat_ssn
        '
        Me.editpat_ssn.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objpatients, "patient.pat_ssn"))
        Me.editpat_ssn.Location = New System.Drawing.Point(96, 120)
        Me.editpat_ssn.Name = "editpat_ssn"
        Me.editpat_ssn.Size = New System.Drawing.Size(128, 20)
        Me.editpat_ssn.TabIndex = 2
        Me.editpat_ssn.Text = ""
        Me.editpat_ssn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'editpat_state
        '
        Me.editpat_state.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objpatients, "patient.pat_state"))
        Me.editpat_state.Location = New System.Drawing.Point(296, 120)
        Me.editpat_state.Name = "editpat_state"
        Me.editpat_state.Size = New System.Drawing.Size(144, 20)
        Me.editpat_state.TabIndex = 6
        Me.editpat_state.Text = ""
        Me.editpat_state.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'editpat_zip
        '
        Me.editpat_zip.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objpatients, "patient.pat_zip"))
        Me.editpat_zip.Location = New System.Drawing.Point(296, 144)
        Me.editpat_zip.Name = "editpat_zip"
        Me.editpat_zip.Size = New System.Drawing.Size(144, 20)
        Me.editpat_zip.TabIndex = 7
        Me.editpat_zip.Text = ""
        Me.editpat_zip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnNavFirst
        '
        Me.btnNavFirst.Location = New System.Drawing.Point(195, 241)
        Me.btnNavFirst.Name = "btnNavFirst"
        Me.btnNavFirst.Size = New System.Drawing.Size(40, 23)
        Me.btnNavFirst.TabIndex = 23
        Me.btnNavFirst.TabStop = False
        Me.btnNavFirst.Text = "<<"
        '
        'btnNavPrev
        '
        Me.btnNavPrev.Location = New System.Drawing.Point(235, 241)
        Me.btnNavPrev.Name = "btnNavPrev"
        Me.btnNavPrev.Size = New System.Drawing.Size(35, 23)
        Me.btnNavPrev.TabIndex = 24
        Me.btnNavPrev.TabStop = False
        Me.btnNavPrev.Text = "<"
        '
        'lblNavLocation
        '
        Me.lblNavLocation.BackColor = System.Drawing.Color.White
        Me.lblNavLocation.Location = New System.Drawing.Point(270, 241)
        Me.lblNavLocation.Name = "lblNavLocation"
        Me.lblNavLocation.Size = New System.Drawing.Size(95, 23)
        Me.lblNavLocation.TabIndex = 25
        Me.lblNavLocation.Text = "No Records"
        Me.lblNavLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNavNext
        '
        Me.btnNavNext.Location = New System.Drawing.Point(365, 241)
        Me.btnNavNext.Name = "btnNavNext"
        Me.btnNavNext.Size = New System.Drawing.Size(35, 23)
        Me.btnNavNext.TabIndex = 26
        Me.btnNavNext.TabStop = False
        Me.btnNavNext.Text = ">"
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(400, 241)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(40, 23)
        Me.btnLast.TabIndex = 27
        Me.btnLast.TabStop = False
        Me.btnLast.Text = ">>"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(195, 274)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.TabIndex = 28
        Me.btnAdd.TabStop = False
        Me.btnAdd.Text = "&Add"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(280, 274)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.TabIndex = 29
        Me.btnDelete.TabStop = False
        Me.btnDelete.Text = "&Delete"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(365, 274)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 30
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "&Cancel"
        '
        'cmdGoBack
        '
        Me.cmdGoBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGoBack.Location = New System.Drawing.Point(8, 288)
        Me.cmdGoBack.Name = "cmdGoBack"
        Me.cmdGoBack.TabIndex = 31
        Me.cmdGoBack.Text = "GO BACK"
        '
        'PatientDataForm1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(442, 315)
        Me.Controls.Add(Me.cmdGoBack)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancelAll)
        Me.Controls.Add(Me.lblpat_address)
        Me.Controls.Add(Me.lblpat_city)
        Me.Controls.Add(Me.lblpat_dob)
        Me.Controls.Add(Me.lblpat_email)
        Me.Controls.Add(Me.lblpat_fname)
        Me.Controls.Add(Me.editpat_address)
        Me.Controls.Add(Me.editpat_city)
        Me.Controls.Add(Me.editpat_dob)
        Me.Controls.Add(Me.editpat_email)
        Me.Controls.Add(Me.editpat_fname)
        Me.Controls.Add(Me.lblpat_lname)
        Me.Controls.Add(Me.lblpat_phone)
        Me.Controls.Add(Me.lblpat_ssn)
        Me.Controls.Add(Me.lblpat_state)
        Me.Controls.Add(Me.lblpat_zip)
        Me.Controls.Add(Me.editpat_lname)
        Me.Controls.Add(Me.editpat_phone)
        Me.Controls.Add(Me.editpat_ssn)
        Me.Controls.Add(Me.editpat_state)
        Me.Controls.Add(Me.editpat_zip)
        Me.Controls.Add(Me.btnNavFirst)
        Me.Controls.Add(Me.btnNavPrev)
        Me.Controls.Add(Me.lblNavLocation)
        Me.Controls.Add(Me.btnNavNext)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "PatientDataForm1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Data Form"
        CType(Me.objpatients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.BindingContext(objpatients, "patient").CancelCurrentEdit()
        Me.objpatients_PositionChanged()

    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (Me.BindingContext(objpatients, "patient").Count > 0) Then
            Me.BindingContext(objpatients, "patient").RemoveAt(Me.BindingContext(objpatients, "patient").Position)
            Me.objpatients_PositionChanged()
        End If

    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            'Clear out the current edits
            Me.BindingContext(objpatients, "patient").EndCurrentEdit()
            Me.BindingContext(objpatients, "patient").AddNew()
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
        Me.objpatients_PositionChanged()

    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            'Attempt to update the datasource.
            Me.UpdateDataSet()
        Catch eUpdate As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eUpdate.Message)
        End Try
        Me.objpatients_PositionChanged()

    End Sub
    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        Try
            'Attempt to load the dataset.
            Me.LoadDataSet()
        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
        Me.objpatients_PositionChanged()

    End Sub
    Private Sub btnNavFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavFirst.Click
        Me.BindingContext(objpatients, "patient").Position = 0
        Me.objpatients_PositionChanged()

    End Sub
    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Me.BindingContext(objpatients, "patient").Position = (Me.objpatients.Tables("patient").Rows.Count - 1)
        Me.objpatients_PositionChanged()

    End Sub
    Private Sub btnNavPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavPrev.Click
        Me.BindingContext(objpatients, "patient").Position = (Me.BindingContext(objpatients, "patient").Position - 1)
        Me.objpatients_PositionChanged()

    End Sub
    Private Sub btnNavNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavNext.Click
        Me.BindingContext(objpatients, "patient").Position = (Me.BindingContext(objpatients, "patient").Position + 1)
        Me.objpatients_PositionChanged()

    End Sub
    Private Sub objpatients_PositionChanged()
        Me.lblNavLocation.Text = (((Me.BindingContext(objpatients, "patient").Position + 1).ToString + " of  ") _
                    + Me.BindingContext(objpatients, "patient").Count.ToString)

    End Sub
    Private Sub btnCancelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelAll.Click
        Me.objpatients.RejectChanges()

    End Sub
    Public Sub UpdateDataSet()
        'Create a new dataset to hold the changes that have been made to the main dataset.
        Dim objDataSetChanges As MIS475groupproj.patients = New MIS475groupproj.patients
        'Stop any current edits.
        Me.BindingContext(objpatients, "patient").EndCurrentEdit()
        'Get the changes that have been made to the main dataset.
        objDataSetChanges = CType(objpatients.GetChanges, MIS475groupproj.patients)
        'Check to see if any changes have been made.
        If (Not (objDataSetChanges) Is Nothing) Then
            Try
                'There are changes that need to be made, so attempt to update the datasource by
                'calling the update method and passing the dataset and any parameters.
                Me.UpdateDataSource(objDataSetChanges)
                objpatients.Merge(objDataSetChanges)
                objpatients.AcceptChanges()
            Catch eUpdate As System.Exception
                'Add your error handling code here.
                Throw eUpdate
            End Try
            'Add your code to check the returned dataset for any errors that may have been
            'pushed into the row object's error.
        End If

    End Sub
    Public Sub LoadDataSet()
        'Create a new dataset to hold the records returned from the call to FillDataSet.
        'A temporary dataset is used because filling the existing dataset would
        'require the databindings to be rebound.
        Dim objDataSetTemp As MIS475groupproj.patients
        objDataSetTemp = New MIS475groupproj.patients
        Try
            'Attempt to fill the temporary dataset.
            Me.FillDataSet(objDataSetTemp)
        Catch eFillDataSet As System.Exception
            'Add your error handling code here.
            Throw eFillDataSet
        End Try
        Try
            'Empty the old records from the dataset.
            objpatients.Clear()
            'Merge the records into the main dataset.
            objpatients.Merge(objDataSetTemp)
        Catch eLoadMerge As System.Exception
            'Add your error handling code here.
            Throw eLoadMerge
        End Try

    End Sub
    Public Sub UpdateDataSource(ByVal ChangedRows As MIS475groupproj.patients)
        Try
            'The data source only needs to be updated if there are changes pending.
            If (Not (ChangedRows) Is Nothing) Then
                'Open the connection.
                Me.OleDbConnection1.Open()
                'Attempt to update the data source.
                OleDbDataAdapter1.Update(ChangedRows)
            End If
        Catch updateException As System.Exception
            'Add your error handling code here.
            Throw updateException
        Finally
            'Close the connection whether or not the exception was thrown.
            Me.OleDbConnection1.Close()
        End Try

    End Sub
    Public Sub FillDataSet(ByVal dataSet As MIS475groupproj.patients)
        'Turn off constraint checking before the dataset is filled.
        'This allows the adapters to fill the dataset without concern
        'for dependencies between the tables.
        dataSet.EnforceConstraints = False
        Try
            'Open the connection.
            Me.OleDbConnection1.Open()
            'Attempt to fill the dataset through the OleDbDataAdapter1.
            Me.OleDbDataAdapter1.Fill(dataSet)
        Catch fillException As System.Exception
            'Add your error handling code here.
            Throw fillException
        Finally
            'Turn constraint checking back on.
            dataSet.EnforceConstraints = True
            'Close the connection whether or not the exception was thrown.
            Me.OleDbConnection1.Close()
        End Try

    End Sub

    Private Sub cmdGoBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGoBack.Click
        'Show Main Form
        Dim objStupidFormObject As New frmFrontEnd
        objStupidFormObject.Show()
        'Hide Patient Data Form
        Me.Hide()
    End Sub

    Private Sub lblpat_state_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblpat_state.Click

    End Sub

    Private Sub editpat_state_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editpat_state.TextChanged

    End Sub
End Class
