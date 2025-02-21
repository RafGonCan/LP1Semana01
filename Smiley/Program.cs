using System;
using System.Globalization;
using System.Text;

namespace Smiley
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //User input
            Console.WriteLine("Insere um número interio em formato hexadecimal:");
            string hexadecimal = Console.ReadLine();
            //convert string ot hexa
            int conv_hexa = Int32.Parse(hexadecimal, NumberStyles.HexNumber);
            char emoji = Convert.ToChar(conv_hexa);

            Console.WriteLine(conv_hexa);

            //1F39C
            //263A
            //1F552
        }
    }
}
