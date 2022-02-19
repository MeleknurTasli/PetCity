public class Supplier
{
    public string CompanyName { get; set; }
    public string Address { get; set; }
    public int SupplierID { get; set; }
    public int CategoryID { get; set; }
    public DateTime FoundationDate { get; set; }
    public int RatingOfCompany { get; set; }


    public Supplier()
    {
        
    }


     public Supplier(string companyName,string address,int supplierID,int categoryID,DateTime foundationDate,int ratingOfCompany)
    {
        this.CompanyName=companyName;
        this.Address=address;
        this.SupplierID=supplierID;
        this.CategoryID=categoryID;
        this.FoundationDate=foundationDate;
        this.RatingOfCompany=ratingOfCompany;
        
    }

}