﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfDemo.Web.ContactService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Contact", Namespace="http://schemas.datacontract.org/2004/07/WcfDemo.Service")]
    [System.SerializableAttribute()]
    public partial class Contact : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneNumberField;
        
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
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
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
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneNumber {
            get {
                return this.PhoneNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNumberField, value) != true)) {
                    this.PhoneNumberField = value;
                    this.RaisePropertyChanged("PhoneNumber");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ContactService.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Select", ReplyAction="http://tempuri.org/IService/SelectResponse")]
        WcfDemo.Web.ContactService.Contact Select(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Select", ReplyAction="http://tempuri.org/IService/SelectResponse")]
        System.Threading.Tasks.Task<WcfDemo.Web.ContactService.Contact> SelectAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/All", ReplyAction="http://tempuri.org/IService/AllResponse")]
        WcfDemo.Web.ContactService.Contact[] All();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/All", ReplyAction="http://tempuri.org/IService/AllResponse")]
        System.Threading.Tasks.Task<WcfDemo.Web.ContactService.Contact[]> AllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Save", ReplyAction="http://tempuri.org/IService/SaveResponse")]
        void Save(WcfDemo.Web.ContactService.Contact contact);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Save", ReplyAction="http://tempuri.org/IService/SaveResponse")]
        System.Threading.Tasks.Task SaveAsync(WcfDemo.Web.ContactService.Contact contact);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Remove", ReplyAction="http://tempuri.org/IService/RemoveResponse")]
        void Remove(WcfDemo.Web.ContactService.Contact contact);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Remove", ReplyAction="http://tempuri.org/IService/RemoveResponse")]
        System.Threading.Tasks.Task RemoveAsync(WcfDemo.Web.ContactService.Contact contact);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : global::WcfDemo.Web.ContactService.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<global::WcfDemo.Web.ContactService.IService>, global::WcfDemo.Web.ContactService.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WcfDemo.Web.ContactService.Contact Select(System.Guid id) {
            return base.Channel.Select(id);
        }
        
        public System.Threading.Tasks.Task<WcfDemo.Web.ContactService.Contact> SelectAsync(System.Guid id) {
            return base.Channel.SelectAsync(id);
        }
        
        public WcfDemo.Web.ContactService.Contact[] All() {
            return base.Channel.All();
        }
        
        public System.Threading.Tasks.Task<WcfDemo.Web.ContactService.Contact[]> AllAsync() {
            return base.Channel.AllAsync();
        }
        
        public void Save(WcfDemo.Web.ContactService.Contact contact) {
            base.Channel.Save(contact);
        }
        
        public System.Threading.Tasks.Task SaveAsync(WcfDemo.Web.ContactService.Contact contact) {
            return base.Channel.SaveAsync(contact);
        }
        
        public void Remove(WcfDemo.Web.ContactService.Contact contact) {
            base.Channel.Remove(contact);
        }
        
        public System.Threading.Tasks.Task RemoveAsync(WcfDemo.Web.ContactService.Contact contact) {
            return base.Channel.RemoveAsync(contact);
        }
    }
}
