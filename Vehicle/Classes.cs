namespace Vehicle;

// DETTE FIL INDEHOLDER 3 KLASSER, DER ALLE HAR EN DRIVE METODE
// KUNNE MAN LAVE NOGLE ÆNDRINGER HER FOR AT MINDSKE KODEDUPLIKERING?

public class Car
{
    public string Brand { get; set; }
    public int MaxSpeed { get; set; }
    public void Drive()
    {
        Console.WriteLine($"Driving car of brand: {Brand}. Max speed is {MaxSpeed}");
    }
}

public class Truck
{
    public string Brand { get; set; }
    public int MaxSpeed { get; set; }
    public void Drive()
    {
        Console.WriteLine($"Driving truck of brand: {Brand}. Max speed is {MaxSpeed}");
    }
}

public class Bike
{
    public string Brand { get; set; }
    public int MaxSpeed { get; set; }
    public void Drive()
    {
        Console.WriteLine($"Driving bike of brand: {Brand}. Max speed is {MaxSpeed}");
    }
}