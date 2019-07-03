using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESIDIF.Tools
{
    public static class Functions
    {
        public static string AregarAlgo(string origen)
        {
            return origen + DateTime.Now.ToLongDateString();
        }
    }

}
