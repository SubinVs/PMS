using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace BusinessLayer
{
    public class PurposeBL
    {
        private HmsEntities dbContext = new HmsEntities();
        public List<Purpose> ListPurpose()
        {
            try
            {
                var query = dbContext.Purposes.ToList();
                return query;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
