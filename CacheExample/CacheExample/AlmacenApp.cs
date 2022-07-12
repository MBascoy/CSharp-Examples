using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Caching;

namespace AlmacenApp
{
    internal class AlmacenApp
    {
        static void Main(string[] args)
        {
            Almacen almacen = new Almacen();

            Console.WriteLine(almacen.ObtenerDato());

            Console.WriteLine(almacen.ObtenerDato());
        }
    }
}
