using Tutorial4.Models;

namespace SimpleApi.Repositories;

public interface IVisitRepository
{
    IEnumerable<Visit> FetchVisits();
}