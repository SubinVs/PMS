using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace BusinessLayer
{
    public class RateBL
    {
        private HmsEntities dbContext = new HmsEntities();
        public bool CheckExists()
        {
            return dbContext.Rates.Count() > 0 ? true : false;
        }

        public void InsertDefaults()
        {
            foreach(var a in dbContext.Agents)
            {
                foreach(var p in dbContext.Plans)
                {
                    foreach(var r in dbContext.RoomTypes)
                    {
                        for(int i = 1; i<= r.Occupancy; i++)
                        {
                            var model = new Rate
                            {
                                RoomTypeId = r.Id,
                                PlanId = p.Id,
                                AgentId = a.Id,
                                Occupancy = i,
                                Amount = 0,
                                ExtraPersonCharge = 0,
                                AgentName = a.AgentName,
                                PlanName = p.PlanType,
                                RoomType = r.RoomTypeName
                            };
                            dbContext.Rates.Add(model);
                            
                        }
                    }
                }
            }
            dbContext.SaveChanges();
        }

        public List<Rate> GetRateList()
        {
            return dbContext.Rates.ToList();
        }

        public void UpdateValue(int id,int amount, int expcharge)
        {
            Rate rate = dbContext.Rates.Find(id);
            rate.Amount = amount;
            rate.ExtraPersonCharge = expcharge;
            dbContext.Entry(rate).CurrentValues.SetValues(rate);
            dbContext.SaveChanges();
        }
    }
}
