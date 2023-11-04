namespace Task2
{
    // Class to generate a list of strings according to FizzBuzzMuzzGuzz rules
    public class FizzBuzzMuzzGuzz
    {
        private IConverter _converter;

        // Constructor that takes a converter as a parameter
        public FizzBuzzMuzzGuzz(IConverter converter)
        {
            _converter = converter;
        }

        // Method to generate a list of strings from a list of numbers
        public List<string> Generate(List<int> numbers)
        {
            List<string> result = new List<string>();
            foreach (int number in numbers)
            {
                result.Add(_converter.Convert(number));
            }
            return result;
        }
    }
}
