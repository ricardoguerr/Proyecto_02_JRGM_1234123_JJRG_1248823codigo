using System;
using System.Diagnostics.CodeAnalysis;
namespace Codigo_Proyecto2
{


    internal class Program
    {
        private static void Main(string[] args)
        {
            //validaciones
            int valor;
            bool valnombre = true;
            bool valnoID = true;
            bool valNac = true;
            bool valAño = true, valMes = true, valDia = true;
            bool valTitular = true, valNumtar = true, valCodigo = true;
            bool valAñotar = true, valMestar = true;
            bool valCant = true;
            bool procesototal = true;
            bool valPago = true;
            bool tarjetaexpirada = true;
            int añoTarjeta = 0;
            int mesTarjeta = 0;
            //
            string sn, sn2, sn3 = "";
            string titular;
            int numtarjeta;
            string fecha;
            double cantidadapostar = 0;
            string nombre = "";
            int noID = 0;
            int dia, mes, año;
            string nacionalidad = "";
            bool seguir = true, juego = true, imprimird = true;
            double[,] slots = new double[10, 4];
            double ganancias = 0;
            bool jugarotravez = true;
            int edadfinal = 0;
            Console.WriteLine("__________________________________________AIgg      ");
            Console.WriteLine("_____________________________________gggggggggg_    ");
            Console.WriteLine("__________________________________ggggggggggg0gg    ");
            Console.WriteLine("_______________________________ggggggggggggggggggg  ");
            Console.WriteLine("_____ggg____ggggggg__________gggggggggggg_____ggggg                   BIENVENIDO       ");
            Console.WriteLine("__ggggggggggggggggggggggggggggggggggggggg             _^_                                             _^_");
            Console.WriteLine("_gggggg__ggggggggggggggggggggggggggggggg             (___)-------------------------------------------(___)");
            Console.WriteLine("gggggg___gggggggggggggggggggggggggggggg              | / |   _____  ____ ______  ______ ____ ______  | / |");
            Console.WriteLine("ggggg____ggggggggggggggggggggggggggggg               |   |   |    | |    |       |    |    / |    |  |   |");
            Console.WriteLine("gggg_____ggggggggggggggggggggggggggggg               | / |   |___ | |__  |  ____ |    |   /  |    |  | / |");
            Console.WriteLine("gg_________ggggggggggggggggggggggggggg               |   |   |      |    |  |  | |----|  /   |    |  |   |");
            Console.WriteLine("__________gggggggg_gggggggggggggggggg                |___|   |      |___ |_____| |    | /___ |____|  |___|");
            Console.WriteLine("______gggggggggggg_____________ggggggg              (_____)-----------------------------------------(_____)");
            Console.WriteLine("_____gggg____gggg________________ggggg                                COIN MASTER       ");
            Console.WriteLine("_____ggR_____ggg___________________gggg                                 CASINO      ");
            Console.WriteLine("_____gg_____gggg___________ggg__ggggggggg           ");
            Console.WriteLine("____ggg______ggg____________gggggg____ggg           ");
            Console.WriteLine("__gggg_________ggg______________________gg                   PRRESIONE ENTER PARA COMENZAR       ");
            Console.WriteLine("__gg____________ggg______________________gg         ");
            Console.WriteLine("_________________gggg_____________________ggg       ");
            Console.WriteLine("__________________gggg_____________________ggg      ");
            Console.ReadKey();
            while (procesototal)
            {
                while (imprimird)
                {
                    while (juego)
                    {
                        while (seguir)
                        {
                            Console.Clear();
                            while (valnombre)
                            {
                                Console.WriteLine("Ingrese su nombre completo");
                                nombre = Convert.ToString(Console.ReadLine());

                                if (int.TryParse(nombre, out valor))
                                {
                                    Console.WriteLine("Error, ingrese un nombre valido");
                                }
                                else
                                {
                                    valnombre = false;
                                }
                            }
                            do
                            {
                                Console.WriteLine("Ingrese su número de identificación:");
                                valnoID = int.TryParse(Console.ReadLine(), out noID);

                                if (!valnoID)
                                {
                                    Console.WriteLine("Error, ingrese un numero de identificación valido");
                                }
                                else
                                {
                                    valnombre = false;
                                    break;
                                }

                            } while (!valnoID);
                            while (valNac)
                            {
                                Console.WriteLine("Ingrese su nacionanalidad");
                                nacionalidad = Convert.ToString(Console.ReadLine());

                                if (int.TryParse(nacionalidad, out valor))
                                {
                                    Console.WriteLine("Error, ingrese una nacionalidad valida");
                                }
                                else
                                {
                                    valNac = false;

                                }
                            }
                            do
                            {
                                Console.WriteLine("Ingrese su año de nacimiento");
                                valAño = int.TryParse(Console.ReadLine(), out año);

                                if (!valAño)
                                {
                                    Console.WriteLine("Error, ingrese un año valido");
                                }
                                else
                                {
                                    valAño = false;
                                    break;
                                }

                            } while (!valAño);
                            do
                            {
                                Console.WriteLine("Ingrese su mes de nacimiento");
                                valMes = int.TryParse(Console.ReadLine(), out mes);

                                if (!valMes)
                                {
                                    Console.WriteLine("Error, ingrese un mes valido");
                                }
                                else
                                {
                                    valMes = false;
                                    break;
                                }

                            } while (!valMes);
                            do
                            {
                                Console.WriteLine("Ingrese su día de nacimiento");
                                valDia = int.TryParse(Console.ReadLine(), out dia);

                                if (!valDia)
                                {
                                    Console.WriteLine("Error, ingrese un día valido");
                                }
                                else
                                {
                                    valDia = false;
                                    break;
                                }

                            } while (!valDia);
                            DateTime fActual = DateTime.Now;
                            DateTime fNacimiento = new DateTime(año, mes, dia);
                            int edad = fActual.Year - fNacimiento.Year;
                            edadfinal = edad;
                            if (fNacimiento > fActual.AddYears(-edad))
                            {
                                edad--;
                            }

                            if (edad >= 21)
                            {
                                Console.WriteLine("Eres mayor de edad, puedes apostar");
                            }
                            else
                            {
                                Console.WriteLine("Menor de edad, no puedes apostar");
                                Environment.Exit(0);
                            }

                            for (int i = 0; i < 10; i++)
                            {
                                for (int f = 0; f < 4; f++)
                                {
                                    Random r = new Random();
                                    slots[i, f] = r.Next(1, 7);
                                }
                            }
                            Console.WriteLine("Presione enter para consultar las probabilidades de victoria");
                            Console.ReadKey();
                            Console.Clear();
                            Probabilidades ganar = new Probabilidades();
                            Console.WriteLine("Probabilidades de victoria: ");
                            Console.WriteLine("Probabilidad de obtener el 1000% de la apuesta: " + ganar.Probabilidadmil(slots) + "%");
                            Console.WriteLine("Probabilidad de duplicar su apuesta: " + ganar.ProbabilidadDupli(slots) + "%");
                            Console.WriteLine("Probabilidad de obtener de regreso su apuesta: " + ganar.Probabilidadretorno(slots) + "%");
                            Console.WriteLine("Probabilidad de perder la mitad de su apuesta:" + ganar.Probabilidadmitad(slots) + "%");
                            Console.WriteLine("Probabilidad de perder toda su apuesta: " + ganar.ProbabilidadCero(slots) + "%");
                            Console.WriteLine();
                            Console.WriteLine();
                            /*for (int i = 0; i < 10; i++)
                            {
                                for (int f = 0; f < 4; f++)
                                {
                                    Console.Write(slots[i, f] + " ");
                                }
                                Console.WriteLine();
                            }*/
                            do
                            {
                                Console.WriteLine("¿Desea apostar? s = si, n = no");
                                sn = Console.ReadLine().ToLower();

                                if (sn == "s")
                                {
                                    seguir = true;
                                }
                                else if (sn == "n")
                                {
                                    seguir = false;
                                    procesototal = false;

                                }
                                else
                                {

                                    Console.WriteLine("Entrada no válida. Por favor, ingrese S o N.");
                                }
                            } while (sn != "s" && sn != "n");
                            while (tarjetaexpirada)
                            {
                                int op = 0;
                                do
                                {
                                    Console.WriteLine("Su pago sera con tarjeta de crédito, debito o efectivo?");
                                    Console.WriteLine("Tarjeta de crédito = 1");
                                    Console.WriteLine("Efectivo = 2");
                                    valPago = int.TryParse(Console.ReadLine(), out op);

                                    if (!valPago)
                                    {
                                        Console.WriteLine("Error, ingrese un dato valido");
                                    }
                                    else
                                    {
                                        valPago = false;
                                        break;
                                    }

                                } while (!valPago);

                                switch (op)
                                {
                                    case 1:
                                        while (valTitular)
                                        {
                                            Console.WriteLine("Ingrese titular de la tarjeta:");
                                            titular = Console.ReadLine();

                                            if (int.TryParse(titular, out valor))
                                            {
                                                Console.WriteLine("Error, ingrese el titular de nuevo");
                                            }
                                            else
                                            {
                                                valTitular = false;
                                            }
                                        }
                                        do
                                        {
                                            Console.WriteLine("Ingrese número de tarjeta:");
                                            valNumtar = int.TryParse(Console.ReadLine(), out numtarjeta);

                                            if (!valNumtar)
                                            {
                                                Console.WriteLine("Error, ingrese un número valido");
                                            }
                                            else
                                            {
                                                valNumtar = false;
                                                break;
                                            }

                                        } while (!valNumtar);
                                        do
                                        {
                                            Console.WriteLine("Ingrese año de expiración: ");
                                            valAñotar = int.TryParse(Console.ReadLine(), out añoTarjeta);

                                            if (!valAñotar)
                                            {
                                                Console.WriteLine("Entrada no valida, ingrese un año valido");
                                            }
                                            else
                                            {
                                                valAñotar = false;
                                                break;
                                            }

                                        } while (!valAñotar);
                                        do
                                        {
                                            Console.WriteLine("Ingrese mes de expiración: ");
                                            valMestar = int.TryParse(Console.ReadLine(), out mesTarjeta);

                                            if (!valMestar)
                                            {

                                                Console.WriteLine("Entrada no valida, ingrese un mes valido");
                                            }
                                            else
                                            {
                                                valMestar = false;
                                                break;
                                            }

                                        } while (!valMestar);

                                        DateTime fExpiracion = new DateTime(añoTarjeta, mesTarjeta, 1).AddMonths(1).AddDays(-1);

                                        if (fExpiracion < fActual)
                                        {
                                            Console.WriteLine("Lo sentimos, su tarjeta está expirada.");

                                            Console.WriteLine("Presion enter para reiniciar el pago");
                                            Console.ReadKey();
                                            tarjetaexpirada = true;
                                            break;
                                        }
                                        do
                                        {
                                            Console.WriteLine("Ingresse la cantidad a apostar");
                                            valCant = double.TryParse(Console.ReadLine(), out cantidadapostar);

                                            if (!valCant)
                                            {
                                                Console.WriteLine("Entrada no valida, ingrese una cantidad valida");
                                            }
                                            else
                                            {
                                                valCant = false;
                                                break;
                                            }

                                        } while (!valCant);
                                        do
                                        {
                                            Console.WriteLine("¿ESTA 100% SEGURO? s = si, n = no");
                                            sn3 = Console.ReadLine().ToLower();

                                            if (sn3 == "s")
                                            {
                                                seguir = false;
                                                jugarotravez = true;
                                                juego = false;
                                                tarjetaexpirada = false;
                                            }
                                            else if (sn3 == "n")
                                            {
                                                seguir = false;
                                                procesototal = false;
                                                imprimird = false;
                                                juego = false;

                                            }
                                            else
                                            {

                                                Console.WriteLine("Entrada no válida. Por favor, ingrese S o N.");
                                            }
                                        } while (sn3 != "s" && sn3 != "n");
                                        break;
                                    case 2:
                                        do
                                        {
                                            Console.WriteLine("Ingresse la cantidad a apostar");
                                            valCant = double.TryParse(Console.ReadLine(), out cantidadapostar);

                                            if (!valCant)
                                            {
                                                Console.WriteLine("Entrada no valida, ingrese una cantidad valida");
                                            }
                                            else
                                            {
                                                valCant = false;
                                                break;
                                            }

                                        } while (!valCant);
                                        seguir = false;
                                        do
                                        {
                                            Console.WriteLine("¿ESTA 100% SEGURO? s = si, n = no");
                                            sn3 = Console.ReadLine().ToLower();

                                            if (sn3 == "s")
                                            {
                                                seguir = false;
                                                jugarotravez = true;
                                                juego = false;
                                                tarjetaexpirada = false;
                                            }
                                            else if (sn3 == "n")
                                            {
                                                seguir = false;
                                                procesototal = false;
                                                imprimird = false;
                                                juego = false;

                                            }
                                            else
                                            {

                                                Console.WriteLine("Entrada no válida. Por favor, ingrese S o N.");
                                            }
                                        } while (sn3 != "s" && sn3 != "n");
                                        tarjetaexpirada = false;
                                        break;
                                    default:
                                        Console.WriteLine("Entrada no valida porfavor ingrese una de las opciones disponibles, presione para reintentar");
                                        Console.ReadKey();
                                        tarjetaexpirada = true;
                                        break;
                                }
                            }
                        }
                    }
                    while (jugarotravez)
                    {
                        cantidadapostar = cantidadapostar;
                        Random r1 = new Random();
                        Random r2 = new Random();
                        Random r3 = new Random();
                        Random r4 = new Random();

                        int s1 = r1.Next(0, 10);
                        int s2 = r2.Next(0, 10);
                        int s3 = r3.Next(0, 10);
                        int s4 = r4.Next(0, 10);
                        Console.OutputEncoding = System.Text.Encoding.UTF8;
                        double[] juegogana = new double[4];
                        Console.WriteLine();
                        /*Console.Write(slots[s1, 0] + " " + slots[s2, 1] + " " + slots[s3, 2] + " " + slots[s4, 3]);*/
                        Simbolos figuras = new Simbolos();
                        Console.Clear();
                        Console.WriteLine("Su juego: ");
                        juegogana[0] = slots[s1, 0];
                        juegogana[1] = slots[s2, 1];
                        juegogana[2] = slots[s3, 2];
                        juegogana[3] = slots[s4, 3];
                        string[] slotsfigura = figuras.Convertirasimbolo(juegogana);
                        Console.Write(slotsfigura[0] + " " + slotsfigura[1] + " " + slotsfigura[2] + " " + slotsfigura[3]);
                        Ganancias mijuego = new Ganancias();
                        ganancias = mijuego.GananciasApuesta(juegogana, cantidadapostar);
                        Console.WriteLine();
                        if (ganancias == 0)
                        {
                            Console.WriteLine("Perdio toda su apuesta:");
                        }
                        else
                        {
                            Console.WriteLine("Sus ganancias: " + ganancias);
                        }
                        Console.WriteLine("¿Desea seguir apostando con sus ganancias?");
                        do
                        {
                            Console.WriteLine("¿Desea apostar? s = si, n = no");
                            sn = Console.ReadLine().ToLower();

                            if (sn == "s")
                            {
                                if (ganancias == 0)
                                {
                                    Console.WriteLine("Usted perdio todo. Para volver a jugar deposite una nueva cantiadad a apostar");
                                    do
                                    {
                                        Console.WriteLine("Ingresse la cantidad a apostar");
                                        valCant = double.TryParse(Console.ReadLine(), out cantidadapostar);

                                        if (!valCant)
                                        {
                                            Console.WriteLine("Entrada no valida, ingrese una cantidad valida");
                                        }
                                        else
                                        {
                                            valCant = false;
                                            break;
                                        }

                                    } while (!valCant);
                                    jugarotravez = true;
                                }
                                else
                                {
                                    jugarotravez = true;
                                    cantidadapostar = ganancias;
                                }
                            }
                            else if (sn == "n")
                            {
                                jugarotravez = false;


                            }
                            else
                            {

                                Console.WriteLine("Entrada no válida. Por favor, ingrese S o N.");
                            }
                        } while (sn != "s" && sn != "n");

                    }
                    Console.WriteLine("Presione enter para obtener sus resultados:");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Nombre: " + nombre);
                    Console.WriteLine("No. de identificación: " + noID);
                    Console.WriteLine("Nacionalidad: " + nacionalidad);
                    Console.WriteLine("Edad:" + edadfinal);
                    ganancias = ganancias * .60;
                    Console.WriteLine("Se aplicó un impuesto del 40% por lo que su ganancia es del: " + ganancias);
                    Console.ReadKey();
                }
            }
        }
    }
}