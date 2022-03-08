using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class Gorthan : Driver
    {
        public Gorthan(RaceCar car) : base(car)
        {
            Name = "Gorthan";
            SkillLevel = 12;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
        
    }
}