using System;
using System.Collections.Generic;
using System.Text;

namespace DateTimePlayground.ConvertingBetweenDateTimeAndDateTimeOffset
{
    public static class Example_007
    {
        public static void RunMain()
        {
            DateTimeOffset originalTime = new DateTimeOffset(2008, 6, 19, 7, 0, 0, new TimeSpan(5, 0, 0));
            DateTime utcTime = originalTime.UtcDateTime;
            Console.WriteLine("|{0}| converted to |{1}| |{2}|",
                              originalTime,
                              utcTime,
                              utcTime.Kind.ToString());
            // The example displays the following output to the console:
            //   6/19/2008 7:00:00 AM +00:00 converted to 6/19/2008 7:00:00 AM Utc
            
        }
    }
}
