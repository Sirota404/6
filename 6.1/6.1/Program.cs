using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        var solarSystem = new[]
        {
new {Name = "Меркурий", OrderNumber = 1, EquatorLength = 5936, PreviousPlanet = new {Name = "Меркурий"}, EqualToVenus = false},
new {Name = "Венера", OrderNumber = 2, EquatorLength = 12519, PreviousPlanet = new {Name = "Меркурий"}, EqualToVenus = true},
new {Name = "Земля", OrderNumber = 3, EquatorLength = 12742, PreviousPlanet = new {Name = "Венера"}, EqualToVenus = false},
new {Name = "Марс", OrderNumber = 4, EquatorLength = 6779, PreviousPlanet = new {Name = "Земля"}, EqualToVenus = false}
};

        foreach (var planet in solarSystem)
        {
            Console.WriteLine($"Планета: {planet.Name}, Порядковый номер от Солнца: {planet.OrderNumber}, Длина экватора: {planet.EquatorLength} км, Предыдущая планета: {planet.PreviousPlanet.Name}, Равна Венере: {(planet.EqualToVenus ? "да " : "нет ")}\n");
        }
    }
}