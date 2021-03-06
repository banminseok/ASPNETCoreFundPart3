using Dapper;
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
    public class CompanyRepositoryDapper : ICompanyRepository
    {
        private string _connetionString;
        private IDbConnection _db;

        public CompanyRepositoryDapper(string connetionString)
        {
            _connetionString = connetionString;
            _db = new SqlConnection(_connetionString);
        }
        public CompanyModel Add(CompanyModel model)
        {
            var sql = @"
                Insert Into Companies(Name) Values(@Name);
                Select Cast(SCOPE_IDENTITY() As Int)";
            var id = _db.Query<int>(sql, model).Single();
            model.Id = id;

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

        public List<CompanyModel> Read()
        {
            var sql = @"
                Select Top 1000 Id, Name From Companies;";
            List<CompanyModel> companies = _db.Query<CompanyModel>(sql).ToList();
            return companies;
        }

        public List<CompanyModel> Search(string query)
        {
            throw new NotImplementedException();
        }
    }
}
