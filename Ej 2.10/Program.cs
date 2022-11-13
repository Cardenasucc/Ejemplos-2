//ejemplos 2
using System;
namespace ejemplo2_10
{
    public class ejemplo2_10
    {
        public static void Main()
        {
            double Tmetros, Pulgadas, pago = 0;
            Console.WriteLine("Digite las medidas en metros: ");
            Tmetros = int.Parse(Console.ReadLine());
            Pulgadas = Tmetros * 0.0254;
            Console.WriteLine("Las medidas de la tela en pulgadas es de: " + Pulgadas);
        }
    }
}
