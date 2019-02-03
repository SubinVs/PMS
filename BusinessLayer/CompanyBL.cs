using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace BusinessLayer
{
    public class CompanyBL
    {
        private HmsEntities dbContext = new HmsEntities();
        public List<Company> ListCompany()
        {
            try
            {
                return dbContext.Companies.Where(n => n.Active == true).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
