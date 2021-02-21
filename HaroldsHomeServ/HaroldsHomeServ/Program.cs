using System;
using static System.Console;

// This is an instantiable class that utilizes the compareTo()
// IComparable. And overloaded + operator.
// This program collects job objects for lawnscaping and combines and displays them.
//Author: Heather Whittlesey
//10/07/20

namespace HaroldsHomeServ
{
    class Job : IComparable 
    {
        // instance variables
        private string jobDesc;
        private double hours;
        private double hourlyRate;

        public string JobDesc
        {
            get => jobDesc;

            set
            {
                if (value.Trim().Length > 0)
                {
                    jobDesc = value;
                }
                else
                {
                    jobDesc = "mow yard";
                }
            }
        }

        public double Hours
        {
            get => hours;

            set
            {
                if (value > 0)
                {
                    hours = value;
                }
                else
                {
                    hours = 1;
                }
            }
        }

        public double HourlyRate
        {
            get => hourlyRate;

            set
            {
                if (value > 0)

                {
                    hourlyRate = value;
                }
                else
                {
                    hourlyRate = 10.00;
                }
                   
            }
        }

      
        public Job()
        {
            jobDesc = "mow yard";
            hours = 1;
            HourlyRate = 10.00;
        }
        //^^default constructor
        
        public Job(string jobDesc)
        {
            this.jobDesc = jobDesc;
            hours = 1;
            HourlyRate = 10.00;
        }
        //^^overloaded/parameterized constructor
       
        public Job(double hours, double hourlyRate, string jobDesc)
        {
            this.Hours = hours;
            this.HourlyRate = hourlyRate;
            this.JobDesc = jobDesc;
            
        }

        //second overloaded/parameterized constructor that accepts all 3 parameters
        public static Job operator+(Job a, Job b)
        {
            double finalHours = a.hours + b.hours;
            double finalHourlyRate = (a.hourlyRate + b.hourlyRate) / 2;
            string jobDescrip = a.JobDesc + " and " + b.JobDesc;

            return  new Job(finalHours, finalHourlyRate, jobDescrip);
           
            // ^^we are instantiating a new object here that is a combination of two jobs
        }

        //^^^this method will compare two objects 

        public double CalcFee()
        {
            double total = hours * HourlyRate;
            return total;
         
        }

        //you must implement IComparable in order to use the sort feature
        //contract that promises to use method at some point
        int IComparable.CompareTo(Object other)
        {
            
            Job listItem = (Job)other;

            if (this.CalcFee() > listItem.CalcFee())
            {
                return 1;
            }
            else if (this.CalcFee() < listItem.CalcFee())
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return "Description: " + this.JobDesc + "\n" +
                   "Charge per hour: " + this.HourlyRate.ToString("$#.00") + "\n"+
                   "Labor hours: " + this.Hours + "\n" +
                   "Total: " + CalcFee().ToString("$#.00");

        }
    }
}


       
