
public class IncidenceRepository : IIncidenceRepository
{
    private readonly PetCityContext _petCityContext;

    public IncidenceRepository(PetCityContext petCityContext)
    {
        _petCityContext = petCityContext;
    }

    public async Task<Incidence> ChangeIncidence(int Id, Incidence incidence)
    {
        if (Id != incidence.Id)
        {
            return null;
        }

        _petCityContext.Entry(incidence).State = EntityState.Modified;

        try
        {
            await _petCityContext.SaveChangesAsync();
        }
        catch (Exception e)
        { 
            throw;
        }
        return incidence;
    }

    public async Task ChangeIncidenceVisibility(Incidence incidence)
    {
    
    }

    public async Task ChangeIncidenceVisibilityById(int Id)
    {

    }

    public async Task<Incidence> CreateIncidence(Incidence incidence)
    {
        await _petCityContext.Incidences.AddAsync(incidence);
        await _petCityContext.SaveChangesAsync();
        return incidence;
    }

    public async Task<IEnumerable<Incidence>> GetAllIncidences()
    {
        return await _petCityContext.Incidences.ToListAsync();
    }

    public async Task<IEnumerable<Incidence>> GetAllIncidencesByUserName(string UserName)
    {
        return await _petCityContext.Incidences.Where(p=> p.User.Name == UserName).ToListAsync();
    }
        
    public async Task<IEnumerable<Incidence>> GetIncidencesByDate(DateTime firstDate, DateTime lastDate)
    {
        var IncidencesByDate = from x in _petCityContext.Incidences 
                               where x.Date >= firstDate.Date
                               where x.Date <= lastDate.Date
                               select x;
        return await IncidencesByDate.ToListAsync();
    }

    public async Task<Incidence> GetIncidencesById(int Id)
    {
        return await _petCityContext.Incidences.Where(p=> p.Id == Id).FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<Incidence>> GetIncidencesByName(string name)
    {
         return await _petCityContext.Incidences.Where(p=> p.Name == name).ToListAsync();
    }

    //TODO
    public async Task<IEnumerable<Incidence>> GetIncidencesByRegionName(string regionName)
    {
       return await _petCityContext.Incidences.Where(p=> p.Region.Name == regionName).ToListAsync();
    }


    private bool IncidenceExists(int id)
    {
        return _petCityContext.Incidences.Any(e => e.Id == id);
    }

    public async Task<IEnumerable<Incidence>> GetAllIncidencesByUser(User user)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Incidence>> GetIncidencesByDate(DateTime date)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Incidence>> GetIncidencesByRegion(Region region)
    {
        throw new NotImplementedException();
    }
}