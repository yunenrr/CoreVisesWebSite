﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.Serialization

Namespace PhoneServiceReference
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="Phone", [Namespace]:="http://schemas.datacontract.org/2004/07/Domain"),  _
     System.SerializableAttribute()>  _
    Partial Public Class Phone
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private BrandField As PhoneServiceReference.Brand
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private ExternalMemoryField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private FlashField As Integer
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private IdPhoneField As Integer
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private ImageField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private InternalMemoryField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private ModelField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private NetworkModeField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private OSField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private PixelsField As Integer
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private PriceField As Integer
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private QuantityField As Integer
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private ResolutionField As String
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Brand() As PhoneServiceReference.Brand
            Get
                Return Me.BrandField
            End Get
            Set
                If (Object.ReferenceEquals(Me.BrandField, value) <> true) Then
                    Me.BrandField = value
                    Me.RaisePropertyChanged("Brand")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property ExternalMemory() As String
            Get
                Return Me.ExternalMemoryField
            End Get
            Set
                If (Object.ReferenceEquals(Me.ExternalMemoryField, value) <> true) Then
                    Me.ExternalMemoryField = value
                    Me.RaisePropertyChanged("ExternalMemory")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Flash() As Integer
            Get
                Return Me.FlashField
            End Get
            Set
                If (Me.FlashField.Equals(value) <> true) Then
                    Me.FlashField = value
                    Me.RaisePropertyChanged("Flash")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property IdPhone() As Integer
            Get
                Return Me.IdPhoneField
            End Get
            Set
                If (Me.IdPhoneField.Equals(value) <> true) Then
                    Me.IdPhoneField = value
                    Me.RaisePropertyChanged("IdPhone")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Image() As String
            Get
                Return Me.ImageField
            End Get
            Set
                If (Object.ReferenceEquals(Me.ImageField, value) <> true) Then
                    Me.ImageField = value
                    Me.RaisePropertyChanged("Image")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property InternalMemory() As String
            Get
                Return Me.InternalMemoryField
            End Get
            Set
                If (Object.ReferenceEquals(Me.InternalMemoryField, value) <> true) Then
                    Me.InternalMemoryField = value
                    Me.RaisePropertyChanged("InternalMemory")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Model() As String
            Get
                Return Me.ModelField
            End Get
            Set
                If (Object.ReferenceEquals(Me.ModelField, value) <> true) Then
                    Me.ModelField = value
                    Me.RaisePropertyChanged("Model")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property NetworkMode() As String
            Get
                Return Me.NetworkModeField
            End Get
            Set
                If (Object.ReferenceEquals(Me.NetworkModeField, value) <> true) Then
                    Me.NetworkModeField = value
                    Me.RaisePropertyChanged("NetworkMode")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property OS() As String
            Get
                Return Me.OSField
            End Get
            Set
                If (Object.ReferenceEquals(Me.OSField, value) <> true) Then
                    Me.OSField = value
                    Me.RaisePropertyChanged("OS")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Pixels() As Integer
            Get
                Return Me.PixelsField
            End Get
            Set
                If (Me.PixelsField.Equals(value) <> true) Then
                    Me.PixelsField = value
                    Me.RaisePropertyChanged("Pixels")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Price() As Integer
            Get
                Return Me.PriceField
            End Get
            Set
                If (Me.PriceField.Equals(value) <> true) Then
                    Me.PriceField = value
                    Me.RaisePropertyChanged("Price")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Quantity() As Integer
            Get
                Return Me.QuantityField
            End Get
            Set
                If (Me.QuantityField.Equals(value) <> true) Then
                    Me.QuantityField = value
                    Me.RaisePropertyChanged("Quantity")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Resolution() As String
            Get
                Return Me.ResolutionField
            End Get
            Set
                If (Object.ReferenceEquals(Me.ResolutionField, value) <> true) Then
                    Me.ResolutionField = value
                    Me.RaisePropertyChanged("Resolution")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="Brand", [Namespace]:="http://schemas.datacontract.org/2004/07/Domain"),  _
     System.SerializableAttribute()>  _
    Partial Public Class Brand
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private IdBrandField As Integer
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private NameField As String
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property IdBrand() As Integer
            Get
                Return Me.IdBrandField
            End Get
            Set
                If (Me.IdBrandField.Equals(value) <> true) Then
                    Me.IdBrandField = value
                    Me.RaisePropertyChanged("IdBrand")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Name() As String
            Get
                Return Me.NameField
            End Get
            Set
                If (Object.ReferenceEquals(Me.NameField, value) <> true) Then
                    Me.NameField = value
                    Me.RaisePropertyChanged("Name")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="PhoneServiceReference.IPhoneService")>  _
    Public Interface IPhoneService
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IPhoneService/insertPhone", ReplyAction:="http://tempuri.org/IPhoneService/insertPhoneResponse")>  _
        Function insertPhone(ByVal idPhone As Integer, ByVal idBrand As Integer, ByVal model As String, ByVal os As String, ByVal networkmode As String, ByVal internalMemory As String, ByVal externalMemory As String, ByVal pixels As Integer, ByVal flash As Integer, ByVal resolution As String, ByVal price As Integer, ByVal quantity As Integer, ByVal image As String) As Integer
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IPhoneService/insertPhone", ReplyAction:="http://tempuri.org/IPhoneService/insertPhoneResponse")>  _
        Function insertPhoneAsync(ByVal idPhone As Integer, ByVal idBrand As Integer, ByVal model As String, ByVal os As String, ByVal networkmode As String, ByVal internalMemory As String, ByVal externalMemory As String, ByVal pixels As Integer, ByVal flash As Integer, ByVal resolution As String, ByVal price As Integer, ByVal quantity As Integer, ByVal image As String) As System.Threading.Tasks.Task(Of Integer)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IPhoneService/getPhones", ReplyAction:="http://tempuri.org/IPhoneService/getPhonesResponse")>  _
        Function getPhones() As PhoneServiceReference.Phone()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IPhoneService/getPhones", ReplyAction:="http://tempuri.org/IPhoneService/getPhonesResponse")>  _
        Function getPhonesAsync() As System.Threading.Tasks.Task(Of PhoneServiceReference.Phone())
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface IPhoneServiceChannel
        Inherits PhoneServiceReference.IPhoneService, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class PhoneServiceClient
        Inherits System.ServiceModel.ClientBase(Of PhoneServiceReference.IPhoneService)
        Implements PhoneServiceReference.IPhoneService
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function insertPhone(ByVal idPhone As Integer, ByVal idBrand As Integer, ByVal model As String, ByVal os As String, ByVal networkmode As String, ByVal internalMemory As String, ByVal externalMemory As String, ByVal pixels As Integer, ByVal flash As Integer, ByVal resolution As String, ByVal price As Integer, ByVal quantity As Integer, ByVal image As String) As Integer Implements PhoneServiceReference.IPhoneService.insertPhone
            Return MyBase.Channel.insertPhone(idPhone, idBrand, model, os, networkmode, internalMemory, externalMemory, pixels, flash, resolution, price, quantity, image)
        End Function
        
        Public Function insertPhoneAsync(ByVal idPhone As Integer, ByVal idBrand As Integer, ByVal model As String, ByVal os As String, ByVal networkmode As String, ByVal internalMemory As String, ByVal externalMemory As String, ByVal pixels As Integer, ByVal flash As Integer, ByVal resolution As String, ByVal price As Integer, ByVal quantity As Integer, ByVal image As String) As System.Threading.Tasks.Task(Of Integer) Implements PhoneServiceReference.IPhoneService.insertPhoneAsync
            Return MyBase.Channel.insertPhoneAsync(idPhone, idBrand, model, os, networkmode, internalMemory, externalMemory, pixels, flash, resolution, price, quantity, image)
        End Function
        
        Public Function getPhones() As PhoneServiceReference.Phone() Implements PhoneServiceReference.IPhoneService.getPhones
            Return MyBase.Channel.getPhones
        End Function
        
        Public Function getPhonesAsync() As System.Threading.Tasks.Task(Of PhoneServiceReference.Phone()) Implements PhoneServiceReference.IPhoneService.getPhonesAsync
            Return MyBase.Channel.getPhonesAsync
        End Function
    End Class
End Namespace
