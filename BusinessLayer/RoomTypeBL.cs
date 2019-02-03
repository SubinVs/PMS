using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace BusinessLayer
{
    public class RoomTypeBL
    {
        private HmsEntities dbContext = new HmsEntities();
        public List<RoomType> ListRoomType()
        {
            return dbContext.RoomTypes.OrderBy(n => n.RoomTypeName).ToList();
        }
    }
}
