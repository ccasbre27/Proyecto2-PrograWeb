﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace P2.UserTypes {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserTypes.IUserTypes")]
    public interface IUserTypes {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserTypes/GetAll", ReplyAction="http://tempuri.org/IUserTypes/GetAllResponse")]
        Entities.UserType[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserTypes/GetAll", ReplyAction="http://tempuri.org/IUserTypes/GetAllResponse")]
        System.Threading.Tasks.Task<Entities.UserType[]> GetAllAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserTypesChannel : P2.UserTypes.IUserTypes, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserTypesClient : System.ServiceModel.ClientBase<P2.UserTypes.IUserTypes>, P2.UserTypes.IUserTypes {
        
        public UserTypesClient() {
        }
        
        public UserTypesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserTypesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserTypesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserTypesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Entities.UserType[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<Entities.UserType[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
    }
}
