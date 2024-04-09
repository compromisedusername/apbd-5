using SimpleApi.Database;
using Tutorial4.Models;

namespace SimpleApi.Repositories;

public class AnimalRepository : IAnimalsRepository

{

    private static readonly IEnumerable<Animal> _animals = MockDb.readAnimals();
    
    public IEnumerable<Animal> FetchAnimals()
    {
        throw new NotImplementedException();
    }
}