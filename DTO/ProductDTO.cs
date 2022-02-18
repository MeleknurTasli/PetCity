public class ProductDTO{

    public static List<ProductDTO> staticList = new List<ProductDTO>();

    public int ID {get;set;}
    public string Name { get; set; }
    public string Detail { get; set; }
    public string Price { get; set; }
    public string Stock { get; set; }
    public string Supplier { get; set; }
    public string Brand { get; set; }
    public string Category { get; set; }

    public ProductDTO(int Id)
    {
        this.ID = Id;
    }


}