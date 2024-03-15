using System;

namespace BetterDecorator
{
    class Program
    {
        /// <summary>
        /// Adiciona um charactere no começo e no fim da string o número de vezes indicado
        /// </summary>
        /// <param name="s"></param>
        /// <param name="dec"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        private static string Decor(string s, char dec, int n)
        {
            return $"{"dec"*n} {s} {"dec"*n}";
        }
        /// <summary>
        /// Entrega os parametros necessários para o Decor funcionar
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            Console.WriteLine(Decor("Good Morning!", '*', 4));
            Console.WriteLine(Decor("Good Morning!", '.', 2));
        }
    }
}