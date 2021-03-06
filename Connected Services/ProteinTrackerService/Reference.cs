﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProteinTrackerClient.ProteinTrackerService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Awebsite.org/", ConfigurationName="ProteinTrackerService.ProteinTrackingServiceSoap")]
    public interface ProteinTrackingServiceSoap {
        
        // CODEGEN: Generating message contract since message AddProteinRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action="http://Awebsite.org/AddProtein", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ProteinTrackerClient.ProteinTrackerService.AddProteinResponse AddProtein(ProteinTrackerClient.ProteinTrackerService.AddProteinRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Awebsite.org/AddProtein", ReplyAction="*")]
        System.Threading.Tasks.Task<ProteinTrackerClient.ProteinTrackerService.AddProteinResponse> AddProteinAsync(ProteinTrackerClient.ProteinTrackerService.AddProteinRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Awebsite.org/AddUser", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int AddUser(string name, int goal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Awebsite.org/AddUser", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddUserAsync(string name, int goal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Awebsite.org/ListUsers", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ProteinTrackerClient.ProteinTrackerService.User[] ListUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Awebsite.org/ListUsers", ReplyAction="*")]
        System.Threading.Tasks.Task<ProteinTrackerClient.ProteinTrackerService.User[]> ListUsersAsync();
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://Awebsite.org/")]
    public partial class AuthenticationHeader : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string userNameField;
        
        private string passwordField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string UserName {
            get {
                return this.userNameField;
            }
            set {
                this.userNameField = value;
                this.RaisePropertyChanged("UserName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
                this.RaisePropertyChanged("Password");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
                this.RaisePropertyChanged("AnyAttr");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://Awebsite.org/")]
    public partial class User : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string nameField;
        
        private int goalField;
        
        private int totalField;
        
        private int userIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int Goal {
            get {
                return this.goalField;
            }
            set {
                this.goalField = value;
                this.RaisePropertyChanged("Goal");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int Total {
            get {
                return this.totalField;
            }
            set {
                this.totalField = value;
                this.RaisePropertyChanged("Total");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int UserID {
            get {
                return this.userIDField;
            }
            set {
                this.userIDField = value;
                this.RaisePropertyChanged("UserID");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AddProtein", WrapperNamespace="http://Awebsite.org/", IsWrapped=true)]
    public partial class AddProteinRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://Awebsite.org/")]
        public ProteinTrackerClient.ProteinTrackerService.AuthenticationHeader AuthenticationHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Awebsite.org/", Order=0)]
        public int amount;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Awebsite.org/", Order=1)]
        public int userId;
        
        public AddProteinRequest() {
        }
        
        public AddProteinRequest(ProteinTrackerClient.ProteinTrackerService.AuthenticationHeader AuthenticationHeader, int amount, int userId) {
            this.AuthenticationHeader = AuthenticationHeader;
            this.amount = amount;
            this.userId = userId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AddProteinResponse", WrapperNamespace="http://Awebsite.org/", IsWrapped=true)]
    public partial class AddProteinResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Awebsite.org/", Order=0)]
        public int AddProteinResult;
        
        public AddProteinResponse() {
        }
        
        public AddProteinResponse(int AddProteinResult) {
            this.AddProteinResult = AddProteinResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ProteinTrackingServiceSoapChannel : ProteinTrackerClient.ProteinTrackerService.ProteinTrackingServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProteinTrackingServiceSoapClient : System.ServiceModel.ClientBase<ProteinTrackerClient.ProteinTrackerService.ProteinTrackingServiceSoap>, ProteinTrackerClient.ProteinTrackerService.ProteinTrackingServiceSoap {
        
        public ProteinTrackingServiceSoapClient() {
        }
        
        public ProteinTrackingServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProteinTrackingServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProteinTrackingServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProteinTrackingServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProteinTrackerClient.ProteinTrackerService.AddProteinResponse ProteinTrackerClient.ProteinTrackerService.ProteinTrackingServiceSoap.AddProtein(ProteinTrackerClient.ProteinTrackerService.AddProteinRequest request) {
            return base.Channel.AddProtein(request);
        }
        
        public int AddProtein(ProteinTrackerClient.ProteinTrackerService.AuthenticationHeader AuthenticationHeader, int amount, int userId) {
            ProteinTrackerClient.ProteinTrackerService.AddProteinRequest inValue = new ProteinTrackerClient.ProteinTrackerService.AddProteinRequest();
            inValue.AuthenticationHeader = AuthenticationHeader;
            inValue.amount = amount;
            inValue.userId = userId;
            ProteinTrackerClient.ProteinTrackerService.AddProteinResponse retVal = ((ProteinTrackerClient.ProteinTrackerService.ProteinTrackingServiceSoap)(this)).AddProtein(inValue);
            return retVal.AddProteinResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProteinTrackerClient.ProteinTrackerService.AddProteinResponse> ProteinTrackerClient.ProteinTrackerService.ProteinTrackingServiceSoap.AddProteinAsync(ProteinTrackerClient.ProteinTrackerService.AddProteinRequest request) {
            return base.Channel.AddProteinAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProteinTrackerClient.ProteinTrackerService.AddProteinResponse> AddProteinAsync(ProteinTrackerClient.ProteinTrackerService.AuthenticationHeader AuthenticationHeader, int amount, int userId) {
            ProteinTrackerClient.ProteinTrackerService.AddProteinRequest inValue = new ProteinTrackerClient.ProteinTrackerService.AddProteinRequest();
            inValue.AuthenticationHeader = AuthenticationHeader;
            inValue.amount = amount;
            inValue.userId = userId;
            return ((ProteinTrackerClient.ProteinTrackerService.ProteinTrackingServiceSoap)(this)).AddProteinAsync(inValue);
        }
        
        public int AddUser(string name, int goal) {
            return base.Channel.AddUser(name, goal);
        }
        
        public System.Threading.Tasks.Task<int> AddUserAsync(string name, int goal) {
            return base.Channel.AddUserAsync(name, goal);
        }
        
        public ProteinTrackerClient.ProteinTrackerService.User[] ListUsers() {
            return base.Channel.ListUsers();
        }
        
        public System.Threading.Tasks.Task<ProteinTrackerClient.ProteinTrackerService.User[]> ListUsersAsync() {
            return base.Channel.ListUsersAsync();
        }
    }
}
