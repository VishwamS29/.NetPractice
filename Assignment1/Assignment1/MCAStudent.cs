using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class MCAStudent : Student
    {
        private int _subject4;

        public int Subject4
        {
            get { return _subject4; }
            set { _subject4 = value; }
        }

        //public int subject4;
        public override double resultCalculation()
        {
            int sum = Subject1 + Subject2 + Subject3 + Subject4;
            double result = (sum * 100) / 400;
            return result;
        }
    }
}
