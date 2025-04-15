using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface INotificationDal:IGenericDal<Notification>
    {
        public int NotificationCountByStatusFalse();
        List<Notification> GetAllNotificationByFalse();
        void NotificationStatusChangeToTrue(int id);
        void NotificationStatusChangeToFalse(int id);
    }
}
