using System;

namespace questao6
{
    class Program
    {
        static void Main(string[] args)
        {   int duracao;
            Console.WriteLine("Introduza a hora de inicio: ");
            int inicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduza a hora de termino: ");
            int termino = int.Parse(Console.ReadLine());

            if (inicio>=termino){
                duracao = (24-inicio)+termino;
                Console.WriteLine("duraçao");
                Console.WriteLine(duracao);

            }
            else{
                duracao= termino- inicio;
                Console.WriteLine("duraçao");
                Console.WriteLine(duracao);
            }
        }
    }
}
