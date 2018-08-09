using System;
using System.Collections.Generic;
using System.Text;

namespace DateTimePlayground.ConvertingBetweenDateTimeAndDateTimeOffset
{
    public static class Example_003
    {
        public static void RunMain()
        {
            DateTime time1 = new DateTime(2008, 6, 19, 7, 0, 0);  // Kind is DateTimeKind.Unspecified
            DateTimeOffset time2 = time1;
            Console.WriteLine("Converted |{0}| |{1}| to a DateTimeOffset value of |{2}|",
                              time1,
                              time1.Kind.ToString(),
                              time2);
            // This example displays the following output to the console:
            //    Converted 6/19/2008 7:00:00 AM Unspecified to a DateTimeOffset value of 6/19/2008 7:00:00 AM -07:00
        }
    }
}
