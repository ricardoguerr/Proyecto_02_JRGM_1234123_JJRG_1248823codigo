using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Proyecto2
{
    class Ganancias
    {
        public double GananciasApuesta(double[] juegofinal, double laapuesta)
        {
            int canttrebol = 0, cantdiamante = 0, cantcarita = 0, cantsol = 0, cantcasa = 0, cantbomba = 0;
            for (int i = 0; i < juegofinal.Length; i++)
            {
                if (juegofinal[i] == 1)
                {
                    canttrebol = canttrebol + 1;
                }
            }
            for (int i = 0; i < juegofinal.Length; i++)
            {
                if (juegofinal[i] == 2)
                {
                    cantdiamante = cantdiamante + 1;
                }
            }
            for (int i = 0; i < juegofinal.Length; i++)
            {
                if (juegofinal[i] == 3)
                {
                    cantcarita = cantcarita + 1;
                }
            }
            for (int i = 0; i < juegofinal.Length; i++)
            {
                if (juegofinal[i] == 4)
                {
                    cantsol = cantsol + 1;
                }
            }
            for (int i = 0; i < juegofinal.Length; i++)
            {
                if (juegofinal[i] == 5)
                {
                    cantcasa = cantcasa + 1;
                }
            }
            for (int i = 0; i < juegofinal.Length; i++)
            {
                if (juegofinal[i] == 6)
                {
                    cantbomba = cantbomba + 1;
                }
            }
            double ganancia = 0;
            double multiplicador = 0;
            if (cantdiamante == 4)
            {
                multiplicador = multiplicador + 10;
            }
            if (canttrebol > 0)
            {
                multiplicador = multiplicador + (2 * canttrebol);
            }
            if (cantcarita > 0)
            {
                multiplicador = multiplicador + (1 * cantcarita);
            }
            if (cantsol > 0)
            {
                multiplicador = multiplicador + (0.25 * cantsol);
            }
            if (cantcasa > 0)
            {
                multiplicador = multiplicador + 0;
            }
            if (cantbomba != 0)
            {
                multiplicador = 0;
            }
            ganancia = laapuesta * multiplicador;
            return ganancia;

        }
    }
}
