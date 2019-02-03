using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace BusinessLayer
{
    public class RoomBL
    {
        private HmsEntities dbContext = new HmsEntities();
        public List<Room> ListRoom()
        {
            return dbContext.Rooms.OrderBy(n => n.RoomNo).ToList();
        }

        public int GetCount()
        {
            return dbContext.Rooms.Count();
        }

        public Room FindId(int id)
        {
            return dbContext.Rooms.Find(id);
        }

        public void InsertRoom(Room room)
        {

            room.StatusId = 1;
            room.Active = true;
            dbContext.Rooms.Add(room);
            dbContext.SaveChanges();
        }

        public void UpdateRoom(Room room)
        {
            room.StatusId = 1;
            room.Active = true;
            dbContext.Entry(room).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void DeleteRoom(int id)
        {
            Room room = FindId(id);
            room.StatusId = 1;
            room.Active = false;
            dbContext.Entry(room).CurrentValues.SetValues(room);
            dbContext.SaveChanges();
        }
    }
}
