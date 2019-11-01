using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Web.Services.Protocols;
using System.Xml;
using ESIDIFCommon.Models.Xml;
using ESIDIFCommon.Tools;
using ESIDIFCommon.Business.Contract;
using ESIDIFCuota.Models;
using ESIDIFLegacy.Models.Director;
using log4net;

namespace ESIDIFCuota.Business
{
    public class Sources
    {
        private static string ServiceLogName = "Cuota";

        private static readonly ILog log = LogManager.GetLogger(ServiceLogName);

        public MailService _mailService;
        service.ZWS_CUOTAClient _service = new service.ZWS_CUOTAClient();

        //Siempre debemos devolver "OK" incluzo en caso de error
        private static EOuput respuesta = new EOuput { Message = "OK", Type = "S" };

        public Sources()
        {

        }
        public EOuput PresupuestoCuota(ZfmWsCuota consulta, SoapUnknownHeader[] unknownHeaders, User UsuarioSession)
        {
            #region Configuracion del envio de Mail
            string mailDestinatarios = ConfigurationManager.AppSettings["Emails"];
            string mailMensaje = string.Empty;
            bool mailError = false;
            #endregion

            bool requestError = false;
            string request = string.Empty;
            string requestXml = string.Empty;

            log.Debug("Entra " + ServiceLogName);

            try
            {
                #region Request to XML
                if (consulta != null)
                {
                    try
                    {
                        request = ((XmlDocument)Functions.GenericToXmlDocument(consulta)).InnerXml;
                        requestXml = Functions.TransforXml(request);

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
                        UsuarioSession = new UserLogged().GetTokenFromHeader(unknownHeaders, "token");
                    }

                    if (UsuarioSession != null &&
                        !string.IsNullOrEmpty(UsuarioSession.Entity) && UsuarioSession.Entity.Length > 0 &&
                        !string.IsNullOrEmpty(UsuarioSession.IP) && UsuarioSession.IP.Length > 0)
                    {
                        log.Info(ServiceLogName + " - Usuario CUIT: " + UsuarioSession.Entity + " IP: " + UsuarioSession.IP);
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

                service.ZfmWsCuota ocuota = new service.ZfmWsCuota();

                //Asignacion CUIL e IP
                ocuota.ICuilUser = UsuarioSession.Entity;
                ocuota.IIpUser = UsuarioSession.IP;

                #region Validacion Cabecera
                if (consulta != null && consulta.ICabecera != null)
                {
                    var validadorCabecera = new validadorLongitud<ICabecera>();

                    var erroresCabecera = validadorCabecera.validarLongitud(consulta.ICabecera);

                    log.Debug("Invoco --> validar longuitud ICabecera: " + consulta.ICabecera.ToString());

                    if (erroresCabecera.Count > 0)
                    {
                        mailError = true;
                        mailMensaje += "\n Se produjo un error al recibir información desde Economía:" + "  ";
                        foreach (var item in erroresCabecera)
                        {
                            mailMensaje += "<br/> \n Se ha registrado un error en la longuitud del objeto Cabecera en el campo " +
                                item.Nombre + " donde su longitud es " + item.Longitud + " y tendria que ser: " + item.LongitudEsperada;
                        }

                        log.ErrorFormat("Errores: " + mailMensaje);
                    }
                    else
                    {
                        ocuota.ICabecera = new service.ZdsCuotaCabecera();
                        ocuota.ICabecera.Fechaenvio = consulta.ICabecera.Fechaenvio;
                        ocuota.ICabecera.Tipocomprobante = consulta.ICabecera.Tipocomprobante;
                        ocuota.ICabecera.Ejercicio = consulta.ICabecera.Ejercicio;
                        ocuota.ICabecera.Numerocomprobante = consulta.ICabecera.Numerocomprobante;
                        ocuota.ICabecera.Periodo = consulta.ICabecera.Periodo;
                        ocuota.ICabecera.Entidademisora = consulta.ICabecera.Entidademisora;
                        ocuota.ICabecera.Entidademisora = consulta.ICabecera.Entidademisora;
                        ocuota.ICabecera.Estado = consulta.ICabecera.Estado;
                        ocuota.ICabecera.Fechaaplicacion = consulta.ICabecera.Fechaaplicacion;
                        ocuota.ICabecera.Ejercicioactoadm = consulta.ICabecera.Ejercicioactoadm;
                        ocuota.ICabecera.Numeroactoadm = consulta.ICabecera.Numeroactoadm;
                        ocuota.ICabecera.Tipoactoadm = consulta.ICabecera.Tipoactoadm;
                        ocuota.ICabecera.Fechaactoadm = consulta.ICabecera.Fechaactoadm;
                        ocuota.ICabecera.Codigoconcepto = consulta.ICabecera.Codigoconcepto;
                        ocuota.ICabecera.Descripcionconcepto = consulta.ICabecera.Descripcionconcepto;
                        ocuota.ICabecera.Identificaciontramite = consulta.ICabecera.Identificaciontramite;
                    }
                }
                else
                {
                    mailError = true;
                    mailMensaje += " <br/> \n  No se ha enviado el objeto ICabecera \n ";
                }
                #endregion

                #region Validacion Entradas Cuota
                if (consulta != null && consulta.ItEntradaCuota != null && consulta.ItEntradaCuota.Any())
                {
                    var validadorEntraCredito = new validadorLongitud<IEntradaCuota>();

                    List<service.ZdsEntradasCuota> EntradasCuota = new List<service.ZdsEntradasCuota>();

                    foreach (var item in consulta.ItEntradaCuota)
                    {

                        var erroresEntradaCuota = validadorEntraCredito.validarLongitud(item);
                        log.Debug("Invoco --> validar longuitud ITEntradaCuota: " + consulta.ItEntradaCuota.ToString());

                        if (erroresEntradaCuota.Count > 0)
                        {
                            mailError = true;
                            foreach (var item2 in erroresEntradaCuota)
                            {
                                mailMensaje += "<br/> \n Se ha registrado un error en la longuitud del objeto entrada cuota en el campo " +
                                    item2.Nombre + " donde su longuitud es " + item2.Longitud + " y tendria que ser: " + item2.LongitudEsperada;

                            }

                            log.ErrorFormat("Errores: " + mailMensaje);
                        }
                        else
                        {
                            var itemCuota = new service.ZdsEntradasCuota();
                            itemCuota.Sector = item.Sector;
                            itemCuota.Subsector = item.Subsector;
                            itemCuota.Caracter = item.Caracter;
                            itemCuota.Jurisdiccion = item.Jurisdiccion;
                            itemCuota.Subjurisdiccion = item.Subjurisdiccion;
                            itemCuota.Entidad = item.Entidad;
                            itemCuota.Saf = item.Saf;
                            itemCuota.Programa = item.Programa;
                            itemCuota.Subprograma = item.Subprograma;
                            itemCuota.Proyecto = item.Proyecto;
                            itemCuota.Actividad = item.Actividad;
                            itemCuota.Obra = item.Obra;
                            itemCuota.Inciso = item.Inciso;
                            itemCuota.Principal = item.Principal;
                            itemCuota.Parcial = item.Parcial;
                            itemCuota.Subparcial = item.Subparcial;
                            itemCuota.Procedencia = item.Procedencia;
                            itemCuota.Fuente = item.Fuente;
                            itemCuota.Compromisoinicial = item.Compromisoinicial;
                            itemCuota.Compromisovigente = item.Compromisovigente;
                            itemCuota.Compromisorestringido = item.Compromisorestringido;

                            itemCuota.Devengadoinicial1 = item.Devengadoinicial1;
                            itemCuota.Devengadovigente1 = item.Devengadovigente1;
                            itemCuota.Devengadorestringido1 = item.Devengadorestringido1;

                            itemCuota.Devengadoinicial2 = item.Devengadoinicial2;
                            itemCuota.Devengadovigente2 = item.Devengadovigente2;
                            itemCuota.Devengadorestringido2 = item.Devengadorestringido2;

                            itemCuota.Devengadoinicial3 = item.Devengadoinicial3;
                            itemCuota.Devengadovigente3 = item.Devengadovigente3;
                            itemCuota.Devengadorestringido3 = item.Devengadorestringido3;

                            itemCuota.Devengado1comprobante = item.Devengado1comprobante;
                            itemCuota.Devengado2comprobante = item.Devengado2comprobante;
                            itemCuota.Devengado3comprobante = item.Devengado3comprobante;

                            itemCuota.Compromisocomprobante = item.Compromisocomprobante;

                            EntradasCuota.Add(itemCuota);
                        }

                        if (!string.IsNullOrEmpty(item.Compromisoinicial) && item.Compromisoinicial.Contains(","))
                        {
                            mailError = true;
                            mailMensaje += "<br/> \n Se ha registrado un error en el objeto entrada cuota en el campo " + " " +
                                    "Compromisoinicial" + " contiene " + " " + "coma(,)" + " " + " en lugar de " + "punto(.)";
                        }

                        if (!string.IsNullOrEmpty(item.Compromisovigente) && item.Compromisovigente.Contains(","))
                        {
                            mailError = true;
                            mailMensaje += "<br/> \n Se ha registrado un error en el objeto entrada cuota en el campo " + " " +
                                    "Compromisovigente" + " contiene " + " " + "coma(,)" + " " + " en lugar de " + "punto(.)";
                        }

                        if (!string.IsNullOrEmpty(item.Compromisorestringido) && item.Compromisorestringido.Contains(","))
                        {
                            mailError = true;
                            mailMensaje += "<br/> \n Se ha registrado un error en el objeto entrada cuota en el campo " + " " +
                                    "Compromisorestringido" + " contiene " + " " + "coma(,)" + " " + " en lugar de " + "punto(.)";
                        }

                        if (!string.IsNullOrEmpty(item.Devengadoinicial1) && item.Devengadoinicial1.Contains(","))
                        {
                            mailError = true;
                            mailMensaje += "<br/> \n Se ha registrado un error en el objeto entrada cuota en el campo " + " " +
                                    "Devengadoinicial1" + " contiene " + " " + "coma(,)" + " " + " en lugar de " + "punto(.)";
                        }

                        if (!string.IsNullOrEmpty(item.Devengadovigente1) && item.Devengadovigente1.Contains(","))
                        {
                            mailError = true;
                            mailMensaje += "<br/> \n Se ha registrado un error en el objeto entrada cuota en el campo " + " " +
                                    "Devengadovigente1" + " contiene " + " " + "coma(,)" + " " + " en lugar de " + "punto(.)";
                        }

                        if (!string.IsNullOrEmpty(item.Devengadorestringido1) && item.Devengadorestringido1.Contains(","))
                        {
                            mailError = true;
                            mailMensaje += "<br/> \n Se ha registrado un error en el objeto entrada cuota en el campo " + " " +
                                    "Devengadorestringido1" + " contiene " + " " + "coma(,)" + " " + " en lugar de " + "punto(.)";
                        }

                        if (!string.IsNullOrEmpty(item.Devengadoinicial2) && item.Devengadoinicial2.Contains(","))
                        {
                            mailError = true;
                            mailMensaje += "<br/> \n Se ha registrado un error en el objeto entrada cuota en el campo " + " " +
                                    "Devengadoinicial2" + " contiene " + " " + "coma(,)" + " " + " en lugar de " + "punto(.)";
                        }

                        if (!string.IsNullOrEmpty(item.Devengadovigente2) && item.Devengadovigente2.Contains(","))
                        {
                            mailError = true;
                            mailMensaje += "<br/> \n Se ha registrado un error en el objeto entrada cuota en el campo " + " " +
                                    "Devengadovigente2" + " contiene " + " " + "coma(,)" + " " + " en lugar de " + "punto(.)";
                        }

                        if (!string.IsNullOrEmpty(item.Devengadorestringido2) && item.Devengadorestringido2.Contains(","))
                        {
                            mailError = true;
                            mailMensaje += "<br/> \n Se ha registrado un error en el objeto entrada cuota en el campo " + " " +
                                    "Devengadorestringido2" + " contiene " + " " + "coma(,)" + " " + " en lugar de " + "punto(.)";
                        }

                        if (!string.IsNullOrEmpty(item.Devengadoinicial3) && item.Devengadoinicial3.Contains(","))
                        {
                            mailError = true;
                            mailMensaje += "<br/> \n Se ha registrado un error en el objeto entrada cuota en el campo " + " " +
                                    "Devengadoinicial3" + " contiene " + " " + "coma(,)" + " " + " en lugar de " + "punto(.)";
                        }

                        if (!string.IsNullOrEmpty(item.Devengadovigente3) && item.Devengadovigente3.Contains(","))
                        {
                            mailError = true;
                            mailMensaje += "<br/> \n Se ha registrado un error en el objeto entrada cuota en el campo " + " " +
                                    "Devengadovigente3" + " contiene " + " " + "coma(,)" + " " + " en lugar de " + "punto(.)";
                        }

                        if (!string.IsNullOrEmpty(item.Devengadorestringido3) && item.Devengadorestringido3.Contains(","))
                        {
                            mailError = true;
                            mailMensaje += "<br/> \n Se ha registrado un error en el objeto entrada cuota en el campo " + " " +
                                    "Devengadorestringido3" + " contiene " + " " + "coma(,)" + " " + " en lugar de " + "punto(.)";
                        }

                        if (!string.IsNullOrEmpty(item.Devengado1comprobante) && item.Devengado1comprobante.Contains(","))
                        {
                            mailError = true;
                            mailMensaje += "<br/> \n Se ha registrado un error en el objeto entrada cuota en el campo " + " " +
                                    "Devengado1comprobante" + " contiene " + " " + "coma(,)" + " " + " en lugar de " + "punto(.)";
                        }

                        if (!string.IsNullOrEmpty(item.Devengado2comprobante) && item.Devengado2comprobante.Contains(","))
                        {
                            mailError = true;
                            mailMensaje += "<br/> \n Se ha registrado un error en el objeto entrada cuota en el campo " + " " +
                                    "Devengado2comprobante" + " contiene " + " " + "coma(,)" + " " + " en lugar de " + "punto(.)";
                        }

                        if (!string.IsNullOrEmpty(item.Devengado3comprobante) && item.Devengado3comprobante.Contains(","))
                        {
                            mailError = true;
                            mailMensaje += "<br/> \n Se ha registrado un error en el objeto entrada cuota en el campo " + " " +
                                    "Devengado3comprobante" + " contiene " + " " + "coma(,)" + " " + " en lugar de " + "punto(.)";
                        }
                        if (!string.IsNullOrEmpty(item.Compromisocomprobante) && item.Compromisocomprobante.Contains(","))
                        {
                            mailError = true;
                            mailMensaje += "<br/> \n Se ha registrado un error en el objeto entrada cuota en el campo " + " " +
                                    "Compromisocomprobante" + " contiene " + " " + "coma(,)" + " " + " en lugar de " + "punto(.)";
                        }
                    }

                    if (EntradasCuota != null && EntradasCuota.Count > 0)
                    {
                        ocuota.ItEntradaCuota = EntradasCuota.ToArray();
                    }
                }
                else
                {
                    //mailError = true;
                    //mailMensaje += " <br/> \n  No se ha enviado el objeto ITEntradaCuota \n ";
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
                        string headerLanguage = ConfigurationManager.AppSettings["ZWS_CUOTALanguage"];

                        if (!string.IsNullOrEmpty(headerLanguage))
                        {
                            HttpRequestMessageProperty requestMessage = new HttpRequestMessageProperty();
                            requestMessage.Headers["Accept-Language"] = headerLanguage;
                            OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestMessage;
                        }

                        //sobreescribimos la URL
                        _service.Endpoint.Address = new EndpointAddress(ConfigurationManager.AppSettings["ZWS_CUOTAService"]);

                        service.ZfmWsCuotaResponse oRespuesta = new service.ZfmWsCuotaResponse();

                        try
                        {
                            oRespuesta = _service.ZfmWsCuota(ocuota);

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

                        log.Debug("Invoco --> Prueba: " + (ocuota.ICabecera != null ? ocuota.ICabecera.ToString() : "No enviado"));
                        log.Debug("Invoco --> Prueba: " + (ocuota.ItEntradaCuota != null && ocuota.ItEntradaCuota.Any() ? ocuota.ItEntradaCuota.ToString() : "No enviado"));
                        //log.Debug("Request  :" + ((XmlDocument)Functions.GenericToXmlDocument(ocuota)).InnerXml);//ASOSA REQUEST OBJECT LOG

                        //log.Debug("Response :" + ((XmlDocument)Functions.GenericToXmlDocument(oRespuesta)).InnerXml);//ASOSA RESPONSE OBJECT LOG
                        log.Debug("PresupuestoCuota ok");
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
                log.Error("Error al invocar el servicio SAP: Presupuesto Cuota " + Environment.NewLine + err.Message + Environment.NewLine + err.StackTrace.ToString());

                #region Armado y envio del mail
                mailMensaje = "<br/> \n "
                    + "<br/> \n Error al invocar el servicio SAP: Presupuesto Cuota"
                    + "<br/> \n"
                    + err.Message
                    + "<br/> \n"
                    + "<br/> \n Datos del solicitante de Economia: "
                    + "<br/> \n CUIT: " + (UsuarioSession.Entity ?? "No Identificado") + " - IP: " + (UsuarioSession.IP ?? "No Identificado")
                    + "<br/> \n "
                    + "<br/> \n Datos enviados por Economia  :"
                    + "<br/> \n "
                    + "<br/><div style='width:400px'><textarea rows='20' cols='40' style='border:none;'>" + requestXml + "</textarea></div>";

                enviarMail(mailMensaje, mailDestinatarios, "Error Servicio SAP-ESIDIF: Presupuesto Cuota");
                #endregion
            }

            if (requestError)
            {
                throw new Exception("Error intente nuevamente");
            }
            return respuesta;
        }

        public SoapException HandleError(Exception ex)
        {
            SoapError error = Functions.SoapErrorFromException(ex);

            return new SoapException(error.FaultDetail, SoapException.ServerFaultCode, error.FaultReason, error.FaultNode);
        }

        private void enviarMail(string cuerpo, string destinatario, string asunto)
        {
            string endpoint = ConfigurationManager.AppSettings["EmailService_Endpoint"];

            _mailService = new MailService(endpoint);
            _mailService.sendMail(cuerpo, destinatario, asunto);
        }
    }
}