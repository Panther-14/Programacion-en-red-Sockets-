﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimpleClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/DataServices")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Manager", Namespace="http://schemas.datacontract.org/2004/07/DataServices")]
    [System.SerializableAttribute()]
    public partial class Manager : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IPlayerManager")]
    public interface IPlayerManager {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPlayerManager/AddUser", ReplyAction="http://tempuri.org/IPlayerManager/AddUserResponse")]
        int AddUser(SimpleClient.ServiceReference1.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPlayerManager/AddUser", ReplyAction="http://tempuri.org/IPlayerManager/AddUserResponse")]
        System.Threading.Tasks.Task<int> AddUserAsync(SimpleClient.ServiceReference1.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPlayerManager/GetUserById", ReplyAction="http://tempuri.org/IPlayerManager/GetUserByIdResponse")]
        SimpleClient.ServiceReference1.User GetUserById(string userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPlayerManager/GetUserById", ReplyAction="http://tempuri.org/IPlayerManager/GetUserByIdResponse")]
        System.Threading.Tasks.Task<SimpleClient.ServiceReference1.User> GetUserByIdAsync(string userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPlayerManager/AddManager", ReplyAction="http://tempuri.org/IPlayerManager/AddManagerResponse")]
        int AddManager(SimpleClient.ServiceReference1.Manager manager);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPlayerManager/AddManager", ReplyAction="http://tempuri.org/IPlayerManager/AddManagerResponse")]
        System.Threading.Tasks.Task<int> AddManagerAsync(SimpleClient.ServiceReference1.Manager manager);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPlayerManagerChannel : SimpleClient.ServiceReference1.IPlayerManager, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PlayerManagerClient : System.ServiceModel.ClientBase<SimpleClient.ServiceReference1.IPlayerManager>, SimpleClient.ServiceReference1.IPlayerManager {
        
        public PlayerManagerClient() {
        }
        
        public PlayerManagerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PlayerManagerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PlayerManagerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PlayerManagerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int AddUser(SimpleClient.ServiceReference1.User user) {
            return base.Channel.AddUser(user);
        }
        
        public System.Threading.Tasks.Task<int> AddUserAsync(SimpleClient.ServiceReference1.User user) {
            return base.Channel.AddUserAsync(user);
        }
        
        public SimpleClient.ServiceReference1.User GetUserById(string userId) {
            return base.Channel.GetUserById(userId);
        }
        
        public System.Threading.Tasks.Task<SimpleClient.ServiceReference1.User> GetUserByIdAsync(string userId) {
            return base.Channel.GetUserByIdAsync(userId);
        }
        
        public int AddManager(SimpleClient.ServiceReference1.Manager manager) {
            return base.Channel.AddManager(manager);
        }
        
        public System.Threading.Tasks.Task<int> AddManagerAsync(SimpleClient.ServiceReference1.Manager manager) {
            return base.Channel.AddManagerAsync(manager);
        }
    }
}
