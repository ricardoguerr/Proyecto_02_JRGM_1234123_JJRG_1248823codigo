using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Proyecto2
{
    class Simbolos
    {
        public string[] Convertirasimbolo(double[] eljuegoquegano)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string[] simbolos = new string[4];
            string trebol = "🍀";
            string diamante = "💎";
            string carita = "🙂";
            string sol = "☀️";
            string casa = "🏠";
            string bomba = "💣";
            for (int i = 0; i < eljuegoquegano.Length; i++)
            {

                if (eljuegoquegano[i] == 1)
                {
                    simbolos[i] = "🍀";
                }
                else if (eljuegoquegano[i] == 2)
                {
                    simbolos[i] = "💎";
                }
                else if (eljuegoquegano[i] == 3)
                {
                    simbolos[i] = "🙂";
                }
                else if (eljuegoquegano[i] == 4)
                {
                    simbolos[i] = "☀️";
                }
                else if (eljuegoquegano[i] == 5)
                {
                    simbolos[i] = "🏠";
                }
                else if (eljuegoquegano[i] == 6)
                {
                    simbolos[i] = "💣";
                }
            }
            return simbolos;
        }
    }
}
