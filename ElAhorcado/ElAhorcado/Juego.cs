using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SastreE.Programacion.Proyecto.ElAhorcado
{
    class Juego
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce la palabra que quieres jugar");
            Console.ReadLine();

            Palabra = Console.ReadLine();
            Console.Clear();

            Console.SetCursorPosition(Palabra.Length + i, 1);
            Console.Write("_");

            Console.Write("Introduce otra vez la palabra, máximo 12 caracteres");
            Console.ReadLine();

            Console.WriteLine("introduce la letra:");
            Letra = Console.ReadKey().KeyChar;
            Console.Clear();

            Errores--;
                        Console.WriteLine(Errores);

             Console.WriteLine("encertades", Acertadas + 1);
                            Console.SetCursorPosition(Palabra.Length + i, 1);
                            Console.Write(Palabra[i]);

             Console.Write("HAS PERDIDO");

             Console.ReadKey();
             Console.Clear();
             //Acabar juego
             Console.Write("Quereis volver a jugar?");
             Console.Write("Sí(prem si)          No( prem no)");
             Console.ReadKey();
             Console.Clear();

               

            
        }
    }
}
