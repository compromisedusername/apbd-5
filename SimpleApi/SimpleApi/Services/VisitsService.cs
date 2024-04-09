using SimpleApi.Repositories;
using Tutorial4.Models;

namespace SimpleApi.Services;

public class VisitsService : IVisitsService
{
    private readonly IVisitsRepository _visitsRepository;
    public VisitsService(IVisitsRepository visitsRepository)
    {
        _visitsRepository = visitsRepository;
    }


    public IEnumerable<Visit> GetVisits(int animalId)
    {
        List<Visit> visits = new List<Visit>();
        foreach (var visit in _visitsRepository.FetchVisits())
        {
            if (visit.animalId.Equals(animalId))
            {
                visits.Add(visit);
            }
        }
        return visits;
    }

    public void CreateVisits(Visit visit)
    {
        _visitsRepository.AddVisit(visit);
    }
}