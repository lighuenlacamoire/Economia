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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.imputaciones.common.esidif.mecon.gov.ar", ConfigurationName="service.estadoAcumuladoresCreditoService")]
    public interface estadoAcumuladoresCreditoService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="https://ws-si.mecon.gov.ar/ws/imputaciones_presupuestarias/acumuladoresCreditoInd" +
            "icativaService", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<service.acumuladoresCreditoIndicativaResponse> acumuladoresCreditoIndicativaAsync(service.acumuladoresCreditoIndicativaRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webService.imputacionesPresupuestarias.esidif.mecon.gov.ar")]
    public partial class imputacionCreditoConsulta
    {
        
        private long ejercicioField;
        
        private bool ejercicioFieldSpecified;
        
        private long sectorInstitucionalField;
        
        private bool sectorInstitucionalFieldSpecified;
        
        private long subSectorInstitucionalField;
        
        private bool subSectorInstitucionalFieldSpecified;
        
        private long caracterInstitucionalField;
        
        private bool caracterInstitucionalFieldSpecified;
        
        private long jurisdiccionField;
        
        private bool jurisdiccionFieldSpecified;
        
        private long subJurisdiccionField;
        
        private bool subJurisdiccionFieldSpecified;
        
        private long entidadField;
        
        private bool entidadFieldSpecified;
        
        private long servicioField;
        
        private bool servicioFieldSpecified;
        
        private long programaField;
        
        private bool programaFieldSpecified;
        
        private long subProgramaField;
        
        private bool subProgramaFieldSpecified;
        
        private long proyectoField;
        
        private bool proyectoFieldSpecified;
        
        private long actividadField;
        
        private bool actividadFieldSpecified;
        
        private long obraField;
        
        private bool obraFieldSpecified;
        
        private long incisoField;
        
        private bool incisoFieldSpecified;
        
        private long principalField;
        
        private bool principalFieldSpecified;
        
        private long parcialField;
        
        private bool parcialFieldSpecified;
        
        private long subParcialField;
        
        private bool subParcialFieldSpecified;
        
        private long procedenciaField;
        
        private bool procedenciaFieldSpecified;
        
        private long fuenteField;
        
        private bool fuenteFieldSpecified;
        
        private long monedaField;
        
        private bool monedaFieldSpecified;
        
        private long ubicacionGeograficaField;
        
        private bool ubicacionGeograficaFieldSpecified;
        
        private long entidadOrigenDestinoField;
        
        private bool entidadOrigenDestinoFieldSpecified;
        
        private long prestamoExternoField;
        
        private bool prestamoExternoFieldSpecified;
        
        private long bapinField;
        
        private bool bapinFieldSpecified;
        
        private long finalidadField;
        
        private bool finalidadFieldSpecified;
        
        private long funcionField;
        
        private bool funcionFieldSpecified;
        
        private long clasificadorEconomicoField;
        
        private bool clasificadorEconomicoFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public long sectorInstitucional
        {
            get
            {
                return this.sectorInstitucionalField;
            }
            set
            {
                this.sectorInstitucionalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sectorInstitucionalSpecified
        {
            get
            {
                return this.sectorInstitucionalFieldSpecified;
            }
            set
            {
                this.sectorInstitucionalFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public long subSectorInstitucional
        {
            get
            {
                return this.subSectorInstitucionalField;
            }
            set
            {
                this.subSectorInstitucionalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool subSectorInstitucionalSpecified
        {
            get
            {
                return this.subSectorInstitucionalFieldSpecified;
            }
            set
            {
                this.subSectorInstitucionalFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public long caracterInstitucional
        {
            get
            {
                return this.caracterInstitucionalField;
            }
            set
            {
                this.caracterInstitucionalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool caracterInstitucionalSpecified
        {
            get
            {
                return this.caracterInstitucionalFieldSpecified;
            }
            set
            {
                this.caracterInstitucionalFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public long jurisdiccion
        {
            get
            {
                return this.jurisdiccionField;
            }
            set
            {
                this.jurisdiccionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool jurisdiccionSpecified
        {
            get
            {
                return this.jurisdiccionFieldSpecified;
            }
            set
            {
                this.jurisdiccionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public long subJurisdiccion
        {
            get
            {
                return this.subJurisdiccionField;
            }
            set
            {
                this.subJurisdiccionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool subJurisdiccionSpecified
        {
            get
            {
                return this.subJurisdiccionFieldSpecified;
            }
            set
            {
                this.subJurisdiccionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public long entidad
        {
            get
            {
                return this.entidadField;
            }
            set
            {
                this.entidadField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool entidadSpecified
        {
            get
            {
                return this.entidadFieldSpecified;
            }
            set
            {
                this.entidadFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public long servicio
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool servicioSpecified
        {
            get
            {
                return this.servicioFieldSpecified;
            }
            set
            {
                this.servicioFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public long programa
        {
            get
            {
                return this.programaField;
            }
            set
            {
                this.programaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool programaSpecified
        {
            get
            {
                return this.programaFieldSpecified;
            }
            set
            {
                this.programaFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public long subPrograma
        {
            get
            {
                return this.subProgramaField;
            }
            set
            {
                this.subProgramaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool subProgramaSpecified
        {
            get
            {
                return this.subProgramaFieldSpecified;
            }
            set
            {
                this.subProgramaFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public long proyecto
        {
            get
            {
                return this.proyectoField;
            }
            set
            {
                this.proyectoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool proyectoSpecified
        {
            get
            {
                return this.proyectoFieldSpecified;
            }
            set
            {
                this.proyectoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public long actividad
        {
            get
            {
                return this.actividadField;
            }
            set
            {
                this.actividadField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool actividadSpecified
        {
            get
            {
                return this.actividadFieldSpecified;
            }
            set
            {
                this.actividadFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public long obra
        {
            get
            {
                return this.obraField;
            }
            set
            {
                this.obraField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool obraSpecified
        {
            get
            {
                return this.obraFieldSpecified;
            }
            set
            {
                this.obraFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public long inciso
        {
            get
            {
                return this.incisoField;
            }
            set
            {
                this.incisoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool incisoSpecified
        {
            get
            {
                return this.incisoFieldSpecified;
            }
            set
            {
                this.incisoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public long principal
        {
            get
            {
                return this.principalField;
            }
            set
            {
                this.principalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool principalSpecified
        {
            get
            {
                return this.principalFieldSpecified;
            }
            set
            {
                this.principalFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public long parcial
        {
            get
            {
                return this.parcialField;
            }
            set
            {
                this.parcialField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool parcialSpecified
        {
            get
            {
                return this.parcialFieldSpecified;
            }
            set
            {
                this.parcialFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=16)]
        public long subParcial
        {
            get
            {
                return this.subParcialField;
            }
            set
            {
                this.subParcialField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool subParcialSpecified
        {
            get
            {
                return this.subParcialFieldSpecified;
            }
            set
            {
                this.subParcialFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=17)]
        public long procedencia
        {
            get
            {
                return this.procedenciaField;
            }
            set
            {
                this.procedenciaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool procedenciaSpecified
        {
            get
            {
                return this.procedenciaFieldSpecified;
            }
            set
            {
                this.procedenciaFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=18)]
        public long fuente
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fuenteSpecified
        {
            get
            {
                return this.fuenteFieldSpecified;
            }
            set
            {
                this.fuenteFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=19)]
        public long moneda
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool monedaSpecified
        {
            get
            {
                return this.monedaFieldSpecified;
            }
            set
            {
                this.monedaFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=20)]
        public long ubicacionGeografica
        {
            get
            {
                return this.ubicacionGeograficaField;
            }
            set
            {
                this.ubicacionGeograficaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ubicacionGeograficaSpecified
        {
            get
            {
                return this.ubicacionGeograficaFieldSpecified;
            }
            set
            {
                this.ubicacionGeograficaFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=21)]
        public long entidadOrigenDestino
        {
            get
            {
                return this.entidadOrigenDestinoField;
            }
            set
            {
                this.entidadOrigenDestinoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool entidadOrigenDestinoSpecified
        {
            get
            {
                return this.entidadOrigenDestinoFieldSpecified;
            }
            set
            {
                this.entidadOrigenDestinoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=22)]
        public long prestamoExterno
        {
            get
            {
                return this.prestamoExternoField;
            }
            set
            {
                this.prestamoExternoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool prestamoExternoSpecified
        {
            get
            {
                return this.prestamoExternoFieldSpecified;
            }
            set
            {
                this.prestamoExternoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=23)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=24)]
        public long finalidad
        {
            get
            {
                return this.finalidadField;
            }
            set
            {
                this.finalidadField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool finalidadSpecified
        {
            get
            {
                return this.finalidadFieldSpecified;
            }
            set
            {
                this.finalidadFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=25)]
        public long funcion
        {
            get
            {
                return this.funcionField;
            }
            set
            {
                this.funcionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool funcionSpecified
        {
            get
            {
                return this.funcionFieldSpecified;
            }
            set
            {
                this.funcionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=26)]
        public long clasificadorEconomico
        {
            get
            {
                return this.clasificadorEconomicoField;
            }
            set
            {
                this.clasificadorEconomicoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool clasificadorEconomicoSpecified
        {
            get
            {
                return this.clasificadorEconomicoFieldSpecified;
            }
            set
            {
                this.clasificadorEconomicoFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webService.imputacionesPresupuestarias.esidif.mecon.gov.ar")]
    public partial class acumuladoresCreditoConsulta
    {
        
        private decimal compromisoField;
        
        private bool compromisoFieldSpecified;
        
        private decimal creditoInicialEjercicioField;
        
        private bool creditoInicialEjercicioFieldSpecified;
        
        private decimal creditoInicialProrrogaField;
        
        private bool creditoInicialProrrogaFieldSpecified;
        
        private decimal creditoPotencialField;
        
        private bool creditoPotencialFieldSpecified;
        
        private decimal creditoRestringidoField;
        
        private bool creditoRestringidoFieldSpecified;
        
        private decimal creditoVigenteField;
        
        private bool creditoVigenteFieldSpecified;
        
        private decimal devengadoField;
        
        private bool devengadoFieldSpecified;
        
        private decimal gastoPreventivoField;
        
        private bool gastoPreventivoFieldSpecified;
        
        private decimal pagadoField;
        
        private bool pagadoFieldSpecified;
        
        private decimal pagadoFinancieroField;
        
        private bool pagadoFinancieroFieldSpecified;
        
        private decimal reservaCompromisoField;
        
        private bool reservaCompromisoFieldSpecified;
        
        private decimal reservaDevengadoField;
        
        private bool reservaDevengadoFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public decimal compromiso
        {
            get
            {
                return this.compromisoField;
            }
            set
            {
                this.compromisoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool compromisoSpecified
        {
            get
            {
                return this.compromisoFieldSpecified;
            }
            set
            {
                this.compromisoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public decimal creditoInicialEjercicio
        {
            get
            {
                return this.creditoInicialEjercicioField;
            }
            set
            {
                this.creditoInicialEjercicioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool creditoInicialEjercicioSpecified
        {
            get
            {
                return this.creditoInicialEjercicioFieldSpecified;
            }
            set
            {
                this.creditoInicialEjercicioFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public decimal creditoInicialProrroga
        {
            get
            {
                return this.creditoInicialProrrogaField;
            }
            set
            {
                this.creditoInicialProrrogaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool creditoInicialProrrogaSpecified
        {
            get
            {
                return this.creditoInicialProrrogaFieldSpecified;
            }
            set
            {
                this.creditoInicialProrrogaFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public decimal creditoPotencial
        {
            get
            {
                return this.creditoPotencialField;
            }
            set
            {
                this.creditoPotencialField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool creditoPotencialSpecified
        {
            get
            {
                return this.creditoPotencialFieldSpecified;
            }
            set
            {
                this.creditoPotencialFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public decimal creditoRestringido
        {
            get
            {
                return this.creditoRestringidoField;
            }
            set
            {
                this.creditoRestringidoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool creditoRestringidoSpecified
        {
            get
            {
                return this.creditoRestringidoFieldSpecified;
            }
            set
            {
                this.creditoRestringidoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public decimal creditoVigente
        {
            get
            {
                return this.creditoVigenteField;
            }
            set
            {
                this.creditoVigenteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool creditoVigenteSpecified
        {
            get
            {
                return this.creditoVigenteFieldSpecified;
            }
            set
            {
                this.creditoVigenteFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public decimal devengado
        {
            get
            {
                return this.devengadoField;
            }
            set
            {
                this.devengadoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool devengadoSpecified
        {
            get
            {
                return this.devengadoFieldSpecified;
            }
            set
            {
                this.devengadoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public decimal gastoPreventivo
        {
            get
            {
                return this.gastoPreventivoField;
            }
            set
            {
                this.gastoPreventivoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool gastoPreventivoSpecified
        {
            get
            {
                return this.gastoPreventivoFieldSpecified;
            }
            set
            {
                this.gastoPreventivoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public decimal pagado
        {
            get
            {
                return this.pagadoField;
            }
            set
            {
                this.pagadoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pagadoSpecified
        {
            get
            {
                return this.pagadoFieldSpecified;
            }
            set
            {
                this.pagadoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public decimal pagadoFinanciero
        {
            get
            {
                return this.pagadoFinancieroField;
            }
            set
            {
                this.pagadoFinancieroField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pagadoFinancieroSpecified
        {
            get
            {
                return this.pagadoFinancieroFieldSpecified;
            }
            set
            {
                this.pagadoFinancieroFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public decimal reservaCompromiso
        {
            get
            {
                return this.reservaCompromisoField;
            }
            set
            {
                this.reservaCompromisoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool reservaCompromisoSpecified
        {
            get
            {
                return this.reservaCompromisoFieldSpecified;
            }
            set
            {
                this.reservaCompromisoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public decimal reservaDevengado
        {
            get
            {
                return this.reservaDevengadoField;
            }
            set
            {
                this.reservaDevengadoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool reservaDevengadoSpecified
        {
            get
            {
                return this.reservaDevengadoFieldSpecified;
            }
            set
            {
                this.reservaDevengadoFieldSpecified = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class acumuladoresCreditoIndicativaRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webService.imputacionesPresupuestarias.esidif.mecon.gov.ar", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public service.imputacionCreditoConsulta imputacionCreditoConsulta;
        
        public acumuladoresCreditoIndicativaRequest()
        {
        }
        
        public acumuladoresCreditoIndicativaRequest(service.imputacionCreditoConsulta imputacionCreditoConsulta)
        {
            this.imputacionCreditoConsulta = imputacionCreditoConsulta;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class acumuladoresCreditoIndicativaResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webService.imputacionesPresupuestarias.esidif.mecon.gov.ar", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public service.acumuladoresCreditoConsulta acumuladoresCreditoIndicativa;
        
        public acumuladoresCreditoIndicativaResponse()
        {
        }
        
        public acumuladoresCreditoIndicativaResponse(service.acumuladoresCreditoConsulta acumuladoresCreditoIndicativa)
        {
            this.acumuladoresCreditoIndicativa = acumuladoresCreditoIndicativa;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface estadoAcumuladoresCreditoServiceChannel : service.estadoAcumuladoresCreditoService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class estadoAcumuladoresCreditoServiceClient : System.ServiceModel.ClientBase<service.estadoAcumuladoresCreditoService>, service.estadoAcumuladoresCreditoService
    {
        
        public estadoAcumuladoresCreditoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<service.acumuladoresCreditoIndicativaResponse> service.estadoAcumuladoresCreditoService.acumuladoresCreditoIndicativaAsync(service.acumuladoresCreditoIndicativaRequest request)
        {
            return base.Channel.acumuladoresCreditoIndicativaAsync(request);
        }
        
        public System.Threading.Tasks.Task<service.acumuladoresCreditoIndicativaResponse> acumuladoresCreditoIndicativaAsync(service.imputacionCreditoConsulta imputacionCreditoConsulta)
        {
            service.acumuladoresCreditoIndicativaRequest inValue = new service.acumuladoresCreditoIndicativaRequest();
            inValue.imputacionCreditoConsulta = imputacionCreditoConsulta;
            return ((service.estadoAcumuladoresCreditoService)(this)).acumuladoresCreditoIndicativaAsync(inValue);
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
