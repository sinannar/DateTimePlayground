using System;
using System.Collections.Generic;
using System.Text;

namespace DateTimePlayground.ConvertingBetweenDateTimeAndDateTimeOffset
{
    public static class Example_002
    {
        public static void RunMain()
        {
            DateTime localTime1 = new DateTime(2008, 6, 19, 7, 0, 0);
            localTime1 = DateTime.SpecifyKind(localTime1, DateTimeKind.Local);
            DateTimeOffset localTime2 = localTime1;
            Console.WriteLine("Converted |{0}| |{1}| to a DateTimeOffset value of |{2}|",
                              localTime1,
                              localTime1.Kind.ToString(),
                              localTime2);
            // This example displays the following output to the console:
            //    Converted 6/19/2008 7:00:00 AM Local to a DateTimeOffset value of 6/19/2008 7:00:00 AM -07:00
        }
    }
}
