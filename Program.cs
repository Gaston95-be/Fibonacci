using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, i, cantidad;
            string linea;
            Console.Write("Ingresar cuantos numeros de la serie desea ver = ");
            linea = Console.ReadLine();
            cantidad = int.Parse(linea);
            a = 0;
            b = 1;
            for (i = 0; i < cantidad; i++)
            {
                c = a;
                a = b;
                b = c + a;
                Console.WriteLine(a);
            }
        }
    }
}