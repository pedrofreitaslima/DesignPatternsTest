namespace TravelExample.TravelingStrategies
{
    public class Bus : TravelStrategy
    {
        public Bus()
        {
            _nameEntityTravelStrategyUsed = this.GetType().Name;
            KilometersCost = 20;
        }

        public override decimal Drive(int kilometers)
        {
            return kilometers * KilometersCost;
        }
    }
}