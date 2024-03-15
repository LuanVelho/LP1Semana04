using System;
using System.Text;

namespace BetterDecorator
{
    /// <summary>
    /// Guarda todo o corpo do código
    /// </summary>
    class Program
    {
        /// <summary>
        /// Adiciona um charactere no começo e no fim da string o número de vezes indicado
        /// </summary>
        /// <param name="s"></param>
        /// <param name="dec"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        private static string Decor(string s, char dec, int count)
        {
            return $"{"dec"*count} {s} {"dec"*count}";
        }
        /// <summary>
        /// Entrega os parametros necessários para o Decor funcionar
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            if args;
                Console.WriteLine(Decor("Good Morning!", '*', 4));
                Console.WriteLine(Decor("Good Morning!", '.', 2));
            else:
                Decor();
        }
        /// <summary>
        /// Caso o Usuário não introduza nenhum parametro, esse método será ativado
        /// </summary>
        /// <returns></returns>
        private static string Decor();
        {
            Console.WriteLine(Decor("User did not specify args!",'=',3));
        }
}