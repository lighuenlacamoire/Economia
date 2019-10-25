using ESIDIFCommon.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ESIDIFLimitativa.Models
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public class consultarLimitativaCreditoRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://webService.imputacionesPresupuestarias.esidif.mecon.gov.ar", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public ESIDIFLimitativa.Models.imputacionCreditoConsulta imputacionPresupuestariaCreditoIndicativa;

        public consultarLimitativaCreditoRequest()
        {
        }

        public consultarLimitativaCreditoRequest(ESIDIFLimitativa.Models.imputacionCreditoConsulta imputacionPresupuestariaCreditoIndicativa)
        {
            this.imputacionPresupuestariaCreditoIndicativa = imputacionPresupuestariaCreditoIndicativa;
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3221.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://webService.imputacionesPresupuestarias.esidif.mecon.gov.ar")]
    public class imputacionCreditoConsulta : object, System.ComponentModel.INotifyPropertyChanged
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

        private long clasificadorEconomicoField;

        private bool clasificadorEconomicoFieldSpecified;

        private long finalidadField;

        private bool finalidadFieldSpecified;

        private long funcionField;

        private bool funcionFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string sectorInstitucional
        {
            get
            {
                return Convert.ToString(this.sectorInstitucionalField);
            }
            set
            {
                this.sectorInstitucionalField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("sectorInstitucional");
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
                this.RaisePropertyChanged("sectorInstitucionalSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string subSectorInstitucional
        {
            get
            {
                return Convert.ToString(this.subSectorInstitucionalField);
            }
            set
            {
                this.subSectorInstitucionalField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("subSectorInstitucional");
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
                this.RaisePropertyChanged("subSectorInstitucionalSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string caracterInstitucional
        {
            get
            {
                return Convert.ToString(this.caracterInstitucionalField);
            }
            set
            {
                this.caracterInstitucionalField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("caracterInstitucional");
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
                this.RaisePropertyChanged("caracterInstitucionalSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string jurisdiccion
        {
            get
            {
                return Convert.ToString(this.jurisdiccionField);
            }
            set
            {
                this.jurisdiccionField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("jurisdiccion");
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
                this.RaisePropertyChanged("jurisdiccionSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public string subJurisdiccion
        {
            get
            {
                return Convert.ToString(this.subJurisdiccionField);
            }
            set
            {
                this.subJurisdiccionField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("subJurisdiccion");
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
                this.RaisePropertyChanged("subJurisdiccionSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public string entidad
        {
            get
            {
                return Convert.ToString(this.entidadField);
            }
            set
            {
                this.entidadField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("entidad");
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
                this.RaisePropertyChanged("entidadSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public string servicio
        {
            get
            {
                return Convert.ToString(this.servicioField);
            }
            set
            {
                this.servicioField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("servicio");
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
                this.RaisePropertyChanged("servicioSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public string programa
        {
            get
            {
                return Convert.ToString(this.programaField);
            }
            set
            {
                this.programaField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("programa");
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
                this.RaisePropertyChanged("programaSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
        public string subPrograma
        {
            get
            {
                return Convert.ToString(this.subProgramaField);
            }
            set
            {
                this.subProgramaField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("subPrograma");
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
                this.RaisePropertyChanged("subProgramaSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 10)]
        public string proyecto
        {
            get
            {
                return Convert.ToString(this.proyectoField);
            }
            set
            {
                this.proyectoField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("proyecto");
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
                this.RaisePropertyChanged("proyectoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 11)]
        public string actividad
        {
            get
            {
                return Convert.ToString(this.actividadField);
            }
            set
            {
                this.actividadField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("actividad");
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
                this.RaisePropertyChanged("actividadSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 12)]
        public string obra
        {
            get
            {
                return Convert.ToString(this.obraField);
            }
            set
            {
                this.obraField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("obra");
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
                this.RaisePropertyChanged("obraSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 13)]
        public string inciso
        {
            get
            {
                return Convert.ToString(this.incisoField);
            }
            set
            {
                this.incisoField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("inciso");
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
                this.RaisePropertyChanged("incisoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 14)]
        public string principal
        {
            get
            {
                return Convert.ToString(this.principalField);
            }
            set
            {
                this.principalField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("principal");
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
                this.RaisePropertyChanged("principalSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 15)]
        public string parcial
        {
            get
            {
                return Convert.ToString(this.parcialField);
            }
            set
            {
                this.parcialField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("parcial");
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
                this.RaisePropertyChanged("parcialSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 16)]
        public string subParcial
        {
            get
            {
                return Convert.ToString(this.subParcialField);
            }
            set
            {
                this.subParcialField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("subParcial");
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
                this.RaisePropertyChanged("subParcialSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 17)]
        public string procedencia
        {
            get
            {
                return Convert.ToString(this.procedenciaField);
            }
            set
            {
                this.procedenciaField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("procedencia");
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
                this.RaisePropertyChanged("procedenciaSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 18)]
        public string fuente
        {
            get
            {
                return Convert.ToString(this.fuenteField);
            }
            set
            {
                this.fuenteField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("fuente");
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
                this.RaisePropertyChanged("fuenteSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 19)]
        public string moneda
        {
            get
            {
                return Convert.ToString(this.monedaField);
            }
            set
            {
                this.monedaField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("moneda");
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
                this.RaisePropertyChanged("monedaSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 20)]
        public string ubicacionGeografica
        {
            get
            {
                return Convert.ToString(this.ubicacionGeograficaField);
            }
            set
            {
                this.ubicacionGeograficaField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("ubicacionGeografica");
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
                this.RaisePropertyChanged("ubicacionGeograficaSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 21)]
        public string entidadOrigenDestino
        {
            get
            {
                return Convert.ToString(this.entidadOrigenDestinoField);
            }
            set
            {
                this.entidadOrigenDestinoField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("entidadOrigenDestino");
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
                this.RaisePropertyChanged("entidadOrigenDestinoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 22)]
        public string prestamoExterno
        {
            get
            {
                return Convert.ToString(this.prestamoExternoField);
            }
            set
            {
                this.prestamoExternoField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("prestamoExterno");
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
                this.RaisePropertyChanged("prestamoExternoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 23)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 24)]
        public string clasificadorEconomico
        {
            get
            {
                return Convert.ToString(this.clasificadorEconomicoField);
            }
            set
            {
                this.clasificadorEconomicoField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("clasificadorEconomico");
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
                this.RaisePropertyChanged("clasificadorEconomicoSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 25)]
        public string finalidad
        {
            get
            {
                return Convert.ToString(this.finalidadField);
            }
            set
            {
                this.finalidadField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("finalidad");
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
                this.RaisePropertyChanged("finalidadSpecified");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 26)]
        public string funcion
        {
            get
            {
                return Convert.ToString(this.funcionField);
            }
            set
            {
                this.funcionField = Functions.CopyStringToLong(value);
                this.RaisePropertyChanged("funcion");
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
                this.RaisePropertyChanged("funcionSpecified");
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