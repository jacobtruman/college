Public Class HospitalDataForm1
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
    Friend WithEvents objhospitals As MIS475groupproj.hospitals
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnCancelAll As System.Windows.Forms.Button
    Friend WithEvents lblhosp_address As System.Windows.Forms.Label
    Friend WithEvents lblhosp_city As System.Windows.Forms.Label
    Friend WithEvents lblhosp_email As System.Windows.Forms.Label
    Friend WithEvents lblhosp_fax As System.Windows.Forms.Label
    Friend WithEvents edithosp_address As System.Windows.Forms.TextBox
    Friend WithEvents edithosp_city As System.Windows.Forms.TextBox
    Friend WithEvents edithosp_email As System.Windows.Forms.TextBox
    Friend WithEvents edithosp_fax As System.Windows.Forms.TextBox
    Friend WithEvents lblhosp_name As System.Windows.Forms.Label
    Friend WithEvents lblhosp_phone As System.Windows.Forms.Label
    Friend WithEvents lblhosp_state As System.Windows.Forms.Label
    Friend WithEvents lblhosp_zip As System.Windows.Forms.Label
    Friend WithEvents edithosp_name As System.Windows.Forms.TextBox
    Friend WithEvents edithosp_phone As System.Windows.Forms.TextBox
    Friend WithEvents edithosp_state As System.Windows.Forms.TextBox
    Friend WithEvents edithosp_zip As System.Windows.Forms.TextBox
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(HospitalDataForm1))
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.objhospitals = New MIS475groupproj.hospitals
        Me.btnLoad = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnCancelAll = New System.Windows.Forms.Button
        Me.lblhosp_address = New System.Windows.Forms.Label
        Me.lblhosp_city = New System.Windows.Forms.Label
        Me.lblhosp_email = New System.Windows.Forms.Label
        Me.lblhosp_fax = New System.Windows.Forms.Label
        Me.edithosp_address = New System.Windows.Forms.TextBox
        Me.edithosp_city = New System.Windows.Forms.TextBox
        Me.edithosp_email = New System.Windows.Forms.TextBox
        Me.edithosp_fax = New System.Windows.Forms.TextBox
        Me.lblhosp_name = New System.Windows.Forms.Label
        Me.lblhosp_phone = New System.Windows.Forms.Label
        Me.lblhosp_state = New System.Windows.Forms.Label
        Me.lblhosp_zip = New System.Windows.Forms.Label
        Me.edithosp_name = New System.Windows.Forms.TextBox
        Me.edithosp_phone = New System.Windows.Forms.TextBox
        Me.edithosp_state = New System.Windows.Forms.TextBox
        Me.edithosp_zip = New System.Windows.Forms.TextBox
        Me.btnNavFirst = New System.Windows.Forms.Button
        Me.btnNavPrev = New System.Windows.Forms.Button
        Me.lblNavLocation = New System.Windows.Forms.Label
        Me.btnNavNext = New System.Windows.Forms.Button
        Me.btnLast = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.cmdGoBack = New System.Windows.Forms.Button
        CType(Me.objhospitals, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT hosp_address, hosp_city, hosp_email, hosp_fax, hosp_name, hosp_phone, hosp" & _
        "_state, hosp_zip FROM hospital"
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
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO hospital(hosp_address, hosp_city, hosp_email, hosp_fax, hosp_name, ho" & _
        "sp_phone, hosp_state, hosp_zip) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("hosp_address", System.Data.OleDb.OleDbType.VarWChar, 120, "hosp_address"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("hosp_city", System.Data.OleDb.OleDbType.VarWChar, 50, "hosp_city"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("hosp_email", System.Data.OleDb.OleDbType.VarWChar, 50, "hosp_email"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("hosp_fax", System.Data.OleDb.OleDbType.VarWChar, 50, "hosp_fax"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("hosp_name", System.Data.OleDb.OleDbType.VarWChar, 60, "hosp_name"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("hosp_phone", System.Data.OleDb.OleDbType.VarWChar, 50, "hosp_phone"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("hosp_state", System.Data.OleDb.OleDbType.VarWChar, 50, "hosp_state"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("hosp_zip", System.Data.OleDb.OleDbType.Integer, 0, "hosp_zip"))
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE hospital SET hosp_address = ?, hosp_city = ?, hosp_email = ?, hosp_fax = ?" & _
        ", hosp_name = ?, hosp_phone = ?, hosp_state = ?, hosp_zip = ? WHERE (hosp_name =" & _
        " ?) AND (hosp_address = ? OR ? IS NULL AND hosp_address IS NULL) AND (hosp_city " & _
        "= ? OR ? IS NULL AND hosp_city IS NULL) AND (hosp_email = ? OR ? IS NULL AND hos" & _
        "p_email IS NULL) AND (hosp_fax = ? OR ? IS NULL AND hosp_fax IS NULL) AND (hosp_" & _
        "phone = ?) AND (hosp_state = ? OR ? IS NULL AND hosp_state IS NULL) AND (hosp_zi" & _
        "p = ? OR ? IS NULL AND hosp_zip IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("hosp_address", System.Data.OleDb.OleDbType.VarWChar, 120, "hosp_address"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("hosp_city", System.Data.OleDb.OleDbType.VarWChar, 50, "hosp_city"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("hosp_email", System.Data.OleDb.OleDbType.VarWChar, 50, "hosp_email"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("hosp_fax", System.Data.OleDb.OleDbType.VarWChar, 50, "hosp_fax"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("hosp_name", System.Data.OleDb.OleDbType.VarWChar, 60, "hosp_name"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("hosp_phone", System.Data.OleDb.OleDbType.VarWChar, 50, "hosp_phone"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("hosp_state", System.Data.OleDb.OleDbType.VarWChar, 50, "hosp_state"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("hosp_zip", System.Data.OleDb.OleDbType.Integer, 0, "hosp_zip"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_hosp_name", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hosp_name", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_hosp_address", System.Data.OleDb.OleDbType.VarWChar, 120, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hosp_address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_hosp_address1", System.Data.OleDb.OleDbType.VarWChar, 120, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hosp_address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_hosp_city", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hosp_city", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_hosp_city1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hosp_city", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_hosp_email", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hosp_email", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_hosp_email1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hosp_email", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_hosp_fax", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hosp_fax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_hosp_fax1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hosp_fax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_hosp_phone", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hosp_phone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_hosp_state", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hosp_state", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_hosp_state1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hosp_state", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_hosp_zip", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hosp_zip", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_hosp_zip1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hosp_zip", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM hospital WHERE (hosp_name = ?) AND (hosp_address = ? OR ? IS NULL AND" & _
        " hosp_address IS NULL) AND (hosp_city = ? OR ? IS NULL AND hosp_city IS NULL) AN" & _
        "D (hosp_email = ? OR ? IS NULL AND hosp_email IS NULL) AND (hosp_fax = ? OR ? IS" & _
        " NULL AND hosp_fax IS NULL) AND (hosp_phone = ?) AND (hosp_state = ? OR ? IS NUL" & _
        "L AND hosp_state IS NULL) AND (hosp_zip = ? OR ? IS NULL AND hosp_zip IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_hosp_name", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hosp_name", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_hosp_address", System.Data.OleDb.OleDbType.VarWChar, 120, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hosp_address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_hosp_address1", System.Data.OleDb.OleDbType.VarWChar, 120, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hosp_address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_hosp_city", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hosp_city", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_hosp_city1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hosp_city", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_hosp_email", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hosp_email", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_hosp_email1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hosp_email", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_hosp_fax", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hosp_fax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_hosp_fax1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hosp_fax", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_hosp_phone", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hosp_phone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_hosp_state", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hosp_state", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_hosp_state1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hosp_state", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_hosp_zip", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hosp_zip", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_hosp_zip1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hosp_zip", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "hospital", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("hosp_address", "hosp_address"), New System.Data.Common.DataColumnMapping("hosp_city", "hosp_city"), New System.Data.Common.DataColumnMapping("hosp_email", "hosp_email"), New System.Data.Common.DataColumnMapping("hosp_fax", "hosp_fax"), New System.Data.Common.DataColumnMapping("hosp_name", "hosp_name"), New System.Data.Common.DataColumnMapping("hosp_phone", "hosp_phone"), New System.Data.Common.DataColumnMapping("hosp_state", "hosp_state"), New System.Data.Common.DataColumnMapping("hosp_zip", "hosp_zip")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'objhospitals
        '
        Me.objhospitals.DataSetName = "hospitals"
        Me.objhospitals.Locale = New System.Globalization.CultureInfo("en-US")
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
        'lblhosp_address
        '
        Me.lblhosp_address.Location = New System.Drawing.Point(224, 72)
        Me.lblhosp_address.Name = "lblhosp_address"
        Me.lblhosp_address.Size = New System.Drawing.Size(48, 23)
        Me.lblhosp_address.TabIndex = 3
        Me.lblhosp_address.Text = "Address"
        Me.lblhosp_address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblhosp_city
        '
        Me.lblhosp_city.Location = New System.Drawing.Point(232, 96)
        Me.lblhosp_city.Name = "lblhosp_city"
        Me.lblhosp_city.Size = New System.Drawing.Size(40, 23)
        Me.lblhosp_city.TabIndex = 4
        Me.lblhosp_city.Text = "City"
        Me.lblhosp_city.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblhosp_email
        '
        Me.lblhosp_email.Location = New System.Drawing.Point(8, 144)
        Me.lblhosp_email.Name = "lblhosp_email"
        Me.lblhosp_email.Size = New System.Drawing.Size(48, 23)
        Me.lblhosp_email.TabIndex = 5
        Me.lblhosp_email.Text = "E-Mail"
        Me.lblhosp_email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblhosp_fax
        '
        Me.lblhosp_fax.Location = New System.Drawing.Point(8, 120)
        Me.lblhosp_fax.Name = "lblhosp_fax"
        Me.lblhosp_fax.Size = New System.Drawing.Size(48, 23)
        Me.lblhosp_fax.TabIndex = 6
        Me.lblhosp_fax.Text = "Fax #"
        Me.lblhosp_fax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'edithosp_address
        '
        Me.edithosp_address.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objhospitals, "hospital.hosp_address"))
        Me.edithosp_address.Location = New System.Drawing.Point(280, 72)
        Me.edithosp_address.Name = "edithosp_address"
        Me.edithosp_address.Size = New System.Drawing.Size(160, 20)
        Me.edithosp_address.TabIndex = 4
        Me.edithosp_address.Text = ""
        Me.edithosp_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'edithosp_city
        '
        Me.edithosp_city.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objhospitals, "hospital.hosp_city"))
        Me.edithosp_city.Location = New System.Drawing.Point(280, 96)
        Me.edithosp_city.Name = "edithosp_city"
        Me.edithosp_city.Size = New System.Drawing.Size(160, 20)
        Me.edithosp_city.TabIndex = 5
        Me.edithosp_city.Text = ""
        Me.edithosp_city.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'edithosp_email
        '
        Me.edithosp_email.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objhospitals, "hospital.hosp_email"))
        Me.edithosp_email.Location = New System.Drawing.Point(64, 144)
        Me.edithosp_email.Name = "edithosp_email"
        Me.edithosp_email.Size = New System.Drawing.Size(144, 20)
        Me.edithosp_email.TabIndex = 3
        Me.edithosp_email.Text = ""
        Me.edithosp_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'edithosp_fax
        '
        Me.edithosp_fax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objhospitals, "hospital.hosp_fax"))
        Me.edithosp_fax.Location = New System.Drawing.Point(64, 120)
        Me.edithosp_fax.Name = "edithosp_fax"
        Me.edithosp_fax.Size = New System.Drawing.Size(144, 20)
        Me.edithosp_fax.TabIndex = 2
        Me.edithosp_fax.Text = ""
        Me.edithosp_fax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblhosp_name
        '
        Me.lblhosp_name.Location = New System.Drawing.Point(0, 72)
        Me.lblhosp_name.Name = "lblhosp_name"
        Me.lblhosp_name.Size = New System.Drawing.Size(48, 23)
        Me.lblhosp_name.TabIndex = 11
        Me.lblhosp_name.Text = "Name"
        Me.lblhosp_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblhosp_phone
        '
        Me.lblhosp_phone.Location = New System.Drawing.Point(8, 96)
        Me.lblhosp_phone.Name = "lblhosp_phone"
        Me.lblhosp_phone.Size = New System.Drawing.Size(48, 23)
        Me.lblhosp_phone.TabIndex = 12
        Me.lblhosp_phone.Text = "Phone #"
        Me.lblhosp_phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblhosp_state
        '
        Me.lblhosp_state.Location = New System.Drawing.Point(232, 120)
        Me.lblhosp_state.Name = "lblhosp_state"
        Me.lblhosp_state.Size = New System.Drawing.Size(34, 23)
        Me.lblhosp_state.TabIndex = 13
        Me.lblhosp_state.Text = "State"
        Me.lblhosp_state.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblhosp_zip
        '
        Me.lblhosp_zip.Location = New System.Drawing.Point(216, 144)
        Me.lblhosp_zip.Name = "lblhosp_zip"
        Me.lblhosp_zip.Size = New System.Drawing.Size(58, 23)
        Me.lblhosp_zip.TabIndex = 14
        Me.lblhosp_zip.Text = "ZIP Code"
        Me.lblhosp_zip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'edithosp_name
        '
        Me.edithosp_name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objhospitals, "hospital.hosp_name"))
        Me.edithosp_name.Location = New System.Drawing.Point(64, 72)
        Me.edithosp_name.Name = "edithosp_name"
        Me.edithosp_name.Size = New System.Drawing.Size(144, 20)
        Me.edithosp_name.TabIndex = 0
        Me.edithosp_name.Text = ""
        Me.edithosp_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'edithosp_phone
        '
        Me.edithosp_phone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objhospitals, "hospital.hosp_phone"))
        Me.edithosp_phone.Location = New System.Drawing.Point(64, 96)
        Me.edithosp_phone.Name = "edithosp_phone"
        Me.edithosp_phone.Size = New System.Drawing.Size(144, 20)
        Me.edithosp_phone.TabIndex = 1
        Me.edithosp_phone.Text = ""
        Me.edithosp_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'edithosp_state
        '
        Me.edithosp_state.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objhospitals, "hospital.hosp_state"))
        Me.edithosp_state.Location = New System.Drawing.Point(280, 120)
        Me.edithosp_state.Name = "edithosp_state"
        Me.edithosp_state.Size = New System.Drawing.Size(160, 20)
        Me.edithosp_state.TabIndex = 6
        Me.edithosp_state.Text = ""
        Me.edithosp_state.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'edithosp_zip
        '
        Me.edithosp_zip.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objhospitals, "hospital.hosp_zip"))
        Me.edithosp_zip.Location = New System.Drawing.Point(280, 144)
        Me.edithosp_zip.Name = "edithosp_zip"
        Me.edithosp_zip.Size = New System.Drawing.Size(160, 20)
        Me.edithosp_zip.TabIndex = 7
        Me.edithosp_zip.Text = ""
        Me.edithosp_zip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnNavFirst
        '
        Me.btnNavFirst.Location = New System.Drawing.Point(195, 208)
        Me.btnNavFirst.Name = "btnNavFirst"
        Me.btnNavFirst.Size = New System.Drawing.Size(40, 23)
        Me.btnNavFirst.TabIndex = 19
        Me.btnNavFirst.TabStop = False
        Me.btnNavFirst.Text = "<<"
        '
        'btnNavPrev
        '
        Me.btnNavPrev.Location = New System.Drawing.Point(235, 208)
        Me.btnNavPrev.Name = "btnNavPrev"
        Me.btnNavPrev.Size = New System.Drawing.Size(35, 23)
        Me.btnNavPrev.TabIndex = 20
        Me.btnNavPrev.TabStop = False
        Me.btnNavPrev.Text = "<"
        '
        'lblNavLocation
        '
        Me.lblNavLocation.BackColor = System.Drawing.Color.White
        Me.lblNavLocation.Location = New System.Drawing.Point(270, 208)
        Me.lblNavLocation.Name = "lblNavLocation"
        Me.lblNavLocation.Size = New System.Drawing.Size(95, 23)
        Me.lblNavLocation.TabIndex = 21
        Me.lblNavLocation.Text = "No Records"
        Me.lblNavLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNavNext
        '
        Me.btnNavNext.Location = New System.Drawing.Point(365, 208)
        Me.btnNavNext.Name = "btnNavNext"
        Me.btnNavNext.Size = New System.Drawing.Size(35, 23)
        Me.btnNavNext.TabIndex = 22
        Me.btnNavNext.TabStop = False
        Me.btnNavNext.Text = ">"
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(400, 208)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(40, 23)
        Me.btnLast.TabIndex = 23
        Me.btnLast.TabStop = False
        Me.btnLast.Text = ">>"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(195, 241)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.TabIndex = 24
        Me.btnAdd.TabStop = False
        Me.btnAdd.Text = "&Add"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(280, 241)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.TabIndex = 25
        Me.btnDelete.TabStop = False
        Me.btnDelete.Text = "&Delete"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(365, 241)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 26
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "&Cancel"
        '
        'cmdGoBack
        '
        Me.cmdGoBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGoBack.Location = New System.Drawing.Point(8, 256)
        Me.cmdGoBack.Name = "cmdGoBack"
        Me.cmdGoBack.TabIndex = 34
        Me.cmdGoBack.Text = "GO BACK"
        '
        'HospitalDataForm1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(442, 282)
        Me.Controls.Add(Me.cmdGoBack)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancelAll)
        Me.Controls.Add(Me.lblhosp_address)
        Me.Controls.Add(Me.lblhosp_city)
        Me.Controls.Add(Me.lblhosp_email)
        Me.Controls.Add(Me.lblhosp_fax)
        Me.Controls.Add(Me.edithosp_address)
        Me.Controls.Add(Me.edithosp_city)
        Me.Controls.Add(Me.edithosp_email)
        Me.Controls.Add(Me.edithosp_fax)
        Me.Controls.Add(Me.lblhosp_name)
        Me.Controls.Add(Me.lblhosp_phone)
        Me.Controls.Add(Me.lblhosp_state)
        Me.Controls.Add(Me.lblhosp_zip)
        Me.Controls.Add(Me.edithosp_name)
        Me.Controls.Add(Me.edithosp_phone)
        Me.Controls.Add(Me.edithosp_state)
        Me.Controls.Add(Me.edithosp_zip)
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
        Me.Name = "HospitalDataForm1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hospital Data Form"
        CType(Me.objhospitals, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.BindingContext(objhospitals, "hospital").CancelCurrentEdit()
        Me.objhospitals_PositionChanged()

    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (Me.BindingContext(objhospitals, "hospital").Count > 0) Then
            Me.BindingContext(objhospitals, "hospital").RemoveAt(Me.BindingContext(objhospitals, "hospital").Position)
            Me.objhospitals_PositionChanged()
        End If

    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            'Clear out the current edits
            Me.BindingContext(objhospitals, "hospital").EndCurrentEdit()
            Me.BindingContext(objhospitals, "hospital").AddNew()
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
        Me.objhospitals_PositionChanged()

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
        Me.objhospitals_PositionChanged()

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
        Me.objhospitals_PositionChanged()

    End Sub
    Private Sub btnNavFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavFirst.Click
        Me.BindingContext(objhospitals, "hospital").Position = 0
        Me.objhospitals_PositionChanged()

    End Sub
    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Me.BindingContext(objhospitals, "hospital").Position = (Me.objhospitals.Tables("hospital").Rows.Count - 1)
        Me.objhospitals_PositionChanged()

    End Sub
    Private Sub btnNavPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavPrev.Click
        Me.BindingContext(objhospitals, "hospital").Position = (Me.BindingContext(objhospitals, "hospital").Position - 1)
        Me.objhospitals_PositionChanged()

    End Sub
    Private Sub btnNavNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavNext.Click
        Me.BindingContext(objhospitals, "hospital").Position = (Me.BindingContext(objhospitals, "hospital").Position + 1)
        Me.objhospitals_PositionChanged()

    End Sub
    Private Sub objhospitals_PositionChanged()
        Me.lblNavLocation.Text = (((Me.BindingContext(objhospitals, "hospital").Position + 1).ToString + " of  ") _
                    + Me.BindingContext(objhospitals, "hospital").Count.ToString)

    End Sub
    Private Sub btnCancelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelAll.Click
        Me.objhospitals.RejectChanges()

    End Sub
    Public Sub UpdateDataSet()
        'Create a new dataset to hold the changes that have been made to the main dataset.
        Dim objDataSetChanges As MIS475groupproj.hospitals = New MIS475groupproj.hospitals
        'Stop any current edits.
        Me.BindingContext(objhospitals, "hospital").EndCurrentEdit()
        'Get the changes that have been made to the main dataset.
        objDataSetChanges = CType(objhospitals.GetChanges, MIS475groupproj.hospitals)
        'Check to see if any changes have been made.
        If (Not (objDataSetChanges) Is Nothing) Then
            Try
                'There are changes that need to be made, so attempt to update the datasource by
                'calling the update method and passing the dataset and any parameters.
                Me.UpdateDataSource(objDataSetChanges)
                objhospitals.Merge(objDataSetChanges)
                objhospitals.AcceptChanges()
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
        Dim objDataSetTemp As MIS475groupproj.hospitals
        objDataSetTemp = New MIS475groupproj.hospitals
        Try
            'Attempt to fill the temporary dataset.
            Me.FillDataSet(objDataSetTemp)
        Catch eFillDataSet As System.Exception
            'Add your error handling code here.
            Throw eFillDataSet
        End Try
        Try
            'Empty the old records from the dataset.
            objhospitals.Clear()
            'Merge the records into the main dataset.
            objhospitals.Merge(objDataSetTemp)
        Catch eLoadMerge As System.Exception
            'Add your error handling code here.
            Throw eLoadMerge
        End Try

    End Sub
    Public Sub UpdateDataSource(ByVal ChangedRows As MIS475groupproj.hospitals)
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
    Public Sub FillDataSet(ByVal dataSet As MIS475groupproj.hospitals)
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
        'Hide Hospital Data Form
        Me.Hide()
    End Sub
End Class
