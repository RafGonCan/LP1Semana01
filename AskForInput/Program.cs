using System;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Show insert integer line for the user
            Console.WriteLine("Insira um número inteiro:");
            //Declare and assign input variable
            string input_int = Console.ReadLine();
            //Convert input into int
            int conv_int = Convert.ToInt32(input_int);

            //Show insert real num line for the user
            Console.WriteLine("Insira um número real:");
            //Declare and assign input variable
            string input_real = Console.ReadLine();
            //Convert input into double
            float conv_real = Convert.ToSingle(input_real);

            //Sentence with the sum of int and double variables 
            Console.WriteLine($"A soma entre {conv_int} e {conv_real} é {conv_int + conv_real}.");
        }
    }
}
