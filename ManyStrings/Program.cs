using System;
using System.Text;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Declare and assign values to string variables
            string tab = "Um tab\t para dar mais espaço";
            string enter = "Um enter para uma linha em branco \n";
            string unicode = "Um simbolo para animar este texto \u2734";
            //\u1F92A unicode doesn't work?
            //Show value of the string variables
            Console.WriteLine(tab);
            Console.WriteLine(enter);
            Console.WriteLine(unicode);
        }
    }
}
