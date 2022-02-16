using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace forum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[] {1, 3, 5, 7 ,9} ;
            int[] vetor2 = new int[] { 1, 4, 5, 6, 9 };

            StringBuilder builderUniao = 
                new StringBuilder("União: ");
            StringBuilder builderInterseccao = 
                new StringBuilder("Interseccção: ");

            IEnumerable<int> inter = vetor1.Intersect(vetor2);
            foreach (int numero in inter)
                builderInterseccao.Append(numero).Append(" ");
            

            for (int i = 0; i < vetor1.Length; i++)
                builderUniao.Append(vetor1[i].ToString() + vetor2[i].ToString()).Append(" ");
            
            Console.WriteLine(builderUniao + "\n" + builderInterseccao);
            Console.ReadKey();
        }
    }
}