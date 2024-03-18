using Cwiczenia3.Exceptions;
using Cwiczenia3.Interfaces;

namespace Cwiczenia3.Containers;

public abstract class Container : IContainer
{
    public double CargoWeight { get; set; }
    public double Maximumload { get; }
    public double Emptying { get; }
    public string SerialNumber { get; }
    public double Height { get; }
    public double Depth { get; }

    protected Container(double cargoWeight, double maximumload, double emptying, string serialNumber)
    {
        CargoWeight = cargoWeight;
        Maximumload = maximumload;
        Emptying = emptying;
        Height = height;
        Depth = depth;
        SerialNumber = serialNumber;
    }

    public virtual void Load(double cargoWeight)
    {
        if (cargoWeight > Maximumload)
        {
            throw new OverfillException();
        }
        CargoWeight = cargoWeight;
    }

    public void Unload()
    {
        CargoWeight -= Emptying;
    }
    

}