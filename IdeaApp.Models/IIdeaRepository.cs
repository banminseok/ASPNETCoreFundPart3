using System.Collections.Generic;

namespace IdeaApp.Models
{
    public interface IIdeaRepository
    {
        Idea Add(Idea model);
        List<Idea> GetAll();
    }
}