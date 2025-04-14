using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface IMenuTableDal : IGenericDal<MenuTable>
    {
        public int MenuTableCount();
        public void ChangeMenuTableStatusToTrue(int id);
        public void ChangeMenuTableStatusToFalse(int id);
    }
}
