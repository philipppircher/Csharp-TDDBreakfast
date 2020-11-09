using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenDevelopmentWithBreakfast
{
    public class Food
    {
        private int count = 0;
        public Food(int length)
        {
            Length = length;
        }

        public int Length { get { return count; } set { count = value; } }
    }
}
