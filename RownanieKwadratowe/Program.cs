using System;

namespace RownanieKwadratowe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Obliczanie ilości pierwiastków równania kwadratowego

            Console.WriteLine("Podaj a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj c: ");
            double c = double.Parse(Console.ReadLine());

            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                Console.WriteLine("2 pierwiastki");
            }
            else if (delta == 0)
            {
                Console.WriteLine("1 pierwiastek");
            }
            else
            {
                Console.WriteLine("0 pierwiastków");
            }
            Console.ReadKey();
        }
    }
}
