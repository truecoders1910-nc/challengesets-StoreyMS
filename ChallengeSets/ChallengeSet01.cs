﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace ChallengeSets
{
    public class ChallengeSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
           if(num1 == num2)
            {
                return true;
            }
           else return false;
        }

        public double Subtract(double minuend, double subtrahend)
        {
            double diff = minuend - subtrahend;
            return diff;
           
        }


        public int Add(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            if (number1 > number2)
            {
                return number2;
            }
            else return number1;
        }

        public long Multiply(long factor1, long factor2)
        {
            long num = factor1 * factor2;
            return num;
        }

        public string GetGreeting(string nameOfPerson)
        {
            if (nameOfPerson == "")
            {
                return "Hello!";
            }


            else
            {
                return $"Hello, {nameOfPerson}!";
            }
        }

        public string GetHey()
        {
            return "HEY!";
        }
    }
}
