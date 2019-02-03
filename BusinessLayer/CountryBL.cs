using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace BusinessLayer
{
    public class CountryBL
    {
        private HmsEntities dbContext = new HmsEntities();
        public List<Country> ListCountry()
        {
            try
            {
                return dbContext.Countries.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
