//------------------------------------------------------------------------------
// <generado automáticamente>
//     Este código fue generado por una herramienta.
//     //
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </generado automáticamente>
//------------------------------------------------------------------------------

namespace service
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="https://ws-si.mecon.gov.ar/ws/generarCrgOv", ConfigurationName="service.crgOvPortType")]
    public interface crgOvPortType
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="https://ws-si.mecon.gov.ar/ws/gastos/crg/crgOvService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<service.crgOvResponse1> generarCrgOvAsync(service.crgOvRequest1 request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://ws-si.mecon.gov.ar/ws/comprobantesCrgOvMsg")]
    public partial class crgOvRequest
    {
        
        private CabeceraCRGType cabeceraCrgField;
        
        private ComprobanteVinculoType comprobanteVinculoField;
        
        private string observacionesField;
        
        private object[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public CabeceraCRGType cabeceraCrg
        {
            get
            {
                return this.cabeceraCrgField;
            }
            set
            {
                this.cabeceraCrgField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ComprobanteVinculoType comprobanteVinculo
        {
            get
            {
                return this.comprobanteVinculoField;
            }
            set
            {
                this.comprobanteVinculoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string observaciones
        {
            get
            {
                return this.observacionesField;
            }
            set
            {
                this.observacionesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("itemsNoPresupuestarios", typeof(ItemNoPresupuestarioCRGType), Order=3)]
        [System.Xml.Serialization.XmlElementAttribute("itemsPresupuestarios", typeof(ItemPresupuestarioCRGType), Order=3)]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://ws-si.mecon.gov.ar/ws/comprobantesCrg")]
    public partial class CabeceraCRGType
    {
        
        private GestionExternaEnum gestionExternaField;
        
        private IdentificacionCRGType identificacionComprobanteField;
        
        private object itemField;
        
        private System.DateTime fechaComprobanteField;
        
        private decimal importeMOField;
        
        private decimal importeMCLField;
        
        private CotizacionType cotizacionField;
        
        private long beneficiarioField;
        
        private MedioDePagoType medioDePagoField;
        
        private IdentificadorDeTramiteType identificadorTramiteField;
        
        private DocumentoRespaldatorioType documentoRespaldatorioField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public GestionExternaEnum gestionExterna
        {
            get
            {
                return this.gestionExternaField;
            }
            set
            {
                this.gestionExternaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public IdentificacionCRGType identificacionComprobante
        {
            get
            {
                return this.identificacionComprobanteField;
            }
            set
            {
                this.identificacionComprobanteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fechaRegistro", typeof(System.DateTime), DataType="date", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute("periodoImpacto", typeof(int), Order=2)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=3)]
        public System.DateTime fechaComprobante
        {
            get
            {
                return this.fechaComprobanteField;
            }
            set
            {
                this.fechaComprobanteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public decimal importeMO
        {
            get
            {
                return this.importeMOField;
            }
            set
            {
                this.importeMOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public decimal importeMCL
        {
            get
            {
                return this.importeMCLField;
            }
            set
            {
                this.importeMCLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public CotizacionType cotizacion
        {
            get
            {
                return this.cotizacionField;
            }
            set
            {
                this.cotizacionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public long beneficiario
        {
            get
            {
                return this.beneficiarioField;
            }
            set
            {
                this.beneficiarioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public MedioDePagoType medioDePago
        {
            get
            {
                return this.medioDePagoField;
            }
            set
            {
                this.medioDePagoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public IdentificadorDeTramiteType identificadorTramite
        {
            get
            {
                return this.identificadorTramiteField;
            }
            set
            {
                this.identificadorTramiteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public DocumentoRespaldatorioType documentoRespaldatorio
        {
            get
            {
                return this.documentoRespaldatorioField;
            }
            set
            {
                this.documentoRespaldatorioField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://ws-si.mecon.gov.ar/ws/comprobantes")]
    public enum GestionExternaEnum
    {
        
        /// <remarks/>
        LOYS_2345,
        
        /// <remarks/>
        LOYS_AT,
        
        /// <remarks/>
        GAT,
        
        /// <remarks/>
        UEPEX,
        
        /// <remarks/>
        ANSES,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://ws-si.mecon.gov.ar/ws/comprobantesCrg")]
    public partial class IdentificacionCRGType
    {
        
        private string entidadEmisoraField;
        
        private string entidadProcesoField;
        
        private long numeroField;
        
        private long ejercicioField;
        
        private string tipoComprobanteField;
        
        private string tipoRegistroField;
        
        private string subTipoRegistroField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string entidadEmisora
        {
            get
            {
                return this.entidadEmisoraField;
            }
            set
            {
                this.entidadEmisoraField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string entidadProceso
        {
            get
            {
                return this.entidadProcesoField;
            }
            set
            {
                this.entidadProcesoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public long numero
        {
            get
            {
                return this.numeroField;
            }
            set
            {
                this.numeroField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public long ejercicio
        {
            get
            {
                return this.ejercicioField;
            }
            set
            {
                this.ejercicioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string tipoComprobante
        {
            get
            {
                return this.tipoComprobanteField;
            }
            set
            {
                this.tipoComprobanteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string tipoRegistro
        {
            get
            {
                return this.tipoRegistroField;
            }
            set
            {
                this.tipoRegistroField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string subTipoRegistro
        {
            get
            {
                return this.subTipoRegistroField;
            }
            set
            {
                this.subTipoRegistroField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://ws-si.mecon.gov.ar/ws/comprobantesCrg")]
    public partial class ItemNoPresupuestarioCRGType
    {
        
        private long axtField;
        
        private decimal importeMOField;
        
        private decimal importeMCLField;
        
        private string pexField;
        
        private CodigoTramoPartidaType recacField;
        
        private CodigoTramoPartidaType sigadeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public long axt
        {
            get
            {
                return this.axtField;
            }
            set
            {
                this.axtField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public decimal importeMO
        {
            get
            {
                return this.importeMOField;
            }
            set
            {
                this.importeMOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public decimal importeMCL
        {
            get
            {
                return this.importeMCLField;
            }
            set
            {
                this.importeMCLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string pex
        {
            get
            {
                return this.pexField;
            }
            set
            {
                this.pexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public CodigoTramoPartidaType recac
        {
            get
            {
                return this.recacField;
            }
            set
            {
                this.recacField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public CodigoTramoPartidaType sigade
        {
            get
            {
                return this.sigadeField;
            }
            set
            {
                this.sigadeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://ws-si.mecon.gov.ar/ws/comprobantes")]
    public partial class CodigoTramoPartidaType
    {
        
        private string idField;
        
        private string tramoField;
        
        private string partidaField;
        
        private string codigoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string tramo
        {
            get
            {
                return this.tramoField;
            }
            set
            {
                this.tramoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string partida
        {
            get
            {
                return this.partidaField;
            }
            set
            {
                this.partidaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://ws-si.mecon.gov.ar/ws/comprobantes")]
    public partial class UnidadDescentralizadaType
    {
        
        private string codigoField;
        
        private long ejercicioField;
        
        private bool ejercicioFieldSpecified;
        
        private string safField;
        
        private string descripcionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public long ejercicio
        {
            get
            {
                return this.ejercicioField;
            }
            set
            {
                this.ejercicioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ejercicioSpecified
        {
            get
            {
                return this.ejercicioFieldSpecified;
            }
            set
            {
                this.ejercicioFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string saf
        {
            get
            {
                return this.safField;
            }
            set
            {
                this.safField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string descripcion
        {
            get
            {
                return this.descripcionField;
            }
            set
            {
                this.descripcionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://ws-si.mecon.gov.ar/ws/comprobantes")]
    public partial class ImputacionPresupuestariaCreditoType
    {
        
        private string institucionField;
        
        private long ejercicioField;
        
        private string servicioField;
        
        private string aperturaProgField;
        
        private string objetoGastoField;
        
        private string fuenteField;
        
        private string monedaField;
        
        private string ugField;
        
        private string entidadDestinoField;
        
        private long bapinField;
        
        private bool bapinFieldSpecified;
        
        private long pexField;
        
        private bool pexFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string institucion
        {
            get
            {
                return this.institucionField;
            }
            set
            {
                this.institucionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public long ejercicio
        {
            get
            {
                return this.ejercicioField;
            }
            set
            {
                this.ejercicioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string servicio
        {
            get
            {
                return this.servicioField;
            }
            set
            {
                this.servicioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string aperturaProg
        {
            get
            {
                return this.aperturaProgField;
            }
            set
            {
                this.aperturaProgField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string objetoGasto
        {
            get
            {
                return this.objetoGastoField;
            }
            set
            {
                this.objetoGastoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string fuente
        {
            get
            {
                return this.fuenteField;
            }
            set
            {
                this.fuenteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string moneda
        {
            get
            {
                return this.monedaField;
            }
            set
            {
                this.monedaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string ug
        {
            get
            {
                return this.ugField;
            }
            set
            {
                this.ugField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string entidadDestino
        {
            get
            {
                return this.entidadDestinoField;
            }
            set
            {
                this.entidadDestinoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public long bapin
        {
            get
            {
                return this.bapinField;
            }
            set
            {
                this.bapinField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bapinSpecified
        {
            get
            {
                return this.bapinFieldSpecified;
            }
            set
            {
                this.bapinFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public long pex
        {
            get
            {
                return this.pexField;
            }
            set
            {
                this.pexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pexSpecified
        {
            get
            {
                return this.pexFieldSpecified;
            }
            set
            {
                this.pexFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://ws-si.mecon.gov.ar/ws/comprobantesCrg")]
    public partial class ItemPresupuestarioCRGType
    {
        
        private ImputacionPresupuestariaCreditoType imputacionField;
        
        private long ejercicioField;
        
        private UnidadDescentralizadaType udField;
        
        private decimal importeMOField;
        
        private decimal importeMCLField;
        
        private string cotenaField;
        
        private CodigoTramoPartidaType recacField;
        
        private CodigoTramoPartidaType sigadeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ImputacionPresupuestariaCreditoType imputacion
        {
            get
            {
                return this.imputacionField;
            }
            set
            {
                this.imputacionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public long ejercicio
        {
            get
            {
                return this.ejercicioField;
            }
            set
            {
                this.ejercicioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public UnidadDescentralizadaType ud
        {
            get
            {
                return this.udField;
            }
            set
            {
                this.udField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public decimal importeMO
        {
            get
            {
                return this.importeMOField;
            }
            set
            {
                this.importeMOField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public decimal importeMCL
        {
            get
            {
                return this.importeMCLField;
            }
            set
            {
                this.importeMCLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string cotena
        {
            get
            {
                return this.cotenaField;
            }
            set
            {
                this.cotenaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public CodigoTramoPartidaType recac
        {
            get
            {
                return this.recacField;
            }
            set
            {
                this.recacField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public CodigoTramoPartidaType sigade
        {
            get
            {
                return this.sigadeField;
            }
            set
            {
                this.sigadeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://ws-si.mecon.gov.ar/ws/comprobantesCrg")]
    public partial class ComprobanteVinculoType
    {
        
        private bool marcaInicioVinculoField;
        
        private string tipoOperacionVinculadaField;
        
        private long ejercicioOperacionVinculadaField;
        
        private bool ejercicioOperacionVinculadaFieldSpecified;
        
        private long numeroOperacionVinculadaField;
        
        private bool numeroOperacionVinculadaFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool marcaInicioVinculo
        {
            get
            {
                return this.marcaInicioVinculoField;
            }
            set
            {
                this.marcaInicioVinculoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string tipoOperacionVinculada
        {
            get
            {
                return this.tipoOperacionVinculadaField;
            }
            set
            {
                this.tipoOperacionVinculadaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public long ejercicioOperacionVinculada
        {
            get
            {
                return this.ejercicioOperacionVinculadaField;
            }
            set
            {
                this.ejercicioOperacionVinculadaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ejercicioOperacionVinculadaSpecified
        {
            get
            {
                return this.ejercicioOperacionVinculadaFieldSpecified;
            }
            set
            {
                this.ejercicioOperacionVinculadaFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public long numeroOperacionVinculada
        {
            get
            {
                return this.numeroOperacionVinculadaField;
            }
            set
            {
                this.numeroOperacionVinculadaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numeroOperacionVinculadaSpecified
        {
            get
            {
                return this.numeroOperacionVinculadaFieldSpecified;
            }
            set
            {
                this.numeroOperacionVinculadaFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://ws-si.mecon.gov.ar/ws/comprobantes")]
    public partial class DocumentoRespaldatorioType
    {
        
        private string tipoField;
        
        private long numeroField;
        
        private long ejercicioField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string tipo
        {
            get
            {
                return this.tipoField;
            }
            set
            {
                this.tipoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public long numero
        {
            get
            {
                return this.numeroField;
            }
            set
            {
                this.numeroField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public long ejercicio
        {
            get
            {
                return this.ejercicioField;
            }
            set
            {
                this.ejercicioField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://ws-si.mecon.gov.ar/ws/comprobantes")]
    public partial class IdentificadorDeTramiteType
    {
        
        private string tipoField;
        
        private string identificadorField;
        
        private long anioField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string tipo
        {
            get
            {
                return this.tipoField;
            }
            set
            {
                this.tipoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string identificador
        {
            get
            {
                return this.identificadorField;
            }
            set
            {
                this.identificadorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public long anio
        {
            get
            {
                return this.anioField;
            }
            set
            {
                this.anioField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://ws-si.mecon.gov.ar/ws/comprobantes")]
    public partial class CotizacionType
    {
        
        private TipoCotizacionType tipoCotizacionField;
        
        private bool tipoCotizacionFieldSpecified;
        
        private string tipoMonedaField;
        
        private System.DateTime fechaField;
        
        private bool fechaFieldSpecified;
        
        private decimal valorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public TipoCotizacionType tipoCotizacion
        {
            get
            {
                return this.tipoCotizacionField;
            }
            set
            {
                this.tipoCotizacionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tipoCotizacionSpecified
        {
            get
            {
                return this.tipoCotizacionFieldSpecified;
            }
            set
            {
                this.tipoCotizacionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string tipoMoneda
        {
            get
            {
                return this.tipoMonedaField;
            }
            set
            {
                this.tipoMonedaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=2)]
        public System.DateTime fecha
        {
            get
            {
                return this.fechaField;
            }
            set
            {
                this.fechaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fechaSpecified
        {
            get
            {
                return this.fechaFieldSpecified;
            }
            set
            {
                this.fechaFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public decimal valor
        {
            get
            {
                return this.valorField;
            }
            set
            {
                this.valorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://ws-si.mecon.gov.ar/ws/comprobantes")]
    public enum TipoCotizacionType
    {
        
        /// <remarks/>
        BNA,
        
        /// <remarks/>
        PACTADA,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://ws-si.mecon.gov.ar/ws/comprobantes")]
    public enum MedioDePagoType
    {
        
        /// <remarks/>
        CHE,
        
        /// <remarks/>
        EX,
        
        /// <remarks/>
        DB,
        
        /// <remarks/>
        OV,
        
        /// <remarks/>
        OR,
        
        /// <remarks/>
        BC,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://ws-si.mecon.gov.ar/ws/comprobantesCrgOvMsg")]
    public partial class crgOvResponse
    {
        
        private long numeroSidifField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public long numeroSidif
        {
            get
            {
                return this.numeroSidifField;
            }
            set
            {
                this.numeroSidifField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class crgOvRequest1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://ws-si.mecon.gov.ar/ws/comprobantesCrgOvMsg", Order=0)]
        public service.crgOvRequest crgOvRequest;
        
        public crgOvRequest1()
        {
        }
        
        public crgOvRequest1(service.crgOvRequest crgOvRequest)
        {
            this.crgOvRequest = crgOvRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class crgOvResponse1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://ws-si.mecon.gov.ar/ws/comprobantesCrgOvMsg", Order=0)]
        public service.crgOvResponse crgOvResponse;
        
        public crgOvResponse1()
        {
        }
        
        public crgOvResponse1(service.crgOvResponse crgOvResponse)
        {
            this.crgOvResponse = crgOvResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface crgOvPortTypeChannel : service.crgOvPortType, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class crgOvPortTypeClient : System.ServiceModel.ClientBase<service.crgOvPortType>, service.crgOvPortType
    {
        
        public crgOvPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<service.crgOvResponse1> service.crgOvPortType.generarCrgOvAsync(service.crgOvRequest1 request)
        {
            return base.Channel.generarCrgOvAsync(request);
        }
        
        public System.Threading.Tasks.Task<service.crgOvResponse1> generarCrgOvAsync(service.crgOvRequest crgOvRequest)
        {
            service.crgOvRequest1 inValue = new service.crgOvRequest1();
            inValue.crgOvRequest = crgOvRequest;
            return ((service.crgOvPortType)(this)).generarCrgOvAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
    }
}
