public interface IBrandRepository{
    Brand AddBrand(Brand brand);
    Brand UpdateBrand(int id, Brand brand);
    void DeleteBrand(Brand brand);
    List<Brand> GetAllBrand();
    Brand GetByBrandId(int brandId);
    List<Brand> GetAllBrandByName(string brandName);
    

}