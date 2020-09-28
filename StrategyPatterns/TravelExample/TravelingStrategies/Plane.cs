namespace TravelExample.TravelingStrategies
{
    public class Plane : TravelStrategy
    {
        public Plane()
        {
            _nameEntityTravelStrategyUsed = this.GetType().Name;
            KilometersCost = 50;
        }

        public override decimal Drive(int kilometers)
        {
            if(kilometers >= 1100)
            {
                KilometersCost = 15;
            }
            return kilometers * KilometersCost;
        }
    }
}