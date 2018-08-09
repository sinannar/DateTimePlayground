using System;
using System.Collections.Generic;
using System.Text;

namespace DateTimePlayground.ConvertingBetweenDateTimeAndDateTimeOffset
{
    public static class Example_011
    {
        public static void RunMain()
        {
            DateTimeOffset originalDate;
            DateTime localDate;

            // Convert time originating in a different time zone
            originalDate = new DateTimeOffset(2008, 6, 18, 7, 0, 0,
                                              new TimeSpan(-5, 0, 0));
            localDate = originalDate.LocalDateTime;
            Console.WriteLine("{0} converted to {1} {2}",
                              originalDate,
                              localDate,
                              localDate.Kind.ToString());
            // Convert time originating in a different time zone 
            // so local time zone's adjustment rules are applied
            originalDate = new DateTimeOffset(2007, 11, 4, 4, 0, 0,
                                              new TimeSpan(-5, 0, 0));
            localDate = originalDate.LocalDateTime;
            Console.WriteLine("{0} converted to {1} {2}",
                              originalDate,
                              localDate,
                              localDate.Kind.ToString());
            // The example displays the following output to the console:
            //       6/19/2008 7:00:00 AM -05:00 converted to 6/19/2008 5:00:00 AM Local
            //       11/4/2007 4:00:00 AM -05:00 converted to 11/4/2007 1:00:00 AM Local
        }
    }
}
