using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDemoEventos
{
    class Programa
    {
        static void Main()


        {
            Acción SAN = new Acción { Simbolo = "SAN" };

            SAN.PrecioChanged = (a, n) => Console.WriteLine("Precio: " + a + "->" + n);
            //SAN.PrecioChanged = SAN.PrecioChanged + SAN_PrecioChangedHandler;
            SAN.PrecioChanged += SAN_PrecioChangedHandler;

            SAN.Precio = 6;
            SAN.Precio = 8;

            //SAN.PrecioChanged = SAN.PrecioChanged - SAN_PrecioChangedHandler;

            SAN.Precio = 7;

            SAN.PrecioChanged += SAN_PrecioChangedHandler2;

            SAN.Precio = 10;

            Console.ReadKey();

        }

        static void SAN_PrecioChangedHandler2(decimal antes, decimal actual)
        {
            Console.WriteLine("Acciones del Santander");
            Console.WriteLine("Anterior: {0}", antes);
            Console.WriteLine("Actual:   {0}", actual);
        }
    }
}
