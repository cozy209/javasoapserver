﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//
//     Les changements apportés à ce fichier peuvent provoquer un comportement incorrect et seront perdus si
//     le code est regénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelServiceReference
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://0.0.0.0:9999/ws", ConfigurationName="HotelServiceReference.HotelService")]
    public interface HotelService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://0.0.0.0:9999/ws/HotelService/getHotelsRequest", ReplyAction="http://0.0.0.0:9999/ws/HotelService/getHotelsResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<HotelServiceReference.getHotelsResponse> getHotelsAsync(HotelServiceReference.getHotelsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://0.0.0.0:9999/ws/HotelService/getRoomsForRequest", ReplyAction="http://0.0.0.0:9999/ws/HotelService/getRoomsForResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<HotelServiceReference.getRoomsForResponse> getRoomsForAsync(HotelServiceReference.getRoomsForRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://0.0.0.0:9999/ws/HotelService/bookRequest", ReplyAction="http://0.0.0.0:9999/ws/HotelService/bookResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<HotelServiceReference.bookResponse> bookAsync(HotelServiceReference.bookRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://0.0.0.0:9999/ws/HotelService/cancelBookingRequest", ReplyAction="http://0.0.0.0:9999/ws/HotelService/cancelBookingResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<HotelServiceReference.cancelBookingResponse> cancelBookingAsync(HotelServiceReference.cancelBookingRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://0.0.0.0:9999/ws")]
    public partial class hotel
    {
        
        private string nameField;
        
        private room[] roomsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("rooms", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=1)]
        public room[] rooms
        {
            get
            {
                return this.roomsField;
            }
            set
            {
                this.roomsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://0.0.0.0:9999/ws")]
    public partial class room
    {
        
        private int roomNumberField;
        
        private category categoryField;
        
        private bool categoryFieldSpecified;
        
        private bool availableField;
        
        private float priceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int roomNumber
        {
            get
            {
                return this.roomNumberField;
            }
            set
            {
                this.roomNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public category category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool categorySpecified
        {
            get
            {
                return this.categoryFieldSpecified;
            }
            set
            {
                this.categoryFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public bool available
        {
            get
            {
                return this.availableField;
            }
            set
            {
                this.availableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public float price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://0.0.0.0:9999/ws")]
    public enum category
    {
        
        /// <remarks/>
        SINGLE,
        
        /// <remarks/>
        DOUBLE,
        
        /// <remarks/>
        SUITE,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getHotels", WrapperNamespace="http://0.0.0.0:9999/ws", IsWrapped=true)]
    public partial class getHotelsRequest
    {
        
        public getHotelsRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getHotelsResponse", WrapperNamespace="http://0.0.0.0:9999/ws", IsWrapped=true)]
    public partial class getHotelsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://0.0.0.0:9999/ws", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public HotelServiceReference.hotel[] @return;
        
        public getHotelsResponse()
        {
        }
        
        public getHotelsResponse(HotelServiceReference.hotel[] @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getRoomsFor", WrapperNamespace="http://0.0.0.0:9999/ws", IsWrapped=true)]
    public partial class getRoomsForRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://0.0.0.0:9999/ws", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public HotelServiceReference.hotel arg0;
        
        public getRoomsForRequest()
        {
        }
        
        public getRoomsForRequest(HotelServiceReference.hotel arg0)
        {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getRoomsForResponse", WrapperNamespace="http://0.0.0.0:9999/ws", IsWrapped=true)]
    public partial class getRoomsForResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://0.0.0.0:9999/ws", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public HotelServiceReference.room[] @return;
        
        public getRoomsForResponse()
        {
        }
        
        public getRoomsForResponse(HotelServiceReference.room[] @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="book", WrapperNamespace="http://0.0.0.0:9999/ws", IsWrapped=true)]
    public partial class bookRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://0.0.0.0:9999/ws", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public HotelServiceReference.room arg0;
        
        public bookRequest()
        {
        }
        
        public bookRequest(HotelServiceReference.room arg0)
        {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="bookResponse", WrapperNamespace="http://0.0.0.0:9999/ws", IsWrapped=true)]
    public partial class bookResponse
    {
        
        public bookResponse()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="cancelBooking", WrapperNamespace="http://0.0.0.0:9999/ws", IsWrapped=true)]
    public partial class cancelBookingRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://0.0.0.0:9999/ws", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public HotelServiceReference.room arg0;
        
        public cancelBookingRequest()
        {
        }
        
        public cancelBookingRequest(HotelServiceReference.room arg0)
        {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="cancelBookingResponse", WrapperNamespace="http://0.0.0.0:9999/ws", IsWrapped=true)]
    public partial class cancelBookingResponse
    {
        
        public cancelBookingResponse()
        {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface HotelServiceChannel : HotelServiceReference.HotelService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class HotelServiceClient : System.ServiceModel.ClientBase<HotelServiceReference.HotelService>, HotelServiceReference.HotelService
    {
        
        /// <summary>
        /// Implémentez cette méthode partielle pour configurer le point de terminaison de service.
        /// </summary>
        /// <param name="serviceEndpoint">Point de terminaison à configurer</param>
        /// <param name="clientCredentials">Informations d'identification du client</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public HotelServiceClient() : 
                base(HotelServiceClient.GetDefaultBinding(), HotelServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.HotelServicePort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public HotelServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(HotelServiceClient.GetBindingForEndpoint(endpointConfiguration), HotelServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public HotelServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(HotelServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public HotelServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(HotelServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public HotelServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HotelServiceReference.getHotelsResponse> HotelServiceReference.HotelService.getHotelsAsync(HotelServiceReference.getHotelsRequest request)
        {
            return base.Channel.getHotelsAsync(request);
        }
        
        public System.Threading.Tasks.Task<HotelServiceReference.getHotelsResponse> getHotelsAsync()
        {
            HotelServiceReference.getHotelsRequest inValue = new HotelServiceReference.getHotelsRequest();
            return ((HotelServiceReference.HotelService)(this)).getHotelsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HotelServiceReference.getRoomsForResponse> HotelServiceReference.HotelService.getRoomsForAsync(HotelServiceReference.getRoomsForRequest request)
        {
            return base.Channel.getRoomsForAsync(request);
        }
        
        public System.Threading.Tasks.Task<HotelServiceReference.getRoomsForResponse> getRoomsForAsync(HotelServiceReference.hotel arg0)
        {
            HotelServiceReference.getRoomsForRequest inValue = new HotelServiceReference.getRoomsForRequest();
            inValue.arg0 = arg0;
            return ((HotelServiceReference.HotelService)(this)).getRoomsForAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HotelServiceReference.bookResponse> HotelServiceReference.HotelService.bookAsync(HotelServiceReference.bookRequest request)
        {
            return base.Channel.bookAsync(request);
        }
        
        public System.Threading.Tasks.Task<HotelServiceReference.bookResponse> bookAsync(HotelServiceReference.room arg0)
        {
            HotelServiceReference.bookRequest inValue = new HotelServiceReference.bookRequest();
            inValue.arg0 = arg0;
            return ((HotelServiceReference.HotelService)(this)).bookAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HotelServiceReference.cancelBookingResponse> HotelServiceReference.HotelService.cancelBookingAsync(HotelServiceReference.cancelBookingRequest request)
        {
            return base.Channel.cancelBookingAsync(request);
        }
        
        public System.Threading.Tasks.Task<HotelServiceReference.cancelBookingResponse> cancelBookingAsync(HotelServiceReference.room arg0)
        {
            HotelServiceReference.cancelBookingRequest inValue = new HotelServiceReference.cancelBookingRequest();
            inValue.arg0 = arg0;
            return ((HotelServiceReference.HotelService)(this)).cancelBookingAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.HotelServicePort))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Le point de terminaison nommé \'{0}\' est introuvable.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.HotelServicePort))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:9999/ws/hotels");
            }
            throw new System.InvalidOperationException(string.Format("Le point de terminaison nommé \'{0}\' est introuvable.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return HotelServiceClient.GetBindingForEndpoint(EndpointConfiguration.HotelServicePort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return HotelServiceClient.GetEndpointAddress(EndpointConfiguration.HotelServicePort);
        }
        
        public enum EndpointConfiguration
        {
            
            HotelServicePort,
        }
    }
}
