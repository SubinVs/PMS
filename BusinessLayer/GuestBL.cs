using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace BusinessLayer
{
    public class GuestBL
    {
        private HmsEntities dbContext = new HmsEntities();
        public int InsertGuest(Guest guest)
        {
            try
            {
                dbContext.Guests.Add(guest);
                dbContext.SaveChanges();
                return guest.Id;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
