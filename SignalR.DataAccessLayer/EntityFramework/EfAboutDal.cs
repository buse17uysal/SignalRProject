using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repostories;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.EntitiyFramework
{
    public class EfAboutDal : GenericRepostory<About>, IAboutDal
    {
        public EfAboutDal(SignalRContext context) : base(context)
        {
        }
    }
}