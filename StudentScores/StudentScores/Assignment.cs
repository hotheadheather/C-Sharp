using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentScores
{
    public class Assignment
    {



        protected double assignmentPointsEarned;
        protected double assignmentPointsPossible;
        protected string assignmentName;



            public string AssignmentName
        {
                get
                {
                return assignmentName;
                }

                set
                {
                    if (!string.IsNullOrEmpty(value.Trim()))
                    {
                    assignmentName = value.Trim();
                    }
                }
            }



            public double AssignmentPointsEarned
        {
                get
                {
                    return assignmentPointsEarned;
                }

                set
                {
                    if (value > -1)
                    {
                    assignmentPointsEarned = value;
                    }

                }
            }


        public double AssignmentPointsPossible
        {
            get
            {
                return assignmentPointsPossible;
            }

            set
            {
                if (value > -1)
                {
                    AssignmentPointsPossible = value;
                }

            }
        }



        public void CurrentStudent()
            {


                assignmentName = "Computer Science";
                assignmentPointsEarned = 100;
                assignmentPointsPossible = 100;



        }



            public void CurrentStudent(string an, double pe, double pp)
            {

            AssignmentName = an;
            AssignmentPointsEarned = pe;
            AssignmentPointsPossible = pp;



        }    
   
        }
    }
