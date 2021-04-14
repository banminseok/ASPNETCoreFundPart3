using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetNote.Models
{
    public class UserRepository : IUserRepository
    {
        private readonly SqlConnection _con;

        public UserRepository(string connectionString)
        {
            _con = new SqlConnection(connectionString);
        }
        /// <summary>
        /// 회원 가입
        /// </summary>
        public void AddUser(UserViewModel model)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _con;
            cmd.CommandText = "Insert Into Users (UserID, UserName, Password) Values(@UserID, @UserName, @Password)";
            //cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@UserID", model.UserId);
            cmd.Parameters.AddWithValue("@UserName", model.UserName);
            cmd.Parameters.AddWithValue("@Password", model.Password);

            _con.Open();
            cmd.ExecuteNonQuery();
            _con.Close();
        }

        /// <summary>
        /// 특정 회원 정보
        /// </summary>
        public UserViewModel GetUserByUserId(string userId)
        {
            UserViewModel r = new UserViewModel();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _con;
            cmd.CommandText = "Select Id, UserId, UserName,[Password] From Users Where UserID = @UserID";
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@UserID", userId);

            _con.Open();
            IDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                r.Id = dr.GetInt32(0);
                r.UserId = dr.GetString(1);
                r.UserName = dr.GetString(2);
                r.Password = dr.GetString(3);
            }
            _con.Close();

            return r;
        }

        /// <summary>
        /// 회원 정보 수정
        /// </summary>
        public void ModifyUser(int uid, string userId, string password)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _con;
            cmd.CommandText = "ModifyUsers";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UserID", userId);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@UID", uid);

            _con.Open();
            cmd.ExecuteNonQuery();
            _con.Close();
        }

        /// <summary>
        /// 아이디와 암호가 동일한 사용자면 참(true) 그렇지 않으면 거짓
        /// </summary>
        public bool IsCorrectUser(string userId, string password)
        {
            bool result = false;

            _con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _con;
            cmd.CommandText = "Select * From Users "
                + " Where UserID = @UserID And Password = @Password";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@UserID", userId);
            cmd.Parameters.AddWithValue("@Password", password);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {               
                result = true; // 아이디와 암호가 맞는 데이터가 있구나...
            }
            _con.Close();
            return result;
        }

        public UserViewModel IsCorrectUserReturnModel(string userId, string password)
        {
            UserViewModel r = new UserViewModel();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _con;
            cmd.CommandText = "Select Id, UserId, UserName,[Password] From Users "
                + " Where UserID = @UserID And Password = @Password"; 
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@UserID", userId);
            cmd.Parameters.AddWithValue("@Password", password);

            _con.Open();
            IDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                r.Id = dr.GetInt32(0);
                r.UserId = dr.GetString(1);
                r.UserName = dr.GetString(2);
                r.Password = dr.GetString(3);
            }
            _con.Close();

            return r;
        }
    }
}
