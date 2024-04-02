using System;
using System.Collections.Generic;

class Planet
{
    public string Name { get; set; }
    public int OrderNumber { get; set; }
    public int EquatorLength { get; set; }
    public Planet PreviousPlanet { get; set; }
}

class PlanetCatalog
{
    private List<Planet> planets;
    private int getPlanetCallsCounter;

    public PlanetCatalog()
    {
        planets = new List<Planet>
{
new Planet { Name = "Венера", OrderNumber = 1, EquatorLength = 6752 },
new Planet { Name = "Земля", OrderNumber = 2, EquatorLength = 6378 },
new Planet { Name = "Марс", OrderNumber = 3, EquatorLength = 6794 }
};

        getPlanetCallsCounter = 0;
    }

    public (string OrderNumber, string EquatorLength, string Error) GetPlanet(string planetName)
    {
        getPlanetCallsCounter++;

        if (getPlanetCallsCounter % 3 == 0)
        {
            return ("", "", "Вы спрашиваете слишком часто");
        }

        var planet = planets.Find(p => p.Name == planetName);

        if (planet == null)
        {
            return ("", "", "Не удалось найти планету");
        }

        return (planet.OrderNumber.ToString(), planet.EquatorLength.ToString(), "");
    }
}

class Program
{
    static void Main()
    {
        var solarSystem = new PlanetCatalog();

        Console.WriteLine("Получение планеты Земля:");
        var earthInfo = solarSystem.GetPlanet("Земля");
        Console.WriteLine($"Порядковый номер: {earthInfo.OrderNumber}, Длина экватора: {earthInfo.EquatorLength} км, Ошибка: {earthInfo.Error}");

        Console.WriteLine("\nПолучение планеты Лимония (если планета не найдена):");
        var limoniaInfo = solarSystem.GetPlanet("Лимония");
        Console.WriteLine($"Порядковый номер: {limoniaInfo.OrderNumber}, Длина экватора: {limoniaInfo.EquatorLength} км, Ошибка: {limoniaInfo.Error}");

        Console.WriteLine("\nПолучение планеты Марс (если спрашиваем слишком часто):");
        var marsInfo = solarSystem.GetPlanet("Марс");
        Console.WriteLine($"Порядковый номер: {marsInfo.OrderNumber}, Длина экватора: {marsInfo.EquatorLength} км, Ошибка: {marsInfo.Error}");
    }
}