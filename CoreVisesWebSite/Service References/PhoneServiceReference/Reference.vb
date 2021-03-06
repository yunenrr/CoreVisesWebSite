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


Namespace PhoneServiceReference
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="PhoneServiceReference.IPhoneService")>  _
    Public Interface IPhoneService
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IPhoneService/getPhones", ReplyAction:="http://tempuri.org/IPhoneService/getPhonesResponse")>  _
        Function getPhones(ByVal key As String) As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IPhoneService/getPhones", ReplyAction:="http://tempuri.org/IPhoneService/getPhonesResponse")>  _
        Function getPhonesAsync(ByVal key As String) As System.Threading.Tasks.Task(Of String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IPhoneService/getPhoneById", ReplyAction:="http://tempuri.org/IPhoneService/getPhoneByIdResponse")>  _
        Function getPhoneById(ByVal idPhone As String, ByVal key As String) As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IPhoneService/getPhoneById", ReplyAction:="http://tempuri.org/IPhoneService/getPhoneByIdResponse")>  _
        Function getPhoneByIdAsync(ByVal idPhone As String, ByVal key As String) As System.Threading.Tasks.Task(Of String)
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
        
        Public Function getPhones(ByVal key As String) As String Implements PhoneServiceReference.IPhoneService.getPhones
            Return MyBase.Channel.getPhones(key)
        End Function
        
        Public Function getPhonesAsync(ByVal key As String) As System.Threading.Tasks.Task(Of String) Implements PhoneServiceReference.IPhoneService.getPhonesAsync
            Return MyBase.Channel.getPhonesAsync(key)
        End Function
        
        Public Function getPhoneById(ByVal idPhone As String, ByVal key As String) As String Implements PhoneServiceReference.IPhoneService.getPhoneById
            Return MyBase.Channel.getPhoneById(idPhone, key)
        End Function
        
        Public Function getPhoneByIdAsync(ByVal idPhone As String, ByVal key As String) As System.Threading.Tasks.Task(Of String) Implements PhoneServiceReference.IPhoneService.getPhoneByIdAsync
            Return MyBase.Channel.getPhoneByIdAsync(idPhone, key)
        End Function
    End Class
End Namespace
