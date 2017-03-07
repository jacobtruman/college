﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.535
'
'     Changes to this file may cause incorrect behavior and will be lost if 
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Runtime.Serialization
Imports System.Xml


<Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.Diagnostics.DebuggerStepThrough(),  _
 System.ComponentModel.ToolboxItem(true)>  _
Public Class DsInstructors
    Inherits DataSet
    
    Private tableInstructors As InstructorsDataTable
    
    Public Sub New()
        MyBase.New
        Me.InitClass
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
        MyBase.New
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(System.String)),String)
        If (Not (strSchema) Is Nothing) Then
            Dim ds As DataSet = New DataSet
            ds.ReadXmlSchema(New XmlTextReader(New System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("Instructors")) Is Nothing) Then
                Me.Tables.Add(New InstructorsDataTable(ds.Tables("Instructors")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.InitClass
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Instructors As InstructorsDataTable
        Get
            Return Me.tableInstructors
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As DsInstructors = CType(MyBase.Clone,DsInstructors)
        cln.InitVars
        Return cln
    End Function
    
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
        Me.Reset
        Dim ds As DataSet = New DataSet
        ds.ReadXml(reader)
        If (Not (ds.Tables("Instructors")) Is Nothing) Then
            Me.Tables.Add(New InstructorsDataTable(ds.Tables("Instructors")))
        End If
        Me.DataSetName = ds.DataSetName
        Me.Prefix = ds.Prefix
        Me.Namespace = ds.Namespace
        Me.Locale = ds.Locale
        Me.CaseSensitive = ds.CaseSensitive
        Me.EnforceConstraints = ds.EnforceConstraints
        Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
        Me.InitVars
    End Sub
    
    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
        Me.WriteXmlSchema(New XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New XmlTextReader(stream), Nothing)
    End Function
    
    Friend Sub InitVars()
        Me.tableInstructors = CType(Me.Tables("Instructors"),InstructorsDataTable)
        If (Not (Me.tableInstructors) Is Nothing) Then
            Me.tableInstructors.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "DsInstructors"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/DsInstructors.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableInstructors = New InstructorsDataTable
        Me.Tables.Add(Me.tableInstructors)
    End Sub
    
    Private Function ShouldSerializeInstructors() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub InstructorsRowChangeEventHandler(ByVal sender As Object, ByVal e As InstructorsRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class InstructorsDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnInstructor As DataColumn
        
        Private columnInstructorID As DataColumn
        
        Friend Sub New()
            MyBase.New("Instructors")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property InstructorColumn As DataColumn
            Get
                Return Me.columnInstructor
            End Get
        End Property
        
        Friend ReadOnly Property InstructorIDColumn As DataColumn
            Get
                Return Me.columnInstructorID
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As InstructorsRow
            Get
                Return CType(Me.Rows(index),InstructorsRow)
            End Get
        End Property
        
        Public Event InstructorsRowChanged As InstructorsRowChangeEventHandler
        
        Public Event InstructorsRowChanging As InstructorsRowChangeEventHandler
        
        Public Event InstructorsRowDeleted As InstructorsRowChangeEventHandler
        
        Public Event InstructorsRowDeleting As InstructorsRowChangeEventHandler
        
        Public Overloads Sub AddInstructorsRow(ByVal row As InstructorsRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddInstructorsRow(ByVal Instructor As String) As InstructorsRow
            Dim rowInstructorsRow As InstructorsRow = CType(Me.NewRow,InstructorsRow)
            rowInstructorsRow.ItemArray = New Object() {Instructor, Nothing}
            Me.Rows.Add(rowInstructorsRow)
            Return rowInstructorsRow
        End Function
        
        Public Function FindByInstructorID(ByVal InstructorID As Integer) As InstructorsRow
            Return CType(Me.Rows.Find(New Object() {InstructorID}),InstructorsRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As InstructorsDataTable = CType(MyBase.Clone,InstructorsDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New InstructorsDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnInstructor = Me.Columns("Instructor")
            Me.columnInstructorID = Me.Columns("InstructorID")
        End Sub
        
        Private Sub InitClass()
            Me.columnInstructor = New DataColumn("Instructor", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnInstructor)
            Me.columnInstructorID = New DataColumn("InstructorID", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnInstructorID)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnInstructorID}, true))
            Me.columnInstructorID.AutoIncrement = true
            Me.columnInstructorID.AllowDBNull = false
            Me.columnInstructorID.Unique = true
        End Sub
        
        Public Function NewInstructorsRow() As InstructorsRow
            Return CType(Me.NewRow,InstructorsRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New InstructorsRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(InstructorsRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.InstructorsRowChangedEvent) Is Nothing) Then
                RaiseEvent InstructorsRowChanged(Me, New InstructorsRowChangeEvent(CType(e.Row,InstructorsRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.InstructorsRowChangingEvent) Is Nothing) Then
                RaiseEvent InstructorsRowChanging(Me, New InstructorsRowChangeEvent(CType(e.Row,InstructorsRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.InstructorsRowDeletedEvent) Is Nothing) Then
                RaiseEvent InstructorsRowDeleted(Me, New InstructorsRowChangeEvent(CType(e.Row,InstructorsRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.InstructorsRowDeletingEvent) Is Nothing) Then
                RaiseEvent InstructorsRowDeleting(Me, New InstructorsRowChangeEvent(CType(e.Row,InstructorsRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveInstructorsRow(ByVal row As InstructorsRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class InstructorsRow
        Inherits DataRow
        
        Private tableInstructors As InstructorsDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableInstructors = CType(Me.Table,InstructorsDataTable)
        End Sub
        
        Public Property Instructor As String
            Get
                Try 
                    Return CType(Me(Me.tableInstructors.InstructorColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableInstructors.InstructorColumn) = value
            End Set
        End Property
        
        Public Property InstructorID As Integer
            Get
                Return CType(Me(Me.tableInstructors.InstructorIDColumn),Integer)
            End Get
            Set
                Me(Me.tableInstructors.InstructorIDColumn) = value
            End Set
        End Property
        
        Public Function IsInstructorNull() As Boolean
            Return Me.IsNull(Me.tableInstructors.InstructorColumn)
        End Function
        
        Public Sub SetInstructorNull()
            Me(Me.tableInstructors.InstructorColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class InstructorsRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As InstructorsRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As InstructorsRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As InstructorsRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class
