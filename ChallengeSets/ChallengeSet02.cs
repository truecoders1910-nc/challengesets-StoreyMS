using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int rem = vals.Length % 2;
            if (rem == 0)
            {
                return true;
            }
            else return false;
        }

        public bool IsNumberEven(int number)
        {
            int rem = number % 2;
            if (rem == 0)
            {
                return true;
            }
            else return false;
        }

        public bool IsNumberOdd(int num)
        {
            int number = num % 2;
            if (number != 0)
            {
                return true;
            }
            else return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            double sum;
            sum = numbers.Min() + numbers.Max();
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if(str1.Length < str2.Length)
            {
                return str1.Length;
            }
            return str2.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            int result = 0;
            if (numbers == null)
            {
                return 0;
            }
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    result += number;
                }
            }
            return result;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            if (numbers.Sum() % 2 != 0 || numbers.Sum() == -1)
            {
                return true;
            }
            else return false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number > 0)
            {
                return number % 2 == 0 ? number / 2 : (number - 1) / 2;
            }
            return 0;
        }
    }
}
