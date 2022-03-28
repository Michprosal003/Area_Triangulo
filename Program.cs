using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {



            // Calcular Area del Triangulo

            Console.Title = " Area del Triangulo";
            Console.WriteLine("Ingresa la base del triangulo");
            int base_t = int.Parse(Console.ReadLine());


            Console.WriteLine("Ingresa la altura del triangulo");
            int altura = int.Parse(Console.ReadLine());

            double area = (base_t * altura) / 2;

            Console.WriteLine("El area del triangulo es : " + area + "   metros²   ");

            Console.ReadKey();
        }
    }
}
