using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

//This is a test file that uses 5 examples and 2 combined expamples featured from IComparable and CompareTo() and And overloaded + operator.
//Author: heather Whittlesey
//10/07/2020

namespace HaroldsHomeServ
{
    class TestJobs {

       static TestJobs [] landscapingArray = new TestJobs [5];
      
    static Job profile1;
    static Job profile2;
    static Job profile3;
    static Job profile4;
    static Job profile5;

        public static void Main(String[] args)

        {

            profile1 = new Job();                    // this uses the default constructor

            profile2 = new Job(2, 17.50, "garden"); // this uses an overloaded/parameterized constructor

            profile3 = new Job(3.5, 15.00, "mow");

            profile4 = new Job(1.25, 37.50, "flowers");

            profile5 = new Job(1.7, 30.00, "bricklaying");

            Job profile6 = profile1 + profile2;

            Job profile7 = profile3 + profile4;

            //^^Job acts like a data type here

            //^^^these represent objects for lawnscaping duties

            Console.WriteLine(profile1.ToString());
            Console.WriteLine(profile2.ToString());
            Console.WriteLine(profile3.ToString());
            Console.WriteLine(profile4.ToString());
            Console.WriteLine(profile5.ToString());
            Console.WriteLine(profile6.ToString());
            Console.WriteLine(profile7.ToString());

            Console.ReadLine();         

        }
    }
}