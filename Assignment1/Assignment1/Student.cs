using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Student
    {
        //public string name;

        private string _name;

        public string MyProperty
        {
            get { return _name; }
            set { _name = value; }
        }

        public int subject1;
        public int subject2;
        public int subject3;

    }
}
