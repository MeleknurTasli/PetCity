using FluentValidation;
public class AccountValidator:AbstractValidator<Account>
{
   public AccountValidator()
   {      
      RuleFor(acc => acc.Email).NotEmpty();
      RuleFor(acc => acc.Password).NotEmpty();
   }
}