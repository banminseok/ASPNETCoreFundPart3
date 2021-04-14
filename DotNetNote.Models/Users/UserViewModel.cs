using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetNote.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="아이디를 입력하시오.")]
        [StringLength(25, MinimumLength =3 , ErrorMessage ="아이디는 3자이상 25자 이하로 입력하시오")]
        public string UserId { get; set; }

        [MaxLength( 25, ErrorMessage = "이름은 4자이상 25자 이하로 입력하시오")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "비밀번호를 입력하시오.")]
        [StringLength(25, MinimumLength = 4, ErrorMessage = "비밀번호는 4자이상 25자 이하로 입력하시오")]
        public string Password { get; set; }
    }
}
