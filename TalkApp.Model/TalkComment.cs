using System;

namespace TalkApp.Models
{
    public class TalkComment
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        //작성일자
        public DateTime? Created { get; set; }

        public Talk Talk { get; set; } //--부모참조
        public long TalkId { get; set; } //-- 부모아이디

        public string? UserId { get; set; }
    }
}
