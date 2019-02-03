using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace BusinessLayer
{
    public class FloorBL
    {
        public HmsEntities dbContext = new HmsEntities();
        public List<Floor> ListFloor()
        {
            try
            {
                return dbContext.Floors.OrderBy(n => n.FloorName).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int GetCount()
        {
            return dbContext.Floors.Count();
        }

        public void InsertFloor(Floor floor)
        {
            floor.Active = true;
            dbContext.Floors.Add(floor);
            dbContext.SaveChanges();
        }

        public Floor FindId(int id)
        {
            return dbContext.Floors.Find(id);
        }

        public void UpdateFloor(Floor floor)
        {
            dbContext.Entry(floor).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void DeleteFloor(int id)
        {
            Floor floor = dbContext.Floors.Find(id);
            floor.Active = false;
            dbContext.Entry(floor).CurrentValues.SetValues(floor);
            dbContext.SaveChanges();
        }

        public bool CheckDuplicate(Floor floor)
        {
            List<Floor> checkUnique;
            if (floor.Id > 0)
            {
                checkUnique = (from d in dbContext.Floors where (d.FloorName == floor.FloorName) && (d.Id != floor.Id) select d).ToList();
            }
            else
            {
                checkUnique = (from d in dbContext.Floors where d.FloorName == floor.FloorName select d).ToList();
            }
            return checkUnique.Count > 0 ? true : false;
        }
    }
}
