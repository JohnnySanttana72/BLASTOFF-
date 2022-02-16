using System;

namespace questão3
{
    class Program
    {
        static void Main(string[] args)

        {   Console.WriteLine("Introduza a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduza b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduza c: ");
            int c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                if(a > c) Console.WriteLine(" O maior é " + a);
                else Console.WriteLine(" O maior é " + c);
            }
            else
            {
                if (b > c) Console.WriteLine(" O maior é " + b);
                else Console.WriteLine(" O maior é " + c);
            }
            
        }
    }
}
