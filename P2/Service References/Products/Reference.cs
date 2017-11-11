﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace P2.Products {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/Entities")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
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
        public int Category {
            get {
                return this.CategoryField;
            }
            set {
                if ((this.CategoryField.Equals(value) != true)) {
                    this.CategoryField = value;
                    this.RaisePropertyChanged("Category");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Products.IProducts")]
    public interface IProducts {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducts/GetAll", ReplyAction="http://tempuri.org/IProducts/GetAllResponse")]
        P2.Products.Product[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducts/GetAll", ReplyAction="http://tempuri.org/IProducts/GetAllResponse")]
        System.Threading.Tasks.Task<P2.Products.Product[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducts/Get", ReplyAction="http://tempuri.org/IProducts/GetResponse")]
        P2.Products.Product Get(int productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducts/Get", ReplyAction="http://tempuri.org/IProducts/GetResponse")]
        System.Threading.Tasks.Task<P2.Products.Product> GetAsync(int productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducts/Add", ReplyAction="http://tempuri.org/IProducts/AddResponse")]
        P2.Products.Product Add(P2.Products.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducts/Add", ReplyAction="http://tempuri.org/IProducts/AddResponse")]
        System.Threading.Tasks.Task<P2.Products.Product> AddAsync(P2.Products.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducts/Update", ReplyAction="http://tempuri.org/IProducts/UpdateResponse")]
        P2.Products.Product Update(P2.Products.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducts/Update", ReplyAction="http://tempuri.org/IProducts/UpdateResponse")]
        System.Threading.Tasks.Task<P2.Products.Product> UpdateAsync(P2.Products.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducts/Delete", ReplyAction="http://tempuri.org/IProducts/DeleteResponse")]
        void Delete(int productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducts/Delete", ReplyAction="http://tempuri.org/IProducts/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int productId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductsChannel : P2.Products.IProducts, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductsClient : System.ServiceModel.ClientBase<P2.Products.IProducts>, P2.Products.IProducts {
        
        public ProductsClient() {
        }
        
        public ProductsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public P2.Products.Product[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<P2.Products.Product[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public P2.Products.Product Get(int productId) {
            return base.Channel.Get(productId);
        }
        
        public System.Threading.Tasks.Task<P2.Products.Product> GetAsync(int productId) {
            return base.Channel.GetAsync(productId);
        }
        
        public P2.Products.Product Add(P2.Products.Product product) {
            return base.Channel.Add(product);
        }
        
        public System.Threading.Tasks.Task<P2.Products.Product> AddAsync(P2.Products.Product product) {
            return base.Channel.AddAsync(product);
        }
        
        public P2.Products.Product Update(P2.Products.Product product) {
            return base.Channel.Update(product);
        }
        
        public System.Threading.Tasks.Task<P2.Products.Product> UpdateAsync(P2.Products.Product product) {
            return base.Channel.UpdateAsync(product);
        }
        
        public void Delete(int productId) {
            base.Channel.Delete(productId);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int productId) {
            return base.Channel.DeleteAsync(productId);
        }
    }
}
