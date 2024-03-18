using System;
using Cwiczenia3.Exceptions;
using Cwiczenia3.Interfaces;

namespace Cwiczenia3.Containers
{
    public class GasContainer : Container, IHazardNotifier
    {
        public GasContainer(double cargoWeight) : base(cargoWeight, 100, 10, 0, 0, "G")
        {
        }

        public override void Load(double cargoWeight)
        {
            if (cargoWeight > MaximumPayload)
            {
                throw new OverfillException();
            }
            

            CargoWeight += cargoWeight;
        }

        public override void Unload()
        {
            CargoWeight *= 0.05;
        }

        public void NotifyHazard(string containerNumber)
        {
            Console.WriteLine($"Dangerous situation detected in gas container {containerNumber}!");
        }
    }
}