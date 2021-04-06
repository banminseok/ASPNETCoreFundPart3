using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace IdeaApp.Models
{
    public class IdeaRepositoryEfCore : IIdeaRepository
    {

        public IdeaRepositoryEfCore()
        {

        }

        public List<Idea> GetAll()
        {
            using (var context = new IdeaAppDbContext())
            {
                return context.Ideas.OrderBy(i => i.Id).ToList();
            }
        }

        public Idea Add(Idea model)
        {
            using (var context = new IdeaAppDbContext())
            {
                context.Ideas.Add(model);
                context.SaveChanges();
                return model;
            }
        }
    }
}
