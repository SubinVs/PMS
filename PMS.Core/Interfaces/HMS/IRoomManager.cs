using PMS.Entity;
using PMS.ViewModel.HMS;
using System.Collections.Generic;

namespace PMS.Core.Interfaces.HMS
{
    public interface IRoomManager
    {
        void Add(RoomViewModel model);
        void Edit(RoomViewModel model);
        void Delete(int id);
        List<HMS_Room> GetAll();
        RoomViewModel Get(int id);
        int GetCount();
        bool CheckDuplicate(HMS_Room model);
    }
}
