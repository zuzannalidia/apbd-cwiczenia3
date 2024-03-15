namespace cwiczenia3.interfaces;

public interface IContainer
{
    private int cargoWeight;
    public int CargoWeight { get; set}
    
    void unload()
    {
        throw new NotImplementedException();
    }

    void virtual load(int cargoWeight){
        throw new NotImplementedException();
    }
}