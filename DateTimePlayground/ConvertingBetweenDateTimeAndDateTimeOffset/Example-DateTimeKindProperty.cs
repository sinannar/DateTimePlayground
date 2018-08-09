using System;
using System.Collections.Generic;
using System.Text;

//https://docs.microsoft.com/en-us/dotnet/api/system.datetime.kind?view=netframework-4.7.2
namespace DateTimePlayground.ConvertingBetweenDateTimeAndDateTimeOffset
{
    public static class Example_DateTimeKindProperty
    {
        public static void RunMain()
        {
            // Get the date and time for the current moment, adjusted 
            // to the local time zone.
            DateTime saveNow = DateTime.Now;

            // Get the date and time for the current moment expressed 
            // as coordinated universal time (UTC).
            DateTime saveUtcNow = DateTime.UtcNow;
            DateTime myDt;

            // Display the value and Kind property of the current moment 
            // expressed as UTC and local time.
            DisplayNow("UtcNow: ..........", saveUtcNow);
            DisplayNow("Now: .............", saveNow);
            Console.WriteLine();


            // Change the Kind property of the current moment to 
            // DateTimeKind.Utc and display the result.
            myDt = DateTime.SpecifyKind(saveNow, DateTimeKind.Utc);
            Display("Utc: .............", myDt);

            // Change the Kind property of the current moment to 
            // DateTimeKind.Local and display the result.
            myDt = DateTime.SpecifyKind(saveNow, DateTimeKind.Local);
            Display("Local: ...........", myDt);

            // Change the Kind property of the current moment to 
            // DateTimeKind.Unspecified and display the result.
            myDt = DateTime.SpecifyKind(saveNow, DateTimeKind.Unspecified);
            Display("Unspecified: .....", myDt);
        }

        public static string datePatt = @"M/d/yyyy hh:mm:ss tt";

        public static void Display(string title, DateTime inputDt)
        {
            DateTime dispDt = inputDt;
            string dtString;

            // Display the original DateTime.
            dtString = dispDt.ToString(datePatt);
            Console.WriteLine("|{0}| |{1}|, Kind = |{2}|",
                              title, dtString, dispDt.Kind);

            // Convert inputDt to local time and display the result. 
            // If inputDt.Kind is DateTimeKind.Utc, the conversion is performed.
            // If inputDt.Kind is DateTimeKind.Local, the conversion is not performed.
            // If inputDt.Kind is DateTimeKind.Unspecified, the conversion is 
            // performed as if inputDt was universal time.
            dispDt = inputDt.ToLocalTime();
            dtString = dispDt.ToString(datePatt);
            Console.WriteLine("  ToLocalTime:     |{0}|, Kind = |{1}|",
                              dtString, dispDt.Kind);

            // Convert inputDt to universal time and display the result. 
            // If inputDt.Kind is DateTimeKind.Utc, the conversion is not performed.
            // If inputDt.Kind is DateTimeKind.Local, the conversion is performed.
            // If inputDt.Kind is DateTimeKind.Unspecified, the conversion is 
            // performed as if inputDt was local time.
            dispDt = inputDt.ToUniversalTime();
            dtString = dispDt.ToString(datePatt);
            Console.WriteLine("  ToUniversalTime: |{0}|, Kind = |{1}|",
                              dtString, dispDt.Kind);
            Console.WriteLine();
        }


        public static void DisplayNow(string title, DateTime inputDt)
        {
            string dtString = inputDt.ToString(datePatt);
            Console.WriteLine("|{0}| |{1}|, Kind = |{2}|",
                              title, dtString, inputDt.Kind);
        }
    }
}
