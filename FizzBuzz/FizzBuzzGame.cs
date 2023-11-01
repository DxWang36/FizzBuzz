using System;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        public static string Countoff(int givenNumber)
        {
            if (givenNumber % 3 == 0)
            {
                return "Fizz";
            }

            return givenNumber.ToString();
        }
    }
}
