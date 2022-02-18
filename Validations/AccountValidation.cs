using FluentValidation;
public class AccountValidator:AbstractValidator<Account>
{
   public AccountValidator()
   {
      RuleFor(acc => acc.Email).NotNull();
      RuleFor(acc => acc.Password).NotNull();
   }
}