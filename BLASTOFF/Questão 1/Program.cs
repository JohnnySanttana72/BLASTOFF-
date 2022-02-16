using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            double  i, j, k, x, y;
            double media;

            Console.WriteLine("digite a idade 1");
            i = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite a idade 2");
            j = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite a idade 3");
            k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite a idade 4");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite a idade 5");
            y = Convert.ToDouble(Console.ReadLine());

            media = (i+j+k+x+y)/5;
            Console.WriteLine("Media:");
            Console.WriteLine(media);

            Console.ReadKey();

        }
    }
}
