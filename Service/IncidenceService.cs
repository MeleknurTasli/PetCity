using Microsoft.AspNetCore.Mvc;
public class IncidenceService : ControllerBase, IIncidenceService
{
    private readonly IIncidenceService _IncidenceService;
    public IncidenceService(IIncidenceService IncidenceService)
    {
         _IncidenceService = IncidenceService;
    }

    public IncidenceService(){}

    public Task<IEnumerable<Incidence>> GetAllIncidences()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Incidence>> GetIncidencesByRegionName(string regionName)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Incidence>> GetAllIncidencesByUserName(string username)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Incidence>> GetIncidencesByDate(DateTime FirstDate, DateTime LastDate)
    {
        throw new NotImplementedException();
    }

    public Task<Incidence> GetIncidencesById(int Id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Incidence>> GetIncidencesByName(string name)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ChangeIncidenceVisibilityById(int Id)
    {
        throw new NotImplementedException();
    }

    public Task<Incidence> CreateIncidence(Incidence incidence)
    {
        throw new NotImplementedException();
    }

    public Task<Incidence> ChangeIncidence(int Id, Incidence incidence)
    {
        throw new NotImplementedException();
    }
}