using System;

namespace RaceTrack.RaceTrack.Cars
{
    public class DemonicThreeWheeler : RaceCar
    {

        public DemonicThreeWheeler()
        {

            Name = "Demonic Three-Wheeler";
            TopSpeed = 60;

        }
        
        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} is revving its engine");
        }

        public override void StopEngine()
        {
            Console.WriteLine($"The {Name} has come to a complete stop.");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} is coming to a screeching halt!");
            base.Brake();
        }
        
    }
}