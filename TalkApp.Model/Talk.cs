using System;
using System.Collections.Generic;

namespace TalkApp.Models
{
    public class Talk
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        //작성일자
        public DateTime? Created { get; set; }

        public List<TalkComment> TalkComments { get; set; } = new List<TalkComment>(); // 일대 다 관계 설정.
        public string? UserId { get; set; }
    }
}
