namespace Cwiczenia3.Containers;

using System;
using Cwiczenia3.Exceptions;
using Cwiczenia3.Interfaces;

namespace Cwiczenia3.Containers
{
    public class LiquidContainer : Container, IHazardNotifier
    {
        private bool _isDangerous;

        public LiquidContainer(double cargoWeight) : base(cargoWeight, 100, 10, 0, 0, "L")
        {
            _isDangerous = false;
        }

        public override void Load(double cargoWeight)
        {
            if (cargoWeight > MaximumPayload)
            {
                throw new OverfillException();
            }

            if (_isDangerous && cargoWeight > MaximumPayload * 0.5)
            {
                throw new DangerousOperationException("Attempted to load dangerous liquid container beyond 50% capacity.");
            }

            if (!_isDangerous && cargoWeight > MaximumPayload * 0.9)
            {
                throw new DangerousOperationException("Attempted to load non-dangerous liquid container beyond 90% capacity.");
            }

            CargoWeight = cargoWeight;
        }

        public void NotifyHazard(string containerNumber)
        {
            Console.WriteLine($"Dangerous situation detected in container {containerNumber}!");
        }
    }
}
