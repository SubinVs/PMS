using PMS.Entity;
using PMS.ViewModel.HMS;
using System.Collections.Generic;

namespace PMS.Core.Interfaces.HMS
{
    public interface IRoomTypeManager
    {
        void Add(RoomTypeViewModel model);
        void Edit(RoomTypeViewModel model);
        void Delete(int id);
        List<HMS_RoomType> GetAll();
        RoomTypeViewModel Get(int id);
        int GetCount();
        bool CheckDuplicate(HMS_RoomType model);
    }
}
