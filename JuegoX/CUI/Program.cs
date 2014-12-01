using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuigR.Programacion.Eval1.Juego.Logica;

namespace PuigR.Programacion.Eval1.Juego.Logica
{
    class Program
    {
        static void Main(string[] args)
        {
            int secreto = ModeloJuego.SecretoDeLaVida();

            Console.WriteLine("El secreto de la vida es " + secreto);
            Console.ReadKey();
        }
    }
}
