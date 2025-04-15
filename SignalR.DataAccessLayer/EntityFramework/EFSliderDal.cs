using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repostories;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EFSliderDal:GenericRepostory<Slider>,ISliderDal
    {
        public EFSliderDal(SignalRContext context):base(context)
        {
        }
    }
}
