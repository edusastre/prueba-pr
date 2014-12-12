using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SastreE.Programación.Ahorcado
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui comenzamos el programa
            //Console.ForegroundColor = ConsoleColor.DarkYellow; para que el texto introducido sea de color amarillo.
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("<<<<BIENVENIDO AL JUEGO DEL AHORCADO>>>>");
            Console.WriteLine("<<Por el alumno EDU SASTRE FULLANA de 1ªDAW>>");

            int i;
            int na;
            int tl;
            String palabra2;
            String palabra3;
            String le;
            String lp;
            palabraAleatoria(out i, out na, out tl, out palabra2, out palabra3, out le, out lp);
            Console.WriteLine(" El numero aletorio es " + na);
            //Console.WriteLine("\n la palabra aleatoria es " + palabra2);
            //Aqui mostramos la palabra aleatoria
            Console.WriteLine("\nY tiene " + tl + " letras");

            bucleEspacio(ref i, tl, palabra2, ref palabra3);

            Console.WriteLine(palabra3);

            //Aqui empezamos a adivinar las palabras utilizando el teclado


            doEspacio(ref i, tl, palabra2, ref palabra3, ref le, ref lp);


            Console.ReadKey(); //FF

        }

        private static void doEspacio(ref int i, int tl, String palabra2, ref String palabra3, ref String le, ref String lp)
        {
            int intento = 0;

            do
            {
                //String lp = "", le = "";
                Boolean exito = false;

                lp = Console.ReadLine();
                for (i = 0; i <= tl - 1; i++)
                {

                    le = palabra2.Substring(i, 1);
                    if (le.Equals(lp))
                    {

                        palabra3 = palabra3.Remove(i, 1);
                        palabra3 = palabra3.Insert(i, lp);
                        exito = true;

                    }

                }

                if (exito) //las variables booleanas solo van solas
                {
                    Console.WriteLine("La palabra oculta es = " + palabra3);
                }
                else
                {
                    intento++;
                    Console.WriteLine("La letra que has introducido no existe, llevas " + intento + " intento");
                }
                //Utilizamos un bucle if para contar los intentos fallados, un intento por cada letra incorrecta
                //En caso de fallar los 5 intentos perderemos la partida
                if (intento == 5)
                {
                    Console.WriteLine("....::::Intentos agotados, !!!!! HAS PERDIDO !!!!::::.... ");
                    Console.WriteLine("La palabra correcta era " + palabra2);
                }
                //Utilizamos este bucle para que la letra tecleada en la palabra2 corresponda a una letra de la palabra3
                //En caso de acertar todas las letras tecleadas ganaremos la partida
                if (palabra2 == palabra3)
                {
                    Console.WriteLine("....::::FELICIDADES, !!!!! HAS GANADO!!!!!::::.... ");
                    break;
                }

            }
            while (intento < 5);
        }

        private static void bucleEspacio(ref int i, int tl, String palabra2, ref String palabra3)
        {
            //un bucle for , puede ejecutar una instrucción o un bloque de instrucciones varias veces hasta que una expresión especificada se evalúe con false.
            //Este bucle for es para poner los signos ? o espacio
            for (i = 1; i <= tl; i++)
            {
                if (palabra2.Substring(i, 0) != " ")
                    palabra3 = palabra3 + "?";
                else
                    palabra3 = palabra3 + " ";

            }
        }

        private static void palabraAleatoria(out int i, out int na, out int tl, out String palabra2, out String palabra3, out String le, out String lp)
        {
            //Aqui pondremos las palabras que queremos jugar
            String[] palabra = new String[100];

            palabra[1] = "arbol";
            palabra[2] = "barco";
            palabra[3] = "motocicleta";
            palabra[4] = "casa";
            palabra[5] = "escarabajo";
            palabra[6] = "pelota";
            palabra[7] = "perro";
            palabra[8] = "gato";
            palabra[9] = "programacion";
            palabra[10] = "montaña";
            palabra[11] = "salamandra";
            palabra[12] = "libro";

            Random objeto = new Random();
            i = 0;
            na = 0;
            tl = 0;


            palabra2 = "";
            palabra3 = "";
            le = "";
            lp = "";
            ;

            na = objeto.Next(1, 12);
            palabra2 = palabra[na];
            tl = palabra2.Length;
        }
    }
}

