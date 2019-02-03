using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace BusinessLayer
{
    public class PlanBL
    {
        private HmsEntities dbContext = new HmsEntities();
        public List<Plan> ListPlan()
        {
            try
            {
                return dbContext.Plans.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
