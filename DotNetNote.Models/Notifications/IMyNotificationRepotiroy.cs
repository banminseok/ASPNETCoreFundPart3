using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetNote.Models
{
    public interface IMyNotificationRepository
    {
        void CompleteNotificationByUserid(int userId);
        void CompleteNotificationByUserid(int userId, int id);
        MyNotification GetNotificationByUserid(int userId);
        bool IsNotification(int userId);
    }
}
