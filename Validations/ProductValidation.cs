using FluentValidation;

public class ProductValidaiton : AbstractValidator<Product> {
    public ProductValidaiton() {
        RuleFor(p => p.Name).NotEmpty().Length(2, 50);
        RuleFor(p => p.Description).MaximumLength(1024);
        RuleFor(p => p.Brand).NotEmpty().Length(2, 50);
        RuleFor(p => p.Brand).NotEmpty().MaximumLength(50);
        RuleFor(p => p.Price).NotEmpty().GreaterThan(0);
    } 
}