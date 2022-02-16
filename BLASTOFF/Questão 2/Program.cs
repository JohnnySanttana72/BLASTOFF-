using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            double distancia,consumo, consumoMedio;

            Console.WriteLine("digite a distancia");
            distancia = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("digite o consumo");
            consumo = Convert.ToDouble(Console.ReadLine());

            consumoMedio = distancia/consumo;

            Console.WriteLine("Consumo Medio: {0:N}",consumoMedio);

            
        }
    }
}
