
public class IncidenceRepository : IIncidenceRepository
{
    private readonly PetCityContext _petCityContext;

    public IncidenceRepository(PetCityContext petCityContext)
    {
        _petCityContext = petCityContext;
    }
    
    public IncidenceRepository(){}

    public async Task<Incidence> ChangeIncidence(int Id, Incidence incidence)
    {
        if(Id != incidence.Id)
        {
            return null;
        }
         _petCityContext.Entry(incidence).State = EntityState.Modified;
         try
         {
            await _petCityContext.SaveChangesAsync();
         }
         catch(Exception ex)
         {
            throw;
         }
         
         return incidence;
    }

    //public async Task ChangeIncidenceVisibility(Incidence incidence)
    //{
        
    //}

    public async Task<bool> ChangeIncidenceVisibilityById(int Id)
    {
        var incidence = await _petCityContext.Incidences.FindAsync(Id); 
        if(incidence == null)
        {
            return false;
        }

        try
        {
            incidence.Visibility=false;
            await _petCityContext.SaveChangesAsync();
            return true;
        }
        catch (Exception e)
        { 
            throw;
        }
    }

    public async Task<Incidence> CreateIncidence(Incidence incidence)
    {
        await _petCityContext.Incidences.AddAsync(incidence);
        await _petCityContext.SaveChangesAsync();
        return incidence;
    }

    public async Task<IEnumerable<Incidence>> GetAllIncidences()
    {
        return await _petCityContext.Incidences.Where(p=>p.Visibility == true).ToListAsync();
    }

    public async Task<IEnumerable<Incidence>> GetAllIncidencesByUserName(string UserName)
    {
        return await _petCityContext.Incidences.Where(p=> p.User.Name == UserName).Where(p=>p.Visibility == true).OrderByDescending(p=>p.Date).ToListAsync();
    }
        
    public async Task<IEnumerable<Incidence>> GetIncidencesByDate(DateTime firstDate, DateTime lastDate)
    {
        var IncidencesByDate = from x in _petCityContext.Incidences 
                               where x.Date >= firstDate.Date
                               where x.Date <= lastDate.Date
                               where x.Visibility == true
                               select x;
        return await IncidencesByDate.ToListAsync();
    }

    public async Task<Incidence> GetIncidencesById(int Id)
    {
        return await _petCityContext.Incidences.Where(p=> p.Id == Id).Where(p=>p.Visibility == true).FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<Incidence>> GetIncidencesByName(string name)
    {
         return await _petCityContext.Incidences.Where(p=> p.Name == name).Where(p=>p.Visibility == true).OrderByDescending(p=>p.Date).ToListAsync();
    }

    //TODO
    public async Task<IEnumerable<Incidence>> GetIncidencesByRegionName(string regionName)
    {
       return await _petCityContext.Incidences.Where(p=> p.Region.Name == regionName).Where(p=>p.Visibility == true).OrderByDescending(p=>p.Date).ToListAsync();
    }

    private bool IncidenceExists(int id)
    {
        return _petCityContext.Incidences.Any(e => e.Id == id);
    }
}