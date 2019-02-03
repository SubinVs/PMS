using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace BusinessLayer
{
    public class StateBL
    {
        private HmsEntities dbContext = new HmsEntities();
        public List<State> ListState()
        {
            try
            {
                return dbContext.States.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<State> GetState(int? countryId)
        {
            try
            {
                return dbContext.States.Where(n => n.country_id == countryId).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
