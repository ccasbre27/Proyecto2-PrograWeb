﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace P2.Users {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/Entities")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DNIField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FullNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private P2.Users.UserType TypeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DNI {
            get {
                return this.DNIField;
            }
            set {
                if ((this.DNIField.Equals(value) != true)) {
                    this.DNIField = value;
                    this.RaisePropertyChanged("DNI");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FullName {
            get {
                return this.FullNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FullNameField, value) != true)) {
                    this.FullNameField = value;
                    this.RaisePropertyChanged("FullName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public P2.Users.UserType Type {
            get {
                return this.TypeField;
            }
            set {
                if ((this.TypeField.Equals(value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserType", Namespace="http://schemas.datacontract.org/2004/07/Entities")]
    public enum UserType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Admin = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Normal = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Users.IUsers")]
    public interface IUsers {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsers/GetAll", ReplyAction="http://tempuri.org/IUsers/GetAllResponse")]
        P2.Users.User[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsers/GetAll", ReplyAction="http://tempuri.org/IUsers/GetAllResponse")]
        System.Threading.Tasks.Task<P2.Users.User[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsers/Get", ReplyAction="http://tempuri.org/IUsers/GetResponse")]
        P2.Users.User Get(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsers/Get", ReplyAction="http://tempuri.org/IUsers/GetResponse")]
        System.Threading.Tasks.Task<P2.Users.User> GetAsync(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsers/Add", ReplyAction="http://tempuri.org/IUsers/AddResponse")]
        P2.Users.User Add(P2.Users.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsers/Add", ReplyAction="http://tempuri.org/IUsers/AddResponse")]
        System.Threading.Tasks.Task<P2.Users.User> AddAsync(P2.Users.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsers/Update", ReplyAction="http://tempuri.org/IUsers/UpdateResponse")]
        P2.Users.User Update(P2.Users.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsers/Update", ReplyAction="http://tempuri.org/IUsers/UpdateResponse")]
        System.Threading.Tasks.Task<P2.Users.User> UpdateAsync(P2.Users.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsers/Delete", ReplyAction="http://tempuri.org/IUsers/DeleteResponse")]
        void Delete(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsers/Delete", ReplyAction="http://tempuri.org/IUsers/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int userId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUsersChannel : P2.Users.IUsers, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UsersClient : System.ServiceModel.ClientBase<P2.Users.IUsers>, P2.Users.IUsers {
        
        public UsersClient() {
        }
        
        public UsersClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UsersClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsersClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsersClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public P2.Users.User[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<P2.Users.User[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public P2.Users.User Get(int userId) {
            return base.Channel.Get(userId);
        }
        
        public System.Threading.Tasks.Task<P2.Users.User> GetAsync(int userId) {
            return base.Channel.GetAsync(userId);
        }
        
        public P2.Users.User Add(P2.Users.User user) {
            return base.Channel.Add(user);
        }
        
        public System.Threading.Tasks.Task<P2.Users.User> AddAsync(P2.Users.User user) {
            return base.Channel.AddAsync(user);
        }
        
        public P2.Users.User Update(P2.Users.User user) {
            return base.Channel.Update(user);
        }
        
        public System.Threading.Tasks.Task<P2.Users.User> UpdateAsync(P2.Users.User user) {
            return base.Channel.UpdateAsync(user);
        }
        
        public void Delete(int userId) {
            base.Channel.Delete(userId);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int userId) {
            return base.Channel.DeleteAsync(userId);
        }
    }
}
