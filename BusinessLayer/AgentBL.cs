using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace BusinessLayer
{
    public class AgentBL
    {
        private PMSEntities dbContext = new PMSEntities();
        public List<Agent> ListAgent()
        {
            try
            {
                return dbContext.Agents.Where(n => n.Active == true).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
