using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace ViewModel
{
    public class RoomStatusModel:Room
    {
        public IEnumerable<Room> RoomList { get; set; }
        public IEnumerable<RoomType> RoomTypeList { get; set; }
        public IEnumerable<Floor> FloorList { get; set; }
    }
}
