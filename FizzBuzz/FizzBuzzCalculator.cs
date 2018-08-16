namespace FizzBuzz
{
    public class FizzBuzzCalculator
    {
        public string PrintNumbers(int iterations)
        {
            var numbers = "";
            for (var i = 1; i <= iterations; i++)
            {
                if (i % 15 == 0)
                {
                    numbers += "FizzBuzz ";
                }              
                else if (i % 3 == 0)
                {
                    numbers += "Fizz ";
                }
                else if (i % 5 == 0)
                {
                    numbers += "Buzz ";
                }              
                else
                {
                    numbers += $"{i} ";
                }
            }

            return numbers.Trim(' ');
        }
    }
}