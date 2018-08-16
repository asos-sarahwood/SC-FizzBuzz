namespace FizzBuzzTests
{
    using FizzBuzz;
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    public class FizzBuzzAppShould
    {
        // prints numbers from 1 to 100
        // but for multiples of 3 it prints 'Fizz'
        // multiples 5 'Buzz'
        // for both print 'FizzBuzz'

        [TestCase(1,"1")]
        [TestCase(2,"1 2")]
        [TestCase(3,"1 2 Fizz")]
        [TestCase(5,"1 2 Fizz 4 Buzz")]
        [TestCase(6, "1 2 Fizz 4 Buzz Fizz")]
        [TestCase(9, "1 2 Fizz 4 Buzz Fizz 7 8 Fizz")]
        [TestCase(10, "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz")]
        [TestCase(15, "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz")]
        [TestCase(20, "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz")]
        [TestCase(30, "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz")]
        public void PrintNumbers(int iterations, string expectedResult)
        {  
            var sut = new FizzBuzzCalculator();

            var result = sut.PrintNumbers(iterations);

            result.Should().Be(expectedResult);
        }
    }
}
