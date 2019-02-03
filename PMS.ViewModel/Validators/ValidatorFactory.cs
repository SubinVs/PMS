using FluentValidation;
using PMS.ViewModel.HMS;
using PMS.ViewModel.Validators.HMS;
using System;
using System.Collections.Generic;

namespace PMS.ViewModel.Validators
{
    public class ValidatorFactory : ValidatorFactoryBase
    {
        private static Dictionary<Type, IValidator> validators = new Dictionary<Type, IValidator>();

        static ValidatorFactory()
        {
            validators.Add(typeof(IValidator<FloorViewModel>), new FloorValidator());
            validators.Add(typeof(IValidator<RoomViewModel>), new RoomValidator());
        }
        public override IValidator CreateInstance(Type validatorType)
        {
            IValidator validator;
            if(validators.TryGetValue(validatorType, out validator))
            {
                return validator;
            }
            return validator;
        }
    }
}
