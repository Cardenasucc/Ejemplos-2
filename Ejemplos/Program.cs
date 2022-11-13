//ejemplos 2
using System;
namespace ejemplo2_5
{
    public class lotes
    {
        public static void Main()
        {
            double a, b, c;
            double Ar, At, Ato = 0;

            Console.WriteLine("Digite los datos a, b y c ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            Ar = b * c;
            At = ((a - c) * b) / 2;
            Ato = Ar + At;

            Console.WriteLine("El resultado del area es: " + Ato);

        }
    }
}
