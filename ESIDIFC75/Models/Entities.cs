using ESIDIFCommon.Models.Xml;
using ESIDIFCommon.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ESIDIFC75.Models
{

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://ws-si.mecon.gov.ar/ws/informeDeGastosMsg")]
    [System.Xml.Serialization.XmlRoot(ElementName = "generarInformeDeGastosResponse", Namespace = "https://ws-si.mecon.gov.ar/ws/informeDeGastosMsg")]
    public class generarInformeDeGastosResponse : IBody, System.ComponentModel.INotifyPropertyChanged
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

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://ws-si.mecon.gov.ar/ws/informeDeGastosMsg")]
    [System.Xml.Serialization.XmlRoot(ElementName = "generarInformeDeGastos", Namespace = "https://ws-si.mecon.gov.ar/ws/informeDeGastosMsg")]
    public class generarInformeDeGastos : IBody, System.ComponentModel.INotifyPropertyChanged
    {
        public DatosInicialesInformeDeGastosType datosInicialesInformeDeGastos { get; set; }
        //public string gestionExterna { get; set; } // GestionExternaEnum

        private service.GestionExternaEnum? gestionExternaField;

        public string gestionExterna
        {
            get
            {
                return this.gestionExternaField.HasValue ? Functions.CheckStringFromEnum<service.GestionExternaEnum>(Convert.ToString(this.gestionExternaField.Value)) : null;
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

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://ws-si.mecon.gov.ar/ws/informeDeGastos")]
    public class DatosInicialesInformeDeGastosType : object, System.ComponentModel.INotifyPropertyChanged
    {
        private IdentificacionComprobanteType identificacionComprobanteField;

        private string entidadProcesoField;

        private IdentificadorDeTramiteType identificadorTramiteField;

        private DocumentoRespaldatorioType documentoRespaldatorioField;

        private IdentificacionComprobanteType comprobanteOrigenField;

        private string fechaAutorizacionField;

        private string fechaComprobanteField;

        private string fechaRegistroField;

        private int periodoImpactoField;

        private bool periodoImpactoFieldSpecified;

        private CuentaType cuentaFinanciadoraField;

        private bool? pagoDirectoField;

        private service.MedioDePagoType? medioDePagoField; //Enum MedioDePagoType

        private string importeCompromisoField;

        private string importeDevengadoField;

        private string importePagadoField;

        private string importeDeduccionesField;

        private string importeDeduccionesPagadoField;

        private string importeNetoPagadoField;

        private string uepexField;

        private string observacionesField;

        private ItemPresupuestarioInformeDeGastosType[] itemsPresupuestariosField;

        private ItemNoPresupuestarioInformeDeGastosType[] itemsNoPresupuestariosField;

        //[System.Xml.Serialization.XmlElement("itemsPresupuestarios")]
        //public ItemPresupuestarioInformeDeGastosType[] itemsPresupuestarios { get; set; }

        //[System.Xml.Serialization.XmlElement("itemsNoPresupuestarios")]
        //public ItemNoPresupuestarioInformeDeGastosType[] itemsNoPresupuestarios { get; set; }

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

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string fechaAutorizacion
        {
            get
            {
                return this.fechaAutorizacionField;
                //return Functions.CheckStringFromDateTime(this.fechaAutorizacionField, Constant.DateShortFormat);
            }
            set
            {
                this.fechaAutorizacionField = value;
                //this.fechaAutorizacionField = !string.IsNullOrEmpty(value) && value.Length > 0 ? Functions.CopyStringToFecha(value, Functions.FechaTipo.SIMPLE, Constant.DateShortFormat) : (DateTime?)null;
                this.RaisePropertyChanged("fechaAutorizacion");
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string fechaComprobante
        {
            get
            {
                return this.fechaComprobanteField;
            }
            set
            {
                this.fechaComprobanteField = value;
                this.RaisePropertyChanged("fechaComprobante");
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string fechaRegistro
        {
            get
            {
                return this.fechaRegistroField;
            }
            set
            {
                this.fechaRegistroField = value;
                this.RaisePropertyChanged("fechaRegistro");
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string periodoImpacto
        {
            get
            {
                return Convert.ToString(this.periodoImpactoField);
            }
            set
            {
                this.periodoImpactoField = Functions.CopyStringToInt(value);
                this.RaisePropertyChanged("periodoImpacto");
            }
        }

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

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string pagoDirecto
        {
            get
            {
                return Functions.CheckStringFromBool(this.pagoDirectoField);
            }
            set
            {
                this.pagoDirectoField = Functions.CopyStringToBool(value);
                this.RaisePropertyChanged("pagoDirecto");
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string medioDePago
        {
            get
            {
                return this.medioDePagoField.HasValue ? Functions.CheckStringFromEnum<service.MedioDePagoType>(Convert.ToString(this.medioDePagoField.Value)) : null;
            }
            set
            {
                //Enum.TryParse(value, out this.medioDePagoField);
                this.medioDePagoField = Functions.CopyStringToEnum<service.MedioDePagoType>(value);
                this.RaisePropertyChanged("medioDePago");
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string importeCompromiso
        {
            get
            {
                return this.importeCompromisoField;
                //return Functions.CheckStringFromDecimal(this.importeCompromisoField);
            }
            set
            {
                this.importeCompromisoField = value;
                //this.importeCompromisoField = !string.IsNullOrEmpty(value) && value.Length > 0 ? Functions.CopyStringToDecimal(value) : (decimal?)null;
                this.RaisePropertyChanged("importeCompromiso");
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public string importeDevengado
        {
            get
            {
                return this.importeDevengadoField;
            }
            set
            {
                this.importeDevengadoField = value;
                this.RaisePropertyChanged("importeDevengado");
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public string importePagado
        {
            get
            {
                return this.importePagadoField;
            }
            set
            {
                this.importePagadoField = value;
                this.RaisePropertyChanged("importePagado");
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public string importeDeducciones
        {
            get
            {
                return this.importeDeduccionesField;
            }
            set
            {
                this.importeDeduccionesField = value;
                this.RaisePropertyChanged("importeDeducciones");
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
        public string importeDeduccionesPagado
        {
            get
            {
                return this.importeDeduccionesPagadoField;
            }
            set
            {
                this.importeDeduccionesPagadoField = value;
                this.RaisePropertyChanged("importeDeduccionesPagado");
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
        public string importeNetoPagado
        {
            get
            {
                return this.importeNetoPagadoField;
            }
            set
            {
                this.importeNetoPagadoField = value;
                this.RaisePropertyChanged("importeNetoPagado");
            }
        }

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
        [System.Xml.Serialization.XmlElementAttribute("itemsPresupuestarios", Order = 20)]
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("itemsNoPresupuestarios", Order = 21)]
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

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantes")]
    public class IdentificacionComprobanteType : object, System.ComponentModel.INotifyPropertyChanged
    {
        private string tipoComprobanteField;

        private long? numeroField;

        private long? ejercicioField;

        private string entidadEmisoraField;

        private string tipoRegistroField;

        private string subTipoRegistroField;

        /// <remarks/>
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string numero
        {
            get
            {
                return Functions.CheckStringFromLong(this.numeroField);
            }
            set
            {
                this.numeroField = !string.IsNullOrEmpty(value) && value.Length > 0 ? Functions.CopyStringToLong(value) : (long?)null;
                this.RaisePropertyChanged("numero");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string ejercicio
        {
            get
            {
                return Functions.CheckStringFromLong(this.ejercicioField);
            }
            set
            {
                this.ejercicioField = !string.IsNullOrEmpty(value) && value.Length > 0 ? Functions.CopyStringToLong(value) : (long?)null;
                this.RaisePropertyChanged("ejercicio");
            }
        }

        /// <remarks/>
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

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantes")]
    public class IdentificadorDeTramiteType : object, System.ComponentModel.INotifyPropertyChanged
    {
        private string tipoField;

        private string identificadorField;

        private long? anioField;

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
                return Functions.CheckStringFromLong(this.anioField);
            }
            set
            {
                this.anioField = !string.IsNullOrEmpty(value) && value.Length > 0 ? Functions.CopyStringToLong(value) : (long?)null;
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

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantes")]
    public class DocumentoRespaldatorioType : object, System.ComponentModel.INotifyPropertyChanged
    {
        private string tipoField;

        private long? numeroField;

        private long? ejercicioField;

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
                return Functions.CheckStringFromLong(this.numeroField);
            }
            set
            {
                this.numeroField = !string.IsNullOrEmpty(value) && value.Length > 0 ? Functions.CopyStringToLong(value) : (long?)null;
                this.RaisePropertyChanged("numero");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string ejercicio
        {
            get
            {
                return Functions.CheckStringFromLong(this.ejercicioField);
            }
            set
            {
                this.ejercicioField = !string.IsNullOrEmpty(value) && value.Length > 0 ? Functions.CopyStringToLong(value) : (long?)null;
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

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantes")]
    public class CuentaType : object, System.ComponentModel.INotifyPropertyChanged
    {

        private long? bancoField;

        private string sucursalField;

        private string cuentaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string banco
        {
            get
            {
                return Functions.CheckStringFromLong(this.bancoField);
            }
            set
            {
                this.bancoField = !string.IsNullOrEmpty(value) && value.Length > 0 ? Functions.CopyStringToLong(value) : (long?)null;
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

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantes")]
    public class ImputacionPresupuestariaCreditoType : object, System.ComponentModel.INotifyPropertyChanged
    {
        private string institucionField;

        private long? ejercicioField;

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
                return Functions.CheckStringFromLong(this.ejercicioField);
            }
            set
            {
                this.ejercicioField = !string.IsNullOrEmpty(value) && value.Length > 0 ? Functions.CopyStringToLong(value) : (long?)null;
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

    public class ItemPresupuestarioInformeDeGastosType : object, System.ComponentModel.INotifyPropertyChanged
    {
        private ImputacionPresupuestariaCreditoType imputacionField;

        private UnidadDescentralizadaType udField;

        private CodigoTramoPartidaType recacField;

        private CodigoTramoPartidaType sigadeField;

        private string importeCompromisoField;

        private string importeDevengadoField;

        private string importePagadoField;

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
                return this.importeCompromisoField;
            }
            set
            {
                this.importeCompromisoField = value;
                this.RaisePropertyChanged("importeCompromiso");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string importeDevengado
        {
            get
            {
                return this.importeDevengadoField;
            }
            set
            {
                this.importeDevengadoField = value;
                this.RaisePropertyChanged("importeDevengado");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string importePagado
        {
            get
            {
                return this.importePagadoField;
            }
            set
            {
                this.importePagadoField = value;
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

    public class ItemNoPresupuestarioInformeDeGastosType : object, System.ComponentModel.INotifyPropertyChanged
    {
        private long? axtField;

        private string importeDevengadoField;

        private string importePagadoField;

        private long? ejercicioField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string axt
        {
            get
            {
                return Functions.CheckStringFromLong(this.axtField);
            }
            set
            {
                this.axtField = !string.IsNullOrEmpty(value) && value.Length > 0 ? Functions.CopyStringToLong(value) : (long?)null;
                this.RaisePropertyChanged("axt");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string importeDevengado
        {
            get
            {
                return this.importeDevengadoField;
            }
            set
            {
                this.importeDevengadoField = value;
                this.RaisePropertyChanged("importeDevengado");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string importePagado
        {
            get
            {
                return this.importePagadoField;
            }
            set
            {
                this.importePagadoField = value;
                this.RaisePropertyChanged("importePagado");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string ejercicio
        {
            get
            {
                return Functions.CheckStringFromLong(this.ejercicioField);
            }
            set
            {
                this.ejercicioField = !string.IsNullOrEmpty(value) && value.Length > 0 ? Functions.CopyStringToLong(value) : (long?)null;
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
}