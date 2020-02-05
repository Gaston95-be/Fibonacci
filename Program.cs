using System;
using System.Collections.Generic;


namespace ConsoleApp3
{
    public class Cal
    {
        public Cal()
        { }
            public int calProducto(int numero1, int numero2)
            {
                int result = 0;

                for (int i = 1; i <= numero2; i++)
                {
                    result = result + numero1;
                }
                return result;
            }
        public List<int> Multiplos(int a)
        {

            List<int> Multiplos = new List<int>();

            Multiplos.Add(0);

            for (int i = 0; i <= a; i++)
            {
                if ((i % 3) == 0 & (i % 5) != 0)
                {
                    Multiplos.Add(i);
                }
            }
            return Multiplos;
        }


    }
}


namespace ConsoleApp3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 300;   // remplaza una entrada de usuario                                                                                                                      
            Cal cal = new Cal();
            Console.WriteLine("Estos son los multiplos de 3 pero no de 5 que se encuentran en los primeros " + a + " numeros =");
            foreach (int numero in cal.Multiplos(a))
            {
                Console.WriteLine(numero);
            }


        }
    }
}
