using System;

namespace questao5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduza a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduza b: ");
            int b = int.Parse(Console.ReadLine());

            if ( a % b == 0 || b % a == 0){
                Console.WriteLine("Sao Multiplos");
            }
            else{
                Console.WriteLine("Não sao Multiplos");
            }

        }
    }
}
