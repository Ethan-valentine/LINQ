using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQListColdWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            enum DaysOfWeek
        {
            Sun = 1, Mon = 2, Tues, Wed, Thurs, Fri, Sat
        }
        class weather
        {
            public int Day { get; set; }
            public int HighTemp { get; set; }
            public int LowTemp { get; set; }

            public weather(weather)
            {
                nameofweather = weather;
                Console.WriteLine("\nDaysOfWeek day" + DaysOfWeek + "\n int HighTemp" + int HighTemp + "\nLowTemp" + int LowTemp);
            }
        }


        }
    }
}
