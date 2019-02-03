using DataModel;
using System.Collections.Generic;
using System.Linq;

namespace ViewModel
{
    public class RoomModel:Room
    {
        public IEnumerable<RoomType> RoomTypeList { get; set; }
        public IEnumerable<Floor> FloorList { get; set; }
    }

    public class RoomValidate
    {
        private HmsEntities dbContext = new HmsEntities();
        public bool CheckDuplicate(RoomModel roomModel)
        {
            if (roomModel.Id > 0)
            {
                return dbContext.Rooms.Any(n => n.RoomNo.Equals(roomModel.RoomNo) && !n.Id.Equals(roomModel.Id));
            }
            else
            {
                return dbContext.Rooms.Any(n => n.RoomNo.Equals(roomModel.RoomNo));
            }
        }
    }
}
