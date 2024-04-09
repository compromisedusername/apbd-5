using Tutorial4.Models;

namespace SimpleApi.Repositories;

public interface IVisitsRepository
{
    IEnumerable<Visit> FetchVisits();
    void AddVisit(Visit visit);
}