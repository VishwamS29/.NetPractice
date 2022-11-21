using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            double result;

            Console.WriteLine("Hello World!");

            Console.Write("Enter Stream : ");
            string stream = Console.ReadLine();

            if (stream == "BCA")
            {
                BCAStudent bca = new BCAStudent();
                
                Console.Write("subject 1 marks : ");
                bca.Subject1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("subject 2 marks : ");
                bca.Subject2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("subject 3 marks : ");
                bca.Subject3 = Convert.ToInt32(Console.ReadLine());

                result = bca.resultCalculation();
                Console.WriteLine(result);
            }
            else if (stream == "MCA")
            {
                MCAStudent mca = new MCAStudent();

                Console.Write("subject 1 marks : ");
                mca.Subject1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("subject 2 marks : ");
                mca.Subject2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("subject 3 marks : ");
                mca.Subject3 = Convert.ToInt32(Console.ReadLine());

                Console.Write("subject 4 marks : ");
                mca.Subject4 = Convert.ToInt32(Console.ReadLine());

                result = mca.resultCalculation();
                Console.WriteLine(result);
            }
        }
    }
}
