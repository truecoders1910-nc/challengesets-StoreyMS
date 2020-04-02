using System;
using System.Collections.Generic;
using System.Linq;
namespace ChallengeSets
{
    public class ChallengeSet08
    {
        public bool CanHopAcross(int[] hopAmount)
        {
            int index = 0;
            while (true)
            {



                int value = hopAmount[index];

                if ((value + index) < 0 || value == 0) return false;

                if ((value + index) > (hopAmount.Length - 1)) return true;

                if (index + value + hopAmount[index + value] == index) return false;

                index = index + value;
            }
        }

        public enum Frogger { Y, N }
        public Frogger GetTheFrogAcross(char[,] finalResult)
        {
            throw new NotImplementedException();
        }
    }
}