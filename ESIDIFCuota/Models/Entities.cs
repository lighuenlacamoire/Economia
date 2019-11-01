using ESIDIFCommon.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ESIDIFCuota.Models
{
    public class ZfmWsCuota : object, System.ComponentModel.INotifyPropertyChanged
    {
        private ICabecera iCabeceraField;

        private IEntradaCuota[] itEntradaCuotaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public ICabecera ICabecera
        {
            get
            {
                return this.iCabeceraField;
            }
            set
            {
                this.iCabeceraField = value;
                this.RaisePropertyChanged("ICabecera");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute("ItEntradaCuota", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", typeof(IEntradaCuota), ElementName = "item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public IEntradaCuota[] ItEntradaCuota
        {
            get
            {
                return this.itEntradaCuotaField;
            }
            set
            {
                this.itEntradaCuotaField = value;
                this.RaisePropertyChanged("ItEntradaCuota");
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
    public class ICabecera : object, System.ComponentModel.INotifyPropertyChanged
    {
        private string FechaenvioField;

        private string FechaaplicacionField;

        private string FechaactoadministrativoField;

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 25)]
        public string Fechaenvio
        {
            get
            {
                return this.FechaenvioField;//.ToString("yyyy-MM-ddTHH:mm:ffff");
            }
            set
            {
                this.FechaenvioField = value;// Funciones.CopyStringToFecha(value, Funciones.FechaTipo.COMPUESTA, "yyyy-MM-ddTHH:mm:ffff");
                this.RaisePropertyChanged("Fechaenvio");
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 128)]
        public string Tipocomprobante { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 4)]
        public string Ejercicio { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 20)]
        public string Numerocomprobante { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 10)]
        public string Periodo { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 10)]
        public string Entidademisora { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 10)]
        public string Entidadproceso { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 25)]
        public string Estado { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 25)]
        public string Fechaaplicacion
        {
            get
            {
                return this.FechaaplicacionField;//.ToString("yyyy-MM-ddTHH:mm:ffff");
            }
            set
            {
                this.FechaaplicacionField = value;//Funciones.CopyStringToFecha(value, Funciones.FechaTipo.COMPUESTA, "yyyy-MM-ddTHH:mm:ffff");
                this.RaisePropertyChanged("Fechaaplicacion");
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 4)]
        public string Ejercicioactoadm { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 20)]
        public string Numeroactoadm { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 128)]
        public string Tipoactoadm { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 25)]
        public string Fechaactoadm
        {
            get
            {
                return this.FechaactoadministrativoField;//.ToString("yyyy-MM-ddTHH:mm:ffff");
            }
            set
            {
                this.FechaactoadministrativoField = value;//Funciones.CopyStringToFecha(value, Funciones.FechaTipo.COMPUESTA, "yyyy-MM-ddTHH:mm:ffff");
                this.RaisePropertyChanged("Fechaactoadm");
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 5)]
        public string Codigoconcepto { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 128)]
        public string Descripcionconcepto { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 136)]
        public string Identificaciontramite { get; set; }


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
    public class IEntradaCuota : object, System.ComponentModel.INotifyPropertyChanged
    {

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 6)]
        public string Sector { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 6)]
        public string Subsector { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 6)]
        public string Caracter { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 10)]
        public string Jurisdiccion { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 10)]
        public string Subjurisdiccion { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 10)]
        public string Entidad { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 10)]
        public string Saf { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 6)]
        public string Programa { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 6)]
        public string Subprograma { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 6)]
        public string Proyecto { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 6)]
        public string Actividad { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 6)]
        public string Obra { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 6)]
        public string Inciso { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 6)]
        public string Principal { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 6)]
        public string Parcial { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 6)]
        public string Subparcial { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 10)]
        public string Procedencia { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 10)]
        public string Fuente { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 22)]
        public string Compromisoinicial { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 22)]
        public string Compromisovigente { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 22)]
        public string Compromisorestringido { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 22)]
        public string Devengadoinicial1 { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 22)]
        public string Devengadovigente1 { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 22)]
        public string Devengadorestringido1 { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 22)]
        public string Devengadoinicial2 { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 22)]
        public string Devengadovigente2 { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 22)]
        public string Devengadorestringido2 { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 22)]
        public string Devengadoinicial3 { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 22)]
        public string Devengadovigente3 { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 22)]
        public string Devengadorestringido3 { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 22)]
        public string Compromisocomprobante { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 22)]
        public string Devengado1comprobante { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 22)]
        public string Devengado2comprobante { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 22)]
        public string Devengado3comprobante { get; set; }


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
    public class EOuput
    {
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 1)]
        public string Type { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 220)]
        public string Message { get; set; }
    }
}

