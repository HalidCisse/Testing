using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            var carsPositions1 = new List<long>{2, 10, 8, 17};
            var numberOfCarsToCover1 = 3;

            var carsPositions2 = new List<long> { 1, 2, 3, 10 };
            var numberOfCarsToCover2 = 4;


            var result = CarParkingRoof(carsPositions1, numberOfCarsToCover1);
            //var result = CarParkingRoof(carsPositions2, numberOfCarsToCover2);
            Console.WriteLine($"Done! {result}");
        }

        public static long CarParkingRoof(List<long> carsPositions, int numberOfCarsToCover)
        {
            var min = carsPositions.Min();
            var max = carsPositions.Max();
            var shortestCoverLength = (max - min) + 1;

            foreach (var carPosition in carsPositions)
            {
                // for each position calculate position to others

                foreach (var neighborPosition in carsPositions.Except(new[] {carPosition}))
                {
                    // calculate coverLength
                    var coverLength = Math.Abs(neighborPosition - carPosition) + 1;
                    var coveredCars = 0;

                    if (neighborPosition > carPosition)
                    {
                        for (var i = carPosition; i <= neighborPosition; i++)
                        {
                            if (carsPositions.Any(e=> e == i))
                            {
                                coveredCars++;
                            }
                        }
                    }
                    else
                    {
                        for (var i = carPosition; i <= neighborPosition; i--)
                        {
                            if (carsPositions.Any(e => e == i))
                            {
                                coveredCars++;
                            }
                        }
                    }

                    if (shortestCoverLength > coverLength && coveredCars == numberOfCarsToCover)
                    {
                        shortestCoverLength = coverLength;
                        Console.WriteLine($"Found {carPosition}->{neighborPosition} {shortestCoverLength}");
                    }
                }
            }

            Console.WriteLine($"Found {shortestCoverLength}");
            return shortestCoverLength;
        }
    }
}
