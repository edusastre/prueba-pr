using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Class1
    {
        static void Main()
        {
            //Aqui mostraremos las palabras que queremos jugar
            String[] Palabra = new String[100];

            Palabra[1] = "perro";
            Palabra[2] = "casa";
            Palabra[3] = "ordenador";
            Palabra[4] = "pelota";
            Palabra[5] = "gato";
            Palabra[6] = "montaña";
            Palabra[7] = "sombrero";
            Palabra[8] = "escarabajo";
            Palabra[9] = "motocicleta";
            Palabra[10] = "libro";
            Palabra[11] = "guadalajara";
            Palabra[12] = "biblioteca";

            Random objeto = new Random();
            int i = 0, na = 0, tl = 0;


            String Palabra2 = "", Palabra3 = "", le = "", lp = ""; ;

            na = objeto.Next(1, 12);
            Palabra2 = Palabra[na];
            tl = Palabra2.Length;

            //Este bucle for es para poner los signos ? o espacio
            for (i = 1; i <= tl; i++)
            {
                if (Palabra2.Substring(i, 0) != " ")
                    Palabra3 = Palabra3 + "?";
                else
                    Palabra3 = Palabra3 + " ";

            }

            //Aqui empezamos a adivinar la palabra presionando el teclado

            int intento = 0;


            do
            {
                //String lp = "", le = "";
                Boolean exito = false;
                for (i = 0; i <= tl - 1; i++)
                {

                    le = Palabra2.Substring(i, 1);
                    if (le.Equals(lp))
                    {

                        Palabra3 = Palabra3.Remove(i, 1);
                        Palabra3 = Palabra3.Insert(i, lp);
                        exito = true;

                    }

                }

                if (exito) //Las variables booleanas van solas
                {
                }
                else
                {
                    intento++;                  
                }

                if (intento == 5)
                {
                }
                if (Palabra2 == Palabra3)
                {                  
                    break;
                }




            }
            while (intento < 5);

        }
    }
}
