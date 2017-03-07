Public Class DoctorDataForm1
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
    Friend WithEvents objdoctors As MIS475groupproj.doctors
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnCancelAll As System.Windows.Forms.Button
    Friend WithEvents lbldoc_address As System.Windows.Forms.Label
    Friend WithEvents lbldoc_city As System.Windows.Forms.Label
    Friend WithEvents lbldoc_email As System.Windows.Forms.Label
    Friend WithEvents lbldoc_fname As System.Windows.Forms.Label
    Friend WithEvents lbldoc_id As System.Windows.Forms.Label
    Friend WithEvents lbldoc_lname As System.Windows.Forms.Label
    Friend WithEvents editdoc_address As System.Windows.Forms.TextBox
    Friend WithEvents editdoc_city As System.Windows.Forms.TextBox
    Friend WithEvents editdoc_email As System.Windows.Forms.TextBox
    Friend WithEvents editdoc_fname As System.Windows.Forms.TextBox
    Friend WithEvents editdoc_id As System.Windows.Forms.TextBox
    Friend WithEvents editdoc_lname As System.Windows.Forms.TextBox
    Friend WithEvents lbldoc_mobile As System.Windows.Forms.Label
    Friend WithEvents lbldoc_phone As System.Windows.Forms.Label
    Friend WithEvents lbldoc_position As System.Windows.Forms.Label
    Friend WithEvents lbldoc_state As System.Windows.Forms.Label
    Friend WithEvents lbldoc_zip As System.Windows.Forms.Label
    Friend WithEvents editdoc_mobile As System.Windows.Forms.TextBox
    Friend WithEvents editdoc_phone As System.Windows.Forms.TextBox
    Friend WithEvents editdoc_position As System.Windows.Forms.TextBox
    Friend WithEvents editdoc_state As System.Windows.Forms.TextBox
    Friend WithEvents editdoc_zip As System.Windows.Forms.TextBox
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(DoctorDataForm1))
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.objdoctors = New MIS475groupproj.doctors
        Me.btnLoad = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnCancelAll = New System.Windows.Forms.Button
        Me.lbldoc_address = New System.Windows.Forms.Label
        Me.lbldoc_city = New System.Windows.Forms.Label
        Me.lbldoc_email = New System.Windows.Forms.Label
        Me.lbldoc_fname = New System.Windows.Forms.Label
        Me.lbldoc_id = New System.Windows.Forms.Label
        Me.lbldoc_lname = New System.Windows.Forms.Label
        Me.editdoc_address = New System.Windows.Forms.TextBox
        Me.editdoc_city = New System.Windows.Forms.TextBox
        Me.editdoc_email = New System.Windows.Forms.TextBox
        Me.editdoc_fname = New System.Windows.Forms.TextBox
        Me.editdoc_id = New System.Windows.Forms.TextBox
        Me.editdoc_lname = New System.Windows.Forms.TextBox
        Me.lbldoc_mobile = New System.Windows.Forms.Label
        Me.lbldoc_phone = New System.Windows.Forms.Label
        Me.lbldoc_position = New System.Windows.Forms.Label
        Me.lbldoc_state = New System.Windows.Forms.Label
        Me.lbldoc_zip = New System.Windows.Forms.Label
        Me.editdoc_mobile = New System.Windows.Forms.TextBox
        Me.editdoc_phone = New System.Windows.Forms.TextBox
        Me.editdoc_position = New System.Windows.Forms.TextBox
        Me.editdoc_state = New System.Windows.Forms.TextBox
        Me.editdoc_zip = New System.Windows.Forms.TextBox
        Me.btnNavFirst = New System.Windows.Forms.Button
        Me.btnNavPrev = New System.Windows.Forms.Button
        Me.lblNavLocation = New System.Windows.Forms.Label
        Me.btnNavNext = New System.Windows.Forms.Button
        Me.btnLast = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.cmdGoBack = New System.Windows.Forms.Button
        CType(Me.objdoctors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT doc_address, doc_city, doc_email, doc_fname, doc_id, doc_lname, doc_mobile" & _
        ", doc_phone, doc_position, doc_state, doc_zip FROM doctor"
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
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO doctor(doc_address, doc_city, doc_email, doc_fname, doc_id, doc_lname" & _
        ", doc_mobile, doc_phone, doc_position, doc_state, doc_zip) VALUES (?, ?, ?, ?, ?" & _
        ", ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("doc_address", System.Data.OleDb.OleDbType.VarWChar, 50, "doc_address"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("doc_city", System.Data.OleDb.OleDbType.VarWChar, 50, "doc_city"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("doc_email", System.Data.OleDb.OleDbType.VarWChar, 50, "doc_email"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("doc_fname", System.Data.OleDb.OleDbType.VarWChar, 50, "doc_fname"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("doc_id", System.Data.OleDb.OleDbType.Integer, 0, "doc_id"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("doc_lname", System.Data.OleDb.OleDbType.VarWChar, 50, "doc_lname"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("doc_mobile", System.Data.OleDb.OleDbType.VarWChar, 50, "doc_mobile"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("doc_phone", System.Data.OleDb.OleDbType.VarWChar, 50, "doc_phone"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("doc_position", System.Data.OleDb.OleDbType.VarWChar, 50, "doc_position"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("doc_state", System.Data.OleDb.OleDbType.VarWChar, 50, "doc_state"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("doc_zip", System.Data.OleDb.OleDbType.Integer, 0, "doc_zip"))
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE doctor SET doc_address = ?, doc_city = ?, doc_email = ?, doc_fname = ?, do" & _
        "c_id = ?, doc_lname = ?, doc_mobile = ?, doc_phone = ?, doc_position = ?, doc_st" & _
        "ate = ?, doc_zip = ? WHERE (doc_id = ?) AND (doc_address = ?) AND (doc_city = ?)" & _
        " AND (doc_email = ? OR ? IS NULL AND doc_email IS NULL) AND (doc_fname = ?) AND " & _
        "(doc_lname = ?) AND (doc_mobile = ?) AND (doc_phone = ?) AND (doc_position = ? O" & _
        "R ? IS NULL AND doc_position IS NULL) AND (doc_state = ?) AND (doc_zip = ?)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("doc_address", System.Data.OleDb.OleDbType.VarWChar, 50, "doc_address"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("doc_city", System.Data.OleDb.OleDbType.VarWChar, 50, "doc_city"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("doc_email", System.Data.OleDb.OleDbType.VarWChar, 50, "doc_email"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("doc_fname", System.Data.OleDb.OleDbType.VarWChar, 50, "doc_fname"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("doc_id", System.Data.OleDb.OleDbType.Integer, 0, "doc_id"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("doc_lname", System.Data.OleDb.OleDbType.VarWChar, 50, "doc_lname"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("doc_mobile", System.Data.OleDb.OleDbType.VarWChar, 50, "doc_mobile"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("doc_phone", System.Data.OleDb.OleDbType.VarWChar, 50, "doc_phone"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("doc_position", System.Data.OleDb.OleDbType.VarWChar, 50, "doc_position"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("doc_state", System.Data.OleDb.OleDbType.VarWChar, 50, "doc_state"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("doc_zip", System.Data.OleDb.OleDbType.Integer, 0, "doc_zip"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_doc_id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "doc_id", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_doc_address", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "doc_address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_doc_city", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "doc_city", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_doc_email", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "doc_email", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_doc_email1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "doc_email", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_doc_fname", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "doc_fname", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_doc_lname", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "doc_lname", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_doc_mobile", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "doc_mobile", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_doc_phone", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "doc_phone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_doc_position", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "doc_position", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_doc_position1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "doc_position", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_doc_state", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "doc_state", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_doc_zip", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "doc_zip", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM doctor WHERE (doc_id = ?) AND (doc_address = ?) AND (doc_city = ?) AN" & _
        "D (doc_email = ? OR ? IS NULL AND doc_email IS NULL) AND (doc_fname = ?) AND (do" & _
        "c_lname = ?) AND (doc_mobile = ?) AND (doc_phone = ?) AND (doc_position = ? OR ?" & _
        " IS NULL AND doc_position IS NULL) AND (doc_state = ?) AND (doc_zip = ?)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_doc_id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "doc_id", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_doc_address", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "doc_address", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_doc_city", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "doc_city", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_doc_email", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "doc_email", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_doc_email1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "doc_email", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_doc_fname", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "doc_fname", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_doc_lname", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "doc_lname", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_doc_mobile", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "doc_mobile", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_doc_phone", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "doc_phone", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_doc_position", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "doc_position", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_doc_position1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "doc_position", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_doc_state", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "doc_state", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_doc_zip", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "doc_zip", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "doctor", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("doc_address", "doc_address"), New System.Data.Common.DataColumnMapping("doc_city", "doc_city"), New System.Data.Common.DataColumnMapping("doc_email", "doc_email"), New System.Data.Common.DataColumnMapping("doc_fname", "doc_fname"), New System.Data.Common.DataColumnMapping("doc_id", "doc_id"), New System.Data.Common.DataColumnMapping("doc_lname", "doc_lname"), New System.Data.Common.DataColumnMapping("doc_mobile", "doc_mobile"), New System.Data.Common.DataColumnMapping("doc_phone", "doc_phone"), New System.Data.Common.DataColumnMapping("doc_position", "doc_position"), New System.Data.Common.DataColumnMapping("doc_state", "doc_state"), New System.Data.Common.DataColumnMapping("doc_zip", "doc_zip")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'objdoctors
        '
        Me.objdoctors.DataSetName = "doctors"
        Me.objdoctors.Locale = New System.Globalization.CultureInfo("en-US")
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
        'lbldoc_address
        '
        Me.lbldoc_address.Location = New System.Drawing.Point(240, 72)
        Me.lbldoc_address.Name = "lbldoc_address"
        Me.lbldoc_address.Size = New System.Drawing.Size(48, 23)
        Me.lbldoc_address.TabIndex = 3
        Me.lbldoc_address.Text = "Address"
        Me.lbldoc_address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbldoc_city
        '
        Me.lbldoc_city.Location = New System.Drawing.Point(248, 96)
        Me.lbldoc_city.Name = "lbldoc_city"
        Me.lbldoc_city.Size = New System.Drawing.Size(32, 23)
        Me.lbldoc_city.TabIndex = 4
        Me.lbldoc_city.Text = "City"
        Me.lbldoc_city.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbldoc_email
        '
        Me.lbldoc_email.Location = New System.Drawing.Point(64, 232)
        Me.lbldoc_email.Name = "lbldoc_email"
        Me.lbldoc_email.TabIndex = 5
        Me.lbldoc_email.Text = "E-Mail"
        Me.lbldoc_email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbldoc_fname
        '
        Me.lbldoc_fname.Location = New System.Drawing.Point(8, 72)
        Me.lbldoc_fname.Name = "lbldoc_fname"
        Me.lbldoc_fname.Size = New System.Drawing.Size(64, 23)
        Me.lbldoc_fname.TabIndex = 6
        Me.lbldoc_fname.Text = "First Name"
        Me.lbldoc_fname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbldoc_id
        '
        Me.lbldoc_id.Location = New System.Drawing.Point(24, 120)
        Me.lbldoc_id.Name = "lbldoc_id"
        Me.lbldoc_id.Size = New System.Drawing.Size(40, 23)
        Me.lbldoc_id.TabIndex = 7
        Me.lbldoc_id.Text = "ID#"
        Me.lbldoc_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbldoc_lname
        '
        Me.lbldoc_lname.Location = New System.Drawing.Point(8, 96)
        Me.lbldoc_lname.Name = "lbldoc_lname"
        Me.lbldoc_lname.Size = New System.Drawing.Size(64, 23)
        Me.lbldoc_lname.TabIndex = 8
        Me.lbldoc_lname.Text = "Last Name"
        Me.lbldoc_lname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'editdoc_address
        '
        Me.editdoc_address.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdoctors, "doctor.doc_address"))
        Me.editdoc_address.Location = New System.Drawing.Point(296, 72)
        Me.editdoc_address.Name = "editdoc_address"
        Me.editdoc_address.Size = New System.Drawing.Size(144, 20)
        Me.editdoc_address.TabIndex = 4
        Me.editdoc_address.Text = ""
        Me.editdoc_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'editdoc_city
        '
        Me.editdoc_city.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdoctors, "doctor.doc_city"))
        Me.editdoc_city.Location = New System.Drawing.Point(296, 96)
        Me.editdoc_city.Name = "editdoc_city"
        Me.editdoc_city.Size = New System.Drawing.Size(144, 20)
        Me.editdoc_city.TabIndex = 5
        Me.editdoc_city.Text = ""
        Me.editdoc_city.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'editdoc_email
        '
        Me.editdoc_email.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdoctors, "doctor.doc_email"))
        Me.editdoc_email.Location = New System.Drawing.Point(168, 232)
        Me.editdoc_email.Name = "editdoc_email"
        Me.editdoc_email.Size = New System.Drawing.Size(272, 20)
        Me.editdoc_email.TabIndex = 10
        Me.editdoc_email.Text = ""
        Me.editdoc_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'editdoc_fname
        '
        Me.editdoc_fname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdoctors, "doctor.doc_fname"))
        Me.editdoc_fname.Location = New System.Drawing.Point(72, 72)
        Me.editdoc_fname.Name = "editdoc_fname"
        Me.editdoc_fname.Size = New System.Drawing.Size(144, 20)
        Me.editdoc_fname.TabIndex = 0
        Me.editdoc_fname.Text = ""
        Me.editdoc_fname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'editdoc_id
        '
        Me.editdoc_id.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdoctors, "doctor.doc_id"))
        Me.editdoc_id.Location = New System.Drawing.Point(72, 120)
        Me.editdoc_id.Name = "editdoc_id"
        Me.editdoc_id.Size = New System.Drawing.Size(144, 20)
        Me.editdoc_id.TabIndex = 2
        Me.editdoc_id.Text = ""
        Me.editdoc_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'editdoc_lname
        '
        Me.editdoc_lname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdoctors, "doctor.doc_lname"))
        Me.editdoc_lname.Location = New System.Drawing.Point(72, 96)
        Me.editdoc_lname.Name = "editdoc_lname"
        Me.editdoc_lname.Size = New System.Drawing.Size(144, 20)
        Me.editdoc_lname.TabIndex = 1
        Me.editdoc_lname.Text = ""
        Me.editdoc_lname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbldoc_mobile
        '
        Me.lbldoc_mobile.Location = New System.Drawing.Point(64, 184)
        Me.lbldoc_mobile.Name = "lbldoc_mobile"
        Me.lbldoc_mobile.TabIndex = 15
        Me.lbldoc_mobile.Text = "Cell #"
        Me.lbldoc_mobile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbldoc_phone
        '
        Me.lbldoc_phone.Location = New System.Drawing.Point(64, 208)
        Me.lbldoc_phone.Name = "lbldoc_phone"
        Me.lbldoc_phone.TabIndex = 16
        Me.lbldoc_phone.Text = "Phone #"
        Me.lbldoc_phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbldoc_position
        '
        Me.lbldoc_position.Location = New System.Drawing.Point(16, 144)
        Me.lbldoc_position.Name = "lbldoc_position"
        Me.lbldoc_position.Size = New System.Drawing.Size(48, 23)
        Me.lbldoc_position.TabIndex = 17
        Me.lbldoc_position.Text = "Position"
        Me.lbldoc_position.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbldoc_state
        '
        Me.lbldoc_state.Location = New System.Drawing.Point(240, 120)
        Me.lbldoc_state.Name = "lbldoc_state"
        Me.lbldoc_state.Size = New System.Drawing.Size(48, 23)
        Me.lbldoc_state.TabIndex = 18
        Me.lbldoc_state.Text = "State"
        Me.lbldoc_state.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbldoc_zip
        '
        Me.lbldoc_zip.Location = New System.Drawing.Point(232, 144)
        Me.lbldoc_zip.Name = "lbldoc_zip"
        Me.lbldoc_zip.Size = New System.Drawing.Size(58, 23)
        Me.lbldoc_zip.TabIndex = 19
        Me.lbldoc_zip.Text = "ZIP Code"
        Me.lbldoc_zip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'editdoc_mobile
        '
        Me.editdoc_mobile.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdoctors, "doctor.doc_mobile"))
        Me.editdoc_mobile.Location = New System.Drawing.Point(168, 184)
        Me.editdoc_mobile.Name = "editdoc_mobile"
        Me.editdoc_mobile.Size = New System.Drawing.Size(272, 20)
        Me.editdoc_mobile.TabIndex = 8
        Me.editdoc_mobile.Text = ""
        Me.editdoc_mobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'editdoc_phone
        '
        Me.editdoc_phone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdoctors, "doctor.doc_phone"))
        Me.editdoc_phone.Location = New System.Drawing.Point(168, 208)
        Me.editdoc_phone.Name = "editdoc_phone"
        Me.editdoc_phone.Size = New System.Drawing.Size(272, 20)
        Me.editdoc_phone.TabIndex = 9
        Me.editdoc_phone.Text = ""
        Me.editdoc_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'editdoc_position
        '
        Me.editdoc_position.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdoctors, "doctor.doc_position"))
        Me.editdoc_position.Location = New System.Drawing.Point(72, 144)
        Me.editdoc_position.Name = "editdoc_position"
        Me.editdoc_position.Size = New System.Drawing.Size(144, 20)
        Me.editdoc_position.TabIndex = 3
        Me.editdoc_position.Text = ""
        Me.editdoc_position.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'editdoc_state
        '
        Me.editdoc_state.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdoctors, "doctor.doc_state"))
        Me.editdoc_state.Location = New System.Drawing.Point(296, 120)
        Me.editdoc_state.Name = "editdoc_state"
        Me.editdoc_state.Size = New System.Drawing.Size(144, 20)
        Me.editdoc_state.TabIndex = 6
        Me.editdoc_state.Text = ""
        Me.editdoc_state.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'editdoc_zip
        '
        Me.editdoc_zip.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objdoctors, "doctor.doc_zip"))
        Me.editdoc_zip.Location = New System.Drawing.Point(296, 144)
        Me.editdoc_zip.Name = "editdoc_zip"
        Me.editdoc_zip.Size = New System.Drawing.Size(144, 20)
        Me.editdoc_zip.TabIndex = 7
        Me.editdoc_zip.Text = ""
        Me.editdoc_zip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnNavFirst
        '
        Me.btnNavFirst.Location = New System.Drawing.Point(195, 274)
        Me.btnNavFirst.Name = "btnNavFirst"
        Me.btnNavFirst.Size = New System.Drawing.Size(40, 23)
        Me.btnNavFirst.TabIndex = 25
        Me.btnNavFirst.TabStop = False
        Me.btnNavFirst.Text = "<<"
        '
        'btnNavPrev
        '
        Me.btnNavPrev.Location = New System.Drawing.Point(235, 274)
        Me.btnNavPrev.Name = "btnNavPrev"
        Me.btnNavPrev.Size = New System.Drawing.Size(35, 23)
        Me.btnNavPrev.TabIndex = 26
        Me.btnNavPrev.TabStop = False
        Me.btnNavPrev.Text = "<"
        '
        'lblNavLocation
        '
        Me.lblNavLocation.BackColor = System.Drawing.Color.White
        Me.lblNavLocation.Location = New System.Drawing.Point(270, 274)
        Me.lblNavLocation.Name = "lblNavLocation"
        Me.lblNavLocation.Size = New System.Drawing.Size(95, 23)
        Me.lblNavLocation.TabIndex = 27
        Me.lblNavLocation.Text = "No Records"
        Me.lblNavLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNavNext
        '
        Me.btnNavNext.Location = New System.Drawing.Point(365, 274)
        Me.btnNavNext.Name = "btnNavNext"
        Me.btnNavNext.Size = New System.Drawing.Size(35, 23)
        Me.btnNavNext.TabIndex = 28
        Me.btnNavNext.TabStop = False
        Me.btnNavNext.Text = ">"
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(400, 274)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(40, 23)
        Me.btnLast.TabIndex = 29
        Me.btnLast.TabStop = False
        Me.btnLast.Text = ">>"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(195, 307)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.TabIndex = 30
        Me.btnAdd.TabStop = False
        Me.btnAdd.Text = "&Add"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(280, 307)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.TabIndex = 31
        Me.btnDelete.TabStop = False
        Me.btnDelete.Text = "&Delete"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(365, 307)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 32
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "&Cancel"
        '
        'cmdGoBack
        '
        Me.cmdGoBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGoBack.Location = New System.Drawing.Point(8, 320)
        Me.cmdGoBack.Name = "cmdGoBack"
        Me.cmdGoBack.TabIndex = 33
        Me.cmdGoBack.Text = "GO BACK"
        '
        'DoctorDataForm1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(442, 348)
        Me.Controls.Add(Me.cmdGoBack)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancelAll)
        Me.Controls.Add(Me.lbldoc_address)
        Me.Controls.Add(Me.lbldoc_city)
        Me.Controls.Add(Me.lbldoc_email)
        Me.Controls.Add(Me.lbldoc_fname)
        Me.Controls.Add(Me.lbldoc_id)
        Me.Controls.Add(Me.lbldoc_lname)
        Me.Controls.Add(Me.editdoc_address)
        Me.Controls.Add(Me.editdoc_city)
        Me.Controls.Add(Me.editdoc_email)
        Me.Controls.Add(Me.editdoc_fname)
        Me.Controls.Add(Me.editdoc_id)
        Me.Controls.Add(Me.editdoc_lname)
        Me.Controls.Add(Me.lbldoc_mobile)
        Me.Controls.Add(Me.lbldoc_phone)
        Me.Controls.Add(Me.lbldoc_position)
        Me.Controls.Add(Me.lbldoc_state)
        Me.Controls.Add(Me.lbldoc_zip)
        Me.Controls.Add(Me.editdoc_mobile)
        Me.Controls.Add(Me.editdoc_phone)
        Me.Controls.Add(Me.editdoc_position)
        Me.Controls.Add(Me.editdoc_state)
        Me.Controls.Add(Me.editdoc_zip)
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
        Me.Name = "DoctorDataForm1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Doctor Data Form"
        CType(Me.objdoctors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.BindingContext(objdoctors, "doctor").CancelCurrentEdit()
        Me.objdoctors_PositionChanged()

    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (Me.BindingContext(objdoctors, "doctor").Count > 0) Then
            Me.BindingContext(objdoctors, "doctor").RemoveAt(Me.BindingContext(objdoctors, "doctor").Position)
            Me.objdoctors_PositionChanged()
        End If

    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            'Clear out the current edits
            Me.BindingContext(objdoctors, "doctor").EndCurrentEdit()
            Me.BindingContext(objdoctors, "doctor").AddNew()
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
        Me.objdoctors_PositionChanged()

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
        Me.objdoctors_PositionChanged()

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
        Me.objdoctors_PositionChanged()

    End Sub
    Private Sub btnNavFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavFirst.Click
        Me.BindingContext(objdoctors, "doctor").Position = 0
        Me.objdoctors_PositionChanged()

    End Sub
    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Me.BindingContext(objdoctors, "doctor").Position = (Me.objdoctors.Tables("doctor").Rows.Count - 1)
        Me.objdoctors_PositionChanged()

    End Sub
    Private Sub btnNavPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavPrev.Click
        Me.BindingContext(objdoctors, "doctor").Position = (Me.BindingContext(objdoctors, "doctor").Position - 1)
        Me.objdoctors_PositionChanged()

    End Sub
    Private Sub btnNavNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNavNext.Click
        Me.BindingContext(objdoctors, "doctor").Position = (Me.BindingContext(objdoctors, "doctor").Position + 1)
        Me.objdoctors_PositionChanged()

    End Sub
    Private Sub objdoctors_PositionChanged()
        Me.lblNavLocation.Text = (((Me.BindingContext(objdoctors, "doctor").Position + 1).ToString + " of  ") _
                    + Me.BindingContext(objdoctors, "doctor").Count.ToString)

    End Sub
    Private Sub btnCancelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelAll.Click
        Me.objdoctors.RejectChanges()

    End Sub
    Public Sub UpdateDataSet()
        'Create a new dataset to hold the changes that have been made to the main dataset.
        Dim objDataSetChanges As MIS475groupproj.doctors = New MIS475groupproj.doctors
        'Stop any current edits.
        Me.BindingContext(objdoctors, "doctor").EndCurrentEdit()
        'Get the changes that have been made to the main dataset.
        objDataSetChanges = CType(objdoctors.GetChanges, MIS475groupproj.doctors)
        'Check to see if any changes have been made.
        If (Not (objDataSetChanges) Is Nothing) Then
            Try
                'There are changes that need to be made, so attempt to update the datasource by
                'calling the update method and passing the dataset and any parameters.
                Me.UpdateDataSource(objDataSetChanges)
                objdoctors.Merge(objDataSetChanges)
                objdoctors.AcceptChanges()
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
        Dim objDataSetTemp As MIS475groupproj.doctors
        objDataSetTemp = New MIS475groupproj.doctors
        Try
            'Attempt to fill the temporary dataset.
            Me.FillDataSet(objDataSetTemp)
        Catch eFillDataSet As System.Exception
            'Add your error handling code here.
            Throw eFillDataSet
        End Try
        Try
            'Empty the old records from the dataset.
            objdoctors.Clear()
            'Merge the records into the main dataset.
            objdoctors.Merge(objDataSetTemp)
        Catch eLoadMerge As System.Exception
            'Add your error handling code here.
            Throw eLoadMerge
        End Try

    End Sub
    Public Sub UpdateDataSource(ByVal ChangedRows As MIS475groupproj.doctors)
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
    Public Sub FillDataSet(ByVal dataSet As MIS475groupproj.doctors)
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
        'Hide Doctor Data Form
        Me.Hide()
    End Sub

    Private Sub lbldoc_phone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbldoc_phone.Click

    End Sub
End Class
