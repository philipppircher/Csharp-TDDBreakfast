using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenDevelopmentWithBreakfast
{
    public class Eggs : Food
    {
        public Eggs(int length) : base(length) 
        {
        }

        public string Print()
        {
            return  this.Length + " eggs";
        }
    }
}
