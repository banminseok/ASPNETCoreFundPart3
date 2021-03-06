using Dul.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetNote.Models.Companies
{
    public class CompanyRepositoryEntityFramework : ICompanyRepository
    {
        private IConfiguration _configuration;

        public CompanyRepositoryEntityFramework(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public CompanyModel Add(CompanyModel model)
        {
            using (var db = new CompanyContext(_configuration))
            {
                db.Companies.Add(model);
                db.SaveChanges();
            }

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
            var companies = new List<CompanyModel>();
            using (var db = new CompanyContext(_configuration))
            {
                companies = db.Companies.ToList();
            }                
            return companies;
        }

        public List<CompanyModel> Search(string query)
        {
            throw new NotImplementedException();
        }
    }
}
