using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetNote.Models
{
    public class UserRepositoryDapper : IUserRepository
    {
        private readonly IDbConnection _con;

        public UserRepositoryDapper(string connectionString)
        {
            _con = new SqlConnection(connectionString);
        }

        /// <summary>
        /// 회원가입
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="password"></param>
        public void AddUser(UserViewModel model)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 특정 회원 정보
        /// </summary>
        public UserViewModel GetUserByUserId(string userId)
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// 회원 정보 수정
        /// </summary>
        public void ModifyUser(int uid, string userId, string password)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 아이디와 암호가 동일한 사용자면 참(true) 그렇지 않으면 거짓
        /// </summary>

        public bool IsCorrectUser(string userId, string password)
        {
            throw new NotImplementedException();
        }

        public UserViewModel IsCorrectUserReturnModel(string userId, string password)
        {
            throw new NotImplementedException();
        }
    }
}
