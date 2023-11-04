namespace Task1
{
    public class FizzBuzz
    {
        private IFizzBuzzConverter _converter;

        public FizzBuzz(IFizzBuzzConverter converter)
        {
            _converter = converter;
        }

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
