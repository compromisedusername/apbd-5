using SimpleApi.Database;
using Tutorial4.Models;

namespace SimpleApi.Repositories;

public class VisitsRepository : IVisitsRepository
{
    private static readonly IEnumerable<Visit> _visits = MockDb.readVisits();
    
    public IEnumerable<Visit> FetchVisits()
    {
        return _visits;
    }

    public void AddVisit(Visit visit)
    {
        MockDb.AddVisit(visit);
    }
}