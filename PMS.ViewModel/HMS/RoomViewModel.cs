using FluentValidation.Attributes;
using PMS.Entity;
using PMS.ViewModel.Validators.HMS;
using System.Collections.Generic;

namespace PMS.ViewModel.HMS
{
    [Validator(typeof(RoomValidator))]
    public class RoomViewModel:HMS_Room
    {
        public IEnumerable<HMS_RoomType> RoomTypeList { get; set; }
        public IEnumerable<HMS_Floor> FloorList { get; set; }
    }
}
