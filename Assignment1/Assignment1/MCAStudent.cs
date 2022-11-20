using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class MCAStudent : Student
    {
        public int subject4;
        public double resultCalculation()
        {
            //Console.Write("Subject 1 Marks : ");
            //int S1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Subject 1 Marks : ");
            //int S2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Subject 1 Marks : ");
            //int S3 = Convert.ToInt32(Console.ReadLine());

            int sum = subject1 + subject2 + subject3 + subject4;
            double result = (sum * 100) / 400;
            return result;
        }
    }
}
