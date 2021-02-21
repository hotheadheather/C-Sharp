using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//this is the child class

namespace StudentScores
{
    //[Serializable]
    class DormStudent : CurrentStudent
    {
        char dormType;
        char mealType;

        public DormStudent()
        {
            
            mealType = 'B';
            dormType = 'W'; 
           
        }


        public DormStudent(string sn, int si, char dormType, char mealType)
        {
            this.DormType = dormType;
            this.MealType = mealType;
            StudentName = sn;
            StudentID = si;
        }


        //this overloaded constructor has characteristics of parent and child

        public char DormType
        {
            get
            {
                return dormType;
            }

            set
            {
                if (char.ToUpper(value) == 'O' || char.ToUpper(value) == 'T' || char.ToUpper(value) == 'W' || char.ToUpper(value) == 'A' || char.ToUpper(value) == 'M')
                {
                    dormType = char.ToUpper(value);

                }
            }
        }

             public char MealType
        {
            get
            {
                return mealType;
            }

            set
            {
                if (char.ToUpper(value) == 'B' || char.ToUpper(value) == 'M' || char.ToUpper(value) == 'H')
                {
                    mealType = char.ToUpper(value);

                }
            }
        }


        override
        public String ToString()
        {
            string dormString;


            if (dormType == 'O')
            {
                dormString = "Oak";
            }
            else if (dormType == 'T')
            {

                dormString = "Trustee";
            }
            else if (dormType == 'W')
            {

                dormString = "Wapello";
            }
            else if (dormType == 'A')
            {

                dormString = "Appanoose";
            }
            else
            {
                dormString = "Mahaska";
            }
            return "Student Name:" + studentName + " "
                + "Student ID:" + studentID + " "
                + "Student Type:" + dormType + " " 
                + "Dorm:" + dormString + " "
                + "Meal Plan:" + mealType;



        }


    }
}
