using NUnit.Framework;

namespace Task1
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void TestFizzBuzz()
        {
            FizzBuzz fizzBuzz = new FizzBuzz(new FizzBuzzConverter());
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            List<string> expected = new List<string> { "1", "2", "fizz", "4", "buzz", "fizz", "7", "8", "fizz", "buzz", "11", "fizz", "13", "14", "fizz-buzz" };
            Assert.AreEqual(expected, fizzBuzz.Generate(numbers));
        }
    }
}
