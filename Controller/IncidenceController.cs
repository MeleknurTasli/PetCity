using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("[controller]")]
public class IncidenceController : ControllerBase
{
    private readonly IIncidenceService _incidenceService;
    public IncidenceController(IIncidenceService incidenceService)
    {
        _incidenceService = incidenceService;
    }

    [HttpGet]
    public async Task<IEnumerable<IncidenceDTO>> GetAllIncidences()
    {
        return await _incidenceService.GetAllIncidences();
    }

    [HttpGet("districtName")]
    public async Task<IEnumerable<IncidenceDTO>> GetIncidencesByDistrictName(string districtName)
    {
         return await _incidenceService.GetIncidencesByDistrictName(districtName);
    }

    [HttpGet("username")]
    public async Task<IEnumerable<IncidenceDTO>> GetAllIncidencesByUserName(string username)
    {
         return await _incidenceService.GetIncidencesByUserName(username);
    }

    [HttpGet("{FirstDate}/{LastDate}")]
    public async Task<IEnumerable<IncidenceDTO>> GetIncidencesByDate(DateTime FirstDate, DateTime LastDate)
    {
        return await _incidenceService.GetIncidencesByDate(FirstDate,LastDate);
    }

    [HttpGet("{Id}")]
    public async Task<IncidenceDTO> GetIncidencesById(int Id)
    {
        return await _incidenceService.GetIncidencesById(Id);
    }

    [HttpGet("name")]
    public async Task<IEnumerable<IncidenceDTO>> GetIncidencesByName(string name)
    {
        return await _incidenceService.GetIncidencesByName(name);
    }

    [HttpPut("{Id}")]
    public async Task ChangeIncidenceVisibilityById(int Id)
    {
        await _incidenceService.ChangeIncidenceVisibilityById(Id);
    }
 
    [HttpPost]
    public async Task<IncidenceDTO> CreateIncidence(IncidenceDTO incidence)
    {
        return await _incidenceService.CreateIncidence(incidence);
    }

    [HttpPut()]
    public async Task<IncidenceDTO> ChangeIncidence(Incidence incidence)
    {
        return await _incidenceService.ChangeIncidence(incidence);
    }

}