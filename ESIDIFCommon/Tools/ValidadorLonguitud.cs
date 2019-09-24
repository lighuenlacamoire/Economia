using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ESIDIFCommon.Tools
{
    public class validadorLongitud<T> where T : class
    {
        public IList<ErrorLongitud> validarLongitud<T>(T request)
        {
            var res = new List<ErrorLongitud>();

            foreach (var _property in request.GetType().GetProperties().Where(x => x.PropertyType == typeof(string)))
            {
                var prop = request.GetType().GetProperty(_property.Name);

                object[] attrs = prop.GetCustomAttributes(true);


                foreach (object attr in attrs)
                {
                    longiAttr longiAttr = attr as longiAttr;
                    
                    if (longiAttr != null)
                    {
                        var valor = prop.GetValue(request, null) as string;

                        if (valor != null && valor.Length > longiAttr.Longitud )
                        {
                            res.Add(new ErrorLongitud()
                            {
                                Nombre = prop.Name,
                                Longitud = valor.Length,
                                LongitudEsperada = longiAttr.Longitud,
                            });
                        }

                      
                    }

                }
            }

            return res;
        }


    }
}