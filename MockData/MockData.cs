public static class MockData
{
    public static List<Account> AccountMockDataList = new List<Account>();
    public static List<PetHelper> PetHelperMockDataList = new List<PetHelper>(){
        new(){Id=1, UserId=1, Image="asd", Date=new DateTime(2015,05,26), Latitude="10", Longtitude="50", Description="açıklama1"},
        new(){Id=2, UserId=2, Image="qwe", Date=new DateTime(2016,06,25), Latitude="15", Longtitude="55", Description="açıklama2"},
        new(){Id=3, UserId=2, Image="zxc", Date=new DateTime(2017,07,24), Latitude="20", Longtitude="60", Description="açıklama3"},
        new(){Id=4, UserId=3, Image="rty", Date=new DateTime(2018,08,23), Latitude="25", Longtitude="65", Description="açıklama4"},
        new(){Id=5, UserId=3, Image="fgh", Date=new DateTime(2019,09,22), Latitude="30", Longtitude="70", Description="açıklama5"}
    };

    public static List<Product> ProductMockDataList = new List<Product>()
    {
        new Product {
            ID = 1,
            Name = "product1", 
            Description = "Detail1",
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