using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetNote.Models
{
    /// <summary>
    /// MyNotification 모델 클래스: MyNotifications.sql 테이블과 일대일
    /// </summary>
    public class MyNotification
    {
        public int Id { get; set; }
        public DateTimeOffset Timestamp { get; set; } // Created, Modified, CreatedDate, DateCreated, ...
        public string Message { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }

        public int UserId { get; set; }
        public bool IsComplte { get; set; }
    }
}
