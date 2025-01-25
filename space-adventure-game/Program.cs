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
    public void Refuel(int amount)
    {
        Fuel += amount;
        Console.WriteLine($"{Name} refueled by {amount} units.");
    }
    public void LoadCargo(Cargo item)
    {
        if (Cargo.Count < CargoCapacity)
        {
            Cargo.Add(item);
            Console.WriteLine($"{item.Name} loaded onto {Name}.");
        }
        else
        {
            Console.WriteLine($"{Name} cannot load more cargo.");
        }
    }
    public void UnloadCargo(Cargo item)
    {
        if (Cargo.Contains(item))
        {
            Cargo.Remove(item);
            Console.WriteLine($"{item.Name} unloaded from {Name}.");
        }
        else
        {
            Console.WriteLine($"{item.Name} is not on {Name}.");
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
        // Cargo objects
        var food = new Cargo("Food", 10);
        var fuel = new Cargo("Fuel", 5);
        var medicalSupplies = new Cargo("Medical Supplies", 3);

        // Planet objects
        var earth = new Planet("Earth", new List<Cargo> { food, fuel }, true);
        var mars = new Planet("Mars", new List<Cargo> { medicalSupplies }, false);
        var jupiter = new Planet("Jupiter", new List<Cargo>(), true);

        // Spaceship objects
        var explorer = new SpaceShip("Explorer", 5, 2, earth);
        var voyager = new SpaceShip("Voyager", 3, 3, mars);
        var pioneer = new SpaceShip("Pioneer", 4, 1, jupiter);

        // List of Spaceships
        var spaceships = new List<SpaceShip> { explorer, voyager, pioneer };
        // List of Planets
        var planets = new List<Planet> { earth, mars, jupiter };

        while (true)
        {
            Console.WriteLine("\nSpace Adventure Game");
            Console.WriteLine("1. List available spaceships");
            Console.WriteLine("2. Choose a spaceship");
            Console.WriteLine("3. List planets");
            Console.WriteLine("4. Choose a destination planet");
            Console.WriteLine("5. List available cargo on a planet");
            Console.WriteLine("6. Load cargo onto the spaceship");
            Console.WriteLine("7. Unload cargo from the spaceship");
            Console.WriteLine("8. Refuel the spaceship");
            Console.WriteLine("9. Fly the spaceship to the chosen destination");
            Console.WriteLine("10. Exit");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid Input. Please select an option from 1 to 10.");
                continue;
            }
            
            switch (choice)
            {
                case 1:
                    foreach (var spaceship in spaceships)
                    {
                        Console.Write($"{spaceship.Name} ");
                    }
                    Console.WriteLine();
                    break;
                case 2:
                    Console.Write("Enter the spaceship name: ");
                    string? spaceshipChoice = Console.ReadLine();
                    if (spaceships.Any(s => s.Name.ToLower() == spaceshipChoice?.ToLower()))
                    {
                        Console.WriteLine($"You've selected spaceship {char.ToUpper(spaceshipChoice[0]) + spaceshipChoice.Substring(1)}.");
                    }
                    else
                    {
                        Console.WriteLine($"{spaceshipChoice} doesn't exist.");
                    }
                    break;
                case 3:
                    foreach (var planet in planets)
                    {
                        Console.Write($"{planet.Name} ");
                    }
                    Console.WriteLine();
                    break;
                case 4:
                    Console.Write("Enter the planet destination: ");
                    string? planetChoice = Console.ReadLine();
                    if (planets.Any(p => p.Name.ToLower() == planetChoice?.ToLower()))
                    {
                        Console.WriteLine($"You've selected planet {char.ToUpper(planetChoice[0]) + planetChoice.Substring(1)} as your destination.");
                    }
                    else
                    {
                        Console.WriteLine($"Planet {planetChoice} does not exist.");
                    }
                    break;
                case 5:
                    Console.WriteLine("5 works");
                    break;
                case 6:
                    Console.WriteLine("6 works");
                    break;
                case 7:
                    Console.WriteLine("7 works");
                    break;
                case 8:
                    Console.WriteLine("8 works");
                    break;
                case 9:
                    Console.WriteLine("9 works");
                    break;
                case 10: 
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select an option from 1 to 10.");
                    break;
            }
        }
    }
}