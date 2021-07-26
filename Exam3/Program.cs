using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam3
{
    class Program
    {
        static void Main(string[] args)
        {
            //var arrival = new List<int>{ 1, 3, 5 };
            //var durations = new List<int>{ 2, 2, 2 };

            //var arrival = new List<int> { 1, 3, 3, 5, 7 };
            //var durations = new List<int> { 2, 2, 1, 2, 1 };

            var arrival = new List<int> { 1};
            var durations = new List<int> { 1 };

            //var result = MaxEvents(arrival1, durations1);
            var result = MaxEvents(arrival, durations);
            Console.WriteLine($"Result {result}");
        }

        public static int MaxEvents(List<int> arrivals, List<int> durations)
        {
            // Code was written in vs code
            // Code is writing to be correct not to be fast
            // find conflicting events
            // Then subtract them

            var conflicts = 0;

            for (var i = 0; i < arrivals.Count - 1; i++)
            {
                var arrival = arrivals[i];

                var arrivalTime = arrival + durations[i];
                var nextTime = arrivals[i + 1] + durations[i + 1];
            }

            for (var i = 0; i < arrivals.Count - 1; i++)
            {
                var arrival = arrivals[i];

                var arrivalTime = arrival + durations[i];
                var previewTime = arrivals[i - 1] + durations[i - 1];
                var nextTime = arrivals[i + 1] + durations[i + 1];

                if (arrivalTime < previewTime)
                {
                    conflicts++;
                }

                if (arrivalTime > nextTime)
                {
                    conflicts++;
                }
            }

            return arrivals.Count - conflicts;
        }
    }
}
