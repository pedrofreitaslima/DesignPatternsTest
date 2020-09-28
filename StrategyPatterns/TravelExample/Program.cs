using System;
using TravelExample.TravelingStrategies;

namespace TravelExample
{
    class Program
    {
        static void Main(string[] args)
        {
            TravelPlanner travelPlanner1 = new TravelPlanner();
            travelPlanner1.SetTravelStrategy(new Bus());
            travelPlanner1.Drive(1100);
            TravelPlanner travelPlanner2 = new TravelPlanner();
            travelPlanner2.SetTravelStrategy(new Car());
            travelPlanner2.Drive(1100);
            TravelPlanner travelPlanner3 = new TravelPlanner();
            travelPlanner3.SetTravelStrategy(new Plane());
            travelPlanner3.Drive(1100);
            
            Console.ReadKey();
        }
    }
}
