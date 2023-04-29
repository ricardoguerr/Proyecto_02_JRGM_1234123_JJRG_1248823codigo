using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Proyecto2
{
    class Probabilidades
    {
        public double ProbabilidadDupli(double[,] eljuegodu)
        {
            double trebol = 0;
            for (int i = 0; i < eljuegodu.GetUpperBound(0) + 1; i++)
            {
                for (int t = 0; t < eljuegodu.GetUpperBound(1) + 1; t++)
                {
                    if (eljuegodu[i, t] == 1)
                    {
                        trebol = trebol + 1;
                    }
                }
            }
            double probabilidadduplicartre = 0;
            if (trebol == 0)
            {
                probabilidadduplicartre = 0;
            }
            else
            {
                probabilidadduplicartre = (trebol / 10000) * 100;
            }
            double caraf1 = 0, caraf2 = 0, caraf3 = 0, caraf4 = 0;
            int f1 = 0, f2 = 1, f3 = 2, f4 = 3;
            for (int i = 0; i < eljuegodu.GetUpperBound(0) + 1; i++)
            {
                if (eljuegodu[i, f1] == 3)
                {
                    caraf1 = caraf1 + 1;
                }
            }
            for (int i = 0; i < eljuegodu.GetUpperBound(0) + 1; i++)
            {
                if (eljuegodu[i, f2] == 3)
                {
                    caraf2 = caraf2 + 1;
                }
            }
            for (int i = 0; i < eljuegodu.GetUpperBound(0) + 1; i++)
            {
                if (eljuegodu[i, f3] == 3)
                {
                    caraf3 = caraf3 + 1;
                }
            }
            for (int i = 0; i < eljuegodu.GetUpperBound(0) + 1; i++)
            {
                if (eljuegodu[i, f4] == 3)
                {
                    caraf4 = caraf4 + 1;
                }
            }
            double probabilidadducar = 0;
            double probabilidadduplicar = 0;
            probabilidadducar = probabilidadducar + (caraf1 * caraf2);
            probabilidadducar = probabilidadducar + (caraf1 * caraf3);
            probabilidadducar = probabilidadducar + (caraf1 * caraf4);
            probabilidadducar = probabilidadducar + (caraf2 * caraf3);
            probabilidadducar = probabilidadducar + (caraf2 * caraf4);
            probabilidadducar = probabilidadducar + (caraf3 * caraf4);
            double pb = (probabilidadducar / 10000) * 100;
            probabilidadduplicar = pb + probabilidadduplicartre;
            return probabilidadduplicar;
        }
        public double Probabilidadmil(double[,] eljuegomil)
        {
            double diamantesf1 = 0, diamantesf2 = 0, diamantesf3 = 0, diamantesf4 = 0;
            int f1 = 0, f2 = 1, f3 = 2, f4 = 3;
            for (int i = 0; i < eljuegomil.GetUpperBound(0) + 1; i++)
            {
                if (eljuegomil[i, f1] == 2)
                {
                    diamantesf1 = diamantesf1 + 1;
                }
            }
            for (int i = 0; i < eljuegomil.GetUpperBound(0) + 1; i++)
            {
                if (eljuegomil[i, f2] == 2)
                {
                    diamantesf2 = diamantesf2 + 1;
                }
            }
            for (int i = 0; i < eljuegomil.GetUpperBound(0) + 1; i++)
            {
                if (eljuegomil[i, f3] == 2)
                {
                    diamantesf3 = diamantesf3 + 1;
                }
            }
            for (int i = 0; i < eljuegomil.GetUpperBound(0) + 1; i++)
            {
                if (eljuegomil[i, f4] == 2)
                {
                    diamantesf4 = diamantesf4 + 1;
                }
            }
            double factoriald = diamantesf1 * diamantesf2 * diamantesf3 * diamantesf4;
            double probabilidaddi = 0;
            if (factoriald == 0)
            {
                probabilidaddi = 0;
            }
            else
            {
                probabilidaddi = (factoriald / 10000) * 100;
            }
            return probabilidaddi;
        }
        public double Probabilidadretorno(double[,] eljuegoregreso)
        {
            double solf1 = 0, solf2 = 0, solf3 = 0, solf4 = 0;
            int f1 = 0, f2 = 1, f3 = 2, f4 = 3;
            for (int i = 0; i < eljuegoregreso.GetUpperBound(0) + 1; i++)
            {
                if (eljuegoregreso[i, f1] == 4)
                {
                    solf1 = solf1 + 1;
                }
            }
            for (int i = 0; i < eljuegoregreso.GetUpperBound(0) + 1; i++)
            {
                if (eljuegoregreso[i, f2] == 4)
                {
                    solf2 = solf2 + 1;
                }
            }
            for (int i = 0; i < eljuegoregreso.GetUpperBound(0) + 1; i++)
            {
                if (eljuegoregreso[i, f3] == 4)
                {
                    solf3 = solf3 + 1;
                }
            }
            for (int i = 0; i < eljuegoregreso.GetUpperBound(0) + 1; i++)
            {
                if (eljuegoregreso[i, f4] == 4)
                {
                    solf4 = solf4 + 1;
                }
            }
            double factorialsol = solf1 * solf2 * solf3 * solf4;
            double probabilidadretornosol = 0;
            if (factorialsol == 0)
            {
                probabilidadretornosol = 0;
            }
            else
            {
                probabilidadretornosol = (factorialsol / 10000) * 100;
            }
            double carita = 0;
            for (int i = 0; i < eljuegoregreso.GetUpperBound(0) + 1; i++)
            {
                for (int t = 0; t < eljuegoregreso.GetUpperBound(1) + 1; t++)
                {
                    if (eljuegoregreso[i, t] == 3)
                    {
                        carita = carita + 1;
                    }
                }
            }
            double probabilidadretornocarita = 0;
            if (carita == 0)
            {
                probabilidadretornocarita = 0;
            }
            else
            {
                probabilidadretornocarita = (carita / 10000) * 100;
            }
            double probabilidadretorno = probabilidadretornocarita + probabilidadretornosol;
            return probabilidadretorno;
        }
        public double Probabilidadmitad(double[,] eljuegomitad)
        {
            double solf1 = 0, solf2 = 0, solf3 = 0, solf4 = 0;
            int f1 = 0, f2 = 1, f3 = 2, f4 = 3;
            for (int i = 0; i < eljuegomitad.GetUpperBound(0) + 1; i++)
            {
                if (eljuegomitad[i, f1] == 2)
                {
                    solf1 = solf1 + 1;
                }
            }
            for (int i = 0; i < eljuegomitad.GetUpperBound(0) + 1; i++)
            {
                if (eljuegomitad[i, f2] == 2)
                {
                    solf2 = solf2 + 1;
                }
            }
            for (int i = 0; i < eljuegomitad.GetUpperBound(0) + 1; i++)
            {
                if (eljuegomitad[i, f3] == 2)
                {
                    solf3 = solf3 + 1;
                }
            }
            for (int i = 0; i < eljuegomitad.GetUpperBound(0) + 1; i++)
            {
                if (eljuegomitad[i, f4] == 2)
                {
                    solf4 = solf4 + 1;
                }
            }
            double probpar = 0;
            probpar = probpar + (solf1 * solf2);
            probpar = probpar + (solf1 * solf3);
            probpar = probpar + (solf1 * solf4);
            probpar = probpar + (solf2 * solf3);
            probpar = probpar + (solf2 * solf4);
            probpar = probpar + (solf3 * solf4);
            double probabilidadmitad = (probpar / 10000) * 100;
            return probabilidadmitad;
        }
        public double ProbabilidadCero(double[,] eljuegocero)
        {
            double bomba = 0;
            for (int i = 0; i < eljuegocero.GetUpperBound(0) + 1; i++)
            {
                for (int t = 0; t < eljuegocero.GetUpperBound(1) + 1; t++)
                {
                    if (eljuegocero[i, t] == 6)
                    {
                        bomba = bomba + 1;
                    }
                }
            }
            double probabilidadcero = 0;
            if (bomba == 0)
            {
                probabilidadcero = 0;
            }
            else
            {
                probabilidadcero = (bomba / 10000) * 100;
            }
            return probabilidadcero;
        }
    }
}
