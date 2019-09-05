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
    [System.ServiceModel.ServiceContractAttribute(Namespace="https://ws-si.mecon.gov.ar/ws/generarInformeDeGastos", ConfigurationName="service.generarInformeDeGastosPortType")]
    public interface generarInformeDeGastosPortType
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="https://ws-si.mecon.gov.ar/ws/gastos/informeDeGastos/generarInformeDeGastosServic" +
            "e", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<service.generarInformeDeGastosResponse1> generarInformeDeGastosAsync(service.generarInformeDeGastosRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://ws-si.mecon.gov.ar/ws/informeDeGastosMsg")]
    public partial class generarInformeDeGastos
    {
        
        private DatosInicialesInformeDeGastosType datosInicialesInformeDeGastosField;
        
        private GestionExternaEnum gestionExternaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public DatosInicialesInformeDeGastosType datosInicialesInformeDeGastos
        {
            get
            {
                return this.datosInicialesInformeDeGastosField;
            }
            set
            {
                this.datosInicialesInformeDeGastosField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://ws-si.mecon.gov.ar/ws/informeDeGastos")]
    public partial class DatosInicialesInformeDeGastosType
    {
        
        private IdentificacionComprobanteType identificacionComprobanteField;
        
        private string entidadProcesoField;
        
        private IdentificadorDeTramiteType identificadorTramiteField;
        
        private DocumentoRespaldatorioType documentoRespaldatorioField;
        
        private IdentificacionComprobanteType comprobanteOrigenField;
        
        private System.DateTime fechaAutorizacionField;
        
        private System.DateTime fechaComprobanteField;
        
        private System.DateTime fechaRegistroField;
        
        private bool fechaRegistroFieldSpecified;
        
        private int periodoImpactoField;
        
        private bool periodoImpactoFieldSpecified;
        
        private CuentaType cuentaFinanciadoraField;
        
        private bool pagoDirectoField;
        
        private MedioDePagoType medioDePagoField;
        
        private decimal importeCompromisoField;
        
        private decimal importeDevengadoField;
        
        private decimal importePagadoField;
        
        private decimal importeDeduccionesField;
        
        private decimal importeDeduccionesPagadoField;
        
        private decimal importeNetoPagadoField;
        
        private string uepexField;
        
        private string observacionesField;
        
        private ItemPresupuestarioInformeDeGastosType[] itemsPresupuestariosField;
        
        private ItemNoPresupuestarioInformeDeGastosType[] itemsNoPresupuestariosField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public IdentificacionComprobanteType identificacionComprobante
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
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public IdentificacionComprobanteType comprobanteOrigen
        {
            get
            {
                return this.comprobanteOrigenField;
            }
            set
            {
                this.comprobanteOrigenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=5)]
        public System.DateTime fechaAutorizacion
        {
            get
            {
                return this.fechaAutorizacionField;
            }
            set
            {
                this.fechaAutorizacionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=6)]
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=7)]
        public System.DateTime fechaRegistro
        {
            get
            {
                return this.fechaRegistroField;
            }
            set
            {
                this.fechaRegistroField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fechaRegistroSpecified
        {
            get
            {
                return this.fechaRegistroFieldSpecified;
            }
            set
            {
                this.fechaRegistroFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public int periodoImpacto
        {
            get
            {
                return this.periodoImpactoField;
            }
            set
            {
                this.periodoImpactoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool periodoImpactoSpecified
        {
            get
            {
                return this.periodoImpactoFieldSpecified;
            }
            set
            {
                this.periodoImpactoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public CuentaType cuentaFinanciadora
        {
            get
            {
                return this.cuentaFinanciadoraField;
            }
            set
            {
                this.cuentaFinanciadoraField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public bool pagoDirecto
        {
            get
            {
                return this.pagoDirectoField;
            }
            set
            {
                this.pagoDirectoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public decimal importeCompromiso
        {
            get
            {
                return this.importeCompromisoField;
            }
            set
            {
                this.importeCompromisoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public decimal importeDevengado
        {
            get
            {
                return this.importeDevengadoField;
            }
            set
            {
                this.importeDevengadoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public decimal importePagado
        {
            get
            {
                return this.importePagadoField;
            }
            set
            {
                this.importePagadoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public decimal importeDeducciones
        {
            get
            {
                return this.importeDeduccionesField;
            }
            set
            {
                this.importeDeduccionesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=16)]
        public decimal importeDeduccionesPagado
        {
            get
            {
                return this.importeDeduccionesPagadoField;
            }
            set
            {
                this.importeDeduccionesPagadoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=17)]
        public decimal importeNetoPagado
        {
            get
            {
                return this.importeNetoPagadoField;
            }
            set
            {
                this.importeNetoPagadoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=18)]
        public string uepex
        {
            get
            {
                return this.uepexField;
            }
            set
            {
                this.uepexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=19)]
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
        [System.Xml.Serialization.XmlElementAttribute("itemsPresupuestarios", Order=20)]
        public ItemPresupuestarioInformeDeGastosType[] itemsPresupuestarios
        {
            get
            {
                return this.itemsPresupuestariosField;
            }
            set
            {
                this.itemsPresupuestariosField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("itemsNoPresupuestarios", Order=21)]
        public ItemNoPresupuestarioInformeDeGastosType[] itemsNoPresupuestarios
        {
            get
            {
                return this.itemsNoPresupuestariosField;
            }
            set
            {
                this.itemsNoPresupuestariosField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://ws-si.mecon.gov.ar/ws/comprobantes")]
    public partial class IdentificacionComprobanteType
    {
        
        private string tipoComprobanteField;
        
        private long numeroField;
        
        private long ejercicioField;
        
        private string entidadEmisoraField;
        
        private string tipoRegistroField;
        
        private string subTipoRegistroField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://ws-si.mecon.gov.ar/ws/informeDeGastos")]
    public partial class ItemNoPresupuestarioInformeDeGastosType
    {
        
        private long axtField;
        
        private decimal importeDevengadoField;
        
        private decimal importePagadoField;
        
        private long ejercicioField;
        
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
        public decimal importeDevengado
        {
            get
            {
                return this.importeDevengadoField;
            }
            set
            {
                this.importeDevengadoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public decimal importePagado
        {
            get
            {
                return this.importePagadoField;
            }
            set
            {
                this.importePagadoField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://ws-si.mecon.gov.ar/ws/informeDeGastos")]
    public partial class ItemPresupuestarioInformeDeGastosType
    {
        
        private ImputacionPresupuestariaCreditoType imputacionField;
        
        private UnidadDescentralizadaType udField;
        
        private CodigoTramoPartidaType recacField;
        
        private CodigoTramoPartidaType sigadeField;
        
        private decimal importeCompromisoField;
        
        private decimal importeDevengadoField;
        
        private decimal importePagadoField;
        
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
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public decimal importeCompromiso
        {
            get
            {
                return this.importeCompromisoField;
            }
            set
            {
                this.importeCompromisoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public decimal importeDevengado
        {
            get
            {
                return this.importeDevengadoField;
            }
            set
            {
                this.importeDevengadoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public decimal importePagado
        {
            get
            {
                return this.importePagadoField;
            }
            set
            {
                this.importePagadoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://ws-si.mecon.gov.ar/ws/comprobantes")]
    public partial class CuentaType
    {
        
        private long bancoField;
        
        private string sucursalField;
        
        private string cuentaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public long banco
        {
            get
            {
                return this.bancoField;
            }
            set
            {
                this.bancoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string sucursal
        {
            get
            {
                return this.sucursalField;
            }
            set
            {
                this.sucursalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string cuenta
        {
            get
            {
                return this.cuentaField;
            }
            set
            {
                this.cuentaField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://ws-si.mecon.gov.ar/ws/informeDeGastosMsg")]
    public partial class generarInformeDeGastosResponse
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
    public partial class generarInformeDeGastosRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://ws-si.mecon.gov.ar/ws/informeDeGastosMsg", Order=0)]
        public service.generarInformeDeGastos generarInformeDeGastos;
        
        public generarInformeDeGastosRequest()
        {
        }
        
        public generarInformeDeGastosRequest(service.generarInformeDeGastos generarInformeDeGastos)
        {
            this.generarInformeDeGastos = generarInformeDeGastos;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class generarInformeDeGastosResponse1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://ws-si.mecon.gov.ar/ws/informeDeGastosMsg", Order=0)]
        public service.generarInformeDeGastosResponse generarInformeDeGastosResponse;
        
        public generarInformeDeGastosResponse1()
        {
        }
        
        public generarInformeDeGastosResponse1(service.generarInformeDeGastosResponse generarInformeDeGastosResponse)
        {
            this.generarInformeDeGastosResponse = generarInformeDeGastosResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface generarInformeDeGastosPortTypeChannel : service.generarInformeDeGastosPortType, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class generarInformeDeGastosPortTypeClient : System.ServiceModel.ClientBase<service.generarInformeDeGastosPortType>, service.generarInformeDeGastosPortType
    {
        
        public generarInformeDeGastosPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<service.generarInformeDeGastosResponse1> service.generarInformeDeGastosPortType.generarInformeDeGastosAsync(service.generarInformeDeGastosRequest request)
        {
            return base.Channel.generarInformeDeGastosAsync(request);
        }
        
        public System.Threading.Tasks.Task<service.generarInformeDeGastosResponse1> generarInformeDeGastosAsync(service.generarInformeDeGastos generarInformeDeGastos)
        {
            service.generarInformeDeGastosRequest inValue = new service.generarInformeDeGastosRequest();
            inValue.generarInformeDeGastos = generarInformeDeGastos;
            return ((service.generarInformeDeGastosPortType)(this)).generarInformeDeGastosAsync(inValue);
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
