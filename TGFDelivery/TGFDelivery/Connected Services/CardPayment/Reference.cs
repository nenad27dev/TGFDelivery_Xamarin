﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CardPayment
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CardPayment.ICardPayment")]
    public interface ICardPayment
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICardPayment/SearchTransaction", ReplyAction="http://tempuri.org/ICardPayment/SearchTransactionResponse")]
        System.Threading.Tasks.Task<WinPizzaData.WPTransaction[]> SearchTransactionAsync(string storeName, System.DateTime Min, System.DateTime Max, string[] TStatus);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICardPayment/GetTransactionToday", ReplyAction="http://tempuri.org/ICardPayment/GetTransactionTodayResponse")]
        System.Threading.Tasks.Task<WinPizzaData.WPTransaction[]> GetTransactionTodayAsync(string OrderRef, string[] TrsStatus);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICardPayment/SearchDisbursement", ReplyAction="http://tempuri.org/ICardPayment/SearchDisbursementResponse")]
        System.Threading.Tasks.Task<WinPizzaData.WPTransaction[]> SearchDisbursementAsync(string OrderRef, System.DateTime Min, System.DateTime Max);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICardPayment/GetClientBrainteeToken", ReplyAction="http://tempuri.org/ICardPayment/GetClientBrainteeTokenResponse")]
        System.Threading.Tasks.Task<string> GetClientBrainteeTokenAsync(string Data);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface ICardPaymentChannel : CardPayment.ICardPayment, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class CardPaymentClient : System.ServiceModel.ClientBase<CardPayment.ICardPayment>, CardPayment.ICardPayment
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public CardPaymentClient(EndpointConfiguration endpointConfiguration) : 
                base(CardPaymentClient.GetBindingForEndpoint(endpointConfiguration), CardPaymentClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CardPaymentClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(CardPaymentClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CardPaymentClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(CardPaymentClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CardPaymentClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<WinPizzaData.WPTransaction[]> SearchTransactionAsync(string storeName, System.DateTime Min, System.DateTime Max, string[] TStatus)
        {
            return base.Channel.SearchTransactionAsync(storeName, Min, Max, TStatus);
        }
        
        public System.Threading.Tasks.Task<WinPizzaData.WPTransaction[]> GetTransactionTodayAsync(string OrderRef, string[] TrsStatus)
        {
            return base.Channel.GetTransactionTodayAsync(OrderRef, TrsStatus);
        }
        
        public System.Threading.Tasks.Task<WinPizzaData.WPTransaction[]> SearchDisbursementAsync(string OrderRef, System.DateTime Min, System.DateTime Max)
        {
            return base.Channel.SearchDisbursementAsync(OrderRef, Min, Max);
        }
        
        public System.Threading.Tasks.Task<string> GetClientBrainteeTokenAsync(string Data)
        {
            return base.Channel.GetClientBrainteeTokenAsync(Data);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ICardPayment))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpsBinding_ICardPayment))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ICardPayment))
            {
                return new System.ServiceModel.EndpointAddress("http://www.korush.eu/BraintreeReporting/CardPayment.svc");
            }
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpsBinding_ICardPayment))
            {
                return new System.ServiceModel.EndpointAddress("https://www.korush.eu/BraintreeReporting/CardPayment.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_ICardPayment,
            
            BasicHttpsBinding_ICardPayment,
        }
    }
}