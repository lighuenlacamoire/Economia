﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ESIDIFDescripciones.service {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.entidadesBasicas.presupuesto.esidif.mecon.gov.ar", ConfigurationName="service.obtenerDescripcionesEntidadesService")]
    public interface obtenerDescripcionesEntidadesService {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que la operación obtenerDescripcionesEntidades no es RPC ni está encapsulada en un documento.
        [System.ServiceModel.OperationContractAttribute(Action="https://ws-si.mecon.gov.ar/ws/entidades_basicas/obtenerDescripcionesEntidadesServ" +
            "ice", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ESIDIFDescripciones.service.obtenerDescripcionesEntidadesResponse obtenerDescripcionesEntidades(ESIDIFDescripciones.service.obtenerDescripcionesEntidadesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://ws-si.mecon.gov.ar/ws/entidades_basicas/obtenerDescripcionesEntidadesServ" +
            "ice", ReplyAction="*")]
        System.Threading.Tasks.Task<ESIDIFDescripciones.service.obtenerDescripcionesEntidadesResponse> obtenerDescripcionesEntidadesAsync(ESIDIFDescripciones.service.obtenerDescripcionesEntidadesRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3221.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webServices.entidadesBasicas.esidif.mecon.gov.ar")]
    public partial class obtenerDescripcionesEntidadesBean : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string codigoField;
        
        private entidadEnum entidadField;
        
        private bool entidadFieldSpecified;
        
        private long safField;
        
        private bool safFieldSpecified;
        
        private string descripcionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string codigo {
            get {
                return this.codigoField;
            }
            set {
                this.codigoField = value;
                this.RaisePropertyChanged("codigo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public entidadEnum entidad {
            get {
                return this.entidadField;
            }
            set {
                this.entidadField = value;
                this.RaisePropertyChanged("entidad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool entidadSpecified {
            get {
                return this.entidadFieldSpecified;
            }
            set {
                this.entidadFieldSpecified = value;
                this.RaisePropertyChanged("entidadSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public long saf {
            get {
                return this.safField;
            }
            set {
                this.safField = value;
                this.RaisePropertyChanged("saf");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool safSpecified {
            get {
                return this.safFieldSpecified;
            }
            set {
                this.safFieldSpecified = value;
                this.RaisePropertyChanged("safSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
                this.RaisePropertyChanged("descripcion");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3221.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://enums.entidadesBasicas.esidif.mecon.gov.ar")]
    public enum entidadEnum {
        
        /// <remarks/>
        INST,
        
        /// <remarks/>
        SERV,
        
        /// <remarks/>
        APG,
        
        /// <remarks/>
        OG,
        
        /// <remarks/>
        FF,
        
        /// <remarks/>
        MON,
        
        /// <remarks/>
        UG,
        
        /// <remarks/>
        PEX,
        
        /// <remarks/>
        UD,
        
        /// <remarks/>
        BAPIN,
        
        /// <remarks/>
        EDEST,
        
        /// <remarks/>
        ECONCRED,
        
        /// <remarks/>
        FFUN,
        
        /// <remarks/>
        EORIG,
        
        /// <remarks/>
        RUBRO,
        
        /// <remarks/>
        ECONREC,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class obtenerDescripcionesEntidadesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webServices.entidadesBasicas.esidif.mecon.gov.ar", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ESIDIFDescripciones.service.obtenerDescripcionesEntidadesBean[] listaDeCodigos;
        
        public obtenerDescripcionesEntidadesRequest() {
        }
        
        public obtenerDescripcionesEntidadesRequest(ESIDIFDescripciones.service.obtenerDescripcionesEntidadesBean[] listaDeCodigos) {
            this.listaDeCodigos = listaDeCodigos;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class obtenerDescripcionesEntidadesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webServices.entidadesBasicas.esidif.mecon.gov.ar", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ESIDIFDescripciones.service.obtenerDescripcionesEntidadesBean[] obtenerDescripcionesEntidades;
        
        public obtenerDescripcionesEntidadesResponse() {
        }
        
        public obtenerDescripcionesEntidadesResponse(ESIDIFDescripciones.service.obtenerDescripcionesEntidadesBean[] obtenerDescripcionesEntidades) {
            this.obtenerDescripcionesEntidades = obtenerDescripcionesEntidades;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface obtenerDescripcionesEntidadesServiceChannel : ESIDIFDescripciones.service.obtenerDescripcionesEntidadesService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class obtenerDescripcionesEntidadesServiceClient : System.ServiceModel.ClientBase<ESIDIFDescripciones.service.obtenerDescripcionesEntidadesService>, ESIDIFDescripciones.service.obtenerDescripcionesEntidadesService {
        
        public obtenerDescripcionesEntidadesServiceClient() {
        }
        
        public obtenerDescripcionesEntidadesServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public obtenerDescripcionesEntidadesServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public obtenerDescripcionesEntidadesServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public obtenerDescripcionesEntidadesServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ESIDIFDescripciones.service.obtenerDescripcionesEntidadesResponse ESIDIFDescripciones.service.obtenerDescripcionesEntidadesService.obtenerDescripcionesEntidades(ESIDIFDescripciones.service.obtenerDescripcionesEntidadesRequest request) {
            return base.Channel.obtenerDescripcionesEntidades(request);
        }
        
        public ESIDIFDescripciones.service.obtenerDescripcionesEntidadesBean[] obtenerDescripcionesEntidades(ESIDIFDescripciones.service.obtenerDescripcionesEntidadesBean[] listaDeCodigos) {
            ESIDIFDescripciones.service.obtenerDescripcionesEntidadesRequest inValue = new ESIDIFDescripciones.service.obtenerDescripcionesEntidadesRequest();
            inValue.listaDeCodigos = listaDeCodigos;
            ESIDIFDescripciones.service.obtenerDescripcionesEntidadesResponse retVal = ((ESIDIFDescripciones.service.obtenerDescripcionesEntidadesService)(this)).obtenerDescripcionesEntidades(inValue);
            return retVal.obtenerDescripcionesEntidades;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ESIDIFDescripciones.service.obtenerDescripcionesEntidadesResponse> ESIDIFDescripciones.service.obtenerDescripcionesEntidadesService.obtenerDescripcionesEntidadesAsync(ESIDIFDescripciones.service.obtenerDescripcionesEntidadesRequest request) {
            return base.Channel.obtenerDescripcionesEntidadesAsync(request);
        }
        
        public System.Threading.Tasks.Task<ESIDIFDescripciones.service.obtenerDescripcionesEntidadesResponse> obtenerDescripcionesEntidadesAsync(ESIDIFDescripciones.service.obtenerDescripcionesEntidadesBean[] listaDeCodigos) {
            ESIDIFDescripciones.service.obtenerDescripcionesEntidadesRequest inValue = new ESIDIFDescripciones.service.obtenerDescripcionesEntidadesRequest();
            inValue.listaDeCodigos = listaDeCodigos;
            return ((ESIDIFDescripciones.service.obtenerDescripcionesEntidadesService)(this)).obtenerDescripcionesEntidadesAsync(inValue);
        }
    }
}
