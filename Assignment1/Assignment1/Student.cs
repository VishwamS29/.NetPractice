using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public abstract class Student
    {
        //public string name;

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _subject1;

        public int Subject1
        {
            get { return _subject1; }
            set { _subject1 = value; }
        }

        private int _subject2;

        public int Subject2
        {
            get { return _subject2; }
            set { _subject2 = value; }
        }

        private int _subject3;

        public int Subject3
        {
            get { return _subject3; }
            set { _subject3 = value; }
        }

        public virtual double resultCalculation()
        {
            return 0;
        }
    }
}
