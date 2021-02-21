using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentScores
{
  
        public class IDException : Exception
        {

            // Exception for when quantity is less than or equal to 0

            public IDException() : base("The student ID must be five digits long")
            {
            }
        }
}
