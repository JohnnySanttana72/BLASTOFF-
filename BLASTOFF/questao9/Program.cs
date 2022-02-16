using System;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Recebe as Variaveis
            int formula, contador, numero;

           
            Console.Write("Digite o Numero para Obter a Taboada : ");
            numero = Int32.Parse(Console.ReadLine());

            //para
            for (contador = 1; contador <= 10; ++contador)
            {
                formula =  numero * contador;
                Console.WriteLine(numero + " X " + contador + " = " + formula);
                
            }

            Console.ReadKey();
        }

    }
}