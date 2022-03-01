public interface ICompanyService {
    Task<Company> AddCompanyAsync(Company company);
    Task<Company> UpdateBrandAsync(int id, Company company);
    Task DeleteCompanyAsync(Company company);
    Task<List<Company>> GetAllCompanyAsync();
    Task<Brand> GetByCompanyIdAsync(int companyId);
    Task<Company> GetByCompanyNameAsync(string companyName);
}