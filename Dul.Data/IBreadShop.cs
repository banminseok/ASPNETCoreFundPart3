using System;
using System.Collections.Generic;
using System.Text;

namespace Dul.Data
{
    public interface IBreadShop<T> where T:class
    {
        T Browse(int id);
        List<T> Read();
        bool Edit(T model);

        T Add(T model);

        bool Delete(int id);

        List<T> Search(string query);

        int Has();

        IEnumerable<T> Ordering(OrderOption orderOption);

        List<T> Paging(int pageNumber, int pageSize);

    }
}
