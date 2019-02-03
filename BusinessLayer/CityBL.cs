using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace BusinessLayer
{
    public class CityBL
    {
        private HmsEntities dbContext = new HmsEntities();
        public List<City> ListCity()
        {
            try
            {
                return dbContext.Cities.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<City> GetCity(int? stateId)
        {
            try
            {
                return dbContext.Cities.Where(n => n.state_id == stateId).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
