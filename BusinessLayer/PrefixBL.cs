using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace BusinessLayer
{
    public class PrefixBL
    {
        private HmsEntities dbContext = new HmsEntities();
        public List<Prefix> ListPrefix()
        {
            try
            {
                var query = dbContext.Prefixes.ToList();
                return query;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
