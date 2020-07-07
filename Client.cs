using System;
public class Client
{
    public static void Main()
    {
        Car ciaz=new Car();
        Engine engine= new PetrolEngine();
        Console.WriteLine(engine.Start());
        Console.WriteLine(engine.engineType());
        Console.WriteLine(ciaz.Start());

        // Car tataNexon=new Car();
        // engine= new DieselEngine();
        // Console.WriteLine(engine.Start());
        // Console.WriteLine(engine.engineType());
        // Console.WriteLine(tataNexon.Start());

        // Car cheavyBeat=new Car();
        // engine= new DieselEngine();
        // Console.WriteLine(engine.Start());
        // Console.WriteLine(engine.engineType());
        // Console.WriteLine(cheavyBeat.Start());

    }
}