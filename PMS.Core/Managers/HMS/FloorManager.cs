using PMS.Data.Interfaces.HMS;
using PMS.Core.Interfaces.HMS;
using PMS.Entity;
using PMS.ViewModel.HMS;
using System.Collections.Generic;
using System.Linq;

namespace PMS.Core.Managers.HMS
{
    public class FloorManager : IFloorManager
    {
        private IGenericRepository<HMS_Floor> _genericRepository = null;

        public FloorManager(IGenericRepository<HMS_Floor> genericRepository)
        {
            this._genericRepository = genericRepository;
        }

        public void Add(FloorViewModel model)
        {
            var entity = new HMS_Floor
            {
                FloorName = model.FloorName,
                Active = true
            };
            _genericRepository.Add(entity);
        }

        public void Delete(int id)
        {
            var model = _genericRepository.Get(id);
            model.Active = false;
            _genericRepository.Delete(model);
        }

        public void Edit(FloorViewModel model)
        {
            var entity = new HMS_Floor
            {
                FloorName = model.FloorName,
                Active = model.Active,
                Id = model.Id
            };
            _genericRepository.Edit(entity);
        }

        public FloorViewModel Get(int id)
        {
            var model = _genericRepository.Get(id);
            var viewModel = new FloorViewModel()
            {
                Id = model.Id,
                Active = model.Active,
                FloorName = model.FloorName
            };
            return viewModel;
        }

        public List<HMS_Floor> GetAll()
        {
            return _genericRepository.GetAll();
        }

        public int GetCount()
        {
            return _genericRepository.GetCount();
        }

        public bool CheckDuplicate(HMS_Floor floor)
        {
            PMSEntities dbContext = new PMSEntities();
            List<HMS_Floor> checkUnique;
            if (floor.Id > 0)
            {
                checkUnique = (from d in dbContext.HMS_Floor where (d.FloorName == floor.FloorName) && (d.Id != floor.Id) select d).ToList();
            }
            else
            {
                checkUnique = (from d in dbContext.HMS_Floor where d.FloorName == floor.FloorName select d).ToList();
            }
            return checkUnique.Count > 0 ? true : false;
        }
    }
}
