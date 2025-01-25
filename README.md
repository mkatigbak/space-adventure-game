# Space Adventure Game

## Overview
This documentation describes a simple text-based spaceship simulation game implemented in C#. The game allows users to interact with spaceships, planets, and cargo, simulating space travel and cargo management.

## Classes
1. Cargo
* Represents a cargo item that can be loaded onto a spaceship or found on a planet.
* Attributes:
  - ```string Name```: The name of the cargo item.
  - ```int Weight```: The weight of the cargo item.
* Constructor:
  - ```Cargo(string name, int weight)```: Initializes a new instance of the Cargo class with the specified name and weight.
2. Planet
* Represents a planet in the game, which can have available cargo and a refueling station.
* Attributes:
  - ```string Name```: The name of the planet.
  - ```List<Cargo> AvailableCargo```: A list of Cargo objects available on the planet.
  - ```bool RefuelingStation```: Indicates whether the planet has a refueling station.
* Constructor:
  - ```Planet(string name, List<Cargo> availableCargo, bool refuelingStation)```: Initializes a new instance of the Planet class with the specified name, available cargo, and refueling station status.
* Methods:
  - ```void AddCargo(Cargo item)```: Adds a cargo item to the planet's available cargo.
  - ```void RemoveCargo(Cargo item)```: Removes a cargo item from the planet's available cargo.
  - ```void RefuelSpaceship(Spaceship spaceship, int amount)```: Refuels the specified spaceship if the planet has a refueling station.
3. Spaceship
* Represents a spaceship that can travel between planets, carry cargo, and be refueled.
* Attributes:
  - ```string Name```: The name of the spaceship.
  - ```int Fuel```: The current fuel level of the spaceship.
  - ```int CargoCapacity```: The maximum cargo capacity of the spaceship.
  - ```List<Cargo> Cargo```: A list of Cargo objects currently loaded onto the spaceship.
  - ```Planet Location```: The current location of the spaceship (a Planet object).
* Constructor:
  - ```Spaceship(string name, int fuel, int cargoCapacity, Planet location)```: Initializes a new instance of the Spaceship class with the specified name, fuel level, cargo capacity, and initial location.
* Methods:
  - ```void Fly(Planet destination)```: Flies the spaceship to the specified destination planet, decreasing fuel by 1 for each flight.
  - ```void Refuel(int amount)```: Refuels the spaceship by the specified amount.
  - ```void LoadCargo(Cargo item)```: Loads a cargo item onto the spaceship if there is enough capacity.
  - ```void UnloadCargo(Cargo item)```: Unloads a cargo item from the spaceship.

## Main Program
### Program Flow
The main program provides a text-based interface for user interaction. The user can perform the following actions:
1. ```List available spaceships```: Displays the names of all available spaceships.
2. ```Choose a spaceship```: Allows the user to select a spaceship.
3. ```List planets```: Displays the names of all available planets.
4. ```Choose a destination planet```: Allows the user to select a destination planet.
5. ```List available cargo on a planet```: Displays the cargo available on the current planet.
6. ```Load cargo onto the spaceship```: Prompts the user to load a specified cargo item onto the spaceship.
7. ```Unload cargo from the spaceship```: Prompts the user to unload a specified cargo item from the spaceship.
8. ```Refuel the spaceship```: Prompts the user to enter an amount to refuel the spaceship.
9. ```Fly the spaceship to the chosen destination```: Flies the spaceship to the selected destination planet.
10. ```Exit```: Exits the program.

## Error Handling
The program includes basic error handling to ensure valid user input, such as checking for valid cargo names, planet names, and refueling amounts.
### Example Usage
1. Run the program in a C# environment.
2. Follow the prompts to interact with the game.
3. Perform various actions such as loading cargo, flying to different planets, and managing resources.

## Conclusion
This documentation provides a comprehensive overview of the spaceship simulation game implemented in C#. The game can be expanded with additional features, improved error handling, and enhanced user interaction to create a more engaging experience.

## Note
This program is still a work in progress. Features might not work as expected.
* ```List available spaceships``` implemented.
* ```Choose a spaceship``` implemented.
* ```List planets``` implemented.
* ```Choose a destination planet``` implemented.
* ```Exit``` implemented.
