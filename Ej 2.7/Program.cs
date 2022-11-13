//ejemplos 2
using System;
namespace ejemplo2_7
{
    public class leche
    {
        public static void Main()
        {
            double Lpg = 3.785;
            double Litros, Pgalon, Vv, Cg = 0;

            Console.WriteLine("Digite la cantidad de litros vendidos");
            Litros = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el precio del galon de leche");
            Pgalon = int.Parse(Console.ReadLine());

            Cg = Litros / Lpg;
            Vv = Cg * Pgalon;
            Console.WriteLine("El valor de la venta es: " + Vv);
        }
    }
}