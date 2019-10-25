using ESIDIFCommon.Tools;
using System;
using System.Collections.Generic;
using System.ServiceModel.Channels;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ESIDIFCommon.Models.Xml
{
    public class SoapError
    {
        public string Title { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorDescription { get; set; }

        public string FaultDetail { get; set; }
        public string FaultReason { get; set; }
        public string FaultResponse { get; set; }
        public XmlNode FaultNode { get; set; }        
    }

    [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class Envelope
    {
        [XmlElement(ElementName = "Header", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public Header Header { get; set; }

        [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public XmlAnything<IBody> Body { get; set; }

        [XmlAttribute(AttributeName = "soapenv", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Soapenv { get; set; }
    }

    /*Usada para crear un body generic en cada consulta*/
    public interface IBody { }

    [XmlRoot(ElementName = "Header", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class Header
    {
        public Header()
        {

        }
        public Header(string id, string username, string password, string endpoint, string action)
        {
            Security = new Security
            {
                MustUnderstand = 1,
                UsernameToken = new UsernameToken(id, username, password)
            };
            To = new To
            {
                MustUnderstand = 1,
                Value = endpoint
            };
            Action = action;
            MessageID = "urn:uuid:" + Guid.NewGuid();
        }

        [XmlElement(ElementName = "Security", Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd")]
        public Security Security { get; set; }

        [XmlElement(ElementName = "To", Namespace = "http://www.w3.org/2005/08/addressing")]
        public To To { get; set; }

        [XmlElement(ElementName = "Action", Namespace = "http://www.w3.org/2005/08/addressing")]
        public string Action { get; set; }

        [XmlElement(ElementName = "MessageID", Namespace = "http://www.w3.org/2005/08/addressing")]
        public string MessageID { get; set; }
    }

    [XmlRoot(ElementName = "Security", Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd")]
    public class Security
    {
        [XmlAttribute("mustUnderstand", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public int MustUnderstand { get; set; }

        [XmlElement(ElementName = "UsernameToken", Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd")]
        public UsernameToken UsernameToken { get; set; }
    }

    [XmlRoot(ElementName = "To", Namespace = "http://www.w3.org/2005/08/addressing")]
    public class To
    {
        [XmlAttribute("mustUnderstand", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public int MustUnderstand { get; set; }

        [XmlText]//endpoint
        public string Value { get; set; }
    }


    public class SecurityHeader : MessageHeader
    {
        private readonly UsernameToken _usernameToken;

        public SecurityHeader(string id, string username, string password)
        {
            _usernameToken = new UsernameToken(id, username, password);
        }

        public override string Name
        {
            get { return "Security"; }
        }

        public override string Namespace
        {
            get { return "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd"; }
        }
        
        protected override void OnWriteHeaderContents(XmlDictionaryWriter writer, MessageVersion messageVersion)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(UsernameToken));
            serializer.Serialize(writer, _usernameToken);
        }
    }


    [XmlRoot(Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd")]
    public class UsernameToken
    {
        public UsernameToken()
        {
        }

        public UsernameToken(string id, string username, string password)
        {
            Id = id;
            Username = username;
            Password = new Password() { Value = password };
        }

        [XmlAttribute(Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd")]
        public string Id { get; set; }

        [XmlElement]
        public string Username { get; set; }

        [XmlElement]
        public Password Password { get; set; }
    }

    public class Password
    {
        public Password()
        {
            Type = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-username-token-profile-1.0#PasswordText";
        }

        [XmlAttribute]
        public string Type { get; set; }

        [XmlText]
        public string Value { get; set; }
    }
}
