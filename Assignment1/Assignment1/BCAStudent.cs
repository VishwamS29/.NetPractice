using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class BCAStudent : Student
    { 
        public override double resultCalculation()
        {
            int sum = Subject1 + Subject2 + Subject3;
            double result = (sum * 100) / 300;
            return result;
        }
    }
}
