using Tutorial4.Models;

namespace SimpleApi.Repositories;

public interface IAnimalsRepository
{
    IEnumerable<Animal> FetchAnimals();
}