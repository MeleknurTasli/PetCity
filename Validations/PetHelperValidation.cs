using FluentValidation;

public class PetHelperValidator : AbstractValidator<PetHelper>
{
    public PetHelperValidator()
    {
        RuleFor(pethelper => pethelper.Description).MaximumLength(1000);
        RuleFor(pethelper => pethelper.Latitude).NotEmpty();
        RuleFor(pethelper => pethelper.Longtitude).NotEmpty();
        RuleFor(pethelper => pethelper.UserId).NotEmpty();
    }
}