using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml;
using ESIDIFCredito.Business;
using ESIDIFCredito.Models;
using ESIDIFLegacy.Models.Director;
using log4net;

namespace ESIDIFCredito
{
    [WebService(Namespace = "urn:sap-com:document:sap:soap:functions:mc-style", Description = "ESIDIFCreditorecurso", Name = "CreditoService")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    //Este servivio es consumido por el Ministerio de Economia y accede a SAP
    public class CreditoService : System.Web.Services.WebService
    {
        private Sources _sources = new Sources();

        service.ZWS_CREDITOClient _service = new service.ZWS_CREDITOClient();

        public CreditoService()
        {
        }

        #region Usuario Token
        public User UsuarioSession
        {
            get
            {
                if (Session["UsuarioSession"] == null)
                    Session["UsuarioSession"] = new User();
                return Session["UsuarioSession"] as User;
            }
            set { Session["UsuarioSession"] = value; }
        }
        #endregion

        public SoapUnknownHeader[] unknownHeaders;

        [WebMethod(Description = "ESIDIFCreditorecurso")]
        [SoapDocumentMethod(Action = "/PresupuestoCredito", ResponseNamespace = "*")]
        [SoapHeader("unknownHeaders")]
        public EOuput PresupuestoCredito([System.Xml.Serialization.XmlElementAttribute("ZfmWsCredito")]ZfmWsCredito consulta)
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw;
            }


            #region Configuracion del envio de Mail
            string mailDestinatarios = ConfigurationManager.AppSettings["Emails"];
            string mailMensaje = string.Empty;
            bool mailError = false;
            #endregion

            bool requestError = false;
            string request = string.Empty;
            string requestXml = string.Empty;

            log.Debug("Entra ESIDIFCreditorecurso");

            try
            {
                #region Request to XML
                if (consulta != null)
                {
                    try
                    {
                        //request = ((XmlDocument)Funciones.GenericToXmlDocument(consulta)).InnerXml;
                        //requestXml = Funciones.TransformarXml(request);

                    }
                    catch (Exception ex)
                    {
                        log.Error("Error transformando request Xml: " + ex.Message);
                    }
                }
                else
                {
                    mailError = true;
                    mailMensaje += "\n La solicitud recibida desde Economía se encuentra vacia, lo cual puede darse por las siguientes razones:" + "  " +
                        "<br/> \n * No se ha enviado el objeto en el Body" +
                        "<br/> \n * No se ha respetado la estructura del objeto" +
                        "<br/> \n * No se ha enviado el objeto con el Namespace correspondiente" +
                        "<br/> \n * No se han enviado los objetos con los prefijos correspondientes a causa de envio incorrecto o no envio del Namespace" +
                        "<br/> \n";
                }
                #endregion

                #region Director Credenciales
                try
                {
                    if (!UsuarioSession.HasToken)
                    {
                        UsuarioSession = new UserLogged().ObtenerDatosToken(unknownHeaders, "token");
                    }

                    if (UsuarioSession != null &&
                        !string.IsNullOrEmpty(UsuarioSession.Entity) && UsuarioSession.Entity.Length > 0 &&
                        !string.IsNullOrEmpty(UsuarioSession.IP) && UsuarioSession.IP.Length > 0)
                    {
                        log.Info("ESIDIFCreditorecurso - Usuario CUIT: " + UsuarioSession.Entity + " IP: " + UsuarioSession.IP);
                    }
                    else
                    {
                        throw new Exception("Ocurrio un error al obtener las credenciales");
                    }
                }
                catch (Exception ex)
                {
                    log.Error("Error Director: " + ex.Message);
                }
                #endregion

                service.ZfmWsCredito ocredito = new service.ZfmWsCredito();

                //Asignacion CUIL e IP
                ocredito.ICuilUser = UsuarioSession.Entity;
                ocredito.IIpUser = UsuarioSession.IP;

                #region Validacion Cabecera
                if (consulta != null && consulta.ICabecera != null)
                {

                    var validadorCabecera = new validadorLongitud<CreditoCabecera>();

                    var erroresCreditoCabecera = validadorCabecera.validarLongitud(consulta.ICabecera);

                    log.Debug("Invoco --> validar longuitud ICabecera: " + consulta.ICabecera.ToString());

                    if (erroresCreditoCabecera.Count > 0)
                    {
                        mailError = true;
                        mailMensaje += "\n Se produjo un error al recibir información desde Economía:" + "  ";
                        foreach (var item in erroresCreditoCabecera)
                        {
                            mailMensaje += "<br/> \n Se ha registrado un error en la longuitud del objeto Cabecera en el campo " +
                                 item.Nombre + " donde su longuitud es " + item.Longitud + " y tendria que ser: " + item.LongitudEsperada;

                        }

                        log.ErrorFormat("Errores: " + mailMensaje);
                    }
                    else
                    {
                        ocredito.ICabecera = new service.ZdsCreditoCabecera();
                        ocredito.ICabecera.Fechaenvio = consulta.ICabecera.Fechaenvio;
                        ocredito.ICabecera.Tipocomprobante = consulta.ICabecera.Tipocomprobante;
                        ocredito.ICabecera.Ejercicio = consulta.ICabecera.Ejercicio;
                        ocredito.ICabecera.Numerocomprobante = consulta.ICabecera.Numerocomprobante;
                        ocredito.ICabecera.Entidademisora = consulta.ICabecera.Entidademisora;
                        ocredito.ICabecera.Entidadproceso = consulta.ICabecera.Entidadproceso;
                        ocredito.ICabecera.Estado = consulta.ICabecera.Estado;
                        ocredito.ICabecera.Fechaaplicacion = consulta.ICabecera.Fechaaplicacion;
                        ocredito.ICabecera.Ejercicioactoadm = consulta.ICabecera.Ejercicioactoadm;
                        ocredito.ICabecera.Numeroactoadm = consulta.ICabecera.Numeroactoadm;
                        ocredito.ICabecera.Tipoactoadm = consulta.ICabecera.Tipoactoadm;
                        ocredito.ICabecera.Fechaactoadm = consulta.ICabecera.Fechaactoadm;
                        ocredito.ICabecera.Codigoconcepto = consulta.ICabecera.Codigoconcepto;
                        ocredito.ICabecera.Descripcionconcepto = consulta.ICabecera.Descripcionconcepto;
                        ocredito.ICabecera.Identificaciontramite = consulta.ICabecera.Identificaciontramite;

                    }
                }
                else
                {
                    mailError = true;
                    mailMensaje += " <br/> \n  No se ha enviado el objeto ICabecera \n ";
                }

                #endregion

                #region Validacion Entradas Credito

                if (consulta != null && consulta.ItEntradaCredito != null && consulta.ItEntradaCredito.Any())
                {

                    var validadorEntraCredito = new validadorLongitud<EntradasCredito>();

                    List<service.ZdsEntradasCredito> EntradasCredito = new List<service.ZdsEntradasCredito>();

                    foreach (var item in consulta.ItEntradaCredito)
                    {

                        var erroresEntradaCredito = validadorEntraCredito.validarLongitud(item);

                        log.Debug("Invoco --> validar longuitud ITEntradaCredito: " + consulta.ItEntradaCredito.ToString());

                        if (erroresEntradaCredito.Count > 0)
                        {
                            mailError = true;
                            foreach (var item2 in erroresEntradaCredito)
                            {
                                mailMensaje += "<br/> \n Se ha registrado un error en la longuitud del objeto entrada credito en el campo " +
                                    item2.Nombre + " donde su longuitud es " + item2.Longitud + " y tendria que ser: " + item2.LongitudEsperada;

                            }

                            log.ErrorFormat("Errores: " + mailMensaje);
                        }
                        else
                        {
                            var itemCredito = new service.ZdsEntradasCredito();
                            itemCredito.Sector = item.Sector;
                            itemCredito.Subsector = item.Subsector;
                            itemCredito.Caracter = item.Caracter;
                            itemCredito.Jurisdiccion = item.Jurisdiccion;
                            itemCredito.Subjurisdiccion = item.Subjurisdiccion;
                            itemCredito.Entidad = item.Entidad;
                            itemCredito.Saf = item.Saf;
                            itemCredito.Programa = item.Programa;
                            itemCredito.Subprograma = item.Subprograma;
                            itemCredito.Proyecto = item.Proyecto;
                            itemCredito.Actividad = item.Actividad;
                            itemCredito.Obra = item.Obra;
                            itemCredito.Ubicaciongeografica = item.Ubicaciongeografica;
                            itemCredito.Inciso = item.Inciso;
                            itemCredito.Principal = item.Principal;
                            itemCredito.Parcial = item.Parcial;
                            itemCredito.Subparcial = item.Subparcial;
                            itemCredito.Procedencia = item.Procedencia;
                            itemCredito.Fuente = item.Fuente;
                            itemCredito.Moneda = item.Moneda;
                            itemCredito.Entidadorigendestino = item.Entidadorigendestino;
                            itemCredito.Prestamoexterno = item.Prestamoexterno;
                            itemCredito.Clasificadoreconomicocredito = item.Clasificadoreconomicocredito;
                            itemCredito.Finalidad = item.Finalidad;
                            itemCredito.Funcion = item.Funcion;
                            itemCredito.Bapin = item.Bapin;
                            itemCredito.Creditoinicial = item.Creditoinicial;
                            itemCredito.Creditovigente = item.Creditovigente;
                            itemCredito.Creditorestringido = item.Creditorestringido;
                            itemCredito.Importecomprobantecredito = item.Importecomprobantecredito;

                            EntradasCredito.Add(itemCredito);
                        }

                        if (!string.IsNullOrEmpty(item.Creditoinicial) && item.Creditoinicial.Contains(","))
                        {
                            mailError = true;
                            mailMensaje += "<br/> \n Se ha registrado un error en el objeto entrada credito en el campo " + " " +
                                    "Creditoinicial" + " contiene " + " " + "coma(,)" + " " + " en lugar de " + "punto(.)";
                        }

                        if (!string.IsNullOrEmpty(item.Creditovigente) && item.Creditovigente.Contains(","))
                        {
                            mailError = true;
                            mailMensaje += "<br/> \n Se ha registrado un error en el objeto entrada credito en el campo " + " " +
                                    "Creditovigente" + " contiene " + " " + "coma(,)" + " " + " en lugar de " + "punto(.)";
                        }

                        if (!string.IsNullOrEmpty(item.Creditorestringido) && item.Creditorestringido.Contains(","))
                        {
                            mailError = true;
                            mailMensaje += "<br/> \n Se ha registrado un error en el objeto entrada credito en el campo " + " " +
                                    "Creditorestringido" + " contiene " + " " + "coma(,)" + " " + " en lugar de " + "punto(.)";
                        }

                        if (!string.IsNullOrEmpty(item.Importecomprobantecredito) && item.Importecomprobantecredito.Contains(","))
                        {
                            mailError = true;
                            mailMensaje += "<br/> \n Se ha registrado un error en el objeto entrada credito en el campo " + " " +
                                    "Importecomprobantecredito" + " contiene " + " " + "coma(,)" + " " + " en lugar de " + "punto(.)";
                        }
                    }

                    if (EntradasCredito != null && EntradasCredito.Count > 0)
                    {
                        ocredito.ItEntradaCredito = EntradasCredito.ToArray();
                    }
                }
                else
                {
                    //mailError = true;
                    //mailMensaje += " <br/> \n  No se ha enviado el objeto ITEntradaCredito \n ";
                }

                #endregion

                #region Validacion Entradas Recursos

                if (consulta != null && consulta.ItEntradaRecurso != null && consulta.ItEntradaRecurso.Any())
                {

                    var validadorEntraRecurso = new validadorLongitud<EntradasRecurso>();

                    List<service.ZdsEntradasRecurso> EntradasRecurso = new List<service.ZdsEntradasRecurso>();

                    foreach (var item in consulta.ItEntradaRecurso)
                    {

                        var erroresEntradaRecurso = validadorEntraRecurso.validarLongitud(item);

                        log.Debug("Invoco --> validar longuitud ITEntradaRecurso: " + consulta.ItEntradaRecurso.ToString());

                        if (erroresEntradaRecurso.Count > 0)
                        {
                            mailError = true;
                            foreach (var item2 in erroresEntradaRecurso)
                            {
                                mailMensaje += "<br/> \n Se ha registrado un error en la longuitud del objeto entrada recurso en el campo " +
                                    item2.Nombre + " donde su longuitud es " + item2.Longitud + " y tendria que ser: " + item2.LongitudEsperada;

                            }

                            log.ErrorFormat("Errores: " + mailMensaje);
                        }
                        else
                        {
                            var itemRecurso = new service.ZdsEntradasRecurso();
                            itemRecurso.Sector = item.Sector;
                            itemRecurso.Subsector = item.Subsector;
                            itemRecurso.Caracter = item.Caracter;
                            itemRecurso.Jurisdiccion = item.Jurisdiccion;
                            itemRecurso.Subjurisdiccion = item.Subjurisdiccion;
                            itemRecurso.Entidad = item.Entidad;
                            itemRecurso.Saf = item.Saf;
                            itemRecurso.Tipo = item.Tipo;
                            itemRecurso.Clase = item.Clase;
                            itemRecurso.Concepto = item.Concepto;
                            itemRecurso.Subconcepto = item.Subconcepto;
                            itemRecurso.Procedencia = item.Procedencia;
                            itemRecurso.Fuente = item.Fuente;
                            itemRecurso.Moneda = item.Moneda;
                            itemRecurso.Entidadorigendestino = item.Entidadorigendestino;
                            itemRecurso.Prestamoexterno = item.Prestamoexterno;
                            itemRecurso.Clasificadoreconomicorecurso = item.Clasificadoreconomicorecurso;
                            itemRecurso.Recursoinicial = item.Recursoinicial;
                            itemRecurso.Recursorestringido = item.Recursorestringido;
                            itemRecurso.Recursovigente = item.Recursovigente;
                            itemRecurso.Importecomprobanterecurso = item.Importecomprobanterecurso;

                            EntradasRecurso.Add(itemRecurso);
                        }


                        if (!string.IsNullOrEmpty(item.Recursoinicial) && item.Recursoinicial.Contains(","))
                        {
                            mailError = true;
                            mailMensaje += "<br/> \n Se ha registrado un error en el objeto entrada recurso en el campo " + " " +
                                    "Recursoinicial" + " contiene " + " " + "coma(,)" + " " + " en lugar de " + "punto(.)";
                        }

                        if (!string.IsNullOrEmpty(item.Recursovigente) && item.Recursovigente.Contains(","))
                        {
                            mailError = true;
                            mailMensaje += "<br/> \n Se ha registrado un error en el objeto entrada recurso en el campo " + " " +
                                    "Recursovigente" + " contiene " + " " + "coma(,)" + " " + " en lugar de " + "punto(.)";
                        }

                        if (!string.IsNullOrEmpty(item.Recursorestringido) && item.Recursorestringido.Contains(","))
                        {
                            mailError = true;
                            mailMensaje += "<br/> \n Se ha registrado un error en el objeto entrada recurso en el campo " + " " +
                                    "Recursorestringido" + " contiene " + " " + "coma(,)" + " " + " en lugar de " + "punto(.)";
                        }

                        if (!string.IsNullOrEmpty(item.Importecomprobanterecurso) && item.Importecomprobanterecurso.Contains(","))
                        {
                            mailError = true;
                            mailMensaje += "<br/> \n Se ha registrado un error en el objeto entrada recurso en el campo " + " " +
                                    "Importecomprobanterecurso" + " contiene " + " " + "coma(,)" + " " + " en lugar de " + "punto(.)";
                        }
                    }

                    if (EntradasRecurso != null && EntradasRecurso.Count > 0)
                    {
                        ocredito.ItEntradaRecurso = EntradasRecurso.ToArray();
                    }
                }
                else
                {
                    //mailError = true;
                    //mailMensaje += " <br/> \n  No se ha enviado el objeto ITEntradaRecurso \n ";
                }

                #endregion

                #region Envio mail con errores o hago la llamada a SAP
                //Envio de mail de errores
                if (mailError)
                {
                    throw new Exception(mailMensaje);
                }
                else
                {
                    using (var scope = new OperationContextScope(_service.InnerChannel))
                    {
                        //var section = (ClientSection)ConfigurationManager.GetSection("system.serviceModel/client");
                        string headerLanguage = ConfigurationManager.AppSettings["ZWS_CREDITOLanguage"];

                        if (!string.IsNullOrEmpty(headerLanguage))
                        {
                            HttpRequestMessageProperty requestMessage = new HttpRequestMessageProperty();
                            requestMessage.Headers["Accept-Language"] = headerLanguage;
                            OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestMessage;
                        }

                        //sobreescribimos la URL
                        _service.Endpoint.Address = new EndpointAddress(ConfigurationManager.AppSettings["ZWS_CREDITOService"]);

                        service.ZfmWsCreditoResponse oRespuesta = new service.ZfmWsCreditoResponse();

                        try
                        {
                            oRespuesta = _service.ZfmWsCredito(ocredito);

                            if (!oRespuesta.EOutput.Message.Equals("OK", StringComparison.InvariantCultureIgnoreCase))
                            {
                                throw new Exception("Error intente nuevamente invocar al servicio");
                            }

                        }
                        catch (Exception ex)
                        {
                            mailError = true;
                            mailMensaje += ex.Message;
                            requestError = true;
                        }

                        log.Debug("Invoco --> Prueba: " + (ocredito.ICabecera != null ? ocredito.ICabecera.ToString() : "No enviado"));
                        log.Debug("Invoco --> Prueba: " + (ocredito.ItEntradaCredito != null && ocredito.ItEntradaCredito.Any() ? ocredito.ItEntradaCredito.ToString() : "No enviado"));
                        log.Debug("Invoco --> Prueba: " + (ocredito.ItEntradaRecurso != null && ocredito.ItEntradaRecurso.Any() ? ocredito.ItEntradaRecurso.ToString() : "No enviado"));
                        //log.Debug("Request  :" + ((XmlDocument)Funciones.GenericToXmlDocument(ocredito)).InnerXml);//ASOSA REQUEST OBJECT LOG

                        //log.Debug("Response :" + ((XmlDocument)Funciones.GenericToXmlDocument(oRespuesta)).InnerXml);//ASOSA RESPONSE OBJECT LOG
                        log.Debug("PresupuestoCredito ok");
                    }
                }
                #endregion

                if (mailError)
                {
                    throw new Exception(mailMensaje);
                }
            }
            catch (Exception err)
            {
                log.Error("Error al invocar el servicio SAP: Presupuesto Credito " + Environment.NewLine + err.Message + Environment.NewLine + err.StackTrace.ToString());

                #region Armado y envio del mail
                mailMensaje = "<br/> \n "
                    + "<br/> \n Error al invocar el servicio SAP: Presupuesto Credito"
                    + "<br/> \n"
                    + err.Message
                    + "<br/> \n"
                    + "<br/> \n Datos del solicitante de Economia: "
                    + "<br/> \n CUIT: " + (UsuarioSession.Entity ?? "No Identificado") + " - IP: " + (UsuarioSession.IP ?? "No Identificado")
                    + "<br/> \n "
                    + "<br/> \n Datos enviados por Economia  :"
                    + "<br/> \n "
                    + "<br/><div style='width:400px'><textarea rows='20' cols='40' style='border:none;'>" + requestXml + "</textarea></div>";


                enviarMail(mailMensaje, mailDestinatarios, "Error Servicio SAP-ESIDIF: Presupuesto Credito");
                #endregion
            }

            if (requestError)
            {
                throw new Exception("Error intente nuevamente");
            }

            return respuesta;
        }

        public static void enviarMail(String cuerpo, String destinatario, String asunto)
        {
            //enMailWS.EnviarMail enMailWS = new enMailWS.EnviarMail();
            //enMailWS.Credentials = CredentialCache.DefaultCredentials;
            //enMailWS.EnvioPruebaMail(asunto, destinatario, cuerpo);
        }

    }
}
