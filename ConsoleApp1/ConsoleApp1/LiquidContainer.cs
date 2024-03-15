using cwiczenia3;

namespace ConsoleApp1;

public class LiquidContainer : Container
{
    public LiquidContainer(int cargoWeight) : base(cargoWeight)
    {
        
    }

    public override void load(int cargoWeight)
    {
        Console.WriteLine();
    }
}