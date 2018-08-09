using System;
using System.Collections.Generic;
using System.Text;

namespace DateTimePlayground.ConvertingBetweenDateTimeAndDateTimeOffset
{
    public static class Example_004
    {
        public static void RunMain()
        {
            DateTime time1 = new DateTime(2008, 6, 19, 7, 0, 0);     // Kind is DateTimeKind.Unspecified
            try
            {
                DateTimeOffset time2 = new DateTimeOffset(time1,
                               TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time").GetUtcOffset(time1));
                Console.WriteLine("Converted |{0}| |{1}| to a DateTimeOffset value of |{2}|",
                                  time1,
                                  time1.Kind.ToString(),
                                  time2);
            }
            // Handle exception if time zone is not defined in registry
            catch (TimeZoneNotFoundException)
            {
                Console.WriteLine("Unable to identify target time zone for conversion.");
            }
            // This example displays the following output to the console:
            //    Converted 6/19/2008 7:00:00 AM Unspecified to a DateTime value of 6/19/2008 7:00:00 AM -05:00
        }
    }
}
