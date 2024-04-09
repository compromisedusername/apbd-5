using Tutorial4.Models;

namespace SimpleApi.Services;

public interface IAnimalsService
{
    IEnumerable<Animal> GetAnimals();
    void CreateAnimal(Animal newAnimal);
    void RemoveAnimal(Animal animalToDelete);
    void EditAnimal(int idAnimalToEdit, Animal newAnimal);
    Animal GetAnimal(int idAnimal);
}