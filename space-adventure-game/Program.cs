﻿public class SpaceShip
{
    
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