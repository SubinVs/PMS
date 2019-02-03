using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace BusinessLayer
{
    public class OutletBL
    {
        private HmsEntities dbContext = new HmsEntities();

        public List<Outlet> ListOutlet()
        {
            return dbContext.Outlets.ToList();
        }

        public int GetCount()
        {
            return dbContext.Outlets.Count();
        }

        public Outlet FindId(int id)
        {
            return dbContext.Outlets.Find(id);
        }

        public void InsertOutlet(Outlet outlet)
        {
            outlet.ControlId = dbContext.Controls.Select(n => n.Id).First();
            outlet.Active = true;
            dbContext.Outlets.Add(outlet);
            dbContext.SaveChanges();
        }

        public void UpdateOutlet(Outlet outlet)
        {
            outlet.ControlId = dbContext.Controls.Select(n => n.Id).First();
            dbContext.Entry(outlet).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void DeleteOutlet(int id)
        {
            Outlet outlet = dbContext.Outlets.Find(id);
            outlet.ControlId = dbContext.Controls.Select(n => n.Id).First();
            outlet.Active = false;
            dbContext.Entry(outlet).CurrentValues.SetValues(outlet);
            dbContext.SaveChanges();
        }

        public bool CheckDuplicate(Outlet outlet)
        {
            List<Outlet> checkUnique;
            if (outlet.Id > 0)
            {
                checkUnique = (from d in dbContext.Outlets where (d.OutletName == outlet.OutletName) && (d.Id != outlet.Id) select d).ToList();
            }
            else
            {
                checkUnique = (from d in dbContext.Outlets where d.OutletName == outlet.OutletName select d).ToList();
            }
            return checkUnique.Count > 0 ? true : false;
        }
    }
}
