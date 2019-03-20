using NUnit.Framework;
using System;
using InterestCalculator;
namespace InterestCalculatorTests
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void Test_Amount_999_99_InterestRate_1_ok()
        { 
            var amount = 999.99m;
            var expectedRate = 1m;
            var expectedAmount = 10;

            var rate = MainClass.GetInterestRate(amount);
            var interestAmount = MainClass.ConvertRateToMoney(amount, rate);

            Assert.AreEqual(expectedRate, rate);
            Assert.AreEqual(expectedAmount, decimal.Round(interestAmount, 2, MidpointRounding.AwayFromZero));
        }

        [Test()]
        public void Test_Amount_1000_InterestRate_1_5_ok()
        {
            var amount = 1000.00m;
            var expectedRate = 1.5m;
            var expectedAmount = 15.00;

            var rate = MainClass.GetInterestRate(amount);
            var interestAmount = MainClass.ConvertRateToMoney(amount, rate);

            Assert.AreEqual(expectedRate, rate);
            Assert.AreEqual(expectedAmount, decimal.Round(interestAmount, 2, MidpointRounding.AwayFromZero));
        }

        [Test()]
        public void Test_Amount_1001_InterestRate_1_5_ok()
        {
            var amount = 1001.00m;
            var expectedRate = 1.5m;
            var expectedAmount = 15.02;

            var rate = MainClass.GetInterestRate(amount);
            var interestAmount = MainClass.ConvertRateToMoney(amount, rate);

            Assert.AreEqual(expectedRate, rate);
            Assert.AreEqual(expectedAmount, decimal.Round(interestAmount, 2, MidpointRounding.AwayFromZero));
        }

        [Test()]
        public void Test_Amount_4999_99_InterestRate_1_5_ok()
        {
            var amount = 4999.99m;
            var expectedRate = 1.5m;
            var expectedAmount = 75;

            var rate = MainClass.GetInterestRate(amount);
            var interestAmount = MainClass.ConvertRateToMoney(amount, rate);

            Assert.AreEqual(expectedRate, rate);
            Assert.AreEqual(expectedAmount, decimal.Round(interestAmount, 2, MidpointRounding.AwayFromZero));
        }

        [Test()]
        public void Test_Amount_5000_InterestRate_2_ok()
        {
            var amount = 5000m;
            var expectedRate = 2m;
            var expectedAmount = 100;

            var rate = MainClass.GetInterestRate(amount);
            var interestAmount = MainClass.ConvertRateToMoney(amount, rate);

            Assert.AreEqual(expectedRate, rate);
            Assert.AreEqual(expectedAmount, decimal.Round(interestAmount, 2, MidpointRounding.AwayFromZero));
        }

        [Test()]
        public void Test_Amount_5000_01_InterestRate_2_ok()
        {
            var amount = 5000.01m;
            var expectedRate = 2m;
            var expectedAmount = 100;

            var rate = MainClass.GetInterestRate(amount);
            var interestAmount = MainClass.ConvertRateToMoney(amount, rate);

            Assert.AreEqual(expectedRate, rate);
            Assert.AreEqual(expectedAmount, decimal.Round(interestAmount, 2, MidpointRounding.AwayFromZero));
        }

        [Test()]
        public void Test_Amount_9999_99_InterestRate_2_ok()
        {
            var amount = 9999.99m;
            var expectedRate = 2m;
            var expectedAmount = 200;

            var rate = MainClass.GetInterestRate(amount);
            var interestAmount = MainClass.ConvertRateToMoney(amount, rate);

            Assert.AreEqual(expectedRate, rate);
            Assert.AreEqual(expectedAmount, decimal.Round(interestAmount, 2, MidpointRounding.AwayFromZero));
        }

        [Test()]
        public void Test_Amount_10000_InterestRate_2_5_ok()
        {
            var amount = 10000m;
            var expectedRate = 2.5m;
            var expectedAmount = 250;

            var rate = MainClass.GetInterestRate(amount);
            var interestAmount = MainClass.ConvertRateToMoney(amount, rate);

            Assert.AreEqual(expectedRate, rate);
            Assert.AreEqual(expectedAmount, decimal.Round(interestAmount, 2, MidpointRounding.AwayFromZero));
        }


        [Test()]
        public void Test_Amount_10001_InterestRate_2_5_ok()
        {
            var amount = 10001m;
            var expectedRate = 2.5m;
            var expectedAmount = 250.03;

            var rate = MainClass.GetInterestRate(amount);
            var interestAmount = MainClass.ConvertRateToMoney(amount, rate);

            Assert.AreEqual(expectedRate, rate);
            Assert.AreEqual(expectedAmount, decimal.Round(interestAmount, 2, MidpointRounding.AwayFromZero));
        }

        [Test()]
        public void Test_Amount_49999_99_InterestRate_2_5_ok()
        {
            var amount = 49999.99m;
            var expectedRate = 2.5m;
            var expectedAmount = 1250;

            var rate = MainClass.GetInterestRate(amount);
            var interestAmount = MainClass.ConvertRateToMoney(amount, rate);

            Assert.AreEqual(expectedRate, rate);
            Assert.AreEqual(expectedAmount, decimal.Round(interestAmount, 2, MidpointRounding.AwayFromZero));
        }

        [Test()]
        public void Test_Amount_50000_InterestRate_3_ok()
        {
            var amount = 50000m;
            var expectedRate =3m;
            var expectedAmount = 1500;

            var rate = MainClass.GetInterestRate(amount);
            var interestAmount = MainClass.ConvertRateToMoney(amount, rate);

            Assert.AreEqual(expectedRate, rate);
            Assert.AreEqual(expectedAmount, decimal.Round(interestAmount, 2, MidpointRounding.AwayFromZero));
        }

        [Test()]
        public void Test_Amount_50001_InterestRate_3_ok()
        {
            var amount = 50001m;
            var expectedRate = 3m;
            var expectedAmount = 1500.03;

            var rate = MainClass.GetInterestRate(amount);
            var interestAmount = MainClass.ConvertRateToMoney(amount, rate);

            Assert.AreEqual(expectedRate, rate);
            Assert.AreEqual(expectedAmount, decimal.Round(interestAmount, 2, MidpointRounding.AwayFromZero));
        }
    }
}
