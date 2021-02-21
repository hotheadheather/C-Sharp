using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

//This is the base/parent class


namespace StudentScores
{

    [Serializable]
   public class  CurrentStudent : IComparable<CurrentStudent>
    {

        public static List<CurrentStudent> assignmentList = new List<CurrentStudent>();

        protected int studentID;
        protected string studentName;


        public List<CurrentStudent> AssignGrades
        {
            get;


            set;
          
        }



        public string StudentName
        {
            get
            {
                return studentName;
            }

            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    studentName = value.Trim();
                }
            }
        }



        public int StudentID
        {
            get
            {
                return studentID;
            }

            set
            {
                if (value == 5)
                {
                    studentID = value;
                }
             
            }
        }

        public string Text { get; }
        public int V { get; }

        public CurrentStudent()
        {


            StudentName = "Donna White";
            studentID = 45528;
           
         
           
        }



        public CurrentStudent(string sn, int si, List<CurrentStudent> aL )
        {

            StudentName = sn;
            StudentID = si;
            assignmentList = aL;




        }

        public CurrentStudent(string text, int v)
        {
            Text = text;
            V = v;
        }

        public int CompareTo(CurrentStudent other)
        {
            return studentID.CompareTo(other.studentID);
        }



        override
            public String ToString()
        {
            return "Student Name:" + studentName + " "
                  + "Student ID:" + studentID + " "
                 + "Student Type: Commuter";


        }

    }
} 
    
