using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElAhorcado2
{
    public class Juego2
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
                
                if (Palabra.Length > 12)
                {
                  
                }
                
                for (i = 0; i < Palabra.Length; i++)
                {
                   
                }
                Errores = 11;
                Acertadas = 0;

                while (Acertadas < Palabra.Length && Errores > 0)
                {
                   
                    Correcto = false;
                    for (i = 0; i < Palabra.Length; i++)
                    {
                        if (Letra == Palabra[i])
                        {
                            Correcto = true;
                            Acertadas++;
                           
                        }
                    }
                    if (Correcto != true)
                    {
                        
                    }
                }

                if (Errores == 0)
                {
                   
                }
                if (Acertadas == Palabra.Length)
                {
                    Console.Write("ENHORABUENA!! HAS GANADO!!!");
                }
                Console.ReadKey();
                Console.Clear();
                //Acabar juego
                Console.Write("Quereis volver a jugar?");
                Console.Write("Sí(prem si)          No( prem no)");
                Console.ReadKey();
                Console.Clear();
                if (No == "no")
                {
                    Console.Write("GRACIAS POR JUGAR! HASTA OTRA!");
                }



            }
        }
    }
}
