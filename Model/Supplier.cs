
public class Supplier
{ 
    private double _rating;

    public int Id { get; set; }
    public string?  Name { get; set; }
    // Account ve Address propları eklenicek.
    public virtual ICollection<Brand>? Brand { get; set; }
    public double Rating 
    { 
        get{
            return _rating;
        } set{
            if(value >=0 && value<=10) _rating = value;
            else if(value<0) _rating = 0;
            else _rating = 10;
        } 
    }
}