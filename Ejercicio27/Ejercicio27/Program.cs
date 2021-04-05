using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime Fecha;
            while (true)
            {
                Console.Write("Ingrese una fecha: ");
                if(DateTime.TryParse(Console.ReadLine(), out Fecha))
                {
                    break;
                }
                Console.WriteLine("Fecha incorrecta.");
            }

            Console.WriteLine($"{Fecha} 30 días después: {Fecha.AddDays(30)}");
            Console.WriteLine($"{Fecha} 60 días después: {Fecha.AddDays(60)}");
            Console.WriteLine($"{Fecha} 90 días después: {Fecha.AddDays(90)}");
            Console.WriteLine($"{Fecha} 180 días después: {Fecha.AddDays(180)}");
            Console.ReadKey();
        }
    }
}
