using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace BusinessLayer
{
    public class CheckInBL
    {
        public HmsEntities dbContext = new HmsEntities();
        public void CreateCheckIn(CheckIn checkIn)
        {
            dbContext.CheckIns.Add(checkIn);
            dbContext.SaveChanges();
        }
    }
}
