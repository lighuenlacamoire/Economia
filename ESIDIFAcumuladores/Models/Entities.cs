using ESIDIF.Models.Xml;

namespace ESIDIFAcumuladores.Models
{

    [System.Runtime.Serialization.DataContract(Namespace = "https://ws-si.mecon.gov.ar/ws/comprobantesCrgOvMsg")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webService.imputacionesPresupuestarias.esidif.mecon.gov.ar")]
    [System.Xml.Serialization.XmlRoot(ElementName = "acumuladoresCreditoIndicativaResponse", Namespace = "http://webService.imputacionesPresupuestarias.esidif.mecon.gov.ar")]
    public class acumuladoresCreditoIndicativaResponse : IBody, System.ComponentModel.INotifyPropertyChanged
    {
        private Models.acumuladoresCreditoConsulta acumuladoresCreditoIndicativaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public Models.acumuladoresCreditoConsulta acumuladoresCreditoIndicativa
        {
            get
            {
                return acumuladoresCreditoIndicativaField;
            }
            set
            {
                acumuladoresCreditoIndicativaField = value;
                RaisePropertyChanged("acumuladoresCreditoIndicativa");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.Runtime.Serialization.DataContract(Namespace = "http://webService.imputacionesPresupuestarias.esidif.mecon.gov.ar")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://webService.imputacionesPresupuestarias.esidif.mecon.gov.ar")]
    [System.Xml.Serialization.XmlRoot(ElementName = "imputacionCreditoConsulta", Namespace = "http://webService.imputacionesPresupuestarias.esidif.mecon.gov.ar")]
    public class imputacionCreditoConsulta : IBody, System.ComponentModel.INotifyPropertyChanged
    {
        private string ejercicioField;

        private string sectorInstitucionalField;

        private string subSectorInstitucionalField;

        private string caracterInstitucionalField;

        private string jurisdiccionField;

        private string subJurisdiccionField;

        private string entidadField;

        private string servicioField;

        private string programaField;

        private string subProgramaField;

        private string proyectoField;

        private string actividadField;

        private string obraField;

        private string incisoField;

        private string principalField;

        private string parcialField;

        private string subParcialField;

        private string procedenciaField;

        private string fuenteField;

        private string monedaField;

        private string ubicacionGeograficaField;

        private string entidadOrigenDestinoField;

        private string prestamoExternoField;

        private string bapinField;

        private string finalidadField;

        private string funcionField;

        private string clasificadorEconomicoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string ejercicio
        {
            get
            {
                return this.ejercicioField;
            }
            set
            {
                this.ejercicioField = value;
                this.RaisePropertyChanged("ejercicio");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string sectorInstitucional
        {
            get
            {
                return this.sectorInstitucionalField;
            }
            set
            {
                this.sectorInstitucionalField = value;
                this.RaisePropertyChanged("sectorInstitucional");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string subSectorInstitucional
        {
            get
            {
                return this.subSectorInstitucionalField;
            }
            set
            {
                this.subSectorInstitucionalField = value;
                this.RaisePropertyChanged("subSectorInstitucional");
            }
        }


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string caracterInstitucional
        {
            get
            {
                return this.caracterInstitucionalField;
            }
            set
            {
                this.caracterInstitucionalField = value;
                this.RaisePropertyChanged("caracterInstitucional");
            }
        }


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string jurisdiccion
        {
            get
            {
                return this.jurisdiccionField;
            }
            set
            {
                this.jurisdiccionField = value;
                this.RaisePropertyChanged("jurisdiccion");
            }
        }


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public string subJurisdiccion
        {
            get
            {
                return this.subJurisdiccionField;
            }
            set
            {
                this.subJurisdiccionField = value;
                this.RaisePropertyChanged("subJurisdiccion");
            }
        }


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public string entidad
        {
            get
            {
                return this.entidadField;
            }
            set
            {
                this.entidadField = value;
                this.RaisePropertyChanged("entidad");
            }
        }


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public string programa
        {
            get
            {
                return this.programaField;
            }
            set
            {
                this.programaField = value;
                this.RaisePropertyChanged("programa");
            }
        }


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
        public string subPrograma
        {
            get
            {
                return this.subProgramaField;
            }
            set
            {
                this.subProgramaField = value;
                this.RaisePropertyChanged("subPrograma");
            }
        }


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 10)]
        public string proyecto
        {
            get
            {
                return this.proyectoField;
            }
            set
            {
                this.proyectoField = value;
                this.RaisePropertyChanged("proyecto");
            }
        }


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 11)]
        public string actividad
        {
            get
            {
                return this.actividadField;
            }
            set
            {
                this.actividadField = value;
                this.RaisePropertyChanged("actividad");
            }
        }


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 12)]
        public string obra
        {
            get
            {
                return this.obraField;
            }
            set
            {
                this.obraField = value;
                this.RaisePropertyChanged("obra");
            }
        }


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 13)]
        public string inciso
        {
            get
            {
                return this.incisoField;
            }
            set
            {
                this.incisoField = value;
                this.RaisePropertyChanged("inciso");
            }
        }


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 14)]
        public string principal
        {
            get
            {
                return this.principalField;
            }
            set
            {
                this.principalField = value;
                this.RaisePropertyChanged("principal");
            }
        }


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 15)]
        public string parcial
        {
            get
            {
                return this.parcialField;
            }
            set
            {
                this.parcialField = value;
                this.RaisePropertyChanged("parcial");
            }
        }


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 16)]
        public string subParcial
        {
            get
            {
                return this.subParcialField;
            }
            set
            {
                this.subParcialField = value;
                this.RaisePropertyChanged("subParcial");
            }
        }


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 17)]
        public string procedencia
        {
            get
            {
                return this.procedenciaField;
            }
            set
            {
                this.procedenciaField = value;
                this.RaisePropertyChanged("procedencia");
            }
        }


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 18)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 19)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 20)]
        public string ubicacionGeografica
        {
            get
            {
                return this.ubicacionGeograficaField;
            }
            set
            {
                this.ubicacionGeograficaField = value;
                this.RaisePropertyChanged("ubicacionGeografica");
            }
        }


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 21)]
        public string entidadOrigenDestino
        {
            get
            {
                return this.entidadOrigenDestinoField;
            }
            set
            {
                this.entidadOrigenDestinoField = value;
                this.RaisePropertyChanged("entidadOrigenDestino");
            }
        }


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 22)]
        public string prestamoExterno
        {
            get
            {
                return this.prestamoExternoField;
            }
            set
            {
                this.prestamoExternoField = value;
                this.RaisePropertyChanged("prestamoExterno");
            }
        }


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 23)]
        public string bapin
        {
            get
            {
                return this.bapinField;
            }
            set
            {
                this.bapinField = value;
                this.RaisePropertyChanged("bapin");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 24)]
        public string finalidad
        {
            get
            {
                return this.finalidadField;
            }
            set
            {
                this.finalidadField = value;
                this.RaisePropertyChanged("finalidad");
            }
        }


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 25)]
        public string funcion
        {
            get
            {
                return this.funcionField;
            }
            set
            {
                this.funcionField = value;
                this.RaisePropertyChanged("funcion");
            }
        }


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 26)]
        public string clasificadorEconomico
        {
            get
            {
                return this.clasificadorEconomicoField;
            }
            set
            {
                this.clasificadorEconomicoField = value;
                this.RaisePropertyChanged("clasificadorEconomico");
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

    /// <remarks/>
    [System.Runtime.Serialization.DataContract(Namespace = "http://webService.imputacionesPresupuestarias.esidif.mecon.gov.ar")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webService.imputacionesPresupuestarias.esidif.mecon.gov.ar")]
    [System.Xml.Serialization.XmlRoot(ElementName = "acumuladoresCreditoIndicativa", Namespace = "http://webService.imputacionesPresupuestarias.esidif.mecon.gov.ar")]
    public class acumuladoresCreditoConsulta : IBody, System.ComponentModel.INotifyPropertyChanged
    {
        private string compromisoField;

        private string creditoInicialEjercicioField;

        private string creditoInicialProrrogaField;

        private string creditoPotencialField;

        private string creditoRestringidoField;

        private string creditoVigenteField;

        private string devengadoField;

        private string gastoPreventivoField;

        private string pagadoField;

        private string pagadoFinancieroField;

        private string reservaCompromisoField;

        private string reservaDevengadoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string compromiso
        {
            get
            {
                return compromisoField;
            }
            set
            {
                compromisoField = value;
                RaisePropertyChanged("compromiso");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string creditoInicialEjercicio
        {
            get
            {
                return creditoInicialEjercicioField;
            }
            set
            {
                creditoInicialEjercicioField = value;
                RaisePropertyChanged("creditoInicialEjercicio");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string creditoInicialProrroga
        {
            get
            {
                return creditoInicialProrrogaField;
            }
            set
            {
                creditoInicialProrrogaField = value;
                RaisePropertyChanged("creditoInicialProrroga");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string creditoPotencial
        {
            get
            {
                return creditoPotencialField;
            }
            set
            {
                creditoPotencialField = value;
                RaisePropertyChanged("creditoPotencial");
            }
        }


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string creditoRestringido
        {
            get
            {
                return creditoRestringidoField;
            }
            set
            {
                creditoRestringidoField = value;
                RaisePropertyChanged("creditoRestringido");
            }
        }


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public string creditoVigente
        {
            get
            {
                return creditoVigenteField;
            }
            set
            {
                creditoVigenteField = value;
                RaisePropertyChanged("creditoVigente");
            }
        }


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public string devengado
        {
            get
            {
                return devengadoField;
            }
            set
            {
                devengadoField = value;
                RaisePropertyChanged("devengado");
            }
        }


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public string gastoPreventivo
        {
            get
            {
                return gastoPreventivoField;
            }
            set
            {
                gastoPreventivoField = value;
                RaisePropertyChanged("gastoPreventivo");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public string pagado
        {
            get
            {
                return pagadoField;
            }
            set
            {
                pagadoField = value;
                RaisePropertyChanged("pagado");
            }
        }


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
        public string pagadoFinanciero
        {
            get
            {
                return pagadoFinancieroField;
            }
            set
            {
                pagadoFinancieroField = value;
                RaisePropertyChanged("pagadoFinanciero");
            }
        }


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 10)]
        public string reservaCompromiso
        {
            get
            {
                return reservaCompromisoField;
            }
            set
            {
                reservaCompromisoField = value;
                RaisePropertyChanged("reservaCompromiso");
            }
        }


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 11)]
        public string reservaDevengado
        {
            get
            {
                return reservaDevengadoField;
            }
            set
            {
                reservaDevengadoField = value;
                RaisePropertyChanged("reservaDevengado");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

}
