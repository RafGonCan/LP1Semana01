using System;
using System.Text;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            //Declare variables
            double xx = 1.23456;
            int ii  = 19;

            //Declare and assign values to string variables
            string tab = "Um tab\t para dar mais espaço";
            string enter = "Um enter para uma linha em branco \n";
            string unicode = "Um simbolo para animar este texto \u2734 \n";
            //\u1F92A unicode doesn't work?

            //Show value of the string variables
            Console.WriteLine(tab);
            Console.WriteLine(enter);
            Console.WriteLine(unicode);

            //Declare and assign values to string variables
            string s_name = "Jakas";
            string emoji = "\u2734";
            string f_name = "Joaquim ";

            //concatenate string values into a sentence
            Console.WriteLine("Olá o meu nome é " + s_name + "!");
            Console.WriteLine("Tenho " + 35 + " anos.");
            Console.WriteLine($"Há várias estrelas no céu {emoji}{emoji}{emoji}");
            Console.WriteLine($"O meu nome completo é {f_name + s_name}");

            //show some ways of formatting variables
            Console.WriteLine($"xx = {xx:f2}");
            Console.WriteLine($"Percentagem de xx = {xx:p1}");
            Console.WriteLine($"Hexadecimal de ii = {ii:x}");
            Console.WriteLine($"Moeda de ii = {ii:c}");
        }
    }
}
