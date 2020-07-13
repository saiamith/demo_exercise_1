using System;
namespace Demo_exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int celsius, farenhiet;
            Console.WriteLine("Enter the Temperature in Celsius : ");
            celsius = Convert.ToInt32(Console.ReadLine());
            farenhiet = (celsius * 9) / 5 + 32;
            Console.WriteLine("Temperature in frenhiet : " + farenhiet);
            Console.ReadLine();

        }
    }
}
