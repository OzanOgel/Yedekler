﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class WarehousDBEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=WarehousDBEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property Managers() As DbSet(Of Managers)
    Public Overridable Property Orders() As DbSet(Of Orders)
    Public Overridable Property ProductCategorys() As DbSet(Of ProductCategorys)
    Public Overridable Property Products() As DbSet(Of Products)
    Public Overridable Property SupplierStore() As DbSet(Of SupplierStore)
    Public Overridable Property sysdiagrams() As DbSet(Of sysdiagrams)

End Class