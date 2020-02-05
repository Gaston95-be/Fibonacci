using System;

    namespace ConsoleApp2
    {
        public class Cal
        {
            public Cal()
            {

            }

            public int calProducto(int numero1, int numero2)
            {

                int result = 0;

                for (int i = 1; i <= numero2; i++)
                {
                    result = result + numero1;
                }
                return result;

            }
        }
    }


namespace ConsoleApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cal cal = new Cal();
            int a = 30;      //Si se desea interactucar con un usuario usamos un "readline" para tomar los numeros, almacenar y recien ahi hacer la suma que lleve al resultado. 
            int s = 4;
            Console.WriteLine("Multiplicar " + a + " x " + s + " = " + cal.calProducto(a, s));

        }
    }
}