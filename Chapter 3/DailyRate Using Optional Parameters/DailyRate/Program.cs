using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyRate
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        void run()
        {
            double fee = CalculateFee(650.0, 5);
            Console.WriteLine($"Fee is {fee}");
        }
        private double CalculateFee(double dailyRate = 500.0, int noOfDays = 1)
        {
            Console.WriteLine("Calculate fee using two optional params");
            return dailyRate * noOfDays;
        }

        private double CalculateFee(double dailyRate = 500.0)
        {
            Console.WriteLine("Calc fee is using one optional param");
            int defaultNoOfDays = 1;
            return dailyRate * defaultNoOfDays;
        }

        private double CalculateFee()
        {
            Console.WriteLine("Calc fee using hardcoded values");
            double defaultDailyRate = 500.0;
            int defaultNoOfDays = 1;
            return defaultDailyRate * defaultNoOfDays;
        }
    }
}
