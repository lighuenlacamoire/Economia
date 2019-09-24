using ESIDIFCommon.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ESIDIFCredito.Models
{
    public class ZfmWsCredito : object, System.ComponentModel.INotifyPropertyChanged
    {
        private CreditoCabecera iCabeceraField;

        private EntradasCredito[] itEntradaCreditoField;

        private EntradasRecurso[] itEntradaRecursoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public CreditoCabecera ICabecera
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
        [System.Xml.Serialization.XmlArrayAttribute("ItEntradaCredito", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", typeof(EntradasCredito), ElementName = "item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public EntradasCredito[] ItEntradaCredito
        {
            get
            {
                return this.itEntradaCreditoField;
            }
            set
            {
                this.itEntradaCreditoField = value;
                this.RaisePropertyChanged("ItEntradaCredito");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute("ItEntradaRecurso", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", typeof(EntradasRecurso), ElementName = "item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public EntradasRecurso[] ItEntradaRecurso
        {
            get
            {
                return this.itEntradaRecursoField;
            }
            set
            {
                this.itEntradaRecursoField = value;
                this.RaisePropertyChanged("ItEntradaRecurso");
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
    public class CreditoCabecera : object, System.ComponentModel.INotifyPropertyChanged
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
                this.FechaenvioField = value;//Funciones.CopyStringToFecha(value, Funciones.FechaTipo.COMPUESTA, "yyyy-MM-ddTHH:mm:ffff");
                this.RaisePropertyChanged("Fechaenvio");
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 128)]//enum no sera 4?
        public string Tipocomprobante { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 4)]
        public string Ejercicio { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 20)]
        public string Numerocomprobante { get; set; }

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
                this.FechaaplicacionField = value;// Funciones.CopyStringToFecha(value, Funciones.FechaTipo.COMPUESTA, "yyyy-MM-ddTHH:mm:ffff");
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
                this.FechaactoadministrativoField = value;// Funciones.CopyStringToFecha(value, Funciones.FechaTipo.COMPUESTA, "yyyy-MM-ddTHH:mm:ffff");
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
    public class EntradasCredito : object, System.ComponentModel.INotifyPropertyChanged
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
        public string Ubicaciongeografica { get; set; }

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
        [longiAttr(Longitud = 6)]
        public string Moneda { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 6)]
        public string Entidadorigendestino { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 15)]
        public string Prestamoexterno { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 8)]
        public string Clasificadoreconomicocredito { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 6)]
        public string Finalidad { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 6)]
        public string Funcion { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 6)]
        public string Bapin { get; set; }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 22)]
        public string Creditoinicial { get; set; }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 22)]
        public string Creditovigente { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 22)]
        public string Creditorestringido { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 22)]
        public string Importecomprobantecredito { get; set; }

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
    public class EntradasRecurso : object, System.ComponentModel.INotifyPropertyChanged
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
        public string Tipo { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 6)]
        public string Clase { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 6)]
        public string Concepto { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 6)]
        public string Subconcepto { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 10)]
        public string Procedencia { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 10)]
        public string Fuente { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 6)]
        public string Moneda { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 6)]
        public string Entidadorigendestino { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 15)]
        public string Prestamoexterno { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 8)]
        public string Clasificadoreconomicorecurso { get; set; }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 22)]
        public string Recursoinicial { get; set; }


        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 22)]
        public string Recursovigente { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 22)]
        public string Recursorestringido { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [longiAttr(Longitud = 22)]
        public string Importecomprobanterecurso { get; set; }

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