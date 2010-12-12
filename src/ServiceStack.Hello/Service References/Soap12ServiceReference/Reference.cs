﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceStack.Hello.Soap12ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://schemas.servicestack.net/types", ConfigurationName="Soap12ServiceReference.ISyncReply")]
    public interface ISyncReply {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.servicestack.net/types/Hello", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Result")]
        string Hello(string Name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ISyncReplyChannel : ServiceStack.Hello.Soap12ServiceReference.ISyncReply, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class SyncReplyClient : System.ServiceModel.ClientBase<ServiceStack.Hello.Soap12ServiceReference.ISyncReply>, ServiceStack.Hello.Soap12ServiceReference.ISyncReply {
        
        public SyncReplyClient() {
        }
        
        public SyncReplyClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SyncReplyClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SyncReplyClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SyncReplyClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Hello(string Name) {
            return base.Channel.Hello(Name);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://schemas.servicestack.net/types", ConfigurationName="Soap12ServiceReference.IOneWay")]
    public interface IOneWay {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IOneWayChannel : ServiceStack.Hello.Soap12ServiceReference.IOneWay, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class OneWayClient : System.ServiceModel.ClientBase<ServiceStack.Hello.Soap12ServiceReference.IOneWay>, ServiceStack.Hello.Soap12ServiceReference.IOneWay {
        
        public OneWayClient() {
        }
        
        public OneWayClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OneWayClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OneWayClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OneWayClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
    }
}