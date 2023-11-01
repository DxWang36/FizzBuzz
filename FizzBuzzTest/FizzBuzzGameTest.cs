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

        [Fact]
        public void Should_return_the_Fizz_when_countoff_given_a_number_can_mod_by_three()
        {
            //given
            int givenNumber = 3;
            //FizzBuzzGame game = new FizzBuzzGame();

            //when
            string res = FizzBuzzGame.Countoff(givenNumber);

            //then
            Assert.Equal("Fizz", res);
        }

        [Fact]
        public void Should_return_the_Fizz_when_countoff_given_a_number_can_mod_by_five()
        {
            //given
            int givenNumber = 5;
            //FizzBuzzGame game = new FizzBuzzGame();

            //when
            string res = FizzBuzzGame.Countoff(givenNumber);

            //then
            Assert.Equal("Buzz", res);
        }
    }
}