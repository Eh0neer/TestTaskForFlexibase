namespace Task2
{
    // Interface for number converter
    public interface IConverter
    {
        string Convert(int number);
    }

    public class FizzBuzzMuzzGuzzConverter : IConverter
    {
        // Implementation of Convert method
        public string Convert(int number)
        {
            string result = "";
            // If the number is divisible by 3 and 5 without a remainder, add "fizz-buzz" to the result
            if (number % 3 == 0 && number % 5 == 0)
                result += "fizz-buzz";
            
            else if (number % 3 == 0)
                result += "fizz";
            
            else if (number % 5 == 0)
                result += "buzz";

            
            if (number % 4 == 0 && number % 7 == 0)
                result += "muzz-guzz";
            
            else if (number % 4 == 0)
                result += "muzz";
            
            else if (number % 7 == 0)
                result += "guzz";

            // If no conditions were met, return the number as a string
            if (result == "")
                result = number.ToString();
            return result;
        }
    }
}
