using System;
using System.Collections.Generic;
using System.Text;

namespace DateTimePlayground.ConvertingBetweenDateTimeAndDateTimeOffset
{
    public static class Example_006
    {
        public static void RunMain()
        {
            DateTimeOffset utcTime1 = new DateTimeOffset(2008, 6, 19, 7, 0, 0, TimeSpan.Zero);
            DateTime utcTime2 = utcTime1.UtcDateTime;
            Console.WriteLine("|{0}| converted to |{1}| |{2}|",
                              utcTime1,
                              utcTime2,
                              utcTime2.Kind.ToString());
            // The example displays the following output to the console:
            //   6/19/2008 7:00:00 AM +00:00 converted to 6/19/2008 7:00:00 AM Utc
        }
    }
}
