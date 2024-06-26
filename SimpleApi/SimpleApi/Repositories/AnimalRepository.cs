using System.Collections;
using SimpleApi.Database;
using Tutorial4.Models;

namespace SimpleApi.Repositories;

public class AnimalRepository : IAnimalsRepository

{

    private static readonly List<Animal> _animals = MockDb.ReadAnimals();
    
    public IEnumerable<Animal> FetchAnimals()
    {
        return _animals;
    }

    public void AddAnimal(Animal animal)
    {
        MockDb.AddAnimal(animal);
    }

    

    public void RemoveAnimal(Animal animal)
    {
        MockDb.DeleteAnimal(animal.Id);
                
    }
}