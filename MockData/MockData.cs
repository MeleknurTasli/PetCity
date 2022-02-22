public static class MockData
{
    public static List<Account> AccountMockDataList = new List<Account>();
    public static List<PetHelper> PetHelperMockDataList = new List<PetHelper>();
    public static List<Product> ProductMockDataList = new List<Product>()
    {
        new Product {
            ID = 1,
            Name = "product1", 
            Detail = "Detail1",
            Price = 12.4m,
            Stock = 15,
            SupplierId = 3,
            Brand = "Brand1",
            CategoryId = 1
        }
    };
    
    public static List<User> UserMockDataList = new List<User>();
    public static List<Pet> PetMockDataList = new List<Pet>();

}