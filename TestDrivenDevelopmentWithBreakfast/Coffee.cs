using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenDevelopmentWithBreakfast
{
    public class Coffee
    {
        private string[] coffeeCondition = { "Hot", "Quite hot", "Not so hot", "Cold" };
        private int count = 0;

        public string Temperature
        {
            get
            {
                return coffeeCondition[count++];
            }
        }

        public Coffee()
        {
            this.count = 0;
        }
    }
}
