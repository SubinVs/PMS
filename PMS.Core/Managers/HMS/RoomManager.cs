using System.Collections.Generic;
using PMS.Core.Interfaces.HMS;
using PMS.Data.Interfaces.HMS;
using PMS.Entity;
using PMS.ViewModel.HMS;
using System.Linq;

namespace PMS.Core.Managers.HMS
{
    public class RoomManager : IRoomManager
    {
        private IGenericRepository<HMS_Room> _genericRepository = null;

        public RoomManager(IGenericRepository<HMS_Room> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public void Add(RoomViewModel model)
        {
            var entity = new HMS_Room
            {
                RoomNo = model.RoomNo,
                FloorId = model.FloorId,
                Active = true,
                RoomTypeId = model.RoomTypeId,
                StatusId = 2
            };
            _genericRepository.Add(entity);
        }

        public bool CheckDuplicate(HMS_Room model)
        {
            PMSEntities dbContext = new PMSEntities();
            List<HMS_Room> checkUnique;
            if (model.Id > 0)
            {
                checkUnique = (from d in dbContext.HMS_Room where (d.RoomNo == model.RoomNo) && (d.Id != model.Id) select d).ToList();
            }
            else
            {
                checkUnique = (from d in dbContext.HMS_Room where d.RoomNo == model.RoomNo select d).ToList();
            }
            return checkUnique.Count > 0 ? true : false;
        }

        public void Delete(int id)
        {
            var model = _genericRepository.Get(id);
            model.Active = false;
            _genericRepository.Delete(model);
        }

        public void Edit(RoomViewModel model)
        {
            var entity = new HMS_Room
            {
                Id = model.Id,
                RoomNo = model.RoomNo,
                FloorId = model.FloorId,
                Active = model.Active,
                RoomTypeId = model.RoomTypeId,
                StatusId = 2
            };
            _genericRepository.Edit(entity);
        }

        public RoomViewModel Get(int id)
        {
            var model = _genericRepository.Get(id);
            var viewModel = new RoomViewModel()
            {
                RoomNo = model.RoomNo,
                FloorId = model.FloorId,
                Active = model.Active,
                RoomTypeId = model.RoomTypeId,
                StatusId = model.StatusId
            };
            return viewModel;
        }

        public List<HMS_Room> GetAll()
        {
            return _genericRepository.GetAll();
        }

        public int GetCount()
        {
            return _genericRepository.GetCount();
        }
    }
}
