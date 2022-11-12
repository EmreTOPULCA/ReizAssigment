using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReizAssigment
{
    internal class Clock //We need just one clock, so I use Singleton pattern.
    {
        
        double hour;
        double minute;

        private static Clock clock;
        
        //Constructor method, private because of Singleton
        private Clock()
        {

        }
               
        //Function that calculates the angle.
        public void CalculateAngel()
        {
            this.hour = InputHour();
            this.minute = InputMinute();
            double angel = Math.Abs((11 * this.minute) - (60 * this.hour))/2;

            if (angel > 180)
            {
                angel = 360-angel;
            }

            Console.WriteLine();
            Console.WriteLine("The hour arrow is on " + hour + "\nThe minute arrow is on " + minute );
            Console.WriteLine();
            Console.WriteLine("Lesser angle between hours arrow and minutes arrow:  "+ angel + " degrees");
            Console.WriteLine();
            Console.WriteLine("Do you want new calculation? (Please write 'y' if you wish. Otherwise press enter to skip. )");
            string x = Console.ReadLine();
            if(x == "y")
            {
                
                CalculateAngel();
            }
            Console.WriteLine();
        }

        public static Clock CreateClock()
        {
                       
            if ( Clock.clock == null)
            {
                Clock.clock = new Clock();
            }          
            return clock;
        }


        //Function that takes hour input
        private static double InputHour()
        {
            
            try
            {
                string sHour;
                double hour;
                Console.WriteLine("Please enter the hour...");
                 sHour = Console.ReadLine();
                 hour = double.Parse(sHour);
                
                while (hour > 23 || hour < 0)
                {
                    Console.WriteLine("Please enter hour correct! Hour must be beetween 0 and 23");
                    sHour = Console.ReadLine();
                    hour = double.Parse(sHour);

                }

                if (hour > 12)
                {
                    hour -= 12;
                }
                else if (hour == 0)
                {
                    hour = 12;
                }
                return hour;
            }
            catch
            {
                Console.WriteLine("Not a valid format. Please enter numbers!");                
                return InputHour();
                                
            }
            
            
            

        }

        //Function that takes minute input
        private static double InputMinute()
        {
            try
            {
                Console.WriteLine("Please enter the minute...");
                string sMinute = Console.ReadLine();
                double minute = double.Parse(sMinute);
                while (minute > 59 || minute < 0)
                {
                    Console.WriteLine("Please enter minute correct! Minute must be between 0 and 59.");
                    sMinute = Console.ReadLine();
                    minute = double.Parse(sMinute);

                }
                return minute;

            }
            catch
            {
                Console.WriteLine("Not a valid format. Please enter numbers!");
                return InputMinute();

            }
            
           
        }


    }
}
