using System;
using System.Collections.Generic;
using System.Text;

namespace TimeAngle
{
    class TimeAngle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the hour: ");
            int hour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the minute: ");
            int minute = Convert.ToInt32(Console.ReadLine());

            if (hour == 12)
                hour = 0;
            if (minute == 60)
                minute = 0;

            int hour_angle = (int)(0.5 * (hour * 60 + minute));
            int minute_angle = (int)(6 * minute);

            int angle = Math.Abs(hour_angle - minute_angle);

            angle = Math.Min(360 - angle, angle);

            Console.WriteLine("Angle between the hour and minute hand is: " + angle);

        }
    }
}
