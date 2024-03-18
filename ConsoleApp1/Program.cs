using System;

namespace Cwiczenia3.Containers
{
    public abstract class Container
    {
        public string SerialNumber { get; }
        public double CargoWeight { get; protected set; }

        protected Container(string serialNumber)
        {
            SerialNumber = serialNumber;
        }

        public abstract void Load(double cargoWeight);
        public abstract void Unload();
        public abstract void PrintContainerInfo();
    }


    public class LiquidContainer : Container
    {
        public LiquidContainer() : base(GenerateSerialNumber("L"))
        {
        }

        public override void Load(double cargoWeight)
        {
            CargoWeight = cargoWeight;
        }

        public override void Unload()
        {
            CargoWeight = 0;
        }

        public override void PrintContainerInfo()
        {
            Console.WriteLine($"Liquid Container {SerialNumber}: {CargoWeight} kg");
        }
    }

    public class GasContainer : Container
    {
        public GasContainer() : base(GenerateSerialNumber("G"))
        {
        }

        public override void Load(double cargoWeight)
        {
            CargoWeight = cargoWeight;
        }

        public override void Unload()
        {
            CargoWeight = 0;
        }

        public override void PrintContainerInfo()
        {
            Console.WriteLine($"Gas Container {SerialNumber}: {CargoWeight} kg");
        }
    }

    private string GenerateSerialNumber(string containerType)
    {
        string serialNumber = $"KON-{containerType}-{_serialCounter}";
        _serialCounter++;
        return serialNumber;
    }
}