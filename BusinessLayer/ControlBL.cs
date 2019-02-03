using DataModel;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BusinessLayer
{
    public class ControlBL
    {
        private HmsEntities dbContext = new HmsEntities();
        public bool CheckExists()
        {
            return dbContext.Controls.Count() > 0 ? true : false;
        }

        public List<Control> ListControl()
        {
            return dbContext.Controls.ToList();
        }

        public Control GetControl()
        {
            return dbContext.Controls.First();
        }

        public void InsertControl(Control control)
        {
            dbContext.Controls.Add(control);
            dbContext.SaveChanges();
        }

        public void UpdateControl(Control control)
        {
            dbContext.Entry(control).State = EntityState.Modified;
            dbContext.SaveChanges();
        }
    }
}
