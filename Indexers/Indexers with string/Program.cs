using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers_with_string
{
    class DayCollection
    {
        string[] days = { "Sun", "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat" };
        private int GetDay(string testDay)
        {
            for(int j=0;j<days.Length;j++)
            {
                if(days[j]==testDay)
                {
                    return j;
                }
            }
            throw new ArgumentOutOfRangeException
                (testDay, "testDay must be in the form\"Sun\",\"Mon\",ets");
        }
        public int this[string day]
        {
            get
            {
                return GetDay(day);
                            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DayCollection week = new DayCollection();
            Console.WriteLine(week["Mon"]);

            // Raises ArgumentOutOfRangeException
         // Console.WriteLine(week["Made-up Day"]);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
          Console.ReadKey();
        }
    }
}
