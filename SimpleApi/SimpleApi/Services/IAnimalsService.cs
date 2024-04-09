using Tutorial4.Models;

namespace SimpleApi.Services;

public interface IAnimalsService
{
    IEnumerable<Animal> GetAnimals();
    void CreateAnimal(Animal newAnimal);
    Animal RemoveAnimal(Animal animalToDelete);
    void EditAnimal(Animal animalToEdit);
    Animal GetAnimal(int idAnimal);
}