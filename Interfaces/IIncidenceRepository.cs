public interface IIncidenceRepository
{
    IEnumerable<Incidence> GetAllIncidences();
    IEnumerable<Incidence> GetIncidencesByRegion(Region region);
    IEnumerable<Incidence> GetAllIncidencesByUser(User user);
    IEnumerable<Incidence> GetIncidencesByDate(DateTime date);
    IEnumerable<Incidence> GetIncidencesById(int Id);
    IEnumerable<Incidence> GetIncidencesByName(string name);
    void ChangeIncidenceVisibility(Incidence incidence);
    void ChangeIncidenceVisibilityById(int Id);
    void CreateIncidence(Incidence incidence);
    void ChangeIncidence(int Id, Incidence incidence);   
}