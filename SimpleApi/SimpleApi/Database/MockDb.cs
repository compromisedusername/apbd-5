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

    public static IEnumerable<Visit> readVisits()
    {
        return Visits;
    }
}