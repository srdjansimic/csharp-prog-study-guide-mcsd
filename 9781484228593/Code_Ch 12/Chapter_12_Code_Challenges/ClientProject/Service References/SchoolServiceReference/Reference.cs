﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientProject.SchoolServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StudentDto", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class StudentDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int StudentIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StudentNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int StudentID {
            get {
                return this.StudentIDField;
            }
            set {
                if ((this.StudentIDField.Equals(value) != true)) {
                    this.StudentIDField = value;
                    this.RaisePropertyChanged("StudentID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string StudentName {
            get {
                return this.StudentNameField;
            }
            set {
                if ((object.ReferenceEquals(this.StudentNameField, value) != true)) {
                    this.StudentNameField = value;
                    this.RaisePropertyChanged("StudentName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SchoolServiceReference.SchoolWebServiceSoap")]
    public interface SchoolWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name name from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        ClientProject.SchoolServiceReference.AddResponse Add(ClientProject.SchoolServiceReference.AddRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<ClientProject.SchoolServiceReference.AddResponse> AddAsync(ClientProject.SchoolServiceReference.AddRequest request);
        
        // CODEGEN: Generating message contract since element name ReadAllResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ReadAll", ReplyAction="*")]
        ClientProject.SchoolServiceReference.ReadAllResponse ReadAll(ClientProject.SchoolServiceReference.ReadAllRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ReadAll", ReplyAction="*")]
        System.Threading.Tasks.Task<ClientProject.SchoolServiceReference.ReadAllResponse> ReadAllAsync(ClientProject.SchoolServiceReference.ReadAllRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Add", Namespace="http://tempuri.org/", Order=0)]
        public ClientProject.SchoolServiceReference.AddRequestBody Body;
        
        public AddRequest() {
        }
        
        public AddRequest(ClientProject.SchoolServiceReference.AddRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string name;
        
        public AddRequestBody() {
        }
        
        public AddRequestBody(int id, string name) {
            this.id = id;
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddResponse", Namespace="http://tempuri.org/", Order=0)]
        public ClientProject.SchoolServiceReference.AddResponseBody Body;
        
        public AddResponse() {
        }
        
        public AddResponse(ClientProject.SchoolServiceReference.AddResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int AddResult;
        
        public AddResponseBody() {
        }
        
        public AddResponseBody(int AddResult) {
            this.AddResult = AddResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReadAllRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReadAll", Namespace="http://tempuri.org/", Order=0)]
        public ClientProject.SchoolServiceReference.ReadAllRequestBody Body;
        
        public ReadAllRequest() {
        }
        
        public ReadAllRequest(ClientProject.SchoolServiceReference.ReadAllRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ReadAllRequestBody {
        
        public ReadAllRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReadAllResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReadAllResponse", Namespace="http://tempuri.org/", Order=0)]
        public ClientProject.SchoolServiceReference.ReadAllResponseBody Body;
        
        public ReadAllResponse() {
        }
        
        public ReadAllResponse(ClientProject.SchoolServiceReference.ReadAllResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ReadAllResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ClientProject.SchoolServiceReference.StudentDto[] ReadAllResult;
        
        public ReadAllResponseBody() {
        }
        
        public ReadAllResponseBody(ClientProject.SchoolServiceReference.StudentDto[] ReadAllResult) {
            this.ReadAllResult = ReadAllResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SchoolWebServiceSoapChannel : ClientProject.SchoolServiceReference.SchoolWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SchoolWebServiceSoapClient : System.ServiceModel.ClientBase<ClientProject.SchoolServiceReference.SchoolWebServiceSoap>, ClientProject.SchoolServiceReference.SchoolWebServiceSoap {
        
        public SchoolWebServiceSoapClient() {
        }
        
        public SchoolWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SchoolWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SchoolWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SchoolWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientProject.SchoolServiceReference.AddResponse ClientProject.SchoolServiceReference.SchoolWebServiceSoap.Add(ClientProject.SchoolServiceReference.AddRequest request) {
            return base.Channel.Add(request);
        }
        
        public int Add(int id, string name) {
            ClientProject.SchoolServiceReference.AddRequest inValue = new ClientProject.SchoolServiceReference.AddRequest();
            inValue.Body = new ClientProject.SchoolServiceReference.AddRequestBody();
            inValue.Body.id = id;
            inValue.Body.name = name;
            ClientProject.SchoolServiceReference.AddResponse retVal = ((ClientProject.SchoolServiceReference.SchoolWebServiceSoap)(this)).Add(inValue);
            return retVal.Body.AddResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientProject.SchoolServiceReference.AddResponse> ClientProject.SchoolServiceReference.SchoolWebServiceSoap.AddAsync(ClientProject.SchoolServiceReference.AddRequest request) {
            return base.Channel.AddAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClientProject.SchoolServiceReference.AddResponse> AddAsync(int id, string name) {
            ClientProject.SchoolServiceReference.AddRequest inValue = new ClientProject.SchoolServiceReference.AddRequest();
            inValue.Body = new ClientProject.SchoolServiceReference.AddRequestBody();
            inValue.Body.id = id;
            inValue.Body.name = name;
            return ((ClientProject.SchoolServiceReference.SchoolWebServiceSoap)(this)).AddAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientProject.SchoolServiceReference.ReadAllResponse ClientProject.SchoolServiceReference.SchoolWebServiceSoap.ReadAll(ClientProject.SchoolServiceReference.ReadAllRequest request) {
            return base.Channel.ReadAll(request);
        }
        
        public ClientProject.SchoolServiceReference.StudentDto[] ReadAll() {
            ClientProject.SchoolServiceReference.ReadAllRequest inValue = new ClientProject.SchoolServiceReference.ReadAllRequest();
            inValue.Body = new ClientProject.SchoolServiceReference.ReadAllRequestBody();
            ClientProject.SchoolServiceReference.ReadAllResponse retVal = ((ClientProject.SchoolServiceReference.SchoolWebServiceSoap)(this)).ReadAll(inValue);
            return retVal.Body.ReadAllResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientProject.SchoolServiceReference.ReadAllResponse> ClientProject.SchoolServiceReference.SchoolWebServiceSoap.ReadAllAsync(ClientProject.SchoolServiceReference.ReadAllRequest request) {
            return base.Channel.ReadAllAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClientProject.SchoolServiceReference.ReadAllResponse> ReadAllAsync() {
            ClientProject.SchoolServiceReference.ReadAllRequest inValue = new ClientProject.SchoolServiceReference.ReadAllRequest();
            inValue.Body = new ClientProject.SchoolServiceReference.ReadAllRequestBody();
            return ((ClientProject.SchoolServiceReference.SchoolWebServiceSoap)(this)).ReadAllAsync(inValue);
        }
    }
}
