using Tutorial4.Models;

namespace SimpleApi.Services;

public interface IVisitsService
{
    public IEnumerable<Visit> GetVisits(int animalId);
    public void CreateVisits(Visit visit);
}