using System;

namespace inluppg2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt hoppade Elin?");
            double langdElin = double.Parse(Console.ReadLine());
            Console.WriteLine("Hur långt hoppade Alma?");
            double langdAlma = double.Parse(Console.ReadLine());

            Console.WriteLine($"Elin hoppade {langdElin - langdAlma}meter längre än Alma");
        }
    }
}