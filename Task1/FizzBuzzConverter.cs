namespace Task1
{
    public interface IFizzBuzzConverter
    {
        string Convert(int number);
    }

    public class FizzBuzzConverter : IFizzBuzzConverter
    {
        public string Convert(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
                return "fizz-buzz";
            else if (number % 3 == 0)
                return "fizz";
            else if (number % 5 == 0)
                return "buzz";
            else
                return number.ToString();
        }
    }
}

