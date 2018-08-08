using System;
using System.Collections.Generic;
using System.Text;

namespace DateTimePlayground.ConvertingBetweenDateTimeAndDateTimeOffset
{
    public static class Example_001
    {
        public static void RunMain()
        {
            DateTime utcTime1 = new DateTime(2008, 6, 19, 7, 0, 0);
            utcTime1 = DateTime.SpecifyKind(utcTime1, DateTimeKind.Utc);
            DateTimeOffset utcTime2 = utcTime1;
            Console.WriteLine("Converted {0} {1} to a DateTimeOffset value of {2}",
                              utcTime1,
                              utcTime1.Kind.ToString(),
                              utcTime2);
            // This example displays the following output to the console:
            //    Converted 6/19/2008 7:00:00 AM Utc to a DateTimeOffset value of 6/19/2008 7:00:00 AM +00:00
        }
    }
}
