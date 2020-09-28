using System;

namespace TravelExample
{
    public class TravelPlanner
    {
        private TravelStrategy _travelStrategy;

        public void SetTravelStrategy(TravelStrategy travelStrategy)
        {
            _travelStrategy = travelStrategy;
        }

        public void Drive(int kilometers)
        {
            var cost = _travelStrategy.Drive(kilometers);
            var entityName = _travelStrategy._nameEntityTravelStrategyUsed;
            Console.WriteLine("Cost of the drive with {0} is: {1}", entityName, cost);
        }

    }
}