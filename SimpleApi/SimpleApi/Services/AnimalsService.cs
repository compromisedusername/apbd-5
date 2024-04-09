using SimpleApi.Repositories;
using Tutorial4.Models;

namespace SimpleApi.Services;

public class AnimalsService : IAnimalsService
{
    private readonly IAnimalsRepository _animals;

    public AnimalsService(IAnimalsRepository animalsRepository)
    {
        _animals = animalsRepository;
    }

    public IEnumerable<Animal> GetAnimals()
    {
        throw new NotImplementedException();
    }

    public void CreateAnimal(Animal newAnimal)
    {
        throw new NotImplementedException();
    }

    public Animal RemoveAnimal(Animal animalToDelete)
    {
        throw new NotImplementedException();
    }

    public void EditAnimal(Animal animalToEdit)
    {
        throw new NotImplementedException();
    }

    public Animal GetAnimal(int idAnimal)
    {
        throw new NotImplementedException();
    }
}