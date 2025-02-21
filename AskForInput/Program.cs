using System;
using System.Runtime.InteropServices;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insira um número inteiro:");
            string input_int = Console.ReadLine();
            int conv_int = Convert.ToInt32(input_int);

            Console.WriteLine("Insira um número real:");
            string input_real = Console.ReadLine();
            double conv_real = Convert.ToSingle(input_real);

            Console.WriteLine($"A soma entre {conv_int} e {conv_real} é {conv_int + conv_real}.");
        }
    }
}
