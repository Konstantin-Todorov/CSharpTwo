//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
using System;
using System.Collections.Generic;
using System.Linq;
class WorkDays
{
    static List<DateTime> publicHolidays;
    static void Main()
    {
        publicHolidays = new List<DateTime>()
        {   new DateTime(2015, 3, 1), new DateTime(2015, 3, 3), new DateTime(2015, 4, 2),
            new DateTime(2015, 4, 10), new DateTime(2015, 5, 2), new DateTime(2015, 5, 12),
            new DateTime(2015, 5, 16), new DateTime(2015, 6, 13), new DateTime(2015, 6, 15)
        };
        Console.WriteLine(CountWorkDays(new DateTime(2015,1,1),new DateTime(2015,12,31)));
    }

    static string CountWorkDays(DateTime start , DateTime stop )
    {
        int workDays = 0;
        int holyDays = 0;
        int weekends = 0;
        DateTime currentDate = start;
        while (currentDate <= stop)
        {
            if (publicHolidays.Contains(currentDate))
            {
                holyDays++;
            }
            else if ( (int)currentDate.DayOfWeek == 0 || (int)currentDate.DayOfWeek == 6)
            {
                weekends++;
            }
            else
            {
                workDays++;
            }
            currentDate = currentDate.AddDays(1);
        }
        return String.Format(@"
WorkDays : {0}
Weekends : {1}
Holydays : {2}", workDays, weekends, holyDays);
    }
    
}
