using System;

namespace questao13
{
    class Program
    {
        static void Main(string[] args)
        {
          int[,] matriz = new int[2, 2];
        int j;

          for (int i = 0; i<=2 ; i++){
              for( j = 0; j<=2; j++){
                  Console.WriteLine("digite o valor");
                  matriz[i,j] = int.Parse(Console.ReadLine());
              }
            Console.WriteLine(matriz[i,j]);
          }

        



        }
    }
}
