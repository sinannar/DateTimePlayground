using System;
using System.Collections.Generic;
using System.Text;

namespace DateTimePlayground.ConvertingBetweenDateTimeAndDateTimeOffset
{
    public static class Example_009
    {
        public static void RunMain()
        {
            DateTime sourceDate = new DateTime(2008, 6, 19, 7, 0, 0);
            DateTimeOffset localTime1 = new DateTimeOffset(sourceDate,
                                      TimeZoneInfo.Local.GetUtcOffset(sourceDate));
            DateTime localTime2 = localTime1.LocalDateTime;

            Console.WriteLine("|{0}| converted to |{1}| |{2}|",
                              localTime1,
                              localTime2,
                              localTime2.Kind.ToString());
            // The example displays the following output to the console:
            //   6/19/2008 7:00:00 AM -07:00 converted to 6/19/2008 7:00:00 AM Local
        }
    }
}
