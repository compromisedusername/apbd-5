using Tutorial4.Models;

namespace SimpleApi.Repositories;

public interface IAnimalsRepository
{
    IEnumerable<Animal> FetchAnimals();
    void AddAnimal(Animal animal);
    void RemoveAnimal(Animal animal);
}