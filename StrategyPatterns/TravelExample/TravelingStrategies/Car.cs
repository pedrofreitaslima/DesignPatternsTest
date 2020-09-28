namespace TravelExample.TravelingStrategies
{
    public class Car : TravelStrategy
    {
        public Car()
        {
            _nameEntityTravelStrategyUsed = this.GetType().Name;
            KilometersCost = 25;
        }

        public override decimal Drive(int kilometers)
        {
            return kilometers * KilometersCost;
        }
    }
}