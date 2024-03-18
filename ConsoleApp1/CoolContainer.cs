namespace DefaultNamespace;

using System;
using Cwiczenia3.Exceptions;
using Cwiczenia3.Interfaces;

namespace Cwiczenia3.Containers
{
    public class RefrigeratedContainer : Container
    {
        private string _productType;
        private double _requiredTemperature;

        public RefrigeratedContainer(double cargoWeight, string productType, double requiredTemperature) 
            : base(cargoWeight, 100, 10, 0, 0, "C")
        {
            _productType = productType;
            _requiredTemperature = requiredTemperature;
        }

        public override void Load(double cargoWeight)
        {
            if (cargoWeight > MaximumPayload)
            {
                throw new OverfillException();
            }

            if (CargoWeight != 0 && _productType != null && _productType != "")
            {
                throw new InvalidOperationException("Refrigerated container already contains cargo.");
            }

            CargoWeight += cargoWeight;
        }

        public override void Unload()
        {
            CargoWeight = 0;
        }
    }
}
