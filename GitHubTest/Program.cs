namespace GitHubTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new(1, 2);
            Fraction fraction2 = new(1, 3);

            Fraction sumMultiply = fraction1 * fraction2;
            Console.WriteLine($"Operator overload: The sum of {fraction1} * {fraction2} = {sumMultiply}\n");

            bool sumEquals = fraction1 == fraction2;
            Console.WriteLine($"Operator overload: Is {fraction1} equal to {fraction2}? {sumEquals}\n");

            #region Fraction methods
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

            bool sum6 = fraction1.GreaterThan(fraction2);
            Console.WriteLine($"Is {fraction1} greater than {fraction2}? {sum6}.");
            #endregion
        }
        
    }
}
