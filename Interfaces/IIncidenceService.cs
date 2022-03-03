public interface IIncidenceService
{
    Task<IEnumerable<IncidenceDTO>> GetAllIncidences();
    Task<IEnumerable<IncidenceDTO>> GetIncidencesByDistrictName(string districtName);
    Task<IEnumerable<IncidenceDTO>> GetAllIncidencesByUserName(string username);
    Task<IEnumerable<IncidenceDTO>> GetIncidencesByDate(DateTime FirstDate, DateTime LastDate);
    Task<IncidenceDTO> GetIncidencesById(int Id);
    Task<IEnumerable<IncidenceDTO>> GetIncidencesByName(string name);
    Task ChangeIncidenceVisibilityById(int Id);
    Task<IncidenceDTO> CreateIncidence(IncidenceDTO incidence);
    Task<IncidenceDTO> ChangeIncidence(Incidence incidence);  
}