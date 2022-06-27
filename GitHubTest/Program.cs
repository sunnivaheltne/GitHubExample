namespace GitHubTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new(1, 2);
            Fraction fraction2 = new(1, 3);

            Fraction sum = fraction1.Add(fraction2);
            Console.WriteLine($"{fraction1} + {fraction2} = {sum}");


            Fraction sum2 = fraction1.Subtract(fraction2);
            Console.WriteLine($"{fraction1} - {fraction2} = {sum2}");


            Fraction sum3 = fraction1.Multiply(fraction2);
            Console.WriteLine($"{fraction1} * {fraction2} = {sum3}");


            Fraction sum4 = fraction1.Division(fraction2);
            Console.WriteLine($"{fraction1} / {fraction2} = {sum4}");

            bool sum5 = fraction1.Equals(fraction2);
            Console.WriteLine($"Is {fraction1} equal to {fraction2}? {sum5}.");
        }
    }
}
