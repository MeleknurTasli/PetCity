
public class SupplierDTO
{
    public string Name { get; set; }
    public string Email { get; set; }
    public double Rating { get; set; }
    public bool IsVisibility { get; set; }
    public List<SupplierAccountDTO>? Account { get; set; }
    public List<SupplierBrandDTO>? Brand { get; set; }
    public Address? Address { get; set; }





    public SupplierDTO()
    {

    }

    public SupplierDTO(Supplier supplier)
    {
        if (supplier != null)
        {
            this.Name = supplier.Name;
            this.Email = supplier.Email;
            if (supplier.Account != null)
            {
                this.Account = new List<SupplierAccountDTO>();
                foreach (Account item in supplier.Account)
                {
                    this.Account.Add(new SupplierAccountDTO(item.Email, item.IsBlocked, item.Visibility));
                }
            }
            else{
                this.Account = new List<SupplierAccountDTO>();
                this.Account.Add(new SupplierAccountDTO());
            }           
            this.Address = supplier.Address;
            
            if( supplier.Brand != null)
            {
                 this.Brand = new List<SupplierBrandDTO>();
                foreach (Brand item in supplier.Brand)
                {
                    this.Brand.Add(new SupplierBrandDTO(item.Name));
                }
            }else{
                this.Brand =new List<SupplierBrandDTO>();
                this.Brand.Add(new SupplierBrandDTO());
            }
            
            this.Rating = supplier.Rating;
            this.IsVisibility = supplier.IsVisibility;
        }
    }


    public SupplierDTO(string name, Account account, Address address, ICollection<Brand> brand, double rating, bool IsVisibility)
    {
        /*
        this.Name = name;
        this.Account = account;
        this.Address = address;
        this.Brand = brand;
        this.Rating = rating;
        this.IsVisibility = IsVisibility;*/

    }

}