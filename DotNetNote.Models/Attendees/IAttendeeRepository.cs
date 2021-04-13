using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetNote.Models
{
    public interface IAttendeeRepository
    {
        List<Attendee> GetAll();
        void Add(Attendee model);
        void Delete(Attendee model);
    }
}
