using System;

namespace Encapsulation1.Models
{
    public class Encapsulation : Program
    {

        private string studentName;
        private int studentAge;

        public string Name
        {

            get
            {
                return studentName;
            }

            set
            {
                studentName = value;
            }

        }

        public int Age
        {

            get
            {
                return studentAge;
            }

            set
            {
                studentAge = value;
            }

        }
    }
}