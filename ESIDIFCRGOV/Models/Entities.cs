using ESIDIF.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ESIDIFCRGOV.Models
{
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantesCrgOvMsg")]
    public class crgOvResponse : object, System.ComponentModel.INotifyPropertyChanged
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

    [System.Runtime.Serialization.DataContract(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantesCrgOvMsg")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantesCrgOvMsg")]
    public class crgOvRequest : object, System.ComponentModel.INotifyPropertyChanged
    {
        private CabeceraCRGType cabeceraCrgField;

        private ComprobanteVinculoType comprobanteVinculoField;

        private string observacionesField;

        private ItemPresupuestarioCRGType[] itemsPresupuestariosField;

        private ItemNoPresupuestarioCRGType[] itemsNoPresupuestariosField;

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public CabeceraCRGType cabeceraCrg
        {
            get
            {
                return this.cabeceraCrgField;
            }
            set
            {
                this.cabeceraCrgField = value;
                this.RaisePropertyChanged("cabeceraCrg");
            }
        }

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public ComprobanteVinculoType comprobanteVinculo
        {
            get
            {
                return this.comprobanteVinculoField;
            }
            set
            {
                this.comprobanteVinculoField = value;
                this.RaisePropertyChanged("comprobanteVinculo");
            }
        }

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
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
        [System.Runtime.Serialization.DataMember(Order = 3)]
        [System.ComponentModel.DataAnnotations.Display(Name = "itemsPresupuestarios")]
        [XmlElement("itemsPresupuestarios", ElementName = "itemsPresupuestarios", Order = 3)]
        public ItemPresupuestarioCRGType[] itemsPresupuestarios
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
        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 4)]
        [System.ComponentModel.DataAnnotations.Display(Name = "itemsNoPresupuestarios")]
        [XmlElement("itemsNoPresupuestarios", ElementName = "itemsNoPresupuestarios", Order = 4)]
        public ItemNoPresupuestarioCRGType[] itemsNoPresupuestarios
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

    [System.Runtime.Serialization.DataContract(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantesCrg")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantesCrg")]
    public class CabeceraCRGType : object, System.ComponentModel.INotifyPropertyChanged
    {
        private service.GestionExternaEnum gestionExternaField;

        private IdentificacionCRGType identificacionComprobanteField;

        private System.DateTime fechaComprobanteField;

        private System.DateTime? fechaRegistroField;

        private bool fechaRegistroFieldSpecified;

        private int? periodoImpactoField;

        private bool periodoImpactoFieldSpecified;

        private decimal importeMOField;

        private decimal importeMCLField;

        private CotizacionType cotizacionField;

        private long beneficiarioField;

        private service.MedioDePagoType medioDePagoField;

        private IdentificadorDeTramiteType identificadorTramiteField;

        private DocumentoRespaldatorioType documentoRespaldatorioField;

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
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

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public IdentificacionCRGType identificacionComprobante
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

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string fechaComprobante
        {
            get
            {
                return this.fechaComprobanteField != null && this.fechaComprobanteField != DateTime.MinValue ? this.fechaComprobanteField.ToString("yyyy-MM-dd") : null;
            }
            set
            {
                this.fechaComprobanteField = Functions.CopyStringToFecha(value, Functions.FechaTipo.SIMPLE, "yyyy-MM-dd");
                this.RaisePropertyChanged("fechaComprobante");
            }
        }

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string fechaRegistro
        {
            get
            {
                return this.fechaRegistroField.HasValue ? (this.fechaRegistroField.Value.ToString("yyyy-MM-dd")) : null;
            }
            set
            {
                this.fechaRegistroField = !string.IsNullOrEmpty(value) ? Functions.CopyStringToFecha(value, Functions.FechaTipo.SIMPLE, "yyyy-MM-dd") : (DateTime?)null;
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
                return (this.fechaRegistroField != null && this.fechaRegistroField.HasValue && this.fechaRegistroField != DateTime.MinValue && !string.IsNullOrEmpty(fechaRegistro));
            }
            set
            {
                this.fechaRegistroFieldSpecified = value;
                this.RaisePropertyChanged("fechaRegistroSpecified");
            }
        }

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 4)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string periodoImpacto
        {
            get
            {
                return this.periodoImpactoField.HasValue ? (Convert.ToString(this.periodoImpactoField)) : null;
            }
            set
            {
                this.periodoImpactoField = !string.IsNullOrEmpty(value) ? Functions.CopyStringToInt(value) : (int?)null;
                this.RaisePropertyChanged("periodoImpacto");
            }
        }

        /// <remarks/>
        [System.Runtime.Serialization.IgnoreDataMember()]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool periodoImpactoSpecified
        {
            get
            {
                return (this.periodoImpactoField != null && this.periodoImpactoField.HasValue && !string.IsNullOrEmpty(periodoImpacto));
                //return this.periodoImpactoFieldSpecified;
            }
            set
            {
                this.periodoImpactoFieldSpecified = value;
                this.RaisePropertyChanged("periodoImpactoSpecified");
            }
        }

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 5)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string importeMO
        {
            get
            {
                return Convert.ToString(this.importeMOField);
            }
            set
            {
                this.importeMOField = Functions.CopyStringToDecimal(value);
                this.RaisePropertyChanged("importeMO");
            }
        }

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 6)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string importeMCL
        {
            get
            {
                return Convert.ToString(this.importeMCLField);
            }
            set
            {
                this.importeMCLField = Functions.CopyStringToDecimal(value);
                this.RaisePropertyChanged("importeMCL");
            }
        }

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 7)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public CotizacionType cotizacion
        {
            get
            {
                return this.cotizacionField;
            }
            set
            {
                this.cotizacionField = value;
                this.RaisePropertyChanged("cotizacion");
            }
        }

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 8)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string beneficiario
        {
            get
            {
                return Convert.ToString(this.beneficiarioField);
            }
            set
            {
                this.beneficiarioField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("beneficiario");
            }
        }

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 9)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string medioDePago
        {
            get
            {
                return Convert.ToString(this.medioDePagoField);
            }
            set
            {
                //Enum.TryParse(value, out this.gestionExternaField);
                this.medioDePagoField = Functions.CopyStringToEnum<service.MedioDePagoType>(value);
                this.RaisePropertyChanged("medioDePago");
            }
        }

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 10)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
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

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 11)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
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

    [System.Runtime.Serialization.DataContract(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantesCrg")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantesCrg")]
    public class ComprobanteVinculoType : object, System.ComponentModel.INotifyPropertyChanged
    {

        private bool marcaInicioVinculoField;

        private string tipoOperacionVinculadaField;

        private long ejercicioOperacionVinculadaField;

        private long numeroOperacionVinculadaField;

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string marcaInicioVinculo
        {
            get
            {
                return Convert.ToString(this.marcaInicioVinculoField);
            }
            set
            {
                this.marcaInicioVinculoField = Functions.CopyStringToBool(value);
                this.RaisePropertyChanged("marcaInicioVinculo");
            }
        }

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string tipoOperacionVinculada
        {
            get
            {
                return this.tipoOperacionVinculadaField;
            }
            set
            {
                this.tipoOperacionVinculadaField = value;
                this.RaisePropertyChanged("tipoOperacionVinculada");
            }
        }

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string ejercicioOperacionVinculada
        {
            get
            {
                return Convert.ToString(this.ejercicioOperacionVinculadaField);
            }
            set
            {
                this.ejercicioOperacionVinculadaField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("ejercicioOperacionVinculada");
            }
        }

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string numeroOperacionVinculada
        {
            get
            {
                return Convert.ToString(this.numeroOperacionVinculadaField);
            }
            set
            {
                this.numeroOperacionVinculadaField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("numeroOperacionVinculada");
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

    [System.Runtime.Serialization.DataContract(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantesCrg")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantesCrg")]
    public class IdentificacionCRGType : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string entidadEmisoraField;

        private string entidadProcesoField;

        private long numeroField;

        private long ejercicioField;

        private string tipoComprobanteField;

        private string tipoRegistroField;

        private string subTipoRegistroField;

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
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

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
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
        [System.Runtime.Serialization.DataMember(Order = 3)]
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

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 4)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
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
        [System.Runtime.Serialization.DataMember(Order = 5)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
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
        [System.Runtime.Serialization.DataMember(Order = 6)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
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
            PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));

        }
    }

    [System.Runtime.Serialization.DataContract(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantes")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantes")]
    public class CotizacionType : object, System.ComponentModel.INotifyPropertyChanged
    {
        private service.TipoCotizacionType tipoCotizacionField;

        private bool tipoCotizacionFieldSpecified;

        private string tipoMonedaField;

        private System.DateTime fechaField;

        private bool fechaFieldSpecified;

        private decimal valorField;

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string tipoCotizacion
        {
            get
            {
                return Convert.ToString(this.tipoCotizacionField);
            }
            set
            {
                //Enum.TryParse(value, out this.gestionExternaField);
                this.tipoCotizacionField = Functions.CopyStringToEnum<service.TipoCotizacionType>(value);
                this.RaisePropertyChanged("tipoCotizacion");
            }
        }

        /// <remarks/>
        [System.Runtime.Serialization.IgnoreDataMember()]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tipoCotizacionSpecified
        {
            get
            {
                return (this.tipoCotizacionField != null && !string.IsNullOrEmpty(tipoCotizacion));
            }
            set
            {
                this.tipoCotizacionFieldSpecified = value;
                this.RaisePropertyChanged("tipoCotizacionSpecified");
            }
        }

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string tipoMoneda
        {
            get
            {
                return this.tipoMonedaField;
            }
            set
            {
                this.tipoMonedaField = value;
                this.RaisePropertyChanged("tipoMoneda");
            }
        }

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string fecha
        {
            get
            {
                return this.fechaField.ToString("yyyy-MM-dd");
                //return string.Format("{0:s}", this.fechaField);
                //return Convert.ToString(this.fechaAutorizacionField);
            }
            set
            {
                this.fechaField = Functions.CopyStringToFecha(value, Functions.FechaTipo.SIMPLE, "yyyy-MM-dd");
                this.RaisePropertyChanged("fecha");
            }
        }

        /// <remarks/>
        [System.Runtime.Serialization.IgnoreDataMember()]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fechaSpecified
        {
            get
            {
                return (this.fechaField != null && this.fechaField != DateTime.MinValue && !string.IsNullOrEmpty(fecha));
            }
            set
            {
                this.fechaFieldSpecified = value;
                this.RaisePropertyChanged("fechaSpecified");
            }
        }

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string valor
        {
            get
            {
                return Convert.ToString(this.valorField);
            }
            set
            {
                this.valorField = Functions.CopyStringToDecimal(value);
                this.RaisePropertyChanged("valor");
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
        [System.Runtime.Serialization.DataMember(Order = 0)]
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
        [System.Runtime.Serialization.DataMember(Order = 1)]
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
        [System.Runtime.Serialization.DataMember(Order = 2)]
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
        [System.Runtime.Serialization.DataMember(Order = 0)]
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

    [System.Runtime.Serialization.DataContract(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantesCrg")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantesCrg")]
    public partial class ItemNoPresupuestarioCRGType : object, System.ComponentModel.INotifyPropertyChanged
    {

        private long axtField;

        private decimal importeMOField;

        private decimal importeMCLField;

        private string pexField;

        private CodigoTramoPartidaType recacField;

        private CodigoTramoPartidaType sigadeField;

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 0)]
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
        [System.Runtime.Serialization.DataMember(Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string importeMO
        {
            get
            {
                return Convert.ToString(this.importeMOField);
            }
            set
            {
                this.importeMOField = Functions.CopyStringToDecimal(value);
                this.RaisePropertyChanged("importeMO");
            }
        }

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string importeMCL
        {
            get
            {
                return Convert.ToString(this.importeMCLField);
            }
            set
            {
                this.importeMCLField = Functions.CopyStringToDecimal(value);
                this.RaisePropertyChanged("importeMCL");
            }
        }

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string pex
        {
            get
            {
                return this.pexField;
            }
            set
            {
                this.pexField = value;
                this.RaisePropertyChanged("pex");
            }
        }

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 4)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
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
        [System.Runtime.Serialization.DataMember(Order = 5)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
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

    [System.Runtime.Serialization.DataContract(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantesCrg")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantesCrg")]
    public class ItemPresupuestarioCRGType : object, System.ComponentModel.INotifyPropertyChanged
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
        [System.Runtime.Serialization.DataMember(Order = 0)]
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
        [System.Runtime.Serialization.DataMember(Order = 1)]
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
        [System.Runtime.Serialization.DataMember(Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
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
        [System.Runtime.Serialization.DataMember(Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string importeMO
        {
            get
            {
                return Convert.ToString(this.importeMOField);
            }
            set
            {
                this.importeMOField = Functions.CopyStringToDecimal(value);
                this.RaisePropertyChanged("importeMO");
            }
        }

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 4)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string importeMCL
        {
            get
            {
                return Convert.ToString(this.importeMCLField);
            }
            set
            {
                this.importeMCLField = Functions.CopyStringToDecimal(value);
                this.RaisePropertyChanged("importeMCL");
            }
        }

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 5)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string cotena
        {
            get
            {
                return this.cotenaField;
            }
            set
            {
                this.cotenaField = value;
                this.RaisePropertyChanged("cotena");
            }
        }

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 6)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
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
        [System.Runtime.Serialization.DataMember(Order = 7)]
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
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
    public class CodigoTramoPartidaType : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string idField;

        private string tramoField;

        private string partidaField;

        private string codigoField;

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 0)]
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
        [System.Runtime.Serialization.DataMember(Order = 1)]
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
        [System.Runtime.Serialization.DataMember(Order = 2)]
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
        [System.Runtime.Serialization.DataMember(Order = 3)]
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
        [System.Runtime.Serialization.DataMember(Order = 0)]
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
        [System.Runtime.Serialization.DataMember(Order = 1)]
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
        [System.Runtime.Serialization.DataMember(Order = 2)]
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
        [System.Runtime.Serialization.DataMember(Order = 3)]
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
        [System.Runtime.Serialization.DataMember(Order = 4)]
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
        [System.Runtime.Serialization.DataMember(Order = 5)]
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
        [System.Runtime.Serialization.DataMember(Order = 6)]
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
        [System.Runtime.Serialization.DataMember(Order = 7)]
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
        [System.Runtime.Serialization.DataMember(Order = 8)]
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
        [System.Runtime.Serialization.DataMember(Order = 9)]
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
                return (this.bapinField != null && !string.IsNullOrEmpty(bapin));
            }
            set
            {
                this.bapinFieldSpecified = value;
                this.RaisePropertyChanged("bapinSpecified");
            }
        }

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 10)]
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
                return (this.pexField != null && !string.IsNullOrEmpty(pex));
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
    public partial class UnidadDescentralizadaType : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string codigoField;

        private long ejercicioField;

        private bool ejercicioFieldSpecified;

        private string safField;

        private string descripcionField;

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 0)]
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
        [System.Runtime.Serialization.DataMember(Order = 1)]
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
                return (this.ejercicioField != null && ejercicioField != 0 && !string.IsNullOrEmpty(ejercicio));
            }
            set
            {
                this.ejercicioFieldSpecified = value;
                this.RaisePropertyChanged("ejercicioSpecified");
            }
        }

        /// <remarks/>
        [System.Runtime.Serialization.DataMember(Order = 2)]
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
        [System.Runtime.Serialization.DataMember(Order = 3)]
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

}


namespace ESIDIFCRGOV.Soap
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
        public Body(Models.crgOvRequest request)
        {
            crgDbRequest = request;
        }

        [XmlElement(ElementName = "crgOvRequest", Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantesCrgOvMsg")]
        public Models.crgOvRequest crgDbRequest { get; set; }
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
                UsernameToken = new UsernameToken(id, username, password)
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
        public UsernameToken UsernameToken { get; set; }
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