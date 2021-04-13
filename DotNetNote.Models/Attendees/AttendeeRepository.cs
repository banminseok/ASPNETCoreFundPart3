using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DotNetNote.Models
{
    public class AttendeeRepository : IAttendeeRepository
    {
        private readonly IConfiguration _configuration;
        private readonly IDbConnection con;

        public AttendeeRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            con = new SqlConnection(configuration.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value);
        }
        public void Add(Attendee model)
        {
            var sql = @"Insert Into Attendees (UID, UserId, Name) 
                    Values (@UID, @UserId, @Name)";
            con.Execute(sql, model);
        }

        public void Delete(Attendee model)
        {
            var sql = "Delete Attendees Where Id = @Id";
            con.Execute(sql, new { Id=model.Id});
        }

        public List<Attendee> GetAll()
        {
            var sql = "Select * From Attendees Order by Id Asc";
            return con.Query<Attendee>(sql).ToList();
        }
    }
}
