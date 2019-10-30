using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ESIDIFCommon.enviarmailService;

namespace ESIDIFCommon.Business.Contract
{
    public class MailService
    {
        public EnviarMail _mailService = new EnviarMail();
        public MailService(string url)
        {
            _mailService.Url = url;
            _mailService.Credentials = CredentialCache.DefaultCredentials;
        }

        public void sendMail(string cuerpo, string destinatario, string asunto)
        {
            _mailService.EnvioPruebaMail(asunto, destinatario, cuerpo);
        }
    }
}
