using Tutorial4.Models;

namespace SimpleApi.Database;

public class StaticData
{
    public static readonly List<Animal> Animals =
    [
        new Animal(1, "bartek", "dog", 120, "black"),
        new Animal(2, "pablo", "panda", 890, "red"),
        new Animal(3, "dawid", "tiger", 195, "orange"),
        new Animal(4, "poldek", "snake", 2137, "yellow")
    ];
    
    public static readonly List<Visit> Visits =
    [
        new Visit(DateTime.Now.AddDays(2), 1, "Brain transplantation", 10),
        new Visit((DateTime.Now.AddDays(1).AddHours(1)), 1, "Full cyborgization", 32),
        new Visit(DateTime.Now.AddDays(3), 1, "Leg swap", 2),
        new Visit(DateTime.Now.AddHours(2), 1, "Root canal treatment", 18),
        new Visit(DateTime.Now.AddDays(1), 1, "Brain chipping ", 1)
    ];
    
}