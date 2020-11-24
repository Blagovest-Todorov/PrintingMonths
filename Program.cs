using System;

namespace _04.MonthsExampleWithMethods
{
    class Program
    {
        static void SayMonth(int month) 
        {
                string[] monthNames = new string[] 
                {
                    "January", "February", "March",
                    "April", "May", "June", "July",
                    "August", "September", "Octomber",
                    "November", "December"
                }; 
                string monthName = monthNames[month - 1];
                Console.Write(monthName);
                
            
        }
        static void SayPeriod(int startMonth, int endMonth)
        {
            int period = endMonth - startMonth;
            if (period < 0)
            {
                period = period + 12;
                //from December till January the Period is  1 Month
                //Periond is one Mopnth not - 11 ! 

            }
            Console.Write("There are {0} months from  ", period );

            SayMonth(startMonth);
            Console.Write(" to ");
            SayMonth(endMonth);
            Console.WriteLine(".");
            
        }

        static void Main() 
        {
            Console.Write("First month (1-12): ");
            int firstMonth = int.Parse(Console.ReadLine());

            Console.Write("Second month (1-12): ");
            int secondMonth = int.Parse(Console.ReadLine());


            SayPeriod(firstMonth, secondMonth);
          
        
        }
    }
}
