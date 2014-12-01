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
            //Comenzamos el juego
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();

            //Palabras con las que vamos a jugar
            String[] Palabra = new String[100];

            Palabra[1] = "Perro";
            Palabra[2] = "Casa";
            Palabra[3] = "Ordenador";
            Palabra[4] = "Pelota";
            Palabra[5] = "Gato";
            Palabra[6] = "Montaña";
            Palabra[7] = "Sombrero";
            Palabra[8] = "Escarabajo";
            Palabra[9] = "Motocicleta";
            Palabra[10] = "Libro";

            Random objeto = new Random();
            int i = 0, na = 0, tl = 0;

            string Palabra2 = "", Palabra3 = "", le = "", lp = ""; ;

            na = objeto.Next(1, 10);
            Palabra2 = Palabra[na];
            tl = Palabra2.Length;
            Console.WriteLine(" El número aletorio es " + na);
            //Aqui se muestra la palabra aleatoria
            Console.WriteLine(" Tiene " + tl + " letras ");

            for (i = 1; i <= tl; i++) 
            {
                if (Palabra2.Substring(i, 0) != " ")
                    Palabra3 = Palabra3 + "?";
                else
                    Palabra3 = Palabra3 + " ";
            }

            Console.WriteLine(Palabra3);

            //Aqui empezamos a adivinar palabras presionando el teclado

            int intento = 0;
            
            
        }
    }
}
