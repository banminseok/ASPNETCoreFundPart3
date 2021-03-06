using Dul.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetNote.Models.Companies
{
    public class CompanyRepositoryAdo : ICompanyRepository
    {
        private string _connectionString;

        public CompanyRepositoryAdo(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// ADO 데이터 입력
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public CompanyModel Add(CompanyModel model)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = _connectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert Into Companies(Name) Values(@Name)";
            cmd.CommandType = CommandType.Text;

            SqlParameter companyName =
                new SqlParameter("@Name", SqlDbType.NVarChar, 50);
            companyName.Value = model.Name;
            cmd.Parameters.Add(companyName);
            cmd.ExecuteNonQuery();
            con.Close();

            return model;
        }

        public CompanyModel Browse(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(CompanyModel model)
        {
            throw new NotImplementedException();
        }

        public int Has()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CompanyModel> Ordering(OrderOption orderOption)
        {
            throw new NotImplementedException();
        }

        public List<CompanyModel> Paging(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 출력
        /// </summary>
        /// <returns></returns>
        public List<CompanyModel> Read()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = _connectionString;
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select Top 1000 Id, Name From Companies";
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "Companies");

            List<CompanyModel> companies = new List<CompanyModel>();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                var id = Convert.ToInt32(ds.Tables[0].Rows[i]["Id"].ToString());
                var name = ds.Tables[0].Rows[i]["Name"].ToString();

                companies.Add( new CompanyModel { 
                    Id      = id,
                    Name    = name
                });
            }
            con.Close();
            return companies;
        }

        public List<CompanyModel> Search(string query)
        {
            throw new NotImplementedException();
        }
    }
}
