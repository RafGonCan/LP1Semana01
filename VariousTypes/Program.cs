using System;

namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
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
        }
    }
}