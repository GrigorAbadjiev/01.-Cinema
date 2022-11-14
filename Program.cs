using System;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            int totalSeats = rows * columns;
            double ticketPrice = 0;

            switch (type)
            {
                case "Premiere": ticketPrice = 12; break;
                case "Normal": ticketPrice = 7.50; break;
                case "Discount": ticketPrice = 5.00; break;
                
                   
            }

            double sum = totalSeats * ticketPrice;
            Console.WriteLine($"{sum:f2} leva");
        }   
    }
}
