using Tutorial4.Models;

namespace SimpleApi.Database;

public class MockDb
{
    private static List<Animal> Animals { get; set; }
    private static List<Visit> Visits { get; set; }

    public MockDb()
    {
        Animals = StaticData.Animals;
        Visits = StaticData.Visits;
    }

    public static IEnumerable<Animal> readAnimals()
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

    public static IEnumerable<Visit> readVisits()
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