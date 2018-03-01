using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class School
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }

        private string _twitterAddress;
        public string TwitterAddress
        {
            //Make sure the twitter address starts with an @ symbol
            get { return _twitterAddress; }
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                }
                else
                {
                    throw new Exception("The twitter address must begin with @");
                }
            }
        }
        //this is a contructor with no arguments
        public School()
        {
            Name = "Untitled School";
            Phone = "555-1234";
        }

        public School(string SchoolName, string SchoolPhoneNumber)
        {
            Name = SchoolName;
            Phone = SchoolPhoneNumber;
        }

        public float AverageTHreeScores(float a, float b, float c)
        {
            var result = (a + b + c) / 3;
            return result;
        }

        public int AverageThreeScores(int a, int b, int c)
        {
            var result = (a + b + c) / 3;
            return result;
        }
    }
}
