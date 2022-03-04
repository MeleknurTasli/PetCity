
public class IncidenceRepository : IIncidenceRepository
{
    private readonly PetCityContext _petCityContext;

    public IncidenceRepository(PetCityContext petCityContext)
    {
        _petCityContext = petCityContext;
    }
    
    public IncidenceRepository(){}

    public async Task<Incidence> ChangeIncidence(Incidence incidence)
    {
        if(incidence != null)
        {
            if(!IncidenceExists(incidence.Id))
            {
                 return null;
            }
             _petCityContext.Entry(incidence).State = EntityState.Modified;
             try
             {
                await  _petCityContext.SaveChangesAsync();
             }
             catch(Exception ex)
            {
                throw;
            }
            return incidence;
        }
        return null;
    }

    public async Task<Incidence> ChangeIncidenceVisibilityById(int Id)
    {
        var incidence =  await _petCityContext.Incidences.FindAsync(Id); 
        if(incidence == null)
        {
            return null;
        }

        try
        {
            incidence.Visibility=false;
            await _petCityContext.SaveChangesAsync();
            return incidence;
        }
        catch (Exception e)
        { 
            throw;
        }
    }
    
    //todo
    public async Task<Incidence> CreateIncidence(IncidenceDTO incidence)
    {
        var CreatedIncidence = new Incidence(incidence);
        await _petCityContext.Incidences.AddAsync(CreatedIncidence);
        await _petCityContext.SaveChangesAsync();
        return CreatedIncidence; 
    }

    public async Task<IEnumerable<Incidence>> GetAllIncidences()
    {
        //List<Incidence> Incidences = await _petCityContext.Incidences.ToListAsync();
        IEnumerable<Incidence> Incidences = await (from x in _petCityContext.Incidences  //.Include(i=>i.User).Include(i=>i.District)
                                                   join u in _petCityContext.Users on x.UserId equals u.Id
                                                   join d in _petCityContext.District on x.DistrictId equals d.DistrictId
                                                   select new Incidence()
                                                   {
                                                       Id = x.Id,
                                                       Name = x.Name,
                                                       Date = x.Date,
                                                       Image = x.Image,
                                                       Description = x.Description,
                                                       Visibility = x.Visibility,
                                                       UserId = x.UserId,
                                                       DistrictId = x.DistrictId,
                                                       District = new District()
                                                       {
                                                           DistrictId = x.District.DistrictId,
                                                           Name = x.District.Name
                                                       },
                                                       User = new User()
                                                       {
                                                           Id = null,
                                                           Name = x.User.Name
                                                       }
                                                   }).ToListAsync();
        return Incidences;
    }

    public async Task<IEnumerable<Incidence>> GetIncidencesByUserName(string UserName)
    {
        //IEnumerable<Incidence> Incidences =  await _petCityContext.Incidences.Where(p=> p.User.Name == UserName).Where(p=>p.Visibility == true).OrderByDescending(p=>p.Date).ToListAsync();
        IEnumerable<Incidence> Incidences = await (from x in _petCityContext.Incidences.Include(i=>i.User).Include(i=>i.District)
         where x.User.Name == UserName && x.Visibility == true orderby x.Date descending
         select new Incidence()
        {
             Id = x.Id,
             Name = x.Name,
             Date = x.Date,
             Image = x.Image,
             Description = x.Description,
             Visibility = x.Visibility,
             UserId = x.UserId,
             DistrictId = x.DistrictId,
             District = new District()
             {
                DistrictId = x.District.DistrictId,
                Name = x.District.Name
             },
             User = new User()
             {
                 Id = null,
                 Name = x.User.Name
             }
        }).ToListAsync();
        return Incidences;
    }
        
    public async Task<IEnumerable<Incidence>> GetIncidencesByDate(DateTime firstDate, DateTime lastDate)
    {
        var IncidencesByDate = from x in _petCityContext.Incidences 
                               where x.Date >= firstDate.Date
                               where x.Date <= lastDate.Date
                               where x.Visibility == true
                               select x;
         IEnumerable<Incidence> Incidences =  await IncidencesByDate.ToListAsync();
         return Incidences;
    }

    public async Task<Incidence> GetIncidencesById(int Id)
    {
        Incidence incidence =  await _petCityContext.Incidences.Where(p=> p.Id == Id).Where(p=>p.Visibility == true).FirstOrDefaultAsync();
        return incidence;
    }

    public async Task<IEnumerable<Incidence>> GetIncidencesByName(string name)
    {
        IEnumerable<Incidence> Incidences =  await _petCityContext.Incidences.Where(p=> p.Name == name).Where(p=>p.Visibility == true).OrderByDescending(p=>p.Date).ToListAsync();
        return Incidences;
    }

    //TODO
    public async Task<IEnumerable<Incidence>> GetIncidencesByDistrictName(string districtName)
    {
        IEnumerable<Incidence> Incidences =  await _petCityContext.Incidences.Where(p=> p.District.Name == districtName).Where(p=>p.Visibility == true).OrderByDescending(p=>p.Date).ToListAsync();
        return Incidences;
    }



    private bool IncidenceExists(int id)
    {
        return _petCityContext.Incidences.Any(e => e.Id == id);
    }

    
}