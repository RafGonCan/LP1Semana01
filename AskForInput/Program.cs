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

        }
    }
}
