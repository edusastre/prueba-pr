using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace juego_del_ahorcado
{
    class Orcado
    {
        static void Main(string[] args)
        {
            //AQUI EMPIEZA EL PROGRAMA
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            //A CONTINUACION LAS PALABRAS, USTEDES LAS PUEDEN CAMIBAR A LAS
            // QUE QUIERAN
            String[] palabra = new String[100];

            palabra[1] = "Saltar";
            palabra[2] = "nava";
            palabra[3] = "juan";
            palabra[4] = "san luis";
            palabra[5] = "jacobo";
            palabra[6] = "colombiano";
            palabra[7] = "tuberia";
            palabra[8] = "gato";
            palabra[9] = "perro";
            palabra[10] = "celular";
            palabra[11] = "cacahuate";
            palabra[12] = "alexa";
            palabra[13] = "pluma";
            palabra[14] = "lapiz";
            palabra[15] = "tiburon";
            palabra[16] = "coyote";
            palabra[17] = "piñata";
            palabra[18] = "cerillo";
            palabra[19] = "dinosaurio";
            palabra[20] = "YAHVE";


            Random objeto = new Random();
            int i = 0, na = 0, tl = 0;


            String palabra2 = "", palabra3 = "", le = "", lp = ""; ;

            na = objeto.Next(1, 20);
            palabra2 = palabra[na];
            tl = palabra2.Length;
            Console.WriteLine(" el numero aletorio es " + na);
            //Console.WriteLine("\n la palabra aleatoria es " + palabra2);
            //AQUI TE MUESTRA LA PALABRA ALEATORIA
            Console.WriteLine("\nY tiene " + tl + " letras");


            //este ciclo for es para poner los signos ? o espacion
            for (i = 1; i <= tl; i++)
            {
                if (palabra2.Substring(i, 0) != " ")
                    palabra3 = palabra3 + "?";
                else
                    palabra3 = palabra3 + " ";

            }


            Console.WriteLine(palabra3);


            //aqui empiezas a adivinar la palabra presionando teclas

            int intento = 0;


            do
            {
                //String lp = "", le = "";
                Boolean exito = false;
                Console.Write("Presione una letra ");
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

                if (exito) //las variables booleanas solo van solar
                {
                    Console.WriteLine("Palabra oculta = " + palabra3);
                }
                else
                {
                    intento++;
                    Console.WriteLine("Letra no exiate lleva " + intento + " intento");
                }

                if (intento == 5)
                {
                    Console.WriteLine("Intentos agotados, !!!!! PERDISTE !!!! ");
                    Console.WriteLine("La palabra correcta era " + palabra2);
                }
                if (palabra2 == palabra3)
                {
                    Console.WriteLine("Felicidades, !!!! GANASTE !!!!!!!!! ");
                    break;
                }




            }
            while (intento < 5);


            Console.ReadKey();

        }

    }
}