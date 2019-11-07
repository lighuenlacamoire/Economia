using ESIDIFCommon.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ESIDIFAcumuladores.Models
{

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantes")]
    public class Prueba : object, System.ComponentModel.INotifyPropertyChanged
    {
        private decimal? tipoField;

        private string identificadorField;


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string tipo
        {
            get
            {
                //return null;
                return Functions.CopyDecimalToString(this.tipoField);
                //return !string.IsNullOrEmpty(this.tipoField) && this.tipoField.Length > 0 ? Functions.CopyStringToDecimal(this.tipoField) : (decimal?)null;
                
            }
            set
            {
                this.tipoField = !string.IsNullOrEmpty(value) && value.Length > 0 ? Functions.CopyStringToDecimal(value) : (decimal?)null;
                
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