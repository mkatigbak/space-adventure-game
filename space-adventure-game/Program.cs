public class SpaceShip
{
    public string Name { get; set; }
    public int Fuel { get; set; }
    public int CargoCapacity { get; set; }
    public List<Cargo> Cargo { get; set; }
    public Planet Location { get; set; }

    public SpaceShip(string name, int fuel, int cargoCapacity, Planet location)
    {
        Name = name;
        Fuel = fuel;
        CargoCapacity = cargoCapacity;
        Cargo = new List<Cargo>();
        Location = location;
    }

    public void Fly(Planet destination)
    {
        if (Fuel > 0)
        {
            Location = destination;
            Fuel -= 1;
            Console.WriteLine($"{Name} flew to {destination.Name}.");
        }
        else
        {
            Console.WriteLine($"{Name} does not have enough fuel to fly.");
        }
    }
}

public class Planet
{
    public string Name { get; set; }
    public List<Cargo> AvailableCargo { get; set; }
    public bool RefuelingStation { get; set; }

    public Planet(string name, List<Cargo> availableCargo, bool refuelingStation)
    {
        Name = name;
        AvailableCargo = availableCargo;
        RefuelingStation = refuelingStation;
    }

    public void AddCargo(Cargo item)
    {
        AvailableCargo.Add(item);
    }
    public void RemoveCargo(Cargo item)
    {
        AvailableCargo.Remove(item);
    }
    public void RefuelSpaceship(SpaceShip spaceship, int amount)
    {
        if (RefuelingStation)
        {
            spaceship.Refuel(amount);
        }
        else
        {
            Console.WriteLine($"{Name} does not have a refueling station.");
        }
    }
}

public class Cargo
{
    public string Name { get; set; }
    public int Weight { get; set; }

    public Cargo(string name, int weight)
    {
        Name = name;
        Weight = weight;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        
    }
}