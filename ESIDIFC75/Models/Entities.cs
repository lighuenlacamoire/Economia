using ESIDIFCommon.Tools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ESIDIFC75.Models
{
    [System.Runtime.Serialization.CollectionDataContract(ItemName ="item2", Namespace = "https://ws-si.mecon.gov.ar/ws/informeDeGastos")]
    public class itemsPresupuestariosDetail : List<ItemPresupuestarioInformeDeGastosType>
    {
        //[System.Runtime.Serialization.DataMember(Name ="eeee", Order =0)]
        //public List<ItemPresupuestarioInformeDeGastosType> _list = new List<ItemPresupuestarioInformeDeGastosType>();

        public itemsPresupuestariosDetail() : base() { }

        public itemsPresupuestariosDetail(List<ItemPresupuestarioInformeDeGastosType> items) : base()
        {
            foreach (var item in items)
            {
                Add(item);
            }
        }


        //    public itemsPresupuestariosDetail(IEnumerable<ItemPresupuestarioInformeDeGastosType> list) : base(list)
        //    {

        //    }
    }

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://ws-si.mecon.gov.ar/ws/informeDeGastosMsg")]
    public class generarInformeDeGastosResponse : object, System.ComponentModel.INotifyPropertyChanged
    {
        private long numeroSidifField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string numeroSidif
        {
            get
            {
                return Convert.ToString(this.numeroSidifField);
            }
            set
            {
                this.numeroSidifField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("numeroSidif");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Runtime.Serialization.DataContract(Namespace = "https://ws-si.mecon.gov.ar/ws/informeDeGastosMsg")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://ws-si.mecon.gov.ar/ws/informeDeGastosMsg")]
    public class generarInformeDeGastos : object, System.ComponentModel.INotifyPropertyChanged
    {
        [System.Runtime.Serialization.DataMember(Order = 0)]
        public DatosInicialesInformeDeGastosType datosInicialesInformeDeGastos { get; set; }
        //public string gestionExterna { get; set; } // GestionExternaEnum

        private service.GestionExternaEnum gestionExternaField;

        [System.Runtime.Serialization.DataMember(Order = 1)]
        public string gestionExterna
        {
            get
            {
                return Convert.ToString(this.gestionExternaField);
            }
            set
            {
                //Enum.TryParse(value, out this.gestionExternaField);
                this.gestionExternaField = Functions.CopyStringToEnum<service.GestionExternaEnum>(value);
                this.RaisePropertyChanged("gestionExterna");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Runtime.Serialization.DataContract(Namespace = "https://ws-si.mecon.gov.ar/ws/informeDeGastos")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://ws-si.mecon.gov.ar/ws/informeDeGastos")]
    public class DatosInicialesInformeDeGastosType : object, System.ComponentModel.INotifyPropertyChanged
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

        private service.MedioDePagoType medioDePagoField; //Enum MedioDePagoType

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

        //[System.Xml.Serialization.XmlElement("itemsPresupuestarios")]
        //public ItemPresupuestarioInformeDeGastosType[] itemsPresupuestarios { get; set; }

        //[System.Xml.Serialization.XmlElement("itemsNoPresupuestarios")]
        //public ItemNoPresupuestarioInformeDeGastosType[] itemsNoPresupuestarios { get; set; }
        
        [System.Runtime.Serialization.DataMember(Order =0)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public IdentificacionComprobanteType identificacionComprobante
        {
            get
            {
                return this.identificacionComprobanteField;
            }
            set
            {
                this.identificacionComprobanteField = value;
                this.RaisePropertyChanged("identificacionComprobante");
            }
        }

        [System.Runtime.Serialization.DataMember(Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string entidadProceso
        {
            get
            {
                return this.entidadProcesoField;
            }
            set
            {
                this.entidadProcesoField = value;
                this.RaisePropertyChanged("entidadProceso");
            }
        }

        [System.Runtime.Serialization.DataMember(Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public IdentificadorDeTramiteType identificadorTramite
        {
            get
            {
                return this.identificadorTramiteField;
            }
            set
            {
                this.identificadorTramiteField = value;
                this.RaisePropertyChanged("identificadorTramite");
            }
        }

        [System.Runtime.Serialization.DataMember(Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public DocumentoRespaldatorioType documentoRespaldatorio
        {
            get
            {
                return this.documentoRespaldatorioField;
            }
            set
            {
                this.documentoRespaldatorioField = value;
                this.RaisePropertyChanged("documentoRespaldatorio");
            }
        }

        [System.Runtime.Serialization.DataMember(Order = 4)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public IdentificacionComprobanteType comprobanteOrigen
        {
            get
            {
                return this.comprobanteOrigenField;
            }
            set
            {
                this.comprobanteOrigenField = value;
                this.RaisePropertyChanged("comprobanteOrigen");
            }
        }

        [System.Runtime.Serialization.DataMember(Order = 5)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string fechaAutorizacion
        {
            get
            {
                return this.fechaAutorizacionField.ToString("yyyy-MM-ddTHH:mm:ss");
                //return Convert.ToString(this.fechaAutorizacionField);
            }
            set
            {
                this.fechaAutorizacionField = Functions.CopyStringToFecha(value, Functions.FechaTipo.MEDIA, "yyyy-MM-ddTHH:mm:ss");
                this.RaisePropertyChanged("fechaAutorizacion");
            }
        }

        [System.Runtime.Serialization.DataMember(Order = 6)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string fechaComprobante
        {
            get
            {
                return this.fechaComprobanteField.ToString("yyyy-MM-ddTHH:mm:ss");
            }
            set
            {
                this.fechaComprobanteField = Functions.CopyStringToFecha(value, Functions.FechaTipo.MEDIA, "yyyy-MM-ddTHH:mm:ss");
                this.RaisePropertyChanged("fechaComprobante");
            }
        }

        [System.Runtime.Serialization.DataMember(Order = 7)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string fechaRegistro
        {
            get
            {
                return this.fechaRegistroField.ToString("yyyy-MM-ddTHH:mm:ss");
            }
            set
            {
                this.fechaRegistroField = Functions.CopyStringToFecha(value, Functions.FechaTipo.MEDIA, "yyyy-MM-ddTHH:mm:ss");
                this.RaisePropertyChanged("fechaRegistro");
            }
        }

        /// <remarks/>
        [System.Runtime.Serialization.IgnoreDataMember()]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fechaRegistroSpecified
        {
            get
            {
                return (this.fechaRegistroField != null && this.fechaRegistroField != DateTime.MinValue && !string.IsNullOrEmpty(fechaRegistro));
            }
            set
            {
                this.fechaRegistroFieldSpecified = value;
                this.RaisePropertyChanged("fechaRegistroSpecified");
            }
        }

        [System.Runtime.Serialization.DataMember(Order = 8)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string periodoImpacto
        {
            get
            {
                return this.periodoImpactoField.ToString();
            }
            set
            {
                this.periodoImpactoField = Functions.CopyStringToInt(value);
                this.RaisePropertyChanged("periodoImpacto");
            }
        }

        [System.Runtime.Serialization.IgnoreDataMember()]
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
                this.RaisePropertyChanged("periodoImpactoSpecified");
            }
        }

        [System.Runtime.Serialization.DataMember(Order = 9)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public CuentaType cuentaFinanciadora
        {
            get
            {
                return this.cuentaFinanciadoraField;
            }
            set
            {
                this.cuentaFinanciadoraField = value;
                this.RaisePropertyChanged("cuentaFinanciadora");
            }
        }

        [System.Runtime.Serialization.DataMember(Order = 10)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string pagoDirecto
        {
            get
            {
                return this.pagoDirectoField.ToString()?.ToLower();
            }
            set
            {
                this.pagoDirectoField = Functions.CopyStringToBool(value);
                this.RaisePropertyChanged("pagoDirecto");
            }
        }

        [System.Runtime.Serialization.DataMember(Order = 11)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string medioDePago
        {
            get
            {
                return Convert.ToString(this.medioDePagoField);
            }
            set
            {
                //Enum.TryParse(value, out this.medioDePagoField);
                this.medioDePagoField = Functions.CopyStringToEnum<service.MedioDePagoType>(value);
                this.RaisePropertyChanged("medioDePago");
            }
        }

        [System.Runtime.Serialization.DataMember(Order = 12)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string importeCompromiso
        {
            get
            {
                return this.importeCompromisoField.ToString("N2", Functions.numberFormat);
            }
            set
            {
                this.importeCompromisoField = Functions.CopyStringToDecimal(value);
                this.RaisePropertyChanged("importeCompromiso");
            }
        }

        [System.Runtime.Serialization.DataMember(Order = 13)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public string importeDevengado
        {
            get
            {
                return this.importeDevengadoField.ToString("N2", Functions.numberFormat);
            }
            set
            {
                this.importeDevengadoField = Functions.CopyStringToDecimal(value);
                this.RaisePropertyChanged("importeDevengado");
            }
        }

        [System.Runtime.Serialization.DataMember(Order = 14)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public string importePagado
        {
            get
            {
                return this.importePagadoField.ToString("N2", Functions.numberFormat);
            }
            set
            {
                this.importePagadoField = Functions.CopyStringToDecimal(value);
                this.RaisePropertyChanged("importePagado");
            }
        }

        [System.Runtime.Serialization.DataMember(Order = 15)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public string importeDeducciones
        {
            get
            {
                return this.importeDeduccionesField.ToString("N2", Functions.numberFormat);
            }
            set
            {
                this.importeDeduccionesField = Functions.CopyStringToDecimal(value);
                this.RaisePropertyChanged("importeDeducciones");
            }
        }

        [System.Runtime.Serialization.DataMember(Order = 16)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
        public string importeDeduccionesPagado
        {
            get
            {
                return this.importeDeduccionesPagadoField.ToString("N2", Functions.numberFormat);
            }
            set
            {
                this.importeDeduccionesPagadoField = Functions.CopyStringToDecimal(value);
                this.RaisePropertyChanged("importeDeduccionesPagado");
            }
        }

        [System.Runtime.Serialization.DataMember(Order = 17)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
        public string importeNetoPagado
        {
            get
            {
                return this.importeNetoPagadoField.ToString("N2", Functions.numberFormat);
            }
            set
            {
                this.importeNetoPagadoField = Functions.CopyStringToDecimal(value);
                this.RaisePropertyChanged("importeNetoPagado");
            }
        }

        [System.Runtime.Serialization.DataMember(Order = 18)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 18)]
        public string uepex
        {
            get
            {
                return this.uepexField;
            }
            set
            {
                this.uepexField = value;
                this.RaisePropertyChanged("uepex");
            }
        }

        [System.Runtime.Serialization.DataMember(Order = 19)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 19)]
        public string observaciones
        {
            get
            {
                return this.observacionesField;
            }
            set
            {
                this.observacionesField = value;
                this.RaisePropertyChanged("observaciones");
            }
        }

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 20)]
        [System.ComponentModel.DataAnnotations.Display(Name = "itemsPresupuestarios")]
        [XmlElement("itemsPresupuestarios", ElementName = "itemsPresupuestarios", Order = 20)]
        public ItemPresupuestarioInformeDeGastosType[] itemsPresupuestarios
        {
            get
            {
                return this.itemsPresupuestariosField;
            }
            set
            {
                this.itemsPresupuestariosField = value;
                this.RaisePropertyChanged("itemsPresupuestarios");
            }
        }
        //[System.Runtime.Serialization.DataMember(Order = 20)]
        //[XmlArray(ElementName ="nose")]
        //[XmlArrayItem(ElementName ="talvez")]
        //public itemsPresupuestariosDetail itemsPresupuestarios { get; set; }

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 21)]
        [System.ComponentModel.DataAnnotations.Display(Name = "itemsNoPresupuestarios")]
        [XmlElement("itemsNoPresupuestarios", ElementName = "itemsNoPresupuestarios", Order = 21)]
        public ItemNoPresupuestarioInformeDeGastosType[] itemsNoPresupuestarios
        {
            get
            {
                return this.itemsNoPresupuestariosField;
            }
            set
            {
                this.itemsNoPresupuestariosField = value;
                this.RaisePropertyChanged("itemsNoPresupuestarios");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Runtime.Serialization.DataContract(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantes")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantes")]
    public class IdentificacionComprobanteType : object, System.ComponentModel.INotifyPropertyChanged
    {
        private string tipoComprobanteField;

        private long numeroField;

        private long ejercicioField;

        private string entidadEmisoraField;

        private string tipoRegistroField;

        private string subTipoRegistroField;

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string tipoComprobante
        {
            get
            {
                return this.tipoComprobanteField;
            }
            set
            {
                this.tipoComprobanteField = value;
                this.RaisePropertyChanged("tipoComprobante");
            }
        }

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string numero
        {
            get
            {
                return Convert.ToString(this.numeroField);
            }
            set
            {
                this.numeroField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("numero");
            }
        }

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string ejercicio
        {
            get
            {
                return Convert.ToString(this.ejercicioField);
            }
            set
            {
                this.ejercicioField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("ejercicio");
            }
        }

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string entidadEmisora
        {
            get
            {
                return this.entidadEmisoraField;
            }
            set
            {
                this.entidadEmisoraField = value;
                this.RaisePropertyChanged("entidadEmisora");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string tipoRegistro
        {
            get
            {
                return this.tipoRegistroField;
            }
            set
            {
                this.tipoRegistroField = value;
                this.RaisePropertyChanged("tipoRegistro");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string subTipoRegistro
        {
            get
            {
                return this.subTipoRegistroField;
            }
            set
            {
                this.subTipoRegistroField = value;
                this.RaisePropertyChanged("subTipoRegistro");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Runtime.Serialization.DataContract(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantes")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantes")]
    public class IdentificadorDeTramiteType : object, System.ComponentModel.INotifyPropertyChanged
    {
        private string tipoField;

        private string identificadorField;

        private long anioField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string tipo
        {
            get
            {
                return this.tipoField;
            }
            set
            {
                this.tipoField = value;
                this.RaisePropertyChanged("tipo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string identificador
        {
            get
            {
                return this.identificadorField;
            }
            set
            {
                this.identificadorField = value;
                this.RaisePropertyChanged("identificador");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string anio
        {
            get
            {
                return Convert.ToString(this.anioField);
            }
            set
            {
                this.anioField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("anio");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Runtime.Serialization.DataContract(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantes")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantes")]
    public class DocumentoRespaldatorioType : object, System.ComponentModel.INotifyPropertyChanged
    {
        private string tipoField;

        private long numeroField;

        private long ejercicioField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string tipo
        {
            get
            {
                return this.tipoField;
            }
            set
            {
                this.tipoField = value;
                this.RaisePropertyChanged("tipo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string numero
        {
            get
            {
                return Convert.ToString(this.numeroField);
            }
            set
            {
                this.numeroField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("numero");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string ejercicio
        {
            get
            {
                return Convert.ToString(this.ejercicioField);
            }
            set
            {
                this.ejercicioField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("ejercicio");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Runtime.Serialization.DataContract(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantes")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantes")]
    public class CuentaType : object, System.ComponentModel.INotifyPropertyChanged
    {

        private long bancoField;

        private string sucursalField;

        private string cuentaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string banco
        {
            get
            {
                return Convert.ToString(this.bancoField);
            }
            set
            {
                this.bancoField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("banco");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string sucursal
        {
            get
            {
                return this.sucursalField;
            }
            set
            {
                this.sucursalField = value;
                this.RaisePropertyChanged("sucursal");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string cuenta
        {
            get
            {
                return this.cuentaField;
            }
            set
            {
                this.cuentaField = value;
                this.RaisePropertyChanged("cuenta");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Runtime.Serialization.DataContract(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantes")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantes")]
    public class ImputacionPresupuestariaCreditoType : object, System.ComponentModel.INotifyPropertyChanged
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string institucion
        {
            get
            {
                return this.institucionField;
            }
            set
            {
                this.institucionField = value;
                this.RaisePropertyChanged("institucion");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string ejercicio
        {
            get
            {
                return Convert.ToString(this.ejercicioField);
            }
            set
            {
                this.ejercicioField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("ejercicio");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string servicio
        {
            get
            {
                return this.servicioField;
            }
            set
            {
                this.servicioField = value;
                this.RaisePropertyChanged("servicio");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string aperturaProg
        {
            get
            {
                return this.aperturaProgField;
            }
            set
            {
                this.aperturaProgField = value;
                this.RaisePropertyChanged("aperturaProg");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string objetoGasto
        {
            get
            {
                return this.objetoGastoField;
            }
            set
            {
                this.objetoGastoField = value;
                this.RaisePropertyChanged("objetoGasto");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string fuente
        {
            get
            {
                return this.fuenteField;
            }
            set
            {
                this.fuenteField = value;
                this.RaisePropertyChanged("fuente");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string moneda
        {
            get
            {
                return this.monedaField;
            }
            set
            {
                this.monedaField = value;
                this.RaisePropertyChanged("moneda");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string ug
        {
            get
            {
                return this.ugField;
            }
            set
            {
                this.ugField = value;
                this.RaisePropertyChanged("ug");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string entidadDestino
        {
            get
            {
                return this.entidadDestinoField;
            }
            set
            {
                this.entidadDestinoField = value;
                this.RaisePropertyChanged("entidadDestino");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string bapin
        {
            get
            {
                return Convert.ToString(this.bapinField);
            }
            set
            {
                this.bapinField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("bapin");
            }
        }

        /// <remarks/>
        [System.Runtime.Serialization.IgnoreDataMember()]
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
                this.RaisePropertyChanged("bapinSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string pex
        {
            get
            {
                return Convert.ToString(this.pexField);
            }
            set
            {
                this.pexField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("pex");
            }
        }

        /// <remarks/>
        [System.Runtime.Serialization.IgnoreDataMember()]
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
                this.RaisePropertyChanged("pexSpecified");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Runtime.Serialization.DataContract(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantes")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantes")]
    public class UnidadDescentralizadaType : object, System.ComponentModel.INotifyPropertyChanged
    {
        private string codigoField;

        private long ejercicioField;

        private bool ejercicioFieldSpecified;

        private string safField;

        private string descripcionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
                this.RaisePropertyChanged("codigo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string ejercicio
        {
            get
            {
                return Convert.ToString(this.ejercicioField);
            }
            set
            {
                this.ejercicioField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("ejercicio");
            }
        }

        /// <remarks/>
        [System.Runtime.Serialization.IgnoreDataMember()]
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
                this.RaisePropertyChanged("ejercicioSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string saf
        {
            get
            {
                return this.safField;
            }
            set
            {
                this.safField = value;
                this.RaisePropertyChanged("saf");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string descripcion
        {
            get
            {
                return this.descripcionField;
            }
            set
            {
                this.descripcionField = value;
                this.RaisePropertyChanged("descripcion");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Runtime.Serialization.DataContract(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantes")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantes")]
    public partial class CodigoTramoPartidaType : object, System.ComponentModel.INotifyPropertyChanged
    {
        private string idField;

        private string tramoField;

        private string partidaField;

        private string codigoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string tramo
        {
            get
            {
                return this.tramoField;
            }
            set
            {
                this.tramoField = value;
                this.RaisePropertyChanged("tramo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string partida
        {
            get
            {
                return this.partidaField;
            }
            set
            {
                this.partidaField = value;
                this.RaisePropertyChanged("partida");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
                this.RaisePropertyChanged("codigo");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Runtime.Serialization.DataContract(Name ="Item",Namespace = "https://ws-si.mecon.gov.ar/ws/informeDeGastos")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://ws-si.mecon.gov.ar/ws/informeDeGastos")]
    public class ItemPresupuestarioInformeDeGastosType : object, System.ComponentModel.INotifyPropertyChanged
    {
        private ImputacionPresupuestariaCreditoType imputacionField;

        private UnidadDescentralizadaType udField;

        private CodigoTramoPartidaType recacField;

        private CodigoTramoPartidaType sigadeField;

        private decimal importeCompromisoField;

        private decimal importeDevengadoField;

        private decimal importePagadoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public ImputacionPresupuestariaCreditoType imputacion
        {
            get
            {
                return this.imputacionField;
            }
            set
            {
                this.imputacionField = value;
                this.RaisePropertyChanged("imputacion");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public UnidadDescentralizadaType ud
        {
            get
            {
                return this.udField;
            }
            set
            {
                this.udField = value;
                this.RaisePropertyChanged("ud");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public CodigoTramoPartidaType recac
        {
            get
            {
                return this.recacField;
            }
            set
            {
                this.recacField = value;
                this.RaisePropertyChanged("recac");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public CodigoTramoPartidaType sigade
        {
            get
            {
                return this.sigadeField;
            }
            set
            {
                this.sigadeField = value;
                this.RaisePropertyChanged("sigade");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string importeCompromiso
        {
            get
            {
                return Convert.ToString(this.importeCompromisoField);
            }
            set
            {
                this.importeCompromisoField = Functions.CopyStringToDecimal(value);
                this.RaisePropertyChanged("importeCompromiso");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string importeDevengado
        {
            get
            {
                return Convert.ToString(this.importeDevengadoField);
            }
            set
            {
                this.importeDevengadoField = Functions.CopyStringToDecimal(value);
                this.RaisePropertyChanged("importeDevengado");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string importePagado
        {
            get
            {
                return Convert.ToString(this.importePagadoField);
            }
            set
            {
                this.importePagadoField = Functions.CopyStringToDecimal(value);
                this.RaisePropertyChanged("importePagado");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Runtime.Serialization.DataContract(Namespace = "https://ws-si.mecon.gov.ar/ws/informeDeGastos")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://ws-si.mecon.gov.ar/ws/informeDeGastos")]
    public class ItemNoPresupuestarioInformeDeGastosType : object, System.ComponentModel.INotifyPropertyChanged
    {
        private long axtField;

        private decimal importeDevengadoField;

        private decimal importePagadoField;

        private long ejercicioField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string axt
        {
            get
            {
                return Convert.ToString(this.axtField);
            }
            set
            {
                this.axtField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("axt");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string importeDevengado
        {
            get
            {
                return Convert.ToString(this.importeDevengadoField);
            }
            set
            {
                this.importeDevengadoField = Functions.CopyStringToDecimal(value);
                this.RaisePropertyChanged("importeDevengado");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string importePagado
        {
            get
            {
                return Convert.ToString(this.importePagadoField);
            }
            set
            {
                this.importePagadoField = Functions.CopyStringToDecimal(value);
                this.RaisePropertyChanged("importePagado");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string ejercicio
        {
            get
            {
                return Convert.ToString(this.ejercicioField);
            }
            set
            {
                this.ejercicioField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("ejercicio");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }


    //[System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantes")]
    //public class IdentificacionComprobanteType
    //{
    //    public string tipoComprobante { get; set; }
    //    public long numero { get; set; }
    //    public long ejercicio { get; set; } // length 4
    //    public string entidadEmisora { get; set; } // length 3
    //    public string tipoRegistro { get; set; }
    //    public string subTipoRegistro { get; set; }
    //}

    //[System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantes")]
    //public class IdentificadorDeTramiteType
    //{
    //    public string tipo { get; set; }
    //    public string identificador { get; set; }
    //    public long anio { get; set; }
    //}

    //[System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantes")]
    //public class DocumentoRespaldatorioType
    //{
    //    public string tipo { get; set; }
    //    public long numero { get; set; }
    //    public long ejercicio { get; set; }
    //}

    //[System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantes")]
    //public class CuentaType
    //{
    //    public long banco { get; set; }
    //    public string sucursal { get; set; }
    //    public string cuenta { get; set; }
    //}

    ////[System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://ws-si.mecon.gov.ar/ws/informeDeGastos")]
    //public class ItemPresupuestarioInformeDeGastosType
    //{
    //    public ImputacionPresupuestariaCreditoType imputacion { get; set; } // ImputacionPresupuestariaCreditoType
    //    public UnidadDescentralizadaType ud { get; set; } // UnidadDescentralizadaType
    //    public CodigoTramoPartidaType recac { get; set; } // CodigoTramoPartidaType
    //    public CodigoTramoPartidaType sigade { get; set; } // CodigoTramoPartidaType

    //    [System.Xml.Serialization.XmlIgnore]
    //    public decimal importeCompromisoValorDecimal
    //    {
    //        get
    //        {
    //            return Functions.CopyStringToDecimal(importeCompromiso);
    //        }
    //        set
    //        {
    //            this.importeCompromisoValorDecimal = Functions.CopyStringToDecimal(importeCompromiso);
    //        }
    //    }
    //    public string importeCompromiso { get; set; } //decimales 2

    //    [System.Xml.Serialization.XmlIgnore]
    //    public decimal importeDevengadoValorDecimal
    //    {
    //        get
    //        {
    //            return Functions.CopyStringToDecimal(importeDevengado);
    //        }
    //        set
    //        {
    //            this.importeDevengadoValorDecimal = Functions.CopyStringToDecimal(importeDevengado);
    //        }
    //    }
    //    public string importeDevengado { get; set; } //decimales 2

    //    [System.Xml.Serialization.XmlIgnore]
    //    public decimal importePagadoValorDecimal
    //    {
    //        get
    //        {
    //            return Functions.CopyStringToDecimal(importePagado);
    //        }
    //        set
    //        {
    //            this.importePagadoValorDecimal = Functions.CopyStringToDecimal(importePagado);
    //        }
    //    }
    //    public string importePagado { get; set; } //decimales 2

    //}

    //[System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantes")]
    //public class ImputacionPresupuestariaCreditoType // ImputacionPresupuestariaCreditoType
    //{
    //    public string institucion { get; set; }
    //    public long codigo { get; set; }
    //    public long ejercicio { get; set; }
    //    public string servicio { get; set; }
    //    public string aperturaProg { get; set; }
    //    public string objetoGasto { get; set; }
    //    public string fuente { get; set; }
    //    public string moneda { get; set; }
    //    public string entidadDestino { get; set; }
    //    public long bapin { get; set; }
    //    public long pex { get; set; }
    //    public string ug { get; set; }
    //}

    //[System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantes")]
    //public class UnidadDescentralizadaType // UnidadDescentralizadaType
    //{
    //    public string codigo { get; set; }
    //    public long ejercicio { get; set; } // legth 4
    //    public string saf { get; set; }
    //    public string descripcion { get; set; }
    //}

    //[System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantes")]
    //public class CodigoTramoPartidaType // CodigoTramoPartidaType
    //{
    //    public string id { get; set; }
    //    public string tramo { get; set; }
    //    public string partida { get; set; }
    //    public string codigo { get; set; }
    //}

    ////[System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://ws-si.mecon.gov.ar/ws/informeDeGastos")]
    //public class ItemNoPresupuestarioInformeDeGastosType
    //{
    //    public long axt { get; set; }

    //    [System.Xml.Serialization.XmlIgnore]
    //    public decimal importeDevengadoValorDecimal
    //    {
    //        get
    //        {
    //            return Functions.CopyStringToDecimal(importeDevengado);
    //        }
    //        set
    //        {
    //            this.importeDevengadoValorDecimal = Functions.CopyStringToDecimal(importeDevengado);
    //        }
    //    }
    //    public string importeDevengado { get; set; } //decimales 2

    //    [System.Xml.Serialization.XmlIgnore]
    //    public decimal importePagadoValorDecimal
    //    {
    //        get
    //        {
    //            return Functions.CopyStringToDecimal(importePagado);
    //        }
    //        set
    //        {
    //            this.importePagadoValorDecimal = Functions.CopyStringToDecimal(importePagado);
    //        }
    //    }
    //    public string importePagado { get; set; } //decimales 2

    //    public long ejercicio { get; set; } // legth 4
    //}
}


namespace ESIDIFC75.Soap
{
    [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class Envelope
    {
        [XmlElement(ElementName = "Header", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public Header Header { get; set; }

        [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public Body Body { get; set; }

        [XmlAttribute(AttributeName = "soapenv", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Soapenv { get; set; }
    }

    [XmlRoot(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class Body
    {
        public Body()
        {

        }
        public Body(Models.generarInformeDeGastos request)
        {
            generarInformeDeGastos = request;
        }

        [XmlElement(ElementName = "generarInformeDeGastos", Namespace = "https://ws-si.mecon.gov.ar/ws/informeDeGastosMsg")]
        public Models.generarInformeDeGastos generarInformeDeGastos { get; set; }
    }

    [XmlRoot(ElementName = "Header", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class Header
    {
        public Header()
        {

        }
        public Header(string id, string username, string password, string endpoint, string action)
        {
            Security = new Security
            {
                MustUnderstand = 1,
                UsernameToken = new ESIDIF.Models.Xml.UsernameToken(id, username, password)
            };
            To = new To
            {
                MustUnderstand = 1,
                Value = endpoint
            };
            Action = action;
            MessageID = "urn:uuid:" + Guid.NewGuid();
        }

        [XmlElement(ElementName = "Security", Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd")]
        public Security Security { get; set; }

        [XmlElement(ElementName = "To", Namespace = "http://www.w3.org/2005/08/addressing")]
        public To To { get; set; }

        [XmlElement(ElementName = "Action", Namespace = "http://www.w3.org/2005/08/addressing")]
        public string Action { get; set; }

        [XmlElement(ElementName = "MessageID", Namespace = "http://www.w3.org/2005/08/addressing")]
        public string MessageID { get; set; }
    }

    [XmlRoot(ElementName = "Security", Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd")]
    public class Security
    {
        [XmlAttribute("mustUnderstand", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public int MustUnderstand { get; set; }

        [XmlElement(ElementName = "UsernameToken", Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd")]
        public ESIDIF.Models.Xml.UsernameToken UsernameToken { get; set; }
    }

    [XmlRoot(ElementName = "To", Namespace = "http://www.w3.org/2005/08/addressing")]
    public class To
    {
        [XmlAttribute("mustUnderstand", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public int MustUnderstand { get; set; }

        [XmlText]//endpoint
        public string Value { get; set; }
    }
}