using NUnit.Framework;

namespace Task2
{
    [TestFixture]
    public class FizzBuzzMuzzGuzzTests
    {
        [Test]
        public void TestFizzBuzzMuzzGuzz()
        {
            FizzBuzzMuzzGuzz fizzBuzzMuzzGuzz = new FizzBuzzMuzzGuzz(new FizzBuzzMuzzGuzzConverter());
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 };
            List<string> expected = new List<string> { "1", "2", "fizz", "muzz", "buzz", "fizz",
                "guzz", "muzz", "fizz", "buzz", "11", "fizz-muzz", "13", "guzz", "fizz-buzz",
                "fizz-buzz-muzz", "fizz-buzz-guzz", "fizz-buzz-muzz-guzz" };
            Assert.AreEqual(expected, fizzBuzzMuzzGuzz.Generate(numbers));
        }
    }
}
