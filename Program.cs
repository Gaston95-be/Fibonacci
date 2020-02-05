using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Double v = 0.1429;
            DateTime fecha1 = new DateTime(2020,1,31);
            DateTime fecha2 = new DateTime(2015,1,31);
            Console.WriteLine(fecha1.ToLongDateString());
            Console.WriteLine(fecha2.ToLongDateString());
            TimeSpan calculo = fecha1 - fecha2;
            int dias = calculo.Days;
            Console.WriteLine(" {0} Es el número de dias de una fecha a la otra", dias);
            //Console.WriteLine("{0} Son las semanas",                                          ver forma simple de convertir dias en semanas.
            Console.Read();

            
        }

    }
}
