using PMS.Entity;
using PMS.ViewModel.HMS;
using System.Collections.Generic;

namespace PMS.Core.Interfaces.HMS
{
    public interface IFloorManager
    {
        void Add(FloorViewModel model);
        void Edit(FloorViewModel model);
        void Delete(int id);
        List<HMS_Floor> GetAll();
        FloorViewModel Get(int id);
        int GetCount();
        bool CheckDuplicate(HMS_Floor model);
    }
}
