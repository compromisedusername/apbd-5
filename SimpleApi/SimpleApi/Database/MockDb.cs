using Tutorial4.Models;

namespace SimpleApi.Database;

public class MockDb
{
    public List<Animal> Animals { get; set; } = new List<Animal>();

    public MockDb()
    {
        Animals.Add(new Animal());
        Animals.Add(new Animal());
        Animals.Add(new Animal());
        Animals.Add(new Animal());
    }
}