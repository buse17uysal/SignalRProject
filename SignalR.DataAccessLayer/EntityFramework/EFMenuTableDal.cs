using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repostories;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EFMenuTableDal : GenericRepostory<MenuTable>, IMenuTableDal
    {
        public EFMenuTableDal(SignalRContext context) : base(context)
        {
        }

        public void ChangeMenuTableStatusToFalse(int id)
        {
            using var context = new SignalRContext();
            var value=context.MenuTables.Where(x => x.MenuTableID == id).FirstOrDefault();
            value.Status = false;
            context.SaveChanges();
        }

        public void ChangeMenuTableStatusToTrue(int id)
        {
            using var context = new SignalRContext();
            var value = context.MenuTables.Where(x => x.MenuTableID == id).FirstOrDefault();
            value.Status = true;
            context.SaveChanges();
        }

        public int MenuTableCount()
        {
            using var context = new SignalRContext();
            return context.MenuTables.Count();
        }
    }
}
