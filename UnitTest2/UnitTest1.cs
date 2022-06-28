using GitHubTest;

namespace UnitTest2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestEquals()
        {
            Fraction fraction1 = new(1, 2);
            Fraction fraction2 = new(1, 3);

            bool equalFractions = false;
            if (fraction1.Equals(fraction2))
            {
                equalFractions = true;
            }

            Assert.IsFalse(equalFractions);
        }

        [Test]
        public void TestAdd()
        {

            Fraction fraction1 = new(1, 2);
            Fraction fraction2 = new(1, 3);
            Fraction actual = fraction1.Add(fraction2);     // tester Add-metoden/funksjonaliteten
            
            Fraction expected = new(5, 6);

            Assert.AreEqual(expected, actual);  // sammenligner forventet svar med faktisk svar
            // Assert.That(actual, Is.EqualTo(expected));  // ny versjon
        }

        [Test]

        public void TestSubtract()
        {
            Fraction fraction1 = new(1, 2);
            Fraction fraction2 = new(1, 3);
            Fraction actual = fraction1.Subtract(fraction2);     // tester Add-metoden/funksjonaliteten

            Fraction expected = new(1, 6);

            Assert.AreEqual(expected, actual);
        }

        public void TestMultiply()
        {
            Fraction fraction1 = new(1, 2);
            Fraction fraction2 = new(1, 3);
            Fraction actual = fraction1.Multiply(fraction2);     // tester Add-metoden/funksjonaliteten

            Fraction expected = new(1, 7);

            Assert.AreEqual(expected, actual);
        }
    }
}

