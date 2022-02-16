using System;

namespace GrausCelsiusParaFahrenheit
{
    class GrausCelsiusParaFahrenheit
    {
        static void Main(string[] args)
        {
            double graus_celsius, graus_fahrenheit;
            Console.Write("Digite o valor do graus celsius: ");
            graus_celsius = double.Parse(Console.ReadLine());
            graus_fahrenheit=1.8*graus_celsius+32;
            Console.WriteLine("O valor do graus fahrenheit: " + graus_fahrenheit);
            Console.WriteLine();
            Console.Write("Pressione qualquer chave para terminar . . . ");
            Console.ReadKey();
        }
    }
}
