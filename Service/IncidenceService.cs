using Microsoft.AspNetCore.Mvc;
public class IncidenceService : ControllerBase, IIncidenceService
{
    private readonly IIncidenceService _IncidenceService;
    public IncidenceService(IIncidenceService IncidenceService)
    {
         _IncidenceService = IncidenceService;
    }

    public async Task<Incidence> ChangeIncidence(int Id, Incidence incidence)
    {
        
    }

    public async Task<bool> ChangeIncidenceVisibilityById(int Id)
    {
        
    }

    public async Task<Incidence> CreateIncidence(Incidence incidence)
    {
        
    }

    public async Task<IEnumerable<Incidence>> GetAllIncidences()
    {
        
    }

    public async Task<IEnumerable<Incidence>> GetAllIncidencesByUserName(string username)
    {
        
    }

    public async Task<IEnumerable<Incidence>> GetIncidencesByDate(DateTime FirstDate, DateTime LastDate)
    {
        
    }

    public async Task<Incidence> GetIncidencesById(int Id)
    {
        
    }

    public async Task<IEnumerable<Incidence>> GetIncidencesByName(string name)
    {
        
    }

    public async Task<IEnumerable<Incidence>> GetIncidencesByRegionName(string regionName)
    {
        
    }
}