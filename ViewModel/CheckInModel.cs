using BusinessLayer;
using DataModel;
using System.Collections.Generic;
using System.Linq;

namespace ViewModel
{
    public class CheckInModel:CheckIn
    {
        public IEnumerable<Plan> PlanList { get; set; }
        public IEnumerable<Purpose> PurposeList { get; set; }
        public IEnumerable<Agent> AgentList { get; set; }
        public IEnumerable<Company> CompanyList { get; set; }
        public IEnumerable<Prefix> PrefixList { get; set; }
        public IEnumerable<Country> CountryList { get; set; }
        public IEnumerable<State> StateList { get; set; }
        public IEnumerable<City> CityList { get; set; }

        private HmsEntities dbContext = new HmsEntities();

        public int roomId { get; set; }
        public int grcNo { get; set; }

        public string GetRoomNo()
        {
            return dbContext.Rooms.Where(n => n.Id.Equals(roomId)).Select(n => n.RoomNo).First();
        }
        public int GetGrcNo()
        {
            return dbContext.Outlets.Select(n => n.GRCNo).First() + 1;
        }
    }
}
