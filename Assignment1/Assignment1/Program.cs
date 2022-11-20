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
            //Console.Write(stream);

            if (stream == "BCA")
            {
                BCAStudent bca = new BCAStudent();
                
                Console.Write("subject 1 marks : ");
                bca.subject1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("subject 2 marks : ");
                bca.subject2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("subject 3 marks : ");
                bca.subject3 = Convert.ToInt32(Console.ReadLine());

                result = bca.resultCalculation();
                Console.WriteLine(result);
            }
            else if (stream == "MCA")
            {
                MCAStudent mca = new MCAStudent();

                Console.Write("subject 1 marks : ");
                mca.subject1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("subject 2 marks : ");
                mca.subject2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("subject 3 marks : ");
                mca.subject3 = Convert.ToInt32(Console.ReadLine());

                Console.Write("subject 4 marks : ");
                mca.subject4 = Convert.ToInt32(Console.ReadLine());

                result = mca.resultCalculation();
                Console.WriteLine(result);
            }

            //Console.WriteLine("Result : " + result);
            //console.write("subject 1 marks : ");
            //s.subject1 = convert.toint32(console.readline());
            //console.write("subject 1 marks : ");
            //string s2 = console.readline();
            //console.write("subject 1 marks : ");
            //string s3 = console.readline();
        }
    }
}
