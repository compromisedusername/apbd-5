using SimpleApi.Repositories;
using Tutorial4.Models;

namespace SimpleApi.Services;

public class AnimalsService : IAnimalsService
{
    private readonly IAnimalsRepository _animalsRepository;

    public AnimalsService(IAnimalsRepository animalsRepository)
    {
        _animalsRepository = animalsRepository;
        
    }

    public IEnumerable<Animal> GetAnimals()
    {
        return _animalsRepository.FetchAnimals();
    }

    public void CreateAnimal(Animal newAnimal)
    {
        _animalsRepository.AddAnimal(newAnimal);
    }

    public void RemoveAnimal(Animal animalToDelete)
    {
        _animalsRepository.RemoveAnimal(animalToDelete);
    }

    public void EditAnimal(int idAnimalToEdit, Animal newAnimal)
    {
        _animalsRepository.RemoveAnimal(GetAnimal(idAnimalToEdit));
        _animalsRepository.AddAnimal(newAnimal);
    }


    public Animal GetAnimal(int idAnimal)
    {
        foreach (Animal animal in _animalsRepository.FetchAnimals())
        {
            if (animal.Id.Equals(idAnimal))
            {
                return animal;
            }
        }
        return null;
    }
}