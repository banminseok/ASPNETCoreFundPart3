using Dapper;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DotNetNote.Models
{
    public class BuyerRepository : IBuyerRepository
    {
        private IDbConnection db;

        public BuyerRepository(string connectionString)
        {
            db = new SqlConnection(connectionString);
        }
        public Buyer GetBuyer(string buyerId)
        {
            string sql = "Select * From Buyers Where Id = @BuyerId";
            return db.Query<Buyer>(sql, new { BuyerId = buyerId }).SingleOrDefault();
        }

        public List<Buyer> GetBuyers()
        {
            string sql = "Select * From Buyers Order By Id Desc";
            return db.Query<Buyer>(sql).ToList();
        }
    }
}
