public class IncidenceRepository: IIncidenceRepository
{
    PetCityContext _petCityContext;

    public IncidenceRepository(PetCityContext petCityContext)
    {
        _petCityContext=petCityContext;
    }

    public async Task<Incidence> ChangeIncidence(int Id, Incidence incidence)
    {
        throw new NotImplementedException();
    }

    public async Task ChangeIncidenceVisibility(Incidence incidence)
    {
        throw new NotImplementedException();
    }

    public async Task ChangeIncidenceVisibilityById(int Id)
    {
        throw new NotImplementedException();
    }

    public async Task<Incidence> CreateIncidence(Incidence incidence)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Incidence>> GetAllIncidences()
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Incidence>> GetAllIncidencesByUser(User user)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Incidence>> GetIncidencesByDate(DateTime date)
    {
        throw new NotImplementedException();
    }

    public async Task<Incidence> GetIncidencesById(int Id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Incidence>> GetIncidencesByName(string name)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Incidence>> GetIncidencesByRegion(Region region)
    {
        throw new NotImplementedException();
    }
}