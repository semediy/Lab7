using System;

class Program
{
    static void Main()
    {
        Func<double, double> discountCalculator = null;

        discountCalculator += price => price * 0.95;
        discountCalculator += price => price * 0.90;
        discountCalculator += price => price - 100;

        double price = 1000;
        double finalPrice = price;

        foreach (Func<double, double> func in discountCalculator.GetInvocationList())
        {
            finalPrice = func(finalPrice);
        }

        Console.WriteLine(finalPrice);
    }
}