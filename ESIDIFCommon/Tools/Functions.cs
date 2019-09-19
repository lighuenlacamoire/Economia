using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ESIDIFCommon.Tools
{
    public static class Functions
    {
        public static string PrefijoValorDecimal = "ValorDecimal";

        private const string SPECIFIED_SUFFIX = "Specified";

        public static CultureInfo culture = CultureInfo.InvariantCulture;

        public static NumberFormatInfo numberFormat = new NumberFormatInfo { NumberGroupSeparator = "", NumberDecimalSeparator = ".", NumberDecimalDigits = 2 };

        public static string ParseXml(string xml)
        {
            try
            {
                return Convert.ToString(XDocument.Parse(xml));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return string.Empty;
            }
        }

        public enum FechaTipo
        {
            SIMPLE, MEDIA, COMPUESTA
        }
        public static string ValidateDecimalFromString(string value)
        {
            decimal result = 0;

            try
            {
                string doubleAsString = value;
                IEnumerable<char> doubleAsCharList = doubleAsString.ToList();

                if (doubleAsCharList.Where(ch => ch == '.' || ch == ',').Count() <= 1)
                {
                    decimal.TryParse(doubleAsString,
                        System.Globalization.NumberStyles.Any,
                        CultureInfo.InvariantCulture,
                        out result);
                }
                else
                {
                    if (doubleAsCharList.Where(ch => ch == '.').Count() <= 1
                        && doubleAsCharList.Where(ch => ch == ',').Count() > 1)
                    {
                        decimal.TryParse(doubleAsString.Replace(",", string.Empty),
                            System.Globalization.NumberStyles.Any,
                            CultureInfo.InvariantCulture,
                            out result);
                    }
                    else if (doubleAsCharList.Where(ch => ch == ',').Count() <= 1
                        && doubleAsCharList.Where(ch => ch == '.').Count() > 1)
                    {
                        decimal.TryParse(doubleAsString.Replace(",", string.Empty),
                            System.Globalization.NumberStyles.Any,
                            CultureInfo.InvariantCulture,
                            out result);
                    }
                    else
                    {
                        //throw new ParsingException($"Error parsing {doubleAsString} as double, try removing thousand separators (if any)");
                    }
                }

                value = result.ToString("N2", numberFormat);

            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return value;
        }

        public static bool CopyStringToBool(string origen)
        {
            if (!string.IsNullOrEmpty(origen))
            {
                try
                {
                    bool value;
                    if (bool.TryParse(origen, out value))
                    {
                        return value;
                    }
                    else
                    {
                        return Convert.ToBoolean(Convert.ToInt32(origen));
                    }
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static int CopyStringToInt(string origen)
        {
            int valor = new int();

            try
            {
                valor = Convert.ToInt32(origen);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return valor;
        }

        public static long CopyStringToLong(string origen)
        {
            long valor = new long();

            try
            {
                valor = Convert.ToInt64(origen);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return valor;
        }

        public static decimal CopyStringToDecimal2(string origen)
        {
            origen = origen.Replace(",", ".");

            decimal valor = 0;

            try
            {
                valor = decimal.Parse(origen, numberFormat);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return valor;
        }

        public static decimal CopyStringToDecimal(string value)
        {
            decimal result = 0;

            try
            {
                string doubleAsString = value;
                IEnumerable<char> doubleAsCharList = doubleAsString.ToList();

                if (doubleAsCharList.Where(ch => ch == '.' || ch == ',').Count() <= 1)
                {
                    decimal.TryParse(doubleAsString,
                        System.Globalization.NumberStyles.Any,
                        CultureInfo.InvariantCulture,
                        out result);
                }
                else
                {
                    if (doubleAsCharList.Where(ch => ch == '.').Count() <= 1
                        && doubleAsCharList.Where(ch => ch == ',').Count() > 1)
                    {
                        decimal.TryParse(doubleAsString.Replace(",", string.Empty),
                            System.Globalization.NumberStyles.Any,
                            CultureInfo.InvariantCulture,
                            out result);
                    }
                    else if (doubleAsCharList.Where(ch => ch == ',').Count() <= 1
                        && doubleAsCharList.Where(ch => ch == '.').Count() > 1)
                    {
                        decimal.TryParse(doubleAsString.Replace(",", string.Empty),
                            System.Globalization.NumberStyles.Any,
                            CultureInfo.InvariantCulture,
                            out result);
                    }
                    else
                    {
                        //throw new ParsingException($"Error parsing {doubleAsString} as double, try removing thousand separators (if any)");
                    }
                }


                value = result.ToString("N2", numberFormat);

            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return result;
        }

        public static DateTime CopyStringToFecha(string origen, FechaTipo tipo, string formato)
        {
            DateTime valor = DateTime.MinValue;

            try
            {
                if (!string.IsNullOrEmpty(origen) && origen.Length > 0)
                {
                    DateTime.TryParse(origen, out valor);

                    origen = valor != DateTime.MinValue ? valor.ToString(formato) : origen;
                }

                switch (tipo)
                {
                    case FechaTipo.SIMPLE:
                        {
                            valor = DateTime.ParseExact(origen, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                            break;
                        }
                    case FechaTipo.MEDIA:
                        {
                            valor = DateTime.ParseExact(origen, "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
                            break;
                        }
                    case FechaTipo.COMPUESTA:
                        {
                            DateTime.TryParseExact(origen, "yyyy-MM-ddTHH:mm:ffff", CultureInfo.InvariantCulture, DateTimeStyles.None, out valor);

                            //valor = DateTime.ParseExact(origen, "yyyy-MM-dd'T'HH:mm:ffff", CultureInfo.InvariantCulture);
                            break;
                        }
                    default:
                        {
                            valor = DateTime.ParseExact(origen, "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
                            break;
                        }
                }

            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return valor;
        }

        public static TEnum CopyStringToEnum<TEnum>(string origen) where TEnum : struct
        {
            TEnum resultInputType = default(TEnum);

            Enum.TryParse(origen, true, out resultInputType);

            return resultInputType;
        }

        public static void CopyPropertiesTo<T, TU>(T source, TU dest)
        {
            var sourceProps = source.GetType().GetProperties().ToList();
            var destProps = dest.GetType().GetProperties().ToList();

            foreach (var sourceProp in sourceProps)
            {
                if (destProps.Any(x => x.Name == sourceProp.Name))
                {
                    var p = destProps.First(x => x.Name == sourceProp.Name);

                    if ((p.PropertyType.IsPrimitive || p.PropertyType == typeof(DateTime) || p.PropertyType == typeof(decimal) || p.PropertyType == typeof(string) || p.PropertyType.IsEnum || p.PropertyType == typeof(long) || p.PropertyType == typeof(Int64) || p.PropertyType == typeof(int) || p.PropertyType == typeof(Int32) || p.PropertyType == typeof(bool)) && sourceProp.GetValue(source, null) != null)
                    {
                        //validamos los campos de formato definido por SAP, que para lograrlos se han puesto como string pero se envia formato distinto a Economia

                        //Cuando recibimos un formato especifico de decimal de SAP y debemos enviarlo a Economia ejemplo: SAP 2343.98-(string) Economia -2343.98
                        if (p.PropertyType == typeof(decimal) && sourceProp.PropertyType == typeof(string))
                        {
                            var valorReal = sourceProps.FirstOrDefault(x => x.Name == sourceProp.Name + PrefijoValorDecimal);

                            if (valorReal != null && valorReal.PropertyType == p.PropertyType)
                            {
                                p.SetValue(dest, valorReal.GetValue(source, null), null);
                                continue;
                            }
                            else if (valorReal == null)
                            {
                                string valor = Convert.ToString(sourceProp.GetValue(source, null));
                                var valorDecimal = CopyStringToDecimal(valor);

                                p.SetValue(dest, valorDecimal, null);
                                continue;
                            }

                        }//Cuando recibimos un formato especifico de fecha de SAP y debemos enviarlo a Economia ejemplo: SAP 2019-12-31T18:05:05/2019-12-31 Economia 2019-12-31
                        else if (p.PropertyType == typeof(DateTime) && sourceProp.PropertyType == typeof(string))
                        {
                            string valor = Convert.ToString(sourceProp.GetValue(source, null));
                            var valorFecha = CopyStringToFecha(valor, FechaTipo.MEDIA, "yyyy-MM-ddTHH:mm:ss");

                            p.SetValue(dest, valorFecha, null);
                            continue;

                        }//Cuando recibimos un formato un string y debemos enviarlo a Economia como long ejemplo: SAP "34" Economia (long)34
                        else if ((p.PropertyType == typeof(long) || p.PropertyType == typeof(Int64)) && sourceProp.PropertyType == typeof(string))
                        {
                            string valor = Convert.ToString(sourceProp.GetValue(source, null));
                            var valorLong = CopyStringToLong(valor);

                            p.SetValue(dest, valorLong, null);
                            continue;

                        }//Cuando recibimos un formato un string y debemos enviarlo a Economia como entero ejemplo: SAP "34" Economia (int)34
                        else if ((p.PropertyType == typeof(int) || p.PropertyType == typeof(Int32)) && sourceProp.PropertyType == typeof(string))
                        {
                            string valor = Convert.ToString(sourceProp.GetValue(source, null));
                            var valorEntero = CopyStringToInt(valor);

                            p.SetValue(dest, valorEntero, null);
                            continue;

                        }
                        else if (p.PropertyType == typeof(bool) && sourceProp.PropertyType == typeof(string))
                        {
                            string valor = Convert.ToString(sourceProp.GetValue(source, null));
                            var valorBooleano = CopyStringToBool(valor);

                            p.SetValue(dest, valorBooleano, null);
                            continue;

                        }

                        else if (p.PropertyType.IsEnum && p.PropertyType.BaseType == typeof(Enum) && sourceProp.PropertyType == typeof(string))
                        {
                            try
                            {
                                p.SetValue(dest, Enum.Parse(p.PropertyType, Convert.ToString(sourceProp.GetValue(source, null)), true), null);
                            }
                            catch (Exception)
                            {
                                p.SetValue(dest, Enum.ToObject(p.PropertyType, (int)sourceProp.GetValue(source, null)), null);
                            }
                            continue;
                        }

                        p.SetValue(dest, sourceProp.GetValue(source, null), null);
                    }
                    else if (p.PropertyType.IsClass && !p.PropertyType.IsArray && sourceProp.GetValue(source, null) != null)
                    {
                        //Type typeDes = p.PropertyType;
                        //MethodInfo info = typeDes.GetMethod("Create", BindingFlags.Static | BindingFlags.Public);

                        var desObj = Activator.CreateInstance(p.PropertyType);
                        //var desObj2 = info.Invoke(null, null);
                        var souObj = sourceProp.GetValue(source, null);
                        CopyPropertiesTo(souObj, desObj);
                        p.SetValue(dest, desObj, null);//agregar en caso de ser un lista de objetos 

                    }
                    else if (p.PropertyType.IsArray && sourceProp.GetValue(source, null) != null)
                    {
                        IList souObj = sourceProp.GetValue(source, null) as IList;
                        string desName = p.PropertyType.FullName;
                        desName = desName.Replace("[]", "");
                        Type ItypeDes = Type.GetType(desName);

                        if (ItypeDes != null)
                        {
                            var desObj = Array.CreateInstance(ItypeDes, souObj.Count);

                            int cont = 0;
                            foreach (var item in souObj)
                            {
                                //Type ItypeDes = Type.GetType(desName); /////
                                //MethodInfo Iinfo = ItypeDes.GetMethod("Create", BindingFlags.Static | BindingFlags.Public);
                                //var idesObj2 = Iinfo.Invoke(null, null);

                                var idesObj = Activator.CreateInstance(ItypeDes);

                                CopyPropertiesTo(item, idesObj);
                                desObj.SetValue(idesObj, cont);
                                cont = cont + 1;
                            }
                            p.SetValue(dest, desObj, null);//agregar en caso de ser un lista de objetos 
                        }
                    }
                }
            }
        }

        public static void CopyPropertiesStringTo<T, TU>(T source, TU dest)
        {
            var sourceProps = source.GetType().GetProperties().ToList();
            var destProps = dest.GetType().GetProperties().ToList();

            foreach (var sourceProp in sourceProps)
            {
                var p = destProps.FirstOrDefault(x => x.Name == sourceProp.Name);
                if (p != null)
                {
                    //Si la variable destino es string y la variable origen es un long consultamos para ver si debemos enviar null
                    if (p.PropertyType == typeof(string) && (sourceProp.PropertyType == typeof(decimal) || sourceProp.PropertyType == typeof(int) || sourceProp.PropertyType == typeof(long) || sourceProp.PropertyType == typeof(Int64)))
                    {
                        var esNulo = sourceProps.FirstOrDefault(x => x.Name == sourceProp.Name + SPECIFIED_SUFFIX);

                        if (esNulo != null && esNulo.PropertyType == typeof(bool))
                        {
                            bool especificado = Convert.ToBoolean(esNulo.GetValue(source, null));
                            if (!especificado)
                            {
                                p.SetValue(dest, string.Empty, null);
                                continue;
                            }
                        }
                    }

                    p.SetValue(dest, Convert.ToString(sourceProp.GetValue(source, null)), null);
                    //   p.SetValue(dest, desObj.ToString(), null);//agregar en caso de ser un lista de objetos 
                }
            }
        }

        public static TConvert ConvertTo<TConvert>(this object entity) where TConvert : new()
        {
            var convertProperties = TypeDescriptor.GetProperties(typeof(TConvert)).Cast<PropertyDescriptor>();
            var entityProperties = TypeDescriptor.GetProperties(entity).Cast<PropertyDescriptor>();

            var convert = new TConvert();

            foreach (var entityProperty in entityProperties)
            {
                var property = entityProperty;
                var convertProperty = convertProperties.FirstOrDefault(prop => prop.Name == property.Name);
                if (property.GetType().IsPrimitive)
                {
                    if (convertProperty != null)
                    {
                        convertProperty.SetValue(convert, Convert.ChangeType(entityProperty.GetValue(entity), convertProperty.PropertyType));
                    }
                }
            }

            return convert;
        }

        public static Exception CapturarSoapError(Exception ex)
        {
            //try
            //{
            //    FaultException faultException = ex as FaultException;
            //    MessageFault msgFault = faultException != null ? faultException.CreateMessageFault() : null;
            //    XmlElement elm = msgFault != null ? msgFault.GetDetail<XmlElement>() : null;

            //    if (elm != null)
            //    {
            //        var errorCodeTag = elm.GetElementsByTagName("ErrorCode");
            //        var errorDescripcionTag = elm.GetElementsByTagName("ErrorDescription");

            //        if (errorCodeTag != null && errorCodeTag.Count > 0 && errorDescripcionTag != null && errorDescripcionTag.Count > 0)
            //        {
            //            ex = new Exception(errorCodeTag[0].InnerText + " " + errorDescripcionTag[0].InnerText);
            //        }
            //    }
            //    else
            //    {
            //        XmlDocument document = new XmlDocument();
            //        document.LoadXml(ex.Message);

            //        var xmlNodeList = document.GetElementsByTagName("detail");

            //        if (xmlNodeList != null && xmlNodeList.Count > 0 && xmlNodeList[0].HasChildNodes)
            //        {
            //            string mensaje = string.Empty;
            //            foreach (var element in xmlNodeList[0].ChildNodes)
            //            {
            //                elm = element as XmlElement;

            //                if (elm != null)
            //                {
            //                    var errorCodeTag = elm.GetElementsByTagName("ErrorCode");
            //                    var errorDescripcionTag = elm.GetElementsByTagName("ErrorDescription");

            //                    if (errorCodeTag != null && errorCodeTag.Count > 0 && errorDescripcionTag != null && errorDescripcionTag.Count > 0)
            //                    {
            //                        mensaje += errorCodeTag[0].InnerText + " " + errorDescripcionTag[0].InnerText + Environment.NewLine;
            //                    }
            //                }
            //            }

            //            if (!string.IsNullOrEmpty(mensaje) && mensaje.Length > 0)
            //            {
            //                ex = new Exception(mensaje);
            //            }
            //        }

            //    }
            //}
            //catch
            //{

            //}
            return ex;
        }

        public static X509Certificate2 GetClientCertificate()
        {
            string huellaDigital = "c2810107087b25676fbc7885bbeeb63e0fae9085";
            X509Store userCaStore = new X509Store(StoreName.Root, StoreLocation.LocalMachine);
            try
            {
                userCaStore.Open(OpenFlags.ReadOnly);
                X509Certificate2Collection certificatesInStore = userCaStore.Certificates;
                X509Certificate2Collection findResult = certificatesInStore.Find(X509FindType.FindByThumbprint, huellaDigital, true);
                X509Certificate2 clientCertificate = null;
                if (findResult.Count == 1)
                {
                    clientCertificate = findResult[0];
                }
                else
                {
                    throw new Exception("No se encontro el certificado");
                }
                return clientCertificate;
            }
            catch
            {
                throw;
            }
            finally
            {
                userCaStore.Close();
            }
        }
        public static WebProxy CrearProxy()
        {
            string usuarioProxy = "E266864";
            string passwdProxy = "VlaSauco2020";
            string urlProxy = "http://proxysgha.anses.gov.ar:80";
            string domainProxy = "ANSES";

            WebProxy Proxy = new WebProxy(new Uri(urlProxy), false);
            Proxy.Address = new Uri(urlProxy);
            Proxy.BypassProxyOnLocal = false;
            Proxy.UseDefaultCredentials = true;
            Proxy.Credentials = new NetworkCredential(usuarioProxy, passwdProxy, domainProxy);

            return Proxy;
        }

        public static string soap = string.Format(@"<?xml version=""1.0"" encoding=""utf-8""?>
            <soapenv:Envelope 
                xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/""
                xmlns:com=""https://ws-si.mecon.gov.ar/ws/comprobantesCrgDbMsg""
                xmlns:com1=""https://ws-si.mecon.gov.ar/ws/comprobantesCrg"" 
                xmlns:com2=""https://ws-si.mecon.gov.ar/ws/comprobantes"">
                <soapenv:Header xmlns:wsa=""http://www.w3.org/2005/08/addressing"">
                    <wsse:Security soapenv:mustUnderstand=""1"" xmlns:wsse=""http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd"">
                        <wsse:UsernameToken wsu:Id=""UsernameToken-1"" xmlns:wsu=""http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd"">
                            <wsse:Username>{0}</wsse:Username>
                            <wsse:Password Type=""http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-username-token-profile-1.0#PasswordText"">{1}</wsse:Password>
                        </wsse:UsernameToken>
                    </wsse:Security>
                    <wsa:To soapenv:mustUnderstand=""1"">https://tws4-si.mecon.gov.ar/SD_Core/ws</wsa:To>
                    <wsa:Action>https://ws-si.mecon.gov.ar/ws/gastos/crg/crgDbService</wsa:Action>
                    <wsa:MessageID>urn:uuid:{2}</wsa:MessageID>
                </soapenv:Header> 
                <soapenv:Body>
                   <com:crgDbRequest>
			<com:cabeceraCrg>
				<com1:gestionExterna>ANSES</com1:gestionExterna>
				<com1:identificacionComprobante>
					<com1:entidadEmisora>850</com1:entidadEmisora>
					<com1:entidadProceso>850</com1:entidadProceso>
					<com1:numero>800501</com1:numero>
					<com1:ejercicio>2019</com1:ejercicio>
					<com1:tipoComprobante>CRG</com1:tipoComprobante>
				</com1:identificacionComprobante>
				<com1:fechaRegistro>2019-07-04</com1:fechaRegistro>
				<com1:fechaComprobante>2019-07-04</com1:fechaComprobante>
				<com1:fechaAutorizacion>2019-07-04</com1:fechaAutorizacion>
				<com1:importeMO>80</com1:importeMO>
				<com1:importeMCL>80</com1:importeMCL>
				<com1:cotizacion>
					<com2:tipoMoneda>ARP</com2:tipoMoneda>
					<com2:valor>1</com2:valor>
				</com1:cotizacion>
				<com1:beneficiario>1036</com1:beneficiario>
				<com1:medioDePago>DB</com1:medioDePago>
			</com:cabeceraCrg>
			<com:datosFinancieros>
				<com1:cuentaDebito>
					<com2:banco>11</com2:banco>
					<com2:sucursal>85</com2:sucursal>
					<com2:cuenta>2831/88</com2:cuenta>
				</com1:cuentaDebito>
				<com1:cuentaFinanciadora>
					<com2:banco>11</com2:banco>
					<com2:sucursal>85</com2:sucursal>
					<com2:cuenta>2831/88</com2:cuenta>
				</com1:cuentaFinanciadora>
			</com:datosFinancieros>
			<com:datosExtracto>
				<com1:ejercicio>2019</com1:ejercicio>
				<com1:numero>6512612</com1:numero>
				<com1:movimientoInternoExtracto>CREVAR</com1:movimientoInternoExtracto>
				<com1:fechaExtracto>2019-06-21</com1:fechaExtracto>
			</com:datosExtracto>
			<com:observaciones>Prueba</com:observaciones>
			<com:itemsPresupuestarios>
				<com1:imputacion>
					<com2:ejercicio>2019</com2:ejercicio>
					<com2:servicio>850</com2:servicio>
					<com2:aperturaProg>1.0.0.1.0</com2:aperturaProg>
					<com2:objetoGasto>2.1.1.0</com2:objetoGasto>
					<com2:fuente>1.2</com2:fuente>
					<com2:moneda>1</com2:moneda>
					<com2:ug>2</com2:ug>
				</com1:imputacion>
				<com1:ejercicio>2019</com1:ejercicio>
				<com1:ud>
					<com2:codigo>850</com2:codigo>
				</com1:ud>
				<com1:importeMO>80</com1:importeMO>
				<com1:importeMCL>80</com1:importeMCL>
			</com:itemsPresupuestarios>
		</com:crgDbRequest>
                </soapenv:Body>
            </soapenv:Envelope>", "", "", Guid.NewGuid());

        public static string SerializeObjectToString<T>(T source, XmlSerializerNamespaces sourceNamespaces)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.OmitXmlDeclaration = false;
                settings.CloseOutput = false;
                settings.Encoding = Encoding.UTF8;

                string result = string.Empty;

                using (XmlWriter xmlWriter = XmlWriter.Create(memoryStream, settings))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(xmlWriter, source, sourceNamespaces);

                    result = Encoding.UTF8.GetString(memoryStream.ToArray());
                }

                return result;
            }
        }
        public static XmlDocument SerializeObjectToXml<T>(T source, XmlSerializerNamespaces sourceNamespaces)
        {
            var document = new XmlDocument();
            var navigator = document.CreateNavigator();

            using (var writer = navigator.AppendChild())
            {
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(writer, source, sourceNamespaces);

            }

            return document;
        }

        public static T DeserializeXMLFileToObject<T>(string XmlFilename)
        {
            T returnObject = default(T);
            if (string.IsNullOrEmpty(XmlFilename)) return default(T);

            try
            {
                StreamReader xmlStream = new StreamReader(XmlFilename);
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                returnObject = (T)serializer.Deserialize(xmlStream);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return returnObject;
        }

    }

    public static class PropertySpecifiedExtensions
    {
        private const string SPECIFIED_SUFFIX = "Specified";

        /// <summary>
        /// Bind the <see cref="INotifyPropertyChanged.PropertyChanged"/> handler to automatically set any xxxSpecified fields when a property is changed.  "Lazy" via reflection.
        /// </summary>
        /// <param name="entity">the entity to bind the autospecify event to</param>
        /// <param name="specifiedSuffix">optionally specify a suffix for the Specified property to set as true on changes</param>
        /// <param name="specifiedPrefix">optionally specify a prefix for the Specified property to set as true on changes</param>
        public static void Autospecify(this INotifyPropertyChanged entity, string specifiedSuffix = SPECIFIED_SUFFIX, string specifiedPrefix = null)
        {
            entity.PropertyChanged += (me, e) =>
            {
                foreach (var pi in me.GetType().GetProperties().Where(o => o.Name == specifiedPrefix + e.PropertyName + specifiedSuffix))
                {
                    pi.SetValue(me, true, BindingFlags.SetField | BindingFlags.SetProperty, null, null, null);
                }
            };
        }

        /// <summary>
        /// Create a new entity and <see cref="Autospecify"/> its properties when changed
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="specifiedSuffix"></param>
        /// <param name="specifiedPrefix"></param>
        /// <returns></returns>
        public static T Create<T>(string specifiedSuffix = SPECIFIED_SUFFIX, string specifiedPrefix = null) where T : INotifyPropertyChanged, new()
        {
            var ret = new T();
            ret.Autospecify(specifiedSuffix, specifiedPrefix);
            return ret;
        }
    }

    public static class GenericObject<T> where T : new()
    {
        public static T GenericMethod(bool inicio = false)
        {
            var source = new T();
            var sourceProps = source.GetType().GetProperties().ToList();
            Type t = typeof(GenericObject<>);

            foreach (var sourceProp in sourceProps)
            {
                if (sourceProp.PropertyType.IsClass && !sourceProp.PropertyType.IsArray && sourceProp.PropertyType.Namespace != "System")
                {
                    var c = Activator.CreateInstance(sourceProp.PropertyType);
                    Type genericType = t.MakeGenericType(new System.Type[] { sourceProp.PropertyType });
                    MethodInfo m = genericType.GetMethod(MethodInfo.GetCurrentMethod().Name);
                    //MethodInfo crear = genericType.GetMethod("Create");

                    //creo asigno e invoko
                    //c = crear.Invoke(null, new object[] { SPECIFIED_SUFFIX, null });
                    c = m.Invoke(null, new object[] { true });
                    sourceProp.SetValue(source, c, null);
                }
                else if (sourceProp.PropertyType.IsArray && sourceProp.PropertyType.Namespace != "System")
                {
                    IList souObj = sourceProp.GetValue(source, null) as IList;
                    string desName = sourceProp.PropertyType.FullName;
                    desName = desName.Replace("[]", "");
                    Type type = Type.GetType(desName);

                    if (type != null)
                    {
                        var cArray = Array.CreateInstance(type, new int[] { 0 });
                        var c = Activator.CreateInstance(Type.GetType(desName));
                        Type genericType = t.MakeGenericType(new System.Type[] { Type.GetType(desName) });
                        MethodInfo m = genericType.GetMethod(MethodInfo.GetCurrentMethod().Name);
                        //MethodInfo crear = genericType.GetMethod("Create");

                        //creo asigno e invoko
                        c = m.Invoke(null, new object[] { true });
                        cArray.SetValue(c, 0);
                        sourceProp.SetValue(source, cArray, null);
                    }

                }
            }
            return source;
        }
    }

    public static class GenericClass<T> where T : INotifyPropertyChanged, new()
    {
        private const string SPECIFIED_SUFFIX = "Specified";

        public static T GenericMethod(bool inicio = false)
        {
            var source = PropertySpecifiedExtensions.Create<T>();
            var sourceProps = source.GetType().GetProperties().ToList();
            Type t = typeof(GenericClass<>);

            foreach (var sourceProp in sourceProps)
            {
                if (sourceProp.PropertyType.IsClass && !sourceProp.PropertyType.IsArray && sourceProp.PropertyType.Namespace != "System")
                {
                    var c = Activator.CreateInstance(sourceProp.PropertyType);
                    Type genericType = t.MakeGenericType(new System.Type[] { sourceProp.PropertyType });
                    MethodInfo m = genericType.GetMethod(MethodInfo.GetCurrentMethod().Name);
                    //MethodInfo crear = genericType.GetMethod("Create");

                    //creo asigno e invoko
                    //c = crear.Invoke(null, new object[] { SPECIFIED_SUFFIX, null });
                    c = m.Invoke(null, new object[] { true });
                    sourceProp.SetValue(source, c, null);
                }
                else if (sourceProp.PropertyType.IsArray && sourceProp.PropertyType.Namespace != "System")
                {
                    IList souObj = sourceProp.GetValue(source, null) as IList;
                    string desName = sourceProp.PropertyType.FullName;
                    desName = desName.Replace("[]", "");
                    var cArray = Array.CreateInstance(Type.GetType(desName), new int[] { 0 });
                    var c = Activator.CreateInstance(Type.GetType(desName));
                    Type genericType = t.MakeGenericType(new System.Type[] { Type.GetType(desName) });
                    MethodInfo m = genericType.GetMethod(MethodInfo.GetCurrentMethod().Name);
                    //MethodInfo crear = genericType.GetMethod("Create");

                    //creo asigno e invoko
                    c = m.Invoke(null, new object[] { true });
                    cArray.SetValue(c, 0);
                    sourceProp.SetValue(source, cArray, null);

                }
            }
            return source;
        }
    }
}
