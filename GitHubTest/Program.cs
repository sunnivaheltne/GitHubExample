namespace GitHubTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction = new(1, 2);
            Fraction fraction2 = new(1, 3);

            Fraction sum = fraction.Add(fraction2);

            Console.WriteLine($"{fraction} + {fraction2} = {sum}");
        }
    }
}
