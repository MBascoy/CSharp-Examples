using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Caching;

namespace AlmacenApp
{
    internal class Almacen
    {
        private Cache cache;
        public Almacen()
        {
            cache = new Cache();
        }

        public String ObtenerDato()
        {
            String dato;

            dato = cache.Get("datoCadena") as String;

            if (dato == null)
            {
                dato = ObtenerDesdeFuenteExterna();
                cache.Add("datoCadena", dato, null, DateTime.Now.AddDays(1), TimeSpan.Zero, CacheItemPriority.High,
                null);
            }

            return dato;
        }

        private String ObtenerDesdeFuenteExterna()
        {
            return "hola";
        }


    }
}
