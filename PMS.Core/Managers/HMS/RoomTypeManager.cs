using System.Collections.Generic;
using PMS.Core.Interfaces.HMS;
using PMS.Data.Interfaces.HMS;
using PMS.Entity;
using PMS.ViewModel.HMS;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Core.Managers.HMS
{
    public class RoomTypeManager : IRoomTypeManager
    {
        private IGenericRepository<HMS_RoomType> _genericRepository = null;

        public RoomTypeManager(IGenericRepository<HMS_RoomType> genericRepository)
        {
            this._genericRepository = genericRepository;
        }

        public void Add(RoomTypeViewModel model)
        {
            var entity = new HMS_RoomType
            {
                RoomTypeName = model.RoomTypeName,
                Occupancy = model.Occupancy,
                Active = true
            };
            _genericRepository.Add(entity);
        }

        public bool CheckDuplicate(HMS_RoomType model)
        {
            PMSEntities dbContext = new PMSEntities();
            List<HMS_RoomType> checkUnique;
            if (model.Id > 0)
            {
                checkUnique = (from d in dbContext.HMS_RoomType where (d.RoomTypeName == model.RoomTypeName) && (d.Id != model.Id) select d).ToList();
            }
            else
            {
                checkUnique = (from d in dbContext.HMS_RoomType where d.RoomTypeName == model.RoomTypeName select d).ToList();
            }
            return checkUnique.Count > 0 ? true : false;
        }

        public void Delete(int id)
        {
            var model = _genericRepository.Get(id);
            model.Active = false;
            _genericRepository.Delete(model);
        }

        public void Edit(RoomTypeViewModel model)
        {
            var entity = new HMS_RoomType
            {
                RoomTypeName = model.RoomTypeName,
                Occupancy = model.Occupancy,
                Active = model.Active,
                Id = model.Id
            };
            _genericRepository.Edit(entity);
        }

        public RoomTypeViewModel Get(int id)
        {
            var model = _genericRepository.Get(id);
            var viewModel = new RoomTypeViewModel()
            {
                RoomTypeName = model.RoomTypeName,
                Occupancy = model.Occupancy,
                Active = model.Active,
                Id = model.Id
            };
            return viewModel;
        }

        public List<HMS_RoomType> GetAll()
        {
            return _genericRepository.GetAll();
        }

        public int GetCount()
        {
            return _genericRepository.GetCount();
        }
    }
}
