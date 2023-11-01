using FizzBuzz;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzGameTest
    {
        [Fact]
        public void Should_return_the_number_when_countoff_given_a_normal_case_number()
        {
            //given
            int givenNumber = 1;
            //FizzBuzzGame game = new FizzBuzzGame();

            //when
            string res = FizzBuzzGame.Countoff(givenNumber);

            //then
            Assert.Equal("1", res);
        }
    }
}