using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
        public class Program
        {
            public static void Main(string[] args)
            {
                List<int> apuesta = new List<int>();
                bool a = true;
                var seed = Environment.TickCount;
                var random = new Random(seed);

                while (a)
                {

                    Console.WriteLine("Ingresar N° al que desea apostar entre el 0 y 36");
                    int numero = int.Parse(Console.ReadLine());

                    if (0 <= numero & numero <= 36)
                    {
                        apuesta.Add(numero);

                    }
                    else
                    {
                        a = false;
                    }
                }


                int variable = random.Next(0, 36);

                Console.WriteLine("El N° ganador es = " + variable);
                int ganador = 0;
                int perdedor = 0;
                foreach (int apuest in apuesta)
                {
                    if (apuest == variable)
                    {
                        ganador += 1;
                    }
                    else
                    {
                        perdedor += 1;
                    }
                }
                Console.WriteLine("N° de ganadores = " + ganador);
                Console.WriteLine("N° de perdedores = " + perdedor);
            }
        }
    }