namespace TravelExample
{
    public abstract class TravelStrategy
    {   
        public string _nameEntityTravelStrategyUsed { get; set; }
        public int KilometersCost { get; set; }
        public abstract decimal Drive(int kilometers);
    }
}