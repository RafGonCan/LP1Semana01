using System;
using System.Text;

namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;

            int num = 5000;
            uint num_uint = 5000U;
            int num_bin = 0b1001110001000;
            uint num_bin_uint = 0b1001110001000U;
            int num_hex = 0x1388;
            uint num_hex_uint = 0x1388U;
            Console.WriteLine(num);
            Console.WriteLine(num_uint);
            Console.WriteLine(num_bin);
            Console.WriteLine(num_bin_uint);
            Console.WriteLine(num_hex);
            Console.WriteLine(num_hex_uint);

            char danger = '\u26A0';
            char down = '\u2B07';
            char radioactive = '\u2622';
            char biohazard = '\u2623';
            Console.WriteLine(danger);
            Console.WriteLine(down);
            Console.WriteLine(radioactive);
            Console.WriteLine(biohazard);

            double real = 5.1515;
            float flt_real = 5.1515f;
            decimal dec_real = 5.1515m;
            Console.WriteLine(real);
            Console.WriteLine(flt_real);
            Console.WriteLine(dec_real);
        }
    }
}