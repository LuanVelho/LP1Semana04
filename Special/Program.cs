using System;
using System.Runtime.InteropServices;

namespace Special
{
    class Program
    {
        private static int GetSpecial(int n)
        {
            int [] Sequencia = [0,1,1,3,5,11,21,43,85,171,341];
            return Sequencia[n];
        }
        static void Main(string[] args)
        {
         Console.Write("Insert n-th number of the special sequence: ");
         resposta = Console.Read();
         GetSpecial(resposta);   
        }
    }
}
