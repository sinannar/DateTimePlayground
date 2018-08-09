using System;
using System.Collections.Generic;
using System.Text;

namespace DateTimePlayground.ConvertingBetweenDateTimeAndDateTimeOffset
{
    public static class Example_013
    {
        public static void RunMain()
        {
            DateTime timeComponent = new DateTime(2008, 6, 19, 7, 0, 0);
            DateTime returnedDate;

            // Convert UTC time
            DateTimeOffset utcTime = new DateTimeOffset(timeComponent, TimeSpan.Zero);
            returnedDate = ConvertFromDateTimeOffset(utcTime);
            Console.WriteLine("{0} converted to {1} {2}",
                              utcTime,
                              returnedDate,
                              returnedDate.Kind.ToString());

            // Convert local time
            DateTimeOffset localTime = new DateTimeOffset(timeComponent,
                                       TimeZoneInfo.Local.GetUtcOffset(timeComponent));
            returnedDate = ConvertFromDateTimeOffset(localTime);
            Console.WriteLine("{0} converted to {1} {2}",
                              localTime,
                              returnedDate,
                              returnedDate.Kind.ToString());

            // Convert Central Standard Time
            DateTimeOffset cstTime = new DateTimeOffset(timeComponent,
                           TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time").GetUtcOffset(timeComponent));
            returnedDate = ConvertFromDateTimeOffset(cstTime);
            Console.WriteLine("{0} converted to {1} {2}",
                              cstTime,
                              returnedDate,
                              returnedDate.Kind.ToString());
            // The example displays the following output to the console:
            //    6/19/2008 7:00:00 AM +00:00 converted to 6/19/2008 7:00:00 AM Utc
            //    6/19/2008 7:00:00 AM -07:00 converted to 6/19/2008 7:00:00 AM Local
            //    6/19/2008 7:00:00 AM -05:00 converted to 6/19/2008 7:00:00 AM Unspecified
        }

        public static DateTime ConvertFromDateTimeOffset(DateTimeOffset dateTime)
        {
            if (dateTime.Offset.Equals(TimeSpan.Zero))
                return dateTime.UtcDateTime;
            else if (dateTime.Offset.Equals(TimeZoneInfo.Local.GetUtcOffset(dateTime.DateTime)))
                return DateTime.SpecifyKind(dateTime.DateTime, DateTimeKind.Local);
            else
                return dateTime.DateTime;
        }
    }
}
