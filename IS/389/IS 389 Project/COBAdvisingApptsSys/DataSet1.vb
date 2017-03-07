﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.573
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
Public Class DataSet1
    Inherits DataSet
    
    Private tableAvailability As AvailabilityDataTable
    
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
            If (Not (ds.Tables("Availability")) Is Nothing) Then
                Me.Tables.Add(New AvailabilityDataTable(ds.Tables("Availability")))
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
    Public ReadOnly Property Availability As AvailabilityDataTable
        Get
            Return Me.tableAvailability
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As DataSet1 = CType(MyBase.Clone,DataSet1)
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
        If (Not (ds.Tables("Availability")) Is Nothing) Then
            Me.Tables.Add(New AvailabilityDataTable(ds.Tables("Availability")))
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
        Me.tableAvailability = CType(Me.Tables("Availability"),AvailabilityDataTable)
        If (Not (Me.tableAvailability) Is Nothing) Then
            Me.tableAvailability.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "DataSet1"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/DataSet1.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableAvailability = New AvailabilityDataTable
        Me.Tables.Add(Me.tableAvailability)
    End Sub
    
    Private Function ShouldSerializeAvailability() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub AvailabilityRowChangeEventHandler(ByVal sender As Object, ByVal e As AvailabilityRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class AvailabilityDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnExpr1 As DataColumn
        
        Private columnExpr2 As DataColumn
        
        Friend Sub New()
            MyBase.New("Availability")
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
        
        Friend ReadOnly Property Expr1Column As DataColumn
            Get
                Return Me.columnExpr1
            End Get
        End Property
        
        Friend ReadOnly Property Expr2Column As DataColumn
            Get
                Return Me.columnExpr2
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As AvailabilityRow
            Get
                Return CType(Me.Rows(index),AvailabilityRow)
            End Get
        End Property
        
        Public Event AvailabilityRowChanged As AvailabilityRowChangeEventHandler
        
        Public Event AvailabilityRowChanging As AvailabilityRowChangeEventHandler
        
        Public Event AvailabilityRowDeleted As AvailabilityRowChangeEventHandler
        
        Public Event AvailabilityRowDeleting As AvailabilityRowChangeEventHandler
        
        Public Overloads Sub AddAvailabilityRow(ByVal row As AvailabilityRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddAvailabilityRow(ByVal Expr1 As String, ByVal Expr2 As Date) As AvailabilityRow
            Dim rowAvailabilityRow As AvailabilityRow = CType(Me.NewRow,AvailabilityRow)
            rowAvailabilityRow.ItemArray = New Object() {Expr1, Expr2}
            Me.Rows.Add(rowAvailabilityRow)
            Return rowAvailabilityRow
        End Function
        
        Public Function FindByExpr1Expr2(ByVal Expr1 As String, ByVal Expr2 As Date) As AvailabilityRow
            Return CType(Me.Rows.Find(New Object() {Expr1, Expr2}),AvailabilityRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As AvailabilityDataTable = CType(MyBase.Clone,AvailabilityDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New AvailabilityDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnExpr1 = Me.Columns("Expr1")
            Me.columnExpr2 = Me.Columns("Expr2")
        End Sub
        
        Private Sub InitClass()
            Me.columnExpr1 = New DataColumn("Expr1", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnExpr1)
            Me.columnExpr2 = New DataColumn("Expr2", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnExpr2)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnExpr1, Me.columnExpr2}, true))
            Me.columnExpr1.AllowDBNull = false
            Me.columnExpr2.AllowDBNull = false
        End Sub
        
        Public Function NewAvailabilityRow() As AvailabilityRow
            Return CType(Me.NewRow,AvailabilityRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New AvailabilityRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(AvailabilityRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.AvailabilityRowChangedEvent) Is Nothing) Then
                RaiseEvent AvailabilityRowChanged(Me, New AvailabilityRowChangeEvent(CType(e.Row,AvailabilityRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.AvailabilityRowChangingEvent) Is Nothing) Then
                RaiseEvent AvailabilityRowChanging(Me, New AvailabilityRowChangeEvent(CType(e.Row,AvailabilityRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.AvailabilityRowDeletedEvent) Is Nothing) Then
                RaiseEvent AvailabilityRowDeleted(Me, New AvailabilityRowChangeEvent(CType(e.Row,AvailabilityRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.AvailabilityRowDeletingEvent) Is Nothing) Then
                RaiseEvent AvailabilityRowDeleting(Me, New AvailabilityRowChangeEvent(CType(e.Row,AvailabilityRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveAvailabilityRow(ByVal row As AvailabilityRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class AvailabilityRow
        Inherits DataRow
        
        Private tableAvailability As AvailabilityDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableAvailability = CType(Me.Table,AvailabilityDataTable)
        End Sub
        
        Public Property Expr1 As String
            Get
                Return CType(Me(Me.tableAvailability.Expr1Column),String)
            End Get
            Set
                Me(Me.tableAvailability.Expr1Column) = value
            End Set
        End Property
        
        Public Property Expr2 As Date
            Get
                Return CType(Me(Me.tableAvailability.Expr2Column),Date)
            End Get
            Set
                Me(Me.tableAvailability.Expr2Column) = value
            End Set
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class AvailabilityRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As AvailabilityRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As AvailabilityRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As AvailabilityRow
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
