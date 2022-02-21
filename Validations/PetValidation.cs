using FluentValidation;
public class PetValidator:AbstractValidator<Pet>
{
   public PetValidator()
   {      
      RuleFor(x => x.name).NotEmpty();
      RuleFor(x=>x.Family).NotEmpty();
      RuleFor(x=>x.Gender).NotEmpty();
   }
}