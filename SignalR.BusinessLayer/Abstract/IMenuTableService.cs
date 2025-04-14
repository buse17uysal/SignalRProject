using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Abstract
{
    public interface IMenuTableService: IGenericService<MenuTable>
    {
        public int TMenuTableCount();
        public void TChangeMenuTableStatusToTrue(int id);
        public void TChangeMenuTableStatusToFalse(int id);
    }
}
