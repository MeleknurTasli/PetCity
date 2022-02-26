    public interface ICompanyRepository{
    Company AddCompany(Company company);
    Company UpdateCompany(int id, Company company);
    void DeleteCompany(Company company);
    List<Company> GetAllCompany();
    Company GetByBrandtId(int companyId);
    List<Company> GetAllCompanyByName(string companyName);
    
    }