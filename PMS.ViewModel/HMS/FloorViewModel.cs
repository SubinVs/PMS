using FluentValidation.Attributes;
using PMS.Entity;
using PMS.ViewModel.Validators.HMS;

namespace PMS.ViewModel.HMS
{
    [Validator(typeof(FloorValidator))]
    public class FloorViewModel:HMS_Floor
    {
    }
}
