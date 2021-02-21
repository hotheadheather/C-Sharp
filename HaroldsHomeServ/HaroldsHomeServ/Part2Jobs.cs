using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HaroldsHomeServ
{
    class Part2Jobs
    {
        static Job newBusiness;
        //instantiate new object

       static ArrayList Biz = new ArrayList(5);
       // static ArrayList newBusiness = new ArrayList();


        //  static string[] jobEntryArray = new string[5];
        //array that holds the jobs

        private static void Main()
        {
            Init();

            int options;
            Boolean inValid = false;

            while (!inValid)
            {
                options = MenuOptions();
                switch (options)
                {
                    case 1:
                        JobEntry();
                        TimeEntry();
                        PayEntry();
                        createAnObject();
                        break;
                    case 2:

                        break;
                    case 3:
                        inValid = true;
                        break;
                    default:
                        Console.WriteLine("An Error occurred. Please try again.");
                        break;
                }
            }
        }

        private static void createAnObject()
        {


            String theJob = "";
            double theHours = 0;
            double thePay = 0;

            theJob = JobEntry();
            theHours = TimeEntry();
            thePay = PayEntry();


           // newBusiness = new Job(hours, hourlyRate, jobDesc);
            newBusiness = new Job (thePay, theHours, theJob);
           // Biz = new Job(thePay, theHours, theJob);
           // Biz = new Job(hours, hourlyRate,jobDesc);

            //instantiate the custom object that you just made


          //  Biz.Add.()


            // newBusiness[0]= new Job
            Console.WriteLine(newBusiness.ToString());



        }

        private static String JobEntry()
        {
            String jobEntry = "";
            
            Boolean inValid = true;

            while (inValid)
            {
                Console.WriteLine("Please enter a 3-5 word description of the landscaping job you need:");
                String jobToDo = Console.ReadLine();


                if (String.IsNullOrEmpty(jobToDo))
                {
                    Console.WriteLine("Please enter a description");
                    inValid = true;
                }
                else
                {
                    Console.WriteLine("Description is acceptable");
                    inValid = false;
                }
            }
            return jobEntry;
        }


        private static double TimeEntry()
        {
            double timeEntry = 0;
            Boolean inValid = true;
            do
            {
                try
                {
                    Console.WriteLine("Please enter how many hours it will take to complete the job");
                    timeEntry = Convert.ToDouble(Console.ReadLine());
                    inValid = false;
                }
                catch (Exception E)
                {
                    Console.WriteLine("Please enter a number");
                    inValid = true;
                }

            } while (inValid);

            return timeEntry;
        }


        private static double PayEntry()
        {
            double payEntry = 0;
            Boolean inValid = true;
            do
            {
                try
                {
                    Console.WriteLine("Please enter the hourly rate:");
                    payEntry = Convert.ToDouble(Console.ReadLine());
                    inValid = false;
                }
                catch (Exception E)
                {
                    Console.WriteLine("Please enter a number");
                    inValid = true;
                }

            } while (inValid);
            Console.Write("Thank you.\n");
            return payEntry;
        }

        private static int MenuOptions()
        {
            int options = 0;
            Boolean inValid = true;

            while (inValid)
            {
                Console.Write("Enter 1 to enter your jobs or enter 2 to print the jobs or enter 3 to combine 2 jobs or 4 to exit. ");
                options = Convert.ToInt32(Console.ReadLine());

                if (options > 0 && options <= 3)
                {
                    Console.Write("That entry is acceptable.\n");
                    break;
                }
                if (options == 4)
                {
                    Console.Write("Goodbye.\n");
                    Environment.Exit(0);
                }
                else
                {
                    Console.Write("Please enter a 1, 2 or 3.\n");
                }
            }
          
            return options;
        }




        private static void Init()
        {
        }
    }
}

