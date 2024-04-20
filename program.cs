using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program1
    {
        static void Main(string[] args)
        {
            int[] vet = new int[20];
            Random n = new Random();

            for (int i = 0; i < vet.Length; i++)
            {
                int x = n.Next(1, 10);
                vet[i] = x;
            }

            Console.WriteLine("Digite o numero do vetor que deseja pesquisar");
            int numvet = int.Parse(Console.ReadLine());
            Console.WriteLine("Seu numero na posição " + numvet + "  Será : " + vet[numvet]);
            Console.WriteLine("VETOR IMPRESSO ");
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(" " + vet[i]);
            }
            Console.ReadKey();
        }
    }
}        
    
