using System;

namespace InterestCalculator
{
    public static class  MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Amount");
            var amoutString = Console.ReadLine();

            var rate = 0m;
            if(decimal.TryParse(amoutString,out  var amount))
            {
                rate = GetInterestRate(amount);
            }
            var interestAmount = ConvertRateToMoney(amount, rate);

            Console.WriteLine($"Amount: £{amount}");
            Console.WriteLine($"Interest Rate: {rate}%");
            Console.WriteLine("Interest Amount: £"+decimal.Round(interestAmount, 2, MidpointRounding.AwayFromZero));
            Console.ReadLine();
        }

        public static decimal ConvertRateToMoney(decimal amount, decimal rate)
        {
            var multipiler = rate / 100;
            return multipiler * amount;
        }

        public static decimal GetInterestRate(decimal amount)
        {
            var rate = 0m;
            if (amount < 1000)
            {
                rate = 1;
            }
            else if (amount < 5000)
            {
                rate = 1.5m;
            }
            else if (amount < 10000)
            {
                rate = 2;
            }
            else if (amount < 50000)
            {
                rate = 2.5m;
            }
            else if (amount >= 50000)
            {
                rate = 3;
            }
            return rate;
        }
    }
}
