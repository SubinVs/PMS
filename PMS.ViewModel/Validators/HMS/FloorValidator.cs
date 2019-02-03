using FluentValidation;
using PMS.ViewModel.HMS;

namespace PMS.ViewModel.Validators.HMS
{
    public class FloorValidator:AbstractValidator<FloorViewModel>
    {
        public FloorValidator()
        {
            RuleFor(n => n.FloorName).NotEmpty().WithMessage("Required");
        }
    }
}
