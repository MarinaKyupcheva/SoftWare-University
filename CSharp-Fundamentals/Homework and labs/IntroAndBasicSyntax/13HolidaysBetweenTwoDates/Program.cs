using System;

namespace _13HolidaysBetweenTwoDates
{
    class Program
    {
        static void Main(string[] args)
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(),
&quot; dd.m.yyyy & quot;, CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(),
            &quot; dd.m.yyyy & quot;, CultureInfo.InvariantCulture);
            var holidaysCount = 0;
            for (var date = startDate; date & lt;= endDate; date.AddDays(1))
if (date.DayOfWeek == DayOfWeek.Saturday & amp; &amp;
            date.DayOfWeek == DayOfWeek.Sunday) holidaysCount++;
            Console.WriteLine(holidaysCount);
        }
    }
}
