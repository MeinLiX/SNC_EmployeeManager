﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeServiceRef
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResponseOfArrayOfEmployeeModelktKz5VpS", Namespace="http://schemas.datacontract.org/2004/07/SNC_WCFService.Services")]
    public partial class ResponseOfArrayOfEmployeeModelktKz5VpS : object
    {
        
        private EmployeeServiceRef.EmployeeModel[] DataField;
        
        private System.Exception ExceptionField;
        
        private bool SuccessField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public EmployeeServiceRef.EmployeeModel[] Data
        {
            get
            {
                return this.DataField;
            }
            set
            {
                this.DataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Exception Exception
        {
            get
            {
                return this.ExceptionField;
            }
            set
            {
                this.ExceptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Success
        {
            get
            {
                return this.SuccessField;
            }
            set
            {
                this.SuccessField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EmployeeModel", Namespace="http://schemas.datacontract.org/2004/07/SNC_WCFService.Models")]
    public partial class EmployeeModel : object
    {
        
        private System.DateTime CreateDateField;
        
        private int DRFOField;
        
        private string EmailField;
        
        private string FirstNameField;
        
        private System.Guid IDField;
        
        private string LastNameField;
        
        private string PatronymicField;
        
        private string PhoneNumberField;
        
        private System.DateTime UpdateDateField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreateDate
        {
            get
            {
                return this.CreateDateField;
            }
            set
            {
                this.CreateDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DRFO
        {
            get
            {
                return this.DRFOField;
            }
            set
            {
                this.DRFOField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName
        {
            get
            {
                return this.FirstNameField;
            }
            set
            {
                this.FirstNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid ID
        {
            get
            {
                return this.IDField;
            }
            set
            {
                this.IDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName
        {
            get
            {
                return this.LastNameField;
            }
            set
            {
                this.LastNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Patronymic
        {
            get
            {
                return this.PatronymicField;
            }
            set
            {
                this.PatronymicField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneNumber
        {
            get
            {
                return this.PhoneNumberField;
            }
            set
            {
                this.PhoneNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime UpdateDate
        {
            get
            {
                return this.UpdateDateField;
            }
            set
            {
                this.UpdateDateField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResponseOfstring", Namespace="http://schemas.datacontract.org/2004/07/SNC_WCFService.Services")]
    public partial class ResponseOfstring : object
    {
        
        private string DataField;
        
        private System.Exception ExceptionField;
        
        private bool SuccessField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Data
        {
            get
            {
                return this.DataField;
            }
            set
            {
                this.DataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Exception Exception
        {
            get
            {
                return this.ExceptionField;
            }
            set
            {
                this.ExceptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Success
        {
            get
            {
                return this.SuccessField;
            }
            set
            {
                this.SuccessField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeServiceRef.IEmployeeService")]
    public interface IEmployeeService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetEmpoyes", ReplyAction="http://tempuri.org/IEmployeeService/GetEmpoyesResponse")]
        System.Threading.Tasks.Task<EmployeeServiceRef.ResponseOfArrayOfEmployeeModelktKz5VpS> GetEmpoyesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/AddEmpoyee", ReplyAction="http://tempuri.org/IEmployeeService/AddEmpoyeeResponse")]
        System.Threading.Tasks.Task<EmployeeServiceRef.ResponseOfstring> AddEmpoyeeAsync(EmployeeServiceRef.EmployeeModel employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/UpdateEmpoyee", ReplyAction="http://tempuri.org/IEmployeeService/UpdateEmpoyeeResponse")]
        System.Threading.Tasks.Task<EmployeeServiceRef.ResponseOfstring> UpdateEmpoyeeAsync(EmployeeServiceRef.EmployeeModel employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/DeleteEmpoyee", ReplyAction="http://tempuri.org/IEmployeeService/DeleteEmpoyeeResponse")]
        System.Threading.Tasks.Task<EmployeeServiceRef.ResponseOfstring> DeleteEmpoyeeAsync(System.Guid id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface IEmployeeServiceChannel : EmployeeServiceRef.IEmployeeService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class EmployeeServiceClient : System.ServiceModel.ClientBase<EmployeeServiceRef.IEmployeeService>, EmployeeServiceRef.IEmployeeService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public EmployeeServiceClient() : 
                base(EmployeeServiceClient.GetDefaultBinding(), EmployeeServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IEmployeeService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public EmployeeServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(EmployeeServiceClient.GetBindingForEndpoint(endpointConfiguration), EmployeeServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public EmployeeServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(EmployeeServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public EmployeeServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(EmployeeServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public EmployeeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<EmployeeServiceRef.ResponseOfArrayOfEmployeeModelktKz5VpS> GetEmpoyesAsync()
        {
            return base.Channel.GetEmpoyesAsync();
        }
        
        public System.Threading.Tasks.Task<EmployeeServiceRef.ResponseOfstring> AddEmpoyeeAsync(EmployeeServiceRef.EmployeeModel employee)
        {
            return base.Channel.AddEmpoyeeAsync(employee);
        }
        
        public System.Threading.Tasks.Task<EmployeeServiceRef.ResponseOfstring> UpdateEmpoyeeAsync(EmployeeServiceRef.EmployeeModel employee)
        {
            return base.Channel.UpdateEmpoyeeAsync(employee);
        }
        
        public System.Threading.Tasks.Task<EmployeeServiceRef.ResponseOfstring> DeleteEmpoyeeAsync(System.Guid id)
        {
            return base.Channel.DeleteEmpoyeeAsync(id);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IEmployeeService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IEmployeeService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:55984/Services/EmployeeService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return EmployeeServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IEmployeeService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return EmployeeServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IEmployeeService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IEmployeeService,
        }
    }
}
