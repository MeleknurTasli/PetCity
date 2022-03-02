public interface IIncidenceService
{
    Task<IEnumerable<Incidence>> GetAllIncidences();
    Task<IEnumerable<Incidence>> GetIncidencesByRegionName(string regionName);
    Task<IEnumerable<Incidence>> GetAllIncidencesByUserName(string username);
    Task<IEnumerable<Incidence>> GetIncidencesByDate(DateTime FirstDate, DateTime LastDate);
    Task<Incidence> GetIncidencesById(int Id);
    Task<IEnumerable<Incidence>> GetIncidencesByName(string name);
    //Task ChangeIncidenceVisibility(Incidence incidence);
    Task<bool> ChangeIncidenceVisibilityById(int Id);
    Task<Incidence> CreateIncidence(Incidence incidence);
    Task<Incidence> ChangeIncidence(int Id, Incidence incidence);  
}