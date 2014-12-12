using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SastreE.Programación.Ahorcado_Juego
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui empezamos el juego
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("<<<BIENVENIDO AL JUEGO DEL AHORCADO>>>");
            Console.WriteLine("<<Por EDU SASTRE FULLANA>>");
            String[] Palabra = new String[100];
            Random objeto = new Random();
            int i = 0, na = 0, tl = 0;
            Console.WriteLine(" El numero aletorio es " + na);
            //Console.WriteLine("\n la palabra aleatoria es " + palabra2);
            //Aqui mostramos la palabra aleatoria
            Console.WriteLine("\nY tiene " + tl + " Letras");


            Console.WriteLine(Palabra3);


                Console.Write(" Presiona una letra del teclado ");
                lp = Console.ReadLine();
                    Console.WriteLine("Palabra oculta es = " + Palabra3);
                
                    Console.WriteLine("La letra que has introducido no existe, llevas " + intento + " intento");
                
                    Console.WriteLine("....::::INTENTOS AGOTADOS, !!!!! HAS PERDIDO!!!!!::::.... ");
                    Console.WriteLine("La palabra correcta era " + Palabra2);
               
                    Console.WriteLine(" ....::::FELICIDADES, !!!! HAS GANADO !!!!!::::.... ");
                    break;
                

            Console.ReadKey();

        }
    }
}
    
