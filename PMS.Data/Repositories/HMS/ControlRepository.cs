using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using PMS.Entity;

namespace BusinessLayer
{
    public class ControlRepository
    {
        private PMSEntities dbContext = new PMSEntities();
        //public bool CheckExists()
        //{
        //    return dbContext.HMS_Control.Count() > 0 ? true : false;
        //}

        public List<HMS_Control> GetAll()
        {
            return dbContext.HMS_Control.ToList();
        }

        public HMS_Control Get()
        {
            return dbContext.HMS_Control.First();
        }

        public void Add(HMS_Control control)
        {
            dbContext.HMS_Control.Add(control);
            dbContext.SaveChanges();
        }

        public void Edit(HMS_Control control)
        {
            dbContext.Entry(control).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
