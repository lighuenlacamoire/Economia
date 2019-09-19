using Anses.Director.Session;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Protocols;

namespace ESIDIFLegacy.Models.Director
{
    public class UserLogged
    {
        //private static readonly ILog log = LogManager.GetLogger("ESIDIFCredito");

        public SSOToken credenciales { get; set; }

        public UserLogged()
        {

        }

        public User ObtenerDatosToken(SoapUnknownHeader[] unknownHeaders, string tag)
        {
            try
            {
                var user = new User();

                var tokenEnviado = new SSOEncodedToken();
                foreach (SoapUnknownHeader header in unknownHeaders)
                {
                    if (header.Element.Name == tag)
                    {
                        tokenEnviado.Token = header.Element.InnerText;
                        break;
                    }
                }

                if (!string.IsNullOrEmpty(tokenEnviado.Token) && tokenEnviado.Token.Length > 0)
                {
                    credenciales = Credencial.ObtenerCredencialEnWs(tokenEnviado);

                    if (credenciales != null)
                    {
                        //Entity - CUIT
                        user.Entity = credenciales.Operation.Login.Entity;

                        //
                        user.HasToken = true;
                        user.Sistema = credenciales.Operation.Login.System;

                        //Perfil
                        user.Perfil = credenciales.Operation.Login.Groups[0].Name;

                        //Cuil
                        user.CUIL = credenciales.Operation.Login.CUIL;

                        //Legajo - Uid
                        user.UserId = credenciales.Operation.Login.UId;

                        //verificamos el grupo y la info 
                        //******************************
                        user.UserName = credenciales.Operation.Login.UserName;

                        //deteccion del cuil - para CVSS en el campo UId estara el CUIL de la persona. 
                        //Para aplicaciones internas el UId tendra el Usuario del operador
                        try
                        {
                            user.Cuip = string.IsNullOrEmpty(credenciales.Operation.Login.UId) ? 0 : long.Parse(credenciales.Operation.Login.UId);
                        }
                        catch
                        {
                            user.Cuip = 0;
                            user.UserName = credenciales.Operation.Login.UId;
                        }

                        //Nombre
                        user.Nombre = credenciales.Operation.Login.UserName;

                        for (int i = 0; i < credenciales.Operation.Login.Info.Length; i++)
                        {
                            switch (credenciales.Operation.Login.Info[i].Name)
                            {
                                case "nombre":
                                    user.Nombre = credenciales.Operation.Login.Info[i].Value;
                                    break;
                                case "ip":
                                    user.IP = credenciales.Operation.Login.Info[i].Value;
                                    break;
                                case "oficina":
                                    user.Oficina = credenciales.Operation.Login.Info[i].Value;
                                    break;
                                case "oficinadesc":
                                    user.OficinaDetalle = credenciales.Operation.Login.Info[i].Value;
                                    break;
                                default:
                                    break;
                            }
                        }
                        return user;
                    }
                    throw new Exception("Ha ocurrido un error al obtener las credenciales del usuario, por favor verifique que ha enviado el token con sus credenciales");
                }
                throw new Exception("Ha ocurrido un error al obtener el token, por favor verifique que el mismo fue enviado");

            }
            catch (Exception ex)
            {
                //log.Error("Credenciales - " + ex.Message);
                throw ex;
            }
            return null;
        }

        public User ObtenerDatosCredencial()
        {
            try
            {
                var user = new User();

                var cred = Credencial.ObtenerCredencial();
                if (cred != null)
                {
                    //(string)cred.GetType().GetField("strtoken", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(cred)
                    var token = cred.GetType().GetField("strtoken", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                    var sign = cred.GetType().GetField("strsign", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

                    if (token != null && sign != null)
                    {
                        //HttpContext.Current.Session["token"] = (string)token.GetValue(cred);
                        //HttpContext.Current.Session["sign"] = (string)sign.GetValue(cred);
                    }

                    credenciales = cred.SSOToken;

                    //Perfil
                    user.Perfil = credenciales.Operation.Login.Groups[0].Name;

                    //Entity - Cuil
                    user.CUIL = credenciales.Operation.Login.CUIL;

                    //Legajo - Uid
                    user.UserId = credenciales.Operation.Login.UId;

                    //Nombre
                    user.UserName = credenciales.Operation.Login.Info[0].Value;

                    //Oficina
                    var oficina = credenciales.Operation.Login.Info.FirstOrDefault(r => r.Name.Equals("oficina", StringComparison.CurrentCultureIgnoreCase));
                    user.Oficina = oficina == null ? string.Empty : oficina.Value;

                    //Oficina Desc
                    var oficinaDetalle = credenciales.Operation.Login.Info.FirstOrDefault(r => r.Name.Equals("oficinadesc", StringComparison.CurrentCultureIgnoreCase));
                    user.OficinaDetalle = oficinaDetalle == null ? string.Empty : oficinaDetalle.Value;

                    //IP
                    var ip = credenciales.Operation.Login.Info.FirstOrDefault(r => r.Name.Equals("ip", StringComparison.CurrentCultureIgnoreCase));
                    user.IP = ip == null ? string.Empty : ip.Value;

                    //
                    user.ExpiraToken = Credencial.ObtenerCredencial().expirasession;
                    user.HasToken = true;
                    user.Sistema = credenciales.Operation.Login.System;
                    //user.Grupos = DirectorHelper.GetTokenListaGroups(credenciales);
                }

                return user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return null;
        }
    }
}