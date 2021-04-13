using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetNote.Models
{
    public class Attendee
    {
        public int Id { get; set; }

        public int UID { get; set; }

        [Required(ErrorMessage="아이디를 입력하세요")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "이름을 입력하세요")]
        public string Name { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
