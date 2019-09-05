using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESIDIF.Models.Session
{
    public class User
    {
        public User()
        {
            HasToken = false;
        }

        public string UserName { get; set; }

        public long Cuip { get; set; }



        public bool HasToken { get; set; }

        public string UserId { get; set; }

        public string Nombre { get; set; }

        public string CUIL { get; set; }

        public string Entity { get; set; }

        public string Oficina { get; set; }

        public string OficinaDetalle { get; set; }

        public string IP { get; set; }

        public bool ControlIP { get; set; }

        public DateTime ExpiraToken { get; set; }

        public string Perfil { get; set; }



        public string Sistema { get; set; }

        public string[] Grupos { get; set; }



        public string Departamento { get; set; }

        public string Sector { get; set; }

    }
}
