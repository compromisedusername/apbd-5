using Tutorial4.Models;

namespace SimpleApi.Database;

public class MockDb
{
   
    public static  List<Visit> Visits =
    [
        new Visit(1,DateTime.Now.AddDays(2), 1, "Brain transplantation", 10),
        new Visit(2,DateTime.Now.AddDays(1).AddHours(1), 2, "Full cyborgization", 32),
        new Visit(3,DateTime.Now.AddDays(3), 3, "Leg swap", 2),
        new Visit(4,DateTime.Now.AddHours(2), 4, "Root canal treatment", 18),
        new Visit(5,DateTime.Now.AddDays(1), 5, "Brain chipping ", 1),
        new Visit(6,DateTime.Now.AddDays(4), 1, "Full cyborgization", 1),
        new Visit(7,DateTime.Now.AddDays(9), 4, "Leg swap", 2),

    ];
    public static  List<Animal> Animals =
    [
        new Animal(1, "bartek", "dog", 120, "black"),
        new Animal(2, "pablo", "panda", 890, "red"),
        new Animal(3, "dawid", "tiger", 195, "orange"),
        new Animal(4, "poldek", "snake", 2137, "yellow")
    ];

    public static List<Animal> ReadAnimals()
    {
        return Animals;
    }

    public static void AddAnimal(Animal animal)
    {
        Animals.Add(animal);
    }

    public static void DeleteAnimal(int idAnimal)
    {
        foreach (var a in Animals)
        {
            if (a.Id.Equals(idAnimal))
            {
                Animals.Remove(a);
            }
        }
    }

    public static List<Visit> readVisits()
    {
        return Visits;
    }

    public static void AddVisit(Visit visit)
    {
        Visits.Add(visit);
    }

    public static void DeleteVisit(int idVisit)
    {
        foreach (var v in Visits)
        {
            if (v.idVisit.Equals(idVisit))
            {
                Visits.Remove(v);
                return;
            }
        }
        Console.WriteLine("Visit for id: "+idVisit +" doesnt exists.");
    }
}