using System;

namespace Num2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Enter a Year: ");
          int year = Convert.ToInt32(Console.ReadLine());
          
          string Leap = LeapYear(year);

          Console.WriteLine("The year " + year + " is a leap year " + Leap);

        }

        static string LeapYear(int year)
        {
          if (year % 4 == 0)
          {
            if (year % 100 == 0)
            {
              if (year % 400 == 0)
              {
                return "is a leap year.";
              }
              else
              {
                return "is not a leap year.";
              }
            }
            else
            {
              return "is a leap year.";
            }
          }
          else 
          {
            return "is not a leap year.";
          }
        }



       
        
    }
}