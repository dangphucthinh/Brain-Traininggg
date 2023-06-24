using System;
using System.Diagnostics.Metrics;

namespace ConsoleApp1
{
    public class KangarooJump
    {
        // You are choreographing a circus show with various animals.
        // For one act, you are given two kangaroos on a number line ready to jump in the positive direction(i.e, toward positive infinity).
        // The first kangaroo starts at location x1 and moves at a rate of v1  meters per jump.
        // The second kangaroo starts at location  x2 and moves at a rate of v2 meters per jump.
        // You have to figure out a way to get both kangaroos at the same location at the same time as part of the show.If it is possible, return YES, otherwise return NO.




        #region Solution
        //Let's denote the position of the first kangaroo as x1, the velocity of the first kangaroo as v1, the position of the second kangaroo as x2, and the velocity of the second kangaroo as v2.
        //For the kangaroos to meet at the same location, two conditions must be met 2 conditions below:
        //1: The relative starting positions of the kangaroos should allow them to potentially reach the same location.
        //In other words, (x2 - x1) should have the same sign as (v1 - v2).
        //If they have different signs, they will move further apart and never meet.
        //2: The relative velocities of the kangaroos should allow them to eventually reach the same location.
        //In other words, (x2 - x1) should be divisible evenly by(v1 - v2).
        //If the remainder is not zero, they will never meet.
        #endregion Solution
        public static string Kangoroo(int x1, int v1, int x2, int v2)
        {
            if ((v1 > v2) && ((x2 - x1) % (v1 - v2) == 0))
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }
    }
}
