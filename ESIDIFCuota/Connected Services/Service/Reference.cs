//------------------------------------------------------------------------------
// <generado automáticamente>
//     Este código fue generado por una herramienta.
//     //
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </generado automáticamente>
//------------------------------------------------------------------------------

namespace Service
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:sap-com:document:sap:soap:functions:mc-style", ConfigurationName="Service.ZWS_CUOTA")]
    public interface ZWS_CUOTA
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:sap-com:document:sap:soap:functions:mc-style:ZWS_CUOTA:ZfmWsCuotaRequest", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Service.ZfmWsCuotaResponse1> ZfmWsCuotaAsync(Service.ZfmWsCuotaRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class ZfmWsCuota
    {
        
        private ZdsCuotaCabecera iCabeceraField;
        
        private string iCuilUserField;
        
        private string iIpUserField;
        
        private ZdsEntradasCuota[] itEntradaCuotaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public ZdsCuotaCabecera ICabecera
        {
            get
            {
                return this.iCabeceraField;
            }
            set
            {
                this.iCabeceraField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string ICuilUser
        {
            get
            {
                return this.iCuilUserField;
            }
            set
            {
                this.iCuilUserField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string IIpUser
        {
            get
            {
                return this.iIpUserField;
            }
            set
            {
                this.iIpUserField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public ZdsEntradasCuota[] ItEntradaCuota
        {
            get
            {
                return this.itEntradaCuotaField;
            }
            set
            {
                this.itEntradaCuotaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class ZdsCuotaCabecera
    {
        
        private string fechaenvioField;
        
        private string tipocomprobanteField;
        
        private string ejercicioField;
        
        private string numerocomprobanteField;
        
        private string periodoField;
        
        private string entidademisoraField;
        
        private string entidadprocesoField;
        
        private string estadoField;
        
        private string fechaaplicacionField;
        
        private string ejercicioactoadmField;
        
        private string numeroactoadmField;
        
        private string tipoactoadmField;
        
        private string fechaactoadmField;
        
        private string codigoconceptoField;
        
        private string descripcionconceptoField;
        
        private string identificaciontramiteField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string Fechaenvio
        {
            get
            {
                return this.fechaenvioField;
            }
            set
            {
                this.fechaenvioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string Tipocomprobante
        {
            get
            {
                return this.tipocomprobanteField;
            }
            set
            {
                this.tipocomprobanteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string Ejercicio
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string Numerocomprobante
        {
            get
            {
                return this.numerocomprobanteField;
            }
            set
            {
                this.numerocomprobanteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string Periodo
        {
            get
            {
                return this.periodoField;
            }
            set
            {
                this.periodoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string Entidademisora
        {
            get
            {
                return this.entidademisoraField;
            }
            set
            {
                this.entidademisoraField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string Entidadproceso
        {
            get
            {
                return this.entidadprocesoField;
            }
            set
            {
                this.entidadprocesoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string Estado
        {
            get
            {
                return this.estadoField;
            }
            set
            {
                this.estadoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string Fechaaplicacion
        {
            get
            {
                return this.fechaaplicacionField;
            }
            set
            {
                this.fechaaplicacionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string Ejercicioactoadm
        {
            get
            {
                return this.ejercicioactoadmField;
            }
            set
            {
                this.ejercicioactoadmField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string Numeroactoadm
        {
            get
            {
                return this.numeroactoadmField;
            }
            set
            {
                this.numeroactoadmField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public string Tipoactoadm
        {
            get
            {
                return this.tipoactoadmField;
            }
            set
            {
                this.tipoactoadmField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public string Fechaactoadm
        {
            get
            {
                return this.fechaactoadmField;
            }
            set
            {
                this.fechaactoadmField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public string Codigoconcepto
        {
            get
            {
                return this.codigoconceptoField;
            }
            set
            {
                this.codigoconceptoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public string Descripcionconcepto
        {
            get
            {
                return this.descripcionconceptoField;
            }
            set
            {
                this.descripcionconceptoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public string Identificaciontramite
        {
            get
            {
                return this.identificaciontramiteField;
            }
            set
            {
                this.identificaciontramiteField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class ZdsWsPresupOutput
    {
        
        private string typeField;
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class ZdsEntradasCuota
    {
        
        private string sectorField;
        
        private string subsectorField;
        
        private string caracterField;
        
        private string jurisdiccionField;
        
        private string subjurisdiccionField;
        
        private string entidadField;
        
        private string safField;
        
        private string programaField;
        
        private string subprogramaField;
        
        private string proyectoField;
        
        private string actividadField;
        
        private string obraField;
        
        private string incisoField;
        
        private string principalField;
        
        private string parcialField;
        
        private string subparcialField;
        
        private string procedenciaField;
        
        private string fuenteField;
        
        private string compromisoinicialField;
        
        private string compromisovigenteField;
        
        private string compromisorestringidoField;
        
        private string devengadoinicial1Field;
        
        private string devengadovigente1Field;
        
        private string devengadorestringido1Field;
        
        private string devengadoinicial2Field;
        
        private string devengadovigente2Field;
        
        private string devengadorestringido2Field;
        
        private string devengadoinicial3Field;
        
        private string devengadovigente3Field;
        
        private string devengadorestringido3Field;
        
        private string compromisocomprobanteField;
        
        private string devengado1comprobanteField;
        
        private string devengado2comprobanteField;
        
        private string devengado3comprobanteField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string Sector
        {
            get
            {
                return this.sectorField;
            }
            set
            {
                this.sectorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string Subsector
        {
            get
            {
                return this.subsectorField;
            }
            set
            {
                this.subsectorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string Caracter
        {
            get
            {
                return this.caracterField;
            }
            set
            {
                this.caracterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string Jurisdiccion
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string Subjurisdiccion
        {
            get
            {
                return this.subjurisdiccionField;
            }
            set
            {
                this.subjurisdiccionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string Entidad
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string Saf
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string Programa
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string Subprograma
        {
            get
            {
                return this.subprogramaField;
            }
            set
            {
                this.subprogramaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public string Proyecto
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public string Actividad
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public string Obra
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public string Inciso
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public string Principal
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public string Parcial
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public string Subparcial
        {
            get
            {
                return this.subparcialField;
            }
            set
            {
                this.subparcialField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=16)]
        public string Procedencia
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=17)]
        public string Fuente
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=18)]
        public string Compromisoinicial
        {
            get
            {
                return this.compromisoinicialField;
            }
            set
            {
                this.compromisoinicialField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=19)]
        public string Compromisovigente
        {
            get
            {
                return this.compromisovigenteField;
            }
            set
            {
                this.compromisovigenteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=20)]
        public string Compromisorestringido
        {
            get
            {
                return this.compromisorestringidoField;
            }
            set
            {
                this.compromisorestringidoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=21)]
        public string Devengadoinicial1
        {
            get
            {
                return this.devengadoinicial1Field;
            }
            set
            {
                this.devengadoinicial1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=22)]
        public string Devengadovigente1
        {
            get
            {
                return this.devengadovigente1Field;
            }
            set
            {
                this.devengadovigente1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=23)]
        public string Devengadorestringido1
        {
            get
            {
                return this.devengadorestringido1Field;
            }
            set
            {
                this.devengadorestringido1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=24)]
        public string Devengadoinicial2
        {
            get
            {
                return this.devengadoinicial2Field;
            }
            set
            {
                this.devengadoinicial2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=25)]
        public string Devengadovigente2
        {
            get
            {
                return this.devengadovigente2Field;
            }
            set
            {
                this.devengadovigente2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=26)]
        public string Devengadorestringido2
        {
            get
            {
                return this.devengadorestringido2Field;
            }
            set
            {
                this.devengadorestringido2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=27)]
        public string Devengadoinicial3
        {
            get
            {
                return this.devengadoinicial3Field;
            }
            set
            {
                this.devengadoinicial3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=28)]
        public string Devengadovigente3
        {
            get
            {
                return this.devengadovigente3Field;
            }
            set
            {
                this.devengadovigente3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=29)]
        public string Devengadorestringido3
        {
            get
            {
                return this.devengadorestringido3Field;
            }
            set
            {
                this.devengadorestringido3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=30)]
        public string Compromisocomprobante
        {
            get
            {
                return this.compromisocomprobanteField;
            }
            set
            {
                this.compromisocomprobanteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=31)]
        public string Devengado1comprobante
        {
            get
            {
                return this.devengado1comprobanteField;
            }
            set
            {
                this.devengado1comprobanteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=32)]
        public string Devengado2comprobante
        {
            get
            {
                return this.devengado2comprobanteField;
            }
            set
            {
                this.devengado2comprobanteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=33)]
        public string Devengado3comprobante
        {
            get
            {
                return this.devengado3comprobanteField;
            }
            set
            {
                this.devengado3comprobanteField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class ZfmWsCuotaResponse
    {
        
        private ZdsWsPresupOutput eOutputField;
        
        private ZdsEntradasCuota[] itEntradaCuotaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public ZdsWsPresupOutput EOutput
        {
            get
            {
                return this.eOutputField;
            }
            set
            {
                this.eOutputField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public ZdsEntradasCuota[] ItEntradaCuota
        {
            get
            {
                return this.itEntradaCuotaField;
            }
            set
            {
                this.itEntradaCuotaField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ZfmWsCuotaRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:sap-com:document:sap:soap:functions:mc-style", Order=0)]
        public Service.ZfmWsCuota ZfmWsCuota;
        
        public ZfmWsCuotaRequest()
        {
        }
        
        public ZfmWsCuotaRequest(Service.ZfmWsCuota ZfmWsCuota)
        {
            this.ZfmWsCuota = ZfmWsCuota;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ZfmWsCuotaResponse1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:sap-com:document:sap:soap:functions:mc-style", Order=0)]
        public Service.ZfmWsCuotaResponse ZfmWsCuotaResponse;
        
        public ZfmWsCuotaResponse1()
        {
        }
        
        public ZfmWsCuotaResponse1(Service.ZfmWsCuotaResponse ZfmWsCuotaResponse)
        {
            this.ZfmWsCuotaResponse = ZfmWsCuotaResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface ZWS_CUOTAChannel : Service.ZWS_CUOTA, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class ZWS_CUOTAClient : System.ServiceModel.ClientBase<Service.ZWS_CUOTA>, Service.ZWS_CUOTA
    {
        
        public ZWS_CUOTAClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Service.ZfmWsCuotaResponse1> Service.ZWS_CUOTA.ZfmWsCuotaAsync(Service.ZfmWsCuotaRequest request)
        {
            return base.Channel.ZfmWsCuotaAsync(request);
        }
        
        public System.Threading.Tasks.Task<Service.ZfmWsCuotaResponse1> ZfmWsCuotaAsync(Service.ZfmWsCuota ZfmWsCuota)
        {
            Service.ZfmWsCuotaRequest inValue = new Service.ZfmWsCuotaRequest();
            inValue.ZfmWsCuota = ZfmWsCuota;
            return ((Service.ZWS_CUOTA)(this)).ZfmWsCuotaAsync(inValue);
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
