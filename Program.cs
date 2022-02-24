using System;
namespace solution
{
    class assignment
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "Poly ilaro ";

            Console.Write("Enter second Integer: ");
            int i_int = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second double: ");
            double d_double = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second string: ");
            string s_str = Console.ReadLine();

            Console.WriteLine(i + i_int);
            Console.WriteLine(d + d_double);
            Console.WriteLine(s + s_str);

        }

    }
}



