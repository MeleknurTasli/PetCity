
public class SupplierDTO
{
    public string? Name { get; set; }
    public Account? Account { get; set; }
    public Address? Address { get; set; }
    public ICollection<Brand>? Brand { get; set; }
    public double Rating { get; set; }
    public bool IsVisibility { get; set; }


    public SupplierDTO()
    {

    }

    public SupplierDTO(Supplier supplier)
    {
        if (supplier != null)
        {
            this.Name = supplier.Name;
            this.Account = supplier.Account;
            this.Address = supplier.Address;
            this.Brand = supplier.Brand;
            this.Rating = supplier.Rating;
            this.IsVisibility = supplier.IsVisibility;
        }
    }

}