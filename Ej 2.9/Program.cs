//ejemplos 2
using System;
namespace ejemplo2_9
{
    public class ejemplo2_9
    {
        public static void Main()
        {
            int Horast, Horasp, pago = 0;
            Console.WriteLine("Digite el número de horas trabajadas en la semana: ");
            Horast = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el pago por hora: ");
            Horasp = int.Parse(Console.ReadLine());
            pago = Horast * Horasp;
            Console.WriteLine("su pagado es: " + pago);
        }
    }
}
