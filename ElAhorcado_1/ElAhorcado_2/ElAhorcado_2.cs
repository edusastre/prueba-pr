using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SastreE.Programación.Juego.ElAhorcado_2
{
    static public class ElAhorcado_2
    {
       static void Main()
       {
           //Variables
        int Acertadas, Errores, i;
        string Palabra, Sí, No;
        bool Correcto;
        char Letra;

             //Leer entradas
        Sí = "Si";
        No = "No";
        while (Sí == "Si") 
        {
            Console.Clear();
            Palabra = Console.ReadLine();
            if (Palabra.Length > 12) 
            {

            }
            Console.Clear();
            for (i = 0; i < Palabra.Length; i++)
            {
                Console.SetCursorPosition(Palabra.Length + i, 1);
                Console.Write("_");
            }
            Errores = 5;
            Acertadas = 0;

            while (Acertadas < Palabra.Length && Errores > 0) 
            {
                Letra = Console.ReadKey().KeyChar;
                Correcto = false;
                for (i = 0; i < Palabra.Length; i++)
                {
                    if (Letra == Palabra[i]) 
                    {
                        Correcto = true;
                        Acertadas++;
                        Console.WriteLine("Acertadas", Acertadas + 1);
                        Console.SetCursorPosition(Palabra.Length + i, 1);
                        Console.Write(Palabra[i]);
                    }
                }
            }

            if (Correcto != true)
            {

            }
       
 
            if (Errores == 0)
            {

            }

            if (Acertadas == Palabra.Length) 
            {

            }

            if (No == "n") 
            {
 
            }

       }


    }
       
    
}
