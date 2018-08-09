using System;
using System.Collections.Generic;
using System.Text;

namespace DateTimePlayground.ConvertingBetweenDateTimeAndDateTimeOffset
{
    public static class Example_005
    {
        public static void RunMain()
        {
            DateTime baseTime = new DateTime(2008, 6, 19, 7, 0, 0);
            DateTimeOffset sourceTime;
            DateTime targetTime;

            // Convert UTC to DateTime value
            sourceTime = new DateTimeOffset(baseTime, TimeSpan.Zero);
            targetTime = sourceTime.DateTime;
            Console.WriteLine("{0} converts to {1} {2}",
                              sourceTime,
                              targetTime,
                              targetTime.Kind.ToString());

            // Convert local time to DateTime value
            sourceTime = new DateTimeOffset(baseTime,
                                            TimeZoneInfo.Local.GetUtcOffset(baseTime));
            targetTime = sourceTime.DateTime;
            Console.WriteLine("|{0}| converted to |{1}| |{2}|",
                              sourceTime,
                              targetTime,
                              targetTime.Kind.ToString());

            // Convert Central Standard Time to a DateTime value
            try
            {
                TimeSpan offset = TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time").GetUtcOffset(baseTime);
                sourceTime = new DateTimeOffset(baseTime, offset);
                targetTime = sourceTime.DateTime;
                Console.WriteLine("|{0}| converted to |{1}| |{2}|",
                                  sourceTime,
                                  targetTime,
                                  targetTime.Kind.ToString());
            }
            catch (TimeZoneNotFoundException)
            {
                Console.WriteLine("Unable to create DateTimeOffset based on U.S. Central Standard Time.");
            }
            // This example displays the following output to the console:
            //    6/19/2008 7:00:00 AM +00:00 converts to 6/19/2008 7:00:00 AM Unspecified
            //    6/19/2008 7:00:00 AM -07:00 converts to 6/19/2008 7:00:00 AM Unspecified
            //    6/19/2008 7:00:00 AM -05:00 converts to 6/19/2008 7:00:00 AM Unspecified
        }
    }
}
