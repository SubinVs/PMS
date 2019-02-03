using FluentValidation;
using PMS.ViewModel.HMS;

namespace PMS.ViewModel.Validators.HMS
{
    public class RoomValidator : AbstractValidator<RoomViewModel>
    {
        public RoomValidator()
        {
            RuleFor(n => n.RoomNo).NotEmpty().WithMessage("Required");
            RuleFor(n => n.RoomNo).MaximumLength(5).WithMessage("Length not greater than 5");
            RuleFor(n => n.RoomTypeId).NotNull().WithMessage("Required, Select RoomType");
            RuleFor(n => n.FloorId).NotNull().WithMessage("Required, Select Floor");
        }
    }
}
