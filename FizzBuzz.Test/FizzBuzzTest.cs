using System;
using Xunit;
using FizzBuzz;

namespace FizzBuzz.Test
{
    public class FizzBuzzProblemTest
    {
        [Fact]
        public void FirstTest()
        {
            var _FIzzBuzz = new FizzBuzzProblem();

            var expected = 2;
            ver actual = _FIzzBuzz.Output();

            actual.Equal(expected, actual);
        }
    }
}
