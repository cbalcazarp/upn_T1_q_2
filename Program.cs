using System;

namespace upn_T2_q_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Double baseMenor, baseMayor, altura, areaTrapecio;
            Console.WriteLine("Bienvenido al programa de cálculo de área de un trapecio");
            Console.Write("Ingrese base menor: ");
            baseMenor = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese base mayor: ");
            baseMayor = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese altura: ");
            altura = Convert.ToDouble(Console.ReadLine());
            areaTrapecio = (baseMenor + baseMayor)*altura/2;
            Console.WriteLine("El area del trapecio es: " + Convert.ToString(areaTrapecio));


        }
    }
}
